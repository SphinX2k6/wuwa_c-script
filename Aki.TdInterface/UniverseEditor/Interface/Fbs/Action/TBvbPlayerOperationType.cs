using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E5E RID: 32350
	public enum TBvbPlayerOperationType : byte
	{
		// Token: 0x0401364D RID: 79437
		NONE,
		// Token: 0x0401364E RID: 79438
		IBvbChangeBoardCard,
		// Token: 0x0401364F RID: 79439
		IBvbChangeHandCard,
		// Token: 0x04013650 RID: 79440
		IBvbDeploy,
		// Token: 0x04013651 RID: 79441
		IBvbEndTurn,
		// Token: 0x04013652 RID: 79442
		IBvbEvolution,
		// Token: 0x04013653 RID: 79443
		IBvbRecycleBoardCard,
		// Token: 0x04013654 RID: 79444
		IBvbRecycleHandCard,
		// Token: 0x04013655 RID: 79445
		IBvbSelectCard,
		// Token: 0x04013656 RID: 79446
		IBvbUseFieldCardSkill,
		// Token: 0x04013657 RID: 79447
		IBvbUseItemCardSkill
	}
}
