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
	// Token: 0x0600021A RID: 538 RVA: 0x0000C99D File Offset: 0x0000AB9D
	public new void Add(T item)
	{
		this.LogError("Add");
	}

	// Token: 0x0600021B RID: 539 RVA: 0x0000C9AA File Offset: 0x0000ABAA
	public new void AddRange(IEnumerable<T> collection)
	{
		this.LogError("AddRange");
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0000C9B7 File Offset: 0x0000ABB7
	public new void Clear()
	{
		this.LogError("Clear");
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
	public new void Insert(int index, T item)
	{
		this.LogError("Insert");
	}

	// Token: 0x0600021E RID: 542 RVA: 0x0000C9D1 File Offset: 0x0000ABD1
	public new void InsertRange(int index, IEnumerable<T> collection)
	{
		this.LogError("InsertRange");
	}

	// Token: 0x0600021F RID: 543 RVA: 0x0000C9DE File Offset: 0x0000ABDE
	public new bool Remove(T item)
	{
		this.LogError("Remove");
		return false;
	}

	// Token: 0x06000220 RID: 544 RVA: 0x0000C9EC File Offset: 0x0000ABEC
	public new int RemoveAll(Predicate<T> match)
	{
		this.LogError("RemoveAll");
		return 0;
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000C9FA File Offset: 0x0000ABFA
	public new void RemoveAt(int index)
	{
		this.LogError("RemoveAt");
	}

	// Token: 0x06000222 RID: 546 RVA: 0x0000CA07 File Offset: 0x0000AC07
	public new void RemoveRange(int index, int count)
	{
		this.LogError("RemoveRange");
	}

	// Token: 0x06000223 RID: 547 RVA: 0x0000CA14 File Offset: 0x0000AC14
	public new void Reverse()
	{
		this.LogError("Reverse");
	}

	// Token: 0x06000224 RID: 548 RVA: 0x0000CA21 File Offset: 0x0000AC21
	public new void Reverse(int index, int count)
	{
		this.LogError("Reverse");
	}

	// Token: 0x06000225 RID: 549 RVA: 0x0000CA2E File Offset: 0x0000AC2E
	public new void Sort()
	{
		this.LogError("Sort");
	}

	// Token: 0x06000226 RID: 550 RVA: 0x0000CA3B File Offset: 0x0000AC3B
	public new void Sort(Comparison<T> comparison)
	{
		this.LogError("Sort");
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0000CA48 File Offset: 0x0000AC48
	public new void Sort(IComparer<T> comparer)
	{
		this.LogError("Sort");
	}

	// Token: 0x06000228 RID: 552 RVA: 0x0000CA55 File Offset: 0x0000AC55
	public new void Sort(int index, int count, IComparer<T> comparer)
	{
		this.LogError("Sort");
	}

	// Token: 0x06000229 RID: 553 RVA: 0x0000CA62 File Offset: 0x0000AC62
	public int push(params T[] items)
	{
		this.LogError("push");
		return 0;
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0000CA70 File Offset: 0x0000AC70
	[NullableContext(2)]
	public T pop()
	{
		this.LogError("pop");
		return default(T);
	}

	// Token: 0x0600022B RID: 555 RVA: 0x0000CA94 File Offset: 0x0000AC94
	[NullableContext(2)]
	public T shift()
	{
		this.LogError("shift");
		return default(T);
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0000CAB5 File Offset: 0x0000ACB5
	public int unshift(params T[] items)
	{
		this.LogError("unshift");
		return 0;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000CAC3 File Offset: 0x0000ACC3
	public T[] splice(int start, int? deleteCount = null, params T[] items)
	{
		this.LogError("splice");
		return new T[0];
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0000CAD6 File Offset: 0x0000ACD6
	public ImmutableArray<T> fill(T value, int? start = null, int? end = null)
	{
		this.LogError("fill");
		return this;
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0000CAE4 File Offset: 0x0000ACE4
	public ImmutableArray<T> copyWithin(int target, int start, int? end = null)
	{
		this.LogError("copyWithin");
		return this;
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06000230 RID: 560 RVA: 0x0000CAF2 File Offset: 0x0000ACF2
	// (set) Token: 0x06000231 RID: 561 RVA: 0x0000CAFA File Offset: 0x0000ACFA
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

	// Token: 0x06000232 RID: 562 RVA: 0x0000CB08 File Offset: 0x0000AD08
	public List<T> concat(params T[][] items)
	{
		List<T> list = new List<T>(this);
		foreach (T[] collection in items)
		{
			list.AddRange(collection);
		}
		return list;
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0000CB38 File Offset: 0x0000AD38
	public List<U> map<[Nullable(2)] U>(Func<T, int, IList<T>, U> callbackfn)
	{
		List<U> list = new List<U>(base.Count);
		for (int i = 0; i < base.Count; i++)
		{
			list.Add(callbackfn(base[i], i, this));
		}
		return list;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0000CB78 File Offset: 0x0000AD78
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

	// Token: 0x06000235 RID: 565 RVA: 0x0000CC0C File Offset: 0x0000AE0C
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

	// Token: 0x06000236 RID: 566 RVA: 0x0000CC50 File Offset: 0x0000AE50
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
