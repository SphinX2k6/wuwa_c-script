using System;
using System.Runtime;
using System.Runtime.CompilerServices;

// Token: 0x02000065 RID: 101
[NullableContext(1)]
[Nullable(0)]
public class WeakMap<TKey, [Nullable(2)] TValue> where TKey : class
{
	// Token: 0x06000326 RID: 806 RVA: 0x00010FED File Offset: 0x0000F1ED
	public WeakMap()
	{
		this.Buckets = new int[8];
		this.Entries = new WeakMap<TKey, TValue>.Entry[8];
		Array.Fill<int>(this.Buckets, -1);
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00011020 File Offset: 0x0000F220
	protected override void Finalize()
	{
		try
		{
			for (int i = 0; i < this.Count; i++)
			{
				if (this.Entries[i].Handle.IsAllocated)
				{
					this.Entries[i].Handle.Dispose();
				}
			}
		}
		finally
		{
			base.Finalize();
		}
	}

	// Token: 0x06000328 RID: 808 RVA: 0x00011088 File Offset: 0x0000F288
	public void Set(TKey key, TValue value)
	{
		int hashCode = RuntimeHelpers.GetHashCode(key);
		for (int i = this.Buckets[hashCode & this.Buckets.Length - 1]; i >= 0; i = this.Entries[i].Next)
		{
			ref WeakMap<TKey, TValue>.Entry ptr = ref this.Entries[i];
			if (ptr.HashCode == hashCode && ptr.Handle.Target == key)
			{
				ptr.Handle.Dependent = value;
				return;
			}
		}
		int num = this.TakeSlot();
		WeakMap<TKey, TValue>.Entry[] entries = this.Entries;
		int num2 = num;
		entries[num2].HashCode = hashCode;
		entries[num2].Handle = new DependentHandle(key, value);
		int num3 = hashCode & this.Buckets.Length - 1;
		entries[num2].Next = this.Buckets[num3];
		this.Buckets[num3] = num;
	}

	// Token: 0x06000329 RID: 809 RVA: 0x00011160 File Offset: 0x0000F360
	public bool TryGetValue(TKey key, out TValue value)
	{
		int hashCode = RuntimeHelpers.GetHashCode(key);
		for (int i = this.Buckets[hashCode & this.Buckets.Length - 1]; i >= 0; i = this.Entries[i].Next)
		{
			ref WeakMap<TKey, TValue>.Entry ptr = ref this.Entries[i];
			if (ptr.HashCode == hashCode)
			{
				ValueTuple<object, object> targetAndDependent = ptr.Handle.TargetAndDependent;
				object item = targetAndDependent.Item1;
				object item2 = targetAndDependent.Item2;
				if (item == key)
				{
					value = (TValue)((object)item2);
					return true;
				}
			}
		}
		value = default(TValue);
		return false;
	}

	// Token: 0x0600032A RID: 810 RVA: 0x000111F4 File Offset: 0x0000F3F4
	public bool Has(TKey key)
	{
		TValue tvalue;
		return this.TryGetValue(key, out tvalue);
	}

	// Token: 0x0600032B RID: 811 RVA: 0x0001120C File Offset: 0x0000F40C
	public bool Remove(TKey key)
	{
		int hashCode = RuntimeHelpers.GetHashCode(key);
		int num = hashCode & this.Buckets.Length - 1;
		int num2 = -1;
		int next;
		for (int i = this.Buckets[num]; i >= 0; i = next)
		{
			ref WeakMap<TKey, TValue>.Entry ptr = ref this.Entries[i];
			next = ptr.Next;
			if (ptr.HashCode == hashCode && ptr.Handle.Target == key)
			{
				if (num2 < 0)
				{
					this.Buckets[num] = next;
				}
				else
				{
					this.Entries[num2].Next = next;
				}
				ptr.Handle.Dispose();
				ptr.Handle = default(DependentHandle);
				ptr.Next = this.FreeList;
				this.FreeList = i;
				this.FreeCount++;
				return true;
			}
			num2 = i;
		}
		return false;
	}

	// Token: 0x0600032C RID: 812 RVA: 0x000112E4 File Offset: 0x0000F4E4
	public void Clear()
	{
		for (int i = 0; i < this.Count; i++)
		{
			ref WeakMap<TKey, TValue>.Entry ptr = ref this.Entries[i];
			if (ptr.Handle.IsAllocated)
			{
				ptr.Handle.Dispose();
				ptr.Handle = default(DependentHandle);
			}
		}
		Array.Fill<int>(this.Buckets, -1);
		this.Count = 0;
		this.FreeList = -1;
		this.FreeCount = 0;
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00011354 File Offset: 0x0000F554
	public void TrimExcess()
	{
		this.Reindex(this.Entries.Length);
	}

	// Token: 0x0600032E RID: 814 RVA: 0x00011364 File Offset: 0x0000F564
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

	// Token: 0x0600032F RID: 815 RVA: 0x00011404 File Offset: 0x0000F604
	private void Reindex(int capacity)
	{
		if (capacity != this.Entries.Length)
		{
			Array.Resize<WeakMap<TKey, TValue>.Entry>(ref this.Entries, capacity);
		}
		this.Buckets = new int[capacity];
		Array.Fill<int>(this.Buckets, -1);
		this.FreeList = -1;
		this.FreeCount = 0;
		for (int i = 0; i < this.Count; i++)
		{
			ref WeakMap<TKey, TValue>.Entry ptr = ref this.Entries[i];
			if (ptr.Handle.IsAllocated && ptr.Handle.Target != null)
			{
				int num = ptr.HashCode & capacity - 1;
				ptr.Next = this.Buckets[num];
				this.Buckets[num] = i;
			}
			else
			{
				if (ptr.Handle.IsAllocated)
				{
					ptr.Handle.Dispose();
					ptr.Handle = default(DependentHandle);
				}
				ptr.Next = this.FreeList;
				this.FreeList = i;
				this.FreeCount++;
			}
		}
	}

	// Token: 0x0400022B RID: 555
	private const int InitialCapacity = 8;

	// Token: 0x0400022C RID: 556
	private int[] Buckets;

	// Token: 0x0400022D RID: 557
	[Nullable(new byte[]
	{
		1,
		0,
		0,
		0
	})]
	private WeakMap<TKey, TValue>.Entry[] Entries;

	// Token: 0x0400022E RID: 558
	private int Count;

	// Token: 0x0400022F RID: 559
	private int FreeList = -1;

	// Token: 0x04000230 RID: 560
	private int FreeCount;

	// Token: 0x020001A2 RID: 418
	[NullableContext(0)]
	private struct Entry
	{
		// Token: 0x040007E1 RID: 2017
		public DependentHandle Handle;

		// Token: 0x040007E2 RID: 2018
		public int HashCode;

		// Token: 0x040007E3 RID: 2019
		public int Next;
	}
}
