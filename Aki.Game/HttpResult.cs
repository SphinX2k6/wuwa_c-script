using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Net;

// Token: 0x02001564 RID: 5476
[NullableContext(1)]
[Nullable(0)]
public class HttpResult
{
	// Token: 0x04007A21 RID: 31265
	public int code;

	// Token: 0x04007A22 RID: 31266
	public string token = string.Empty;

	// Token: 0x04007A23 RID: 31267
	public List<NetHostInfo> udpHosts = new List<NetHostInfo>();

	// Token: 0x04007A24 RID: 31268
	public List<NetHostInfo> tcpHosts = new List<NetHostInfo>();

	// Token: 0x04007A25 RID: 31269
	public int tcpRatio;

	// Token: 0x04007A26 RID: 31270
	[Nullable(2)]
	public GatewayLatencyConfigVo gatewayLatencyConfig;

	// Token: 0x04007A27 RID: 31271
	public int userData;

	// Token: 0x04007A28 RID: 31272
	public string errMessage = string.Empty;

	// Token: 0x04007A29 RID: 31273
	public int? sex;

	// Token: 0x04007A2A RID: 31274
	public long banTimeStamp;

	// Token: 0x04007A2B RID: 31275
	public int banReason;

	// Token: 0x04007A2C RID: 31276
	public int clientWaitingMode;

	// Token: 0x04007A2D RID: 31277
	public int clientWaitingTime;

	// Token: 0x04007A2E RID: 31278
	public int clientAutoInInterval;
}
