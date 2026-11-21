using System;

namespace System.Threading
{
	// Token: 0x02000471 RID: 1137
	internal sealed class CompleteWaitThreadPoolWorkItem : IThreadPoolWorkItem
	{
		// Token: 0x060043B2 RID: 17330 RVA: 0x000E18D8 File Offset: 0x000DFAD8
		void IThreadPoolWorkItem.Execute()
		{
			PortableThreadPool.CompleteWait(this._registeredWaitHandle, this._timedOut);
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x000E18EB File Offset: 0x000DFAEB
		public CompleteWaitThreadPoolWorkItem(RegisteredWaitHandle registeredWaitHandle, bool timedOut)
		{
			this._registeredWaitHandle = registeredWaitHandle;
			this._timedOut = timedOut;
		}

		// Token: 0x04000F10 RID: 3856
		private readonly RegisteredWaitHandle _registeredWaitHandle;

		// Token: 0x04000F11 RID: 3857
		private readonly bool _timedOut;
	}
}
