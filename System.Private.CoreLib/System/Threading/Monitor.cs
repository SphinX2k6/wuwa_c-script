using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Threading
{
	// Token: 0x020003BA RID: 954
	[NullableContext(1)]
	[Nullable(0)]
	public static class Monitor
	{
		// Token: 0x06003E95 RID: 16021
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Enter(object obj);

		// Token: 0x06003E96 RID: 16022 RVA: 0x000D2E47 File Offset: 0x000D1047
		[Intrinsic]
		public static void Enter(object obj, ref bool lockTaken)
		{
			if (lockTaken)
			{
				throw new ArgumentException(SR.Argument_MustBeFalse, "lockTaken");
			}
			Monitor.ReliableEnterTimeout(obj, -1, ref lockTaken);
		}

		// Token: 0x06003E97 RID: 16023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InternalExit(object obj);

		// Token: 0x06003E98 RID: 16024 RVA: 0x000D2E65 File Offset: 0x000D1065
		public static void Exit(object obj)
		{
			if (obj == null)
			{
				ArgumentNullException.ThrowIfNull(obj, "obj");
			}
			if (ObjectHeader.TryExitChecked(obj))
			{
				return;
			}
			Monitor.InternalExit(obj);
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x000D2E84 File Offset: 0x000D1084
		public static bool TryEnter(object obj)
		{
			bool result = false;
			Monitor.TryEnter(obj, 0, ref result);
			return result;
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x000D2E9D File Offset: 0x000D109D
		public static void TryEnter(object obj, ref bool lockTaken)
		{
			if (lockTaken)
			{
				throw new ArgumentException(SR.Argument_MustBeFalse, "lockTaken");
			}
			Monitor.ReliableEnterTimeout(obj, 0, ref lockTaken);
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x000D2EBC File Offset: 0x000D10BC
		public static bool TryEnter(object obj, int millisecondsTimeout)
		{
			bool result = false;
			Monitor.TryEnter(obj, millisecondsTimeout, ref result);
			return result;
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x000D2ED5 File Offset: 0x000D10D5
		public static void TryEnter(object obj, int millisecondsTimeout, ref bool lockTaken)
		{
			if (lockTaken)
			{
				throw new ArgumentException(SR.Argument_MustBeFalse, "lockTaken");
			}
			Monitor.ReliableEnterTimeout(obj, millisecondsTimeout, ref lockTaken);
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x000D2EF3 File Offset: 0x000D10F3
		public static bool IsEntered(object obj)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			return ObjectHeader.IsEntered(obj);
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x000D2F06 File Offset: 0x000D1106
		[UnsupportedOSPlatform("browser")]
		public static bool Wait(object obj, int millisecondsTimeout)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			return Monitor.ObjWait(millisecondsTimeout, obj);
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x000D2F1A File Offset: 0x000D111A
		public static void Pulse(object obj)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			Monitor.ObjPulse(obj);
		}

		// Token: 0x06003EA0 RID: 16032 RVA: 0x000D2F2D File Offset: 0x000D112D
		public static void PulseAll(object obj)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			Monitor.ObjPulseAll(obj);
		}

		// Token: 0x06003EA1 RID: 16033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Monitor_pulse(object obj);

		// Token: 0x06003EA2 RID: 16034 RVA: 0x000D2F40 File Offset: 0x000D1140
		private static void ObjPulse(object obj)
		{
			if (!ObjectHeader.HasOwner(obj))
			{
				throw new SynchronizationLockException();
			}
			Monitor.Monitor_pulse(obj);
		}

		// Token: 0x06003EA3 RID: 16035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Monitor_pulse_all(object obj);

		// Token: 0x06003EA4 RID: 16036 RVA: 0x000D2F56 File Offset: 0x000D1156
		private static void ObjPulseAll(object obj)
		{
			if (!ObjectHeader.HasOwner(obj))
			{
				throw new SynchronizationLockException();
			}
			Monitor.Monitor_pulse_all(obj);
		}

		// Token: 0x06003EA5 RID: 16037
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Monitor_wait(object obj, int ms, bool allowInterruption);

		// Token: 0x06003EA6 RID: 16038 RVA: 0x000D2F6C File Offset: 0x000D116C
		private static bool ObjWait(int millisecondsTimeout, object obj)
		{
			if (millisecondsTimeout < 0 && millisecondsTimeout != -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout");
			}
			if (!ObjectHeader.HasOwner(obj))
			{
				throw new SynchronizationLockException();
			}
			bool flag = millisecondsTimeout != 0 && NativeRuntimeEventSource.Log.IsEnabled(EventLevel.Verbose, (EventKeywords)4398046511104L);
			if (flag)
			{
				NativeRuntimeEventSource.Log.WaitHandleWaitStart(NativeRuntimeEventSource.WaitHandleWaitSourceMap.MonitorWait, obj);
			}
			bool result = Monitor.Monitor_wait(obj, millisecondsTimeout, true);
			if (flag)
			{
				NativeRuntimeEventSource.Log.WaitHandleWaitStop(0);
			}
			return result;
		}

		// Token: 0x06003EA7 RID: 16039
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void try_enter_with_atomic_var(object obj, int millisecondsTimeout, bool allowInterruption, ref bool lockTaken);

		// Token: 0x06003EA8 RID: 16040 RVA: 0x000D2FDA File Offset: 0x000D11DA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken)
		{
			if (obj == null)
			{
				ArgumentNullException.ThrowIfNull(obj, "obj");
			}
			if (timeout < 0 && timeout != -1)
			{
				throw new ArgumentOutOfRangeException("timeout");
			}
			if (ObjectHeader.TryEnterFast(obj))
			{
				lockTaken = true;
				return;
			}
			Monitor.try_enter_with_atomic_var(obj, timeout, true, ref lockTaken);
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06003EA9 RID: 16041 RVA: 0x000D3012 File Offset: 0x000D1212
		public static long LockContentionCount
		{
			get
			{
				return Monitor.Monitor_get_lock_contention_count() + Lock.ContentionCount;
			}
		}

		// Token: 0x06003EAA RID: 16042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long Monitor_get_lock_contention_count();

		// Token: 0x06003EAB RID: 16043 RVA: 0x000D301F File Offset: 0x000D121F
		public static bool TryEnter(object obj, TimeSpan timeout)
		{
			return Monitor.TryEnter(obj, WaitHandle.ToTimeoutMilliseconds(timeout));
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x000D302D File Offset: 0x000D122D
		public static void TryEnter(object obj, TimeSpan timeout, ref bool lockTaken)
		{
			Monitor.TryEnter(obj, WaitHandle.ToTimeoutMilliseconds(timeout), ref lockTaken);
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x000D303C File Offset: 0x000D123C
		[UnsupportedOSPlatform("browser")]
		public static bool Wait(object obj, TimeSpan timeout)
		{
			return Monitor.Wait(obj, WaitHandle.ToTimeoutMilliseconds(timeout));
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x000D304A File Offset: 0x000D124A
		[UnsupportedOSPlatform("browser")]
		public static bool Wait(object obj)
		{
			return Monitor.Wait(obj, -1);
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x000D3053 File Offset: 0x000D1253
		[UnsupportedOSPlatform("browser")]
		public static bool Wait(object obj, int millisecondsTimeout, bool exitContext)
		{
			return Monitor.Wait(obj, millisecondsTimeout);
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x000D303C File Offset: 0x000D123C
		[UnsupportedOSPlatform("browser")]
		public static bool Wait(object obj, TimeSpan timeout, bool exitContext)
		{
			return Monitor.Wait(obj, WaitHandle.ToTimeoutMilliseconds(timeout));
		}
	}
}
