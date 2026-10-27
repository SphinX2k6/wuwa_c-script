using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004226 RID: 16934
	public enum ITrapDefenseConditionStepBase_Union : byte
	{
		// Token: 0x0400BEA7 RID: 48807
		NONE,
		// Token: 0x0400BEA8 RID: 48808
		ITrapDefenseConditionStepBase,
		// Token: 0x0400BEA9 RID: 48809
		ITrapDefenseConditionStepReward,
		// Token: 0x0400BEAA RID: 48810
		ITrapDefenseConditionStepMapChange,
		// Token: 0x0400BEAB RID: 48811
		ITrapDefenseConditionStepPreview,
		// Token: 0x0400BEAC RID: 48812
		ITrapDefenseConditionStepSpawnMonster,
		// Token: 0x0400BEAD RID: 48813
		ITrapDefenseConditionStepLoadAndRestoreMap
	}
}
