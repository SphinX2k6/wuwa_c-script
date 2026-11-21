using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B91 RID: 7057
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeChapterViewModel
{
	// Token: 0x17001A80 RID: 6784
	// (get) Token: 0x0601191F RID: 71967 RVA: 0x0052E070 File Offset: 0x0052C270
	public bool OverrideLockReasonGoto
	{
		get
		{
			return this.View != null && this.InternalOverrideLockReasonGoto;
		}
	}

	// Token: 0x06011920 RID: 71968 RVA: 0x0052E082 File Offset: 0x0052C282
	public void SetOverrideLockReasonGoto(bool value)
	{
		this.InternalOverrideLockReasonGoto = value;
	}

	// Token: 0x06011921 RID: 71969 RVA: 0x0052E08B File Offset: 0x0052C28B
	protected QuestTreeChapterViewModel()
	{
	}

	// Token: 0x17001A81 RID: 6785
	// (get) Token: 0x06011922 RID: 71970 RVA: 0x0052E0C8 File Offset: 0x0052C2C8
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

	// Token: 0x17001A82 RID: 6786
	// (get) Token: 0x06011923 RID: 71971 RVA: 0x0052E130 File Offset: 0x0052C330
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

	// Token: 0x06011924 RID: 71972 RVA: 0x0052E198 File Offset: 0x0052C398
	public static QuestTreeChapterViewModel Create()
	{
		return new QuestTreeChapterViewModel();
	}

	// Token: 0x06011925 RID: 71973 RVA: 0x0052E19F File Offset: 0x0052C39F
	public void InitLocatingHelper(UUIScrollViewComponent scroll)
	{
		if (this.LocatingHelper == null)
		{
			this.LocatingHelper = new QuestTreeNodeLocatingHelper(scroll);
		}
	}

	// Token: 0x06011926 RID: 71974 RVA: 0x0052E1B5 File Offset: 0x0052C3B5
	public void OnViewOpen(QuestTreeChapterView view)
	{
		this.View = view;
	}

	// Token: 0x06011927 RID: 71975 RVA: 0x0052E1BE File Offset: 0x0052C3BE
	public void OnViewClose()
	{
		this.Clear();
		this.View = null;
	}

	// Token: 0x06011928 RID: 71976 RVA: 0x0052E1D0 File Offset: 0x0052C3D0
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

	// Token: 0x06011929 RID: 71977 RVA: 0x0052E22D File Offset: 0x0052C42D
	public void AddOnSelectedDataChange([Nullable(new byte[]
	{
		1,
		2
	})] Action<QuestTreeNodeData> del)
	{
		this.DelegatesOnSelectedDataChange.Add(del);
	}

	// Token: 0x0601192A RID: 71978 RVA: 0x0052E23C File Offset: 0x0052C43C
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

	// Token: 0x0601192B RID: 71979 RVA: 0x0052E266 File Offset: 0x0052C466
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

	// Token: 0x0601192C RID: 71980 RVA: 0x0052E27F File Offset: 0x0052C47F
	public void AddOnLocatingNode([Nullable(new byte[]
	{
		1,
		2
	})] Action<QuestTreeNodeData, bool> del)
	{
		this.DelegatesOnLocatingNode.Add(del);
	}

	// Token: 0x0601192D RID: 71981 RVA: 0x0052E290 File Offset: 0x0052C490
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

	// Token: 0x0601192E RID: 71982 RVA: 0x0052E2BC File Offset: 0x0052C4BC
	[NullableContext(2)]
	public void LocateToNode(QuestTreeNodeData data, bool tween = true)
	{
		foreach (Action<QuestTreeNodeData, bool> action in this.DelegatesOnLocatingNode)
		{
			action(data, tween);
		}
	}

	// Token: 0x0601192F RID: 71983 RVA: 0x0052E310 File Offset: 0x0052C510
	public void SetShouldLocateToDefaultNode(bool should)
	{
		this.ShouldLocateToDefaultNode = should;
	}

	// Token: 0x06011930 RID: 71984 RVA: 0x0052E319 File Offset: 0x0052C519
	public void RecordHeightBalanceValue(int id, float valueTop, float valueBottom)
	{
		this.NodeHeightDeltaMap[id] = new ValueTuple<float, float>(valueTop, valueBottom);
	}

	// Token: 0x06011931 RID: 71985 RVA: 0x0052E32E File Offset: 0x0052C52E
	public void RemoveHeightBalanceValue(int id)
	{
		this.NodeHeightDeltaMap.Remove(id);
	}

	// Token: 0x06011932 RID: 71986 RVA: 0x0052E33D File Offset: 0x0052C53D
	public void RecordToggleHeight(float value)
	{
		if (value > this.MaxToggleHeight)
		{
			this.MaxToggleHeight = value;
		}
	}

	// Token: 0x06011933 RID: 71987 RVA: 0x0052E350 File Offset: 0x0052C550
	private void NotifySelectedDataChange()
	{
		foreach (Action<QuestTreeNodeData> action in this.DelegatesOnSelectedDataChange)
		{
			action(this.SelectedData);
		}
	}

	// Token: 0x06011934 RID: 71988 RVA: 0x0052E3A8 File Offset: 0x0052C5A8
	public void AddOnUpdateNode(Action del)
	{
		this.DelegatesOnUpdateNode.Add(del);
	}

	// Token: 0x06011935 RID: 71989 RVA: 0x0052E3B6 File Offset: 0x0052C5B6
	public void RemoveOnUpdateNode(Action del)
	{
		this.DelegatesOnUpdateNode.Remove(del);
	}

	// Token: 0x06011936 RID: 71990 RVA: 0x0052E3C8 File Offset: 0x0052C5C8
	public void NotifyUpdateNode()
	{
		foreach (Action action in this.DelegatesOnUpdateNode)
		{
			action();
		}
	}

	// Token: 0x06011937 RID: 71991 RVA: 0x0052E418 File Offset: 0x0052C618
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

	// Token: 0x040099D3 RID: 39379
	private bool InternalOverrideLockReasonGoto;

	// Token: 0x040099D4 RID: 39380
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly List<Action<QuestTreeNodeData>> DelegatesOnSelectedDataChange = new List<Action<QuestTreeNodeData>>();

	// Token: 0x040099D5 RID: 39381
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly List<Action<QuestTreeNodeData, bool>> DelegatesOnLocatingNode = new List<Action<QuestTreeNodeData, bool>>();

	// Token: 0x040099D6 RID: 39382
	private readonly List<Action> DelegatesOnUpdateNode = new List<Action>();

	// Token: 0x040099D7 RID: 39383
	public float MaxToggleHeight;

	// Token: 0x040099D8 RID: 39384
	[Nullable(2)]
	public QuestTreeNodeData SelectedData;

	// Token: 0x040099D9 RID: 39385
	[Nullable(2)]
	public QuestTreeNodeLocatingHelper LocatingHelper;

	// Token: 0x040099DA RID: 39386
	[Nullable(new byte[]
	{
		1,
		0
	})]
	public Dictionary<int, ValueTuple<float, float>> NodeHeightDeltaMap = new Dictionary<int, ValueTuple<float, float>>();

	// Token: 0x040099DB RID: 39387
	[Nullable(2)]
	public QuestTreeChapterView View;

	// Token: 0x040099DC RID: 39388
	[Nullable(2)]
	public QuestTreeNodeData LastSelectedDataCache;

	// Token: 0x040099DD RID: 39389
	public bool ShouldLocateToDefaultNode = true;
}
