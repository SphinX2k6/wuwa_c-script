using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x0200046B RID: 1131
	public sealed class ThreadPoolBoundHandle : IDisposable, IDeferredDisposable
	{
		// Token: 0x06004365 RID: 17253 RVA: 0x000E0E18 File Offset: 0x000DF018
		private static ThreadPoolBoundHandle BindHandleWindowsThreadPool(SafeHandle handle)
		{
			ArgumentNullException.ThrowIfNull(handle, "handle");
			if (handle.IsClosed || handle.IsInvalid)
			{
				throw new ArgumentException(SR.Argument_InvalidHandle, "handle");
			}
			SafeThreadPoolIOHandle safeThreadPoolIOHandle = Interop.Kernel32.CreateThreadpoolIo(handle, ldftn(OnNativeIOCompleted), (short)IntPtr.Zero, IntPtr.Zero);
			if (!safeThreadPoolIOHandle.IsInvalid)
			{
				return new ThreadPoolBoundHandle(handle, safeThreadPoolIOHandle);
			}
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 6)
			{
				throw new ArgumentException(SR.Argument_InvalidHandle, "handle");
			}
			if (lastWin32Error == 87)
			{
				throw new ArgumentException(SR.Argument_AlreadyBoundOrSyncHandle, "handle");
			}
			throw Win32Marshal.GetExceptionForWin32Error(lastWin32Error, "", null);
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x000E0EB0 File Offset: 0x000DF0B0
		private unsafe NativeOverlapped* AllocateNativeOverlappedWindowsThreadPool(IOCompletionCallback callback, object state, object pinData)
		{
			return this.AllocateNativeOverlappedWindowsThreadPool(callback, state, pinData, true);
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x000E0EBC File Offset: 0x000DF0BC
		private unsafe NativeOverlapped* UnsafeAllocateNativeOverlappedWindowsThreadPool(IOCompletionCallback callback, object state, object pinData)
		{
			return this.AllocateNativeOverlappedWindowsThreadPool(callback, state, pinData, false);
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x000E0EC8 File Offset: 0x000DF0C8
		private unsafe NativeOverlapped* AllocateNativeOverlappedWindowsThreadPool(IOCompletionCallback callback, object state, object pinData, bool flowExecutionContext)
		{
			ArgumentNullException.ThrowIfNull(callback, "callback");
			this.AddRef();
			NativeOverlapped* result;
			try
			{
				Win32ThreadPoolNativeOverlapped* ptr = Win32ThreadPoolNativeOverlapped.Allocate(callback, state, pinData, null, flowExecutionContext);
				ptr->Data._boundHandle = this;
				if (NativeRuntimeEventSource.Log.IsEnabled())
				{
					NativeRuntimeEventSource.Log.ThreadPoolIOEnqueue(Win32ThreadPoolNativeOverlapped.ToNativeOverlapped(ptr));
				}
				Interop.Kernel32.StartThreadpoolIo(this._threadPoolHandle);
				result = Win32ThreadPoolNativeOverlapped.ToNativeOverlapped(ptr);
			}
			catch
			{
				this.Release();
				throw;
			}
			return result;
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x000E0F4C File Offset: 0x000DF14C
		private unsafe NativeOverlapped* AllocateNativeOverlappedWindowsThreadPool(PreAllocatedOverlapped preAllocated)
		{
			ArgumentNullException.ThrowIfNull(preAllocated, "preAllocated");
			bool flag = false;
			bool flag2 = false;
			NativeOverlapped* result;
			try
			{
				flag = this.AddRef();
				flag2 = preAllocated.AddRef();
				Win32ThreadPoolNativeOverlapped.OverlappedData data = preAllocated._overlappedWindowsThreadPool->Data;
				if (data._boundHandle != null)
				{
					throw new ArgumentException(SR.Argument_PreAllocatedAlreadyAllocated, "preAllocated");
				}
				data._boundHandle = this;
				if (NativeRuntimeEventSource.Log.IsEnabled())
				{
					NativeRuntimeEventSource.Log.ThreadPoolIOEnqueue(Win32ThreadPoolNativeOverlapped.ToNativeOverlapped(preAllocated._overlappedWindowsThreadPool));
				}
				Interop.Kernel32.StartThreadpoolIo(this._threadPoolHandle);
				result = Win32ThreadPoolNativeOverlapped.ToNativeOverlapped(preAllocated._overlappedWindowsThreadPool);
			}
			catch
			{
				if (flag2)
				{
					preAllocated.Release();
				}
				if (flag)
				{
					this.Release();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x000E1000 File Offset: 0x000DF200
		private unsafe void FreeNativeOverlappedWindowsThreadPool(NativeOverlapped* overlapped)
		{
			ArgumentNullException.ThrowIfNull((void*)overlapped, "overlapped");
			Win32ThreadPoolNativeOverlapped* overlapped2 = Win32ThreadPoolNativeOverlapped.FromNativeOverlapped(overlapped);
			Win32ThreadPoolNativeOverlapped.OverlappedData overlappedData = ThreadPoolBoundHandle.GetOverlappedData(overlapped2, this);
			if (!overlappedData._completed)
			{
				Interop.Kernel32.CancelThreadpoolIo(this._threadPoolHandle);
				this.Release();
			}
			overlappedData._boundHandle = null;
			overlappedData._completed = false;
			if (overlappedData._preAllocated != null)
			{
				overlappedData._preAllocated.Release();
				return;
			}
			Win32ThreadPoolNativeOverlapped.Free(overlapped2);
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x000E1068 File Offset: 0x000DF268
		private unsafe static object GetNativeOverlappedStateWindowsThreadPool(NativeOverlapped* overlapped)
		{
			ArgumentNullException.ThrowIfNull((void*)overlapped, "overlapped");
			return ThreadPoolBoundHandle.GetOverlappedData(Win32ThreadPoolNativeOverlapped.FromNativeOverlapped(overlapped), null)._state;
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x000E1088 File Offset: 0x000DF288
		private unsafe static Win32ThreadPoolNativeOverlapped.OverlappedData GetOverlappedData(Win32ThreadPoolNativeOverlapped* overlapped, ThreadPoolBoundHandle expectedBoundHandle)
		{
			Win32ThreadPoolNativeOverlapped.OverlappedData data = overlapped->Data;
			if (data._boundHandle == null)
			{
				throw new ArgumentException(SR.Argument_NativeOverlappedAlreadyFree, "overlapped");
			}
			if (expectedBoundHandle != null && data._boundHandle != expectedBoundHandle)
			{
				throw new ArgumentException(SR.Argument_NativeOverlappedWrongBoundHandle, "overlapped");
			}
			return data;
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x000E10D4 File Offset: 0x000DF2D4
		[UnmanagedCallersOnly]
		private static void OnNativeIOCompleted(IntPtr instance, IntPtr context, IntPtr overlappedPtr, uint ioResult, UIntPtr numberOfBytesTransferred, IntPtr ioPtr)
		{
			ThreadPoolCallbackWrapper threadPoolCallbackWrapper = ThreadPoolCallbackWrapper.Enter();
			ThreadPoolBoundHandle boundHandle = overlappedPtr.Data._boundHandle;
			if (boundHandle == null)
			{
				throw new InvalidOperationException(SR.Argument_NativeOverlappedAlreadyFree);
			}
			boundHandle.Release();
			if (NativeRuntimeEventSource.Log.IsEnabled())
			{
				NativeRuntimeEventSource.Log.ThreadPoolIODequeue(Win32ThreadPoolNativeOverlapped.ToNativeOverlapped(overlappedPtr));
			}
			Win32ThreadPoolNativeOverlapped.CompleteWithCallback(ioResult, (uint)numberOfBytesTransferred, overlappedPtr);
			ThreadPool.IncrementCompletedWorkItemCount();
			threadPoolCallbackWrapper.Exit(true);
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x000E113B File Offset: 0x000DF33B
		private bool AddRef()
		{
			return this._lifetime.AddRef();
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x000E1148 File Offset: 0x000DF348
		private void Release()
		{
			this._lifetime.Release(this);
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x000E1156 File Offset: 0x000DF356
		private void DisposeWindowsThreadPool()
		{
			this._lifetime.Dispose(this);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x000E116A File Offset: 0x000DF36A
		private void FinalizeWindowsThreadPool()
		{
			this.Dispose();
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x000E1174 File Offset: 0x000DF374
		private void IDeferredDisposableOnFinalReleaseWindowsThreadPool(bool disposed)
		{
			if (disposed)
			{
				this._threadPoolHandle.Dispose();
			}
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x000E1184 File Offset: 0x000DF384
		private unsafe NativeOverlapped* AllocateNativeOverlappedPortableCore(IOCompletionCallback callback, object state, object pinData)
		{
			return this.AllocateNativeOverlappedPortableCore(callback, state, pinData, true);
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x000E1190 File Offset: 0x000DF390
		private unsafe NativeOverlapped* UnsafeAllocateNativeOverlappedPortableCore(IOCompletionCallback callback, object state, object pinData)
		{
			return this.AllocateNativeOverlappedPortableCore(callback, state, pinData, false);
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x000E119C File Offset: 0x000DF39C
		private unsafe NativeOverlapped* AllocateNativeOverlappedPortableCore(IOCompletionCallback callback, object state, object pinData, bool flowExecutionContext)
		{
			ArgumentNullException.ThrowIfNull(callback, "callback");
			ObjectDisposedException.ThrowIf(this._isDisposed, this);
			return new ThreadPoolBoundHandleOverlapped(callback, state, pinData, null, flowExecutionContext)
			{
				_boundHandle = this
			}._nativeOverlapped;
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x000E11CC File Offset: 0x000DF3CC
		private unsafe NativeOverlapped* AllocateNativeOverlappedPortableCore(PreAllocatedOverlapped preAllocated)
		{
			ArgumentNullException.ThrowIfNull(preAllocated, "preAllocated");
			ObjectDisposedException.ThrowIf(this._isDisposed, this);
			preAllocated.AddRef();
			NativeOverlapped* nativeOverlapped;
			try
			{
				ThreadPoolBoundHandleOverlapped overlappedPortableCore = preAllocated._overlappedPortableCore;
				if (overlappedPortableCore._boundHandle != null)
				{
					throw new ArgumentException(SR.Argument_PreAllocatedAlreadyAllocated, "preAllocated");
				}
				overlappedPortableCore._boundHandle = this;
				nativeOverlapped = overlappedPortableCore._nativeOverlapped;
			}
			catch
			{
				preAllocated.Release();
				throw;
			}
			return nativeOverlapped;
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x000E1240 File Offset: 0x000DF440
		private unsafe void FreeNativeOverlappedPortableCore(NativeOverlapped* overlapped)
		{
			ArgumentNullException.ThrowIfNull((void*)overlapped, "overlapped");
			ThreadPoolBoundHandleOverlapped overlappedWrapper = ThreadPoolBoundHandle.GetOverlappedWrapper(overlapped);
			if (overlappedWrapper._boundHandle != this)
			{
				throw new ArgumentException(SR.Argument_NativeOverlappedWrongBoundHandle, "overlapped");
			}
			if (overlappedWrapper._preAllocated != null)
			{
				overlappedWrapper._preAllocated.Release();
				return;
			}
			Overlapped.Free(overlapped);
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x000E1292 File Offset: 0x000DF492
		private unsafe static object GetNativeOverlappedStatePortableCore(NativeOverlapped* overlapped)
		{
			ArgumentNullException.ThrowIfNull((void*)overlapped, "overlapped");
			return ThreadPoolBoundHandle.GetOverlappedWrapper(overlapped)._userState;
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x000E12AC File Offset: 0x000DF4AC
		private unsafe static ThreadPoolBoundHandleOverlapped GetOverlappedWrapper(NativeOverlapped* overlapped)
		{
			ThreadPoolBoundHandleOverlapped result;
			try
			{
				result = (ThreadPoolBoundHandleOverlapped)Overlapped.Unpack(overlapped);
			}
			catch (NullReferenceException innerException)
			{
				throw new ArgumentException(SR.Argument_NativeOverlappedAlreadyFree, "overlapped", innerException);
			}
			return result;
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x000E12EC File Offset: 0x000DF4EC
		private void DisposePortableCore()
		{
			this._isDisposed = true;
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x000E12F5 File Offset: 0x000DF4F5
		private ThreadPoolBoundHandle(SafeHandle handle, SafeThreadPoolIOHandle threadPoolHandle)
		{
			this._threadPoolHandle = threadPoolHandle;
			this._handle = handle;
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x000E130B File Offset: 0x000DF50B
		private ThreadPoolBoundHandle(SafeHandle handle)
		{
			this._handle = handle;
			GC.SuppressFinalize(this);
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x0600437D RID: 17277 RVA: 0x000E1320 File Offset: 0x000DF520
		[Nullable(1)]
		public SafeHandle Handle
		{
			[NullableContext(1)]
			get
			{
				return this._handle;
			}
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x000E1328 File Offset: 0x000DF528
		private static ThreadPoolBoundHandle BindHandleCore(SafeHandle handle)
		{
			ArgumentNullException.ThrowIfNull(handle, "handle");
			if (handle.IsClosed || handle.IsInvalid)
			{
				throw new ArgumentException(SR.Argument_InvalidHandle, "handle");
			}
			try
			{
				ThreadPool.BindHandle(handle);
			}
			catch (Exception ex)
			{
				if (ex.HResult == -2147024890)
				{
					throw new ArgumentException(SR.Argument_InvalidHandle, "handle");
				}
				if (ex.HResult == -2147024809)
				{
					throw new ArgumentException(SR.Argument_AlreadyBoundOrSyncHandle, "handle");
				}
				throw;
			}
			return new ThreadPoolBoundHandle(handle);
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x000E13BC File Offset: 0x000DF5BC
		[NullableContext(1)]
		public static ThreadPoolBoundHandle BindHandle(SafeHandle handle)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return ThreadPoolBoundHandle.BindHandleCore(handle);
			}
			return ThreadPoolBoundHandle.BindHandleWindowsThreadPool(handle);
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x000E13D2 File Offset: 0x000DF5D2
		[NullableContext(2)]
		[CLSCompliant(false)]
		[return: Nullable(0)]
		public unsafe NativeOverlapped* AllocateNativeOverlapped([Nullable(1)] IOCompletionCallback callback, object state, object pinData)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return this.AllocateNativeOverlappedPortableCore(callback, state, pinData);
			}
			return this.AllocateNativeOverlappedWindowsThreadPool(callback, state, pinData);
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x000E13EE File Offset: 0x000DF5EE
		[NullableContext(2)]
		[CLSCompliant(false)]
		[return: Nullable(0)]
		public unsafe NativeOverlapped* UnsafeAllocateNativeOverlapped([Nullable(1)] IOCompletionCallback callback, object state, object pinData)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return this.UnsafeAllocateNativeOverlappedPortableCore(callback, state, pinData);
			}
			return this.UnsafeAllocateNativeOverlappedWindowsThreadPool(callback, state, pinData);
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x000E140A File Offset: 0x000DF60A
		[CLSCompliant(false)]
		public unsafe NativeOverlapped* AllocateNativeOverlapped([Nullable(1)] PreAllocatedOverlapped preAllocated)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return this.AllocateNativeOverlappedPortableCore(preAllocated);
			}
			return this.AllocateNativeOverlappedWindowsThreadPool(preAllocated);
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x000E1422 File Offset: 0x000DF622
		[CLSCompliant(false)]
		public unsafe void FreeNativeOverlapped(NativeOverlapped* overlapped)
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				this.FreeNativeOverlappedWindowsThreadPool(overlapped);
				return;
			}
			this.FreeNativeOverlappedPortableCore(overlapped);
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x000E143A File Offset: 0x000DF63A
		[CLSCompliant(false)]
		[return: Nullable(2)]
		public unsafe static object GetNativeOverlappedState(NativeOverlapped* overlapped)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return ThreadPoolBoundHandle.GetNativeOverlappedStatePortableCore(overlapped);
			}
			return ThreadPoolBoundHandle.GetNativeOverlappedStateWindowsThreadPool(overlapped);
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x000E1450 File Offset: 0x000DF650
		public void Dispose()
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				this.DisposeWindowsThreadPool();
				return;
			}
			this.DisposePortableCore();
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x000E1468 File Offset: 0x000DF668
		~ThreadPoolBoundHandle()
		{
			this.FinalizeWindowsThreadPool();
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x000E1494 File Offset: 0x000DF694
		void IDeferredDisposable.OnFinalRelease(bool disposed)
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				this.IDeferredDisposableOnFinalReleaseWindowsThreadPool(disposed);
			}
		}

		// Token: 0x04000EFE RID: 3838
		private readonly SafeHandle _handle;

		// Token: 0x04000EFF RID: 3839
		private readonly SafeThreadPoolIOHandle _threadPoolHandle;

		// Token: 0x04000F00 RID: 3840
		private DeferredDisposableLifetime<ThreadPoolBoundHandle> _lifetime;

		// Token: 0x04000F01 RID: 3841
		private bool _isDisposed;
	}
}
