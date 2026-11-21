using System;

// Token: 0x020025F2 RID: 9714
internal class HideWeaponOrder
{
	// Token: 0x06018392 RID: 99218 RVA: 0x0074AD8A File Offset: 0x00748F8A
	public HideWeaponOrder(int index, bool hide, bool withEffect, bool bNormaState = true, EWeaponExtraVisibleType extraType = EWeaponExtraVisibleType.LowCustom)
	{
		this.Index = index;
		this.Hide = hide;
		this.WithEffect = withEffect;
		this.NormaState = bNormaState;
		this.ExtraType = extraType;
	}

	// Token: 0x0400D0BF RID: 53439
	public int Index;

	// Token: 0x0400D0C0 RID: 53440
	public bool Hide;

	// Token: 0x0400D0C1 RID: 53441
	public bool WithEffect;

	// Token: 0x0400D0C2 RID: 53442
	public bool NormaState = true;

	// Token: 0x0400D0C3 RID: 53443
	public EWeaponExtraVisibleType ExtraType;
}
