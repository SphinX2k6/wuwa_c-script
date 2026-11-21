using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000055 RID: 85
[NullableContext(1)]
[Nullable(0)]
public sealed class OrderedSet<[Nullable(2)] T> : ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	// Token: 0x06000283 RID: 643 RVA: 0x0000DC99 File Offset: 0x0000BE99
	public OrderedSet()
	{
	}

	// Token: 0x06000284 RID: 644 RVA: 0x0000DCC9 File Offset: 0x0000BEC9
	public OrderedSet(int capacity)
	{
		this.EnsureCapacity(capacity);
	}

	// Token: 0x06000285 RID: 645 RVA: 0x0000DD01 File Offset: 0x0000BF01
	public int EnsureCapacity(int capacity)
	{
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity");
		}
		this.Index.EnsureCapacity(capacity);
		this.HandlePositions.EnsureCapacity(capacity);
		return this.Entries.EnsureCapacity(capacity);
	}

	// Token: 0x06000286 RID: 646 RVA: 0x0000DD38 File Offset: 0x0000BF38
	private long AcquireLease()
	{
		long num = this.LeaseCounter + 1L;
		this.LeaseCounter = num;
		long num2 = num;
		if (this.PrimaryLease == 0L)
		{
			this.PrimaryLease = num2;
		}
		else
		{
			List<long> list;
			if ((list = this.AdditionalLeases) == null)
			{
				list = (this.AdditionalLeases = new List<long>());
			}
			list.Add(num2);
		}
		this.IterateDepth++;
		return num2;
	}

	// Token: 0x06000287 RID: 647 RVA: 0x0000DD98 File Offset: 0x0000BF98
	private bool ReleaseLease(long lease)
	{
		if (this.PrimaryLease == lease)
		{
			List<long> additionalLeases = this.AdditionalLeases;
			int num = ((additionalLeases != null) ? additionalLeases.Count : 0) - 1;
			if (num >= 0)
			{
				this.PrimaryLease = this.AdditionalLeases[num];
				this.AdditionalLeases.RemoveAt(num);
			}
			else
			{
				this.PrimaryLease = 0L;
			}
		}
		else
		{
			List<long> additionalLeases2 = this.AdditionalLeases;
			int num2 = ((additionalLeases2 != null) ? additionalLeases2.Count : 0) - 1;
			int num3 = (num2 >= 0) ? this.AdditionalLeases.LastIndexOf(lease) : -1;
			if (num3 < 0)
			{
				return false;
			}
			this.AdditionalLeases[num3] = this.AdditionalLeases[num2];
			this.AdditionalLeases.RemoveAt(num2);
		}
		this.IterateDepth--;
		if (this.IterateDepth == 0 && this.ShouldCompact)
		{
			this.TryCompact();
		}
		return true;
	}

	// Token: 0x06000288 RID: 648 RVA: 0x0000DE69 File Offset: 0x0000C069
	private bool IsLeaseActive(long lease)
	{
		if (this.PrimaryLease != lease)
		{
			List<long> additionalLeases = this.AdditionalLeases;
			return additionalLeases != null && additionalLeases.LastIndexOf(lease) >= 0;
		}
		return true;
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000289 RID: 649 RVA: 0x0000DE8E File Offset: 0x0000C08E
	public int Count
	{
		get
		{
			return this.Index.Count;
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600028A RID: 650 RVA: 0x0000DE9B File Offset: 0x0000C09B
	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600028B RID: 651 RVA: 0x0000DE9E File Offset: 0x0000C09E
	public bool IsIterating
	{
		get
		{
			return this.IterateDepth > 0;
		}
	}

	// Token: 0x0600028C RID: 652 RVA: 0x0000DEAC File Offset: 0x0000C0AC
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Add(T item)
	{
		if (this.ShouldCompact)
		{
			this.TryCompact();
		}
		int count = this.Entries.Count;
		OrderedSet<T>.IndexKey key = new OrderedSet<T>.IndexKey(item);
		if ((count == this.Entries.Capacity || (this.FreeHandleHead < 0 && this.HandlePositions.Count == this.HandlePositions.Capacity)) && this.Index.ContainsKey(key))
		{
			return false;
		}
		this.PrepareEntryCapacity(count);
		bool flag;
		ref int valueRefOrAddDefault = ref CollectionsMarshal.GetValueRefOrAddDefault<OrderedSet<T>.IndexKey, int>(this.Index, key, out flag);
		if (flag)
		{
			return false;
		}
		int num = this.AcquireHandle(count);
		this.Entries.Add(new OrderedSet<T>.Entry
		{
			Item = item,
			Handle = num
		});
		valueRefOrAddDefault = num;
		return true;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0000DF69 File Offset: 0x0000C169
	void ICollection<!0>.Add(T item)
	{
		this.Add(item);
	}

	// Token: 0x0600028E RID: 654 RVA: 0x0000DF74 File Offset: 0x0000C174
	public bool Remove(T item)
	{
		int num;
		if (!this.Index.Remove(new OrderedSet<T>.IndexKey(item), out num))
		{
			return false;
		}
		if (num >= this.HandlePositions.Count)
		{
			this.ThrowInvalidEntry(-1);
		}
		int num2 = this.HandlePositions[num];
		if (num2 >= this.Entries.Count || this.Entries[num2].Handle != num)
		{
			this.ThrowInvalidEntry(num2);
		}
		ref OrderedSet<T>.Entry ptr = ref CollectionsMarshal.AsSpan<OrderedSet<T>.Entry>(this.Entries)[num2];
		if (!ptr.Alive)
		{
			this.ThrowInvalidEntry(num2);
		}
		this.ReleaseHandle(num);
		ptr.Handle = -1;
		ptr.Item = default(T);
		this.DeadCount++;
		if (this.ShouldCompact)
		{
			this.TryCompact();
		}
		return true;
	}

	// Token: 0x0600028F RID: 655 RVA: 0x0000E03C File Offset: 0x0000C23C
	public void Clear()
	{
		if (this.IterateDepth == 0)
		{
			this.Entries.Clear();
			this.Index.Clear();
			this.HandlePositions.Clear();
			this.FreeHandleHead = -1;
			this.DeadCount = 0;
			this.ClearScanStart = 0;
			return;
		}
		int count = this.Entries.Count;
		Span<OrderedSet<T>.Entry> span = CollectionsMarshal.AsSpan<OrderedSet<T>.Entry>(this.Entries);
		for (int i = this.ClearScanStart; i < count; i++)
		{
			ref OrderedSet<T>.Entry ptr = ref span[i];
			if (ptr.Alive)
			{
				this.ReleaseHandle(ptr.Handle);
				ptr.Handle = -1;
				ptr.Item = default(T);
			}
		}
		this.DeadCount = count;
		this.ClearScanStart = count;
		this.Index.Clear();
	}

	// Token: 0x06000290 RID: 656 RVA: 0x0000E0FA File Offset: 0x0000C2FA
	public bool Contains(T item)
	{
		return this.Index.ContainsKey(new OrderedSet<T>.IndexKey(item));
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0000E110 File Offset: 0x0000C310
	public void CopyTo(T[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0 || arrayIndex > array.Length)
		{
			throw new ArgumentOutOfRangeException("arrayIndex");
		}
		if (array.Length - arrayIndex < this.Count)
		{
			throw new ArgumentException("目标数组空间不足", "array");
		}
		Span<OrderedSet<T>.Entry> span = CollectionsMarshal.AsSpan<OrderedSet<T>.Entry>(this.Entries);
		for (int i = 0; i < span.Length; i++)
		{
			ref OrderedSet<T>.Entry ptr = ref span[i];
			if (ptr.Alive)
			{
				array[arrayIndex++] = ptr.Item;
			}
		}
	}

	// Token: 0x06000292 RID: 658 RVA: 0x0000E1A0 File Offset: 0x0000C3A0
	public void ForEach(Action<T> action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		this.IterateDepth++;
		try
		{
			List<OrderedSet<T>.Entry> entries = this.Entries;
			for (int i = 0; i < entries.Count; i++)
			{
				OrderedSet<T>.Entry entry = entries[i];
				if (entry.Alive)
				{
					action(entry.Item);
				}
			}
		}
		finally
		{
			int num = this.IterateDepth - 1;
			this.IterateDepth = num;
			if (num == 0 && this.ShouldCompact)
			{
				this.TryCompact();
			}
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000293 RID: 659 RVA: 0x0000E234 File Offset: 0x0000C434
	private bool ShouldCompact
	{
		get
		{
			return this.IterateDepth == 0 && this.DeadCount >= 8 && this.DeadCount * 2 >= this.Entries.Count;
		}
	}

	// Token: 0x06000294 RID: 660 RVA: 0x0000E264 File Offset: 0x0000C464
	private unsafe void Compact()
	{
		Span<OrderedSet<T>.Entry> span = CollectionsMarshal.AsSpan<OrderedSet<T>.Entry>(this.Entries);
		for (int i = 0; i < span.Length; i++)
		{
			ref OrderedSet<T>.Entry ptr = ref span[i];
			if (ptr.Alive && (ptr.Handle >= this.HandlePositions.Count || this.HandlePositions[ptr.Handle] != i))
			{
				this.ThrowInvalidEntry(i);
			}
		}
		int num = 0;
		for (int j = 0; j < span.Length; j++)
		{
			OrderedSet<T>.Entry entry = *span[j];
			if (entry.Alive)
			{
				if (num != j)
				{
					*span[num] = entry;
				}
				this.HandlePositions[entry.Handle] = num++;
			}
		}
		if (num < this.Entries.Count)
		{
			this.Entries.RemoveRange(num, this.Entries.Count - num);
		}
		this.DeadCount = 0;
		this.ClearScanStart = 0;
	}

	// Token: 0x06000295 RID: 661 RVA: 0x0000E35F File Offset: 0x0000C55F
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void PrepareEntryCapacity(int position)
	{
		this.Entries.EnsureCapacity(position + 1);
		if (this.FreeHandleHead < 0)
		{
			this.HandlePositions.EnsureCapacity(this.HandlePositions.Count + 1);
		}
	}

	// Token: 0x06000296 RID: 662 RVA: 0x0000E394 File Offset: 0x0000C594
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private int AcquireHandle(int position)
	{
		if (this.FreeHandleHead >= 0)
		{
			int freeHandleHead = this.FreeHandleHead;
			this.FreeHandleHead = -this.HandlePositions[freeHandleHead] - 2;
			this.HandlePositions[freeHandleHead] = position;
			return freeHandleHead;
		}
		this.HandlePositions.Add(position);
		return this.HandlePositions.Count - 1;
	}

	// Token: 0x06000297 RID: 663 RVA: 0x0000E3EE File Offset: 0x0000C5EE
	private void ReleaseHandle(int handle)
	{
		this.HandlePositions[handle] = -this.FreeHandleHead - 2;
		this.FreeHandleHead = handle;
	}

	// Token: 0x06000298 RID: 664 RVA: 0x0000E40C File Offset: 0x0000C60C
	private void TryCompact()
	{
		try
		{
			this.Compact();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000299 RID: 665 RVA: 0x0000E434 File Offset: 0x0000C634
	[NullableContext(0)]
	public OrderedSet<T>.Enumerator GetEnumerator()
	{
		return new OrderedSet<T>.Enumerator(this);
	}

	// Token: 0x0600029A RID: 666 RVA: 0x0000E43C File Offset: 0x0000C63C
	IEnumerator<T> IEnumerable<!0>.GetEnumerator()
	{
		return new OrderedSet<T>.Enumerator(this);
	}

	// Token: 0x0600029B RID: 667 RVA: 0x0000E449 File Offset: 0x0000C649
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new OrderedSet<T>.Enumerator(this);
	}

	// Token: 0x0600029C RID: 668 RVA: 0x0000E456 File Offset: 0x0000C656
	[Conditional("UE_BUILD_DEBUG")]
	[Conditional("UE_BUILD_DEVELOPMENT")]
	[Conditional("UE_BUILD_TEST")]
	private void LogInvariantViolation(string reason, int position)
	{
	}

	// Token: 0x0600029D RID: 669 RVA: 0x0000E458 File Offset: 0x0000C658
	[DoesNotReturn]
	private void ThrowInvalidEntry(int position)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 3);
		defaultInterpolatedStringHandler.AppendLiteral("OrderedSet 索引与顺序存储不一致: position=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(position);
		defaultInterpolatedStringHandler.AppendLiteral(", entries=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.Entries.Count);
		defaultInterpolatedStringHandler.AppendLiteral(", count=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.Index.Count);
		throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x0600029E RID: 670 RVA: 0x0000E4CB File Offset: 0x0000C6CB
	[Conditional("UE_BUILD_DEBUG")]
	[Conditional("UE_BUILD_DEVELOPMENT")]
	[Conditional("UE_BUILD_TEST")]
	private void LogCompactionFailure(Exception exception)
	{
	}

	// Token: 0x040001E6 RID: 486
	[Nullable(new byte[]
	{
		1,
		0,
		0
	})]
	private List<OrderedSet<T>.Entry> Entries = new List<OrderedSet<T>.Entry>();

	// Token: 0x040001E7 RID: 487
	[Nullable(new byte[]
	{
		1,
		0,
		0
	})]
	private readonly Dictionary<OrderedSet<T>.IndexKey, int> Index = new Dictionary<OrderedSet<T>.IndexKey, int>();

	// Token: 0x040001E8 RID: 488
	private readonly List<int> HandlePositions = new List<int>();

	// Token: 0x040001E9 RID: 489
	private int FreeHandleHead = -1;

	// Token: 0x040001EA RID: 490
	private int DeadCount;

	// Token: 0x040001EB RID: 491
	private int ClearScanStart;

	// Token: 0x040001EC RID: 492
	private int IterateDepth;

	// Token: 0x040001ED RID: 493
	private long PrimaryLease;

	// Token: 0x040001EE RID: 494
	[Nullable(2)]
	private List<long> AdditionalLeases;

	// Token: 0x040001EF RID: 495
	private long LeaseCounter;

	// Token: 0x0200019E RID: 414
	[NullableContext(0)]
	private struct Entry
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x0003E11B File Offset: 0x0003C31B
		public readonly bool Alive
		{
			get
			{
				return this.Handle >= 0;
			}
		}

		// Token: 0x040007D3 RID: 2003
		[Nullable(1)]
		public T Item;

		// Token: 0x040007D4 RID: 2004
		public int Handle;
	}

	// Token: 0x0200019F RID: 415
	[NullableContext(0)]
	private readonly struct IndexKey : IEquatable<OrderedSet<T>.IndexKey>
	{
		// Token: 0x06000D4D RID: 3405 RVA: 0x0003E129 File Offset: 0x0003C329
		[NullableContext(1)]
		public IndexKey(T item)
		{
			this.Item = item;
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x0003E132 File Offset: 0x0003C332
		public bool Equals(OrderedSet<T>.IndexKey other)
		{
			return EqualityComparer<T>.Default.Equals(this.Item, other.Item);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0003E14C File Offset: 0x0003C34C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is OrderedSet<T>.IndexKey)
			{
				OrderedSet<T>.IndexKey other = (OrderedSet<T>.IndexKey)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0003E171 File Offset: 0x0003C371
		public override int GetHashCode()
		{
			if (this.Item != null)
			{
				return EqualityComparer<T>.Default.GetHashCode(this.Item);
			}
			return 0;
		}

		// Token: 0x040007D5 RID: 2005
		[Nullable(1)]
		public readonly T Item;
	}

	// Token: 0x020001A0 RID: 416
	[Nullable(0)]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		// Token: 0x06000D51 RID: 3409 RVA: 0x0003E192 File Offset: 0x0003C392
		internal Enumerator(OrderedSet<T> owner)
		{
			this.Owner = owner;
			this.Lease = owner.AcquireLease();
			this.IndexPos = -1;
			this.Done = false;
			this.Exhausted = false;
			this.HasCurrent = false;
			this.CurrentItem = default(T);
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x0003E1CF File Offset: 0x0003C3CF
		public readonly T Current
		{
			get
			{
				if (this.Done || !this.Owner.IsLeaseActive(this.Lease) || this.Exhausted || !this.HasCurrent)
				{
					throw new InvalidOperationException("枚举器不在有效位置（未开始/已结束/已释放）");
				}
				return this.CurrentItem;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x0003E20D File Offset: 0x0003C40D
		T IEnumerator<!0>.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x0003E215 File Offset: 0x0003C415
		[Nullable(2)]
		object IEnumerator.Current
		{
			[NullableContext(2)]
			get
			{
				return this.Current;
			}
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0003E224 File Offset: 0x0003C424
		public bool MoveNext()
		{
			this.HasCurrent = false;
			this.CurrentItem = default(T);
			if (this.Done || !this.Owner.IsLeaseActive(this.Lease) || this.Exhausted)
			{
				return false;
			}
			List<OrderedSet<T>.Entry> entries = this.Owner.Entries;
			while (this.IndexPos < entries.Count - 1)
			{
				this.IndexPos++;
				OrderedSet<T>.Entry entry = entries[this.IndexPos];
				if (entry.Alive)
				{
					this.CurrentItem = entry.Item;
					this.HasCurrent = true;
					return true;
				}
			}
			this.Exhausted = true;
			return false;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0003E2C6 File Offset: 0x0003C4C6
		public void Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0003E2CD File Offset: 0x0003C4CD
		public void Dispose()
		{
			if (this.Done)
			{
				return;
			}
			this.Done = true;
			this.HasCurrent = false;
			this.CurrentItem = default(T);
			this.Owner.ReleaseLease(this.Lease);
		}

		// Token: 0x040007D6 RID: 2006
		private readonly OrderedSet<T> Owner;

		// Token: 0x040007D7 RID: 2007
		private readonly long Lease;

		// Token: 0x040007D8 RID: 2008
		private int IndexPos;

		// Token: 0x040007D9 RID: 2009
		private bool Done;

		// Token: 0x040007DA RID: 2010
		private bool Exhausted;

		// Token: 0x040007DB RID: 2011
		private bool HasCurrent;

		// Token: 0x040007DC RID: 2012
		private T CurrentItem;
	}
}
