using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02005F66 RID: 24422
	public enum EExecBattleActionType : byte
	{
		// Token: 0x0400FD36 RID: 64822
		SetBattleTags,
		// Token: 0x0400FD37 RID: 64823
		SendBattleEvents,
		// Token: 0x0400FD38 RID: 64824
		SendBattleEventsForMonsterSummon,
		// Token: 0x0400FD39 RID: 64825
		SetMonsterMoveTarget,
		// Token: 0x0400FD3A RID: 64826
		ExitMonsterMoveTarget,
		// Token: 0x0400FD3B RID: 64827
		SetMonsterMoveWithSpline,
		// Token: 0x0400FD3C RID: 64828
		ExitMonsterMoveWithSpline
	}
}
