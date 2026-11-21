using System;

// Token: 0x02001B4D RID: 6989
public class QuestItemData
{
	// Token: 0x060116A7 RID: 71335 RVA: 0x00521D47 File Offset: 0x0051FF47
	public QuestItemData(int questId, int questType)
	{
		this.QuestId = questId;
		this.QuestType = questType;
	}

	// Token: 0x040098EB RID: 39147
	public readonly int QuestId;

	// Token: 0x040098EC RID: 39148
	public readonly int QuestType;
}
