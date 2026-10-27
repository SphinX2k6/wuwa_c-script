using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022AD RID: 8877
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyRootView : UiViewBase
{
	// Token: 0x06011625 RID: 71205 RVA: 0x0044173A File Offset: 0x0043F93A
	public MotorcycleDiyRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011626 RID: 71206 RVA: 0x00441768 File Offset: 0x0043F968
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

	// Token: 0x06011627 RID: 71207 RVA: 0x00441858 File Offset: 0x0043FA58
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyRootView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyRootView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011628 RID: 71208 RVA: 0x0044189C File Offset: 0x0043FA9C
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

	// Token: 0x06011629 RID: 71209 RVA: 0x0044190C File Offset: 0x0043FB0C
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

	// Token: 0x0601162A RID: 71210 RVA: 0x004419CC File Offset: 0x0043FBCC
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

	// Token: 0x0601162B RID: 71211 RVA: 0x00441A48 File Offset: 0x0043FC48
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x0601162C RID: 71212 RVA: 0x00441A54 File Offset: 0x0043FC54
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

	// Token: 0x0601162D RID: 71213 RVA: 0x00441A8B File Offset: 0x0043FC8B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnRootUpdate));
	}

	// Token: 0x0601162E RID: 71214 RVA: 0x00441AA9 File Offset: 0x0043FCA9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnRootUpdate));
	}

	// Token: 0x0601162F RID: 71215 RVA: 0x00441AC8 File Offset: 0x0043FCC8
	protected void InitTabComponent()
	{
		CommonTabComponentData<MotorcycleTabItem> data = new CommonTabComponentData<MotorcycleTabItem>(new Func<UUIItem, int?, MotorcycleTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<MotorcycleTabItem>(base.GetItem(1), data, new Action(this.CloseClick), false);
		this.LastClickTime = null;
		this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(2), EKeyMode.Default);
	}

	// Token: 0x06011630 RID: 71216 RVA: 0x00441B58 File Offset: 0x0043FD58
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
		UiCameraInputComponentData data = new UiCameraInputComponentData
		{
			DragComponent = base.GetDraggable(6),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputComponent.InitData(data);
		this.IsInitCameraInput = true;
	}

	// Token: 0x06011631 RID: 71217 RVA: 0x00441BED File Offset: 0x0043FDED
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

	// Token: 0x06011632 RID: 71218 RVA: 0x00441C06 File Offset: 0x0043FE06
	private void OnTabCameraClick(int partIndex)
	{
		this.CurSelectPart = partIndex;
		this.PushPartCameraHandle(partIndex);
		this.StartMaskTimer();
	}

	// Token: 0x06011633 RID: 71219 RVA: 0x00441C1C File Offset: 0x0043FE1C
	protected UniTask RefreshTabListAsync()
	{
		MotorcycleDiyRootView.<RefreshTabListAsync>d__29 <RefreshTabListAsync>d__;
		<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabListAsync>d__.<>4__this = this;
		<RefreshTabListAsync>d__.<>1__state = -1;
		<RefreshTabListAsync>d__.<>t__builder.Start<MotorcycleDiyRootView.<RefreshTabListAsync>d__29>(ref <RefreshTabListAsync>d__);
		return <RefreshTabListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011634 RID: 71220 RVA: 0x00441C60 File Offset: 0x0043FE60
	private bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int value = ConfigCommonParamById.GetIntConfig("panel_interval_time").Value;
		return this.LastClickTime == null || Time.Instance.Now - this.LastClickTime.Value >= (double)value;
	}

	// Token: 0x06011635 RID: 71221 RVA: 0x00441CB8 File Offset: 0x0043FEB8
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

	// Token: 0x06011636 RID: 71222 RVA: 0x00441D58 File Offset: 0x0043FF58
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x06011637 RID: 71223 RVA: 0x00441D90 File Offset: 0x0043FF90
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

	// Token: 0x06011638 RID: 71224 RVA: 0x00441DF0 File Offset: 0x0043FFF0
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

	// Token: 0x06011639 RID: 71225 RVA: 0x00441E50 File Offset: 0x00440050
	private void CheckBtnEnable(EOutlookType itemType, int itemPart, int itemId)
	{
		if (itemType == EOutlookType.Decoration || itemType == EOutlookType.Frame)
		{
			base.GetExtendToggle(3).RootUIComp.Get().SetUIActive(false);
			return;
		}
		base.GetExtendToggle(3).RootUIComp.Get().SetUIActive(itemPart == 3);
	}

	// Token: 0x0601163A RID: 71226 RVA: 0x00441E9D File Offset: 0x0044009D
	private void RemoveMaskTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0601163B RID: 71227 RVA: 0x00441EC0 File Offset: 0x004400C0
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

	// Token: 0x0601163C RID: 71228 RVA: 0x00441F2C File Offset: 0x0044012C
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
		this.CameraInputComponent.CanCameraInput = !this.IsNotHidingUi;
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(handleName, true, true, "1001", false, null, null);
	}

	// Token: 0x0601163D RID: 71229 RVA: 0x0044213C File Offset: 0x0044033C
	private void OnRootUpdate()
	{
		ButtonItem btnSave = this.BtnSave;
		if (btnSave == null)
		{
			return;
		}
		btnSave.SetEnableClick(false);
	}

	// Token: 0x0601163E RID: 71230 RVA: 0x0044214F File Offset: 0x0044034F
	private void OnSelectItemClick(EOutlookType itemType, int itemPart, int itemId)
	{
		this.CheckBtnEnable(itemType, itemPart, itemId);
	}

	// Token: 0x0601163F RID: 71231 RVA: 0x0044215A File Offset: 0x0044035A
	private void OnTogChangeCameraPosClick(EToggleState toggleState)
	{
		this.IsPartDefaultCam = !this.IsPartDefaultCam;
		this.PushPartCameraHandle(3);
		this.StartMaskTimer();
	}

	// Token: 0x06011640 RID: 71232 RVA: 0x00442178 File Offset: 0x00440378
	private void OnBtnMotorDiySaveClick(int _)
	{
		List<int> selectedStickerIdList = MotorcycleDiyModel.Instance.GetSelectedStickerIdList(false);
		MotorcycleDiyController.Instance.EquipMotorStickerRequest(selectedStickerIdList, null);
	}

	// Token: 0x06011641 RID: 71233 RVA: 0x004421A0 File Offset: 0x004403A0
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
		this.PushPartCameraHandle(this.CurSelectPart);
	}

	// Token: 0x06011642 RID: 71234 RVA: 0x00442262 File Offset: 0x00440462
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

	// Token: 0x04008418 RID: 33816
	private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x04008419 RID: 33817
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<MotorcycleTabItem> TabComponent;

	// Token: 0x0400841A RID: 33818
	[Nullable(2)]
	private TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x0400841B RID: 33819
	private double? LastClickTime;

	// Token: 0x0400841C RID: 33820
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x0400841D RID: 33821
	[Nullable(2)]
	private ButtonItem BtnSave;

	// Token: 0x0400841E RID: 33822
	public UiCameraInputComponent CameraInputComponent = new UiCameraInputComponent();

	// Token: 0x0400841F RID: 33823
	private bool IsNotHidingUi = true;

	// Token: 0x04008420 RID: 33824
	private bool IsPartDefaultCam = true;

	// Token: 0x04008421 RID: 33825
	private EUiTabViewName? CurSelectTabView;

	// Token: 0x04008422 RID: 33826
	private int CurSelectPart;

	// Token: 0x04008423 RID: 33827
	private int OriginPartTabIndex;

	// Token: 0x04008424 RID: 33828
	private bool IsNeedResetMotor;

	// Token: 0x04008425 RID: 33829
	private bool IsInitCameraInput;

	// Token: 0x02008813 RID: 34835
	[NullableContext(0)]
	private class EMotorDiyRootComponent
	{
		// Token: 0x0402C38B RID: 181131
		public const int NotHideUIItem = 0;

		// Token: 0x0402C38C RID: 181132
		public const int CaptainItem = 1;

		// Token: 0x0402C38D RID: 181133
		public const int ContentItem = 2;

		// Token: 0x0402C38E RID: 181134
		public const int TogMotorDiyChange = 3;

		// Token: 0x0402C38F RID: 181135
		public const int BtnMotorSave = 4;

		// Token: 0x0402C390 RID: 181136
		public const int TogEye = 5;

		// Token: 0x0402C391 RID: 181137
		public const int DragComponent = 6;
	}
}
