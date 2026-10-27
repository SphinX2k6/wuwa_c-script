using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000064 RID: 100
[NullableContext(1)]
[Nullable(0)]
public class WeakSet<T> where T : class
{
	// Token: 0x060002F5 RID: 757 RVA: 0x0001070D File Offset: 0x0000E90D
	public WeakSet()
	{
		this.Buckets = new int[8];
		this.Entries = new WeakSet<T>.Entry[8];
		Array.Fill<int>(this.Buckets, -1);
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00010740 File Offset: 0x0000E940
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

	// Token: 0x060002F7 RID: 759 RVA: 0x000107A8 File Offset: 0x0000E9A8
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

	// Token: 0x060002F8 RID: 760 RVA: 0x00010894 File Offset: 0x0000EA94
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

	// Token: 0x060002F9 RID: 761 RVA: 0x00010908 File Offset: 0x0000EB08
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

	// Token: 0x060002FA RID: 762 RVA: 0x000109D4 File Offset: 0x0000EBD4
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

	// Token: 0x060002FB RID: 763 RVA: 0x00010A44 File Offset: 0x0000EC44
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

	// Token: 0x060002FC RID: 764 RVA: 0x00010AE4 File Offset: 0x0000ECE4
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

	// Token: 0x0400021B RID: 539
	private const int InitialCapacity = 8;

	// Token: 0x0400021C RID: 540
	private int[] Buckets;

	// Token: 0x0400021D RID: 541
	[Nullable(new byte[]
	{
		1,
		0,
		0
	})]
	private WeakSet<T>.Entry[] Entries;

	// Token: 0x0400021E RID: 542
	private int Count;

	// Token: 0x0400021F RID: 543
	private int FreeList = -1;

	// Token: 0x04000220 RID: 544
	private int FreeCount;

	// Token: 0x02000199 RID: 409
	[NullableContext(0)]
	private struct Entry
	{
		// Token: 0x040007C4 RID: 1988
		public GCHandle Handle;

		// Token: 0x040007C5 RID: 1989
		public int HashCode;

		// Token: 0x040007C6 RID: 1990
		public int Next;
	}
}
