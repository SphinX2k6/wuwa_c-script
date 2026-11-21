using System;

namespace System.Threading.Tasks
{
	// Token: 0x020004CD RID: 1229
	internal abstract class TaskContinuation
	{
		// Token: 0x060046C0 RID: 18112
		internal abstract void Run(Task completedTask, bool canInlineContinuationTask);

		// Token: 0x060046C1 RID: 18113 RVA: 0x000ECB9C File Offset: 0x000EAD9C
		protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection)
		{
			if (needsProtection)
			{
				if (!task.MarkStarted())
				{
					return;
				}
			}
			else
			{
				task.m_stateFlags |= 65536;
			}
			try
			{
				if (!task.m_taskScheduler.TryRunInline(task, false))
				{
					task.m_taskScheduler.InternalQueueTask(task);
				}
			}
			catch (Exception innerException)
			{
				TaskSchedulerException exceptionObject = new TaskSchedulerException(innerException);
				task.AddException(exceptionObject);
				task.Finish(false);
			}
		}

		// Token: 0x060046C2 RID: 18114
		internal abstract Delegate[] GetDelegateContinuationsForDebugger();
	}
}
