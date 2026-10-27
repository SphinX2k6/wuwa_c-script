using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DB4 RID: 28084
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiPlanInstance
	{
		// Token: 0x06044844 RID: 280644 RVA: 0x010E5569 File Offset: 0x010E3769
		public void Initialize(CharacterPlanComponent ownerComponent)
		{
			this.OwnerComponent = ownerComponent;
		}

		// Token: 0x06044845 RID: 280645 RVA: 0x010E5572 File Offset: 0x010E3772
		public bool IsPlanning()
		{
			return this.CurrentPlanner != null;
		}

		// Token: 0x06044846 RID: 280646 RVA: 0x010E557D File Offset: 0x010E377D
		public bool HasPlan()
		{
			return this.CurrentPlan != null && this.CurrentPlanStartedExecution;
		}

		// Token: 0x06044847 RID: 280647 RVA: 0x010E558F File Offset: 0x010E378F
		public bool HasActiveTasks()
		{
			return this.CurrentlyExecutingStepIds.Count > 0 || this.PendingExecutionStepIds.Count > 0 || this.CurrentlyAbortingStepIds.Count > 0;
		}

		// Token: 0x06044848 RID: 280648 RVA: 0x010E55BD File Offset: 0x010E37BD
		public bool HasActivePlan()
		{
			return this.HasPlan() && this.HasActiveTasks();
		}

		// Token: 0x06044849 RID: 280649 RVA: 0x010E55CF File Offset: 0x010E37CF
		public bool CanLoop()
		{
			return this.Loop && !this.OwnerComponent.Paused;
		}

		// Token: 0x0604484A RID: 280650 RVA: 0x010E55E9 File Offset: 0x010E37E9
		public void Start()
		{
			if (this.Status == ELevelAiPlanInstanceStatus.InProgress)
			{
				return;
			}
			this.Status = ELevelAiPlanInstanceStatus.InProgress;
			this.SavedPlan = null;
			this.ClearCurrentPlan();
			this.CancelActivePlanning();
			this.StartPlanning();
		}

		// Token: 0x0604484B RID: 280651 RVA: 0x010E5618 File Offset: 0x010E3818
		public void Tick(float deltaTime)
		{
			if (this.Status == ELevelAiPlanInstanceStatus.InProgress && !this.HasActivePlan() && !this.IsPlanning())
			{
				this.StartPlanning();
			}
			if (this.Status == ELevelAiPlanInstanceStatus.InProgress && !this.HasActivePlan() && this.IsPlanning())
			{
				this.CurrentPlanner.DoPlanning();
			}
			if (this.HasActivePlan())
			{
				this.TickCurrentPlan(deltaTime);
			}
		}

		// Token: 0x0604484C RID: 280652 RVA: 0x010E5677 File Offset: 0x010E3877
		public void Stop()
		{
			if (this.Status != ELevelAiPlanInstanceStatus.InProgress)
			{
				return;
			}
			this.CancelActivePlanning();
			this.AbortCurrentPlan();
		}

		// Token: 0x0604484D RID: 280653 RVA: 0x010E568F File Offset: 0x010E388F
		public void Pause()
		{
			if (this.Status != ELevelAiPlanInstanceStatus.InProgress)
			{
				return;
			}
			if (!this.IsPlanning() && this.HasActiveTasks())
			{
				this.SavedPlan = this.CurrentPlan;
			}
			this.CancelActivePlanning();
			this.AbortCurrentPlan();
		}

		// Token: 0x0604484E RID: 280654 RVA: 0x010E56C4 File Offset: 0x010E38C4
		public void Resume()
		{
			if (this.Status == ELevelAiPlanInstanceStatus.InProgress)
			{
				return;
			}
			this.Status = ELevelAiPlanInstanceStatus.InProgress;
			this.ClearCurrentPlan();
			this.CancelActivePlanning();
			if (this.CanReuseSavedPlan())
			{
				this.StartPlanExecution(this.SavedPlan);
			}
			else
			{
				this.StartPlanning();
			}
			this.SavedPlan = null;
		}

		// Token: 0x0604484F RID: 280655 RVA: 0x010E5714 File Offset: 0x010E3914
		public bool RecheckCurrentPlan()
		{
			List<LevelAiPlanStepId> list;
			if (this.CurrentPlanStartedExecution)
			{
				list = this.CurrentlyExecutingStepIds.ToList<LevelAiPlanStepId>();
			}
			else
			{
				list = new List<LevelAiPlanStepId>();
				this.GetNextStepsInCurrentPlan(list, new LevelAiPlanStepId(0, -1), false);
			}
			while (list.Count > 0)
			{
				LevelAiPlanStepId planStepId = list.Pop<LevelAiPlanStepId>();
				if (!this.UpdateSubNodes(planStepId, false, true))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06044850 RID: 280656 RVA: 0x010E576F File Offset: 0x010E396F
		public void RePlan()
		{
			if (this.Status != ELevelAiPlanInstanceStatus.InProgress)
			{
				return;
			}
			this.AbortCurrentPlan();
			if (!this.IsPlanning())
			{
				this.StartPlanning();
			}
		}

		// Token: 0x06044851 RID: 280657 RVA: 0x010E5790 File Offset: 0x010E3990
		public void AbortCurrentPlan()
		{
			if (this.HasPlan())
			{
				for (int i = this.PendingExecutionStepIds.Count - 1; i >= 0; i--)
				{
					LevelAiPlanStepId planStepId = this.PendingExecutionStepIds[i];
					this.PendingExecutionStepIds.RemoveAt(i);
					this.FinishSubNodesAtPlanStep(planStepId, ELevelAiNodeResult.Aborted);
				}
				if (this.CurrentlyExecutingStepIds.Count > 0)
				{
					for (int j = this.CurrentlyExecutingStepIds.Count - 1; j >= 0; j--)
					{
						this.AbortExecutingPlanStep(this.CurrentlyExecutingStepIds[j]);
					}
					return;
				}
				this.OnPlanAbortFinished();
			}
		}

		// Token: 0x06044852 RID: 280658 RVA: 0x010E581D File Offset: 0x010E3A1D
		public void CancelActivePlanning()
		{
			if (this.IsPlanning())
			{
				this.CurrentPlanner.CancelPlanning();
				if (this.CurrentPlanner != null)
				{
					this.CurrentPlanner.Clear();
					this.CurrentPlanner = null;
				}
			}
		}

		// Token: 0x06044853 RID: 280659 RVA: 0x010E584C File Offset: 0x010E3A4C
		private void StartPlanning()
		{
			if (this.IsPlanning())
			{
				Log.Instance.Error(ELogModule.LevelAi, ELogAuthor.CJH, "[StartPlanning] 规划中，重复调用", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.OwnerComponent != null && this.OwnerComponent.GetCurrentLevelAiAsset() != null)
			{
				this.CurrentPlanner = new LevelAiPlanner();
				this.CurrentPlanner.SetUp(this.OwnerComponent.GetCurrentLevelAiAsset(), this.OwnerComponent);
				this.CurrentPlanner.OnPlanningFinished = new Action<LevelAiPlanner, LevelAiPlan>(this.OnPlanningTaskFinished);
				this.CurrentPlanner.StartPlanning();
			}
		}

		// Token: 0x06044854 RID: 280660 RVA: 0x010E58DC File Offset: 0x010E3ADC
		private void OnPlanningTaskFinished(LevelAiPlanner sender, LevelAiPlan producedPlan)
		{
			if (this.OwnerComponent == null)
			{
				return;
			}
			if (sender != this.CurrentPlanner)
			{
				return;
			}
			bool wasCanceled = sender.WasCanceled;
			sender.Clear();
			this.CurrentPlanner = null;
			if (wasCanceled)
			{
				this.Stop();
				return;
			}
			if (this.Status != ELevelAiPlanInstanceStatus.InProgress)
			{
				return;
			}
			if (producedPlan != null)
			{
				if (!this.StartPlanExecution(producedPlan))
				{
					this.Stop();
					return;
				}
			}
			else
			{
				this.Stop();
			}
		}

		// Token: 0x06044855 RID: 280661 RVA: 0x010E593C File Offset: 0x010E3B3C
		private bool StartPlanExecution(LevelAiPlan plan)
		{
			if (plan == null)
			{
				return false;
			}
			if (this.OwnerComponent == null || this.OwnerComponent.GetCurrentLevelAiAsset() == null)
			{
				return false;
			}
			this.InitializeCurrentPlan(plan);
			if (!this.RecheckCurrentPlan())
			{
				this.ClearCurrentPlan();
				return false;
			}
			bool flag = this.GetNextStepsInCurrentPlan(this.PendingExecutionStepIds, new LevelAiPlanStepId(0, -1), true) > 0;
			this.CurrentPlanStartedExecution = true;
			if (flag)
			{
				this.StartTasksExecution();
			}
			else
			{
				this.OnPlanExecutionSuccessfullyFinished();
			}
			return true;
		}

		// Token: 0x06044856 RID: 280662 RVA: 0x010E59AC File Offset: 0x010E3BAC
		private void StartTasksExecution()
		{
			List<LevelAiPlanStepId> list = new List<LevelAiPlanStepId>();
			while (this.PendingExecutionStepIds.Count > 0)
			{
				LevelAiPlanStepId levelAiPlanStepId = this.PendingExecutionStepIds[0];
				if (levelAiPlanStepId == null)
				{
					return;
				}
				if (list.Contains(levelAiPlanStepId))
				{
					break;
				}
				this.PendingExecutionStepIds.RemoveAt(0);
				this.StartExecuteTask(levelAiPlanStepId);
				list.Add(levelAiPlanStepId);
			}
		}

		// Token: 0x06044857 RID: 280663 RVA: 0x010E5A04 File Offset: 0x010E3C04
		private ELevelAiNodeResult StartExecuteTask(LevelAiPlanStepId planStepId)
		{
			if (!this.HasPlan())
			{
				Log.Instance.Error(ELogModule.LevelAi, ELogAuthor.CJH, "[StartExecuteTask] 当前没有规划", default(ReadOnlySpan<ValueTuple<string, object>>));
				return ELevelAiNodeResult.Failed;
			}
			LevelAiTask levelAiTask = this.CurrentPlan.GetStep(planStepId).Node as LevelAiTask;
			if (levelAiTask == null)
			{
				Log.Instance.Error(ELogModule.LevelAi, ELogAuthor.CJH, "[StartExecuteTask] 执行了非Task节点", default(ReadOnlySpan<ValueTuple<string, object>>));
				return ELevelAiNodeResult.Failed;
			}
			List<SubNodesInfo> list = new List<SubNodesInfo>();
			this.GetSubNodesInCurrentPlanToStart(list, planStepId);
			for (int i = list.Count - 1; i >= 0; i--)
			{
				SubNodesInfo subNodesInfo = list[i];
				if (!this.CheckConditionsOfDecorators(subNodesInfo, ELevelAiDecoratorCheckType.PlanExecuting))
				{
					this.FinishSubNodesAtPlanStep(planStepId, ELevelAiNodeResult.Aborted);
					this.AbortCurrentPlan();
					return ELevelAiNodeResult.Failed;
				}
				this.StartSubNodesInSubNodeGroup(subNodesInfo);
			}
			this.CurrentlyExecutingStepIds.Add(planStepId);
			ELevelAiNodeResult elevelAiNodeResult = levelAiTask.WrappedExecuteTask();
			if (elevelAiNodeResult != ELevelAiNodeResult.InProgress)
			{
				this.OnTaskFinished(levelAiTask, planStepId, elevelAiNodeResult);
			}
			return elevelAiNodeResult;
		}

		// Token: 0x06044858 RID: 280664 RVA: 0x010E5AE4 File Offset: 0x010E3CE4
		private void TickCurrentPlan(float deltaTime)
		{
			LevelAiPlanInstance.<>c__DisplayClass30_0 CS$<>8__locals1;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.deltaTime = deltaTime;
			this.StartTasksExecution();
			foreach (LevelAiPlanStepId levelAiPlanStepId in this.CurrentlyExecutingStepIds.ToList<LevelAiPlanStepId>())
			{
				if (this.CurrentlyExecutingStepIds.Contains(levelAiPlanStepId) && !this.<TickCurrentPlan>g__updateAtPlanStep|30_0(levelAiPlanStepId, ref CS$<>8__locals1))
				{
					break;
				}
			}
		}

		// Token: 0x06044859 RID: 280665 RVA: 0x010E5B68 File Offset: 0x010E3D68
		private bool UpdateSubNodes(LevelAiPlanStepId planStepId, bool bCheckConditionsExecution, bool bCheckConditionsRecheck)
		{
			bool flag = bCheckConditionsExecution || bCheckConditionsRecheck;
			List<SubNodesInfo> list = new List<SubNodesInfo>();
			this.GetSubNodesInCurrentPlanToTick(list, planStepId);
			for (int i = list.Count - 1; i >= 0; i--)
			{
				SubNodesInfo subNodesInfo = list[i];
				if (flag)
				{
					ELevelAiDecoratorCheckType checkType = bCheckConditionsRecheck ? ELevelAiDecoratorCheckType.PlanRecheck : ELevelAiDecoratorCheckType.PlanExecuting;
					if (!this.CheckConditionsOfDecorators(subNodesInfo, checkType))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0604485A RID: 280666 RVA: 0x010E5BBC File Offset: 0x010E3DBC
		private void AbortExecutingPlanStep(LevelAiPlanStepId planStepId)
		{
			LevelAiTask taskInCurrentPlan = this.GetTaskInCurrentPlan(planStepId);
			int index = this.CurrentlyExecutingStepIds.IndexOf(planStepId);
			this.CurrentlyExecutingStepIds.RemoveAt(index);
			this.CurrentlyExecutingStepIds.Add(planStepId);
			ELevelAiNodeResult elevelAiNodeResult = taskInCurrentPlan.WrappedAbortTask();
			if (elevelAiNodeResult != ELevelAiNodeResult.Aborted)
			{
				Log.Instance.Error(ELogModule.LevelAi, ELogAuthor.CJH, "[AbortExecutingPlanStep] 失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (elevelAiNodeResult == ELevelAiNodeResult.Aborted)
			{
				this.OnTaskFinished(taskInCurrentPlan, planStepId, elevelAiNodeResult);
			}
		}

		// Token: 0x0604485B RID: 280667 RVA: 0x010E5C2C File Offset: 0x010E3E2C
		public void OnTaskFinished(LevelAiTask task, LevelAiPlanStepId finishStepId, ELevelAiNodeResult result)
		{
			if (task == null)
			{
				Log.Instance.Error(ELogModule.LevelAi, ELogAuthor.CJH, "[OnTaskFinished] Task无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!this.HasPlan())
			{
				Log.Instance.Error(ELogModule.LevelAi, ELogAuthor.CJH, "[OnTaskFinished] Plan无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			task.WrappedOnTaskFinished(result);
			this.NotifySubLevelStepFinishedIfNeeded(finishStepId, result);
			if (result == ELevelAiNodeResult.Succeeded)
			{
				this.GetNextStepsInCurrentPlan(this.PendingExecutionStepIds, finishStepId, true);
			}
			this.FinishSubNodesAtPlanStep(finishStepId, result);
			int num = this.CurrentlyExecutingStepIds.IndexOf(finishStepId);
			if (num >= 0)
			{
				this.CurrentlyExecutingStepIds.RemoveAt(num);
			}
			if (result == ELevelAiNodeResult.Succeeded)
			{
				if (!this.HasActiveTasks())
				{
					this.OnPlanExecutionSuccessfullyFinished();
					return;
				}
			}
			else if (result == ELevelAiNodeResult.Aborted)
			{
				int num2 = this.CurrentlyAbortingStepIds.IndexOf(finishStepId);
				if (num2 >= 0)
				{
					this.CurrentlyAbortingStepIds.RemoveAt(num2);
				}
				if (!this.HasActiveTasks())
				{
					this.OnPlanAbortFinished();
					return;
				}
			}
			else
			{
				this.AbortCurrentPlan();
			}
		}

		// Token: 0x0604485C RID: 280668 RVA: 0x010E5D0C File Offset: 0x010E3F0C
		public bool NotifyEventBasedDecoratorCondition(LevelAiDecorator decorator, bool bFinalConditionValue)
		{
			if (!this.HasActivePlan())
			{
				return false;
			}
			if (!bFinalConditionValue)
			{
				decorator.PrintDescription("[NotifyEventBasedDecoratorCondition] Decorator通知RePlan", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.RePlan();
				return true;
			}
			return false;
		}

		// Token: 0x0604485D RID: 280669 RVA: 0x010E5D44 File Offset: 0x010E3F44
		private void NotifySubLevelStepFinishedIfNeeded(LevelAiPlanStepId finishedStepId, ELevelAiNodeResult result)
		{
			if (this.CurrentlyExecutingStepIds.Count == 0)
			{
				return;
			}
			LevelAiPlanLevel levelAiPlanLevel = this.CurrentPlan.Levels[finishedStepId.LevelIndex];
			LevelAiPlanStepId parentStepId = levelAiPlanLevel.ParentStepId;
			bool bFinishedLevel = result == ELevelAiNodeResult.Succeeded && finishedStepId.StepIndex == levelAiPlanLevel.Steps.Count - 1;
			if (!parentStepId.Equal(LevelAiPlanStepId.None))
			{
				LevelAiPlanStep step = this.CurrentPlan.GetStep(parentStepId);
				if (step.Node != null && step.Node.OnSubLevelStepFinished(this, parentStepId, finishedStepId, result, bFinishedLevel))
				{
					this.NotifySubLevelStepFinishedIfNeeded(parentStepId, result);
				}
			}
		}

		// Token: 0x0604485E RID: 280670 RVA: 0x010E5DD5 File Offset: 0x010E3FD5
		private void OnPlanAbortFinished()
		{
			if (this.CanLoop())
			{
				this.Status = ELevelAiPlanInstanceStatus.InProgress;
			}
			else
			{
				this.Status = ELevelAiPlanInstanceStatus.Failed;
			}
			this.ClearCurrentPlan();
		}

		// Token: 0x0604485F RID: 280671 RVA: 0x010E5DF5 File Offset: 0x010E3FF5
		private void OnPlanExecutionSuccessfullyFinished()
		{
			if (this.CanLoop())
			{
				this.Status = ELevelAiPlanInstanceStatus.InProgress;
			}
			else
			{
				this.Status = ELevelAiPlanInstanceStatus.Succeeded;
			}
			this.ClearCurrentPlan();
		}

		// Token: 0x06044860 RID: 280672 RVA: 0x010E5E18 File Offset: 0x010E4018
		private void InitializeCurrentPlan(LevelAiPlan newPlan)
		{
			if (this.CurrentPlan != null)
			{
				Log.Instance.Error(ELogModule.LevelAi, ELogAuthor.CJH, "[OnPlanningTaskFinished] 初始化规划失败，当前规划正在运行", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.CurrentPlan = newPlan;
			foreach (LevelAiPlanLevel levelAiPlanLevel in this.CurrentPlan.Levels)
			{
				foreach (LevelAiPlanStep levelAiPlanStep in levelAiPlanLevel.Steps)
				{
					levelAiPlanStep.SubNodesInfo.SubDecorators.Clear();
					foreach (LevelAiDecorator item in levelAiPlanStep.Node.Decorators)
					{
						levelAiPlanStep.SubNodesInfo.SubDecorators.Add(item);
					}
				}
			}
		}

		// Token: 0x06044861 RID: 280673 RVA: 0x010E5F38 File Offset: 0x010E4138
		private void ClearCurrentPlan()
		{
			if (this.CurrentPlan != null)
			{
				foreach (LevelAiPlanLevel levelAiPlanLevel in this.CurrentPlan.Levels)
				{
					foreach (LevelAiPlanStep levelAiPlanStep in levelAiPlanLevel.Steps)
					{
						levelAiPlanStep.SubNodesInfo.SubDecorators.Clear();
					}
				}
				this.CurrentPlan = null;
			}
			this.CurrentlyExecutingStepIds.Clear();
			this.PendingExecutionStepIds.Clear();
			this.CurrentlyAbortingStepIds.Clear();
			this.CurrentPlanStartedExecution = false;
		}

		// Token: 0x06044862 RID: 280674 RVA: 0x010E6008 File Offset: 0x010E4208
		private LevelAiTask GetTaskInCurrentPlan(LevelAiPlanStepId executingStepId)
		{
			return this.CurrentPlan.GetStep(executingStepId).Node as LevelAiTask;
		}

		// Token: 0x06044863 RID: 280675 RVA: 0x010E6020 File Offset: 0x010E4220
		private int GetNextStepsInCurrentPlan(List<LevelAiPlanStepId> outStepIds, LevelAiPlanStepId stepId, bool bIsExecutingPlan = true)
		{
			GetNextStepsContext getNextStepsContext = new GetNextStepsContext(this.CurrentPlan, bIsExecutingPlan, outStepIds);
			getNextStepsContext.AddNextStepsAfter(stepId);
			return getNextStepsContext.GetNumSubmittedSteps();
		}

		// Token: 0x06044864 RID: 280676 RVA: 0x010E603C File Offset: 0x010E423C
		private void GetSubNodesInCurrentPlanToStart(List<SubNodesInfo> outSubNodesInfoGroup, LevelAiPlanStepId stepId)
		{
			if (this.CurrentPlan == null || !this.CurrentPlan.HasStep(stepId, 0))
			{
				return;
			}
			LevelAiPlanStepId levelAiPlanStepId = stepId;
			for (;;)
			{
				LevelAiPlanLevel levelAiPlanLevel = this.CurrentPlan.Levels[levelAiPlanStepId.LevelIndex];
				LevelAiPlanStep levelAiPlanStep = levelAiPlanLevel.Steps[levelAiPlanStepId.StepIndex];
				if (levelAiPlanStep.SubNodesInfo.SubNodesExecuting)
				{
					break;
				}
				outSubNodesInfoGroup.Add(levelAiPlanStep.SubNodesInfo);
				if (levelAiPlanStepId.LevelIndex <= 0)
				{
					break;
				}
				levelAiPlanStepId = levelAiPlanLevel.ParentStepId;
			}
		}

		// Token: 0x06044865 RID: 280677 RVA: 0x010E60B8 File Offset: 0x010E42B8
		private void GetSubNodesInCurrentPlanToTick(List<SubNodesInfo> outSubNodesInfoGroup, LevelAiPlanStepId stepId)
		{
			if (this.CurrentPlan == null || !this.CurrentPlan.HasStep(stepId, 0))
			{
				return;
			}
			LevelAiPlanStepId levelAiPlanStepId = stepId;
			for (;;)
			{
				LevelAiPlanLevel levelAiPlanLevel = this.CurrentPlan.Levels[levelAiPlanStepId.LevelIndex];
				LevelAiPlanStep levelAiPlanStep = levelAiPlanLevel.Steps[levelAiPlanStepId.StepIndex];
				if (levelAiPlanStep.SubNodesInfo.LastFrameSubNodesTicked == Time.Instance.Frame)
				{
					break;
				}
				outSubNodesInfoGroup.Add(levelAiPlanStep.SubNodesInfo);
				if (levelAiPlanStepId.LevelIndex <= 0)
				{
					break;
				}
				levelAiPlanStepId = levelAiPlanLevel.ParentStepId;
			}
		}

		// Token: 0x06044866 RID: 280678 RVA: 0x010E6140 File Offset: 0x010E4340
		private void GetSubNodesInCurrentPlanToFinish(List<SubNodesInfo> outSubNodesInfoGroup, LevelAiPlanStepId stepId)
		{
			if (this.CurrentPlan == null || !this.CurrentPlan.HasStep(stepId, 0))
			{
				return;
			}
			LevelAiPlanStepId levelAiPlanStepId = stepId;
			for (;;)
			{
				LevelAiPlanLevel levelAiPlanLevel = this.CurrentPlan.Levels[levelAiPlanStepId.LevelIndex];
				LevelAiPlanStep levelAiPlanStep = levelAiPlanLevel.Steps[levelAiPlanStepId.StepIndex];
				if (!levelAiPlanStep.SubNodesInfo.SubNodesExecuting)
				{
					break;
				}
				outSubNodesInfoGroup.Add(levelAiPlanStep.SubNodesInfo);
				bool flag = true;
				foreach (LevelAiPlanStepId levelAiPlanStepId2 in this.PendingExecutionStepIds)
				{
					if ((levelAiPlanStepId2.LevelIndex != levelAiPlanStepId.LevelIndex || levelAiPlanStepId2.StepIndex > levelAiPlanStepId.StepIndex) && this.CurrentPlan.HasStep(levelAiPlanStepId2, levelAiPlanStepId.LevelIndex))
					{
						flag = false;
					}
				}
				if (!flag || levelAiPlanStepId.LevelIndex <= 0)
				{
					break;
				}
				levelAiPlanStepId = levelAiPlanLevel.ParentStepId;
			}
		}

		// Token: 0x06044867 RID: 280679 RVA: 0x010E623C File Offset: 0x010E443C
		private void GetSubNodesInCurrentPlanToAbort(List<SubNodesInfo> outSubNodesInfoGroup, LevelAiPlanStepId stepId)
		{
			if (this.CurrentPlan == null || !this.CurrentPlan.HasStep(stepId, 0))
			{
				return;
			}
			LevelAiPlanStepId levelAiPlanStepId = stepId;
			for (;;)
			{
				LevelAiPlanLevel levelAiPlanLevel = this.CurrentPlan.Levels[levelAiPlanStepId.LevelIndex];
				LevelAiPlanStep levelAiPlanStep = levelAiPlanLevel.Steps[levelAiPlanStepId.StepIndex];
				if (!levelAiPlanStep.SubNodesInfo.SubNodesExecuting)
				{
					break;
				}
				outSubNodesInfoGroup.Add(levelAiPlanStep.SubNodesInfo);
				if (levelAiPlanStepId.LevelIndex <= 0)
				{
					break;
				}
				levelAiPlanStepId = levelAiPlanLevel.ParentStepId;
			}
		}

		// Token: 0x06044868 RID: 280680 RVA: 0x010E62B8 File Offset: 0x010E44B8
		private bool CheckConditionsOfDecorators(SubNodesInfo subNodesInfo, ELevelAiDecoratorCheckType checkType)
		{
			if (this.CurrentPlan == null)
			{
				return false;
			}
			using (List<LevelAiDecorator>.Enumerator enumerator = subNodesInfo.SubDecorators.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.WrappedCheckCondition(checkType) == ELevelAiDecoratorCheckResult.Failed)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06044869 RID: 280681 RVA: 0x010E631C File Offset: 0x010E451C
		private void StartSubNodesInSubNodeGroup(SubNodesInfo subNodesInfo)
		{
			if (subNodesInfo.SubNodesExecuting)
			{
				Log.Instance.Error(ELogModule.LevelAi, ELogAuthor.CJH, "[StartSubNodesInSubNodeGroup] 错误的调用，子节点执行中", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			subNodesInfo.SubNodesExecuting = true;
			foreach (LevelAiDecorator subNode in subNodesInfo.SubDecorators)
			{
				LevelAiPlanInstance.<StartSubNodesInSubNodeGroup>g__startExecution|47_0(subNode);
			}
		}

		// Token: 0x0604486A RID: 280682 RVA: 0x010E6398 File Offset: 0x010E4598
		private void FinishSubNodesAtPlanStep(LevelAiPlanStepId planStepId, ELevelAiNodeResult result)
		{
			List<SubNodesInfo> list = new List<SubNodesInfo>();
			switch (result)
			{
			case ELevelAiNodeResult.Succeeded:
				this.GetSubNodesInCurrentPlanToFinish(list, planStepId);
				break;
			case ELevelAiNodeResult.Failed:
			case ELevelAiNodeResult.Aborted:
				this.GetSubNodesInCurrentPlanToAbort(list, planStepId);
				break;
			case ELevelAiNodeResult.InProgress:
				Log.Instance.Error(ELogModule.LevelAi, ELogAuthor.CJH, "[FinishSubNodesAtPlanStep] 错误的调用，结束时节点状态为InProgress", default(ReadOnlySpan<ValueTuple<string, object>>));
				break;
			}
			foreach (SubNodesInfo subNodesInfo in list)
			{
				this.FinishSubNodesInSubNodeGroup(subNodesInfo, result);
			}
		}

		// Token: 0x0604486B RID: 280683 RVA: 0x010E6438 File Offset: 0x010E4638
		private void FinishSubNodesInSubNodeGroup(SubNodesInfo subNodesInfo, ELevelAiNodeResult result)
		{
			LevelAiPlanInstance.<>c__DisplayClass49_0 CS$<>8__locals1;
			CS$<>8__locals1.result = result;
			if (!subNodesInfo.SubNodesExecuting)
			{
				Log.Instance.Error(ELogModule.LevelAi, ELogAuthor.CJH, "[FinishSubNodesInSubNodeGroup] 错误的调用，子节点非执行中", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			subNodesInfo.SubNodesExecuting = false;
			List<LevelAiDecorator> subDecorators = subNodesInfo.SubDecorators;
			for (int i = subDecorators.Count - 1; i >= 0; i--)
			{
				LevelAiPlanInstance.<FinishSubNodesInSubNodeGroup>g__finishExecution|49_0(subDecorators[i], ref CS$<>8__locals1);
			}
		}

		// Token: 0x0604486C RID: 280684 RVA: 0x010E64A4 File Offset: 0x010E46A4
		[return: Nullable(2)]
		public ActiveTaskInfo FindActiveTaskInfo(LevelAiTask task)
		{
			if (!this.HasActivePlan())
			{
				return null;
			}
			LevelAiPlanStepId levelAiPlanStepId = this.CurrentlyExecutingStepIds.FirstOrDefault((LevelAiPlanStepId value) => task == this.GetTaskInCurrentPlan(value));
			if (levelAiPlanStepId != null)
			{
				return new ActiveTaskInfo
				{
					PlanInstance = this,
					PlanStepId = levelAiPlanStepId
				};
			}
			levelAiPlanStepId = this.CurrentlyAbortingStepIds.FirstOrDefault((LevelAiPlanStepId value) => task == this.GetTaskInCurrentPlan(value));
			if (levelAiPlanStepId != null)
			{
				return new ActiveTaskInfo
				{
					PlanInstance = this,
					PlanStepId = levelAiPlanStepId
				};
			}
			return null;
		}

		// Token: 0x0604486D RID: 280685 RVA: 0x010E6530 File Offset: 0x010E4730
		[return: Nullable(2)]
		public ActiveTaskInfo FindActiveDecoratorInfo(LevelAiDecorator decorator)
		{
			LevelAiPlanInstance.<>c__DisplayClass51_0 CS$<>8__locals1 = new LevelAiPlanInstance.<>c__DisplayClass51_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.decorator = decorator;
			if (!this.HasActivePlan())
			{
				return null;
			}
			CS$<>8__locals1.subNodesInfoGroup = new List<SubNodesInfo>();
			LevelAiPlanStepId levelAiPlanStepId = this.CurrentlyExecutingStepIds.FirstOrDefault(new Func<LevelAiPlanStepId, bool>(CS$<>8__locals1.<FindActiveDecoratorInfo>g__findDecorator|0));
			if (levelAiPlanStepId != null)
			{
				return new ActiveTaskInfo
				{
					PlanInstance = this,
					PlanStepId = levelAiPlanStepId
				};
			}
			levelAiPlanStepId = this.CurrentlyAbortingStepIds.FirstOrDefault(new Func<LevelAiPlanStepId, bool>(CS$<>8__locals1.<FindActiveDecoratorInfo>g__findDecorator|0));
			if (levelAiPlanStepId != null)
			{
				return new ActiveTaskInfo
				{
					PlanInstance = this,
					PlanStepId = levelAiPlanStepId
				};
			}
			return null;
		}

		// Token: 0x0604486E RID: 280686 RVA: 0x010E65C7 File Offset: 0x010E47C7
		private bool CanReuseSavedPlan()
		{
			return this.SavedPlan != null;
		}

		// Token: 0x06044870 RID: 280688 RVA: 0x010E6602 File Offset: 0x010E4802
		[CompilerGenerated]
		private bool <TickCurrentPlan>g__updateAtPlanStep|30_0(LevelAiPlanStepId planStepId, ref LevelAiPlanInstance.<>c__DisplayClass30_0 A_2)
		{
			if (!this.UpdateSubNodes(planStepId, true, false))
			{
				this.AbortCurrentPlan();
				return false;
			}
			this.GetTaskInCurrentPlan(planStepId).WrappedTickTask(A_2.deltaTime);
			return true;
		}

		// Token: 0x06044871 RID: 280689 RVA: 0x010E662A File Offset: 0x010E482A
		[CompilerGenerated]
		internal static void <StartSubNodesInSubNodeGroup>g__startExecution|47_0(LevelAiDecorator subNode)
		{
			if (subNode != null)
			{
				subNode.WrappedExecutionStart();
			}
		}

		// Token: 0x06044872 RID: 280690 RVA: 0x010E6635 File Offset: 0x010E4835
		[CompilerGenerated]
		internal static void <FinishSubNodesInSubNodeGroup>g__finishExecution|49_0(LevelAiDecorator subNode, ref LevelAiPlanInstance.<>c__DisplayClass49_0 A_1)
		{
			if (subNode != null)
			{
				subNode.WrappedExecutionFinish(A_1.result);
			}
		}

		// Token: 0x04023A26 RID: 145958
		private ELevelAiPlanInstanceStatus Status;

		// Token: 0x04023A27 RID: 145959
		[Nullable(2)]
		private CharacterPlanComponent OwnerComponent;

		// Token: 0x04023A28 RID: 145960
		private readonly List<LevelAiPlanStepId> CurrentlyExecutingStepIds = new List<LevelAiPlanStepId>();

		// Token: 0x04023A29 RID: 145961
		private readonly List<LevelAiPlanStepId> PendingExecutionStepIds = new List<LevelAiPlanStepId>();

		// Token: 0x04023A2A RID: 145962
		private readonly List<LevelAiPlanStepId> CurrentlyAbortingStepIds = new List<LevelAiPlanStepId>();

		// Token: 0x04023A2B RID: 145963
		[Nullable(2)]
		private LevelAiPlan CurrentPlan;

		// Token: 0x04023A2C RID: 145964
		[Nullable(2)]
		private LevelAiPlanner CurrentPlanner;

		// Token: 0x04023A2D RID: 145965
		private bool CurrentPlanStartedExecution;

		// Token: 0x04023A2E RID: 145966
		private readonly bool Loop = true;

		// Token: 0x04023A2F RID: 145967
		[Nullable(2)]
		private LevelAiPlan SavedPlan;
	}
}
