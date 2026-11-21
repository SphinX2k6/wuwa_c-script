using System;

namespace System.Threading.Tasks
{
	// Token: 0x020004CE RID: 1230
	internal sealed class ContinueWithTaskContinuation : TaskContinuation
	{
		// Token: 0x060046C4 RID: 18116 RVA: 0x000ECC10 File Offset: 0x000EAE10
		internal ContinueWithTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler)
		{
			this.m_task = task;
			this.m_options = options;
			this.m_taskScheduler = scheduler;
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationBegin(this.m_task.Id, "Task.ContinueWith: " + task.m_action.GetMethodName(), 0L);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(this.m_task);
			}
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x000ECC84 File Offset: 0x000EAE84
		internal override void Run(Task completedTask, bool canInlineContinuationTask)
		{
			Task task = this.m_task;
			this.m_task = null;
			TaskContinuationOptions options = this.m_options;
			if (completedTask.IsCompletedSuccessfully ? ((options & TaskContinuationOptions.NotOnRanToCompletion) == TaskContinuationOptions.None) : (completedTask.IsCanceled ? ((options & TaskContinuationOptions.NotOnCanceled) == TaskContinuationOptions.None) : ((options & TaskContinuationOptions.NotOnFaulted) == TaskContinuationOptions.None)))
			{
				if (TplEventSource.Log.IsEnabled() && !task.IsCanceled)
				{
					TplEventSource.Log.TraceOperationRelation(task.Id, CausalityRelation.AssignDelegate);
				}
				task.m_taskScheduler = this.m_taskScheduler;
				if (canInlineContinuationTask && (options & TaskContinuationOptions.ExecuteSynchronously) != TaskContinuationOptions.None)
				{
					TaskContinuation.InlineIfPossibleOrElseQueue(task, true);
					return;
				}
				try
				{
					task.ScheduleAndStart(true);
					return;
				}
				catch (TaskSchedulerException)
				{
					return;
				}
			}
			Task.ContingentProperties contingentProperties = task.m_contingentProperties;
			if (contingentProperties == null || contingentProperties.m_cancellationToken == default(CancellationToken))
			{
				task.InternalCancelContinueWithInitialState();
				return;
			}
			task.InternalCancel();
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x000ECD6C File Offset: 0x000EAF6C
		internal override Delegate[] GetDelegateContinuationsForDebugger()
		{
			if (this.m_task == null)
			{
				return null;
			}
			if (this.m_task.m_action != null)
			{
				return new Delegate[]
				{
					this.m_task.m_action
				};
			}
			return this.m_task.GetDelegateContinuationsForDebugger();
		}

		// Token: 0x04001094 RID: 4244
		internal Task m_task;

		// Token: 0x04001095 RID: 4245
		internal readonly TaskContinuationOptions m_options;

		// Token: 0x04001096 RID: 4246
		private readonly TaskScheduler m_taskScheduler;
	}
}
