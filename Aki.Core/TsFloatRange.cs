using System;

// Token: 0x02000109 RID: 265
public class TsFloatRange
{
	// Token: 0x060009ED RID: 2541 RVA: 0x00032910 File Offset: 0x00030B10
	public TsFloatRange(bool exclusive, float min, float max)
	{
		this.Exclusive = exclusive;
		this.Min = min;
		this.Max = max;
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x0003292D File Offset: 0x00030B2D
	public bool InRange(float v)
	{
		if (this.Exclusive)
		{
			return v > this.Min && v < this.Max;
		}
		return v >= this.Min && v <= this.Max;
	}

	// Token: 0x04000698 RID: 1688
	public readonly bool Exclusive;

	// Token: 0x04000699 RID: 1689
	public readonly float Min;

	// Token: 0x0400069A RID: 1690
	public readonly float Max;
}
