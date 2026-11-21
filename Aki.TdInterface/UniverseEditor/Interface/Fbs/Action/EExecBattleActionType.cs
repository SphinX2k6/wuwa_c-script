using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065AB RID: 26027
	public enum EExecBattleActionType : byte
	{
		// Token: 0x04010AB7 RID: 68279
		SetBattleTags,
		// Token: 0x04010AB8 RID: 68280
		SendBattleEvents,
		// Token: 0x04010AB9 RID: 68281
		SendBattleEventsForMonsterSummon,
		// Token: 0x04010ABA RID: 68282
		SetMonsterMoveTarget,
		// Token: 0x04010ABB RID: 68283
		ExitMonsterMoveTarget,
		// Token: 0x04010ABC RID: 68284
		SetMonsterMoveWithSpline,
		// Token: 0x04010ABD RID: 68285
		ExitMonsterMoveWithSpline,
		// Token: 0x04010ABE RID: 68286
		AssistCharacterMoveToPoint,
		// Token: 0x04010ABF RID: 68287
		AssistCharacterStopMoveToPoint
	}
}
