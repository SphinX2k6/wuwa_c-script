using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026A6 RID: 9894
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeChapterViewModel
{
	// Token: 0x17001A48 RID: 6728
	// (get) Token: 0x0601443D RID: 83005 RVA: 0x0051F338 File Offset: 0x0051D538
	public bool OverrideLockReasonGoto
	{
		get
		{
			return this.View != null && this.InternalOverrideLockReasonGoto;
		}
	}

	// Token: 0x0601443E RID: 83006 RVA: 0x0051F34A File Offset: 0x0051D54A
	public void SetOverrideLockReasonGoto(bool value)
	{
		this.InternalOverrideLockReasonGoto = value;
	}

	// Token: 0x0601443F RID: 83007 RVA: 0x0051F353 File Offset: 0x0051D553
	protected QuestTreeChapterViewModel()
	{
	}

	// Token: 0x17001A49 RID: 6729
	// (get) Token: 0x06014440 RID: 83008 RVA: 0x0051F390 File Offset: 0x0051D590
	public float MaxTopHeight
	{
		get
		{
			float num = 0f;
			foreach (ValueTuple<float, float> valueTuple in this.NodeHeightDeltaMap.Values)
			{
				if (valueTuple.Item1 > num)
				{
					num = valueTuple.Item1;
				}
			}
			return num;
		}
	}

	// Token: 0x17001A4A RID: 6730
	// (get) Token: 0x06014441 RID: 83009 RVA: 0x0051F3F8 File Offset: 0x0051D5F8
	public float MaxBottomHeight
	{
		get
		{
			float num = 0f;
			foreach (ValueTuple<float, float> valueTuple in this.NodeHeightDeltaMap.Values)
			{
				if (valueTuple.Item2 > num)
				{
					num = valueTuple.Item2;
				}
			}
			return num;
		}
	}

	// Token: 0x06014442 RID: 83010 RVA: 0x0051F460 File Offset: 0x0051D660
	public static QuestTreeChapterViewModel Create()
	{
		return new QuestTreeChapterViewModel();
	}

	// Token: 0x06014443 RID: 83011 RVA: 0x0051F467 File Offset: 0x0051D667
	public void InitLocatingHelper(UUIScrollViewComponent scroll)
	{
		if (this.LocatingHelper == null)
		{
			this.LocatingHelper = new QuestTreeNodeLocatingHelper(scroll);
		}
	}

	// Token: 0x06014444 RID: 83012 RVA: 0x0051F47D File Offset: 0x0051D67D
	public void OnViewOpen(QuestTreeChapterView view)
	{
		this.View = view;
	}

	// Token: 0x06014445 RID: 83013 RVA: 0x0051F486 File Offset: 0x0051D686
	public void OnViewClose()
	{
		this.Clear();
		this.View = null;
	}

	// Token: 0x06014446 RID: 83014 RVA: 0x0051F498 File Offset: 0x0051D698
	public void Clear()
	{
		this.DelegatesOnSelectedDataChange.Clear();
		this.DelegatesOnLocatingNode.Clear();
		this.DelegatesOnUpdateNode.Clear();
		this.SelectedData = null;
		this.LastSelectedDataCache = null;
		this.ShouldLocateToDefaultNode = true;
		if (this.LocatingHelper != null)
		{
			this.LocatingHelper.Clear();
			this.LocatingHelper = null;
		}
	}

	// Token: 0x06014447 RID: 83015 RVA: 0x0051F4F5 File Offset: 0x0051D6F5
	public void AddOnSelectedDataChange([Nullable(new byte[]
	{
		1,
		2
	})] Action<QuestTreeNodeData> del)
	{
		this.DelegatesOnSelectedDataChange.Add(del);
	}

	// Token: 0x06014448 RID: 83016 RVA: 0x0051F504 File Offset: 0x0051D704
	public void RemoveOnSelectedDataChange([Nullable(new byte[]
	{
		1,
		2
	})] Action<QuestTreeNodeData> del)
	{
		int num = this.DelegatesOnSelectedDataChange.IndexOf(del);
		if (num != -1)
		{
			this.DelegatesOnSelectedDataChange.RemoveAt(num);
		}
	}

	// Token: 0x06014449 RID: 83017 RVA: 0x0051F52E File Offset: 0x0051D72E
	[NullableContext(2)]
	public void SelectData(QuestTreeNodeData data)
	{
		this.SelectedData = data;
		if (data != null)
		{
			this.LastSelectedDataCache = data;
		}
		this.NotifySelectedDataChange();
	}

	// Token: 0x0601444A RID: 83018 RVA: 0x0051F547 File Offset: 0x0051D747
	public void AddOnLocatingNode([Nullable(new byte[]
	{
		1,
		2
	})] Action<QuestTreeNodeData, bool> del)
	{
		this.DelegatesOnLocatingNode.Add(del);
	}

	// Token: 0x0601444B RID: 83019 RVA: 0x0051F558 File Offset: 0x0051D758
	public void RemoveOnLocatingNode([Nullable(new byte[]
	{
		1,
		2
	})] Action<QuestTreeNodeData, bool> del)
	{
		int num = this.DelegatesOnLocatingNode.IndexOf(del);
		if (num != -1)
		{
			this.DelegatesOnLocatingNode.RemoveAt(num);
		}
	}

	// Token: 0x0601444C RID: 83020 RVA: 0x0051F584 File Offset: 0x0051D784
	[NullableContext(2)]
	public void LocateToNode(QuestTreeNodeData data, bool tween = true)
	{
		foreach (Action<QuestTreeNodeData, bool> action in this.DelegatesOnLocatingNode)
		{
			action(data, tween);
		}
	}

	// Token: 0x0601444D RID: 83021 RVA: 0x0051F5D8 File Offset: 0x0051D7D8
	public void SetShouldLocateToDefaultNode(bool should)
	{
		this.ShouldLocateToDefaultNode = should;
	}

	// Token: 0x0601444E RID: 83022 RVA: 0x0051F5E1 File Offset: 0x0051D7E1
	public void RecordHeightBalanceValue(int id, float valueTop, float valueBottom)
	{
		this.NodeHeightDeltaMap[id] = new ValueTuple<float, float>(valueTop, valueBottom);
	}

	// Token: 0x0601444F RID: 83023 RVA: 0x0051F5F6 File Offset: 0x0051D7F6
	public void RemoveHeightBalanceValue(int id)
	{
		this.NodeHeightDeltaMap.Remove(id);
	}

	// Token: 0x06014450 RID: 83024 RVA: 0x0051F605 File Offset: 0x0051D805
	public void RecordToggleHeight(float value)
	{
		if (value > this.MaxToggleHeight)
		{
			this.MaxToggleHeight = value;
		}
	}

	// Token: 0x06014451 RID: 83025 RVA: 0x0051F618 File Offset: 0x0051D818
	private void NotifySelectedDataChange()
	{
		foreach (Action<QuestTreeNodeData> action in this.DelegatesOnSelectedDataChange)
		{
			action(this.SelectedData);
		}
	}

	// Token: 0x06014452 RID: 83026 RVA: 0x0051F670 File Offset: 0x0051D870
	public void AddOnUpdateNode(Action del)
	{
		this.DelegatesOnUpdateNode.Add(del);
	}

	// Token: 0x06014453 RID: 83027 RVA: 0x0051F67E File Offset: 0x0051D87E
	public void RemoveOnUpdateNode(Action del)
	{
		this.DelegatesOnUpdateNode.Remove(del);
	}

	// Token: 0x06014454 RID: 83028 RVA: 0x0051F690 File Offset: 0x0051D890
	public void NotifyUpdateNode()
	{
		foreach (Action action in this.DelegatesOnUpdateNode)
		{
			action();
		}
	}

	// Token: 0x06014455 RID: 83029 RVA: 0x0051F6E0 File Offset: 0x0051D8E0
	public UniTask RefreshViewByData(QuestTreeChapterData data, bool useBlackScreen = true)
	{
		QuestTreeChapterViewModel.<RefreshViewByData>d__38 <RefreshViewByData>d__;
		<RefreshViewByData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshViewByData>d__.<>4__this = this;
		<RefreshViewByData>d__.data = data;
		<RefreshViewByData>d__.useBlackScreen = useBlackScreen;
		<RefreshViewByData>d__.<>1__state = -1;
		<RefreshViewByData>d__.<>t__builder.Start<QuestTreeChapterViewModel.<RefreshViewByData>d__38>(ref <RefreshViewByData>d__);
		return <RefreshViewByData>d__.<>t__builder.Task;
	}

	// Token: 0x0400987B RID: 39035
	private bool InternalOverrideLockReasonGoto;

	// Token: 0x0400987C RID: 39036
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly List<Action<QuestTreeNodeData>> DelegatesOnSelectedDataChange = new List<Action<QuestTreeNodeData>>();

	// Token: 0x0400987D RID: 39037
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly List<Action<QuestTreeNodeData, bool>> DelegatesOnLocatingNode = new List<Action<QuestTreeNodeData, bool>>();

	// Token: 0x0400987E RID: 39038
	private readonly List<Action> DelegatesOnUpdateNode = new List<Action>();

	// Token: 0x0400987F RID: 39039
	public float MaxToggleHeight;

	// Token: 0x04009880 RID: 39040
	[Nullable(2)]
	public QuestTreeNodeData SelectedData;

	// Token: 0x04009881 RID: 39041
	[Nullable(2)]
	public QuestTreeNodeLocatingHelper LocatingHelper;

	// Token: 0x04009882 RID: 39042
	[Nullable(new byte[]
	{
		1,
		0
	})]
	public Dictionary<int, ValueTuple<float, float>> NodeHeightDeltaMap = new Dictionary<int, ValueTuple<float, float>>();

	// Token: 0x04009883 RID: 39043
	[Nullable(2)]
	public QuestTreeChapterView View;

	// Token: 0x04009884 RID: 39044
	[Nullable(2)]
	public QuestTreeNodeData LastSelectedDataCache;

	// Token: 0x04009885 RID: 39045
	public bool ShouldLocateToDefaultNode = true;
}
