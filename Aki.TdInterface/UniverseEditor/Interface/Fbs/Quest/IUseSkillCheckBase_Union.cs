using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004247 RID: 16967
	public enum IUseSkillCheckBase_Union : byte
	{
		// Token: 0x0400BECB RID: 48843
		NONE,
		// Token: 0x0400BECC RID: 48844
		IUseSkillCheckBase,
		// Token: 0x0400BECD RID: 48845
		IUseSkillCheckBySkillGenre,
		// Token: 0x0400BECE RID: 48846
		IUseSkillCheckBySkillId,
		// Token: 0x0400BECF RID: 48847
		IUseSkillCheckByVisionSummonId,
		// Token: 0x0400BED0 RID: 48848
		IUseSkillCheckByVisionShowId,
		// Token: 0x0400BED1 RID: 48849
		IUseSkillCheckByFollowShooterSkillId
	}
}
