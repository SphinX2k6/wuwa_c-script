using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200191B RID: 6427
[NullableContext(1)]
[Nullable(0)]
public class PhantomBattleFettersViewItem : UiPanelBase
{
	// Token: 0x0600FE22 RID: 65058 RVA: 0x004A2FF4 File Offset: 0x004A11F4
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

	// Token: 0x0600FE23 RID: 65059 RVA: 0x004A3198 File Offset: 0x004A1398
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

	// Token: 0x0600FE24 RID: 65060 RVA: 0x004A3295 File Offset: 0x004A1495
	private VisionFetterMonsterItem InitMonsterItem()
	{
		return new VisionFetterMonsterItem();
	}

	// Token: 0x0600FE25 RID: 65061 RVA: 0x004A329C File Offset: 0x004A149C
	public UniTask PlayStartSequence()
	{
		PhantomBattleFettersViewItem.<PlayStartSequence>d__18 <PlayStartSequence>d__;
		<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayStartSequence>d__.<>4__this = this;
		<PlayStartSequence>d__.<>1__state = -1;
		<PlayStartSequence>d__.<>t__builder.Start<PhantomBattleFettersViewItem.<PlayStartSequence>d__18>(ref <PlayStartSequence>d__);
		return <PlayStartSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600FE26 RID: 65062 RVA: 0x004A32E0 File Offset: 0x004A14E0
	public UniTask PlayHideSequence()
	{
		PhantomBattleFettersViewItem.<PlayHideSequence>d__19 <PlayHideSequence>d__;
		<PlayHideSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideSequence>d__.<>4__this = this;
		<PlayHideSequence>d__.<>1__state = -1;
		<PlayHideSequence>d__.<>t__builder.Start<PhantomBattleFettersViewItem.<PlayHideSequence>d__19>(ref <PlayHideSequence>d__);
		return <PlayHideSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600FE27 RID: 65063 RVA: 0x004A3323 File Offset: 0x004A1523
	private VisionFetterDescItem InitItem()
	{
		return new VisionFetterDescItem();
	}

	// Token: 0x0600FE28 RID: 65064 RVA: 0x004A332C File Offset: 0x004A152C
	private void OnClickDetect()
	{
		SkipTaskManager.RunByConfigId(PhantomBattleConfig.Instance.GetFetterGroupById(this.CurrentSelectGroupId).AccessId, null);
	}

	// Token: 0x0600FE29 RID: 65065 RVA: 0x004A3357 File Offset: 0x004A1557
	private PhantomFettersItem OnGridProxyCreate()
	{
		PhantomFettersItem phantomFettersItem = new PhantomFettersItem();
		phantomFettersItem.BindOnItemButtonClickedCallback(new Action<PhantomFetterItemData>(this.OnItemButtonClicked));
		return phantomFettersItem;
	}

	// Token: 0x0600FE2A RID: 65066 RVA: 0x004A3370 File Offset: 0x004A1570
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

	// Token: 0x0600FE2B RID: 65067 RVA: 0x004A33F4 File Offset: 0x004A15F4
	private void UpdateFliterComponent()
	{
		PhantomFetterGroup[] phantomFetterGroupList = CalabashModel.Instance.GetPhantomFetterGroupList();
		this.FilterEntrance.UpdateData(this.UseWayId, new List<PhantomFetterGroup>(phantomFetterGroupList), new object[]
		{
			this.RoleId
		});
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(this.UseWayId);
		this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId);
		this.SortEntrance.UpdateData(this.UseWayId, new List<PhantomFetterGroup>(phantomFetterGroupList), new object[]
		{
			this.RoleId
		});
		int uniqueIdByGroupId2 = this.SortEntrance.GetUniqueIdByGroupId(this.UseWayId);
		this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId2);
	}

	// Token: 0x0600FE2C RID: 65068 RVA: 0x004A34A0 File Offset: 0x004A16A0
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

	// Token: 0x0600FE2D RID: 65069 RVA: 0x004A3528 File Offset: 0x004A1728
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

	// Token: 0x0600FE2E RID: 65070 RVA: 0x004A35A4 File Offset: 0x004A17A4
	private void RefreshRightItem(IList list)
	{
		base.GetItem(8).SetUIActive(list.Count > 0);
		base.GetButton(5).RootUIComp.Get().SetUIActive(list.Count > 0 && this.OnFastFilter != null);
	}

	// Token: 0x0600FE2F RID: 65071 RVA: 0x004A35F4 File Offset: 0x004A17F4
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

