using System;

// Token: 0x020019A5 RID: 6565
public class CharacterOrnamentSmallItemGrid : SmallItemGridBase
{
	// Token: 0x1700100A RID: 4106
	// (get) Token: 0x0600BF8A RID: 49034 RVA: 0x002B4009 File Offset: 0x002B2209
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.CharacterOrnament;
		}
	}

	// Token: 0x04005622 RID: 22050
	public bool? IsLockVisibleBlack;

	// Token: 0x04005623 RID: 22051
	public bool? IsReceivableVisible;

	// Token: 0x04005624 RID: 22052
	public bool? IsReceivedVisible;

	// Token: 0x04005625 RID: 22053
	public bool? IsSelectedFlag;

	// Token: 0x04005626 RID: 22054
	public bool? IsOrnamentConflictVisible;
}
