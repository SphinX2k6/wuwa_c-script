using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DB5 RID: 28085
	[NullableContext(2)]
	[Nullable(0)]
	public class PlanningContext
	{
		// Token: 0x170099B8 RID: 39352
		// (get) Token: 0x06044873 RID: 280691 RVA: 0x010E6646 File Offset: 0x010E4846
		public int CurrentLevelIndex
		{
			get
			{
				return this.CurrentPlanStepId.LevelIndex;
			}
		}

		// Token: 0x170099B9 RID: 39353
		// (get) Token: 0x06044874 RID: 280692 RVA: 0x010E6653 File Offset: 0x010E4853
		public int CurrentStepIndex
		{
			get
			{
				return this.CurrentPlanStepId.StepIndex;
			}
		}

		// Token: 0x06044875 RID: 280693 RVA: 0x010E6660 File Offset: 0x010E4860
		[NullableContext(1)]
		public PlanningContext(LevelAiPlanner planner, LevelAiStandaloneNode addingNode, LevelAiPlan planToExpand, LevelAiPlanStepId currentPlanStepId, LevelAiWorldState worldState)
		{
			this.Planner = planner;
			this.AddingNode = addingNode;
			this.PlanToExpand = planToExpand;
			this.CurrentPlanStepId = currentPlanStepId;
			this.WorldState = worldState;
		}

		// Token: 0x06044876 RID: 280694 RVA: 0x010E6690 File Offset: 0x010E4890
		[return: TupleElementNames(new string[]
		{
			"PlanCopy",
			"OutAddedStep",
			"OutAddedStepId"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})]
		public ValueTuple<LevelAiPlan, LevelAiPlanStep, LevelAiPlanStepId> MakePlanCopyWithAddedStep()
		{
			LevelAiPlan levelAiPlan = this.PlanToExpand.MakeCopy();
			LevelAiPlanLevel levelAiPlanLevel = levelAiPlan.Levels[this.CurrentPlanStepId.LevelIndex];
			LevelAiPlanStep levelAiPlanStep = new LevelAiPlanStep(this.AddingNode, this.WorldState, 0, -1);
			levelAiPlanLevel.Steps.Add(levelAiPlanStep);
			LevelAiPlanStepId item = new LevelAiPlanStepId(this.CurrentPlanStepId.LevelIndex, levelAiPlanLevel.Steps.Count - 1);
			return new ValueTuple<LevelAiPlan, LevelAiPlanStep, LevelAiPlanStepId>(levelAiPlan, levelAiPlanStep, item);
		}

		// Token: 0x06044877 RID: 280695 RVA: 0x010E6704 File Offset: 0x010E4904
		[NullableContext(1)]
		public int AddLevel(LevelAiPlan newPlan, [Nullable(2)] LevelAiPlanStepId parentStepId = null)
		{
			if (parentStepId == null)
			{
				parentStepId = LevelAiPlanStepId.None;
			}
			newPlan.Levels.Add(new LevelAiPlanLevel(this.WorldState, parentStepId));
			return newPlan.Levels.Count - 1;
		}

		// Token: 0x06044878 RID: 280696 RVA: 0x010E6734 File Offset: 0x010E4934
		[NullableContext(1)]
		public void SubmitCandidatePlanStep(LevelAiTask task, LevelAiWorldState worldState, int cost)
		{
			LevelAiPlan levelAiPlan = this.PlanToExpand.MakeCopy();
			LevelAiPlanStep item = new LevelAiPlanStep(task, worldState, cost, -1);
			LevelAiPlanLevel levelAiPlanLevel = levelAiPlan.Levels[this.CurrentPlanStepId.LevelIndex];
			levelAiPlanLevel.Steps.Add(item);
			levelAiPlanLevel.Cost += cost;
			levelAiPlan.Cost += cost;
			this.SubmitCandidatePlan(levelAiPlan);
		}

		// Token: 0x06044879 RID: 280697 RVA: 0x010E679B File Offset: 0x010E499B
		[NullableContext(1)]
		public void SubmitCandidatePlan(LevelAiPlan candidatePlan)
		{
			this.Planner.SubmitCandidatePlan(candidatePlan);
		}

		// Token: 0x04023A30 RID: 145968
		private readonly LevelAiPlanner Planner;

		// Token: 0x04023A31 RID: 145969
		private readonly LevelAiStandaloneNode AddingNode;

		// Token: 0x04023A32 RID: 145970
		private readonly LevelAiPlan PlanToExpand;

		// Token: 0x04023A33 RID: 145971
		private readonly LevelAiPlanStepId CurrentPlanStepId;

		// Token: 0x04023A34 RID: 145972
		private readonly LevelAiWorldState WorldState;
	}
}
