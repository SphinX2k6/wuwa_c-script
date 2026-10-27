using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026B2 RID: 9906
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeNodeItemPool
{
	// Token: 0x060144BF RID: 83135 RVA: 0x00521330 File Offset: 0x0051F530
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

	// Token: 0x060144C0 RID: 83136 RVA: 0x005213A8 File Offset: 0x0051F5A8
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

	// Token: 0x060144C1 RID: 83137 RVA: 0x005213F4 File Offset: 0x0051F5F4
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

	// Token: 0x060144C2 RID: 83138 RVA: 0x0052143F File Offset: 0x0051F63F
	public void ClearPool()
	{
		this.IsCleared = true;
		this.Pool.Clear();
		this.InUseCountMap.Clear();
	}

	// Token: 0x060144C3 RID: 83139 RVA: 0x00521460 File Offset: 0x0051F660
	public IQuestTreeNodeItem GetItemByData(QuestTreeNodeData data)
	{
		IQuestTreeNodeItem result;
		this.DataItemMap.TryGetValue(data, out result);
		return result;
	}

	// Token: 0x060144C4 RID: 83140 RVA: 0x00521480 File Offset: 0x0051F680
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

	// Token: 0x060144C5 RID: 83141 RVA: 0x005214CC File Offset: 0x0051F6CC
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

	// Token: 0x060144C6 RID: 83142 RVA: 0x00521518 File Offset: 0x0051F718
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

	// Token: 0x040098AA RID: 39082
	private const int HIERARCHY_START_INDEX = 2;

	// Token: 0x040098AB RID: 39083
	private readonly Dictionary<int, List<IQuestTreeNodeItem>> Pool = new Dictionary<int, List<IQuestTreeNodeItem>>();

	// Token: 0x040098AC RID: 39084
	private readonly Dictionary<int, int> InUseCountMap = new Dictionary<int, int>();

	// Token: 0x040098AD RID: 39085
	private readonly Dictionary<QuestTreeNodeData, IQuestTreeNodeItem> DataItemMap = new Dictionary<QuestTreeNodeData, IQuestTreeNodeItem>();

	// Token: 0x040098AE RID: 39086
	private int RefreshVersion;

	// Token: 0x040098AF RID: 39087
	private UniTask RefreshTail = UniTask.CompletedTask;

	// Token: 0x040098B0 RID: 39088
	private bool IsCleared;

	// Token: 0x040098B1 RID: 39089
	private readonly IQuestTreeNodeItemLoader Loader;

	// Token: 0x040098B2 RID: 39090
	private readonly UUIItem Parent;
}
