using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Misc.PreemptiveFrameQueue
{
	// Token: 0x02004490 RID: 17552
	[NullableContext(1)]
	[Nullable(0)]
	public class SimplePreemptiveFrameQueue
	{
		// Token: 0x17005890 RID: 22672
		// (get) Token: 0x0602C57D RID: 181629 RVA: 0x00C7760E File Offset: 0x00C7580E
		public int PerFrameTaskLimit { get; }

		// Token: 0x17005891 RID: 22673
		// (get) Token: 0x0602C57E RID: 181630 RVA: 0x00C77616 File Offset: 0x00C75816
		public int ExecuteFrameInterval { get; }

		// Token: 0x0602C57F RID: 181631 RVA: 0x00C7761E File Offset: 0x00C7581E
		public SimplePreemptiveFrameQueue(int perFrameTaskLimit, int executeFrameInterval = 0)
		{
			this.PerFrameTaskLimit = perFrameTaskLimit;
			this.ExecuteFrameInterval = executeFrameInterval;
			this.FrameCounter = this.ExecuteFrameInterval;
		}

		// Token: 0x0602C580 RID: 181632 RVA: 0x00C7764C File Offset: 0x00C7584C
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

		// Token: 0x0602C581 RID: 181633 RVA: 0x00C776B4 File Offset: 0x00C758B4
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

		// Token: 0x0602C582 RID: 181634 RVA: 0x00C776F0 File Offset: 0x00C758F0
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

		// Token: 0x0602C583 RID: 181635 RVA: 0x00C777DC File Offset: 0x00C759DC
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

		// Token: 0x0602C584 RID: 181636 RVA: 0x00C77806 File Offset: 0x00C75A06
		protected virtual void OnTaskComplete(IPreemptiveFrameTask task)
		{
		}

		// Token: 0x0602C585 RID: 181637 RVA: 0x00C77808 File Offset: 0x00C75A08
		protected virtual void OnLateExecuteTasksFrame()
		{
		}

		// Token: 0x0602C586 RID: 181638 RVA: 0x00C7780A File Offset: 0x00C75A0A
		protected bool IsTaskComplete()
		{
			if (this.CurrentTask != null)
			{
				TPreemptiveIsCompleteMethod isComplete = this.CurrentTask.IsComplete;
				return isComplete == null || isComplete();
			}
			return true;
		}

		// Token: 0x17005892 RID: 22674
		// (get) Token: 0x0602C587 RID: 181639 RVA: 0x00C7782C File Offset: 0x00C75A2C
		protected bool OnExecutionInterval
		{
			get
			{
				return this.FrameCounter < this.ExecuteFrameInterval;
			}
		}

		// Token: 0x0602C588 RID: 181640 RVA: 0x00C7783C File Offset: 0x00C75A3C
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

		// Token: 0x04017D64 RID: 97636
		protected readonly List<IPreemptiveFrameTask> Tasks = new List<IPreemptiveFrameTask>();

		// Token: 0x04017D65 RID: 97637
		[Nullable(2)]
		private IPreemptiveFrameTask CurrentTask;

		// Token: 0x04017D66 RID: 97638
		private int FrameExecuteTaskCounter;

		// Token: 0x04017D67 RID: 97639
		protected bool EnableFlush;

		// Token: 0x04017D68 RID: 97640
		private int FrameCounter;
	}
}
