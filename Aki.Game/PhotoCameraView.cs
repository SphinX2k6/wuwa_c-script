using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001AAF RID: 6831
[NullableContext(1)]
[Nullable(0)]
public class PhotoCameraView : UiTickViewBase
{
	// Token: 0x06010E78 RID: 69240 RVA: 0x004F56D4 File Offset: 0x004F38D4
	public PhotoCameraView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010E79 RID: 69241 RVA: 0x004F56E0 File Offset: 0x004F38E0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(22, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(27, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(28, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(29, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(30, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(31, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnBackButtonClicked)),
			new ValueTuple<int, Delegate>(29, new Action<EToggleState>(this.OnNormalModeToggle)),
			new ValueTuple<int, Delegate>(30, new Action<EToggleState>(this.OnSelfieModeToggle)),
			new ValueTuple<int, Delegate>(31, new Action<EToggleState>(this.OnFirstPersonModeToggle)),
			new ValueTuple<int, Delegate>(27, new Action<EToggleState>(this.OnDroneModeToggle))
		};
	}

	// Token: 0x06010E7A RID: 69242 RVA: 0x004F5A40 File Offset: 0x004F3C40
	protected override void OnStart()
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.EnterPhotoCamera(PhotoCameraType.Normal, null);
		PhotographController.Instance.CloseBlackScreen().Forget();
		PhotoCamera photoCamera = this.GetPhotoCamera();
		if (photoCamera != null)
		{
			photoCamera.SetModeChangedCallback(new Action(this.OnModeChanged));
		}
		this.SyncModeToggles(new PhotoCameraType?(PhotoCameraType.Normal));
	}

	// Token: 0x06010E7B RID: 69243 RVA: 0x004F5AA1 File Offset: 0x004F3CA1
	protected override void OnBeforeDestroy()
	{
		PhotoCamera photoCamera = this.GetPhotoCamera();
		if (photoCamera != null)
		{
			photoCamera.SetModeChangedCallback(null);
		}
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitPhotoCamera();
	}

	// Token: 0x06010E7C RID: 69244 RVA: 0x004F5AD0 File Offset: 0x004F3CD0
	protected override void OnAddEventListener()
	{
		UUIButtonComponent button = base.GetButton(0);
		UUIButtonComponent button2 = base.GetButton(1);
		UUIButtonComponent button3 = base.GetButton(2);
		UUIButtonComponent button4 = base.GetButton(3);
		UUIButtonComponent button5 = base.GetButton(21);
		UUIButtonComponent button6 = base.GetButton(22);
		UUIButtonComponent button7 = base.GetButton(4);
		UUIButtonComponent button8 = base.GetButton(5);
		UUISliderComponent slider = base.GetSlider(10);
		UUIDraggableComponent draggable = base.GetDraggable(13);
		button.OnPointDownCallBack.Bind(new Action(this.OnPressUpButton));
		button.OnPointUpCallBack.Bind(new Action(this.OnReleaseUpDownButton));
		button.OnPointCancelCallBack.Bind(new Action(this.OnReleaseUpDownButton));
		button2.OnPointDownCallBack.Bind(new Action(this.OnPressDownButton));
		button2.OnPointUpCallBack.Bind(new Action(this.OnReleaseUpDownButton));
		button2.OnPointCancelCallBack.Bind(new Action(this.OnReleaseUpDownButton));
		button3.OnPointDownCallBack.Bind(new Action(this.OnPressLeftButton));
		button3.OnPointUpCallBack.Bind(new Action(this.OnReleaseLeftRightButton));
		button3.OnPointCancelCallBack.Bind(new Action(this.OnReleaseLeftRightButton));
		button4.OnPointDownCallBack.Bind(new Action(this.OnPressRightButton));
		button4.OnPointUpCallBack.Bind(new Action(this.OnReleaseLeftRightButton));
		button4.OnPointCancelCallBack.Bind(new Action(this.OnReleaseLeftRightButton));
		button5.OnPointDownCallBack.Bind(new Action(this.OnPressForwardButton));
		button5.OnPointUpCallBack.Bind(new Action(this.OnReleaseForwardBackButton));
		button5.OnPointCancelCallBack.Bind(new Action(this.OnReleaseForwardBackButton));
		button6.OnPointDownCallBack.Bind(new Action(this.OnPressBackButton));
		button6.OnPointUpCallBack.Bind(new Action(this.OnReleaseForwardBackButton));
		button6.OnPointCancelCallBack.Bind(new Action(this.OnReleaseForwardBackButton));
		button7.OnPointDownCallBack.Bind(new Action(this.OnPressAddButton));
		button7.OnPointUpCallBack.Bind(new Action(this.OnReleaseFovButton));
		button7.OnPointCancelCallBack.Bind(new Action(this.OnReleaseFovButton));
		button8.OnPointDownCallBack.Bind(new Action(this.OnPressReduceButton));
		button8.OnPointUpCallBack.Bind(new Action(this.OnReleaseFovButton));
		button8.OnPointCancelCallBack.Bind(new Action(this.OnReleaseFovButton));
		slider.OnValueChangeCb.Bind(new Action<float>(this.OnSliderFov));
		InputDistributeController.Instance.BindAxis("UiIncrease", new TInputHandle<float>(this.OnInputUiIncrease));
		InputDistributeController.Instance.BindAxis("UiReduce", new TInputHandle<float>(this.OnInputUiReduce));
		InputDistributeController.Instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiMoveForward));
		InputDistributeController.Instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiMoveRight));
		InputDistributeController.Instance.BindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
		InputDistributeController.Instance.BindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
		InputDistributeController.Instance.BindAxis("UiLookInOut", new TInputHandle<float>(this.OnInputUiLookInOut));
		InputDistributeController.Instance.BindAxis("UiCamRotate", new TInputHandle<float>(this.OnInputUiCamRotate));
		draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
		draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
		draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragMoved));
		draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnded));
		draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnded));
	}

	// Token: 0x06010E7D RID: 69245 RVA: 0x004F5ED0 File Offset: 0x004F40D0
	protected override void OnRemoveEventListener()
	{
		base.GetButton(0).OnPointDownCallBack.Unbind();
		base.GetButton(0).OnPointUpCallBack.Unbind();
		base.GetButton(1).OnPointDownCallBack.Unbind();
		base.GetButton(1).OnPointUpCallBack.Unbind();
		base.GetButton(2).OnPointDownCallBack.Unbind();
		base.GetButton(2).OnPointUpCallBack.Unbind();
		base.GetButton(3).OnPointDownCallBack.Unbind();
		base.GetButton(3).OnPointUpCallBack.Unbind();
		base.GetButton(21).OnPointDownCallBack.Unbind();
		base.GetButton(21).OnPointUpCallBack.Unbind();
		base.GetButton(22).OnPointDownCallBack.Unbind();
		base.GetButton(22).OnPointUpCallBack.Unbind();
		base.GetButton(4).OnPointDownCallBack.Unbind();
		base.GetButton(4).OnPointUpCallBack.Unbind();
		base.GetButton(5).OnPointDownCallBack.Unbind();
		base.GetButton(5).OnPointUpCallBack.Unbind();
		base.GetSlider(10).OnValueChangeCb.Unbind();
		InputDistributeController.Instance.UnBindAxis("UiIncrease", new TInputHandle<float>(this.OnInputUiIncrease));
		InputDistributeController.Instance.UnBindAxis("UiReduce", new TInputHandle<float>(this.OnInputUiReduce));
		InputDistributeController.Instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiMoveForward));
		InputDistributeController.Instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiMoveRight));
		InputDistributeController.Instance.UnBindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
		InputDistributeController.Instance.UnBindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
		InputDistributeController.Instance.UnBindAxis("UiLookInOut", new TInputHandle<float>(this.OnInputUiLookInOut));
		InputDistributeController.Instance.UnBindAxis("UiCamRotate", new TInputHandle<float>(this.OnInputUiCamRotate));
		UUIDraggableComponent draggable = base.GetDraggable(13);
		draggable.OnPointerBeginDragCallBack.Unbind();
		draggable.OnPointerDownCallBack.Unbind();
		draggable.OnPointerDragCallBack.Unbind();
		draggable.OnPointerEndDragCallBack.Unbind();
		draggable.OnPointerUpCallBack.Unbind();
		this.ResetAllAxes();
	}

	// Token: 0x06010E7E RID: 69246 RVA: 0x004F6120 File Offset: 0x004F4320
	protected override void OnTick(float delta)
	{
		if (this.FovValue != 0f)
		{
			InputDistributeController.Instance.InputAxis("PhotoFov", this.FovValue, false);
		}
		if (this.PendingPitch != 0f || this.PendingYaw != 0f)
		{
			InputDistributeController.Instance.InputAxis("PhotoPitch", this.PendingPitch, false);
			InputDistributeController.Instance.InputAxis("PhotoYaw", this.PendingYaw, false);
			this.PendingPitch = 0f;
			this.PendingYaw = 0f;
		}
	}

	// Token: 0x06010E7F RID: 69247 RVA: 0x004F61AC File Offset: 0x004F43AC
	private void ResetAllAxes()
	{
		this.FovValue = 0f;
		this.PendingPitch = 0f;
		this.PendingYaw = 0f;
		InputDistributeController.Instance.InputAxis("PhotoMoveForward", 0f, false);
		InputDistributeController.Instance.InputAxis("PhotoMoveRight", 0f, false);
		InputDistributeController.Instance.InputAxis("PhotoMoveUp", 0f, false);
		InputDistributeController.Instance.InputAxis("PhotoFov", 0f, false);
	}

	// Token: 0x06010E80 RID: 69248 RVA: 0x004F622E File Offset: 0x004F442E
	[NullableContext(2)]
	private PhotoCamera GetPhotoCamera()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		if (fightCamera == null)
		{
			return null;
		}
		FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
		if (logicComponent == null)
		{
			return null;
		}
		return logicComponent.CameraSpecialGameplayController.GetCurrentGameplay<PhotoCamera>();
	}

	// Token: 0x06010E81 RID: 69249 RVA: 0x004F625C File Offset: 0x004F445C
	private void InitFovSlider()
	{
		PhotoCamera photoCamera = this.GetPhotoCamera();
		BP_PhotoCameraConfig_C bp_PhotoCameraConfig_C = (photoCamera != null) ? photoCamera.CurrentConfig : null;
		if (bp_PhotoCameraConfig_C == null)
		{
			return;
		}
		UUISliderComponent slider = base.GetSlider(10);
		slider.SetMinValue(bp_PhotoCameraConfig_C.CommonConfig.FovRange.X, false, false);
		slider.SetMaxValue(bp_PhotoCameraConfig_C.CommonConfig.FovRange.Y, false, false);
		slider.SetValue(photoCamera.VirtualCamera.Fov, false);
	}

	// Token: 0x06010E82 RID: 69250 RVA: 0x004F62CA File Offset: 0x004F44CA
	private void OnPressUpButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveUp", 1f, false);
	}

	// Token: 0x06010E83 RID: 69251 RVA: 0x004F62E1 File Offset: 0x004F44E1
	private void OnPressDownButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveUp", -1f, false);
	}

	// Token: 0x06010E84 RID: 69252 RVA: 0x004F62F8 File Offset: 0x004F44F8
	private void OnReleaseUpDownButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveUp", 0f, false);
	}

	// Token: 0x06010E85 RID: 69253 RVA: 0x004F630F File Offset: 0x004F450F
	private void OnPressRightButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveRight", 1f, false);
	}

	// Token: 0x06010E86 RID: 69254 RVA: 0x004F6326 File Offset: 0x004F4526
	private void OnPressLeftButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveRight", -1f, false);
	}

	// Token: 0x06010E87 RID: 69255 RVA: 0x004F633D File Offset: 0x004F453D
	private void OnReleaseLeftRightButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveRight", 0f, false);
	}

	// Token: 0x06010E88 RID: 69256 RVA: 0x004F6354 File Offset: 0x004F4554
	private void OnPressForwardButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveForward", 1f, false);
	}

	// Token: 0x06010E89 RID: 69257 RVA: 0x004F636B File Offset: 0x004F456B
	private void OnPressBackButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveForward", -1f, false);
	}

	// Token: 0x06010E8A RID: 69258 RVA: 0x004F6382 File Offset: 0x004F4582
	private void OnReleaseForwardBackButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveForward", 0f, false);
	}

	// Token: 0x06010E8B RID: 69259 RVA: 0x004F6399 File Offset: 0x004F4599
	private void OnPressAddButton()
	{
		this.FovValue = 1f;
	}

	// Token: 0x06010E8C RID: 69260 RVA: 0x004F63A6 File Offset: 0x004F45A6
	private void OnPressReduceButton()
	{
		this.FovValue = -1f;
	}

	// Token: 0x06010E8D RID: 69261 RVA: 0x004F63B3 File Offset: 0x004F45B3
	private void OnReleaseFovButton()
	{
		this.FovValue = 0f;
		InputDistributeController.Instance.InputAxis("PhotoFov", 0f, false);
	}

	// Token: 0x06010E8E RID: 69262 RVA: 0x004F63D8 File Offset: 0x004F45D8
	private void OnSliderFov(float value)
	{
		PhotoCamera photoCamera = this.GetPhotoCamera();
		if (photoCamera != null)
		{
			photoCamera.VirtualCamera.Fov = value;
		}
	}

	// Token: 0x06010E8F RID: 69263 RVA: 0x004F63FB File Offset: 0x004F45FB
	private void OnInputUiIncrease(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoFov", -value, false);
	}

	// Token: 0x06010E90 RID: 69264 RVA: 0x004F6424 File Offset: 0x004F4624
	private void OnInputUiReduce(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoFov", -value, false);
	}

	// Token: 0x06010E91 RID: 69265 RVA: 0x004F644D File Offset: 0x004F464D
	private void OnInputUiMoveForward(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoMoveUp", value, false);
	}

	// Token: 0x06010E92 RID: 69266 RVA: 0x004F6469 File Offset: 0x004F4669
	private void OnInputUiMoveRight(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoMoveRight", value, false);
	}

	// Token: 0x06010E93 RID: 69267 RVA: 0x004F6485 File Offset: 0x004F4685
	private void OnInputUiLookInOut(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoMoveForward", value, false);
	}

	// Token: 0x06010E94 RID: 69268 RVA: 0x004F64A1 File Offset: 0x004F46A1
	private void OnInputUiLookUp(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoPitch", -value, false);
	}

	// Token: 0x06010E95 RID: 69269 RVA: 0x004F64BE File Offset: 0x004F46BE
	private void OnInputUiTurn(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoYaw", value, false);
	}

	// Token: 0x06010E96 RID: 69270 RVA: 0x004F64DA File Offset: 0x004F46DA
	private void OnInputUiCamRotate(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoRoll", value, false);
	}

	// Token: 0x06010E97 RID: 69271 RVA: 0x004F64F6 File Offset: 0x004F46F6
	[NullableContext(2)]
	private void OnDragBegin(ULGUIPointerEventData eventData)
	{
		if (eventData == null)
		{
			return;
		}
		this.IsDragging = true;
		this.LastDragX = eventData.pointerPosition.X;
		this.LastDragY = eventData.pointerPosition.Y;
	}

	// Token: 0x06010E98 RID: 69272 RVA: 0x004F6528 File Offset: 0x004F4728
	[NullableContext(2)]
	private void OnDragMoved(ULGUIPointerEventData eventData)
	{
		if (eventData == null || !this.IsDragging)
		{
			return;
		}
		FVector pointerPosition = eventData.pointerPosition;
		this.PendingPitch += -(pointerPosition.Y - this.LastDragY) * 0.1f;
		this.PendingYaw += -(this.LastDragX - pointerPosition.X) * 0.1f;
		this.LastDragX = pointerPosition.X;
		this.LastDragY = pointerPosition.Y;
	}

	// Token: 0x06010E99 RID: 69273 RVA: 0x004F65A2 File Offset: 0x004F47A2
	[NullableContext(2)]
	private void OnDragEnded(ULGUIPointerEventData eventData)
	{
		this.IsDragging = false;
	}

	// Token: 0x06010E9A RID: 69274 RVA: 0x004F65AC File Offset: 0x004F47AC
	private void OnModeChanged()
	{
		this.InitFovSlider();
		PhotoCamera photoCamera = this.GetPhotoCamera();
		this.SyncModeToggles((photoCamera != null) ? photoCamera.CurrentMode : null);
	}

	// Token: 0x06010E9B RID: 69275 RVA: 0x004F65DF File Offset: 0x004F47DF
	private void OnBackButtonClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010E9C RID: 69276 RVA: 0x004F65E8 File Offset: 0x004F47E8
	private void OnNormalModeToggle(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			PhotoCamera photoCamera = this.GetPhotoCamera();
			this.SyncModeToggles((photoCamera != null) ? photoCamera.CurrentMode : null);
			return;
		}
		this.SyncModeToggles(new PhotoCameraType?(PhotoCameraType.Normal));
		PhotoCamera photoCamera2 = this.GetPhotoCamera();
		if (photoCamera2 == null)
		{
			return;
		}
		photoCamera2.SwitchMode(PhotoCameraType.Normal, null).Forget<bool>();
	}

	// Token: 0x06010E9D RID: 69277 RVA: 0x004F6640 File Offset: 0x004F4840
	private void OnSelfieModeToggle(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			PhotoCamera photoCamera = this.GetPhotoCamera();
			this.SyncModeToggles((photoCamera != null) ? photoCamera.CurrentMode : null);
			return;
		}
		this.SyncModeToggles(new PhotoCameraType?(PhotoCameraType.Selfie));
		PhotoCamera photoCamera2 = this.GetPhotoCamera();
		if (photoCamera2 == null)
		{
			return;
		}
		photoCamera2.SwitchMode(PhotoCameraType.Selfie, null).Forget<bool>();
	}

	// Token: 0x06010E9E RID: 69278 RVA: 0x004F6698 File Offset: 0x004F4898
	private void OnFirstPersonModeToggle(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			PhotoCamera photoCamera = this.GetPhotoCamera();
			this.SyncModeToggles((photoCamera != null) ? photoCamera.CurrentMode : null);
			return;
		}
		this.SyncModeToggles(new PhotoCameraType?(PhotoCameraType.FirstPerson));
		PhotoCamera photoCamera2 = this.GetPhotoCamera();
		if (photoCamera2 == null)
		{
			return;
		}
		photoCamera2.SwitchMode(PhotoCameraType.FirstPerson, null).Forget<bool>();
	}

	// Token: 0x06010E9F RID: 69279 RVA: 0x004F66F0 File Offset: 0x004F48F0
	private void OnDroneModeToggle(EToggleState state)
	{
		PhotoCameraType photoCameraType = (state == EToggleState.ETT_Checked) ? PhotoCameraType.Drone : PhotoCameraType.Normal;
		this.SyncModeToggles(new PhotoCameraType?(photoCameraType));
		PhotoCamera photoCamera = this.GetPhotoCamera();
		if (photoCamera == null)
		{
			return;
		}
		photoCamera.SwitchMode(photoCameraType, null).Forget<bool>();
	}

	// Token: 0x06010EA0 RID: 69280 RVA: 0x004F672C File Offset: 0x004F492C
	private void SyncModeToggles(PhotoCameraType? mode)
	{
		if (mode == null)
		{
			return;
		}
		PhotoCameraType? photoCameraType = mode;
		PhotoCameraType photoCameraType2 = PhotoCameraType.Normal;
		bool flag;
		if (!(photoCameraType.GetValueOrDefault() == photoCameraType2 & photoCameraType != null))
		{
			photoCameraType = mode;
			photoCameraType2 = PhotoCameraType.Drone;
			flag = (photoCameraType.GetValueOrDefault() == photoCameraType2 & photoCameraType != null);
		}
		else
		{
			flag = true;
		}
		bool flag2 = flag;
		UUIExtendToggle extendToggle = base.GetExtendToggle(29);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(this.ToToggleState(flag2), false, false, false);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(30);
		if (extendToggle2 != null)
		{
			photoCameraType = mode;
			photoCameraType2 = PhotoCameraType.Selfie;
			extendToggle2.SetToggleState(this.ToToggleState(photoCameraType.GetValueOrDefault() == photoCameraType2 & photoCameraType != null), false, false, false);
		}
		UUIExtendToggle extendToggle3 = base.GetExtendToggle(31);
		if (extendToggle3 != null)
		{
			photoCameraType = mode;
			photoCameraType2 = PhotoCameraType.FirstPerson;
			extendToggle3.SetToggleState(this.ToToggleState(photoCameraType.GetValueOrDefault() == photoCameraType2 & photoCameraType != null), false, false, false);
		}
		UUIExtendToggle extendToggle4 = base.GetExtendToggle(27);
		if (extendToggle4 != null)
		{
			photoCameraType = mode;
			photoCameraType2 = PhotoCameraType.Drone;
			extendToggle4.SetToggleState(this.ToToggleState(photoCameraType.GetValueOrDefault() == photoCameraType2 & photoCameraType != null), false, false, false);
		}
		if (extendToggle4 == null)
		{
			return;
		}
		extendToggle4.RootUIComp.Get().SetUIActive(flag2);
	}

	// Token: 0x06010EA1 RID: 69281 RVA: 0x004F6845 File Offset: 0x004F4A45
	private EToggleState ToToggleState(bool isChecked)
	{
		if (!isChecked)
		{
			return EToggleState.ETT_UnChecked;
		}
		return EToggleState.ETT_Checked;
	}

	// Token: 0x04009537 RID: 38199
	private const float DRAG_ROTATE_RATE = 0.1f;

	// Token: 0x04009538 RID: 38200
	private const float FOV_AXIS_VALUE = 1f;

	// Token: 0x04009539 RID: 38201
	private const float MOVE_AXIS_VALUE = 1f;

	// Token: 0x0400953A RID: 38202
	private float FovValue;

	// Token: 0x0400953B RID: 38203
	private float PendingPitch;

	// Token: 0x0400953C RID: 38204
	private float PendingYaw;

	// Token: 0x0400953D RID: 38205
	private bool IsDragging;

	// Token: 0x0400953E RID: 38206
	private float LastDragX;

	// Token: 0x0400953F RID: 38207
	private float LastDragY;

	// Token: 0x02007D5D RID: 32093
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04028947 RID: 166215
		public const int UpButton = 0;

		// Token: 0x04028948 RID: 166216
		public const int DownButton = 1;

		// Token: 0x04028949 RID: 166217
		public const int LeftButton = 2;

		// Token: 0x0402894A RID: 166218
		public const int RightButton = 3;

		// Token: 0x0402894B RID: 166219
		public const int AddButton = 4;

		// Token: 0x0402894C RID: 166220
		public const int ReduceButton = 5;

		// Token: 0x0402894D RID: 166221
		public const int FovBarSprite = 6;

		// Token: 0x0402894E RID: 166222
		public const int ResetButton = 7;

		// Token: 0x0402894F RID: 166223
		public const int PhotographButton = 8;

		// Token: 0x04028950 RID: 166224
		public const int BackButton = 9;

		// Token: 0x04028951 RID: 166225
		public const int CameraFovSlider = 10;

		// Token: 0x04028952 RID: 166226
		public const int HideItem = 11;

		// Token: 0x04028953 RID: 166227
		public const int PanelLeft = 12;

		// Token: 0x04028954 RID: 166228
		public const int ControlScreenDraggable = 13;

		// Token: 0x04028955 RID: 166229
		public const int SetButton = 14;

		// Token: 0x04028956 RID: 166230
		public const int EntityPanel = 15;

		// Token: 0x04028957 RID: 166231
		public const int PanelContent = 16;

		// Token: 0x04028958 RID: 166232
		public const int PanelTitle = 17;

		// Token: 0x04028959 RID: 166233
		public const int VisibleButton = 18;

		// Token: 0x0402895A RID: 166234
		public const int RedDot = 19;

		// Token: 0x0402895B RID: 166235
		public const int PanelKeyNormal = 20;

		// Token: 0x0402895C RID: 166236
		public const int ForwardBtn = 21;

		// Token: 0x0402895D RID: 166237
		public const int BackBtn = 22;

		// Token: 0x0402895E RID: 166238
		public const int PlayerInfoMark = 23;

		// Token: 0x0402895F RID: 166239
		public const int CameraMovePanel = 24;

		// Token: 0x04028960 RID: 166240
		public const int CharacterMovePanel = 25;

		// Token: 0x04028961 RID: 166241
		public const int CharacterMoveJoystick = 26;

		// Token: 0x04028962 RID: 166242
		public const int DroneModeToggle = 27;

		// Token: 0x04028963 RID: 166243
		public const int OverturnBtn = 28;

		// Token: 0x04028964 RID: 166244
		public const int NormalModeToggle = 29;

		// Token: 0x04028965 RID: 166245
		public const int SelfieModeToggle = 30;

		// Token: 0x04028966 RID: 166246
		public const int FirstPersonModeToggle = 31;
	}
}
