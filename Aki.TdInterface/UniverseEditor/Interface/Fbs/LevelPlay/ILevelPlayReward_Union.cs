using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004518 RID: 17688
	public enum ILevelPlayReward_Union : byte
	{
		// Token: 0x0400C58B RID: 50571
		NONE,
		// Token: 0x0400C58C RID: 50572
		ILevelPlayReward,
		// Token: 0x0400C58D RID: 50573
		INoneRewardParam,
		// Token: 0x0400C58E RID: 50574
		IAutomaticRewardParam,
		// Token: 0x0400C58F RID: 50575
		IVariableRewardParam,
		// Token: 0x0400C590 RID: 50576
		IInteractRewardParam
	}
}
