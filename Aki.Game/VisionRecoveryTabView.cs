using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001760 RID: 5984
[NullableContext(1)]
[Nullable(0)]
public class VisionRecoveryTabView : UiTabViewBase
{
	// Token: 0x0600AD31 RID: 44337 RVA: 0x0026EFAC File Offset: 0x0026D1AC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickRecoveryBtn)),
			new ValueTuple<int, Delegate>(10, new Action(this.OnClickBatchRecoveryBtn))
		};
	}

	// Token: 0x0600AD32 RID: 44338 RVA: 0x0026F180 File Offset: 0x0026D380
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecoveryTabView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecoveryTabView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AD33 RID: 44339 RVA: 0x0026F1C4 File Offset: 0x0026D3C4
	protected override void OnStart()
	{
		CalabashModel.Instance.DirectionalFusionTargetFetterGroup = 0;
		this.RefreshRecoverySlotPanel(this.SelectedVisionList);
		UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
		LevelSequencePlayer levelSequencePlayer = (tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.OnTabSequenceStart));
			levelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnTabSequenceFinish), false);
		}
		bool isOpenAim = FunctionModel.Instance.IsOpen(10100);
		GenericLayout<VisionRecoveryTabItem, EVisionRecoveryTabViewType> tabLayout = this.TabLayout;
		if (tabLayout != null)
		{
			tabLayout.RefreshByData(new List<EVisionRecoveryTabViewType>
			{
				EVisionRecoveryTabViewType.DirectionalFusion,
				EVisionRecoveryTabViewType.NormalFusion
			}, delegate
			{
				if (!isOpenAim)
				{
					GenericLayout<VisionRecoveryTabItem, EVisionRecoveryTabViewType> tabLayout3 = this.TabLayout;
					if (tabLayout3 == null)
					{
						return;
					}
					VisionRecoveryTabItem layoutItemByIndex = tabLayout3.GetLayoutItemByIndex(1);
					if (layoutItemByIndex == null)
					{
						return;
					}
					layoutItemByIndex.SelectToggle();
					return;
				}
				else if (CalabashModel.Instance.DirectionalFusionTimeMax - CalabashModel.Instance.DirectionalFusionTime > 0)
				{
					GenericLayout<VisionRecoveryTabItem, EVisionRecoveryTabViewType> tabLayout4 = this.TabLayout;
					if (tabLayout4 == null)
					{
						return;
					}
					VisionRecoveryTabItem layoutItemByIndex2 = tabLayout4.GetLayoutItemByIndex(0);
					if (layoutItemByIndex2 == null)
					{
						return;
					}
					layoutItemByIndex2.SelectToggle();
					return;
				}
				else
				{
					GenericLayout<VisionRecoveryTabItem, EVisionRecoveryTabViewType> tabLayout5 = this.TabLayout;
					if (tabLayout5 == null)
					{
						return;
					}
					VisionRecoveryTabItem layoutItemByIndex3 = tabLayout5.GetLayoutItemByIndex(1);
					if (layoutItemByIndex3 == null)
					{
						return;
					}
					layoutItemByIndex3.SelectToggle();
					return;
				}
			}, false);
		}
		GenericLayout<VisionRecoveryTabItem, EVisionRecoveryTabViewType> tabLayout2 = this.TabLayout;
		if (tabLayout2 != null)
		{
			UUIItem rootUiItem = tabLayout2.GetRootUiItem();
			if (rootUiItem != null)
			{
				rootUiItem.SetUIActive(isOpenAim);
			}
		}
		PhantomBattleModel.Instance.RecordVisionRecoveryRedDot(false);
		PhantomBattleModel.Instance.RecordVisionRecoveryAimRedDot(false);
	}

	// Token: 0x0600AD34 RID: 44340 RVA: 0x0026F2B0 File Offset: 0x0026D4B0
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<OneOf<PhantomBatchDirectRefiningResponse, PhantomRefiningResponse>>(EEventName.OnVisionRecoveryResult, new Action<OneOf<PhantomBatchDirectRefiningResponse, PhantomRefiningResponse>>(this.OnVisionRecoveryResult));
		EventSystem.Instance.Add<OneOf<PhantomBatchDirectRefiningResponse, PhantomBatchRefiningResponse>>(EEventName.OnVisionRecoveryBatchResult, new Action<OneOf<PhantomBatchDirectRefiningResponse, PhantomBatchRefiningResponse>>(this.OnVisionRecoveryBatchResult));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Add(EEventName.SelectDirectionalFusionTarget, new Action(this.SelectDirectionalFusionTarget));
		EventSystem.Instance.Add(EEventName.PhantomDirectRefiningWeeklyReset, new Action(this.PhantomDirectRefiningWeeklyReset));
	}

	// Token: 0x0600AD35 RID: 44341 RVA: 0x0026F349 File Offset: 0x0026D549
	protected override void OnBeforeShow()
	{
		if (this.IsShowRecoveryChoosePanel)
		{
			this.AllVisionItemInfoList = InventoryModel.Instance.GetUnEquipPhantomItemDataList();
			this.RemoveInvalidSelectedVisions();
			this.RefreshRecoveryChoosePanel(this.AllVisionItemInfoList, this.SelectedVisionList);
		}
	}

	// Token: 0x0600AD36 RID: 44342 RVA: 0x0026F37C File Offset: 0x0026D57C
	private void InitRecoveryChoosePanel(EVisionRecoveryMode recoveryMode)
	{
		this.HasInitRecoveryChoosePanel = true;
		this.AllVisionItemInfoList = InventoryModel.Instance.GetUnEquipPhantomItemDataList();
		this.RefreshRecoveryChoosePanel(this.AllVisionItemInfoList, this.SelectedVisionList);
	}

	// Token: 0x0600AD37 RID: 44343 RVA: 0x0026F3A8 File Offset: 0x0026D5A8
	private void InitPreviewReward()
	{
		int value = ConfigCommonParamById.GetIntConfig("VisionRecoveryPreviewRewardDropId").Value;
		List<TItem> list = new List<TItem>();
		Dictionary<int, int> dropPackagePreview = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreview(value);
		if (dropPackagePreview != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in dropPackagePreview)
			{
				InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(keyValuePair.Key, 0);
				TItem item = new TItem(itemData, keyValuePair.Value);
				list.Add(item);
			}
		}
		this.RewardLayout.RefreshByData(list, null, false);
		this.BatchRewardLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0600AD38 RID: 44344 RVA: 0x0026F45C File Offset: 0x0026D65C
	private void RefreshRecoveryChoosePanel(List<PhantomItemData> itemDataList, List<ISelectedData> selectedDataList)
	{
		CommonItemSelectViewOpenViewData<PhantomItemData> commonItemSelectViewOpenViewData = new CommonItemSelectViewOpenViewData<PhantomItemData>();
		SelectableComponentData selectableComponentData = new SelectableComponentData();
		selectableComponentData.IsSingleSelected = false;
		selectableComponentData.MaxSelectedGridNum = this.BatchMaxNum;
		selectableComponentData.OnlyGold = (this.CurrentShowType == EVisionRecoveryTabViewType.DirectionalFusion);
		selectableComponentData.IsSelectFrameFollowClick = true;
		selectableComponentData.OnChangeSelectedFunction = new Action<List<ISelectedData>, SelectableExpData>(this.OnChangeSelectedFunction);
		commonItemSelectViewOpenViewData.SelectableComponentType = ESelectableComponentType.VisionRecovery;
		commonItemSelectViewOpenViewData.ItemDataBaseList = itemDataList.ToList<PhantomItemData>();
		commonItemSelectViewOpenViewData.SelectedDataList = selectedDataList;
		commonItemSelectViewOpenViewData.ExpData = null;
		commonItemSelectViewOpenViewData.SelectableComponentData = selectableComponentData;
		commonItemSelectViewOpenViewData.UseWayId = ((this.CurrentShowType == EVisionRecoveryTabViewType.NormalFusion) ? EFilterSortGroupId.VisionRecovery : EFilterSortGroupId.VersionAim);
		commonItemSelectViewOpenViewData.InitSortToggleState = true;
		this.RecoveryChoosePanel.RefreshUi(commonItemSelectViewOpenViewData);
		this.RecoveryChoosePanel.SetAllSelectToggleVisible(true);
	}

	// Token: 0x0600AD39 RID: 44345 RVA: 0x0026F50C File Offset: 0x0026D70C
	private void RefreshRecoverySlotPanel(List<ISelectedData> selectedDataList)
	{
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (ISelectedData selectedData in selectedDataList)
		{
			if (list.Count >= this.SlotMaxNum)
			{
				break;
			}
			PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(selectedData.IncId);
			if (phantomItemData != null)
			{
				int unitCount = PhantomStackUtil.GetUnitCount(selectedData);
				int num = 0;
				while (num < unitCount && list.Count < this.SlotMaxNum)
				{
					list.Add(phantomItemData);
					num++;
				}
			}
		}
		this.RecoverySlotPanel.RefreshUi(list);
		base.GetItem(14).SetUIActive(this.CurrentShowType == EVisionRecoveryTabViewType.DirectionalFusion);
		int num2 = CalabashModel.Instance.DirectionalFusionTimeMax - CalabashModel.Instance.DirectionalFusionTime;
		UUIText text = base.GetText(2);
		LguiUtil.Instance.SetLocalTextNew(text, (num2 > 0) ? "DirectionalFusion_Times" : "DirectionalFusion_Times_Red", new <>z__ReadOnlyArray<object>(new object[]
		{
			num2,
			CalabashModel.Instance.DirectionalFusionTimeMax
		}));
	}

	// Token: 0x0600AD3A RID: 44346 RVA: 0x0026F634 File Offset: 0x0026D834
	private void RefreshRecoveryBatchPanel(List<ISelectedData> selectedDataList)
	{
		int selectedUnitCount = PhantomStackUtil.GetSelectedUnitCount(selectedDataList);
		if (this.CurrentShowType == EVisionRecoveryTabViewType.NormalFusion)
		{
			int num = (int)Math.Floor((double)((float)selectedUnitCount / (float)this.SlotMaxNum));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "Text_BatchEchoSelect_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				selectedUnitCount,
				this.BatchMaxNum
			}));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "Text_BatchEchoSelectNum_Text", new <>z__ReadOnlySingleElementList<object>(num));
		}
		if (this.CurrentShowType == EVisionRecoveryTabViewType.DirectionalFusion)
		{
			int num2 = CalabashModel.Instance.DirectionalFusionTimeMax - CalabashModel.Instance.DirectionalFusionTime;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "Text_BatchEchoSelect_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				selectedUnitCount,
				num2 * 5
			}));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "DirectionalFusion_Times", new <>z__ReadOnlyArray<object>(new object[]
			{
				num2,
				CalabashModel.Instance.DirectionalFusionTimeMax
			}));
		}
	}

	// Token: 0x0600AD3B RID: 44347 RVA: 0x0026F750 File Offset: 0x0026D950
	private void ShowRecoveryChoosePanel()
	{
		if (this.IsShowRecoveryChoosePanel)
		{
			return;
		}
		this.IsShowRecoveryChoosePanel = true;
		this.RecoveryChoosePanel.SetActive(true);
		this.UiViewSequence.PlaySequence("SwitchA", false, null);
		this.RecoveryChoosePanel.UiViewSequence.PlaySequence("SwitchA", false, null);
		EventSystem.Instance.Emit<bool>(EEventName.OnRefreshCalabashTabShowState, true);
		EventSystem.Instance.Emit(EEventName.CalabashEnterInternalView);
	}

	// Token: 0x0600AD3C RID: 44348 RVA: 0x0026F7D4 File Offset: 0x0026D9D4
	private void HideRecoveryChoosePanel()
	{
		if (!this.IsShowRecoveryChoosePanel)
		{
			return;
		}
		this.IsShowRecoveryChoosePanel = false;
		this.UiViewSequence.PlaySequence("SwitchB", false, null);
		this.RecoveryChoosePanel.UiViewSequence.PlaySequence("SwitchB", false, null);
		this.RecoveryChoosePanel.UiViewSequence.AddSequenceFinishEvent("SwitchB", new Action<string>(this.OnRecoveryChoosePanelHideAniFinish), false);
		VisionRecoveryDirectionalFusionItem directionalFusionItem = this.DirectionalFusionItem;
		if (directionalFusionItem != null)
		{
			directionalFusionItem.SetUiActive(false);
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnRefreshCalabashTabShowState, false);
		EventSystem.Instance.Emit(EEventName.CalabashQuitInternalView);
	}

	// Token: 0x0600AD3D RID: 44349 RVA: 0x0026F880 File Offset: 0x0026DA80
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnVisionRecoveryResult, new Action<OneOf<PhantomBatchDirectRefiningResponse, PhantomRefiningResponse>>(this.OnVisionRecoveryResult));
		EventSystem.Instance.Remove(EEventName.OnVisionRecoveryBatchResult, new Action<OneOf<PhantomBatchDirectRefiningResponse, PhantomBatchRefiningResponse>>(this.OnVisionRecoveryBatchResult));
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Remove(EEventName.SelectDirectionalFusionTarget, new Action(this.SelectDirectionalFusionTarget));
		EventSystem.Instance.Remove(EEventName.PhantomDirectRefiningWeeklyReset, new Action(this.PhantomDirectRefiningWeeklyReset));
	}

	// Token: 0x0600AD3E RID: 44350 RVA: 0x0026F91C File Offset: 0x0026DB1C
	private void PlayBatchInAnim()
	{
		this.UiViewSequence.StopPrevSequence(false, false);
		base.GetItem(5).SetUIActive(true);
		this.UiViewSequence.PlaySequence("BatchIn", false, null);
		base.GetHorizontalLayout(11).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600AD3F RID: 44351 RVA: 0x0026F978 File Offset: 0x0026DB78
	private void PlayBatchOutAnim()
	{
		this.UiViewSequence.StopPrevSequence(false, false);
		this.UiViewSequence.PlaySequence("BatchOut", false, null);
		bool uiactive = FunctionModel.Instance.IsOpen(10100);
		base.GetHorizontalLayout(11).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x0600AD40 RID: 44352 RVA: 0x0026F9D7 File Offset: 0x0026DBD7
	private void OnRecoveryChoosePanelHideAniFinish(string _)
	{
		this.RecoveryChoosePanel.SetActive(false);
		this.RecoveryChoosePanel.UiViewSequence.RemoveSequenceFinishEvent("SwitchB", new Action<string>(this.OnRecoveryChoosePanelHideAniFinish));
	}

	// Token: 0x0600AD41 RID: 44353 RVA: 0x0026FA08 File Offset: 0x0026DC08
	private void OnTabSequenceStart(string sequenceName)
	{
		if (sequenceName == "Start".ToString() || sequenceName == "ShowView".ToString() || sequenceName == "Sle".ToString())
		{
			UiLayer.Instance.SetShowMaskLayer(EUiTabViewName.VisionRecoveryTabView, true);
		}
	}

	// Token: 0x0600AD42 RID: 44354 RVA: 0x0026FA60 File Offset: 0x0026DC60
	private void OnTabSequenceFinish(string sequenceName)
	{
		if (sequenceName == "Start".ToString() || sequenceName == "ShowView".ToString() || sequenceName == "Sle".ToString())
		{
			UiLayer.Instance.SetShowMaskLayer(EUiTabViewName.VisionRecoveryTabView, false);
			this.ExecuteViewParams();
		}
	}

	// Token: 0x0600AD43 RID: 44355 RVA: 0x0026FAC0 File Offset: 0x0026DCC0
	private void ExecuteViewParams()
	{
		if (this.ExtraParams == null)
		{
			return;
		}
		EVisionRecoveryMode? evisionRecoveryMode = this.ExtraParams as EVisionRecoveryMode?;
		if (evisionRecoveryMode == null)
		{
			return;
		}
		EVisionRecoveryMode value = evisionRecoveryMode.Value;
		if (value != EVisionRecoveryMode.Batch)
		{
			if (value == EVisionRecoveryMode.DirectionalFusion)
			{
				this.OnClickDirectionalFusionModelBtn();
			}
		}
		else
		{
			this.OnClickRecoveryModelBtn();
		}
		this.ExtraParams = null;
	}

	// Token: 0x0600AD44 RID: 44356 RVA: 0x0026FB16 File Offset: 0x0026DD16
	[NullableContext(2)]
	private void OnClickSlotCallBack(bool isAddVision, PhantomItemData data)
	{
	}

	// Token: 0x0600AD45 RID: 44357 RVA: 0x0026FB18 File Offset: 0x0026DD18
	private void BatchQuickAddVisionItem()
	{
		if (!this.HasInitRecoveryChoosePanel)
		{
			this.RefreshFilterVisionItemInfoList();
		}
		int num = PhantomStackUtil.GetSelectedUnitCount(this.SelectedVisionList);
		foreach (PhantomItemData phantomItemData in this.FilterVisionItemInfoList)
		{
			if (num >= this.BatchMaxNum)
			{
				break;
			}
			ISelectedData selectedData = this.FindSelectedVisionData(phantomItemData.GetUniqueId());
			if (selectedData != null)
			{
				int num2 = this.BatchMaxNum - num;
				int num3 = phantomItemData.GetStackCount() - selectedData.SelectedCount;
				int num4 = (num3 < num2) ? num3 : num2;
				if (num4 > 0)
				{
					selectedData.SelectedCount += num4;
					num += num4;
				}
			}
		}
		foreach (PhantomItemData phantomItemData2 in this.FilterVisionItemInfoList)
		{
			if (num >= this.BatchMaxNum)
			{
				break;
			}
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(phantomItemData2.GetUniqueId());
			if (phantomBattleData != null && phantomBattleData.GetVisionIfCanRecovery(this.CurrentShowType == EVisionRecoveryTabViewType.DirectionalFusion) && this.FindSelectedVisionData(phantomBattleData.GetIncrId()) == null)
			{
				SelectablePropData selectablePropData = SelectablePropDataUtil.GetSelectablePropData(phantomItemData2);
				int num5 = this.BatchMaxNum - num;
				int stackCount = phantomItemData2.GetStackCount();
				selectablePropData.SelectedCount = ((stackCount < num5) ? stackCount : num5);
				num += selectablePropData.SelectedCount;
				this.SelectedVisionList.Add(selectablePropData);
			}
		}
		this.RefreshRecoveryBatchPanel(this.SelectedVisionList);
		this.RefreshRecoveryChoosePanel(this.AllVisionItemInfoList, this.SelectedVisionList);
	}

	// Token: 0x0600AD46 RID: 44358 RVA: 0x0026FCC8 File Offset: 0x0026DEC8
	[NullableContext(2)]
	private ISelectedData FindSelectedVisionData(int incId)
	{
		foreach (ISelectedData selectedData in this.SelectedVisionList)
		{
			if (selectedData.IncId == incId)
			{
				return selectedData;
			}
		}
		return null;
	}

	// Token: 0x0600AD47 RID: 44359 RVA: 0x0026FD24 File Offset: 0x0026DF24
	private void RefreshFilterVisionItemInfoList()
	{
		this.FilterVisionItemInfoList = InventoryModel.Instance.GetUnEquipPhantomItemDataList();
		int sortId = SortConfig.Instance.GetSortId(EFilterSortGroupId.VisionRecovery);
		Sort? sortConfig = SortConfig.Instance.GetSortConfig(sortId);
		SortResultData sortResultData = new SortResultData();
		sortResultData.SetConfigId(sortConfig.Value.Id);
		sortResultData.SetIsAscending(true);
		int ruleId = sortConfig.Value.BaseSortList()[0];
		string sortRuleName = SortConfig.Instance.GetSortRuleName(ruleId, (ESortDataType)sortConfig.Value.DataId);
		sortResultData.SetSelectBaseSort(new SortViewBaseSort(ruleId, sortRuleName));
		SortModel.Instance.SortDataList<PhantomItemData>(this.FilterVisionItemInfoList, sortConfig.Value.Id, sortResultData, Array.Empty<object>());
	}

	// Token: 0x0600AD48 RID: 44360 RVA: 0x0026FDE1 File Offset: 0x0026DFE1
	private void RemoveAllVisionItem()
	{
		if (this.SelectedVisionList.Count <= 0)
		{
			return;
		}
		this.SelectedVisionList = new List<ISelectedData>();
		this.RefreshRecoveryBatchPanel(this.SelectedVisionList);
		this.RefreshRecoveryChoosePanel(this.AllVisionItemInfoList, this.SelectedVisionList);
	}

	// Token: 0x0600AD49 RID: 44361 RVA: 0x0026FE1B File Offset: 0x0026E01B
	public void RemoveAllVisionItemOutside()
	{
		this.AllVisionItemInfoList = InventoryModel.Instance.GetUnEquipPhantomItemDataList();
		this.RemoveAllVisionItem();
	}

	// Token: 0x0600AD4A RID: 44362 RVA: 0x0026FE34 File Offset: 0x0026E034
	private void OnClickRecoveryBtn()
	{
		if (!this.IsShowRecoveryChoosePanel)
		{
			EVisionRecoveryTabViewType currentShowType = this.CurrentShowType;
			if (currentShowType == EVisionRecoveryTabViewType.NormalFusion)
			{
				this.OnClickRecoveryModelBtn();
				return;
			}
			if (currentShowType != EVisionRecoveryTabViewType.DirectionalFusion)
			{
				return;
			}
			this.OnClickDirectionalFusionModelBtn();
			return;
		}
		else
		{
			this.RemoveInvalidSelectedVisions();
			if (PhantomStackUtil.GetSelectedUnitCount(this.SelectedVisionList) < this.SlotMaxNum)
			{
				ScrollingTipsController.Instance.ShowTipsById("Text_EchoLack_Text", Array.Empty<object>());
				return;
			}
			EVisionRecoveryTabViewType currentShowType = this.CurrentShowType;
			if (currentShowType == EVisionRecoveryTabViewType.NormalFusion)
			{
				this.VisionRecovery(delegate
				{
					CalabashController.Instance.RequestPhantomRefiningRequest(this.SelectedVisionList.ToArray());
				});
				return;
			}
			if (currentShowType != EVisionRecoveryTabViewType.DirectionalFusion)
			{
				return;
			}
			this.VisionRecovery(delegate
			{
				CalabashController.Instance.PhantomBatchDirectRefiningRequest(this.SelectedVisionList.ToArray());
			});
			return;
		}
	}

	// Token: 0x0600AD4B RID: 44363 RVA: 0x0026FECC File Offset: 0x0026E0CC
	private void VisionRecovery(Action refineRequest)
	{
		Action action = delegate()
		{
			bool flag4 = false;
			foreach (ISelectedData selectedData2 in this.SelectedVisionList)
			{
				if (selectedData2.IncId > 0 && VisionEquipGroupModel.Instance.CheckVisionConsumeBreakGroup(selectedData2.IncId, PhantomStackUtil.GetUnitCount(selectedData2)))
				{
					flag4 = true;
					break;
				}
			}
			if (flag4)
			{
				ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.DestroyVisionInGroup);
				confirmBoxDataNew2.FunctionMap.Add(2, refineRequest);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
				return;
			}
			refineRequest();
		};
		if (CalabashModel.Instance.HideVisionRecoveryConfirmBox)
		{
			action();
			return;
		}
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		foreach (ISelectedData selectedData in this.SelectedVisionList)
		{
			PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(selectedData.IncId);
			if (phantomItemDataByUniqueId != null)
			{
				if (!flag && PhantomBattleModel.Instance.IsVisionHighQuality(phantomItemDataByUniqueId))
				{
					flag = true;
				}
				if (!flag2 && PhantomBattleModel.Instance.IsVisionHighLevel(phantomItemDataByUniqueId))
				{
					flag2 = true;
				}
				if (!flag3 && PhantomBattleModel.Instance.IsVisionHighRare(phantomItemDataByUniqueId))
				{
					flag3 = true;
				}
			}
		}
		EConfirmBoxConfigId? econfirmBoxConfigId = null;
		List<string> list = new List<string>();
		if (flag)
		{
			string textById = TextConfig.Instance.GetTextById("VisionHighQuality");
			if (textById != null)
			{
				list.Add(textById);
			}
		}
		if (flag2)
		{
			string textById2 = TextConfig.Instance.GetTextById("VisionHighLevel");
			if (textById2 != null)
			{
				list.Add(textById2);
			}
		}
		if (flag3)
		{
			string textById3 = TextConfig.Instance.GetTextById("VisionHighRare");
			if (textById3 != null)
			{
				list.Add(textById3);
			}
		}
		switch (list.Count)
		{
		case 1:
			econfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.VisionLevelUpTips1);
			break;
		case 2:
			econfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.VisionLevelUpTips2);
			break;
		case 3:
			econfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.VisionLevelUpTips3);
			break;
		}
		if (econfirmBoxConfigId != null)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(econfirmBoxConfigId.Value);
			confirmBoxDataNew.SetTextArgs(list.ToArray());
			confirmBoxDataNew.FunctionMap.Add(2, action);
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleText = ConfigMultiTextLang.GetLocalTextNew("Text_ItemRecycleConfirmToggle_text", null);
			confirmBoxDataNew.SetToggleFunction(new Action<bool>(this.OnClickedNotShowConfirm));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		action();
	}

	// Token: 0x0600AD4C RID: 44364 RVA: 0x002700C8 File Offset: 0x0026E2C8
	private void OnClickedNotShowConfirm(bool isSelectedOn)
	{
		CalabashModel.Instance.HideVisionRecoveryConfirmBox = isSelectedOn;
	}

	// Token: 0x0600AD4D RID: 44365 RVA: 0x002700D8 File Offset: 0x0026E2D8
	private void OnClickRecoveryModelBtn()
	{
		this.VisionRecoveryMode = EVisionRecoveryMode.Batch;
		this.SelectedVisionList = new List<ISelectedData>();
		if (!this.HasInitRecoveryChoosePanel)
		{
			this.InitRecoveryChoosePanel(this.VisionRecoveryMode);
		}
		else
		{
			this.RefreshRecoveryChoosePanel(this.AllVisionItemInfoList, this.SelectedVisionList);
		}
		this.RefreshRecoverySlotPanel(this.SelectedVisionList);
		this.RefreshRecoveryBatchPanel(this.SelectedVisionList);
		this.PlayBatchInAnim();
		this.ShowRecoveryChoosePanel();
		this.RefreshRewardItemTag();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "VisionRecoveryTabView_Btn_RandomModel", Array.Empty<object>());
		EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "VisionRecoveryBatchStart");
	}

	// Token: 0x0600AD4E RID: 44366 RVA: 0x0027017C File Offset: 0x0026E37C
	private void OnClickDirectionalFusionModelBtn()
	{
		if (CalabashModel.Instance.DirectionalFusionTimeMax - CalabashModel.Instance.DirectionalFusionTime <= 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PhantomRecycle_Tips02", Array.Empty<object>());
			return;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.VisionDirectionalFusionSelectTargetView))
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.VisionDirectionalFusionSelectTargetView, null, null);
	}

	// Token: 0x0600AD4F RID: 44367 RVA: 0x002701DC File Offset: 0x0026E3DC
	private void OnEnterDirectionalFusionModel()
	{
		this.VisionRecoveryMode = EVisionRecoveryMode.DirectionalFusion;
		this.SelectedVisionList = new List<ISelectedData>();
		if (!this.HasInitRecoveryChoosePanel)
		{
			this.InitRecoveryChoosePanel(this.VisionRecoveryMode);
		}
		else
		{
			this.RefreshRecoveryChoosePanel(this.AllVisionItemInfoList, this.SelectedVisionList);
		}
		this.RefreshRecoverySlotPanel(this.SelectedVisionList);
		this.RefreshRecoveryBatchPanel(this.SelectedVisionList);
		this.PlayBatchInAnim();
		this.ShowRecoveryChoosePanel();
		VisionRecoveryDirectionalFusionItem directionalFusionItem = this.DirectionalFusionItem;
		if (directionalFusionItem != null)
		{
			directionalFusionItem.SetUiActive(true);
		}
		VisionRecoveryDirectionalFusionItem directionalFusionItem2 = this.DirectionalFusionItem;
		if (directionalFusionItem2 != null)
		{
			directionalFusionItem2.RefreshItem();
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "VisionRecoveryTabView_Btn_AimModel", Array.Empty<object>());
		EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "VisionRecoveryBatchStart");
	}

	// Token: 0x0600AD50 RID: 44368 RVA: 0x0027029C File Offset: 0x0026E49C
	private void OnClickBatchRecoveryBtn()
	{
		if (!this.IsShowRecoveryChoosePanel)
		{
			EVisionRecoveryTabViewType currentShowType = this.CurrentShowType;
			if (currentShowType == EVisionRecoveryTabViewType.NormalFusion)
			{
				this.OnClickRecoveryModelBtn();
				return;
			}
			if (currentShowType != EVisionRecoveryTabViewType.DirectionalFusion)
			{
				return;
			}
			this.OnClickDirectionalFusionModelBtn();
			return;
		}
		else
		{
			this.RemoveInvalidSelectedVisions();
			if (PhantomStackUtil.GetSelectedUnitCount(this.SelectedVisionList) < this.SlotMaxNum)
			{
				ScrollingTipsController.Instance.ShowTipsById("Text_BatchEchoLack", Array.Empty<object>());
				return;
			}
			EVisionRecoveryTabViewType currentShowType = this.CurrentShowType;
			if (currentShowType == EVisionRecoveryTabViewType.NormalFusion)
			{
				this.VisionRecovery(delegate
				{
					CalabashController.Instance.RequestBatchRefiningRequest(this.SelectedVisionList.ToArray());
				});
				return;
			}
			if (currentShowType != EVisionRecoveryTabViewType.DirectionalFusion)
			{
				return;
			}
			this.VisionRecovery(delegate
			{
				CalabashController.Instance.PhantomBatchDirectRefiningRequest(this.SelectedVisionList.ToArray());
			});
			return;
		}
	}

	// Token: 0x0600AD51 RID: 44369 RVA: 0x00270331 File Offset: 0x0026E531
	private CommonItemSmallItemGrid OnRewardLayoutUpdate()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600AD52 RID: 44370 RVA: 0x00270338 File Offset: 0x0026E538
	private VisionRecoveryTabItem OnInitTabItem()
	{
		return new VisionRecoveryTabItem
		{
			OnClickToggleCallBack = new Action<EVisionRecoveryTabViewType, UUIExtendToggle>(this.OnClickTabItemCallBack)
		};
	}

	// Token: 0x0600AD53 RID: 44371 RVA: 0x00270354 File Offset: 0x0026E554
	private void OnClickTabItemCallBack(EVisionRecoveryTabViewType type, UUIExtendToggle toggle)
	{
		UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
		if (currentSelectToggle != null)
		{
			currentSelectToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.CurrentShowType = type;
		this.SelectedVisionList = new List<ISelectedData>();
		if (type == EVisionRecoveryTabViewType.NormalFusion)
		{
			this.BatchMaxNum = CalabashConfig.Instance.GetVisionBatchRecoveryMaxCount();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "VisionRecoveryTabView_Out_Btn_RandomModel", Array.Empty<object>());
			base.GetItem(14).SetUIActive(false);
		}
		else
		{
			int num = CalabashModel.Instance.DirectionalFusionTimeMax - CalabashModel.Instance.DirectionalFusionTime;
			this.BatchMaxNum = num * this.SlotMaxNum;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "VisionRecoveryTabView_Out_Btn_AimModel", Array.Empty<object>());
			base.GetItem(14).SetUIActive(true);
		}
		this.RefreshRecoverySlotPanel(this.SelectedVisionList);
		this.RefreshRewardItemTag();
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Change", false, null);
	}

	// Token: 0x0600AD54 RID: 44372 RVA: 0x00270450 File Offset: 0x0026E650
	private void RefreshRewardItemTag()
	{
		GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
		foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in (((rewardLayout != null) ? rewardLayout.GetLayoutItemList() : null) ?? new List<CommonItemSmallItemGrid>()))
		{
			commonItemSmallItemGrid.SetDirectionalFusionComponent(new int?((this.CurrentShowType == EVisionRecoveryTabViewType.DirectionalFusion) ? -1 : 0));
		}
		GenericLayout<CommonItemSmallItemGrid, TItem> batchRewardLayout = this.BatchRewardLayout;
		foreach (CommonItemSmallItemGrid commonItemSmallItemGrid2 in (((batchRewardLayout != null) ? batchRewardLayout.GetLayoutItemList() : null) ?? new List<CommonItemSmallItemGrid>()))
		{
			commonItemSmallItemGrid2.SetDirectionalFusionComponent(new int?((this.CurrentShowType == EVisionRecoveryTabViewType.DirectionalFusion) ? CalabashModel.Instance.DirectionalFusionTargetFetterGroup : 0));
		}
	}

	// Token: 0x0600AD55 RID: 44373 RVA: 0x00270538 File Offset: 0x0026E738
	private void OnChangeSelectedFunction(List<ISelectedData> selectedDataList, SelectableExpData _)
	{
		this.SelectedVisionList = selectedDataList;
		this.RefreshRecoveryBatchPanel(this.SelectedVisionList);
	}

	// Token: 0x0600AD56 RID: 44374 RVA: 0x00270550 File Offset: 0x0026E750
	private void OnRecoveryChoosePanelClose()
	{
		this.SelectedVisionList = new List<ISelectedData>();
		this.RefreshRecoveryChoosePanel(this.AllVisionItemInfoList, this.SelectedVisionList);
		this.RefreshRecoverySlotPanel(this.SelectedVisionList);
		this.RefreshRecoveryBatchPanel(this.SelectedVisionList);
		this.PlayBatchOutAnim();
		this.HideRecoveryChoosePanel();
	}

	// Token: 0x0600AD57 RID: 44375 RVA: 0x0027059E File Offset: 0x0026E79E
	private void OnVisionRecoveryResult([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<PhantomBatchDirectRefiningResponse, PhantomRefiningResponse> response)
	{
		EventSystem.Instance.Emit(EEventName.CalabashQuitInternalView);
		UiManager.Instance.OpenView(EUiViewName.VisionRecoveryResultView, response, delegate(bool _2, int _3)
		{
			this.AllVisionItemInfoList = InventoryModel.Instance.GetUnEquipPhantomItemDataList();
			this.RemoveAllVisionItem();
			this.RefreshRecoverySlotPanel(this.SelectedVisionList);
			this.PlayBatchOutAnim();
			this.HideRecoveryChoosePanel();
		});
	}

	// Token: 0x0600AD58 RID: 44376 RVA: 0x002705D4 File Offset: 0x0026E7D4
	private void OnVisionRecoveryBatchResult([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<PhantomBatchDirectRefiningResponse, PhantomBatchRefiningResponse> response)
	{
		if (this.CurrentShowType == EVisionRecoveryTabViewType.DirectionalFusion)
		{
			int num = CalabashModel.Instance.DirectionalFusionTimeMax - CalabashModel.Instance.DirectionalFusionTime;
			this.BatchMaxNum = num * this.SlotMaxNum;
		}
		UiManager.Instance.OpenView(EUiViewName.VisionRecoveryBatchResultView, response, delegate(bool _2, int _3)
		{
			this.AllVisionItemInfoList = InventoryModel.Instance.GetUnEquipPhantomItemDataList();
			this.RemoveAllVisionItem();
			this.RefreshRecoverySlotPanel(this.SelectedVisionList);
		});
	}

	// Token: 0x0600AD59 RID: 44377 RVA: 0x00270630 File Offset: 0x0026E830
	private void OnItemFuncValueChange(int uniqueId)
	{
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(uniqueId);
		if (phantomItemData == null)
		{
			return;
		}
		int num = this.SelectedVisionList.FindIndex((ISelectedData value) => value.IncId == uniqueId);
		if (num >= 0 && phantomItemData.GetIsLock())
		{
			this.SelectedVisionList.RemoveAt(num);
			this.RefreshRecoveryBatchPanel(this.SelectedVisionList);
		}
		int num2 = this.FilterVisionItemInfoList.FindIndex((PhantomItemData visionData) => visionData.GetUniqueId() == uniqueId);
		if (num2 >= 0)
		{
			this.RecoveryChoosePanel.UpdatePartByIndex(num2);
		}
	}

	// Token: 0x0600AD5A RID: 44378 RVA: 0x002706C4 File Offset: 0x0026E8C4
	private int RemoveInvalidSelectedVisions()
	{
		int num = 0;
		for (int i = this.SelectedVisionList.Count - 1; i >= 0; i--)
		{
			int incId = this.SelectedVisionList[i].IncId;
			PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(incId);
			if (phantomItemData == null || phantomItemData.GetIsLock())
			{
				this.SelectedVisionList.RemoveAt(i);
				num++;
			}
		}
		if (num > 0)
		{
			this.RefreshRecoveryBatchPanel(this.SelectedVisionList);
		}
		return num;
	}

	// Token: 0x0600AD5B RID: 44379 RVA: 0x00270735 File Offset: 0x0026E935
	private void SelectDirectionalFusionTarget()
	{
		VisionRecoveryDirectionalFusionItem directionalFusionItem = this.DirectionalFusionItem;
		if (directionalFusionItem != null)
		{
			directionalFusionItem.RefreshItem();
		}
		this.RefreshRewardItemTag();
		this.OnEnterDirectionalFusionModel();
	}

	// Token: 0x0600AD5C RID: 44380 RVA: 0x00270754 File Offset: 0x0026E954
	private void PhantomDirectRefiningWeeklyReset()
	{
		UiManager.Instance.CloseView(EUiViewName.CalabashRootView, null);
	}

	// Token: 0x0600AD5D RID: 44381 RVA: 0x00270766 File Offset: 0x0026E966
	private void OnVisionChooseSortRefresh(List<PhantomItemData> list)
	{
		if (list != null)
		{
			this.FilterVisionItemInfoList = list;
		}
	}

	// Token: 0x0600AD5E RID: 44382 RVA: 0x00270772 File Offset: 0x0026E972
	private void OnClickSelectAllToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_UnChecked)
		{
			this.RemoveAllVisionItem();
			return;
		}
		this.BatchQuickAddVisionItem();
	}

	// Token: 0x0600AD5F RID: 44383 RVA: 0x00270784 File Offset: 0x0026E984
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "Filter"))
		{
			return null;
		}
		UUIItem filterToggleItem = this.RecoveryChoosePanel.GetFilterToggleItem();
		if (filterToggleItem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			filterToggleItem,
			filterToggleItem
		};
	}

	// Token: 0x04004EC0 RID: 20160
	private List<ISelectedData> SelectedVisionList = new List<ISelectedData>();

	// Token: 0x04004EC1 RID: 20161
	private List<PhantomItemData> AllVisionItemInfoList = new List<PhantomItemData>();

	// Token: 0x04004EC2 RID: 20162
	private List<PhantomItemData> FilterVisionItemInfoList = new List<PhantomItemData>();

	// Token: 0x04004EC3 RID: 20163
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private VisionRecoveryChoosePanel<PhantomItemData> RecoveryChoosePanel;

	// Token: 0x04004EC4 RID: 20164
	[Nullable(2)]
	private VisionRecoverySlotPanel RecoverySlotPanel;

	// Token: 0x04004EC5 RID: 20165
	[Nullable(2)]
	private VisionRecoveryDirectionalFusionItem DirectionalFusionItem;

	// Token: 0x04004EC6 RID: 20166
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<VisionRecoveryTabItem, EVisionRecoveryTabViewType> TabLayout;

	// Token: 0x04004EC7 RID: 20167
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x04004EC8 RID: 20168
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> BatchRewardLayout;

	// Token: 0x04004EC9 RID: 20169
	private bool IsShowRecoveryChoosePanel;

	// Token: 0x04004ECA RID: 20170
	private bool HasInitRecoveryChoosePanel;

	// Token: 0x04004ECB RID: 20171
	private EVisionRecoveryMode VisionRecoveryMode = EVisionRecoveryMode.Batch;

	// Token: 0x04004ECC RID: 20172
	private readonly int SlotMaxNum = 5;

	// Token: 0x04004ECD RID: 20173
	private int BatchMaxNum;

	// Token: 0x04004ECE RID: 20174
	private EVisionRecoveryTabViewType CurrentShowType;

	// Token: 0x04004ECF RID: 20175
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x02007D4C RID: 32076
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029079 RID: 168057
		RecoverySlotPanel,
		// Token: 0x0402907A RID: 168058
		RecoveryChoosePanelRoot,
		// Token: 0x0402907B RID: 168059
		RecoveryCountText,
		// Token: 0x0402907C RID: 168060
		RecoveryBtn,
		// Token: 0x0402907D RID: 168061
		RewardLayout,
		// Token: 0x0402907E RID: 168062
		NormalRecoveryRoot,
		// Token: 0x0402907F RID: 168063
		BatchRecoveryRoot,
		// Token: 0x04029080 RID: 168064
		BatchRewardLayout,
		// Token: 0x04029081 RID: 168065
		BatchMaterialText,
		// Token: 0x04029082 RID: 168066
		BatchCountText,
		// Token: 0x04029083 RID: 168067
		BatchRecoveryBtn,
		// Token: 0x04029084 RID: 168068
		TabLayout,
		// Token: 0x04029085 RID: 168069
		TabItem,
		// Token: 0x04029086 RID: 168070
		DirectionalItem,
		// Token: 0x04029087 RID: 168071
		RecoveryCountTextItem,
		// Token: 0x04029088 RID: 168072
		IntoBtnText,
		// Token: 0x04029089 RID: 168073
		BatchRecoveryBtnText
	}
}
