using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000054 RID: 84
[NullableContext(1)]
[Nullable(0)]
public sealed class OrderedMap<[Nullable(2)] K, [Nullable(2)] V> : IReadOnlyCollection<KeyValuePair<K, V>>, IEnumerable<KeyValuePair<K, V>>, IEnumerable
{
	// Token: 0x06000265 RID: 613 RVA: 0x0000D3C7 File Offset: 0x0000B5C7
	public OrderedMap()
	{
	}

	// Token: 0x06000266 RID: 614 RVA: 0x0000D3F7 File Offset: 0x0000B5F7
	public OrderedMap(int capacity)
	{
		this.EnsureCapacity(capacity);
	}

	// Token: 0x06000267 RID: 615 RVA: 0x0000D42F File Offset: 0x0000B62F
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

	// Token: 0x06000268 RID: 616 RVA: 0x0000D468 File Offset: 0x0000B668
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

	// Token: 0x06000269 RID: 617 RVA: 0x0000D4C8 File Offset: 0x0000B6C8
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

	// Token: 0x0600026A RID: 618 RVA: 0x0000D599 File Offset: 0x0000B799
	private bool IsLeaseActive(long lease)
	{
		if (this.PrimaryLease != lease)
		{
			List<long> additionalLeases = this.AdditionalLeases;
			return additionalLeases != null && additionalLeases.LastIndexOf(lease) >= 0;
		}
		return true;
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x0600026B RID: 619 RVA: 0x0000D5BE File Offset: 0x0000B7BE
	public int Count
	{
		get
		{
			return this.Index.Count;
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x0600026C RID: 620 RVA: 0x0000D5CB File Offset: 0x0000B7CB
	public bool IsIterating
	{
		get
		{
			return this.IterateDepth > 0;
		}
	}

	// Token: 0x0600026D RID: 621 RVA: 0x0000D5D6 File Offset: 0x0000B7D6
	public void Set(K key, V value)
	{
		this.TryInsert(key, value, true);
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0000D5E2 File Offset: 0x0000B7E2
	public bool Add(K key, V value)
	{
		return this.TryInsert(key, value, false);
	}

	// Token: 0x0600026F RID: 623 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool TryInsert(K key, V value, bool overwrite)
	{
		if (this.ShouldCompact)
		{
			this.TryCompact();
		}
		int count = this.Entries.Count;
		OrderedMap<K, V>.IndexKey key2 = new OrderedMap<K, V>.IndexKey(key);
		int index;
		if ((count == this.Entries.Capacity || (this.FreeHandleHead < 0 && this.HandlePositions.Count == this.HandlePositions.Capacity)) && this.Index.TryGetValue(key2, out index))
		{
			if (overwrite)
			{
				CollectionsMarshal.AsSpan<OrderedMap<K, V>.Entry>(this.Entries)[this.HandlePositions[index]].Value = value;
			}
			return false;
		}
		this.PrepareEntryCapacity(count);
		bool flag;
		ref int valueRefOrAddDefault = ref CollectionsMarshal.GetValueRefOrAddDefault<OrderedMap<K, V>.IndexKey, int>(this.Index, key2, out flag);
		if (flag)
		{
			if (overwrite)
			{
				CollectionsMarshal.AsSpan<OrderedMap<K, V>.Entry>(this.Entries)[this.HandlePositions[valueRefOrAddDefault]].Value = value;
			}
			return false;
		}
		int num = this.AcquireHandle(count);
		this.Entries.Add(new OrderedMap<K, V>.Entry
		{
			Key = key,
			Value = value,
			Handle = num
		});
		valueRefOrAddDefault = num;
		return true;
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0000D70C File Offset: 0x0000B90C
	public bool Remove(K key)
	{
		int num;
		if (!this.Index.Remove(new OrderedMap<K, V>.IndexKey(key), out num))
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
		ref OrderedMap<K, V>.Entry ptr = ref CollectionsMarshal.AsSpan<OrderedMap<K, V>.Entry>(this.Entries)[num2];
		if (!ptr.Alive)
		{
			this.ThrowInvalidEntry(num2);
		}
		this.ReleaseHandle(num);
		ptr.Handle = -1;
		ptr.Key = default(K);
		ptr.Value = default(V);
		this.DeadCount++;
		if (this.ShouldCompact)
		{
			this.TryCompact();
		}
		return true;
	}

	// Token: 0x06000271 RID: 625 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
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
		Span<OrderedMap<K, V>.Entry> span = CollectionsMarshal.AsSpan<OrderedMap<K, V>.Entry>(this.Entries);
		for (int i = this.ClearScanStart; i < count; i++)
		{
			ref OrderedMap<K, V>.Entry ptr = ref span[i];
			if (ptr.Alive)
			{
				this.ReleaseHandle(ptr.Handle);
				ptr.Handle = -1;
				ptr.Key = default(K);
				ptr.Value = default(V);
			}
		}
		this.DeadCount = count;
		this.ClearScanStart = count;
		this.Index.Clear();
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0000D8AA File Offset: 0x0000BAAA
	public bool ContainsKey(K key)
	{
		return this.Index.ContainsKey(new OrderedMap<K, V>.IndexKey(key));
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
	public bool TryGetValue(K key, out V value)
	{
		int index;
		if (this.Index.TryGetValue(new OrderedMap<K, V>.IndexKey(key), out index))
		{
			value = CollectionsMarshal.AsSpan<OrderedMap<K, V>.Entry>(this.Entries)[this.HandlePositions[index]].Value;
			return true;
		}
		value = default(V);
		return false;
	}

	// Token: 0x17000052 RID: 82
	public V this[K key]
	{
		get
		{
			V result;
			if (!this.TryGetValue(key, out result))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("OrderedMap key 不存在: ");
				defaultInterpolatedStringHandler.AppendFormatted<K>(key);
				throw new KeyNotFoundException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return result;
		}
		set
		{
			this.Set(key, value);
		}
	}

	// Token: 0x06000276 RID: 630 RVA: 0x0000D968 File Offset: 0x0000BB68
	public void ForEach(Action<K, V> action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		this.IterateDepth++;
		try
		{
			List<OrderedMap<K, V>.Entry> entries = this.Entries;
			for (int i = 0; i < entries.Count; i++)
			{
				OrderedMap<K, V>.Entry entry = entries[i];
				if (entry.Alive)
				{
					action(entry.Key, entry.Value);
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

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000277 RID: 631 RVA: 0x0000DA00 File Offset: 0x0000BC00
	private bool ShouldCompact
	{
		get
		{
			return this.IterateDepth == 0 && this.DeadCount >= 8 && this.DeadCount * 2 >= this.Entries.Count;
		}
	}

	// Token: 0x06000278 RID: 632 RVA: 0x0000DA30 File Offset: 0x0000BC30
	private unsafe void Compact()
	{
		Span<OrderedMap<K, V>.Entry> span = CollectionsMarshal.AsSpan<OrderedMap<K, V>.Entry>(this.Entries);
		for (int i = 0; i < span.Length; i++)
		{
			ref OrderedMap<K, V>.Entry ptr = ref span[i];
			if (ptr.Alive && (ptr.Handle >= this.HandlePositions.Count || this.HandlePositions[ptr.Handle] != i))
			{
				this.ThrowInvalidEntry(i);
			}
		}
		int num = 0;
		for (int j = 0; j < span.Length; j++)
		{
			OrderedMap<K, V>.Entry entry = *span[j];
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

	// Token: 0x06000279 RID: 633 RVA: 0x0000DB2B File Offset: 0x0000BD2B
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void PrepareEntryCapacity(int position)
	{
		this.Entries.EnsureCapacity(position + 1);
		if (this.FreeHandleHead < 0)
		{
			this.HandlePositions.EnsureCapacity(this.HandlePositions.Count + 1);
		}
	}

	// Token: 0x0600027A RID: 634 RVA: 0x0000DB60 File Offset: 0x0000BD60
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

	// Token: 0x0600027B RID: 635 RVA: 0x0000DBBA File Offset: 0x0000BDBA
	private void ReleaseHandle(int handle)
	{
		this.HandlePositions[handle] = -this.FreeHandleHead - 2;
		this.FreeHandleHead = handle;
	}

	// Token: 0x0600027C RID: 636 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
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

	// Token: 0x0600027D RID: 637 RVA: 0x0000DC00 File Offset: 0x0000BE00
	[NullableContext(0)]
	public OrderedMap<K, V>.Enumerator GetEnumerator()
	{
		return new OrderedMap<K, V>.Enumerator(this);
	}

	// Token: 0x0600027E RID: 638 RVA: 0x0000DC08 File Offset: 0x0000BE08
	[return: Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	IEnumerator<KeyValuePair<K, V>> IEnumerable<KeyValuePair<!0, !1>>.GetEnumerator()
	{
		return new OrderedMap<K, V>.Enumerator(this);
	}

	// Token: 0x0600027F RID: 639 RVA: 0x0000DC15 File Offset: 0x0000BE15
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new OrderedMap<K, V>.Enumerator(this);
	}

	// Token: 0x06000280 RID: 640 RVA: 0x0000DC22 File Offset: 0x0000BE22
	[Conditional("UE_BUILD_DEBUG")]
	[Conditional("UE_BUILD_DEVELOPMENT")]
	[Conditional("UE_BUILD_TEST")]
	private void LogInvariantViolation(string reason, int position)
	{
	}

	// Token: 0x06000281 RID: 641 RVA: 0x0000DC24 File Offset: 0x0000BE24
	[DoesNotReturn]
	private void ThrowInvalidEntry(int position)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 3);
		defaultInterpolatedStringHandler.AppendLiteral("OrderedMap 索引与顺序存储不一致: position=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(position);
		defaultInterpolatedStringHandler.AppendLiteral(", entries=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.Entries.Count);
		defaultInterpolatedStringHandler.AppendLiteral(", count=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.Index.Count);
		throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x06000282 RID: 642 RVA: 0x0000DC97 File Offset: 0x0000BE97
	[Conditional("UE_BUILD_DEBUG")]
	[Conditional("UE_BUILD_DEVELOPMENT")]
	[Conditional("UE_BUILD_TEST")]
	private void LogCompactionFailure(Exception exception)
	{
	}

	// Token: 0x040001DC RID: 476
	[Nullable(new byte[]
	{
		1,
		0,
		0,
		0
	})]
	private List<OrderedMap<K, V>.Entry> Entries = new List<OrderedMap<K, V>.Entry>();

	// Token: 0x040001DD RID: 477
	[Nullable(new byte[]
	{
		1,
		0,
		0,
		0
	})]
	private readonly Dictionary<OrderedMap<K, V>.IndexKey, int> Index = new Dictionary<OrderedMap<K, V>.IndexKey, int>();

	// Token: 0x040001DE RID: 478
	private readonly List<int> HandlePositions = new List<int>();

	// Token: 0x040001DF RID: 479
	private int FreeHandleHead = -1;

	// Token: 0x040001E0 RID: 480
	private int DeadCount;

	// Token: 0x040001E1 RID: 481
	private int ClearScanStart;

	// Token: 0x040001E2 RID: 482
	private int IterateDepth;

	// Token: 0x040001E3 RID: 483
	private long PrimaryLease;

	// Token: 0x040001E4 RID: 484
	[Nullable(2)]
	private List<long> AdditionalLeases;

	// Token: 0x040001E5 RID: 485
	private long LeaseCounter;

	// Token: 0x0200019B RID: 411
	[Nullable(0)]
	private struct Entry
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0003DF26 File Offset: 0x0003C126
		public readonly bool Alive
		{
			get
			{
				return this.Handle >= 0;
			}
		}

		// Token: 0x040007C8 RID: 1992
		public K Key;

		// Token: 0x040007C9 RID: 1993
		public V Value;

		// Token: 0x040007CA RID: 1994
		public int Handle;
	}

	// Token: 0x0200019C RID: 412
	[NullableContext(0)]
	private readonly struct IndexKey : IEquatable<OrderedMap<K, V>.IndexKey>
	{
		// Token: 0x06000D41 RID: 3393 RVA: 0x0003DF34 File Offset: 0x0003C134
		[NullableContext(1)]
		public IndexKey(K key)
		{
			this.Key = key;
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0003DF3D File Offset: 0x0003C13D
		public bool Equals(OrderedMap<K, V>.IndexKey other)
		{
			return EqualityComparer<K>.Default.Equals(this.Key, other.Key);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0003DF58 File Offset: 0x0003C158
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is OrderedMap<K, V>.IndexKey)
			{
				OrderedMap<K, V>.IndexKey other = (OrderedMap<K, V>.IndexKey)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x0003DF7D File Offset: 0x0003C17D
		public override int GetHashCode()
		{
			if (this.Key != null)
			{
				return EqualityComparer<K>.Default.GetHashCode(this.Key);
			}
			return 0;
		}

		// Token: 0x040007CB RID: 1995
		[Nullable(1)]
		public readonly K Key;
	}

	// Token: 0x0200019D RID: 413
	[NullableContext(0)]
	public struct Enumerator : IEnumerator<KeyValuePair<K, V>>, IEnumerator, IDisposable
	{
		// Token: 0x06000D45 RID: 3397 RVA: 0x0003DF9E File Offset: 0x0003C19E
		[NullableContext(1)]
		internal Enumerator(OrderedMap<K, V> owner)
		{
			this.Owner = owner;
			this.Lease = owner.AcquireLease();
			this.IndexPos = -1;
			this.Done = false;
			this.Exhausted = false;
			this.HasCurrent = false;
			this.CurrentPair = default(KeyValuePair<K, V>);
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x0003DFDB File Offset: 0x0003C1DB
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public readonly KeyValuePair<K, V> Current
		{
			[return: Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			get
			{
				if (this.Done || !this.Owner.IsLeaseActive(this.Lease) || this.Exhausted || !this.HasCurrent)
				{
					throw new InvalidOperationException("枚举器不在有效位置（未开始/已结束/已释放）");
				}
				return this.CurrentPair;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0003E019 File Offset: 0x0003C219
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		KeyValuePair<K, V> IEnumerator<KeyValuePair<!0, !1>>.Current
		{
			[return: Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			get
			{
				return this.Current;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x0003E021 File Offset: 0x0003C221
		[Nullable(2)]
		object IEnumerator.Current
		{
			[NullableContext(2)]
			get
			{
				return this.Current;
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0003E030 File Offset: 0x0003C230
		public bool MoveNext()
		{
			this.HasCurrent = false;
			this.CurrentPair = default(KeyValuePair<K, V>);
			if (this.Done || !this.Owner.IsLeaseActive(this.Lease) || this.Exhausted)
			{
				return false;
			}
			List<OrderedMap<K, V>.Entry> entries = this.Owner.Entries;
			while (this.IndexPos < entries.Count - 1)
			{
				this.IndexPos++;
				OrderedMap<K, V>.Entry entry = entries[this.IndexPos];
				if (entry.Alive)
				{
					this.CurrentPair = new KeyValuePair<K, V>(entry.Key, entry.Value);
					this.HasCurrent = true;
					return true;
				}
			}
			this.Exhausted = true;
			return false;
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0003E0DD File Offset: 0x0003C2DD
		public void Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0003E0E4 File Offset: 0x0003C2E4
		public void Dispose()
		{
			if (this.Done)
			{
				return;
			}
			this.Done = true;
			this.HasCurrent = false;
			this.CurrentPair = default(KeyValuePair<K, V>);
			this.Owner.ReleaseLease(this.Lease);
		}

		// Token: 0x040007CC RID: 1996
		[Nullable(1)]
		private readonly OrderedMap<K, V> Owner;

		// Token: 0x040007CD RID: 1997
		private readonly long Lease;

		// Token: 0x040007CE RID: 1998
		private int IndexPos;

		// Token: 0x040007CF RID: 1999
		private bool Done;

		// Token: 0x040007D0 RID: 2000
		private bool Exhausted;

		// Token: 0x040007D1 RID: 2001
		private bool HasCurrent;

		// Token: 0x040007D2 RID: 2002
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private KeyValuePair<K, V> CurrentPair;
	}
}
