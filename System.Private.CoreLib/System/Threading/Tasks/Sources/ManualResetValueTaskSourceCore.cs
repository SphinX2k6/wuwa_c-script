using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x020004F6 RID: 1270
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Auto)]
	public struct ManualResetValueTaskSourceCore<[Nullable(2)] TResult>
	{
		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060047FE RID: 18430 RVA: 0x000EFFED File Offset: 0x000EE1ED
		// (set) Token: 0x060047FF RID: 18431 RVA: 0x000EFFF5 File Offset: 0x000EE1F5
		public bool RunContinuationsAsynchronously
		{
			get
			{
				return this._runContinuationsAsynchronously;
			}
			set
			{
				this._runContinuationsAsynchronously = value;
			}
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x000EFFFE File Offset: 0x000EE1FE
		public void Reset()
		{
			this._version += 1;
			this._continuation = null;
			this._continuationState = null;
			this._capturedContext = null;
			this._error = null;
			this._result = default(TResult);
			this._completed = false;
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x000F003E File Offset: 0x000EE23E
		public void SetResult(TResult result)
		{
			this._result = result;
			this.SignalCompletion();
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x000F004D File Offset: 0x000EE24D
		public void SetException(Exception error)
		{
			this._error = ExceptionDispatchInfo.Capture(error);
			this.SignalCompletion();
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x000F0061 File Offset: 0x000EE261
		public short Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x000F0069 File Offset: 0x000EE269
		public ValueTaskSourceStatus GetStatus(short token)
		{
			this.ValidateToken(token);
			if (Volatile.Read<Action<object>>(ref this._continuation) == null || !this._completed)
			{
				return ValueTaskSourceStatus.Pending;
			}
			if (this._error == null)
			{
				return ValueTaskSourceStatus.Succeeded;
			}
			if (!(this._error.SourceException is OperationCanceledException))
			{
				return ValueTaskSourceStatus.Faulted;
			}
			return ValueTaskSourceStatus.Canceled;
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x000F00A8 File Offset: 0x000EE2A8
		[StackTraceHidden]
		public TResult GetResult(short token)
		{
			if (token != this._version || !this._completed || this._error != null)
			{
				this.ThrowForFailedGetResult();
			}
			return this._result;
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x000F00CF File Offset: 0x000EE2CF
		[StackTraceHidden]
		private void ThrowForFailedGetResult()
		{
			ExceptionDispatchInfo error = this._error;
			if (error != null)
			{
				error.Throw();
			}
			throw new InvalidOperationException();
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x000F00E8 File Offset: 0x000EE2E8
		[NullableContext(2)]
		public void OnCompleted([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
		{
			if (continuation == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuation);
			}
			this.ValidateToken(token);
			if ((flags & ValueTaskSourceOnCompletedFlags.FlowExecutionContext) != ValueTaskSourceOnCompletedFlags.None)
			{
				this._capturedContext = ExecutionContext.Capture();
			}
			if ((flags & ValueTaskSourceOnCompletedFlags.UseSchedulingContext) != ValueTaskSourceOnCompletedFlags.None)
			{
				SynchronizationContext synchronizationContext = SynchronizationContext.Current;
				if (synchronizationContext != null && synchronizationContext.GetType() != typeof(SynchronizationContext))
				{
					this._capturedContext = ((this._capturedContext == null) ? synchronizationContext : new CapturedSchedulerAndExecutionContext(synchronizationContext, (ExecutionContext)this._capturedContext));
				}
				else
				{
					TaskScheduler taskScheduler = TaskScheduler.Current;
					if (taskScheduler != TaskScheduler.Default)
					{
						this._capturedContext = ((this._capturedContext == null) ? taskScheduler : new CapturedSchedulerAndExecutionContext(taskScheduler, (ExecutionContext)this._capturedContext));
					}
				}
			}
			object obj = this._continuation;
			if (obj == null)
			{
				this._continuationState = state;
				obj = Interlocked.CompareExchange<Action<object>>(ref this._continuation, continuation, null);
				if (obj == null)
				{
					return;
				}
			}
			if (obj != ManualResetValueTaskSourceCoreShared.s_sentinel)
			{
				ThrowHelper.ThrowInvalidOperationException();
			}
			object capturedContext = this._capturedContext;
			if (capturedContext == null)
			{
				ThreadPool.UnsafeQueueUserWorkItem<object>(continuation, state, true);
				return;
			}
			if (!(capturedContext is ExecutionContext))
			{
				ManualResetValueTaskSourceCoreShared.ScheduleCapturedContext(capturedContext, continuation, state);
				return;
			}
			ThreadPool.QueueUserWorkItem<object>(continuation, state, true);
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x000F01F1 File Offset: 0x000EE3F1
		private void ValidateToken(short token)
		{
			if (token != this._version)
			{
				ThrowHelper.ThrowInvalidOperationException();
			}
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x000F0204 File Offset: 0x000EE404
		private void SignalCompletion()
		{
			if (this._completed)
			{
				ThrowHelper.ThrowInvalidOperationException();
			}
			this._completed = true;
			Action<object> action = Volatile.Read<Action<object>>(ref this._continuation) ?? Interlocked.CompareExchange<Action<object>>(ref this._continuation, ManualResetValueTaskSourceCoreShared.s_sentinel, null);
			if (action != null)
			{
				object capturedContext = this._capturedContext;
				if (capturedContext == null)
				{
					if (this._runContinuationsAsynchronously)
					{
						ThreadPool.UnsafeQueueUserWorkItem<object>(action, this._continuationState, true);
						return;
					}
					action(this._continuationState);
					return;
				}
				else
				{
					bool flag = capturedContext is ExecutionContext || capturedContext is CapturedSchedulerAndExecutionContext;
					if (flag)
					{
						ManualResetValueTaskSourceCoreShared.InvokeContinuationWithContext(capturedContext, action, this._continuationState, this._runContinuationsAsynchronously);
						return;
					}
					ManualResetValueTaskSourceCoreShared.ScheduleCapturedContext(capturedContext, action, this._continuationState);
				}
			}
		}

		// Token: 0x04001111 RID: 4369
		private Action<object> _continuation;

		// Token: 0x04001112 RID: 4370
		private object _continuationState;

		// Token: 0x04001113 RID: 4371
		private object _capturedContext;

		// Token: 0x04001114 RID: 4372
		private ExceptionDispatchInfo _error;

		// Token: 0x04001115 RID: 4373
		private TResult _result;

		// Token: 0x04001116 RID: 4374
		private short _version;

		// Token: 0x04001117 RID: 4375
		private bool _completed;

		// Token: 0x04001118 RID: 4376
		private bool _runContinuationsAsynchronously;
	}
}
