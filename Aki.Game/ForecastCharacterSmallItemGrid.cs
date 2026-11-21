using System;

// Token: 0x02000E5F RID: 3679
public class ForecastCharacterSmallItemGrid : SmallItemGridBase
{
	// Token: 0x1700102B RID: 4139
	// (get) Token: 0x0600938C RID: 37772 RVA: 0x002BEF6C File Offset: 0x002BD16C
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.ForecastCharacter;
		}
	}

	// Token: 0x040056BE RID: 22206
	public int? RoleId;
}
