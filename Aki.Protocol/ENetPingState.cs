using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016EF RID: 5871
	public enum ENetPingState
	{
		// Token: 0x0400C6EB RID: 50923
		[OriginalName("UNKNOWN")]
		Unknown,
		// Token: 0x0400C6EC RID: 50924
		[OriginalName("GREAT")]
		Great,
		// Token: 0x0400C6ED RID: 50925
		[OriginalName("GOOD")]
		Good,
		// Token: 0x0400C6EE RID: 50926
		[OriginalName("POOR")]
		Poor,
		// Token: 0x0400C6EF RID: 50927
		[OriginalName("MAX")]
		Max
	}
}
