using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F38 RID: 24376
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiTask : LevelAiStandaloneNode
	{
		// Token: 0x0603A9FB RID: 240123 RVA: 0x010910AB File Offset: 0x0108F2AB
		public override void Serialize(CharacterPlanComponent ownerComponent, CreatureDataComponent creatureDataComp, string description, [Nullable(2)] ActionParams @params = null)
		{
			base.Serialize(ownerComponent, creatureDataComp, description, null);
			this.Params = @params;
		}

		// Token: 0x0603A9FC RID: 240124 RVA: 0x010910C0 File Offset: 0x0108F2C0
		public unsafe override void MakePlanExpansions(PlanningContext context, LevelAiWorldState worldState)
		{
			string reason = "Task Make Plan Expansions";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LevelIndex", context.CurrentLevelIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StepIndex", context.CurrentStepIndex);
			base.PrintDescription(reason, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.CreatePlanSteps(context, worldState.MakeCopy());
		}

		// Token: 0x0603A9FD RID: 240125 RVA: 0x0109113C File Offset: 0x0108F33C
		public ELevelAiNodeResult WrappedExecuteTask()
		{
			base.PrintDescription("Execute Task", default(ReadOnlySpan<ValueTuple<string, object>>));
			return this.ExecuteTask();
		}

		// Token: 0x0603A9FE RID: 240126 RVA: 0x01091164 File Offset: 0x0108F364
		public ELevelAiNodeResult WrappedAbortTask()
		{
			base.PrintDescription("Abort Task", default(ReadOnlySpan<ValueTuple<string, object>>));
			return this.AbortTask();
		}

		// Token: 0x0603A9FF RID: 240127 RVA: 0x0109118B File Offset: 0x0108F38B
		public void WrappedTickTask(float deltaTime)
		{
			if (this.NotifyTick)
			{
				this.TickTask(deltaTime);
			}
		}

		// Token: 0x0603AA00 RID: 240128 RVA: 0x0109119C File Offset: 0x0108F39C
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

		// Token: 0x0603AA01 RID: 240129 RVA: 0x010911DC File Offset: 0x0108F3DC
		protected virtual void CreatePlanSteps(PlanningContext context, LevelAiWorldState worldStateAfterTask)
		{
			context.SubmitCandidatePlanStep(this, worldStateAfterTask, 0);
		}

		// Token: 0x0603AA02 RID: 240130 RVA: 0x010911E8 File Offset: 0x0108F3E8
		protected void FinishLatentTask(ELevelAiNodeResult taskResult)
		{
			ActiveTaskInfo activeTaskInfo = base.CharacterPlanComponent.FindActiveTaskInfo(this);
			if (activeTaskInfo == null)
			{
				return;
			}
			activeTaskInfo.PlanInstance.OnTaskFinished(this, activeTaskInfo.PlanStepId, taskResult);
		}

		// Token: 0x0603AA03 RID: 240131 RVA: 0x01091219 File Offset: 0x0108F419
		protected virtual ELevelAiNodeResult ExecuteTask()
		{
			return ELevelAiNodeResult.Succeeded;
		}

		// Token: 0x0603AA04 RID: 240132 RVA: 0x0109121C File Offset: 0x0108F41C
		protected virtual ELevelAiNodeResult AbortTask()
		{
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x0603AA05 RID: 240133 RVA: 0x0109121F File Offset: 0x0108F41F
		protected virtual void TickTask(float deltaTime)
		{
		}

		// Token: 0x0603AA06 RID: 240134 RVA: 0x01091221 File Offset: 0x0108F421
		protected virtual void OnTaskFinished(ELevelAiNodeResult result)
		{
		}

		// Token: 0x0401ECE6 RID: 126182
		protected bool NotifyTick;

		// Token: 0x0401ECE7 RID: 126183
		protected bool NotifyTaskFinished;

		// Token: 0x0401ECE8 RID: 126184
		[Nullable(2)]
		protected ActionParams Params;
	}
}
