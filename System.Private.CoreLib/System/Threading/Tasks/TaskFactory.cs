using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x0200049C RID: 1180
	[NullableContext(1)]
	[Nullable(0)]
	public class TaskFactory<[Nullable(2)] TResult>
	{
		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060044DB RID: 17627 RVA: 0x000E6265 File Offset: 0x000E4465
		private TaskScheduler DefaultScheduler
		{
			get
			{
				return this.m_defaultScheduler ?? TaskScheduler.Current;
			}
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x000E6276 File Offset: 0x000E4476
		private TaskScheduler GetDefaultScheduler(Task currTask)
		{
			if (this.m_defaultScheduler != null)
			{
				return this.m_defaultScheduler;
			}
			if (currTask != null && (currTask.CreationOptions & TaskCreationOptions.HideScheduler) == TaskCreationOptions.None)
			{
				return currTask.ExecutingTaskScheduler;
			}
			return TaskScheduler.Default;
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x00005ACC File Offset: 0x00003CCC
		public TaskFactory()
		{
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x000E62A1 File Offset: 0x000E44A1
		public TaskFactory(CancellationToken cancellationToken)
		{
			this.m_defaultCancellationToken = cancellationToken;
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x000E62B0 File Offset: 0x000E44B0
		[NullableContext(2)]
		public TaskFactory(TaskScheduler scheduler)
		{
			this.m_defaultScheduler = scheduler;
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x000E62BF File Offset: 0x000E44BF
		public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			TaskFactory.CheckCreationOptions(creationOptions);
			this.m_defaultCreationOptions = creationOptions;
			this.m_defaultContinuationOptions = continuationOptions;
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x000E62E1 File Offset: 0x000E44E1
		[NullableContext(2)]
		public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) : this(creationOptions, continuationOptions)
		{
			this.m_defaultCancellationToken = cancellationToken;
			this.m_defaultScheduler = scheduler;
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x000E62FA File Offset: 0x000E44FA
		public CancellationToken CancellationToken
		{
			get
			{
				return this.m_defaultCancellationToken;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x000E6302 File Offset: 0x000E4502
		[Nullable(2)]
		public TaskScheduler Scheduler
		{
			[NullableContext(2)]
			get
			{
				return this.m_defaultScheduler;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x000E630A File Offset: 0x000E450A
		public TaskCreationOptions CreationOptions
		{
			get
			{
				return this.m_defaultCreationOptions;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x000E6312 File Offset: 0x000E4512
		public TaskContinuationOptions ContinuationOptions
		{
			get
			{
				return this.m_defaultContinuationOptions;
			}
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x000E631C File Offset: 0x000E451C
		public Task<TResult> StartNew(Func<TResult> function)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, this.m_defaultCancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x000E634C File Offset: 0x000E454C
		public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, cancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x000E6378 File Offset: 0x000E4578
		public Task<TResult> StartNew(Func<TResult> function, TaskCreationOptions creationOptions)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, this.m_defaultCancellationToken, creationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x000E63A1 File Offset: 0x000E45A1
		public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Task<TResult>.StartNew(Task.InternalCurrentIfAttached(creationOptions), function, cancellationToken, creationOptions, InternalTaskOptions.None, scheduler);
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x000E63B4 File Offset: 0x000E45B4
		public Task<TResult> StartNew([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<object, TResult> function, [Nullable(2)] object state)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, state, this.m_defaultCancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x000E63E4 File Offset: 0x000E45E4
		public Task<TResult> StartNew([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<object, TResult> function, [Nullable(2)] object state, CancellationToken cancellationToken)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, state, cancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x000E6410 File Offset: 0x000E4610
		public Task<TResult> StartNew([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<object, TResult> function, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, state, this.m_defaultCancellationToken, creationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x000E643A File Offset: 0x000E463A
		public Task<TResult> StartNew([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<object, TResult> function, [Nullable(2)] object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Task<TResult>.StartNew(Task.InternalCurrentIfAttached(creationOptions), function, state, cancellationToken, creationOptions, InternalTaskOptions.None, scheduler);
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x000E6450 File Offset: 0x000E4650
		private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization)
		{
			Exception ex = null;
			OperationCanceledException ex2 = null;
			TResult result = default(TResult);
			try
			{
				if (endFunction != null)
				{
					result = endFunction(iar);
				}
				else
				{
					endAction(iar);
				}
			}
			catch (OperationCanceledException ex2)
			{
			}
			catch (Exception ex)
			{
			}
			finally
			{
				if (ex2 != null)
				{
					promise.TrySetCanceled(ex2.CancellationToken, ex2);
				}
				else if (ex != null)
				{
					promise.TrySetException(ex);
				}
				else
				{
					if (TplEventSource.Log.IsEnabled())
					{
						TplEventSource.Log.TraceOperationEnd(promise.Id, AsyncCausalityStatus.Completed);
					}
					if (Task.s_asyncDebuggingEnabled)
					{
						Task.RemoveFromActiveTasks(promise);
					}
					if (requiresSynchronization)
					{
						promise.TrySetResult(result);
					}
					else
					{
						promise.DangerousSetResult(result);
					}
				}
			}
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x000E6510 File Offset: 0x000E4710
		public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod)
		{
			return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, this.m_defaultCreationOptions, this.DefaultScheduler);
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x000E6526 File Offset: 0x000E4726
		public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, creationOptions, this.DefaultScheduler);
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x000E6537 File Offset: 0x000E4737
		public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, creationOptions, scheduler);
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x000E6544 File Offset: 0x000E4744
		internal static Task<TResult> FromAsyncImpl(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			if (asyncResult == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.asyncResult);
			}
			if (endFunction == null && endAction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.endMethod);
			}
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			TaskFactory.CheckFromAsyncOptions(creationOptions, false);
			Task<TResult> promise = new Task<TResult>(null, creationOptions);
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationBegin(promise.Id, "TaskFactory.FromAsync", 0L);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(promise);
			}
			Task t = new Task(new Action<object>(delegate(object <p0>)
			{
				TaskFactory<TResult>.FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, true);
			}), null, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.None, null);
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationBegin(t.Id, "TaskFactory.FromAsync Callback", 0L);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(t);
			}
			if (asyncResult.IsCompleted)
			{
				try
				{
					t.InternalRunSynchronously(scheduler, false);
					goto IL_158;
				}
				catch (Exception exceptionObject)
				{
					promise.TrySetException(exceptionObject);
					goto IL_158;
				}
			}
			ThreadPool.RegisterWaitForSingleObject(asyncResult.AsyncWaitHandle, delegate(object <p0>, bool <p1>)
			{
				try
				{
					t.InternalRunSynchronously(scheduler, false);
				}
				catch (Exception exceptionObject2)
				{
					promise.TrySetException(exceptionObject2);
				}
			}, null, -1, true);
			IL_158:
			return promise;
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x000E66C0 File Offset: 0x000E48C0
		public Task<TResult> FromAsync([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, [Nullable(2)] object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, state, this.m_defaultCreationOptions);
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x000E66D1 File Offset: 0x000E48D1
		public Task<TResult> FromAsync([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, state, creationOptions);
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x000E66E0 File Offset: 0x000E48E0
		internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions)
		{
			if (beginMethod == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.beginMethod);
			}
			if (endFunction == null && endAction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.endMethod);
			}
			TaskFactory.CheckFromAsyncOptions(creationOptions, true);
			Task<TResult> promise = new Task<TResult>(state, creationOptions);
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationBegin(promise.Id, "TaskFactory.FromAsync: " + beginMethod.GetMethodName(), 0L);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(promise);
			}
			try
			{
				IAsyncResult asyncResult = beginMethod(delegate(IAsyncResult iar)
				{
					if (!iar.CompletedSynchronously)
					{
						TaskFactory<TResult>.FromAsyncCoreLogic(iar, endFunction, endAction, promise, true);
					}
				}, state);
				if (asyncResult.CompletedSynchronously)
				{
					TaskFactory<TResult>.FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, false);
				}
			}
			catch
			{
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationEnd(promise.Id, AsyncCausalityStatus.Error);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.RemoveFromActiveTasks(promise);
				}
				promise.TrySetResult();
				throw;
			}
			return promise;
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x000E6810 File Offset: 0x000E4A10
		public Task<TResult> FromAsync<[Nullable(2)] TArg1>([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, [Nullable(2)] object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1>(beginMethod, endMethod, null, arg1, state, this.m_defaultCreationOptions);
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x000E6823 File Offset: 0x000E4A23
		public Task<TResult> FromAsync<[Nullable(2)] TArg1>([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1>(beginMethod, endMethod, null, arg1, state, creationOptions);
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x000E6834 File Offset: 0x000E4A34
		internal static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			if (beginMethod == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.beginMethod);
			}
			if (endFunction == null && endAction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.endFunction);
			}
			TaskFactory.CheckFromAsyncOptions(creationOptions, true);
			Task<TResult> promise = new Task<TResult>(state, creationOptions);
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationBegin(promise.Id, "TaskFactory.FromAsync: " + beginMethod.GetMethodName(), 0L);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(promise);
			}
			try
			{
				IAsyncResult asyncResult = beginMethod(arg1, delegate(IAsyncResult iar)
				{
					if (!iar.CompletedSynchronously)
					{
						TaskFactory<TResult>.FromAsyncCoreLogic(iar, endFunction, endAction, promise, true);
					}
				}, state);
				if (asyncResult.CompletedSynchronously)
				{
					TaskFactory<TResult>.FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, false);
				}
			}
			catch
			{
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationEnd(promise.Id, AsyncCausalityStatus.Error);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.RemoveFromActiveTasks(promise);
				}
				promise.TrySetResult();
				throw;
			}
			return promise;
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x000E6968 File Offset: 0x000E4B68
		public Task<TResult> FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TArg2>([Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, [Nullable(2)] object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2>(beginMethod, endMethod, null, arg1, arg2, state, this.m_defaultCreationOptions);
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x000E697D File Offset: 0x000E4B7D
		public Task<TResult> FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TArg2>([Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2>(beginMethod, endMethod, null, arg1, arg2, state, creationOptions);
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x000E6990 File Offset: 0x000E4B90
		internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			if (beginMethod == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.beginMethod);
			}
			if (endFunction == null && endAction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.endMethod);
			}
			TaskFactory.CheckFromAsyncOptions(creationOptions, true);
			Task<TResult> promise = new Task<TResult>(state, creationOptions);
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationBegin(promise.Id, "TaskFactory.FromAsync: " + beginMethod.GetMethodName(), 0L);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(promise);
			}
			try
			{
				IAsyncResult asyncResult = beginMethod(arg1, arg2, delegate(IAsyncResult iar)
				{
					if (!iar.CompletedSynchronously)
					{
						TaskFactory<TResult>.FromAsyncCoreLogic(iar, endFunction, endAction, promise, true);
					}
				}, state);
				if (asyncResult.CompletedSynchronously)
				{
					TaskFactory<TResult>.FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, false);
				}
			}
			catch
			{
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationEnd(promise.Id, AsyncCausalityStatus.Error);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.RemoveFromActiveTasks(promise);
				}
				promise.TrySetResult();
				throw;
			}
			return promise;
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x000E6AC4 File Offset: 0x000E4CC4
		public Task<TResult> FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TArg2, [Nullable(2)] TArg3>([Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, [Nullable(2)] object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2, TArg3>(beginMethod, endMethod, null, arg1, arg2, arg3, state, this.m_defaultCreationOptions);
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x000E6ADB File Offset: 0x000E4CDB
		public Task<TResult> FromAsync<[Nullable(2)] TArg1, [Nullable(2)] TArg2, [Nullable(2)] TArg3>([Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			2,
			1
		})] Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, [Nullable(2)] object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2, TArg3>(beginMethod, endMethod, null, arg1, arg2, arg3, state, creationOptions);
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x000E6AF0 File Offset: 0x000E4CF0
		internal static Task<TResult> FromAsyncImpl<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
		{
			if (beginMethod == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.beginMethod);
			}
			if (endFunction == null && endAction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.endMethod);
			}
			TaskFactory.CheckFromAsyncOptions(creationOptions, true);
			Task<TResult> promise = new Task<TResult>(state, creationOptions);
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationBegin(promise.Id, "TaskFactory.FromAsync: " + beginMethod.GetMethodName(), 0L);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(promise);
			}
			try
			{
				IAsyncResult asyncResult = beginMethod(arg1, arg2, arg3, delegate(IAsyncResult iar)
				{
					if (!iar.CompletedSynchronously)
					{
						TaskFactory<TResult>.FromAsyncCoreLogic(iar, endFunction, endAction, promise, true);
					}
				}, state);
				if (asyncResult.CompletedSynchronously)
				{
					TaskFactory<TResult>.FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, false);
				}
			}
			catch
			{
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationEnd(promise.Id, AsyncCausalityStatus.Error);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.RemoveFromActiveTasks(promise);
				}
				promise.TrySetResult();
				throw;
			}
			return promise;
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x000E6C28 File Offset: 0x000E4E28
		internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) where TInstance : class
		{
			TaskFactory<TResult>.FromAsyncTrimPromise<TInstance> fromAsyncTrimPromise = new TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>(thisRef, endMethod);
			IAsyncResult asyncResult = beginMethod(thisRef, args, TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.s_completeFromAsyncResult, fromAsyncTrimPromise);
			if (asyncResult.CompletedSynchronously)
			{
				fromAsyncTrimPromise.Complete(thisRef, endMethod, asyncResult, false);
			}
			return fromAsyncTrimPromise;
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x000E6C60 File Offset: 0x000E4E60
		private static Task<TResult> CreateCanceledTask(TaskContinuationOptions continuationOptions, CancellationToken ct)
		{
			TaskCreationOptions creationOptions;
			InternalTaskOptions internalTaskOptions;
			Task.CreationOptionsFromContinuationOptions(continuationOptions, out creationOptions, out internalTaskOptions);
			return new Task<TResult>(true, default(TResult), creationOptions, ct);
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x000E6C88 File Offset: 0x000E4E88
		public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x000E6CAE File Offset: 0x000E4EAE
		public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x000E6CCF File Offset: 0x000E4ECF
		public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x000E6CF0 File Offset: 0x000E4EF0
		public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x000E6D09 File Offset: 0x000E4F09
		public Task<TResult> ContinueWhenAll<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, null, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x000E6D2F File Offset: 0x000E4F2F
		public Task<TResult> ContinueWhenAll<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, null, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x000E6D50 File Offset: 0x000E4F50
		public Task<TResult> ContinueWhenAll<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, null, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x000E6D71 File Offset: 0x000E4F71
		public Task<TResult> ContinueWhenAll<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x000E6D8C File Offset: 0x000E4F8C
		internal static Task<TResult> ContinueWhenAllImpl<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, Action<Task<TAntecedentResult>[]> continuationAction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			Task<TAntecedentResult>[] tasksCopy = TaskFactory.CheckMultiContinuationTasksAndCopy<TAntecedentResult>(tasks);
			if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == TaskContinuationOptions.None)
			{
				return TaskFactory<TResult>.CreateCanceledTask(continuationOptions, cancellationToken);
			}
			Task<Task<TAntecedentResult>[]> task = TaskFactory.CommonCWAllLogic<TAntecedentResult>(tasksCopy);
			if (continuationFunction4 != null)
			{
				Task<Task<TAntecedentResult>[]> task2 = task;
				Func<Task<Task<TAntecedentResult>[]>, object, TResult> continuationFunction2;
				if ((continuationFunction2 = TaskFactory<TResult>.<>c__56<TAntecedentResult>.<>9__56_0) == null)
				{
					Func<Task<Task<TAntecedentResult>[]>, object, TResult> func = TaskFactory<TResult>.<>c__56<TAntecedentResult>.<>9__56_0 = ((Task<Task<TAntecedentResult>[]> starter, object continuationFunction) => ((Func<Task<TAntecedentResult>[], TResult>)continuationFunction)(starter.Result));
					continuationFunction2 = func;
				}
				return task2.ContinueWith<TResult>(continuationFunction2, continuationFunction4, scheduler, cancellationToken, continuationOptions);
			}
			Task<Task<TAntecedentResult>[]> task3 = task;
			Func<Task<Task<TAntecedentResult>[]>, object, TResult> continuationFunction3;
			if ((continuationFunction3 = TaskFactory<TResult>.<>c__56<TAntecedentResult>.<>9__56_1) == null)
			{
				Func<Task<Task<TAntecedentResult>[]>, object, TResult> func = TaskFactory<TResult>.<>c__56<TAntecedentResult>.<>9__56_1 = delegate(Task<Task<TAntecedentResult>[]> starter, object continuationAction)
				{
					((Action<Task<TAntecedentResult>[]>)continuationAction)(starter.Result);
					return default(TResult);
				};
				continuationFunction3 = func;
			}
			return task3.ContinueWith<TResult>(continuationFunction3, continuationAction2, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x000E6E38 File Offset: 0x000E5038
		internal static Task<TResult> ContinueWhenAllImpl(Task[] tasks, Func<Task[], TResult> continuationFunction, Action<Task[]> continuationAction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			Task[] tasksCopy = TaskFactory.CheckMultiContinuationTasksAndCopy(tasks);
			if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == TaskContinuationOptions.None)
			{
				return TaskFactory<TResult>.CreateCanceledTask(continuationOptions, cancellationToken);
			}
			Task<Task[]> task = TaskFactory.CommonCWAllLogic(tasksCopy);
			if (continuationFunction != null)
			{
				return task.ContinueWith<TResult>(delegate(Task<Task[]> completedTasks, object state)
				{
					completedTasks.NotifyDebuggerOfWaitCompletionIfNecessary();
					return ((Func<Task[], TResult>)state)(completedTasks.Result);
				}, continuationFunction, scheduler, cancellationToken, continuationOptions);
			}
			return task.ContinueWith<TResult>(delegate(Task<Task[]> completedTasks, object state)
			{
				completedTasks.NotifyDebuggerOfWaitCompletionIfNecessary();
				((Action<Task[]>)state)(completedTasks.Result);
				return default(TResult);
			}, continuationAction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x000E6EE0 File Offset: 0x000E50E0
		public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x000E6F06 File Offset: 0x000E5106
		public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x000E6F27 File Offset: 0x000E5127
		public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x000E6F48 File Offset: 0x000E5148
		public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x000E6F61 File Offset: 0x000E5161
		public Task<TResult> ContinueWhenAny<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, null, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x000E6F87 File Offset: 0x000E5187
		public Task<TResult> ContinueWhenAny<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, null, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x000E6FA8 File Offset: 0x000E51A8
		public Task<TResult> ContinueWhenAny<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, null, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x000E6FC9 File Offset: 0x000E51C9
		public Task<TResult> ContinueWhenAny<[Nullable(2)] TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x000E6FE4 File Offset: 0x000E51E4
		internal static Task<TResult> ContinueWhenAnyImpl(Task[] tasks, Func<Task, TResult> continuationFunction, Action<Task> continuationAction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			if (tasks.Length == 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_EmptyTaskList, ExceptionArgument.tasks);
			}
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			Task<Task> task = TaskFactory.CommonCWAnyLogic<Task>(tasks, false);
			if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == TaskContinuationOptions.None)
			{
				return TaskFactory<TResult>.CreateCanceledTask(continuationOptions, cancellationToken);
			}
			if (continuationFunction != null)
			{
				return task.ContinueWith<TResult>((Task<Task> completedTask, object state) => ((Func<Task, TResult>)state)(completedTask.Result), continuationFunction, scheduler, cancellationToken, continuationOptions);
			}
			return task.ContinueWith<TResult>(delegate(Task<Task> completedTask, object state)
			{
				((Action<Task>)state)(completedTask.Result);
				return default(TResult);
			}, continuationAction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x000E7094 File Offset: 0x000E5294
		internal static Task<TResult> ContinueWhenAnyImpl<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, Action<Task<TAntecedentResult>> continuationAction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			if (tasks.Length == 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_EmptyTaskList, ExceptionArgument.tasks);
			}
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			Task<Task<TAntecedentResult>> task = TaskFactory.CommonCWAnyLogic<Task<TAntecedentResult>>(tasks, false);
			if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == TaskContinuationOptions.None)
			{
				return TaskFactory<TResult>.CreateCanceledTask(continuationOptions, cancellationToken);
			}
			if (continuationFunction4 != null)
			{
				Task<Task<TAntecedentResult>> task2 = task;
				Func<Task<Task<TAntecedentResult>>, object, TResult> continuationFunction2;
				if ((continuationFunction2 = TaskFactory<TResult>.<>c__67<TAntecedentResult>.<>9__67_0) == null)
				{
					Func<Task<Task<TAntecedentResult>>, object, TResult> func = TaskFactory<TResult>.<>c__67<TAntecedentResult>.<>9__67_0 = ((Task<Task<TAntecedentResult>> starter, object continuationFunction) => ((Func<Task<TAntecedentResult>, TResult>)continuationFunction)(starter.Result));
					continuationFunction2 = func;
				}
				return task2.ContinueWith<TResult>(continuationFunction2, continuationFunction4, scheduler, cancellationToken, continuationOptions);
			}
			Task<Task<TAntecedentResult>> task3 = task;
			Func<Task<Task<TAntecedentResult>>, object, TResult> continuationFunction3;
			if ((continuationFunction3 = TaskFactory<TResult>.<>c__67<TAntecedentResult>.<>9__67_1) == null)
			{
				Func<Task<Task<TAntecedentResult>>, object, TResult> func = TaskFactory<TResult>.<>c__67<TAntecedentResult>.<>9__67_1 = delegate(Task<Task<TAntecedentResult>> starter, object continuationAction)
				{
					((Action<Task<TAntecedentResult>>)continuationAction)(starter.Result);
					return default(TResult);
				};
				continuationFunction3 = func;
			}
			return task3.ContinueWith<TResult>(continuationFunction3, continuationAction2, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x04000FD9 RID: 4057
		private readonly CancellationToken m_defaultCancellationToken;

		// Token: 0x04000FDA RID: 4058
		private readonly TaskScheduler m_defaultScheduler;

		// Token: 0x04000FDB RID: 4059
		private readonly TaskCreationOptions m_defaultCreationOptions;

		// Token: 0x04000FDC RID: 4060
		private readonly TaskContinuationOptions m_defaultContinuationOptions;

		// Token: 0x0200049D RID: 1181
		private sealed class FromAsyncTrimPromise<TInstance> : Task<TResult> where TInstance : class
		{
			// Token: 0x06004515 RID: 17685 RVA: 0x000E7147 File Offset: 0x000E5347
			internal FromAsyncTrimPromise(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod)
			{
				this.m_thisRef = thisRef;
				this.m_endMethod = endMethod;
			}

			// Token: 0x06004516 RID: 17686 RVA: 0x000E7160 File Offset: 0x000E5360
			internal static void CompleteFromAsyncResult(IAsyncResult asyncResult)
			{
				if (asyncResult == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.asyncResult);
				}
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance> fromAsyncTrimPromise = asyncResult.AsyncState as TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>;
				if (fromAsyncTrimPromise == null)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.InvalidOperation_WrongAsyncResultOrEndCalledMultiple, ExceptionArgument.asyncResult);
				}
				TInstance thisRef = fromAsyncTrimPromise.m_thisRef;
				Func<TInstance, IAsyncResult, TResult> endMethod = fromAsyncTrimPromise.m_endMethod;
				fromAsyncTrimPromise.m_thisRef = default(TInstance);
				fromAsyncTrimPromise.m_endMethod = null;
				if (endMethod == null)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.InvalidOperation_WrongAsyncResultOrEndCalledMultiple, ExceptionArgument.asyncResult);
				}
				if (!asyncResult.CompletedSynchronously)
				{
					fromAsyncTrimPromise.Complete(thisRef, endMethod, asyncResult, true);
				}
			}

			// Token: 0x06004517 RID: 17687 RVA: 0x000E71D0 File Offset: 0x000E53D0
			internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization)
			{
				try
				{
					TResult result = endMethod(thisRef, asyncResult);
					if (requiresSynchronization)
					{
						base.TrySetResult(result);
					}
					else
					{
						base.DangerousSetResult(result);
					}
				}
				catch (OperationCanceledException ex)
				{
					base.TrySetCanceled(ex.CancellationToken, ex);
				}
				catch (Exception exceptionObject)
				{
					base.TrySetException(exceptionObject);
				}
			}

			// Token: 0x04000FDD RID: 4061
			internal static readonly AsyncCallback s_completeFromAsyncResult = new AsyncCallback(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.CompleteFromAsyncResult);

			// Token: 0x04000FDE RID: 4062
			private TInstance m_thisRef;

			// Token: 0x04000FDF RID: 4063
			private Func<TInstance, IAsyncResult, TResult> m_endMethod;
		}
	}
}
