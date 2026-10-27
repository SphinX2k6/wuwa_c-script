using System;
using System.Runtime.CompilerServices;

// Token: 0x02002095 RID: 8341
[NullableContext(1)]
[Nullable(0)]
public class ReconnectInfo
{
	// Token: 0x060106F7 RID: 67319 RVA: 0x00403DF6 File Offset: 0x00401FF6
	public ReconnectInfo(string token, string host, int port)
	{
		this.Token = token;
		this.Host = host;
		this.Port = port;
	}

	// Token: 0x04007969 RID: 31081
	public string Token = string.Empty;

	// Token: 0x0400796A RID: 31082
	public string Host = string.Empty;

	// Token: 0x0400796B RID: 31083
	public int Port;
}
