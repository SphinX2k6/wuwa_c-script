using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x020003E7 RID: 999
	[NullableContext(1)]
	[Nullable(0)]
	public class EventWaitHandle : WaitHandle
	{
		// Token: 0x06003FFD RID: 16381 RVA: 0x000D5D98 File Offset: 0x000D3F98
		public EventWaitHandle(bool initialState, EventResetMode mode)
		{
			bool flag;
			this..ctor(initialState, mode, null, out flag);
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x000D5DB0 File Offset: 0x000D3FB0
		[NullableContext(2)]
		public EventWaitHandle(bool initialState, EventResetMode mode, string name)
		{
			bool flag;
			this..ctor(initialState, mode, name, out flag);
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x000D5DC8 File Offset: 0x000D3FC8
		[NullableContext(2)]
		public EventWaitHandle(bool initialState, EventResetMode mode, string name, out bool createdNew)
		{
			if (mode != EventResetMode.AutoReset && mode != EventResetMode.ManualReset)
			{
				throw new ArgumentException(SR.Argument_InvalidFlag, "mode");
			}
			this.CreateEventCore(initialState, mode, name, out createdNew);
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x000D5DF4 File Offset: 0x000D3FF4
		[SupportedOSPlatform("windows")]
		public static EventWaitHandle OpenExisting(string name)
		{
			EventWaitHandle result;
			switch (EventWaitHandle.OpenExistingWorker(name, out result))
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

		// Token: 0x06004001 RID: 16385 RVA: 0x000D5E49 File Offset: 0x000D4049
		[SupportedOSPlatform("windows")]
		public static bool TryOpenExisting(string name, [Nullable(2)] [NotNullWhen(true)] out EventWaitHandle result)
		{
			return EventWaitHandle.OpenExistingWorker(name, out result) == OpenExistingResult.Success;
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x000D5E55 File Offset: 0x000D4055
		private EventWaitHandle(SafeWaitHandle handle)
		{
			base.SafeWaitHandle = handle;
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x000D5E64 File Offset: 0x000D4064
		private void CreateEventCore(bool initialState, EventResetMode mode, string name, out bool createdNew)
		{
			uint num = initialState ? 2U : 0U;
			if (mode == EventResetMode.ManualReset)
			{
				num |= 1U;
			}
			SafeWaitHandle safeWaitHandle = Interop.Kernel32.CreateEventEx(IntPtr.Zero, name, num, 34603010U);
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			if (!safeWaitHandle.IsInvalid)
			{
				createdNew = (lastPInvokeError != 183);
				base.SafeWaitHandle = safeWaitHandle;
				return;
			}
			safeWaitHandle.SetHandleAsInvalid();
			if (!string.IsNullOrEmpty(name) && lastPInvokeError == 6)
			{
				throw new WaitHandleCannotBeOpenedException(SR.Format(SR.Threading_WaitHandleCannotBeOpenedException_InvalidHandle, name));
			}
			throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, name, null);
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x000D5EE4 File Offset: 0x000D40E4
		private static OpenExistingResult OpenExistingWorker(string name, out EventWaitHandle result)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			result = null;
			SafeWaitHandle safeWaitHandle = Interop.Kernel32.OpenEvent(34603010U, false, name);
			if (!safeWaitHandle.IsInvalid)
			{
				result = new EventWaitHandle(safeWaitHandle);
				return OpenExistingResult.Success;
			}
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
			throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, name, null);
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x000D5F49 File Offset: 0x000D4149
		public bool Reset()
		{
			bool flag = Interop.Kernel32.ResetEvent(base.SafeWaitHandle);
			if (!flag)
			{
				throw Win32Marshal.GetExceptionForLastWin32Error("");
			}
			return flag;
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x000D5F64 File Offset: 0x000D4164
		public bool Set()
		{
			bool flag = Interop.Kernel32.SetEvent(base.SafeWaitHandle);
			if (!flag)
			{
				throw Win32Marshal.GetExceptionForLastWin32Error("");
			}
			return flag;
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x000D5F7F File Offset: 0x000D417F
		internal static bool Set(SafeWaitHandle waitHandle)
		{
			return Interop.Kernel32.SetEvent(waitHandle);
		}
	}
}
