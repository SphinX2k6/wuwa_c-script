using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000054 RID: 84
[NullableContext(1)]
[Nullable(0)]
public class Pool<T> where T : class
{
	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000264 RID: 612 RVA: 0x0000D6E3 File Offset: 0x0000B8E3
	public int Size
	{
		get
		{
			return this.UsedSize + this.UnusedList.Count;
		}
	}

	// Token: 0x06000265 RID: 613 RVA: 0x0000D6F7 File Offset: 0x0000B8F7
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

	// Token: 0x06000266 RID: 614 RVA: 0x0000D72C File Offset: 0x0000B92C
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

	// Token: 0x06000267 RID: 615 RVA: 0x0000D7BC File Offset: 0x0000B9BC
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

	// Token: 0x06000268 RID: 616 RVA: 0x0000D830 File Offset: 0x0000BA30
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

	// Token: 0x06000269 RID: 617 RVA: 0x0000D8EC File Offset: 0x0000BAEC
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

	// Token: 0x040001DA RID: 474
	private readonly List<T> UnusedList = new List<T>();

	// Token: 0x040001DB RID: 475
	private readonly WeakSet<T> UsedSet = new WeakSet<T>();

	// Token: 0x040001DC RID: 476
	private int UsedSize;

	// Token: 0x040001DD RID: 477
	private readonly int Capacity;

	// Token: 0x040001DE RID: 478
	[Nullable(2)]
	private readonly Func<T> Creator;

	// Token: 0x040001DF RID: 479
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly Action<T> Clearer;
}
