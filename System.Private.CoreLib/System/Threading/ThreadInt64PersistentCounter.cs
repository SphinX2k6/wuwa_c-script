using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x0200041B RID: 1051
	internal sealed class ThreadInt64PersistentCounter
	{
		// Token: 0x060041A1 RID: 16801 RVA: 0x000DAE58 File Offset: 0x000D9058
		public ThreadInt64PersistentCounter()
		{
			this._nodes = new ThreadInt64PersistentCounter.ThreadLocalNode(this);
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x000DAE77 File Offset: 0x000D9077
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Increment(object threadLocalCountObject)
		{
			Unsafe.As<ThreadInt64PersistentCounter.ThreadLocalNode>(threadLocalCountObject).Increment();
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x000DAE84 File Offset: 0x000D9084
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Decrement(object threadLocalCountObject)
		{
			Unsafe.As<ThreadInt64PersistentCounter.ThreadLocalNode>(threadLocalCountObject).Decrement();
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x000DAE91 File Offset: 0x000D9091
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Add(object threadLocalCountObject, uint count)
		{
			Unsafe.As<ThreadInt64PersistentCounter.ThreadLocalNode>(threadLocalCountObject).Add(count);
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x000DAEA0 File Offset: 0x000D90A0
		public object CreateThreadLocalCountObject()
		{
			ThreadInt64PersistentCounter.ThreadLocalNode threadLocalNode = new ThreadInt64PersistentCounter.ThreadLocalNode(this);
			List<ThreadInt64PersistentCounter.ThreadLocalNodeFinalizationHelper> list;
			if ((list = ThreadInt64PersistentCounter.t_nodeFinalizationHelpers) == null)
			{
				list = (ThreadInt64PersistentCounter.t_nodeFinalizationHelpers = new List<ThreadInt64PersistentCounter.ThreadLocalNodeFinalizationHelper>(1));
			}
			list.Add(new ThreadInt64PersistentCounter.ThreadLocalNodeFinalizationHelper(threadLocalNode));
			this._lock.Acquire();
			try
			{
				threadLocalNode._next = this._nodes._next;
				threadLocalNode._prev = this._nodes;
				this._nodes._next._prev = threadLocalNode;
				this._nodes._next = threadLocalNode;
			}
			finally
			{
				this._lock.Release();
			}
			return threadLocalNode;
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060041A6 RID: 16806 RVA: 0x000DAF38 File Offset: 0x000D9138
		public long Count
		{
			get
			{
				this._lock.Acquire();
				long num = this._overflowCount;
				try
				{
					ThreadInt64PersistentCounter.ThreadLocalNode nodes = this._nodes;
					for (ThreadInt64PersistentCounter.ThreadLocalNode next = nodes._next; next != nodes; next = next._next)
					{
						num += (long)((ulong)next.Count);
					}
					long lastReturnedCount = this._lastReturnedCount;
					if (num > lastReturnedCount)
					{
						this._lastReturnedCount = num;
					}
					else
					{
						num = lastReturnedCount;
					}
				}
				finally
				{
					this._lock.Release();
				}
				return num;
			}
		}

		// Token: 0x04000DF6 RID: 3574
		private readonly LowLevelLock _lock = new LowLevelLock();

		// Token: 0x04000DF7 RID: 3575
		[ThreadStatic]
		private static List<ThreadInt64PersistentCounter.ThreadLocalNodeFinalizationHelper> t_nodeFinalizationHelpers;

		// Token: 0x04000DF8 RID: 3576
		private long _overflowCount;

		// Token: 0x04000DF9 RID: 3577
		private long _lastReturnedCount;

		// Token: 0x04000DFA RID: 3578
		private readonly ThreadInt64PersistentCounter.ThreadLocalNode _nodes;

		// Token: 0x0200041C RID: 1052
		private sealed class ThreadLocalNode
		{
			// Token: 0x060041A7 RID: 16807 RVA: 0x000DAFB4 File Offset: 0x000D91B4
			public ThreadLocalNode(ThreadInt64PersistentCounter counter)
			{
				this._counter = counter;
				this._prev = this;
				this._next = this;
			}

			// Token: 0x060041A8 RID: 16808 RVA: 0x000DAFD4 File Offset: 0x000D91D4
			public void Dispose()
			{
				ThreadInt64PersistentCounter counter = this._counter;
				counter._lock.Acquire();
				try
				{
					counter._overflowCount += (long)((ulong)this._count);
					this._prev._next = this._next;
					this._next._prev = this._prev;
				}
				finally
				{
					counter._lock.Release();
				}
			}

			// Token: 0x17000BE1 RID: 3041
			// (get) Token: 0x060041A9 RID: 16809 RVA: 0x000DB048 File Offset: 0x000D9248
			public uint Count
			{
				get
				{
					return this._count;
				}
			}

			// Token: 0x060041AA RID: 16810 RVA: 0x000DB050 File Offset: 0x000D9250
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Increment()
			{
				uint num = this._count + 1U;
				if (num != 0U)
				{
					this._count = num;
					return;
				}
				this.OnAddOverflow(1L);
			}

			// Token: 0x060041AB RID: 16811 RVA: 0x000DB079 File Offset: 0x000D9279
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Decrement()
			{
				if (this._count != 0U)
				{
					this._count -= 1U;
					return;
				}
				this.OnAddOverflow(-1L);
			}

			// Token: 0x060041AC RID: 16812 RVA: 0x000DB09C File Offset: 0x000D929C
			public void Add(uint count)
			{
				uint num = this._count + count;
				if (num >= count)
				{
					this._count = num;
					return;
				}
				this.OnAddOverflow((long)((ulong)count));
			}

			// Token: 0x060041AD RID: 16813 RVA: 0x000DB0C8 File Offset: 0x000D92C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void OnAddOverflow(long count)
			{
				ThreadInt64PersistentCounter counter = this._counter;
				counter._lock.Acquire();
				try
				{
					counter._overflowCount += (long)((ulong)this._count + (ulong)count);
					this._count = 0U;
				}
				finally
				{
					counter._lock.Release();
				}
			}

			// Token: 0x04000DFB RID: 3579
			private uint _count;

			// Token: 0x04000DFC RID: 3580
			private readonly ThreadInt64PersistentCounter _counter;

			// Token: 0x04000DFD RID: 3581
			internal ThreadInt64PersistentCounter.ThreadLocalNode _prev;

			// Token: 0x04000DFE RID: 3582
			internal ThreadInt64PersistentCounter.ThreadLocalNode _next;
		}

		// Token: 0x0200041D RID: 1053
		private sealed class ThreadLocalNodeFinalizationHelper
		{
			// Token: 0x060041AE RID: 16814 RVA: 0x000DB124 File Offset: 0x000D9324
			public ThreadLocalNodeFinalizationHelper(ThreadInt64PersistentCounter.ThreadLocalNode node)
			{
				this._node = node;
			}

			// Token: 0x060041AF RID: 16815 RVA: 0x000DB134 File Offset: 0x000D9334
			~ThreadLocalNodeFinalizationHelper()
			{
				this._node.Dispose();
			}

			// Token: 0x04000DFF RID: 3583
			private readonly ThreadInt64PersistentCounter.ThreadLocalNode _node;
		}
	}
}
