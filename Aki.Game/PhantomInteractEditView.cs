using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002477 RID: 9335
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractEditView : UiViewBase
{
	// Token: 0x06012BBC RID: 76732 RVA: 0x0049ED08 File Offset: 0x0049CF08
	public PhantomInteractEditView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012BBD RID: 76733 RVA: 0x0049EDCF File Offset: 0x0049CFCF
	private void LocalLog(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
	}

	// Token: 0x06012BBE RID: 76734 RVA: 0x0049EDD4 File Offset: 0x0049CFD4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem))
		};
		foreach (ICostToggleInfo costToggleInfo in this.allCostToggleInfo)
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(costToggleInfo.Component, typeof(UUIItem)));
		}
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnMoveNextSkinClick))
		};
	}

	// Token: 0x06012BBF RID: 76735 RVA: 0x0049EF6C File Offset: 0x0049D16C
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomInteractEditView.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomInteractEditView.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012BC0 RID: 76736 RVA: 0x0049EFAF File Offset: 0x0049D1AF
	protected override void OnDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
	}

	// Token: 0x06012BC1 RID: 76737 RVA: 0x0049EFC9 File Offset: 0x0049D1C9
	protected override void OnBeforeShow()
	{
		this.SetOtherTeamEntitiesEnable(false);
	}

	// Token: 0x06012BC2 RID: 76738 RVA: 0x0049EFD2 File Offset: 0x0049D1D2
	protected override void OnAfterHide()
	{
		PhantomInteractDetailPanelGroup detailPanelGroup = this.DetailPanelGroup;
		if (detailPanelGroup != null)
		{
			detailPanelGroup.RefreshDetailPanel(false, null);
		}
		this.SetOtherTeamEntitiesEnable(true);
	}

	// Token: 0x06012BC3 RID: 76739 RVA: 0x0049EFF0 File Offset: 0x0049D1F0
	private void InitDropDown()
	{
		this.FilterDropDown.SetOnSelectCall(new Action<int, EFilterIsSpecialOption>(this.OnDropDownSelectCall));
		this.FilterDropDown.SetShowType(ECommonDropDownShowType.Up);
		this.FilterDropDown.InitScroll(this.allFilterOption, new Func<EFilterIsSpecialOption, int>(this.GetDropDownTextId), 0, true);
	}

	// Token: 0x06012BC4 RID: 76740 RVA: 0x0049F03F File Offset: 0x0049D23F
	private int GetDropDownTextId(EFilterIsSpecialOption data)
	{
		return (int)data;
	}

	// Token: 0x06012BC5 RID: 76741 RVA: 0x0049F044 File Offset: 0x0049D244
	private void OnDropDownSelectCall(int index, EFilterIsSpecialOption data)
	{
		PhantomInteractEditViewModel editViewModel = PhantomInteractModel.Instance.EditViewModel;
		this.RefreshRightScrollViewGrid(-1);
		editViewModel.SetFilterIsSpecial(data);
		if (this.ViewStarted)
		{
			editViewModel.RefreshFilterGridViewData();
		}
		this.Refresh();
		this.RefreshRightScrollData();
		this.RefreshRightScrollView(null, true);
	}

	// Token: 0x06012BC6 RID: 76742 RVA: 0x0049F094 File Offset: 0x0049D294
	protected override void OnStart()
	{
		PhantomInteractEditViewParam phantomInteractEditViewParam = this.OpenParam as PhantomInteractEditViewParam;
		if (phantomInteractEditViewParam == null)
		{
			return;
		}
		PhantomInteractEditViewModel editViewModel = PhantomInteractModel.Instance.EditViewModel;
		this.CaptionPanel = new PopupCaptionItem(base.GetItem(7));
		this.CaptionPanel.SetCloseCallBack(delegate
		{
			base.CloseMe(null);
		});
		this.CaptionPanel.SetTitleByTextIdAndArgNew("ExploreTools_1007_Name", Array.Empty<object>());
		this.CaptionPanel.SetTitleIcon("/Game/Aki/UI/UIResources/Common/Atlas/SkillIcon/SkillIconNor/SP_IconT29.SP_IconT29");
		this.CaptionPanel.SetHelpCallBack(delegate
		{
			HelpController.Instance.OpenHelpById(473);
		});
		this.InitDropDown();
		PhantomInteractListPanel visionList = this.VisionList;
		if (visionList != null)
		{
			visionList.Refresh(phantomInteractEditViewParam.InfoData.EquippedVisionData.Cast<IPhantomInteractItemData>().ToList<IPhantomInteractItemData>(), true, true);
		}
		this.RefreshRightScrollData();
		IPhantomInteractItemData selectedItemData = editViewModel.SelectedItemData;
		int value = editViewModel.FindGridIndexInMultiTemplate((selectedItemData != null) ? selectedItemData.MonsterId : 0);
		this.RefreshRightScrollView(new int?(value), false);
		this.Refresh();
		if (phantomInteractEditViewParam.FromSummonView)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.PlayLevelSequenceByName("Start01", false, null, false);
			}
		}
		else
		{
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 != null)
			{
				seqPlayer2.PlayLevelSequenceByName("Start02", false, null, false);
			}
		}
		this.ViewStarted = true;
	}

	// Token: 0x06012BC7 RID: 76743 RVA: 0x0049F1E5 File Offset: 0x0049D3E5
	protected override void OnAddEventListener()
	{
		if (EventSystem.Instance.HasWithTarget<HitInformation, HitContext>(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit)))
		{
			return;
		}
		EventSystem.Instance.AddWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit));
	}

	// Token: 0x06012BC8 RID: 76744 RVA: 0x0049F225 File Offset: 0x0049D425
	protected override void OnRemoveEventListener()
	{
		this.RemoveCharBeHitListener();
	}

	// Token: 0x06012BC9 RID: 76745 RVA: 0x0049F22D File Offset: 0x0049D42D
	private CostTabItem TabItemProxyCreate(UUIItem uiItem, int index)
	{
		CostTabItem costTabItem = new CostTabItem(uiItem);
		costTabItem.Init();
		return costTabItem;
	}

	// Token: 0x06012BCA RID: 76746 RVA: 0x0049F23C File Offset: 0x0049D43C
	private void ToggleCallBack(int index)
	{
		PhantomInteractEditViewModel editViewModel = PhantomInteractModel.Instance.EditViewModel;
		int costValue = this.allCostToggleInfo[index].CostValue;
		this.RefreshRightScrollViewGrid(-1);
		editViewModel.SetFilterCost(costValue);
		if (this.ViewStarted)
		{
			editViewModel.RefreshFilterGridViewData();
		}
		this.Refresh();
		this.RefreshRightScrollData();
		this.RefreshRightScrollView(null, true);
	}

	// Token: 0x06012BCB RID: 76747 RVA: 0x0049F29C File Offset: 0x0049D49C
	private void ConfirmEquipHandler(int _)
	{
		PhantomInteractEditViewModel editViewModel = PhantomInteractModel.Instance.EditViewModel;
		IPhantomInteractItemData selectedItemData = editViewModel.SelectedItemData;
		int num = (selectedItemData != null) ? selectedItemData.MonsterId : 0;
		editViewModel.ConfirmEquipHandler();
		this.Refresh();
		PhantomInteractEditViewModel phantomInteractEditViewModel = editViewModel;
		PhantomInteractEditGridViewModel selectedGridData = editViewModel.SelectedGridData;
		int num2 = phantomInteractEditViewModel.FindGridIndexInMultiTemplate((selectedGridData != null) ? selectedGridData.MonsterId : 0);
		if (num2 >= 0)
		{
			this.RefreshRightScrollViewGrid(num2);
		}
		if (num <= 0)
		{
			return;
		}
		int num3 = editViewModel.FindGridIndexInMultiTemplate(num);
		if (num3 >= 0)
		{
			this.RefreshRightScrollViewGrid(num3);
		}
	}

	// Token: 0x06012BCC RID: 76748 RVA: 0x0049F310 File Offset: 0x0049D510
	private void ReplaceRecommendHandler()
	{
		PhantomInteractEditViewModel viewModel = PhantomInteractModel.Instance.EditViewModel;
		viewModel.SetEquipRecommendCallback(delegate
		{
			this.Refresh();
			List<int> filteredRecommendedIdList = viewModel.GetFilteredRecommendedIdList();
			int num = (filteredRecommendedIdList != null) ? filteredRecommendedIdList.Count : 0;
			for (int i = 0; i < num; i++)
			{
				int gridIndex = i + 1;
				this.RefreshRightScrollViewGrid(gridIndex);
			}
			this.RefreshRightScrollView(new int?(-1), false);
		});
		viewModel.EquipRecommendHandler();
	}

	// Token: 0x06012BCD RID: 76749 RVA: 0x0049F35C File Offset: 0x0049D55C
	private void OnListItemClick(IPhantomInteractItemData itemData)
	{
		PhantomInteractEditViewModel editViewModel = PhantomInteractModel.Instance.EditViewModel;
		int itemIndex = itemData.ItemIndex;
		IPhantomInteractItemData selectedItemData = editViewModel.SelectedItemData;
		bool flag = itemIndex != ((selectedItemData != null) ? selectedItemData.ItemIndex : -1);
		int monsterId = itemData.MonsterId;
		if (flag && monsterId > 0)
		{
			int num = editViewModel.FindGridIndexInMultiTemplate(itemData.MonsterId);
			if (num < 0)
			{
				StaticTabComponent<CostTabItem> costTabComponent = this.CostTabComponent;
				object obj = costTabComponent == null || costTabComponent.GetSelectedIndex() != 0;
				CommonDropDown<int, EFilterIsSpecialOption> filterDropDown = this.FilterDropDown;
				bool flag2 = filterDropDown == null || filterDropDown.GetSelectedIndex() != 0;
				object obj2 = obj;
				if (obj2 != null)
				{
					StaticTabComponent<CostTabItem> costTabComponent2 = this.CostTabComponent;
					if (costTabComponent2 != null)
					{
						costTabComponent2.SelectToggleByIndex(0, true);
					}
				}
				if (flag2)
				{
					CommonDropDown<int, EFilterIsSpecialOption> filterDropDown2 = this.FilterDropDown;
					if (filterDropDown2 != null)
					{
						filterDropDown2.SetSelectedIndex(0, true);
					}
				}
				if ((obj2 | flag2) != null)
				{
					num = editViewModel.FindGridIndexInMultiTemplate(itemData.MonsterId);
				}
			}
			this.RefreshRightScrollView(new int?((num < 0) ? 0 : num), true);
		}
		editViewModel.SelectItem(itemData.ItemIndex);
		this.Refresh();
	}

	// Token: 0x06012BCE RID: 76750 RVA: 0x0049F444 File Offset: 0x0049D644
	private void OnMoveNextSkinClick()
	{
		PhantomInteractEditViewModel editViewModel = PhantomInteractModel.Instance.EditViewModel;
		editViewModel.MoveNextSkinHandler();
		this.Refresh();
		PhantomInteractEditGridViewModel selectedGridData = editViewModel.SelectedGridData;
		int num = editViewModel.FindGridIndexInMultiTemplate((selectedGridData != null) ? selectedGridData.MonsterId : 0);
		if (num >= 0)
		{
			this.RefreshRightScrollViewGrid(num);
		}
	}

	// Token: 0x06012BCF RID: 76751 RVA: 0x0049F48C File Offset: 0x0049D68C
	public void Refresh()
	{
		PhantomInteractInfoData interactInfoData = PhantomInteractModel.Instance.InteractInfoData;
		PhantomInteractEditViewModel editViewModel = PhantomInteractModel.Instance.EditViewModel;
		this.ApplyBtnState(editViewModel.BtnState, editViewModel.BtnAvailable);
		PhantomInteractListPanel visionList = this.VisionList;
		if (visionList != null)
		{
			visionList.Refresh(interactInfoData.EquippedVisionData.Cast<IPhantomInteractItemData>().ToList<IPhantomInteractItemData>(), true, true);
		}
		IPhantomInteractItemData selectedItemData = editViewModel.SelectedItemData;
		if (selectedItemData != null)
		{
			this.VisionList.SetSelectedItem(selectedItemData.ItemIndex);
		}
		PhantomInteractEditGridViewModel selectedGridData = editViewModel.SelectedGridData;
		bool flag = selectedGridData != null && selectedGridData.IsUnlocked;
		PhantomInteractEditGridViewModel selectedGridData2 = editViewModel.SelectedGridData;
		bool flag2 = selectedGridData2 != null && selectedGridData2.HasSkin;
		UUIButtonComponent button = base.GetButton(6);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag2 && flag);
		}
		int num = (selectedGridData != null) ? selectedGridData.MonsterId : 0;
		if (this.CurrentDetailMonsterId != num)
		{
			this.CurrentDetailMonsterId = num;
		}
		PhantomInteractEditGridViewModel selectedGridData3 = editViewModel.SelectedGridData;
		int newId = (selectedGridData3 != null) ? selectedGridData3.MonsterId : 0;
		this.RefreshSelectGridId(newId);
		PhantomInteractDetailPanelGroup detailPanelGroup = this.DetailPanelGroup;
		if (detailPanelGroup == null)
		{
			return;
		}
		detailPanelGroup.RefreshDetailPanel(editViewModel.ShowDetail, editViewModel.DetailViewModel);
	}

	// Token: 0x06012BD0 RID: 76752 RVA: 0x0049F5A4 File Offset: 0x0049D7A4
	private void RefreshSelectGridId(int newId)
	{
		if (newId == this.CurrentSelectGridId)
		{
			return;
		}
		PhantomInteractEditViewModel editViewModel = PhantomInteractModel.Instance.EditViewModel;
		int gridIndex = editViewModel.FindGridIndexInMultiTemplate(this.CurrentSelectGridId);
		this.RefreshRightScrollViewGrid(gridIndex);
		int gridIndex2 = editViewModel.FindGridIndexInMultiTemplate(newId);
		this.RefreshRightScrollViewGrid(gridIndex2);
		this.CurrentSelectGridId = newId;
	}

	// Token: 0x06012BD1 RID: 76753 RVA: 0x0049F5F0 File Offset: 0x0049D7F0
	private void ApplyBtnState(EPhantomInteractEditBtnState state, bool enableClick)
	{
		bool flag = state == EPhantomInteractEditBtnState.Invisible;
		ButtonItem btnConfirm = this.BtnConfirm;
		if (btnConfirm != null)
		{
			btnConfirm.SetUiActive(!flag);
		}
		this.SetConfirmBtnText(state);
		ButtonItem btnConfirm2 = this.BtnConfirm;
		if (btnConfirm2 == null)
		{
			return;
		}
		btnConfirm2.SetEnableClick(enableClick);
	}

	// Token: 0x06012BD2 RID: 76754 RVA: 0x0049F630 File Offset: 0x0049D830
	private void SetConfirmBtnText(EPhantomInteractEditBtnState state)
	{
		string text;
		switch (state)
		{
		case EPhantomInteractEditBtnState.UnEquip:
			text = "Text_PhantomTakeOff_Text";
			goto IL_34;
		case EPhantomInteractEditBtnState.Equip:
			text = "Text_PhantomPutOn_Text";
			goto IL_34;
		case EPhantomInteractEditBtnState.Swap:
			text = "Text_PhantomReplace_Text";
			goto IL_34;
		}
		text = null;
		IL_34:
		if (text != null)
		{
			ButtonItem btnConfirm = this.BtnConfirm;
			if (btnConfirm == null)
			{
				return;
			}
			btnConfirm.SetLocalTextNew(text, Array.Empty<object>());
		}
	}

	// Token: 0x06012BD3 RID: 76755 RVA: 0x0049F68A File Offset: 0x0049D88A
	private PhantomInteractDropDownItem CreateDropDownItem(UUIItem uiItem, EFilterIsSpecialOption data)
	{
		return new PhantomInteractDropDownItem(uiItem);
	}

	// Token: 0x06012BD4 RID: 76756 RVA: 0x0049F692 File Offset: 0x0049D892
	private PhantomInteractDropDownTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new PhantomInteractDropDownTitleItem(uiItem);
	}

	// Token: 0x06012BD5 RID: 76757 RVA: 0x0049F69C File Offset: 0x0049D89C
	private void RefreshRightScrollData()
	{
		this.RightScrollDataList = new List<IMultiTemplateGridData>();
		this.TitleTemplatePositionList.Clear();
		int num = 0;
		int num2 = 0;
		PhantomInteractEditViewModel editViewModel = PhantomInteractModel.Instance.EditViewModel;
		foreach (IPhantomGridListData phantomGridListData in editViewModel.GridsDataList)
		{
			if (phantomGridListData.TitleType != EGridTitleType.Hide)
			{
				PhantomGridRowTitleTemplateData titleTemplateData = this.GetTitleTemplateData(num2++);
				titleTemplateData.Data = (int)phantomGridListData.TitleType;
				titleTemplateData.ClickRecommendBtnCb = new Action(this.ReplaceRecommendHandler);
				this.TitleTemplatePositionList.Add(this.RightScrollDataList.Count);
				this.RightScrollDataList.Add(titleTemplateData);
			}
			foreach (int key in phantomGridListData.MonsterIds)
			{
				PhantomInteractEditGridViewModel phantomInteractEditGridViewModel = null;
				PhantomInteractEditGridViewModel phantomInteractEditGridViewModel2;
				if (editViewModel.GridViewModelMap.TryGetValue(key, out phantomInteractEditGridViewModel2))
				{
					phantomInteractEditGridViewModel = phantomInteractEditGridViewModel2;
				}
				if (phantomInteractEditGridViewModel != null)
				{
					PhantomGridGridTemplateData gridTemplateData = this.GetGridTemplateData(num++);
					gridTemplateData.Data = phantomInteractEditGridViewModel;
					gridTemplateData.OnClickCb = new Action<IPhantomInteractGridViewModel, int>(this.OnClickGridItem);
					phantomInteractEditGridViewModel.GridIndex = this.RightScrollDataList.Count;
					this.RightScrollDataList.Add(gridTemplateData);
				}
			}
		}
	}

	// Token: 0x06012BD6 RID: 76758 RVA: 0x0049F828 File Offset: 0x0049DA28
	private PhantomGridGridTemplateData GetGridTemplateData(int index)
	{
		for (int i = index - this.GridTemplateDataList.Count; i >= 0; i--)
		{
			PhantomGridGridTemplateData item = new PhantomGridGridTemplateData();
			this.GridTemplateDataList.Add(item);
		}
		return this.GridTemplateDataList[index];
	}

	// Token: 0x06012BD7 RID: 76759 RVA: 0x0049F86C File Offset: 0x0049DA6C
	private PhantomGridRowTitleTemplateData GetTitleTemplateData(int index)
	{
		for (int i = index - this.TitleTemplateDataList.Count; i >= 0; i--)
		{
			PhantomGridRowTitleTemplateData item = new PhantomGridRowTitleTemplateData();
			this.TitleTemplateDataList.Add(item);
		}
		return this.TitleTemplateDataList[index];
	}

	// Token: 0x06012BD8 RID: 76760 RVA: 0x0049F8B0 File Offset: 0x0049DAB0
	private void RefreshRightScrollView(int? focusIndex = null, bool playAnim = false)
	{
		MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.RightScrollDataList);
		int num = focusIndex.GetValueOrDefault();
		foreach (int num2 in this.TitleTemplatePositionList)
		{
			if (num > num2 && num <= num2 + 3)
			{
				num = num2;
				break;
			}
		}
		multiTemplateScrollViewRefreshContext.ScrollToGridIndex = num;
		multiTemplateScrollViewRefreshContext.GridAnimName = "Start";
		multiTemplateScrollViewRefreshContext.PlayGridAnim = playAnim;
		MultiTemplateScrollView multiTemplateScrollView = this.MultiTemplateScrollView;
		if (multiTemplateScrollView != null)
		{
			multiTemplateScrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
		}
		bool uiactive = this.RightScrollDataList.Count <= 0;
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x06012BD9 RID: 76761 RVA: 0x0049F974 File Offset: 0x0049DB74
	private void RefreshRightScrollViewGrid(int gridIndex)
	{
		if (gridIndex < 0 || gridIndex >= this.RightScrollDataList.Count)
		{
			return;
		}
		IMultiTemplateGridData multiTemplateGridData = this.RightScrollDataList[gridIndex];
		MultiTemplateScrollView multiTemplateScrollView = this.MultiTemplateScrollView;
		ISyncGridProxy syncGridProxy = (multiTemplateScrollView != null) ? multiTemplateScrollView.GetProxyByGridIndex(gridIndex) : null;
		PhantomGridGridTemplateData phantomGridGridTemplateData = multiTemplateGridData as PhantomGridGridTemplateData;
		if (phantomGridGridTemplateData != null && syncGridProxy != null)
		{
			syncGridProxy.Refresh(phantomGridGridTemplateData.Data);
		}
	}

	// Token: 0x06012BDA RID: 76762 RVA: 0x0049F9CC File Offset: 0x0049DBCC
	private void OnClickGridItem(IPhantomInteractGridViewModel data, int gridIndex)
	{
		PhantomInteractModel.Instance.EditViewModel.SelectGrid(data.MonsterId);
		this.Refresh();
	}

	// Token: 0x06012BDB RID: 76763 RVA: 0x0049F9E9 File Offset: 0x0049DBE9
	private void OnCharBeHit(HitInformation hitData, HitContext hitContext)
	{
		this.RemoveCharBeHitListener();
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x06012BDC RID: 76764 RVA: 0x0049F9FC File Offset: 0x0049DBFC
	private void RemoveCharBeHitListener()
	{
		if (!EventSystem.Instance.HasWithTarget<HitInformation, HitContext>(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit)))
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit));
	}

	// Token: 0x06012BDD RID: 76765 RVA: 0x0049FA3C File Offset: 0x0049DC3C
	private void SetOtherTeamEntitiesEnable(bool isEnable)
	{
		foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(false))
		{
			Entity entity = entityHandle.Entity;
			if (!(!entity) && !entity.GetComponent<CharacterActorComponent>().IsAutonomousProxy)
			{
				if (isEnable)
				{
					int handle;
					if (this.DisabledEntityHandles.TryGetValue(entity.Id, out handle))
					{
						entity.Enable(handle, "PhantomInteractEditView_Show");
						this.DisabledEntityHandles.Remove(entity.Id);
					}
				}
				else
				{
					int value = entity.Disable("PhantomInteractEditView_Show");
					this.DisabledEntityHandles[entity.Id] = value;
				}
			}
		}
		if (isEnable)
		{
			this.DisabledEntityHandles.Clear();
		}
	}

	// Token: 0x04008D12 RID: 36114
	private ICostToggleInfo[] allCostToggleInfo = new ICostToggleInfo[]
	{
		new CostToggleInfo
		{
			Component = 9,
			CostValue = -1
		},
		new CostToggleInfo
		{
			Component = 10,
			CostValue = 1
		},
		new CostToggleInfo
		{
			Component = 11,
			CostValue = 3
		},
		new CostToggleInfo
		{
			Component = 12,
			CostValue = 4
		}
	};

	// Token: 0x04008D13 RID: 36115
	private EFilterIsSpecialOption[] allFilterOption = new EFilterIsSpecialOption[]
	{
		EFilterIsSpecialOption.All,
		EFilterIsSpecialOption.Special,
		EFilterIsSpecialOption.NonSpecial
	};

	// Token: 0x04008D14 RID: 36116
	private const string CAPTION_ICON_ID = "/Game/Aki/UI/UIResources/Common/Atlas/SkillIcon/SkillIconNor/SP_IconT29.SP_IconT29";

	// Token: 0x04008D15 RID: 36117
	private const string CAPTION_TITLE_ID = "ExploreTools_1007_Name";

	// Token: 0x04008D16 RID: 36118
	private const int CAPTION_HELP_ID = 473;

	// Token: 0x04008D17 RID: 36119
	private const int GRID_FOCUS_CLAMP_TO_TITLE_RANGE = 3;

	// Token: 0x04008D18 RID: 36120
	[Nullable(2)]
	private PopupCaptionItem CaptionPanel;

	// Token: 0x04008D19 RID: 36121
	[Nullable(2)]
	private PhantomInteractListPanel VisionList;

	// Token: 0x04008D1A RID: 36122
	[Nullable(2)]
	private PhantomInteractDetailPanelGroup DetailPanelGroup;

	// Token: 0x04008D1B RID: 36123
	[Nullable(2)]
	private ButtonItem BtnConfirm;

	// Token: 0x04008D1C RID: 36124
	[Nullable(2)]
	private MultiTemplateScrollView MultiTemplateScrollView;

	// Token: 0x04008D1D RID: 36125
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private StaticTabComponent<CostTabItem> CostTabComponent;

	// Token: 0x04008D1E RID: 36126
	private List<IMultiTemplateGridData> RightScrollDataList = new List<IMultiTemplateGridData>();

	// Token: 0x04008D1F RID: 36127
	[Nullable(2)]
	private CommonDropDown<int, EFilterIsSpecialOption> FilterDropDown;

	// Token: 0x04008D20 RID: 36128
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008D21 RID: 36129
	private int CurrentDetailMonsterId;

	// Token: 0x04008D22 RID: 36130
	private readonly List<PhantomGridGridTemplateData> GridTemplateDataList = new List<PhantomGridGridTemplateData>();

	// Token: 0x04008D23 RID: 36131
	private readonly List<PhantomGridRowTitleTemplateData> TitleTemplateDataList = new List<PhantomGridRowTitleTemplateData>();

	// Token: 0x04008D24 RID: 36132
	private readonly List<int> TitleTemplatePositionList = new List<int>();

	// Token: 0x04008D25 RID: 36133
	private int CurrentSelectGridId;

	// Token: 0x04008D26 RID: 36134
	private bool ViewStarted;

	// Token: 0x04008D27 RID: 36135
	private readonly Dictionary<int, int> DisabledEntityHandles = new Dictionary<int, int>();

	// Token: 0x020089EF RID: 35311
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CCB3 RID: 183475
		ItemPanelVisionList,
		// Token: 0x0402CCB4 RID: 183476
		ScrollView,
		// Token: 0x0402CCB5 RID: 183477
		ItemPanelEmpty,
		// Token: 0x0402CCB6 RID: 183478
		ToggleGroupTopTab,
		// Token: 0x0402CCB7 RID: 183479
		ItemSort,
		// Token: 0x0402CCB8 RID: 183480
		ItemBtnConfirm,
		// Token: 0x0402CCB9 RID: 183481
		BtnSkin,
		// Token: 0x0402CCBA RID: 183482
		ItemCaption,
		// Token: 0x0402CCBB RID: 183483
		ItemVisionEditTip,
		// Token: 0x0402CCBC RID: 183484
		TogTabCostAll,
		// Token: 0x0402CCBD RID: 183485
		TogTabCost1,
		// Token: 0x0402CCBE RID: 183486
		TogTabCost3,
		// Token: 0x0402CCBF RID: 183487
		TogTabCost4,
		// Token: 0x0402CCC0 RID: 183488
		ItemTemplateTitle,
		// Token: 0x0402CCC1 RID: 183489
		ItemTemplateGrid,
		// Token: 0x0402CCC2 RID: 183490
		ItemEquipBtnGroup,
		// Token: 0x0402CCC3 RID: 183491
		ItemGridContent
	}
}
