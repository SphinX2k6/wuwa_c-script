using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000048 RID: 72
[NullableContext(1)]
[Nullable(0)]
public class DisjointSet<[Nullable(0)] TKey> where TKey : IEquatable<TKey>
{
	// Token: 0x060001FE RID: 510 RVA: 0x0000C15C File Offset: 0x0000A35C
	private TKey FindRoot(TKey key)
	{
		TKey tkey;
		if (!this.Root.TryGetValue(key, out tkey) || tkey.Equals(key))
		{
			return key;
		}
		tkey = this.FindRoot(tkey);
		this.Root[key] = tkey;
		return tkey;
	}

	// Token: 0x060001FF RID: 511 RVA: 0x0000C1A1 File Offset: 0x0000A3A1
	public void Add(TKey key)
	{
		if (!this.Root.ContainsKey(key))
		{
			this.Root[key] = key;
			this.Set[key] = new List<TKey>
			{
				key
			};
		}
	}

	// Token: 0x06000200 RID: 512 RVA: 0x0000C1D8 File Offset: 0x0000A3D8
	public void Union(TKey key1, TKey key2)
	{
		if (!this.Root.ContainsKey(key1))
		{
			this.Add(key1);
		}
		if (!this.Root.ContainsKey(key2))
		{
			this.Add(key2);
		}
		TKey tkey = this.FindRoot(key1);
		TKey tkey2 = this.FindRoot(key2);
		if (!tkey.Equals(tkey2))
		{
			this.Root[tkey2] = tkey;
			List<TKey> list;
			List<TKey> collection;
			if (this.Set.TryGetValue(tkey, out list) && this.Set.TryGetValue(tkey2, out collection))
			{
				list.AddRange(collection);
				this.Set.Remove(tkey2);
			}
		}
	}

	// Token: 0x06000201 RID: 513 RVA: 0x0000C270 File Offset: 0x0000A470
	public void Delete(TKey key)
	{
		TKey key2 = this.FindRoot(key);
		List<TKey> list;
		if (!this.Set.TryGetValue(key2, out list))
		{
			return;
		}
		if (list.Count <= 2)
		{
			foreach (TKey key3 in list)
			{
				this.Root.Remove(key3);
			}
			this.Set.Remove(key2);
			return;
		}
		if (!key2.Equals(key))
		{
			list.RemoveAt(list.IndexOf(key));
			this.Root.Remove(key);
			return;
		}
		TKey tkey = list[0];
		int num = 0;
		while (num < list.Count && tkey.Equals(key))
		{
			tkey = list[num];
			num++;
		}
		list.RemoveAt(list.IndexOf(key));
		foreach (TKey key4 in list)
		{
			this.Root[key4] = tkey;
		}
		this.Root.Remove(key);
		this.Set.Remove(key2);
		this.Set[tkey] = list;
	}

	// Token: 0x06000202 RID: 514 RVA: 0x0000C3D0 File Offset: 0x0000A5D0
	public void DeleteSet(TKey key)
	{
		TKey key2 = this.FindRoot(key);
		List<TKey> list;
		if (this.Set.TryGetValue(key2, out list))
		{
			foreach (TKey key3 in list)
			{
				this.Root.Remove(key3);
			}
			this.Set.Remove(key2);
		}
	}

	// Token: 0x06000203 RID: 515 RVA: 0x0000C44C File Offset: 0x0000A64C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<TKey> GetSet(TKey key)
	{
		TKey key2 = this.FindRoot(key);
		List<TKey> list;
		if (!this.Set.TryGetValue(key2, out list))
		{
			return null;
		}
		return list.AsReadOnly();
	}

	// Token: 0x06000204 RID: 516 RVA: 0x0000C479 File Offset: 0x0000A679
	public bool Has(TKey key)
	{
		return this.Root.ContainsKey(key);
	}

	// Token: 0x06000205 RID: 517 RVA: 0x0000C487 File Offset: 0x0000A687
	public void Clear()
	{
		this.Root.Clear();
		this.Set.Clear();
	}

	// Token: 0x040001B4 RID: 436
	private readonly Dictionary<TKey, TKey> Root = new Dictionary<TKey, TKey>();

	// Token: 0x040001B5 RID: 437
	private readonly Dictionary<TKey, List<TKey>> Set = new Dictionary<TKey, List<TKey>>();
}
