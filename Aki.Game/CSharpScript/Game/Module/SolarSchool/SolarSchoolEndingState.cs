using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCondition;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058F2 RID: 22770
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolEndingState : SolarSchoolInProgressStateBase
	{
		// Token: 0x06038247 RID: 229959 RVA: 0x00FB1720 File Offset: 0x00FAF920
		protected unsafe override void OnEnterState(ESolarSchoolStageStateType? prev)
		{
			SolarSchoolGamePlayModel.Instance.ResetEndingRuntime();
			SolarSchoolGamePlayModel.Instance.CaptureEndingSnapshot();
			SolarSchoolGamePlayModel.Instance.EnterEndingDay();
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			SolarSchoolEndingFlowGraph solarSchoolEndingFlowGraph = SolarSchoolEndingFlowGraph.Create(activityId, SolarSchoolConfig.Instance.GetEndingFlowList(activityId));
			this.FlowGraph = solarSchoolEndingFlowGraph;
			this.CurrentNodeId = solarSchoolEndingFlowGraph.StartNodeId;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.SWC;
			string message = "[SolarSchool] 进入配置化结局流程";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("startNodeId", this.CurrentNodeId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.AdvanceFlow();
		}

		// Token: 0x06038248 RID: 229960 RVA: 0x00FB17E8 File Offset: 0x00FAF9E8
		protected unsafe override void OnTaskFinish(int taskId)
		{
			SolarSchoolEndingTask currentActionTask = this.CurrentActionTask;
			this.CurrentActionTask = null;
			if (currentActionTask == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[SolarSchool] 结局 Action Task 完成回调异常，停止结局流程";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("nodeId", this.CurrentNodeId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("taskId", taskId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (!currentActionTask.ActionSucceeded)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[SolarSchool] 结局 Action 执行失败，停止结局流程";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("nodeId", this.CurrentNodeId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("taskId", taskId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			SolarSchoolEndingFlowGraph flowGraph = this.FlowGraph;
			this.CurrentNodeId = flowGraph.GetNextNodeId(flowGraph.GetNode(this.CurrentNodeId), false);
			this.AdvanceFlow();
		}

		// Token: 0x06038249 RID: 229961 RVA: 0x00FB1900 File Offset: 0x00FAFB00
		protected override void OnExitState(ESolarSchoolStageStateType? next)
		{
			SolarSchoolGamePlayModel.Instance.ClearEndingVisualNovelTime();
			this.CurrentActionTask = null;
			this.FlowGraph = null;
			this.CurrentNodeId = 0;
		}

		// Token: 0x0603824A RID: 229962 RVA: 0x00FB1924 File Offset: 0x00FAFB24
		private unsafe void AdvanceFlow()
		{
			SolarSchoolEndingFlowGraph flowGraph = this.FlowGraph;
			while (this.CurrentNodeId != 0)
			{
				SolarSchoolEndingFlow node = flowGraph.GetNode(this.CurrentNodeId);
				switch (node.NodeType)
				{
				case 1:
				{
					SolarSchoolActionBase solarSchoolActionBase = SolarSchoolGamePlayModel.Instance.CreateAction(node.ActionId);
					if (solarSchoolActionBase != null)
					{
						SolarSchoolModel.Instance.SetFirstScreenReadyIfNoPreparer(new <>z__ReadOnlySingleElementList<SolarSchoolActionBase>(solarSchoolActionBase));
						SolarSchoolEndingTask solarSchoolEndingTask = new SolarSchoolEndingTask(solarSchoolActionBase);
						this.CurrentActionTask = solarSchoolEndingTask;
						base.RunTask(solarSchoolEndingTask);
						return;
					}
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.SWC;
					string message = "[SolarSchool] 结局流程 Action 创建失败，跳过当前节点并继续流程";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("nodeId", node.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("actionId", node.ActionId);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.CurrentNodeId = flowGraph.GetNextNodeId(node, false);
					break;
				}
				case 2:
				{
					bool flag = ActivityConditionCenter.Instance.CheckGroup(node.ConditionId);
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SolarSchool;
					ELogAuthor author2 = ELogAuthor.SWC;
					string message2 = "[SolarSchool] 结局流程条件分支";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("nodeId", node.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("conditionId", node.ConditionId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("result", flag);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
					this.CurrentNodeId = flowGraph.GetNextNodeId(node, flag);
					break;
				}
				case 3:
					this.ReportCycleFinish();
					SolarSchoolGamePlayModel.Instance.ChangeState(ESolarSchoolStageStateType.GameExit);
					return;
				case 4:
					this.ReportCycleFinish();
					SolarSchoolGamePlayModel.Instance.StartNextCycleAsync().Forget<bool>();
					return;
				default:
					SolarSchoolEndingState.ExitWithError("结局流程节点类型无效", new ValueTuple<string, object>[]
					{
						new ValueTuple<string, object>("nodeId", node.Id),
						new ValueTuple<string, object>("nodeType", node.NodeType)
					});
					return;
				}
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.SolarSchool;
			ELogAuthor author3 = ELogAuthor.LRC;
			string message3 = "[SolarSchool] 结局流程走到空后继节点，结束流程";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", flowGraph.ActivityId);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ReportCycleFinish();
			SolarSchoolGamePlayModel.Instance.ChangeState(ESolarSchoolStageStateType.GameExit);
		}

		// Token: 0x0603824B RID: 229963 RVA: 0x00FB1BA4 File Offset: 0x00FAFDA4
		private void ReportCycleFinish()
		{
			SolarSchoolGamePlayModel.Instance.LogReporter.ReportStageSettle(ESolarSchoolStageSettleType.CycleFinish);
		}

		// Token: 0x0603824C RID: 229964 RVA: 0x00FB1BB6 File Offset: 0x00FAFDB6
		[NullableContext(1)]
		private static void ExitWithError(string message, [TupleElementNames(new string[]
		{
			"Key",
			"Value"
		})] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] params ValueTuple<string, object>[] args)
		{
			Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.SWC, "[SolarSchool] " + message + "，安全退出结局流程", args);
			SolarSchoolGamePlayModel.Instance.ChangeState(ESolarSchoolStageStateType.GameExit);
		}

		// Token: 0x0401D90D RID: 121101
		private SolarSchoolEndingFlowGraph FlowGraph;

		// Token: 0x0401D90E RID: 121102
		private SolarSchoolEndingTask CurrentActionTask;

		// Token: 0x0401D90F RID: 121103
		private int CurrentNodeId;
	}
}
