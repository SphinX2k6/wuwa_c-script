using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x020004D5 RID: 1237
	internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem
	{
		// Token: 0x060046D7 RID: 18135 RVA: 0x000ED04C File Offset: 0x000EB24C
		internal AwaitTaskContinuation(Action action, bool flowExecutionContext)
		{
			this.m_action = action;
			if (flowExecutionContext)
			{
				this.m_capturedContext = ExecutionContext.Capture();
			}
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x000ED06C File Offset: 0x000EB26C
		protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler)
		{
			return new Task(action, state, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.QueuedByRuntime, scheduler)
			{
				CapturedContext = this.m_capturedContext
			};
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x000ED0A0 File Offset: 0x000EB2A0
		internal override void Run(Task task, bool canInlineContinuationTask)
		{
			if (canInlineContinuationTask && AwaitTaskContinuation.IsValidLocationForInlining)
			{
				this.RunCallback(AwaitTaskContinuation.GetInvokeActionCallback(), this.m_action, ref Task.t_currentTask);
				return;
			}
			TplEventSource log = TplEventSource.Log;
			if (log.IsEnabled())
			{
				this.m_continuationId = Task.NewId();
				log.AwaitTaskContinuationScheduled((task.ExecutingTaskScheduler ?? TaskScheduler.Default).Id, task.Id, this.m_continuationId);
			}
			ThreadPool.UnsafeQueueUserWorkItemInternal(this, true);
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x000ED114 File Offset: 0x000EB314
		internal static bool IsValidLocationForInlining
		{
			get
			{
				SynchronizationContext synchronizationContext = SynchronizationContext.Current;
				if (synchronizationContext != null && synchronizationContext.GetType() != typeof(SynchronizationContext))
				{
					return false;
				}
				TaskScheduler internalCurrent = TaskScheduler.InternalCurrent;
				return internalCurrent == null || internalCurrent == TaskScheduler.Default;
			}
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x000ED158 File Offset: 0x000EB358
		void IThreadPoolWorkItem.Execute()
		{
			TplEventSource log = TplEventSource.Log;
			ExecutionContext capturedContext = this.m_capturedContext;
			if (!log.IsEnabled() && capturedContext == null)
			{
				this.m_action();
				return;
			}
			Guid currentThreadActivityId = default(Guid);
			if (log.IsEnabled() && log.TasksSetActivityIds && this.m_continuationId != 0)
			{
				EventSource.SetCurrentThreadActivityId(TplEventSource.CreateGuidForTaskID(this.m_continuationId), out currentThreadActivityId);
			}
			try
			{
				if (capturedContext == null || capturedContext.IsDefault)
				{
					this.m_action();
				}
				else
				{
					ExecutionContext.RunForThreadPoolUnsafe<Action>(capturedContext, AwaitTaskContinuation.s_invokeAction, this.m_action);
				}
			}
			finally
			{
				if (log.IsEnabled() && log.TasksSetActivityIds && this.m_continuationId != 0)
				{
					EventSource.SetCurrentThreadActivityId(currentThreadActivityId);
				}
			}
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x000ED218 File Offset: 0x000EB418
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected static ContextCallback GetInvokeActionCallback()
		{
			return AwaitTaskContinuation.s_invokeContextCallback;
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x000ED220 File Offset: 0x000EB420
		protected void RunCallback(ContextCallback callback, object state, ref Task currentTask)
		{
			Task task = currentTask;
			try
			{
				if (task != null)
				{
					currentTask = null;
				}
				ExecutionContext capturedContext = this.m_capturedContext;
				if (capturedContext == null)
				{
					callback(state);
				}
				else
				{
					ExecutionContext.RunInternal(capturedContext, callback, state);
				}
			}
			catch (Exception exception)
			{
				Task.ThrowAsync(exception, null);
			}
			finally
			{
				if (task != null)
				{
					currentTask = task;
				}
			}
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x000ED280 File Offset: 0x000EB480
		internal static void RunOrScheduleAction(Action action, bool allowInlining)
		{
			ref Task ptr = ref Task.t_currentTask;
			Task task = ptr;
			if (!allowInlining || !AwaitTaskContinuation.IsValidLocationForInlining)
			{
				AwaitTaskContinuation.UnsafeScheduleAction(action, task);
				return;
			}
			try
			{
				if (task != null)
				{
					ptr = null;
				}
				action();
			}
			catch (Exception exception)
			{
				Task.ThrowAsync(exception, null);
			}
			finally
			{
				if (task != null)
				{
					ptr = task;
				}
			}
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x000ED2E4 File Offset: 0x000EB4E4
		internal static void RunOrScheduleAction(IAsyncStateMachineBox box, bool allowInlining)
		{
			ref Task ptr = ref Task.t_currentTask;
			Task task = ptr;
			if (allowInlining && AwaitTaskContinuation.IsValidLocationForInlining)
			{
				try
				{
					if (task != null)
					{
						ptr = null;
					}
					box.MoveNext();
				}
				catch (Exception exception)
				{
					Task.ThrowAsync(exception, null);
				}
				finally
				{
					if (task != null)
					{
						ptr = task;
					}
				}
				return;
			}
			if (TplEventSource.Log.IsEnabled())
			{
				AwaitTaskContinuation.UnsafeScheduleAction(box.MoveNextAction, task);
				return;
			}
			ThreadPool.UnsafeQueueUserWorkItemInternal(box, true);
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x000ED360 File Offset: 0x000EB560
		internal static void UnsafeScheduleAction(Action action, Task task)
		{
			AwaitTaskContinuation awaitTaskContinuation = new AwaitTaskContinuation(action, false);
			TplEventSource log = TplEventSource.Log;
			if (log.IsEnabled() && task != null)
			{
				awaitTaskContinuation.m_continuationId = Task.NewId();
				log.AwaitTaskContinuationScheduled((task.ExecutingTaskScheduler ?? TaskScheduler.Default).Id, task.Id, awaitTaskContinuation.m_continuationId);
			}
			ThreadPool.UnsafeQueueUserWorkItemInternal(awaitTaskContinuation, true);
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x000ED3BE File Offset: 0x000EB5BE
		internal override Delegate[] GetDelegateContinuationsForDebugger()
		{
			return new Delegate[]
			{
				AsyncMethodBuilderCore.TryGetStateMachineForDebugger(this.m_action)
			};
		}

		// Token: 0x040010A1 RID: 4257
		private readonly ExecutionContext m_capturedContext;

		// Token: 0x040010A2 RID: 4258
		protected readonly Action m_action;

		// Token: 0x040010A3 RID: 4259
		protected int m_continuationId;

		// Token: 0x040010A4 RID: 4260
		private static readonly ContextCallback s_invokeContextCallback = delegate(object state)
		{
			((Action)state)();
		};

		// Token: 0x040010A5 RID: 4261
		private static readonly Action<Action> s_invokeAction = delegate(Action action)
		{
			action();
		};
	}
}
