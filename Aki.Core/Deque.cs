using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Extension;

// Token: 0x02000047 RID: 71
[NullableContext(2)]
[Nullable(0)]
public class Deque<T> : IClearable
{
	// Token: 0x060001F1 RID: 497 RVA: 0x0000BA04 File Offset: 0x00009C04
	public Deque(int capacity = 4)
	{
		this.DefaultCapacity = capacity;
		this.DataArray = new T[capacity];
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x0000BA20 File Offset: 0x00009C20
	[NullableContext(1)]
	public void Clone(Deque<T> origin)
	{
		this.Clear();
		this.DataArray = new T[origin.DataArray.Length];
		for (int i = 0; i < origin.Size; i++)
		{
			T t = origin.DataArray[(origin.Head + i) % origin.DataArray.Length];
			this.DataArray[i] = t;
		}
		this.SizeInternal = origin.Size;
		this.Tail = origin.Size;
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000BA99 File Offset: 0x00009C99
	public int Size
	{
		get
		{
			return this.SizeInternal;
		}
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x0000BAA4 File Offset: 0x00009CA4
	[NullableContext(1)]
	public void AddFront(T element)
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
		int num2 = (this.Head - 1 + this.DataArray.Length) % this.DataArray.Length;
		this.DataArray[num2] = element;
		this.Head = num2;
		this.SizeInternal++;
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x0000BB28 File Offset: 0x00009D28
	[NullableContext(1)]
	public void AddRear(T element)
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
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000BBA8 File Offset: 0x00009DA8
	public T Front
	{
		get
		{
			if (this.SizeInternal == 0)
			{
				Log.Instance.Error(ELogModule.Container, ELogAuthor.WCL, "队列为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return default(T);
			}
			return this.DataArray[this.Head];
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000BBF4 File Offset: 0x00009DF4
	public T Rear
	{
		get
		{
			if (this.SizeInternal == 0)
			{
				Log.Instance.Error(ELogModule.Container, ELogAuthor.WCL, "队列为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return default(T);
			}
			int num = (this.Tail - 1 + this.DataArray.Length) % this.DataArray.Length;
			return this.DataArray[num];
		}
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x0000BC58 File Offset: 0x00009E58
	public T RemoveFront()
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
		int num = this.DataArray.Length;
		if (num > 4 && num > this.DefaultCapacity)
		{
			int num2 = (int)Math.Floor((double)num / 2.0);
			if (this.SizeInternal == num2)
			{
				int num3 = (int)Math.Floor((double)((float)num * 0.75f));
				if (num3 > this.DefaultCapacity)
				{
					this.SetCapacity(num3);
				}
			}
		}
		return result;
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x0000BD38 File Offset: 0x00009F38
	public T RemoveRear()
	{
		if (this.SizeInternal == 0)
		{
			Log.Instance.Error(ELogModule.Container, ELogAuthor.WCL, "队列为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return default(T);
		}
		int num = (this.Tail - 1 + this.DataArray.Length) % this.DataArray.Length;
		T result = this.DataArray[num];
		this.DataArray[num] = default(T);
		this.Tail = num;
		this.SizeInternal--;
		int num2 = this.DataArray.Length;
		if (num2 > 4 && num2 > this.DefaultCapacity)
		{
			int num3 = (int)Math.Floor((double)num2 / 2.0);
			if (this.SizeInternal == num3)
			{
				int num4 = (int)Math.Floor((double)((float)num2 * 0.75f));
				if (num4 > this.DefaultCapacity)
				{
					this.SetCapacity(num4);
				}
			}
		}
		return result;
	}

	// Token: 0x060001FA RID: 506 RVA: 0x0000BE1C File Offset: 0x0000A01C
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

	// Token: 0x060001FB RID: 507 RVA: 0x0000BEEC File Offset: 0x0000A0EC
	private void SetCapacity(int capacity)
	{
		if (this.SizeInternal == 0)
		{
			Array.Resize<T>(ref this.DataArray, capacity);
			this.Head = 0;
			this.Tail = 0;
			return;
		}
		int num = this.DataArray.Length;
		if (capacity < num)
		{
			if (this.Head == 0)
			{
				Array.Resize<T>(ref this.DataArray, capacity);
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
				Array.Resize<T>(ref this.DataArray, capacity);
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
				Array.Resize<T>(ref this.DataArray, capacity);
				this.Head = num7;
				return;
			}
		}
		else
		{
			Array.Resize<T>(ref this.DataArray, capacity);
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

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060001FC RID: 508 RVA: 0x0000C12C File Offset: 0x0000A32C
	public bool Empty
	{
		get
		{
			return this.SizeInternal == 0;
		}
	}

	// Token: 0x060001FD RID: 509 RVA: 0x0000C137 File Offset: 0x0000A337
	public void Clear()
	{
		Array.Resize<T>(ref this.DataArray, 0);
		this.Head = 0;
		this.Tail = 0;
		this.SizeInternal = 0;
	}

	// Token: 0x040001AD RID: 429
	private const int MINIMUM_GROW = 4;

	// Token: 0x040001AE RID: 430
	private const float THREE_QUARTER = 0.75f;

	// Token: 0x040001AF RID: 431
	[Nullable(1)]
	private T[] DataArray;

	// Token: 0x040001B0 RID: 432
	private readonly int DefaultCapacity;

	// Token: 0x040001B1 RID: 433
	private int Head;

	// Token: 0x040001B2 RID: 434
	private int Tail;

	// Token: 0x040001B3 RID: 435
	private int SizeInternal;
}
