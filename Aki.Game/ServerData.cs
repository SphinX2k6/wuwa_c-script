using System;
using System.Runtime.CompilerServices;

// Token: 0x0200156E RID: 5486
[NullableContext(1)]
[Nullable(0)]
public class ServerData
{
	// Token: 0x0600DB67 RID: 56167 RVA: 0x00410451 File Offset: 0x0040E651
	public ServerData(ServerConfig config = null)
	{
		if (config != null)
		{
			this.Config = config;
		}
	}

	// Token: 0x0600DB68 RID: 56168 RVA: 0x0041047E File Offset: 0x0040E67E
	public ServerData SetIp(string ip)
	{
		this.Config.Ip = ip;
		return this;
	}

	// Token: 0x04007A6B RID: 31339
	public ServerConfig Config = new ServerConfig("", "", "", 0);
}
