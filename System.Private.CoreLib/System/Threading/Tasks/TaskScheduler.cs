using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x020004DD RID: 1245
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("Id = {Id}")]
	[DebuggerTypeProxy(typeof(TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView))]
	public abstract class TaskScheduler
	{
		// Token: 0x06004759 RID: 18265
		protected internal abstract void QueueTask(Task task);

		// Token: 0x0600475A RID: 18266
		protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

		// Token: 0x0600475B RID: 18267
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		protected abstract IEnumerable<Task> GetScheduledTasks();

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x000405D1 File Offset: 0x0003E7D1
		public virtual int MaximumConcurrencyLevel
		{
			get
			{
				return int.MaxValue;
			}
		}

		// Token: 0x0600475D RID: 18269 RVA: 0x000EE548 File Offset: 0x000EC748
		internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
		{
			TaskScheduler executingTaskScheduler = task.ExecutingTaskScheduler;
			if (executingTaskScheduler != this && executingTaskScheduler != null)
			{
				return executingTaskScheduler.TryRunInline(task, taskWasPreviouslyQueued);
			}
			if (executingTaskScheduler == null || task.m_action == null || task.IsDelegateInvoked || task.IsCanceled || !RuntimeHelpers.TryEnsureSufficientExecutionStack())
			{
				return false;
			}
			if (TplEventSource.Log.IsEnabled())
			{
				task.FireTaskScheduledIfNeeded(this);
			}
			bool flag = this.TryExecuteTaskInline(task, taskWasPreviouslyQueued);
			if (flag && !task.IsDelegateInvoked && !task.IsCanceled)
			{
				throw new InvalidOperationException(SR.TaskScheduler_InconsistentStateAfterTryExecuteTaskInline);
			}
			return flag;
		}

		// Token: 0x0600475E RID: 18270 RVA: 0x00007B65 File Offset: 0x00005D65
		protected internal virtual bool TryDequeue(Task task)
		{
			return false;
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		internal virtual void NotifyWorkItemProgress()
		{
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x000EE5C9 File Offset: 0x000EC7C9
		internal void InternalQueueTask(Task task)
		{
			if (TplEventSource.Log.IsEnabled())
			{
				task.FireTaskScheduledIfNeeded(this);
			}
			this.QueueTask(task);
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06004762 RID: 18274 RVA: 0x000EE5E5 File Offset: 0x000EC7E5
		public static TaskScheduler Default
		{
			get
			{
				return TaskScheduler.s_defaultTaskScheduler;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x000EE5EC File Offset: 0x000EC7EC
		public static TaskScheduler Current
		{
			get
			{
				return TaskScheduler.InternalCurrent ?? TaskScheduler.Default;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06004764 RID: 18276 RVA: 0x000EE5FC File Offset: 0x000EC7FC
		[Nullable(2)]
		internal static TaskScheduler InternalCurrent
		{
			get
			{
				Task internalCurrent = Task.InternalCurrent;
				if (internalCurrent == null || (internalCurrent.CreationOptions & TaskCreationOptions.HideScheduler) != TaskCreationOptions.None)
				{
					return null;
				}
				return internalCurrent.ExecutingTaskScheduler;
			}
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x000EE625 File Offset: 0x000EC825
		public static TaskScheduler FromCurrentSynchronizationContext()
		{
			return new SynchronizationContextTaskScheduler();
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06004766 RID: 18278 RVA: 0x000EE62C File Offset: 0x000EC82C
		public int Id
		{
			get
			{
				int taskSchedulerId = this.m_taskSchedulerId;
				if (taskSchedulerId == 0)
				{
					int num;
					do
					{
						num = Interlocked.Increment(ref TaskScheduler.s_taskSchedulerIdCounter);
					}
					while (num == 0);
					Interlocked.CompareExchange(ref this.m_taskSchedulerId, num, 0);
					taskSchedulerId = this.m_taskSchedulerId;
				}
				return taskSchedulerId;
			}
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x000EE66B File Offset: 0x000EC86B
		protected bool TryExecuteTask(Task task)
		{
			if (task.ExecutingTaskScheduler != this)
			{
				throw new InvalidOperationException(SR.TaskScheduler_ExecuteTask_WrongTaskScheduler);
			}
			return task.ExecuteEntry();
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06004768 RID: 18280 RVA: 0x000EE688 File Offset: 0x000EC888
		// (remove) Token: 0x06004769 RID: 18281 RVA: 0x000EE6BC File Offset: 0x000EC8BC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static event EventHandler<UnobservedTaskExceptionEventArgs> UnobservedTaskException;

		// Token: 0x0600476A RID: 18282 RVA: 0x000EE6EF File Offset: 0x000EC8EF
		internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea)
		{
			EventHandler<UnobservedTaskExceptionEventArgs> unobservedTaskException = TaskScheduler.UnobservedTaskException;
			if (unobservedTaskException == null)
			{
				return;
			}
			unobservedTaskException(sender, ueea);
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x000EE704 File Offset: 0x000EC904
		internal Task[] GetScheduledTasksForDebugger()
		{
			IEnumerable<Task> scheduledTasks = this.GetScheduledTasks();
			if (scheduledTasks == null)
			{
				return null;
			}
			Task[] array = scheduledTasks as Task[];
			if (array == null)
			{
				array = new List<Task>(scheduledTasks).ToArray();
			}
			Task[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				int id = array2[i].Id;
			}
			return array;
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x000EE750 File Offset: 0x000EC950
		internal static TaskScheduler[] GetTaskSchedulersForDebugger()
		{
			if (TaskScheduler.s_activeTaskSchedulers == null)
			{
				return new TaskScheduler[]
				{
					TaskScheduler.s_defaultTaskScheduler
				};
			}
			List<TaskScheduler> list = new List<TaskScheduler>();
			foreach (KeyValuePair<TaskScheduler, object> keyValuePair in ((IEnumerable<KeyValuePair<TaskScheduler, object>>)TaskScheduler.s_activeTaskSchedulers))
			{
				list.Add(keyValuePair.Key);
			}
			if (!list.Contains(TaskScheduler.s_defaultTaskScheduler))
			{
				list.Add(TaskScheduler.s_defaultTaskScheduler);
			}
			TaskScheduler[] array = list.ToArray();
			TaskScheduler[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				int id = array2[i].Id;
			}
			return array;
		}

		// Token: 0x040010B5 RID: 4277
		private static ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers;

		// Token: 0x040010B6 RID: 4278
		private static readonly TaskScheduler s_defaultTaskScheduler = new ThreadPoolTaskScheduler();

		// Token: 0x040010B7 RID: 4279
		internal static int s_taskSchedulerIdCounter;

		// Token: 0x040010B8 RID: 4280
		private volatile int m_taskSchedulerId;

		// Token: 0x020004DE RID: 1246
		internal sealed class SystemThreadingTasks_TaskSchedulerDebugView
		{
			// Token: 0x0600476E RID: 18286 RVA: 0x000EE80C File Offset: 0x000ECA0C
			public SystemThreadingTasks_TaskSchedulerDebugView(TaskScheduler scheduler)
			{
				this.m_taskScheduler = scheduler;
			}

			// Token: 0x17000CA0 RID: 3232
			// (get) Token: 0x0600476F RID: 18287 RVA: 0x000EE81B File Offset: 0x000ECA1B
			public int Id
			{
				get
				{
					return this.m_taskScheduler.Id;
				}
			}

			// Token: 0x17000CA1 RID: 3233
			// (get) Token: 0x06004770 RID: 18288 RVA: 0x000EE828 File Offset: 0x000ECA28
			public IEnumerable<Task> ScheduledTasks
			{
				get
				{
					return this.m_taskScheduler.GetScheduledTasks();
				}
			}

			// Token: 0x040010BA RID: 4282
			private readonly TaskScheduler m_taskScheduler;
		}
	}
}