	// Token: 0x0600FE30 RID: 65072 RVA: 0x004A37D0 File Offset: 0x004A19D0
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

	// Token: 0x0600FE31 RID: 65073 RVA: 0x004A38CC File Offset: 0x004A1ACC
	public void SelectByFetterId(int id)
	{
		int num = this.PhantomFetterDataList.FindIndex((PhantomFetterItemData data) => data.PhantomFetterGroup.Value.Id == id);
		if (num >= 0)
		{
			this.PhantomFettersScrollView.ScrollToGridIndex(num, true);
			this.PhantomFettersScrollView.SelectGridProxy(num, false);
		}
	}

	// Token: 0x0600FE32 RID: 65074 RVA: 0x004A391C File Offset: 0x004A1B1C
	public void SetSelectRoleId(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x0600FE33 RID: 65075 RVA: 0x004A3925 File Offset: 0x004A1B25
	public void SetRecommendGroupIds(List<int> groupIds)
	{
		this.RecommendGroupIds = groupIds;
	}

	// Token: 0x0600FE34 RID: 65076 RVA: 0x004A3930 File Offset: 0x004A1B30
	private void RefreshRight(PhantomFetterGroup itemData)
	{
		this.CurrentSelectGroupId = itemData.Id;
		this.RefreshName(itemData.FetterGroupName);
		this.RefreshInfo(itemData.FetterMap());
		this.RefreshConfigInfo(itemData.FetterGroupDesc);
		List<int> monsterList = new List<int>(PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(this.CurrentSelectGroupId));
		this.RefreshMonster(monsterList);
		base.GetScrollViewWithScrollbar(13).SetScrollProgress(0f);
	}

	// Token: 0x0600FE35 RID: 65077 RVA: 0x004A39A0 File Offset: 0x004A1BA0
	private void RefreshName(string name)
	{
		base.GetText(2).ShowTextNew(name);
	}

	// Token: 0x0600FE36 RID: 65078 RVA: 0x004A39B0 File Offset: 0x004A1BB0
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

	// Token: 0x0600FE37 RID: 65079 RVA: 0x004A3AA4 File Offset: 0x004A1CA4
	private void RefreshConfigInfo(string configInfo)
	{
		base.GetText(4).ShowTextNew(configInfo);
	}

	// Token: 0x0600FE38 RID: 65080 RVA: 0x004A3AB4 File Offset: 0x004A1CB4
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

	// Token: 0x0600FE39 RID: 65081 RVA: 0x004A3B13 File Offset: 0x004A1D13
	public int GetCurrentSelectGroupId()
	{
		return this.CurrentSelectGroupId;
	}

	// Token: 0x0600FE3A RID: 65082 RVA: 0x004A3B1C File Offset: 0x004A1D1C
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

	// Token: 0x04008D63 RID: 36195
	private readonly EFilterSortGroupId UseWayId = EFilterSortGroupId.PhantomFetter;

	// Token: 0x04008D64 RID: 36196
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PhantomFettersItem, PhantomFetterItemData> PhantomFettersScrollView;

	// Token: 0x04008D65 RID: 36197
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhantomFetterItemData> PhantomFetterDataList;

	// Token: 0x04008D66 RID: 36198
	[Nullable(2)]
	private FilterEntrance<PhantomFetterGroup> FilterEntrance;

	// Token: 0x04008D67 RID: 36199
	[Nullable(2)]
	private SortEntrance<PhantomFetterGroup> SortEntrance;

	// Token: 0x04008D68 RID: 36200
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionFetterDescItem, VisionFetterDescData> Layout;

	// Token: 0x04008D69 RID: 36201
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionFetterMonsterItem, VisionFetterMonsterData> MonsterLayout;

	// Token: 0x04008D6A RID: 36202
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04008D6B RID: 36203
	private int CurrentSelectGroupId;

	// Token: 0x04008D6C RID: 36204
	private int RoleId;

	// Token: 0x04008D6D RID: 36205
	private List<int> RecommendGroupIds = new List<int>();

	// Token: 0x04008D6E RID: 36206
	private readonly int OutSizeSelectFetterGroupId;

	// Token: 0x04008D6F RID: 36207
	private bool ObserverShowState;

	// Token: 0x04008D70 RID: 36208
	private bool NeedProcessObserver;

	// Token: 0x04008D71 RID: 36209
	[Nullable(2)]
	public Action OnFastFilter;
}
