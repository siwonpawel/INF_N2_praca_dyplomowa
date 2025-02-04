public UdpClient connectToSAPmcastGroup()
{
    UdpClient client = new UdpClient();
    IPEndPoint localEp = new IPEndPoint(IPAddress.Any, 9875);

    client.ExclusiveAddressUse = false;
    client.Client.SetSocketOption(
        SocketOptionLevel.Socket,
        SocketOptionName.ReuseAddress,
        true);
    client.Client.Bind(localEp);

    IPAddress multicastaddress = IPAddress.Parse("224.2.127.254");
    client.JoinMulticastGroup(multicastaddress);

    return client;
}