using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001627 RID: 5671
	public enum ENewLinkStage
	{
		// Token: 0x0400C16C RID: 49516
		[OriginalName("NewLinkStageNone")]
		NewLinkStageNone,
		// Token: 0x0400C16D RID: 49517
		[OriginalName("NewLinkStageLock")]
		NewLinkStageLock,
		// Token: 0x0400C16E RID: 49518
		[OriginalName("Accumulate")]
		Accumulate,
		// Token: 0x0400C16F RID: 49519
		[OriginalName("Ready")]
		Ready,
		// Token: 0x0400C170 RID: 49520
		[OriginalName("Burst")]
		Burst
	}
}
