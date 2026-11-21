using System;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005A7 RID: 1447
	[StructLayout(LayoutKind.Sequential)]
	public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
	{
		// Token: 0x06006FA7 RID: 28583 RVA: 0x0010D120 File Offset: 0x0010B320
		protected SafeHandle(IntPtr invalidHandleValue, bool ownsHandle)
		{
			this.handle = invalidHandleValue;
			this._state = 4;
			this._ownsHandle = ownsHandle;
			if (!ownsHandle)
			{
				GC.SuppressFinalize(this);
			}
			Volatile.Write(ref this._fullyInitialized, true);
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x0010D154 File Offset: 0x0010B354
		~SafeHandle()
		{
			if (this._fullyInitialized)
			{
				this.Dispose(false);
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06006FA9 RID: 28585 RVA: 0x0010D18C File Offset: 0x0010B38C
		internal bool OwnsHandle
		{
			get
			{
				return this._ownsHandle;
			}
		}

		// Token: 0x06006FAA RID: 28586 RVA: 0x0010D194 File Offset: 0x0010B394
		protected internal void SetHandle(IntPtr handle)
		{
			this.handle = handle;
		}

		// Token: 0x06006FAB RID: 28587 RVA: 0x0010D19D File Offset: 0x0010B39D
		public IntPtr DangerousGetHandle()
		{
			return this.handle;
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06006FAC RID: 28588 RVA: 0x0010D1A5 File Offset: 0x0010B3A5
		public bool IsClosed
		{
			get
			{
				return (this._state & 1) == 1;
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06006FAD RID: 28589
		public abstract bool IsInvalid { get; }

		// Token: 0x06006FAE RID: 28590 RVA: 0x0010D1B4 File Offset: 0x0010B3B4
		public void Close()
		{
			this.Dispose();
		}

		// Token: 0x06006FAF RID: 28591 RVA: 0x0010D1BC File Offset: 0x0010B3BC
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x0010D1CB File Offset: 0x0010B3CB
		protected virtual void Dispose(bool disposing)
		{
			this.InternalRelease(true);
		}

		// Token: 0x06006FB1 RID: 28593 RVA: 0x0010D1D4 File Offset: 0x0010B3D4
		public void SetHandleAsInvalid()
		{
			Interlocked.Or(ref this._state, 1);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06006FB2 RID: 28594
		protected abstract bool ReleaseHandle();

		// Token: 0x06006FB3 RID: 28595 RVA: 0x0010D1EC File Offset: 0x0010B3EC
		public void DangerousAddRef(ref bool success)
		{
			int state;
			int value;
			do
			{
				state = this._state;
				ObjectDisposedException.ThrowIf((state & 1) != 0, this);
				value = state + 4;
			}
			while (Interlocked.CompareExchange(ref this._state, value, state) != state);
			success = true;
		}

		// Token: 0x06006FB4 RID: 28596 RVA: 0x0010D228 File Offset: 0x0010B428
		internal void DangerousAddRef()
		{
			bool flag = false;
			this.DangerousAddRef(ref flag);
		}

		// Token: 0x06006FB5 RID: 28597 RVA: 0x0010D23F File Offset: 0x0010B43F
		public void DangerousRelease()
		{
			this.InternalRelease(false);
		}

		// Token: 0x06006FB6 RID: 28598 RVA: 0x0010D248 File Offset: 0x0010B448
		private void InternalRelease(bool disposeOrFinalizeOperation)
		{
			bool flag;
			for (;;)
			{
				int state = this._state;
				if (disposeOrFinalizeOperation && (state & 2) != 0)
				{
					break;
				}
				ObjectDisposedException.ThrowIf((state & -4) == 0, this);
				flag = ((state & -3) == 4 && this._ownsHandle && !this.IsInvalid);
				int num = state - 4;
				if ((state & -4) == 4)
				{
					num |= 1;
				}
				if (disposeOrFinalizeOperation)
				{
					num |= 2;
				}
				if (Interlocked.CompareExchange(ref this._state, num, state) == state)
				{
					goto Block_6;
				}
			}
			return;
			Block_6:
			if (flag)
			{
				int lastPInvokeError = Marshal.GetLastPInvokeError();
				this.ReleaseHandle();
				Marshal.SetLastPInvokeError(lastPInvokeError);
			}
		}

		// Token: 0x04001239 RID: 4665
		protected IntPtr handle;

		// Token: 0x0400123A RID: 4666
		private volatile int _state;

		// Token: 0x0400123B RID: 4667
		private readonly bool _ownsHandle;

		// Token: 0x0400123C RID: 4668
		private readonly bool _fullyInitialized;
	}
}
