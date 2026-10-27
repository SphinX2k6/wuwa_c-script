using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076BC RID: 30396
	public enum TExecBattleOption : byte
	{
		// Token: 0x0401270C RID: 75532
		NONE,
		// Token: 0x0401270D RID: 75533
		IExitMonsterMoveTarget,
		// Token: 0x0401270E RID: 75534
		IExitMonsterMoveWithSpline,
		// Token: 0x0401270F RID: 75535
		ISendBattleEvents,
		// Token: 0x04012710 RID: 75536
		ISendBattleEventsForMonsterSummon,
		// Token: 0x04012711 RID: 75537
		ISetBattleTags,
		// Token: 0x04012712 RID: 75538
		ISetMonsterMoveTarget,
		// Token: 0x04012713 RID: 75539
		ISetMonsterMoveWithSpline
	}
}
