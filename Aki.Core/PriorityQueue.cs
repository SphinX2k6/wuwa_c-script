using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Extension;

// Token: 0x02000055 RID: 85
[NullableContext(1)]
[Nullable(0)]
public class PriorityQueue<[Nullable(2)] T> : IClearable
{
	// Token: 0x0600026A RID: 618 RVA: 0x0000D96C File Offset: 0x0000BB6C
	public PriorityQueue(Comparison<T> compare)
	{
		this._Compare = compare;
	}

	// Token: 0x0600026B RID: 619 RVA: 0x0000D994 File Offset: 0x0000BB94
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

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x0600026C RID: 620 RVA: 0x0000DA48 File Offset: 0x0000BC48
	public int Size
	{
		get
		{
			return this._Heap.Count;
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x0600026D RID: 621 RVA: 0x0000DA55 File Offset: 0x0000BC55
	public bool Empty
	{
		get
		{
			return this._Heap.Count == 0;
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600026E RID: 622 RVA: 0x0000DA68 File Offset: 0x0000BC68
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

	// Token: 0x0600026F RID: 623 RVA: 0x0000DAB4 File Offset: 0x0000BCB4
	public void Clear()
	{
		this._Heap.Clear();
		this._Hash.Clear();
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0000DACC File Offset: 0x0000BCCC
	public bool Has(T item)
	{
		return this._Hash.ContainsKey(item);
	}

	// Token: 0x06000271 RID: 625 RVA: 0x0000DADC File Offset: 0x0000BCDC
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

	// Token: 0x06000272 RID: 626 RVA: 0x0000DB34 File Offset: 0x0000BD34
	public void Push(T item)
	{
		int count = this._Heap.Count;
		this._Heap.Add(item);
		this._Hash[item] = count;
		this.Up(count);
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0000DB70 File Offset: 0x0000BD70
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

	// Token: 0x06000274 RID: 628 RVA: 0x0000DC2C File Offset: 0x0000BE2C
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

	// Token: 0x06000275 RID: 629 RVA: 0x0000DD00 File Offset: 0x0000BF00
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

	// Token: 0x06000276 RID: 630 RVA: 0x0000DD4C File Offset: 0x0000BF4C
	public void Heapify()
	{
		for (int i = (this._Heap.Count - 2) / 2; i >= 0; i--)
		{
			this.Down(i);
		}
	}

	// Token: 0x06000277 RID: 631 RVA: 0x0000DD7C File Offset: 0x0000BF7C
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

	// Token: 0x06000278 RID: 632 RVA: 0x0000DDCC File Offset: 0x0000BFCC
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

	// Token: 0x06000279 RID: 633 RVA: 0x0000DE70 File Offset: 0x0000C070
	private void Swap(int i, int j)
	{
		T value = this._Heap[i];
		this._Heap[i] = this._Heap[j];
		this._Heap[j] = value;
		this._Hash[this._Heap[i]] = i;
		this._Hash[this._Heap[j]] = j;
	}

	// Token: 0x040001E0 RID: 480
	private readonly List<T> _Heap = new List<T>();

	// Token: 0x040001E1 RID: 481
	private readonly Dictionary<T, int> _Hash = new Dictionary<T, int>();

	// Token: 0x040001E2 RID: 482
	private readonly Comparison<T> _Compare;
}
