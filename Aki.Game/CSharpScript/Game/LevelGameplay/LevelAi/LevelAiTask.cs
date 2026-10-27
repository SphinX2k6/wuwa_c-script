using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DB9 RID: 28089
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiTask : LevelAiStandaloneNode
	{
		// Token: 0x06044897 RID: 280727 RVA: 0x010E6E83 File Offset: 0x010E5083
		public override void Serialize(CharacterPlanComponent ownerComponent, CreatureDataComponent creatureDataComp, string description, [Nullable(2)] ActionParams @params = null)
		{
			base.Serialize(ownerComponent, creatureDataComp, description, null);
			this.Params = @params;
		}

		// Token: 0x06044898 RID: 280728 RVA: 0x010E6E98 File Offset: 0x010E5098
		public unsafe override void MakePlanExpansions(PlanningContext context, LevelAiWorldState worldState)
		{
			string reason = "Task Make Plan Expansions";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LevelIndex", context.CurrentLevelIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StepIndex", context.CurrentStepIndex);
			base.PrintDescription(reason, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.CreatePlanSteps(context, worldState.MakeCopy());
		}

		// Token: 0x06044899 RID: 280729 RVA: 0x010E6F14 File Offset: 0x010E5114
		public ELevelAiNodeResult WrappedExecuteTask()
		{
			base.PrintDescription("Execute Task", default(ReadOnlySpan<ValueTuple<string, object>>));
			return this.ExecuteTask();
		}

		// Token: 0x0604489A RID: 280730 RVA: 0x010E6F3C File Offset: 0x010E513C
		public ELevelAiNodeResult WrappedAbortTask()
		{
			base.PrintDescription("Abort Task", default(ReadOnlySpan<ValueTuple<string, object>>));
			return this.AbortTask();
		}

		// Token: 0x0604489B RID: 280731 RVA: 0x010E6F63 File Offset: 0x010E5163
		public void WrappedTickTask(float deltaTime)
		{
			if (this.NotifyTick)
			{
				this.TickTask(deltaTime);
			}
		}

		// Token: 0x0604489C RID: 280732 RVA: 0x010E6F74 File Offset: 0x010E5174
		public void WrappedOnTaskFinished(ELevelAiNodeResult result)
		{
			if (this.NotifyTaskFinished)
			{
				string reason = "Task Finished";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Result", result);
				base.PrintDescription(reason, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.OnTaskFinished(result);
			}
		}

		// Token: 0x0604489D RID: 280733 RVA: 0x010E6FB4 File Offset: 0x010E51B4
		protected virtual void CreatePlanSteps(PlanningContext context, LevelAiWorldState worldStateAfterTask)
		{
			context.SubmitCandidatePlanStep(this, worldStateAfterTask, 0);
		}

		// Token: 0x0604489E RID: 280734 RVA: 0x010E6FC0 File Offset: 0x010E51C0
		protected void FinishLatentTask(ELevelAiNodeResult taskResult)
		{
			ActiveTaskInfo activeTaskInfo = base.CharacterPlanComponent.FindActiveTaskInfo(this);
			if (activeTaskInfo == null)
			{
				return;
			}
			activeTaskInfo.PlanInstance.OnTaskFinished(this, activeTaskInfo.PlanStepId, taskResult);
		}

		// Token: 0x0604489F RID: 280735 RVA: 0x010E6FF1 File Offset: 0x010E51F1
		protected virtual ELevelAiNodeResult ExecuteTask()
		{
			return ELevelAiNodeResult.Succeeded;
		}

		// Token: 0x060448A0 RID: 280736 RVA: 0x010E6FF4 File Offset: 0x010E51F4
		protected virtual ELevelAiNodeResult AbortTask()
		{
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x060448A1 RID: 280737 RVA: 0x010E6FF7 File Offset: 0x010E51F7
		protected virtual void TickTask(float deltaTime)
		{
		}

		// Token: 0x060448A2 RID: 280738 RVA: 0x010E6FF9 File Offset: 0x010E51F9
		protected virtual void OnTaskFinished(ELevelAiNodeResult result)
		{
		}

		// Token: 0x04023A44 RID: 145988
		protected bool NotifyTick;

		// Token: 0x04023A45 RID: 145989
		protected bool NotifyTaskFinished;

		// Token: 0x04023A46 RID: 145990
		[Nullable(2)]
		protected ActionParams Params;
	}
}
