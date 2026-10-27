using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020034FA RID: 13562
[NullableContext(1)]
[Nullable(0)]
public class CustomMap<[Nullable(2)] TKey, [Nullable(2)] TValue>
{
	// Token: 0x0601DBC1 RID: 121793 RVA: 0x00854F7D File Offset: 0x0085317D
	public int Size()
	{
		return this.Key2Index.Count;
	}

	// Token: 0x0601DBC2 RID: 121794 RVA: 0x00854F8C File Offset: 0x0085318C
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

	// Token: 0x0601DBC3 RID: 121795 RVA: 0x00855004 File Offset: 0x00853204
	public TValue Get(TKey key)
	{
		int index;
		if (this.Key2Index.TryGetValue(key, out index))
		{
			return this.List[index];
		}
		return default(TValue);
	}

	// Token: 0x0601DBC4 RID: 121796 RVA: 0x00855038 File Offset: 0x00853238
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

	// Token: 0x0601DBC5 RID: 121797 RVA: 0x00855074 File Offset: 0x00853274
	public TValue GetByIndex(int index)
	{
		TKey key;
		if (this.Index2Key.TryGetValue(index, out key))
		{
			return this.Get(key);
		}
		return default(TValue);
	}

	// Token: 0x0601DBC6 RID: 121798 RVA: 0x008550A2 File Offset: 0x008532A2
	public bool Contains(TKey key)
	{
		return this.Key2Index.ContainsKey(key);
	}

	// Token: 0x0601DBC7 RID: 121799 RVA: 0x008550B0 File Offset: 0x008532B0
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

	// Token: 0x0601DBC8 RID: 121800 RVA: 0x00855154 File Offset: 0x00853354
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

	// Token: 0x0601DBC9 RID: 121801 RVA: 0x00855214 File Offset: 0x00853414
	public bool RemoveByIndex(int index)
	{
		TKey key;
		return this.Index2Key.TryGetValue(index, out key) && this.Remove(key);
	}

	// Token: 0x0601DBCA RID: 121802 RVA: 0x0085523A File Offset: 0x0085343A
	public IEnumerable<TKey> Keys()
	{
		return this.Key2Index.Keys;
	}

	// Token: 0x0601DBCB RID: 121803 RVA: 0x00855247 File Offset: 0x00853447
	public IReadOnlyList<TValue> GetItems()
	{
		return this.List;
	}

	// Token: 0x0601DBCC RID: 121804 RVA: 0x0085524F File Offset: 0x0085344F
	public void Clear()
	{
		this.Key2Index.Clear();
		this.Index2Key.Clear();
		this.List.Clear();
	}

	// Token: 0x0400E956 RID: 59734
	private readonly Dictionary<TKey, int> Key2Index = new Dictionary<TKey, int>();

	// Token: 0x0400E957 RID: 59735
	private readonly List<TValue> List = new List<TValue>();

	// Token: 0x0400E958 RID: 59736
	private readonly Dictionary<int, TKey> Index2Key = new Dictionary<int, TKey>();
}
