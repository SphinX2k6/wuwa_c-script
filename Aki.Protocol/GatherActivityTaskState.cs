using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015B5 RID: 5557
	public enum GatherActivityTaskState
	{
		// Token: 0x0400A9A8 RID: 43432
		[OriginalName("GatherLock")]
		GatherLock,
		// Token: 0x0400A9A9 RID: 43433
		[OriginalName("GatherRunning")]
		GatherRunning,
		// Token: 0x0400A9AA RID: 43434
		[OriginalName("GatherInComplete")]
		GatherInComplete,
		// Token: 0x0400A9AB RID: 43435
		[OriginalName("GatherDone")]
		GatherDone,
		// Token: 0x0400A9AC RID: 43436
		[OriginalName("GatherTakeReward")]
		GatherTakeReward
	}
}
