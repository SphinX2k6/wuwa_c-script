using System;

namespace System.Threading.Tasks
{
	// Token: 0x020004B9 RID: 1209
	internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
	{
		// Token: 0x06004667 RID: 18023 RVA: 0x000EBD40 File Offset: 0x000E9F40
		internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask)
		{
			this.m_action = action;
			this.m_completingTask = completingTask;
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x000EBD56 File Offset: 0x000E9F56
		void IThreadPoolWorkItem.Execute()
		{
			this.m_action.Invoke(this.m_completingTask);
		}

		// Token: 0x04001058 RID: 4184
		private readonly ITaskCompletionAction m_action;

		// Token: 0x04001059 RID: 4185
		private readonly Task m_completingTask;
	}
}
