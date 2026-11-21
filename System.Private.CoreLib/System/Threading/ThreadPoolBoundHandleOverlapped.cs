using System;

namespace System.Threading
{
	// Token: 0x0200048A RID: 1162
	internal sealed class ThreadPoolBoundHandleOverlapped : Overlapped
	{
		// Token: 0x0600445A RID: 17498 RVA: 0x000E4E24 File Offset: 0x000E3024
		public unsafe ThreadPoolBoundHandleOverlapped(IOCompletionCallback callback, object state, object pinData, PreAllocatedOverlapped preAllocated, bool flowExecutionContext)
		{
			this._userCallback = callback;
			this._userState = state;
			this._preAllocated = preAllocated;
			this._nativeOverlapped = (flowExecutionContext ? base.Pack(ThreadPoolBoundHandleOverlapped.s_completionCallback, pinData) : base.UnsafePack(ThreadPoolBoundHandleOverlapped.s_completionCallback, pinData));
			this._nativeOverlapped->OffsetLow = 0;
			this._nativeOverlapped->OffsetHigh = 0;
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x000E4E8C File Offset: 0x000E308C
		private unsafe static void CompletionCallback(uint errorCode, uint numBytes, NativeOverlapped* nativeOverlapped)
		{
			ThreadPoolBoundHandleOverlapped threadPoolBoundHandleOverlapped = (ThreadPoolBoundHandleOverlapped)Overlapped.Unpack(nativeOverlapped);
			if (threadPoolBoundHandleOverlapped._completed)
			{
				throw new InvalidOperationException(SR.InvalidOperation_NativeOverlappedReused);
			}
			threadPoolBoundHandleOverlapped._completed = true;
			if (threadPoolBoundHandleOverlapped._boundHandle == null)
			{
				throw new InvalidOperationException(SR.Argument_NativeOverlappedAlreadyFree);
			}
			threadPoolBoundHandleOverlapped._userCallback(errorCode, numBytes, nativeOverlapped);
		}

		// Token: 0x04000F99 RID: 3993
		private static readonly IOCompletionCallback s_completionCallback = new IOCompletionCallback(ThreadPoolBoundHandleOverlapped.CompletionCallback);

		// Token: 0x04000F9A RID: 3994
		private readonly IOCompletionCallback _userCallback;

		// Token: 0x04000F9B RID: 3995
		internal readonly object _userState;

		// Token: 0x04000F9C RID: 3996
		internal readonly PreAllocatedOverlapped _preAllocated;

		// Token: 0x04000F9D RID: 3997
		internal unsafe NativeOverlapped* _nativeOverlapped;

		// Token: 0x04000F9E RID: 3998
		internal ThreadPoolBoundHandle _boundHandle;

		// Token: 0x04000F9F RID: 3999
		internal bool _completed;
	}
}
