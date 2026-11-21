using System;
using System.Runtime.CompilerServices;

// Token: 0x02000046 RID: 70
[NullableContext(1)]
[Nullable(0)]
public class CacheLru<TK, TV> where TV : class
{
	// Token: 0x060001E7 RID: 487 RVA: 0x0000B600 File Offset: 0x00009800
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

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000B61C File Offset: 0x0000981C
	// (set) Token: 0x060001E9 RID: 489 RVA: 0x0000B629 File Offset: 0x00009829
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

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060001EA RID: 490 RVA: 0x0000B637 File Offset: 0x00009837
	public int Size
	{
		get
		{
			return this.Lru.Size;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060001EB RID: 491 RVA: 0x0000B644 File Offset: 0x00009844
	// (set) Token: 0x060001EC RID: 492 RVA: 0x0000B651 File Offset: 0x00009851
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

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060001ED RID: 493 RVA: 0x0000B65F File Offset: 0x0000985F
	public float HitRate
	{
		get
		{
			return this.Lru.HitRate;
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060001EE RID: 494 RVA: 0x0000B66C File Offset: 0x0000986C
	public float UsedAvg
	{
		get
		{
			return this.Lru.UsedAvg;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060001EF RID: 495 RVA: 0x0000B679 File Offset: 0x00009879
	public float ThresholdUsedRate
	{
		get
		{
			return this.Lru.ThresholdUsedRate;
		}
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x0000B688 File Offset: 0x00009888
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

	// Token: 0x060001F1 RID: 497 RVA: 0x0000B6DB File Offset: 0x000098DB
	public void Clear()
	{
		this.Lru.Clear();
	}

	// Token: 0x040001AD RID: 429
	private readonly TrimLru<TK, TV> Lru;

	// Token: 0x040001AE RID: 430
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly Func<TK, TV> Creator;
}
