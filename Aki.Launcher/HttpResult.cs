using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Net;

// Token: 0x02000008 RID: 8
[NullableContext(1)]
[Nullable(0)]
public class HttpResult
{
	// Token: 0x0400002F RID: 47
	public int code;

	// Token: 0x04000030 RID: 48
	public string token = string.Empty;

	// Token: 0x04000031 RID: 49
	public List<NetHostInfo> udpHosts = new List<NetHostInfo>();

	// Token: 0x04000032 RID: 50
	public List<NetHostInfo> tcpHosts = new List<NetHostInfo>();

	// Token: 0x04000033 RID: 51
	public int tcpRatio;

	// Token: 0x04000034 RID: 52
	[Nullable(2)]
	public GatewayLatencyConfigVo gatewayLatencyConfig;

	// Token: 0x04000035 RID: 53
	public int userData;

	// Token: 0x04000036 RID: 54
	public string errMessage = string.Empty;

	// Token: 0x04000037 RID: 55
	public int? sex;

	// Token: 0x04000038 RID: 56
	public long banTimeStamp;

	// Token: 0x04000039 RID: 57
	public int banReason;

	// Token: 0x0400003A RID: 58
	public int clientWaitingMode;

	// Token: 0x0400003B RID: 59
	public int clientWaitingTime;

	// Token: 0x0400003C RID: 60
	public int clientAutoInInterval;
}
