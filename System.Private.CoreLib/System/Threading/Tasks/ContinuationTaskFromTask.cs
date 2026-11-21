using System;

namespace System.Threading.Tasks
{
	// Token: 0x020004C9 RID: 1225
	internal sealed class ContinuationTaskFromTask : Task
	{
		// Token: 0x060046B8 RID: 18104 RVA: 0x000EC954 File Offset: 0x000EAB54
		public ContinuationTaskFromTask(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) : base(action, state, Task.InternalCurrentIfAttached(creationOptions), default(CancellationToken), creationOptions, internalOptions, null)
		{
			this.m_antecedent = antecedent;
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x000EC988 File Offset: 0x000EAB88
		internal override void InnerInvoke()
		{
			Task antecedent = this.m_antecedent;
			this.m_antecedent = null;
			antecedent.NotifyDebuggerOfWaitCompletionIfNecessary();
			Action<Task> action = this.m_action as Action<Task>;
			if (action != null)
			{
				action(antecedent);
				return;
			}
			Action<Task, object> action2 = this.m_action as Action<Task, object>;
			if (action2 != null)
			{
				action2(antecedent, this.m_stateObject);
				return;
			}
		}

		// Token: 0x04001090 RID: 4240
		private Task m_antecedent;
	}
}
