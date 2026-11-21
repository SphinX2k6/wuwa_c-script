using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.LevelAi.Tasks;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Nodes
{
	// Token: 0x02005F48 RID: 24392
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiNodeBehaviourActions : LevelAiStandaloneNode
	{
		// Token: 0x0603AA5A RID: 240218 RVA: 0x01092E50 File Offset: 0x01091050
		public unsafe override void MakePlanExpansions(PlanningContext context, LevelAiWorldState worldState)
		{
			if (this.Actions == null)
			{
				return;
			}
			string reason = "Behaviour Actions Make Plan Expansions";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LevelIndex", context.CurrentLevelIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StepIndex", context.CurrentStepIndex);
			base.PrintDescription(reason, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (!this.ActionsInited)
			{
				this.InitActions();
			}
			if (!this.CanRecordPlanProgress)
			{
				this.LastAbortedSubLevelStepId.Reset();
			}
			ValueTuple<LevelAiPlan, LevelAiPlanStep, LevelAiPlanStepId> valueTuple = context.MakePlanCopyWithAddedStep();
			LevelAiPlan item = valueTuple.Item1;
			LevelAiPlanStep item2 = valueTuple.Item2;
			LevelAiPlanStepId item3 = valueTuple.Item3;
			item2.SubLevelIndex = context.AddLevel(item, item3);
			context.SubmitCandidatePlan(item);
		}

		// Token: 0x0603AA5B RID: 240219 RVA: 0x01092F18 File Offset: 0x01091118
		public override void GetNextSteps(GetNextStepsContext context, LevelAiPlanStepId thisStepId)
		{
			if (!this.LastAbortedSubLevelStepId.Equal(LevelAiPlanStepId.None))
			{
				int levelIndex = this.LastAbortedSubLevelStepId.LevelIndex;
				int stepIndex = this.LastAbortedSubLevelStepId.StepIndex;
				if (context.IsExecutingPlan)
				{
					this.LastAbortedSubLevelStepId.Reset();
				}
				if (levelIndex >= 0 && stepIndex >= 0)
				{
					context.AddNextStepsAfter(new LevelAiPlanStepId(levelIndex, stepIndex - 1));
					return;
				}
			}
			LevelAiPlanStep step = context.GetStep(thisStepId);
			context.AddNextStepsAfter(new LevelAiPlanStepId(step.SubLevelIndex, -1));
		}

		// Token: 0x0603AA5C RID: 240220 RVA: 0x01092F96 File Offset: 0x01091196
		public override bool OnSubLevelStepFinished(LevelAiPlanInstance planInstance, LevelAiPlanStepId thisStepId, LevelAiPlanStepId finishedSubLevelStepId, ELevelAiNodeResult result, bool bFinishedLevel)
		{
			if (result == ELevelAiNodeResult.Aborted)
			{
				this.LastAbortedSubLevelStepId.CopyFrom(finishedSubLevelStepId);
			}
			return true;
		}

		// Token: 0x0603AA5D RID: 240221 RVA: 0x01092FAC File Offset: 0x010911AC
		private void InitActions()
		{
			LevelAiTaskSuccess levelAiTaskSuccess = new LevelAiTaskSuccess();
			levelAiTaskSuccess.Serialize(base.CharacterPlanComponent, base.CreatureDataComponent, this.Description, null);
			levelAiTaskSuccess.Cost = this.Cost;
			this.NextNodes.Add(levelAiTaskSuccess);
			LevelAiRegistry instance = LevelAiRegistry.Instance;
			LevelAiStandaloneNode levelAiStandaloneNode = levelAiTaskSuccess;
			for (int i = 0; i < this.Actions.Count; i++)
			{
				ActionInfo actionInfo = this.Actions[i];
				LevelAiTask levelAiTask = instance.FindTaskCtor(actionInfo.Name)();
				levelAiTask.Serialize(base.CharacterPlanComponent, base.CreatureDataComponent, this.Description + " 任务" + i.ToString(), actionInfo.Params);
				levelAiStandaloneNode.NextNodes.Add(levelAiTask);
				levelAiStandaloneNode = levelAiTask;
			}
			this.ActionsInited = true;
		}

		// Token: 0x0401ED1D RID: 126237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x0401ED1E RID: 126238
		public bool CanRecordPlanProgress;

		// Token: 0x0401ED1F RID: 126239
		public int Cost;

		// Token: 0x0401ED20 RID: 126240
		private bool ActionsInited;

		// Token: 0x0401ED21 RID: 126241
		private readonly LevelAiPlanStepId LastAbortedSubLevelStepId = new LevelAiPlanStepId(-1, -1);
	}
}
