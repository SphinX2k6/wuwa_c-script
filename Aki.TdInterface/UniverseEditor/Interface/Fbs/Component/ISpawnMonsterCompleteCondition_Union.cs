using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F57 RID: 24407
	public enum ISpawnMonsterCompleteCondition_Union : byte
	{
		// Token: 0x0400FC13 RID: 64531
		NONE,
		// Token: 0x0400FC14 RID: 64532
		ISpawnMonsterCompleteCondition,
		// Token: 0x0400FC15 RID: 64533
		IAllKillCondition,
		// Token: 0x0400FC16 RID: 64534
		IDurationCondition,
		// Token: 0x0400FC17 RID: 64535
		IQuantityRefillCondition
	}
}
