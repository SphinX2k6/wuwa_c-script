using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001011 RID: 4113
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDailyInStageState : FloroRanchStateBase
{
	// Token: 0x0600A393 RID: 41875 RVA: 0x002FF3FE File Offset: 0x002FD5FE
	public FloroRanchDailyInStageState(FloroRanchStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x0600A394 RID: 41876 RVA: 0x002FF414 File Offset: 0x002FD614
	protected override void OnEnter()
	{
		List<FloroRanchPlayTask> dailyTaskList = FloroRanchGamePlayModel.Instance.GetDailyTaskList();
		this.UpdateTaskList(dailyTaskList);
		this.TryExecuteTask();
	}

	// Token: 0x0600A395 RID: 41877 RVA: 0x002FF439 File Offset: 0x002FD639
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchNextDayTaskRefresh, new Action<IReadOnlyList<FloroRanchPlayTask>>(this.OnFloroRanchNextDayTaskRefresh));
		EventSystem.Instance.Add<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchInsertTask, new Action<IReadOnlyList<FloroRanchPlayTask>>(this.OnFloroRanchInsertTask));
	}

	// Token: 0x0600A396 RID: 41878 RVA: 0x002FF474 File Offset: 0x002FD674
	private void UpdateTaskList(IReadOnlyList<FloroRanchPlayTask> taskList)
	{
		foreach (FloroRanchPlayTask taskData in taskList)
		{
			FloroRanchDailyTaskBase item = this.CreateTask(taskData);
			this.TaskList.Add(item);
		}
	}

	// Token: 0x0600A397 RID: 41879 RVA: 0x002FF4CC File Offset: 0x002FD6CC
	private void InsertTaskList(IReadOnlyList<FloroRanchPlayTask> taskList)
	{
		List<FloroRanchDailyTaskBase> list = new List<FloroRanchDailyTaskBase>();
		foreach (FloroRanchPlayTask taskData in taskList)
		{
			FloroRanchDailyTaskBase item = this.CreateTask(taskData);
			list.Add(item);
		}
		list.Reverse();
		foreach (FloroRanchDailyTaskBase item2 in list)
		{
			this.TaskList.Insert(0, item2);
		}
		if (list.Count > 0)
		{
			if (this.CurrentTask != null && !this.CurrentTask.IsPause)
			{
				this.CurrentTask.Pause();
			}
			this.CurrentTask = null;
		}
	}

	// Token: 0x0600A398 RID: 41880 RVA: 0x002FF5A0 File Offset: 0x002FD7A0
	private void TryExecuteTask()
	{
		if (!this.IsActive)
		{
			return;
		}
		if (this.CurrentTask != null)
		{
			return;
		}
		int count = this.TaskList.Count;
		this.CurrentTask = ((count > 0) ? this.TaskList[0] : null);
		if (this.CurrentTask == null)
		{
			this.OnDayAllTaskFinish();
			return;
		}
		if (this.CurrentTask.IsPause)
		{
			this.CurrentTask.Resume();
			return;
		}
		if (!this.CurrentTask.IsExecuting)
		{
			this.CurrentTask.Execute();
		}
	}

	// Token: 0x0600A399 RID: 41881 RVA: 0x002FF624 File Offset: 0x002FD824
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFloroRanchNextDayTaskRefresh, new Action<IReadOnlyList<FloroRanchPlayTask>>(this.OnFloroRanchNextDayTaskRefresh));
		EventSystem.Instance.Remove(EEventName.OnFloroRanchInsertTask, new Action<IReadOnlyList<FloroRanchPlayTask>>(this.OnFloroRanchInsertTask));
	}

	// Token: 0x0600A39A RID: 41882 RVA: 0x002FF65E File Offset: 0x002FD85E
	protected override void OnExit()
	{
		if (this.CurrentTask != null)
		{
			this.CurrentTask.ForceFinish();
			this.CurrentTask = null;
		}
	}

	// Token: 0x0600A39B RID: 41883 RVA: 0x002FF67C File Offset: 0x002FD87C
	private void OnTaskFinish(int taskId, Action preExcuteNextCallback)
	{
		if (this.CurrentTask == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "OnTaskFinish 当前任务不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.CurrentTask.TaskId != taskId)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "OnTaskFinish 任务id不匹配", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.TaskList.RemoveAt(0);
		this.CurrentTask = null;
		if (preExcuteNextCallback != null)
		{
			preExcuteNextCallback();
		}
		this.TryExecuteTask();
	}

	// Token: 0x0600A39C RID: 41884 RVA: 0x002FF701 File Offset: 0x002FD901
	private void OnFloroRanchNextDayTaskRefresh(IReadOnlyList<FloroRanchPlayTask> taskList)
	{
		this.UpdateTaskList(taskList);
		this.TryExecuteTask();
	}

	// Token: 0x0600A39D RID: 41885 RVA: 0x002FF710 File Offset: 0x002FD910
	private void OnFloroRanchInsertTask(IReadOnlyList<FloroRanchPlayTask> taskList)
	{
		this.InsertTaskList(taskList);
		this.TryExecuteTask();
	}

	// Token: 0x0600A39E RID: 41886 RVA: 0x002FF71F File Offset: 0x002FD91F
	private void OnDayAllTaskFinish()
	{
		FloroRanchEntityActionSystem.DayEnd();
	}

	// Token: 0x0600A39F RID: 41887 RVA: 0x002FF728 File Offset: 0x002FD928
	private FloroRanchDailyTaskBase CreateTask(FloroRanchPlayTask taskData)
	{
		FloroRanchDailyTaskBase floroRanchDailyTaskBase;
		switch (taskData.TaskType)
		{
		case FloroRanchPlayTaskType.DayStart:
			floroRanchDailyTaskBase = new FloroRanchDayStartTask(taskData.DayStart);
			break;
		case FloroRanchPlayTaskType.DaySettleActions:
			floroRanchDailyTaskBase = new FloroRanchDayActionSettleTask(taskData.UnitActions);
			break;
		case FloroRanchPlayTaskType.Event:
			floroRanchDailyTaskBase = new FloroRanchRandomEventTask(taskData.FloroRanchPlayEvent);
			break;
		case FloroRanchPlayTaskType.Shop:
			floroRanchDailyTaskBase = new FloroRanchShopTask(taskData.Shop);
			break;
		case FloroRanchPlayTaskType.Gacha:
			floroRanchDailyTaskBase = new FloroRanchGachaTask(taskData.Gacha);
			break;
		case FloroRanchPlayTaskType.StageStart:
			floroRanchDailyTaskBase = new FloroRanchStageStartTask(taskData.StageStart);
			break;
		case FloroRanchPlayTaskType.StageEnd:
			floroRanchDailyTaskBase = new FloroRanchStageEndTask(taskData.StageEnd);
			break;
		case FloroRanchPlayTaskType.WageSettleTask:
			floroRanchDailyTaskBase = new FloroRanchDaySalarySettleTask(taskData.WageSettleTask);
			break;
		default:
			floroRanchDailyTaskBase = new FloroRanchDailyTaskBase();
			break;
		}
		floroRanchDailyTaskBase.BindCompleteCallBack(new Action<int, Action>(this.OnTaskFinish));
		return floroRanchDailyTaskBase;
	}

	// Token: 0x0600A3A0 RID: 41888 RVA: 0x002FF7EF File Offset: 0x002FD9EF
	public bool IsExecutingTask()
	{
		return this.CurrentTask != null;
	}

	// Token: 0x04006041 RID: 24641
	private readonly List<FloroRanchDailyTaskBase> TaskList = new List<FloroRanchDailyTaskBase>();

	// Token: 0x04006042 RID: 24642
	[Nullable(2)]
	private FloroRanchDailyTaskBase CurrentTask;
}
