using System;
using System.Diagnostics.Tracing;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006E5 RID: 1765
	public readonly struct YieldAwaitable
	{
		// Token: 0x06007504 RID: 29956 RVA: 0x001163C0 File Offset: 0x001145C0
		public YieldAwaitable.YieldAwaiter GetAwaiter()
		{
			return default(YieldAwaitable.YieldAwaiter);
		}

		// Token: 0x020006E6 RID: 1766
		public readonly struct YieldAwaiter : ICriticalNotifyCompletion, INotifyCompletion, IStateMachineBoxAwareAwaiter
		{
			// Token: 0x17000E66 RID: 3686
			// (get) Token: 0x06007505 RID: 29957 RVA: 0x00007B65 File Offset: 0x00005D65
			public bool IsCompleted
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06007506 RID: 29958 RVA: 0x001163D6 File Offset: 0x001145D6
			[NullableContext(1)]
			public void OnCompleted(Action continuation)
			{
				YieldAwaitable.YieldAwaiter.QueueContinuation(continuation, true);
			}

			// Token: 0x06007507 RID: 29959 RVA: 0x001163DF File Offset: 0x001145DF
			[NullableContext(1)]
			public void UnsafeOnCompleted(Action continuation)
			{
				YieldAwaitable.YieldAwaiter.QueueContinuation(continuation, false);
			}

			// Token: 0x06007508 RID: 29960 RVA: 0x001163E8 File Offset: 0x001145E8
			private static void QueueContinuation(Action continuation, bool flowContext)
			{
				ArgumentNullException.ThrowIfNull(continuation, "continuation");
				if (TplEventSource.Log.IsEnabled())
				{
					continuation = YieldAwaitable.YieldAwaiter.OutputCorrelationEtwEvent(continuation);
				}
				SynchronizationContext synchronizationContext = SynchronizationContext.Current;
				if (synchronizationContext != null && synchronizationContext.GetType() != typeof(SynchronizationContext))
				{
					synchronizationContext.Post(YieldAwaitable.YieldAwaiter.s_sendOrPostCallbackRunAction, continuation);
					return;
				}
				TaskScheduler taskScheduler = TaskScheduler.Current;
				if (taskScheduler != TaskScheduler.Default)
				{
					Task.Factory.StartNew(continuation, default(CancellationToken), TaskCreationOptions.PreferFairness, taskScheduler);
					return;
				}
				if (flowContext)
				{
					ThreadPool.QueueUserWorkItem(YieldAwaitable.YieldAwaiter.s_waitCallbackRunAction, continuation);
					return;
				}
				ThreadPool.UnsafeQueueUserWorkItem(YieldAwaitable.YieldAwaiter.s_waitCallbackRunAction, continuation);
			}

			// Token: 0x06007509 RID: 29961 RVA: 0x00116484 File Offset: 0x00114684
			void IStateMachineBoxAwareAwaiter.AwaitUnsafeOnCompleted(IAsyncStateMachineBox box)
			{
				if (TplEventSource.Log.IsEnabled())
				{
					YieldAwaitable.YieldAwaiter.QueueContinuation(box.MoveNextAction, false);
					return;
				}
				SynchronizationContext synchronizationContext = SynchronizationContext.Current;
				if (synchronizationContext != null && synchronizationContext.GetType() != typeof(SynchronizationContext))
				{
					synchronizationContext.Post(delegate(object s)
					{
						((IAsyncStateMachineBox)s).MoveNext();
					}, box);
					return;
				}
				TaskScheduler taskScheduler = TaskScheduler.Current;
				if (taskScheduler == TaskScheduler.Default)
				{
					ThreadPool.UnsafeQueueUserWorkItemInternal(box, false);
					return;
				}
				Task.Factory.StartNew(delegate(object s)
				{
					((IAsyncStateMachineBox)s).MoveNext();
				}, box, default(CancellationToken), TaskCreationOptions.PreferFairness, taskScheduler);
			}

			// Token: 0x0600750A RID: 29962 RVA: 0x00116540 File Offset: 0x00114740
			private static Action OutputCorrelationEtwEvent(Action continuation)
			{
				int num = Task.NewId();
				Task internalCurrent = Task.InternalCurrent;
				TplEventSource.Log.AwaitTaskContinuationScheduled(TaskScheduler.Current.Id, (internalCurrent != null) ? internalCurrent.Id : 0, num);
				return AsyncMethodBuilderCore.CreateContinuationWrapper(continuation, delegate(Action innerContinuation, Task continuationIdTask)
				{
					TplEventSource log = TplEventSource.Log;
					log.TaskWaitContinuationStarted(((Task<int>)continuationIdTask).Result);
					Guid currentThreadActivityId = default(Guid);
					if (log.TasksSetActivityIds)
					{
						EventSource.SetCurrentThreadActivityId(TplEventSource.CreateGuidForTaskID(((Task<int>)continuationIdTask).Result), out currentThreadActivityId);
					}
					innerContinuation();
					if (log.TasksSetActivityIds)
					{
						EventSource.SetCurrentThreadActivityId(currentThreadActivityId);
					}
					log.TaskWaitContinuationComplete(((Task<int>)continuationIdTask).Result);
				}, Task.FromResult<int>(num));
			}

			// Token: 0x0600750B RID: 29963 RVA: 0x001165A5 File Offset: 0x001147A5
			private static void RunAction(object state)
			{
				((Action)state)();
			}

			// Token: 0x0600750C RID: 29964 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public void GetResult()
			{
			}

			// Token: 0x0400150C RID: 5388
			private static readonly WaitCallback s_waitCallbackRunAction = new WaitCallback(YieldAwaitable.YieldAwaiter.RunAction);

			// Token: 0x0400150D RID: 5389
			private static readonly SendOrPostCallback s_sendOrPostCallbackRunAction = new SendOrPostCallback(YieldAwaitable.YieldAwaiter.RunAction);
		}
	}
}
