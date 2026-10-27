using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200432F RID: 17199
	public enum TUseSkillCheck : byte
	{
		// Token: 0x0400C0F8 RID: 49400
		NONE,
		// Token: 0x0400C0F9 RID: 49401
		IUseSkillCheckByFollowShooterSkillId,
		// Token: 0x0400C0FA RID: 49402
		IUseSkillCheckBySkillGenre,
		// Token: 0x0400C0FB RID: 49403
		IUseSkillCheckBySkillId,
		// Token: 0x0400C0FC RID: 49404
		IUseSkillCheckByVisionShowId,
		// Token: 0x0400C0FD RID: 49405
		IUseSkillCheckByVisionSummonId
	}
}
