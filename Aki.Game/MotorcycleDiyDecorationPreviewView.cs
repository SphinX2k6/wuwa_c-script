using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001789 RID: 6025
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyDecorationPreviewView : UiViewBase
{
	// Token: 0x0600EA27 RID: 59943 RVA: 0x0044A4A2 File Offset: 0x004486A2
	public MotorcycleDiyDecorationPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EA28 RID: 59944 RVA: 0x0044A4C0 File Offset: 0x004486C0
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

	// Token: 0x0600EA29 RID: 59945 RVA: 0x0044A580 File Offset: 0x00448780
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

	// Token: 0x0600EA2A RID: 59946 RVA: 0x0044A665 File Offset: 0x00448865
	protected override void OnHandleLoadScene()
	{
		this.InitMotorModel();
	}

	// Token: 0x0600EA2B RID: 59947 RVA: 0x0044A670 File Offset: 0x00448870
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

	// Token: 0x0600EA2C RID: 59948 RVA: 0x0044A6B5 File Offset: 0x004488B5
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x0600EA2D RID: 59949 RVA: 0x0044A6C4 File Offset: 0x004488C4
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

	// Token: 0x0600EA2E RID: 59950 RVA: 0x0044A728 File Offset: 0x00448928
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
		UiCameraInputBindingData data = new UiCameraInputBindingData
		{
			DragComponent = base.GetDraggable(0),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputBinding.Configure(data);
	}

	// Token: 0x0600EA2F RID: 59951 RVA: 0x0044A7AC File Offset: 0x004489AC
	private void PushExCameraHandle()
	{
		if (this.PreviewConfig == null)
		{
			return;
		}
		string handleName = this.IsNotHidingUi ? this.PreviewConfig.Value.CameraId : this.PreviewConfig.Value.FreeCamera;
		if (!this.PreviewConfig.Value.IsFree)
		{
			if (this.IsNotHidingUi)
			{
				this.CameraInputBinding.Unbind();
			}
			else
			{
				this.CameraInputBinding.Bind();
			}
		}
		UiCameraModel.Instance.PushCameraHandleByHandleName(handleName, true, true, "1001", false, null);
	}

	// Token: 0x0600EA30 RID: 59952 RVA: 0x0044A842 File Offset: 0x00448A42
	private void OnBackBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.MotorcycleDiyDecorationPreviewView, null);
	}

	// Token: 0x0600EA31 RID: 59953 RVA: 0x0044A854 File Offset: 0x00448A54
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
			this.CameraInputBinding.Unbind();
		}
		else
		{
			base.PlaySequence("UiOut", delegate
			{
				this.GetItem(5).SetUIActive(state);
			}, true);
			this.CameraInputBinding.Bind();
		}
		this.PushExCameraHandle();
	}

	// Token: 0x04008515 RID: 34069
	private bool IsNotHidingUi = true;

	// Token: 0x04008516 RID: 34070
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008517 RID: 34071
	private MotorGeneralPreview? PreviewConfig;

	// Token: 0x04008518 RID: 34072
	protected UiCameraInputBinding CameraInputBinding = new UiCameraInputBinding();

	// Token: 0x0200797C RID: 31100
	[NullableContext(0)]
	private class EMotorDecorationPreviewComponent
	{
		// Token: 0x040275F4 RID: 161268
		public const int DragComponent = 0;

		// Token: 0x040275F5 RID: 161269
		public const int CaptionItem = 1;

		// Token: 0x040275F6 RID: 161270
		public const int TogEye = 2;

		// Token: 0x040275F7 RID: 161271
		public const int TxtTitle = 3;

		// Token: 0x040275F8 RID: 161272
		public const int TxtSubTitle = 4;

		// Token: 0x040275F9 RID: 161273
		public const int NotHideUIItem = 5;
	}
}
