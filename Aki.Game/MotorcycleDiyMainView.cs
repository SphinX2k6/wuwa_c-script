using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022AA RID: 8874
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleDiyMainView : UiTabViewBase
{
	// Token: 0x06011602 RID: 71170 RVA: 0x004406EC File Offset: 0x0043E8EC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(16, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTogEyeClick)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnBtnSkinClick)),
			new ValueTuple<int, Delegate>(11, new Action(this.OnBtnImportPresetClick)),
			new ValueTuple<int, Delegate>(15, new Action<EToggleState>(this.OnToggleSceneClick))
		};
	}

	// Token: 0x06011603 RID: 71171 RVA: 0x004408DC File Offset: 0x0043EADC
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011604 RID: 71172 RVA: 0x00440920 File Offset: 0x0043EB20
	protected override void OnBeforeShow()
	{
		int equippedSkinId = MotorcycleDiyModel.Instance.GetEquippedSkinId();
		MotorSkin? motorSkinConfig = MotorDiyConfig.Instance.GetMotorSkinConfig(equippedSkinId);
		if (motorSkinConfig == null)
		{
			return;
		}
		this.IsDiyEditable = motorSkinConfig.Value.Editable;
		base.SetTextureByPath(motorSkinConfig.Value.MainIcon, base.GetTexture(3), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), motorSkinConfig.Value.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), motorSkinConfig.Value.BgDescription, Array.Empty<object>());
		this.FramePanel.Refresh(MotorcycleDiyModel.Instance.GetEquippedFrameId());
		this.FramePanel.SetEditable(this.IsDiyEditable);
		this.StickerPanel.Refresh(MotorcycleDiyModel.Instance.GetEquippedStickerIdList());
		this.StickerPanel.SetEditable(this.IsDiyEditable);
		base.GetButton(11).RootUIComp.Get().SetUIActive(this.IsDiyEditable);
		base.GetDraggable(13).RootUIComp.Get().SetUIActive(this.IsObserving);
		this.CameraInputComponent.CanCameraInput = this.IsObserving;
		this.DecoratePanel.Refresh(MotorcycleDiyModel.Instance.GetEquippedDecorationIdList());
		this.DecoratePanel.SetEditable(this.IsDiyEditable);
		MotorcycleDevelopModel.Instance.UpdateSelectedTreeType(0);
		base.GetItem(14).SetUIActive(MotorcycleDiyModel.Instance.RedDotHasNewSkin());
		RedDotController.Instance.BindRedDot(ERedDotName.MotorcycleSceneButtonRedDot, base.GetItem(16), null, 0);
	}

	// Token: 0x06011605 RID: 71173 RVA: 0x00440AD3 File Offset: 0x0043ECD3
	protected override void OnAfterShow()
	{
		this.CameraInputComponent.Start();
		this.CameraInputComponent.TryActivate();
		EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "MotorDiyViewShow");
	}

	// Token: 0x06011606 RID: 71174 RVA: 0x00440B01 File Offset: 0x0043ED01
	protected override void OnBeforeHide()
	{
		this.CameraInputComponent.End();
		RedDotController.Instance.UnBindRedDot(ERedDotName.MotorcycleSceneButtonRedDot);
	}

	// Token: 0x06011607 RID: 71175 RVA: 0x00440B20 File Offset: 0x0043ED20
	public void InitCameraInputData()
	{
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig("摩托车自定义界面");
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
			DragComponent = base.GetDraggable(13),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputComponent.InitData(data);
	}

	// Token: 0x06011608 RID: 71176 RVA: 0x00440BA8 File Offset: 0x0043EDA8
	private void OnTogEyeClick(EToggleState toggleState)
	{
		this.IsObserving = !this.IsObserving;
		bool state = this.IsObserving;
		if (!state)
		{
			base.GetItem(12).SetUIActive(!state);
			this.UiViewSequence.StopSequenceByKey("UiIn", false, false);
			this.UiViewSequence.PlaySequencePurely("UiIn", false, false);
		}
		else
		{
			this.UiViewSequence.AddSequenceFinishEvent("UiOut", delegate(string _)
			{
				this.GetItem(12).SetUIActive(!state);
			}, false);
			this.UiViewSequence.StopSequenceByKey("UiOut", false, false);
			this.UiViewSequence.PlaySequencePurely("UiOut", false, false);
		}
		base.GetExtendToggle(15).RootUIComp.Get().SetUIActive(!state);
		MotorDevelopRootData p = new MotorDevelopRootData
		{
			IsObserving = new bool?(this.IsObserving)
		};
		EventSystem.Instance.Emit<MotorDevelopRootData>(EEventName.MotorDevelopRootUpdate, p);
		base.GetDraggable(13).RootUIComp.Get().SetUIActive(this.IsObserving);
		this.CameraInputComponent.CanCameraInput = this.IsObserving;
		string handleName = ConfigCommonParamById.GetStringConfig(this.IsObserving ? "MotorDiyMainCameraIdIn" : "MotorDiyMainCameraIdOut") ?? "";
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(handleName, true, true, "1001", false, null, null);
	}

	// Token: 0x06011609 RID: 71177 RVA: 0x00440D20 File Offset: 0x0043EF20
	private void OnBtnSkinClick()
	{
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiySkinView, null, null);
	}

	// Token: 0x0601160A RID: 71178 RVA: 0x00440D33 File Offset: 0x0043EF33
	private void OnBtnImportPresetClick()
	{
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyImportPresetView, null, null);
	}

	// Token: 0x0601160B RID: 71179 RVA: 0x00440D46 File Offset: 0x0043EF46
	private void OnToggleSceneClick(EToggleState toggleState)
	{
		UiManager.Instance.OpenView(EUiViewName.MotorcycleScenePopupView, null, null);
	}

	// Token: 0x04008409 RID: 33801
	private MotorcycleDiyFramePanel FramePanel;

	// Token: 0x0400840A RID: 33802
	private MotorcycleDiyStickerPanel StickerPanel;

	// Token: 0x0400840B RID: 33803
	private MotorcycleDiyDecoratePanel DecoratePanel;

	// Token: 0x0400840C RID: 33804
	[Nullable(1)]
	public UiCameraInputComponent CameraInputComponent = new UiCameraInputComponent();

	// Token: 0x0400840D RID: 33805
	private bool IsObserving;

	// Token: 0x0400840E RID: 33806
	private bool IsDiyEditable;

	// Token: 0x0200880C RID: 34828
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402C364 RID: 181092
		public const int TogEye = 0;

		// Token: 0x0402C365 RID: 181093
		public const int PanelSkinTitle = 1;

		// Token: 0x0402C366 RID: 181094
		public const int BtnSkin = 2;

		// Token: 0x0402C367 RID: 181095
		public const int TexSkinIcon = 3;

		// Token: 0x0402C368 RID: 181096
		public const int TxtSkinTitle = 4;

		// Token: 0x0402C369 RID: 181097
		public const int PanelTitle = 5;

		// Token: 0x0402C36A RID: 181098
		public const int TxtTitle = 6;

		// Token: 0x0402C36B RID: 181099
		public const int TxtDesc = 7;

		// Token: 0x0402C36C RID: 181100
		public const int PanelMotorFrame = 8;

		// Token: 0x0402C36D RID: 181101
		public const int PanelMotorSticker = 9;

		// Token: 0x0402C36E RID: 181102
		public const int PanelMotorDecoration = 10;

		// Token: 0x0402C36F RID: 181103
		public const int BtnImportPreset = 11;

		// Token: 0x0402C370 RID: 181104
		public const int PanelHideUI = 12;

		// Token: 0x0402C371 RID: 181105
		public const int DragComponent = 13;

		// Token: 0x0402C372 RID: 181106
		public const int RedDotItem = 14;

		// Token: 0x0402C373 RID: 181107
		public const int ToggleScene = 15;

		// Token: 0x0402C374 RID: 181108
		public const int ToggleSceneRedDot = 16;
	}
}
