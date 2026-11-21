using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Internal;

namespace System.Threading
{
	// Token: 0x02000425 RID: 1061
	internal sealed class ThreadPoolWorkQueue
	{
		// Token: 0x060041D8 RID: 16856 RVA: 0x000DBAE8 File Offset: 0x000D9CE8
		public ThreadPoolWorkQueue()
		{
			for (int i = 0; i < ThreadPoolWorkQueue.s_assignableWorkItemQueueCount; i++)
			{
				this._assignableWorkItemQueues[i] = new ConcurrentQueue<object>();
			}
			this.RefreshLoggingEnabled();
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x000DBB70 File Offset: 0x000D9D70
		private void AssignWorkItemQueue(ThreadPoolWorkQueueThreadLocals tl)
		{
			this._queueAssignmentLock.Acquire();
			int num = -1;
			int num2 = int.MaxValue;
			int num3 = 0;
			for (int i = 0; i < ThreadPoolWorkQueue.s_assignableWorkItemQueueCount; i++)
			{
				int num4 = this._assignedWorkItemQueueThreadCounts[i];
				if (num4 < 16)
				{
					num = i;
					this._assignedWorkItemQueueThreadCounts[num] = num4 + 1;
					break;
				}
				if (num4 < num2)
				{
					num2 = num4;
					num3 = i;
				}
			}
			if (num < 0)
			{
				num = num3;
				this._assignedWorkItemQueueThreadCounts[num]++;
			}
			this._queueAssignmentLock.Release();
			tl.queueIndex = num;
			tl.assignedGlobalWorkItemQueue = this._assignableWorkItemQueues[num];
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x000DBC04 File Offset: 0x000D9E04
		private void TryReassignWorkItemQueue(ThreadPoolWorkQueueThreadLocals tl)
		{
			int num = tl.queueIndex;
			if (num == 0)
			{
				return;
			}
			if (!this._queueAssignmentLock.TryAcquire())
			{
				return;
			}
			if (this._assignedWorkItemQueueThreadCounts[num] > 1)
			{
				for (int i = 0; i < num; i++)
				{
					if (this._assignedWorkItemQueueThreadCounts[i] < 16)
					{
						this._assignedWorkItemQueueThreadCounts[num]--;
						num = i;
						this._assignedWorkItemQueueThreadCounts[num]++;
						break;
					}
				}
			}
			this._queueAssignmentLock.Release();
			tl.queueIndex = num;
			tl.assignedGlobalWorkItemQueue = this._assignableWorkItemQueues[num];
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x000DBC94 File Offset: 0x000D9E94
		private void UnassignWorkItemQueue(ThreadPoolWorkQueueThreadLocals tl)
		{
			int queueIndex = tl.queueIndex;
			this._queueAssignmentLock.Acquire();
			int[] assignedWorkItemQueueThreadCounts = this._assignedWorkItemQueueThreadCounts;
			int num = queueIndex;
			int num2 = assignedWorkItemQueueThreadCounts[num] - 1;
			assignedWorkItemQueueThreadCounts[num] = num2;
			int num3 = num2;
			this._queueAssignmentLock.Release();
			if (num3 > 0)
			{
				return;
			}
			bool flag = false;
			ConcurrentQueue<object> assignedGlobalWorkItemQueue = tl.assignedGlobalWorkItemQueue;
			object item;
			while (this._assignedWorkItemQueueThreadCounts[queueIndex] <= 0 && assignedGlobalWorkItemQueue.TryDequeue(out item))
			{
				this.workItems.Enqueue(item);
				flag = true;
			}
			if (flag)
			{
				this.EnsureThreadRequested();
			}
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x000DBD0E File Offset: 0x000D9F0E
		public ThreadPoolWorkQueueThreadLocals GetOrCreateThreadLocals()
		{
			return ThreadPoolWorkQueueThreadLocals.threadLocals ?? this.CreateThreadLocals();
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x000DBD1F File Offset: 0x000D9F1F
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ThreadPoolWorkQueueThreadLocals CreateThreadLocals()
		{
			return ThreadPoolWorkQueueThreadLocals.threadLocals = new ThreadPoolWorkQueueThreadLocals(this);
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x000DBD2D File Offset: 0x000D9F2D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void RefreshLoggingEnabled()
		{
			if (!FrameworkEventSource.Log.IsEnabled())
			{
				if (this._loggingEnabled)
				{
					this._loggingEnabled = false;
				}
				return;
			}
			this.RefreshLoggingEnabledFull();
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x000DBD51 File Offset: 0x000D9F51
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshLoggingEnabledFull()
		{
			this._loggingEnabled = FrameworkEventSource.Log.IsEnabled(EventLevel.Verbose, (EventKeywords)18L);
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x000DBD67 File Offset: 0x000D9F67
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void EnsureThreadRequested()
		{
			if (Interlocked.Exchange<ThreadPoolWorkQueue.QueueProcessingStage>(ref this._separated.queueProcessingStage, ThreadPoolWorkQueue.QueueProcessingStage.Scheduled) == ThreadPoolWorkQueue.QueueProcessingStage.NotScheduled)
			{
				ThreadPool.RequestWorkerThread();
			}
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x000DBD84 File Offset: 0x000D9F84
		public void Enqueue(object callback, bool forceGlobal)
		{
			if (this._loggingEnabled && FrameworkEventSource.Log.IsEnabled())
			{
				FrameworkEventSource.Log.ThreadPoolEnqueueWorkObject(callback);
			}
			ThreadPoolWorkQueueThreadLocals threadLocals;
			if (!forceGlobal && (threadLocals = ThreadPoolWorkQueueThreadLocals.threadLocals) != null)
			{
				threadLocals.workStealingQueue.LocalPush(callback);
			}
			else
			{
				((ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0 && (threadLocals = ThreadPoolWorkQueueThreadLocals.threadLocals) != null) ? threadLocals.assignedGlobalWorkItemQueue : this.workItems).Enqueue(callback);
			}
			this.EnsureThreadRequested();
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x000DBDF5 File Offset: 0x000D9FF5
		public void EnqueueAtHighPriority(object workItem)
		{
			if (this._loggingEnabled && FrameworkEventSource.Log.IsEnabled())
			{
				FrameworkEventSource.Log.ThreadPoolEnqueueWorkObject(workItem);
			}
			this.highPriorityWorkItems.Enqueue(workItem);
			Volatile.Write(ref this._mayHaveHighPriorityWorkItems, true);
			this.EnsureThreadRequested();
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x000DBE34 File Offset: 0x000DA034
		internal static bool LocalFindAndPop(object callback)
		{
			ThreadPoolWorkQueueThreadLocals threadLocals = ThreadPoolWorkQueueThreadLocals.threadLocals;
			return threadLocals != null && threadLocals.workStealingQueue.LocalFindAndPop(callback);
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x000DBE58 File Offset: 0x000DA058
		public object Dequeue(ThreadPoolWorkQueueThreadLocals tl, ref bool missedSteal)
		{
			object obj = tl.workStealingQueue.LocalPop();
			if (obj != null)
			{
				return obj;
			}
			if (this._nextWorkItemToProcess != null)
			{
				obj = Interlocked.Exchange(ref this._nextWorkItemToProcess, null);
				if (obj != null)
				{
					return obj;
				}
			}
			if (tl.isProcessingHighPriorityWorkItems)
			{
				if (this.highPriorityWorkItems.TryDequeue(out obj))
				{
					return obj;
				}
				tl.isProcessingHighPriorityWorkItems = false;
			}
			else if (this._mayHaveHighPriorityWorkItems && Interlocked.CompareExchange<bool>(ref this._mayHaveHighPriorityWorkItems, false, true) && this.TryStartProcessingHighPriorityWorkItemsAndDequeue(tl, out obj))
			{
				return obj;
			}
			if (ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0 && tl.assignedGlobalWorkItemQueue.TryDequeue(out obj))
			{
				return obj;
			}
			if (this.workItems.TryDequeue(out obj))
			{
				return obj;
			}
			uint num = tl.random.NextUInt32();
			if (ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0)
			{
				int queueIndex = tl.queueIndex;
				int i = ThreadPoolWorkQueue.s_assignableWorkItemQueueCount;
				int num2 = i - 1;
				int num3 = (int)(num % (uint)i);
				while (i > 0)
				{
					if (num3 != queueIndex && this._assignableWorkItemQueues[num3].TryDequeue(out obj))
					{
						return obj;
					}
					num3 = ((num3 < num2) ? (num3 + 1) : 0);
					i--;
				}
			}
			ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue = tl.workStealingQueue;
			ThreadPoolWorkQueue.WorkStealingQueue[] queues = ThreadPoolWorkQueue.WorkStealingQueueList.Queues;
			int j = queues.Length;
			int num4 = j - 1;
			int num5 = (int)(num % (uint)j);
			while (j > 0)
			{
				ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue2 = queues[num5];
				if (workStealingQueue2 != workStealingQueue && workStealingQueue2.CanSteal)
				{
					obj = workStealingQueue2.TrySteal(ref missedSteal);
					if (obj != null)
					{
						return obj;
					}
				}
				num5 = ((num5 < num4) ? (num5 + 1) : 0);
				j--;
			}
			return null;
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x000DBFBF File Offset: 0x000DA1BF
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool TryStartProcessingHighPriorityWorkItemsAndDequeue(ThreadPoolWorkQueueThreadLocals tl, [MaybeNullWhen(false)] out object workItem)
		{
			if (!this.highPriorityWorkItems.TryDequeue(out workItem))
			{
				return false;
			}
			tl.isProcessingHighPriorityWorkItems = true;
			this._mayHaveHighPriorityWorkItems = true;
			return true;
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060041E6 RID: 16870 RVA: 0x000DBFE0 File Offset: 0x000DA1E0
		public static long LocalCount
		{
			get
			{
				long num = 0L;
				foreach (ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue in ThreadPoolWorkQueue.WorkStealingQueueList.Queues)
				{
					num += (long)workStealingQueue.Count;
				}
				return num;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060041E7 RID: 16871 RVA: 0x000DC014 File Offset: 0x000DA214
		public long GlobalCount
		{
			get
			{
				long num = (long)this.highPriorityWorkItems.Count + (long)this.workItems.Count;
				for (int i = 0; i < ThreadPoolWorkQueue.s_assignableWorkItemQueueCount; i++)
				{
					num += (long)this._assignableWorkItemQueues[i].Count;
				}
				return num;
			}
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x000DC060 File Offset: 0x000DA260
		private static object DequeueWithPriorityAlternation(ThreadPoolWorkQueue workQueue, ThreadPoolWorkQueueThreadLocals tl, out bool missedSteal)
		{
			object obj = null;
			bool dispatchNormalPriorityWorkFirst = workQueue._dispatchNormalPriorityWorkFirst;
			if (dispatchNormalPriorityWorkFirst && !tl.workStealingQueue.CanSteal)
			{
				workQueue._dispatchNormalPriorityWorkFirst = !dispatchNormalPriorityWorkFirst;
				if (!((ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0) ? tl.assignedGlobalWorkItemQueue : workQueue.workItems).TryDequeue(out obj) && ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0)
				{
					workQueue.workItems.TryDequeue(out obj);
				}
			}
			missedSteal = false;
			if (obj == null)
			{
				obj = workQueue.Dequeue(tl, ref missedSteal);
			}
			return obj;
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x000DC0D8 File Offset: 0x000DA2D8
		internal static bool Dispatch()
		{
			ThreadPoolWorkQueue s_workQueue = ThreadPool.s_workQueue;
			ThreadPoolWorkQueueThreadLocals orCreateThreadLocals = s_workQueue.GetOrCreateThreadLocals();
			if (ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0)
			{
				s_workQueue.AssignWorkItemQueue(orCreateThreadLocals);
			}
			s_workQueue._separated.queueProcessingStage = ThreadPoolWorkQueue.QueueProcessingStage.Determining;
			Interlocked.MemoryBarrier();
			object obj = null;
			if (s_workQueue._nextWorkItemToProcess != null)
			{
				obj = Interlocked.Exchange(ref s_workQueue._nextWorkItemToProcess, null);
			}
			if (obj == null)
			{
				bool flag;
				while ((obj = ThreadPoolWorkQueue.DequeueWithPriorityAlternation(s_workQueue, orCreateThreadLocals, out flag)) == null)
				{
					if (flag)
					{
						if (ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0)
						{
							s_workQueue.UnassignWorkItemQueue(orCreateThreadLocals);
						}
						s_workQueue._separated.queueProcessingStage = ThreadPoolWorkQueue.QueueProcessingStage.Scheduled;
						ThreadPool.RequestWorkerThread();
						return true;
					}
					if (Interlocked.CompareExchange<ThreadPoolWorkQueue.QueueProcessingStage>(ref s_workQueue._separated.queueProcessingStage, ThreadPoolWorkQueue.QueueProcessingStage.NotScheduled, ThreadPoolWorkQueue.QueueProcessingStage.Determining) == ThreadPoolWorkQueue.QueueProcessingStage.Determining)
					{
						if (ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0)
						{
							s_workQueue.UnassignWorkItemQueue(orCreateThreadLocals);
						}
						return true;
					}
					s_workQueue._separated.queueProcessingStage = ThreadPoolWorkQueue.QueueProcessingStage.Determining;
					Interlocked.MemoryBarrier();
				}
			}
			s_workQueue._separated.queueProcessingStage = ThreadPoolWorkQueue.QueueProcessingStage.Determining;
			Interlocked.MemoryBarrier();
			bool flag2;
			object obj2 = ThreadPoolWorkQueue.DequeueWithPriorityAlternation(s_workQueue, orCreateThreadLocals, out flag2);
			if (obj2 != null)
			{
				s_workQueue._nextWorkItemToProcess = obj2;
			}
			if (obj2 != null || flag2)
			{
				s_workQueue._separated.queueProcessingStage = ThreadPoolWorkQueue.QueueProcessingStage.Scheduled;
				ThreadPool.RequestWorkerThread();
			}
			else if (Interlocked.CompareExchange<ThreadPoolWorkQueue.QueueProcessingStage>(ref s_workQueue._separated.queueProcessingStage, ThreadPoolWorkQueue.QueueProcessingStage.NotScheduled, ThreadPoolWorkQueue.QueueProcessingStage.Determining) == ThreadPoolWorkQueue.QueueProcessingStage.Scheduled)
			{
				ThreadPool.RequestWorkerThread();
			}
			s_workQueue.RefreshLoggingEnabled();
			object threadLocalCompletionCountObject = orCreateThreadLocals.threadLocalCompletionCountObject;
			Thread currentThread = orCreateThreadLocals.currentThread;
			currentThread._executionContext = null;
			currentThread._synchronizationContext = null;
			int num = Environment.TickCount;
			bool flag3;
			for (;;)
			{
				if (obj == null)
				{
					flag3 = false;
					obj = s_workQueue.Dequeue(orCreateThreadLocals, ref flag3);
					if (obj == null)
					{
						break;
					}
				}
				if (s_workQueue._loggingEnabled && FrameworkEventSource.Log.IsEnabled())
				{
					FrameworkEventSource.Log.ThreadPoolDequeueWorkObject(obj);
				}
				if (ThreadPool.EnableWorkerTracking)
				{
					ThreadPoolWorkQueue.DispatchWorkItemWithWorkerTracking(obj, currentThread);
				}
				else
				{
					ThreadPoolWorkQueue.DispatchWorkItem(obj, currentThread);
				}
				obj = null;
				ExecutionContext.ResetThreadPoolThread(currentThread);
				currentThread.ResetThreadPoolThread();
				int tickCount = Environment.TickCount;
				if (!ThreadPool.NotifyWorkItemComplete(threadLocalCompletionCountObject, tickCount))
				{
					goto Block_18;
				}
				if (tickCount - num >= 30)
				{
					if (ThreadPool.YieldFromDispatchLoop)
					{
						goto Block_21;
					}
					if (ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0)
					{
						s_workQueue.TryReassignWorkItemQueue(orCreateThreadLocals);
					}
					num = tickCount;
					s_workQueue.RefreshLoggingEnabled();
				}
			}
			if (ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0)
			{
				s_workQueue.UnassignWorkItemQueue(orCreateThreadLocals);
			}
			if (flag3)
			{
				s_workQueue.EnsureThreadRequested();
			}
			return true;
			Block_18:
			orCreateThreadLocals.TransferLocalWork();
			orCreateThreadLocals.isProcessingHighPriorityWorkItems = false;
			if (ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0)
			{
				s_workQueue.UnassignWorkItemQueue(orCreateThreadLocals);
			}
			return false;
			Block_21:
			orCreateThreadLocals.isProcessingHighPriorityWorkItems = false;
			if (ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0)
			{
				s_workQueue.UnassignWorkItemQueue(orCreateThreadLocals);
			}
			return true;
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x000DC310 File Offset: 0x000DA510
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void DispatchWorkItemWithWorkerTracking(object workItem, Thread currentThread)
		{
			bool flag = false;
			try
			{
				ThreadPool.ReportThreadStatus(true);
				flag = true;
				ThreadPoolWorkQueue.DispatchWorkItem(workItem, currentThread);
			}
			finally
			{
				if (flag)
				{
					ThreadPool.ReportThreadStatus(false);
				}
			}
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x000DC34C File Offset: 0x000DA54C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void DispatchWorkItem(object workItem, Thread currentThread)
		{
			Task task = workItem as Task;
			if (task != null)
			{
				task.ExecuteFromThreadPool(currentThread);
				return;
			}
			Unsafe.As<IThreadPoolWorkItem>(workItem).Execute();
		}

		// Token: 0x04000E15 RID: 3605
		private static readonly int s_assignableWorkItemQueueCount = (Environment.ProcessorCount <= 32) ? 0 : ((Environment.ProcessorCount + 15) / 16);

		// Token: 0x04000E16 RID: 3606
		private bool _loggingEnabled;

		// Token: 0x04000E17 RID: 3607
		private bool _dispatchNormalPriorityWorkFirst;

		// Token: 0x04000E18 RID: 3608
		private bool _mayHaveHighPriorityWorkItems;

		// Token: 0x04000E19 RID: 3609
		internal readonly ConcurrentQueue<object> workItems = new ConcurrentQueue<object>();

		// Token: 0x04000E1A RID: 3610
		internal readonly ConcurrentQueue<object> highPriorityWorkItems = new ConcurrentQueue<object>();

		// Token: 0x04000E1B RID: 3611
		internal readonly ConcurrentQueue<object>[] _assignableWorkItemQueues = new ConcurrentQueue<object>[ThreadPoolWorkQueue.s_assignableWorkItemQueueCount];

		// Token: 0x04000E1C RID: 3612
		private readonly LowLevelLock _queueAssignmentLock = new LowLevelLock();

		// Token: 0x04000E1D RID: 3613
		private readonly int[] _assignedWorkItemQueueThreadCounts = (ThreadPoolWorkQueue.s_assignableWorkItemQueueCount > 0) ? new int[ThreadPoolWorkQueue.s_assignableWorkItemQueueCount] : Array.Empty<int>();

		// Token: 0x04000E1E RID: 3614
		private object _nextWorkItemToProcess;

		// Token: 0x04000E1F RID: 3615
		private ThreadPoolWorkQueue.CacheLineSeparated _separated;

		// Token: 0x02000426 RID: 1062
		internal static class WorkStealingQueueList
		{
			// Token: 0x17000BEE RID: 3054
			// (get) Token: 0x060041ED RID: 16877 RVA: 0x000DC394 File Offset: 0x000DA594
			public static ThreadPoolWorkQueue.WorkStealingQueue[] Queues
			{
				get
				{
					return ThreadPoolWorkQueue.WorkStealingQueueList.s_queues;
				}
			}

			// Token: 0x060041EE RID: 16878 RVA: 0x000DC39C File Offset: 0x000DA59C
			public static void Add(ThreadPoolWorkQueue.WorkStealingQueue queue)
			{
				ThreadPoolWorkQueue.WorkStealingQueue[] array;
				ThreadPoolWorkQueue.WorkStealingQueue[] array2;
				do
				{
					array = ThreadPoolWorkQueue.WorkStealingQueueList.s_queues;
					array2 = new ThreadPoolWorkQueue.WorkStealingQueue[array.Length + 1];
					Array.Copy(array, array2, array.Length);
					ThreadPoolWorkQueue.WorkStealingQueue[] array3 = array2;
					array3[array3.Length - 1] = queue;
				}
				while (Interlocked.CompareExchange<ThreadPoolWorkQueue.WorkStealingQueue[]>(ref ThreadPoolWorkQueue.WorkStealingQueueList.s_queues, array2, array) != array);
			}

			// Token: 0x060041EF RID: 16879 RVA: 0x000DC3DC File Offset: 0x000DA5DC
			public static void Remove(ThreadPoolWorkQueue.WorkStealingQueue queue)
			{
				for (;;)
				{
					ThreadPoolWorkQueue.WorkStealingQueue[] array = ThreadPoolWorkQueue.WorkStealingQueueList.s_queues;
					if (array.Length == 0)
					{
						break;
					}
					int num = Array.IndexOf<ThreadPoolWorkQueue.WorkStealingQueue>(array, queue);
					if (num < 0)
					{
						return;
					}
					ThreadPoolWorkQueue.WorkStealingQueue[] array2 = new ThreadPoolWorkQueue.WorkStealingQueue[array.Length - 1];
					if (num == 0)
					{
						Array.Copy(array, 1, array2, 0, array2.Length);
					}
					else if (num == array.Length - 1)
					{
						Array.Copy(array, array2, array2.Length);
					}
					else
					{
						Array.Copy(array, array2, num);
						Array.Copy(array, num + 1, array2, num, array2.Length - num);
					}
					if (Interlocked.CompareExchange<ThreadPoolWorkQueue.WorkStealingQueue[]>(ref ThreadPoolWorkQueue.WorkStealingQueueList.s_queues, array2, array) == array)
					{
						return;
					}
				}
			}

			// Token: 0x04000E20 RID: 3616
			private static ThreadPoolWorkQueue.WorkStealingQueue[] s_queues = new ThreadPoolWorkQueue.WorkStealingQueue[0];
		}

		// Token: 0x02000427 RID: 1063
		internal sealed class WorkStealingQueue
		{
			// Token: 0x060041F1 RID: 16881 RVA: 0x000DC468 File Offset: 0x000DA668
			public void LocalPush(object obj)
			{
				int num = this.m_tailIndex;
				if (num == 2147483647)
				{
					num = this.LocalPush_HandleTailOverflow();
				}
				if (num < this.m_headIndex + this.m_mask)
				{
					Volatile.Write<object>(ref this.m_array[num & this.m_mask], obj);
					this.m_tailIndex = num + 1;
					return;
				}
				bool flag = false;
				try
				{
					this.m_foreignLock.Enter(ref flag);
					int headIndex = this.m_headIndex;
					int num2 = this.m_tailIndex - this.m_headIndex;
					if (num2 >= this.m_mask)
					{
						object[] array = new object[this.m_array.Length << 1];
						for (int i = 0; i < this.m_array.Length; i++)
						{
							array[i] = this.m_array[i + headIndex & this.m_mask];
						}
						this.m_array = array;
						this.m_headIndex = 0;
						num = (this.m_tailIndex = num2);
						this.m_mask = (this.m_mask << 1 | 1);
					}
					Volatile.Write<object>(ref this.m_array[num & this.m_mask], obj);
					this.m_tailIndex = num + 1;
				}
				finally
				{
					if (flag)
					{
						this.m_foreignLock.Exit(false);
					}
				}
			}

			// Token: 0x060041F2 RID: 16882 RVA: 0x000DC5C4 File Offset: 0x000DA7C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			private int LocalPush_HandleTailOverflow()
			{
				bool flag = false;
				int result;
				try
				{
					this.m_foreignLock.Enter(ref flag);
					int num = this.m_tailIndex;
					if (num == 2147483647)
					{
						this.m_headIndex &= this.m_mask;
						num = (this.m_tailIndex &= this.m_mask);
					}
					result = num;
				}
				finally
				{
					if (flag)
					{
						this.m_foreignLock.Exit(true);
					}
				}
				return result;
			}

			// Token: 0x060041F3 RID: 16883 RVA: 0x000DC64C File Offset: 0x000DA84C
			public bool LocalFindAndPop(object obj)
			{
				if (this.m_array[this.m_tailIndex - 1 & this.m_mask] == obj)
				{
					return this.LocalPop() != null;
				}
				for (int i = this.m_tailIndex - 2; i >= this.m_headIndex; i--)
				{
					if (this.m_array[i & this.m_mask] == obj)
					{
						bool flag = false;
						try
						{
							this.m_foreignLock.Enter(ref flag);
							if (this.m_array[i & this.m_mask] == null)
							{
								return false;
							}
							Volatile.Write<object>(ref this.m_array[i & this.m_mask], null);
							if (i == this.m_tailIndex)
							{
								this.m_tailIndex--;
							}
							else if (i == this.m_headIndex)
							{
								this.m_headIndex++;
							}
							return true;
						}
						finally
						{
							if (flag)
							{
								this.m_foreignLock.Exit(false);
							}
						}
					}
				}
				return false;
			}

			// Token: 0x060041F4 RID: 16884 RVA: 0x000DC768 File Offset: 0x000DA968
			public object LocalPop()
			{
				if (this.m_headIndex >= this.m_tailIndex)
				{
					return null;
				}
				return this.LocalPopCore();
			}

			// Token: 0x060041F5 RID: 16885 RVA: 0x000DC784 File Offset: 0x000DA984
			private object LocalPopCore()
			{
				int num3;
				object obj2;
				for (;;)
				{
					int num = this.m_tailIndex;
					if (this.m_headIndex >= num)
					{
						break;
					}
					num--;
					Interlocked.Exchange(ref this.m_tailIndex, num);
					if (this.m_headIndex > num)
					{
						bool flag = false;
						object result;
						try
						{
							this.m_foreignLock.Enter(ref flag);
							if (this.m_headIndex <= num)
							{
								int num2 = num & this.m_mask;
								object obj = Volatile.Read<object>(ref this.m_array[num2]);
								if (obj == null)
								{
									continue;
								}
								this.m_array[num2] = null;
								result = obj;
							}
							else
							{
								this.m_tailIndex = num + 1;
								result = null;
							}
						}
						finally
						{
							if (flag)
							{
								this.m_foreignLock.Exit(false);
							}
						}
						return result;
					}
					num3 = (num & this.m_mask);
					obj2 = Volatile.Read<object>(ref this.m_array[num3]);
					if (obj2 != null)
					{
						goto Block_2;
					}
				}
				return null;
				Block_2:
				this.m_array[num3] = null;
				return obj2;
			}

			// Token: 0x17000BEF RID: 3055
			// (get) Token: 0x060041F6 RID: 16886 RVA: 0x000DC880 File Offset: 0x000DAA80
			public bool CanSteal
			{
				get
				{
					return this.m_headIndex < this.m_tailIndex;
				}
			}

			// Token: 0x060041F7 RID: 16887 RVA: 0x000DC894 File Offset: 0x000DAA94
			public object TrySteal(ref bool missedSteal)
			{
				while (this.CanSteal)
				{
					bool flag = false;
					try
					{
						this.m_foreignLock.TryEnter(ref flag);
						if (flag)
						{
							int headIndex = this.m_headIndex;
							Interlocked.Exchange(ref this.m_headIndex, headIndex + 1);
							if (headIndex < this.m_tailIndex)
							{
								int num = headIndex & this.m_mask;
								object obj = Volatile.Read<object>(ref this.m_array[num]);
								if (obj == null)
								{
									continue;
								}
								this.m_array[num] = null;
								return obj;
							}
							else
							{
								this.m_headIndex = headIndex;
							}
						}
					}
					finally
					{
						if (flag)
						{
							this.m_foreignLock.Exit(false);
						}
					}
					missedSteal = true;
					break;
				}
				return null;
			}

			// Token: 0x17000BF0 RID: 3056
			// (get) Token: 0x060041F8 RID: 16888 RVA: 0x000DC94C File Offset: 0x000DAB4C
			public int Count
			{
				get
				{
					bool flag = false;
					int result;
					try
					{
						this.m_foreignLock.Enter(ref flag);
						result = Math.Max(0, this.m_tailIndex - this.m_headIndex);
					}
					finally
					{
						if (flag)
						{
							this.m_foreignLock.Exit(false);
						}
					}
					return result;
				}
			}

			// Token: 0x04000E21 RID: 3617
			internal volatile object[] m_array = new object[32];

			// Token: 0x04000E22 RID: 3618
			private volatile int m_mask = 31;

			// Token: 0x04000E23 RID: 3619
			private volatile int m_headIndex;

			// Token: 0x04000E24 RID: 3620
			private volatile int m_tailIndex;

			// Token: 0x04000E25 RID: 3621
			private SpinLock m_foreignLock = new SpinLock(false);
		}

		// Token: 0x02000428 RID: 1064
		private enum QueueProcessingStage
		{
			// Token: 0x04000E27 RID: 3623
			NotScheduled,
			// Token: 0x04000E28 RID: 3624
			Determining,
			// Token: 0x04000E29 RID: 3625
			Scheduled
		}

		// Token: 0x02000429 RID: 1065
		private struct CacheLineSeparated
		{
			// Token: 0x04000E2A RID: 3626
			private readonly PaddingFor32 pad1;

			// Token: 0x04000E2B RID: 3627
			public ThreadPoolWorkQueue.QueueProcessingStage queueProcessingStage;

			// Token: 0x04000E2C RID: 3628
			private readonly PaddingFor32 pad2;
		}
	}
}
