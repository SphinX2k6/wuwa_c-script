using System;

// Token: 0x0200228A RID: 8842
public class MotorcycleDiyOutlookBoxItemData
{
	// Token: 0x0601142E RID: 70702 RVA: 0x00436D0B File Offset: 0x00434F0B
	public MotorcycleDiyOutlookBoxItemData(EOutlookType outlookType, int itemId, int index)
	{
		this.OutlookType = outlookType;
		this.ItemId = itemId;
		this.JumpIndex = index;
	}

	// Token: 0x0400834F RID: 33615
	public EOutlookType OutlookType;

	// Token: 0x04008350 RID: 33616
	public int ItemId;

	// Token: 0x04008351 RID: 33617
	public int JumpIndex = -1;
}
