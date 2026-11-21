using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.InputView.Controller;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200178D RID: 6029
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyImportPresetView : UiViewBase
{
	// Token: 0x0600EA6F RID: 60015 RVA: 0x0044C008 File Offset: 0x0044A208
	public MotorcycleDiyImportPresetView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EA70 RID: 60016 RVA: 0x0044C090 File Offset: 0x0044A290
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(30, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIText)),
			new ValueTuple<int, Type>(19, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(20, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(24, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(26, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(23, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(27, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(28, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(29, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(25, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(31, typeof(UUIItem)),
			new ValueTuple<int, Type>(32, typeof(UUIText)),
			new ValueTuple<int, Type>(33, typeof(UUIItem)),
			new ValueTuple<int, Type>(34, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(19, new Action<EToggleState>(this.OnTogCustomPresetClick)),
			new ValueTuple<int, Delegate>(20, new Action<EToggleState>(this.OnTogOfficialPresetClick)),
			new ValueTuple<int, Delegate>(24, new Action<EToggleState>(this.OnTogEyeClick)),
			new ValueTuple<int, Delegate>(23, new Action(this.OnBtnCreatePresetClick)),
			new ValueTuple<int, Delegate>(27, new Action(this.OnBtnDeletePresetClick)),
			new ValueTuple<int, Delegate>(28, new Action(this.OnBtnEditPresetClick)),
			new ValueTuple<int, Delegate>(29, new Action(this.OnBtnSaveToNewPresetClick)),
			new ValueTuple<int, Delegate>(25, new Action(this.OnBtnEditNameClick)),
			new ValueTuple<int, Delegate>(13, new Action(this.OnBtnImportPresetClick))
		};
	}

	// Token: 0x0600EA71 RID: 60017 RVA: 0x0044C4B0 File Offset: 0x0044A6B0
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyImportPresetView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyImportPresetView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EA72 RID: 60018 RVA: 0x0044C4F3 File Offset: 0x0044A6F3
	protected override void OnBeforeShow()
	{
		MotorcycleUiModelUtil.Instance.ShowMotor(true);
		this.RefreshLeftPresetInfo(true, this.CustomPresetDataIndex, true, false);
	}

	// Token: 0x0600EA73 RID: 60019 RVA: 0x0044C50F File Offset: 0x0044A70F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyFullOutlookUpdate, new Action(this.OnUpdateAllPresetInfo));
	}

	// Token: 0x0600EA74 RID: 60020 RVA: 0x0044C52D File Offset: 0x0044A72D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyFullOutlookUpdate, new Action(this.OnUpdateAllPresetInfo));
	}

	// Token: 0x0600EA75 RID: 60021 RVA: 0x0044C54B File Offset: 0x0044A74B
	protected override void OnAfterShow()
	{
		this.CameraInputBinding.Bind();
	}

	// Token: 0x0600EA76 RID: 60022 RVA: 0x0044C558 File Offset: 0x0044A758
	protected override void OnBeforeHide()
	{
		MotorcycleUiModelUtil.Instance.ShowMotor(false);
		this.CameraInputBinding.Unbind();
	}

	// Token: 0x0600EA77 RID: 60023 RVA: 0x0044C570 File Offset: 0x0044A770
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x0600EA78 RID: 60024 RVA: 0x0044C57C File Offset: 0x0044A77C
	private void OnClickPresetItem(MotorcycleDiyPresetData data, int listIndex, UUIExtendToggle toggle)
	{
		if (this.CurrentSelectToggle != null)
		{
			this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		this.CustomPresetDataIndex = listIndex;
		this.RefreshRightPresetInfo(data);
	}

	// Token: 0x0600EA79 RID: 60025 RVA: 0x0044C5BB File Offset: 0x0044A7BB
	private MotorcycleDiyPresetItem InitPresetScrollItem()
	{
		return new MotorcycleDiyPresetItem
		{
			OnClickToggleBack = new Action<MotorcycleDiyPresetData, int, UUIExtendToggle>(this.OnClickPresetItem)
		};
	}

	// Token: 0x0600EA7A RID: 60026 RVA: 0x0044C5D4 File Offset: 0x0044A7D4
	private MotorcycleDiyPresetStickerItem InitStickerScrollItem()
	{
		return new MotorcycleDiyPresetStickerItem();
	}

	// Token: 0x0600EA7B RID: 60027 RVA: 0x0044C5DB File Offset: 0x0044A7DB
	private MotorcycleDiyPresetDecorationItem InitDecorateScrollItem()
	{
		return new MotorcycleDiyPresetDecorationItem();
	}

	// Token: 0x0600EA7C RID: 60028 RVA: 0x0044C5E4 File Offset: 0x0044A7E4
	private void RefreshLeftPresetInfo(bool isCustom, int selectIndex = -1, bool needScroll = true, bool playGridAnim = false)
	{
		List<MotorcycleDiyPresetData> allPresetDataList = MotorcycleDiyModel.Instance.GetAllPresetDataList(isCustom);
		int count = allPresetDataList.Count;
		bool flag = count >= this.MaxCustomPresetNum;
		base.GetButton(23).RootUIComp.Get().SetUIActive(isCustom);
		base.GetButton(23).SetSelfInteractive(!flag);
		base.GetItem(4).SetUIActive(!isCustom);
		base.GetItem(33).SetUIActive(isCustom);
		base.GetItem(34).SetUIActive(isCustom);
		base.GetItem(22).SetUIActive(count <= 0);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(21), "DIYProjectList", new <>z__ReadOnlyArray<object>(new object[]
		{
			count,
			this.MaxCustomPresetNum
		}));
		this.PresetScrollView.SetActive(count > 0);
		this.PresetScrollView.RefreshByData(allPresetDataList, delegate
		{
			this.GetItem(4).SetAsLastHierarchy();
			if (selectIndex < 0)
			{
				MotorcycleDiyPresetItem curPresetItem = this.CurPresetItem;
				if (curPresetItem == null)
				{
					return;
				}
				curPresetItem.OnSelected(true);
				return;
			}
			else
			{
				UUIItem selectItem = this.PresetScrollView.GetItemByIndex(selectIndex);
				if (needScroll && selectItem != null)
				{
					this.PresetScrollView.LateScrollTo(selectItem, delegate
					{
						this.PresetScrollView.SelectGridProxy(selectIndex, false);
						UiNavigationNewController.Instance.SetNavigationFocusForView(selectItem, false, false, false);
					}, false);
					return;
				}
				this.PresetScrollView.SelectGridProxy(selectIndex, false);
				if (selectItem != null)
				{
					UiNavigationNewController.Instance.SetNavigationFocusForView(selectItem, false, false, false);
				}
				return;
			}
		}, playGridAnim);
	}

	// Token: 0x0600EA7D RID: 60029 RVA: 0x0044C6FC File Offset: 0x0044A8FC
	private MotorcycleDiyPresetData BuildCurrentPresetData()
	{
		return new MotorcycleDiyPresetData
		{
			IsCurEquipped = true,
			Name = (ConfigMultiTextLang.GetLocalTextNew("DIYProjectPresent", null) ?? string.Empty),
			FrameId = MotorcycleDiyModel.Instance.GetEquippedFrameId(),
			StickerIds = MotorcycleDiyModel.Instance.GetEquippedStickerIdList().ToArray(),
			DecorateIds = MotorcycleDiyModel.Instance.GetEquippedDecorationIdList().ToArray()
		};
	}

	// Token: 0x0600EA7E RID: 60030 RVA: 0x0044C76C File Offset: 0x0044A96C
	private void RefreshRightPresetInfo(MotorcycleDiyPresetData data)
	{
		this.RefreshFramePresetInfo(data);
		this.RefreshStickerPresetInfo(data);
		this.RefreshDecorationPresetInfo(data);
		bool uiactive = data.CustomId > 0;
		int count = MotorcycleDiyModel.Instance.GetAllPresetDataList(true).Count;
		bool isCurEquipped = data.IsCurEquipped;
		bool flag = count >= this.MaxCustomPresetNum;
		base.GetItem(30).SetUIActive(isCurEquipped && flag);
		base.GetButton(29).RootUIComp.Get().SetUIActive(isCurEquipped && !flag);
		base.GetButton(27).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(25).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(28).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(13).RootUIComp.Get().SetUIActive(!isCurEquipped);
		base.GetText(32).SetText(data.Name, true);
		if (data.CustomId > 0)
		{
			this.CurCustomPresetData = data;
		}
		bool flag2 = base.GetButton(25).RootUIComp.Get().IsUIActiveSelf();
		UUIItem uuiitem = base.GetHorizontalLayout(26).RootUIComp.Get();
		uuiitem.SetWidth((float)(flag2 ? this.TwoBtnWidthAndOffsetX[0] : this.OneBtnWidthAndOffsetX[0]));
		uuiitem.SetAnchorOffsetX((float)(flag2 ? this.TwoBtnWidthAndOffsetX[1] : this.OneBtnWidthAndOffsetX[1]));
		if (this.IsEyeActiveFromGamepad)
		{
			this.IsEyeActiveFromGamepad = false;
			return;
		}
		MotorcycleUiModelParam param = new MotorcycleUiModelParam
		{
			FrameId = this.PresetFrameId,
			StickerIds = this.PresetStickerIds.ToArray(),
			DecorationIds = this.PresetDecorationIds.ToArray()
		};
		MotorcycleUiModelUtil.Instance.LoadMotorByParam(param, null);
	}

	// Token: 0x0600EA7F RID: 60031 RVA: 0x0044C944 File Offset: 0x0044AB44
	private void RefreshStickerPresetInfo(MotorcycleDiyPresetData data)
	{
		List<int> list = new List<int>(data.StickerIds);
		List<MotorcycleDiyEditStickerDecoItemData> list2 = new List<MotorcycleDiyEditStickerDecoItemData>();
		MotorSticker? motorSticker = null;
		for (int i = 0; i < list.Count; i++)
		{
			int num = list[i];
			if (num > 0)
			{
				motorSticker = MotorDiyConfig.Instance.GetMotorStickerConfig(num);
			}
			list2.Add(new MotorcycleDiyEditStickerDecoItemData
			{
				Part = i + 1,
				ItemId = num,
				QualityId = ((motorSticker != null) ? motorSticker.Value.QualityId : 0),
				SortIndex = ((motorSticker != null) ? motorSticker.Value.SortIndex : 0),
				IsSticker = true
			});
		}
		this.StickerScrollView.RefreshByData(list2, null, false);
		this.PresetStickerIds = list;
	}

	// Token: 0x0600EA80 RID: 60032 RVA: 0x0044CA24 File Offset: 0x0044AC24
	private void RefreshDecorationPresetInfo(MotorcycleDiyPresetData data)
	{
		List<int> list = new List<int>(data.DecorateIds);
		List<MotorcycleDiyEditStickerDecoItemData> list2 = new List<MotorcycleDiyEditStickerDecoItemData>();
		MotorDecorations? motorDecorations = null;
		for (int i = 0; i < list.Count; i++)
		{
			int num = list[i];
			if (num > 0)
			{
				motorDecorations = MotorDiyConfig.Instance.GetMotorDecorationConfig(num);
			}
			list2.Add(new MotorcycleDiyEditStickerDecoItemData
			{
				Part = i + 1,
				ItemId = num,
				QualityId = ((motorDecorations != null) ? motorDecorations.Value.QualityId : 0),
				SortIndex = ((motorDecorations != null) ? motorDecorations.Value.SortIndex : 0),
				IsSticker = false
			});
		}
		this.DecorateScrollView.RefreshByData(list2, null, false);
		this.PresetDecorationIds = list;
	}

	// Token: 0x0600EA81 RID: 60033 RVA: 0x0044CB04 File Offset: 0x0044AD04
	private void RefreshFramePresetInfo(MotorcycleDiyPresetData data)
	{
		if (data.FrameId > 0)
		{
			MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(data.FrameId);
			MotorFramePart? motorFramePartConfig = MotorDiyConfig.Instance.GetMotorFramePartConfig();
			if (motorFramePartConfig != null && motorFrameConfig != null)
			{
				base.SetTextureByPath(motorFramePartConfig.Value.Icon, base.GetTexture(5), null, null);
				base.SetTextureByPath(motorFrameConfig.Value.ModelIconPath, base.GetTexture(6), null, null);
			}
		}
		this.PresetFrameId = data.FrameId;
	}

	// Token: 0x0600EA82 RID: 60034 RVA: 0x0044CBA4 File Offset: 0x0044ADA4
	public void InitCameraInputData()
	{
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig("摩托车预设界面");
		if (roleCameraConfig == null)
		{
			return;
		}
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("RoleCase").Value, ECollectActorType.UI);
		if (actorWithTag == null)
		{
			return;
		}
		FVectorDouble fvectorDouble = actorWithTag.D_K2_GetActorLocation();
		UiCameraInputBindingData data = new UiCameraInputBindingData
		{
			DragComponent = base.GetDraggable(18),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputBinding.Configure(data);
	}

	// Token: 0x0600EA83 RID: 60035 RVA: 0x0044CC2C File Offset: 0x0044AE2C
	private void OnUpdateAllPresetInfo()
	{
		MotorcycleDiyPresetData curCustomPresetData = this.CurCustomPresetData;
		if (curCustomPresetData == null)
		{
			return;
		}
		if (curCustomPresetData.OfficialId != 0)
		{
			this.RefreshLeftPresetInfo(false, 0, false, true);
			return;
		}
		this.CustomPresetDataIndex = -1;
		MotorcycleDiyModel instance = MotorcycleDiyModel.Instance;
		this.RefreshLeftPresetInfo(true, this.CustomPresetDataIndex, false, true);
		MotorcycleDiyPresetData data = this.BuildCurrentPresetData();
		MotorcycleDiyPresetItem curPresetItem = this.CurPresetItem;
		if (curPresetItem != null)
		{
			curPresetItem.RefreshPresetInfo(data);
		}
		MotorcycleDiyPresetItem curPresetItem2 = this.CurPresetItem;
		if (curPresetItem2 == null)
		{
			return;
		}
		curPresetItem2.SetToggleState(EToggleState.ETT_Checked, true);
	}

	// Token: 0x0600EA84 RID: 60036 RVA: 0x0044CCA4 File Offset: 0x0044AEA4
	private void OnTogCustomPresetClick(EToggleState toggleState)
	{
		UUIExtendToggle officialToggle = this.OfficialToggle;
		if (officialToggle != null)
		{
			officialToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		MotorcycleDiyPresetItem curPresetItem = this.CurPresetItem;
		if (curPresetItem != null)
		{
			curPresetItem.SetToggleState(EToggleState.ETT_Checked, true);
		}
		this.RefreshLeftPresetInfo(true, -1, true, true);
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequencePurely("Switch", false, false);
	}

	// Token: 0x0600EA85 RID: 60037 RVA: 0x0044CCFA File Offset: 0x0044AEFA
	private void OnTogOfficialPresetClick(EToggleState toggleState)
	{
		UUIExtendToggle customToggle = this.CustomToggle;
		if (customToggle != null)
		{
			customToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.RefreshLeftPresetInfo(false, 0, false, true);
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequencePurely("Switch", false, false);
	}

	// Token: 0x0600EA86 RID: 60038 RVA: 0x0044CD34 File Offset: 0x0044AF34
	private void OnTogEyeClick(EToggleState toggleState)
	{
		this.IsNotHidingUi = !this.IsNotHidingUi;
		base.GetItem(31).SetUIActive(this.IsNotHidingUi);
		if (this.IsNotHidingUi && Info.Instance.IsInGamepad())
		{
			UUIItem itemByIndex = this.PresetScrollView.GetItemByIndex(this.CustomPresetDataIndex);
			if (itemByIndex != null)
			{
				this.IsEyeActiveFromGamepad = true;
				UiNavigationNewController.Instance.SetNavigationFocusForView(itemByIndex, true, true, true);
			}
		}
	}

	// Token: 0x0600EA87 RID: 60039 RVA: 0x0044CDA4 File Offset: 0x0044AFA4
	private void AutoSetSelectedFromPreset(MotorcycleDiyPresetData presetData)
	{
		MotorcycleDiyModel instance = MotorcycleDiyModel.Instance;
		for (int i = 0; i < presetData.StickerIds.Length; i++)
		{
			instance.SetSelectStickerInfo(i + 1, presetData.StickerIds[i]);
		}
		for (int j = 0; j < presetData.DecorateIds.Length; j++)
		{
			instance.SetSelectDecorationInfo(j + 1, presetData.DecorateIds[j]);
		}
		instance.SetSelectFrame(presetData.FrameId);
	}

	// Token: 0x0600EA88 RID: 60040 RVA: 0x0044CE0C File Offset: 0x0044B00C
	private void OnBtnCreatePresetClick()
	{
		if (this.TempCreatePresetData == null)
		{
			return;
		}
		this.AutoSetSelectedFromPreset(this.TempCreatePresetData);
		OpenMotorcycleDiyRootViewData param = new OpenMotorcycleDiyRootViewData
		{
			PartTabIndex = new int?(1),
			IsNeedResetMotor = new bool?(true),
			PresetData = this.TempCreatePresetData,
			CustomMode = new EMotorcycleDiyCustomMode?(EMotorcycleDiyCustomMode.NewCreate),
			OnNewCustomPresetCreated = delegate(int customPresetListIndex)
			{
				this.CustomPresetDataIndex = customPresetListIndex;
			}
		};
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyEditRootView, param, null);
	}

	// Token: 0x0600EA89 RID: 60041 RVA: 0x0044CE88 File Offset: 0x0044B088
	private void OnBtnDeletePresetClick()
	{
		if (this.CurCustomPresetData == null)
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MotorDiyDeletePresetConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			MotorcycleDiyController.Instance.DeleteMotorOutlookPresetRequest(this.CurCustomPresetData.CustomId, delegate
			{
				this.CustomPresetDataIndex--;
				if (MotorcycleDiyModel.Instance.GetAllPresetDataList(true).Count > 0)
				{
					this.CustomPresetDataIndex = Math.Max(this.CustomPresetDataIndex, 0);
				}
				if (this.CustomPresetDataIndex < 0)
				{
					MotorcycleDiyPresetItem curPresetItem = this.CurPresetItem;
					if (curPresetItem != null)
					{
						curPresetItem.SetToggleState(EToggleState.ETT_Checked, true);
					}
				}
				this.RefreshLeftPresetInfo(true, this.CustomPresetDataIndex, true, false);
			});
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600EA8A RID: 60042 RVA: 0x0044CED0 File Offset: 0x0044B0D0
	private void OnBtnEditPresetClick()
	{
		if (this.CurCustomPresetData != null)
		{
			this.AutoSetSelectedFromPreset(this.CurCustomPresetData);
		}
		OpenMotorcycleDiyRootViewData param = new OpenMotorcycleDiyRootViewData
		{
			PartTabIndex = new int?(1),
			IsNeedResetMotor = new bool?(true),
			PresetData = this.CurCustomPresetData,
			CustomMode = new EMotorcycleDiyCustomMode?(EMotorcycleDiyCustomMode.Edit)
		};
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyEditRootView, param, null);
	}

	// Token: 0x0600EA8B RID: 60043 RVA: 0x0044CF38 File Offset: 0x0044B138
	private void OnBtnSaveToNewPresetClick()
	{
		CommonInputViewController.Instance.OpenMotorcycleDiyNameInputView(new Func<string, UniTask<Aki.Protocol.ErrorCode>>(this.OnConfirmRenameForCreate), this.DefaultCustomPresetName);
	}

	// Token: 0x0600EA8C RID: 60044 RVA: 0x0044CF56 File Offset: 0x0044B156
	private void OnBtnEditNameClick()
	{
		CommonInputViewController instance = CommonInputViewController.Instance;
		Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack = new Func<string, UniTask<Aki.Protocol.ErrorCode>>(this.OnConfirmRenameForEdit);
		MotorcycleDiyPresetData curCustomPresetData = this.CurCustomPresetData;
		instance.OpenMotorcycleDiyNameInputView(callBack, ((curCustomPresetData != null) ? curCustomPresetData.Name : null) ?? string.Empty);
	}

	// Token: 0x0600EA8D RID: 60045 RVA: 0x0044CF8C File Offset: 0x0044B18C
	[NullableContext(0)]
	private UniTask<Aki.Protocol.ErrorCode> OnConfirmRenameForCreate([Nullable(1)] string input)
	{
		MotorcycleDiyImportPresetView.<OnConfirmRenameForCreate>d__53 <OnConfirmRenameForCreate>d__;
		<OnConfirmRenameForCreate>d__.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
		<OnConfirmRenameForCreate>d__.<>4__this = this;
		<OnConfirmRenameForCreate>d__.input = input;
		<OnConfirmRenameForCreate>d__.<>1__state = -1;
		<OnConfirmRenameForCreate>d__.<>t__builder.Start<MotorcycleDiyImportPresetView.<OnConfirmRenameForCreate>d__53>(ref <OnConfirmRenameForCreate>d__);
		return <OnConfirmRenameForCreate>d__.<>t__builder.Task;
	}

	// Token: 0x0600EA8E RID: 60046 RVA: 0x0044CFD8 File Offset: 0x0044B1D8
	[NullableContext(0)]
	private UniTask<Aki.Protocol.ErrorCode> OnConfirmRenameForEdit([Nullable(1)] string input)
	{
		MotorcycleDiyImportPresetView.<OnConfirmRenameForEdit>d__54 <OnConfirmRenameForEdit>d__;
		<OnConfirmRenameForEdit>d__.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
		<OnConfirmRenameForEdit>d__.<>4__this = this;
		<OnConfirmRenameForEdit>d__.input = input;
		<OnConfirmRenameForEdit>d__.<>1__state = -1;
		<OnConfirmRenameForEdit>d__.<>t__builder.Start<MotorcycleDiyImportPresetView.<OnConfirmRenameForEdit>d__54>(ref <OnConfirmRenameForEdit>d__);
		return <OnConfirmRenameForEdit>d__.<>t__builder.Task;
	}

	// Token: 0x0600EA8F RID: 60047 RVA: 0x0044D024 File Offset: 0x0044B224
	private void OnBtnImportPresetClick()
	{
		bool flag = this.PresetFrameId == MotorcycleDiyModel.Instance.GetEquippedFrameId();
		if (MotorcycleDiyModel.Instance.IsEquipFrameLockedByPlayer() && !flag)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("MotorDIYWarning02", Array.Empty<object>());
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MotorcycleDiyImportConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			MotorcycleDiyController.Instance.EquipMotorOutLookRequest(this.PresetStickerIds, this.PresetDecorationIds, this.PresetFrameId, delegate
			{
				this.AutoSetSelectedFromPreset(new MotorcycleDiyPresetData
				{
					FrameId = this.PresetFrameId,
					StickerIds = this.PresetStickerIds.ToArray(),
					DecorateIds = this.PresetDecorationIds.ToArray()
				});
				if (this.CurCustomPresetData != null)
				{
					MotorcycleDiyPresetItem curPresetItem = this.CurPresetItem;
					if (curPresetItem != null)
					{
						curPresetItem.RefreshPresetInfo(this.CurCustomPresetData);
					}
				}
				ScrollingTipsController.Instance.ShowTipsByTextId("MotorDIYTips02", Array.Empty<object>());
				base.CloseMe(null);
			});
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600EA90 RID: 60048 RVA: 0x0044D097 File Offset: 0x0044B297
	private void OnCloseClick()
	{
		MotorcycleUiModelUtil.Instance.LoadEquippedMotor(delegate(UiModelBase _)
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x0600EA91 RID: 60049 RVA: 0x0044D0B0 File Offset: 0x0044B2B0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "Preset"))
		{
			return null;
		}
		int num2;
		int num = int.TryParse(configParams[1], out num2) ? num2 : int.MinValue;
		GenericLayout<MotorcycleDiyPresetItem, MotorcycleDiyPresetData> genericLayout = this.PresetScrollView.GetGenericLayout();
		IReadOnlyList<MotorcycleDiyPresetData> readOnlyList = (genericLayout != null) ? genericLayout.GetDatas() : null;
		if (readOnlyList == null)
		{
			return null;
		}
		int displayIndex = -1;
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			if (readOnlyList[i].OfficialId == num)
			{
				displayIndex = i;
				break;
			}
		}
		GenericLayout<MotorcycleDiyPresetItem, MotorcycleDiyPresetData> genericLayout2 = this.PresetScrollView.GetGenericLayout();
		UUIItem uuiitem = (genericLayout2 != null) ? genericLayout2.GetGridByDisplayIndex(displayIndex) : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x04008531 RID: 34097
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008532 RID: 34098
	[Nullable(2)]
	private MotorcycleDiyPresetItem CurPresetItem;

	// Token: 0x04008533 RID: 34099
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleDiyPresetItem, MotorcycleDiyPresetData> PresetScrollView;

	// Token: 0x04008534 RID: 34100
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleDiyPresetStickerItem, MotorcycleDiyEditStickerDecoItemData> StickerScrollView;

	// Token: 0x04008535 RID: 34101
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleDiyPresetDecorationItem, MotorcycleDiyEditStickerDecoItemData> DecorateScrollView;

	// Token: 0x04008536 RID: 34102
	[Nullable(2)]
	private UUIExtendToggle CustomToggle;

	// Token: 0x04008537 RID: 34103
	[Nullable(2)]
	private UUIExtendToggle OfficialToggle;

	// Token: 0x04008538 RID: 34104
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x04008539 RID: 34105
	[Nullable(2)]
	private UUIInturnAnimController AnimController;

	// Token: 0x0400853A RID: 34106
	public UiCameraInputBinding CameraInputBinding = new UiCameraInputBinding();

	// Token: 0x0400853B RID: 34107
	private List<int> PresetStickerIds = new List<int>();

	// Token: 0x0400853C RID: 34108
	private List<int> PresetDecorationIds = new List<int>();

	// Token: 0x0400853D RID: 34109
	private int PresetFrameId;

	// Token: 0x0400853E RID: 34110
	[Nullable(2)]
	private MotorcycleDiyPresetData CurCustomPresetData;

	// Token: 0x0400853F RID: 34111
	[Nullable(2)]
	private MotorcycleDiyPresetData TempCreatePresetData;

	// Token: 0x04008540 RID: 34112
	private int CustomPresetDataIndex = -1;

	// Token: 0x04008541 RID: 34113
	private string DefaultCustomPresetName = string.Empty;

	// Token: 0x04008542 RID: 34114
	private int MaxCustomPresetNum;

	// Token: 0x04008543 RID: 34115
	private bool IsNotHidingUi = true;

	// Token: 0x04008544 RID: 34116
	private bool IsEyeActiveFromGamepad;

	// Token: 0x04008545 RID: 34117
	private readonly int[] TwoBtnWidthAndOffsetX = new int[]
	{
		830,
		-490
	};

	// Token: 0x04008546 RID: 34118
	private readonly int[] OneBtnWidthAndOffsetX = new int[]
	{
		637,
		-390
	};

	// Token: 0x0200798C RID: 31116
	[NullableContext(0)]
	private class EMotorDiyPresetComponent
	{
		// Token: 0x04027635 RID: 161333
		public const int CurPresetItem = 0;

		// Token: 0x04027636 RID: 161334
		public const int PresetScroll = 1;

		// Token: 0x04027637 RID: 161335
		public const int PresetContent = 2;

		// Token: 0x04027638 RID: 161336
		public const int PresetToggle = 3;

		// Token: 0x04027639 RID: 161337
		public const int PresetTipsItem = 4;

		// Token: 0x0402763A RID: 161338
		public const int TexFramePartIcon = 5;

		// Token: 0x0402763B RID: 161339
		public const int TexFrameIcon = 6;

		// Token: 0x0402763C RID: 161340
		public const int StickerScroll = 7;

		// Token: 0x0402763D RID: 161341
		public const int StickerContent = 8;

		// Token: 0x0402763E RID: 161342
		public const int StickerItem = 9;

		// Token: 0x0402763F RID: 161343
		public const int DecorateScroll = 10;

		// Token: 0x04027640 RID: 161344
		public const int DecorateContent = 11;

		// Token: 0x04027641 RID: 161345
		public const int DecorateItem = 12;

		// Token: 0x04027642 RID: 161346
		public const int BtnImportPreset = 13;

		// Token: 0x04027643 RID: 161347
		public const int CaptionItem = 14;

		// Token: 0x04027644 RID: 161348
		public const int PnlFrame = 15;

		// Token: 0x04027645 RID: 161349
		public const int PnlSticker = 16;

		// Token: 0x04027646 RID: 161350
		public const int PnlDecorate = 17;

		// Token: 0x04027647 RID: 161351
		public const int DragComponent = 18;

		// Token: 0x04027648 RID: 161352
		public const int TogCustomPreset = 19;

		// Token: 0x04027649 RID: 161353
		public const int TogOfficialPreset = 20;

		// Token: 0x0402764A RID: 161354
		public const int TxtPresetCount = 21;

		// Token: 0x0402764B RID: 161355
		public const int PnlEmpty = 22;

		// Token: 0x0402764C RID: 161356
		public const int BtnCreatePreset = 23;

		// Token: 0x0402764D RID: 161357
		public const int TogEye = 24;

		// Token: 0x0402764E RID: 161358
		public const int BtnEditName = 25;

		// Token: 0x0402764F RID: 161359
		public const int RightBottomBtnLayout = 26;

		// Token: 0x04027650 RID: 161360
		public const int BtnDeletePreset = 27;

		// Token: 0x04027651 RID: 161361
		public const int BtnEditPreset = 28;

		// Token: 0x04027652 RID: 161362
		public const int BtnSaveNewPreset = 29;

		// Token: 0x04027653 RID: 161363
		public const int PnlMaxTips = 30;

		// Token: 0x04027654 RID: 161364
		public const int NotHideUIItem = 31;

		// Token: 0x04027655 RID: 161365
		public const int CurUsePresetName = 32;

		// Token: 0x04027656 RID: 161366
		public const int PnlCurPreset = 33;

		// Token: 0x04027657 RID: 161367
		public const int PnlPresetCount = 34;
	}
}
