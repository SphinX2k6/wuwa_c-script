using System;
using System.Collections.Concurrent;

namespace System.Threading
{
	// Token: 0x0200042A RID: 1066
	internal sealed class ThreadPoolWorkQueueThreadLocals
	{
		// Token: 0x060041FA RID: 16890 RVA: 0x000DC9D4 File Offset: 0x000DABD4
		public ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq)
		{
			this.assignedGlobalWorkItemQueue = tpq.workItems;
			this.workQueue = tpq;
			this.workStealingQueue = new ThreadPoolWorkQueue.WorkStealingQueue();
			ThreadPoolWorkQueue.WorkStealingQueueList.Add(this.workStealingQueue);
			this.currentThread = Thread.CurrentThread;
			this.threadLocalCompletionCountObject = ThreadPool.GetOrCreateThreadLocalCompletionCountObject();
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x000DCA34 File Offset: 0x000DAC34
		public void TransferLocalWork()
		{
			for (;;)
			{
				object obj = this.workStealingQueue.LocalPop();
				if (obj == null)
				{
					break;
				}
				this.workQueue.Enqueue(obj, true);
			}
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x000DCA60 File Offset: 0x000DAC60
		~ThreadPoolWorkQueueThreadLocals()
		{
			if (this.workStealingQueue != null)
			{
				this.TransferLocalWork();
				ThreadPoolWorkQueue.WorkStealingQueueList.Remove(this.workStealingQueue);
			}
		}

		// Token: 0x04000E2D RID: 3629
		[ThreadStatic]
		public static ThreadPoolWorkQueueThreadLocals threadLocals;

		// Token: 0x04000E2E RID: 3630
		public bool isProcessingHighPriorityWorkItems;

		// Token: 0x04000E2F RID: 3631
		public int queueIndex;

		// Token: 0x04000E30 RID: 3632
		public ConcurrentQueue<object> assignedGlobalWorkItemQueue;

		// Token: 0x04000E31 RID: 3633
		public readonly ThreadPoolWorkQueue workQueue;

		// Token: 0x04000E32 RID: 3634
		public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue;

		// Token: 0x04000E33 RID: 3635
		public readonly Thread currentThread;

		// Token: 0x04000E34 RID: 3636
		public readonly object threadLocalCompletionCountObject;

		// Token: 0x04000E35 RID: 3637
		public readonly Random.XoshiroImpl random = new Random.XoshiroImpl();
	}
}
