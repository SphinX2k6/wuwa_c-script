using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DB2 RID: 28082
	[NullableContext(1)]
	[Nullable(0)]
	public class GetNextStepsContext
	{
		// Token: 0x0604483A RID: 280634 RVA: 0x010E542C File Offset: 0x010E362C
		public GetNextStepsContext(LevelAiPlan plan, bool bIsExecutingPlan, List<LevelAiPlanStepId> outStepIds)
		{
			this.Plan = plan;
			this.IsExecutingPlan = bIsExecutingPlan;
			this.OutStepIds = outStepIds;
			this.NumSubmittedSteps = 0;
		}

		// Token: 0x0604483B RID: 280635 RVA: 0x010E5450 File Offset: 0x010E3650
		public void SubmitPlanStep(LevelAiPlanStepId planStepId)
		{
			this.OutStepIds.Add(planStepId);
			this.NumSubmittedSteps++;
		}

		// Token: 0x0604483C RID: 280636 RVA: 0x010E546C File Offset: 0x010E366C
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

		// Token: 0x0604483D RID: 280637 RVA: 0x010E5529 File Offset: 0x010E3729
		public int GetNumSubmittedSteps()
		{
			return this.NumSubmittedSteps;
		}

		// Token: 0x0604483E RID: 280638 RVA: 0x010E5531 File Offset: 0x010E3731
		[return: Nullable(2)]
		public LevelAiPlanStep GetStep(LevelAiPlanStepId inStepId)
		{
			return this.Plan.GetStep(inStepId);
		}

		// Token: 0x04023A20 RID: 145952
		private readonly LevelAiPlan Plan;

		// Token: 0x04023A21 RID: 145953
		private readonly List<LevelAiPlanStepId> OutStepIds;

		// Token: 0x04023A22 RID: 145954
		private int NumSubmittedSteps;

		// Token: 0x04023A23 RID: 145955
		public bool IsExecutingPlan;
	}
}
