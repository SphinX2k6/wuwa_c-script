using System;

// Token: 0x020019FE RID: 6654
public class DamageViewOffsetInfo
{
	// Token: 0x0600C2D7 RID: 49879 RVA: 0x002C0557 File Offset: 0x002BE757
	public void Reset()
	{
		this.LastUpdateTime = 0.0;
		this.OffsetX = 0f;
		this.OffsetY = 0f;
		this.Index = 0;
		this.DamageTextAreaId = 0;
		this.DistanceScale = 0f;
	}

	// Token: 0x040059D1 RID: 22993
	public double LastUpdateTime;

	// Token: 0x040059D2 RID: 22994
	public float OffsetX;

	// Token: 0x040059D3 RID: 22995
	public float OffsetY;

	// Token: 0x040059D4 RID: 22996
	public int Index;

	// Token: 0x040059D5 RID: 22997
	public int DamageTextAreaId;

	// Token: 0x040059D6 RID: 22998
	public float DistanceScale;
}
