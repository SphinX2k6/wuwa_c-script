using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200478E RID: 18318
	public enum TTrapDefenseConditionStep : byte
	{
		// Token: 0x0400CB0D RID: 51981
		NONE,
		// Token: 0x0400CB0E RID: 51982
		ITrapDefenseConditionStepLoadAndRestoreMap,
		// Token: 0x0400CB0F RID: 51983
		ITrapDefenseConditionStepMapChange,
		// Token: 0x0400CB10 RID: 51984
		ITrapDefenseConditionStepPreview,
		// Token: 0x0400CB11 RID: 51985
		ITrapDefenseConditionStepReward,
		// Token: 0x0400CB12 RID: 51986
		ITrapDefenseConditionStepSpawnMonster
	}
}
