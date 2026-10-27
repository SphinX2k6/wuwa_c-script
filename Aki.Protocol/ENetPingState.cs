using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001673 RID: 5747
	public enum ENetPingState
	{
		// Token: 0x0400C1C2 RID: 49602
		[OriginalName("UNKNOWN")]
		Unknown,
		// Token: 0x0400C1C3 RID: 49603
		[OriginalName("GREAT")]
		Great,
		// Token: 0x0400C1C4 RID: 49604
		[OriginalName("GOOD")]
		Good,
		// Token: 0x0400C1C5 RID: 49605
		[OriginalName("POOR")]
		Poor,
		// Token: 0x0400C1C6 RID: 49606
		[OriginalName("MAX")]
		Max
	}
}
