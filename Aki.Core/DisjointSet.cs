using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000048 RID: 72
[NullableContext(1)]
[Nullable(0)]
public class DisjointSet<[Nullable(0)] TKey> where TKey : IEquatable<TKey>
{
	// Token: 0x060001FF RID: 511 RVA: 0x0000BE40 File Offset: 0x0000A040
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

	// Token: 0x06000200 RID: 512 RVA: 0x0000BE85 File Offset: 0x0000A085
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

	// Token: 0x06000201 RID: 513 RVA: 0x0000BEBC File Offset: 0x0000A0BC
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

	// Token: 0x06000202 RID: 514 RVA: 0x0000BF54 File Offset: 0x0000A154
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

	// Token: 0x06000203 RID: 515 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
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

	// Token: 0x06000204 RID: 516 RVA: 0x0000C130 File Offset: 0x0000A330
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

	// Token: 0x06000205 RID: 517 RVA: 0x0000C15D File Offset: 0x0000A35D
	public bool Has(TKey key)
	{
		return this.Root.ContainsKey(key);
	}

	// Token: 0x06000206 RID: 518 RVA: 0x0000C16B File Offset: 0x0000A36B
	public void Clear()
	{
		this.Root.Clear();
		this.Set.Clear();
	}

	// Token: 0x040001B6 RID: 438
	private readonly Dictionary<TKey, TKey> Root = new Dictionary<TKey, TKey>();

	// Token: 0x040001B7 RID: 439
	private readonly Dictionary<TKey, List<TKey>> Set = new Dictionary<TKey, List<TKey>>();
}
