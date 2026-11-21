using System;

// Token: 0x02000E61 RID: 3681
public class WeaponSmallItemGrid : SmallItemGridBase
{
	// Token: 0x1700102D RID: 4141
	// (get) Token: 0x06009390 RID: 37776 RVA: 0x002BEF82 File Offset: 0x002BD182
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.Weapon;
		}
	}

	// Token: 0x040056C2 RID: 22210
	public int? Level;

	// Token: 0x040056C3 RID: 22211
	public int? ResonanceLevel;

	// Token: 0x040056C4 RID: 22212
	public bool? IsWeaponFlagVisible;
}
