using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D7F RID: 28031
	public enum IExecBattleActionType_Union : byte
	{
		// Token: 0x04011C04 RID: 72708
		NONE,
		// Token: 0x04011C05 RID: 72709
		IExecBattleActionType,
		// Token: 0x04011C06 RID: 72710
		ISetBattleTags,
		// Token: 0x04011C07 RID: 72711
		ISendBattleEvents,
		// Token: 0x04011C08 RID: 72712
		ISendBattleEventsForMonsterSummon,
		// Token: 0x04011C09 RID: 72713
		ISetMonsterMoveTarget,
		// Token: 0x04011C0A RID: 72714
		IExitMonsterMoveTarget,
		// Token: 0x04011C0B RID: 72715
		ISetMonsterMoveWithSpline,
		// Token: 0x04011C0C RID: 72716
		IExitMonsterMoveWithSpline,
		// Token: 0x04011C0D RID: 72717
		IAiAssistCharacterMoveToPoint,
		// Token: 0x04011C0E RID: 72718
		IAiAssistCharacterStopMoveToPoint
	}
}
