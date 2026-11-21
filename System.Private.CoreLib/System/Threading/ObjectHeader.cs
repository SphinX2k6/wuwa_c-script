using System;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x020003BB RID: 955
	internal static class ObjectHeader
	{
		// Token: 0x06003EB1 RID: 16049 RVA: 0x000D305C File Offset: 0x000D125C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ObjectHeader.LockWord GetLockWord(ObjectHeader.ObjectHeaderOnStack h)
		{
			return ObjectHeader.LockWord.FromObjectHeader(h.Header);
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x000D306A File Offset: 0x000D126A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IntPtr LockWordCompareExchange(ObjectHeader.ObjectHeaderOnStack h, ObjectHeader.LockWord nlw, ObjectHeader.LockWord expected)
		{
			return Interlocked.CompareExchange(ref h.Header.synchronization, nlw.AsIntPtr, expected.AsIntPtr);
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x000D308C File Offset: 0x000D128C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetHashCode(object o, out int hash)
		{
			hash = 0;
			if (o == null)
			{
				return true;
			}
			ObjectHeader.LockWord lockWord = ObjectHeader.GetLockWord(ObjectHeader.ObjectHeaderOnStack.Create(ref o));
			if (!lockWord.HasHash)
			{
				return false;
			}
			if (lockWord.IsInflated)
			{
				ref ObjectHeader.MonoThreadsSync inflatedLock = ref lockWord.GetInflatedLock();
				hash = ObjectHeader.SyncBlock.HashCode(ref inflatedLock);
				return true;
			}
			hash = lockWord.FlatHash;
			return true;
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x000D30E0 File Offset: 0x000D12E0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool TryEnterInflatedFast([ScopedRef] ref ObjectHeader.MonoThreadsSync mon, int small_id)
		{
			uint num = *ObjectHeader.SyncBlock.Status(ref mon);
			if (ObjectHeader.MonitorStatus.GetOwner(num) == 0)
			{
				uint value = ObjectHeader.MonitorStatus.SetOwner(num, small_id);
				return Interlocked.CompareExchange(ObjectHeader.SyncBlock.Status(ref mon), value, num) == num;
			}
			if (ObjectHeader.MonitorStatus.GetOwner(num) == small_id)
			{
				ObjectHeader.SyncBlock.IncrementNest(ref mon);
				return true;
			}
			return false;
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x000D312C File Offset: 0x000D132C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryEnterFast(object o)
		{
			ObjectHeader.ObjectHeaderOnStack h = ObjectHeader.ObjectHeaderOnStack.Create(ref o);
			ObjectHeader.LockWord lockWord = ObjectHeader.GetLockWord(h);
			if (!lockWord.IsInflated && lockWord.HasHash)
			{
				return false;
			}
			int smallId = Thread.CurrentThread.GetSmallId();
			if (lockWord.IsFree)
			{
				ObjectHeader.LockWord nlw = ObjectHeader.LockWord.NewFlat(smallId);
				return ObjectHeader.LockWordCompareExchange(h, nlw, lockWord) == lockWord.AsIntPtr;
			}
			if (lockWord.IsInflated)
			{
				return ObjectHeader.TryEnterInflatedFast(lockWord.GetInflatedLock(), smallId);
			}
			if (!lockWord.IsFlat)
			{
				return false;
			}
			if (lockWord.GetOwner() != smallId)
			{
				return false;
			}
			if (lockWord.IsNestMax)
			{
				return false;
			}
			ObjectHeader.LockWord nlw2 = lockWord.IncrementNest();
			return ObjectHeader.LockWordCompareExchange(h, nlw2, lockWord) == lockWord.AsIntPtr;
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x000D31E4 File Offset: 0x000D13E4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsEntered(object obj)
		{
			ObjectHeader.LockWord lockWord = ObjectHeader.GetLockWord(ObjectHeader.ObjectHeaderOnStack.Create(ref obj));
			if (lockWord.IsFlat)
			{
				return lockWord.GetOwner() == Thread.CurrentThread.GetSmallId();
			}
			return lockWord.IsInflated && ObjectHeader.MonitorStatus.GetOwner(lockWord.GetInflatedLock().status) == Thread.CurrentThread.GetSmallId();
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x000D3244 File Offset: 0x000D1444
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasOwner(object obj)
		{
			ObjectHeader.LockWord lockWord = ObjectHeader.GetLockWord(ObjectHeader.ObjectHeaderOnStack.Create(ref obj));
			if (lockWord.IsFlat)
			{
				return !lockWord.IsFree;
			}
			return lockWord.IsInflated && ObjectHeader.MonitorStatus.GetOwner(lockWord.GetInflatedLock().status) != 0;
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x000D3294 File Offset: 0x000D1494
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryExitInflated([ScopedRef] ref ObjectHeader.MonoThreadsSync mon)
		{
			if (ObjectHeader.SyncBlock.TryDecrementNest(ref mon))
			{
				return true;
			}
			ref uint ptr = ref ObjectHeader.SyncBlock.Status(ref mon);
			uint num = ptr;
			if (ObjectHeader.MonitorStatus.HaveWaiters(num))
			{
				return false;
			}
			uint value = ObjectHeader.MonitorStatus.SetOwner(num, 0);
			return Interlocked.CompareExchange(ref ptr, value, num) == num;
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x000D32D8 File Offset: 0x000D14D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryExitFlat(ObjectHeader.ObjectHeaderOnStack h, ObjectHeader.LockWord lw)
		{
			ObjectHeader.LockWord nlw;
			if (lw.IsNested)
			{
				nlw = lw.DecrementNest();
			}
			else
			{
				nlw = default(ObjectHeader.LockWord);
			}
			return ObjectHeader.LockWordCompareExchange(h, nlw, lw) == lw.AsIntPtr;
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x000D3314 File Offset: 0x000D1514
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryExitChecked(object obj)
		{
			ObjectHeader.ObjectHeaderOnStack h = ObjectHeader.ObjectHeaderOnStack.Create(ref obj);
			ObjectHeader.LockWord lockWord = ObjectHeader.GetLockWord(h);
			bool flag = false;
			ref ObjectHeader.MonoThreadsSync ptr = ref Unsafe.NullRef<ObjectHeader.MonoThreadsSync>();
			if (lockWord.IsFlat)
			{
				flag = (lockWord.GetOwner() == Thread.CurrentThread.GetSmallId());
			}
			else if (lockWord.IsInflated)
			{
				ptr = lockWord.GetInflatedLock();
				flag = (ObjectHeader.MonitorStatus.GetOwner(ptr.status) == Thread.CurrentThread.GetSmallId());
			}
			if (!flag)
			{
				throw new SynchronizationLockException(SR.Arg_SynchronizationLockException);
			}
			if (lockWord.IsInflated)
			{
				return ObjectHeader.TryExitInflated(ref ptr);
			}
			return ObjectHeader.TryExitFlat(h, lockWord);
		}

		// Token: 0x020003BC RID: 956
		private struct Header
		{
			// Token: 0x04000CDB RID: 3291
			public unsafe void* vtable;

			// Token: 0x04000CDC RID: 3292
			public IntPtr synchronization;
		}

		// Token: 0x020003BD RID: 957
		[CompilerFeatureRequired("RefStructs")]
		private ref struct ObjectHeaderOnStack
		{
			// Token: 0x06003EBB RID: 16059 RVA: 0x000D33A5 File Offset: 0x000D15A5
			private unsafe ObjectHeaderOnStack(ref object o)
			{
				this._header = (ObjectHeader.Header**)Unsafe.AsPointer<object>(ref o);
			}

			// Token: 0x06003EBC RID: 16060 RVA: 0x000D33B3 File Offset: 0x000D15B3
			public static ObjectHeader.ObjectHeaderOnStack Create(ref object o)
			{
				return new ObjectHeader.ObjectHeaderOnStack(ref o);
			}

			// Token: 0x17000B80 RID: 2944
			// (get) Token: 0x06003EBD RID: 16061 RVA: 0x000D33BB File Offset: 0x000D15BB
			public unsafe ref ObjectHeader.Header Header
			{
				get
				{
					return Unsafe.AsRef<ObjectHeader.Header>(*(IntPtr*)this._header);
				}
			}

			// Token: 0x04000CDD RID: 3293
			private unsafe ObjectHeader.Header** _header;
		}

		// Token: 0x020003BE RID: 958
		private struct MonoThreadsSync
		{
			// Token: 0x04000CDE RID: 3294
			public uint status;

			// Token: 0x04000CDF RID: 3295
			public uint nest;

			// Token: 0x04000CE0 RID: 3296
			public int hash_code;
		}

		// Token: 0x020003BF RID: 959
		private static class SyncBlock
		{
			// Token: 0x06003EBE RID: 16062 RVA: 0x000D33C9 File Offset: 0x000D15C9
			public static int HashCode(ref ObjectHeader.MonoThreadsSync mon)
			{
				return mon.hash_code;
			}

			// Token: 0x06003EBF RID: 16063 RVA: 0x000D33D1 File Offset: 0x000D15D1
			public static ref uint Status(ref ObjectHeader.MonoThreadsSync mon)
			{
				return ref mon.status;
			}

			// Token: 0x06003EC0 RID: 16064 RVA: 0x000D33D9 File Offset: 0x000D15D9
			public static void IncrementNest(ref ObjectHeader.MonoThreadsSync mon)
			{
				mon.nest += 1U;
			}

			// Token: 0x06003EC1 RID: 16065 RVA: 0x000D33E6 File Offset: 0x000D15E6
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool TryDecrementNest(ref ObjectHeader.MonoThreadsSync mon)
			{
				if (mon.nest == 1U)
				{
					return false;
				}
				mon.nest -= 1U;
				return true;
			}
		}

		// Token: 0x020003C0 RID: 960
		private static class MonitorStatus
		{
			// Token: 0x06003EC2 RID: 16066 RVA: 0x000D33FF File Offset: 0x000D15FF
			public static int GetOwner(uint status)
			{
				return (int)(status & 65535U);
			}

			// Token: 0x06003EC3 RID: 16067 RVA: 0x000D3408 File Offset: 0x000D1608
			public static uint SetOwner(uint status, int owner)
			{
				return (status & 4294901760U) | (uint)owner;
			}

			// Token: 0x06003EC4 RID: 16068 RVA: 0x000D3413 File Offset: 0x000D1613
			public static bool HaveWaiters(uint status)
			{
				return (status & 2147483648U) > 0U;
			}
		}

		// Token: 0x020003C1 RID: 961
		private struct LockWord
		{
			// Token: 0x17000B81 RID: 2945
			// (get) Token: 0x06003EC5 RID: 16069 RVA: 0x000D341F File Offset: 0x000D161F
			public bool IsInflated
			{
				get
				{
					return (this._lock_word & (IntPtr)2) > (IntPtr)0;
				}
			}

			// Token: 0x06003EC6 RID: 16070 RVA: 0x000D342E File Offset: 0x000D162E
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public ref ObjectHeader.MonoThreadsSync GetInflatedLock()
			{
				return Unsafe.AsRef<ObjectHeader.MonoThreadsSync>(this._lock_word & ~(IntPtr)3);
			}

			// Token: 0x17000B82 RID: 2946
			// (get) Token: 0x06003EC7 RID: 16071 RVA: 0x000D343F File Offset: 0x000D163F
			public bool HasHash
			{
				get
				{
					return (this._lock_word & (IntPtr)1) > (IntPtr)0;
				}
			}

			// Token: 0x17000B83 RID: 2947
			// (get) Token: 0x06003EC8 RID: 16072 RVA: 0x000D344E File Offset: 0x000D164E
			public bool IsFree
			{
				get
				{
					return this._lock_word == IntPtr.Zero;
				}
			}

			// Token: 0x17000B84 RID: 2948
			// (get) Token: 0x06003EC9 RID: 16073 RVA: 0x000D345D File Offset: 0x000D165D
			public bool IsFlat
			{
				get
				{
					return (this._lock_word & (IntPtr)3) == (IntPtr)0;
				}
			}

			// Token: 0x17000B85 RID: 2949
			// (get) Token: 0x06003ECA RID: 16074 RVA: 0x000D346C File Offset: 0x000D166C
			public bool IsNested
			{
				get
				{
					return (this._lock_word & (IntPtr)1020) > (IntPtr)0;
				}
			}

			// Token: 0x17000B86 RID: 2950
			// (get) Token: 0x06003ECB RID: 16075 RVA: 0x000D347F File Offset: 0x000D167F
			public int FlatHash
			{
				get
				{
					return (int)(this._lock_word >> 2);
				}
			}

			// Token: 0x17000B87 RID: 2951
			// (get) Token: 0x06003ECC RID: 16076 RVA: 0x000D348A File Offset: 0x000D168A
			public bool IsNestMax
			{
				get
				{
					return (this._lock_word & (IntPtr)1020) == (IntPtr)1020;
				}
			}

			// Token: 0x06003ECD RID: 16077 RVA: 0x000D34A4 File Offset: 0x000D16A4
			public ObjectHeader.LockWord IncrementNest()
			{
				ObjectHeader.LockWord result;
				result._lock_word = this._lock_word + (IntPtr)4;
				return result;
			}

			// Token: 0x06003ECE RID: 16078 RVA: 0x000D34C4 File Offset: 0x000D16C4
			public ObjectHeader.LockWord DecrementNest()
			{
				ObjectHeader.LockWord result;
				result._lock_word = this._lock_word - (IntPtr)4;
				return result;
			}

			// Token: 0x06003ECF RID: 16079 RVA: 0x000D34E2 File Offset: 0x000D16E2
			public int GetOwner()
			{
				return (int)(this._lock_word >> 10);
			}

			// Token: 0x06003ED0 RID: 16080 RVA: 0x000D34F0 File Offset: 0x000D16F0
			public static ObjectHeader.LockWord NewFlat(int owner)
			{
				ObjectHeader.LockWord result;
				result._lock_word = (IntPtr)((UIntPtr)owner << 10);
				return result;
			}

			// Token: 0x06003ED1 RID: 16081 RVA: 0x000D350C File Offset: 0x000D170C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static ObjectHeader.LockWord FromObjectHeader(ref ObjectHeader.Header header)
			{
				ObjectHeader.LockWord result;
				result._lock_word = header.synchronization;
				return result;
			}

			// Token: 0x17000B88 RID: 2952
			// (get) Token: 0x06003ED2 RID: 16082 RVA: 0x000D3527 File Offset: 0x000D1727
			public IntPtr AsIntPtr
			{
				get
				{
					return this._lock_word;
				}
			}

			// Token: 0x04000CE1 RID: 3297
			private IntPtr _lock_word;
		}
	}
}
