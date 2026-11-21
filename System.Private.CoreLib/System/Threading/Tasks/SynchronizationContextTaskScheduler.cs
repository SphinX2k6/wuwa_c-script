using System;
using System.Collections.Generic;

namespace System.Threading.Tasks
{
	// Token: 0x020004DF RID: 1247
	internal sealed class SynchronizationContextTaskScheduler : TaskScheduler
	{
		// Token: 0x06004771 RID: 18289 RVA: 0x000EE835 File Offset: 0x000ECA35
		internal SynchronizationContextTaskScheduler()
		{
			SynchronizationContext synchronizationContext = SynchronizationContext.Current;
			if (synchronizationContext == null)
			{
				throw new InvalidOperationException(SR.TaskScheduler_FromCurrentSynchronizationContext_NoCurrent);
			}
			this.m_synchronizationContext = synchronizationContext;
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x000EE857 File Offset: 0x000ECA57
		protected internal override void QueueTask(Task task)
		{
			this.m_synchronizationContext.Post(SynchronizationContextTaskScheduler.s_postCallback, task);
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x000EE86A File Offset: 0x000ECA6A
		protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			return SynchronizationContext.Current == this.m_synchronizationContext && base.TryExecuteTask(task);
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x0001A4BA File Offset: 0x000186BA
		protected override IEnumerable<Task> GetScheduledTasks()
		{
			return null;
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06004775 RID: 18293 RVA: 0x000070DD File Offset: 0x000052DD
		public override int MaximumConcurrencyLevel
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x040010BB RID: 4283
		private readonly SynchronizationContext m_synchronizationContext;

		// Token: 0x040010BC RID: 4284
		private static readonly SendOrPostCallback s_postCallback = delegate(object s)
		{
			((Task)s).ExecuteEntry();
		};
	}
}
