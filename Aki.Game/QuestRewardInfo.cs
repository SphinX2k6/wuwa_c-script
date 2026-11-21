using System;

// Token: 0x02001B41 RID: 6977
public class QuestRewardInfo
{
	// Token: 0x06011635 RID: 71221 RVA: 0x0051EC64 File Offset: 0x0051CE64
	public QuestRewardInfo(int itemId, int itemCount)
	{
		this.ItemId = itemId;
		this.ItemCount = itemCount;
	}

	// Token: 0x040098C8 RID: 39112
	public readonly int ItemId;

	// Token: 0x040098C9 RID: 39113
	public readonly int ItemCount;
}
