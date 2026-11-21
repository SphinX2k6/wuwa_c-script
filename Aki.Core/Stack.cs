using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Extension;

// Token: 0x02000061 RID: 97
[NullableContext(1)]
[Nullable(0)]
public class Stack<[Nullable(2)] T> : IEnumerable<!0>, IEnumerable, IClearable
{
	// Token: 0x06000303 RID: 771 RVA: 0x00010780 File Offset: 0x0000E980
	public IEnumerator<T> GetEnumerator()
	{
		return this.List.GetEnumerator();
	}

	// Token: 0x06000304 RID: 772 RVA: 0x00010792 File Offset: 0x0000E992
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000305 RID: 773 RVA: 0x0001079A File Offset: 0x0000E99A
	public int Size
	{
		get
		{
			return this.List.Count;
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000306 RID: 774 RVA: 0x000107A7 File Offset: 0x0000E9A7
	public bool Empty
	{
		get
		{
			return this.Size == 0;
		}
	}

	// Token: 0x06000307 RID: 775 RVA: 0x000107B2 File Offset: 0x0000E9B2
	public void Clear()
	{
		this.List.Clear();
	}

	// Token: 0x06000308 RID: 776 RVA: 0x000107BF File Offset: 0x0000E9BF
	public void Push(T element)
	{
		this.List.Add(element);
	}

	// Token: 0x06000309 RID: 777 RVA: 0x000107D0 File Offset: 0x0000E9D0
	[NullableContext(2)]
	public T Peek()
	{
		if (this.Size <= 0)
		{
			return default(T);
		}
		return this.List[this.List.Count - 1];
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00010808 File Offset: 0x0000EA08
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

	// Token: 0x0600030B RID: 779 RVA: 0x0001085C File Offset: 0x0000EA5C
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

	// Token: 0x04000214 RID: 532
	private readonly List<T> List = new List<T>();
}
