using System;

namespace System.Threading
{
	// Token: 0x02000433 RID: 1075
	internal sealed class QueueUserWorkItemCallback<TState> : QueueUserWorkItemCallbackBase
	{
		// Token: 0x06004213 RID: 16915 RVA: 0x000DCC3E File Offset: 0x000DAE3E
		internal QueueUserWorkItemCallback(Action<TState> callback, TState state, ExecutionContext context)
		{
			this._callback = callback;
			this._state = state;
			this._context = context;
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x000DCC5C File Offset: 0x000DAE5C
		public override void Execute()
		{
			base.Execute();
			Action<TState> callback = this._callback;
			this._callback = null;
			ExecutionContext.RunForThreadPoolUnsafe<TState>(this._context, callback, this._state);
		}

		// Token: 0x04000E41 RID: 3649
		private Action<TState> _callback;

		// Token: 0x04000E42 RID: 3650
		private readonly TState _state;

		// Token: 0x04000E43 RID: 3651
		private readonly ExecutionContext _context;
	}
}
