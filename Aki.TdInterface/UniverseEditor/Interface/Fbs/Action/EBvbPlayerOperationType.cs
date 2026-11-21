using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200656F RID: 25967
	public enum EBvbPlayerOperationType : byte
	{
		// Token: 0x040109CD RID: 68045
		BvbDeploy,
		// Token: 0x040109CE RID: 68046
		BvbEvolution,
		// Token: 0x040109CF RID: 68047
		BvbChangeHandCard,
		// Token: 0x040109D0 RID: 68048
		BvbChangeBoardCard,
		// Token: 0x040109D1 RID: 68049
		BvbRecycleHandCard,
		// Token: 0x040109D2 RID: 68050
		BvbRecycleBoardCard,
		// Token: 0x040109D3 RID: 68051
		BvbEndTurn,
		// Token: 0x040109D4 RID: 68052
		BvbUseItemCardSkill,
		// Token: 0x040109D5 RID: 68053
		BvbUseFieldCardSkill,
		// Token: 0x040109D6 RID: 68054
		BvbSelectCard
	}
}
