using System;
using System.Runtime.ConstrainedExecution;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005C1 RID: 1473
	public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable
	{
		// Token: 0x06006FF9 RID: 28665 RVA: 0x0010D82D File Offset: 0x0010BA2D
		protected CriticalHandle(IntPtr invalidHandleValue)
		{
			this.handle = invalidHandleValue;
		}

		// Token: 0x06006FFA RID: 28666 RVA: 0x0010D83C File Offset: 0x0010BA3C
		~CriticalHandle()
		{
			this.Dispose(false);
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x0010D86C File Offset: 0x0010BA6C
		private void Cleanup()
		{
			if (this.IsClosed)
			{
				return;
			}
			this._isClosed = true;
			if (this.IsInvalid)
			{
				return;
			}
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			this.ReleaseHandle();
			Marshal.SetLastPInvokeError(lastPInvokeError);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06006FFC RID: 28668 RVA: 0x0010D89E File Offset: 0x0010BA9E
		protected void SetHandle(IntPtr handle)
		{
			this.handle = handle;
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06006FFD RID: 28669 RVA: 0x0010D8A7 File Offset: 0x0010BAA7
		public bool IsClosed
		{
			get
			{
				return this._isClosed;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06006FFE RID: 28670
		public abstract bool IsInvalid { get; }

		// Token: 0x06006FFF RID: 28671 RVA: 0x0010D8AF File Offset: 0x0010BAAF
		public void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x06007000 RID: 28672 RVA: 0x0010D8AF File Offset: 0x0010BAAF
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x0010D8B8 File Offset: 0x0010BAB8
		protected virtual void Dispose(bool disposing)
		{
			this.Cleanup();
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x0010D8C0 File Offset: 0x0010BAC0
		public void SetHandleAsInvalid()
		{
			this._isClosed = true;
			GC.SuppressFinalize(this);
		}

		// Token: 0x06007003 RID: 28675
		protected abstract bool ReleaseHandle();

		// Token: 0x0400127B RID: 4731
		protected IntPtr handle;

		// Token: 0x0400127C RID: 4732
		private bool _isClosed;
	}
}
