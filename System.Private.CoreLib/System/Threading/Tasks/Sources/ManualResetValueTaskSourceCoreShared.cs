using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x020004F8 RID: 1272
	internal static class ManualResetValueTaskSourceCoreShared
	{
		// Token: 0x0600480B RID: 18443 RVA: 0x000F02C7 File Offset: 0x000EE4C7
		private static void CompletionSentinel(object _)
		{
			ThrowHelper.ThrowInvalidOperationException();
		}

		// Token: 0x0600480C RID: 18444 RVA: 0x000F02D0 File Offset: 0x000EE4D0
		internal static void ScheduleCapturedContext(object context, Action<object> continuation, object state)
		{
			SynchronizationContext synchronizationContext = context as SynchronizationContext;
			if (synchronizationContext != null)
			{
				ManualResetValueTaskSourceCoreShared.<ScheduleCapturedContext>g__ScheduleSynchronizationContext|2_0(synchronizationContext, continuation, state);
				return;
			}
			TaskScheduler taskScheduler = context as TaskScheduler;
			if (taskScheduler != null)
			{
				ManualResetValueTaskSourceCoreShared.<ScheduleCapturedContext>g__ScheduleTaskScheduler|2_1(taskScheduler, continuation, state);
				return;
			}
			CapturedSchedulerAndExecutionContext capturedSchedulerAndExecutionContext = (CapturedSchedulerAndExecutionContext)context;
			SynchronizationContext synchronizationContext2 = capturedSchedulerAndExecutionContext._scheduler as SynchronizationContext;
			if (synchronizationContext2 != null)
			{
				ManualResetValueTaskSourceCoreShared.<ScheduleCapturedContext>g__ScheduleSynchronizationContext|2_0(synchronizationContext2, continuation, state);
				return;
			}
			ManualResetValueTaskSourceCoreShared.<ScheduleCapturedContext>g__ScheduleTaskScheduler|2_1((TaskScheduler)capturedSchedulerAndExecutionContext._scheduler, continuation, state);
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x000F0338 File Offset: 0x000EE538
		internal static void InvokeContinuationWithContext(object capturedContext, Action<object> continuation, object continuationState, bool runContinuationsAsynchronously)
		{
			ExecutionContext executionContext = ExecutionContext.CaptureForRestore();
			ExecutionContext executionContext2 = capturedContext as ExecutionContext;
			if (executionContext2 != null)
			{
				ExecutionContext.RestoreInternal(executionContext2);
				if (runContinuationsAsynchronously)
				{
					try
					{
						ThreadPool.QueueUserWorkItem<object>(continuation, continuationState, true);
						return;
					}
					finally
					{
						ExecutionContext.RestoreInternal(executionContext);
					}
				}
				ExceptionDispatchInfo exceptionDispatchInfo = null;
				SynchronizationContext synchronizationContext = SynchronizationContext.Current;
				try
				{
					continuation(continuationState);
				}
				catch (Exception source)
				{
					exceptionDispatchInfo = ExceptionDispatchInfo.Capture(source);
				}
				finally
				{
					SynchronizationContext.SetSynchronizationContext(synchronizationContext);
					ExecutionContext.RestoreInternal(executionContext);
				}
				if (exceptionDispatchInfo != null)
				{
					exceptionDispatchInfo.Throw();
					return;
				}
			}
			else
			{
				ExecutionContext.Restore(((CapturedSchedulerAndExecutionContext)capturedContext)._executionContext);
				try
				{
					ManualResetValueTaskSourceCoreShared.ScheduleCapturedContext(capturedContext, continuation, continuationState);
				}
				finally
				{
					ExecutionContext.RestoreInternal(executionContext);
				}
			}
		}

		// Token: 0x0600480F RID: 18447 RVA: 0x000F040B File Offset: 0x000EE60B
		[CompilerGenerated]
		internal static void <ScheduleCapturedContext>g__ScheduleSynchronizationContext|2_0(SynchronizationContext sc, Action<object> continuation, object state)
		{
			sc.Post(new SendOrPostCallback(continuation.Invoke), state);
		}

		// Token: 0x06004810 RID: 18448 RVA: 0x000F0420 File Offset: 0x000EE620
		[CompilerGenerated]
		internal static void <ScheduleCapturedContext>g__ScheduleTaskScheduler|2_1(TaskScheduler scheduler, Action<object> continuation, object state)
		{
			Task.Factory.StartNew(continuation, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach, scheduler);
		}

		// Token: 0x0400111B RID: 4379
		internal static readonly Action<object> s_sentinel = new Action<object>(ManualResetValueTaskSourceCoreShared.CompletionSentinel);
	}
}
