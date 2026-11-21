using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F2C RID: 24364
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiPlanStepId
	{
		// Token: 0x0603A989 RID: 240009 RVA: 0x0108F06D File Offset: 0x0108D26D
		public LevelAiPlanStepId(int levelIndex = -1, int stepIndex = -1)
		{
			this.LevelIndex = levelIndex;
			this.StepIndex = stepIndex;
		}

		// Token: 0x0603A98A RID: 240010 RVA: 0x0108F083 File Offset: 0x0108D283
		public void Reset()
		{
			this.LevelIndex = -1;
			this.StepIndex = -1;
		}

		// Token: 0x0603A98B RID: 240011 RVA: 0x0108F093 File Offset: 0x0108D293
		public void CopyFrom(LevelAiPlanStepId other)
		{
			this.LevelIndex = other.LevelIndex;
			this.StepIndex = other.StepIndex;
		}

		// Token: 0x0603A98C RID: 240012 RVA: 0x0108F0AD File Offset: 0x0108D2AD
		public bool Equal(LevelAiPlanStepId other)
		{
			return this.LevelIndex == other.LevelIndex && this.StepIndex == other.StepIndex;
		}

		// Token: 0x0603A98D RID: 240013 RVA: 0x0108F0CD File Offset: 0x0108D2CD
		public static bool Equal(LevelAiPlanStepId l, LevelAiPlanStepId r)
		{
			return l.LevelIndex == r.LevelIndex && l.StepIndex == r.StepIndex;
		}

		// Token: 0x0401ECAF RID: 126127
		[StaticVariableRuleIgnore]
		public static readonly LevelAiPlanStepId None = new LevelAiPlanStepId(-1, -1);

		// Token: 0x0401ECB0 RID: 126128
		public int LevelIndex;

		// Token: 0x0401ECB1 RID: 126129
		public int StepIndex;
	}
}
