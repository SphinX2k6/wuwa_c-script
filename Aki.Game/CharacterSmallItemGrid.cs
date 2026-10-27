using System;

// Token: 0x020019A1 RID: 6561
public class CharacterSmallItemGrid : SmallItemGridBase
{
	// Token: 0x17001006 RID: 4102
	// (get) Token: 0x0600BF82 RID: 49026 RVA: 0x002B3FDD File Offset: 0x002B21DD
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.Character;
		}
	}

	// Token: 0x04005608 RID: 22024
	public int? ElementId;

	// Token: 0x04005609 RID: 22025
	public bool? IsLockVisible;

	// Token: 0x0400560A RID: 22026
	public bool? IsReceivableVisible;

	// Token: 0x0400560B RID: 22027
	public bool? IsReceivedVisible;

	// Token: 0x0400560C RID: 22028
	public bool? IsSelectedFlag;

	// Token: 0x0400560D RID: 22029
	public bool? IsCookUp;

	// Token: 0x0400560E RID: 22030
	public bool? IsBlack;
}
