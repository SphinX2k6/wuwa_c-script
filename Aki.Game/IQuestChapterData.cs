using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001B4E RID: 6990
[NullableContext(1)]
public interface IQuestChapterData
{
	// Token: 0x170019D5 RID: 6613
	// (get) Token: 0x060116A8 RID: 71336
	int ChapterId { get; }

	// Token: 0x170019D6 RID: 6614
	// (get) Token: 0x060116A9 RID: 71337
	int QuestType { get; }

	// Token: 0x170019D7 RID: 6615
	// (get) Token: 0x060116AA RID: 71338
	List<int> QuestList { get; }
}
