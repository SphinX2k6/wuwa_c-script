using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001B97 RID: 7063
[NullableContext(1)]
public interface IQuestTreeNodeItem
{
	// Token: 0x17001A84 RID: 6788
	// (get) Token: 0x06011956 RID: 72022
	EQuestTreeNodeType Type { get; }

	// Token: 0x17001A85 RID: 6789
	// (get) Token: 0x06011957 RID: 72023
	// (set) Token: 0x06011958 RID: 72024
	int HierarchyIndex { get; set; }

	// Token: 0x06011959 RID: 72025
	void Init(IQuestTreeNodeItemLoader loader);

	// Token: 0x0601195A RID: 72026
	UniTask CreateSelf(UUIItem parent);

	// Token: 0x0601195B RID: 72027
	void UpdateData(QuestTreeNodeData data);

	// Token: 0x0601195C RID: 72028
	float GetAdditionalHeight();

	// Token: 0x0601195D RID: 72029
	void UpdateDataList(List<QuestTreeNodeData> data);
}
