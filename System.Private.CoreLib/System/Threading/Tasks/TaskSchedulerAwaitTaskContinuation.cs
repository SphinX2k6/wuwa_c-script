using System;

namespace System.Threading.Tasks
{
	// Token: 0x020004D3 RID: 1235
	internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x060046D2 RID: 18130 RVA: 0x000ECF5C File Offset: 0x000EB15C
		internal TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, Action action, bool flowExecutionContext) : base(action, flowExecutionContext)
		{
			this.m_scheduler = scheduler;
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x000ECF70 File Offset: 0x000EB170
		internal sealed override void Run(Task ignored, bool canInlineContinuationTask)
		{
			if (this.m_scheduler == TaskScheduler.Default)
			{
				base.Run(ignored, canInlineContinuationTask);
				return;
			}
			bool flag = canInlineContinuationTask && (TaskScheduler.InternalCurrent == this.m_scheduler || Thread.CurrentThread.IsThreadPoolThread);
			Task task = base.CreateTask(delegate(object state)
			{
				try
				{
					((Action)state)();
				}
				catch (Exception exception)
				{
					Task.ThrowAsync(exception, null);
				}
			}, this.m_action, this.m_scheduler);
			if (flag)
			{
				TaskContinuation.InlineIfPossibleOrElseQueue(task, false);
				return;
			}
			try
			{
				task.ScheduleAndStart(false);
			}
			catch (TaskSchedulerException)
			{
			}
		}

		// Token: 0x0400109E RID: 4254
		private readonly TaskScheduler m_scheduler;
	}
}
