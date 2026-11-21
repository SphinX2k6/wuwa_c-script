using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001791 RID: 6033
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyRootView : UiViewBase
{
	// Token: 0x0600EABD RID: 60093 RVA: 0x0044E332 File Offset: 0x0044C532
	public MotorcycleDiyRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EABE RID: 60094 RVA: 0x0044E360 File Offset: 0x0044C560
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(6, typeof(UUIDraggableComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnTogChangeCameraPosClick)),
			new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnTogEyeClick))
		};
	}

	// Token: 0x0600EABF RID: 60095 RVA: 0x0044E450 File Offset: 0x0044C650
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyRootView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyRootView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EAC0 RID: 60096 RVA: 0x0044E494 File Offset: 0x0044C694
	protected override void OnHandleLoadScene()
	{
		int selectedFrameId = MotorcycleDiyModel.Instance.GetSelectedFrameId();
		List<int> selectedStickerIdList = MotorcycleDiyModel.Instance.GetSelectedStickerIdList(false);
		List<int> selectedDecorationIdList = MotorcycleDiyModel.Instance.GetSelectedDecorationIdList(false);
		MotorcycleUiModelUtil.Instance.CreateMotor(EUiModelUseWay.MotorInMotorView);
		MotorcycleUiModelParam param = new MotorcycleUiModelParam
		{
			FrameId = selectedFrameId,
			StickerIds = selectedStickerIdList.ToArray(),
			DecorationIds = selectedDecorationIdList.ToArray()
		};
		MotorcycleUiModelUtil.Instance.LoadMotorByParam(param, null);
	}

	// Token: 0x0600EAC1 RID: 60097 RVA: 0x0044E504 File Offset: 0x0044C704
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

	// Token: 0x0600EAC2 RID: 60098 RVA: 0x0044E5C4 File Offset: 0x0044C7C4
	protected override void OnBeforeHide()
	{
		UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Normal);
		EUiViewName? euiViewName;
		if (topView == null)
		{
			euiViewName = null;
		}
		else
		{
			UiViewInfo viewInfo = topView.ViewInfo;
			euiViewName = ((viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null);
		}
		if (euiViewName != EUiViewName.MotorcycleRootView)
		{
			MotorcycleUiModelUtil.Instance.ClearMotorBuff();
		}
		MotorcycleUiModelUtil.Instance.ShowMotor(false);
	}

	// Token: 0x0600EAC3 RID: 60099 RVA: 0x0044E640 File Offset: 0x0044C840
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x0600EAC4 RID: 60100 RVA: 0x0044E64C File Offset: 0x0044C84C
	protected override void OnBeforeDestroy()
	{
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
		if (this.TabViewComponent != null)
		{
			this.TabViewComponent.DestroyTabViewComponent();
			this.TabViewComponent = null;
		}
	}

	// Token: 0x0600EAC5 RID: 60101 RVA: 0x0044E683 File Offset: 0x0044C883
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnRootUpdate));
	}

	// Token: 0x0600EAC6 RID: 60102 RVA: 0x0044E6A1 File Offset: 0x0044C8A1
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnRootUpdate));
	}

	// Token: 0x0600EAC7 RID: 60103 RVA: 0x0044E6C0 File Offset: 0x0044C8C0
	protected void InitTabComponent()
	{
		CommonTabComponentData<MotorcycleTabItem> data = new CommonTabComponentData<MotorcycleTabItem>(new Func<UUIItem, int?, MotorcycleTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<MotorcycleTabItem>(base.GetItem(1), data, new Action(this.CloseClick), false);
		this.LastClickTime = null;
		this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(2), EKeyMode.Default);
	}

	// Token: 0x0600EAC8 RID: 60104 RVA: 0x0044E750 File Offset: 0x0044C950
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
		FVectorDouble fvectorDouble = actorWithTag.D_K2_GetActorLocation();
		UiCameraInputBindingData data = new UiCameraInputBindingData
		{
			DragComponent = base.GetDraggable(6),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputBinding.Configure(data);
		this.IsInitCameraInput = true;
	}

	// Token: 0x0600EAC9 RID: 60105 RVA: 0x0044E7E5 File Offset: 0x0044C9E5
	private MotorcycleTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleTabItem
		{
			OnRegisterViewCallback = delegate(UiTabViewBase view)
			{
				IMotorcycleDiyTabViewRegister motorcycleDiyTabViewRegister = view as IMotorcycleDiyTabViewRegister;
				if (motorcycleDiyTabViewRegister != null)
				{
					motorcycleDiyTabViewRegister.OnTabCameraClick = new Action<int>(this.OnTabCameraClick);
					motorcycleDiyTabViewRegister.OnSelectItemClick = new Action<EOutlookType, int, int>(this.OnSelectItemClick);
				}
			}
		};
	}

	// Token: 0x0600EACA RID: 60106 RVA: 0x0044E7FE File Offset: 0x0044C9FE
	private void OnTabCameraClick(int partIndex)
	{
		this.CurSelectPart = partIndex;
		this.PushPartCameraHandle(partIndex);
		this.StartMaskTimer();
	}

	// Token: 0x0600EACB RID: 60107 RVA: 0x0044E814 File Offset: 0x0044CA14
	protected UniTask RefreshTabListAsync()
	{
		MotorcycleDiyRootView.<RefreshTabListAsync>d__29 <RefreshTabListAsync>d__;
		<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabListAsync>d__.<>4__this = this;
		<RefreshTabListAsync>d__.<>1__state = -1;
		<RefreshTabListAsync>d__.<>t__builder.Start<MotorcycleDiyRootView.<RefreshTabListAsync>d__29>(ref <RefreshTabListAsync>d__);
		return <RefreshTabListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EACC RID: 60108 RVA: 0x0044E858 File Offset: 0x0044CA58
	private bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int value = ConfigCommonParamById.GetIntConfig("panel_interval_time").Value;
		return this.LastClickTime == null || Time.Instance.Now - this.LastClickTime.Value >= (double)value;
	}

	// Token: 0x0600EACD RID: 60109 RVA: 0x0044E8B0 File Offset: 0x0044CAB0
	private void ToggleCallBack(int index)
	{
		this.LastClickTime = new double?(Time.Instance.Now);
		UiDynamicTab data = this.TabDataList[index];
		EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
		MotorcycleTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		this.CurSelectTabView = new EUiTabViewName?(euiTabViewName);
		if (this.OriginPartTabIndex > 0)
		{
			this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, this.OriginPartTabIndex, null);
			this.OriginPartTabIndex = 0;
			return;
		}
		this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, null, null);
	}

	// Token: 0x0600EACE RID: 60110 RVA: 0x0044E950 File Offset: 0x0044CB50
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x0600EACF RID: 60111 RVA: 0x0044E988 File Offset: 0x0044CB88
	protected ERedDotName? GetRedDotName(EUiTabViewName tabViewName)
	{
		if (tabViewName == EUiTabViewName.MotorcycleDiyFrameTabView)
		{
			return new ERedDotName?(ERedDotName.MotorcycleDiyFrameTab);
		}
		if (tabViewName == EUiTabViewName.MotorcycleDiyStickerTabView)
		{
			return new ERedDotName?(ERedDotName.MotorcycleDiyStickerTab);
		}
		if (tabViewName == EUiTabViewName.MotorcycleDiyDecorationTabView)
		{
			return new ERedDotName?(ERedDotName.MotorcycleDiyDecorationTab);
		}
		return null;
	}

	// Token: 0x0600EAD0 RID: 60112 RVA: 0x0044E9E8 File Offset: 0x0044CBE8
	protected ERedDotName? GetPreviewRedDotName(EUiTabViewName tabViewName)
	{
		if (tabViewName == EUiTabViewName.MotorcycleDiyFrameTabView)
		{
			return new ERedDotName?(ERedDotName.MotorcycleDiyFramePreTab);
		}
		if (tabViewName == EUiTabViewName.MotorcycleDiyStickerTabView)
		{
			return new ERedDotName?(ERedDotName.MotorcycleDiyStickerPreTab);
		}
		if (tabViewName == EUiTabViewName.MotorcycleDiyDecorationTabView)
		{
			return new ERedDotName?(ERedDotName.MotorcycleDiyDecorationPreTab);
		}
		return null;
	}

	// Token: 0x0600EAD1 RID: 60113 RVA: 0x0044EA48 File Offset: 0x0044CC48
	private void CheckBtnEnable(EOutlookType itemType, int itemPart, int itemId)
	{
		if (itemType == EOutlookType.Decoration || itemType == EOutlookType.Frame)
		{
			base.GetExtendToggle(3).RootUIComp.Get().SetUIActive(false);
			return;
		}
		base.GetExtendToggle(3).RootUIComp.Get().SetUIActive(itemPart == 3);
	}

	// Token: 0x0600EAD2 RID: 60114 RVA: 0x0044EA95 File Offset: 0x0044CC95
	private void RemoveMaskTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600EAD3 RID: 60115 RVA: 0x0044EAB8 File Offset: 0x0044CCB8
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

	// Token: 0x0600EAD4 RID: 60116 RVA: 0x0044EB24 File Offset: 0x0044CD24
	private void PushPartCameraHandle(int partTabIndex)
	{
		MotorFramePart? motorFramePart = null;
		MotorStickerPart? motorStickerPart = null;
		MotorDecorationsPart? motorDecorationsPart = null;
		if (this.CurSelectTabView == EUiTabViewName.MotorcycleDiyFrameTabView)
		{
			motorFramePart = MotorDiyConfig.Instance.GetMotorFramePartConfig();
		}
		else if (this.CurSelectTabView == EUiTabViewName.MotorcycleDiyStickerTabView)
		{
			if (partTabIndex > 0)
			{
				motorStickerPart = MotorDiyConfig.Instance.GetMotorStickerPartConfig(partTabIndex);
			}
		}
		else if (this.CurSelectTabView == EUiTabViewName.MotorcycleDiyDecorationTabView && partTabIndex > 0)
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
		List<string> list = new List<string>();
		foreach (string item in this.IsNotHidingUi ? array : (array2 ?? array))
		{
			list.Add(item);
		}
		string handleName = list[0];
		if (partTabIndex == 3 && list.Count > 1)
		{
			handleName = (this.IsPartDefaultCam ? list[0] : list[1]);
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

	// Token: 0x0600EAD5 RID: 60117 RVA: 0x0044ED36 File Offset: 0x0044CF36
	private void OnRootUpdate()
	{
		ButtonItem btnSave = this.BtnSave;
		if (btnSave == null)
		{
			return;
		}
		btnSave.SetEnableClick(false);
	}

	// Token: 0x0600EAD6 RID: 60118 RVA: 0x0044ED49 File Offset: 0x0044CF49
	private void OnSelectItemClick(EOutlookType itemType, int itemPart, int itemId)
	{
		this.CheckBtnEnable(itemType, itemPart, itemId);
	}

	// Token: 0x0600EAD7 RID: 60119 RVA: 0x0044ED54 File Offset: 0x0044CF54
	private void OnTogChangeCameraPosClick(EToggleState toggleState)
	{
		this.IsPartDefaultCam = !this.IsPartDefaultCam;
		this.PushPartCameraHandle(3);
		this.StartMaskTimer();
	}

	// Token: 0x0600EAD8 RID: 60120 RVA: 0x0044ED74 File Offset: 0x0044CF74
	private void OnBtnMotorDiySaveClick(int _)
	{
		List<int> selectedStickerIdList = MotorcycleDiyModel.Instance.GetSelectedStickerIdList(false);
		MotorcycleDiyController.Instance.EquipMotorStickerRequest(selectedStickerIdList, null);
	}

	// Token: 0x0600EAD9 RID: 60121 RVA: 0x0044ED9C File Offset: 0x0044CF9C
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
		this.PushPartCameraHandle(this.CurSelectPart);
	}

	// Token: 0x0600EADA RID: 60122 RVA: 0x0044EE52 File Offset: 0x0044D052
	protected void CloseClick()
	{
		if (!this.IsNeedResetMotor)
		{
			base.CloseMe(null);
			return;
		}
		MotorcycleDiyModel.Instance.ResetSelectedItemInfo();
		MotorcycleUiModelUtil.Instance.LoadEquippedMotor(delegate(UiModelBase _)
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x04008556 RID: 34134
	private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x04008557 RID: 34135
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<MotorcycleTabItem> TabComponent;

	// Token: 0x04008558 RID: 34136
	[Nullable(2)]
	private TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x04008559 RID: 34137
	private double? LastClickTime;

	// Token: 0x0400855A RID: 34138
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x0400855B RID: 34139
	[Nullable(2)]
	private ButtonItem BtnSave;

	// Token: 0x0400855C RID: 34140
	public UiCameraInputBinding CameraInputBinding = new UiCameraInputBinding();

	// Token: 0x0400855D RID: 34141
	private bool IsNotHidingUi = true;

	// Token: 0x0400855E RID: 34142
	private bool IsPartDefaultCam = true;

	// Token: 0x0400855F RID: 34143
	private EUiTabViewName? CurSelectTabView;

	// Token: 0x04008560 RID: 34144
	private int CurSelectPart;

	// Token: 0x04008561 RID: 34145
	private int OriginPartTabIndex;

	// Token: 0x04008562 RID: 34146
	private bool IsNeedResetMotor;

	// Token: 0x04008563 RID: 34147
	private bool IsInitCameraInput;

	// Token: 0x02007999 RID: 31129
	[NullableContext(0)]
	private class EMotorDiyRootComponent
	{
		// Token: 0x04027693 RID: 161427
		public const int NotHideUIItem = 0;

		// Token: 0x04027694 RID: 161428
		public const int CaptainItem = 1;

		// Token: 0x04027695 RID: 161429
		public const int ContentItem = 2;

		// Token: 0x04027696 RID: 161430
		public const int TogMotorDiyChange = 3;

		// Token: 0x04027697 RID: 161431
		public const int BtnMotorSave = 4;

		// Token: 0x04027698 RID: 161432
		public const int TogEye = 5;

		// Token: 0x04027699 RID: 161433
		public const int DragComponent = 6;
	}
}
