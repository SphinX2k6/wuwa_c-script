using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024CF RID: 9423
[NullableContext(1)]
[Nullable(0)]
public class VisionLevelUpView : UiTabViewBase
{
	// Token: 0x06012F00 RID: 77568 RVA: 0x004AF280 File Offset: 0x004AD480
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnClickLockToggle)),
			new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickDeprecateToggle))
		};
	}

	// Token: 0x06012F01 RID: 77569 RVA: 0x004AF3CC File Offset: 0x004AD5CC
	protected override UniTask OnBeforeStartAsync()
	{
		VisionLevelUpView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionLevelUpView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012F02 RID: 77570 RVA: 0x004AF410 File Offset: 0x004AD610
	protected override void OnStart()
	{
		this.ExpComponent = new ExpComponent(base.GetItem(0), false);
		this.ExpComponent.Init();
		this.ExpComponent.SetLevelFormatText("VisionLevel");
		this.ExpComponent.BindPlayCompleteCallBack(new Action<bool>(this.OnTweenComplete));
		this.ItemGridConsumeComponent.InitFilter(EItemGridConsumeLocalDropDown.VisionLevelUp, new Action<int>(this.ConditionFunction));
		this.ItemGridConsumeComponent.SetConsumeTexture(2);
		this.ItemGridConsumeComponent.SetSettingButtonVisible(true);
		this.ItemGridConsumeComponent.BindSettingButtonRedDot(ERedDotName.VisionLevelUpSetting);
		this.ItemGridConsumeComponent.SetSettingButtonClickCallBack(delegate
		{
			RedDotBase redDot = RedDotModel.Instance.GetRedDot(ERedDotName.VisionLevelUpSetting);
			if (redDot != null && redDot.IsRedDotActive())
			{
				PhantomBattleController.Instance.RecordVisionLevelUpSettingRedDot();
			}
			UiManager.Instance.OpenView(EUiViewName.VisionLevelUpSettingPopView, null, null);
		});
		int maxCount = this.ItemGridConsumeComponent.GetMaxCount();
		this.ConsumeList = new List<TCommonMultipleConsumeData>(maxCount);
		for (int i = 0; i < maxCount; i++)
		{
			this.ConsumeList.Add(new TCommonMultipleConsumeData(new InventoryDefine.GetItemData(0, 0), 0));
		}
		this.VisionNameText = new VisionNameText(base.GetText(4));
	}

	// Token: 0x06012F03 RID: 77571 RVA: 0x004AF51C File Offset: 0x004AD71C
	private void ConditionFunction(int index)
	{
		this.CurrentAutoQualityIndex = index;
		int id = CommonConfig.Instance.GetItemQualityList()[this.CurrentAutoQualityIndex].Id;
		this.ItemGridConsumeComponent.RefreshConditionText(CommonConfig.Instance.GetItemQualityById(id).Value.ConsumeFilterText);
	}

	// Token: 0x06012F04 RID: 77572 RVA: 0x004AF574 File Offset: 0x004AD774
	private void OnTweenComplete(bool isFinish)
	{
		if (!isFinish)
		{
			return;
		}
		UiLayer.Instance.SetShowMaskLayer("PhantomLevelUp", false);
		this.AnimateState = false;
		SelectableExpData currentExpData = this.GetCurrentExpData();
		this.CurrentExpData = currentExpData;
		this.ExpComponent.UpdateInitState(currentExpData);
	}

	// Token: 0x06012F05 RID: 77573 RVA: 0x004AF5B8 File Offset: 0x004AD7B8
	private void ShowLevelSuccessView()
	{
		LevelUpPastVisionData cachePhantomLevelUpData = PhantomBattleModel.Instance.GetCachePhantomLevelUpData();
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		int phantomLevel = phantomItemDataByUniqueId.GetPhantomLevel();
		if (cachePhantomLevelUpData == null)
		{
			return;
		}
		if (cachePhantomLevelUpData.Level == phantomLevel)
		{
			List<Aki.Protocol.PhantomPropInfo> subProp = cachePhantomLevelUpData.SubProp;
			if (((subProp != null) ? subProp.Count : 0) >= phantomItemDataByUniqueId.GetPhantomSubProp().Count)
			{
				return;
			}
		}
		int visionLevelUpDelay = PhantomBattleConfig.Instance.GetVisionLevelUpDelay();
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			SkeletalObserverHandle visionSkeletalHandle = UiSceneManager.Instance.GetVisionSkeletalHandle();
			UiModelBase uiModelBase = (visionSkeletalHandle != null) ? visionSkeletalHandle.Model : null;
			if (uiModelBase != null)
			{
				UiModelUtil.Instance.SetRenderingMaterial(uiModelBase, "VisionStepupController");
			}
			ILevelUpSuccessAttributeData levelUpSuccessData = PhantomBattleModel.Instance.GetLevelUpSuccessData(this.CurrentVisionUniqueId);
			levelUpSuccessData.ClickFunction = delegate()
			{
				UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.VisionLevelUp);
				this.CheckAndCloseItemHintViewNew();
			};
			RoleLevelUpSuccessController.Instance.OpenSuccessAttributeView(levelUpSuccessData, null);
			ItemHintViewNewData itemHintViewNewData = new ItemHintViewNewData();
			itemHintViewNewData.CheckPriorNext = (() => PhantomBattleModel.Instance.GetTempSaveItemList().Length != 0);
			itemHintViewNewData.ShiftPriorItem = delegate()
			{
				TItem? titem = PhantomBattleModel.Instance.ShiftTempSaveItemList();
				if (titem == null)
				{
					return new ItemRewardInfo();
				}
				ItemRewardInfo itemRewardInfo = new ItemRewardInfo();
				itemRewardInfo.ItemId = new int?(titem.Value.ItemData.ItemId);
				itemRewardInfo.ItemCount = new int?(titem.Value.Count);
				CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(titem.Value.ItemData.ItemId);
				itemRewardInfo.Quality = itemConfigData.QualityId;
				return itemRewardInfo;
			};
			itemHintViewNewData.TitleTextId = "Text_ItemReturnTitle_Text";
			UiManager.Instance.OpenView(EUiViewName.ItemHintViewNew, itemHintViewNewData, null);
		}, (float)visionLevelUpDelay, null, null, true, 1f);
	}

	// Token: 0x06012F06 RID: 77574 RVA: 0x004AF644 File Offset: 0x004AD844
	private void CheckAndCloseItemHintViewNew()
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.ItemHintViewNew))
		{
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.ItemHintViewNew, null);
	}

	// Token: 0x06012F07 RID: 77575 RVA: 0x004AF668 File Offset: 0x004AD868
	private void OnPhantomInfoUpdate()
	{
		this.CurrentSelectedMat.Clear();
		this.ClearConsume();
		this.ItemGridConsumeComponent.UpdateComponent(2, 0, this.ConsumeList);
		this.CurrentAddLevel = 0;
		this.PlayExpTween();
		this.RefreshItemGridConsume();
		this.RefreshAttributePreview();
		this.ShowLevelSuccessView();
	}

	// Token: 0x06012F08 RID: 77576 RVA: 0x004AF6B8 File Offset: 0x004AD8B8
	private void PlayExpTween()
	{
		if (this.CurrentExpData.GetCurrentAddExp() > 0f)
		{
			UiLayer.Instance.SetShowMaskLayer("PhantomLevelUp", true);
			this.AnimateState = true;
			this.ExpComponent.PlayExpTween(this.CurrentExpData);
		}
	}

	// Token: 0x06012F09 RID: 77577 RVA: 0x004AF6F4 File Offset: 0x004AD8F4
	private void OnItemFuncValueChange(int uniqueId)
	{
		if (uniqueId != this.CurrentVisionUniqueId)
		{
			return;
		}
		this.RefreshToggleState();
	}

	// Token: 0x06012F0A RID: 77578 RVA: 0x004AF706 File Offset: 0x004AD906
	private void OnVisionLevelUpMaterialPutInModeChange()
	{
		this.RefreshPutInModeState();
	}

	// Token: 0x06012F0B RID: 77579 RVA: 0x004AF70E File Offset: 0x004AD90E
	private void OnVisionLevelUpIdentifyChange()
	{
		this.RefreshItemAndExp();
	}

	// Token: 0x06012F0C RID: 77580 RVA: 0x004AF718 File Offset: 0x004AD918
	private void SetUniqueId(int uniqueId)
	{
		this.CurrentVisionUniqueId = uniqueId;
		SelectableExpData currentExpData = this.GetCurrentExpData();
		this.ExpComponent.UpdateInitState(currentExpData);
		this.OnChangeSelectedFunction(new List<ISelectedData>(), currentExpData);
	}

	// Token: 0x06012F0D RID: 77581 RVA: 0x004AF74C File Offset: 0x004AD94C
	private SelectableExpData GetCurrentExpData()
	{
		CommonIntensifyPropExpData commonIntensifyPropExpData = new CommonIntensifyPropExpData();
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return SelectableExpData.PhraseData(commonIntensifyPropExpData);
		}
		commonIntensifyPropExpData.CurrentExp = phantomItemDataByUniqueId.GetExp();
		commonIntensifyPropExpData.CurrentLevel = phantomItemDataByUniqueId.GetPhantomLevel();
		commonIntensifyPropExpData.CurrentMaxLevel = PhantomBattleController.Instance.GetMaxLevel(this.CurrentVisionUniqueId);
		commonIntensifyPropExpData.MaxExpFunction = new Func<int, int>(this.MaxExpFunction);
		return SelectableExpData.PhraseData(commonIntensifyPropExpData);
	}

	// Token: 0x06012F0E RID: 77582 RVA: 0x004AF7C0 File Offset: 0x004AD9C0
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.PhantomLevelUp, new Action(this.OnPhantomInfoUpdate));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Add(EEventName.OnVisionLevelUpMaterialPutInModeChange, new Action(this.OnVisionLevelUpMaterialPutInModeChange));
		EventSystem.Instance.Add(EEventName.OnVisionLevelUpIdentifyChange, new Action(this.OnVisionLevelUpIdentifyChange));
		this.EventRegistState = true;
		this.CurrentVisionUniqueId = (int)(this.ExtraParams ?? 0);
		this.CurrentAddLevel = 0;
		this.SetUniqueId(this.CurrentVisionUniqueId);
		this.RefreshName();
		this.RefreshToggleState();
		this.RefreshPutInModeState();
	}

	// Token: 0x06012F0F RID: 77583 RVA: 0x004AF884 File Offset: 0x004ADA84
	private void RefreshName()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		this.VisionNameText.Update(phantomItemDataByUniqueId);
	}

	// Token: 0x06012F10 RID: 77584 RVA: 0x004AF8B4 File Offset: 0x004ADAB4
	private void RefreshAttributePreview()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		List<AttrListScrollData> levelUpPreviewData = phantomItemDataByUniqueId.GetLevelUpPreviewData(phantomItemDataByUniqueId.GetPhantomLevel() + this.CurrentAddLevel);
		this.VisionMainAttributeComponent.Update(levelUpPreviewData.ToArray());
		List<VisionSubPropData> levelSubPropPreviewData = phantomItemDataByUniqueId.GetLevelSubPropPreviewData(phantomItemDataByUniqueId.GetPhantomLevel(), phantomItemDataByUniqueId.GetPhantomLevel() + this.CurrentAddLevel);
		VisionSubPropData[] array = new VisionSubPropData[levelSubPropPreviewData.Count];
		for (int i = 0; i < levelSubPropPreviewData.Count; i++)
		{
			array[i] = levelSubPropPreviewData[i];
		}
		this.LevelUpIdentifyComponent.Update(array, false);
		this.LevelUpIdentifyComponent.GetRootItem().SetUIActive(levelSubPropPreviewData.Count > 0);
	}

	// Token: 0x06012F11 RID: 77585 RVA: 0x004AF968 File Offset: 0x004ADB68
	private void RefreshToggleState()
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.CurrentVisionUniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		EToggleState state = attributeItemData.GetIsLock() ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		base.GetExtendToggle(5).SetToggleState(state, false, false, false);
		EToggleState state2 = attributeItemData.GetIsDeprecated() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(6).SetToggleState(state2, false, false, false);
	}

	// Token: 0x06012F12 RID: 77586 RVA: 0x004AF9C8 File Offset: 0x004ADBC8
	private void RefreshPutInModeState()
	{
		string textId = (PhantomBattleModel.Instance.GetVisionLevelUpMaterialPutInMode() == EVisionLevelUpMaterialPutInMode.AllIn) ? "Text_QuickInsertion_Text" : "Text_StageInsertion_Text";
		ItemGridConsumeComponent itemGridConsumeComponent = this.ItemGridConsumeComponent;
		if (itemGridConsumeComponent == null)
		{
			return;
		}
		itemGridConsumeComponent.UpdateAutoSelectTextByTextId(textId);
	}

	// Token: 0x06012F13 RID: 77587 RVA: 0x004AFA00 File Offset: 0x004ADC00
	private bool CheckEnableIdentify(PhantomDataBase data)
	{
		bool flag = PhantomBattleModel.Instance.GetVisionLevelUpIdentify() == EVisionLevelUpIdentify.EnableIdentify;
		bool flag2 = data.GetQuality() > 2;
		return flag && flag2;
	}

	// Token: 0x06012F14 RID: 77588 RVA: 0x004AFA28 File Offset: 0x004ADC28
	private void RemoveEvent()
	{
		if (this.EventRegistState)
		{
			this.EventRegistState = false;
			EventSystem.Instance.Remove(EEventName.PhantomLevelUp, new Action(this.OnPhantomInfoUpdate));
			EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
			EventSystem.Instance.Remove(EEventName.OnVisionLevelUpMaterialPutInModeChange, new Action(this.OnVisionLevelUpMaterialPutInModeChange));
			EventSystem.Instance.Remove(EEventName.OnVisionLevelUpIdentifyChange, new Action(this.OnVisionLevelUpIdentifyChange));
		}
	}

	// Token: 0x06012F15 RID: 77589 RVA: 0x004AFAB4 File Offset: 0x004ADCB4
	protected override void OnBeforeHide()
	{
		this.RemoveEvent();
	}

	// Token: 0x06012F16 RID: 77590 RVA: 0x004AFABC File Offset: 0x004ADCBC
	private bool CheckSelectedMat()
	{
		if (this.CurrentSelectedMat == null || this.CurrentSelectedMat.Count == 0)
		{
			VisionLevelUpView.EStrengthBtnState? btnState = this.BtnState;
			VisionLevelUpView.EStrengthBtnState estrengthBtnState = VisionLevelUpView.EStrengthBtnState.Strength;
			if (btnState.GetValueOrDefault() == estrengthBtnState & btnState != null)
			{
				GenericPromptController.Instance.ShowPromptByCode("VisionNotSelectItem", Array.Empty<object>());
				return false;
			}
		}
		return true;
	}

	// Token: 0x06012F17 RID: 77591 RVA: 0x004AFB12 File Offset: 0x004ADD12
	private bool CheckEnoughMoney()
	{
		if (!this.ItemGridConsumeComponent.GetEnoughMoney())
		{
			ScrollingTipsController.Instance.ShowTipsById("WeaponNoEnoughMoneyText", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x06012F18 RID: 77592 RVA: 0x004AFB38 File Offset: 0x004ADD38
	private void OnClickStrengthBtn(int _)
	{
		this.CheckCanLevelUp().Forget();
	}

	// Token: 0x06012F19 RID: 77593 RVA: 0x004AFB48 File Offset: 0x004ADD48
	private UniTask CheckCanLevelUp()
	{
		VisionLevelUpView.<CheckCanLevelUp>d__44 <CheckCanLevelUp>d__;
		<CheckCanLevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckCanLevelUp>d__.<>4__this = this;
		<CheckCanLevelUp>d__.<>1__state = -1;
		<CheckCanLevelUp>d__.<>t__builder.Start<VisionLevelUpView.<CheckCanLevelUp>d__44>(ref <CheckCanLevelUp>d__);
		return <CheckCanLevelUp>d__.<>t__builder.Task;
	}

	// Token: 0x06012F1A RID: 77594 RVA: 0x004AFB8C File Offset: 0x004ADD8C
	[NullableContext(0)]
	private UniTask<bool> CheckIdentify()
	{
		CustomPromise<bool> customPromise = new CustomPromise<bool>();
		if (this.IdentifyConfirmBoxConfigId == null)
		{
			customPromise.SetResult(true);
			return customPromise.Promise;
		}
		if (this.CurrentSelectedMat.Count == 0 && this.IdentifyConfirmBoxConfigId.Value == EConfirmBoxConfigId.VisionLevelUpIdentifyLessMin)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GenericPrompt_LevelUpMaterialShort_TipsText", Array.Empty<object>());
			customPromise.SetResult(false);
			return customPromise.Promise;
		}
		List<string> list = new List<string>();
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(this.IdentifyConfirmBoxConfigId.Value);
		list.Add(this.TargetIdentifyNum.ToString());
		confirmBoxDataNew.SetTextArgs(list.ToArray());
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			customPromise.SetResult(true);
		});
		confirmBoxDataNew.FunctionMap.Add(1, delegate
		{
			customPromise.SetResult(false);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		return customPromise.Promise;
	}

	// Token: 0x06012F1B RID: 77595 RVA: 0x004AFC98 File Offset: 0x004ADE98
	private void LevelUpClick()
	{
		List<PhantomConsumeItem> data = new List<PhantomConsumeItem>();
		Dictionary<int, int> overItemMap = new Dictionary<int, int>();
		this.ProcessSelectedMat(data, overItemMap);
		this.ProcessAutoIdentity(overItemMap);
		this.ProcessOverExp(overItemMap);
		Action request = delegate()
		{
			if (!this.TryOpenLevelUpTipConfirmBox(data, overItemMap))
			{
				PhantomBattleController.Instance.SendPhantomLevelUpRequest(this.CurrentVisionUniqueId, data, this.TargetIdentifyNum);
			}
		};
		bool flag = false;
		foreach (PhantomConsumeItem phantomConsumeItem in data)
		{
			if (phantomConsumeItem.IncId > 0 && VisionEquipGroupModel.Instance.CheckVisionConsumeBreakGroup(phantomConsumeItem.IncId, PhantomStackUtil.GetUnitCount(phantomConsumeItem.Count)))
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DestroyVisionInGroup);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				request();
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		request();
	}

	// Token: 0x06012F1C RID: 77596 RVA: 0x004AFDB0 File Offset: 0x004ADFB0
	private void ProcessSelectedMat(List<PhantomConsumeItem> data, Dictionary<int, int> overItemMap)
	{
		foreach (ISelectedData selectedData in this.CurrentSelectedMat)
		{
			PhantomConsumeItem phantomConsumeItem = PhantomConsumeItem.Create();
			phantomConsumeItem.Count = selectedData.SelectedCount;
			phantomConsumeItem.IncId = selectedData.IncId;
			phantomConsumeItem.ItemId = selectedData.ItemId;
			data.Add(phantomConsumeItem);
			PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(selectedData.IncId);
			if (phantomItemDataByUniqueId != null)
			{
				Dictionary<int, int> identifyBackItem = phantomItemDataByUniqueId.GetIdentifyBackItem();
				this.AddBackItemToTargetMap(identifyBackItem, overItemMap);
			}
		}
	}

	// Token: 0x06012F1D RID: 77597 RVA: 0x004AFE54 File Offset: 0x004AE054
	private void ProcessAutoIdentity(Dictionary<int, int> overItemMap)
	{
		if (this.TargetIdentifyNum > 0)
		{
			PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
			if (phantomItemDataByUniqueId == null)
			{
				return;
			}
			int currentIdentifyCostId = phantomItemDataByUniqueId.GetCurrentIdentifyCostId();
			int num;
			overItemMap.TryGetValue(currentIdentifyCostId, out num);
			int currentIdentifyCostValue = phantomItemDataByUniqueId.GetCurrentIdentifyCostValue();
			int num2 = this.TargetIdentifyNum * currentIdentifyCostValue;
			if (num > num2)
			{
				overItemMap[currentIdentifyCostId] = num - num2;
				return;
			}
			overItemMap.Remove(currentIdentifyCostId);
		}
	}

	// Token: 0x06012F1E RID: 77598 RVA: 0x004AFEBC File Offset: 0x004AE0BC
	private void ProcessOverExp(Dictionary<int, int> overItemMap)
	{
		int overExp = this.CurrentExpData.GetOverExp();
		if (overExp > 0)
		{
			Dictionary<int, int> source = PhantomBattleModel.Instance.CalculateExpBackItem(overExp);
			this.AddBackItemToTargetMap(source, overItemMap);
		}
	}

	// Token: 0x06012F1F RID: 77599 RVA: 0x004AFEF0 File Offset: 0x004AE0F0
	private bool TryOpenLevelUpTipConfirmBox(List<PhantomConsumeItem> data, Dictionary<int, int> overItemMap)
	{
		if (PhantomBattleModel.Instance.LevelUpConfirmTipsNotShow)
		{
			return false;
		}
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		foreach (ISelectedData selectedData in this.CurrentSelectedMat)
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
		List<string> list = new List<string>();
		if (flag)
		{
			string textById = TextConfig.Instance.GetTextById("VisionHighQuality");
			if (textById != null && textById.Length > 0)
			{
				list.Add(textById);
			}
		}
		if (flag2)
		{
			string textById2 = TextConfig.Instance.GetTextById("VisionHighLevel");
			if (textById2 != null && textById2.Length > 0)
			{
				list.Add(textById2);
			}
		}
		if (flag3)
		{
			string textById3 = TextConfig.Instance.GetTextById("VisionHighRare");
			if (textById3 != null && textById3.Length > 0)
			{
				list.Add(textById3);
			}
		}
		bool flag4 = overItemMap.Count > 0;
		bool flag5 = list.Count > 0;
		ConfirmBoxDataNew confirmBoxDataNew = null;
		if (flag4 && flag5)
		{
			confirmBoxDataNew = this.CreateLevelUpTipsWithAll(list, overItemMap);
		}
		else if (flag4)
		{
			confirmBoxDataNew = this.CreateLevelUpTipsWithOverflow(overItemMap);
		}
		else if (flag5)
		{
			confirmBoxDataNew = this.CreateLevelUpTipsWithCondition(list);
		}
		if (confirmBoxDataNew == null)
		{
			return false;
		}
		confirmBoxDataNew.HasToggle = true;
		confirmBoxDataNew.ToggleText = ConfigMultiTextLang.GetLocalTextNew("Text_PhantomLevelUpTips_Text", null);
		confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
		{
			PhantomBattleModel.Instance.LevelUpConfirmTipsNotShow = isSelectOn;
		});
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			PhantomBattleController.Instance.SendPhantomLevelUpRequest(this.CurrentVisionUniqueId, data, this.TargetIdentifyNum);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		return true;
	}

	// Token: 0x06012F20 RID: 77600 RVA: 0x004B00F8 File Offset: 0x004AE2F8
	private ConfirmBoxDataNew CreateLevelUpTipsWithCondition(List<string> words)
	{
		EConfirmBoxConfigId? econfirmBoxConfigId = null;
		switch (words.Count)
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
		if (econfirmBoxConfigId == null)
		{
			return new ConfirmBoxDataNew(EConfirmBoxConfigId.VisionLevelUpTips1);
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(econfirmBoxConfigId.Value);
		confirmBoxDataNew.SetTextArgs(words.ToArray());
		return confirmBoxDataNew;
	}

	// Token: 0x06012F21 RID: 77601 RVA: 0x004B0172 File Offset: 0x004AE372
	private ConfirmBoxDataNew CreateLevelUpTipsWithOverflow(Dictionary<int, int> overItemMap)
	{
		return new ConfirmBoxDataNew(EConfirmBoxConfigId.WeaponOverflowExpTip)
		{
			ItemIdMap = overItemMap
		};
	}

	// Token: 0x06012F22 RID: 77602 RVA: 0x004B0184 File Offset: 0x004AE384
	private ConfirmBoxDataNew CreateLevelUpTipsWithAll(List<string> words, Dictionary<int, int> overItemMap)
	{
		EConfirmBoxConfigId? econfirmBoxConfigId = null;
		switch (words.Count)
		{
		case 1:
			econfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.VisionLevelUpTipsOverflow1);
			break;
		case 2:
			econfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.VisionLevelUpTipsOverflow2);
			break;
		case 3:
			econfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.VisionLevelUpTipsOverflow3);
			break;
		}
		if (econfirmBoxConfigId == null)
		{
			return new ConfirmBoxDataNew(EConfirmBoxConfigId.VisionLevelUpTipsOverflow1);
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(econfirmBoxConfigId.Value);
		confirmBoxDataNew.SetTextArgs(words.ToArray());
		confirmBoxDataNew.ItemIdMap = overItemMap;
		return confirmBoxDataNew;
	}

	// Token: 0x06012F23 RID: 77603 RVA: 0x004B0214 File Offset: 0x004AE414
	private void AddBackItemToTargetMap(Dictionary<int, int> source, Dictionary<int, int> target)
	{
		foreach (KeyValuePair<int, int> keyValuePair in source)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			int num;
			target.TryGetValue(key, out num);
			num += value;
			target[key] = num;
		}
	}

	// Token: 0x06012F24 RID: 77604 RVA: 0x004B0284 File Offset: 0x004AE484
	private void OnClickDeleteSelectFunction()
	{
		this.CurrentSelectedMat.Clear();
		this.RefreshItemAndExp();
	}

	// Token: 0x06012F25 RID: 77605 RVA: 0x004B0298 File Offset: 0x004AE498
	private void OnClickAutoFunction(int _)
	{
		int id = CommonConfig.Instance.GetItemQualityList()[this.CurrentAutoQualityIndex].Id;
		PhantomBattleModel instance = PhantomBattleModel.Instance;
		EVisionLevelUpMaterialUseType visionLevelUpMaterialUseType = instance.GetVisionLevelUpMaterialUseType();
		ItemDataBase[] sortedExpMaterialList = instance.GetSortedExpMaterialList(this.CurrentVisionUniqueId, id, visionLevelUpMaterialUseType == EVisionLevelUpMaterialUseType.OnlyLevelUpMaterial);
		if (sortedExpMaterialList.Length == 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("RoleNoMaterial", Array.Empty<object>());
			return;
		}
		List<ISelectedData> list = new List<ISelectedData>();
		foreach (ItemDataBase itemDataBase in sortedExpMaterialList)
		{
			SelectedData item = new SelectedData
			{
				IncId = itemDataBase.GetUniqueId(),
				ItemId = itemDataBase.GetConfigId(),
				Count = itemDataBase.GetCount(),
				SelectedCount = 0
			};
			list.Add(item);
		}
		bool flag = instance.GetVisionLevelUpMaterialPutInMode() == EVisionLevelUpMaterialPutInMode.StepIn;
		int needExp = 0;
		if (flag)
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("VisionLevelStageList");
			if (intArrayConfig == null || intArrayConfig.Count == 0)
			{
				return;
			}
			int currentLevel = this.CurrentExpData.GetCurrentLevel();
			int currentMaxLevel = this.CurrentExpData.GetCurrentMaxLevel();
			using (IEnumerator<int> enumerator = intArrayConfig.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int num = enumerator.Current;
					if (num > currentMaxLevel)
					{
						break;
					}
					if (num > currentLevel)
					{
						needExp = this.CurrentExpData.GetExpDistanceToLevel(num);
						break;
					}
				}
				goto IL_156;
			}
		}
		needExp = this.CurrentExpData.GetExpDistanceToMax();
		IL_156:
		WeaponModel instance2 = WeaponModel.Instance;
		int maxCount = this.ItemGridConsumeComponent.GetMaxCount();
		if (flag && !instance2.CheckSatisfyExp(needExp, maxCount, list.ToArray(), new Func<ISelectedData, int>(this.GetItemExpFunction)))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_EchoMaterialLack_Text", Array.Empty<object>());
		}
		List<ISelectedData> currentSelectedMat = instance2.AutoAddExpItem(needExp, maxCount, list.ToArray(), new Func<ISelectedData, int>(this.GetItemExpFunction));
		this.CurrentSelectedMat = currentSelectedMat;
		this.RefreshItemAndExp();
	}

	// Token: 0x06012F26 RID: 77606 RVA: 0x004B0488 File Offset: 0x004AE688
	private void RefreshItemAndExp()
	{
		int num = 0;
		this.ClearConsume();
		if (this.CurrentSelectedMat != null)
		{
			for (int i = 0; i < this.CurrentSelectedMat.Count; i++)
			{
				ISelectedData selectedData = this.CurrentSelectedMat[i];
				TCommonMultipleConsumeData value = this.ConsumeList[i];
				value.ItemData = new InventoryDefine.GetItemData(selectedData.ItemId, selectedData.IncId);
				value.Count = selectedData.SelectedCount;
				this.ConsumeList[i] = value;
				num += this.GetItemExpFunction(selectedData) * selectedData.SelectedCount;
			}
		}
		this.CurrentExpData.UpdateExp(num);
		this.ExpComponent.Update(this.CurrentExpData, true);
		this.CurrentAddLevel = this.CurrentExpData.GetArrivedLevel() - this.CurrentExpData.GetCurrentLevel();
		int expDistanceToMax = this.CurrentExpData.GetExpDistanceToMax();
		int levelUpNeedCost = PhantomBattleController.Instance.GetLevelUpNeedCost(Math.Min(num, expDistanceToMax));
		this.ItemGridConsumeComponent.UpdateComponent(2, levelUpNeedCost, this.ConsumeList);
		this.RefreshItemGridConsume();
		this.RefreshAttributePreview();
	}

	// Token: 0x06012F27 RID: 77607 RVA: 0x004B059C File Offset: 0x004AE79C
	private void ClearConsume()
	{
		for (int i = 0; i < this.ConsumeList.Count; i++)
		{
			TCommonMultipleConsumeData value = new TCommonMultipleConsumeData(new InventoryDefine.GetItemData(0, 0), 0);
			this.ConsumeList[i] = value;
		}
	}

	// Token: 0x06012F28 RID: 77608 RVA: 0x004B05DC File Offset: 0x004AE7DC
	private void OnClickItemReduce(int? incId, int? itemId)
	{
		for (int i = this.CurrentSelectedMat.Count - 1; i >= 0; i--)
		{
			int itemId2 = this.CurrentSelectedMat[i].ItemId;
			int? num = itemId;
			if (itemId2 == num.GetValueOrDefault() & num != null)
			{
				int incId2 = this.CurrentSelectedMat[i].IncId;
				num = incId;
				if (incId2 == num.GetValueOrDefault() & num != null)
				{
					ISelectedData selectedData = this.CurrentSelectedMat[i];
					int selectedCount = selectedData.SelectedCount;
					selectedData.SelectedCount = selectedCount - 1;
					if (this.CurrentSelectedMat[i].SelectedCount == 0)
					{
						this.CurrentSelectedMat.RemoveAt(i);
					}
				}
			}
		}
		this.RefreshItemAndExp();
	}

	// Token: 0x06012F29 RID: 77609 RVA: 0x004B0693 File Offset: 0x004AE893
	private void ItemClickFunction()
	{
		this.MaterialItemFunction(new int?(0), new int?(0));
	}

	// Token: 0x06012F2A RID: 77610 RVA: 0x004B06A8 File Offset: 0x004AE8A8
	private void MaterialItemFunction(int? incId, int? itemId)
	{
		CommonItemSelectViewOpenViewData<ItemDataBase> commonItemSelectViewOpenViewData = new CommonItemSelectViewOpenViewData<ItemDataBase>();
		ItemDataBase[] expMaterialList = PhantomBattleModel.Instance.GetExpMaterialList(this.CurrentVisionUniqueId, 0, false, false);
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		CommonIntensifyPropExpData commonIntensifyPropExpData = new CommonIntensifyPropExpData();
		commonIntensifyPropExpData.CurrentExp = phantomItemDataByUniqueId.GetExp();
		commonIntensifyPropExpData.CurrentLevel = phantomItemDataByUniqueId.GetPhantomLevel();
		commonIntensifyPropExpData.CurrentMaxLevel = PhantomBattleController.Instance.GetMaxLevel(this.CurrentVisionUniqueId);
		commonIntensifyPropExpData.MaxExpFunction = new Func<int, int>(this.MaxExpFunction);
		commonIntensifyPropExpData.GetItemExpFunction = new Func<ISelectedData, int>(this.GetItemExpFunction);
		List<ISelectedData> currentSelectedMat = this.CurrentSelectedMat;
		commonItemSelectViewOpenViewData.ItemDataBaseList = expMaterialList.ToList<ItemDataBase>();
		commonItemSelectViewOpenViewData.SelectedDataList = (currentSelectedMat ?? new List<ISelectedData>());
		commonItemSelectViewOpenViewData.UseWayId = EFilterSortGroupId.VisionLevelUp;
		commonItemSelectViewOpenViewData.ExpData = commonIntensifyPropExpData;
		SelectableComponentData selectableComponentData = new SelectableComponentData();
		selectableComponentData.IsSingleSelected = false;
		selectableComponentData.MaxSelectedGridNum = this.ItemGridConsumeComponent.GetMaxCount();
		commonItemSelectViewOpenViewData.SelectableComponentData = selectableComponentData;
		selectableComponentData.OnChangeSelectedFunction = new Action<List<ISelectedData>, SelectableExpData>(this.OnChangeSelectedFunction);
		UiManager.Instance.OpenView(EUiViewName.CommonItemSelectViewRight, commonItemSelectViewOpenViewData, null);
	}

	// Token: 0x06012F2B RID: 77611 RVA: 0x004B07C0 File Offset: 0x004AE9C0
	private int MaxExpFunction(int level)
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return 0;
		}
		PhantomBattleInstance phantomInstanceByItemId = PhantomBattleModel.Instance.GetPhantomInstanceByItemId(phantomItemDataByUniqueId.GetConfigId(false));
		if (phantomInstanceByItemId.PhantomItem == null)
		{
			return 0;
		}
		return PhantomBattleConfig.Instance.GetPhantomLevelExpByGroupIdAndLevel(phantomInstanceByItemId.PhantomItem.Value.LevelUpGroupId, level + 1);
	}

	// Token: 0x06012F2C RID: 77612 RVA: 0x004B082A File Offset: 0x004AEA2A
	private void OnChangeSelectedFunction(List<ISelectedData> currentSelectedData, SelectableExpData expData)
	{
		this.CurrentSelectedMat = currentSelectedData;
		this.CurrentExpData = expData;
		this.RefreshItemAndExp();
	}

	// Token: 0x06012F2D RID: 77613 RVA: 0x004B0840 File Offset: 0x004AEA40
	private int GetItemExpFunction(ISelectedData selectedData)
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(selectedData.IncId);
		if (phantomItemDataByUniqueId != null)
		{
			return phantomItemDataByUniqueId.GetEatFullExp();
		}
		return PhantomBattleConfig.Instance.GetPhantomExpItemById(selectedData.ItemId).Exp;
	}

	// Token: 0x06012F2E RID: 77614 RVA: 0x004B0880 File Offset: 0x004AEA80
	protected override void OnBeforeDestroy()
	{
		this.RemoveEvent();
		this.VisionMainAttributeComponent.Destroy(null);
		this.LevelUpIdentifyComponent.Destroy(null);
		this.CheckAndCloseItemHintViewNew();
		if (this.AnimateState)
		{
			UiLayer.Instance.SetShowMaskLayer("PhantomLevelUp", false);
		}
	}

	// Token: 0x06012F2F RID: 77615 RVA: 0x004B08C0 File Offset: 0x004AEAC0
	protected void OnClickLockToggle(EToggleState toggleState)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.CurrentVisionUniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		InventoryController.Instance.ItemLockRequest(this.CurrentVisionUniqueId, !attributeItemData.GetIsLock());
	}

	// Token: 0x06012F30 RID: 77616 RVA: 0x004B08FC File Offset: 0x004AEAFC
	protected void OnClickDeprecateToggle(EToggleState toggleState)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.CurrentVisionUniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		InventoryController.Instance.ItemDeprecateRequest(this.CurrentVisionUniqueId, !attributeItemData.GetIsDeprecated());
	}

	// Token: 0x06012F31 RID: 77617 RVA: 0x004B0938 File Offset: 0x004AEB38
	private void RefreshItemGridConsume()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		bool enableIdentify = this.CheckEnableIdentify(phantomItemDataByUniqueId);
		this.RefreshStrengthBtnTxt(phantomItemDataByUniqueId, enableIdentify);
		this.RefreshIdentifyConsume(phantomItemDataByUniqueId, enableIdentify);
	}

	// Token: 0x06012F32 RID: 77618 RVA: 0x004B0974 File Offset: 0x004AEB74
	private void OnClickedRewardItem(MediumItemGridExtendCallback callbackParameter)
	{
		MediumItemGrid itemGridVariantSelect = this.ItemGridVariantSelect;
		if (itemGridVariantSelect != null)
		{
			itemGridVariantSelect.SetSelected(false, true);
		}
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		int currentIdentifyCostId = phantomItemDataByUniqueId.GetCurrentIdentifyCostId();
		List<ItemDataBase> itemDataBaseByConfigId = InventoryModel.Instance.GetItemDataBaseByConfigId(currentIdentifyCostId);
		int num = 0;
		if (itemDataBaseByConfigId.Count > 0)
		{
			num = itemDataBaseByConfigId[0].GetUniqueId();
		}
		if (num > 0)
		{
			ItemController.Instance.OpenItemTipsByItemUid(num, currentIdentifyCostId, true, null);
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(currentIdentifyCostId, true, null);
	}

	// Token: 0x06012F33 RID: 77619 RVA: 0x004B09F4 File Offset: 0x004AEBF4
	private void RefreshIdentifyConsume(PhantomDataBase itemData, bool enableIdentify)
	{
		this.TargetIdentifyNum = 0;
		this.IdentifyConfirmBoxConfigId = null;
		if (!enableIdentify)
		{
			return;
		}
		foreach (VisionSubPropData visionSubPropData in itemData.GetLevelSubPropPreviewData(itemData.GetPhantomLevel(), itemData.GetPhantomLevel() + this.CurrentAddLevel))
		{
			if (visionSubPropData.SlotState == EVisionSlotState.PreviewUnLock || visionSubPropData.SlotState == EVisionSlotState.UnlockAndNoProp)
			{
				this.TargetIdentifyNum++;
			}
		}
		if (this.ItemGridVariantSelect == null)
		{
			this.ItemGridVariantSelect = new MediumItemGrid();
			this.ItemGridVariantSelect.Initialize(base.GetItem(10).GetOwner());
			this.ItemGridVariantSelect.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
		}
		int currentIdentifyCostId = itemData.GetCurrentIdentifyCostId();
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(currentIdentifyCostId);
		if (itemConfig == null)
		{
			return;
		}
		PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
		{
			ItemConfigId = new int?(currentIdentifyCostId),
			StarLevel = new int?(itemConfig.Value.QualityId)
		};
		int currentIdentifyCostValue = itemData.GetCurrentIdentifyCostValue();
		List<ItemDataBase> itemDataBaseByConfigId = InventoryModel.Instance.GetItemDataBaseByConfigId(currentIdentifyCostId);
		int num = 0;
		if (itemDataBaseByConfigId.Count > 0)
		{
			num = itemDataBaseByConfigId[0].GetCount();
		}
		int num2 = 0;
		if (this.TargetIdentifyNum > 0)
		{
			num2 = currentIdentifyCostValue * this.TargetIdentifyNum;
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (ISelectedData selectedData in this.CurrentSelectedMat)
			{
				PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(selectedData.IncId);
				if (phantomItemDataByUniqueId != null)
				{
					Dictionary<int, int> identifyBackItem = phantomItemDataByUniqueId.GetIdentifyBackItem();
					this.AddBackItemToTargetMap(identifyBackItem, dictionary);
				}
			}
			int currentIdentifyCostId2 = itemData.GetCurrentIdentifyCostId();
			int num3;
			dictionary.TryGetValue(currentIdentifyCostId2, out num3);
			int num4 = num;
			if (num3 > 0)
			{
				num2 = Math.Max(0, num2 - num3);
				num4 += num3;
			}
			if (num4 < currentIdentifyCostValue)
			{
				this.IdentifyConfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.VisionLevelUpIdentifyLessMin);
			}
			else if (num4 < this.TargetIdentifyNum * currentIdentifyCostValue)
			{
				this.IdentifyConfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.VisionLevelUpIdentifyLessTarget);
			}
			for (int i = this.TargetIdentifyNum; i >= 0; i--)
			{
				if (num4 >= i * currentIdentifyCostValue)
				{
					this.TargetIdentifyNum = i;
					break;
				}
			}
		}
		string id;
		if (num >= num2)
		{
			id = "Text_CollectProgress_Text";
		}
		else
		{
			id = "Text_ItemCostNotEnough_Text";
		}
		propMediumItemGrid.BottomText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(id, null), new string[]
		{
			num.ToString(),
			num2.ToString()
		});
		MediumItemGrid itemGridVariantSelect = this.ItemGridVariantSelect;
		if (itemGridVariantSelect != null)
		{
			itemGridVariantSelect.Apply<PropMediumItemGrid>(propMediumItemGrid);
		}
		int num5 = this.GetIdentifyCostItemValue() * this.TargetIdentifyNum;
		int currentCostCount = this.ItemGridConsumeComponent.GetCurrentCostCount();
		this.ItemGridConsumeComponent.UpdateComponent(2, num5 + currentCostCount, this.ConsumeList);
	}

	// Token: 0x06012F34 RID: 77620 RVA: 0x004B0CE8 File Offset: 0x004AEEE8
	private int GetIdentifyCostItemValue()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return 0;
		}
		return phantomItemDataByUniqueId.GetIdentifyCostItemValue();
	}

	// Token: 0x06012F35 RID: 77621 RVA: 0x004B0D11 File Offset: 0x004AEF11
	private void RefreshStrengthBtnTxt(PhantomDataBase itemData, bool enableIdentify)
	{
		this.BtnState = new VisionLevelUpView.EStrengthBtnState?(this.CalculateBtnState(itemData, enableIdentify));
		this.OnBtnState();
	}

	// Token: 0x06012F36 RID: 77622 RVA: 0x004B0D2C File Offset: 0x004AEF2C
	private VisionLevelUpView.EStrengthBtnState CalculateBtnState(PhantomDataBase itemData, bool enableIdentify)
	{
		int phantomLevel = itemData.GetPhantomLevel();
		int maxLevel = PhantomBattleController.Instance.GetMaxLevel(this.CurrentVisionUniqueId);
		bool flag = phantomLevel == maxLevel;
		bool flag2 = false;
		List<VisionSubPropData> levelSubPropData = itemData.GetLevelSubPropData(phantomLevel);
		using (List<VisionSubPropData>.Enumerator enumerator = levelSubPropData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SlotState == EVisionSlotState.UnlockAndNoProp)
				{
					flag2 = true;
					break;
				}
			}
		}
		bool flag3 = true;
		using (List<VisionSubPropData>.Enumerator enumerator = levelSubPropData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SlotState != EVisionSlotState.UnlockAndHaveProp)
				{
					flag3 = false;
					break;
				}
			}
		}
		bool flag4 = false;
		using (List<VisionSubPropData>.Enumerator enumerator = itemData.GetLevelSubPropPreviewData(phantomLevel, phantomLevel + this.CurrentAddLevel).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SlotState == EVisionSlotState.PreviewUnLock)
				{
					flag4 = true;
					break;
				}
			}
		}
		bool flag5 = this.CurrentSelectedMat.Count > 0;
		List<ValueTuple<bool, VisionLevelUpView.EStrengthBtnState>> list = new List<ValueTuple<bool, VisionLevelUpView.EStrengthBtnState>>();
		list.Add(new ValueTuple<bool, VisionLevelUpView.EStrengthBtnState>(enableIdentify && flag2 && !flag5, VisionLevelUpView.EStrengthBtnState.Identify));
		list.Add(new ValueTuple<bool, VisionLevelUpView.EStrengthBtnState>(enableIdentify && flag2 && flag5, VisionLevelUpView.EStrengthBtnState.StrengthAndIdentify));
		list.Add(new ValueTuple<bool, VisionLevelUpView.EStrengthBtnState>(enableIdentify && !flag2 && flag4, VisionLevelUpView.EStrengthBtnState.StrengthAndIdentify));
		list.Add(new ValueTuple<bool, VisionLevelUpView.EStrengthBtnState>(enableIdentify && flag && flag2, VisionLevelUpView.EStrengthBtnState.MaxLevelOnlyIdentify));
		list.Add(new ValueTuple<bool, VisionLevelUpView.EStrengthBtnState>(enableIdentify && flag && flag3, VisionLevelUpView.EStrengthBtnState.MaxLevelAndIdentify));
		list.Add(new ValueTuple<bool, VisionLevelUpView.EStrengthBtnState>(!enableIdentify && flag, VisionLevelUpView.EStrengthBtnState.MaxLevelNoIdentify));
		VisionLevelUpView.EStrengthBtnState result = VisionLevelUpView.EStrengthBtnState.Strength;
		foreach (ValueTuple<bool, VisionLevelUpView.EStrengthBtnState> valueTuple in list)
		{
			if (valueTuple.Item1)
			{
				result = valueTuple.Item2;
			}
		}
		return result;
	}

	// Token: 0x06012F37 RID: 77623 RVA: 0x004B0F20 File Offset: 0x004AF120
	private void SetMaxState(bool isMaxLevel, bool isMaxIdentify, string text)
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		bool costRootItemState;
		bool strengthItemEnable;
		bool maxItemEnable;
		bool consumeListEnable;
		bool uiactive;
		bool flag;
		bool uiactive2;
		bool uiactive3;
		if (this.CheckEnableIdentify(phantomItemDataByUniqueId))
		{
			costRootItemState = !isMaxIdentify;
			strengthItemEnable = !isMaxIdentify;
			maxItemEnable = (isMaxLevel && isMaxIdentify);
			consumeListEnable = !isMaxLevel;
			uiactive = isMaxLevel;
			flag = (isMaxLevel && isMaxIdentify);
			uiactive2 = !isMaxIdentify;
			uiactive3 = !isMaxIdentify;
		}
		else
		{
			costRootItemState = !isMaxLevel;
			strengthItemEnable = !isMaxLevel;
			maxItemEnable = isMaxLevel;
			consumeListEnable = !isMaxLevel;
			uiactive = isMaxLevel;
			flag = isMaxLevel;
			uiactive2 = false;
			uiactive3 = false;
		}
		ItemGridConsumeComponent itemGridConsumeComponent = this.ItemGridConsumeComponent;
		if (itemGridConsumeComponent != null)
		{
			itemGridConsumeComponent.SetCostRootItemState(costRootItemState);
		}
		ItemGridConsumeComponent itemGridConsumeComponent2 = this.ItemGridConsumeComponent;
		if (itemGridConsumeComponent2 != null)
		{
			itemGridConsumeComponent2.SetStrengthItemEnable(strengthItemEnable);
		}
		ItemGridConsumeComponent itemGridConsumeComponent3 = this.ItemGridConsumeComponent;
		if (itemGridConsumeComponent3 != null)
		{
			itemGridConsumeComponent3.SetMaxItemEnable(maxItemEnable);
		}
		ItemGridConsumeComponent itemGridConsumeComponent4 = this.ItemGridConsumeComponent;
		if (itemGridConsumeComponent4 != null)
		{
			itemGridConsumeComponent4.SetConsumeListEnable(consumeListEnable);
		}
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
		UUIItem item2 = base.GetItem(9);
		if (item2 != null)
		{
			item2.SetUIActive(uiactive2);
		}
		UUIItem item3 = base.GetItem(12);
		if (item3 != null)
		{
			item3.SetUIActive(uiactive3);
		}
		if (flag)
		{
			ItemGridConsumeComponent itemGridConsumeComponent5 = this.ItemGridConsumeComponent;
			if (itemGridConsumeComponent5 == null)
			{
				return;
			}
			itemGridConsumeComponent5.SetMaxItemText(text);
			return;
		}
		else
		{
			ItemGridConsumeComponent itemGridConsumeComponent6 = this.ItemGridConsumeComponent;
			if (itemGridConsumeComponent6 == null)
			{
				return;
			}
			itemGridConsumeComponent6.SetStrengthItemText(text);
			return;
		}
	}

	// Token: 0x06012F38 RID: 77624 RVA: 0x004B1044 File Offset: 0x004AF244
	private void OnBtnState()
	{
		bool isMaxLevel = false;
		bool isMaxIdentify = false;
		VisionLevelUpView.EStrengthBtnState? btnState = this.BtnState;
		string text;
		if (btnState != null)
		{
			switch (btnState.GetValueOrDefault())
			{
			case VisionLevelUpView.EStrengthBtnState.Strength:
				text = "PrefabTextItem_1704419995_Text";
				goto IL_7E;
			case VisionLevelUpView.EStrengthBtnState.Identify:
				text = "IdentifyText";
				goto IL_7E;
			case VisionLevelUpView.EStrengthBtnState.StrengthAndIdentify:
				text = "TuneEchoesProject_Button2";
				goto IL_7E;
			case VisionLevelUpView.EStrengthBtnState.MaxLevelOnlyIdentify:
				text = "TuneEchoesProject_Button4";
				isMaxLevel = true;
				goto IL_7E;
			case VisionLevelUpView.EStrengthBtnState.MaxLevelNoIdentify:
				text = "PrefabTextItem_1826757657_Text";
				isMaxLevel = true;
				goto IL_7E;
			case VisionLevelUpView.EStrengthBtnState.MaxLevelAndIdentify:
				text = "PrefabTextItem_183779057_Text";
				isMaxLevel = true;
				isMaxIdentify = true;
				goto IL_7E;
			}
		}
		text = "PrefabTextItem_1704419995_Text";
		IL_7E:
		if (text == null)
		{
			return;
		}
		this.SetMaxState(isMaxLevel, isMaxIdentify, text);
	}

	// Token: 0x04008EA5 RID: 36517
	[Nullable(2)]
	private ExpComponent ExpComponent;

	// Token: 0x04008EA6 RID: 36518
	[Nullable(2)]
	private ItemGridConsumeComponent ItemGridConsumeComponent;

	// Token: 0x04008EA7 RID: 36519
	private int CurrentVisionUniqueId;

	// Token: 0x04008EA8 RID: 36520
	private int CurrentAddLevel;

	// Token: 0x04008EA9 RID: 36521
	private List<ISelectedData> CurrentSelectedMat = new List<ISelectedData>();

	// Token: 0x04008EAA RID: 36522
	[Nullable(2)]
	private List<TCommonMultipleConsumeData> ConsumeList;

	// Token: 0x04008EAB RID: 36523
	[Nullable(2)]
	private SelectableExpData CurrentExpData;

	// Token: 0x04008EAC RID: 36524
	[Nullable(2)]
	private VisionMainAttributeComponent VisionMainAttributeComponent;

	// Token: 0x04008EAD RID: 36525
	[Nullable(2)]
	private LevelUpIdentifyComponent LevelUpIdentifyComponent;

	// Token: 0x04008EAE RID: 36526
	private int CurrentAutoQualityIndex;

	// Token: 0x04008EAF RID: 36527
	private bool EventRegistState;

	// Token: 0x04008EB0 RID: 36528
	[Nullable(2)]
	private VisionNameText VisionNameText;

	// Token: 0x04008EB1 RID: 36529
	private bool AnimateState;

	// Token: 0x04008EB2 RID: 36530
	[Nullable(2)]
	private MediumItemGrid ItemGridVariantSelect;

	// Token: 0x04008EB3 RID: 36531
	private int TargetIdentifyNum;

	// Token: 0x04008EB4 RID: 36532
	private VisionLevelUpView.EStrengthBtnState? BtnState;

	// Token: 0x04008EB5 RID: 36533
	private EConfirmBoxConfigId? IdentifyConfirmBoxConfigId;

	// Token: 0x02008A5A RID: 35418
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CEC6 RID: 184006
		ExpItem,
		// Token: 0x0402CEC7 RID: 184007
		AttributeItem,
		// Token: 0x0402CEC8 RID: 184008
		ConsumeItem,
		// Token: 0x0402CEC9 RID: 184009
		SubAttributeItem,
		// Token: 0x0402CECA RID: 184010
		VisionName,
		// Token: 0x0402CECB RID: 184011
		LockToggle,
		// Token: 0x0402CECC RID: 184012
		DeprecateToggle,
		// Token: 0x0402CECD RID: 184013
		VisionIdentifyLayOutItem = 9,
		// Token: 0x0402CECE RID: 184014
		VisionIdentifyCostItem,
		// Token: 0x0402CECF RID: 184015
		MaxLevelTips,
		// Token: 0x0402CED0 RID: 184016
		MaxLevelTipsText
	}

	// Token: 0x02008A5B RID: 35419
	[NullableContext(0)]
	private enum EStrengthBtnState
	{
		// Token: 0x0402CED2 RID: 184018
		Strength,
		// Token: 0x0402CED3 RID: 184019
		Identify,
		// Token: 0x0402CED4 RID: 184020
		StrengthAndIdentify,
		// Token: 0x0402CED5 RID: 184021
		MaxLevelOnlyIdentify,
		// Token: 0x0402CED6 RID: 184022
		MaxLevelNoIdentify,
		// Token: 0x0402CED7 RID: 184023
		MaxLevelAndIdentify
	}
}
