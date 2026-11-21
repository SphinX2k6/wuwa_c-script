using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FC3 RID: 4035
	[EnumExtensions]
	public enum EUseSkillCheckType
	{
		// Token: 0x0400352F RID: 13615
		[EnumStringMember("CheckBySkillGenre")]
		CheckSkillGenre,
		// Token: 0x04003530 RID: 13616
		[EnumStringMember("CheckBySkillId")]
		CheckSkillId,
		// Token: 0x04003531 RID: 13617
		CheckVisionSummonId,
		// Token: 0x04003532 RID: 13618
		CheckVisionShowId,
		// Token: 0x04003533 RID: 13619
		CheckFollowShooterSkillId
	}
}
