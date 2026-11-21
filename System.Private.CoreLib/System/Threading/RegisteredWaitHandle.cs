using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x0200046A RID: 1130
	[NullableContext(2)]
	[Nullable(0)]
	[UnsupportedOSPlatform("browser")]
	public sealed class RegisteredWaitHandle : MarshalByRefObject
	{
		// Token: 0x0600433F RID: 17215 RVA: 0x000E065C File Offset: 0x000DE85C
		internal RegisteredWaitHandle(SafeWaitHandle waitHandle, _ThreadPoolWaitOrTimerCallback callbackHelper, uint millisecondsTimeout, bool repeating)
		{
			this._lock = new Lock();
			waitHandle.DangerousAddRef();
			this._waitHandle = waitHandle;
			this._callbackHelper = callbackHelper;
			this._millisecondsTimeout = millisecondsTimeout;
			this._repeating = repeating;
			this._gcHandle = GCHandle.Alloc(this);
			this._tpWait = Interop.Kernel32.CreateThreadpoolWait(ldftn(RegisteredWaitCallback), (sbyte)((IntPtr)this._gcHandle), IntPtr.Zero);
			if (this._tpWait == IntPtr.Zero)
			{
				this._gcHandle.Free();
				throw new OutOfMemoryException();
			}
			if (NativeRuntimeEventSource.Log.IsEnabled())
			{
				NativeRuntimeEventSource.Log.ThreadPoolIOEnqueue(this);
			}
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x000E0700 File Offset: 0x000DE900
		[UnmanagedCallersOnly]
		internal static void RegisteredWaitCallback(IntPtr instance, IntPtr context, IntPtr wait, uint waitResult)
		{
			ThreadPoolCallbackWrapper threadPoolCallbackWrapper = ThreadPoolCallbackWrapper.Enter();
			RegisteredWaitHandle registeredWaitHandle = (RegisteredWaitHandle)((GCHandle)context).Target;
			bool timedOut = waitResult == 258U;
			registeredWaitHandle.PerformCallbackWindowsThreadPool(timedOut);
			ThreadPool.IncrementCompletedWorkItemCount();
			threadPoolCallbackWrapper.Exit(true);
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x000E0744 File Offset: 0x000DE944
		private void PerformCallbackWindowsThreadPool(bool timedOut)
		{
			using (this._lock.EnterScope())
			{
				if (!this._unregistering)
				{
					if (this._repeating)
					{
						this.RestartWait();
					}
					else
					{
						this._gcHandle.Free();
					}
				}
			}
			if (NativeRuntimeEventSource.Log.IsEnabled())
			{
				NativeRuntimeEventSource.Log.ThreadPoolIODequeue(this);
			}
			_ThreadPoolWaitOrTimerCallback.PerformWaitOrTimerCallback(this._callbackHelper, timedOut);
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x000E07C0 File Offset: 0x000DE9C0
		internal unsafe void RestartWait()
		{
			long* pftTimeout = null;
			if (this._millisecondsTimeout != 4294967295U)
			{
				long num = (long)(18446744073709541616UL * (ulong)this._millisecondsTimeout);
				pftTimeout = &num;
			}
			Interop.Kernel32.SetThreadpoolWait(this._tpWait, this._waitHandle.DangerousGetHandle(), pftTimeout);
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x000E0804 File Offset: 0x000DEA04
		private bool UnregisterWindowsThreadPool(WaitHandle waitObject)
		{
			using (this._lock.EnterScope())
			{
				if (!this._unregistering)
				{
					this._unregistering = true;
					Interop.Kernel32.SetThreadpoolWait(this._tpWait, IntPtr.Zero, IntPtr.Zero);
					SafeWaitHandle safeWaitHandle = (waitObject != null) ? waitObject.SafeWaitHandle : null;
					if (safeWaitHandle != null && safeWaitHandle.DangerousGetHandle() == new IntPtr(-1))
					{
						this.FinishUnregistering();
					}
					else
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.FinishUnregisteringAsync), safeWaitHandle);
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x000E08A0 File Offset: 0x000DEAA0
		private void FinishUnregistering()
		{
			Interop.Kernel32.WaitForThreadpoolWaitCallbacks(this._tpWait, false);
			Interop.Kernel32.CloseThreadpoolWait(this._tpWait);
			this._tpWait = IntPtr.Zero;
			if (this._gcHandle.IsAllocated)
			{
				this._gcHandle.Free();
			}
			this._waitHandle.DangerousRelease();
			this._waitHandle = null;
			GC.SuppressFinalize(this);
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x000E0900 File Offset: 0x000DEB00
		private void FinishUnregisteringAsync(object waitObject)
		{
			this.FinishUnregistering();
			SafeWaitHandle safeWaitHandle = (SafeWaitHandle)waitObject;
			if (safeWaitHandle != null && !safeWaitHandle.IsInvalid)
			{
				Interop.Kernel32.SetEvent(safeWaitHandle);
			}
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x000E092C File Offset: 0x000DEB2C
		~RegisteredWaitHandle()
		{
			if (this._lock != null && this._lock.TryEnter())
			{
				try
				{
					if (!this._unregistering)
					{
						this._unregistering = true;
						if (this._tpWait != IntPtr.Zero)
						{
							Interop.Kernel32.CloseThreadpoolWait(this._tpWait);
							this._tpWait = IntPtr.Zero;
						}
						if (this._waitHandle != null)
						{
							this._waitHandle.DangerousRelease();
							this._waitHandle = null;
						}
					}
				}
				finally
				{
					this._lock.Exit();
				}
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06004347 RID: 17223 RVA: 0x000E09D0 File Offset: 0x000DEBD0
		internal _ThreadPoolWaitOrTimerCallback Callback
		{
			get
			{
				return this._callbackHelper;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06004348 RID: 17224 RVA: 0x000E09D8 File Offset: 0x000DEBD8
		[Nullable(1)]
		internal SafeWaitHandle Handle
		{
			get
			{
				return this._waitHandle;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06004349 RID: 17225 RVA: 0x000E09E0 File Offset: 0x000DEBE0
		// (set) Token: 0x0600434A RID: 17226 RVA: 0x000E09E8 File Offset: 0x000DEBE8
		internal int TimeoutTimeMs { get; private set; }

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600434B RID: 17227 RVA: 0x000E09F1 File Offset: 0x000DEBF1
		internal int TimeoutDurationMs
		{
			get
			{
				return this._signedMillisecondsTimeout;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x000E09F9 File Offset: 0x000DEBF9
		internal bool IsInfiniteTimeout
		{
			get
			{
				return this.TimeoutDurationMs == -1;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x000E0A04 File Offset: 0x000DEC04
		internal bool Repeating
		{
			get
			{
				return this._repeating;
			}
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x000E0A0C File Offset: 0x000DEC0C
		[NullableContext(1)]
		public bool Unregister(WaitHandle waitObject)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return this.UnregisterPortableCore(waitObject);
			}
			return this.UnregisterWindowsThreadPool(waitObject);
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x000E0A24 File Offset: 0x000DEC24
		internal void PerformCallback(bool timedOut)
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				this.PerformCallbackWindowsThreadPool(timedOut);
				return;
			}
			this.PerformCallbackPortableCore(timedOut);
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x000E0A3C File Offset: 0x000DEC3C
		// (set) Token: 0x06004351 RID: 17233 RVA: 0x000E0A44 File Offset: 0x000DEC44
		private SafeWaitHandle UserUnregisterWaitHandle { get; set; }

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x000E0A4D File Offset: 0x000DEC4D
		// (set) Token: 0x06004353 RID: 17235 RVA: 0x000E0A55 File Offset: 0x000DEC55
		private IntPtr UserUnregisterWaitHandleValue { get; set; }

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x000E0A5E File Offset: 0x000DEC5E
		private static IntPtr InvalidHandleValue
		{
			get
			{
				return new IntPtr(-1);
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06004355 RID: 17237 RVA: 0x000E0A66 File Offset: 0x000DEC66
		internal bool IsBlocking
		{
			get
			{
				return this.UserUnregisterWaitHandleValue == RegisteredWaitHandle.InvalidHandleValue;
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06004356 RID: 17238 RVA: 0x000E0A75 File Offset: 0x000DEC75
		// (set) Token: 0x06004357 RID: 17239 RVA: 0x000E0A7D File Offset: 0x000DEC7D
		internal PortableThreadPool.WaitThread WaitThread { get; set; }

		// Token: 0x06004358 RID: 17240 RVA: 0x000E0A88 File Offset: 0x000DEC88
		internal RegisteredWaitHandle(WaitHandle waitHandle, _ThreadPoolWaitOrTimerCallback callbackHelper, int millisecondsTimeout, bool repeating)
		{
			GC.SuppressFinalize(this);
			Thread.ThrowIfNoThreadStart(false);
			this._waitHandle = waitHandle.SafeWaitHandle;
			this._callbackHelper = callbackHelper;
			this._signedMillisecondsTimeout = millisecondsTimeout;
			this._repeating = repeating;
			if (!this.IsInfiniteTimeout)
			{
				this.RestartTimeout();
			}
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x000E0AD7 File Offset: 0x000DECD7
		private static AutoResetEvent RentEvent()
		{
			return Interlocked.Exchange<AutoResetEvent>(ref RegisteredWaitHandle.s_cachedEvent, null) ?? new AutoResetEvent(false);
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x000E0AEE File Offset: 0x000DECEE
		private static void ReturnEvent(AutoResetEvent resetEvent)
		{
			if (Interlocked.CompareExchange<AutoResetEvent>(ref RegisteredWaitHandle.s_cachedEvent, resetEvent, null) != null)
			{
				resetEvent.Dispose();
			}
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x000E0B04 File Offset: 0x000DED04
		internal void RestartTimeout()
		{
			this.TimeoutTimeMs = Environment.TickCount + this.TimeoutDurationMs;
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x000E0B18 File Offset: 0x000DED18
		private bool UnregisterPortableCore(WaitHandle waitObject)
		{
			RegisteredWaitHandle.s_callbackLock.Acquire();
			bool flag = false;
			try
			{
				if (this._unregisterCalled)
				{
					return false;
				}
				this.UserUnregisterWaitHandle = ((waitObject != null) ? waitObject.SafeWaitHandle : null);
				SafeWaitHandle userUnregisterWaitHandle = this.UserUnregisterWaitHandle;
				if (userUnregisterWaitHandle != null)
				{
					userUnregisterWaitHandle.DangerousAddRef(ref flag);
				}
				SafeWaitHandle userUnregisterWaitHandle2 = this.UserUnregisterWaitHandle;
				this.UserUnregisterWaitHandleValue = ((userUnregisterWaitHandle2 != null) ? userUnregisterWaitHandle2.DangerousGetHandle() : IntPtr.Zero);
				if (this._unregistered)
				{
					this.SignalUserWaitHandle();
					return true;
				}
				if (this.IsBlocking)
				{
					this._callbacksComplete = RegisteredWaitHandle.RentEvent();
				}
				else
				{
					this._removed = RegisteredWaitHandle.RentEvent();
				}
			}
			catch (Exception)
			{
				if (this._removed != null)
				{
					RegisteredWaitHandle.ReturnEvent(this._removed);
					this._removed = null;
				}
				else if (this._callbacksComplete != null)
				{
					RegisteredWaitHandle.ReturnEvent(this._callbacksComplete);
					this._callbacksComplete = null;
				}
				this.UserUnregisterWaitHandleValue = IntPtr.Zero;
				if (flag)
				{
					SafeWaitHandle userUnregisterWaitHandle3 = this.UserUnregisterWaitHandle;
					if (userUnregisterWaitHandle3 != null)
					{
						userUnregisterWaitHandle3.DangerousRelease();
					}
				}
				this.UserUnregisterWaitHandle = null;
				throw;
			}
			finally
			{
				this._unregisterCalled = true;
				RegisteredWaitHandle.s_callbackLock.Release();
			}
			this.WaitThread.UnregisterWait(this);
			return true;
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x000E0C54 File Offset: 0x000DEE54
		private void SignalUserWaitHandle()
		{
			SafeWaitHandle userUnregisterWaitHandle = this.UserUnregisterWaitHandle;
			IntPtr userUnregisterWaitHandleValue = this.UserUnregisterWaitHandleValue;
			try
			{
				if (userUnregisterWaitHandleValue != IntPtr.Zero && userUnregisterWaitHandleValue != RegisteredWaitHandle.InvalidHandleValue)
				{
					EventWaitHandle.Set(userUnregisterWaitHandle);
				}
			}
			finally
			{
				if (userUnregisterWaitHandle != null)
				{
					userUnregisterWaitHandle.DangerousRelease();
				}
				AutoResetEvent callbacksComplete = this._callbacksComplete;
				if (callbacksComplete != null)
				{
					callbacksComplete.Set();
				}
				this._unregistered = true;
			}
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x000E0CBC File Offset: 0x000DEEBC
		internal void PerformCallbackPortableCore(bool timedOut)
		{
			_ThreadPoolWaitOrTimerCallback.PerformWaitOrTimerCallback(this.Callback, timedOut);
			this.CompleteCallbackRequest();
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x000E0CD0 File Offset: 0x000DEED0
		internal void RequestCallback()
		{
			RegisteredWaitHandle.s_callbackLock.Acquire();
			try
			{
				this._numRequestedCallbacks++;
			}
			finally
			{
				RegisteredWaitHandle.s_callbackLock.Release();
			}
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x000E0D14 File Offset: 0x000DEF14
		internal void OnRemoveWait()
		{
			RegisteredWaitHandle.s_callbackLock.Acquire();
			try
			{
				AutoResetEvent removed = this._removed;
				if (removed != null)
				{
					removed.Set();
				}
				if (this._numRequestedCallbacks == 0)
				{
					this.SignalUserWaitHandle();
				}
				else
				{
					this._signalAfterCallbacksComplete = true;
				}
			}
			finally
			{
				RegisteredWaitHandle.s_callbackLock.Release();
			}
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x000E0D74 File Offset: 0x000DEF74
		private void CompleteCallbackRequest()
		{
			RegisteredWaitHandle.s_callbackLock.Acquire();
			try
			{
				this._numRequestedCallbacks--;
				if (this._numRequestedCallbacks == 0 && this._signalAfterCallbacksComplete)
				{
					this.SignalUserWaitHandle();
				}
			}
			finally
			{
				RegisteredWaitHandle.s_callbackLock.Release();
			}
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x000E0DCC File Offset: 0x000DEFCC
		internal void WaitForCallbacks()
		{
			this._callbacksComplete.WaitOne();
			RegisteredWaitHandle.ReturnEvent(this._callbacksComplete);
			this._callbacksComplete = null;
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x000E0DEC File Offset: 0x000DEFEC
		internal void WaitForRemoval()
		{
			this._removed.WaitOne();
			RegisteredWaitHandle.ReturnEvent(this._removed);
			this._removed = null;
		}

		// Token: 0x04000EE9 RID: 3817
		private readonly Lock _lock;

		// Token: 0x04000EEA RID: 3818
		private bool _unregistering;

		// Token: 0x04000EEB RID: 3819
		private GCHandle _gcHandle;

		// Token: 0x04000EEC RID: 3820
		private IntPtr _tpWait;

		// Token: 0x04000EED RID: 3821
		private SafeWaitHandle _waitHandle;

		// Token: 0x04000EEE RID: 3822
		private readonly _ThreadPoolWaitOrTimerCallback _callbackHelper;

		// Token: 0x04000EEF RID: 3823
		private readonly uint _millisecondsTimeout;

		// Token: 0x04000EF0 RID: 3824
		private readonly int _signedMillisecondsTimeout;

		// Token: 0x04000EF1 RID: 3825
		private bool _repeating;

		// Token: 0x04000EF3 RID: 3827
		private static AutoResetEvent s_cachedEvent;

		// Token: 0x04000EF4 RID: 3828
		private static readonly LowLevelLock s_callbackLock = new LowLevelLock();

		// Token: 0x04000EF7 RID: 3831
		private int _numRequestedCallbacks;

		// Token: 0x04000EF8 RID: 3832
		private bool _signalAfterCallbacksComplete;

		// Token: 0x04000EF9 RID: 3833
		private bool _unregisterCalled;

		// Token: 0x04000EFA RID: 3834
		private bool _unregistered;

		// Token: 0x04000EFB RID: 3835
		private AutoResetEvent _callbacksComplete;

		// Token: 0x04000EFC RID: 3836
		private AutoResetEvent _removed;
	}
}
