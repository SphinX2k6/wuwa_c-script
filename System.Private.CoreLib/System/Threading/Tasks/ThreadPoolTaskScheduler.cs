using System;
using System.Collections.Generic;

namespace System.Threading.Tasks
{
	// Token: 0x020004E3 RID: 1251
	internal sealed class ThreadPoolTaskScheduler : TaskScheduler
	{
		// Token: 0x06004783 RID: 18307 RVA: 0x000EE91B File Offset: 0x000ECB1B
		internal ThreadPoolTaskScheduler()
		{
			int id = base.Id;
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x000EE92C File Offset: 0x000ECB2C
		protected internal override void QueueTask(Task task)
		{
			TaskCreationOptions options = task.Options;
			if ((options & TaskCreationOptions.LongRunning) != TaskCreationOptions.None)
			{
				new Thread(ThreadPoolTaskScheduler.s_longRunningThreadWork)
				{
					IsBackground = true,
					Name = ".NET Long Running Task"
				}.UnsafeStart(task);
				return;
			}
			ThreadPool.UnsafeQueueUserWorkItemInternal(task, (options & TaskCreationOptions.PreferFairness) == TaskCreationOptions.None);
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x000EE978 File Offset: 0x000ECB78
		protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			if (taskWasPreviouslyQueued && !ThreadPool.TryPopCustomWorkItem(task))
			{
				return false;
			}
			try
			{
				task.ExecuteEntryUnsafe(null);
			}
			finally
			{
				if (taskWasPreviouslyQueued)
				{
					this.NotifyWorkItemProgress();
				}
			}
			return true;
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x000EE9B8 File Offset: 0x000ECBB8
		protected internal override bool TryDequeue(Task task)
		{
			return ThreadPool.TryPopCustomWorkItem(task);
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x000EE9C0 File Offset: 0x000ECBC0
		protected override IEnumerable<Task> GetScheduledTasks()
		{
			return ThreadPoolTaskScheduler.FilterTasksFromWorkItems(ThreadPool.GetQueuedWorkItems());
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x000EE9CC File Offset: 0x000ECBCC
		private static IEnumerable<Task> FilterTasksFromWorkItems(IEnumerable<object> tpwItems)
		{
			foreach (object obj in tpwItems)
			{
				Task task = obj as Task;
				if (task != null)
				{
					yield return task;
				}
			}
			IEnumerator<object> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x000EE9DC File Offset: 0x000ECBDC
		internal override void NotifyWorkItemProgress()
		{
			ThreadPool.NotifyWorkItemProgress();
		}

		// Token: 0x040010C0 RID: 4288
		private static readonly ParameterizedThreadStart s_longRunningThreadWork = delegate(object s)
		{
			((Task)s).ExecuteEntryUnsafe(null);
		};
	}
}
