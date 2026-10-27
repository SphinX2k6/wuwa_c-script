using System;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F62 RID: 20322
	public class QuickHackSkillConditionResult
	{
		// Token: 0x06034119 RID: 213273 RVA: 0x00C36455 File Offset: 0x00C34655
		public QuickHackSkillConditionResult(bool isSuccess, EQuickHackSkillCondition? failConditionType)
		{
		}

		// Token: 0x0401BA9A RID: 113306
		public readonly bool IsSuccess = isSuccess;

		// Token: 0x0401BA9B RID: 113307
		public readonly EQuickHackSkillCondition? FailConditionType = failConditionType;
	}
}
