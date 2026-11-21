using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x02000408 RID: 1032
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class Semaphore : WaitHandle
	{
		// Token: 0x0600412C RID: 16684 RVA: 0x000D9700 File Offset: 0x000D7900
		public Semaphore(int initialCount, int maximumCount) : this(initialCount, maximumCount, null)
		{
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x000D970C File Offset: 0x000D790C
		[NullableContext(2)]
		public Semaphore(int initialCount, int maximumCount, string name)
		{
			bool flag;
			this..ctor(initialCount, maximumCount, name, out flag);
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x000D9724 File Offset: 0x000D7924
		[NullableContext(2)]
		public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(initialCount, "initialCount");
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(maximumCount, "maximumCount");
			if (initialCount > maximumCount)
			{
				throw new ArgumentException(SR.Argument_SemaphoreInitialMaximum);
			}
			this.CreateSemaphoreCore(initialCount, maximumCount, name, out createdNew);
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x000D975C File Offset: 0x000D795C
		[SupportedOSPlatform("windows")]
		public static Semaphore OpenExisting(string name)
		{
			Semaphore result;
			switch (Semaphore.OpenExistingWorker(name, out result))
			{
			case OpenExistingResult.NameNotFound:
				throw new WaitHandleCannotBeOpenedException();
			case OpenExistingResult.PathNotFound:
				throw new IOException(SR.Format(SR.IO_PathNotFound_Path, name));
			case OpenExistingResult.NameInvalid:
				throw new WaitHandleCannotBeOpenedException(SR.Format(SR.Threading_WaitHandleCannotBeOpenedException_InvalidHandle, name));
			default:
				return result;
			}
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x000D97B1 File Offset: 0x000D79B1
		[SupportedOSPlatform("windows")]
		public static bool TryOpenExisting(string name, [Nullable(2)] [NotNullWhen(true)] out Semaphore result)
		{
			return Semaphore.OpenExistingWorker(name, out result) == OpenExistingResult.Success;
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x000D97BD File Offset: 0x000D79BD
		public int Release()
		{
			return this.ReleaseCore(1);
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x000D97C6 File Offset: 0x000D79C6
		public int Release(int releaseCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(releaseCount, "releaseCount");
			return this.ReleaseCore(releaseCount);
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x000D5E55 File Offset: 0x000D4055
		private Semaphore(SafeWaitHandle handle)
		{
			base.SafeWaitHandle = handle;
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x000D97DC File Offset: 0x000D79DC
		private void CreateSemaphoreCore(int initialCount, int maximumCount, string name, out bool createdNew)
		{
			SafeWaitHandle safeWaitHandle = Interop.Kernel32.CreateSemaphoreEx(IntPtr.Zero, initialCount, maximumCount, name, 0U, 34603010U);
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			if (!safeWaitHandle.IsInvalid)
			{
				createdNew = (lastPInvokeError != 183);
				base.SafeWaitHandle = safeWaitHandle;
				return;
			}
			safeWaitHandle.Dispose();
			if (!string.IsNullOrEmpty(name) && lastPInvokeError == 6)
			{
				throw new WaitHandleCannotBeOpenedException(SR.Format(SR.Threading_WaitHandleCannotBeOpenedException_InvalidHandle, name));
			}
			throw Win32Marshal.GetExceptionForLastWin32Error("");
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x000D9850 File Offset: 0x000D7A50
		private static OpenExistingResult OpenExistingWorker(string name, out Semaphore result)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			SafeWaitHandle safeWaitHandle = Interop.Kernel32.OpenSemaphore(34603010U, false, name);
			if (!safeWaitHandle.IsInvalid)
			{
				result = new Semaphore(safeWaitHandle);
				return OpenExistingResult.Success;
			}
			result = null;
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			safeWaitHandle.Dispose();
			if (lastPInvokeError == 2 || lastPInvokeError == 123)
			{
				return OpenExistingResult.NameNotFound;
			}
			if (lastPInvokeError == 3)
			{
				return OpenExistingResult.PathNotFound;
			}
			if (lastPInvokeError == 6)
			{
				return OpenExistingResult.NameInvalid;
			}
			throw Win32Marshal.GetExceptionForLastWin32Error("");
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x000D98B8 File Offset: 0x000D7AB8
		private int ReleaseCore(int releaseCount)
		{
			int result;
			if (!Interop.Kernel32.ReleaseSemaphore(base.SafeWaitHandle, releaseCount, out result))
			{
				throw new SemaphoreFullException();
			}
			return result;
		}
	}
}
