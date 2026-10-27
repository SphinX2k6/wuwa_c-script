using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F70 RID: 20336
	[EnumExtensions]
	public enum EQuickHackSkillCondition
	{
		// Token: 0x0401BACA RID: 113354
		CheckTargetTypeMatch,
		// Token: 0x0401BACB RID: 113355
		CheckRamEnough,
		// Token: 0x0401BACC RID: 113356
		CheckUsageCountEnough,
		// Token: 0x0401BACD RID: 113357
		CheckAnyMonsterTypeMatch,
		// Token: 0x0401BACE RID: 113358
		CheckAnySceneItemCanHack,
		// Token: 0x0401BACF RID: 113359
		CheckAnyTargetNotBeenUsedSkill
	}
}
