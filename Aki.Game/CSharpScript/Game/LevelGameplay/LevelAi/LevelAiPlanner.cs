using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F35 RID: 24373
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiPlanner
	{
		// Token: 0x17006EBD RID: 28349
		// (get) Token: 0x0603A9DE RID: 240094 RVA: 0x010909D1 File Offset: 0x0108EBD1
		public bool WasCanceled
		{
			get
			{
				return this.WasCanceledInternal;
			}
		}

		// Token: 0x0603A9DF RID: 240095 RVA: 0x010909D9 File Offset: 0x0108EBD9
		public void SetUp(LevelAi asset, CharacterPlanComponent owner)
		{
			this.OwnerComponent = owner;
			this.StartingPlan = new LevelAiPlan(asset, this.OwnerComponent.WorldState.MakeCopy());
		}

		// Token: 0x0603A9E0 RID: 240096 RVA: 0x01090A00 File Offset: 0x0108EC00
		public void StartPlanning()
		{
			if (this.IsPlanning)
			{
				return;
			}
			LevelAiPlan startingPlan = this.StartingPlan;
			this.Clear();
			this.Frontier.Push(startingPlan);
			this.IsPlanning = true;
			this.DoPlanning();
		}

		// Token: 0x0603A9E1 RID: 240097 RVA: 0x01090A3C File Offset: 0x0108EC3C
		public void CancelPlanning()
		{
			this.WasCanceledInternal = true;
			this.FinishedPlan = null;
			this.IsPlanning = false;
		}

		// Token: 0x0603A9E2 RID: 240098 RVA: 0x01090A54 File Offset: 0x0108EC54
		public void DoPlanning()
		{
			if (this.WasCanceledInternal)
			{
				return;
			}
			for (;;)
			{
				this.CurrentPlanToExpand = this.DeQueueCurrentBestPlan();
				if (this.CurrentPlanToExpand == null)
				{
					break;
				}
				if (this.CurrentPlanToExpand.IsComplete())
				{
					goto Block_3;
				}
				this.MakeExpansionsOfCurrentPlan();
			}
			this.EndPlanning();
			return;
			Block_3:
			this.FinishedPlan = this.CurrentPlanToExpand;
			this.EndPlanning();
		}

		// Token: 0x0603A9E3 RID: 240099 RVA: 0x01090AAC File Offset: 0x0108ECAC
		private void EndPlanning()
		{
			this.ClearIntermediateState();
			this.Frontier.Clear();
			this.OnPlanningFinished(this, this.FinishedPlan);
			this.IsPlanning = false;
		}

		// Token: 0x0603A9E4 RID: 240100 RVA: 0x01090AD8 File Offset: 0x0108ECD8
		public void Clear()
		{
			this.ClearIntermediateState();
			this.StartingPlan = null;
			this.Frontier.Clear();
			this.FinishedPlan = null;
		}

		// Token: 0x0603A9E5 RID: 240101 RVA: 0x01090AF9 File Offset: 0x0108ECF9
		private void ClearIntermediateState()
		{
			this.CurrentPlanToExpand = null;
			this.CurrentPlanStepId.Reset();
		}

		// Token: 0x0603A9E6 RID: 240102 RVA: 0x01090B0D File Offset: 0x0108ED0D
		[NullableContext(2)]
		private LevelAiPlan DeQueueCurrentBestPlan()
		{
			if (!this.Frontier.Empty)
			{
				return this.Frontier.Pop();
			}
			return null;
		}

		// Token: 0x0603A9E7 RID: 240103 RVA: 0x01090B2C File Offset: 0x0108ED2C
		private void MakeExpansionsOfCurrentPlan()
		{
			if (!this.CurrentPlanToExpand.FindStepToAddAfter(this.CurrentPlanStepId) || this.CurrentPlanStepId.Equal(LevelAiPlanStepId.None))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelAi;
				ELogAuthor author = ELogAuthor.CJH;
				string message = "没有未完成的任务层";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", this.OwnerComponent.GetCreatureDataComponent().GetPbDataId());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			IEnumerable<LevelAiStandaloneNode> nextNodes = this.CurrentPlanToExpand.GetNextNodes(this.CurrentPlanStepId);
			LevelAiWorldState worldState = this.CurrentPlanToExpand.GetWorldState(this.CurrentPlanStepId);
			foreach (LevelAiStandaloneNode levelAiStandaloneNode in nextNodes)
			{
				this.OwnerComponent.WorldStateProxy = worldState;
				if (LevelAiPlanner.EnterDecorators(levelAiStandaloneNode))
				{
					PlanningContext context = new PlanningContext(this, levelAiStandaloneNode, this.CurrentPlanToExpand, this.CurrentPlanStepId, worldState);
					levelAiStandaloneNode.MakePlanExpansions(context, worldState);
				}
			}
			this.ClearIntermediateState();
		}

		// Token: 0x0603A9E8 RID: 240104 RVA: 0x01090C2C File Offset: 0x0108EE2C
		private static bool EnterDecorators(LevelAiStandaloneNode node)
		{
			return LevelAiPlanner.<EnterDecorators>g__checkCondition|20_0(node.Decorators);
		}

		// Token: 0x0603A9E9 RID: 240105 RVA: 0x01090C3E File Offset: 0x0108EE3E
		public void SubmitCandidatePlan(LevelAiPlan candidatePlan)
		{
			this.Frontier.Push(candidatePlan);
		}

		// Token: 0x0603A9EB RID: 240107 RVA: 0x01090C8C File Offset: 0x0108EE8C
		[CompilerGenerated]
		internal static bool <EnterDecorators>g__checkCondition|20_0(List<LevelAiDecorator> decorators)
		{
			ELevelAiDecoratorCheckResult elevelAiDecoratorCheckResult = ELevelAiDecoratorCheckResult.Passed;
			foreach (LevelAiDecorator levelAiDecorator in decorators)
			{
				if (levelAiDecorator != null)
				{
					ELevelAiDecoratorCheckResult val = levelAiDecorator.WrappedCheckCondition(ELevelAiDecoratorCheckType.PlanEnter);
					elevelAiDecoratorCheckResult = (ELevelAiDecoratorCheckResult)Math.Min((int)elevelAiDecoratorCheckResult, (int)val);
					if (elevelAiDecoratorCheckResult != ELevelAiDecoratorCheckResult.Passed)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0401ECD7 RID: 126167
		[Nullable(2)]
		private CharacterPlanComponent OwnerComponent;

		// Token: 0x0401ECD8 RID: 126168
		[Nullable(2)]
		private LevelAiPlan CurrentPlanToExpand;

		// Token: 0x0401ECD9 RID: 126169
		private readonly LevelAiPlanStepId CurrentPlanStepId = new LevelAiPlanStepId(-1, -1);

		// Token: 0x0401ECDA RID: 126170
		[Nullable(2)]
		private LevelAiPlan StartingPlan;

		// Token: 0x0401ECDB RID: 126171
		[Nullable(2)]
		private LevelAiPlan FinishedPlan;

		// Token: 0x0401ECDC RID: 126172
		private bool WasCanceledInternal;

		// Token: 0x0401ECDD RID: 126173
		private readonly PriorityQueue<LevelAiPlan> Frontier = new PriorityQueue<LevelAiPlan>((LevelAiPlan a, LevelAiPlan b) => a.Cost - b.Cost);

		// Token: 0x0401ECDE RID: 126174
		private bool IsPlanning;

		// Token: 0x0401ECDF RID: 126175
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<LevelAiPlanner, LevelAiPlan> OnPlanningFinished;
	}
}
