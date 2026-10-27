using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200153F RID: 5439
	public enum GatherActivityTaskState
	{
		// Token: 0x0400A54A RID: 42314
		[OriginalName("GatherLock")]
		GatherLock,
		// Token: 0x0400A54B RID: 42315
		[OriginalName("GatherRunning")]
		GatherRunning,
		// Token: 0x0400A54C RID: 42316
		[OriginalName("GatherInComplete")]
		GatherInComplete,
		// Token: 0x0400A54D RID: 42317
		[OriginalName("GatherDone")]
		GatherDone,
		// Token: 0x0400A54E RID: 42318
		[OriginalName("GatherTakeReward")]
		GatherTakeReward
	}
}
