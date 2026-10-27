using System;

// Token: 0x02002662 RID: 9826
public class QuestItemData
{
	// Token: 0x060141C5 RID: 82373 RVA: 0x0051308F File Offset: 0x0051128F
	public QuestItemData(int questId, int questType)
	{
		this.QuestId = questId;
		this.QuestType = questType;
	}

	// Token: 0x04009793 RID: 38803
	public readonly int QuestId;

	// Token: 0x04009794 RID: 38804
	public readonly int QuestType;
}
