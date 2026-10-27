using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200594A RID: 22858
	public enum ISpawnMonsterCompleteCondition_Union : byte
	{
		// Token: 0x0400EF1E RID: 61214
		NONE,
		// Token: 0x0400EF1F RID: 61215
		ISpawnMonsterCompleteCondition,
		// Token: 0x0400EF20 RID: 61216
		IAllKillCondition,
		// Token: 0x0400EF21 RID: 61217
		IDurationCondition,
		// Token: 0x0400EF22 RID: 61218
		IQuantityRefillCondition
	}
}
