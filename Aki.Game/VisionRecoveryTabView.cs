using System;
using System.Collections.Generic;
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

// Token: 0x02000C19 RID: 3097
[NullableContext(1)]
[Nullable(0)]
public class VisionRecoveryTabView : UiTabViewBase
{
	// Token: 0x06008118 RID: 33048 RVA: 0x00279420 File Offset: 0x00277620
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

	// Token: 0x06008119 RID: 33049 RVA: 0x002795F4 File Offset: 0x002777F4
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecoveryTabView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecoveryTabView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600811A RID: 33050 RVA: 0x00279638 File Offset: 0x00277838
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

	// Token: 0x0600811B RID: 33051 RVA: 0x00279724 File Offset: 0x00277924
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<OneOf<PhantomBatchDirectRefiningResponse, PhantomRefiningResponse>>(EEventName.OnVisionRecoveryResult, new Action<OneOf<PhantomBatchDirectRefiningResponse, PhantomRefiningResponse>>(this.OnVisionRecoveryResult));
		EventSystem.Instance.Add<OneOf<PhantomBatchDirectRefiningResponse, PhantomBatchRefiningResponse>>(EEventName.OnVisionRecoveryBatchResult, new Action<OneOf<PhantomBatchDirectRefiningResponse, PhantomBatchRefiningResponse>>(this.OnVisionRecoveryBatchResult));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Add(EEventName.SelectDirectionalFusionTarget, new Action(this.SelectDirectionalFusionTarget));
		EventSystem.Instance.Add(EEventName.PhantomDirectRefiningWeeklyReset, new Action(this.PhantomDirectRefiningWeeklyReset));
	}

	// Token: 0x0600811C RID: 33052 RVA: 0x002797BD File Offset: 0x002779BD
	protected override void OnBeforeShow()
	{
		if (this.IsShowRecoveryChoosePanel)
		{
			this.AllVisionItemInfoList = InventoryModel.Instance.GetUnEquipPhantomItemDataList();
			this.RemoveInvalidSelectedVisions();
			this.RefreshRecoveryChoosePanel(this.AllVisionItemInfoList, this.SelectedVisionList);
		}
	}

	// Token: 0x0600811D RID: 33053 RVA: 0x002797F0 File Offset: 0x002779F0
	private void InitRecoveryChoosePanel(EVisionRecoveryMode recoveryMode)
	{
		this.HasInitRecoveryChoosePanel = true;
		this.AllVisionItemInfoList = InventoryModel.Instance.GetUnEquipPhantomItemDataList();
		this.RefreshRecoveryChoosePanel(this.AllVisionItemInfoList, this.SelectedVisionList);
	}

	// Token: 0x0600811E RID: 33054 RVA: 0x0027981C File Offset: 0x00277A1C
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

	// Token: 0x0600811F RID: 33055 RVA: 0x002798D0 File Offset: 0x00277AD0
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
		commonItemSelectViewOpenViewData.ItemDataBaseList = new List<PhantomItemData>(itemDataList);
		commonItemSelectViewOpenViewData.SelectedDataList = selectedDataList;
		commonItemSelectViewOpenViewData.ExpData = null;
		commonItemSelectViewOpenViewData.SelectableComponentData = selectableComponentData;
		commonItemSelectViewOpenViewData.UseWayId = ((this.CurrentShowType == EVisionRecoveryTabViewType.NormalFusion) ? EFilterSortGroupId.VisionRecovery : EFilterSortGroupId.VersionAim);
		commonItemSelectViewOpenViewData.InitSortToggleState = true;
		this.RecoveryChoosePanel.RefreshUi(commonItemSelectViewOpenViewData);
		this.RecoveryChoosePanel.SetAllSelectToggleVisible(true);
	}

	// Token: 0x06008120 RID: 33056 RVA: 0x00279980 File Offset: 0x00277B80
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

	// Token: 0x06008121 RID: 33057 RVA: 0x00279AA8 File Offset: 0x00277CA8
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

	// Token: 0x06008122 RID: 33058 RVA: 0x00279BC4 File Offset: 0x00277DC4
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

	// Token: 0x06008123 RID: 33059 RVA: 0x00279C48 File Offset: 0x00277E48
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
		Action onQuitInternalViewCallback = this.OnQuitInternalViewCallback;
		if (onQuitInternalViewCallback == null)
		{
			return;
		}
		onQuitInternalViewCallback();
	}

	// Token: 0x06008124 RID: 33060 RVA: 0x00279D04 File Offset: 0x00277F04
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnVisionRecoveryResult, new Action<OneOf<PhantomBatchDirectRefiningResponse, PhantomRefiningResponse>>(this.OnVisionRecoveryResult));
		EventSystem.Instance.Remove(EEventName.OnVisionRecoveryBatchResult, new Action<OneOf<PhantomBatchDirectRefiningResponse, PhantomBatchRefiningResponse>>(this.OnVisionRecoveryBatchResult));
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Remove(EEventName.SelectDirectionalFusionTarget, new Action(this.SelectDirectionalFusionTarget));
		EventSystem.Instance.Remove(EEventName.PhantomDirectRefiningWeeklyReset, new Action(this.PhantomDirectRefiningWeeklyReset));
	}

	// Token: 0x06008125 RID: 33061 RVA: 0x00279DA0 File Offset: 0x00277FA0
	private void PlayBatchInAnim()
	{
		this.UiViewSequence.StopPrevSequence(false, false);
		base.GetItem(5).SetUIActive(true);
		this.UiViewSequence.PlaySequence("BatchIn", false, null);
		base.GetHorizontalLayout(11).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06008126 RID: 33062 RVA: 0x00279DFC File Offset: 0x00277FFC
	private void PlayBatchOutAnim()
	{
		this.UiViewSequence.StopPrevSequence(false, false);
		this.UiViewSequence.PlaySequence("BatchOut", false, null);
		bool uiactive = FunctionModel.Instance.IsOpen(10100);
		base.GetHorizontalLayout(11).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06008127 RID: 33063 RVA: 0x00279E5B File Offset: 0x0027805B
	private void OnRecoveryChoosePanelHideAniFinish(string _)
	{
		this.RecoveryChoosePanel.SetActive(false);
		this.RecoveryChoosePanel.UiViewSequence.RemoveSequenceFinishEvent("SwitchB", new Action<string>(this.OnRecoveryChoosePanelHideAniFinish));
	}

	// Token: 0x06008128 RID: 33064 RVA: 0x00279E8C File Offset: 0x0027808C
	private void OnTabSequenceStart(string sequenceName)
	{
		if (sequenceName == "Start".ToString() || sequenceName == "ShowView".ToString() || sequenceName == "Sle".ToString())
		{
			UiLayer.Instance.SetShowMaskLayer(EUiTabViewName.VisionRecoveryTabView, true);
		}
	}

	// Token: 0x06008129 RID: 33065 RVA: 0x00279EE4 File Offset: 0x002780E4
	private void OnTabSequenceFinish(string sequenceName)
	{
		if (sequenceName == "Start".ToString() || sequenceName == "ShowView".ToString() || sequenceName == "Sle".ToString())
		{
			UiLayer.Instance.SetShowMaskLayer(EUiTabViewName.VisionRecoveryTabView, false);
			this.ExecuteViewParams();
		}
	}

	// Token: 0x0600812A RID: 33066 RVA: 0x00279F44 File Offset: 0x00278144
	private void ExecuteViewParams()
	{
		VisionRecoveryTabViewParam visionRecoveryTabViewParam = this.ExtraParams as VisionRecoveryTabViewParam;
		if (visionRecoveryTabViewParam != null)
		{
			this.OnQuitInternalViewCallback = visionRecoveryTabViewParam.OnQuitInternalView;
			EVisionRecoveryMode? recoveryMode = visionRecoveryTabViewParam.RecoveryMode;
			if (recoveryMode != null)
			{
				EVisionRecoveryMode value = recoveryMode.Value;
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
			}
		}
		this.ExtraParams = null;
	}

	// Token: 0x0600812B RID: 33067 RVA: 0x00279FA1 File Offset: 0x002781A1
	[NullableContext(2)]
	private void OnClickSlotCallBack(bool isAddVision, PhantomItemData data)
	{
	}

	// Token: 0x0600812C RID: 33068 RVA: 0x00279FA4 File Offset: 0x002781A4
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

	// Token: 0x0600812D RID: 33069 RVA: 0x0027A154 File Offset: 0x00278354
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

	// Token: 0x0600812E RID: 33070 RVA: 0x0027A1B0 File Offset: 0x002783B0
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

	// Token: 0x0600812F RID: 33071 RVA: 0x0027A26D File Offset: 0x0027846D
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

	// Token: 0x06008130 RID: 33072 RVA: 0x0027A2A7 File Offset: 0x002784A7
	public void RemoveAllVisionItemOutside()
	{
		this.AllVisionItemInfoList = InventoryModel.Instance.GetUnEquipPhantomItemDataList();
		this.RemoveAllVisionItem();
	}

	// Token: 0x06008131 RID: 33073 RVA: 0x0027A2C0 File Offset: 0x002784C0
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

	// Token: 0x06008132 RID: 33074 RVA: 0x0027A358 File Offset: 0x00278558
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

	// Token: 0x06008133 RID: 33075 RVA: 0x0027A554 File Offset: 0x00278754
	private void OnClickedNotShowConfirm(bool isSelectedOn)
	{
		CalabashModel.Instance.HideVisionRecoveryConfirmBox = isSelectedOn;
	}

	// Token: 0x06008134 RID: 33076 RVA: 0x0027A564 File Offset: 0x00278764
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

	// Token: 0x06008135 RID: 33077 RVA: 0x0027A608 File Offset: 0x00278808
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

	// Token: 0x06008136 RID: 33078 RVA: 0x0027A668 File Offset: 0x00278868
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

	// Token: 0x06008137 RID: 33079 RVA: 0x0027A728 File Offset: 0x00278928
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

	// Token: 0x06008138 RID: 33080 RVA: 0x0027A7BD File Offset: 0x002789BD
	private CommonItemSmallItemGrid OnRewardLayoutUpdate()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06008139 RID: 33081 RVA: 0x0027A7C4 File Offset: 0x002789C4
	private VisionRecoveryTabItem OnInitTabItem()
	{
		return new VisionRecoveryTabItem
		{
			OnClickToggleCallBack = new Action<EVisionRecoveryTabViewType, UUIExtendToggle>(this.OnClickTabItemCallBack)
		};
	}

	// Token: 0x0600813A RID: 33082 RVA: 0x0027A7E0 File Offset: 0x002789E0
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

	// Token: 0x0600813B RID: 33083 RVA: 0x0027A8DC File Offset: 0x00278ADC
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

	// Token: 0x0600813C RID: 33084 RVA: 0x0027A9C4 File Offset: 0x00278BC4
	private void OnChangeSelectedFunction(List<ISelectedData> selectedDataList, SelectableExpData _)
	{
		this.SelectedVisionList = selectedDataList;
		this.RefreshRecoveryBatchPanel(this.SelectedVisionList);
	}

	// Token: 0x0600813D RID: 33085 RVA: 0x0027A9DC File Offset: 0x00278BDC
	private void OnRecoveryChoosePanelClose()
	{
		this.SelectedVisionList = new List<ISelectedData>();
		this.RefreshRecoveryChoosePanel(this.AllVisionItemInfoList, this.SelectedVisionList);
		this.RefreshRecoverySlotPanel(this.SelectedVisionList);
		this.RefreshRecoveryBatchPanel(this.SelectedVisionList);
		this.PlayBatchOutAnim();
		this.HideRecoveryChoosePanel();
	}

	// Token: 0x0600813E RID: 33086 RVA: 0x0027AA2A File Offset: 0x00278C2A
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

	// Token: 0x0600813F RID: 33087 RVA: 0x0027AA60 File Offset: 0x00278C60
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
			if (this.CurrentShowType == EVisionRecoveryTabViewType.DirectionalFusion && CalabashModel.Instance.DirectionalFusionTimeMax - CalabashModel.Instance.DirectionalFusionTime <= 0)
			{
				this.OnRecoveryChoosePanelClose();
			}
		});
	}

	// Token: 0x06008140 RID: 33088 RVA: 0x0027AABC File Offset: 0x00278CBC
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

	// Token: 0x06008141 RID: 33089 RVA: 0x0027AB50 File Offset: 0x00278D50
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

	// Token: 0x06008142 RID: 33090 RVA: 0x0027ABC1 File Offset: 0x00278DC1
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

	// Token: 0x06008143 RID: 33091 RVA: 0x0027ABE0 File Offset: 0x00278DE0
	private void PhantomDirectRefiningWeeklyReset()
	{
		UiManager.Instance.CloseView(EUiViewName.CalabashRootView, null);
	}

	// Token: 0x06008144 RID: 33092 RVA: 0x0027ABF2 File Offset: 0x00278DF2
	private void OnVisionChooseSortRefresh(List<PhantomItemData> list)
	{
		if (list != null)
		{
			this.FilterVisionItemInfoList = list;
		}
	}

	// Token: 0x06008145 RID: 33093 RVA: 0x0027ABFE File Offset: 0x00278DFE
	private void OnClickSelectAllToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_UnChecked)
		{
			this.RemoveAllVisionItem();
			return;
		}
		this.BatchQuickAddVisionItem();
	}

	// Token: 0x06008146 RID: 33094 RVA: 0x0027AC10 File Offset: 0x00278E10
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

	// Token: 0x04004F69 RID: 20329
	private List<ISelectedData> SelectedVisionList = new List<ISelectedData>();

	// Token: 0x04004F6A RID: 20330
	private List<PhantomItemData> AllVisionItemInfoList = new List<PhantomItemData>();

	// Token: 0x04004F6B RID: 20331
	private List<PhantomItemData> FilterVisionItemInfoList = new List<PhantomItemData>();

	// Token: 0x04004F6C RID: 20332
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private VisionRecoveryChoosePanel<PhantomItemData> RecoveryChoosePanel;

	// Token: 0x04004F6D RID: 20333
	[Nullable(2)]
	private VisionRecoverySlotPanel RecoverySlotPanel;

	// Token: 0x04004F6E RID: 20334
	[Nullable(2)]
	private VisionRecoveryDirectionalFusionItem DirectionalFusionItem;

	// Token: 0x04004F6F RID: 20335
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<VisionRecoveryTabItem, EVisionRecoveryTabViewType> TabLayout;

	// Token: 0x04004F70 RID: 20336
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x04004F71 RID: 20337
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> BatchRewardLayout;

	// Token: 0x04004F72 RID: 20338
	private bool IsShowRecoveryChoosePanel;

	// Token: 0x04004F73 RID: 20339
	private bool HasInitRecoveryChoosePanel;

	// Token: 0x04004F74 RID: 20340
	private EVisionRecoveryMode VisionRecoveryMode = EVisionRecoveryMode.Batch;

	// Token: 0x04004F75 RID: 20341
	private readonly int SlotMaxNum = 5;

	// Token: 0x04004F76 RID: 20342
	private int BatchMaxNum;

	// Token: 0x04004F77 RID: 20343
	private EVisionRecoveryTabViewType CurrentShowType;

	// Token: 0x04004F78 RID: 20344
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x04004F79 RID: 20345
	[Nullable(2)]
	private Action OnQuitInternalViewCallback;

	// Token: 0x02006ED2 RID: 28370
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040243A4 RID: 148388
		RecoverySlotPanel,
		// Token: 0x040243A5 RID: 148389
		RecoveryChoosePanelRoot,
		// Token: 0x040243A6 RID: 148390
		RecoveryCountText,
		// Token: 0x040243A7 RID: 148391
		RecoveryBtn,
		// Token: 0x040243A8 RID: 148392
		RewardLayout,
		// Token: 0x040243A9 RID: 148393
		NormalRecoveryRoot,
		// Token: 0x040243AA RID: 148394
		BatchRecoveryRoot,
		// Token: 0x040243AB RID: 148395
		BatchRewardLayout,
		// Token: 0x040243AC RID: 148396
		BatchMaterialText,
		// Token: 0x040243AD RID: 148397
		BatchCountText,
		// Token: 0x040243AE RID: 148398
		BatchRecoveryBtn,
		// Token: 0x040243AF RID: 148399
		TabLayout,
		// Token: 0x040243B0 RID: 148400
		TabItem,
		// Token: 0x040243B1 RID: 148401
		DirectionalItem,
		// Token: 0x040243B2 RID: 148402
		RecoveryCountTextItem,
		// Token: 0x040243B3 RID: 148403
		IntoBtnText,
		// Token: 0x040243B4 RID: 148404
		BatchRecoveryBtnText
	}
}
