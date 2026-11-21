using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ECA RID: 32458
	public enum TExecBattleOption : byte
	{
		// Token: 0x0401375B RID: 79707
		NONE,
		// Token: 0x0401375C RID: 79708
		IAiAssistCharacterMoveToPoint,
		// Token: 0x0401375D RID: 79709
		IAiAssistCharacterStopMoveToPoint,
		// Token: 0x0401375E RID: 79710
		IExitMonsterMoveTarget,
		// Token: 0x0401375F RID: 79711
		IExitMonsterMoveWithSpline,
		// Token: 0x04013760 RID: 79712
		ISendBattleEvents,
		// Token: 0x04013761 RID: 79713
		ISendBattleEventsForMonsterSummon,
		// Token: 0x04013762 RID: 79714
		ISetBattleTags,
		// Token: 0x04013763 RID: 79715
		ISetMonsterMoveTarget,
		// Token: 0x04013764 RID: 79716
		ISetMonsterMoveWithSpline
	}
}
