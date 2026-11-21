using System;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x0200046C RID: 1132
	public sealed class PreAllocatedOverlapped : IDisposable, IDeferredDisposable
	{
		// Token: 0x06004388 RID: 17288 RVA: 0x000E14A4 File Offset: 0x000DF6A4
		private static PreAllocatedOverlapped UnsafeCreateWindowsThreadPool(IOCompletionCallback callback, object state, object pinData)
		{
			return new PreAllocatedOverlapped(callback, state, pinData, false);
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x000E14AF File Offset: 0x000DF6AF
		private bool AddRefWindowsThreadPool()
		{
			return this._lifetime.AddRef();
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x000E14BC File Offset: 0x000DF6BC
		private void ReleaseWindowsThreadPool()
		{
			this._lifetime.Release(this);
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x000E14CA File Offset: 0x000DF6CA
		private void DisposeWindowsThreadPool()
		{
			this._lifetime.Dispose(this);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x000E14DE File Offset: 0x000DF6DE
		private unsafe void IDeferredDisposableOnFinalReleaseWindowsThreadPool(bool disposed)
		{
			if (this._overlappedWindowsThreadPool != null)
			{
				if (disposed)
				{
					Win32ThreadPoolNativeOverlapped.Free(this._overlappedWindowsThreadPool);
					return;
				}
				*Win32ThreadPoolNativeOverlapped.ToNativeOverlapped(this._overlappedWindowsThreadPool) = default(NativeOverlapped);
			}
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x000E150A File Offset: 0x000DF70A
		[NullableContext(2)]
		[CLSCompliant(false)]
		public PreAllocatedOverlapped([Nullable(1)] IOCompletionCallback callback, object state, object pinData) : this(callback, state, pinData, true)
		{
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x000E1516 File Offset: 0x000DF716
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static PreAllocatedOverlapped UnsafeCreate(IOCompletionCallback callback, [Nullable(2)] object state, [Nullable(2)] object pinData)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return PreAllocatedOverlapped.UnsafeCreatePortableCore(callback, state, pinData);
			}
			return PreAllocatedOverlapped.UnsafeCreateWindowsThreadPool(callback, state, pinData);
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x000E1530 File Offset: 0x000DF730
		private PreAllocatedOverlapped(IOCompletionCallback callback, object state, object pinData, bool flowExecutionContext)
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				ArgumentNullException.ThrowIfNull(callback, "callback");
				this._overlappedWindowsThreadPool = Win32ThreadPoolNativeOverlapped.Allocate(callback, state, pinData, this, flowExecutionContext);
				return;
			}
			ArgumentNullException.ThrowIfNull(callback, "callback");
			this._overlappedPortableCore = new ThreadPoolBoundHandleOverlapped(callback, state, pinData, this, flowExecutionContext);
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x000E1583 File Offset: 0x000DF783
		internal bool AddRef()
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return this.AddRefPortableCore();
			}
			return this.AddRefWindowsThreadPool();
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x000E1599 File Offset: 0x000DF799
		internal void Release()
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				this.ReleaseWindowsThreadPool();
				return;
			}
			this.ReleasePortableCore();
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x000E15AF File Offset: 0x000DF7AF
		public void Dispose()
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				this.DisposeWindowsThreadPool();
				return;
			}
			this.DisposePortableCore();
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x000E15C8 File Offset: 0x000DF7C8
		~PreAllocatedOverlapped()
		{
			this.Dispose();
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x000E15F4 File Offset: 0x000DF7F4
		void IDeferredDisposable.OnFinalRelease(bool disposed)
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				this.IDeferredDisposableOnFinalReleaseWindowsThreadPool(disposed);
				return;
			}
			this.IDeferredDisposableOnFinalReleasePortableCore(disposed);
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x000E14A4 File Offset: 0x000DF6A4
		private static PreAllocatedOverlapped UnsafeCreatePortableCore(IOCompletionCallback callback, object state, object pinData)
		{
			return new PreAllocatedOverlapped(callback, state, pinData, false);
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x000E14AF File Offset: 0x000DF6AF
		private bool AddRefPortableCore()
		{
			return this._lifetime.AddRef();
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x000E14BC File Offset: 0x000DF6BC
		private void ReleasePortableCore()
		{
			this._lifetime.Release(this);
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x000E14CA File Offset: 0x000DF6CA
		private void DisposePortableCore()
		{
			this._lifetime.Dispose(this);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x000E160C File Offset: 0x000DF80C
		private unsafe void IDeferredDisposableOnFinalReleasePortableCore(bool disposed)
		{
			if (this._overlappedPortableCore != null)
			{
				if (disposed)
				{
					Overlapped.Free(this._overlappedPortableCore._nativeOverlapped);
					return;
				}
				this._overlappedPortableCore._boundHandle = null;
				this._overlappedPortableCore._completed = false;
				*this._overlappedPortableCore._nativeOverlapped = default(NativeOverlapped);
			}
		}

		// Token: 0x04000F02 RID: 3842
		internal unsafe readonly Win32ThreadPoolNativeOverlapped* _overlappedWindowsThreadPool;

		// Token: 0x04000F03 RID: 3843
		private DeferredDisposableLifetime<PreAllocatedOverlapped> _lifetime;

		// Token: 0x04000F04 RID: 3844
		internal ThreadPoolBoundHandleOverlapped _overlappedPortableCore;
	}
}
