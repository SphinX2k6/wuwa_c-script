using System;

// Token: 0x02000E63 RID: 3683
public class CharacterOrnamentSmallItemGrid : SmallItemGridBase
{
	// Token: 0x1700102F RID: 4143
	// (get) Token: 0x06009394 RID: 37780 RVA: 0x002BEF98 File Offset: 0x002BD198
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.CharacterOrnament;
		}
	}

	// Token: 0x040056D4 RID: 22228
	public bool? IsLockVisibleBlack;

	// Token: 0x040056D5 RID: 22229
	public bool? IsReceivableVisible;

	// Token: 0x040056D6 RID: 22230
	public bool? IsReceivedVisible;

	// Token: 0x040056D7 RID: 22231
	public bool? IsSelectedFlag;

	// Token: 0x040056D8 RID: 22232
	public bool? IsOrnamentConflictVisible;
}
