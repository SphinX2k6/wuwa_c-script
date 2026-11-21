using System;
using System.Runtime.CompilerServices;

// Token: 0x0200156B RID: 5483
[NullableContext(1)]
[Nullable(0)]
public class ReconnectInfo
{
	// Token: 0x0600DB64 RID: 56164 RVA: 0x004103AA File Offset: 0x0040E5AA
	public ReconnectInfo(string token, string host, int port)
	{
		this.Token = token;
		this.Host = host;
		this.Port = port;
	}

	// Token: 0x04007A62 RID: 31330
	public string Token = string.Empty;

	// Token: 0x04007A63 RID: 31331
	public string Host = string.Empty;

	// Token: 0x04007A64 RID: 31332
	public int Port;
}
