using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200005B RID: 91
[NullableContext(1)]
[Nullable(0)]
public class ProxyLru<[Nullable(2)] TK, TV> where TV : class
{
	// Token: 0x060002BF RID: 703 RVA: 0x0000ED00 File Offset: 0x0000CF00
	public ProxyLru(int capacity, Func<TK, TV> creator, [Nullable(new byte[]
	{
		2,
		1
	})] Action<TV> clearer = null, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Func<object, object, bool> checker = null)
	{
		this.Lru = new Lru<TK, TV>(capacity, creator, clearer);
		this.Checker = checker;
		this.ProxyEnable = ProxyLruConstants.ProxyLruEnable;
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000ED51 File Offset: 0x0000CF51
	// (set) Token: 0x060002C1 RID: 705 RVA: 0x0000ED5E File Offset: 0x0000CF5E
	public bool Enable
	{
		get
		{
			return this.Lru.Enable;
		}
		set
		{
			this.Lru.Enable = value;
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000ED6C File Offset: 0x0000CF6C
	public int Size
	{
		get
		{
			return this.Lru.Size;
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000ED79 File Offset: 0x0000CF79
	// (set) Token: 0x060002C4 RID: 708 RVA: 0x0000ED86 File Offset: 0x0000CF86
	public int Capacity
	{
		get
		{
			return this.Lru.Capacity;
		}
		set
		{
			this.Lru.Capacity = value;
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000ED94 File Offset: 0x0000CF94
	public float HitRate
	{
		get
		{
			return this.Lru.HitRate;
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000EDA1 File Offset: 0x0000CFA1
	public float UsedAvg
	{
		get
		{
			return this.Lru.UsedAvg;
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000EDAE File Offset: 0x0000CFAE
	public float ThresholdUsedRate
	{
		get
		{
			return this.Lru.ThresholdUsedRate;
		}
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x0000EDBB File Offset: 0x0000CFBB
	[return: Nullable(2)]
	public TV Create(TK key)
	{
		return this.Lru.Create(key);
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x0000EDC9 File Offset: 0x0000CFC9
	[return: Nullable(2)]
	public TV Get(TK key)
	{
		return this.Lru.Get(key);
	}

	// Token: 0x060002CA RID: 714 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
	public bool Put(TV value)
	{
		if (!this.ProxyEnable)
		{
			return this.Lru.Put(value);
		}
		IRevocableObject<TK, TV> revocableObject;
		if (!this.RevocableWeakMap.TryGetValue(value, out revocableObject))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "对象不在维护列表中";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		Dictionary<object, IRevocable<object>> dictionary;
		if (!this.ProxyToOwnRevocableMap.TryGetValue(value, out dictionary))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Core;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "对象不存在所属代理表";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("value", value);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		this.ProxyToOwnRevocableMap.Remove(value);
		foreach (IRevocable<object> revocable in dictionary.Values)
		{
			this.ProxyToOwnRevocableMap.Remove(revocable.proxy);
			revocable.Revoke();
		}
		dictionary.Clear();
		revocableObject.Revoke();
		this.RevocableWeakMap.Remove(value);
		return this.Lru.Put(revocableObject.Value);
	}

	// Token: 0x060002CB RID: 715 RVA: 0x0000EF14 File Offset: 0x0000D114
	public void Clear()
	{
		this.Lru.Clear();
	}

	// Token: 0x060002CC RID: 716 RVA: 0x0000EF21 File Offset: 0x0000D121
	public int GetCount(TK key)
	{
		return this.Lru.GetCount(key);
	}

	// Token: 0x040001FA RID: 506
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private readonly Lru<TK, TV> Lru;

	// Token: 0x040001FB RID: 507
	private readonly ConditionalWeakTable<TV, IRevocableObject<TK, TV>> RevocableWeakMap = new ConditionalWeakTable<TV, IRevocableObject<TK, TV>>();

	// Token: 0x040001FC RID: 508
	private readonly ConditionalWeakTable<object, Dictionary<object, IRevocable<object>>> ProxyToOwnRevocableMap = new ConditionalWeakTable<object, Dictionary<object, IRevocable<object>>>();

	// Token: 0x040001FD RID: 509
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private readonly Func<object, object, bool> Checker;

	// Token: 0x040001FE RID: 510
	private readonly bool ProxyEnable = true;
}
