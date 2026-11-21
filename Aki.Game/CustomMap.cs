using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A6F RID: 10863
[NullableContext(1)]
[Nullable(0)]
public class CustomMap<[Nullable(2)] TKey, [Nullable(2)] TValue>
{
	// Token: 0x0601B8D8 RID: 112856 RVA: 0x0087D3D1 File Offset: 0x0087B5D1
	public int Size()
	{
		return this.Key2Index.Count;
	}

	// Token: 0x0601B8D9 RID: 112857 RVA: 0x0087D3E0 File Offset: 0x0087B5E0
	public void Set(TKey key, TValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value", "Value cannot be null");
		}
		int count;
		if (this.Key2Index.TryGetValue(key, out count))
		{
			this.List[count] = value;
			return;
		}
		count = this.Key2Index.Count;
		this.Key2Index[key] = count;
		this.List.Add(value);
		this.Index2Key[count] = key;
	}

	// Token: 0x0601B8DA RID: 112858 RVA: 0x0087D458 File Offset: 0x0087B658
	public TValue Get(TKey key)
	{
		int index;
		if (this.Key2Index.TryGetValue(key, out index))
		{
			return this.List[index];
		}
		return default(TValue);
	}

	// Token: 0x0601B8DB RID: 112859 RVA: 0x0087D48C File Offset: 0x0087B68C
	public bool TryGetValue(TKey key, [Nullable(2)] out TValue value)
	{
		int index;
		if (this.Key2Index.TryGetValue(key, out index))
		{
			value = this.List[index];
			return true;
		}
		value = default(TValue);
		return false;
	}

	// Token: 0x0601B8DC RID: 112860 RVA: 0x0087D4C8 File Offset: 0x0087B6C8
	public TValue GetByIndex(int index)
	{
		TKey key;
		if (this.Index2Key.TryGetValue(index, out key))
		{
			return this.Get(key);
		}
		return default(TValue);
	}

	// Token: 0x0601B8DD RID: 112861 RVA: 0x0087D4F6 File Offset: 0x0087B6F6
	public bool Contains(TKey key)
	{
		return this.Key2Index.ContainsKey(key);
	}

	// Token: 0x0601B8DE RID: 112862 RVA: 0x0087D504 File Offset: 0x0087B704
	public bool Remove(TKey key)
	{
		int num;
		if (!this.Key2Index.Remove(key, out num))
		{
			return false;
		}
		this.Index2Key.Remove(num);
		if (this.List.Count > 1)
		{
			int num2 = this.List.Count - 1;
			TKey tkey;
			if (this.Index2Key.Remove(num2, out tkey))
			{
				this.Key2Index[tkey] = num;
				this.Index2Key[num] = tkey;
			}
			this.List[num] = this.List[num2];
			this.List.RemoveAt(num2);
		}
		else
		{
			this.List.Clear();
		}
		return true;
	}

	// Token: 0x0601B8DF RID: 112863 RVA: 0x0087D5A8 File Offset: 0x0087B7A8
	public bool Remove(TKey key, [Nullable(2)] out TValue value)
	{
		int num;
		if (!this.Key2Index.Remove(key, out num))
		{
			value = default(TValue);
			return false;
		}
		value = this.List[num];
		this.Index2Key.Remove(num);
		if (this.List.Count > 1)
		{
			int num2 = this.List.Count - 1;
			TKey tkey;
			if (this.Index2Key.Remove(num2, out tkey))
			{
				this.Key2Index[tkey] = num;
				this.Index2Key[num] = tkey;
			}
			this.List[num] = this.List[num2];
			this.List.RemoveAt(num2);
		}
		else
		{
			this.List.Clear();
		}
		return true;
	}

	// Token: 0x0601B8E0 RID: 112864 RVA: 0x0087D668 File Offset: 0x0087B868
	public bool RemoveByIndex(int index)
	{
		TKey key;
		return this.Index2Key.TryGetValue(index, out key) && this.Remove(key);
	}

	// Token: 0x0601B8E1 RID: 112865 RVA: 0x0087D68E File Offset: 0x0087B88E
	public IEnumerable<TKey> Keys()
	{
		return this.Key2Index.Keys;
	}

	// Token: 0x0601B8E2 RID: 112866 RVA: 0x0087D69B File Offset: 0x0087B89B
	public IReadOnlyList<TValue> GetItems()
	{
		return this.List;
	}

	// Token: 0x0601B8E3 RID: 112867 RVA: 0x0087D6A3 File Offset: 0x0087B8A3
	public void Clear()
	{
		this.Key2Index.Clear();
		this.Index2Key.Clear();
		this.List.Clear();
	}

	// Token: 0x0400EE11 RID: 60945
	private readonly Dictionary<TKey, int> Key2Index = new Dictionary<TKey, int>();

	// Token: 0x0400EE12 RID: 60946
	private readonly List<TValue> List = new List<TValue>();

	// Token: 0x0400EE13 RID: 60947
	private readonly Dictionary<int, TKey> Index2Key = new Dictionary<int, TKey>();
}
