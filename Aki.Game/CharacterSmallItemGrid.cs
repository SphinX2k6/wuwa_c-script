using System;

// Token: 0x02000E5E RID: 3678
public class CharacterSmallItemGrid : SmallItemGridBase
{
	// Token: 0x1700102A RID: 4138
	// (get) Token: 0x0600938A RID: 37770 RVA: 0x002BEF61 File Offset: 0x002BD161
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.Character;
		}
	}

	// Token: 0x040056B7 RID: 22199
	public int? ElementId;

	// Token: 0x040056B8 RID: 22200
	public bool? IsLockVisible;

	// Token: 0x040056B9 RID: 22201
	public bool? IsReceivableVisible;

	// Token: 0x040056BA RID: 22202
	public bool? IsReceivedVisible;

	// Token: 0x040056BB RID: 22203
	public bool? IsSelectedFlag;

	// Token: 0x040056BC RID: 22204
	public bool? IsCookUp;

	// Token: 0x040056BD RID: 22205
	public bool? IsBlack;
}
