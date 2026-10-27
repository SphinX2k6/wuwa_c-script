using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001B52 RID: 6994
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDailyInStageState : FloroRanchStateBase
{
	// Token: 0x0600CF82 RID: 53122 RVA: 0x002F4326 File Offset: 0x002F2526
	public FloroRanchDailyInStageState(FloroRanchStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x0600CF83 RID: 53123 RVA: 0x002F433C File Offset: 0x002F253C
	protected override void OnEnter()
	{
		List<FloroRanchPlayTask> dailyTaskList = FloroRanchGamePlayModel.Instance.GetDailyTaskList();
		this.UpdateTaskList(dailyTaskList);
		this.TryExecuteTask();
	}

	// Token: 0x0600CF84 RID: 53124 RVA: 0x002F4361 File Offset: 0x002F2561
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchNextDayTaskRefresh, new Action<IReadOnlyList<FloroRanchPlayTask>>(this.OnFloroRanchNextDayTaskRefresh));
		EventSystem.Instance.Add<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchInsertTask, new Action<IReadOnlyList<FloroRanchPlayTask>>(this.OnFloroRanchInsertTask));
	}

	// Token: 0x0600CF85 RID: 53125 RVA: 0x002F439C File Offset: 0x002F259C
	private void UpdateTaskList(IReadOnlyList<FloroRanchPlayTask> taskList)
	{
		foreach (FloroRanchPlayTask taskData in taskList)
		{
			FloroRanchDailyTaskBase item = this.CreateTask(taskData);
			this.TaskList.Add(item);
		}
	}

	// Token: 0x0600CF86 RID: 53126 RVA: 0x002F43F4 File Offset: 0x002F25F4
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

	// Token: 0x0600CF87 RID: 53127 RVA: 0x002F44C8 File Offset: 0x002F26C8
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

	// Token: 0x0600CF88 RID: 53128 RVA: 0x002F454C File Offset: 0x002F274C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFloroRanchNextDayTaskRefresh, new Action<IReadOnlyList<FloroRanchPlayTask>>(this.OnFloroRanchNextDayTaskRefresh));
		EventSystem.Instance.Remove(EEventName.OnFloroRanchInsertTask, new Action<IReadOnlyList<FloroRanchPlayTask>>(this.OnFloroRanchInsertTask));
	}

	// Token: 0x0600CF89 RID: 53129 RVA: 0x002F4586 File Offset: 0x002F2786
	protected override void OnExit()
	{
		if (this.CurrentTask != null)
		{
			this.CurrentTask.ForceFinish();
			this.CurrentTask = null;
		}
	}

	// Token: 0x0600CF8A RID: 53130 RVA: 0x002F45A4 File Offset: 0x002F27A4
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

	// Token: 0x0600CF8B RID: 53131 RVA: 0x002F4629 File Offset: 0x002F2829
	private void OnFloroRanchNextDayTaskRefresh(IReadOnlyList<FloroRanchPlayTask> taskList)
	{
		this.UpdateTaskList(taskList);
		this.TryExecuteTask();
	}

	// Token: 0x0600CF8C RID: 53132 RVA: 0x002F4638 File Offset: 0x002F2838
	private void OnFloroRanchInsertTask(IReadOnlyList<FloroRanchPlayTask> taskList)
	{
		this.InsertTaskList(taskList);
		this.TryExecuteTask();
	}

	// Token: 0x0600CF8D RID: 53133 RVA: 0x002F4647 File Offset: 0x002F2847
	private void OnDayAllTaskFinish()
	{
		FloroRanchEntityActionSystem.DayEnd();
	}

	// Token: 0x0600CF8E RID: 53134 RVA: 0x002F4650 File Offset: 0x002F2850
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

	// Token: 0x0600CF8F RID: 53135 RVA: 0x002F4717 File Offset: 0x002F2917
	public bool IsExecutingTask()
	{
		return this.CurrentTask != null;
	}

	// Token: 0x04005F72 RID: 24434
	private readonly List<FloroRanchDailyTaskBase> TaskList = new List<FloroRanchDailyTaskBase>();

	// Token: 0x04005F73 RID: 24435
	[Nullable(2)]
	private FloroRanchDailyTaskBase CurrentTask;
}
