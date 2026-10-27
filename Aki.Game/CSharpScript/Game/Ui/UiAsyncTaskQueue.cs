using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004626 RID: 17958
	public class UiAsyncTaskQueue
	{
		// Token: 0x0602E42C RID: 189484 RVA: 0x00AB1FED File Offset: 0x00AB01ED
		[NullableContext(1)]
		public void EnQueue(UiAsyncTask task)
		{
			if (this.TaskQueue == null)
			{
				this.TaskQueue = new Queue<UiAsyncTask>(4);
			}
			this.TaskQueue.Push(task);
		}

		// Token: 0x0602E42D RID: 189485 RVA: 0x00AB2010 File Offset: 0x00AB0210
		public UniTask ProcessQueue()
		{
			UiAsyncTaskQueue.<ProcessQueue>d__5 <ProcessQueue>d__;
			<ProcessQueue>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessQueue>d__.<>4__this = this;
			<ProcessQueue>d__.<>1__state = -1;
			<ProcessQueue>d__.<>t__builder.Start<UiAsyncTaskQueue.<ProcessQueue>d__5>(ref <ProcessQueue>d__);
			return <ProcessQueue>d__.<>t__builder.Task;
		}

		// Token: 0x0602E42E RID: 189486 RVA: 0x00AB2054 File Offset: 0x00AB0254
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

		// Token: 0x0602E42F RID: 189487 RVA: 0x00AB20BC File Offset: 0x00AB02BC
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

		// Token: 0x04018D4C RID: 101708
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Queue<UiAsyncTask> TaskQueue;

		// Token: 0x04018D4D RID: 101709
		private bool IsProcessing;

		// Token: 0x04018D4E RID: 101710
		private bool Canceled;

		// Token: 0x04018D4F RID: 101711
		[Nullable(2)]
		private UiAsyncTask CurrentRunningTask;
	}
}
