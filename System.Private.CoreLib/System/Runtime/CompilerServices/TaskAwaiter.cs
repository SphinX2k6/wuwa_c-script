using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006D1 RID: 1745
	public readonly struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion, ITaskAwaiter
	{
		// Token: 0x0600749B RID: 29851 RVA: 0x00115ABA File Offset: 0x00113CBA
		internal TaskAwaiter(Task task)
		{
			this.m_task = task;
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x0600749C RID: 29852 RVA: 0x00115AC3 File Offset: 0x00113CC3
		public bool IsCompleted
		{
			get
			{
				return this.m_task.IsCompleted;
			}
		}

		// Token: 0x0600749D RID: 29853 RVA: 0x00115AD0 File Offset: 0x00113CD0
		[NullableContext(1)]
		public void OnCompleted(Action continuation)
		{
			TaskAwaiter.OnCompletedInternal(this.m_task, continuation, true, true);
		}

		// Token: 0x0600749E RID: 29854 RVA: 0x00115AE0 File Offset: 0x00113CE0
		[NullableContext(1)]
		public void UnsafeOnCompleted(Action continuation)
		{
			TaskAwaiter.OnCompletedInternal(this.m_task, continuation, true, false);
		}

		// Token: 0x0600749F RID: 29855 RVA: 0x00115AF0 File Offset: 0x00113CF0
		[StackTraceHidden]
		public void GetResult()
		{
			TaskAwaiter.ValidateEnd(this.m_task, ConfigureAwaitOptions.None);
		}

		// Token: 0x060074A0 RID: 29856 RVA: 0x00115AFE File Offset: 0x00113CFE
		[StackTraceHidden]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ValidateEnd(Task task, ConfigureAwaitOptions options = ConfigureAwaitOptions.None)
		{
			if (task.IsWaitNotificationEnabledOrNotRanToCompletion)
			{
				TaskAwaiter.HandleNonSuccessAndDebuggerNotification(task, options);
			}
		}

		// Token: 0x060074A1 RID: 29857 RVA: 0x00115B10 File Offset: 0x00113D10
		[StackTraceHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void HandleNonSuccessAndDebuggerNotification(Task task, ConfigureAwaitOptions options)
		{
			if (!task.IsCompleted)
			{
				task.InternalWait(-1, default(CancellationToken));
			}
			task.NotifyDebuggerOfWaitCompletionIfNecessary();
			if (!task.IsCompletedSuccessfully)
			{
				if ((options & ConfigureAwaitOptions.SuppressThrowing) == ConfigureAwaitOptions.None)
				{
					TaskAwaiter.ThrowForNonSuccess(task);
				}
				task.MarkExceptionsAsHandled();
			}
		}

		// Token: 0x060074A2 RID: 29858 RVA: 0x00115B58 File Offset: 0x00113D58
		[StackTraceHidden]
		private static void ThrowForNonSuccess(Task task)
		{
			TaskStatus status = task.Status;
			if (status == TaskStatus.Canceled)
			{
				ExceptionDispatchInfo cancellationExceptionDispatchInfo = task.GetCancellationExceptionDispatchInfo();
				if (cancellationExceptionDispatchInfo != null)
				{
					cancellationExceptionDispatchInfo.Throw();
				}
				throw new TaskCanceledException(task);
			}
			if (status != TaskStatus.Faulted)
			{
				return;
			}
			List<ExceptionDispatchInfo> exceptionDispatchInfos = task.GetExceptionDispatchInfos();
			if (exceptionDispatchInfos.Count > 0)
			{
				exceptionDispatchInfos[0].Throw();
				return;
			}
			throw task.Exception;
		}

		// Token: 0x060074A3 RID: 29859 RVA: 0x00115BAF File Offset: 0x00113DAF
		internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			ArgumentNullException.ThrowIfNull(continuation, "continuation");
			if (TplEventSource.Log.IsEnabled() || Task.s_asyncDebuggingEnabled)
			{
				continuation = TaskAwaiter.OutputWaitEtwEvents(task, continuation);
			}
			task.SetContinuationForAwait(continuation, continueOnCapturedContext, flowExecutionContext);
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x00115BE1 File Offset: 0x00113DE1
		internal static void UnsafeOnCompletedInternal(Task task, IAsyncStateMachineBox stateMachineBox, bool continueOnCapturedContext)
		{
			if (TplEventSource.Log.IsEnabled() || Task.s_asyncDebuggingEnabled)
			{
				task.SetContinuationForAwait(TaskAwaiter.OutputWaitEtwEvents(task, stateMachineBox.MoveNextAction), continueOnCapturedContext, false);
				return;
			}
			task.UnsafeSetContinuationForAwait(stateMachineBox, continueOnCapturedContext);
		}

		// Token: 0x060074A5 RID: 29861 RVA: 0x00115C14 File Offset: 0x00113E14
		private static Action OutputWaitEtwEvents(Task task, Action continuation)
		{
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(task);
			}
			TplEventSource log = TplEventSource.Log;
			if (log.IsEnabled())
			{
				Task internalCurrent = Task.InternalCurrent;
				Task task2 = AsyncMethodBuilderCore.TryGetContinuationTask(continuation);
				log.TaskWaitBegin((internalCurrent != null) ? internalCurrent.m_taskScheduler.Id : TaskScheduler.Default.Id, (internalCurrent != null) ? internalCurrent.Id : 0, task.Id, TplEventSource.TaskWaitBehavior.Asynchronous, (task2 != null) ? task2.Id : 0);
			}
			return AsyncMethodBuilderCore.CreateContinuationWrapper(continuation, delegate(Action innerContinuation, Task innerTask)
			{
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.RemoveFromActiveTasks(innerTask);
				}
				TplEventSource log2 = TplEventSource.Log;
				Guid currentThreadActivityId = default(Guid);
				bool flag = log2.IsEnabled();
				if (flag)
				{
					Task internalCurrent2 = Task.InternalCurrent;
					log2.TaskWaitEnd((internalCurrent2 != null) ? internalCurrent2.m_taskScheduler.Id : TaskScheduler.Default.Id, (internalCurrent2 != null) ? internalCurrent2.Id : 0, innerTask.Id);
					if (log2.TasksSetActivityIds && (innerTask.Options & (TaskCreationOptions)1024) != TaskCreationOptions.None)
					{
						EventSource.SetCurrentThreadActivityId(TplEventSource.CreateGuidForTaskID(innerTask.Id), out currentThreadActivityId);
					}
				}
				innerContinuation();
				if (flag)
				{
					log2.TaskWaitContinuationComplete(innerTask.Id);
					if (log2.TasksSetActivityIds && (innerTask.Options & (TaskCreationOptions)1024) != TaskCreationOptions.None)
					{
						EventSource.SetCurrentThreadActivityId(currentThreadActivityId);
					}
				}
			}, task);
		}

		// Token: 0x040014F3 RID: 5363
		internal readonly Task m_task;
	}
}
