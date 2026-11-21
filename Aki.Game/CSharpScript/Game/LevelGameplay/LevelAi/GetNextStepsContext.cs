using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F31 RID: 24369
	[NullableContext(1)]
	[Nullable(0)]
	public class GetNextStepsContext
	{
		// Token: 0x0603A99E RID: 240030 RVA: 0x0108F654 File Offset: 0x0108D854
		public GetNextStepsContext(LevelAiPlan plan, bool bIsExecutingPlan, List<LevelAiPlanStepId> outStepIds)
		{
			this.Plan = plan;
			this.IsExecutingPlan = bIsExecutingPlan;
			this.OutStepIds = outStepIds;
			this.NumSubmittedSteps = 0;
		}

		// Token: 0x0603A99F RID: 240031 RVA: 0x0108F678 File Offset: 0x0108D878
		public void SubmitPlanStep(LevelAiPlanStepId planStepId)
		{
			this.OutStepIds.Add(planStepId);
			this.NumSubmittedSteps++;
		}

		// Token: 0x0603A9A0 RID: 240032 RVA: 0x0108F694 File Offset: 0x0108D894
		public int AddNextStepsAfter(LevelAiPlanStepId inStepId)
		{
			if (!this.Plan.HasLevel(inStepId.LevelIndex))
			{
				return 0;
			}
			int numSubmittedSteps = this.NumSubmittedSteps;
			LevelAiPlanLevel levelAiPlanLevel = this.Plan.Levels[inStepId.LevelIndex];
			for (int i = inStepId.StepIndex + 1; i < levelAiPlanLevel.Steps.Count; i++)
			{
				LevelAiPlanStep levelAiPlanStep = levelAiPlanLevel.Steps[i];
				LevelAiPlanStepId thisStepId = new LevelAiPlanStepId(inStepId.LevelIndex, i);
				levelAiPlanStep.Node.GetNextSteps(this, thisStepId);
				if (this.NumSubmittedSteps - numSubmittedSteps > 0)
				{
					return this.NumSubmittedSteps - numSubmittedSteps;
				}
			}
			if (!levelAiPlanLevel.ParentStepId.Equal(LevelAiPlanStepId.None))
			{
				return this.AddNextStepsAfter(levelAiPlanLevel.ParentStepId);
			}
			return this.NumSubmittedSteps - numSubmittedSteps;
		}

		// Token: 0x0603A9A1 RID: 240033 RVA: 0x0108F751 File Offset: 0x0108D951
		public int GetNumSubmittedSteps()
		{
			return this.NumSubmittedSteps;
		}

		// Token: 0x0603A9A2 RID: 240034 RVA: 0x0108F759 File Offset: 0x0108D959
		[return: Nullable(2)]
		public LevelAiPlanStep GetStep(LevelAiPlanStepId inStepId)
		{
			return this.Plan.GetStep(inStepId);
		}

		// Token: 0x0401ECC2 RID: 126146
		private readonly LevelAiPlan Plan;

		// Token: 0x0401ECC3 RID: 126147
		private readonly List<LevelAiPlanStepId> OutStepIds;

		// Token: 0x0401ECC4 RID: 126148
		private int NumSubmittedSteps;

		// Token: 0x0401ECC5 RID: 126149
		public bool IsExecutingPlan;
	}
}
