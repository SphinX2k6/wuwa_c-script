using System;

// Token: 0x02000109 RID: 265
public class TsFloatRange
{
	// Token: 0x06000A3E RID: 2622 RVA: 0x0003326C File Offset: 0x0003146C
	public TsFloatRange(bool exclusive, float min, float max)
	{
		this.Exclusive = exclusive;
		this.Min = min;
		this.Max = max;
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x00033289 File Offset: 0x00031489
	public bool InRange(float v)
	{
		if (this.Exclusive)
		{
			return v > this.Min && v < this.Max;
		}
		return v >= this.Min && v <= this.Max;
	}

	// Token: 0x040006A3 RID: 1699
	public readonly bool Exclusive;

	// Token: 0x040006A4 RID: 1700
	public readonly float Min;

	// Token: 0x040006A5 RID: 1701
	public readonly float Max;
}
