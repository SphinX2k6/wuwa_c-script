using System;

namespace System.Threading
{
	// Token: 0x02000436 RID: 1078
	internal sealed class _ThreadPoolWaitOrTimerCallback
	{
		// Token: 0x06004219 RID: 16921 RVA: 0x000DCCFB File Offset: 0x000DAEFB
		internal _ThreadPoolWaitOrTimerCallback(WaitOrTimerCallback waitOrTimerCallback, object state, bool flowExecutionContext)
		{
			this._waitOrTimerCallback = waitOrTimerCallback;
			this._state = state;
			if (flowExecutionContext)
			{
				this._executionContext = ExecutionContext.Capture();
			}
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x000DCD1F File Offset: 0x000DAF1F
		private static void WaitOrTimerCallback_Context_t(object state)
		{
			_ThreadPoolWaitOrTimerCallback.WaitOrTimerCallback_Context(state, true);
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x000DCD28 File Offset: 0x000DAF28
		private static void WaitOrTimerCallback_Context_f(object state)
		{
			_ThreadPoolWaitOrTimerCallback.WaitOrTimerCallback_Context(state, false);
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x000DCD34 File Offset: 0x000DAF34
		private static void WaitOrTimerCallback_Context(object state, bool timedOut)
		{
			_ThreadPoolWaitOrTimerCallback threadPoolWaitOrTimerCallback = (_ThreadPoolWaitOrTimerCallback)state;
			threadPoolWaitOrTimerCallback._waitOrTimerCallback(threadPoolWaitOrTimerCallback._state, timedOut);
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x000DCD5C File Offset: 0x000DAF5C
		internal static void PerformWaitOrTimerCallback(_ThreadPoolWaitOrTimerCallback helper, bool timedOut)
		{
			ExecutionContext executionContext = helper._executionContext;
			if (executionContext == null)
			{
				helper._waitOrTimerCallback(helper._state, timedOut);
				return;
			}
			ExecutionContext.Run(executionContext, timedOut ? _ThreadPoolWaitOrTimerCallback._ccbt : _ThreadPoolWaitOrTimerCallback._ccbf, helper);
		}

		// Token: 0x04000E48 RID: 3656
		private readonly WaitOrTimerCallback _waitOrTimerCallback;

		// Token: 0x04000E49 RID: 3657
		private readonly ExecutionContext _executionContext;

		// Token: 0x04000E4A RID: 3658
		private readonly object _state;

		// Token: 0x04000E4B RID: 3659
		private static readonly ContextCallback _ccbt = new ContextCallback(_ThreadPoolWaitOrTimerCallback.WaitOrTimerCallback_Context_t);

		// Token: 0x04000E4C RID: 3660
		private static readonly ContextCallback _ccbf = new ContextCallback(_ThreadPoolWaitOrTimerCallback.WaitOrTimerCallback_Context_f);
	}
}
