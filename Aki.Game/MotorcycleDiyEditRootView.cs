using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022A7 RID: 8871
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyEditRootView : UiViewBase
{
	// Token: 0x060115A9 RID: 71081 RVA: 0x0043E31E File Offset: 0x0043C51E
	public MotorcycleDiyEditRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060115AA RID: 71082 RVA: 0x0043E34C File Offset: 0x0043C54C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIDraggableComponent));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnTogChangeCameraPosClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnTogEyeClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnBtnMotorDiySaveClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060115AB RID: 71083 RVA: 0x0043E4E0 File Offset: 0x0043C6E0
	protected override void OnStart()
	{
		IOpenMotorcycleDiyRootViewData openMotorcycleDiyRootViewData = this.OpenParam as IOpenMotorcycleDiyRootViewData;
		if (openMotorcycleDiyRootViewData != null)
		{
			this.CurSelectTabView = openMotorcycleDiyRootViewData.OpenTabView;
			this.LocalPresetData = openMotorcycleDiyRootViewData.PresetData;
			this.CustomMode = openMotorcycleDiyRootViewData.CustomMode;
		}
		this.InitTabComponent();
		base.GetButton(7).RootUIComp.Get().SetUIActive(true);
		this.AddHomeBtnExtraCallback();
	}

	// Token: 0x060115AC RID: 71084 RVA: 0x0043E548 File Offset: 0x0043C748
	protected override void OnBeforeShow()
	{
		this.RefreshTabListAsync();
		this.InitCameraInputData();
		MotorcycleUiModelUtil.Instance.ShowMotor(true);
		if (this.TabViewComponent != null)
		{
			IMotorcycleDiyTabViewRegister motorcycleDiyTabViewRegister = this.TabViewComponent.GetCurrentTabView() as IMotorcycleDiyTabViewRegister;
			if (motorcycleDiyTabViewRegister != null)
			{
				motorcycleDiyTabViewRegister.RefreshItemScrollView();
				Action<int> onTabCameraClick = motorcycleDiyTabViewRegister.OnTabCameraClick;
				if (onTabCameraClick != null)
				{
					onTabCameraClick(this.CurSelectPart);
				}
			}
		}
		if (MotorcycleUiModelUtil.Instance.IsMotorCreated())
		{
			int selectedFrameId = MotorcycleDiyModel.Instance.GetSelectedFrameId();
			List<int> selectedStickerIdList = MotorcycleDiyModel.Instance.GetSelectedStickerIdList(false);
			List<int> selectedDecorationIdList = MotorcycleDiyModel.Instance.GetSelectedDecorationIdList(false);
			MotorcycleUiModelParam param = new MotorcycleUiModelParam
			{
				FrameId = selectedFrameId,
				StickerIds = selectedStickerIdList.ToArray(),
				DecorationIds = selectedDecorationIdList.ToArray()
			};
			MotorcycleUiModelUtil.Instance.LoadMotorByParam(param, null);
		}
	}

	// Token: 0x060115AD RID: 71085 RVA: 0x0043E608 File Offset: 0x0043C808
	protected override void OnBeforeHide()
	{
		MotorcycleUiModelUtil.Instance.ShowMotor(false);
	}

	// Token: 0x060115AE RID: 71086 RVA: 0x0043E615 File Offset: 0x0043C815
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x060115AF RID: 71087 RVA: 0x0043E621 File Offset: 0x0043C821
	protected override void OnBeforeDestroy()
	{
		TabComponentWithCaptionItem<MotorcycleEditTabItem> tabComponent = this.TabComponent;
		if (tabComponent != null)
		{
			tabComponent.Destroy(null);
		}
		this.TabComponent = null;
		TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
		if (tabViewComponent != null)
		{
			tabViewComponent.DestroyTabViewComponent();
		}
		this.TabViewComponent = null;
	}

	// Token: 0x060115B0 RID: 71088 RVA: 0x0043E654 File Offset: 0x0043C854
	private void InitTabComponent()
	{
		CommonTabComponentData<MotorcycleEditTabItem> data = new CommonTabComponentData<MotorcycleEditTabItem>(new Func<UUIItem, int?, MotorcycleEditTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<MotorcycleEditTabItem>(base.GetItem(1), data, new Action(this.CloseClick), false);
		this.LastClickTime = null;
		this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(2), EKeyMode.Default);
	}

	// Token: 0x060115B1 RID: 71089 RVA: 0x0043E6E4 File Offset: 0x0043C8E4
	private void InitCameraInputData()
	{
		if (this.IsInitCameraInput)
		{
			return;
		}
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig("摩托车贴纸界面");
		if (roleCameraConfig == null)
		{
			return;
		}
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("RoleCase").Value, ECollectActorType.UI);
		if (actorWithTag == null)
		{
			return;
		}
		UiCameraInputComponentData uiCameraInputComponentData = new UiCameraInputComponentData();
		uiCameraInputComponentData.DragComponent = base.GetDraggable(6);
		uiCameraInputComponentData.CameraSettingConfig = roleCameraConfig.Value;
		FVectorDouble fvectorDouble = actorWithTag.D_K2_GetActorLocation();
		uiCameraInputComponentData.SourceLocation = fvectorDouble;
		UiCameraInputComponentData data = uiCameraInputComponentData;
		this.CameraInputComponent.InitData(data);
		this.IsInitCameraInput = true;
	}

	// Token: 0x060115B2 RID: 71090 RVA: 0x0043E779 File Offset: 0x0043C979
	private MotorcycleEditTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleEditTabItem
		{
			OnRegisterViewCallback = delegate(UiTabViewBase view)
			{
				IMotorcycleDiyEditTabViewRegister motorcycleDiyEditTabViewRegister = view as IMotorcycleDiyEditTabViewRegister;
				if (motorcycleDiyEditTabViewRegister != null)
				{
					motorcycleDiyEditTabViewRegister.OnTabCameraClick = new Action<int>(this.OnTabCameraClick);
					motorcycleDiyEditTabViewRegister.OnSelectItemClick = new Action<EOutlookType, int, int>(this.OnSelectItemClick);
					motorcycleDiyEditTabViewRegister.GetLocalPresetData = new Func<MotorcycleDiyPresetData>(this.GetLocalPresetData);
					motorcycleDiyEditTabViewRegister.OnEditPresetChanged = new Action<EOutlookType, bool>(this.OnEditPresetChanged);
				}
			}
		};
	}

	// Token: 0x060115B3 RID: 71091 RVA: 0x0043E794 File Offset: 0x0043C994
	private UniTask RefreshTabListAsync()
	{
		MotorcycleDiyEditRootView.<RefreshTabListAsync>d__26 <RefreshTabListAsync>d__;
		<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabListAsync>d__.<>4__this = this;
		<RefreshTabListAsync>d__.<>1__state = -1;
		<RefreshTabListAsync>d__.<>t__builder.Start<MotorcycleDiyEditRootView.<RefreshTabListAsync>d__26>(ref <RefreshTabListAsync>d__);
		return <RefreshTabListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060115B4 RID: 71092 RVA: 0x0043E7D8 File Offset: 0x0043C9D8
	public void SwitchToTabPart(EUiTabViewName tabViewName, int? partTabIndex = null)
	{
		int num = this.TabDataList.FindIndex((UiDynamicTab data) => (EUiTabViewName)data.ChildViewName == tabViewName);
		if (num == -1)
		{
			return;
		}
		this.CurSelectPart = partTabIndex.GetValueOrDefault();
		this.TabComponent.SelectToggleByIndex(num, false);
	}

	// Token: 0x060115B5 RID: 71093 RVA: 0x0043E82C File Offset: 0x0043CA2C
	private bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int value = ConfigCommonParamById.GetIntConfig("panel_interval_time").Value;
		return this.LastClickTime == null || Time.Instance.Now - this.LastClickTime.Value >= (double)value;
	}

	// Token: 0x060115B6 RID: 71094 RVA: 0x0043E888 File Offset: 0x0043CA88
	private void ToggleCallBack(int index)
	{
		this.LastClickTime = new double?(Time.Instance.Now);
		UiDynamicTab data = this.TabDataList[index];
		EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
		MotorcycleEditTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		if (this.OriginPartTabIndex > 0)
		{
			this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, this.OriginPartTabIndex, null);
			this.OriginPartTabIndex = 0;
		}
		else
		{
			this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, null, null);
		}
		this.CurSelectTabView = new EUiTabViewName?(euiTabViewName);
	}

	// Token: 0x060115B7 RID: 71095 RVA: 0x0043E92C File Offset: 0x0043CB2C
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x060115B8 RID: 71096 RVA: 0x0043E964 File Offset: 0x0043CB64
	private void CheckBtnEnable(EOutlookType itemType, int itemPart, int itemId)
	{
		bool flag = itemType == EOutlookType.Sticker;
		base.GetExtendToggle(3).RootUIComp.Get().SetUIActive(flag && itemPart == 3);
		bool flag2 = this.IsPresetModified();
		EMotorcycleDiyCustomMode? customMode = this.CustomMode;
		EMotorcycleDiyCustomMode emotorcycleDiyCustomMode = EMotorcycleDiyCustomMode.NewCreate;
		bool flag3 = customMode.GetValueOrDefault() == emotorcycleDiyCustomMode & customMode != null;
		base.GetButton(7).SetSelfInteractive(flag2 || flag3);
		this.IsModifyPreset = flag2;
	}

	// Token: 0x060115B9 RID: 71097 RVA: 0x0043E9D8 File Offset: 0x0043CBD8
	private bool IsPresetModified()
	{
		if (this.LocalPresetData == null)
		{
			return false;
		}
		MotorcycleDiyModel instance = MotorcycleDiyModel.Instance;
		List<int> selectedStickerIdList = instance.GetSelectedStickerIdList(false);
		List<int> selectedDecorationIdList = instance.GetSelectedDecorationIdList(false);
		int selectedFrameId = instance.GetSelectedFrameId();
		int[] listB = this.LocalPresetData.StickerIds ?? new int[0];
		int[] listB2 = this.LocalPresetData.DecorateIds ?? new int[0];
		int frameId = this.LocalPresetData.FrameId;
		return !this.IsSameIdList(selectedStickerIdList, listB) || !this.IsSameIdList(selectedDecorationIdList, listB2) || selectedFrameId != frameId;
	}

	// Token: 0x060115BA RID: 71098 RVA: 0x0043EA68 File Offset: 0x0043CC68
	private bool IsSameIdList(List<int> listA, int[] listB)
	{
		if (listA.Count != listB.Length)
		{
			return false;
		}
		for (int i = 0; i < listA.Count; i++)
		{
			if (listA[i] != listB[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060115BB RID: 71099 RVA: 0x0043EAA4 File Offset: 0x0043CCA4
	private void CreateOrSaveDiyOutlookRequest()
	{
		EMotorcycleDiyCustomMode? customMode = this.CustomMode;
		EMotorcycleDiyCustomMode emotorcycleDiyCustomMode = EMotorcycleDiyCustomMode.NewCreate;
		if (customMode.GetValueOrDefault() == emotorcycleDiyCustomMode & customMode != null)
		{
			this.CreateDiyOutlookRequestAsync(false).ContinueWith(delegate(bool isSuccess)
			{
				if (!isSuccess)
				{
					return;
				}
				ScrollingTipsController.Instance.ShowTipsByTextId("DIYProjectTips02", Array.Empty<object>());
				base.CloseMe(null);
			});
			return;
		}
		this.SaveDiyOutlookRequestAsync().ContinueWith(delegate(bool isSuccess)
		{
			if (!isSuccess)
			{
				return;
			}
			base.GetButton(7).SetSelfInteractive(false);
			this.IsModifyPreset = false;
			ScrollingTipsController.Instance.ShowTipsByTextId("DIYProjectTips04", Array.Empty<object>());
			base.CloseMe(null);
		});
	}

	// Token: 0x060115BC RID: 71100 RVA: 0x0043EB00 File Offset: 0x0043CD00
	[NullableContext(0)]
	private UniTask<bool> CreateDiyOutlookRequestAsync(bool isHome = false)
	{
		MotorcycleDiyEditRootView.<CreateDiyOutlookRequestAsync>d__35 <CreateDiyOutlookRequestAsync>d__;
		<CreateDiyOutlookRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<CreateDiyOutlookRequestAsync>d__.<>4__this = this;
		<CreateDiyOutlookRequestAsync>d__.isHome = isHome;
		<CreateDiyOutlookRequestAsync>d__.<>1__state = -1;
		<CreateDiyOutlookRequestAsync>d__.<>t__builder.Start<MotorcycleDiyEditRootView.<CreateDiyOutlookRequestAsync>d__35>(ref <CreateDiyOutlookRequestAsync>d__);
		return <CreateDiyOutlookRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060115BD RID: 71101 RVA: 0x0043EB4C File Offset: 0x0043CD4C
	[NullableContext(0)]
	private UniTask<bool> SaveDiyOutlookRequestAsync()
	{
		MotorcycleDiyEditRootView.<SaveDiyOutlookRequestAsync>d__36 <SaveDiyOutlookRequestAsync>d__;
		<SaveDiyOutlookRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SaveDiyOutlookRequestAsync>d__.<>4__this = this;
		<SaveDiyOutlookRequestAsync>d__.<>1__state = -1;
		<SaveDiyOutlookRequestAsync>d__.<>t__builder.Start<MotorcycleDiyEditRootView.<SaveDiyOutlookRequestAsync>d__36>(ref <SaveDiyOutlookRequestAsync>d__);
		return <SaveDiyOutlookRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060115BE RID: 71102 RVA: 0x0043EB8F File Offset: 0x0043CD8F
	private void RemoveMaskTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x060115BF RID: 71103 RVA: 0x0043EBB4 File Offset: 0x0043CDB4
	private void StartMaskTimer()
	{
		this.RemoveMaskTimer();
		float? floatConfig = ConfigCommonParamById.GetFloatConfig("MotorDiyChangeBPartDelay");
		if (floatConfig != null)
		{
			UiLayer.Instance.SetShowMaskLayer("DiyChangeBPartPos", true);
			this.TimerHandle = TimerSystem.RealTimeInstance.Delay(delegate(float _)
			{
				this.RemoveMaskTimer();
				UiLayer.Instance.SetShowMaskLayer("DiyChangeBPartPos", false);
			}, (float)((int)(floatConfig.Value * 1000f)), null, null, true, 1f);
		}
	}

	// Token: 0x060115C0 RID: 71104 RVA: 0x0043EC20 File Offset: 0x0043CE20
	private void PushPartCameraHandle(int partTabIndex)
	{
		MotorFramePart? motorFramePart = null;
		MotorStickerPart? motorStickerPart = null;
		MotorDecorationsPart? motorDecorationsPart = null;
		if (this.CurSelectTabView == EUiTabViewName.MotorcycleDiyEditFrameTabView)
		{
			motorFramePart = MotorDiyConfig.Instance.GetMotorFramePartConfig();
		}
		else if (this.CurSelectTabView == EUiTabViewName.MotorcycleDiyEditStickerTabView && partTabIndex > 0)
		{
			motorStickerPart = MotorDiyConfig.Instance.GetMotorStickerPartConfig(partTabIndex);
		}
		else if (this.CurSelectTabView == EUiTabViewName.MotorcycleDiyEditDecorationTabView && partTabIndex > 0)
		{
			motorDecorationsPart = MotorDiyConfig.Instance.GetMotorDecorationPartConfig(partTabIndex);
		}
		string[] array = null;
		string[] array2 = null;
		if (motorFramePart != null)
		{
			array = motorFramePart.Value.CameraIds();
			array2 = motorFramePart.Value.DetailCameraIds();
		}
		else if (motorStickerPart != null)
		{
			array = motorStickerPart.Value.CameraIds();
			array2 = motorStickerPart.Value.DetailCameraIds();
		}
		else if (motorDecorationsPart != null)
		{
			array = motorDecorationsPart.Value.CameraIds();
			array2 = motorDecorationsPart.Value.DetailCameraIds();
		}
		if (array == null || array.Length == 0)
		{
			return;
		}
		string[] array3 = this.IsNotHidingUi ? array : (array2 ?? array);
		string handleName = array3[0];
		if (partTabIndex == 3 && array3.Length > 1)
		{
			handleName = (this.IsPartDefaultCam ? array3[0] : array3[1]);
		}
		this.CameraInputComponent.CanCameraInput = !this.IsNotHidingUi;
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(handleName, true, true, "1001", false, null, null);
	}

	// Token: 0x060115C1 RID: 71105 RVA: 0x0043EDF7 File Offset: 0x0043CFF7
	private void OnTabCameraClick(int partIndex)
	{
		this.CurSelectPart = partIndex;
		this.PushPartCameraHandle(partIndex);
		this.StartMaskTimer();
	}

	// Token: 0x060115C2 RID: 71106 RVA: 0x0043EE0D File Offset: 0x0043D00D
	private void OnSelectItemClick(EOutlookType itemType, int itemPart, int itemId)
	{
		this.CheckBtnEnable(itemType, itemPart, itemId);
	}

	// Token: 0x060115C3 RID: 71107 RVA: 0x0043EE18 File Offset: 0x0043D018
	private void OnEditPresetChanged(EOutlookType outlookType, bool isModified)
	{
		if (this.TabComponent == null || this.TabDataList.Count == 0)
		{
			return;
		}
		EUiTabViewName? euiTabViewName;
		switch (outlookType)
		{
		case EOutlookType.Frame:
			euiTabViewName = new EUiTabViewName?(EUiTabViewName.MotorcycleDiyEditFrameTabView);
			break;
		case EOutlookType.Sticker:
			euiTabViewName = new EUiTabViewName?(EUiTabViewName.MotorcycleDiyEditStickerTabView);
			break;
		case EOutlookType.Decoration:
			euiTabViewName = new EUiTabViewName?(EUiTabViewName.MotorcycleDiyEditDecorationTabView);
			break;
		default:
			euiTabViewName = null;
			break;
		}
		EUiTabViewName? euiTabViewName2 = euiTabViewName;
		if (euiTabViewName2 == null)
		{
			return;
		}
		int i = 0;
		while (i < this.TabDataList.Count)
		{
			if ((EUiTabViewName)this.TabDataList[i].ChildViewName == euiTabViewName2)
			{
				MotorcycleEditTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(i);
				if (tabItemByIndex == null)
				{
					return;
				}
				tabItemByIndex.SetSubRedDotVisible(isModified);
				return;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x060115C4 RID: 71108 RVA: 0x0043EEF8 File Offset: 0x0043D0F8
	[NullableContext(2)]
	private MotorcycleDiyPresetData GetLocalPresetData()
	{
		EMotorcycleDiyCustomMode? customMode = this.CustomMode;
		EMotorcycleDiyCustomMode emotorcycleDiyCustomMode = EMotorcycleDiyCustomMode.NewCreate;
		if (customMode.GetValueOrDefault() == emotorcycleDiyCustomMode & customMode != null)
		{
			return null;
		}
		return this.LocalPresetData;
	}

	// Token: 0x060115C5 RID: 71109 RVA: 0x0043EF2A File Offset: 0x0043D12A
	private void OnTogChangeCameraPosClick(EToggleState toggleState)
	{
		this.IsPartDefaultCam = !this.IsPartDefaultCam;
		this.PushPartCameraHandle(3);
		this.StartMaskTimer();
	}

	// Token: 0x060115C6 RID: 71110 RVA: 0x0043EF48 File Offset: 0x0043D148
	private void OnBtnMotorDiySaveClick()
	{
		this.CreateOrSaveDiyOutlookRequest();
	}

	// Token: 0x060115C7 RID: 71111 RVA: 0x0043EF50 File Offset: 0x0043D150
	private void OnTogEyeClick(EToggleState toggleState)
	{
		this.IsNotHidingUi = !this.IsNotHidingUi;
		bool state = this.IsNotHidingUi;
		if (state)
		{
			base.GetItem(0).SetUIActive(state);
			base.PlaySequence("UiIn", delegate
			{
			}, true);
			this.CameraInputComponent.End();
		}
		else
		{
			base.PlaySequence("UiOut", delegate
			{
				this.GetItem(0).SetUIActive(state);
			}, true);
			this.CameraInputComponent.Start();
			this.CameraInputComponent.TryActivate();
		}
		base.GetItem(0).SetUIActive(state);
		this.PushPartCameraHandle(this.CurSelectPart);
	}

	// Token: 0x060115C8 RID: 71112 RVA: 0x0043F024 File Offset: 0x0043D224
	protected void CloseClick()
	{
		EMotorcycleDiyCustomMode? customMode = this.CustomMode;
		EMotorcycleDiyCustomMode emotorcycleDiyCustomMode = EMotorcycleDiyCustomMode.NewCreate;
		bool flag = customMode.GetValueOrDefault() == emotorcycleDiyCustomMode & customMode != null;
		if (this.IsModifyPreset || flag)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(flag ? EConfirmBoxConfigId.MotorDiyNewPresetConfirm : EConfirmBoxConfigId.MotorDiyChangePresetConfirm);
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				MotorcycleUiModelParam param = new MotorcycleUiModelParam
				{
					FrameId = this.LocalPresetData.FrameId,
					StickerIds = (this.LocalPresetData.StickerIds ?? new int[0]),
					DecorationIds = (this.LocalPresetData.DecorateIds ?? new int[0])
				};
				MotorcycleUiModelUtil.Instance.LoadMotorByParam(param, delegate(UiModelBase _)
				{
					base.CloseMe(null);
				});
			};
			confirmBoxDataNew.FunctionMap[2] = new Action(this.CreateOrSaveDiyOutlookRequest);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x060115C9 RID: 71113 RVA: 0x0043F0B7 File Offset: 0x0043D2B7
	private void AddHomeBtnExtraCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			MotorcycleDiyEditRootView.<<AddHomeBtnExtraCallback>b__48_0>d <<AddHomeBtnExtraCallback>b__48_0>d;
			<<AddHomeBtnExtraCallback>b__48_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExtraCallback>b__48_0>d.<>4__this = this;
			<<AddHomeBtnExtraCallback>b__48_0>d.<>1__state = -1;
			<<AddHomeBtnExtraCallback>b__48_0>d.<>t__builder.Start<MotorcycleDiyEditRootView.<<AddHomeBtnExtraCallback>b__48_0>d>(ref <<AddHomeBtnExtraCallback>b__48_0>d);
			return <<AddHomeBtnExtraCallback>b__48_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x040083E4 RID: 33764
	private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x040083E5 RID: 33765
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<MotorcycleEditTabItem> TabComponent;

	// Token: 0x040083E6 RID: 33766
	[Nullable(2)]
	private TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x040083E7 RID: 33767
	private double? LastClickTime;

	// Token: 0x040083E8 RID: 33768
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x040083E9 RID: 33769
	public UiCameraInputComponent CameraInputComponent = new UiCameraInputComponent();

	// Token: 0x040083EA RID: 33770
	private bool IsNotHidingUi = true;

	// Token: 0x040083EB RID: 33771
	private bool IsPartDefaultCam = true;

	// Token: 0x040083EC RID: 33772
	private EUiTabViewName? CurSelectTabView;

	// Token: 0x040083ED RID: 33773
	private int CurSelectPart;

	// Token: 0x040083EE RID: 33774
	private int OriginPartTabIndex;

	// Token: 0x040083EF RID: 33775
	private bool IsInitCameraInput;

	// Token: 0x040083F0 RID: 33776
	private bool IsModifyPreset;

	// Token: 0x040083F1 RID: 33777
	[Nullable(2)]
	private MotorcycleDiyPresetData LocalPresetData;

	// Token: 0x040083F2 RID: 33778
	private EMotorcycleDiyCustomMode? CustomMode;

	// Token: 0x020087FB RID: 34811
	[NullableContext(0)]
	private class EMotorDiyRootComponent
	{
		// Token: 0x0402C302 RID: 180994
		public const int NotHideUIItem = 0;

		// Token: 0x0402C303 RID: 180995
		public const int CaptainItem = 1;

		// Token: 0x0402C304 RID: 180996
		public const int ContentItem = 2;

		// Token: 0x0402C305 RID: 180997
		public const int TogMotorDiyChange = 3;

		// Token: 0x0402C306 RID: 180998
		public const int BtnMotorSaveOld = 4;

		// Token: 0x0402C307 RID: 180999
		public const int TogEye = 5;

		// Token: 0x0402C308 RID: 181000
		public const int DragComponent = 6;

		// Token: 0x0402C309 RID: 181001
		public const int BtnMotorSave = 7;
	}
}
