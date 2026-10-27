using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066FF RID: 26367
	public enum IExecBattleActionType_Union : byte
	{
		// Token: 0x04010DD5 RID: 69077
		NONE,
		// Token: 0x04010DD6 RID: 69078
		IExecBattleActionType,
		// Token: 0x04010DD7 RID: 69079
		ISetBattleTags,
		// Token: 0x04010DD8 RID: 69080
		ISendBattleEvents,
		// Token: 0x04010DD9 RID: 69081
		ISendBattleEventsForMonsterSummon,
		// Token: 0x04010DDA RID: 69082
		ISetMonsterMoveTarget,
		// Token: 0x04010DDB RID: 69083
		IExitMonsterMoveTarget,
		// Token: 0x04010DDC RID: 69084
		ISetMonsterMoveWithSpline,
		// Token: 0x04010DDD RID: 69085
		IExitMonsterMoveWithSpline
	}
}
