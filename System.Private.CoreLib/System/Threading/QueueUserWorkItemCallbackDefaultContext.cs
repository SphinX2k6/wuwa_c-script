using System;

namespace System.Threading
{
	// Token: 0x02000434 RID: 1076
	internal sealed class QueueUserWorkItemCallbackDefaultContext : QueueUserWorkItemCallbackBase
	{
		// Token: 0x06004215 RID: 16917 RVA: 0x000DCC8F File Offset: 0x000DAE8F
		internal QueueUserWorkItemCallbackDefaultContext(WaitCallback callback, object state)
		{
			this._callback = callback;
			this._state = state;
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x000DCCA5 File Offset: 0x000DAEA5
		public override void Execute()
		{
			base.Execute();
			WaitCallback callback = this._callback;
			this._callback = null;
			callback(this._state);
		}

		// Token: 0x04000E44 RID: 3652
		private WaitCallback _callback;

		// Token: 0x04000E45 RID: 3653
		private readonly object _state;
	}
}
