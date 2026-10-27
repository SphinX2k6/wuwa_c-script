using System;

// Token: 0x020019A2 RID: 6562
public class ForecastCharacterSmallItemGrid : SmallItemGridBase
{
	// Token: 0x17001007 RID: 4103
	// (get) Token: 0x0600BF84 RID: 49028 RVA: 0x002B3FE8 File Offset: 0x002B21E8
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.ForecastCharacter;
		}
	}

	// Token: 0x0400560F RID: 22031
	public int? RoleId;
}
