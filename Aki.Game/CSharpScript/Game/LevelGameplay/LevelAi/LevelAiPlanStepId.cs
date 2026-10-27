using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DAD RID: 28077
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiPlanStepId
	{
		// Token: 0x06044825 RID: 280613 RVA: 0x010E4E45 File Offset: 0x010E3045
		public LevelAiPlanStepId(int levelIndex = -1, int stepIndex = -1)
		{
			this.LevelIndex = levelIndex;
			this.StepIndex = stepIndex;
		}

		// Token: 0x06044826 RID: 280614 RVA: 0x010E4E5B File Offset: 0x010E305B
		public void Reset()
		{
			this.LevelIndex = -1;
			this.StepIndex = -1;
		}

		// Token: 0x06044827 RID: 280615 RVA: 0x010E4E6B File Offset: 0x010E306B
		public void CopyFrom(LevelAiPlanStepId other)
		{
			this.LevelIndex = other.LevelIndex;
			this.StepIndex = other.StepIndex;
		}

		// Token: 0x06044828 RID: 280616 RVA: 0x010E4E85 File Offset: 0x010E3085
		public bool Equal(LevelAiPlanStepId other)
		{
			return this.LevelIndex == other.LevelIndex && this.StepIndex == other.StepIndex;
		}

		// Token: 0x06044829 RID: 280617 RVA: 0x010E4EA5 File Offset: 0x010E30A5
		public static bool Equal(LevelAiPlanStepId l, LevelAiPlanStepId r)
		{
			return l.LevelIndex == r.LevelIndex && l.StepIndex == r.StepIndex;
		}

		// Token: 0x04023A0D RID: 145933
		[StaticVariableRuleIgnore]
		public static readonly LevelAiPlanStepId None = new LevelAiPlanStepId(-1, -1);

		// Token: 0x04023A0E RID: 145934
		public int LevelIndex;

		// Token: 0x04023A0F RID: 145935
		public int StepIndex;
	}
}
