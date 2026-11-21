using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004980 RID: 18816
	public enum ILevelPlayReward_Union : byte
	{
		// Token: 0x0400CFBA RID: 53178
		NONE,
		// Token: 0x0400CFBB RID: 53179
		ILevelPlayReward,
		// Token: 0x0400CFBC RID: 53180
		INoneRewardParam,
		// Token: 0x0400CFBD RID: 53181
		IAutomaticRewardParam,
		// Token: 0x0400CFBE RID: 53182
		IVariableRewardParam,
		// Token: 0x0400CFBF RID: 53183
		IInteractRewardParam
	}
}
