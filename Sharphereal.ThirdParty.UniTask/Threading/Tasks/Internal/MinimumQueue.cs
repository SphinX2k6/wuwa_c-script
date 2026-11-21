using System;
using System.Runtime.CompilerServices;

namespace Sharphereal.UniTaskExtensions.Threading.Tasks.Internal
{
	// Token: 0x0200000B RID: 11
	[NullableContext(1)]
	[Nullable(0)]
	internal class MinimumQueue<[Nullable(2)] T>
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00002AB0 File Offset: 0x00000CB0
		public MinimumQueue(int capacity)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity");
			}
			this.array = new T[capacity];
			this.head = (this.tail = (this.size = 0));
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002AF7 File Offset: 0x00000CF7
		public int Count
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.size;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002AFF File Offset: 0x00000CFF
		public T Peek()
		{
			if (this.size == 0)
			{
				this.ThrowForEmptyQueue();
			}
			return this.array[this.head];
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002B20 File Offset: 0x00000D20
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Enqueue(T item)
		{
			if (this.size == this.array.Length)
			{
				this.Grow();
			}
			this.array[this.tail] = item;
			this.MoveNext(ref this.tail);
			this.size++;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002B70 File Offset: 0x00000D70
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Dequeue()
		{
			if (this.size == 0)
			{
				this.ThrowForEmptyQueue();
			}
			int num = this.head;
			T[] array = this.array;
			T result = array[num];
			array[num] = default(T);
			this.MoveNext(ref this.head);
			this.size--;
			return result;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002BCC File Offset: 0x00000DCC
		private void Grow()
		{
			int num = (int)((long)this.array.Length * 200L / 100L);
			if (num < this.array.Length + 4)
			{
				num = this.array.Length + 4;
			}
			this.SetCapacity(num);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002C10 File Offset: 0x00000E10
		private void SetCapacity(int capacity)
		{
			T[] destinationArray = new T[capacity];
			if (this.size > 0)
			{
				if (this.head < this.tail)
				{
					Array.Copy(this.array, this.head, destinationArray, 0, this.size);
				}
				else
				{
					Array.Copy(this.array, this.head, destinationArray, 0, this.array.Length - this.head);
					Array.Copy(this.array, 0, destinationArray, this.array.Length - this.head, this.tail);
				}
			}
			this.array = destinationArray;
			this.head = 0;
			this.tail = ((this.size == capacity) ? 0 : this.size);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002CC0 File Offset: 0x00000EC0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void MoveNext(ref int index)
		{
			int num = index + 1;
			if (num == this.array.Length)
			{
				num = 0;
			}
			index = num;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002CE2 File Offset: 0x00000EE2
		private void ThrowForEmptyQueue()
		{
			throw new InvalidOperationException("EmptyQueue");
		}

		// Token: 0x04000025 RID: 37
		private const int MinimumGrow = 4;

		// Token: 0x04000026 RID: 38
		private const int GrowFactor = 200;

		// Token: 0x04000027 RID: 39
		private T[] array;

		// Token: 0x04000028 RID: 40
		private int head;

		// Token: 0x04000029 RID: 41
		private int tail;

		// Token: 0x0400002A RID: 42
		private int size;
	}
}
