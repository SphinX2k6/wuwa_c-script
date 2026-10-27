using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000059 RID: 89
[NullableContext(1)]
[Nullable(0)]
public class ProxyLru<[Nullable(2)] TK, TV> where TV : class
{
	// Token: 0x06000284 RID: 644 RVA: 0x0000DF18 File Offset: 0x0000C118
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

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000285 RID: 645 RVA: 0x0000DF69 File Offset: 0x0000C169
	// (set) Token: 0x06000286 RID: 646 RVA: 0x0000DF76 File Offset: 0x0000C176
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

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000287 RID: 647 RVA: 0x0000DF84 File Offset: 0x0000C184
	public int Size
	{
		get
		{
			return this.Lru.Size;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000288 RID: 648 RVA: 0x0000DF91 File Offset: 0x0000C191
	// (set) Token: 0x06000289 RID: 649 RVA: 0x0000DF9E File Offset: 0x0000C19E
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

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x0600028A RID: 650 RVA: 0x0000DFAC File Offset: 0x0000C1AC
	public float HitRate
	{
		get
		{
			return this.Lru.HitRate;
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x0600028B RID: 651 RVA: 0x0000DFB9 File Offset: 0x0000C1B9
	public float UsedAvg
	{
		get
		{
			return this.Lru.UsedAvg;
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x0600028C RID: 652 RVA: 0x0000DFC6 File Offset: 0x0000C1C6
	public float ThresholdUsedRate
	{
		get
		{
			return this.Lru.ThresholdUsedRate;
		}
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0000DFD3 File Offset: 0x0000C1D3
	[return: Nullable(2)]
	public TV Create(TK key)
	{
		return this.Lru.Create(key);
	}

	// Token: 0x0600028E RID: 654 RVA: 0x0000DFE1 File Offset: 0x0000C1E1
	[return: Nullable(2)]
	public TV Get(TK key)
	{
		return this.Lru.Get(key);
	}

	// Token: 0x0600028F RID: 655 RVA: 0x0000DFF0 File Offset: 0x0000C1F0
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

	// Token: 0x06000290 RID: 656 RVA: 0x0000E12C File Offset: 0x0000C32C
	public void Clear()
	{
		this.Lru.Clear();
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0000E139 File Offset: 0x0000C339
	public int GetCount(TK key)
	{
		return this.Lru.GetCount(key);
	}

	// Token: 0x040001E4 RID: 484
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private readonly Lru<TK, TV> Lru;

	// Token: 0x040001E5 RID: 485
	private readonly ConditionalWeakTable<TV, IRevocableObject<TK, TV>> RevocableWeakMap = new ConditionalWeakTable<TV, IRevocableObject<TK, TV>>();

	// Token: 0x040001E6 RID: 486
	private readonly ConditionalWeakTable<object, Dictionary<object, IRevocable<object>>> ProxyToOwnRevocableMap = new ConditionalWeakTable<object, Dictionary<object, IRevocable<object>>>();

	// Token: 0x040001E7 RID: 487
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private readonly Func<object, object, bool> Checker;

	// Token: 0x040001E8 RID: 488
	private readonly bool ProxyEnable = true;
}
