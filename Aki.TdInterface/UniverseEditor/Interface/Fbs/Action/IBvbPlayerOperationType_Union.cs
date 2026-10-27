using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006251 RID: 25169
	public enum IBvbPlayerOperationType_Union : byte
	{
		// Token: 0x0401079F RID: 67487
		NONE,
		// Token: 0x040107A0 RID: 67488
		IBvbPlayerOperationType,
		// Token: 0x040107A1 RID: 67489
		IBvbDeploy,
		// Token: 0x040107A2 RID: 67490
		IBvbEvolution,
		// Token: 0x040107A3 RID: 67491
		IBvbChangeHandCard,
		// Token: 0x040107A4 RID: 67492
		IBvbChangeBoardCard,
		// Token: 0x040107A5 RID: 67493
		IBvbRecycleHandCard,
		// Token: 0x040107A6 RID: 67494
		IBvbRecycleBoardCard,
		// Token: 0x040107A7 RID: 67495
		IBvbUseItemCardSkill,
		// Token: 0x040107A8 RID: 67496
		IBvbSelectCard,
		// Token: 0x040107A9 RID: 67497
		IBvbUseFieldCardSkill,
		// Token: 0x040107AA RID: 67498
		IBvbEndTurn
	}
}
