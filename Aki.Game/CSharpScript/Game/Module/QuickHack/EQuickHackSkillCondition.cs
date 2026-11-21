using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F39 RID: 16185
	[EnumExtensions]
	public enum EQuickHackSkillCondition
	{
		// Token: 0x0401649F RID: 91295
		CheckTargetTypeMatch,
		// Token: 0x040164A0 RID: 91296
		CheckRamEnough,
		// Token: 0x040164A1 RID: 91297
		CheckUsageCountEnough,
		// Token: 0x040164A2 RID: 91298
		CheckAnyMonsterTypeMatch,
		// Token: 0x040164A3 RID: 91299
		CheckAnySceneItemCanHack,
		// Token: 0x040164A4 RID: 91300
		CheckAnyTargetNotBeenUsedSkill
	}
}
