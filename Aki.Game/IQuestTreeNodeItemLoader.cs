using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001B95 RID: 7061
[NullableContext(1)]
public interface IQuestTreeNodeItemLoader
{
	// Token: 0x0601194A RID: 72010
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	UniTask<IQuestTreeNodeItem> LoadNodeItem(QuestTreeNodeData nodeData, UUIItem parent);

	// Token: 0x0601194B RID: 72011
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	UniTask<IQuestTreeNodeItem> LoadNodeContainer(List<QuestTreeNodeData> nodeDataList, UUIItem parent);

	// Token: 0x0601194C RID: 72012
	[NullableContext(2)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	QuestTreeNodeItemBase<TData> CreateLogicalNodeItem<TData>(EQuestTreeNodeType type);
}
