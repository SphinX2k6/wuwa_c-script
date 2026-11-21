using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200164B RID: 5707
	public enum GatherTaskState
	{
		// Token: 0x0400C28A RID: 49802
		[OriginalName("Lock")]
		Lock,
		// Token: 0x0400C28B RID: 49803
		[OriginalName("Running")]
		Running,
		// Token: 0x0400C28C RID: 49804
		[OriginalName("InComplete")]
		InComplete,
		// Token: 0x0400C28D RID: 49805
		[OriginalName("Done")]
		Done,
		// Token: 0x0400C28E RID: 49806
		[OriginalName("TakeReward")]
		TakeReward
	}
}
