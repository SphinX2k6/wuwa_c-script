using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200432C RID: 17196
	public enum TTrapDefenseConditionStep : byte
	{
		// Token: 0x0400C0EF RID: 49391
		NONE,
		// Token: 0x0400C0F0 RID: 49392
		ITrapDefenseConditionStepLoadAndRestoreMap,
		// Token: 0x0400C0F1 RID: 49393
		ITrapDefenseConditionStepMapChange,
		// Token: 0x0400C0F2 RID: 49394
		ITrapDefenseConditionStepPreview,
		// Token: 0x0400C0F3 RID: 49395
		ITrapDefenseConditionStepReward,
		// Token: 0x0400C0F4 RID: 49396
		ITrapDefenseConditionStepSpawnMonster
	}
}
