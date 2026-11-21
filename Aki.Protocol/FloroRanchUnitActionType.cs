using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001637 RID: 5687
	public enum FloroRanchUnitActionType
	{
		// Token: 0x0400C1BC RID: 49596
		[OriginalName("OpBuff")]
		OpBuff,
		// Token: 0x0400C1BD RID: 49597
		[OriginalName("OpUnit")]
		OpUnit,
		// Token: 0x0400C1BE RID: 49598
		[OriginalName("UnitSettle")]
		UnitSettle,
		// Token: 0x0400C1BF RID: 49599
		[OriginalName("UnitResourcesChange")]
		UnitResourcesChange,
		// Token: 0x0400C1C0 RID: 49600
		[OriginalName("Eating")]
		Eating,
		// Token: 0x0400C1C1 RID: 49601
		[OriginalName("EvolveUpdate")]
		EvolveUpdate,
		// Token: 0x0400C1C2 RID: 49602
		[OriginalName("Mix")]
		Mix,
		// Token: 0x0400C1C3 RID: 49603
		[OriginalName("Sacrifice")]
		Sacrifice,
		// Token: 0x0400C1C4 RID: 49604
		[OriginalName("DebugActionInfo")]
		DebugActionInfo,
		// Token: 0x0400C1C5 RID: 49605
		[OriginalName("BeEat")]
		BeEat,
		// Token: 0x0400C1C6 RID: 49606
		[OriginalName("ChangePoint")]
		ChangePoint,
		// Token: 0x0400C1C7 RID: 49607
		[OriginalName("ActionStop")]
		ActionStop,
		// Token: 0x0400C1C8 RID: 49608
		[OriginalName("ToyLvUp")]
		ToyLvUp,
		// Token: 0x0400C1C9 RID: 49609
		[OriginalName("ChangeTag")]
		ChangeTag,
		// Token: 0x0400C1CA RID: 49610
		[OriginalName("StageTributeChange")]
		StageTributeChange,
		// Token: 0x0400C1CB RID: 49611
		[OriginalName("SelfDefineValue")]
		SelfDefineValue
	}
}
