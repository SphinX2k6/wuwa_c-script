using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002663 RID: 9827
[NullableContext(1)]
public interface IQuestChapterData
{
	// Token: 0x1700199D RID: 6557
	// (get) Token: 0x060141C6 RID: 82374
	int ChapterId { get; }

	// Token: 0x1700199E RID: 6558
	// (get) Token: 0x060141C7 RID: 82375
	int QuestType { get; }

	// Token: 0x1700199F RID: 6559
	// (get) Token: 0x060141C8 RID: 82376
	List<int> QuestList { get; }
}
