using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022A5 RID: 8869
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyDecorationPreviewView : UiViewBase
{
	// Token: 0x0601158F RID: 71055 RVA: 0x0043D8A2 File Offset: 0x0043BAA2
	public MotorcycleDiyDecorationPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011590 RID: 71056 RVA: 0x0043D8C0 File Offset: 0x0043BAC0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnTogEyeClick))
		};
	}

	// Token: 0x06011591 RID: 71057 RVA: 0x0043D980 File Offset: 0x0043BB80
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(1));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnBackBtnClick));
		this.CaptionItem.SetHelpBtnActive(false);
		this.CaptionItem.SetTitleTextActive(false);
		this.CaptionItem.SetTitleIconVisible(false);
		int valueOrDefault = (this.OpenParam as int?).GetValueOrDefault();
		MotorGeneralPreview? motorGeneralPreviewConfig = MotorDiyConfig.Instance.GetMotorGeneralPreviewConfig(valueOrDefault);
		if (motorGeneralPreviewConfig == null)
		{
			return;
		}
		this.PreviewConfig = new MotorGeneralPreview?(motorGeneralPreviewConfig.Value);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), motorGeneralPreviewConfig.Value.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), motorGeneralPreviewConfig.Value.SubTitle, Array.Empty<object>());
	}

	// Token: 0x06011592 RID: 71058 RVA: 0x0043DA65 File Offset: 0x0043BC65
	protected override void OnHandleLoadScene()
	{
		this.InitMotorModel();
	}

	// Token: 0x06011593 RID: 71059 RVA: 0x0043DA70 File Offset: 0x0043BC70
	protected override void OnBeforeShow()
	{
		if (this.PreviewConfig == null)
		{
			return;
		}
		this.InitCameraInputData(this.PreviewConfig.Value.FreeCameraConfig);
		MotorcycleUiModelUtil.Instance.ShowMotor(true);
		this.PushExCameraHandle();
	}

	// Token: 0x06011594 RID: 71060 RVA: 0x0043DAB5 File Offset: 0x0043BCB5
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x06011595 RID: 71061 RVA: 0x0043DAC4 File Offset: 0x0043BCC4
	private void InitMotorModel()
	{
		MotorcycleUiModelUtil.Instance.CreateMotor(EUiModelUseWay.MotorInMotorView);
		if (this.PreviewConfig == null)
		{
			return;
		}
		MotorGeneralPreview value = this.PreviewConfig.Value;
		int frame = value.Frame;
		int[] decorationsArray = value.GetDecorationsArray();
		MotorcycleUiModelParam param = new MotorcycleUiModelParam
		{
			FrameId = frame,
			DecorationIds = decorationsArray
		};
		MotorcycleUiModelUtil.Instance.LoadMotorByParam(param, null);
	}

	// Token: 0x06011596 RID: 71062 RVA: 0x0043DB28 File Offset: 0x0043BD28
	private void InitCameraInputData(string cameraRotateConfig)
	{
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig(cameraRotateConfig);
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
			DragComponent = base.GetDraggable(0),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputComponent.InitData(data);
	}

	// Token: 0x06011597 RID: 71063 RVA: 0x0043DBAC File Offset: 0x0043BDAC
	private void PushExCameraHandle()
	{
		if (this.PreviewConfig == null)
		{
			return;
		}
		string handleName = this.IsNotHidingUi ? this.PreviewConfig.Value.CameraId : this.PreviewConfig.Value.FreeCamera;
		if (!this.PreviewConfig.Value.IsFree)
		{
			this.CameraInputComponent.CanCameraInput = !this.IsNotHidingUi;
		}
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(handleName, true, true, "1001", false, null, null);
	}

	// Token: 0x06011598 RID: 71064 RVA: 0x0043DC3F File Offset: 0x0043BE3F
	private void OnBackBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.MotorcycleDiyDecorationPreviewView, null);
	}

	// Token: 0x06011599 RID: 71065 RVA: 0x0043DC54 File Offset: 0x0043BE54
	private void OnTogEyeClick(EToggleState toggleState)
	{
		this.IsNotHidingUi = !this.IsNotHidingUi;
		base.GetItem(5).SetUIActive(!this.IsNotHidingUi);
		bool state = this.IsNotHidingUi;
		if (state)
		{
			base.GetItem(5).SetUIActive(state);
			base.PlaySequence("UiIn", delegate
			{
			}, true);
			this.CameraInputComponent.End();
		}
		else
		{
			base.PlaySequence("UiOut", delegate
			{
				this.GetItem(5).SetUIActive(state);
			}, true);
			this.CameraInputComponent.Start();
			this.CameraInputComponent.TryActivate();
		}
		this.PushExCameraHandle();
	}

	// Token: 0x040083D7 RID: 33751
	private bool IsNotHidingUi = true;

	// Token: 0x040083D8 RID: 33752
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040083D9 RID: 33753
	private MotorGeneralPreview? PreviewConfig;

	// Token: 0x040083DA RID: 33754
	protected UiCameraInputComponent CameraInputComponent = new UiCameraInputComponent();

	// Token: 0x020087F4 RID: 34804
	[NullableContext(0)]
	private class EMotorDecorationPreviewComponent
	{
		// Token: 0x0402C2EA RID: 180970
		public const int DragComponent = 0;

		// Token: 0x0402C2EB RID: 180971
		public const int CaptionItem = 1;

		// Token: 0x0402C2EC RID: 180972
		public const int TogEye = 2;

		// Token: 0x0402C2ED RID: 180973
		public const int TxtTitle = 3;

		// Token: 0x0402C2EE RID: 180974
		public const int TxtSubTitle = 4;

		// Token: 0x0402C2EF RID: 180975
		public const int NotHideUIItem = 5;
	}
}
