using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Misc.PreemptiveFrameQueue
{
	// Token: 0x020054AD RID: 21677
	[NullableContext(1)]
	[Nullable(0)]
	public class SimplePreemptiveFrameQueue
	{
		// Token: 0x170084C4 RID: 33988
		// (get) Token: 0x06037627 RID: 226855 RVA: 0x00D27892 File Offset: 0x00D25A92
		public int PerFrameTaskLimit { get; }

		// Token: 0x170084C5 RID: 33989
		// (get) Token: 0x06037628 RID: 226856 RVA: 0x00D2789A File Offset: 0x00D25A9A
		public int ExecuteFrameInterval { get; }

		// Token: 0x06037629 RID: 226857 RVA: 0x00D278A2 File Offset: 0x00D25AA2
		public SimplePreemptiveFrameQueue(int perFrameTaskLimit, int executeFrameInterval = 0)
		{
			this.PerFrameTaskLimit = perFrameTaskLimit;
			this.ExecuteFrameInterval = executeFrameInterval;
			this.FrameCounter = this.ExecuteFrameInterval;
		}

		// Token: 0x0603762A RID: 226858 RVA: 0x00D278D0 File Offset: 0x00D25AD0
		public virtual void AddTask(IPreemptiveFrameTask task)
		{
			int num = 0;
			while (num < this.Tasks.Count && this.Tasks[num].Priority < task.Priority)
			{
				num++;
			}
			this.Tasks.Insert(num, task);
			if (this.IsTaskComplete() && !this.OnExecutionInterval)
			{
				this.FrameCounter = this.ExecuteFrameInterval;
			}
		}

		// Token: 0x0603762B RID: 226859 RVA: 0x00D27938 File Offset: 0x00D25B38
		public void CancelTask(IPreemptiveFrameTask task)
		{
			int num = this.Tasks.IndexOf(task);
			if (num > -1)
			{
				TPreemptiveCancelMethod cancel = task.Cancel;
				if (cancel != null)
				{
					cancel();
				}
				this.Tasks.RemoveAt(num);
			}
		}

		// Token: 0x0603762C RID: 226860 RVA: 0x00D27974 File Offset: 0x00D25B74
		public void Process()
		{
			if (this.OnExecutionInterval)
			{
				this.FrameCounter++;
				return;
			}
			if (this.FrameCounter >= this.ExecuteFrameInterval)
			{
				this.FrameCounter = 0;
			}
			if (this.IsTaskComplete())
			{
				this.FrameExecuteTaskCounter = 0;
				while (this.Tasks.Count > 0 && this.FrameExecuteTaskCounter < this.PerFrameTaskLimit)
				{
					this.CurrentTask = this.ShiftNextTask();
					if (this.CurrentTask != null)
					{
						this.CurrentTask.Execute();
						if (!this.EnableFlush)
						{
							this.FrameExecuteTaskCounter++;
						}
						if (!this.IsTaskComplete())
						{
							break;
						}
						this.OnTaskComplete(this.CurrentTask);
					}
				}
				if (this.Tasks.Count == 0)
				{
					this.CurrentTask = null;
				}
				if (this.FrameExecuteTaskCounter != 0)
				{
					this.OnLateExecuteTasksFrame();
				}
				return;
			}
			TPreemptiveExecuteMethod frameExecute = this.CurrentTask.FrameExecute;
			if (frameExecute == null)
			{
				return;
			}
			frameExecute();
		}

		// Token: 0x0603762D RID: 226861 RVA: 0x00D27A60 File Offset: 0x00D25C60
		[NullableContext(2)]
		protected virtual IPreemptiveFrameTask ShiftNextTask()
		{
			if (this.Tasks.Count > 0)
			{
				IPreemptiveFrameTask result = this.Tasks[0];
				this.Tasks.RemoveAt(0);
				return result;
			}
			return null;
		}

		// Token: 0x0603762E RID: 226862 RVA: 0x00D27A8A File Offset: 0x00D25C8A
		protected virtual void OnTaskComplete(IPreemptiveFrameTask task)
		{
		}

		// Token: 0x0603762F RID: 226863 RVA: 0x00D27A8C File Offset: 0x00D25C8C
		protected virtual void OnLateExecuteTasksFrame()
		{
		}

		// Token: 0x06037630 RID: 226864 RVA: 0x00D27A8E File Offset: 0x00D25C8E
		protected bool IsTaskComplete()
		{
			if (this.CurrentTask != null)
			{
				TPreemptiveIsCompleteMethod isComplete = this.CurrentTask.IsComplete;
				return isComplete == null || isComplete();
			}
			return true;
		}

		// Token: 0x170084C6 RID: 33990
		// (get) Token: 0x06037631 RID: 226865 RVA: 0x00D27AB0 File Offset: 0x00D25CB0
		protected bool OnExecutionInterval
		{
			get
			{
				return this.FrameCounter < this.ExecuteFrameInterval;
			}
		}

		// Token: 0x06037632 RID: 226866 RVA: 0x00D27AC0 File Offset: 0x00D25CC0
		public virtual void Dispose()
		{
			IPreemptiveFrameTask currentTask = this.CurrentTask;
			if (currentTask != null)
			{
				TPreemptiveCancelMethod cancel = currentTask.Cancel;
				if (cancel != null)
				{
					cancel();
				}
			}
			this.CurrentTask = null;
			this.Tasks.Clear();
		}

		// Token: 0x0401D2C8 RID: 119496
		protected readonly List<IPreemptiveFrameTask> Tasks = new List<IPreemptiveFrameTask>();

		// Token: 0x0401D2C9 RID: 119497
		[Nullable(2)]
		private IPreemptiveFrameTask CurrentTask;

		// Token: 0x0401D2CA RID: 119498
		private int FrameExecuteTaskCounter;

		// Token: 0x0401D2CB RID: 119499
		protected bool EnableFlush;

		// Token: 0x0401D2CC RID: 119500
		private int FrameCounter;
	}
}
