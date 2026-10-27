using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EAD RID: 3757
	[EnumExtensions]
	public enum EUseSkillCheckType
	{
		// Token: 0x04003222 RID: 12834
		[EnumStringMember("CheckBySkillGenre")]
		CheckSkillGenre,
		// Token: 0x04003223 RID: 12835
		[EnumStringMember("CheckBySkillId")]
		CheckSkillId,
		// Token: 0x04003224 RID: 12836
		CheckVisionSummonId,
		// Token: 0x04003225 RID: 12837
		CheckVisionShowId,
		// Token: 0x04003226 RID: 12838
		CheckFollowShooterSkillId
	}
}
