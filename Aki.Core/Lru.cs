using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000053 RID: 83
[NullableContext(1)]
[Nullable(0)]
public class Lru<TK, TV> where TV : class
{
	// Token: 0x06000252 RID: 594 RVA: 0x0000CFA4 File Offset: 0x0000B1A4
	public Lru(int capacity, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Func<TK, TV> creator = null, [Nullable(new byte[]
	{
		2,
		1
	})] Action<TV> clearer = null)
	{
		this.Creator = creator;
		this.Clearer = clearer;
		if (this.Creator == null)
		{
			Log.Instance.Error(ELogModule.Core, ELogAuthor.LCC, "创建器不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (capacity < 2)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "容量必须大于 1";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("capacity", capacity);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.CapacityInternal = capacity;
		this.DecayRate = 1f - 1f / (float)capacity;
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000253 RID: 595 RVA: 0x0000D04F File Offset: 0x0000B24F
	// (set) Token: 0x06000254 RID: 596 RVA: 0x0000D057 File Offset: 0x0000B257
	public bool Enable
	{
		get
		{
			return this.EnableInternal;
		}
		set
		{
			if (this.EnableInternal != value)
			{
				this.Clear();
			}
			this.EnableInternal = value;
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06000255 RID: 597 RVA: 0x0000D06F File Offset: 0x0000B26F
	public int Size
	{
		get
		{
			return this.SizeInternal;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06000256 RID: 598 RVA: 0x0000D077 File Offset: 0x0000B277
	// (set) Token: 0x06000257 RID: 599 RVA: 0x0000D080 File Offset: 0x0000B280
	public int Capacity
	{
		get
		{
			return this.CapacityInternal;
		}
		set
		{
			if (value < 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Core;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "容量必须大于 1";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("capacity", value);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.HitCount = this.HitCount / (float)this.CapacityInternal * (float)value;
			this.MissCount = this.MissCount / (float)this.CapacityInternal * (float)value;
			this.CapacityInternal = value;
			this.DecayRate = 1f - 1f / (float)value;
			while (this.SizeInternal > value)
			{
				this.RemoveTail();
			}
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000258 RID: 600 RVA: 0x0000D116 File Offset: 0x0000B316
	public float HitRate
	{
		get
		{
			if (this.HitCount <= 0f)
			{
				return 0f;
			}
			return this.HitCount / (this.HitCount + this.MissCount);
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000259 RID: 601 RVA: 0x0000D13F File Offset: 0x0000B33F
	public float UsedAvg
	{
		get
		{
			if (this.SizeInternal <= 0)
			{
				return 0f;
			}
			return (float)this.UsedCount / (float)this.SizeInternal;
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x0600025A RID: 602 RVA: 0x0000D15F File Offset: 0x0000B35F
	public float ThresholdUsedRate
	{
		get
		{
			if (this.SizeInternal <= 0)
			{
				return 0f;
			}
			return (float)this.ThresholdUsedCount / (float)this.SizeInternal;
		}
	}

	// Token: 0x0600025B RID: 603 RVA: 0x0000D180 File Offset: 0x0000B380
	[return: Nullable(2)]
	public TV Create(TK key)
	{
		if (this.Creator == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "创建器不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return default(TV);
		}
		TV tv = this.Creator(key);
		if (tv == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Core;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "创建器创建对象为空";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("key", key);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return default(TV);
		}
		LruNode<TK, TV> value = new LruNode<TK, TV>(key, tv);
		this.Cache.Set(tv, value);
		return tv;
	}

	// Token: 0x0600025C RID: 604 RVA: 0x0000D22C File Offset: 0x0000B42C
	[return: Nullable(2)]
	public TV Get(TK key)
	{
		if (!this.EnableInternal || !LruConstants.IsLruEnabledGlobal)
		{
			return default(TV);
		}
		HashSet<LruNode<TK, TV>> hashSet;
		if (!this.Table.TryGetValue(key, out hashSet))
		{
			return default(TV);
		}
		LruNode<TK, TV> lruNode = null;
		using (HashSet<LruNode<TK, TV>>.Enumerator enumerator = hashSet.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				lruNode = enumerator.Current;
			}
		}
		if (lruNode == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "存在键对应的节点集合，但集合为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.HitCount *= this.DecayRate;
			this.MissCount = this.MissCount * this.DecayRate + 1f;
			return default(TV);
		}
		if (hashSet.Remove(lruNode) && hashSet.Count == 0)
		{
			this.Table.Remove(key);
		}
		this.RemoveNode(lruNode);
		lruNode.Count++;
		this.HitCount = this.HitCount * this.DecayRate + 1f;
		this.MissCount *= this.DecayRate;
		return lruNode.Value;
	}

	// Token: 0x0600025D RID: 605 RVA: 0x0000D374 File Offset: 0x0000B574
	public int GetCount(TK key)
	{
		if (!this.EnableInternal || !LruConstants.IsLruEnabledGlobal)
		{
			return 0;
		}
		HashSet<LruNode<TK, TV>> hashSet;
		if (!this.Table.TryGetValue(key, out hashSet))
		{
			return 0;
		}
		return hashSet.Count;
	}

	// Token: 0x0600025E RID: 606 RVA: 0x0000D3AC File Offset: 0x0000B5AC
	public bool Put(TV value)
	{
		if (value == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "无效对象";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (!this.EnableInternal || !LruConstants.IsLruEnabledGlobal)
		{
			this.Cache.Remove(value);
			return false;
		}
		LruNode<TK, TV> lruNode;
		if (!this.Cache.TryGetValue(value, out lruNode))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Core;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "对象不在容器中";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("value", value);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		this.AddToFront(lruNode);
		HashSet<LruNode<TK, TV>> hashSet;
		if (!this.Table.TryGetValue(lruNode.Key, out hashSet))
		{
			hashSet = new HashSet<LruNode<TK, TV>>();
			this.Table[lruNode.Key] = hashSet;
		}
		hashSet.Add(lruNode);
		if (this.SizeInternal > this.CapacityInternal)
		{
			this.RemoveTail();
		}
		return true;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x0000D498 File Offset: 0x0000B698
	public bool RemoveExternal(TV value)
	{
		if (value == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "无效对象";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.Cache.Remove(value);
		return true;
	}

	// Token: 0x06000260 RID: 608 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
	public void Clear()
	{
		while (this.SizeInternal > 0)
		{
			this.RemoveTail();
		}
		this.Table.Clear();
		this.Head = null;
		this.Tail = null;
		this.HitCount = 0f;
		this.MissCount = 0f;
	}

	// Token: 0x06000261 RID: 609 RVA: 0x0000D538 File Offset: 0x0000B738
	private void AddToFront(LruNode<TK, TV> node)
	{
		node.Prev = null;
		node.Next = this.Head;
		if (this.Head != null)
		{
			this.Head.Prev = node;
		}
		else
		{
			this.Tail = node;
		}
		this.Head = node;
		this.SizeInternal++;
		this.UsedCount += node.Count;
		if (node.Count >= 3)
		{
			this.ThresholdUsedCount++;
		}
	}

	// Token: 0x06000262 RID: 610 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
	private void RemoveNode(LruNode<TK, TV> node)
	{
		if (node.Prev != null)
		{
			node.Prev.Next = node.Next;
		}
		else
		{
			this.Head = node.Next;
		}
		if (node.Next != null)
		{
			node.Next.Prev = node.Prev;
		}
		else
		{
			this.Tail = node.Prev;
		}
		node.Prev = null;
		node.Next = null;
		this.SizeInternal--;
		this.UsedCount -= node.Count;
		if (node.Count >= 3)
		{
			this.ThresholdUsedCount--;
		}
	}

	// Token: 0x06000263 RID: 611 RVA: 0x0000D658 File Offset: 0x0000B858
	private void RemoveTail()
	{
		if (this.Tail == null)
		{
			return;
		}
		LruNode<TK, TV> tail = this.Tail;
		this.RemoveNode(tail);
		tail.Count = 0;
		TV value = tail.Value;
		HashSet<LruNode<TK, TV>> hashSet;
		if (this.Table.TryGetValue(tail.Key, out hashSet) && hashSet.Remove(tail) && hashSet.Count == 0)
		{
			this.Table.Remove(tail.Key);
		}
		this.Cache.Remove(value);
		if (this.Clearer != null)
		{
			this.Clearer(value);
		}
	}

	// Token: 0x040001CB RID: 459
	private const int USED_THRESHOLD = 3;

	// Token: 0x040001CC RID: 460
	private bool EnableInternal = true;

	// Token: 0x040001CD RID: 461
	private int CapacityInternal;

	// Token: 0x040001CE RID: 462
	private float DecayRate;

	// Token: 0x040001CF RID: 463
	private readonly Dictionary<TK, HashSet<LruNode<TK, TV>>> Table = new Dictionary<TK, HashSet<LruNode<TK, TV>>>();

	// Token: 0x040001D0 RID: 464
	private readonly WeakMap<TV, LruNode<TK, TV>> Cache = new WeakMap<TV, LruNode<TK, TV>>();

	// Token: 0x040001D1 RID: 465
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LruNode<TK, TV> Head;

	// Token: 0x040001D2 RID: 466
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LruNode<TK, TV> Tail;

	// Token: 0x040001D3 RID: 467
	private int SizeInternal;

	// Token: 0x040001D4 RID: 468
	private float HitCount;

	// Token: 0x040001D5 RID: 469
	private float MissCount;

	// Token: 0x040001D6 RID: 470
	private int UsedCount;

	// Token: 0x040001D7 RID: 471
	private int ThresholdUsedCount;

	// Token: 0x040001D8 RID: 472
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private readonly Func<TK, TV> Creator;

	// Token: 0x040001D9 RID: 473
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly Action<TV> Clearer;
}
