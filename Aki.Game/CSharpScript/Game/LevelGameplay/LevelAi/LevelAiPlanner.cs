using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DB6 RID: 28086
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiPlanner
	{
		// Token: 0x170099BA RID: 39354
		// (get) Token: 0x0604487A RID: 280698 RVA: 0x010E67A9 File Offset: 0x010E49A9
		public bool WasCanceled
		{
			get
			{
				return this.WasCanceledInternal;
			}
		}

		// Token: 0x0604487B RID: 280699 RVA: 0x010E67B1 File Offset: 0x010E49B1
		public void SetUp(LevelAi asset, CharacterPlanComponent owner)
		{
			this.OwnerComponent = owner;
			this.StartingPlan = new LevelAiPlan(asset, this.OwnerComponent.WorldState.MakeCopy());
		}

		// Token: 0x0604487C RID: 280700 RVA: 0x010E67D8 File Offset: 0x010E49D8
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

		// Token: 0x0604487D RID: 280701 RVA: 0x010E6814 File Offset: 0x010E4A14
		public void CancelPlanning()
		{
			this.WasCanceledInternal = true;
			this.FinishedPlan = null;
			this.IsPlanning = false;
		}

		// Token: 0x0604487E RID: 280702 RVA: 0x010E682C File Offset: 0x010E4A2C
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

		// Token: 0x0604487F RID: 280703 RVA: 0x010E6884 File Offset: 0x010E4A84
		private void EndPlanning()
		{
			this.ClearIntermediateState();
			this.Frontier.Clear();
			this.OnPlanningFinished(this, this.FinishedPlan);
			this.IsPlanning = false;
		}

		// Token: 0x06044880 RID: 280704 RVA: 0x010E68B0 File Offset: 0x010E4AB0
		public void Clear()
		{
			this.ClearIntermediateState();
			this.StartingPlan = null;
			this.Frontier.Clear();
			this.FinishedPlan = null;
		}

		// Token: 0x06044881 RID: 280705 RVA: 0x010E68D1 File Offset: 0x010E4AD1
		private void ClearIntermediateState()
		{
			this.CurrentPlanToExpand = null;
			this.CurrentPlanStepId.Reset();
		}

		// Token: 0x06044882 RID: 280706 RVA: 0x010E68E5 File Offset: 0x010E4AE5
		[NullableContext(2)]
		private LevelAiPlan DeQueueCurrentBestPlan()
		{
			if (!this.Frontier.Empty)
			{
				return this.Frontier.Pop();
			}
			return null;
		}

		// Token: 0x06044883 RID: 280707 RVA: 0x010E6904 File Offset: 0x010E4B04
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

		// Token: 0x06044884 RID: 280708 RVA: 0x010E6A04 File Offset: 0x010E4C04
		private static bool EnterDecorators(LevelAiStandaloneNode node)
		{
			return LevelAiPlanner.<EnterDecorators>g__checkCondition|20_0(node.Decorators);
		}

		// Token: 0x06044885 RID: 280709 RVA: 0x010E6A16 File Offset: 0x010E4C16
		public void SubmitCandidatePlan(LevelAiPlan candidatePlan)
		{
			this.Frontier.Push(candidatePlan);
		}

		// Token: 0x06044887 RID: 280711 RVA: 0x010E6A64 File Offset: 0x010E4C64
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

		// Token: 0x04023A35 RID: 145973
		[Nullable(2)]
		private CharacterPlanComponent OwnerComponent;

		// Token: 0x04023A36 RID: 145974
		[Nullable(2)]
		private LevelAiPlan CurrentPlanToExpand;

		// Token: 0x04023A37 RID: 145975
		private readonly LevelAiPlanStepId CurrentPlanStepId = new LevelAiPlanStepId(-1, -1);

		// Token: 0x04023A38 RID: 145976
		[Nullable(2)]
		private LevelAiPlan StartingPlan;

		// Token: 0x04023A39 RID: 145977
		[Nullable(2)]
		private LevelAiPlan FinishedPlan;

		// Token: 0x04023A3A RID: 145978
		private bool WasCanceledInternal;

		// Token: 0x04023A3B RID: 145979
		private readonly PriorityQueue<LevelAiPlan> Frontier = new PriorityQueue<LevelAiPlan>((LevelAiPlan a, LevelAiPlan b) => a.Cost - b.Cost);

		// Token: 0x04023A3C RID: 145980
		private bool IsPlanning;

		// Token: 0x04023A3D RID: 145981
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<LevelAiPlanner, LevelAiPlan> OnPlanningFinished;
	}
}
