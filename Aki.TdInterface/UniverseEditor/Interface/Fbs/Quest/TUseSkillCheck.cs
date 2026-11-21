using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004791 RID: 18321
	public enum TUseSkillCheck : byte
	{
		// Token: 0x0400CB16 RID: 51990
		NONE,
		// Token: 0x0400CB17 RID: 51991
		IUseSkillCheckByFollowShooterSkillId,
		// Token: 0x0400CB18 RID: 51992
		IUseSkillCheckBySkillGenre,
		// Token: 0x0400CB19 RID: 51993
		IUseSkillCheckBySkillId,
		// Token: 0x0400CB1A RID: 51994
		IUseSkillCheckByVisionShowId,
		// Token: 0x0400CB1B RID: 51995
		IUseSkillCheckByVisionSummonId
	}
}
