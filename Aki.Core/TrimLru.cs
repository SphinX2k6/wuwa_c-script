using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000064 RID: 100
[NullableContext(1)]
[Nullable(0)]
public class TrimLru<[Nullable(2)] TK, TV> where TV : class
{
	// Token: 0x06000317 RID: 791 RVA: 0x00010AB8 File Offset: 0x0000ECB8
	public TrimLru(int capacity, bool allowEmpty = false)
	{
		this.AllowEmpty = allowEmpty;
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

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000318 RID: 792 RVA: 0x00010B2E File Offset: 0x0000ED2E
	// (set) Token: 0x06000319 RID: 793 RVA: 0x00010B36 File Offset: 0x0000ED36
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

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x0600031A RID: 794 RVA: 0x00010B4E File Offset: 0x0000ED4E
	public int Size
	{
		get
		{
			return this.SizeInternal;
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x0600031B RID: 795 RVA: 0x00010B56 File Offset: 0x0000ED56
	// (set) Token: 0x0600031C RID: 796 RVA: 0x00010B60 File Offset: 0x0000ED60
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
			this.DecayRate = 1f - 1f / (float)value;
			this.HitCount = this.HitCount / (float)this.CapacityInternal * (float)value;
			this.MissCount = this.MissCount / (float)this.CapacityInternal * (float)value;
			this.CapacityInternal = value;
			while (this.SizeInternal > value)
			{
				this.RemoveTail();
			}
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x0600031D RID: 797 RVA: 0x00010BF6 File Offset: 0x0000EDF6
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

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x0600031E RID: 798 RVA: 0x00010C1F File Offset: 0x0000EE1F
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

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x0600031F RID: 799 RVA: 0x00010C3F File Offset: 0x0000EE3F
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

	// Token: 0x06000320 RID: 800 RVA: 0x00010C60 File Offset: 0x0000EE60
	[return: Nullable(2)]
	public TV Get(TK key)
	{
		if (!this.EnableInternal)
		{
			return default(TV);
		}
		TrimLruNode<TK, TV> trimLruNode;
		if (!this.Table.TryGetValue(key, out trimLruNode))
		{
			this.HitCount *= this.DecayRate;
			this.MissCount = this.MissCount * this.DecayRate + 1f;
			return default(TV);
		}
		this.RemoveNode(trimLruNode);
		trimLruNode.Count++;
		this.AddToFront(trimLruNode);
		this.HitCount = this.HitCount * this.DecayRate + (float)trimLruNode.Size;
		this.MissCount *= this.DecayRate;
		return trimLruNode.Value;
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00010D18 File Offset: 0x0000EF18
	public bool Put(TK key, TV value, int size = 1)
	{
		if (key == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "无效键";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (this.Table.ContainsKey(key))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Core;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "键已存在";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("key", key);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		if (!this.AllowEmpty && value == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Core;
			ELogAuthor author3 = ELogAuthor.LCC;
			string message3 = "无效对象";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("value", value);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return false;
		}
		if (!this.EnableInternal)
		{
			return false;
		}
		TrimLruNode<TK, TV> trimLruNode = new TrimLruNode<TK, TV>(key, value, size);
		this.Table[key] = trimLruNode;
		this.AddToFront(trimLruNode);
		while (this.SizeInternal > this.CapacityInternal)
		{
			this.RemoveTail();
		}
		return true;
	}

	// Token: 0x06000322 RID: 802 RVA: 0x00010E10 File Offset: 0x0000F010
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

	// Token: 0x06000323 RID: 803 RVA: 0x00010E60 File Offset: 0x0000F060
	private void AddToFront(TrimLruNode<TK, TV> node)
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
		this.SizeInternal += node.Size;
		this.UsedCount += node.Count * node.Size;
		if (node.Count >= 3)
		{
			this.ThresholdUsedCount += node.Count * node.Size;
		}
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00010EF4 File Offset: 0x0000F0F4
	private void RemoveNode(TrimLruNode<TK, TV> node)
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
		this.SizeInternal -= node.Size;
		this.UsedCount -= node.Count * node.Size;
		if (node.Count >= 3)
		{
			this.ThresholdUsedCount -= node.Count * node.Size;
		}
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00010FB0 File Offset: 0x0000F1B0
	private void RemoveTail()
	{
		if (this.Tail == null)
		{
			return;
		}
		TrimLruNode<TK, TV> tail = this.Tail;
		this.RemoveNode(tail);
		tail.Count = 0;
		this.Table.Remove(tail.Key);
	}

	// Token: 0x0400021E RID: 542
	private const int USED_THRESHOLD = 3;

	// Token: 0x0400021F RID: 543
	private bool EnableInternal = true;

	// Token: 0x04000220 RID: 544
	private int CapacityInternal;

	// Token: 0x04000221 RID: 545
	private float DecayRate;

	// Token: 0x04000222 RID: 546
	private readonly Dictionary<TK, TrimLruNode<TK, TV>> Table = new Dictionary<TK, TrimLruNode<TK, TV>>();

	// Token: 0x04000223 RID: 547
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TrimLruNode<TK, TV> Head;

	// Token: 0x04000224 RID: 548
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TrimLruNode<TK, TV> Tail;

	// Token: 0x04000225 RID: 549
	private int SizeInternal;

	// Token: 0x04000226 RID: 550
	private float HitCount;

	// Token: 0x04000227 RID: 551
	private float MissCount;

	// Token: 0x04000228 RID: 552
	private int UsedCount;

	// Token: 0x04000229 RID: 553
	private int ThresholdUsedCount;

	// Token: 0x0400022A RID: 554
	private readonly bool AllowEmpty;
}
