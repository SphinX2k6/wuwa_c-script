using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x020003FC RID: 1020
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class Mutex : WaitHandle
	{
		// Token: 0x060040C2 RID: 16578 RVA: 0x000D7EC0 File Offset: 0x000D60C0
		[NullableContext(2)]
		public Mutex(bool initiallyOwned, string name, out bool createdNew)
		{
			this.CreateMutexCore(initiallyOwned, name, out createdNew);
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x000D7ED4 File Offset: 0x000D60D4
		[NullableContext(2)]
		public Mutex(bool initiallyOwned, string name)
		{
			bool flag;
			this.CreateMutexCore(initiallyOwned, name, out flag);
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x000D7EF4 File Offset: 0x000D60F4
		public Mutex(bool initiallyOwned)
		{
			bool flag;
			this.CreateMutexCore(initiallyOwned, null, out flag);
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x000D7F14 File Offset: 0x000D6114
		public Mutex()
		{
			bool flag;
			this.CreateMutexCore(false, null, out flag);
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x000D5E55 File Offset: 0x000D4055
		private Mutex(SafeWaitHandle handle)
		{
			base.SafeWaitHandle = handle;
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x000D7F34 File Offset: 0x000D6134
		public static Mutex OpenExisting(string name)
		{
			Mutex result;
			switch (Mutex.OpenExistingWorker(name, out result))
			{
			case OpenExistingResult.NameNotFound:
				throw new WaitHandleCannotBeOpenedException();
			case OpenExistingResult.PathNotFound:
				throw new DirectoryNotFoundException(SR.Format(SR.IO_PathNotFound_Path, name));
			case OpenExistingResult.NameInvalid:
				throw new WaitHandleCannotBeOpenedException(SR.Format(SR.Threading_WaitHandleCannotBeOpenedException_InvalidHandle, name));
			default:
				return result;
			}
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x000D7F89 File Offset: 0x000D6189
		public static bool TryOpenExisting(string name, [Nullable(2)] [NotNullWhen(true)] out Mutex result)
		{
			return Mutex.OpenExistingWorker(name, out result) == OpenExistingResult.Success;
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x000D7F98 File Offset: 0x000D6198
		private void CreateMutexCore(bool initiallyOwned, string name, out bool createdNew)
		{
			uint flags = (initiallyOwned > false) ? 1U : 0U;
			SafeWaitHandle safeWaitHandle = Interop.Kernel32.CreateMutexEx(IntPtr.Zero, name, flags, 34603009U);
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			if (!safeWaitHandle.IsInvalid)
			{
				createdNew = (lastPInvokeError != 183);
				base.SafeWaitHandle = safeWaitHandle;
				return;
			}
			safeWaitHandle.SetHandleAsInvalid();
			if (lastPInvokeError == 6)
			{
				throw new WaitHandleCannotBeOpenedException(SR.Format(SR.Threading_WaitHandleCannotBeOpenedException_InvalidHandle, name));
			}
			throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, name, null);
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x000D8004 File Offset: 0x000D6204
		private static OpenExistingResult OpenExistingWorker(string name, out Mutex result)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			result = null;
			SafeWaitHandle safeWaitHandle = Interop.Kernel32.OpenMutex(34603009U, false, name);
			if (!safeWaitHandle.IsInvalid)
			{
				result = new Mutex(safeWaitHandle);
				return OpenExistingResult.Success;
			}
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			safeWaitHandle.Dispose();
			if (2 == lastPInvokeError || 123 == lastPInvokeError)
			{
				return OpenExistingResult.NameNotFound;
			}
			if (3 == lastPInvokeError)
			{
				return OpenExistingResult.PathNotFound;
			}
			if (6 == lastPInvokeError)
			{
				return OpenExistingResult.NameInvalid;
			}
			throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, name, null);
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x000D8069 File Offset: 0x000D6269
		public void ReleaseMutex()
		{
			if (!Interop.Kernel32.ReleaseMutex(base.SafeWaitHandle))
			{
				throw new ApplicationException(SR.Arg_SynchronizationLockException);
			}
		}
	}
}
