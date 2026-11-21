using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FAE RID: 4014
	[EnumExtensions]
	public enum EStatisticsEventType
	{
		// Token: 0x040034AE RID: 13486
		Collect,
		// Token: 0x040034AF RID: 13487
		UseSkill,
		// Token: 0x040034B0 RID: 13488
		UseSkillNew,
		// Token: 0x040034B1 RID: 13489
		PlayerTriggerMotion,
		// Token: 0x040034B2 RID: 13490
		Timer,
		// Token: 0x040034B3 RID: 13491
		MonsterPoint,
		// Token: 0x040034B4 RID: 13492
		MonsterRemainingHealth,
		// Token: 0x040034B5 RID: 13493
		MonsterHealthScore,
		// Token: 0x040034B6 RID: 13494
		PlayerHit,
		// Token: 0x040034B7 RID: 13495
		MechaTrackScore
	}
}
