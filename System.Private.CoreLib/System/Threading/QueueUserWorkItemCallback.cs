using System;

namespace System.Threading
{
	// Token: 0x02000431 RID: 1073
	internal sealed class QueueUserWorkItemCallback : QueueUserWorkItemCallbackBase
	{
		// Token: 0x0600420D RID: 16909 RVA: 0x000DCBCA File Offset: 0x000DADCA
		internal QueueUserWorkItemCallback(WaitCallback callback, object state, ExecutionContext context)
		{
			this._callback = callback;
			this._state = state;
			this._context = context;
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x000DCBE7 File Offset: 0x000DADE7
		public override void Execute()
		{
			base.Execute();
			ExecutionContext.RunForThreadPoolUnsafe<QueueUserWorkItemCallback>(this._context, QueueUserWorkItemCallback.s_executionContextShim, this);
		}

		// Token: 0x04000E3C RID: 3644
		private WaitCallback _callback;

		// Token: 0x04000E3D RID: 3645
		private readonly object _state;

		// Token: 0x04000E3E RID: 3646
		private readonly ExecutionContext _context;

		// Token: 0x04000E3F RID: 3647
		private static readonly Action<QueueUserWorkItemCallback> s_executionContextShim = delegate(QueueUserWorkItemCallback quwi)
		{
			WaitCallback callback = quwi._callback;
			quwi._callback = null;
			callback(quwi._state);
		};
	}
}
