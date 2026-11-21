using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Extension;

// Token: 0x0200005D RID: 93
[NullableContext(2)]
[Nullable(0)]
public class Queue<T> : IEnumerable<!0>, IEnumerable, IClearable
{
	// Token: 0x060002DE RID: 734 RVA: 0x0000F1E6 File Offset: 0x0000D3E6
	public Queue(int capacity = 4)
	{
		this.DefaultCapacity = capacity;
		this.DataArray = new T[capacity];
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060002DF RID: 735 RVA: 0x0000F201 File Offset: 0x0000D401
	public int Size
	{
		get
		{
			return this.SizeInternal;
		}
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x0000F20C File Offset: 0x0000D40C
	[NullableContext(1)]
	public void Push(T element)
	{
		if (this.SizeInternal == this.DataArray.Length)
		{
			int num = this.DataArray.Length * 2;
			if (num < this.DataArray.Length + 4)
			{
				num = this.DataArray.Length + 4;
			}
			this.SetCapacity(num);
		}
		this.DataArray[this.Tail] = element;
		this.Tail = (this.Tail + 1) % this.DataArray.Length;
		this.SizeInternal++;
		this.Version++;
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x0000F298 File Offset: 0x0000D498
	public T Pop()
	{
		if (this.SizeInternal == 0)
		{
			Log.Instance.Error(ELogModule.Container, ELogAuthor.LFJW, "队列为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return default(T);
		}
		T result = this.DataArray[this.Head];
		this.DataArray[this.Head] = default(T);
		this.Head = (this.Head + 1) % this.DataArray.Length;
		this.SizeInternal--;
		this.Version++;
		int num = this.DataArray.Length;
		if (num > 4 && num > this.DefaultCapacity)
		{
			int num2 = num / 2;
			if (this.SizeInternal == num2)
			{
				int num3 = (int)((float)num * 0.75f);
				if (num3 > this.DefaultCapacity)
				{
					this.SetCapacity(num3);
				}
			}
		}
		return result;
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x0000F370 File Offset: 0x0000D570
	public bool TryPop(out T Result)
	{
		if (this.SizeInternal == 0)
		{
			Result = default(T);
			return false;
		}
		Result = this.DataArray[this.Head];
		this.DataArray[this.Head] = default(T);
		this.Head = (this.Head + 1) % this.DataArray.Length;
		this.SizeInternal--;
		this.Version++;
		int num = this.DataArray.Length;
		if (num > 4 && num > this.DefaultCapacity)
		{
			int num2 = num / 2;
			if (this.SizeInternal == num2)
			{
				int num3 = (int)((float)num * 0.75f);
				if (num3 > this.DefaultCapacity)
				{
					this.SetCapacity(num3);
				}
			}
		}
		return true;
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000F430 File Offset: 0x0000D630
	public T Front
	{
		get
		{
			if (this.SizeInternal == 0)
			{
				Log.Instance.Error(ELogModule.Container, ELogAuthor.LFJW, "队列为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return default(T);
			}
			return this.DataArray[this.Head];
		}
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x0000F47B File Offset: 0x0000D67B
	public bool TryGetFront(out T Result)
	{
		if (this.SizeInternal == 0)
		{
			Result = default(T);
			return false;
		}
		Result = this.DataArray[this.Head];
		return true;
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0000F4A8 File Offset: 0x0000D6A8
	public unsafe T Get(int index)
	{
		if (this.SizeInternal == 0)
		{
			Log.Instance.Error(ELogModule.Container, ELogAuthor.WCL, "队列为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return default(T);
		}
		if (index < 0 || index >= this.SizeInternal)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Container;
			ELogAuthor author = ELogAuthor.WCL;
			string message = "下标越界";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("index", index);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("size", this.SizeInternal);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return default(T);
		}
		return this.DataArray[(this.Head + index) % this.DataArray.Length];
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x0000F578 File Offset: 0x0000D778
	private void SetCapacity(int capacity)
	{
		if (this.SizeInternal == 0)
		{
			this.DataArray = new T[capacity];
			this.Head = 0;
			this.Tail = 0;
			return;
		}
		int num = this.DataArray.Length;
		if (capacity < num)
		{
			if (this.Head == 0)
			{
				T[] array = new T[capacity];
				Array.Copy(this.DataArray, 0, array, 0, capacity);
				this.DataArray = array;
				this.Tail %= capacity;
				return;
			}
			int num2 = num - capacity;
			int num3 = num - num2;
			if (this.Head < this.Tail)
			{
				int num4 = 0;
				for (int i = num3; i < this.Tail; i++)
				{
					this.DataArray[num4++] = this.DataArray[i];
					this.DataArray[i] = default(T);
				}
				if (num3 <= this.Head)
				{
					this.Head = (this.Head + num2) % capacity;
				}
				int num5 = this.Tail - num3;
				if (num5 > 0)
				{
					this.Tail = num5 % capacity;
				}
				else
				{
					this.Tail %= capacity;
				}
				T[] array2 = new T[capacity];
				Array.Copy(this.DataArray, 0, array2, 0, capacity);
				this.DataArray = array2;
				return;
			}
			if (this.Head >= this.Tail)
			{
				int num6 = num - this.Head;
				int num7 = capacity - num6;
				for (int j = 0; j < num6; j++)
				{
					this.DataArray[num7 + j] = this.DataArray[this.Head + j];
					this.DataArray[this.Head + j] = default(T);
				}
				T[] array3 = new T[capacity];
				Array.Copy(this.DataArray, 0, array3, 0, capacity);
				this.DataArray = array3;
				this.Head = num7;
				return;
			}
		}
		else
		{
			T[] array4 = new T[capacity];
			Array.Copy(this.DataArray, 0, array4, 0, this.DataArray.Length);
			this.DataArray = array4;
			if (this.Tail == 0)
			{
				this.Tail = this.SizeInternal;
				return;
			}
			if (this.Head >= this.Tail)
			{
				int num8 = num - this.Head;
				int num9 = this.DataArray.Length - num8;
				for (int k = 0; k < num8; k++)
				{
					this.DataArray[num9 + k] = this.DataArray[this.Head + k];
					this.DataArray[this.Head + k] = default(T);
				}
				this.Head = num9;
			}
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000F80F File Offset: 0x0000DA0F
	public bool Empty
	{
		get
		{
			return this.SizeInternal == 0;
		}
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x0000F81A File Offset: 0x0000DA1A
	public void Clear()
	{
		Array.Clear(this.DataArray, 0, this.DataArray.Length);
		this.Head = 0;
		this.Tail = 0;
		this.SizeInternal = 0;
		this.Version++;
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x0000F853 File Offset: 0x0000DA53
	[NullableContext(1)]
	public IEnumerator<T> GetEnumerator()
	{
		return new Queue<T>.Enumerator(this);
	}

	// Token: 0x060002EA RID: 746 RVA: 0x0000F860 File Offset: 0x0000DA60
	[NullableContext(1)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x04000201 RID: 513
	private const int MINIMUM_GROW = 4;

	// Token: 0x04000202 RID: 514
	private const float THREE_QUARTER = 0.75f;

	// Token: 0x04000203 RID: 515
	private int Version;

	// Token: 0x04000204 RID: 516
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private T[] DataArray;

	// Token: 0x04000205 RID: 517
	private readonly int DefaultCapacity;

	// Token: 0x04000206 RID: 518
	private int Head;

	// Token: 0x04000207 RID: 519
	private int Tail;

	// Token: 0x04000208 RID: 520
	private int SizeInternal;

	// Token: 0x020001A1 RID: 417
	[NullableContext(1)]
	[Nullable(0)]
	private struct Enumerator : IEnumerator<!0>, IEnumerator, IDisposable
	{
		// Token: 0x06000D58 RID: 3416 RVA: 0x0003E304 File Offset: 0x0003C504
		public Enumerator(Queue<T> queue)
		{
			this.<queue>P = queue;
			this.Index = 0;
			this.Current = default(T);
			this.Version = this.<queue>P.Version;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0003E334 File Offset: 0x0003C534
		public bool MoveNext()
		{
			if (this.Version != this.<queue>P.Version)
			{
				throw new InvalidOperationException("The queue was modified during foreach");
			}
			if (this.Index < this.<queue>P.SizeInternal)
			{
				Queue<T> queue = this.<queue>P;
				int index = this.Index;
				this.Index = index + 1;
				this.Current = queue.Get(index);
				return true;
			}
			return false;
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0003E397 File Offset: 0x0003C597
		public void Reset()
		{
			this.Index = 0;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0003E3A0 File Offset: 0x0003C5A0
		T IEnumerator<!0>.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x0003E3A8 File Offset: 0x0003C5A8
		[Nullable(2)]
		object IEnumerator.Current
		{
			[NullableContext(2)]
			get
			{
				return this.Current;
			}
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x0003E3B5 File Offset: 0x0003C5B5
		public void Dispose()
		{
		}

		// Token: 0x040007DD RID: 2013
		[CompilerGenerated]
		private Queue<T> <queue>P;

		// Token: 0x040007DE RID: 2014
		private readonly int Version;

		// Token: 0x040007DF RID: 2015
		private int Index;

		// Token: 0x040007E0 RID: 2016
		private T Current;
	}
}
