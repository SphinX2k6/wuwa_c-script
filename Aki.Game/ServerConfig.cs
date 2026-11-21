using System;
using System.Runtime.CompilerServices;

// Token: 0x0200156D RID: 5485
[NullableContext(1)]
[Nullable(0)]
public class ServerConfig
{
	// Token: 0x0600DB66 RID: 56166 RVA: 0x00410400 File Offset: 0x0040E600
	public ServerConfig(string ip = "", string port = "", string name = "", int order = 0)
	{
		this.Ip = ip;
		this.Port = port;
		this.Name = name;
		this.Order = order;
	}

	// Token: 0x04007A67 RID: 31335
	public string Ip = string.Empty;

	// Token: 0x04007A68 RID: 31336
	public string Port = string.Empty;

	// Token: 0x04007A69 RID: 31337
	public string Name = string.Empty;

	// Token: 0x04007A6A RID: 31338
	public int Order;
}
