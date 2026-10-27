using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002E18 RID: 11800
[NullableContext(1)]
[Nullable(0)]
public class SimplePool<[Nullable(2)] T>
{
	// Token: 0x06018D58 RID: 101720 RVA: 0x0065ECC4 File Offset: 0x0065CEC4
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

	// Token: 0x06018D59 RID: 101721 RVA: 0x0065ED1C File Offset: 0x0065CF1C
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

	// Token: 0x06018D5A RID: 101722 RVA: 0x0065ED6C File Offset: 0x0065CF6C
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

	// Token: 0x06018D5B RID: 101723 RVA: 0x0065EDB9 File Offset: 0x0065CFB9
	public void Clear()
	{
		this.UnusedList.Clear();
	}

	// Token: 0x0400BA55 RID: 47701
	private readonly List<T> UnusedList = new List<T>();
}
