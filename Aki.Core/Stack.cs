using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Extension;

// Token: 0x0200005F RID: 95
[NullableContext(1)]
[Nullable(0)]
public class Stack<[Nullable(2)] T> : IEnumerable<T>, IEnumerable, IClearable
{
	// Token: 0x060002C8 RID: 712 RVA: 0x0000F998 File Offset: 0x0000DB98
	public IEnumerator<T> GetEnumerator()
	{
		return this.List.GetEnumerator();
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x0000F9AA File Offset: 0x0000DBAA
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060002CA RID: 714 RVA: 0x0000F9B2 File Offset: 0x0000DBB2
	public int Size
	{
		get
		{
			return this.List.Count;
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060002CB RID: 715 RVA: 0x0000F9BF File Offset: 0x0000DBBF
	public bool Empty
	{
		get
		{
			return this.Size == 0;
		}
	}

	// Token: 0x060002CC RID: 716 RVA: 0x0000F9CA File Offset: 0x0000DBCA
	public void Clear()
	{
		this.List.Clear();
	}

	// Token: 0x060002CD RID: 717 RVA: 0x0000F9D7 File Offset: 0x0000DBD7
	public void Push(T element)
	{
		this.List.Add(element);
	}

	// Token: 0x060002CE RID: 718 RVA: 0x0000F9E8 File Offset: 0x0000DBE8
	[NullableContext(2)]
	public T Peek()
	{
		if (this.Size <= 0)
		{
			return default(T);
		}
		return this.List[this.List.Count - 1];
	}

	// Token: 0x060002CF RID: 719 RVA: 0x0000FA20 File Offset: 0x0000DC20
	[NullableContext(2)]
	public T Pop()
	{
		if (this.List.Count == 0)
		{
			return default(T);
		}
		T result = this.List[this.List.Count - 1];
		this.List.RemoveAt(this.List.Count - 1);
		return result;
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0000FA74 File Offset: 0x0000DC74
	public bool Delete(T element)
	{
		int num = this.List.IndexOf(element);
		if (num >= 0)
		{
			this.List.RemoveAt(num);
			return true;
		}
		return false;
	}

	// Token: 0x040001FE RID: 510
	private readonly List<T> List = new List<T>();
}
