using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200005C RID: 92
[NullableContext(1)]
[Nullable(0)]
public class ProxyLruMap<[Nullable(2)] TC, [Nullable(2)] TK, TV> : IEnumerable<!0>, IEnumerable where TV : class
{
	// Token: 0x060002CD RID: 717 RVA: 0x0000EF2F File Offset: 0x0000D12F
	public ProxyLruMap([Nullable(new byte[]
	{
		2,
		1
	})] Action<TC> callback = null)
	{
		this.Callback = callback;
	}

	// Token: 0x060002CE RID: 718 RVA: 0x0000EF4C File Offset: 0x0000D14C
	public void Add(TC category, int capacity, Func<TK, TV> creator, [Nullable(new byte[]
	{
		2,
		1
	})] Action<TV> clearer = null)
	{
		if (this.Table.ContainsKey(category))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "池中已存在该种类";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("category", category);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.Table[category] = new ProxyLru<TK, TV>(capacity, creator, clearer, null);
	}

	// Token: 0x060002CF RID: 719 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
	public void Remove(TC category)
	{
		ProxyLru<TK, TV> category2 = this.GetCategory(category);
		if (category2 == null)
		{
			return;
		}
		this.Table.Remove(category);
		category2.Clear();
		if (this.Callback != null)
		{
			this.Callback(category);
		}
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
	[return: Nullable(2)]
	public TV Create(TC category, TK key)
	{
		ProxyLru<TK, TV> category2 = this.GetCategory(category);
		if (category2 == null)
		{
			return default(TV);
		}
		return category2.Create(key);
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0000F010 File Offset: 0x0000D210
	[return: Nullable(2)]
	public TV Get(TC category, TK key)
	{
		ProxyLru<TK, TV> category2 = this.GetCategory(category);
		if (category2 == null)
		{
			return default(TV);
		}
		return category2.Get(key);
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0000F038 File Offset: 0x0000D238
	public void Put(TC category, TV value)
	{
		ProxyLru<TK, TV> category2 = this.GetCategory(category);
		if (category2 != null && category2.Put(value) && this.Callback != null)
		{
			this.Callback(category);
		}
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0000F070 File Offset: 0x0000D270
	public bool GetEnable(TC category)
	{
		ProxyLru<TK, TV> category2 = this.GetCategory(category);
		return category2 != null && category2.Enable;
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0000F090 File Offset: 0x0000D290
	public void SetEnable(TC category, bool value)
	{
		ProxyLru<TK, TV> category2 = this.GetCategory(category);
		if (category2 != null)
		{
			category2.Enable = value;
		}
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
	public int GetSize(TC category)
	{
		ProxyLru<TK, TV> category2 = this.GetCategory(category);
		if (category2 == null)
		{
			return 0;
		}
		return category2.Size;
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0000F0D0 File Offset: 0x0000D2D0
	public int GetCapacity(TC category)
	{
		ProxyLru<TK, TV> category2 = this.GetCategory(category);
		if (category2 == null)
		{
			return 0;
		}
		return category2.Capacity;
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
	public void SetCapacity(TC category, int value)
	{
		ProxyLru<TK, TV> category2 = this.GetCategory(category);
		if (category2 != null)
		{
			category2.Capacity = value;
		}
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x0000F110 File Offset: 0x0000D310
	public float GetHitRate(TC category)
	{
		ProxyLru<TK, TV> category2 = this.GetCategory(category);
		if (category2 == null)
		{
			return 0f;
		}
		return category2.HitRate;
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0000F134 File Offset: 0x0000D334
	public float GetUsedAvg(TC category)
	{
		ProxyLru<TK, TV> category2 = this.GetCategory(category);
		if (category2 == null)
		{
			return 0f;
		}
		return category2.UsedAvg;
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0000F158 File Offset: 0x0000D358
	public float GetThresholdUsedRate(TC category)
	{
		ProxyLru<TK, TV> category2 = this.GetCategory(category);
		if (category2 == null)
		{
			return 0f;
		}
		return category2.ThresholdUsedRate;
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0000F17C File Offset: 0x0000D37C
	public IEnumerator<TC> GetEnumerator()
	{
		return this.Table.Keys.GetEnumerator();
	}

	// Token: 0x060002DC RID: 732 RVA: 0x0000F193 File Offset: 0x0000D393
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0000F19C File Offset: 0x0000D39C
	[return: Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private ProxyLru<TK, TV> GetCategory(TC category)
	{
		ProxyLru<TK, TV> result;
		if (!this.Table.TryGetValue(category, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "池中不存在该种类";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("category", category);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return result;
	}

	// Token: 0x040001FF RID: 511
	private readonly Dictionary<TC, ProxyLru<TK, TV>> Table = new Dictionary<TC, ProxyLru<TK, TV>>();

	// Token: 0x04000200 RID: 512
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly Action<TC> Callback;
}
