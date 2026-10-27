using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.InputView.Controller;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022A9 RID: 8873
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyImportPresetView : UiViewBase
{
	// Token: 0x060115D7 RID: 71127 RVA: 0x0043F41C File Offset: 0x0043D61C
	public MotorcycleDiyImportPresetView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060115D8 RID: 71128 RVA: 0x0043F4A4 File Offset: 0x0043D6A4
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

	// Token: 0x060115D9 RID: 71129 RVA: 0x0043F8C4 File Offset: 0x0043DAC4
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyImportPresetView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyImportPresetView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060115DA RID: 71130 RVA: 0x0043F907 File Offset: 0x0043DB07
	protected override void OnBeforeShow()
	{
		MotorcycleUiModelUtil.Instance.ShowMotor(true);
		this.RefreshLeftPresetInfo(true, this.CustomPresetDataIndex, true, false);
	}

	// Token: 0x060115DB RID: 71131 RVA: 0x0043F923 File Offset: 0x0043DB23
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyFullOutlookUpdate, new Action(this.OnUpdateAllPresetInfo));
	}

	// Token: 0x060115DC RID: 71132 RVA: 0x0043F941 File Offset: 0x0043DB41
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyFullOutlookUpdate, new Action(this.OnUpdateAllPresetInfo));
	}

	// Token: 0x060115DD RID: 71133 RVA: 0x0043F95F File Offset: 0x0043DB5F
	protected override void OnAfterShow()
	{
		this.CameraInputComponent.Start();
		this.CameraInputComponent.TryActivate();
	}

	// Token: 0x060115DE RID: 71134 RVA: 0x0043F978 File Offset: 0x0043DB78
	protected override void OnBeforeHide()
	{
		MotorcycleUiModelUtil.Instance.ShowMotor(false);
		this.CameraInputComponent.End();
	}

	// Token: 0x060115DF RID: 71135 RVA: 0x0043F990 File Offset: 0x0043DB90
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x060115E0 RID: 71136 RVA: 0x0043F99C File Offset: 0x0043DB9C
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

	// Token: 0x060115E1 RID: 71137 RVA: 0x0043F9DB File Offset: 0x0043DBDB
	private MotorcycleDiyPresetItem InitPresetScrollItem()
	{
		return new MotorcycleDiyPresetItem
		{
			OnClickToggleBack = new Action<MotorcycleDiyPresetData, int, UUIExtendToggle>(this.OnClickPresetItem)
		};
	}

	// Token: 0x060115E2 RID: 71138 RVA: 0x0043F9F4 File Offset: 0x0043DBF4
	private MotorcycleDiyPresetStickerItem InitStickerScrollItem()
	{
		return new MotorcycleDiyPresetStickerItem();
	}

	// Token: 0x060115E3 RID: 71139 RVA: 0x0043F9FB File Offset: 0x0043DBFB
	private MotorcycleDiyPresetDecorationItem InitDecorateScrollItem()
	{
		return new MotorcycleDiyPresetDecorationItem();
	}

	// Token: 0x060115E4 RID: 71140 RVA: 0x0043FA04 File Offset: 0x0043DC04
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

	// Token: 0x060115E5 RID: 71141 RVA: 0x0043FB1C File Offset: 0x0043DD1C
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

	// Token: 0x060115E6 RID: 71142 RVA: 0x0043FB8C File Offset: 0x0043DD8C
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

	// Token: 0x060115E7 RID: 71143 RVA: 0x0043FD64 File Offset: 0x0043DF64
	private void RefreshStickerPresetInfo(MotorcycleDiyPresetData data)
	{
		List<int> list = data.StickerIds.ToList<int>();
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

	// Token: 0x060115E8 RID: 71144 RVA: 0x0043FE44 File Offset: 0x0043E044
	private void RefreshDecorationPresetInfo(MotorcycleDiyPresetData data)
	{
		List<int> list = data.DecorateIds.ToList<int>();
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

	// Token: 0x060115E9 RID: 71145 RVA: 0x0043FF24 File Offset: 0x0043E124
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

	// Token: 0x060115EA RID: 71146 RVA: 0x0043FFC4 File Offset: 0x0043E1C4
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
		UiCameraInputComponentData data = new UiCameraInputComponentData
		{
			DragComponent = base.GetDraggable(18),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputComponent.InitData(data);
	}

	// Token: 0x060115EB RID: 71147 RVA: 0x0044004C File Offset: 0x0043E24C
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

	// Token: 0x060115EC RID: 71148 RVA: 0x004400C4 File Offset: 0x0043E2C4
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

	// Token: 0x060115ED RID: 71149 RVA: 0x0044011A File Offset: 0x0043E31A
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

	// Token: 0x060115EE RID: 71150 RVA: 0x00440154 File Offset: 0x0043E354
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

	// Token: 0x060115EF RID: 71151 RVA: 0x004401C4 File Offset: 0x0043E3C4
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

	// Token: 0x060115F0 RID: 71152 RVA: 0x0044022C File Offset: 0x0043E42C
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

	// Token: 0x060115F1 RID: 71153 RVA: 0x004402A8 File Offset: 0x0043E4A8
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

	// Token: 0x060115F2 RID: 71154 RVA: 0x004402F0 File Offset: 0x0043E4F0
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

	// Token: 0x060115F3 RID: 71155 RVA: 0x00440358 File Offset: 0x0043E558
	private void OnBtnSaveToNewPresetClick()
	{
		CommonInputViewController.Instance.OpenMotorcycleDiyNameInputView(new Func<string, UniTask<Aki.Protocol.ErrorCode>>(this.OnConfirmRenameForCreate), this.DefaultCustomPresetName);
	}

	// Token: 0x060115F4 RID: 71156 RVA: 0x00440376 File Offset: 0x0043E576
	private void OnBtnEditNameClick()
	{
		CommonInputViewController instance = CommonInputViewController.Instance;
		Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack = new Func<string, UniTask<Aki.Protocol.ErrorCode>>(this.OnConfirmRenameForEdit);
		MotorcycleDiyPresetData curCustomPresetData = this.CurCustomPresetData;
		instance.OpenMotorcycleDiyNameInputView(callBack, ((curCustomPresetData != null) ? curCustomPresetData.Name : null) ?? string.Empty);
	}

	// Token: 0x060115F5 RID: 71157 RVA: 0x004403AC File Offset: 0x0043E5AC
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

	// Token: 0x060115F6 RID: 71158 RVA: 0x004403F8 File Offset: 0x0043E5F8
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

	// Token: 0x060115F7 RID: 71159 RVA: 0x00440444 File Offset: 0x0043E644
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

	// Token: 0x060115F8 RID: 71160 RVA: 0x004404B7 File Offset: 0x0043E6B7
	private void OnCloseClick()
	{
		MotorcycleUiModelUtil.Instance.LoadEquippedMotor(delegate(UiModelBase _)
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x060115F9 RID: 71161 RVA: 0x004404D0 File Offset: 0x0043E6D0
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
		int num;
		int id = int.TryParse(configParams[1], out num) ? num : int.MinValue;
		GenericLayout<MotorcycleDiyPresetItem, MotorcycleDiyPresetData> genericLayout = this.PresetScrollView.GetGenericLayout();
		IReadOnlyList<MotorcycleDiyPresetData> readOnlyList = (genericLayout != null) ? genericLayout.GetDatas() : null;
		if (readOnlyList == null)
		{
			return null;
		}
		int displayIndex = readOnlyList.ToList<MotorcycleDiyPresetData>().FindIndex((MotorcycleDiyPresetData data) => data.OfficialId == id);
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

	// Token: 0x040083F3 RID: 33779
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040083F4 RID: 33780
	[Nullable(2)]
	private MotorcycleDiyPresetItem CurPresetItem;

	// Token: 0x040083F5 RID: 33781
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleDiyPresetItem, MotorcycleDiyPresetData> PresetScrollView;

	// Token: 0x040083F6 RID: 33782
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleDiyPresetStickerItem, MotorcycleDiyEditStickerDecoItemData> StickerScrollView;

	// Token: 0x040083F7 RID: 33783
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleDiyPresetDecorationItem, MotorcycleDiyEditStickerDecoItemData> DecorateScrollView;

	// Token: 0x040083F8 RID: 33784
	[Nullable(2)]
	private UUIExtendToggle CustomToggle;

	// Token: 0x040083F9 RID: 33785
	[Nullable(2)]
	private UUIExtendToggle OfficialToggle;

	// Token: 0x040083FA RID: 33786
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040083FB RID: 33787
	[Nullable(2)]
	private UUIInturnAnimController AnimController;

	// Token: 0x040083FC RID: 33788
	public UiCameraInputComponent CameraInputComponent = new UiCameraInputComponent();

	// Token: 0x040083FD RID: 33789
	private List<int> PresetStickerIds = new List<int>();

	// Token: 0x040083FE RID: 33790
	private List<int> PresetDecorationIds = new List<int>();

	// Token: 0x040083FF RID: 33791
	private int PresetFrameId;

	// Token: 0x04008400 RID: 33792
	[Nullable(2)]
	private MotorcycleDiyPresetData CurCustomPresetData;

	// Token: 0x04008401 RID: 33793
	[Nullable(2)]
	private MotorcycleDiyPresetData TempCreatePresetData;

	// Token: 0x04008402 RID: 33794
	private int CustomPresetDataIndex = -1;

	// Token: 0x04008403 RID: 33795
	private string DefaultCustomPresetName = string.Empty;

	// Token: 0x04008404 RID: 33796
	private int MaxCustomPresetNum;

	// Token: 0x04008405 RID: 33797
	private bool IsNotHidingUi = true;

	// Token: 0x04008406 RID: 33798
	private bool IsEyeActiveFromGamepad;

	// Token: 0x04008407 RID: 33799
	private readonly int[] TwoBtnWidthAndOffsetX = new int[]
	{
		830,
		-490
	};

	// Token: 0x04008408 RID: 33800
	private readonly int[] OneBtnWidthAndOffsetX = new int[]
	{
		637,
		-390
	};

	// Token: 0x02008805 RID: 34821
	[NullableContext(0)]
	private class EMotorDiyPresetComponent
	{
		// Token: 0x0402C32C RID: 181036
		public const int CurPresetItem = 0;

		// Token: 0x0402C32D RID: 181037
		public const int PresetScroll = 1;

		// Token: 0x0402C32E RID: 181038
		public const int PresetContent = 2;

		// Token: 0x0402C32F RID: 181039
		public const int PresetToggle = 3;

		// Token: 0x0402C330 RID: 181040
		public const int PresetTipsItem = 4;

		// Token: 0x0402C331 RID: 181041
		public const int TexFramePartIcon = 5;

		// Token: 0x0402C332 RID: 181042
		public const int TexFrameIcon = 6;

		// Token: 0x0402C333 RID: 181043
		public const int StickerScroll = 7;

		// Token: 0x0402C334 RID: 181044
		public const int StickerContent = 8;

		// Token: 0x0402C335 RID: 181045
		public const int StickerItem = 9;

		// Token: 0x0402C336 RID: 181046
		public const int DecorateScroll = 10;

		// Token: 0x0402C337 RID: 181047
		public const int DecorateContent = 11;

		// Token: 0x0402C338 RID: 181048
		public const int DecorateItem = 12;

		// Token: 0x0402C339 RID: 181049
		public const int BtnImportPreset = 13;

		// Token: 0x0402C33A RID: 181050
		public const int CaptionItem = 14;

		// Token: 0x0402C33B RID: 181051
		public const int PnlFrame = 15;

		// Token: 0x0402C33C RID: 181052
		public const int PnlSticker = 16;

		// Token: 0x0402C33D RID: 181053
		public const int PnlDecorate = 17;

		// Token: 0x0402C33E RID: 181054
		public const int DragComponent = 18;

		// Token: 0x0402C33F RID: 181055
		public const int TogCustomPreset = 19;

		// Token: 0x0402C340 RID: 181056
		public const int TogOfficialPreset = 20;

		// Token: 0x0402C341 RID: 181057
		public const int TxtPresetCount = 21;

		// Token: 0x0402C342 RID: 181058
		public const int PnlEmpty = 22;

		// Token: 0x0402C343 RID: 181059
		public const int BtnCreatePreset = 23;

		// Token: 0x0402C344 RID: 181060
		public const int TogEye = 24;

		// Token: 0x0402C345 RID: 181061
		public const int BtnEditName = 25;

		// Token: 0x0402C346 RID: 181062
		public const int RightBottomBtnLayout = 26;

		// Token: 0x0402C347 RID: 181063
		public const int BtnDeletePreset = 27;

		// Token: 0x0402C348 RID: 181064
		public const int BtnEditPreset = 28;

		// Token: 0x0402C349 RID: 181065
		public const int BtnSaveNewPreset = 29;

		// Token: 0x0402C34A RID: 181066
		public const int PnlMaxTips = 30;

		// Token: 0x0402C34B RID: 181067
		public const int NotHideUIItem = 31;

		// Token: 0x0402C34C RID: 181068
		public const int CurUsePresetName = 32;

		// Token: 0x0402C34D RID: 181069
		public const int PnlCurPreset = 33;

		// Token: 0x0402C34E RID: 181070
		public const int PnlPresetCount = 34;
	}
}
