using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002436 RID: 9270
[NullableContext(1)]
[Nullable(0)]
public class PhantomBattleFettersViewItem : UiPanelBase
{
	// Token: 0x0601296C RID: 76140 RVA: 0x00495A28 File Offset: 0x00493C28
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIScrollViewWithScrollbarComponent))
		};
		if (this.OnFastFilter != null)
		{
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, this.OnFastFilter)
			};
		}
		else
		{
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}
		this.BtnBindInfo.Add(new ValueTuple<int, Delegate>(12, new Action(this.OnClickDetect)));
	}

	// Token: 0x0601296D RID: 76141 RVA: 0x00495BCC File Offset: 0x00493DCC
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.PhantomFettersScrollView = new LoopScrollView<PhantomFettersItem, PhantomFetterItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<PhantomFettersItem>(this.OnGridProxyCreate), false);
		this.FilterEntrance = new FilterEntrance<PhantomFetterGroup>(base.GetItem(6), new TUpdateDataListFunction<PhantomFetterGroup>(this.OnFilterRefresh));
		this.SortEntrance = new SortEntrance<PhantomFetterGroup>(base.GetItem(7), new TUpdateDataListFunction<PhantomFetterGroup>(this.OnFilterRefresh));
		this.Layout = new GenericLayout<VisionFetterDescItem, VisionFetterDescData>(base.GetVerticalLayout(3), new Func<VisionFetterDescItem>(this.InitItem), null, false, true);
		this.MonsterLayout = new GenericLayout<VisionFetterMonsterItem, VisionFetterMonsterData>(base.GetVerticalLayout(10), new Func<VisionFetterMonsterItem>(this.InitMonsterItem), null, false, true);
		this.FilterEntrance.SetUiActive(!CalabashModel.Instance.OnlyShowBattleFettersTab);
		this.SortEntrance.SetUiActive(!CalabashModel.Instance.OnlyShowBattleFettersTab);
	}

	// Token: 0x0601296E RID: 76142 RVA: 0x00495CC9 File Offset: 0x00493EC9
	private VisionFetterMonsterItem InitMonsterItem()
	{
		return new VisionFetterMonsterItem();
	}

	// Token: 0x0601296F RID: 76143 RVA: 0x00495CD0 File Offset: 0x00493ED0
	public UniTask PlayStartSequence()
	{
		PhantomBattleFettersViewItem.<PlayStartSequence>d__18 <PlayStartSequence>d__;
		<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayStartSequence>d__.<>4__this = this;
		<PlayStartSequence>d__.<>1__state = -1;
		<PlayStartSequence>d__.<>t__builder.Start<PhantomBattleFettersViewItem.<PlayStartSequence>d__18>(ref <PlayStartSequence>d__);
		return <PlayStartSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06012970 RID: 76144 RVA: 0x00495D14 File Offset: 0x00493F14
	public UniTask PlayHideSequence()
	{
		PhantomBattleFettersViewItem.<PlayHideSequence>d__19 <PlayHideSequence>d__;
		<PlayHideSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideSequence>d__.<>4__this = this;
		<PlayHideSequence>d__.<>1__state = -1;
		<PlayHideSequence>d__.<>t__builder.Start<PhantomBattleFettersViewItem.<PlayHideSequence>d__19>(ref <PlayHideSequence>d__);
		return <PlayHideSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06012971 RID: 76145 RVA: 0x00495D57 File Offset: 0x00493F57
	private VisionFetterDescItem InitItem()
	{
		return new VisionFetterDescItem();
	}

	// Token: 0x06012972 RID: 76146 RVA: 0x00495D60 File Offset: 0x00493F60
	private void OnClickDetect()
	{
		SkipTaskManager.RunByConfigId(PhantomBattleConfig.Instance.GetFetterGroupById(this.CurrentSelectGroupId).AccessId, null);
	}

	// Token: 0x06012973 RID: 76147 RVA: 0x00495D8B File Offset: 0x00493F8B
	private PhantomFettersItem OnGridProxyCreate()
	{
		PhantomFettersItem phantomFettersItem = new PhantomFettersItem();
		phantomFettersItem.BindOnItemButtonClickedCallback(new Action<PhantomFetterItemData>(this.OnItemButtonClicked));
		return phantomFettersItem;
	}

	// Token: 0x06012974 RID: 76148 RVA: 0x00495DA4 File Offset: 0x00493FA4
	protected override void OnBeforeShow()
	{
		object openParam = this.OpenParam;
		bool flag;
		bool flag2;
		if (openParam is bool)
		{
			flag = (bool)openParam;
			flag2 = true;
		}
		else
		{
			flag2 = false;
		}
		this.NeedProcessObserver = (flag2 && flag);
		if (UiSceneManager.Instance.HasVisionSkeletalHandle() && this.NeedProcessObserver)
		{
			UiModelBase model = UiSceneManager.Instance.GetVisionSkeletalHandle().Model;
			UiModelDataComponent uiModelDataComponent = (model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null;
			this.ObserverShowState = (uiModelDataComponent != null && uiModelDataComponent.GetVisible());
			if (uiModelDataComponent != null)
			{
				uiModelDataComponent.SetVisible(false);
			}
		}
		this.UpdateFliterComponent();
	}

	// Token: 0x06012975 RID: 76149 RVA: 0x00495E28 File Offset: 0x00494028
	private void UpdateFliterComponent()
	{
		PhantomFetterGroup[] phantomFetterGroupList = CalabashModel.Instance.GetPhantomFetterGroupList();
		this.FilterEntrance.UpdateData(this.UseWayId, phantomFetterGroupList.ToList<PhantomFetterGroup>(), new object[]
		{
			this.RoleId
		});
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(this.UseWayId);
		this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId);
		this.SortEntrance.UpdateData(this.UseWayId, phantomFetterGroupList.ToList<PhantomFetterGroup>(), new object[]
		{
			this.RoleId
		});
		int uniqueIdByGroupId2 = this.SortEntrance.GetUniqueIdByGroupId(this.UseWayId);
		this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId2);
	}

	// Token: 0x06012976 RID: 76150 RVA: 0x00495ED4 File Offset: 0x004940D4
	private void SortFetterDataListByRecommend()
	{
		if (this.PhantomFetterDataList == null || this.PhantomFetterDataList.Count == 0)
		{
			return;
		}
		if (this.RecommendGroupIds.Count == 0)
		{
			return;
		}
		Dictionary<int, int> orderMap = new Dictionary<int, int>();
		for (int i = 0; i < this.RecommendGroupIds.Count; i++)
		{
			orderMap[this.RecommendGroupIds[i]] = i;
		}
		this.PhantomFetterDataList.Sort(delegate(PhantomFetterItemData a, PhantomFetterItemData b)
		{
			int value;
			int? num = orderMap.TryGetValue(a.PhantomFetterGroup.Value.Id, out value) ? new int?(value) : null;
			int value2;
			int? num2 = orderMap.TryGetValue(b.PhantomFetterGroup.Value.Id, out value2) ? new int?(value2) : null;
			if (num != null && num2 != null)
			{
				return num.Value - num2.Value;
			}
			if (num != null)
			{
				return -1;
			}
			if (num2 != null)
			{
				return 1;
			}
			return 0;
		});
	}

	// Token: 0x06012977 RID: 76151 RVA: 0x00495F5C File Offset: 0x0049415C
	private void OnFilterRefresh(List<PhantomFetterGroup> list, bool isOutSideChange, EFilterSortType operationType)
	{
		this.PhantomFetterDataList = new List<PhantomFetterItemData>();
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			PhantomFetterItemData phantomFetterItemData = new PhantomFetterItemData();
			phantomFetterItemData.PhantomFetterGroup = new PhantomFetterGroup?(list[i]);
			phantomFetterItemData.RoleId = this.RoleId;
			phantomFetterItemData.RecommendGroupIds = this.RecommendGroupIds;
			this.PhantomFetterDataList.Add(phantomFetterItemData);
		}
		this.SortFetterDataListByRecommend();
		this.RefreshScrollView();
		this.RefreshRightItem(list);
	}

	// Token: 0x06012978 RID: 76152 RVA: 0x00495FD8 File Offset: 0x004941D8
	private void RefreshRightItem(IList list)
	{
		base.GetItem(8).SetUIActive(list.Count > 0);
		base.GetButton(5).RootUIComp.Get().SetUIActive(list.Count > 0 && this.OnFastFilter != null);
	}

	// Token: 0x06012979 RID: 76153 RVA: 0x00496028 File Offset: 0x00494228
	private void RefreshMonster(List<int> monsterList)
	{
		int count = monsterList.Count;
		Dictionary<int, List<VisionDetailMonsterItemData>> dictionary = new Dictionary<int, List<VisionDetailMonsterItemData>>();
		for (int i = 0; i < count; i++)
		{
			int rarity = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(monsterList[i])[0].Rarity;
			int cost = PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity).Value.Cost;
			List<VisionDetailMonsterItemData> list;
			if (!dictionary.TryGetValue(cost, out list))
			{
				list = new List<VisionDetailMonsterItemData>();
				dictionary.Add(cost, list);
			}
			list.Add(new VisionDetailMonsterItemData(monsterList[i], 0, this.RoleId));
		}
		int? onlyMonsterCostShowMaxLevel = CalabashModel.Instance.OnlyMonsterCostShowMaxLevel;
		List<VisionFetterMonsterData> list2 = new List<VisionFetterMonsterData>();
		foreach (KeyValuePair<int, List<VisionDetailMonsterItemData>> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			List<VisionDetailMonsterItemData> value = keyValuePair.Value;
			if (onlyMonsterCostShowMaxLevel != null)
			{
				int? num = onlyMonsterCostShowMaxLevel;
				int num2 = key;
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					continue;
				}
			}
			list2.Add(new VisionFetterMonsterData
			{
				Cost = key,
				MonsterList = value
			});
		}
		list2.Sort((VisionFetterMonsterData a, VisionFetterMonsterData b) => b.Cost - a.Cost);
		if (list2.Count > 0)
		{
			this.MonsterLayout.RefreshByData(list2, null, false);
		}
		int monsterFindCountByMonsterIdArray = PhantomBattleModel.Instance.GetMonsterFindCountByMonsterIdArray(monsterList.ToArray());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "Illustration_Progress_Iteration", new <>z__ReadOnlyArray<object>(new object[]
		{
			monsterFindCountByMonsterIdArray,
			monsterList.Count
		}));
	}

	// Token: 0x0601297A RID: 76154 RVA: 0x00496204 File Offset: 0x00494404
	private void RefreshScrollView()
	{
		if (this.PhantomFetterDataList == null)
		{
			Log.Instance.Info(ELogModule.Phantom, ELogAuthor.YZY, "没有羁绊幻象", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PhantomFettersScrollView.DeselectCurrentGridProxy(false);
		this.PhantomFettersScrollView.ReloadData(this.PhantomFetterDataList, false);
		if (this.OutSizeSelectFetterGroupId == 0)
		{
			this.PhantomFettersScrollView.SelectGridProxy(0, false);
			this.PhantomFettersScrollView.RefreshGridProxy(0);
			this.RefreshRight(this.PhantomFetterDataList[0].PhantomFetterGroup.Value);
			return;
		}
		int gridIndex = 0;
		int count = this.PhantomFetterDataList.Count;
		for (int i = 0; i < count; i++)
		{
			if (this.PhantomFetterDataList[i].PhantomFetterGroup.Value.Id == this.OutSizeSelectFetterGroupId)
			{
				gridIndex = i;
				break;
			}
		}
		this.PhantomFettersScrollView.ScrollToGridIndex(gridIndex, true);
		this.PhantomFettersScrollView.SelectGridProxy(gridIndex, false);
		this.PhantomFettersScrollView.RefreshGridProxy(gridIndex);
	}

	// Token: 0x0601297B RID: 76155 RVA: 0x00496300 File Offset: 0x00494500
	public void SelectByFetterId(int id)
	{
		int num = this.PhantomFetterDataList.FindIndex((PhantomFetterItemData data) => data.PhantomFetterGroup.Value.Id == id);
		if (num >= 0)
		{
			this.PhantomFettersScrollView.ScrollToGridIndex(num, true);
			this.PhantomFettersScrollView.SelectGridProxy(num, false);
		}
	}

	// Token: 0x0601297C RID: 76156 RVA: 0x00496350 File Offset: 0x00494550
	public void SetSelectRoleId(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x0601297D RID: 76157 RVA: 0x00496359 File Offset: 0x00494559
	public void SetRecommendGroupIds(List<int> groupIds)
	{
		this.RecommendGroupIds = groupIds;
	}

	// Token: 0x0601297E RID: 76158 RVA: 0x00496364 File Offset: 0x00494564
	private void RefreshRight(PhantomFetterGroup itemData)
	{
		this.CurrentSelectGroupId = itemData.Id;
		this.RefreshName(itemData.FetterGroupName);
		this.RefreshInfo(itemData.FetterMap());
		this.RefreshConfigInfo(itemData.FetterGroupDesc);
		List<int> monsterList = PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(this.CurrentSelectGroupId).ToList<int>();
		this.RefreshMonster(monsterList);
		base.GetScrollViewWithScrollbar(13).SetScrollProgress(0f);
	}

	// Token: 0x0601297F RID: 76159 RVA: 0x004963D4 File Offset: 0x004945D4
	private void RefreshName(string name)
	{
		base.GetText(2).ShowTextNew(name);
	}

	// Token: 0x06012980 RID: 76160 RVA: 0x004963E4 File Offset: 0x004945E4
	private void RefreshInfo(Dictionary<int, int> data)
	{
		List<VisionFetterDescData> list = new List<VisionFetterDescData>();
		foreach (KeyValuePair<int, int> keyValuePair in data)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			list.Add(new VisionFetterDescData
			{
				Key = key,
				Value = value
			});
		}
		this.Layout.RefreshByData(list, null, true);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (((levelSequencePlayer != null) ? levelSequencePlayer.GetCurrentSequence() : null) == "Switch")
		{
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.ReplaySequenceByKey("Switch");
			return;
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 != null)
			{
				levelSequencePlayer3.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
			if (levelSequencePlayer4 == null)
			{
				return;
			}
			levelSequencePlayer4.PlayLevelSequenceByName("Switch", false, null, false);
			return;
		}
	}

	// Token: 0x06012981 RID: 76161 RVA: 0x004964D8 File Offset: 0x004946D8
	private void RefreshConfigInfo(string configInfo)
	{
		base.GetText(4).ShowTextNew(configInfo);
	}

	// Token: 0x06012982 RID: 76162 RVA: 0x004964E8 File Offset: 0x004946E8
	private void OnItemButtonClicked(PhantomFetterItemData itemData)
	{
		this.PhantomFettersScrollView.DeselectCurrentGridProxy(false);
		int gridIndex = this.PhantomFetterDataList.IndexOf(itemData);
		if (!this.PhantomFettersScrollView.IsGridDisplaying(gridIndex))
		{
			return;
		}
		this.RefreshRight(itemData.PhantomFetterGroup.Value);
		this.PhantomFettersScrollView.SelectGridProxy(gridIndex, false);
		this.PhantomFettersScrollView.RefreshGridProxy(gridIndex);
	}

	// Token: 0x06012983 RID: 76163 RVA: 0x00496547 File Offset: 0x00494747
	public int GetCurrentSelectGroupId()
	{
		return this.CurrentSelectGroupId;
	}

	// Token: 0x06012984 RID: 76164 RVA: 0x00496550 File Offset: 0x00494750
	protected override void OnBeforeDestroy()
	{
		PhantomBattleModel.Instance.CurrentSelectedFetter = null;
		if (UiSceneManager.Instance.HasVisionSkeletalHandle() && this.NeedProcessObserver)
		{
			SkeletalObserverHandle visionSkeletalHandle = UiSceneManager.Instance.GetVisionSkeletalHandle();
			UiModelBase uiModelBase = (visionSkeletalHandle != null) ? visionSkeletalHandle.Model : null;
			if (uiModelBase != null)
			{
				UiModelUtil.Instance.SetVisible(uiModelBase, this.ObserverShowState);
			}
		}
		if (this.PhantomFettersScrollView != null)
		{
			this.PhantomFettersScrollView.ClearGridProxies();
			this.PhantomFettersScrollView = null;
		}
	}

	// Token: 0x04008C1C RID: 35868
	private readonly EFilterSortGroupId UseWayId = EFilterSortGroupId.PhantomFetter;

	// Token: 0x04008C1D RID: 35869
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PhantomFettersItem, PhantomFetterItemData> PhantomFettersScrollView;

	// Token: 0x04008C1E RID: 35870
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhantomFetterItemData> PhantomFetterDataList;

	// Token: 0x04008C1F RID: 35871
	[Nullable(2)]
	private FilterEntrance<PhantomFetterGroup> FilterEntrance;

	// Token: 0x04008C20 RID: 35872
	[Nullable(2)]
	private SortEntrance<PhantomFetterGroup> SortEntrance;

	// Token: 0x04008C21 RID: 35873
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionFetterDescItem, VisionFetterDescData> Layout;

	// Token: 0x04008C22 RID: 35874
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionFetterMonsterItem, VisionFetterMonsterData> MonsterLayout;

	// Token: 0x04008C23 RID: 35875
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04008C24 RID: 35876
	private int CurrentSelectGroupId;

	// Token: 0x04008C25 RID: 35877
	private int RoleId;

	// Token: 0x04008C26 RID: 35878
	private List<int> RecommendGroupIds = new List<int>();

	// Token: 0x04008C27 RID: 35879
	private readonly int OutSizeSelectFetterGroupId;

	// Token: 0x04008C28 RID: 35880
	private bool ObserverShowState;

	// Token: 0x04008C29 RID: 35881
	private bool NeedProcessObserver;

	// Token: 0x04008C2A RID: 35882
	[Nullable(2)]
	public Action OnFastFilter;
}
