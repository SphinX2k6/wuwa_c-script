using System;
using System.Collections.Generic;
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

// Token: 0x020019B6 RID: 6582
[NullableContext(1)]
[Nullable(0)]
public class VisionLevelUpView : UiTabViewBase
{
	// Token: 0x060103BF RID: 66495 RVA: 0x004BCE80 File Offset: 0x004BB080
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

	// Token: 0x060103C0 RID: 66496 RVA: 0x004BCFCC File Offset: 0x004BB1CC
	protected override UniTask OnBeforeStartAsync()
	{
		VisionLevelUpView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionLevelUpView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060103C1 RID: 66497 RVA: 0x004BD010 File Offset: 0x004BB210
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

	// Token: 0x060103C2 RID: 66498 RVA: 0x004BD11C File Offset: 0x004BB31C
	private void ConditionFunction(int index)
	{
		this.CurrentAutoQualityIndex = index;
		int id = CommonConfig.Instance.GetItemQualityList()[this.CurrentAutoQualityIndex].Id;
		this.ItemGridConsumeComponent.RefreshConditionText(CommonConfig.Instance.GetItemQualityById(id).Value.ConsumeFilterText);
	}

	// Token: 0x060103C3 RID: 66499 RVA: 0x004BD174 File Offset: 0x004BB374
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

	// Token: 0x060103C4 RID: 66500 RVA: 0x004BD1B8 File Offset: 0x004BB3B8
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

	// Token: 0x060103C5 RID: 66501 RVA: 0x004BD244 File Offset: 0x004BB444
	private void CheckAndCloseItemHintViewNew()
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.ItemHintViewNew))
		{
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.ItemHintViewNew, null);
	}

	// Token: 0x060103C6 RID: 66502 RVA: 0x004BD268 File Offset: 0x004BB468
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

	// Token: 0x060103C7 RID: 66503 RVA: 0x004BD2B8 File Offset: 0x004BB4B8
	private void PlayExpTween()
	{
		if (this.CurrentExpData.GetCurrentAddExp() > 0f)
		{
			UiLayer.Instance.SetShowMaskLayer("PhantomLevelUp", true);
			this.AnimateState = true;
			this.ExpComponent.PlayExpTween(this.CurrentExpData);
		}
	}

	// Token: 0x060103C8 RID: 66504 RVA: 0x004BD2F4 File Offset: 0x004BB4F4
	private void OnItemFuncValueChange(int uniqueId)
	{
		if (uniqueId != this.CurrentVisionUniqueId)
		{
			return;
		}
		this.RefreshToggleState();
	}

	// Token: 0x060103C9 RID: 66505 RVA: 0x004BD306 File Offset: 0x004BB506
	private void OnVisionLevelUpMaterialPutInModeChange()
	{
		this.RefreshPutInModeState();
	}

	// Token: 0x060103CA RID: 66506 RVA: 0x004BD30E File Offset: 0x004BB50E
	private void OnVisionLevelUpIdentifyChange()
	{
		this.RefreshItemAndExp();
	}

	// Token: 0x060103CB RID: 66507 RVA: 0x004BD318 File Offset: 0x004BB518
	private void SetUniqueId(int uniqueId)
	{
		this.CurrentVisionUniqueId = uniqueId;
		SelectableExpData currentExpData = this.GetCurrentExpData();
		this.ExpComponent.UpdateInitState(currentExpData);
		this.OnChangeSelectedFunction(new List<ISelectedData>(), currentExpData);
	}

	// Token: 0x060103CC RID: 66508 RVA: 0x004BD34C File Offset: 0x004BB54C
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

	// Token: 0x060103CD RID: 66509 RVA: 0x004BD3C0 File Offset: 0x004BB5C0
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

	// Token: 0x060103CE RID: 66510 RVA: 0x004BD484 File Offset: 0x004BB684
	private void RefreshName()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		this.VisionNameText.Update(phantomItemDataByUniqueId);
	}

	// Token: 0x060103CF RID: 66511 RVA: 0x004BD4B4 File Offset: 0x004BB6B4
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

	// Token: 0x060103D0 RID: 66512 RVA: 0x004BD568 File Offset: 0x004BB768
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

	// Token: 0x060103D1 RID: 66513 RVA: 0x004BD5C8 File Offset: 0x004BB7C8
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

	// Token: 0x060103D2 RID: 66514 RVA: 0x004BD600 File Offset: 0x004BB800
	private bool CheckEnableIdentify(PhantomDataBase data)
	{
		bool flag = PhantomBattleModel.Instance.GetVisionLevelUpIdentify() == EVisionLevelUpIdentify.EnableIdentify;
		bool flag2 = data.GetQuality() > 2;
		return flag && flag2;
	}

	// Token: 0x060103D3 RID: 66515 RVA: 0x004BD628 File Offset: 0x004BB828
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

	// Token: 0x060103D4 RID: 66516 RVA: 0x004BD6B4 File Offset: 0x004BB8B4
	protected override void OnBeforeHide()
	{
		this.RemoveEvent();
	}

	// Token: 0x060103D5 RID: 66517 RVA: 0x004BD6BC File Offset: 0x004BB8BC
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

	// Token: 0x060103D6 RID: 66518 RVA: 0x004BD712 File Offset: 0x004BB912
	private bool CheckEnoughMoney()
	{
		if (!this.ItemGridConsumeComponent.GetEnoughMoney())
		{
			ScrollingTipsController.Instance.ShowTipsById("WeaponNoEnoughMoneyText", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x060103D7 RID: 66519 RVA: 0x004BD738 File Offset: 0x004BB938
	private void OnClickStrengthBtn(int _)
	{
		this.CheckCanLevelUp().Forget();
	}

	// Token: 0x060103D8 RID: 66520 RVA: 0x004BD748 File Offset: 0x004BB948
	private UniTask CheckCanLevelUp()
	{
		VisionLevelUpView.<CheckCanLevelUp>d__44 <CheckCanLevelUp>d__;
		<CheckCanLevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckCanLevelUp>d__.<>4__this = this;
		<CheckCanLevelUp>d__.<>1__state = -1;
		<CheckCanLevelUp>d__.<>t__builder.Start<VisionLevelUpView.<CheckCanLevelUp>d__44>(ref <CheckCanLevelUp>d__);
		return <CheckCanLevelUp>d__.<>t__builder.Task;
	}

	// Token: 0x060103D9 RID: 66521 RVA: 0x004BD78C File Offset: 0x004BB98C
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

	// Token: 0x060103DA RID: 66522 RVA: 0x004BD898 File Offset: 0x004BBA98
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

	// Token: 0x060103DB RID: 66523 RVA: 0x004BD9B0 File Offset: 0x004BBBB0
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

	// Token: 0x060103DC RID: 66524 RVA: 0x004BDA54 File Offset: 0x004BBC54
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

	// Token: 0x060103DD RID: 66525 RVA: 0x004BDABC File Offset: 0x004BBCBC
	private void ProcessOverExp(Dictionary<int, int> overItemMap)
	{
		int overExp = this.CurrentExpData.GetOverExp();
		if (overExp > 0)
		{
			Dictionary<int, int> source = PhantomBattleModel.Instance.CalculateExpBackItem(overExp);
			this.AddBackItemToTargetMap(source, overItemMap);
		}
	}

	// Token: 0x060103DE RID: 66526 RVA: 0x004BDAF0 File Offset: 0x004BBCF0
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

	// Token: 0x060103DF RID: 66527 RVA: 0x004BDCF8 File Offset: 0x004BBEF8
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

	// Token: 0x060103E0 RID: 66528 RVA: 0x004BDD72 File Offset: 0x004BBF72
	private ConfirmBoxDataNew CreateLevelUpTipsWithOverflow(Dictionary<int, int> overItemMap)
	{
		return new ConfirmBoxDataNew(EConfirmBoxConfigId.WeaponOverflowExpTip)
		{
			ItemIdMap = overItemMap
		};
	}

	// Token: 0x060103E1 RID: 66529 RVA: 0x004BDD84 File Offset: 0x004BBF84
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

	// Token: 0x060103E2 RID: 66530 RVA: 0x004BDE14 File Offset: 0x004BC014
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

	// Token: 0x060103E3 RID: 66531 RVA: 0x004BDE84 File Offset: 0x004BC084
	private void OnClickDeleteSelectFunction()
	{
		this.CurrentSelectedMat.Clear();
		this.RefreshItemAndExp();
	}

	// Token: 0x060103E4 RID: 66532 RVA: 0x004BDE98 File Offset: 0x004BC098
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

	// Token: 0x060103E5 RID: 66533 RVA: 0x004BE088 File Offset: 0x004BC288
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

	// Token: 0x060103E6 RID: 66534 RVA: 0x004BE19C File Offset: 0x004BC39C
	private void ClearConsume()
	{
		for (int i = 0; i < this.ConsumeList.Count; i++)
		{
			TCommonMultipleConsumeData value = new TCommonMultipleConsumeData(new InventoryDefine.GetItemData(0, 0), 0);
			this.ConsumeList[i] = value;
		}
	}

	// Token: 0x060103E7 RID: 66535 RVA: 0x004BE1DC File Offset: 0x004BC3DC
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

	// Token: 0x060103E8 RID: 66536 RVA: 0x004BE293 File Offset: 0x004BC493
	private void ItemClickFunction()
	{
		this.MaterialItemFunction(new int?(0), new int?(0));
	}

	// Token: 0x060103E9 RID: 66537 RVA: 0x004BE2A8 File Offset: 0x004BC4A8
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
		commonItemSelectViewOpenViewData.ItemDataBaseList = new List<ItemDataBase>(expMaterialList);
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

	// Token: 0x060103EA RID: 66538 RVA: 0x004BE3C0 File Offset: 0x004BC5C0
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

	// Token: 0x060103EB RID: 66539 RVA: 0x004BE42A File Offset: 0x004BC62A
	private void OnChangeSelectedFunction(List<ISelectedData> currentSelectedData, SelectableExpData expData)
	{
		this.CurrentSelectedMat = currentSelectedData;
		this.CurrentExpData = expData;
		this.RefreshItemAndExp();
	}

	// Token: 0x060103EC RID: 66540 RVA: 0x004BE440 File Offset: 0x004BC640
	private int GetItemExpFunction(ISelectedData selectedData)
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(selectedData.IncId);
		if (phantomItemDataByUniqueId != null)
		{
			return phantomItemDataByUniqueId.GetEatFullExp();
		}
		return PhantomBattleConfig.Instance.GetPhantomExpItemById(selectedData.ItemId).Exp;
	}

	// Token: 0x060103ED RID: 66541 RVA: 0x004BE480 File Offset: 0x004BC680
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

	// Token: 0x060103EE RID: 66542 RVA: 0x004BE4C0 File Offset: 0x004BC6C0
	protected void OnClickLockToggle(EToggleState toggleState)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.CurrentVisionUniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		InventoryController.Instance.ItemLockRequest(this.CurrentVisionUniqueId, !attributeItemData.GetIsLock());
	}

	// Token: 0x060103EF RID: 66543 RVA: 0x004BE4FC File Offset: 0x004BC6FC
	protected void OnClickDeprecateToggle(EToggleState toggleState)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.CurrentVisionUniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		InventoryController.Instance.ItemDeprecateRequest(this.CurrentVisionUniqueId, !attributeItemData.GetIsDeprecated());
	}

	// Token: 0x060103F0 RID: 66544 RVA: 0x004BE538 File Offset: 0x004BC738
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

	// Token: 0x060103F1 RID: 66545 RVA: 0x004BE574 File Offset: 0x004BC774
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
		ItemController.Instance.OpenItemTipsByItemId(currentIdentifyCostId, true, null, false);
	}

	// Token: 0x060103F2 RID: 66546 RVA: 0x004BE5F8 File Offset: 0x004BC7F8
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

	// Token: 0x060103F3 RID: 66547 RVA: 0x004BE8EC File Offset: 0x004BCAEC
	private int GetIdentifyCostItemValue()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return 0;
		}
		return phantomItemDataByUniqueId.GetIdentifyCostItemValue();
	}

	// Token: 0x060103F4 RID: 66548 RVA: 0x004BE915 File Offset: 0x004BCB15
	private void RefreshStrengthBtnTxt(PhantomDataBase itemData, bool enableIdentify)
	{
		this.BtnState = new VisionLevelUpView.EStrengthBtnState?(this.CalculateBtnState(itemData, enableIdentify));
		this.OnBtnState();
	}

	// Token: 0x060103F5 RID: 66549 RVA: 0x004BE930 File Offset: 0x004BCB30
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

	// Token: 0x060103F6 RID: 66550 RVA: 0x004BEB24 File Offset: 0x004BCD24
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

	// Token: 0x060103F7 RID: 66551 RVA: 0x004BEC48 File Offset: 0x004BCE48
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

	// Token: 0x04008FEF RID: 36847
	[Nullable(2)]
	private ExpComponent ExpComponent;

	// Token: 0x04008FF0 RID: 36848
	[Nullable(2)]
	private ItemGridConsumeComponent ItemGridConsumeComponent;

	// Token: 0x04008FF1 RID: 36849
	private int CurrentVisionUniqueId;

	// Token: 0x04008FF2 RID: 36850
	private int CurrentAddLevel;

	// Token: 0x04008FF3 RID: 36851
	private List<ISelectedData> CurrentSelectedMat = new List<ISelectedData>();

	// Token: 0x04008FF4 RID: 36852
	[Nullable(2)]
	private List<TCommonMultipleConsumeData> ConsumeList;

	// Token: 0x04008FF5 RID: 36853
	[Nullable(2)]
	private SelectableExpData CurrentExpData;

	// Token: 0x04008FF6 RID: 36854
	[Nullable(2)]
	private VisionMainAttributeComponent VisionMainAttributeComponent;

	// Token: 0x04008FF7 RID: 36855
	[Nullable(2)]
	private LevelUpIdentifyComponent LevelUpIdentifyComponent;

	// Token: 0x04008FF8 RID: 36856
	private int CurrentAutoQualityIndex;

	// Token: 0x04008FF9 RID: 36857
	private bool EventRegistState;

	// Token: 0x04008FFA RID: 36858
	[Nullable(2)]
	private VisionNameText VisionNameText;

	// Token: 0x04008FFB RID: 36859
	private bool AnimateState;

	// Token: 0x04008FFC RID: 36860
	[Nullable(2)]
	private MediumItemGrid ItemGridVariantSelect;

	// Token: 0x04008FFD RID: 36861
	private int TargetIdentifyNum;

	// Token: 0x04008FFE RID: 36862
	private VisionLevelUpView.EStrengthBtnState? BtnState;

	// Token: 0x04008FFF RID: 36863
	private EConfirmBoxConfigId? IdentifyConfirmBoxConfigId;

	// Token: 0x02007BE3 RID: 31715
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040281E4 RID: 164324
		ExpItem,
		// Token: 0x040281E5 RID: 164325
		AttributeItem,
		// Token: 0x040281E6 RID: 164326
		ConsumeItem,
		// Token: 0x040281E7 RID: 164327
		SubAttributeItem,
		// Token: 0x040281E8 RID: 164328
		VisionName,
		// Token: 0x040281E9 RID: 164329
		LockToggle,
		// Token: 0x040281EA RID: 164330
		DeprecateToggle,
		// Token: 0x040281EB RID: 164331
		VisionIdentifyLayOutItem = 9,
		// Token: 0x040281EC RID: 164332
		VisionIdentifyCostItem,
		// Token: 0x040281ED RID: 164333
		MaxLevelTips,
		// Token: 0x040281EE RID: 164334
		MaxLevelTipsText
	}

	// Token: 0x02007BE4 RID: 31716
	[NullableContext(0)]
	private enum EStrengthBtnState
	{
		// Token: 0x040281F0 RID: 164336
		Strength,
		// Token: 0x040281F1 RID: 164337
		Identify,
		// Token: 0x040281F2 RID: 164338
		StrengthAndIdentify,
		// Token: 0x040281F3 RID: 164339
		MaxLevelOnlyIdentify,
		// Token: 0x040281F4 RID: 164340
		MaxLevelNoIdentify,
		// Token: 0x040281F5 RID: 164341
		MaxLevelAndIdentify
	}
}
