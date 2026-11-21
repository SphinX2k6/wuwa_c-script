using System;

namespace System.Threading
{
	// Token: 0x02000435 RID: 1077
	internal sealed class QueueUserWorkItemCallbackDefaultContext<TState> : QueueUserWorkItemCallbackBase
	{
		// Token: 0x06004217 RID: 16919 RVA: 0x000DCCC5 File Offset: 0x000DAEC5
		internal QueueUserWorkItemCallbackDefaultContext(Action<TState> callback, TState state)
		{
			this._callback = callback;
			this._state = state;
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x000DCCDB File Offset: 0x000DAEDB
		public override void Execute()
		{
			base.Execute();
			Action<TState> callback = this._callback;
			this._callback = null;
			callback(this._state);
		}

		// Token: 0x04000E46 RID: 3654
		private Action<TState> _callback;

		// Token: 0x04000E47 RID: 3655
		private readonly TState _state;
	}
}
