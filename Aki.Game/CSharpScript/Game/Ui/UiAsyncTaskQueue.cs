using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200354F RID: 13647
	public class UiAsyncTaskQueue
	{
		// Token: 0x06022B21 RID: 142113 RVA: 0x009DE6E1 File Offset: 0x009DC8E1
		[NullableContext(1)]
		public void EnQueue(UiAsyncTask task)
		{
			if (this.TaskQueue == null)
			{
				this.TaskQueue = new Queue<UiAsyncTask>(4);
			}
			this.TaskQueue.Push(task);
		}

		// Token: 0x06022B22 RID: 142114 RVA: 0x009DE704 File Offset: 0x009DC904
		public UniTask ProcessQueue()
		{
			UiAsyncTaskQueue.<ProcessQueue>d__5 <ProcessQueue>d__;
			<ProcessQueue>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessQueue>d__.<>4__this = this;
			<ProcessQueue>d__.<>1__state = -1;
			<ProcessQueue>d__.<>t__builder.Start<UiAsyncTaskQueue.<ProcessQueue>d__5>(ref <ProcessQueue>d__);
			return <ProcessQueue>d__.<>t__builder.Task;
		}

		// Token: 0x06022B23 RID: 142115 RVA: 0x009DE748 File Offset: 0x009DC948
		public void Cancel()
		{
			this.Canceled = true;
			UiAsyncTask currentRunningTask = this.CurrentRunningTask;
			if (currentRunningTask != null)
			{
				currentRunningTask.Cancel();
			}
			if (this.TaskQueue == null)
			{
				return;
			}
			for (int i = 0; i < this.TaskQueue.Size; i++)
			{
				UiAsyncTask uiAsyncTask = this.TaskQueue.Get(i);
				if (uiAsyncTask != null)
				{
					uiAsyncTask.Cancel();
				}
			}
			this.TaskQueue.Clear();
		}

		// Token: 0x06022B24 RID: 142116 RVA: 0x009DE7B0 File Offset: 0x009DC9B0
		public void CancelPending()
		{
			if (this.TaskQueue == null)
			{
				return;
			}
			for (int i = 0; i < this.TaskQueue.Size; i++)
			{
				UiAsyncTask uiAsyncTask = this.TaskQueue.Get(i);
				if (uiAsyncTask != null)
				{
					uiAsyncTask.Cancel();
				}
			}
			this.TaskQueue.Clear();
		}

		// Token: 0x0401338B RID: 78731
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Queue<UiAsyncTask> TaskQueue;

		// Token: 0x0401338C RID: 78732
		private bool IsProcessing;

		// Token: 0x0401338D RID: 78733
		private bool Canceled;

		// Token: 0x0401338E RID: 78734
		[Nullable(2)]
		private UiAsyncTask CurrentRunningTask;
	}
}
