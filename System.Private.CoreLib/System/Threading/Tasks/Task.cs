using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x0200049A RID: 1178
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<>))]
	[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
	public class Task<[Nullable(2)] TResult> : Task
	{
		// Token: 0x06004497 RID: 17559 RVA: 0x000E5639 File Offset: 0x000E3839
		internal Task()
		{
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x000E59A0 File Offset: 0x000E3BA0
		internal Task(object state, TaskCreationOptions options) : base(state, options, true)
		{
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x000E59AC File Offset: 0x000E3BAC
		internal Task(TResult result) : base(false, TaskCreationOptions.None, default(CancellationToken))
		{
			this.m_result = result;
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x000E59D1 File Offset: 0x000E3BD1
		internal Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) : base(canceled, creationOptions, ct)
		{
			if (!canceled)
			{
				this.m_result = result;
			}
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x000E59E8 File Offset: 0x000E3BE8
		public Task(Func<TResult> function) : this(function, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x000E5A09 File Offset: 0x000E3C09
		public Task(Func<TResult> function, CancellationToken cancellationToken) : this(function, null, cancellationToken, TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x000E5A18 File Offset: 0x000E3C18
		public Task(Func<TResult> function, TaskCreationOptions creationOptions) : this(function, Task.InternalCurrentIfAttached(creationOptions), default(CancellationToken), creationOptions, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x000E5A3E File Offset: 0x000E3C3E
		public Task(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : this(function, Task.InternalCurrentIfAttached(creationOptions), cancellationToken, creationOptions, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x000E5A54 File Offset: 0x000E3C54
		[NullableContext(2)]
		public Task([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<object, TResult> function, object state) : this(function, state, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x000E5A76 File Offset: 0x000E3C76
		[NullableContext(2)]
		public Task([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<object, TResult> function, object state, CancellationToken cancellationToken) : this(function, state, null, cancellationToken, TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x000E5A88 File Offset: 0x000E3C88
		[NullableContext(2)]
		public Task([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<object, TResult> function, object state, TaskCreationOptions creationOptions) : this(function, state, Task.InternalCurrentIfAttached(creationOptions), default(CancellationToken), creationOptions, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x000E5AAF File Offset: 0x000E3CAF
		[NullableContext(2)]
		public Task([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : this(function, state, Task.InternalCurrentIfAttached(creationOptions), cancellationToken, creationOptions, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x000E5AC5 File Offset: 0x000E3CC5
		internal Task(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) : base(valueSelector, null, parent, cancellationToken, creationOptions, internalOptions, scheduler)
		{
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x000E5AD7 File Offset: 0x000E3CD7
		internal Task(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) : base(valueSelector, state, parent, cancellationToken, creationOptions, internalOptions, scheduler)
		{
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x000E5AEA File Offset: 0x000E3CEA
		internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			if (function == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.function);
			}
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			Task<TResult> task = new Task<TResult>(function, parent, cancellationToken, creationOptions, internalOptions | InternalTaskOptions.QueuedByRuntime, scheduler);
			task.ScheduleAndStart(false);
			return task;
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x000E5B1B File Offset: 0x000E3D1B
		internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			if (function == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.function);
			}
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			Task<TResult> task = new Task<TResult>(function, state, parent, cancellationToken, creationOptions, internalOptions | InternalTaskOptions.QueuedByRuntime, scheduler);
			task.ScheduleAndStart(false);
			return task;
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060044A7 RID: 17575 RVA: 0x000E5B50 File Offset: 0x000E3D50
		private string DebuggerDisplayResultDescription
		{
			get
			{
				if (!base.IsCompletedSuccessfully)
				{
					return SR.TaskT_DebuggerNoResult;
				}
				TResult result = this.m_result;
				return ((result != null) ? result.ToString() : null) ?? "";
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x000E5B93 File Offset: 0x000E3D93
		private string DebuggerDisplayMethodDescription
		{
			get
			{
				Delegate action = this.m_action;
				return ((action != null) ? action.Method.ToString() : null) ?? "{null}";
			}
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x000E5BB8 File Offset: 0x000E3DB8
		internal bool TrySetResult(TResult result)
		{
			bool result2 = false;
			if (base.AtomicStateUpdate(67108864, 90177536))
			{
				this.m_result = result;
				Interlocked.Exchange(ref this.m_stateFlags, this.m_stateFlags | 16777216);
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				if (contingentProperties != null)
				{
					base.NotifyParentIfPotentiallyAttachedTask();
					contingentProperties.SetCompleted();
				}
				base.FinishContinuations();
				result2 = true;
			}
			return result2;
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x000E5C19 File Offset: 0x000E3E19
		internal void DangerousSetResult(TResult result)
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (((contingentProperties != null) ? contingentProperties.m_parent : null) != null)
			{
				this.TrySetResult(result);
				return;
			}
			this.m_result = result;
			this.m_stateFlags |= 16777216;
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x060044AB RID: 17579 RVA: 0x000E5C55 File Offset: 0x000E3E55
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public TResult Result
		{
			get
			{
				if (!base.IsWaitNotificationEnabledOrNotRanToCompletion)
				{
					return this.m_result;
				}
				return this.GetResultCore(true);
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060044AC RID: 17580 RVA: 0x000E5C6D File Offset: 0x000E3E6D
		internal TResult ResultOnSuccess
		{
			get
			{
				return this.m_result;
			}
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x000E5C78 File Offset: 0x000E3E78
		internal TResult GetResultCore(bool waitCompletionNotification)
		{
			if (!base.IsCompleted)
			{
				base.InternalWait(-1, default(CancellationToken));
			}
			if (waitCompletionNotification)
			{
				base.NotifyDebuggerOfWaitCompletionIfNecessary();
			}
			if (!base.IsCompletedSuccessfully)
			{
				base.ThrowIfExceptional(true);
			}
			return this.m_result;
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060044AE RID: 17582 RVA: 0x000E5CBD File Offset: 0x000E3EBD
		public new static TaskFactory<TResult> Factory
		{
			get
			{
				TaskFactory<TResult> result;
				if ((result = Volatile.Read<TaskFactory<TResult>>(ref Task<TResult>.s_Factory)) == null)
				{
					result = (Interlocked.CompareExchange<TaskFactory<TResult>>(ref Task<TResult>.s_Factory, new TaskFactory<TResult>(), null) ?? Task<TResult>.s_Factory);
				}
				return result;
			}
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x000E5CE8 File Offset: 0x000E3EE8
		internal override void InnerInvoke()
		{
			Func<TResult> func = this.m_action as Func<TResult>;
			if (func != null)
			{
				this.m_result = func();
				return;
			}
			Func<object, TResult> func2 = this.m_action as Func<object, TResult>;
			if (func2 != null)
			{
				this.m_result = func2(this.m_stateObject);
				return;
			}
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x000E5D33 File Offset: 0x000E3F33
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public new TaskAwaiter<TResult> GetAwaiter()
		{
			return new TaskAwaiter<TResult>(this);
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x000E5D3B File Offset: 0x000E3F3B
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			return new ConfiguredTaskAwaitable<TResult>(this, continueOnCapturedContext ? ConfigureAwaitOptions.ContinueOnCapturedContext : ConfigureAwaitOptions.None);
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x000E5D4A File Offset: 0x000E3F4A
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(ConfigureAwaitOptions options)
		{
			if ((options & ~(ConfigureAwaitOptions.ContinueOnCapturedContext | ConfigureAwaitOptions.ForceYielding)) != ConfigureAwaitOptions.None)
			{
				Task<TResult>.<ConfigureAwait>g__ThrowForInvalidOptions|35_0(options);
			}
			return new ConfiguredTaskAwaitable<TResult>(this, options);
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x000E5D5F File Offset: 0x000E3F5F
		public new Task<TResult> WaitAsync(CancellationToken cancellationToken)
		{
			return this.WaitAsync(uint.MaxValue, TimeProvider.System, cancellationToken);
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x000E5D70 File Offset: 0x000E3F70
		public new Task<TResult> WaitAsync(TimeSpan timeout)
		{
			return this.WaitAsync(Task.ValidateTimeout(timeout, ExceptionArgument.timeout), TimeProvider.System, default(CancellationToken));
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x000E5D9C File Offset: 0x000E3F9C
		public new Task<TResult> WaitAsync(TimeSpan timeout, TimeProvider timeProvider)
		{
			ArgumentNullException.ThrowIfNull(timeProvider, "timeProvider");
			return this.WaitAsync(Task.ValidateTimeout(timeout, ExceptionArgument.timeout), timeProvider, default(CancellationToken));
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x000E5DCC File Offset: 0x000E3FCC
		public new Task<TResult> WaitAsync(TimeSpan timeout, CancellationToken cancellationToken)
		{
			return this.WaitAsync(Task.ValidateTimeout(timeout, ExceptionArgument.timeout), TimeProvider.System, cancellationToken);
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x000E5DE2 File Offset: 0x000E3FE2
		public new Task<TResult> WaitAsync(TimeSpan timeout, TimeProvider timeProvider, CancellationToken cancellationToken)
		{
			ArgumentNullException.ThrowIfNull(timeProvider, "timeProvider");
			return this.WaitAsync(Task.ValidateTimeout(timeout, ExceptionArgument.timeout), timeProvider, cancellationToken);
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x000E5DFF File Offset: 0x000E3FFF
		private Task<TResult> WaitAsync(uint millisecondsTimeout, TimeProvider timeProvider, CancellationToken cancellationToken)
		{
			if (base.IsCompleted || (!cancellationToken.CanBeCanceled && millisecondsTimeout == 4294967295U))
			{
				return this;
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<TResult>(cancellationToken);
			}
			if (millisecondsTimeout == 0U)
			{
				return Task.FromException<TResult>(new TimeoutException());
			}
			return new Task.CancellationPromise<TResult>(this, millisecondsTimeout, timeProvider, cancellationToken);
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x000E5E40 File Offset: 0x000E4040
		public Task ContinueWith(Action<Task<TResult>> continuationAction)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x000E5E63 File Offset: 0x000E4063
		public Task ContinueWith(Action<Task<TResult>> continuationAction, CancellationToken cancellationToken)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x000E5E74 File Offset: 0x000E4074
		public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x000E5E94 File Offset: 0x000E4094
		public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x000E5EB7 File Offset: 0x000E40B7
		public Task ContinueWith(Action<Task<TResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x000E5EC4 File Offset: 0x000E40C4
		internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			if (continuationAction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationAction);
			}
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			TaskCreationOptions creationOptions;
			InternalTaskOptions internalOptions;
			Task.CreationOptionsFromContinuationOptions(continuationOptions, out creationOptions, out internalOptions);
			Task task = new ContinuationTaskFromResultTask<TResult>(this, continuationAction, null, creationOptions, internalOptions);
			base.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x000E5F08 File Offset: 0x000E4108
		public Task ContinueWith([Nullable(new byte[]
		{
			1,
			1,
			1,
			2
		})] Action<Task<TResult>, object> continuationAction, [Nullable(2)] object state)
		{
			return this.ContinueWith(continuationAction, state, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x000E5F2C File Offset: 0x000E412C
		public Task ContinueWith([Nullable(new byte[]
		{
			1,
			1,
			1,
			2
		})] Action<Task<TResult>, object> continuationAction, [Nullable(2)] object state, CancellationToken cancellationToken)
		{
			return this.ContinueWith(continuationAction, state, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x000E5F40 File Offset: 0x000E4140
		public Task ContinueWith([Nullable(new byte[]
		{
			1,
			1,
			1,
			2
		})] Action<Task<TResult>, object> continuationAction, [Nullable(2)] object state, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, state, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x000E5F60 File Offset: 0x000E4160
		public Task ContinueWith([Nullable(new byte[]
		{
			1,
			1,
			1,
			2
		})] Action<Task<TResult>, object> continuationAction, [Nullable(2)] object state, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith(continuationAction, state, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x000E5F84 File Offset: 0x000E4184
		public Task ContinueWith([Nullable(new byte[]
		{
			1,
			1,
			1,
			2
		})] Action<Task<TResult>, object> continuationAction, [Nullable(2)] object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, state, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x000E5F94 File Offset: 0x000E4194
		internal Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			if (continuationAction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationAction);
			}
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			TaskCreationOptions creationOptions;
			InternalTaskOptions internalOptions;
			Task.CreationOptionsFromContinuationOptions(continuationOptions, out creationOptions, out internalOptions);
			Task task = new ContinuationTaskFromResultTask<TResult>(this, continuationAction, state, creationOptions, internalOptions);
			base.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x000E5FD8 File Offset: 0x000E41D8
		public Task<TNewResult> ContinueWith<[Nullable(2)] TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x000E5FFB File Offset: 0x000E41FB
		public Task<TNewResult> ContinueWith<[Nullable(2)] TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x000E600C File Offset: 0x000E420C
		public Task<TNewResult> ContinueWith<[Nullable(2)] TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x000E602C File Offset: 0x000E422C
		public Task<TNewResult> ContinueWith<[Nullable(2)] TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x000E604F File Offset: 0x000E424F
		public Task<TNewResult> ContinueWith<[Nullable(2)] TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x000E605C File Offset: 0x000E425C
		internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			TaskCreationOptions creationOptions;
			InternalTaskOptions internalOptions;
			Task.CreationOptionsFromContinuationOptions(continuationOptions, out creationOptions, out internalOptions);
			Task<TNewResult> task = new ContinuationResultTaskFromResultTask<TResult, TNewResult>(this, continuationFunction, null, creationOptions, internalOptions);
			base.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x000E60A0 File Offset: 0x000E42A0
		[NullableContext(2)]
		[return: Nullable(1)]
		public Task<TNewResult> ContinueWith<TNewResult>([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})] Func<Task<TResult>, object, TNewResult> continuationFunction, object state)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, state, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x000E60C4 File Offset: 0x000E42C4
		[NullableContext(2)]
		[return: Nullable(1)]
		public Task<TNewResult> ContinueWith<TNewResult>([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})] Func<Task<TResult>, object, TNewResult> continuationFunction, object state, CancellationToken cancellationToken)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, state, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x000E60D8 File Offset: 0x000E42D8
		public Task<TNewResult> ContinueWith<[Nullable(2)] TNewResult>([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})] Func<Task<TResult>, object, TNewResult> continuationFunction, [Nullable(2)] object state, TaskScheduler scheduler)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, state, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x000E60F8 File Offset: 0x000E42F8
		[NullableContext(2)]
		[return: Nullable(1)]
		public Task<TNewResult> ContinueWith<TNewResult>([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})] Func<Task<TResult>, object, TNewResult> continuationFunction, object state, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, state, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x000E611C File Offset: 0x000E431C
		public Task<TNewResult> ContinueWith<[Nullable(2)] TNewResult>([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})] Func<Task<TResult>, object, TNewResult> continuationFunction, [Nullable(2)] object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, state, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x000E612C File Offset: 0x000E432C
		internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.continuationFunction);
			}
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			TaskCreationOptions creationOptions;
			InternalTaskOptions internalOptions;
			Task.CreationOptionsFromContinuationOptions(continuationOptions, out creationOptions, out internalOptions);
			Task<TNewResult> task = new ContinuationResultTaskFromResultTask<TResult, TNewResult>(this, continuationFunction, state, creationOptions, internalOptions);
			base.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x000E6190 File Offset: 0x000E4390
		[CompilerGenerated]
		internal static void <ConfigureAwait>g__ThrowForInvalidOptions|35_0(ConfigureAwaitOptions options)
		{
			throw ((options & ConfigureAwaitOptions.SuppressThrowing) == ConfigureAwaitOptions.None) ? new ArgumentOutOfRangeException("options") : new ArgumentOutOfRangeException("options", SR.TaskT_ConfigureAwait_InvalidOptions);
		}

		// Token: 0x04000FD5 RID: 4053
		internal static readonly Task<TResult> s_defaultResultTask = TaskCache.CreateCacheableTask<TResult>(default(TResult));

		// Token: 0x04000FD6 RID: 4054
		private static TaskFactory<TResult> s_Factory;

		// Token: 0x04000FD7 RID: 4055
		internal TResult m_result;
	}
}
