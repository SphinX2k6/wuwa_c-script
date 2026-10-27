using System;
using System.Runtime.CompilerServices;

// Token: 0x02002097 RID: 8343
[NullableContext(1)]
[Nullable(0)]
public class ServerConfig
{
	// Token: 0x060106F9 RID: 67321 RVA: 0x00403E4C File Offset: 0x0040204C
	public ServerConfig(string ip = "", string port = "", string name = "", int order = 0)
	{
		this.Ip = ip;
		this.Port = port;
		this.Name = name;
		this.Order = order;
	}

	// Token: 0x0400796E RID: 31086
	public string Ip = string.Empty;

	// Token: 0x0400796F RID: 31087
	public string Port = string.Empty;

	// Token: 0x04007970 RID: 31088
	public string Name = string.Empty;

	// Token: 0x04007971 RID: 31089
	public int Order;
}
