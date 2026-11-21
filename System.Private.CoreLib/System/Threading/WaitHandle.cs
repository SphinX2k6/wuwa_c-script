using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x0200045C RID: 1116
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class WaitHandle : MarshalByRefObject, IDisposable
	{
		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060042F2 RID: 17138 RVA: 0x000DF302 File Offset: 0x000DD502
		// (set) Token: 0x060042F3 RID: 17139 RVA: 0x000DF31D File Offset: 0x000DD51D
		[Obsolete("WaitHandle.Handle has been deprecated. Use the SafeWaitHandle property instead.")]
		public virtual IntPtr Handle
		{
			get
			{
				if (this._waitHandle != null)
				{
					return this._waitHandle.DangerousGetHandle();
				}
				return WaitHandle.InvalidHandle;
			}
			set
			{
				if (value == WaitHandle.InvalidHandle)
				{
					if (this._waitHandle != null)
					{
						this._waitHandle.SetHandleAsInvalid();
						this._waitHandle = null;
						return;
					}
				}
				else
				{
					this._waitHandle = new SafeWaitHandle(value, true);
				}
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x000DF350 File Offset: 0x000DD550
		// (set) Token: 0x060042F5 RID: 17141 RVA: 0x000DF37B File Offset: 0x000DD57B
		public SafeWaitHandle SafeWaitHandle
		{
			get
			{
				SafeWaitHandle result;
				if ((result = this._waitHandle) == null)
				{
					result = (this._waitHandle = new SafeWaitHandle(WaitHandle.InvalidHandle, false));
				}
				return result;
			}
			[param: AllowNull]
			set
			{
				this._waitHandle = value;
			}
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x000DF384 File Offset: 0x000DD584
		internal static int ToTimeoutMilliseconds(TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(num, -1L, "timeout");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(num, 2147483647L, "timeout");
			return (int)num;
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x000DF3AD File Offset: 0x000DD5AD
		public virtual void Close()
		{
			this.Dispose();
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x000DF3B5 File Offset: 0x000DD5B5
		protected virtual void Dispose(bool explicitDisposing)
		{
			SafeWaitHandle waitHandle = this._waitHandle;
			if (waitHandle == null)
			{
				return;
			}
			waitHandle.Close();
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x000DF3C7 File Offset: 0x000DD5C7
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x000DF3D6 File Offset: 0x000DD5D6
		public virtual bool WaitOne(int millisecondsTimeout)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(millisecondsTimeout, -1, "millisecondsTimeout");
			return this.WaitOneNoCheck(millisecondsTimeout, false, null, NativeRuntimeEventSource.WaitHandleWaitSourceMap.Unknown);
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x000DF3F0 File Offset: 0x000DD5F0
		internal bool WaitOneNoCheck(int millisecondsTimeout, bool useTrivialWaits = false, object associatedObject = null, NativeRuntimeEventSource.WaitHandleWaitSourceMap waitSource = NativeRuntimeEventSource.WaitHandleWaitSourceMap.Unknown)
		{
			SafeWaitHandle waitHandle = this._waitHandle;
			ObjectDisposedException.ThrowIf(waitHandle == null, this);
			bool flag = false;
			bool result;
			try
			{
				waitHandle.DangerousAddRef(ref flag);
				int num = -1;
				bool flag2 = false;
				if (!useTrivialWaits)
				{
					SynchronizationContext synchronizationContext = SynchronizationContext.Current;
					if (synchronizationContext != null && synchronizationContext.IsWaitNotificationRequired())
					{
						flag2 = true;
						num = synchronizationContext.Wait(new IntPtr[]
						{
							waitHandle.DangerousGetHandle()
						}, false, millisecondsTimeout);
					}
				}
				if (!flag2)
				{
					bool flag3 = millisecondsTimeout != 0 && !useTrivialWaits && NativeRuntimeEventSource.Log.IsEnabled(EventLevel.Verbose, (EventKeywords)4398046511104L);
					bool flag4 = flag3 && waitSource != NativeRuntimeEventSource.WaitHandleWaitSourceMap.MonitorWait;
					if (flag4)
					{
						num = WaitHandle.WaitOneCore(waitHandle.DangerousGetHandle(), 0, useTrivialWaits);
						if (num == 258)
						{
							flag4 = false;
						}
						else
						{
							flag3 = false;
						}
					}
					if (flag3)
					{
						NativeRuntimeEventSource.Log.WaitHandleWaitStart(waitSource, associatedObject ?? this);
					}
					if (!flag4)
					{
						num = WaitHandle.WaitOneCore(waitHandle.DangerousGetHandle(), millisecondsTimeout, useTrivialWaits);
					}
					if (flag3)
					{
						NativeRuntimeEventSource.Log.WaitHandleWaitStop(0);
					}
				}
				if (num == 128)
				{
					throw new AbandonedMutexException();
				}
				result = (num != 258);
			}
			finally
			{
				if (flag)
				{
					waitHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x000DF518 File Offset: 0x000DD718
		private static SafeWaitHandle[] RentSafeWaitHandleArray(int capacity)
		{
			SafeWaitHandle[] array = WaitHandle.t_safeWaitHandlesForRent;
			WaitHandle.t_safeWaitHandlesForRent = null;
			int num = (array != null) ? array.Length : 0;
			if (num < capacity)
			{
				array = new SafeWaitHandle[Math.Max(capacity, Math.Min(64, 2 * num))];
			}
			return array;
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x000DF556 File Offset: 0x000DD756
		private static void ReturnSafeWaitHandleArray(SafeWaitHandle[] safeWaitHandles)
		{
			WaitHandle.t_safeWaitHandlesForRent = safeWaitHandles;
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x000DF560 File Offset: 0x000DD760
		private unsafe static void ObtainSafeWaitHandles(ReadOnlySpan<WaitHandle> waitHandles, Span<SafeWaitHandle> safeWaitHandles, Span<IntPtr> unsafeWaitHandles)
		{
			bool flag = true;
			SafeWaitHandle safeWaitHandle = null;
			try
			{
				for (int i = 0; i < waitHandles.Length; i++)
				{
					object obj = *waitHandles[i];
					if (obj == null)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
						defaultInterpolatedStringHandler.AppendLiteral("waitHandles[");
						defaultInterpolatedStringHandler.AppendFormatted<int>(i);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						throw new ArgumentNullException(defaultInterpolatedStringHandler.ToStringAndClear(), SR.ArgumentNull_ArrayElement);
					}
					WaitHandle waitHandle = obj;
					SafeWaitHandle waitHandle2 = waitHandle._waitHandle;
					ObjectDisposedException.ThrowIf(waitHandle2 == null, waitHandle);
					safeWaitHandle = waitHandle2;
					flag = false;
					waitHandle2.DangerousAddRef(ref flag);
					*safeWaitHandles[i] = waitHandle2;
					*unsafeWaitHandles[i] = waitHandle2.DangerousGetHandle();
				}
			}
			catch
			{
				for (int j = 0; j < waitHandles.Length; j++)
				{
					SafeWaitHandle safeWaitHandle2 = *safeWaitHandles[j];
					if (safeWaitHandle2 == null)
					{
						break;
					}
					safeWaitHandle2.DangerousRelease();
					*safeWaitHandles[j] = null;
					if (safeWaitHandle2 == safeWaitHandle)
					{
						safeWaitHandle = null;
						flag = true;
					}
				}
				if (!flag)
				{
					safeWaitHandle.DangerousRelease();
				}
				throw;
			}
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x000DF670 File Offset: 0x000DD870
		private static int WaitMultiple(WaitHandle[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			ArgumentNullException.ThrowIfNull(waitHandles, "waitHandles");
			return WaitHandle.WaitMultiple(new ReadOnlySpan<WaitHandle>(waitHandles), waitAll, millisecondsTimeout);
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x000DF68C File Offset: 0x000DD88C
		private unsafe static int WaitMultiple(ReadOnlySpan<WaitHandle> waitHandles, bool waitAll, int millisecondsTimeout)
		{
			if (waitHandles.Length == 0)
			{
				throw new ArgumentException(SR.Argument_EmptyWaithandleArray, "waitHandles");
			}
			if (waitHandles.Length > 64)
			{
				throw new NotSupportedException(SR.NotSupported_MaxWaitHandles);
			}
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(millisecondsTimeout, -1, "millisecondsTimeout");
			SynchronizationContext synchronizationContext = SynchronizationContext.Current;
			bool flag = synchronizationContext != null && synchronizationContext.IsWaitNotificationRequired();
			SafeWaitHandle[] array = WaitHandle.RentSafeWaitHandleArray(waitHandles.Length);
			int num2;
			try
			{
				int num;
				if (flag)
				{
					IntPtr[] array2 = new IntPtr[waitHandles.Length];
					WaitHandle.ObtainSafeWaitHandles(waitHandles, array, array2);
					num = synchronizationContext.Wait(array2, waitAll, millisecondsTimeout);
				}
				else
				{
					num2 = waitHandles.Length;
					Span<IntPtr> span = new Span<IntPtr>(stackalloc byte[checked(unchecked((UIntPtr)num2) * 8)], num2);
					WaitHandle.ObtainSafeWaitHandles(waitHandles, array, span);
					num = WaitHandle.WaitMultipleIgnoringSyncContext(span, waitAll, millisecondsTimeout);
				}
				if (num >= 128 && num < 128 + waitHandles.Length)
				{
					if (waitAll)
					{
						throw new AbandonedMutexException();
					}
					num -= 128;
					throw new AbandonedMutexException(num, *waitHandles[num]);
				}
				else
				{
					num2 = num;
				}
			}
			finally
			{
				for (int i = 0; i < waitHandles.Length; i++)
				{
					SafeWaitHandle safeWaitHandle = array[i];
					if (safeWaitHandle != null)
					{
						safeWaitHandle.DangerousRelease();
						array[i] = null;
					}
				}
				WaitHandle.ReturnSafeWaitHandleArray(array);
			}
			return num2;
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x000DF7E4 File Offset: 0x000DD9E4
		private unsafe static int WaitAnyMultiple(ReadOnlySpan<SafeWaitHandle> safeWaitHandles, int millisecondsTimeout)
		{
			SynchronizationContext synchronizationContext = SynchronizationContext.Current;
			int result;
			if (synchronizationContext != null && synchronizationContext.IsWaitNotificationRequired())
			{
				IntPtr[] array = new IntPtr[safeWaitHandles.Length];
				for (int i = 0; i < safeWaitHandles.Length; i++)
				{
					array[i] = safeWaitHandles[i]->DangerousGetHandle();
				}
				result = synchronizationContext.Wait(array, false, millisecondsTimeout);
			}
			else
			{
				int length = safeWaitHandles.Length;
				Span<IntPtr> span = new Span<IntPtr>(stackalloc byte[checked(unchecked((UIntPtr)length) * 8)], length);
				for (int j = 0; j < safeWaitHandles.Length; j++)
				{
					*span[j] = safeWaitHandles[j]->DangerousGetHandle();
				}
				result = WaitHandle.WaitMultipleIgnoringSyncContext(span, false, millisecondsTimeout);
			}
			return result;
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x000DF8A0 File Offset: 0x000DDAA0
		internal static int WaitMultipleIgnoringSyncContext(ReadOnlySpan<IntPtr> handles, bool waitAll, int millisecondsTimeout)
		{
			int num = -1;
			bool flag = millisecondsTimeout != 0 && NativeRuntimeEventSource.Log.IsEnabled(EventLevel.Verbose, (EventKeywords)4398046511104L);
			bool flag2 = flag;
			if (flag2)
			{
				num = WaitHandle.WaitMultipleIgnoringSyncContextCore(handles, waitAll, 0);
				if (num == 258)
				{
					flag2 = false;
				}
				else
				{
					flag = false;
				}
			}
			if (flag)
			{
				NativeRuntimeEventSource.Log.WaitHandleWaitStart(NativeRuntimeEventSource.WaitHandleWaitSourceMap.Unknown, null);
			}
			if (!flag2)
			{
				num = WaitHandle.WaitMultipleIgnoringSyncContextCore(handles, waitAll, millisecondsTimeout);
			}
			if (flag)
			{
				NativeRuntimeEventSource.Log.WaitHandleWaitStop(0);
			}
			return num;
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x000DF910 File Offset: 0x000DDB10
		private static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, int millisecondsTimeout)
		{
			ArgumentNullException.ThrowIfNull(toSignal, "toSignal");
			ArgumentNullException.ThrowIfNull(toWaitOn, "toWaitOn");
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(millisecondsTimeout, -1, "millisecondsTimeout");
			SafeWaitHandle waitHandle = toSignal._waitHandle;
			SafeWaitHandle waitHandle2 = toWaitOn._waitHandle;
			ObjectDisposedException.ThrowIf(waitHandle == null, toSignal);
			ObjectDisposedException.ThrowIf(waitHandle2 == null, toWaitOn);
			bool flag = false;
			bool flag2 = false;
			bool result;
			try
			{
				waitHandle.DangerousAddRef(ref flag);
				waitHandle2.DangerousAddRef(ref flag2);
				int num = WaitHandle.SignalAndWaitCore(waitHandle.DangerousGetHandle(), waitHandle2.DangerousGetHandle(), millisecondsTimeout);
				if (num == 128)
				{
					throw new AbandonedMutexException();
				}
				result = (num != 258);
			}
			finally
			{
				if (flag2)
				{
					waitHandle2.DangerousRelease();
				}
				if (flag)
				{
					waitHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x000DF9C8 File Offset: 0x000DDBC8
		internal static void ThrowInvalidHandleException()
		{
			throw new InvalidOperationException(SR.InvalidOperation_InvalidHandle)
			{
				HResult = -2147024890
			};
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x000DF9DF File Offset: 0x000DDBDF
		public virtual bool WaitOne(TimeSpan timeout)
		{
			return this.WaitOneNoCheck(WaitHandle.ToTimeoutMilliseconds(timeout), false, null, NativeRuntimeEventSource.WaitHandleWaitSourceMap.Unknown);
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x000DF9F0 File Offset: 0x000DDBF0
		public virtual bool WaitOne()
		{
			return this.WaitOneNoCheck(-1, false, null, NativeRuntimeEventSource.WaitHandleWaitSourceMap.Unknown);
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x000DF9FC File Offset: 0x000DDBFC
		public virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
		{
			return this.WaitOne(millisecondsTimeout);
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x000DF9DF File Offset: 0x000DDBDF
		public virtual bool WaitOne(TimeSpan timeout, bool exitContext)
		{
			return this.WaitOneNoCheck(WaitHandle.ToTimeoutMilliseconds(timeout), false, null, NativeRuntimeEventSource.WaitHandleWaitSourceMap.Unknown);
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x000DFA05 File Offset: 0x000DDC05
		public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout)
		{
			return WaitHandle.WaitMultiple(waitHandles, true, millisecondsTimeout) != 258;
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x000DFA19 File Offset: 0x000DDC19
		public static bool WaitAll(WaitHandle[] waitHandles, TimeSpan timeout)
		{
			return WaitHandle.WaitMultiple(waitHandles, true, WaitHandle.ToTimeoutMilliseconds(timeout)) != 258;
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x000DFA32 File Offset: 0x000DDC32
		public static bool WaitAll(WaitHandle[] waitHandles)
		{
			return WaitHandle.WaitMultiple(waitHandles, true, -1) != 258;
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x000DFA05 File Offset: 0x000DDC05
		public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
		{
			return WaitHandle.WaitMultiple(waitHandles, true, millisecondsTimeout) != 258;
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x000DFA19 File Offset: 0x000DDC19
		public static bool WaitAll(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext)
		{
			return WaitHandle.WaitMultiple(waitHandles, true, WaitHandle.ToTimeoutMilliseconds(timeout)) != 258;
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x000DFA46 File Offset: 0x000DDC46
		public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout)
		{
			return WaitHandle.WaitMultiple(waitHandles, false, millisecondsTimeout);
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x000DFA50 File Offset: 0x000DDC50
		internal static int WaitAny(ReadOnlySpan<SafeWaitHandle> safeWaitHandles, int millisecondsTimeout)
		{
			return WaitHandle.WaitAnyMultiple(safeWaitHandles, millisecondsTimeout);
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x000DFA59 File Offset: 0x000DDC59
		public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout)
		{
			return WaitHandle.WaitMultiple(waitHandles, false, WaitHandle.ToTimeoutMilliseconds(timeout));
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x000DFA68 File Offset: 0x000DDC68
		public static int WaitAny(WaitHandle[] waitHandles)
		{
			return WaitHandle.WaitMultiple(waitHandles, false, -1);
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x000DFA46 File Offset: 0x000DDC46
		public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
		{
			return WaitHandle.WaitMultiple(waitHandles, false, millisecondsTimeout);
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x000DFA59 File Offset: 0x000DDC59
		public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext)
		{
			return WaitHandle.WaitMultiple(waitHandles, false, WaitHandle.ToTimeoutMilliseconds(timeout));
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x000DFA72 File Offset: 0x000DDC72
		public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn)
		{
			return WaitHandle.SignalAndWait(toSignal, toWaitOn, -1);
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x000DFA7C File Offset: 0x000DDC7C
		public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, TimeSpan timeout, bool exitContext)
		{
			return WaitHandle.SignalAndWait(toSignal, toWaitOn, WaitHandle.ToTimeoutMilliseconds(timeout));
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x000DFA8B File Offset: 0x000DDC8B
		public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, int millisecondsTimeout, bool exitContext)
		{
			return WaitHandle.SignalAndWait(toSignal, toWaitOn, millisecondsTimeout);
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x000DFA98 File Offset: 0x000DDC98
		private unsafe static int WaitMultipleIgnoringSyncContextCore(ReadOnlySpan<IntPtr> handles, bool waitAll, int millisecondsTimeout)
		{
			fixed (IntPtr* reference = MemoryMarshal.GetReference<IntPtr>(handles))
			{
				return WaitHandle.WaitForMultipleObjectsIgnoringSyncContext(reference, handles.Length, waitAll, millisecondsTimeout, false);
			}
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x000DFAC0 File Offset: 0x000DDCC0
		private unsafe static int WaitForMultipleObjectsIgnoringSyncContext(IntPtr* pHandles, int numHandles, bool waitAll, int millisecondsTimeout, bool useTrivialWaits)
		{
			if (numHandles == 1)
			{
				waitAll = false;
			}
			Thread currentThread = Thread.CurrentThread;
			currentThread.SetWaitSleepJoinState();
			int num = (int)Interop.Kernel32.WaitForMultipleObjectsEx((uint)numHandles, pHandles, waitAll ? Interop.BOOL.TRUE : Interop.BOOL.FALSE, (uint)millisecondsTimeout, Interop.BOOL.FALSE);
			currentThread.ClearWaitSleepJoinState();
			if (num == -1)
			{
				int lastError = Interop.Kernel32.GetLastError();
				if (waitAll && lastError == 87)
				{
					for (int i = 1; i < numHandles; i++)
					{
						IntPtr intPtr = pHandles[(IntPtr)i * 8 / (IntPtr)sizeof(IntPtr)];
						for (int j = 0; j < i; j++)
						{
							if (pHandles[(IntPtr)j * 8 / (IntPtr)sizeof(IntPtr)] == intPtr)
							{
								throw new DuplicateWaitObjectException("waitHandles[" + i.ToString() + "]");
							}
						}
					}
				}
				WaitHandle.ThrowWaitFailedException(lastError);
			}
			return num;
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x000DFB65 File Offset: 0x000DDD65
		internal unsafe static int WaitOneCore(IntPtr handle, int millisecondsTimeout, bool useTrivialWaits)
		{
			return WaitHandle.WaitForMultipleObjectsIgnoringSyncContext(&handle, 1, false, millisecondsTimeout, useTrivialWaits);
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x000DFB73 File Offset: 0x000DDD73
		private static int SignalAndWaitCore(IntPtr handleToSignal, IntPtr handleToWaitOn, int millisecondsTimeout)
		{
			uint num = Interop.Kernel32.SignalObjectAndWait(handleToSignal, handleToWaitOn, (uint)millisecondsTimeout, Interop.BOOL.FALSE);
			if (num == 4294967295U)
			{
				WaitHandle.ThrowWaitFailedException(Interop.Kernel32.GetLastError());
			}
			return (int)num;
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x000DFB8C File Offset: 0x000DDD8C
		private static void ThrowWaitFailedException(int errorCode)
		{
			if (errorCode <= 87)
			{
				switch (errorCode)
				{
				case 5:
					throw new UnauthorizedAccessException();
				case 6:
					WaitHandle.ThrowInvalidHandleException();
					return;
				case 7:
					break;
				case 8:
					throw new OutOfMemoryException();
				default:
					if (errorCode == 87)
					{
						throw new ArgumentException();
					}
					break;
				}
			}
			else
			{
				if (errorCode == 288)
				{
					throw new ApplicationException(SR.Arg_SynchronizationLockException);
				}
				if (errorCode == 298)
				{
					throw new InvalidOperationException(SR.Threading_WaitHandleTooManyPosts);
				}
				if (errorCode == 587)
				{
					throw new OverflowException(SR.Overflow_MutexReacquireCount);
				}
			}
			throw new Exception
			{
				HResult = errorCode
			};
		}

		// Token: 0x04000EB6 RID: 3766
		protected static readonly IntPtr InvalidHandle = new IntPtr(-1);

		// Token: 0x04000EB7 RID: 3767
		private SafeWaitHandle _waitHandle;

		// Token: 0x04000EB8 RID: 3768
		[ThreadStatic]
		private static SafeWaitHandle[] t_safeWaitHandlesForRent;

		// Token: 0x04000EB9 RID: 3769
		public const int WaitTimeout = 258;
	}
}
