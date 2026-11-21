using System;

namespace System.Threading
{
	// Token: 0x020003EC RID: 1004
	internal sealed class IOCompletionCallbackHelper
	{
		// Token: 0x06004032 RID: 16434 RVA: 0x000D663E File Offset: 0x000D483E
		public IOCompletionCallbackHelper(IOCompletionCallback ioCompletionCallback, ExecutionContext executionContext)
		{
			this._ioCompletionCallback = ioCompletionCallback;
			this._executionContext = executionContext;
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x000D6654 File Offset: 0x000D4854
		private static void IOCompletionCallback_Context(object state)
		{
			IOCompletionCallbackHelper iocompletionCallbackHelper = (IOCompletionCallbackHelper)state;
			iocompletionCallbackHelper._ioCompletionCallback(iocompletionCallbackHelper._errorCode, iocompletionCallbackHelper._numBytes, iocompletionCallbackHelper._pNativeOverlapped);
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x000D6688 File Offset: 0x000D4888
		public unsafe static void PerformSingleIOCompletionCallback(uint errorCode, uint numBytes, NativeOverlapped* pNativeOverlapped)
		{
			object callback = Overlapped.GetOverlappedFromNative(pNativeOverlapped)._callback;
			IOCompletionCallback iocompletionCallback = callback as IOCompletionCallback;
			if (iocompletionCallback != null)
			{
				iocompletionCallback(errorCode, numBytes, pNativeOverlapped);
				return;
			}
			if (callback == null)
			{
				return;
			}
			IOCompletionCallbackHelper iocompletionCallbackHelper = (IOCompletionCallbackHelper)callback;
			iocompletionCallbackHelper._errorCode = errorCode;
			iocompletionCallbackHelper._numBytes = numBytes;
			iocompletionCallbackHelper._pNativeOverlapped = pNativeOverlapped;
			ExecutionContext.RunInternal(iocompletionCallbackHelper._executionContext, IOCompletionCallbackHelper.IOCompletionCallback_Context_Delegate, iocompletionCallbackHelper);
		}

		// Token: 0x04000D66 RID: 3430
		private readonly IOCompletionCallback _ioCompletionCallback;

		// Token: 0x04000D67 RID: 3431
		private readonly ExecutionContext _executionContext;

		// Token: 0x04000D68 RID: 3432
		private uint _errorCode;

		// Token: 0x04000D69 RID: 3433
		private uint _numBytes;

		// Token: 0x04000D6A RID: 3434
		private unsafe NativeOverlapped* _pNativeOverlapped;

		// Token: 0x04000D6B RID: 3435
		private static readonly ContextCallback IOCompletionCallback_Context_Delegate = new ContextCallback(IOCompletionCallbackHelper.IOCompletionCallback_Context);
	}
}
