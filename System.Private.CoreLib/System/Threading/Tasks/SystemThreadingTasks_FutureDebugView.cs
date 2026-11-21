using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200049B RID: 1179
	internal sealed class SystemThreadingTasks_FutureDebugView<TResult>
	{
		// Token: 0x060044D3 RID: 17619 RVA: 0x000E61B2 File Offset: 0x000E43B2
		public SystemThreadingTasks_FutureDebugView(Task<TResult> task)
		{
			this.m_task = task;
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x000E61C4 File Offset: 0x000E43C4
		public TResult Result
		{
			get
			{
				if (this.m_task.Status != TaskStatus.RanToCompletion)
				{
					return default(TResult);
				}
				return this.m_task.Result;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060044D5 RID: 17621 RVA: 0x000E61F4 File Offset: 0x000E43F4
		public object AsyncState
		{
			get
			{
				return this.m_task.AsyncState;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x000E6201 File Offset: 0x000E4401
		public TaskCreationOptions CreationOptions
		{
			get
			{
				return this.m_task.CreationOptions;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060044D7 RID: 17623 RVA: 0x000E620E File Offset: 0x000E440E
		public Exception Exception
		{
			get
			{
				return this.m_task.Exception;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060044D8 RID: 17624 RVA: 0x000E621B File Offset: 0x000E441B
		public int Id
		{
			get
			{
				return this.m_task.Id;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060044D9 RID: 17625 RVA: 0x000E6228 File Offset: 0x000E4428
		public bool CancellationPending
		{
			get
			{
				return this.m_task.Status == TaskStatus.WaitingToRun && this.m_task.CancellationToken.IsCancellationRequested;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060044DA RID: 17626 RVA: 0x000E6258 File Offset: 0x000E4458
		public TaskStatus Status
		{
			get
			{
				return this.m_task.Status;
			}
		}

		// Token: 0x04000FD8 RID: 4056
		private readonly Task<TResult> m_task;
	}
}
