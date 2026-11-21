using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F34 RID: 24372
	[NullableContext(2)]
	[Nullable(0)]
	public class PlanningContext
	{
		// Token: 0x17006EBB RID: 28347
		// (get) Token: 0x0603A9D7 RID: 240087 RVA: 0x0109086E File Offset: 0x0108EA6E
		public int CurrentLevelIndex
		{
			get
			{
				return this.CurrentPlanStepId.LevelIndex;
			}
		}

		// Token: 0x17006EBC RID: 28348
		// (get) Token: 0x0603A9D8 RID: 240088 RVA: 0x0109087B File Offset: 0x0108EA7B
		public int CurrentStepIndex
		{
			get
			{
				return this.CurrentPlanStepId.StepIndex;
			}
		}

		// Token: 0x0603A9D9 RID: 240089 RVA: 0x01090888 File Offset: 0x0108EA88
		[NullableContext(1)]
		public PlanningContext(LevelAiPlanner planner, LevelAiStandaloneNode addingNode, LevelAiPlan planToExpand, LevelAiPlanStepId currentPlanStepId, LevelAiWorldState worldState)
		{
			this.Planner = planner;
			this.AddingNode = addingNode;
			this.PlanToExpand = planToExpand;
			this.CurrentPlanStepId = currentPlanStepId;
			this.WorldState = worldState;
		}

		// Token: 0x0603A9DA RID: 240090 RVA: 0x010908B8 File Offset: 0x0108EAB8
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

		// Token: 0x0603A9DB RID: 240091 RVA: 0x0109092C File Offset: 0x0108EB2C
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

		// Token: 0x0603A9DC RID: 240092 RVA: 0x0109095C File Offset: 0x0108EB5C
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

		// Token: 0x0603A9DD RID: 240093 RVA: 0x010909C3 File Offset: 0x0108EBC3
		[NullableContext(1)]
		public void SubmitCandidatePlan(LevelAiPlan candidatePlan)
		{
			this.Planner.SubmitCandidatePlan(candidatePlan);
		}

		// Token: 0x0401ECD2 RID: 126162
		private readonly LevelAiPlanner Planner;

		// Token: 0x0401ECD3 RID: 126163
		private readonly LevelAiStandaloneNode AddingNode;

		// Token: 0x0401ECD4 RID: 126164
		private readonly LevelAiPlan PlanToExpand;

		// Token: 0x0401ECD5 RID: 126165
		private readonly LevelAiPlanStepId CurrentPlanStepId;

		// Token: 0x0401ECD6 RID: 126166
		private readonly LevelAiWorldState WorldState;
	}
}
