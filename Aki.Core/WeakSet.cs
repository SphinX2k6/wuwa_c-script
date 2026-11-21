using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000066 RID: 102
[NullableContext(1)]
[Nullable(0)]
public class WeakSet<T> where T : class
{
	// Token: 0x06000330 RID: 816 RVA: 0x000114F5 File Offset: 0x0000F6F5
	public WeakSet()
	{
		this.Buckets = new int[8];
		this.Entries = new WeakSet<T>.Entry[8];
		Array.Fill<int>(this.Buckets, -1);
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00011528 File Offset: 0x0000F728
	protected override void Finalize()
	{
		try
		{
			for (int i = 0; i < this.Count; i++)
			{
				if (this.Entries[i].Handle.IsAllocated)
				{
					this.Entries[i].Handle.Free();
				}
			}
		}
		finally
		{
			base.Finalize();
		}
	}

	// Token: 0x06000332 RID: 818 RVA: 0x00011590 File Offset: 0x0000F790
	public bool Add(T value)
	{
		int hashCode = RuntimeHelpers.GetHashCode(value);
		for (int i = this.Buckets[hashCode & this.Buckets.Length - 1]; i >= 0; i = this.Entries[i].Next)
		{
			ref WeakSet<T>.Entry ptr = ref this.Entries[i];
			if (ptr.HashCode == hashCode && ptr.Handle.Target == value)
			{
				return false;
			}
		}
		int num = this.TakeSlot();
		ref WeakSet<T>.Entry ptr2 = ref this.Entries[num];
		ptr2.HashCode = hashCode;
		if (ptr2.Handle.IsAllocated)
		{
			ptr2.Handle.Target = value;
		}
		else
		{
			ptr2.Handle = GCHandle.Alloc(value, GCHandleType.Weak);
		}
		int num2 = hashCode & this.Buckets.Length - 1;
		ptr2.Next = this.Buckets[num2];
		this.Buckets[num2] = num;
		return true;
	}

	// Token: 0x06000333 RID: 819 RVA: 0x0001167C File Offset: 0x0000F87C
	public bool Has(T value)
	{
		int hashCode = RuntimeHelpers.GetHashCode(value);
		for (int i = this.Buckets[hashCode & this.Buckets.Length - 1]; i >= 0; i = this.Entries[i].Next)
		{
			ref WeakSet<T>.Entry ptr = ref this.Entries[i];
			if (ptr.HashCode == hashCode && ptr.Handle.Target == value)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000334 RID: 820 RVA: 0x000116F0 File Offset: 0x0000F8F0
	public bool Remove(T value)
	{
		int hashCode = RuntimeHelpers.GetHashCode(value);
		int num = hashCode & this.Buckets.Length - 1;
		int num2 = -1;
		int next;
		for (int i = this.Buckets[num]; i >= 0; i = next)
		{
			ref WeakSet<T>.Entry ptr = ref this.Entries[i];
			next = ptr.Next;
			if (ptr.HashCode == hashCode && ptr.Handle.Target == value)
			{
				if (num2 < 0)
				{
					this.Buckets[num] = next;
				}
				else
				{
					this.Entries[num2].Next = next;
				}
				ptr.Handle.Target = null;
				ptr.Next = this.FreeList;
				this.FreeList = i;
				this.FreeCount++;
				return true;
			}
			num2 = i;
		}
		return false;
	}

	// Token: 0x06000335 RID: 821 RVA: 0x000117BC File Offset: 0x0000F9BC
	public void Clear()
	{
		for (int i = 0; i < this.Count; i++)
		{
			ref WeakSet<T>.Entry ptr = ref this.Entries[i];
			if (ptr.Handle.IsAllocated)
			{
				ptr.Handle.Free();
				ptr.Handle = default(GCHandle);
			}
		}
		Array.Fill<int>(this.Buckets, -1);
		this.Count = 0;
		this.FreeList = -1;
		this.FreeCount = 0;
	}

	// Token: 0x06000336 RID: 822 RVA: 0x0001182C File Offset: 0x0000FA2C
	private int TakeSlot()
	{
		if (this.FreeList < 0 && this.Count >= this.Entries.Length)
		{
			this.Reindex(this.Entries.Length);
			if (this.FreeCount < this.Entries.Length / 4)
			{
				this.Reindex(this.Entries.Length * 2);
			}
		}
		if (this.FreeList >= 0)
		{
			int freeList = this.FreeList;
			this.FreeList = this.Entries[freeList].Next;
			this.FreeCount--;
			return freeList;
		}
		int count = this.Count;
		this.Count = count + 1;
		return count;
	}

	// Token: 0x06000337 RID: 823 RVA: 0x000118CC File Offset: 0x0000FACC
	private void Reindex(int capacity)
	{
		if (capacity != this.Entries.Length)
		{
			Array.Resize<WeakSet<T>.Entry>(ref this.Entries, capacity);
		}
		this.Buckets = new int[capacity];
		Array.Fill<int>(this.Buckets, -1);
		this.FreeList = -1;
		this.FreeCount = 0;
		for (int i = 0; i < this.Count; i++)
		{
			ref WeakSet<T>.Entry ptr = ref this.Entries[i];
			if (ptr.Handle.IsAllocated && ptr.Handle.Target != null)
			{
				int num = ptr.HashCode & capacity - 1;
				ptr.Next = this.Buckets[num];
				this.Buckets[num] = i;
			}
			else
			{
				ptr.Next = this.FreeList;
				this.FreeList = i;
				this.FreeCount++;
			}
		}
	}

	// Token: 0x04000231 RID: 561
	private const int InitialCapacity = 8;

	// Token: 0x04000232 RID: 562
	private int[] Buckets;

	// Token: 0x04000233 RID: 563
	[Nullable(new byte[]
	{
		1,
		0,
		0
	})]
	private WeakSet<T>.Entry[] Entries;

	// Token: 0x04000234 RID: 564
	private int Count;

	// Token: 0x04000235 RID: 565
	private int FreeList = -1;

	// Token: 0x04000236 RID: 566
	private int FreeCount;

	// Token: 0x020001A3 RID: 419
	[NullableContext(0)]
	private struct Entry
	{
		// Token: 0x040007E4 RID: 2020
		public GCHandle Handle;

		// Token: 0x040007E5 RID: 2021
		public int HashCode;

		// Token: 0x040007E6 RID: 2022
		public int Next;
	}
}
