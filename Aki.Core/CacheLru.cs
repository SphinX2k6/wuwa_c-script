using System;
using System.Runtime.CompilerServices;

// Token: 0x02000046 RID: 70
[NullableContext(1)]
[Nullable(0)]
public class CacheLru<TK, TV> where TV : class
{
	// Token: 0x060001E6 RID: 486 RVA: 0x0000B91C File Offset: 0x00009B1C
	public CacheLru(int capacity, [Nullable(new byte[]
	{
		1,
		1,
		2
	})] Func<TK, TV> creator)
	{
		this.Lru = new TrimLru<TK, TV>(capacity, false);
		this.Creator = creator;
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000B938 File Offset: 0x00009B38
	// (set) Token: 0x060001E8 RID: 488 RVA: 0x0000B945 File Offset: 0x00009B45
	public bool Enable
	{
		get
		{
			return this.Lru.Enable;
		}
		set
		{
			this.Lru.Enable = value;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000B953 File Offset: 0x00009B53
	public int Size
	{
		get
		{
			return this.Lru.Size;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060001EA RID: 490 RVA: 0x0000B960 File Offset: 0x00009B60
	// (set) Token: 0x060001EB RID: 491 RVA: 0x0000B96D File Offset: 0x00009B6D
	public int Capacity
	{
		get
		{
			return this.Lru.Capacity;
		}
		set
		{
			this.Lru.Capacity = value;
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060001EC RID: 492 RVA: 0x0000B97B File Offset: 0x00009B7B
	public float HitRate
	{
		get
		{
			return this.Lru.HitRate;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060001ED RID: 493 RVA: 0x0000B988 File Offset: 0x00009B88
	public float UsedAvg
	{
		get
		{
			return this.Lru.UsedAvg;
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060001EE RID: 494 RVA: 0x0000B995 File Offset: 0x00009B95
	public float ThresholdUsedRate
	{
		get
		{
			return this.Lru.ThresholdUsedRate;
		}
	}

	// Token: 0x060001EF RID: 495 RVA: 0x0000B9A4 File Offset: 0x00009BA4
	[return: Nullable(2)]
	public TV Get(TK key)
	{
		TV tv = this.Lru.Get(key);
		if (tv != null)
		{
			return tv;
		}
		tv = this.Creator(key);
		if (tv == null)
		{
			return default(TV);
		}
		this.Lru.Put(key, tv, 1);
		return tv;
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x0000B9F7 File Offset: 0x00009BF7
	public void Clear()
	{
		this.Lru.Clear();
	}

	// Token: 0x040001AB RID: 427
	private readonly TrimLru<TK, TV> Lru;

	// Token: 0x040001AC RID: 428
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly Func<TK, TV> Creator;
}
