using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200155D RID: 5469
	public enum FailReason
	{
		// Token: 0x0400A60A RID: 42506
		[OriginalName("DefaultFail")]
		DefaultFail,
		// Token: 0x0400A60B RID: 42507
		[OriginalName("AutoFail")]
		AutoFail,
		// Token: 0x0400A60C RID: 42508
		[OriginalName("EntityStateFail")]
		EntityStateFail,
		// Token: 0x0400A60D RID: 42509
		[OriginalName("TimeoutFail")]
		TimeoutFail,
		// Token: 0x0400A60E RID: 42510
		[OriginalName("LeaveInstFail")]
		LeaveInstFail,
		// Token: 0x0400A60F RID: 42511
		[OriginalName("InstFail")]
		InstFail,
		// Token: 0x0400A610 RID: 42512
		[OriginalName("CharacterDieFail")]
		CharacterDieFail,
		// Token: 0x0400A611 RID: 42513
		[OriginalName("EntityDieFail")]
		EntityDieFail,
		// Token: 0x0400A612 RID: 42514
		[OriginalName("OutRangeFail")]
		OutRangeFail,
		// Token: 0x0400A613 RID: 42515
		[OriginalName("GiveUpFail")]
		GiveUpFail,
		// Token: 0x0400A614 RID: 42516
		[OriginalName("SneakTimeoutFail")]
		SneakTimeoutFail,
		// Token: 0x0400A615 RID: 42517
		[OriginalName("TransferFail")]
		TransferFail,
		// Token: 0x0400A616 RID: 42518
		[OriginalName("PlayerMotionState")]
		PlayerMotionState,
		// Token: 0x0400A617 RID: 42519
		[OriginalName("NpcTraceOutRange")]
		NpcTraceOutRange,
		// Token: 0x0400A618 RID: 42520
		[OriginalName("NpcTraceAlertFull")]
		NpcTraceAlertFull,
		// Token: 0x0400A619 RID: 42521
		[OriginalName("DataLayerFail")]
		DataLayerFail,
		// Token: 0x0400A61A RID: 42522
		[OriginalName("PlayerLevelPlayMoveStateFail")]
		PlayerLevelPlayMoveStateFail,
		// Token: 0x0400A61B RID: 42523
		[OriginalName("CompareVarFail")]
		CompareVarFail,
		// Token: 0x0400A61C RID: 42524
		[OriginalName("TimeRange")]
		TimeRange,
		// Token: 0x0400A61D RID: 42525
		[OriginalName("ClearCabinFail")]
		ClearCabinFail,
		// Token: 0x0400A61E RID: 42526
		[OriginalName("YuXueModeChange")]
		YuXueModeChange
	}
}
