using System;

namespace System.Threading
{
	// Token: 0x0200048B RID: 1163
	internal struct ThreadPoolCallbackWrapper
	{
		// Token: 0x0600445D RID: 17501 RVA: 0x000E4EF4 File Offset: 0x000E30F4
		public static ThreadPoolCallbackWrapper Enter()
		{
			Thread currentThread = Thread.CurrentThread;
			if (!currentThread.IsThreadPoolThread)
			{
				currentThread.IsThreadPoolThread = true;
				ThreadPool.InitializeForThreadPoolThread();
			}
			return new ThreadPoolCallbackWrapper
			{
				_currentThread = currentThread
			};
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x000E4F2C File Offset: 0x000E312C
		public void Exit(bool resetThread = true)
		{
			if (resetThread)
			{
				this._currentThread.ResetThreadPoolThread();
			}
		}

		// Token: 0x04000FA0 RID: 4000
		private Thread _currentThread;
	}
}
