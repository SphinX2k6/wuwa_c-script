using System;

// Token: 0x02002656 RID: 9814
public class QuestRewardInfo
{
	// Token: 0x06014153 RID: 82259 RVA: 0x0050FFAD File Offset: 0x0050E1AD
	public QuestRewardInfo(int itemId, int itemCount)
	{
		this.ItemId = itemId;
		this.ItemCount = itemCount;
	}

	// Token: 0x04009770 RID: 38768
	public readonly int ItemId;

	// Token: 0x04009771 RID: 38769
	public readonly int ItemCount;
}
