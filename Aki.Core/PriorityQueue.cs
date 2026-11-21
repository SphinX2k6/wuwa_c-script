using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Extension;

// Token: 0x02000057 RID: 87
[NullableContext(1)]
[Nullable(0)]
public class PriorityQueue<[Nullable(2)] T> : IClearable
{
	// Token: 0x060002A5 RID: 677 RVA: 0x0000E754 File Offset: 0x0000C954
	public PriorityQueue(Comparison<T> compare)
	{
		this._Compare = compare;
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0000E77C File Offset: 0x0000C97C
	public void Clone(PriorityQueue<T> origin)
	{
		this.Clear();
		foreach (T item in origin._Heap)
		{
			this._Heap.Add(item);
		}
		foreach (KeyValuePair<T, int> keyValuePair in origin._Hash)
		{
			this._Hash.Add(keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000E830 File Offset: 0x0000CA30
	public int Size
	{
		get
		{
			return this._Heap.Count;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000E83D File Offset: 0x0000CA3D
	public bool Empty
	{
		get
		{
			return this._Heap.Count == 0;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000E850 File Offset: 0x0000CA50
	[Nullable(2)]
	public T Top
	{
		[NullableContext(2)]
		get
		{
			if (this._Heap.Count <= 0)
			{
				Log.Instance.Error(ELogModule.Container, ELogAuthor.LCC, "优先队列为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return default(T);
			}
			return this._Heap[0];
		}
	}

	// Token: 0x060002AA RID: 682 RVA: 0x0000E89C File Offset: 0x0000CA9C
	public void Clear()
	{
		this._Heap.Clear();
		this._Hash.Clear();
	}

	// Token: 0x060002AB RID: 683 RVA: 0x0000E8B4 File Offset: 0x0000CAB4
	public bool Has(T item)
	{
		return this._Hash.ContainsKey(item);
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
	public void ForEach(Func<T, bool> callback)
	{
		foreach (T arg in this._Heap)
		{
			if (!callback(arg))
			{
				break;
			}
		}
	}

	// Token: 0x060002AD RID: 685 RVA: 0x0000E91C File Offset: 0x0000CB1C
	public void Push(T item)
	{
		int count = this._Heap.Count;
		this._Heap.Add(item);
		this._Hash[item] = count;
		this.Up(count);
	}

	// Token: 0x060002AE RID: 686 RVA: 0x0000E958 File Offset: 0x0000CB58
	[NullableContext(2)]
	public T Pop()
	{
		if (this._Heap.Count <= 0)
		{
			Log.Instance.Error(ELogModule.Container, ELogAuthor.LCC, "优先队列为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return default(T);
		}
		T t = this._Heap[0];
		this._Hash.Remove(t);
		T t2 = this._Heap[this._Heap.Count - 1];
		this._Heap.RemoveAt(this._Heap.Count - 1);
		if (this._Heap.Count > 0)
		{
			this._Heap[0] = t2;
			this._Hash[t2] = 0;
			this.Down(0);
		}
		return t;
	}

	// Token: 0x060002AF RID: 687 RVA: 0x0000EA14 File Offset: 0x0000CC14
	public bool Remove(T item)
	{
		int num;
		if (!this._Hash.TryGetValue(item, out num))
		{
			Log.Instance.Error(ELogModule.Container, ELogAuthor.LCC, "元素不在优先队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (num == this._Heap.Count - 1)
		{
			this._Heap.RemoveAt(this._Heap.Count - 1);
			this._Hash.Remove(item);
			return true;
		}
		this._Hash.Remove(item);
		T t = this._Heap[this._Heap.Count - 1];
		this._Heap.RemoveAt(this._Heap.Count - 1);
		this._Heap[num] = t;
		this._Hash[t] = num;
		this.Down(num);
		return true;
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
	public bool Update(T item)
	{
		int index;
		if (!this._Hash.TryGetValue(item, out index))
		{
			Log.Instance.Error(ELogModule.Container, ELogAuthor.LCC, "元素不在优先队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (!this.Up(index))
		{
			this.Down(index);
		}
		return true;
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x0000EB34 File Offset: 0x0000CD34
	public void Heapify()
	{
		for (int i = (this._Heap.Count - 2) / 2; i >= 0; i--)
		{
			this.Down(i);
		}
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x0000EB64 File Offset: 0x0000CD64
	private bool Up(int index)
	{
		bool result = false;
		int i = index;
		while (i > 0)
		{
			int num = (i - 1) / 2;
			if (this._Compare(this._Heap[i], this._Heap[num]) >= 0)
			{
				break;
			}
			this.Swap(i, num);
			i = num;
			result = true;
		}
		return result;
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x0000EBB4 File Offset: 0x0000CDB4
	private bool Down(int index)
	{
		bool result = false;
		int num = index;
		for (;;)
		{
			int num2 = 2 * num + 1;
			int num3 = 2 * num + 2;
			int num4 = num2;
			if (num3 < this._Heap.Count && this._Compare(this._Heap[num3], this._Heap[num2]) < 0)
			{
				num4 = num3;
			}
			if (num4 >= this._Heap.Count || this._Compare(this._Heap[num], this._Heap[num4]) <= 0)
			{
				break;
			}
			this.Swap(num, num4);
			num = num4;
			result = true;
		}
		return result;
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x0000EC58 File Offset: 0x0000CE58
	private void Swap(int i, int j)
	{
		T value = this._Heap[i];
		this._Heap[i] = this._Heap[j];
		this._Heap[j] = value;
		this._Hash[this._Heap[i]] = i;
		this._Hash[this._Heap[j]] = j;
	}

	// Token: 0x040001F6 RID: 502
	private readonly List<T> _Heap = new List<T>();

	// Token: 0x040001F7 RID: 503
	private readonly Dictionary<T, int> _Hash = new Dictionary<T, int>();

	// Token: 0x040001F8 RID: 504
	private readonly Comparison<T> _Compare;
}
