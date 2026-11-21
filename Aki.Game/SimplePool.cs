using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002374 RID: 9076
[NullableContext(1)]
[Nullable(0)]
public class SimplePool<[Nullable(2)] T>
{
	// Token: 0x0601661A RID: 91674 RVA: 0x00684E4C File Offset: 0x0068304C
	[NullableContext(2)]
	public T Get()
	{
		if (this.UnusedList.Count <= 0)
		{
			return default(T);
		}
		T result = this.UnusedList[this.UnusedList.Count - 1];
		this.UnusedList.RemoveAt(this.UnusedList.Count - 1);
		return result;
	}

	// Token: 0x0601661B RID: 91675 RVA: 0x00684EA4 File Offset: 0x006830A4
	public void PreloadAdd(T target)
	{
		if (target == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Pool;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "无效对象";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("target", target);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.UnusedList.Add(target);
	}

	// Token: 0x0601661C RID: 91676 RVA: 0x00684EF4 File Offset: 0x006830F4
	public void Release(T target)
	{
		if (target == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Pool;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "无效对象";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("target", target);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.UnusedList.Add(target);
	}

	// Token: 0x0601661D RID: 91677 RVA: 0x00684F41 File Offset: 0x00683141
	public void Clear()
	{
		this.UnusedList.Clear();
	}

	// Token: 0x0400BDE3 RID: 48611
	private readonly List<T> UnusedList = new List<T>();
}
