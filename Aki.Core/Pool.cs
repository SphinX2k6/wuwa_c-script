using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000056 RID: 86
[NullableContext(1)]
[Nullable(0)]
public class Pool<T> where T : class
{
	// Token: 0x17000058 RID: 88
	// (get) Token: 0x0600029F RID: 671 RVA: 0x0000E4CD File Offset: 0x0000C6CD
	public int Size
	{
		get
		{
			return this.UsedSize + this.UnusedList.Count;
		}
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x0000E4E1 File Offset: 0x0000C6E1
	public Pool(int capacity, Func<T> creator, [Nullable(new byte[]
	{
		2,
		1
	})] Action<T> clearer = null)
	{
		this.Capacity = capacity;
		this.Creator = creator;
		this.Clearer = clearer;
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x0000E514 File Offset: 0x0000C714
	[NullableContext(2)]
	public T Create()
	{
		if (this.Creator == null)
		{
			Log.Instance.Error(ELogModule.Core, ELogAuthor.LCC, "创建器不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return default(T);
		}
		T t = this.Creator();
		if (t == null)
		{
			Log.Instance.Error(ELogModule.Core, ELogAuthor.LCC, "创建器创建值为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return default(T);
		}
		this.UsedSize++;
		this.UsedSet.Add(t);
		return t;
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x0000E5A4 File Offset: 0x0000C7A4
	[NullableContext(2)]
	public T Get()
	{
		if (this.UnusedList.Count <= 0)
		{
			return default(T);
		}
		T t = this.UnusedList[this.UnusedList.Count - 1];
		this.UnusedList.RemoveAt(this.UnusedList.Count - 1);
		this.UsedSize++;
		this.UsedSet.Add(t);
		return t;
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x0000E618 File Offset: 0x0000C818
	[NullableContext(2)]
	public bool Put(T value)
	{
		if (value == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "无效对象";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (!this.UsedSet.Remove(value))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Pool;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "非池中对象";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("value", value);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		this.UsedSize--;
		if (this.Size < this.Capacity)
		{
			this.UnusedList.Add(value);
			return true;
		}
		if (this.Clearer != null)
		{
			this.Clearer(value);
		}
		return false;
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
	public void Clear()
	{
		foreach (T obj in this.UnusedList)
		{
			if (this.Clearer != null)
			{
				this.Clearer(obj);
			}
		}
		this.UnusedList.Clear();
		this.UsedSize = 0;
		this.UsedSet.Clear();
	}

	// Token: 0x040001F0 RID: 496
	private readonly List<T> UnusedList = new List<T>();

	// Token: 0x040001F1 RID: 497
	private readonly WeakSet<T> UsedSet = new WeakSet<T>();

	// Token: 0x040001F2 RID: 498
	private int UsedSize;

	// Token: 0x040001F3 RID: 499
	private readonly int Capacity;

	// Token: 0x040001F4 RID: 500
	[Nullable(2)]
	private readonly Func<T> Creator;

	// Token: 0x040001F5 RID: 501
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly Action<T> Clearer;
}
