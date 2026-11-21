using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Threading.Tasks.Sources;

namespace System.Threading.Tasks
{
	// Token: 0x020004A8 RID: 1192
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
	[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
	public class Task : IAsyncResult, IDisposable
	{
		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06004533 RID: 17715 RVA: 0x000E747D File Offset: 0x000E567D
		[Nullable(2)]
		private Task ParentForDebugger
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				if (contingentProperties == null)
				{
					return null;
				}
				return contingentProperties.m_parent;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06004534 RID: 17716 RVA: 0x000E7490 File Offset: 0x000E5690
		private int StateFlagsForDebugger
		{
			get
			{
				return this.m_stateFlags;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06004535 RID: 17717 RVA: 0x000E749A File Offset: 0x000E569A
		private Task.TaskStateFlags StateFlags
		{
			get
			{
				return (Task.TaskStateFlags)(this.m_stateFlags & -65536);
			}
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x000E74AC File Offset: 0x000E56AC
		internal static bool AddToActiveTasks(Task task)
		{
			Dictionary<int, Task> dictionary;
			if ((dictionary = Volatile.Read<Dictionary<int, Task>>(ref Task.s_currentActiveTasks)) == null)
			{
				dictionary = (Interlocked.CompareExchange<Dictionary<int, Task>>(ref Task.s_currentActiveTasks, new Dictionary<int, Task>(), null) ?? Task.s_currentActiveTasks);
			}
			Dictionary<int, Task> dictionary2 = dictionary;
			int id = task.Id;
			Dictionary<int, Task> obj = dictionary2;
			lock (obj)
			{
				dictionary2[id] = task;
			}
			return true;
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x000E751C File Offset: 0x000E571C
		internal static void RemoveFromActiveTasks(Task task)
		{
			Dictionary<int, Task> dictionary = Task.s_currentActiveTasks;
			if (dictionary == null)
			{
				return;
			}
			int id = task.Id;
			Dictionary<int, Task> obj = dictionary;
			lock (obj)
			{
				dictionary.Remove(id);
			}
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x000E756C File Offset: 0x000E576C
		internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
		{
			if (canceled)
			{
				this.m_stateFlags = (int)((TaskCreationOptions)5242880 | creationOptions);
				this.m_contingentProperties = new Task.ContingentProperties
				{
					m_cancellationToken = ct,
					m_internalCancellationRequested = 1
				};
				return;
			}
			this.m_stateFlags = (int)((TaskCreationOptions)16777216 | creationOptions);
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x000E75BE File Offset: 0x000E57BE
		internal Task()
		{
			this.m_stateFlags = 33555456;
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x000E75D4 File Offset: 0x000E57D4
		internal Task(object state, TaskCreationOptions creationOptions, bool promiseStyle)
		{
			if ((creationOptions & ~(TaskCreationOptions.AttachedToParent | TaskCreationOptions.RunContinuationsAsynchronously)) != TaskCreationOptions.None)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.creationOptions);
			}
			if ((creationOptions & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None)
			{
				Task internalCurrent = Task.InternalCurrent;
				if (internalCurrent != null)
				{
					this.EnsureContingentPropertiesInitializedUnsafe().m_parent = internalCurrent;
				}
			}
			this.TaskConstructorCore(null, state, default(CancellationToken), creationOptions, InternalTaskOptions.PromiseTask, null);
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x000E7628 File Offset: 0x000E5828
		public Task(Action action) : this(action, null, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x000E764A File Offset: 0x000E584A
		public Task(Action action, CancellationToken cancellationToken) : this(action, null, null, cancellationToken, TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x000E765C File Offset: 0x000E585C
		public Task(Action action, TaskCreationOptions creationOptions) : this(action, null, Task.InternalCurrentIfAttached(creationOptions), default(CancellationToken), creationOptions, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x000E7683 File Offset: 0x000E5883
		public Task(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : this(action, null, Task.InternalCurrentIfAttached(creationOptions), cancellationToken, creationOptions, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x000E7698 File Offset: 0x000E5898
		[NullableContext(2)]
		public Task([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> action, object state) : this(action, state, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x000E76BA File Offset: 0x000E58BA
		[NullableContext(2)]
		public Task([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> action, object state, CancellationToken cancellationToken) : this(action, state, null, cancellationToken, TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x000E76CC File Offset: 0x000E58CC
		[NullableContext(2)]
		public Task([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> action, object state, TaskCreationOptions creationOptions) : this(action, state, Task.InternalCurrentIfAttached(creationOptions), default(CancellationToken), creationOptions, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x000E76F3 File Offset: 0x000E58F3
		[NullableContext(2)]
		public Task([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : this(action, state, Task.InternalCurrentIfAttached(creationOptions), cancellationToken, creationOptions, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x000E770C File Offset: 0x000E590C
		internal Task(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			if (action == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.action);
			}
			if (parent != null && (creationOptions & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None)
			{
				this.EnsureContingentPropertiesInitializedUnsafe().m_parent = parent;
			}
			this.TaskConstructorCore(action, state, cancellationToken, creationOptions, internalOptions, scheduler);
			this.CapturedContext = ExecutionContext.Capture();
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x000E775C File Offset: 0x000E595C
		internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			this.m_action = action;
			this.m_stateObject = state;
			this.m_taskScheduler = scheduler;
			if ((creationOptions & ~(TaskCreationOptions.PreferFairness | TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent | TaskCreationOptions.DenyChildAttach | TaskCreationOptions.HideScheduler | TaskCreationOptions.RunContinuationsAsynchronously)) != TaskCreationOptions.None)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.creationOptions);
			}
			int num = (int)(creationOptions | (TaskCreationOptions)internalOptions);
			this.m_stateFlags = ((this.m_action == null || (internalOptions & InternalTaskOptions.ContinuationTask) != InternalTaskOptions.None) ? (num | 33554432) : num);
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties != null)
			{
				Task parent = contingentProperties.m_parent;
				if (parent != null && (creationOptions & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None && (parent.CreationOptions & TaskCreationOptions.DenyChildAttach) == TaskCreationOptions.None)
				{
					parent.AddNewChild();
				}
			}
			if (cancellationToken.CanBeCanceled)
			{
				this.AssignCancellationToken(cancellationToken, null, null);
			}
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x000E77F4 File Offset: 0x000E59F4
		private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
		{
			Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitializedUnsafe();
			contingentProperties.m_cancellationToken = cancellationToken;
			try
			{
				if ((this.Options & (TaskCreationOptions)13312) == TaskCreationOptions.None)
				{
					if (cancellationToken.IsCancellationRequested)
					{
						this.InternalCancel();
					}
					else
					{
						CancellationTokenRegistration value;
						if (antecedent == null)
						{
							value = cancellationToken.UnsafeRegister(delegate(object t)
							{
								((Task)t).InternalCancel();
							}, this);
						}
						else
						{
							value = cancellationToken.UnsafeRegister(delegate(object t)
							{
								TupleSlim<Task, Task, TaskContinuation> tupleSlim = (TupleSlim<Task, Task, TaskContinuation>)t;
								Task item = tupleSlim.Item1;
								tupleSlim.Item2.RemoveContinuation(tupleSlim.Item3);
								item.InternalCancel();
							}, new TupleSlim<Task, Task, TaskContinuation>(this, antecedent, continuation));
						}
						contingentProperties.m_cancellationRegistration = new StrongBox<CancellationTokenRegistration>(value);
					}
				}
			}
			catch
			{
				Task.ContingentProperties contingentProperties2 = this.m_contingentProperties;
				Task task = (contingentProperties2 != null) ? contingentProperties2.m_parent : null;
				if (task != null && (this.Options & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None && (task.Options & TaskCreationOptions.DenyChildAttach) == TaskCreationOptions.None)
				{
					task.DisregardChild();
				}
				throw;
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06004546 RID: 17734 RVA: 0x000E5B93 File Offset: 0x000E3D93
		private string DebuggerDisplayMethodDescription
		{
			get
			{
				Delegate action = this.m_action;
				return ((action != null) ? action.Method.ToString() : null) ?? "{null}";
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x000E78DC File Offset: 0x000E5ADC
		internal TaskCreationOptions Options
		{
			get
			{
				return Task.OptionsMethod(this.m_stateFlags);
			}
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x000D33FF File Offset: 0x000D15FF
		internal static TaskCreationOptions OptionsMethod(int flags)
		{
			return (TaskCreationOptions)(flags & 65535);
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x000E78EC File Offset: 0x000E5AEC
		internal bool AtomicStateUpdate(int newBits, int illegalBits)
		{
			int stateFlags = this.m_stateFlags;
			return (stateFlags & illegalBits) == 0 && (Interlocked.CompareExchange(ref this.m_stateFlags, stateFlags | newBits, stateFlags) == stateFlags || this.AtomicStateUpdateSlow(newBits, illegalBits));
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x000E7928 File Offset: 0x000E5B28
		private bool AtomicStateUpdateSlow(int newBits, int illegalBits)
		{
			int num = this.m_stateFlags;
			while ((num & illegalBits) == 0)
			{
				int num2 = Interlocked.CompareExchange(ref this.m_stateFlags, num | newBits, num);
				if (num2 == num)
				{
					return true;
				}
				num = num2;
			}
			return false;
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x000E7960 File Offset: 0x000E5B60
		internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags)
		{
			int num = oldFlags = this.m_stateFlags;
			while ((num & illegalBits) == 0)
			{
				oldFlags = Interlocked.CompareExchange(ref this.m_stateFlags, num | newBits, num);
				if (oldFlags == num)
				{
					return true;
				}
				num = oldFlags;
			}
			return false;
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x000E799E File Offset: 0x000E5B9E
		internal void SetNotificationForWaitCompletion(bool enabled)
		{
			if (enabled)
			{
				this.AtomicStateUpdate(268435456, 90177536);
				return;
			}
			Interlocked.And(ref this.m_stateFlags, -268435457);
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x000E79C6 File Offset: 0x000E5BC6
		internal bool NotifyDebuggerOfWaitCompletionIfNecessary()
		{
			if (this.IsWaitNotificationEnabled && this.ShouldNotifyDebuggerOfWaitCompletion)
			{
				this.NotifyDebuggerOfWaitCompletion();
				return true;
			}
			return false;
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x000E79E4 File Offset: 0x000E5BE4
		internal static bool AnyTaskRequiresNotifyDebuggerOfWaitCompletion(Task[] tasks)
		{
			foreach (Task task in tasks)
			{
				if (task != null && task.IsWaitNotificationEnabled && task.ShouldNotifyDebuggerOfWaitCompletion)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x0600454F RID: 17743 RVA: 0x000E7A1B File Offset: 0x000E5C1B
		internal bool IsWaitNotificationEnabledOrNotRanToCompletion
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return (this.m_stateFlags & 285212672) != 16777216;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06004550 RID: 17744 RVA: 0x000E7A35 File Offset: 0x000E5C35
		private protected virtual bool ShouldNotifyDebuggerOfWaitCompletion
		{
			get
			{
				return this.IsWaitNotificationEnabled;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06004551 RID: 17745 RVA: 0x000E7A3D File Offset: 0x000E5C3D
		internal bool IsWaitNotificationEnabled
		{
			get
			{
				return (this.m_stateFlags & 268435456) != 0;
			}
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x000E7A50 File Offset: 0x000E5C50
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void NotifyDebuggerOfWaitCompletion()
		{
			this.SetNotificationForWaitCompletion(false);
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x000E7A59 File Offset: 0x000E5C59
		internal bool MarkStarted()
		{
			return this.AtomicStateUpdate(65536, 4259840);
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x000E7A6C File Offset: 0x000E5C6C
		internal void FireTaskScheduledIfNeeded(TaskScheduler ts)
		{
			if ((this.m_stateFlags & 1073741824) == 0)
			{
				this.m_stateFlags |= 1073741824;
				if (TplEventSource.Log.IsEnabled())
				{
					Task internalCurrent = Task.InternalCurrent;
					Task.ContingentProperties contingentProperties = this.m_contingentProperties;
					Task task = (contingentProperties != null) ? contingentProperties.m_parent : null;
					TplEventSource.Log.TaskScheduled(ts.Id, (internalCurrent == null) ? 0 : internalCurrent.Id, this.Id, (task == null) ? 0 : task.Id, (int)this.Options, 1);
				}
			}
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x000E7AFC File Offset: 0x000E5CFC
		internal void AddNewChild()
		{
			Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitialized();
			if (contingentProperties.m_completionCountdown == 1)
			{
				contingentProperties.m_completionCountdown++;
				return;
			}
			Interlocked.Increment(ref contingentProperties.m_completionCountdown);
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x000E7B3A File Offset: 0x000E5D3A
		internal void DisregardChild()
		{
			Interlocked.Decrement(ref this.EnsureContingentPropertiesInitialized().m_completionCountdown);
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x000E7B4D File Offset: 0x000E5D4D
		public void Start()
		{
			this.Start(TaskScheduler.Current);
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x000E7B5C File Offset: 0x000E5D5C
		public void Start(TaskScheduler scheduler)
		{
			int stateFlags = this.m_stateFlags;
			if (Task.IsCompletedMethod(stateFlags))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.Task_Start_TaskCompleted);
			}
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			TaskCreationOptions taskCreationOptions = Task.OptionsMethod(stateFlags);
			if ((taskCreationOptions & (TaskCreationOptions)1024) != TaskCreationOptions.None)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.Task_Start_Promise);
			}
			if ((taskCreationOptions & (TaskCreationOptions)512) != TaskCreationOptions.None)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.Task_Start_ContinuationTask);
			}
			if (Interlocked.CompareExchange<TaskScheduler>(ref this.m_taskScheduler, scheduler, null) != null)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.Task_Start_AlreadyStarted);
			}
			this.ScheduleAndStart(true);
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x000E7BCB File Offset: 0x000E5DCB
		public void RunSynchronously()
		{
			this.InternalRunSynchronously(TaskScheduler.Current, true);
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x000E7BD9 File Offset: 0x000E5DD9
		public void RunSynchronously(TaskScheduler scheduler)
		{
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			this.InternalRunSynchronously(scheduler, true);
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x000E7BF0 File Offset: 0x000E5DF0
		internal void InternalRunSynchronously(TaskScheduler scheduler, bool waitForCompletion)
		{
			int stateFlags = this.m_stateFlags;
			TaskCreationOptions taskCreationOptions = Task.OptionsMethod(stateFlags);
			if ((taskCreationOptions & (TaskCreationOptions)512) != TaskCreationOptions.None)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.Task_RunSynchronously_Continuation);
			}
			if ((taskCreationOptions & (TaskCreationOptions)1024) != TaskCreationOptions.None)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.Task_RunSynchronously_Promise);
			}
			if (Task.IsCompletedMethod(stateFlags))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.Task_RunSynchronously_TaskCompleted);
			}
			if (Interlocked.CompareExchange<TaskScheduler>(ref this.m_taskScheduler, scheduler, null) != null)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.Task_RunSynchronously_AlreadyStarted);
			}
			if (this.MarkStarted())
			{
				bool flag = false;
				try
				{
					if (!scheduler.TryRunInline(this, false))
					{
						scheduler.InternalQueueTask(this);
						flag = true;
					}
					if (waitForCompletion && !this.IsCompleted)
					{
						this.SpinThenBlockingWait(-1, default(CancellationToken));
					}
					return;
				}
				catch (Exception innerException)
				{
					if (!flag)
					{
						TaskSchedulerException ex = new TaskSchedulerException(innerException);
						this.AddException(ex);
						this.Finish(false);
						this.m_contingentProperties.m_exceptionsHolder.MarkAsHandled(false);
						throw ex;
					}
					throw;
				}
			}
			ThrowHelper.ThrowInvalidOperationException(ExceptionResource.Task_RunSynchronously_TaskCompleted);
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x000E7CD0 File Offset: 0x000E5ED0
		internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions)
		{
			if (scheduler == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.scheduler);
			}
			Task task = new Task(action, state, creatingTask, cancellationToken, options, internalOptions | InternalTaskOptions.QueuedByRuntime, scheduler);
			task.ScheduleAndStart(false);
			return task;
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x000E7CFC File Offset: 0x000E5EFC
		internal static int NewId()
		{
			int num;
			do
			{
				num = Interlocked.Increment(ref Task.s_taskIdCounter);
			}
			while (num == 0);
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.NewID(num);
			}
			return num;
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x0600455E RID: 17758 RVA: 0x000E7D30 File Offset: 0x000E5F30
		public int Id
		{
			get
			{
				if (Volatile.Read(ref this.m_taskId) == 0)
				{
					int value = Task.NewId();
					Interlocked.CompareExchange(ref this.m_taskId, value, 0);
				}
				return this.m_taskId;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x0600455F RID: 17759 RVA: 0x000E7D64 File Offset: 0x000E5F64
		public static int? CurrentId
		{
			get
			{
				Task internalCurrent = Task.InternalCurrent;
				if (internalCurrent != null)
				{
					return new int?(internalCurrent.Id);
				}
				return null;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06004560 RID: 17760 RVA: 0x000E7D8F File Offset: 0x000E5F8F
		[Nullable(2)]
		internal static Task InternalCurrent
		{
			get
			{
				return Task.t_currentTask;
			}
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x000E7D96 File Offset: 0x000E5F96
		internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
		{
			if ((creationOptions & TaskCreationOptions.AttachedToParent) == TaskCreationOptions.None)
			{
				return null;
			}
			return Task.InternalCurrent;
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06004562 RID: 17762 RVA: 0x000E7DA4 File Offset: 0x000E5FA4
		[Nullable(2)]
		public AggregateException Exception
		{
			[NullableContext(2)]
			get
			{
				AggregateException result = null;
				if (this.IsFaulted)
				{
					result = this.GetExceptions(false);
				}
				return result;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06004563 RID: 17763 RVA: 0x000E7DC4 File Offset: 0x000E5FC4
		public TaskStatus Status
		{
			get
			{
				int stateFlags = this.m_stateFlags;
				TaskStatus result;
				if ((stateFlags & 2097152) != 0)
				{
					result = TaskStatus.Faulted;
				}
				else if ((stateFlags & 4194304) != 0)
				{
					result = TaskStatus.Canceled;
				}
				else if ((stateFlags & 16777216) != 0)
				{
					result = TaskStatus.RanToCompletion;
				}
				else if ((stateFlags & 8388608) != 0)
				{
					result = TaskStatus.WaitingForChildrenToComplete;
				}
				else if ((stateFlags & 131072) != 0)
				{
					result = TaskStatus.Running;
				}
				else if ((stateFlags & 65536) != 0)
				{
					result = TaskStatus.WaitingToRun;
				}
				else if ((stateFlags & 33554432) != 0)
				{
					result = TaskStatus.WaitingForActivation;
				}
				else
				{
					result = TaskStatus.Created;
				}
				return result;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06004564 RID: 17764 RVA: 0x000E7E38 File Offset: 0x000E6038
		public bool IsCanceled
		{
			get
			{
				return (this.m_stateFlags & 6291456) == 4194304;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06004565 RID: 17765 RVA: 0x000E7E50 File Offset: 0x000E6050
		internal bool IsCancellationRequested
		{
			get
			{
				Task.ContingentProperties contingentProperties = Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties);
				return contingentProperties != null && (contingentProperties.m_internalCancellationRequested == 1 || contingentProperties.m_cancellationToken.IsCancellationRequested);
			}
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x000E7E86 File Offset: 0x000E6086
		internal Task.ContingentProperties EnsureContingentPropertiesInitialized()
		{
			return Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties) ?? this.<EnsureContingentPropertiesInitialized>g__InitializeContingentProperties|81_0();
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x000E7EA0 File Offset: 0x000E60A0
		internal Task.ContingentProperties EnsureContingentPropertiesInitializedUnsafe()
		{
			Task.ContingentProperties result;
			if ((result = this.m_contingentProperties) == null)
			{
				result = (this.m_contingentProperties = new Task.ContingentProperties());
			}
			return result;
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06004568 RID: 17768 RVA: 0x000E7EC8 File Offset: 0x000E60C8
		internal CancellationToken CancellationToken
		{
			get
			{
				Task.ContingentProperties contingentProperties = Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties);
				if (contingentProperties != null)
				{
					return contingentProperties.m_cancellationToken;
				}
				return default(CancellationToken);
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x000E7EF4 File Offset: 0x000E60F4
		internal bool IsCancellationAcknowledged
		{
			get
			{
				return (this.m_stateFlags & 1048576) != 0;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x0600456A RID: 17770 RVA: 0x000E7F07 File Offset: 0x000E6107
		public bool IsCompleted
		{
			get
			{
				return Task.IsCompletedMethod(this.m_stateFlags);
			}
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x000E7F16 File Offset: 0x000E6116
		private static bool IsCompletedMethod(int flags)
		{
			return (flags & 23068672) != 0;
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x0600456C RID: 17772 RVA: 0x000E7F22 File Offset: 0x000E6122
		public bool IsCompletedSuccessfully
		{
			get
			{
				return (this.m_stateFlags & 23068672) == 16777216;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x0600456D RID: 17773 RVA: 0x000E7F39 File Offset: 0x000E6139
		public TaskCreationOptions CreationOptions
		{
			get
			{
				return this.Options & (TaskCreationOptions)(-65281);
			}
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x000E7F48 File Offset: 0x000E6148
		internal void SpinUntilCompleted()
		{
			SpinWait spinWait = default(SpinWait);
			while (!this.IsCompleted)
			{
				spinWait.SpinOnce();
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x0600456F RID: 17775 RVA: 0x000E7F6E File Offset: 0x000E616E
		WaitHandle IAsyncResult.AsyncWaitHandle
		{
			get
			{
				if ((this.m_stateFlags & 262144) != 0)
				{
					ThrowHelper.ThrowObjectDisposedException(ExceptionResource.Task_ThrowIfDisposed);
				}
				return this.CompletedEvent.WaitHandle;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06004570 RID: 17776 RVA: 0x000E7F95 File Offset: 0x000E6195
		[Nullable(2)]
		public object AsyncState
		{
			[NullableContext(2)]
			get
			{
				if ((this.m_stateFlags & 2048) != 0)
				{
					return null;
				}
				return this.m_stateObject;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06004571 RID: 17777 RVA: 0x00007B65 File Offset: 0x00005D65
		bool IAsyncResult.CompletedSynchronously
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06004572 RID: 17778 RVA: 0x000E7FAF File Offset: 0x000E61AF
		[Nullable(2)]
		internal TaskScheduler ExecutingTaskScheduler
		{
			get
			{
				return this.m_taskScheduler;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06004573 RID: 17779 RVA: 0x000E7FB7 File Offset: 0x000E61B7
		public static TaskFactory Factory { get; } = new TaskFactory();

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x000E7FBE File Offset: 0x000E61BE
		public static Task CompletedTask
		{
			get
			{
				return Task.s_cachedCompleted;
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06004575 RID: 17781 RVA: 0x000E7FC8 File Offset: 0x000E61C8
		internal ManualResetEventSlim CompletedEvent
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitialized();
				if (contingentProperties.m_completionEvent == null)
				{
					bool isCompleted = this.IsCompleted;
					ManualResetEventSlim manualResetEventSlim = new ManualResetEventSlim(isCompleted);
					if (Interlocked.CompareExchange<ManualResetEventSlim>(ref contingentProperties.m_completionEvent, manualResetEventSlim, null) != null)
					{
						manualResetEventSlim.Dispose();
					}
					else if (!isCompleted && this.IsCompleted)
					{
						Task.ContingentProperties.SetEvent(manualResetEventSlim);
					}
				}
				return contingentProperties.m_completionEvent;
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x000E8024 File Offset: 0x000E6224
		internal bool ExceptionRecorded
		{
			get
			{
				Task.ContingentProperties contingentProperties = Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties);
				return contingentProperties != null && contingentProperties.m_exceptionsHolder != null && contingentProperties.m_exceptionsHolder.ContainsFaultList;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06004577 RID: 17783 RVA: 0x000E8059 File Offset: 0x000E6259
		[MemberNotNullWhen(true, "Exception")]
		public bool IsFaulted
		{
			[MemberNotNullWhen(true, "Exception")]
			get
			{
				return (this.m_stateFlags & 2097152) != 0;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06004578 RID: 17784 RVA: 0x000E806C File Offset: 0x000E626C
		// (set) Token: 0x06004579 RID: 17785 RVA: 0x000E80A0 File Offset: 0x000E62A0
		[Nullable(2)]
		internal ExecutionContext CapturedContext
		{
			get
			{
				if ((this.m_stateFlags & 536870912) == 536870912)
				{
					return null;
				}
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				return ((contingentProperties != null) ? contingentProperties.m_capturedContext : null) ?? ExecutionContext.Default;
			}
			set
			{
				if (value == null)
				{
					this.m_stateFlags |= 536870912;
					return;
				}
				if (value != ExecutionContext.Default)
				{
					this.EnsureContingentPropertiesInitializedUnsafe().m_capturedContext = value;
				}
			}
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x000E80D0 File Offset: 0x000E62D0
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x000E80E0 File Offset: 0x000E62E0
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if ((this.Options & (TaskCreationOptions)16384) != TaskCreationOptions.None)
				{
					return;
				}
				if (!this.IsCompleted)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.Task_Dispose_NotCompleted);
				}
				Task.ContingentProperties contingentProperties = Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties);
				if (contingentProperties != null)
				{
					ManualResetEventSlim completionEvent = contingentProperties.m_completionEvent;
					if (completionEvent != null)
					{
						contingentProperties.m_completionEvent = null;
						Task.ContingentProperties.SetEvent(completionEvent);
						completionEvent.Dispose();
					}
				}
			}
			this.m_stateFlags |= 262144;
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x000E8154 File Offset: 0x000E6354
		internal void ScheduleAndStart(bool needsProtection)
		{
			if (needsProtection)
			{
				if (!this.MarkStarted())
				{
					return;
				}
			}
			else
			{
				this.m_stateFlags |= 65536;
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(this);
			}
			if (TplEventSource.Log.IsEnabled() && (this.Options & (TaskCreationOptions)512) == TaskCreationOptions.None)
			{
				TplEventSource.Log.TraceOperationBegin(this.Id, "Task: " + this.m_action.GetMethodName(), 0L);
			}
			try
			{
				this.m_taskScheduler.InternalQueueTask(this);
			}
			catch (Exception innerException)
			{
				TaskSchedulerException ex = new TaskSchedulerException(innerException);
				this.AddException(ex);
				this.Finish(false);
				if ((this.Options & (TaskCreationOptions)512) == TaskCreationOptions.None)
				{
					this.m_contingentProperties.m_exceptionsHolder.MarkAsHandled(false);
				}
				throw ex;
			}
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x000E8228 File Offset: 0x000E6428
		internal void AddException(object exceptionObject)
		{
			this.AddException(exceptionObject, false);
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x000E8234 File Offset: 0x000E6434
		internal void AddException(object exceptionObject, bool representsCancellation)
		{
			Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitialized();
			if (contingentProperties.m_exceptionsHolder == null)
			{
				TaskExceptionHolder taskExceptionHolder = new TaskExceptionHolder(this);
				if (Interlocked.CompareExchange<TaskExceptionHolder>(ref contingentProperties.m_exceptionsHolder, taskExceptionHolder, null) != null)
				{
					taskExceptionHolder.MarkAsHandled(false);
				}
			}
			Task.ContingentProperties obj = contingentProperties;
			lock (obj)
			{
				contingentProperties.m_exceptionsHolder.Add(exceptionObject, representsCancellation);
			}
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x000E82A8 File Offset: 0x000E64A8
		private AggregateException GetExceptions(bool includeTaskCanceledExceptions)
		{
			Exception ex = null;
			if (includeTaskCanceledExceptions && this.IsCanceled)
			{
				ex = new TaskCanceledException(this);
				ex.SetCurrentStackTrace();
			}
			if (this.ExceptionRecorded)
			{
				return this.m_contingentProperties.m_exceptionsHolder.CreateExceptionObject(false, ex);
			}
			if (ex != null)
			{
				return new AggregateException(new Exception[]
				{
					ex
				});
			}
			return null;
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x000E8300 File Offset: 0x000E6500
		internal List<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			return this.m_contingentProperties.m_exceptionsHolder.GetExceptionDispatchInfos();
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x000E8314 File Offset: 0x000E6514
		internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			Task.ContingentProperties contingentProperties = Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties);
			if (contingentProperties == null)
			{
				return null;
			}
			TaskExceptionHolder exceptionsHolder = contingentProperties.m_exceptionsHolder;
			if (exceptionsHolder == null)
			{
				return null;
			}
			return exceptionsHolder.GetCancellationExceptionDispatchInfo();
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x000E8339 File Offset: 0x000E6539
		internal void MarkExceptionsAsHandled()
		{
			Task.ContingentProperties contingentProperties = Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties);
			if (contingentProperties == null)
			{
				return;
			}
			TaskExceptionHolder exceptionsHolder = contingentProperties.m_exceptionsHolder;
			if (exceptionsHolder == null)
			{
				return;
			}
			exceptionsHolder.MarkAsHandled(false);
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x000E8360 File Offset: 0x000E6560
		internal void ThrowIfExceptional(bool includeTaskCanceledExceptions)
		{
			Exception exceptions = this.GetExceptions(includeTaskCanceledExceptions);
			if (exceptions != null)
			{
				this.UpdateExceptionObservedStatus();
				throw exceptions;
			}
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x000E8380 File Offset: 0x000E6580
		internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext)
		{
			ExceptionDispatchInfo state2 = ExceptionDispatchInfo.Capture(exception);
			if (targetContext != null)
			{
				try
				{
					targetContext.Post(delegate(object state)
					{
						((ExceptionDispatchInfo)state).Throw();
					}, state2);
					return;
				}
				catch (Exception ex)
				{
					state2 = ExceptionDispatchInfo.Capture(new AggregateException(new Exception[]
					{
						exception,
						ex
					}));
				}
			}
			ThreadPool.QueueUserWorkItem(delegate(object state)
			{
				((ExceptionDispatchInfo)state).Throw();
			}, state2);
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x000E8414 File Offset: 0x000E6614
		internal void UpdateExceptionObservedStatus()
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			Task task = (contingentProperties != null) ? contingentProperties.m_parent : null;
			if (task != null && (this.Options & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None && (task.CreationOptions & TaskCreationOptions.DenyChildAttach) == TaskCreationOptions.None && Task.InternalCurrent == task)
			{
				this.m_stateFlags |= 524288;
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06004586 RID: 17798 RVA: 0x000E8469 File Offset: 0x000E6669
		internal bool IsExceptionObservedByParent
		{
			get
			{
				return (this.m_stateFlags & 524288) != 0;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06004587 RID: 17799 RVA: 0x000E847C File Offset: 0x000E667C
		internal bool IsDelegateInvoked
		{
			get
			{
				return (this.m_stateFlags & 131072) != 0;
			}
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x000E848F File Offset: 0x000E668F
		internal void Finish(bool userDelegateExecute)
		{
			if (this.m_contingentProperties == null)
			{
				this.FinishStageTwo();
				return;
			}
			this.FinishSlow(userDelegateExecute);
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x000E84A8 File Offset: 0x000E66A8
		private void FinishSlow(bool userDelegateExecute)
		{
			if (!userDelegateExecute)
			{
				this.FinishStageTwo();
				return;
			}
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties.m_completionCountdown == 1 || Interlocked.Decrement(ref contingentProperties.m_completionCountdown) == 0)
			{
				this.FinishStageTwo();
			}
			else
			{
				this.AtomicStateUpdate(8388608, 23068672);
			}
			List<Task> exceptionalChildren = contingentProperties.m_exceptionalChildren;
			if (exceptionalChildren != null)
			{
				List<Task> obj = exceptionalChildren;
				lock (obj)
				{
					exceptionalChildren.RemoveAll((Task t) => t.IsExceptionObservedByParent);
				}
			}
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x000E8554 File Offset: 0x000E6754
		private void FinishStageTwo()
		{
			Task.ContingentProperties contingentProperties = Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties);
			if (contingentProperties != null)
			{
				this.AddExceptionsFromChildren(contingentProperties);
			}
			int num;
			if (this.ExceptionRecorded)
			{
				num = 2097152;
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationEnd(this.Id, AsyncCausalityStatus.Error);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.RemoveFromActiveTasks(this);
				}
			}
			else if (this.IsCancellationRequested && this.IsCancellationAcknowledged)
			{
				num = 4194304;
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationEnd(this.Id, AsyncCausalityStatus.Canceled);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.RemoveFromActiveTasks(this);
				}
			}
			else
			{
				num = 16777216;
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationEnd(this.Id, AsyncCausalityStatus.Completed);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.RemoveFromActiveTasks(this);
				}
			}
			Interlocked.Exchange(ref this.m_stateFlags, this.m_stateFlags | num);
			contingentProperties = Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties);
			if (contingentProperties != null)
			{
				contingentProperties.SetCompleted();
				contingentProperties.UnregisterCancellationCallback();
			}
			this.FinishStageThree();
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x000E865C File Offset: 0x000E685C
		internal void FinishStageThree()
		{
			this.m_action = null;
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties != null)
			{
				contingentProperties.m_capturedContext = null;
				this.NotifyParentIfPotentiallyAttachedTask();
			}
			this.FinishContinuations();
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x000E8690 File Offset: 0x000E6890
		internal void NotifyParentIfPotentiallyAttachedTask()
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			Task task = (contingentProperties != null) ? contingentProperties.m_parent : null;
			if (task != null && (task.CreationOptions & TaskCreationOptions.DenyChildAttach) == TaskCreationOptions.None && (this.m_stateFlags & 65535 & 4) != 0)
			{
				task.ProcessChildCompletion(this);
			}
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x000E86D8 File Offset: 0x000E68D8
		internal void ProcessChildCompletion(Task childTask)
		{
			Task.ContingentProperties contingentProperties = Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties);
			if (childTask.IsFaulted && !childTask.IsExceptionObservedByParent)
			{
				if (contingentProperties.m_exceptionalChildren == null)
				{
					Interlocked.CompareExchange<List<Task>>(ref contingentProperties.m_exceptionalChildren, new List<Task>(), null);
				}
				List<Task> exceptionalChildren = contingentProperties.m_exceptionalChildren;
				if (exceptionalChildren != null)
				{
					List<Task> obj = exceptionalChildren;
					lock (obj)
					{
						exceptionalChildren.Add(childTask);
					}
				}
			}
			if (Interlocked.Decrement(ref contingentProperties.m_completionCountdown) == 0)
			{
				this.FinishStageTwo();
			}
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x000E876C File Offset: 0x000E696C
		internal void AddExceptionsFromChildren(Task.ContingentProperties props)
		{
			List<Task> exceptionalChildren = props.m_exceptionalChildren;
			if (exceptionalChildren != null)
			{
				List<Task> obj = exceptionalChildren;
				lock (obj)
				{
					foreach (Task task in exceptionalChildren)
					{
						if (task.IsFaulted && !task.IsExceptionObservedByParent)
						{
							TaskExceptionHolder exceptionsHolder = Volatile.Read<Task.ContingentProperties>(ref task.m_contingentProperties).m_exceptionsHolder;
							this.AddException(exceptionsHolder.CreateExceptionObject(false, null));
						}
					}
				}
				props.m_exceptionalChildren = null;
			}
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x000E8824 File Offset: 0x000E6A24
		internal bool ExecuteEntry()
		{
			int num = 0;
			if (!this.AtomicStateUpdate(131072, 23199744, ref num) && (num & 4194304) == 0)
			{
				return false;
			}
			if (!this.IsCancellationRequested & !this.IsCanceled)
			{
				this.ExecuteWithThreadLocal(ref Task.t_currentTask, null);
			}
			else
			{
				this.ExecuteEntryCancellationRequestedOrCanceled();
			}
			return true;
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x000E887C File Offset: 0x000E6A7C
		internal virtual void ExecuteFromThreadPool(Thread threadPoolThread)
		{
			this.ExecuteEntryUnsafe(threadPoolThread);
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x000E8885 File Offset: 0x000E6A85
		internal void ExecuteEntryUnsafe(Thread threadPoolThread)
		{
			this.m_stateFlags |= 131072;
			if (!this.IsCancellationRequested & !this.IsCanceled)
			{
				this.ExecuteWithThreadLocal(ref Task.t_currentTask, threadPoolThread);
				return;
			}
			this.ExecuteEntryCancellationRequestedOrCanceled();
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x000E88C5 File Offset: 0x000E6AC5
		internal void ExecuteEntryCancellationRequestedOrCanceled()
		{
			if (!this.IsCanceled && (Interlocked.Exchange(ref this.m_stateFlags, this.m_stateFlags | 4194304) & 4194304) == 0)
			{
				this.CancellationCleanupLogic();
			}
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x000E88F8 File Offset: 0x000E6AF8
		private void ExecuteWithThreadLocal(ref Task currentTaskSlot, Thread threadPoolThread = null)
		{
			Task task = currentTaskSlot;
			TplEventSource log = TplEventSource.Log;
			Guid currentThreadActivityId = default(Guid);
			bool flag = log.IsEnabled();
			if (flag)
			{
				if (log.TasksSetActivityIds)
				{
					EventSource.SetCurrentThreadActivityId(TplEventSource.CreateGuidForTaskID(this.Id), out currentThreadActivityId);
				}
				if (task != null)
				{
					log.TaskStarted(task.m_taskScheduler.Id, task.Id, this.Id);
				}
				else
				{
					log.TaskStarted(TaskScheduler.Current.Id, 0, this.Id);
				}
				log.TraceSynchronousWorkBegin(this.Id, CausalitySynchronousWork.Execution);
			}
			try
			{
				currentTaskSlot = this;
				try
				{
					ExecutionContext capturedContext = this.CapturedContext;
					if (capturedContext == null)
					{
						this.InnerInvoke();
					}
					else if (threadPoolThread == null)
					{
						ExecutionContext.RunInternal(capturedContext, Task.s_ecCallback, this);
					}
					else
					{
						ExecutionContext.RunFromThreadPoolDispatchLoop(threadPoolThread, capturedContext, Task.s_ecCallback, this);
					}
				}
				catch (Exception unhandledException)
				{
					this.HandleException(unhandledException);
				}
				if (flag)
				{
					log.TraceSynchronousWorkEnd(CausalitySynchronousWork.Execution);
				}
				this.Finish(true);
			}
			finally
			{
				currentTaskSlot = task;
				if (flag)
				{
					if (task != null)
					{
						log.TaskCompleted(task.m_taskScheduler.Id, task.Id, this.Id, this.IsFaulted);
					}
					else
					{
						log.TaskCompleted(TaskScheduler.Current.Id, 0, this.Id, this.IsFaulted);
					}
					if (log.TasksSetActivityIds)
					{
						EventSource.SetCurrentThreadActivityId(currentThreadActivityId);
					}
				}
			}
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x000E8A50 File Offset: 0x000E6C50
		internal virtual void InnerInvoke()
		{
			Action action = this.m_action as Action;
			if (action != null)
			{
				action();
				return;
			}
			Action<object> action2 = this.m_action as Action<object>;
			if (action2 != null)
			{
				action2(this.m_stateObject);
				return;
			}
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x000E8A90 File Offset: 0x000E6C90
		private void HandleException(Exception unhandledException)
		{
			OperationCanceledException ex = unhandledException as OperationCanceledException;
			if (ex != null && this.IsCancellationRequested && this.m_contingentProperties.m_cancellationToken == ex.CancellationToken)
			{
				this.SetCancellationAcknowledged();
				this.AddException(ex, true);
				return;
			}
			this.AddException(unhandledException);
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x000E8ADD File Offset: 0x000E6CDD
		public TaskAwaiter GetAwaiter()
		{
			return new TaskAwaiter(this);
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x000E8AE5 File Offset: 0x000E6CE5
		public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			return new ConfiguredTaskAwaitable(this, continueOnCapturedContext ? ConfigureAwaitOptions.ContinueOnCapturedContext : ConfigureAwaitOptions.None);
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x000E8AF4 File Offset: 0x000E6CF4
		public ConfiguredTaskAwaitable ConfigureAwait(ConfigureAwaitOptions options)
		{
			if ((options & ~(ConfigureAwaitOptions.ContinueOnCapturedContext | ConfigureAwaitOptions.SuppressThrowing | ConfigureAwaitOptions.ForceYielding)) != ConfigureAwaitOptions.None)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.options);
			}
			return new ConfiguredTaskAwaitable(this, options);
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x000E8B0C File Offset: 0x000E6D0C
		internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			TaskContinuation taskContinuation;
			if (continueOnCapturedContext)
			{
				SynchronizationContext synchronizationContext = SynchronizationContext.Current;
				if (synchronizationContext != null && synchronizationContext.GetType() != typeof(SynchronizationContext))
				{
					taskContinuation = new SynchronizationContextAwaitTaskContinuation(synchronizationContext, continuationAction, flowExecutionContext);
					goto IL_69;
				}
				TaskScheduler internalCurrent = TaskScheduler.InternalCurrent;
				if (internalCurrent != null && internalCurrent != TaskScheduler.Default)
				{
					taskContinuation = new TaskSchedulerAwaitTaskContinuation(internalCurrent, continuationAction, flowExecutionContext);
					goto IL_69;
				}
			}
			if (!flowExecutionContext)
			{
				if (!this.AddTaskContinuation(continuationAction, false))
				{
					AwaitTaskContinuation.UnsafeScheduleAction(continuationAction, this);
				}
				return;
			}
			taskContinuation = new AwaitTaskContinuation(continuationAction, true);
			IL_69:
			if (!this.AddTaskContinuation(taskContinuation, false))
			{
				taskContinuation.Run(this, false);
			}
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x000E8B94 File Offset: 0x000E6D94
		internal void UnsafeSetContinuationForAwait(IAsyncStateMachineBox stateMachineBox, bool continueOnCapturedContext)
		{
			if (continueOnCapturedContext)
			{
				SynchronizationContext synchronizationContext = SynchronizationContext.Current;
				TaskContinuation taskContinuation;
				if (synchronizationContext != null && synchronizationContext.GetType() != typeof(SynchronizationContext))
				{
					taskContinuation = new SynchronizationContextAwaitTaskContinuation(synchronizationContext, stateMachineBox.MoveNextAction, false);
				}
				else
				{
					TaskScheduler internalCurrent = TaskScheduler.InternalCurrent;
					if (internalCurrent == null || internalCurrent == TaskScheduler.Default)
					{
						goto IL_54;
					}
					taskContinuation = new TaskSchedulerAwaitTaskContinuation(internalCurrent, stateMachineBox.MoveNextAction, false);
				}
				if (!this.AddTaskContinuation(taskContinuation, false))
				{
					taskContinuation.Run(this, false);
				}
				return;
			}
			IL_54:
			if (!this.AddTaskContinuation(stateMachineBox, false))
			{
				ThreadPool.UnsafeQueueUserWorkItemInternal(stateMachineBox, true);
			}
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x000E8C1C File Offset: 0x000E6E1C
		public static YieldAwaitable Yield()
		{
			return default(YieldAwaitable);
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x000E8C34 File Offset: 0x000E6E34
		public void Wait()
		{
			this.Wait(-1, default(CancellationToken));
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x000E8C54 File Offset: 0x000E6E54
		public bool Wait(TimeSpan timeout)
		{
			return this.Wait(timeout, default(CancellationToken));
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x000E8C74 File Offset: 0x000E6E74
		public bool Wait(TimeSpan timeout, CancellationToken cancellationToken)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.timeout);
			}
			cancellationToken.ThrowIfCancellationRequested();
			return this.Wait((int)num, cancellationToken);
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x000E8CAF File Offset: 0x000E6EAF
		public void Wait(CancellationToken cancellationToken)
		{
			this.Wait(-1, cancellationToken);
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x000E8CBC File Offset: 0x000E6EBC
		public bool Wait(int millisecondsTimeout)
		{
			return this.Wait(millisecondsTimeout, default(CancellationToken));
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x000E8CDC File Offset: 0x000E6EDC
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (millisecondsTimeout < -1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.millisecondsTimeout);
			}
			if (!this.IsWaitNotificationEnabledOrNotRanToCompletion)
			{
				return true;
			}
			if (!this.InternalWait(millisecondsTimeout, cancellationToken))
			{
				return false;
			}
			if (this.IsWaitNotificationEnabledOrNotRanToCompletion)
			{
				this.NotifyDebuggerOfWaitCompletionIfNecessary();
				if (this.IsCanceled)
				{
					cancellationToken.ThrowIfCancellationRequested();
				}
				this.ThrowIfExceptional(true);
			}
			return true;
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x000E8D30 File Offset: 0x000E6F30
		public Task WaitAsync(CancellationToken cancellationToken)
		{
			return this.WaitAsync(uint.MaxValue, TimeProvider.System, cancellationToken);
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x000E8D40 File Offset: 0x000E6F40
		public Task WaitAsync(TimeSpan timeout)
		{
			return this.WaitAsync(Task.ValidateTimeout(timeout, ExceptionArgument.timeout), TimeProvider.System, default(CancellationToken));
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x000E8D6C File Offset: 0x000E6F6C
		public Task WaitAsync(TimeSpan timeout, TimeProvider timeProvider)
		{
			ArgumentNullException.ThrowIfNull(timeProvider, "timeProvider");
			return this.WaitAsync(Task.ValidateTimeout(timeout, ExceptionArgument.timeout), timeProvider, default(CancellationToken));
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x000E8D9C File Offset: 0x000E6F9C
		public Task WaitAsync(TimeSpan timeout, CancellationToken cancellationToken)
		{
			return this.WaitAsync(Task.ValidateTimeout(timeout, ExceptionArgument.timeout), TimeProvider.System, cancellationToken);
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x000E8DB2 File Offset: 0x000E6FB2
		public Task WaitAsync(TimeSpan timeout, TimeProvider timeProvider, CancellationToken cancellationToken)
		{
			ArgumentNullException.ThrowIfNull(timeProvider, "timeProvider");
			return this.WaitAsync(Task.ValidateTimeout(timeout, ExceptionArgument.timeout), timeProvider, cancellationToken);
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x000E8DCF File Offset: 0x000E6FCF
		private Task WaitAsync(uint millisecondsTimeout, TimeProvider timeProvider, CancellationToken cancellationToken)
		{
			if (this.IsCompleted || (!cancellationToken.CanBeCanceled && millisecondsTimeout == 4294967295U))
			{
				return this;
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (millisecondsTimeout == 0U)
			{
				return Task.FromException(new TimeoutException());
			}
			return new Task.CancellationPromise<VoidTaskResult>(this, millisecondsTimeout, timeProvider, cancellationToken);
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x000E8E10 File Offset: 0x000E7010
		private bool WrappedTryRunInline()
		{
			if (this.m_taskScheduler == null)
			{
				return false;
			}
			bool result;
			try
			{
				result = this.m_taskScheduler.TryRunInline(this, true);
			}
			catch (Exception innerException)
			{
				throw new TaskSchedulerException(innerException);
			}
			return result;
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x000E8E50 File Offset: 0x000E7050
		[MethodImpl(MethodImplOptions.NoOptimization)]
		internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return this.InternalWaitCore(millisecondsTimeout, cancellationToken);
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x000E8E5C File Offset: 0x000E705C
		private bool InternalWaitCore(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			bool flag = this.IsCompleted;
			if (flag)
			{
				return true;
			}
			TplEventSource log = TplEventSource.Log;
			bool flag2 = log.IsEnabled();
			if (flag2)
			{
				Task internalCurrent = Task.InternalCurrent;
				log.TaskWaitBegin((internalCurrent != null) ? internalCurrent.m_taskScheduler.Id : TaskScheduler.Default.Id, (internalCurrent != null) ? internalCurrent.Id : 0, this.Id, TplEventSource.TaskWaitBehavior.Synchronous, 0);
			}
			Debugger.NotifyOfCrossThreadDependency();
			flag = ((millisecondsTimeout == -1 && !cancellationToken.CanBeCanceled && this.WrappedTryRunInline() && this.IsCompleted) || this.SpinThenBlockingWait(millisecondsTimeout, cancellationToken));
			if (flag2)
			{
				Task internalCurrent2 = Task.InternalCurrent;
				if (internalCurrent2 != null)
				{
					log.TaskWaitEnd(internalCurrent2.m_taskScheduler.Id, internalCurrent2.Id, this.Id);
				}
				else
				{
					log.TaskWaitEnd(TaskScheduler.Default.Id, 0, this.Id);
				}
				log.TaskWaitContinuationComplete(this.Id);
			}
			return flag;
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x000E8F3C File Offset: 0x000E713C
		private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			bool flag = millisecondsTimeout == -1;
			uint num = (uint)(flag ? 0 : Environment.TickCount);
			bool flag2 = this.SpinWait(millisecondsTimeout);
			if (!flag2)
			{
				Task.SetOnInvokeMres setOnInvokeMres = new Task.SetOnInvokeMres();
				try
				{
					this.AddCompletionAction(setOnInvokeMres, true);
					if (flag)
					{
						bool flag3 = ThreadPool.NotifyThreadBlocked();
						try
						{
							return setOnInvokeMres.Wait(-1, cancellationToken);
						}
						finally
						{
							if (flag3)
							{
								ThreadPool.NotifyThreadUnblocked();
							}
						}
					}
					uint num2 = (uint)(Environment.TickCount - (int)num);
					if ((ulong)num2 < (ulong)((long)millisecondsTimeout))
					{
						bool flag4 = ThreadPool.NotifyThreadBlocked();
						try
						{
							flag2 = setOnInvokeMres.Wait((int)((long)millisecondsTimeout - (long)((ulong)num2)), cancellationToken);
						}
						finally
						{
							if (flag4)
							{
								ThreadPool.NotifyThreadUnblocked();
							}
						}
					}
				}
				finally
				{
					if (!this.IsCompleted)
					{
						this.RemoveContinuation(setOnInvokeMres);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x000E9000 File Offset: 0x000E7200
		private bool SpinWait(int millisecondsTimeout)
		{
			if (this.IsCompleted)
			{
				return true;
			}
			if (millisecondsTimeout == 0)
			{
				return false;
			}
			int spinCountforSpinBeforeWait = System.Threading.SpinWait.SpinCountforSpinBeforeWait;
			SpinWait spinWait = default(SpinWait);
			while (spinWait.Count < spinCountforSpinBeforeWait)
			{
				spinWait.SpinOnce(-1);
				if (this.IsCompleted)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x000E904C File Offset: 0x000E724C
		internal void InternalCancel()
		{
			TaskSchedulerException ex = null;
			bool flag = false;
			if ((this.m_stateFlags & 65536) != 0)
			{
				TaskScheduler taskScheduler = this.m_taskScheduler;
				try
				{
					flag = (taskScheduler != null && taskScheduler.TryDequeue(this));
				}
				catch (Exception innerException)
				{
					ex = new TaskSchedulerException(innerException);
				}
			}
			this.RecordInternalCancellationRequest();
			bool flag2 = false;
			if (flag)
			{
				flag2 = this.AtomicStateUpdate(4194304, 4325376);
			}
			else if ((this.m_stateFlags & 65536) == 0)
			{
				flag2 = this.AtomicStateUpdate(4194304, 23265280);
			}
			if (flag2)
			{
				this.CancellationCleanupLogic();
			}
			if (ex != null)
			{
				throw ex;
			}
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x000E90EC File Offset: 0x000E72EC
		internal void InternalCancelContinueWithInitialState()
		{
			this.m_stateFlags |= 4194304;
			this.CancellationCleanupLogic();
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x000E910A File Offset: 0x000E730A
		internal void RecordInternalCancellationRequest()
		{
			this.EnsureContingentPropertiesInitialized().m_internalCancellationRequested = 1;
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x000E911C File Offset: 0x000E731C
		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException)
		{
			this.RecordInternalCancellationRequest();
			if (tokenToRecord != default(CancellationToken))
			{
				this.m_contingentProperties.m_cancellationToken = tokenToRecord;
			}
			if (cancellationException != null)
			{
				this.AddException(cancellationException, true);
			}
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x000E9158 File Offset: 0x000E7358
		internal void CancellationCleanupLogic()
		{
			Interlocked.Exchange(ref this.m_stateFlags, this.m_stateFlags | 4194304);
			Task.ContingentProperties contingentProperties = Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties);
			if (contingentProperties != null)
			{
				contingentProperties.SetCompleted();
				contingentProperties.UnregisterCancellationCallback();
			}
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationEnd(this.Id, AsyncCausalityStatus.Canceled);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.RemoveFromActiveTasks(this);
			}
			this.FinishStageThree();
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x000E91CA File Offset: 0x000E73CA
		private void SetCancellationAcknowledged()
		{
			this.m_stateFlags |= 1048576;
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x000E91E4 File Offset: 0x000E73E4
		internal bool TrySetResult()
		{
			if (this.AtomicStateUpdate(83886080, 90177536))
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				if (contingentProperties != null)
				{
					this.NotifyParentIfPotentiallyAttachedTask();
					contingentProperties.SetCompleted();
				}
				this.FinishContinuations();
				return true;
			}
			return false;
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x000E9224 File Offset: 0x000E7424
		internal bool TrySetException(object exceptionObject)
		{
			bool result = false;
			this.EnsureContingentPropertiesInitialized();
			if (this.AtomicStateUpdate(67108864, 90177536))
			{
				this.AddException(exceptionObject);
				this.Finish(false);
				result = true;
			}
			return result;
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x000E925D File Offset: 0x000E745D
		internal bool TrySetCanceled(CancellationToken tokenToRecord)
		{
			return this.TrySetCanceled(tokenToRecord, null);
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x000E9268 File Offset: 0x000E7468
		internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException)
		{
			bool result = false;
			if (this.AtomicStateUpdate(67108864, 90177536))
			{
				this.RecordInternalCancellationRequest(tokenToRecord, cancellationException);
				this.CancellationCleanupLogic();
				result = true;
			}
			return result;
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x000E929C File Offset: 0x000E749C
		internal void FinishContinuations()
		{
			object obj = Interlocked.Exchange(ref this.m_continuationObject, Task.s_taskCompletionSentinel);
			if (obj != null)
			{
				this.RunContinuations(obj);
			}
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x000E92C4 File Offset: 0x000E74C4
		private unsafe void RunContinuations(object continuationObject)
		{
			TplEventSource log = TplEventSource.Log;
			bool flag = log.IsEnabled();
			if (flag)
			{
				log.TraceSynchronousWorkBegin(this.Id, CausalitySynchronousWork.CompletionNotification);
			}
			bool flag2 = (this.m_stateFlags & 64) == 0 && RuntimeHelpers.TryEnsureSufficientExecutionStack();
			IAsyncStateMachineBox asyncStateMachineBox = continuationObject as IAsyncStateMachineBox;
			if (asyncStateMachineBox != null)
			{
				AwaitTaskContinuation.RunOrScheduleAction(asyncStateMachineBox, flag2);
				Task.LogFinishCompletionNotification();
				return;
			}
			Action action = continuationObject as Action;
			if (action != null)
			{
				AwaitTaskContinuation.RunOrScheduleAction(action, flag2);
				Task.LogFinishCompletionNotification();
				return;
			}
			TaskContinuation taskContinuation = continuationObject as TaskContinuation;
			if (taskContinuation != null)
			{
				taskContinuation.Run(this, flag2);
				Task.LogFinishCompletionNotification();
				return;
			}
			ITaskCompletionAction taskCompletionAction = continuationObject as ITaskCompletionAction;
			if (taskCompletionAction == null)
			{
				List<object> list = (List<object>)continuationObject;
				Monitor.Enter(list);
				Monitor.Exit(list);
				Span<object> span = CollectionsMarshal.AsSpan<object>(list);
				if (flag2)
				{
					bool flag3 = false;
					for (int i = 0; i < span.Length; i++)
					{
						object obj = *span[i];
						if (obj != null)
						{
							ContinueWithTaskContinuation continueWithTaskContinuation = obj as ContinueWithTaskContinuation;
							if (continueWithTaskContinuation != null)
							{
								if ((continueWithTaskContinuation.m_options & TaskContinuationOptions.ExecuteSynchronously) == TaskContinuationOptions.None)
								{
									*span[i] = null;
									if (flag)
									{
										log.RunningContinuationList(this.Id, i, continueWithTaskContinuation);
									}
									continueWithTaskContinuation.Run(this, false);
								}
							}
							else if (!(obj is ITaskCompletionAction))
							{
								if (flag3)
								{
									*span[i] = null;
									if (flag)
									{
										log.RunningContinuationList(this.Id, i, obj);
									}
									IAsyncStateMachineBox asyncStateMachineBox2 = obj as IAsyncStateMachineBox;
									if (asyncStateMachineBox2 == null)
									{
										Action action2 = obj as Action;
										if (action2 == null)
										{
											((TaskContinuation)obj).Run(this, false);
										}
										else
										{
											AwaitTaskContinuation.RunOrScheduleAction(action2, false);
										}
									}
									else
									{
										AwaitTaskContinuation.RunOrScheduleAction(asyncStateMachineBox2, false);
									}
								}
								flag3 = true;
							}
						}
					}
				}
				for (int j = 0; j < span.Length; j++)
				{
					object obj2 = *span[j];
					if (obj2 != null)
					{
						*span[j] = null;
						if (flag)
						{
							log.RunningContinuationList(this.Id, j, obj2);
						}
						IAsyncStateMachineBox asyncStateMachineBox3 = obj2 as IAsyncStateMachineBox;
						if (asyncStateMachineBox3 == null)
						{
							Action action3 = obj2 as Action;
							if (action3 == null)
							{
								TaskContinuation taskContinuation2 = obj2 as TaskContinuation;
								if (taskContinuation2 == null)
								{
									this.RunOrQueueCompletionAction((ITaskCompletionAction)obj2, flag2);
								}
								else
								{
									taskContinuation2.Run(this, flag2);
								}
							}
							else
							{
								AwaitTaskContinuation.RunOrScheduleAction(action3, flag2);
							}
						}
						else
						{
							AwaitTaskContinuation.RunOrScheduleAction(asyncStateMachineBox3, flag2);
						}
					}
				}
				Task.LogFinishCompletionNotification();
				return;
			}
			this.RunOrQueueCompletionAction(taskCompletionAction, flag2);
			Task.LogFinishCompletionNotification();
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x000E9519 File Offset: 0x000E7719
		private void RunOrQueueCompletionAction(ITaskCompletionAction completionAction, bool allowInlining)
		{
			if (allowInlining || !completionAction.InvokeMayRunArbitraryCode)
			{
				completionAction.Invoke(this);
				return;
			}
			ThreadPool.UnsafeQueueUserWorkItemInternal(new CompletionActionInvoker(completionAction, this), true);
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x000E953B File Offset: 0x000E773B
		private static void LogFinishCompletionNotification()
		{
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceSynchronousWorkEnd(CausalitySynchronousWork.CompletionNotification);
			}
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x000E9554 File Offset: 0x000E7754
		public Task ContinueWith(Action<Task> continuationAction)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x000E9577 File Offset: 0x000E7777
		public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x000E9588 File Offset: 0x000E7788
		public Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x000E95A8 File Offset: 0x000E77A8
		public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x000E95CB File Offset: 0x000E77CB
		public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x000E95D8 File Offset: 0x000E77D8
		private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
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
			Task task = new ContinuationTaskFromTask(this, continuationAction, null, creationOptions, internalOptions);
			this.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x000E961C File Offset: 0x000E781C
		public Task ContinueWith([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<Task, object> continuationAction, [Nullable(2)] object state)
		{
			return this.ContinueWith(continuationAction, state, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x000E9640 File Offset: 0x000E7840
		public Task ContinueWith([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<Task, object> continuationAction, [Nullable(2)] object state, CancellationToken cancellationToken)
		{
			return this.ContinueWith(continuationAction, state, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x000E9654 File Offset: 0x000E7854
		public Task ContinueWith([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<Task, object> continuationAction, [Nullable(2)] object state, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, state, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x000E9674 File Offset: 0x000E7874
		public Task ContinueWith([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<Task, object> continuationAction, [Nullable(2)] object state, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith(continuationAction, state, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x000E9698 File Offset: 0x000E7898
		public Task ContinueWith([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<Task, object> continuationAction, [Nullable(2)] object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, state, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x000E96A8 File Offset: 0x000E78A8
		private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
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
			Task task = new ContinuationTaskFromTask(this, continuationAction, state, creationOptions, internalOptions);
			this.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x000E96EC File Offset: 0x000E78EC
		public Task<TResult> ContinueWith<[Nullable(2)] TResult>(Func<Task, TResult> continuationFunction)
		{
			return this.ContinueWith<TResult>(continuationFunction, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x000E970F File Offset: 0x000E790F
		public Task<TResult> ContinueWith<[Nullable(2)] TResult>(Func<Task, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return this.ContinueWith<TResult>(continuationFunction, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x000E9720 File Offset: 0x000E7920
		public Task<TResult> ContinueWith<[Nullable(2)] TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler)
		{
			return this.ContinueWith<TResult>(continuationFunction, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x000E9740 File Offset: 0x000E7940
		public Task<TResult> ContinueWith<[Nullable(2)] TResult>(Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith<TResult>(continuationFunction, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x000E9763 File Offset: 0x000E7963
		public Task<TResult> ContinueWith<[Nullable(2)] TResult>(Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith<TResult>(continuationFunction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x000E9770 File Offset: 0x000E7970
		private Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
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
			Task<TResult> task = new ContinuationResultTaskFromTask<TResult>(this, continuationFunction, null, creationOptions, internalOptions);
			this.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x000E97B4 File Offset: 0x000E79B4
		[NullableContext(2)]
		[return: Nullable(1)]
		public Task<TResult> ContinueWith<TResult>([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<Task, object, TResult> continuationFunction, object state)
		{
			return this.ContinueWith<TResult>(continuationFunction, state, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x000E97D8 File Offset: 0x000E79D8
		[NullableContext(2)]
		[return: Nullable(1)]
		public Task<TResult> ContinueWith<TResult>([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<Task, object, TResult> continuationFunction, object state, CancellationToken cancellationToken)
		{
			return this.ContinueWith<TResult>(continuationFunction, state, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x000E97EC File Offset: 0x000E79EC
		public Task<TResult> ContinueWith<[Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<Task, object, TResult> continuationFunction, [Nullable(2)] object state, TaskScheduler scheduler)
		{
			return this.ContinueWith<TResult>(continuationFunction, state, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x000E980C File Offset: 0x000E7A0C
		[NullableContext(2)]
		[return: Nullable(1)]
		public Task<TResult> ContinueWith<TResult>([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<Task, object, TResult> continuationFunction, object state, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith<TResult>(continuationFunction, state, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x000E9830 File Offset: 0x000E7A30
		public Task<TResult> ContinueWith<[Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<Task, object, TResult> continuationFunction, [Nullable(2)] object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith<TResult>(continuationFunction, state, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x000E9840 File Offset: 0x000E7A40
		private Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
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
			Task<TResult> task = new ContinuationResultTaskFromTask<TResult>(this, continuationFunction, state, creationOptions, internalOptions);
			this.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x000E9884 File Offset: 0x000E7A84
		internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions)
		{
			if ((continuationOptions & (TaskContinuationOptions.LongRunning | TaskContinuationOptions.ExecuteSynchronously)) == (TaskContinuationOptions.LongRunning | TaskContinuationOptions.ExecuteSynchronously))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.continuationOptions, ExceptionResource.Task_ContinueWith_ESandLR);
			}
			if ((continuationOptions & ~(TaskContinuationOptions.PreferFairness | TaskContinuationOptions.LongRunning | TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.DenyChildAttach | TaskContinuationOptions.HideScheduler | TaskContinuationOptions.LazyCancellation | TaskContinuationOptions.RunContinuationsAsynchronously | TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.NotOnFaulted | TaskContinuationOptions.NotOnCanceled | TaskContinuationOptions.ExecuteSynchronously)) != TaskContinuationOptions.None)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.continuationOptions);
			}
			if ((continuationOptions & (TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.NotOnFaulted | TaskContinuationOptions.NotOnCanceled)) == (TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.NotOnFaulted | TaskContinuationOptions.NotOnCanceled))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.continuationOptions, ExceptionResource.Task_ContinueWith_NotOnAnything);
			}
			creationOptions = (TaskCreationOptions)(continuationOptions & (TaskContinuationOptions.PreferFairness | TaskContinuationOptions.LongRunning | TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.DenyChildAttach | TaskContinuationOptions.HideScheduler | TaskContinuationOptions.RunContinuationsAsynchronously));
			internalOptions = (((continuationOptions & TaskContinuationOptions.LazyCancellation) != TaskContinuationOptions.None) ? (InternalTaskOptions.ContinuationTask | InternalTaskOptions.LazyCancellation) : InternalTaskOptions.ContinuationTask);
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x000E98EC File Offset: 0x000E7AEC
		internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
		{
			ContinueWithTaskContinuation continueWithTaskContinuation = new ContinueWithTaskContinuation(continuationTask, options, scheduler);
			if (cancellationToken.CanBeCanceled)
			{
				if (this.IsCompleted || cancellationToken.IsCancellationRequested)
				{
					continuationTask.AssignCancellationToken(cancellationToken, null, null);
				}
				else
				{
					continuationTask.AssignCancellationToken(cancellationToken, this, continueWithTaskContinuation);
				}
			}
			if (!continuationTask.IsCompleted)
			{
				if ((this.Options & (TaskCreationOptions)1024) != TaskCreationOptions.None && !(this is ITaskCompletionAction))
				{
					TplEventSource log = TplEventSource.Log;
					if (log.IsEnabled())
					{
						log.AwaitTaskContinuationScheduled(TaskScheduler.Current.Id, Task.CurrentId.GetValueOrDefault(), continuationTask.Id);
					}
				}
				if (!this.AddTaskContinuation(continueWithTaskContinuation, false))
				{
					continueWithTaskContinuation.Run(this, true);
				}
			}
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x000E9992 File Offset: 0x000E7B92
		internal void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers = false)
		{
			if (!this.AddTaskContinuation(action, addBeforeOthers))
			{
				action.Invoke(this);
			}
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x000E99A8 File Offset: 0x000E7BA8
		private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers)
		{
			object obj = this.m_continuationObject;
			if (obj == Task.s_taskCompletionSentinel)
			{
				return false;
			}
			List<object> list = obj as List<object>;
			if (list == null)
			{
				list = new List<object>();
				if (addBeforeOthers)
				{
					list.Add(tc);
					list.Add(obj);
				}
				else
				{
					list.Add(obj);
					list.Add(tc);
				}
				object obj2 = obj;
				obj = Interlocked.CompareExchange(ref this.m_continuationObject, list, obj2);
				if (obj == obj2)
				{
					return true;
				}
				list = (obj as List<object>);
				if (list == null)
				{
					return false;
				}
			}
			List<object> obj3 = list;
			lock (obj3)
			{
				if (this.m_continuationObject == Task.s_taskCompletionSentinel)
				{
					return false;
				}
				if (list.Count == list.Capacity)
				{
					list.RemoveAll((object l) => l == null);
				}
				if (addBeforeOthers)
				{
					list.Insert(0, tc);
				}
				else
				{
					list.Add(tc);
				}
			}
			return true;
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x000E9AA8 File Offset: 0x000E7CA8
		private bool AddTaskContinuation(object tc, bool addBeforeOthers)
		{
			return !this.IsCompleted && ((this.m_continuationObject == null && Interlocked.CompareExchange(ref this.m_continuationObject, tc, null) == null) || this.AddTaskContinuationComplex(tc, addBeforeOthers));
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x000E9AD8 File Offset: 0x000E7CD8
		internal void RemoveContinuation(object continuationObject)
		{
			object obj = this.m_continuationObject;
			if (obj == Task.s_taskCompletionSentinel)
			{
				return;
			}
			List<object> list = obj as List<object>;
			if (list == null)
			{
				obj = Interlocked.CompareExchange(ref this.m_continuationObject, new List<object>(), continuationObject);
				if (obj == continuationObject)
				{
					return;
				}
				list = (obj as List<object>);
				if (list == null)
				{
					return;
				}
			}
			List<object> obj2 = list;
			lock (obj2)
			{
				if (this.m_continuationObject != Task.s_taskCompletionSentinel)
				{
					int num = list.IndexOf(continuationObject);
					if (num >= 0)
					{
						list[num] = null;
					}
				}
			}
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x000E9B74 File Offset: 0x000E7D74
		[UnsupportedOSPlatform("browser")]
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static void WaitAll(params Task[] tasks)
		{
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			Task.WaitAllCore(tasks, -1, default(CancellationToken));
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x000E9BA4 File Offset: 0x000E7DA4
		[UnsupportedOSPlatform("browser")]
		public static void WaitAll([ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<Task> tasks)
		{
			Task.WaitAllCore(tasks, -1, default(CancellationToken));
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x000E9BC4 File Offset: 0x000E7DC4
		[UnsupportedOSPlatform("browser")]
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static bool WaitAll(Task[] tasks, TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			bool flag = num < -1L || num > 2147483647L;
			if (flag)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.timeout);
			}
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			return Task.WaitAllCore(tasks, (int)num, default(CancellationToken));
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x000E9C18 File Offset: 0x000E7E18
		[UnsupportedOSPlatform("browser")]
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static bool WaitAll(Task[] tasks, int millisecondsTimeout)
		{
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			return Task.WaitAllCore(tasks, millisecondsTimeout, default(CancellationToken));
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x000E9C44 File Offset: 0x000E7E44
		[UnsupportedOSPlatform("browser")]
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static void WaitAll(Task[] tasks, CancellationToken cancellationToken)
		{
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			Task.WaitAllCore(tasks, -1, cancellationToken);
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x000E9C5E File Offset: 0x000E7E5E
		[UnsupportedOSPlatform("browser")]
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static bool WaitAll(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			return Task.WaitAllCore(tasks, millisecondsTimeout, cancellationToken);
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x000E9C78 File Offset: 0x000E7E78
		[UnsupportedOSPlatform("browser")]
		public static void WaitAll(IEnumerable<Task> tasks, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			List<Task> list = tasks as List<Task>;
			Span<Task> span;
			if (list == null)
			{
				Task[] array = tasks as Task[];
				span = ((array != null) ? array : CollectionsMarshal.AsSpan<Task>(new List<Task>(tasks)));
			}
			else
			{
				span = CollectionsMarshal.AsSpan<Task>(list);
			}
			Task.WaitAllCore(span, -1, cancellationToken);
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x000E9CCC File Offset: 0x000E7ECC
		[UnsupportedOSPlatform("browser")]
		private unsafe static bool WaitAllCore(ReadOnlySpan<Task> tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (millisecondsTimeout < -1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.millisecondsTimeout);
			}
			cancellationToken.ThrowIfCancellationRequested();
			List<Exception> exceptions = null;
			List<Task> list = null;
			List<Task> list2 = null;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = true;
			for (int i = tasks.Length - 1; i >= 0; i--)
			{
				Task task = *tasks[i];
				if (task == null)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Task_WaitMulti_NullTask, ExceptionArgument.tasks);
				}
				bool flag4 = task.IsCompleted;
				if (!flag4)
				{
					if (millisecondsTimeout != -1 || cancellationToken.CanBeCanceled)
					{
						Task.AddToList<Task>(task, ref list, tasks.Length);
					}
					else
					{
						flag4 = (task.WrappedTryRunInline() && task.IsCompleted);
						if (!flag4)
						{
							Task.AddToList<Task>(task, ref list, tasks.Length);
						}
					}
				}
				if (flag4)
				{
					if (task.IsFaulted)
					{
						flag = true;
					}
					else if (task.IsCanceled)
					{
						flag2 = true;
					}
					if (task.IsWaitNotificationEnabled)
					{
						Task.AddToList<Task>(task, ref list2, 1);
					}
				}
			}
			if (list != null)
			{
				flag3 = Task.WaitAllBlockingCore(list, millisecondsTimeout, cancellationToken);
				if (flag3)
				{
					foreach (Task task2 in list)
					{
						if (task2.IsFaulted)
						{
							flag = true;
						}
						else if (task2.IsCanceled)
						{
							flag2 = true;
						}
						if (task2.IsWaitNotificationEnabled)
						{
							Task.AddToList<Task>(task2, ref list2, 1);
						}
					}
				}
			}
			if (flag3 && list2 != null)
			{
				using (List<Task>.Enumerator enumerator = list2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.NotifyDebuggerOfWaitCompletionIfNecessary())
						{
							break;
						}
					}
				}
			}
			if (flag3 && (flag || flag2))
			{
				if (!flag)
				{
					cancellationToken.ThrowIfCancellationRequested();
				}
				ReadOnlySpan<Task> readOnlySpan = tasks;
				for (int j = 0; j < readOnlySpan.Length; j++)
				{
					Task t = *readOnlySpan[j];
					Task.AddExceptionsForCompletedTask(ref exceptions, t);
				}
				ThrowHelper.ThrowAggregateException(exceptions);
			}
			return flag3;
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x000E9EC0 File Offset: 0x000E80C0
		private static void AddToList<T>(T item, ref List<T> list, int initSize)
		{
			if (list == null)
			{
				list = new List<T>(initSize);
			}
			list.Add(item);
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x000E9ED8 File Offset: 0x000E80D8
		[UnsupportedOSPlatform("browser")]
		private static bool WaitAllBlockingCore(List<Task> tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			bool flag = false;
			Task.SetOnCountdownMres setOnCountdownMres = new Task.SetOnCountdownMres(tasks.Count);
			try
			{
				foreach (Task task in tasks)
				{
					task.AddCompletionAction(setOnCountdownMres, true);
				}
				flag = setOnCountdownMres.Wait(millisecondsTimeout, cancellationToken);
			}
			finally
			{
				if (!flag)
				{
					foreach (Task task2 in tasks)
					{
						if (!task2.IsCompleted)
						{
							task2.RemoveContinuation(setOnCountdownMres);
						}
					}
				}
			}
			return flag;
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x000E9F94 File Offset: 0x000E8194
		internal static void AddExceptionsForCompletedTask(ref List<Exception> exceptions, Task t)
		{
			AggregateException exceptions2 = t.GetExceptions(true);
			if (exceptions2 != null)
			{
				t.UpdateExceptionObservedStatus();
				if (exceptions == null)
				{
					exceptions = new List<Exception>(exceptions2.InnerExceptionCount);
				}
				exceptions.AddRange(exceptions2.InternalInnerExceptions);
			}
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x000E9FD0 File Offset: 0x000E81D0
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static int WaitAny(params Task[] tasks)
		{
			return Task.WaitAnyCore(tasks, -1, default(CancellationToken));
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x000E9FF0 File Offset: 0x000E81F0
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static int WaitAny(Task[] tasks, TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.timeout);
			}
			return Task.WaitAnyCore(tasks, (int)num, default(CancellationToken));
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x000EA02C File Offset: 0x000E822C
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static int WaitAny(Task[] tasks, CancellationToken cancellationToken)
		{
			return Task.WaitAnyCore(tasks, -1, cancellationToken);
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x000EA038 File Offset: 0x000E8238
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static int WaitAny(Task[] tasks, int millisecondsTimeout)
		{
			return Task.WaitAnyCore(tasks, millisecondsTimeout, default(CancellationToken));
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x000EA055 File Offset: 0x000E8255
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static int WaitAny(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return Task.WaitAnyCore(tasks, millisecondsTimeout, cancellationToken);
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x000EA060 File Offset: 0x000E8260
		private static int WaitAnyCore(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			if (millisecondsTimeout < -1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.millisecondsTimeout);
			}
			cancellationToken.ThrowIfCancellationRequested();
			int num = -1;
			for (int i = 0; i < tasks.Length; i++)
			{
				Task task = tasks[i];
				if (task == null)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Task_WaitMulti_NullTask, ExceptionArgument.tasks);
				}
				if (num == -1 && task.IsCompleted)
				{
					num = i;
				}
			}
			if (num == -1 && tasks.Length != 0)
			{
				Task<Task> task2 = TaskFactory.CommonCWAnyLogic<Task>(tasks, true);
				if (task2.Wait(millisecondsTimeout, cancellationToken))
				{
					num = Array.IndexOf<Task>(tasks, task2.Result);
				}
				else
				{
					TaskFactory.CommonCWAnyLogicCleanup(task2);
				}
			}
			GC.KeepAlive(tasks);
			return num;
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x000EA0F0 File Offset: 0x000E82F0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Task<TResult> FromResult<[Nullable(2)] TResult>(TResult result)
		{
			if (result == null)
			{
				return Task<TResult>.s_defaultResultTask;
			}
			if (typeof(TResult) == typeof(bool))
			{
				Task<bool> task = (*(byte*)(&result) != 0) ? TaskCache.s_trueTask : TaskCache.s_falseTask;
				return *(&task);
			}
			if (typeof(TResult) == typeof(int))
			{
				int num = *(int*)(&result);
				if (num - -1 < 10)
				{
					Task<int> task2 = TaskCache.s_int32Tasks[num - -1];
					return *(&task2);
				}
			}
			else if (!RuntimeHelpers.IsReferenceOrContainsReferences<TResult>() && ((sizeof(TResult) == 1 && *(byte*)(&result) == 0) || (sizeof(TResult) == 2 && *(ushort*)(&result) == 0) || (sizeof(TResult) == 4 && *(uint*)(&result) == 0U) || (sizeof(TResult) == 8 && *(long*)(&result) == 0L) || (sizeof(TResult) == sizeof(UInt128) && *(UInt128*)(&result) == default(UInt128))))
			{
				return Task<TResult>.s_defaultResultTask;
			}
			return new Task<TResult>(result);
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x000EA1E9 File Offset: 0x000E83E9
		public static Task FromException(Exception exception)
		{
			if (exception == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exception);
			}
			Task task = new Task();
			task.TrySetException(exception);
			return task;
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x000EA202 File Offset: 0x000E8402
		public static Task<TResult> FromException<[Nullable(2)] TResult>(Exception exception)
		{
			if (exception == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exception);
			}
			Task<TResult> task = new Task<TResult>();
			task.TrySetException(exception);
			return task;
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x000EA21B File Offset: 0x000E841B
		public static Task FromCanceled(CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.cancellationToken);
			}
			return new Task(true, TaskCreationOptions.None, cancellationToken);
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x000EA238 File Offset: 0x000E8438
		public static Task<TResult> FromCanceled<[Nullable(2)] TResult>(CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.cancellationToken);
			}
			return new Task<TResult>(true, default(TResult), TaskCreationOptions.None, cancellationToken);
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x000EA266 File Offset: 0x000E8466
		internal static Task FromCanceled(OperationCanceledException exception)
		{
			Task task = new Task();
			task.TrySetCanceled(exception.CancellationToken, exception);
			return task;
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x000EA27B File Offset: 0x000E847B
		internal static Task<TResult> FromCanceled<TResult>(OperationCanceledException exception)
		{
			Task<TResult> task = new Task<TResult>();
			task.TrySetCanceled(exception.CancellationToken, exception);
			return task;
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x000EA290 File Offset: 0x000E8490
		public static Task Run(Action action)
		{
			return Task.InternalStartNew(null, action, null, default(CancellationToken), TaskScheduler.Default, TaskCreationOptions.DenyChildAttach, InternalTaskOptions.None);
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x000EA2B5 File Offset: 0x000E84B5
		public static Task Run(Action action, CancellationToken cancellationToken)
		{
			return Task.InternalStartNew(null, action, null, cancellationToken, TaskScheduler.Default, TaskCreationOptions.DenyChildAttach, InternalTaskOptions.None);
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x000EA2C8 File Offset: 0x000E84C8
		public static Task<TResult> Run<[Nullable(2)] TResult>(Func<TResult> function)
		{
			return Task<TResult>.StartNew(null, function, default(CancellationToken), TaskCreationOptions.DenyChildAttach, InternalTaskOptions.None, TaskScheduler.Default);
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x000EA2EC File Offset: 0x000E84EC
		public static Task<TResult> Run<[Nullable(2)] TResult>(Func<TResult> function, CancellationToken cancellationToken)
		{
			return Task<TResult>.StartNew(null, function, cancellationToken, TaskCreationOptions.DenyChildAttach, InternalTaskOptions.None, TaskScheduler.Default);
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x000EA300 File Offset: 0x000E8500
		public static Task Run([Nullable(new byte[]
		{
			1,
			2
		})] Func<Task> function)
		{
			return Task.Run(function, default(CancellationToken));
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x000EA31C File Offset: 0x000E851C
		public static Task Run([Nullable(new byte[]
		{
			1,
			2
		})] Func<Task> function, CancellationToken cancellationToken)
		{
			if (function == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.function);
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			return new UnwrapPromise<VoidTaskResult>(Task<Task>.Factory.StartNew(function, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default), true);
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x000EA350 File Offset: 0x000E8550
		public static Task<TResult> Run<[Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<Task<TResult>> function)
		{
			return Task.Run<TResult>(function, default(CancellationToken));
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x000EA36C File Offset: 0x000E856C
		public static Task<TResult> Run<[Nullable(2)] TResult>([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			if (function == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.function);
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<TResult>(cancellationToken);
			}
			return new UnwrapPromise<TResult>(Task<Task<TResult>>.Factory.StartNew(function, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default), true);
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x000EA3A0 File Offset: 0x000E85A0
		public static Task Delay(TimeSpan delay)
		{
			return Task.Delay(delay, TimeProvider.System, default(CancellationToken));
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x000EA3C4 File Offset: 0x000E85C4
		public static Task Delay(TimeSpan delay, TimeProvider timeProvider)
		{
			return Task.Delay(delay, timeProvider, default(CancellationToken));
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x000EA3E1 File Offset: 0x000E85E1
		public static Task Delay(TimeSpan delay, CancellationToken cancellationToken)
		{
			return Task.Delay(delay, TimeProvider.System, cancellationToken);
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x000EA3EF File Offset: 0x000E85EF
		public static Task Delay(TimeSpan delay, TimeProvider timeProvider, CancellationToken cancellationToken)
		{
			ArgumentNullException.ThrowIfNull(timeProvider, "timeProvider");
			return Task.Delay(Task.ValidateTimeout(delay, ExceptionArgument.delay), timeProvider, cancellationToken);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x000EA40C File Offset: 0x000E860C
		public static Task Delay(int millisecondsDelay)
		{
			return Task.Delay(millisecondsDelay, default(CancellationToken));
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x000EA428 File Offset: 0x000E8628
		public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			if (millisecondsDelay < -1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.millisecondsDelay, ExceptionResource.Task_Delay_InvalidMillisecondsDelay);
			}
			return Task.Delay((uint)millisecondsDelay, TimeProvider.System, cancellationToken);
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x000EA443 File Offset: 0x000E8643
		private static Task Delay(uint millisecondsDelay, TimeProvider timeProvider, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (millisecondsDelay == 0U)
			{
				return Task.CompletedTask;
			}
			if (!cancellationToken.CanBeCanceled)
			{
				return new Task.DelayPromise(millisecondsDelay, timeProvider);
			}
			return new Task.DelayPromiseWithCancellation(millisecondsDelay, timeProvider, cancellationToken);
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x000EA478 File Offset: 0x000E8678
		internal static uint ValidateTimeout(TimeSpan timeout, ExceptionArgument argument)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > (long)((ulong)-2))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(argument, ExceptionResource.Task_InvalidTimerTimeSpan);
			}
			return (uint)num;
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x000EA4A4 File Offset: 0x000E86A4
		public static Task WhenAll(IEnumerable<Task> tasks)
		{
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			ICollection<Task> collection = tasks as ICollection<Task>;
			if (collection == null)
			{
				List<Task> list = new List<Task>();
				foreach (Task item in tasks)
				{
					list.Add(item);
				}
				return Task.WhenAll(CollectionsMarshal.AsSpan<Task>(list));
			}
			Task[] array = tasks as Task[];
			if (array != null)
			{
				return Task.WhenAll(array);
			}
			List<Task> list2 = tasks as List<Task>;
			if (list2 != null)
			{
				return Task.WhenAll(CollectionsMarshal.AsSpan<Task>(list2));
			}
			array = new Task[collection.Count];
			collection.CopyTo(array, 0);
			return Task.WhenAll(array);
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x000EA570 File Offset: 0x000E8770
		public static Task WhenAll(params Task[] tasks)
		{
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			return Task.WhenAll(tasks);
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x000EA587 File Offset: 0x000E8787
		public static Task WhenAll([ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<Task> tasks)
		{
			if (tasks.Length == 0)
			{
				return Task.CompletedTask;
			}
			return new Task.WhenAllPromise(tasks);
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x000EA5A0 File Offset: 0x000E87A0
		public static Task<TResult[]> WhenAll<[Nullable(2)] TResult>(IEnumerable<Task<TResult>> tasks)
		{
			Task<TResult>[] array = tasks as Task<TResult>[];
			if (array != null)
			{
				return Task.WhenAll<TResult>(array);
			}
			ICollection<Task<TResult>> collection = tasks as ICollection<Task<TResult>>;
			if (collection != null)
			{
				int count = collection.Count;
				if (count == 0)
				{
					return new Task<TResult[]>(false, Array.Empty<TResult>(), TaskCreationOptions.None, default(CancellationToken));
				}
				array = new Task<TResult>[count];
				collection.CopyTo(array, 0);
				Task<TResult>[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] == null)
					{
						ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_NullTask, ExceptionArgument.tasks);
					}
				}
				return new Task.WhenAllPromise<TResult>(array);
			}
			else
			{
				if (tasks == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
				}
				List<Task<TResult>> list = new List<Task<TResult>>();
				foreach (Task<TResult> task in tasks)
				{
					if (task == null)
					{
						ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_NullTask, ExceptionArgument.tasks);
					}
					list.Add(task);
				}
				if (list.Count != 0)
				{
					return new Task.WhenAllPromise<TResult>(list.ToArray());
				}
				return new Task<TResult[]>(false, Array.Empty<TResult>(), TaskCreationOptions.None, default(CancellationToken));
			}
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x000EA6B0 File Offset: 0x000E88B0
		public static Task<TResult[]> WhenAll<[Nullable(2)] TResult>(params Task<TResult>[] tasks)
		{
			if (tasks == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
			}
			return Task.WhenAll<TResult>(tasks);
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x000EA6C8 File Offset: 0x000E88C8
		public static Task<TResult[]> WhenAll<[Nullable(2)] TResult>([ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			1,
			1
		})] ReadOnlySpan<Task<TResult>> tasks)
		{
			if (tasks.IsEmpty)
			{
				return new Task<TResult[]>(false, Array.Empty<TResult>(), TaskCreationOptions.None, default(CancellationToken));
			}
			Task<TResult>[] array = tasks.ToArray();
			Task<TResult>[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] == null)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_NullTask, ExceptionArgument.tasks);
				}
			}
			return new Task.WhenAllPromise<TResult>(array);
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x000EA720 File Offset: 0x000E8920
		public static Task<Task> WhenAny(params Task[] tasks)
		{
			ArgumentNullException.ThrowIfNull(tasks, "tasks");
			return Task.WhenAnyCore<Task>(tasks);
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x000EA738 File Offset: 0x000E8938
		public static Task<Task> WhenAny([ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<Task> tasks)
		{
			return Task.WhenAnyCore<Task>(tasks);
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x000EA740 File Offset: 0x000E8940
		private unsafe static Task<TTask> WhenAnyCore<TTask>(ReadOnlySpan<TTask> tasks) where TTask : Task
		{
			if (tasks.Length == 2)
			{
				return Task.WhenAny<TTask>(*tasks[0], *tasks[1]);
			}
			if (tasks.IsEmpty)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_EmptyTaskList, ExceptionArgument.tasks);
			}
			TTask[] array = tasks.ToArray();
			TTask[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] == null)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_NullTask, ExceptionArgument.tasks);
				}
			}
			return TaskFactory.CommonCWAnyLogic<TTask>(array, false);
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x000EA7BF File Offset: 0x000E89BF
		public static Task<Task> WhenAny(Task task1, Task task2)
		{
			return Task.WhenAny<Task>(task1, task2);
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x000EA7C8 File Offset: 0x000E89C8
		private static Task<TTask> WhenAny<TTask>(TTask task1, TTask task2) where TTask : Task
		{
			ArgumentNullException.ThrowIfNull(task1, "task1");
			ArgumentNullException.ThrowIfNull(task2, "task2");
			if (task1.IsCompleted)
			{
				return Task.FromResult<TTask>(task1);
			}
			if (!task2.IsCompleted)
			{
				return new Task.TwoTaskWhenAnyPromise<TTask>(task1, task2);
			}
			return Task.FromResult<TTask>(task2);
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x000EA824 File Offset: 0x000E8A24
		public static Task<Task> WhenAny(IEnumerable<Task> tasks)
		{
			return Task.WhenAny<Task>(tasks);
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x000EA82C File Offset: 0x000E8A2C
		private static Task<TTask> WhenAny<TTask>(IEnumerable<TTask> tasks) where TTask : Task
		{
			ICollection<TTask> collection = tasks as ICollection<TTask>;
			if (collection == null)
			{
				if (tasks == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tasks);
				}
				List<TTask> list = new List<TTask>();
				foreach (TTask ttask in tasks)
				{
					if (ttask == null)
					{
						ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_NullTask, ExceptionArgument.tasks);
					}
					list.Add(ttask);
				}
				if (list.Count == 0)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_EmptyTaskList, ExceptionArgument.tasks);
				}
				return TaskFactory.CommonCWAnyLogic<TTask>(list, false);
			}
			if (tasks.GetType() == typeof(List<TTask>))
			{
				return Task.WhenAnyCore<TTask>(CollectionsMarshal.AsSpan<TTask>(Unsafe.As<List<TTask>>(tasks)));
			}
			TTask[] array = tasks as TTask[];
			if (array != null)
			{
				return Task.WhenAnyCore<TTask>(array);
			}
			int count = collection.Count;
			if (count <= 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_EmptyTaskList, ExceptionArgument.tasks);
			}
			TTask[] array2 = new TTask[count];
			collection.CopyTo(array2, 0);
			TTask[] array3 = array2;
			for (int i = 0; i < array3.Length; i++)
			{
				if (array3[i] == null)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_NullTask, ExceptionArgument.tasks);
				}
			}
			return TaskFactory.CommonCWAnyLogic<TTask>(array2, false);
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x000EA960 File Offset: 0x000E8B60
		public static Task<Task<TResult>> WhenAny<[Nullable(2)] TResult>(params Task<TResult>[] tasks)
		{
			ArgumentNullException.ThrowIfNull(tasks, "tasks");
			return Task.WhenAnyCore<Task<TResult>>(tasks);
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x000EA978 File Offset: 0x000E8B78
		public static Task<Task<TResult>> WhenAny<[Nullable(2)] TResult>([ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			1,
			1
		})] ReadOnlySpan<Task<TResult>> tasks)
		{
			return Task.WhenAnyCore<Task<TResult>>(tasks);
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x000EA980 File Offset: 0x000E8B80
		public static Task<Task<TResult>> WhenAny<[Nullable(2)] TResult>(Task<TResult> task1, Task<TResult> task2)
		{
			return Task.WhenAny<Task<TResult>>(task1, task2);
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x000EA989 File Offset: 0x000E8B89
		public static Task<Task<TResult>> WhenAny<[Nullable(2)] TResult>(IEnumerable<Task<TResult>> tasks)
		{
			return Task.WhenAny<Task<TResult>>(tasks);
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x000EA991 File Offset: 0x000E8B91
		public static IAsyncEnumerable<Task> WhenEach(params Task[] tasks)
		{
			ArgumentNullException.ThrowIfNull(tasks, "tasks");
			return Task.WhenEach(tasks);
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x000EA9AC File Offset: 0x000E8BAC
		public static IAsyncEnumerable<Task> WhenEach([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<Task> tasks)
		{
			return Task.WhenEachState.Iterate<Task>(Task.WhenEachState.Create(tasks), default(CancellationToken));
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x000EA9D0 File Offset: 0x000E8BD0
		public static IAsyncEnumerable<Task> WhenEach(IEnumerable<Task> tasks)
		{
			return Task.WhenEachState.Iterate<Task>(Task.WhenEachState.Create(tasks), default(CancellationToken));
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x000EA9F1 File Offset: 0x000E8BF1
		public static IAsyncEnumerable<Task<TResult>> WhenEach<[Nullable(2)] TResult>(params Task<TResult>[] tasks)
		{
			ArgumentNullException.ThrowIfNull(tasks, "tasks");
			return Task.WhenEach<TResult>(tasks);
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x000EAA0C File Offset: 0x000E8C0C
		public static IAsyncEnumerable<Task<TResult>> WhenEach<[Nullable(2)] TResult>([Nullable(new byte[]
		{
			0,
			1,
			1
		})] ReadOnlySpan<Task<TResult>> tasks)
		{
			return Task.WhenEachState.Iterate<Task<TResult>>(Task.WhenEachState.Create(ReadOnlySpan<Task>.CastUp<Task<TResult>>(tasks)), default(CancellationToken));
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x000EAA34 File Offset: 0x000E8C34
		public static IAsyncEnumerable<Task<TResult>> WhenEach<[Nullable(2)] TResult>(IEnumerable<Task<TResult>> tasks)
		{
			return Task.WhenEachState.Iterate<Task<TResult>>(Task.WhenEachState.Create(tasks), default(CancellationToken));
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x000EAA55 File Offset: 0x000E8C55
		internal static Task<TResult> CreateUnwrapPromise<TResult>(Task outerTask, bool lookForOce)
		{
			return new UnwrapPromise<TResult>(outerTask, lookForOce);
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x000EAA5E File Offset: 0x000E8C5E
		internal virtual Delegate[] GetDelegateContinuationsForDebugger()
		{
			if (this.m_continuationObject != this)
			{
				return Task.GetDelegatesFromContinuationObject(this.m_continuationObject);
			}
			return null;
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x000EAA7C File Offset: 0x000E8C7C
		private static Delegate[] GetDelegatesFromContinuationObject(object continuationObject)
		{
			if (continuationObject != null)
			{
				Action action = continuationObject as Action;
				if (action != null)
				{
					return new Delegate[]
					{
						AsyncMethodBuilderCore.TryGetStateMachineForDebugger(action)
					};
				}
				TaskContinuation taskContinuation = continuationObject as TaskContinuation;
				if (taskContinuation != null)
				{
					return taskContinuation.GetDelegateContinuationsForDebugger();
				}
				Task task = continuationObject as Task;
				if (task != null)
				{
					Delegate[] delegateContinuationsForDebugger = task.GetDelegateContinuationsForDebugger();
					if (delegateContinuationsForDebugger != null)
					{
						return delegateContinuationsForDebugger;
					}
				}
				ITaskCompletionAction taskCompletionAction = continuationObject as ITaskCompletionAction;
				if (taskCompletionAction != null)
				{
					return new Delegate[]
					{
						new Action<Task>(taskCompletionAction.Invoke)
					};
				}
				List<object> list = continuationObject as List<object>;
				if (list != null)
				{
					List<Delegate> list2 = new List<Delegate>();
					foreach (object continuationObject2 in list)
					{
						Delegate[] delegatesFromContinuationObject = Task.GetDelegatesFromContinuationObject(continuationObject2);
						if (delegatesFromContinuationObject != null)
						{
							foreach (Delegate @delegate in delegatesFromContinuationObject)
							{
								if (@delegate != null)
								{
									list2.Add(@delegate);
								}
							}
						}
					}
					return list2.ToArray();
				}
			}
			return null;
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x000EAB84 File Offset: 0x000E8D84
		private static Task GetActiveTaskFromId(int taskId)
		{
			Task result = null;
			Dictionary<int, Task> dictionary = Task.s_currentActiveTasks;
			if (dictionary != null)
			{
				dictionary.TryGetValue(taskId, out result);
			}
			return result;
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x000EAC00 File Offset: 0x000E8E00
		[CompilerGenerated]
		private Task.ContingentProperties <EnsureContingentPropertiesInitialized>g__InitializeContingentProperties|81_0()
		{
			Interlocked.CompareExchange<Task.ContingentProperties>(ref this.m_contingentProperties, new Task.ContingentProperties(), null);
			return this.m_contingentProperties;
		}

		// Token: 0x04001006 RID: 4102
		[ThreadStatic]
		internal static Task t_currentTask;

		// Token: 0x04001007 RID: 4103
		private static int s_taskIdCounter;

		// Token: 0x04001008 RID: 4104
		private int m_taskId;

		// Token: 0x04001009 RID: 4105
		internal Delegate m_action;

		// Token: 0x0400100A RID: 4106
		private protected object m_stateObject;

		// Token: 0x0400100B RID: 4107
		internal TaskScheduler m_taskScheduler;

		// Token: 0x0400100C RID: 4108
		internal volatile int m_stateFlags;

		// Token: 0x0400100D RID: 4109
		private volatile object m_continuationObject;

		// Token: 0x0400100E RID: 4110
		private static readonly object s_taskCompletionSentinel = new object();

		// Token: 0x0400100F RID: 4111
		internal static bool s_asyncDebuggingEnabled;

		// Token: 0x04001010 RID: 4112
		private static Dictionary<int, Task> s_currentActiveTasks;

		// Token: 0x04001011 RID: 4113
		internal Task.ContingentProperties m_contingentProperties;

		// Token: 0x04001013 RID: 4115
		internal static readonly Task<VoidTaskResult> s_cachedCompleted = new Task<VoidTaskResult>(false, default(VoidTaskResult), (TaskCreationOptions)16384, default(CancellationToken));

		// Token: 0x04001014 RID: 4116
		private static readonly ContextCallback s_ecCallback = delegate(object obj)
		{
			Unsafe.As<Task>(obj).InnerInvoke();
		};

		// Token: 0x020004A9 RID: 1193
		[Flags]
		internal enum TaskStateFlags
		{
			// Token: 0x04001016 RID: 4118
			Started = 65536,
			// Token: 0x04001017 RID: 4119
			DelegateInvoked = 131072,
			// Token: 0x04001018 RID: 4120
			Disposed = 262144,
			// Token: 0x04001019 RID: 4121
			ExceptionObservedByParent = 524288,
			// Token: 0x0400101A RID: 4122
			CancellationAcknowledged = 1048576,
			// Token: 0x0400101B RID: 4123
			Faulted = 2097152,
			// Token: 0x0400101C RID: 4124
			Canceled = 4194304,
			// Token: 0x0400101D RID: 4125
			WaitingOnChildren = 8388608,
			// Token: 0x0400101E RID: 4126
			RanToCompletion = 16777216,
			// Token: 0x0400101F RID: 4127
			WaitingForActivation = 33554432,
			// Token: 0x04001020 RID: 4128
			CompletionReserved = 67108864,
			// Token: 0x04001021 RID: 4129
			WaitCompletionNotification = 268435456,
			// Token: 0x04001022 RID: 4130
			ExecutionContextIsNull = 536870912,
			// Token: 0x04001023 RID: 4131
			TaskScheduledWasFired = 1073741824,
			// Token: 0x04001024 RID: 4132
			CompletedMask = 23068672,
			// Token: 0x04001025 RID: 4133
			OptionsMask = 65535
		}

		// Token: 0x020004AA RID: 1194
		internal sealed class ContingentProperties
		{
			// Token: 0x0600461E RID: 17950 RVA: 0x000EAC1C File Offset: 0x000E8E1C
			internal void SetCompleted()
			{
				ManualResetEventSlim completionEvent = this.m_completionEvent;
				if (completionEvent != null)
				{
					Task.ContingentProperties.SetEvent(completionEvent);
				}
			}

			// Token: 0x0600461F RID: 17951 RVA: 0x000EAC3C File Offset: 0x000E8E3C
			internal static void SetEvent(ManualResetEventSlim mres)
			{
				try
				{
					mres.Set();
				}
				catch (ObjectDisposedException)
				{
				}
			}

			// Token: 0x06004620 RID: 17952 RVA: 0x000EAC64 File Offset: 0x000E8E64
			internal void UnregisterCancellationCallback()
			{
				if (this.m_cancellationRegistration != null)
				{
					try
					{
						this.m_cancellationRegistration.Value.Dispose();
					}
					catch (ObjectDisposedException)
					{
					}
					this.m_cancellationRegistration = null;
				}
			}

			// Token: 0x04001026 RID: 4134
			internal ExecutionContext m_capturedContext;

			// Token: 0x04001027 RID: 4135
			internal volatile ManualResetEventSlim m_completionEvent;

			// Token: 0x04001028 RID: 4136
			internal volatile TaskExceptionHolder m_exceptionsHolder;

			// Token: 0x04001029 RID: 4137
			internal CancellationToken m_cancellationToken;

			// Token: 0x0400102A RID: 4138
			internal StrongBox<CancellationTokenRegistration> m_cancellationRegistration;

			// Token: 0x0400102B RID: 4139
			internal volatile int m_internalCancellationRequested;

			// Token: 0x0400102C RID: 4140
			internal volatile int m_completionCountdown = 1;

			// Token: 0x0400102D RID: 4141
			internal volatile List<Task> m_exceptionalChildren;

			// Token: 0x0400102E RID: 4142
			internal Task m_parent;
		}

		// Token: 0x020004AB RID: 1195
		internal sealed class CancellationPromise<TResult> : Task<TResult>, ITaskCompletionAction
		{
			// Token: 0x06004622 RID: 17954 RVA: 0x000EACBC File Offset: 0x000E8EBC
			internal CancellationPromise(Task source, uint millisecondsDelay, TimeProvider timeProvider, CancellationToken token)
			{
				this._task = source;
				source.AddCompletionAction(this, false);
				if (millisecondsDelay != 4294967295U)
				{
					TimerCallback timerCallback = delegate(object state)
					{
						Task.CancellationPromise<TResult> cancellationPromise = (Task.CancellationPromise<TResult>)state;
						if (cancellationPromise.TrySetException(new TimeoutException()))
						{
							cancellationPromise.Cleanup();
						}
					};
					if (timeProvider == TimeProvider.System)
					{
						this._timer = new TimerQueueTimer(timerCallback, this, millisecondsDelay, uint.MaxValue, false);
					}
					else
					{
						using (ExecutionContext.SuppressFlow())
						{
							this._timer = timeProvider.CreateTimer(timerCallback, this, TimeSpan.FromMilliseconds((long)((ulong)millisecondsDelay), 0L), Timeout.InfiniteTimeSpan);
						}
					}
				}
				this._registration = token.UnsafeRegister(delegate(object state, CancellationToken cancellationToken)
				{
					Task.CancellationPromise<TResult> cancellationPromise = (Task.CancellationPromise<TResult>)state;
					if (cancellationPromise.TrySetCanceled(cancellationToken))
					{
						cancellationPromise.Cleanup();
					}
				}, this);
				if (base.IsCompleted)
				{
					this.Cleanup();
				}
			}

			// Token: 0x17000C78 RID: 3192
			// (get) Token: 0x06004623 RID: 17955 RVA: 0x000070DD File Offset: 0x000052DD
			bool ITaskCompletionAction.InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06004624 RID: 17956 RVA: 0x000EAD9C File Offset: 0x000E8F9C
			void ITaskCompletionAction.Invoke(Task completingTask)
			{
				TaskStatus status = completingTask.Status;
				bool flag;
				if (status != TaskStatus.Canceled)
				{
					if (status != TaskStatus.Faulted)
					{
						Task<TResult> task = completingTask as Task<TResult>;
						flag = ((task != null) ? base.TrySetResult(task.Result) : base.TrySetResult());
					}
					else
					{
						flag = base.TrySetException(completingTask.GetExceptionDispatchInfos());
					}
				}
				else
				{
					flag = base.TrySetCanceled(completingTask.CancellationToken, completingTask.GetCancellationExceptionDispatchInfo());
				}
				if (flag)
				{
					this.Cleanup();
				}
			}

			// Token: 0x06004625 RID: 17957 RVA: 0x000EAE06 File Offset: 0x000E9006
			private void Cleanup()
			{
				this._registration.Dispose();
				ITimer timer = this._timer;
				if (timer != null)
				{
					timer.Dispose();
				}
				this._task.RemoveContinuation(this);
			}

			// Token: 0x0400102F RID: 4143
			private readonly Task _task;

			// Token: 0x04001030 RID: 4144
			private readonly CancellationTokenRegistration _registration;

			// Token: 0x04001031 RID: 4145
			private readonly ITimer _timer;
		}

		// Token: 0x020004AD RID: 1197
		private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
		{
			// Token: 0x0600462A RID: 17962 RVA: 0x000EAE87 File Offset: 0x000E9087
			internal SetOnInvokeMres() : base(false, 0)
			{
			}

			// Token: 0x0600462B RID: 17963 RVA: 0x000EAE91 File Offset: 0x000E9091
			public void Invoke(Task completingTask)
			{
				base.Set();
			}

			// Token: 0x17000C79 RID: 3193
			// (get) Token: 0x0600462C RID: 17964 RVA: 0x00007B65 File Offset: 0x00005D65
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return false;
				}
			}
		}

		// Token: 0x020004AE RID: 1198
		private sealed class SetOnCountdownMres : ManualResetEventSlim, ITaskCompletionAction
		{
			// Token: 0x0600462D RID: 17965 RVA: 0x000EAE99 File Offset: 0x000E9099
			internal SetOnCountdownMres(int count)
			{
				this._count = count;
			}

			// Token: 0x0600462E RID: 17966 RVA: 0x000EAEA8 File Offset: 0x000E90A8
			public void Invoke(Task completingTask)
			{
				if (Interlocked.Decrement(ref this._count) == 0)
				{
					base.Set();
				}
			}

			// Token: 0x17000C7A RID: 3194
			// (get) Token: 0x0600462F RID: 17967 RVA: 0x00007B65 File Offset: 0x00005D65
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return false;
				}
			}

			// Token: 0x04001035 RID: 4149
			private int _count;
		}

		// Token: 0x020004AF RID: 1199
		private class DelayPromise : Task
		{
			// Token: 0x06004630 RID: 17968 RVA: 0x000EAEC0 File Offset: 0x000E90C0
			internal DelayPromise(uint millisecondsDelay, TimeProvider timeProvider)
			{
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationBegin(base.Id, "Task.Delay", 0L);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.AddToActiveTasks(this);
				}
				if (millisecondsDelay != 4294967295U)
				{
					if (timeProvider == TimeProvider.System)
					{
						this._timer = new TimerQueueTimer(Task.DelayPromise.s_timerCallback, this, millisecondsDelay, uint.MaxValue, false);
					}
					else
					{
						using (ExecutionContext.SuppressFlow())
						{
							this._timer = timeProvider.CreateTimer(Task.DelayPromise.s_timerCallback, this, TimeSpan.FromMilliseconds((long)((ulong)millisecondsDelay), 0L), Timeout.InfiniteTimeSpan);
						}
					}
					if (base.IsCompleted)
					{
						this._timer.Dispose();
					}
				}
			}

			// Token: 0x06004631 RID: 17969 RVA: 0x000EAF80 File Offset: 0x000E9180
			private static void TimerCallback(object state)
			{
				((Task.DelayPromise)state).CompleteTimedOut();
			}

			// Token: 0x06004632 RID: 17970 RVA: 0x000EAF8D File Offset: 0x000E918D
			private void CompleteTimedOut()
			{
				if (base.TrySetResult())
				{
					this.Cleanup();
					if (Task.s_asyncDebuggingEnabled)
					{
						Task.RemoveFromActiveTasks(this);
					}
					if (TplEventSource.Log.IsEnabled())
					{
						TplEventSource.Log.TraceOperationEnd(base.Id, AsyncCausalityStatus.Completed);
					}
				}
			}

			// Token: 0x06004633 RID: 17971 RVA: 0x000EAFC7 File Offset: 0x000E91C7
			protected virtual void Cleanup()
			{
				ITimer timer = this._timer;
				if (timer == null)
				{
					return;
				}
				timer.Dispose();
			}

			// Token: 0x04001036 RID: 4150
			private static readonly TimerCallback s_timerCallback = new TimerCallback(Task.DelayPromise.TimerCallback);

			// Token: 0x04001037 RID: 4151
			private readonly ITimer _timer;
		}

		// Token: 0x020004B0 RID: 1200
		private sealed class DelayPromiseWithCancellation : Task.DelayPromise
		{
			// Token: 0x06004635 RID: 17973 RVA: 0x000EAFEC File Offset: 0x000E91EC
			internal DelayPromiseWithCancellation(uint millisecondsDelay, TimeProvider timeProvider, CancellationToken token) : base(millisecondsDelay, timeProvider)
			{
				this._registration = token.UnsafeRegister(delegate(object state, CancellationToken cancellationToken)
				{
					Task.DelayPromiseWithCancellation delayPromiseWithCancellation = (Task.DelayPromiseWithCancellation)state;
					delayPromiseWithCancellation.AtomicStateUpdate(64, 0);
					if (delayPromiseWithCancellation.TrySetCanceled(cancellationToken))
					{
						delayPromiseWithCancellation.Cleanup();
					}
				}, this);
				if (base.IsCompleted)
				{
					this._registration.Dispose();
				}
			}

			// Token: 0x06004636 RID: 17974 RVA: 0x000EB041 File Offset: 0x000E9241
			protected override void Cleanup()
			{
				this._registration.Dispose();
				base.Cleanup();
			}

			// Token: 0x04001038 RID: 4152
			private readonly CancellationTokenRegistration _registration;
		}

		// Token: 0x020004B2 RID: 1202
		private sealed class WhenAllPromise : Task, ITaskCompletionAction
		{
			// Token: 0x0600463A RID: 17978 RVA: 0x000EB090 File Offset: 0x000E9290
			internal unsafe WhenAllPromise(ReadOnlySpan<Task> tasks)
			{
				this.m_stateFlags |= 2048;
				ReadOnlySpan<Task> readOnlySpan = tasks;
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					if (!(*readOnlySpan[i]))
					{
						ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_NullTask, ExceptionArgument.tasks);
					}
				}
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationBegin(base.Id, "Task.WhenAll", 0L);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.AddToActiveTasks(this);
				}
				this._remainingToComplete = tasks.Length;
				readOnlySpan = tasks;
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					Task task = *readOnlySpan[i];
					if (task == null || task.IsCompleted)
					{
						this.Invoke(task);
					}
					else
					{
						task.AddCompletionAction(this, false);
					}
				}
			}

			// Token: 0x0600463B RID: 17979 RVA: 0x000EB15C File Offset: 0x000E935C
			public void Invoke(Task completedTask)
			{
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationRelation(base.Id, CausalityRelation.Join);
				}
				if (completedTask != null)
				{
					if (completedTask.IsWaitNotificationEnabled)
					{
						base.SetNotificationForWaitCompletion(true);
					}
					if (!completedTask.IsCompletedSuccessfully)
					{
						object obj = Interlocked.CompareExchange(ref this.m_stateObject, completedTask, null);
						if (obj != null)
						{
							Task task;
							do
							{
								List<Task> list = obj as List<Task>;
								if (list != null)
								{
									List<Task> obj2 = list;
									lock (obj2)
									{
										list.Add(completedTask);
										break;
									}
								}
								task = (Task)obj;
								obj = Interlocked.CompareExchange(ref this.m_stateObject, new List<Task>
								{
									task,
									completedTask
								}, task);
							}
							while (obj != task);
						}
					}
				}
				if (Interlocked.Decrement(ref this._remainingToComplete) == 0)
				{
					object stateObject = this.m_stateObject;
					if (stateObject == null)
					{
						if (TplEventSource.Log.IsEnabled())
						{
							TplEventSource.Log.TraceOperationEnd(base.Id, AsyncCausalityStatus.Completed);
						}
						if (Task.s_asyncDebuggingEnabled)
						{
							Task.RemoveFromActiveTasks(this);
						}
						base.TrySetResult();
						return;
					}
					Task.WhenAllPromise.<>c__DisplayClass2_0 CS$<>8__locals1;
					CS$<>8__locals1.observedExceptions = null;
					CS$<>8__locals1.canceledTask = null;
					List<Task> list2 = stateObject as List<Task>;
					if (list2 != null)
					{
						using (List<Task>.Enumerator enumerator = list2.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Task task2 = enumerator.Current;
								Task.WhenAllPromise.<Invoke>g__HandleTask|2_0(task2, ref CS$<>8__locals1);
							}
							goto IL_149;
						}
					}
					Task.WhenAllPromise.<Invoke>g__HandleTask|2_0((Task)stateObject, ref CS$<>8__locals1);
					IL_149:
					if (CS$<>8__locals1.observedExceptions != null)
					{
						base.TrySetException(CS$<>8__locals1.observedExceptions);
						return;
					}
					if (CS$<>8__locals1.canceledTask != null)
					{
						base.TrySetCanceled(CS$<>8__locals1.canceledTask.CancellationToken, CS$<>8__locals1.canceledTask.GetCancellationExceptionDispatchInfo());
					}
				}
			}

			// Token: 0x17000C7B RID: 3195
			// (get) Token: 0x0600463C RID: 17980 RVA: 0x000070DD File Offset: 0x000052DD
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x0600463D RID: 17981 RVA: 0x000EB310 File Offset: 0x000E9510
			[CompilerGenerated]
			internal static void <Invoke>g__HandleTask|2_0(Task task, ref Task.WhenAllPromise.<>c__DisplayClass2_0 A_1)
			{
				if (task.IsFaulted)
				{
					List<ExceptionDispatchInfo> list;
					if ((list = A_1.observedExceptions) == null)
					{
						list = (A_1.observedExceptions = new List<ExceptionDispatchInfo>());
					}
					list.AddRange(task.GetExceptionDispatchInfos());
					return;
				}
				if (task.IsCanceled && A_1.canceledTask == null)
				{
					A_1.canceledTask = task;
				}
			}

			// Token: 0x0400103B RID: 4155
			private int _remainingToComplete;
		}

		// Token: 0x020004B4 RID: 1204
		private sealed class WhenAllPromise<T> : Task<T[]>, ITaskCompletionAction
		{
			// Token: 0x0600463E RID: 17982 RVA: 0x000EB360 File Offset: 0x000E9560
			internal WhenAllPromise(Task<T>[] tasks)
			{
				this.m_tasks = tasks;
				this.m_count = tasks.Length;
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationBegin(base.Id, "Task.WhenAll", 0L);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.AddToActiveTasks(this);
				}
				foreach (Task<T> task in tasks)
				{
					if (task.IsCompleted)
					{
						this.Invoke(task);
					}
					else
					{
						task.AddCompletionAction(this, false);
					}
				}
			}

			// Token: 0x0600463F RID: 17983 RVA: 0x000EB3E4 File Offset: 0x000E95E4
			public void Invoke(Task ignored)
			{
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationRelation(base.Id, CausalityRelation.Join);
				}
				if (Interlocked.Decrement(ref this.m_count) == 0)
				{
					T[] array = new T[this.m_tasks.Length];
					List<ExceptionDispatchInfo> list = null;
					Task task = null;
					for (int i = 0; i < this.m_tasks.Length; i++)
					{
						Task<T> task2 = this.m_tasks[i];
						if (task2.IsFaulted)
						{
							if (list == null)
							{
								list = new List<ExceptionDispatchInfo>();
							}
							list.AddRange(task2.GetExceptionDispatchInfos());
						}
						else if (task2.IsCanceled)
						{
							if (task == null)
							{
								task = task2;
							}
						}
						else
						{
							array[i] = task2.GetResultCore(false);
						}
						if (task2.IsWaitNotificationEnabled)
						{
							base.SetNotificationForWaitCompletion(true);
						}
						else
						{
							this.m_tasks[i] = null;
						}
					}
					if (list != null)
					{
						base.TrySetException(list);
						return;
					}
					if (task != null)
					{
						base.TrySetCanceled(task.CancellationToken, task.GetCancellationExceptionDispatchInfo());
						return;
					}
					if (TplEventSource.Log.IsEnabled())
					{
						TplEventSource.Log.TraceOperationEnd(base.Id, AsyncCausalityStatus.Completed);
					}
					if (Task.s_asyncDebuggingEnabled)
					{
						Task.RemoveFromActiveTasks(this);
					}
					base.TrySetResult(array);
				}
			}

			// Token: 0x17000C7C RID: 3196
			// (get) Token: 0x06004640 RID: 17984 RVA: 0x000070DD File Offset: 0x000052DD
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000C7D RID: 3197
			// (get) Token: 0x06004641 RID: 17985 RVA: 0x000EB500 File Offset: 0x000E9700
			private protected override bool ShouldNotifyDebuggerOfWaitCompletion
			{
				get
				{
					if (base.ShouldNotifyDebuggerOfWaitCompletion)
					{
						Task[] tasks = this.m_tasks;
						return Task.AnyTaskRequiresNotifyDebuggerOfWaitCompletion(tasks);
					}
					return false;
				}
			}

			// Token: 0x0400103E RID: 4158
			private readonly Task<T>[] m_tasks;

			// Token: 0x0400103F RID: 4159
			private int m_count;
		}

		// Token: 0x020004B5 RID: 1205
		private sealed class TwoTaskWhenAnyPromise<TTask> : Task<TTask>, ITaskCompletionAction where TTask : Task
		{
			// Token: 0x06004642 RID: 17986 RVA: 0x000EB524 File Offset: 0x000E9724
			public TwoTaskWhenAnyPromise(TTask task1, TTask task2)
			{
				this._task1 = task1;
				this._task2 = task2;
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationBegin(base.Id, "Task.WhenAny", 0L);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.AddToActiveTasks(this);
				}
				task1.AddCompletionAction(this, false);
				task2.AddCompletionAction(this, false);
				if (task1.IsCompleted)
				{
					task2.RemoveContinuation(this);
				}
			}

			// Token: 0x06004643 RID: 17987 RVA: 0x000EB5AC File Offset: 0x000E97AC
			public void Invoke(Task completingTask)
			{
				Task task;
				if ((task = Interlocked.Exchange<TTask>(ref this._task1, default(TTask))) != null)
				{
					Task task2 = this._task2;
					this._task2 = default(TTask);
					if (TplEventSource.Log.IsEnabled())
					{
						TplEventSource.Log.TraceOperationRelation(base.Id, CausalityRelation.Choice);
						TplEventSource.Log.TraceOperationEnd(base.Id, AsyncCausalityStatus.Completed);
					}
					if (Task.s_asyncDebuggingEnabled)
					{
						Task.RemoveFromActiveTasks(this);
					}
					if (!task.IsCompleted)
					{
						task.RemoveContinuation(this);
					}
					else
					{
						task2.RemoveContinuation(this);
					}
					base.TrySetResult((TTask)((object)completingTask));
				}
			}

			// Token: 0x17000C7E RID: 3198
			// (get) Token: 0x06004644 RID: 17988 RVA: 0x000070DD File Offset: 0x000052DD
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x04001040 RID: 4160
			private TTask _task1;

			// Token: 0x04001041 RID: 4161
			private TTask _task2;
		}

		// Token: 0x020004B6 RID: 1206
		private sealed class WhenEachState : Queue<Task>, IValueTaskSource, ITaskCompletionAction
		{
			// Token: 0x06004645 RID: 17989 RVA: 0x000EB64E File Offset: 0x000E984E
			public bool TryStart()
			{
				return Interlocked.Exchange(ref this._enumerated, 1) == 0;
			}

			// Token: 0x17000C7F RID: 3199
			// (get) Token: 0x06004646 RID: 17990 RVA: 0x000EB65F File Offset: 0x000E985F
			// (set) Token: 0x06004647 RID: 17991 RVA: 0x000EB667 File Offset: 0x000E9867
			public int Remaining { get; set; }

			// Token: 0x06004648 RID: 17992 RVA: 0x000EB670 File Offset: 0x000E9870
			void ITaskCompletionAction.Invoke(Task completingTask)
			{
				lock (this)
				{
					base.Enqueue(completingTask);
					if (base.Count == 1)
					{
						this._waitForNextCompletedTask.SetResult(false);
					}
				}
			}

			// Token: 0x17000C80 RID: 3200
			// (get) Token: 0x06004649 RID: 17993 RVA: 0x00007B65 File Offset: 0x00005D65
			bool ITaskCompletionAction.InvokeMayRunArbitraryCode
			{
				get
				{
					return false;
				}
			}

			// Token: 0x0600464A RID: 17994 RVA: 0x000EB6C4 File Offset: 0x000E98C4
			void IValueTaskSource.GetResult(short token)
			{
				this._waitForNextCompletedTask.GetResult(token);
			}

			// Token: 0x0600464B RID: 17995 RVA: 0x000EB6D3 File Offset: 0x000E98D3
			ValueTaskSourceStatus IValueTaskSource.GetStatus(short token)
			{
				return this._waitForNextCompletedTask.GetStatus(token);
			}

			// Token: 0x0600464C RID: 17996 RVA: 0x000EB6E1 File Offset: 0x000E98E1
			void IValueTaskSource.OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
			{
				this._waitForNextCompletedTask.OnCompleted(continuation, state, token, flags);
			}

			// Token: 0x0600464D RID: 17997 RVA: 0x000EB6F4 File Offset: 0x000E98F4
			public unsafe static Task.WhenEachState Create(ReadOnlySpan<Task> tasks)
			{
				Task.WhenEachState whenEachState = null;
				if (tasks.Length != 0)
				{
					whenEachState = new Task.WhenEachState();
					ReadOnlySpan<Task> readOnlySpan = tasks;
					for (int i = 0; i < readOnlySpan.Length; i++)
					{
						object obj = *readOnlySpan[i];
						if (obj == null)
						{
							ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_NullTask, ExceptionArgument.tasks);
						}
						Task.WhenEachState whenEachState2 = whenEachState;
						int remaining = whenEachState2.Remaining;
						whenEachState2.Remaining = remaining + 1;
						obj.AddCompletionAction(whenEachState, false);
					}
				}
				return whenEachState;
			}

			// Token: 0x0600464E RID: 17998 RVA: 0x000EB754 File Offset: 0x000E9954
			public static Task.WhenEachState Create(IEnumerable<Task> tasks)
			{
				ArgumentNullException.ThrowIfNull(tasks, "tasks");
				Task.WhenEachState whenEachState = null;
				IEnumerator<Task> enumerator = tasks.GetEnumerator();
				if (enumerator.MoveNext())
				{
					whenEachState = new Task.WhenEachState();
					do
					{
						Task task = enumerator.Current;
						if (task == null)
						{
							ThrowHelper.ThrowArgumentException(ExceptionResource.Task_MultiTaskContinuation_NullTask, ExceptionArgument.tasks);
						}
						Task.WhenEachState whenEachState2 = whenEachState;
						int remaining = whenEachState2.Remaining;
						whenEachState2.Remaining = remaining + 1;
						task.AddCompletionAction(whenEachState, false);
					}
					while (enumerator.MoveNext());
				}
				return whenEachState;
			}

			// Token: 0x0600464F RID: 17999 RVA: 0x000EB7B5 File Offset: 0x000E99B5
			[AsyncIteratorStateMachine(typeof(Task.WhenEachState.<Iterate>d__15<>))]
			public static IAsyncEnumerable<T> Iterate<T>(Task.WhenEachState waiter, [EnumeratorCancellation] CancellationToken cancellationToken = default(CancellationToken)) where T : Task
			{
				Task.WhenEachState.<Iterate>d__15<T> <Iterate>d__ = new Task.WhenEachState.<Iterate>d__15<T>(-2);
				<Iterate>d__.<>3__waiter = waiter;
				<Iterate>d__.<>3__cancellationToken = cancellationToken;
				return <Iterate>d__;
			}

			// Token: 0x04001042 RID: 4162
			private ManualResetValueTaskSourceCore<bool> _waitForNextCompletedTask = new ManualResetValueTaskSourceCore<bool>
			{
				RunContinuationsAsynchronously = true
			};

			// Token: 0x04001043 RID: 4163
			private int _enumerated;
		}
	}
}
