using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200178B RID: 6027
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyEditRootView : UiViewBase
{
	// Token: 0x0600EA41 RID: 59969 RVA: 0x0044AF12 File Offset: 0x00449112
	public MotorcycleDiyEditRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EA42 RID: 59970 RVA: 0x0044AF40 File Offset: 0x00449140
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

	// Token: 0x0600EA43 RID: 59971 RVA: 0x0044B0D4 File Offset: 0x004492D4
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

	// Token: 0x0600EA44 RID: 59972 RVA: 0x0044B13C File Offset: 0x0044933C
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

	// Token: 0x0600EA45 RID: 59973 RVA: 0x0044B1FC File Offset: 0x004493FC
	protected override void OnBeforeHide()
	{
		MotorcycleUiModelUtil.Instance.ShowMotor(false);
	}

	// Token: 0x0600EA46 RID: 59974 RVA: 0x0044B209 File Offset: 0x00449409
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x0600EA47 RID: 59975 RVA: 0x0044B215 File Offset: 0x00449415
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

	// Token: 0x0600EA48 RID: 59976 RVA: 0x0044B248 File Offset: 0x00449448
	private void InitTabComponent()
	{
		CommonTabComponentData<MotorcycleEditTabItem> data = new CommonTabComponentData<MotorcycleEditTabItem>(new Func<UUIItem, int?, MotorcycleEditTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<MotorcycleEditTabItem>(base.GetItem(1), data, new Action(this.CloseClick), false);
		this.LastClickTime = null;
		this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(2), EKeyMode.Default);
	}

	// Token: 0x0600EA49 RID: 59977 RVA: 0x0044B2D8 File Offset: 0x004494D8
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
		UiCameraInputBindingData uiCameraInputBindingData = new UiCameraInputBindingData();
		uiCameraInputBindingData.DragComponent = base.GetDraggable(6);
		uiCameraInputBindingData.CameraSettingConfig = roleCameraConfig.Value;
		FVectorDouble fvectorDouble = actorWithTag.D_K2_GetActorLocation();
		uiCameraInputBindingData.SourceLocation = fvectorDouble;
		UiCameraInputBindingData data = uiCameraInputBindingData;
		this.CameraInputBinding.Configure(data);
		this.IsInitCameraInput = true;
	}

	// Token: 0x0600EA4A RID: 59978 RVA: 0x0044B36D File Offset: 0x0044956D
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

	// Token: 0x0600EA4B RID: 59979 RVA: 0x0044B388 File Offset: 0x00449588
	private UniTask RefreshTabListAsync()
	{
		MotorcycleDiyEditRootView.<RefreshTabListAsync>d__26 <RefreshTabListAsync>d__;
		<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabListAsync>d__.<>4__this = this;
		<RefreshTabListAsync>d__.<>1__state = -1;
		<RefreshTabListAsync>d__.<>t__builder.Start<MotorcycleDiyEditRootView.<RefreshTabListAsync>d__26>(ref <RefreshTabListAsync>d__);
		return <RefreshTabListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EA4C RID: 59980 RVA: 0x0044B3CC File Offset: 0x004495CC
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

	// Token: 0x0600EA4D RID: 59981 RVA: 0x0044B420 File Offset: 0x00449620
	private bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int value = ConfigCommonParamById.GetIntConfig("panel_interval_time").Value;
		return this.LastClickTime == null || Time.Instance.Now - this.LastClickTime.Value >= (double)value;
	}

	// Token: 0x0600EA4E RID: 59982 RVA: 0x0044B47C File Offset: 0x0044967C
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

	// Token: 0x0600EA4F RID: 59983 RVA: 0x0044B520 File Offset: 0x00449720
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x0600EA50 RID: 59984 RVA: 0x0044B558 File Offset: 0x00449758
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

	// Token: 0x0600EA51 RID: 59985 RVA: 0x0044B5CC File Offset: 0x004497CC
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

	// Token: 0x0600EA52 RID: 59986 RVA: 0x0044B65C File Offset: 0x0044985C
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

	// Token: 0x0600EA53 RID: 59987 RVA: 0x0044B698 File Offset: 0x00449898
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

	// Token: 0x0600EA54 RID: 59988 RVA: 0x0044B6F4 File Offset: 0x004498F4
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

	// Token: 0x0600EA55 RID: 59989 RVA: 0x0044B740 File Offset: 0x00449940
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

	// Token: 0x0600EA56 RID: 59990 RVA: 0x0044B783 File Offset: 0x00449983
	private void RemoveMaskTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600EA57 RID: 59991 RVA: 0x0044B7A8 File Offset: 0x004499A8
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

	// Token: 0x0600EA58 RID: 59992 RVA: 0x0044B814 File Offset: 0x00449A14
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
		if (this.IsNotHidingUi)
		{
			this.CameraInputBinding.Unbind();
		}
		else
		{
			this.CameraInputBinding.Bind();
		}
		UiCameraModel.Instance.PushCameraHandleByHandleName(handleName, true, true, "1001", false, null);
	}

	// Token: 0x0600EA59 RID: 59993 RVA: 0x0044B9ED File Offset: 0x00449BED
	private void OnTabCameraClick(int partIndex)
	{
		this.CurSelectPart = partIndex;
		this.PushPartCameraHandle(partIndex);
		this.StartMaskTimer();
	}

	// Token: 0x0600EA5A RID: 59994 RVA: 0x0044BA03 File Offset: 0x00449C03
	private void OnSelectItemClick(EOutlookType itemType, int itemPart, int itemId)
	{
		this.CheckBtnEnable(itemType, itemPart, itemId);
	}

	// Token: 0x0600EA5B RID: 59995 RVA: 0x0044BA10 File Offset: 0x00449C10
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

	// Token: 0x0600EA5C RID: 59996 RVA: 0x0044BAF0 File Offset: 0x00449CF0
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

	// Token: 0x0600EA5D RID: 59997 RVA: 0x0044BB22 File Offset: 0x00449D22
	private void OnTogChangeCameraPosClick(EToggleState toggleState)
	{
		this.IsPartDefaultCam = !this.IsPartDefaultCam;
		this.PushPartCameraHandle(3);
		this.StartMaskTimer();
	}

	// Token: 0x0600EA5E RID: 59998 RVA: 0x0044BB40 File Offset: 0x00449D40
	private void OnBtnMotorDiySaveClick()
	{
		this.CreateOrSaveDiyOutlookRequest();
	}

	// Token: 0x0600EA5F RID: 59999 RVA: 0x0044BB48 File Offset: 0x00449D48
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
			this.CameraInputBinding.Unbind();
		}
		else
		{
			base.PlaySequence("UiOut", delegate
			{
				this.GetItem(0).SetUIActive(state);
			}, true);
			this.CameraInputBinding.Bind();
		}
		base.GetItem(0).SetUIActive(state);
		this.PushPartCameraHandle(this.CurSelectPart);
	}

	// Token: 0x0600EA60 RID: 60000 RVA: 0x0044BC10 File Offset: 0x00449E10
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

	// Token: 0x0600EA61 RID: 60001 RVA: 0x0044BCA3 File Offset: 0x00449EA3
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

	// Token: 0x04008522 RID: 34082
	private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x04008523 RID: 34083
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<MotorcycleEditTabItem> TabComponent;

	// Token: 0x04008524 RID: 34084
	[Nullable(2)]
	private TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x04008525 RID: 34085
	private double? LastClickTime;

	// Token: 0x04008526 RID: 34086
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04008527 RID: 34087
	public UiCameraInputBinding CameraInputBinding = new UiCameraInputBinding();

	// Token: 0x04008528 RID: 34088
	private bool IsNotHidingUi = true;

	// Token: 0x04008529 RID: 34089
	private bool IsPartDefaultCam = true;

	// Token: 0x0400852A RID: 34090
	private EUiTabViewName? CurSelectTabView;

	// Token: 0x0400852B RID: 34091
	private int CurSelectPart;

	// Token: 0x0400852C RID: 34092
	private int OriginPartTabIndex;

	// Token: 0x0400852D RID: 34093
	private bool IsInitCameraInput;

	// Token: 0x0400852E RID: 34094
	private bool IsModifyPreset;

	// Token: 0x0400852F RID: 34095
	[Nullable(2)]
	private MotorcycleDiyPresetData LocalPresetData;

	// Token: 0x04008530 RID: 34096
	private EMotorcycleDiyCustomMode? CustomMode;

	// Token: 0x02007983 RID: 31107
	[NullableContext(0)]
	private class EMotorDiyRootComponent
	{
		// Token: 0x0402760C RID: 161292
		public const int NotHideUIItem = 0;

		// Token: 0x0402760D RID: 161293
		public const int CaptainItem = 1;

		// Token: 0x0402760E RID: 161294
		public const int ContentItem = 2;

		// Token: 0x0402760F RID: 161295
		public const int TogMotorDiyChange = 3;

		// Token: 0x04027610 RID: 161296
		public const int BtnMotorSaveOld = 4;

		// Token: 0x04027611 RID: 161297
		public const int TogEye = 5;

		// Token: 0x04027612 RID: 161298
		public const int DragComponent = 6;

		// Token: 0x04027613 RID: 161299
		public const int BtnMotorSave = 7;
	}
}
