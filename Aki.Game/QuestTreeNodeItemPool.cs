using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B9D RID: 7069
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeNodeItemPool
{
	// Token: 0x060119A1 RID: 72097 RVA: 0x00530068 File Offset: 0x0052E268
	public QuestTreeNodeItemPool(IQuestTreeNodeItemLoader loader, UUIItem parent)
	{
		this.Loader = loader;
		this.Parent = parent;
		for (int i = 0; i < 5; i++)
		{
			this.Pool[i] = new List<IQuestTreeNodeItem>();
			this.InUseCountMap[i] = 0;
		}
	}

	// Token: 0x060119A2 RID: 72098 RVA: 0x005300E0 File Offset: 0x0052E2E0
	[NullableContext(0)]
	public UniTask<bool> RefreshByData([Nullable(1)] List<QuestTreeNodeData> dataList)
	{
		QuestTreeNodeItemPool.<RefreshByData>d__10 <RefreshByData>d__;
		<RefreshByData>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RefreshByData>d__.<>4__this = this;
		<RefreshByData>d__.dataList = dataList;
		<RefreshByData>d__.<>1__state = -1;
		<RefreshByData>d__.<>t__builder.Start<QuestTreeNodeItemPool.<RefreshByData>d__10>(ref <RefreshByData>d__);
		return <RefreshByData>d__.<>t__builder.Task;
	}

	// Token: 0x060119A3 RID: 72099 RVA: 0x0053012C File Offset: 0x0052E32C
	private UniTask RefreshByDataInternal(List<QuestTreeNodeData> dataList)
	{
		QuestTreeNodeItemPool.<RefreshByDataInternal>d__11 <RefreshByDataInternal>d__;
		<RefreshByDataInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshByDataInternal>d__.<>4__this = this;
		<RefreshByDataInternal>d__.dataList = dataList;
		<RefreshByDataInternal>d__.<>1__state = -1;
		<RefreshByDataInternal>d__.<>t__builder.Start<QuestTreeNodeItemPool.<RefreshByDataInternal>d__11>(ref <RefreshByDataInternal>d__);
		return <RefreshByDataInternal>d__.<>t__builder.Task;
	}

	// Token: 0x060119A4 RID: 72100 RVA: 0x00530177 File Offset: 0x0052E377
	public void ClearPool()
	{
		this.IsCleared = true;
		this.Pool.Clear();
		this.InUseCountMap.Clear();
	}

	// Token: 0x060119A5 RID: 72101 RVA: 0x00530198 File Offset: 0x0052E398
	public IQuestTreeNodeItem GetItemByData(QuestTreeNodeData data)
	{
		IQuestTreeNodeItem result;
		this.DataItemMap.TryGetValue(data, out result);
		return result;
	}

	// Token: 0x060119A6 RID: 72102 RVA: 0x005301B8 File Offset: 0x0052E3B8
	private UniTask LoadItems([Nullable(new byte[]
	{
		1,
		0,
		1
	})] List<ValueTuple<QuestTreeNodeData, int>> loadTasks)
	{
		QuestTreeNodeItemPool.<LoadItems>d__14 <LoadItems>d__;
		<LoadItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadItems>d__.<>4__this = this;
		<LoadItems>d__.loadTasks = loadTasks;
		<LoadItems>d__.<>1__state = -1;
		<LoadItems>d__.<>t__builder.Start<QuestTreeNodeItemPool.<LoadItems>d__14>(ref <LoadItems>d__);
		return <LoadItems>d__.<>t__builder.Task;
	}

	// Token: 0x060119A7 RID: 72103 RVA: 0x00530204 File Offset: 0x0052E404
	private UniTask ProcessTask([Nullable(new byte[]
	{
		0,
		1
	})] ValueTuple<QuestTreeNodeData, int> task)
	{
		QuestTreeNodeItemPool.<ProcessTask>d__15 <ProcessTask>d__;
		<ProcessTask>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ProcessTask>d__.<>4__this = this;
		<ProcessTask>d__.task = task;
		<ProcessTask>d__.<>1__state = -1;
		<ProcessTask>d__.<>t__builder.Start<QuestTreeNodeItemPool.<ProcessTask>d__15>(ref <ProcessTask>d__);
		return <ProcessTask>d__.<>t__builder.Task;
	}

	// Token: 0x060119A8 RID: 72104 RVA: 0x00530250 File Offset: 0x0052E450
	private void ResetPool()
	{
		this.DataItemMap.Clear();
		foreach (KeyValuePair<int, List<IQuestTreeNodeItem>> keyValuePair in this.Pool)
		{
			int num;
			List<IQuestTreeNodeItem> list;
			keyValuePair.Deconstruct(out num, out list);
			int key = num;
			foreach (IQuestTreeNodeItem questTreeNodeItem in list)
			{
				(questTreeNodeItem as UiPanelBase).SetUiActive(false);
			}
			this.InUseCountMap[key] = 0;
		}
	}

	// Token: 0x04009A02 RID: 39426
	private const int HIERARCHY_START_INDEX = 2;

	// Token: 0x04009A03 RID: 39427
	private readonly Dictionary<int, List<IQuestTreeNodeItem>> Pool = new Dictionary<int, List<IQuestTreeNodeItem>>();

	// Token: 0x04009A04 RID: 39428
	private readonly Dictionary<int, int> InUseCountMap = new Dictionary<int, int>();

	// Token: 0x04009A05 RID: 39429
	private readonly Dictionary<QuestTreeNodeData, IQuestTreeNodeItem> DataItemMap = new Dictionary<QuestTreeNodeData, IQuestTreeNodeItem>();

	// Token: 0x04009A06 RID: 39430
	private int RefreshVersion;

	// Token: 0x04009A07 RID: 39431
	private UniTask RefreshTail = UniTask.CompletedTask;

	// Token: 0x04009A08 RID: 39432
	private bool IsCleared;

	// Token: 0x04009A09 RID: 39433
	private readonly IQuestTreeNodeItemLoader Loader;

	// Token: 0x04009A0A RID: 39434
	private readonly UUIItem Parent;
}
