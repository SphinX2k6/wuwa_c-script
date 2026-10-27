using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015D9 RID: 5593
	public enum GatherTaskState
	{
		// Token: 0x0400BD96 RID: 48534
		[OriginalName("Lock")]
		Lock,
		// Token: 0x0400BD97 RID: 48535
		[OriginalName("Running")]
		Running,
		// Token: 0x0400BD98 RID: 48536
		[OriginalName("InComplete")]
		InComplete,
		// Token: 0x0400BD99 RID: 48537
		[OriginalName("Done")]
		Done,
		// Token: 0x0400BD9A RID: 48538
		[OriginalName("TakeReward")]
		TakeReward
	}
}
