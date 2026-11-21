using System;

// Token: 0x02000EBD RID: 3773
public class DamageViewOffsetInfo
{
	// Token: 0x060096E5 RID: 38629 RVA: 0x002CB543 File Offset: 0x002C9743
	public void Reset()
	{
		this.LastUpdateTime = 0.0;
		this.OffsetX = 0f;
		this.OffsetY = 0f;
		this.Index = 0;
		this.DamageTextAreaId = 0;
		this.DistanceScale = 0f;
	}

	// Token: 0x04005AA0 RID: 23200
	public double LastUpdateTime;

	// Token: 0x04005AA1 RID: 23201
	public float OffsetX;

	// Token: 0x04005AA2 RID: 23202
	public float OffsetY;

	// Token: 0x04005AA3 RID: 23203
	public int Index;

	// Token: 0x04005AA4 RID: 23204
	public int DamageTextAreaId;

	// Token: 0x04005AA5 RID: 23205
	public float DistanceScale;
}
