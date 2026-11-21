using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200195C RID: 6492
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractEditView : UiViewBase
{
	// Token: 0x06010074 RID: 65652 RVA: 0x004AC474 File Offset: 0x004AA674
	public PhantomInteractEditView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010075 RID: 65653 RVA: 0x004AC53B File Offset: 0x004AA73B
	private void LocalLog(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
	}

	// Token: 0x06010076 RID: 65654 RVA: 0x004AC540 File Offset: 0x004AA740
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

	// Token: 0x06010077 RID: 65655 RVA: 0x004AC6D8 File Offset: 0x004AA8D8
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomInteractEditView.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomInteractEditView.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010078 RID: 65656 RVA: 0x004AC71B File Offset: 0x004AA91B
	protected override void OnDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
	}

	// Token: 0x06010079 RID: 65657 RVA: 0x004AC735 File Offset: 0x004AA935
	protected override void OnBeforeShow()
	{
		this.SetOtherTeamEntitiesEnable(false);
	}

	// Token: 0x0601007A RID: 65658 RVA: 0x004AC73E File Offset: 0x004AA93E
	protected override void OnAfterHide()
	{
		PhantomInteractDetailPanelGroup detailPanelGroup = this.DetailPanelGroup;
		if (detailPanelGroup != null)
		{
			detailPanelGroup.RefreshDetailPanel(false, null);
		}
		this.SetOtherTeamEntitiesEnable(true);
	}

	// Token: 0x0601007B RID: 65659 RVA: 0x004AC75C File Offset: 0x004AA95C
	private void InitDropDown()
	{
		this.FilterDropDown.SetOnSelectCall(new Action<int, EFilterIsSpecialOption>(this.OnDropDownSelectCall));
		this.FilterDropDown.SetShowType(ECommonDropDownShowType.Up);
		this.FilterDropDown.InitScroll(this.allFilterOption, new Func<EFilterIsSpecialOption, int>(this.GetDropDownTextId), 0, true);
	}

	// Token: 0x0601007C RID: 65660 RVA: 0x004AC7AB File Offset: 0x004AA9AB
	private int GetDropDownTextId(EFilterIsSpecialOption data)
	{
		return (int)data;
	}

	// Token: 0x0601007D RID: 65661 RVA: 0x004AC7B0 File Offset: 0x004AA9B0
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

	// Token: 0x0601007E RID: 65662 RVA: 0x004AC800 File Offset: 0x004AAA00
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
			visionList.Refresh(new List<IPhantomInteractItemData>(phantomInteractEditViewParam.InfoData.EquippedVisionData), true, true);
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

	// Token: 0x0601007F RID: 65663 RVA: 0x004AC94C File Offset: 0x004AAB4C
	protected override void OnAddEventListener()
	{
		if (EventSystem.Instance.HasWithTarget<HitInformation, HitContext>(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit)))
		{
			return;
		}
		EventSystem.Instance.AddWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit));
	}

	// Token: 0x06010080 RID: 65664 RVA: 0x004AC98C File Offset: 0x004AAB8C
	protected override void OnRemoveEventListener()
	{
		this.RemoveCharBeHitListener();
	}

	// Token: 0x06010081 RID: 65665 RVA: 0x004AC994 File Offset: 0x004AAB94
	private CostTabItem TabItemProxyCreate(UUIItem uiItem, int index)
	{
		CostTabItem costTabItem = new CostTabItem(uiItem);
		costTabItem.Init();
		return costTabItem;
	}

	// Token: 0x06010082 RID: 65666 RVA: 0x004AC9A4 File Offset: 0x004AABA4
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

	// Token: 0x06010083 RID: 65667 RVA: 0x004ACA04 File Offset: 0x004AAC04
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

	// Token: 0x06010084 RID: 65668 RVA: 0x004ACA78 File Offset: 0x004AAC78
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

	// Token: 0x06010085 RID: 65669 RVA: 0x004ACAC4 File Offset: 0x004AACC4
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

	// Token: 0x06010086 RID: 65670 RVA: 0x004ACBAC File Offset: 0x004AADAC
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

	// Token: 0x06010087 RID: 65671 RVA: 0x004ACBF4 File Offset: 0x004AADF4
	public void Refresh()
	{
		PhantomInteractInfoData interactInfoData = PhantomInteractModel.Instance.InteractInfoData;
		PhantomInteractEditViewModel editViewModel = PhantomInteractModel.Instance.EditViewModel;
		this.ApplyBtnState(editViewModel.BtnState, editViewModel.BtnAvailable);
		PhantomInteractListPanel visionList = this.VisionList;
		if (visionList != null)
		{
			visionList.Refresh(new List<IPhantomInteractItemData>(interactInfoData.EquippedVisionData), true, true);
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

	// Token: 0x06010088 RID: 65672 RVA: 0x004ACD08 File Offset: 0x004AAF08
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

	// Token: 0x06010089 RID: 65673 RVA: 0x004ACD54 File Offset: 0x004AAF54
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

	// Token: 0x0601008A RID: 65674 RVA: 0x004ACD94 File Offset: 0x004AAF94
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

	// Token: 0x0601008B RID: 65675 RVA: 0x004ACDEE File Offset: 0x004AAFEE
	private PhantomInteractDropDownItem CreateDropDownItem(UUIItem uiItem, EFilterIsSpecialOption data)
	{
		return new PhantomInteractDropDownItem(uiItem);
	}

	// Token: 0x0601008C RID: 65676 RVA: 0x004ACDF6 File Offset: 0x004AAFF6
	private PhantomInteractDropDownTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new PhantomInteractDropDownTitleItem(uiItem);
	}

	// Token: 0x0601008D RID: 65677 RVA: 0x004ACE00 File Offset: 0x004AB000
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

	// Token: 0x0601008E RID: 65678 RVA: 0x004ACF8C File Offset: 0x004AB18C
	private PhantomGridGridTemplateData GetGridTemplateData(int index)
	{
		for (int i = index - this.GridTemplateDataList.Count; i >= 0; i--)
		{
			PhantomGridGridTemplateData item = new PhantomGridGridTemplateData();
			this.GridTemplateDataList.Add(item);
		}
		return this.GridTemplateDataList[index];
	}

	// Token: 0x0601008F RID: 65679 RVA: 0x004ACFD0 File Offset: 0x004AB1D0
	private PhantomGridRowTitleTemplateData GetTitleTemplateData(int index)
	{
		for (int i = index - this.TitleTemplateDataList.Count; i >= 0; i--)
		{
			PhantomGridRowTitleTemplateData item = new PhantomGridRowTitleTemplateData();
			this.TitleTemplateDataList.Add(item);
		}
		return this.TitleTemplateDataList[index];
	}

	// Token: 0x06010090 RID: 65680 RVA: 0x004AD014 File Offset: 0x004AB214
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

	// Token: 0x06010091 RID: 65681 RVA: 0x004AD0D8 File Offset: 0x004AB2D8
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

	// Token: 0x06010092 RID: 65682 RVA: 0x004AD130 File Offset: 0x004AB330
	private void OnClickGridItem(IPhantomInteractGridViewModel data, int gridIndex)
	{
		PhantomInteractModel.Instance.EditViewModel.SelectGrid(data.MonsterId);
		this.Refresh();
	}

	// Token: 0x06010093 RID: 65683 RVA: 0x004AD14D File Offset: 0x004AB34D
	private void OnCharBeHit(HitInformation hitData, HitContext hitContext)
	{
		this.RemoveCharBeHitListener();
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x06010094 RID: 65684 RVA: 0x004AD160 File Offset: 0x004AB360
	private void RemoveCharBeHitListener()
	{
		if (!EventSystem.Instance.HasWithTarget<HitInformation, HitContext>(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit)))
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit));
	}

	// Token: 0x06010095 RID: 65685 RVA: 0x004AD1A0 File Offset: 0x004AB3A0
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

	// Token: 0x04008E59 RID: 36441
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

	// Token: 0x04008E5A RID: 36442
	private EFilterIsSpecialOption[] allFilterOption = new EFilterIsSpecialOption[]
	{
		EFilterIsSpecialOption.All,
		EFilterIsSpecialOption.Special,
		EFilterIsSpecialOption.NonSpecial
	};

	// Token: 0x04008E5B RID: 36443
	private const string CAPTION_ICON_ID = "/Game/Aki/UI/UIResources/Common/Atlas/SkillIcon/SkillIconNor/SP_IconT29.SP_IconT29";

	// Token: 0x04008E5C RID: 36444
	private const string CAPTION_TITLE_ID = "ExploreTools_1007_Name";

	// Token: 0x04008E5D RID: 36445
	private const int CAPTION_HELP_ID = 473;

	// Token: 0x04008E5E RID: 36446
	private const int GRID_FOCUS_CLAMP_TO_TITLE_RANGE = 3;

	// Token: 0x04008E5F RID: 36447
	[Nullable(2)]
	private PopupCaptionItem CaptionPanel;

	// Token: 0x04008E60 RID: 36448
	[Nullable(2)]
	private PhantomInteractListPanel VisionList;

	// Token: 0x04008E61 RID: 36449
	[Nullable(2)]
	private PhantomInteractDetailPanelGroup DetailPanelGroup;

	// Token: 0x04008E62 RID: 36450
	[Nullable(2)]
	private ButtonItem BtnConfirm;

	// Token: 0x04008E63 RID: 36451
	[Nullable(2)]
	private MultiTemplateScrollView MultiTemplateScrollView;

	// Token: 0x04008E64 RID: 36452
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private StaticTabComponent<CostTabItem> CostTabComponent;

	// Token: 0x04008E65 RID: 36453
	private List<IMultiTemplateGridData> RightScrollDataList = new List<IMultiTemplateGridData>();

	// Token: 0x04008E66 RID: 36454
	[Nullable(2)]
	private CommonDropDown<int, EFilterIsSpecialOption> FilterDropDown;

	// Token: 0x04008E67 RID: 36455
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008E68 RID: 36456
	private int CurrentDetailMonsterId;

	// Token: 0x04008E69 RID: 36457
	private readonly List<PhantomGridGridTemplateData> GridTemplateDataList = new List<PhantomGridGridTemplateData>();

	// Token: 0x04008E6A RID: 36458
	private readonly List<PhantomGridRowTitleTemplateData> TitleTemplateDataList = new List<PhantomGridRowTitleTemplateData>();

	// Token: 0x04008E6B RID: 36459
	private readonly List<int> TitleTemplatePositionList = new List<int>();

	// Token: 0x04008E6C RID: 36460
	private int CurrentSelectGridId;

	// Token: 0x04008E6D RID: 36461
	private bool ViewStarted;

	// Token: 0x04008E6E RID: 36462
	private readonly Dictionary<int, int> DisabledEntityHandles = new Dictionary<int, int>();

	// Token: 0x02007B76 RID: 31606
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04027FC9 RID: 163785
		ItemPanelVisionList,
		// Token: 0x04027FCA RID: 163786
		ScrollView,
		// Token: 0x04027FCB RID: 163787
		ItemPanelEmpty,
		// Token: 0x04027FCC RID: 163788
		ToggleGroupTopTab,
		// Token: 0x04027FCD RID: 163789
		ItemSort,
		// Token: 0x04027FCE RID: 163790
		ItemBtnConfirm,
		// Token: 0x04027FCF RID: 163791
		BtnSkin,
		// Token: 0x04027FD0 RID: 163792
		ItemCaption,
		// Token: 0x04027FD1 RID: 163793
		ItemVisionEditTip,
		// Token: 0x04027FD2 RID: 163794
		TogTabCostAll,
		// Token: 0x04027FD3 RID: 163795
		TogTabCost1,
		// Token: 0x04027FD4 RID: 163796
		TogTabCost3,
		// Token: 0x04027FD5 RID: 163797
		TogTabCost4,
		// Token: 0x04027FD6 RID: 163798
		ItemTemplateTitle,
		// Token: 0x04027FD7 RID: 163799
		ItemTemplateGrid,
		// Token: 0x04027FD8 RID: 163800
		ItemEquipBtnGroup,
		// Token: 0x04027FD9 RID: 163801
		ItemGridContent
	}
}
