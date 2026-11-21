using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200004D RID: 77
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ImmutableArray<[Nullable(2)] T> : List<T>
{
	// Token: 0x0600021B RID: 539 RVA: 0x0000C681 File Offset: 0x0000A881
	public new void Add(T item)
	{
		this.LogError("Add");
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0000C68E File Offset: 0x0000A88E
	public new void AddRange(IEnumerable<T> collection)
	{
		this.LogError("AddRange");
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0000C69B File Offset: 0x0000A89B
	public new void Clear()
	{
		this.LogError("Clear");
	}

	// Token: 0x0600021E RID: 542 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
	public new void Insert(int index, T item)
	{
		this.LogError("Insert");
	}

	// Token: 0x0600021F RID: 543 RVA: 0x0000C6B5 File Offset: 0x0000A8B5
	public new void InsertRange(int index, IEnumerable<T> collection)
	{
		this.LogError("InsertRange");
	}

	// Token: 0x06000220 RID: 544 RVA: 0x0000C6C2 File Offset: 0x0000A8C2
	public new bool Remove(T item)
	{
		this.LogError("Remove");
		return false;
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
	public new int RemoveAll(Predicate<T> match)
	{
		this.LogError("RemoveAll");
		return 0;
	}

	// Token: 0x06000222 RID: 546 RVA: 0x0000C6DE File Offset: 0x0000A8DE
	public new void RemoveAt(int index)
	{
		this.LogError("RemoveAt");
	}

	// Token: 0x06000223 RID: 547 RVA: 0x0000C6EB File Offset: 0x0000A8EB
	public new void RemoveRange(int index, int count)
	{
		this.LogError("RemoveRange");
	}

	// Token: 0x06000224 RID: 548 RVA: 0x0000C6F8 File Offset: 0x0000A8F8
	public new void Reverse()
	{
		this.LogError("Reverse");
	}

	// Token: 0x06000225 RID: 549 RVA: 0x0000C705 File Offset: 0x0000A905
	public new void Reverse(int index, int count)
	{
		this.LogError("Reverse");
	}

	// Token: 0x06000226 RID: 550 RVA: 0x0000C712 File Offset: 0x0000A912
	public new void Sort()
	{
		this.LogError("Sort");
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0000C71F File Offset: 0x0000A91F
	public new void Sort(Comparison<T> comparison)
	{
		this.LogError("Sort");
	}

	// Token: 0x06000228 RID: 552 RVA: 0x0000C72C File Offset: 0x0000A92C
	public new void Sort(IComparer<T> comparer)
	{
		this.LogError("Sort");
	}

	// Token: 0x06000229 RID: 553 RVA: 0x0000C739 File Offset: 0x0000A939
	public new void Sort(int index, int count, IComparer<T> comparer)
	{
		this.LogError("Sort");
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0000C746 File Offset: 0x0000A946
	public int push(params T[] items)
	{
		this.LogError("push");
		return 0;
	}

	// Token: 0x0600022B RID: 555 RVA: 0x0000C754 File Offset: 0x0000A954
	[NullableContext(2)]
	public T pop()
	{
		this.LogError("pop");
		return default(T);
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0000C778 File Offset: 0x0000A978
	[NullableContext(2)]
	public T shift()
	{
		this.LogError("shift");
		return default(T);
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000C799 File Offset: 0x0000A999
	public int unshift(params T[] items)
	{
		this.LogError("unshift");
		return 0;
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0000C7A7 File Offset: 0x0000A9A7
	public T[] splice(int start, int? deleteCount = null, params T[] items)
	{
		this.LogError("splice");
		return new T[0];
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0000C7BA File Offset: 0x0000A9BA
	public ImmutableArray<T> fill(T value, int? start = null, int? end = null)
	{
		this.LogError("fill");
		return this;
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
	public ImmutableArray<T> copyWithin(int target, int start, int? end = null)
	{
		this.LogError("copyWithin");
		return this;
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000231 RID: 561 RVA: 0x0000C7D6 File Offset: 0x0000A9D6
	// (set) Token: 0x06000232 RID: 562 RVA: 0x0000C7DE File Offset: 0x0000A9DE
	public int length
	{
		get
		{
			return base.Count;
		}
		set
		{
			this.LogError("set length");
		}
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0000C7EC File Offset: 0x0000A9EC
	public List<T> concat(params T[][] items)
	{
		List<T> list = new List<T>(this);
		foreach (T[] collection in items)
		{
			list.AddRange(collection);
		}
		return list;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0000C81C File Offset: 0x0000AA1C
	public List<U> map<[Nullable(2)] U>(Func<T, int, IList<T>, U> callbackfn)
	{
		List<U> list = new List<U>(base.Count);
		for (int i = 0; i < base.Count; i++)
		{
			list.Add(callbackfn(base[i], i, this));
		}
		return list;
	}

	// Token: 0x06000235 RID: 565 RVA: 0x0000C85C File Offset: 0x0000AA5C
	public List<T> slice(int? start = null, int? end = null)
	{
		int num = start.GetValueOrDefault();
		int num2 = end ?? base.Count;
		if (num < 0)
		{
			num = base.Count + num;
		}
		if (num2 < 0)
		{
			num2 = base.Count + num2;
		}
		num = Math.Max(0, Math.Min(num, base.Count));
		num2 = Math.Max(0, Math.Min(num2, base.Count));
		int num3 = Math.Max(0, num2 - num);
		if (num3 == 0 || num >= base.Count)
		{
			return new List<T>();
		}
		return base.GetRange(num, num3);
	}

	// Token: 0x06000236 RID: 566 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
	public List<T> filter(Func<T, int, IList<T>, bool> predicate)
	{
		List<T> list = new List<T>();
		for (int i = 0; i < base.Count; i++)
		{
			if (predicate(base[i], i, this))
			{
				list.Add(base[i]);
			}
		}
		return list;
	}

	// Token: 0x06000237 RID: 567 RVA: 0x0000C934 File Offset: 0x0000AB34
	private void LogError(string funcName)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Core;
		ELogAuthor author = ELogAuthor.CYK;
		string message = "ImmutableArray 不允许修改";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("函数名", funcName);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}
}
