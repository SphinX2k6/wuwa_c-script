using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x02000490 RID: 1168
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("Concurrent = {ConcurrentTaskCountForDebugger}, Exclusive = {ExclusiveTaskCountForDebugger}, Mode = {ModeForDebugger}")]
	[DebuggerTypeProxy(typeof(ConcurrentExclusiveSchedulerPair.DebugView))]
	public class ConcurrentExclusiveSchedulerPair
	{
		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06004460 RID: 17504 RVA: 0x000E4F6D File Offset: 0x000E316D
		private static int DefaultMaxConcurrencyLevel
		{
			get
			{
				return Environment.ProcessorCount;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06004461 RID: 17505 RVA: 0x000E4F74 File Offset: 0x000E3174
		private object ValueLock
		{
			get
			{
				return this.m_threadProcessingMode;
			}
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x000E4F7C File Offset: 0x000E317C
		public ConcurrentExclusiveSchedulerPair() : this(TaskScheduler.Default, ConcurrentExclusiveSchedulerPair.DefaultMaxConcurrencyLevel, -1)
		{
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x000E4F8F File Offset: 0x000E318F
		public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler) : this(taskScheduler, ConcurrentExclusiveSchedulerPair.DefaultMaxConcurrencyLevel, -1)
		{
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x000E4F9E File Offset: 0x000E319E
		public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler, int maxConcurrencyLevel) : this(taskScheduler, maxConcurrencyLevel, -1)
		{
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x000E4FAC File Offset: 0x000E31AC
		public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler, int maxConcurrencyLevel, int maxItemsPerTask)
		{
			ArgumentNullException.ThrowIfNull(taskScheduler, "taskScheduler");
			if (maxConcurrencyLevel == 0 || maxConcurrencyLevel < -1)
			{
				throw new ArgumentOutOfRangeException("maxConcurrencyLevel");
			}
			if (maxItemsPerTask == 0 || maxItemsPerTask < -1)
			{
				throw new ArgumentOutOfRangeException("maxItemsPerTask");
			}
			this.m_underlyingTaskScheduler = taskScheduler;
			this.m_maxConcurrencyLevel = maxConcurrencyLevel;
			this.m_maxItemsPerTask = maxItemsPerTask;
			int maximumConcurrencyLevel = taskScheduler.MaximumConcurrencyLevel;
			if (maximumConcurrencyLevel > 0 && maximumConcurrencyLevel < this.m_maxConcurrencyLevel)
			{
				this.m_maxConcurrencyLevel = maximumConcurrencyLevel;
			}
			if (this.m_maxConcurrencyLevel == -1)
			{
				this.m_maxConcurrencyLevel = int.MaxValue;
			}
			if (this.m_maxItemsPerTask == -1)
			{
				this.m_maxItemsPerTask = int.MaxValue;
			}
			this.m_exclusiveTaskScheduler = new ConcurrentExclusiveSchedulerPair.ConcurrentExclusiveTaskScheduler(this, 1, ConcurrentExclusiveSchedulerPair.ProcessingMode.ProcessingExclusiveTask);
			this.m_concurrentTaskScheduler = new ConcurrentExclusiveSchedulerPair.ConcurrentExclusiveTaskScheduler(this, this.m_maxConcurrencyLevel, ConcurrentExclusiveSchedulerPair.ProcessingMode.ProcessingConcurrentTasks);
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x000E5074 File Offset: 0x000E3274
		public void Complete()
		{
			object valueLock = this.ValueLock;
			lock (valueLock)
			{
				if (!this.CompletionRequested)
				{
					this.RequestCompletion();
					this.CleanupStateIfCompletingAndQuiesced();
				}
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x000E50C4 File Offset: 0x000E32C4
		public Task Completion
		{
			get
			{
				return this.EnsureCompletionStateInitialized();
			}
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x000E50CC File Offset: 0x000E32CC
		private ConcurrentExclusiveSchedulerPair.CompletionState EnsureCompletionStateInitialized()
		{
			return Volatile.Read<ConcurrentExclusiveSchedulerPair.CompletionState>(ref this.m_completionState) ?? this.<EnsureCompletionStateInitialized>g__InitializeCompletionState|23_0();
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06004469 RID: 17513 RVA: 0x000E50E3 File Offset: 0x000E32E3
		private bool CompletionRequested
		{
			get
			{
				return this.m_completionState != null && Volatile.Read(ref this.m_completionState.m_completionRequested);
			}
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x000E50FF File Offset: 0x000E32FF
		private void RequestCompletion()
		{
			this.EnsureCompletionStateInitialized().m_completionRequested = true;
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x000E510D File Offset: 0x000E330D
		private void CleanupStateIfCompletingAndQuiesced()
		{
			if (this.ReadyToComplete)
			{
				this.CompleteTaskAsync();
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x0600446C RID: 17516 RVA: 0x000E5120 File Offset: 0x000E3320
		private bool ReadyToComplete
		{
			get
			{
				if (!this.CompletionRequested || this.m_processingCount != 0)
				{
					return false;
				}
				ConcurrentExclusiveSchedulerPair.CompletionState completionState = this.EnsureCompletionStateInitialized();
				return (completionState.m_exceptions != null && completionState.m_exceptions.Count > 0) || (this.m_concurrentTaskScheduler.m_tasks.IsEmpty && this.m_exclusiveTaskScheduler.m_tasks.IsEmpty);
			}
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x000E5184 File Offset: 0x000E3384
		private void CompleteTaskAsync()
		{
			ConcurrentExclusiveSchedulerPair.CompletionState completionState = this.EnsureCompletionStateInitialized();
			if (!completionState.m_completionQueued)
			{
				completionState.m_completionQueued = true;
				ThreadPool.QueueUserWorkItem(delegate(object state)
				{
					ConcurrentExclusiveSchedulerPair concurrentExclusiveSchedulerPair = (ConcurrentExclusiveSchedulerPair)state;
					List<Exception> exceptions = concurrentExclusiveSchedulerPair.m_completionState.m_exceptions;
					if (exceptions == null || exceptions.Count <= 0)
					{
						concurrentExclusiveSchedulerPair.m_completionState.TrySetResult();
					}
					else
					{
						concurrentExclusiveSchedulerPair.m_completionState.TrySetException(exceptions);
					}
					concurrentExclusiveSchedulerPair.m_threadProcessingMode.Dispose();
				}, this);
			}
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x000E51D0 File Offset: 0x000E33D0
		private void FaultWithTask(Task faultedTask)
		{
			AggregateException exception = faultedTask.Exception;
			ConcurrentExclusiveSchedulerPair.CompletionState completionState2;
			ConcurrentExclusiveSchedulerPair.CompletionState completionState = completionState2 = this.EnsureCompletionStateInitialized();
			if (completionState2.m_exceptions == null)
			{
				completionState2.m_exceptions = new List<Exception>(exception.InnerExceptionCount);
			}
			completionState.m_exceptions.AddRange(exception.InternalInnerExceptions);
			this.RequestCompletion();
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x0600446F RID: 17519 RVA: 0x000E521B File Offset: 0x000E341B
		public TaskScheduler ConcurrentScheduler
		{
			get
			{
				return this.m_concurrentTaskScheduler;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06004470 RID: 17520 RVA: 0x000E5223 File Offset: 0x000E3423
		public TaskScheduler ExclusiveScheduler
		{
			get
			{
				return this.m_exclusiveTaskScheduler;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06004471 RID: 17521 RVA: 0x000E522B File Offset: 0x000E342B
		private int ConcurrentTaskCountForDebugger
		{
			get
			{
				return this.m_concurrentTaskScheduler.m_tasks.Count;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06004472 RID: 17522 RVA: 0x000E523D File Offset: 0x000E343D
		private int ExclusiveTaskCountForDebugger
		{
			get
			{
				return this.m_exclusiveTaskScheduler.m_tasks.Count;
			}
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x000E5250 File Offset: 0x000E3450
		private void ProcessAsyncIfNecessary(bool fairly = false)
		{
			if (this.m_processingCount >= 0)
			{
				bool flag = !this.m_exclusiveTaskScheduler.m_tasks.IsEmpty;
				Task task = null;
				if (this.m_processingCount == 0 && flag)
				{
					this.m_processingCount = -1;
					if (this.TryQueueThreadPoolWorkItem(fairly))
					{
						goto IL_17A;
					}
					try
					{
						task = new Task(delegate(object thisPair)
						{
							((ConcurrentExclusiveSchedulerPair)thisPair).ProcessExclusiveTasks();
						}, this, default(CancellationToken), ConcurrentExclusiveSchedulerPair.GetCreationOptionsForTask(fairly));
						task.Start(this.m_underlyingTaskScheduler);
						goto IL_17A;
					}
					catch (Exception exception)
					{
						this.m_processingCount = 0;
						this.FaultWithTask(task ?? Task.FromException(exception));
						goto IL_17A;
					}
				}
				int count = this.m_concurrentTaskScheduler.m_tasks.Count;
				if (count > 0 && !flag && this.m_processingCount < this.m_maxConcurrencyLevel)
				{
					int num = 0;
					while (num < count && this.m_processingCount < this.m_maxConcurrencyLevel)
					{
						this.m_processingCount++;
						if (!this.TryQueueThreadPoolWorkItem(fairly))
						{
							try
							{
								task = new Task(delegate(object thisPair)
								{
									((ConcurrentExclusiveSchedulerPair)thisPair).ProcessConcurrentTasks();
								}, this, default(CancellationToken), ConcurrentExclusiveSchedulerPair.GetCreationOptionsForTask(fairly));
								task.Start(this.m_underlyingTaskScheduler);
							}
							catch (Exception exception2)
							{
								this.m_processingCount--;
								this.FaultWithTask(task ?? Task.FromException(exception2));
							}
						}
						num++;
					}
				}
				IL_17A:
				this.CleanupStateIfCompletingAndQuiesced();
			}
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x000E53FC File Offset: 0x000E35FC
		private bool TryQueueThreadPoolWorkItem(bool fairly)
		{
			if (TaskScheduler.Default == this.m_underlyingTaskScheduler)
			{
				ConcurrentExclusiveSchedulerPair.SchedulerWorkItem callBack;
				if ((callBack = this.m_threadPoolWorkItem) == null)
				{
					callBack = (this.m_threadPoolWorkItem = new ConcurrentExclusiveSchedulerPair.SchedulerWorkItem(this));
				}
				ThreadPool.UnsafeQueueUserWorkItemInternal(callBack, !fairly);
				return true;
			}
			return false;
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x000E543C File Offset: 0x000E363C
		private void ProcessExclusiveTasks()
		{
			try
			{
				this.m_threadProcessingMode.Value = ConcurrentExclusiveSchedulerPair.ProcessingMode.ProcessingExclusiveTask;
				for (int i = 0; i < this.m_maxItemsPerTask; i++)
				{
					Task task;
					if (!this.m_exclusiveTaskScheduler.m_tasks.TryDequeue(out task))
					{
						break;
					}
					if (!task.IsFaulted)
					{
						this.m_exclusiveTaskScheduler.ExecuteTask(task);
					}
				}
			}
			finally
			{
				this.m_threadProcessingMode.Value = ConcurrentExclusiveSchedulerPair.ProcessingMode.NotCurrentlyProcessing;
				object valueLock = this.ValueLock;
				lock (valueLock)
				{
					this.m_processingCount = 0;
					this.ProcessAsyncIfNecessary(true);
				}
			}
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x000E54E8 File Offset: 0x000E36E8
		private void ProcessConcurrentTasks()
		{
			try
			{
				this.m_threadProcessingMode.Value = ConcurrentExclusiveSchedulerPair.ProcessingMode.ProcessingConcurrentTasks;
				for (int i = 0; i < this.m_maxItemsPerTask; i++)
				{
					Task task;
					if (!this.m_concurrentTaskScheduler.m_tasks.TryDequeue(out task))
					{
						break;
					}
					if (!task.IsFaulted)
					{
						this.m_concurrentTaskScheduler.ExecuteTask(task);
					}
					if (!this.m_exclusiveTaskScheduler.m_tasks.IsEmpty)
					{
						break;
					}
				}
			}
			finally
			{
				this.m_threadProcessingMode.Value = ConcurrentExclusiveSchedulerPair.ProcessingMode.NotCurrentlyProcessing;
				object valueLock = this.ValueLock;
				lock (valueLock)
				{
					if (this.m_processingCount > 0)
					{
						this.m_processingCount--;
					}
					this.ProcessAsyncIfNecessary(true);
				}
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x000E55B8 File Offset: 0x000E37B8
		private ConcurrentExclusiveSchedulerPair.ProcessingMode ModeForDebugger
		{
			get
			{
				if (this.m_completionState != null && this.m_completionState.IsCompleted)
				{
					return ConcurrentExclusiveSchedulerPair.ProcessingMode.Completed;
				}
				ConcurrentExclusiveSchedulerPair.ProcessingMode processingMode = ConcurrentExclusiveSchedulerPair.ProcessingMode.NotCurrentlyProcessing;
				if (this.m_processingCount == -1)
				{
					processingMode |= ConcurrentExclusiveSchedulerPair.ProcessingMode.ProcessingExclusiveTask;
				}
				if (this.m_processingCount >= 1)
				{
					processingMode |= ConcurrentExclusiveSchedulerPair.ProcessingMode.ProcessingConcurrentTasks;
				}
				if (this.CompletionRequested)
				{
					processingMode |= ConcurrentExclusiveSchedulerPair.ProcessingMode.Completing;
				}
				return processingMode;
			}
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x000E5608 File Offset: 0x000E3808
		internal static TaskCreationOptions GetCreationOptionsForTask(bool isReplacementReplica = false)
		{
			TaskCreationOptions taskCreationOptions = TaskCreationOptions.DenyChildAttach;
			if (isReplacementReplica)
			{
				taskCreationOptions |= TaskCreationOptions.PreferFairness;
			}
			return taskCreationOptions;
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x000E561F File Offset: 0x000E381F
		[CompilerGenerated]
		private ConcurrentExclusiveSchedulerPair.CompletionState <EnsureCompletionStateInitialized>g__InitializeCompletionState|23_0()
		{
			Interlocked.CompareExchange<ConcurrentExclusiveSchedulerPair.CompletionState>(ref this.m_completionState, new ConcurrentExclusiveSchedulerPair.CompletionState(), null);
			return this.m_completionState;
		}

		// Token: 0x04000FB1 RID: 4017
		private readonly ThreadLocal<ConcurrentExclusiveSchedulerPair.ProcessingMode> m_threadProcessingMode = new ThreadLocal<ConcurrentExclusiveSchedulerPair.ProcessingMode>();

		// Token: 0x04000FB2 RID: 4018
		private readonly ConcurrentExclusiveSchedulerPair.ConcurrentExclusiveTaskScheduler m_concurrentTaskScheduler;

		// Token: 0x04000FB3 RID: 4019
		private readonly ConcurrentExclusiveSchedulerPair.ConcurrentExclusiveTaskScheduler m_exclusiveTaskScheduler;

		// Token: 0x04000FB4 RID: 4020
		private readonly TaskScheduler m_underlyingTaskScheduler;

		// Token: 0x04000FB5 RID: 4021
		private readonly int m_maxConcurrencyLevel;

		// Token: 0x04000FB6 RID: 4022
		private readonly int m_maxItemsPerTask;

		// Token: 0x04000FB7 RID: 4023
		private int m_processingCount;

		// Token: 0x04000FB8 RID: 4024
		private ConcurrentExclusiveSchedulerPair.CompletionState m_completionState;

		// Token: 0x04000FB9 RID: 4025
		private ConcurrentExclusiveSchedulerPair.SchedulerWorkItem m_threadPoolWorkItem;

		// Token: 0x02000491 RID: 1169
		private sealed class CompletionState : Task
		{
			// Token: 0x04000FBA RID: 4026
			internal bool m_completionRequested;

			// Token: 0x04000FBB RID: 4027
			internal bool m_completionQueued;

			// Token: 0x04000FBC RID: 4028
			internal List<Exception> m_exceptions;
		}

		// Token: 0x02000492 RID: 1170
		private sealed class SchedulerWorkItem : IThreadPoolWorkItem
		{
			// Token: 0x0600447B RID: 17531 RVA: 0x000E5641 File Offset: 0x000E3841
			internal SchedulerWorkItem(ConcurrentExclusiveSchedulerPair pair)
			{
				this._pair = pair;
			}

			// Token: 0x0600447C RID: 17532 RVA: 0x000E5650 File Offset: 0x000E3850
			void IThreadPoolWorkItem.Execute()
			{
				if (this._pair.m_processingCount == -1)
				{
					this._pair.ProcessExclusiveTasks();
					return;
				}
				this._pair.ProcessConcurrentTasks();
			}

			// Token: 0x04000FBD RID: 4029
			private readonly ConcurrentExclusiveSchedulerPair _pair;
		}

		// Token: 0x02000493 RID: 1171
		[DebuggerDisplay("Count = {CountForDebugger}, MaxConcurrencyLevel = {m_maxConcurrencyLevel}, Id = {Id}")]
		[DebuggerTypeProxy(typeof(ConcurrentExclusiveSchedulerPair.ConcurrentExclusiveTaskScheduler.DebugView))]
		private sealed class ConcurrentExclusiveTaskScheduler : TaskScheduler
		{
			// Token: 0x0600447D RID: 17533 RVA: 0x000E5678 File Offset: 0x000E3878
			internal ConcurrentExclusiveTaskScheduler(ConcurrentExclusiveSchedulerPair pair, int maxConcurrencyLevel, ConcurrentExclusiveSchedulerPair.ProcessingMode processingMode)
			{
				this.m_pair = pair;
				this.m_maxConcurrencyLevel = maxConcurrencyLevel;
				this.m_processingMode = processingMode;
				IProducerConsumerQueue<Task> tasks;
				if (processingMode != ConcurrentExclusiveSchedulerPair.ProcessingMode.ProcessingExclusiveTask)
				{
					IProducerConsumerQueue<Task> producerConsumerQueue = new MultiProducerMultiConsumerQueue<Task>();
					tasks = producerConsumerQueue;
				}
				else
				{
					IProducerConsumerQueue<Task> producerConsumerQueue = new SingleProducerSingleConsumerQueue<Task>();
					tasks = producerConsumerQueue;
				}
				this.m_tasks = tasks;
			}

			// Token: 0x17000C3D RID: 3133
			// (get) Token: 0x0600447E RID: 17534 RVA: 0x000E56BA File Offset: 0x000E38BA
			public override int MaximumConcurrencyLevel
			{
				get
				{
					return this.m_maxConcurrencyLevel;
				}
			}

			// Token: 0x0600447F RID: 17535 RVA: 0x000E56C4 File Offset: 0x000E38C4
			protected internal override void QueueTask(Task task)
			{
				object valueLock = this.m_pair.ValueLock;
				lock (valueLock)
				{
					if (this.m_pair.CompletionRequested)
					{
						throw new InvalidOperationException(base.GetType().ToString());
					}
					this.m_tasks.Enqueue(task);
					this.m_pair.ProcessAsyncIfNecessary(false);
				}
			}

			// Token: 0x06004480 RID: 17536 RVA: 0x000E573C File Offset: 0x000E393C
			internal void ExecuteTask(Task task)
			{
				base.TryExecuteTask(task);
			}

			// Token: 0x06004481 RID: 17537 RVA: 0x000E5748 File Offset: 0x000E3948
			protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
			{
				if (!taskWasPreviouslyQueued && this.m_pair.CompletionRequested)
				{
					return false;
				}
				bool flag = this.m_pair.m_underlyingTaskScheduler == TaskScheduler.Default;
				if (flag && taskWasPreviouslyQueued && !Thread.CurrentThread.IsThreadPoolThread)
				{
					return false;
				}
				if (this.m_pair.m_threadProcessingMode.Value != this.m_processingMode)
				{
					return false;
				}
				if (!flag || taskWasPreviouslyQueued)
				{
					return this.TryExecuteTaskInlineOnTargetScheduler(task);
				}
				return base.TryExecuteTask(task);
			}

			// Token: 0x06004482 RID: 17538 RVA: 0x000E57BC File Offset: 0x000E39BC
			private bool TryExecuteTaskInlineOnTargetScheduler(Task task)
			{
				Task<bool> task2 = new Task<bool>(delegate(object s)
				{
					TupleSlim<ConcurrentExclusiveSchedulerPair.ConcurrentExclusiveTaskScheduler, Task> tupleSlim = (TupleSlim<ConcurrentExclusiveSchedulerPair.ConcurrentExclusiveTaskScheduler, Task>)s;
					return tupleSlim.Item1.TryExecuteTask(tupleSlim.Item2);
				}, new TupleSlim<ConcurrentExclusiveSchedulerPair.ConcurrentExclusiveTaskScheduler, Task>(this, task));
				bool result;
				try
				{
					task2.RunSynchronously(this.m_pair.m_underlyingTaskScheduler);
					result = task2.Result;
				}
				catch
				{
					AggregateException exception = task2.Exception;
					throw;
				}
				finally
				{
					task2.Dispose();
				}
				return result;
			}

			// Token: 0x06004483 RID: 17539 RVA: 0x000E5840 File Offset: 0x000E3A40
			protected override IEnumerable<Task> GetScheduledTasks()
			{
				return this.m_tasks;
			}

			// Token: 0x17000C3E RID: 3134
			// (get) Token: 0x06004484 RID: 17540 RVA: 0x000E5848 File Offset: 0x000E3A48
			private int CountForDebugger
			{
				get
				{
					return this.m_tasks.Count;
				}
			}

			// Token: 0x04000FBE RID: 4030
			private readonly ConcurrentExclusiveSchedulerPair m_pair;

			// Token: 0x04000FBF RID: 4031
			private readonly int m_maxConcurrencyLevel;

			// Token: 0x04000FC0 RID: 4032
			private readonly ConcurrentExclusiveSchedulerPair.ProcessingMode m_processingMode;

			// Token: 0x04000FC1 RID: 4033
			internal readonly IProducerConsumerQueue<Task> m_tasks;

			// Token: 0x02000494 RID: 1172
			private sealed class DebugView
			{
				// Token: 0x06004485 RID: 17541 RVA: 0x000E5855 File Offset: 0x000E3A55
				public DebugView(ConcurrentExclusiveSchedulerPair.ConcurrentExclusiveTaskScheduler scheduler)
				{
					this.m_taskScheduler = scheduler;
				}

				// Token: 0x17000C3F RID: 3135
				// (get) Token: 0x06004486 RID: 17542 RVA: 0x000E5864 File Offset: 0x000E3A64
				public int MaximumConcurrencyLevel
				{
					get
					{
						return this.m_taskScheduler.m_maxConcurrencyLevel;
					}
				}

				// Token: 0x17000C40 RID: 3136
				// (get) Token: 0x06004487 RID: 17543 RVA: 0x000E5871 File Offset: 0x000E3A71
				public IEnumerable<Task> ScheduledTasks
				{
					get
					{
						return this.m_taskScheduler.m_tasks;
					}
				}

				// Token: 0x17000C41 RID: 3137
				// (get) Token: 0x06004488 RID: 17544 RVA: 0x000E587E File Offset: 0x000E3A7E
				public ConcurrentExclusiveSchedulerPair SchedulerPair
				{
					get
					{
						return this.m_taskScheduler.m_pair;
					}
				}

				// Token: 0x04000FC2 RID: 4034
				private readonly ConcurrentExclusiveSchedulerPair.ConcurrentExclusiveTaskScheduler m_taskScheduler;
			}
		}

		// Token: 0x02000496 RID: 1174
		private sealed class DebugView
		{
			// Token: 0x0600448C RID: 17548 RVA: 0x000E58BD File Offset: 0x000E3ABD
			public DebugView(ConcurrentExclusiveSchedulerPair pair)
			{
				this.m_pair = pair;
			}

			// Token: 0x17000C42 RID: 3138
			// (get) Token: 0x0600448D RID: 17549 RVA: 0x000E58CC File Offset: 0x000E3ACC
			public ConcurrentExclusiveSchedulerPair.ProcessingMode Mode
			{
				get
				{
					return this.m_pair.ModeForDebugger;
				}
			}

			// Token: 0x17000C43 RID: 3139
			// (get) Token: 0x0600448E RID: 17550 RVA: 0x000E58D9 File Offset: 0x000E3AD9
			public IEnumerable<Task> ScheduledExclusive
			{
				get
				{
					return this.m_pair.m_exclusiveTaskScheduler.m_tasks;
				}
			}

			// Token: 0x17000C44 RID: 3140
			// (get) Token: 0x0600448F RID: 17551 RVA: 0x000E58EB File Offset: 0x000E3AEB
			public IEnumerable<Task> ScheduledConcurrent
			{
				get
				{
					return this.m_pair.m_concurrentTaskScheduler.m_tasks;
				}
			}

			// Token: 0x17000C45 RID: 3141
			// (get) Token: 0x06004490 RID: 17552 RVA: 0x000E58FD File Offset: 0x000E3AFD
			public int CurrentlyExecutingTaskCount
			{
				get
				{
					if (this.m_pair.m_processingCount != -1)
					{
						return this.m_pair.m_processingCount;
					}
					return 1;
				}
			}

			// Token: 0x17000C46 RID: 3142
			// (get) Token: 0x06004491 RID: 17553 RVA: 0x000E591A File Offset: 0x000E3B1A
			public TaskScheduler TargetScheduler
			{
				get
				{
					return this.m_pair.m_underlyingTaskScheduler;
				}
			}

			// Token: 0x04000FC5 RID: 4037
			private readonly ConcurrentExclusiveSchedulerPair m_pair;
		}

		// Token: 0x02000497 RID: 1175
		[Flags]
		private enum ProcessingMode : byte
		{
			// Token: 0x04000FC7 RID: 4039
			NotCurrentlyProcessing = 0,
			// Token: 0x04000FC8 RID: 4040
			ProcessingExclusiveTask = 1,
			// Token: 0x04000FC9 RID: 4041
			ProcessingConcurrentTasks = 2,
			// Token: 0x04000FCA RID: 4042
			Completing = 4,
			// Token: 0x04000FCB RID: 4043
			Completed = 8
		}
	}
}
