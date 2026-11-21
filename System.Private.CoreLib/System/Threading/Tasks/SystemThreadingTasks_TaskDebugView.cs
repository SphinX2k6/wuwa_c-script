using System;

namespace System.Threading.Tasks
{
	// Token: 0x020004BA RID: 1210
	internal sealed class SystemThreadingTasks_TaskDebugView
	{
		// Token: 0x06004669 RID: 18025 RVA: 0x000EBD69 File Offset: 0x000E9F69
		public SystemThreadingTasks_TaskDebugView(Task task)
		{
			this.m_task = task;
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x0600466A RID: 18026 RVA: 0x000EBD78 File Offset: 0x000E9F78
		public object AsyncState
		{
			get
			{
				return this.m_task.AsyncState;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600466B RID: 18027 RVA: 0x000EBD85 File Offset: 0x000E9F85
		public TaskCreationOptions CreationOptions
		{
			get
			{
				return this.m_task.CreationOptions;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x0600466C RID: 18028 RVA: 0x000EBD92 File Offset: 0x000E9F92
		public Exception Exception
		{
			get
			{
				return this.m_task.Exception;
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x0600466D RID: 18029 RVA: 0x000EBD9F File Offset: 0x000E9F9F
		public int Id
		{
			get
			{
				return this.m_task.Id;
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x0600466E RID: 18030 RVA: 0x000EBDAC File Offset: 0x000E9FAC
		public bool CancellationPending
		{
			get
			{
				return this.m_task.Status == TaskStatus.WaitingToRun && this.m_task.CancellationToken.IsCancellationRequested;
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x0600466F RID: 18031 RVA: 0x000EBDDC File Offset: 0x000E9FDC
		public TaskStatus Status
		{
			get
			{
				return this.m_task.Status;
			}
		}

		// Token: 0x0400105A RID: 4186
		private readonly Task m_task;
	}
}
