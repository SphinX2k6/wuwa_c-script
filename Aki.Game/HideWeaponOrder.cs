using System;

// Token: 0x0200309B RID: 12443
internal class HideWeaponOrder
{
	// Token: 0x0601A994 RID: 108948 RVA: 0x00724F7E File Offset: 0x0072317E
	public HideWeaponOrder(int index, bool hide, bool withEffect, bool bNormaState = true, EWeaponExtraVisibleType extraType = EWeaponExtraVisibleType.LowCustom)
	{
		this.Index = index;
		this.Hide = hide;
		this.WithEffect = withEffect;
		this.NormaState = bNormaState;
		this.ExtraType = extraType;
	}

	// Token: 0x0400CCDC RID: 52444
	public int Index;

	// Token: 0x0400CCDD RID: 52445
	public bool Hide;

	// Token: 0x0400CCDE RID: 52446
	public bool WithEffect;

	// Token: 0x0400CCDF RID: 52447
	public bool NormaState = true;

	// Token: 0x0400CCE0 RID: 52448
	public EWeaponExtraVisibleType ExtraType;
}
