using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02005F2B RID: 24363
	public enum EBvbPlayerOperationType : byte
	{
		// Token: 0x0400FC57 RID: 64599
		BvbDeploy,
		// Token: 0x0400FC58 RID: 64600
		BvbEvolution,
		// Token: 0x0400FC59 RID: 64601
		BvbChangeHandCard,
		// Token: 0x0400FC5A RID: 64602
		BvbChangeBoardCard,
		// Token: 0x0400FC5B RID: 64603
		BvbRecycleHandCard,
		// Token: 0x0400FC5C RID: 64604
		BvbRecycleBoardCard,
		// Token: 0x0400FC5D RID: 64605
		BvbEndTurn,
		// Token: 0x0400FC5E RID: 64606
		BvbUseItemCardSkill,
		// Token: 0x0400FC5F RID: 64607
		BvbUseFieldCardSkill,
		// Token: 0x0400FC60 RID: 64608
		BvbSelectCard
	}
}
