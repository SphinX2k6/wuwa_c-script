using System;

// Token: 0x0200176E RID: 5998
public class MotorcycleDiyOutlookBoxItemData
{
	// Token: 0x0600E8C4 RID: 59588 RVA: 0x00443917 File Offset: 0x00441B17
	public MotorcycleDiyOutlookBoxItemData(EOutlookType outlookType, int itemId, int index)
	{
		this.OutlookType = outlookType;
		this.ItemId = itemId;
		this.JumpIndex = index;
	}

	// Token: 0x0400848D RID: 33933
	public EOutlookType OutlookType;

	// Token: 0x0400848E RID: 33934
	public int ItemId;

	// Token: 0x0400848F RID: 33935
	public int JumpIndex = -1;
}
