using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200178E RID: 6030
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleDiyMainView : UiTabViewBase
{
	// Token: 0x0600EA9A RID: 60058 RVA: 0x0044D2D8 File Offset: 0x0044B4D8
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

	// Token: 0x0600EA9B RID: 60059 RVA: 0x0044D4C8 File Offset: 0x0044B6C8
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EA9C RID: 60060 RVA: 0x0044D50C File Offset: 0x0044B70C
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
		if (this.IsObserving)
		{
			this.CameraInputBinding.Bind();
		}
		else
		{
			this.CameraInputBinding.Unbind();
		}
		this.DecoratePanel.Refresh(MotorcycleDiyModel.Instance.GetEquippedDecorationIdList());
		this.DecoratePanel.SetEditable(this.IsDiyEditable);
		MotorcycleDevelopModel.Instance.UpdateSelectedTreeType(0);
		base.GetItem(14).SetUIActive(MotorcycleDiyModel.Instance.RedDotHasNewSkin());
		RedDotController.Instance.BindRedDot(ERedDotName.MotorcycleSceneButtonRedDot, base.GetItem(16), null, 0);
	}

	// Token: 0x0600EA9D RID: 60061 RVA: 0x0044D6CE File Offset: 0x0044B8CE
	protected override void OnAfterShow()
	{
		if (this.IsObserving)
		{
			this.CameraInputBinding.Bind();
		}
		EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "MotorDiyViewShow");
	}

	// Token: 0x0600EA9E RID: 60062 RVA: 0x0044D6F8 File Offset: 0x0044B8F8
	protected override void OnBeforeHide()
	{
		this.CameraInputBinding.Unbind();
		RedDotController.Instance.UnBindRedDot(ERedDotName.MotorcycleSceneButtonRedDot);
	}

	// Token: 0x0600EA9F RID: 60063 RVA: 0x0044D714 File Offset: 0x0044B914
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
		UiCameraInputBindingData data = new UiCameraInputBindingData
		{
			DragComponent = base.GetDraggable(13),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputBinding.Configure(data);
	}

	// Token: 0x0600EAA0 RID: 60064 RVA: 0x0044D79C File Offset: 0x0044B99C
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
		if (this.IsObserving)
		{
			this.CameraInputBinding.Bind();
		}
		else
		{
			this.CameraInputBinding.Unbind();
		}
		string handleName = ConfigCommonParamById.GetStringConfig(this.IsObserving ? "MotorDiyMainCameraIdIn" : "MotorDiyMainCameraIdOut") ?? "";
		UiCameraModel.Instance.PushCameraHandleByHandleName(handleName, true, true, "1001", false, null);
	}

	// Token: 0x0600EAA1 RID: 60065 RVA: 0x0044D919 File Offset: 0x0044BB19
	private void OnBtnSkinClick()
	{
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiySkinView, null, null);
	}

	// Token: 0x0600EAA2 RID: 60066 RVA: 0x0044D92C File Offset: 0x0044BB2C
	private void OnBtnImportPresetClick()
	{
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyImportPresetView, null, null);
	}

	// Token: 0x0600EAA3 RID: 60067 RVA: 0x0044D93F File Offset: 0x0044BB3F
	private void OnToggleSceneClick(EToggleState toggleState)
	{
		UiManager.Instance.OpenView(EUiViewName.MotorcycleScenePopupView, null, null);
	}

	// Token: 0x04008547 RID: 34119
	private MotorcycleDiyFramePanel FramePanel;

	// Token: 0x04008548 RID: 34120
	private MotorcycleDiyStickerPanel StickerPanel;

	// Token: 0x04008549 RID: 34121
	private MotorcycleDiyDecoratePanel DecoratePanel;

	// Token: 0x0400854A RID: 34122
	[Nullable(1)]
	public UiCameraInputBinding CameraInputBinding = new UiCameraInputBinding();

	// Token: 0x0400854B RID: 34123
	private bool IsObserving;

	// Token: 0x0400854C RID: 34124
	private bool IsDiyEditable;

	// Token: 0x02007992 RID: 31122
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402766C RID: 161388
		public const int TogEye = 0;

		// Token: 0x0402766D RID: 161389
		public const int PanelSkinTitle = 1;

		// Token: 0x0402766E RID: 161390
		public const int BtnSkin = 2;

		// Token: 0x0402766F RID: 161391
		public const int TexSkinIcon = 3;

		// Token: 0x04027670 RID: 161392
		public const int TxtSkinTitle = 4;

		// Token: 0x04027671 RID: 161393
		public const int PanelTitle = 5;

		// Token: 0x04027672 RID: 161394
		public const int TxtTitle = 6;

		// Token: 0x04027673 RID: 161395
		public const int TxtDesc = 7;

		// Token: 0x04027674 RID: 161396
		public const int PanelMotorFrame = 8;

		// Token: 0x04027675 RID: 161397
		public const int PanelMotorSticker = 9;

		// Token: 0x04027676 RID: 161398
		public const int PanelMotorDecoration = 10;

		// Token: 0x04027677 RID: 161399
		public const int BtnImportPreset = 11;

		// Token: 0x04027678 RID: 161400
		public const int PanelHideUI = 12;

		// Token: 0x04027679 RID: 161401
		public const int DragComponent = 13;

		// Token: 0x0402767A RID: 161402
		public const int RedDotItem = 14;

		// Token: 0x0402767B RID: 161403
		public const int ToggleScene = 15;

		// Token: 0x0402767C RID: 161404
		public const int ToggleSceneRedDot = 16;
	}
}
