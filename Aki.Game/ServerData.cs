using System;
using System.Runtime.CompilerServices;

// Token: 0x02002098 RID: 8344
[NullableContext(1)]
[Nullable(0)]
public class ServerData
{
	// Token: 0x060106FA RID: 67322 RVA: 0x00403E9D File Offset: 0x0040209D
	public ServerData(ServerConfig config = null)
	{
		if (config != null)
		{
			this.Config = config;
		}
	}

	// Token: 0x060106FB RID: 67323 RVA: 0x00403ECA File Offset: 0x004020CA
	public ServerData SetIp(string ip)
	{
		this.Config.Ip = ip;
		return this;
	}

	// Token: 0x04007972 RID: 31090
	public ServerConfig Config = new ServerConfig("", "", "", 0);
}
