using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F72 RID: 24434
	public enum ISpawnMonsterStartCondition_Union : byte
	{
		// Token: 0x0400FC3E RID: 64574
		NONE,
		// Token: 0x0400FC3F RID: 64575
		ISpawnMonsterStartCondition,
		// Token: 0x0400FC40 RID: 64576
		IImmediateStartCondition,
		// Token: 0x0400FC41 RID: 64577
		ITriggerRangeStartCondition
	}
}
