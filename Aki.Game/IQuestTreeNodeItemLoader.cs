using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020026AA RID: 9898
[NullableContext(1)]
public interface IQuestTreeNodeItemLoader
{
	// Token: 0x06014468 RID: 83048
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	UniTask<IQuestTreeNodeItem> LoadNodeItem(QuestTreeNodeData nodeData, UUIItem parent);

	// Token: 0x06014469 RID: 83049
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	UniTask<IQuestTreeNodeItem> LoadNodeContainer(List<QuestTreeNodeData> nodeDataList, UUIItem parent);

	// Token: 0x0601446A RID: 83050
	[NullableContext(2)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	QuestTreeNodeItemBase<TData> CreateLogicalNodeItem<TData>(EQuestTreeNodeType type);
}
