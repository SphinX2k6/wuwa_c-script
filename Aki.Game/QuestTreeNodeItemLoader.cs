using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026AE RID: 9902
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeNodeItemLoader : IQuestTreeNodeItemLoader
{
	// Token: 0x06014489 RID: 83081 RVA: 0x0051FEA5 File Offset: 0x0051E0A5
	public void RegisterNodeType(EQuestTreeNodeType type, Type ctorType)
	{
		this._nodeConstructors[type] = ctorType;
	}

	// Token: 0x0601448A RID: 83082 RVA: 0x0051FEB4 File Offset: 0x0051E0B4
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<IQuestTreeNodeItem> LoadNodeItem(QuestTreeNodeData nodeData, UUIItem parent)
	{
		QuestTreeNodeItemLoader.<LoadNodeItem>d__2 <LoadNodeItem>d__;
		<LoadNodeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<IQuestTreeNodeItem>.Create();
		<LoadNodeItem>d__.<>4__this = this;
		<LoadNodeItem>d__.nodeData = nodeData;
		<LoadNodeItem>d__.parent = parent;
		<LoadNodeItem>d__.<>1__state = -1;
		<LoadNodeItem>d__.<>t__builder.Start<QuestTreeNodeItemLoader.<LoadNodeItem>d__2>(ref <LoadNodeItem>d__);
		return <LoadNodeItem>d__.<>t__builder.Task;
	}

	// Token: 0x0601448B RID: 83083 RVA: 0x0051FF08 File Offset: 0x0051E108
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<IQuestTreeNodeItem> LoadNodeContainer(List<QuestTreeNodeData> nodeDataList, UUIItem parent)
	{
		QuestTreeNodeItemLoader.<LoadNodeContainer>d__3 <LoadNodeContainer>d__;
		<LoadNodeContainer>d__.<>t__builder = AsyncUniTaskMethodBuilder<IQuestTreeNodeItem>.Create();
		<LoadNodeContainer>d__.<>4__this = this;
		<LoadNodeContainer>d__.nodeDataList = nodeDataList;
		<LoadNodeContainer>d__.parent = parent;
		<LoadNodeContainer>d__.<>1__state = -1;
		<LoadNodeContainer>d__.<>t__builder.Start<QuestTreeNodeItemLoader.<LoadNodeContainer>d__3>(ref <LoadNodeContainer>d__);
		return <LoadNodeContainer>d__.<>t__builder.Task;
	}

	// Token: 0x0601448C RID: 83084 RVA: 0x0051FF5C File Offset: 0x0051E15C
	[NullableContext(2)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public QuestTreeNodeItemBase<TData> CreateLogicalNodeItem<TData>(EQuestTreeNodeType type)
	{
		Type type2;
		if (!this._nodeConstructors.TryGetValue(type, out type2))
		{
			return null;
		}
		QuestTreeNodeItemBase<TData> questTreeNodeItemBase = (QuestTreeNodeItemBase<TData>)Activator.CreateInstance(type2);
		questTreeNodeItemBase.Init(this);
		return questTreeNodeItemBase;
	}

	// Token: 0x0400988F RID: 39055
	private readonly Dictionary<EQuestTreeNodeType, Type> _nodeConstructors = new Dictionary<EQuestTreeNodeType, Type>();
}
