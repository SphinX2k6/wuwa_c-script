using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015D3 RID: 5587
	public enum FailReason
	{
		// Token: 0x0400AA97 RID: 43671
		[OriginalName("DefaultFail")]
		DefaultFail,
		// Token: 0x0400AA98 RID: 43672
		[OriginalName("AutoFail")]
		AutoFail,
		// Token: 0x0400AA99 RID: 43673
		[OriginalName("EntityStateFail")]
		EntityStateFail,
		// Token: 0x0400AA9A RID: 43674
		[OriginalName("TimeoutFail")]
		TimeoutFail,
		// Token: 0x0400AA9B RID: 43675
		[OriginalName("LeaveInstFail")]
		LeaveInstFail,
		// Token: 0x0400AA9C RID: 43676
		[OriginalName("InstFail")]
		InstFail,
		// Token: 0x0400AA9D RID: 43677
		[OriginalName("CharacterDieFail")]
		CharacterDieFail,
		// Token: 0x0400AA9E RID: 43678
		[OriginalName("EntityDieFail")]
		EntityDieFail,
		// Token: 0x0400AA9F RID: 43679
		[OriginalName("OutRangeFail")]
		OutRangeFail,
		// Token: 0x0400AAA0 RID: 43680
		[OriginalName("GiveUpFail")]
		GiveUpFail,
		// Token: 0x0400AAA1 RID: 43681
		[OriginalName("SneakTimeoutFail")]
		SneakTimeoutFail,
		// Token: 0x0400AAA2 RID: 43682
		[OriginalName("TransferFail")]
		TransferFail,
		// Token: 0x0400AAA3 RID: 43683
		[OriginalName("PlayerMotionState")]
		PlayerMotionState,
		// Token: 0x0400AAA4 RID: 43684
		[OriginalName("NpcTraceOutRange")]
		NpcTraceOutRange,
		// Token: 0x0400AAA5 RID: 43685
		[OriginalName("NpcTraceAlertFull")]
		NpcTraceAlertFull,
		// Token: 0x0400AAA6 RID: 43686
		[OriginalName("DataLayerFail")]
		DataLayerFail,
		// Token: 0x0400AAA7 RID: 43687
		[OriginalName("PlayerLevelPlayMoveStateFail")]
		PlayerLevelPlayMoveStateFail,
		// Token: 0x0400AAA8 RID: 43688
		[OriginalName("CompareVarFail")]
		CompareVarFail,
		// Token: 0x0400AAA9 RID: 43689
		[OriginalName("TimeRange")]
		TimeRange,
		// Token: 0x0400AAAA RID: 43690
		[OriginalName("ClearCabinFail")]
		ClearCabinFail,
		// Token: 0x0400AAAB RID: 43691
		[OriginalName("YuXueModeChange")]
		YuXueModeChange
	}
}
