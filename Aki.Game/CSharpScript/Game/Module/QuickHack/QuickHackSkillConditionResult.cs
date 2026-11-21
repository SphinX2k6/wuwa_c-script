using System;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F2B RID: 16171
	public class QuickHackSkillConditionResult
	{
		// Token: 0x06028F87 RID: 167815 RVA: 0x00B7FBF5 File Offset: 0x00B7DDF5
		public QuickHackSkillConditionResult(bool isSuccess, EQuickHackSkillCondition? failConditionType)
		{
		}

		// Token: 0x0401646F RID: 91247
		public readonly bool IsSuccess = isSuccess;

		// Token: 0x04016470 RID: 91248
		public readonly EQuickHackSkillCondition? FailConditionType = failConditionType;
	}
}
