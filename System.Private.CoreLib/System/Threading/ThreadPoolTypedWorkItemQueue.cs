using System;
using System.Collections.Concurrent;

namespace System.Threading
{
	// Token: 0x0200042C RID: 1068
	internal sealed class ThreadPoolTypedWorkItemQueue<T, TCallback> : IThreadPoolWorkItem where T : struct where TCallback : struct, IThreadPoolTypedWorkItemQueueCallback<T>
	{
		// Token: 0x060041FE RID: 16894 RVA: 0x000DCAA0 File Offset: 0x000DACA0
		public void BatchEnqueue(T workItem)
		{
			this._workItems.Enqueue(workItem);
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x000DCAAE File Offset: 0x000DACAE
		public void CompleteBatchEnqueue()
		{
			if (Interlocked.Exchange<ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage>(ref this._queueProcessingStage, ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage.Scheduled) == ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage.NotScheduled)
			{
				ThreadPool.UnsafeQueueHighPriorityWorkItemInternal(this);
			}
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x000DCAC4 File Offset: 0x000DACC4
		private void UpdateQueueProcessingStage(bool isQueueEmpty)
		{
			if (!isQueueEmpty)
			{
				this._queueProcessingStage = ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage.Scheduled;
			}
			else if (Interlocked.CompareExchange<ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage>(ref this._queueProcessingStage, ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage.NotScheduled, ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage.Determining) == ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage.Determining)
			{
				return;
			}
			ThreadPool.UnsafeQueueHighPriorityWorkItemInternal(this);
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x000DCAEC File Offset: 0x000DACEC
		void IThreadPoolWorkItem.Execute()
		{
			do
			{
				this._queueProcessingStage = ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage.Determining;
				Interlocked.MemoryBarrier();
				T item;
				if (this._workItems.TryDequeue(out item))
				{
					goto IL_3B;
				}
			}
			while (Interlocked.CompareExchange<ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage>(ref this._queueProcessingStage, ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage.NotScheduled, ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage.Determining) != ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage.Determining);
			ThreadInt64PersistentCounter.Decrement(ThreadPoolWorkQueueThreadLocals.threadLocals.threadLocalCompletionCountObject);
			return;
			IL_3B:
			this.UpdateQueueProcessingStage(this._workItems.IsEmpty);
			ThreadPoolWorkQueueThreadLocals threadLocals = ThreadPoolWorkQueueThreadLocals.threadLocals;
			Thread currentThread = threadLocals.currentThread;
			uint num = 0U;
			int tickCount = Environment.TickCount;
			for (;;)
			{
				T item;
				IThreadPoolTypedWorkItemQueueCallback<T>.Invoke(item);
				if ((num += 1U) == 4294967295U || threadLocals.workStealingQueue.CanSteal || Environment.TickCount - tickCount >= 15 || !this._workItems.TryDequeue(out item))
				{
					break;
				}
				ExecutionContext.ResetThreadPoolThread(currentThread);
				currentThread.ResetThreadPoolThread();
			}
			if (num > 1U)
			{
				ThreadInt64PersistentCounter.Add(threadLocals.threadLocalCompletionCountObject, num - 1U);
			}
		}

		// Token: 0x04000E36 RID: 3638
		private ThreadPoolTypedWorkItemQueue<T, TCallback>.QueueProcessingStage _queueProcessingStage;

		// Token: 0x04000E37 RID: 3639
		private readonly ConcurrentQueue<T> _workItems = new ConcurrentQueue<T>();

		// Token: 0x0200042D RID: 1069
		private enum QueueProcessingStage
		{
			// Token: 0x04000E39 RID: 3641
			NotScheduled,
			// Token: 0x04000E3A RID: 3642
			Determining,
			// Token: 0x04000E3B RID: 3643
			Scheduled
		}
	}
}
