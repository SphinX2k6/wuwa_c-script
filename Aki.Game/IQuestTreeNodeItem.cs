using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020026AC RID: 9900
[NullableContext(1)]
public interface IQuestTreeNodeItem
{
	// Token: 0x17001A4C RID: 6732
	// (get) Token: 0x06014474 RID: 83060
	EQuestTreeNodeType Type { get; }

	// Token: 0x17001A4D RID: 6733
	// (get) Token: 0x06014475 RID: 83061
	// (set) Token: 0x06014476 RID: 83062
	int HierarchyIndex { get; set; }

	// Token: 0x06014477 RID: 83063
	void Init(IQuestTreeNodeItemLoader loader);

	// Token: 0x06014478 RID: 83064
	UniTask CreateSelf(UUIItem parent);

	// Token: 0x06014479 RID: 83065
	void UpdateData(QuestTreeNodeData data);

	// Token: 0x0601447A RID: 83066
	float GetAdditionalHeight();

	// Token: 0x0601447B RID: 83067
	void UpdateDataList(List<QuestTreeNodeData> data);
}
