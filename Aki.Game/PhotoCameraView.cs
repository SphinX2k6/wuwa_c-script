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

// Token: 0x020025C4 RID: 9668
[NullableContext(1)]
[Nullable(0)]
public class PhotoCameraView : UiTickViewBase
{
	// Token: 0x06013998 RID: 80280 RVA: 0x004E6AD4 File Offset: 0x004E4CD4
	public PhotoCameraView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013999 RID: 80281 RVA: 0x004E6AE0 File Offset: 0x004E4CE0
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

	// Token: 0x0601399A RID: 80282 RVA: 0x004E6E40 File Offset: 0x004E5040
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

	// Token: 0x0601399B RID: 80283 RVA: 0x004E6EA1 File Offset: 0x004E50A1
	protected override void OnBeforeDestroy()
	{
		PhotoCamera photoCamera = this.GetPhotoCamera();
		if (photoCamera != null)
		{
			photoCamera.SetModeChangedCallback(null);
		}
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitPhotoCamera();
	}

	// Token: 0x0601399C RID: 80284 RVA: 0x004E6ED0 File Offset: 0x004E50D0
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

	// Token: 0x0601399D RID: 80285 RVA: 0x004E72D0 File Offset: 0x004E54D0
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

	// Token: 0x0601399E RID: 80286 RVA: 0x004E7520 File Offset: 0x004E5720
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

	// Token: 0x0601399F RID: 80287 RVA: 0x004E75AC File Offset: 0x004E57AC
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

	// Token: 0x060139A0 RID: 80288 RVA: 0x004E762E File Offset: 0x004E582E
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

	// Token: 0x060139A1 RID: 80289 RVA: 0x004E765C File Offset: 0x004E585C
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

	// Token: 0x060139A2 RID: 80290 RVA: 0x004E76CA File Offset: 0x004E58CA
	private void OnPressUpButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveUp", 1f, false);
	}

	// Token: 0x060139A3 RID: 80291 RVA: 0x004E76E1 File Offset: 0x004E58E1
	private void OnPressDownButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveUp", -1f, false);
	}

	// Token: 0x060139A4 RID: 80292 RVA: 0x004E76F8 File Offset: 0x004E58F8
	private void OnReleaseUpDownButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveUp", 0f, false);
	}

	// Token: 0x060139A5 RID: 80293 RVA: 0x004E770F File Offset: 0x004E590F
	private void OnPressRightButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveRight", 1f, false);
	}

	// Token: 0x060139A6 RID: 80294 RVA: 0x004E7726 File Offset: 0x004E5926
	private void OnPressLeftButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveRight", -1f, false);
	}

	// Token: 0x060139A7 RID: 80295 RVA: 0x004E773D File Offset: 0x004E593D
	private void OnReleaseLeftRightButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveRight", 0f, false);
	}

	// Token: 0x060139A8 RID: 80296 RVA: 0x004E7754 File Offset: 0x004E5954
	private void OnPressForwardButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveForward", 1f, false);
	}

	// Token: 0x060139A9 RID: 80297 RVA: 0x004E776B File Offset: 0x004E596B
	private void OnPressBackButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveForward", -1f, false);
	}

	// Token: 0x060139AA RID: 80298 RVA: 0x004E7782 File Offset: 0x004E5982
	private void OnReleaseForwardBackButton()
	{
		InputDistributeController.Instance.InputAxis("PhotoMoveForward", 0f, false);
	}

	// Token: 0x060139AB RID: 80299 RVA: 0x004E7799 File Offset: 0x004E5999
	private void OnPressAddButton()
	{
		this.FovValue = 1f;
	}

	// Token: 0x060139AC RID: 80300 RVA: 0x004E77A6 File Offset: 0x004E59A6
	private void OnPressReduceButton()
	{
		this.FovValue = -1f;
	}

	// Token: 0x060139AD RID: 80301 RVA: 0x004E77B3 File Offset: 0x004E59B3
	private void OnReleaseFovButton()
	{
		this.FovValue = 0f;
		InputDistributeController.Instance.InputAxis("PhotoFov", 0f, false);
	}

	// Token: 0x060139AE RID: 80302 RVA: 0x004E77D8 File Offset: 0x004E59D8
	private void OnSliderFov(float value)
	{
		PhotoCamera photoCamera = this.GetPhotoCamera();
		if (photoCamera != null)
		{
			photoCamera.VirtualCamera.Fov = value;
		}
	}

	// Token: 0x060139AF RID: 80303 RVA: 0x004E77FB File Offset: 0x004E59FB
	private void OnInputUiIncrease(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoFov", -value, false);
	}

	// Token: 0x060139B0 RID: 80304 RVA: 0x004E7824 File Offset: 0x004E5A24
	private void OnInputUiReduce(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoFov", -value, false);
	}

	// Token: 0x060139B1 RID: 80305 RVA: 0x004E784D File Offset: 0x004E5A4D
	private void OnInputUiMoveForward(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoMoveUp", value, false);
	}

	// Token: 0x060139B2 RID: 80306 RVA: 0x004E7869 File Offset: 0x004E5A69
	private void OnInputUiMoveRight(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoMoveRight", value, false);
	}

	// Token: 0x060139B3 RID: 80307 RVA: 0x004E7885 File Offset: 0x004E5A85
	private void OnInputUiLookInOut(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoMoveForward", value, false);
	}

	// Token: 0x060139B4 RID: 80308 RVA: 0x004E78A1 File Offset: 0x004E5AA1
	private void OnInputUiLookUp(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoPitch", -value, false);
	}

	// Token: 0x060139B5 RID: 80309 RVA: 0x004E78BE File Offset: 0x004E5ABE
	private void OnInputUiTurn(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoYaw", value, false);
	}

	// Token: 0x060139B6 RID: 80310 RVA: 0x004E78DA File Offset: 0x004E5ADA
	private void OnInputUiCamRotate(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoRoll", value, false);
	}

	// Token: 0x060139B7 RID: 80311 RVA: 0x004E78F6 File Offset: 0x004E5AF6
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

	// Token: 0x060139B8 RID: 80312 RVA: 0x004E7928 File Offset: 0x004E5B28
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

	// Token: 0x060139B9 RID: 80313 RVA: 0x004E79A2 File Offset: 0x004E5BA2
	[NullableContext(2)]
	private void OnDragEnded(ULGUIPointerEventData eventData)
	{
		this.IsDragging = false;
	}

	// Token: 0x060139BA RID: 80314 RVA: 0x004E79AC File Offset: 0x004E5BAC
	private void OnModeChanged()
	{
		this.InitFovSlider();
		PhotoCamera photoCamera = this.GetPhotoCamera();
		this.SyncModeToggles((photoCamera != null) ? photoCamera.CurrentMode : null);
	}

	// Token: 0x060139BB RID: 80315 RVA: 0x004E79DF File Offset: 0x004E5BDF
	private void OnBackButtonClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x060139BC RID: 80316 RVA: 0x004E79E8 File Offset: 0x004E5BE8
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

	// Token: 0x060139BD RID: 80317 RVA: 0x004E7A40 File Offset: 0x004E5C40
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

	// Token: 0x060139BE RID: 80318 RVA: 0x004E7A98 File Offset: 0x004E5C98
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

	// Token: 0x060139BF RID: 80319 RVA: 0x004E7AF0 File Offset: 0x004E5CF0
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

	// Token: 0x060139C0 RID: 80320 RVA: 0x004E7B2C File Offset: 0x004E5D2C
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

	// Token: 0x060139C1 RID: 80321 RVA: 0x004E7C45 File Offset: 0x004E5E45
	private EToggleState ToToggleState(bool isChecked)
	{
		if (!isChecked)
		{
			return EToggleState.ETT_UnChecked;
		}
		return EToggleState.ETT_Checked;
	}

	// Token: 0x040093E1 RID: 37857
	private const float DRAG_ROTATE_RATE = 0.1f;

	// Token: 0x040093E2 RID: 37858
	private const float FOV_AXIS_VALUE = 1f;

	// Token: 0x040093E3 RID: 37859
	private const float MOVE_AXIS_VALUE = 1f;

	// Token: 0x040093E4 RID: 37860
	private float FovValue;

	// Token: 0x040093E5 RID: 37861
	private float PendingPitch;

	// Token: 0x040093E6 RID: 37862
	private float PendingYaw;

	// Token: 0x040093E7 RID: 37863
	private bool IsDragging;

	// Token: 0x040093E8 RID: 37864
	private float LastDragX;

	// Token: 0x040093E9 RID: 37865
	private float LastDragY;

	// Token: 0x02008BD5 RID: 35797
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402D632 RID: 185906
		public const int UpButton = 0;

		// Token: 0x0402D633 RID: 185907
		public const int DownButton = 1;

		// Token: 0x0402D634 RID: 185908
		public const int LeftButton = 2;

		// Token: 0x0402D635 RID: 185909
		public const int RightButton = 3;

		// Token: 0x0402D636 RID: 185910
		public const int AddButton = 4;

		// Token: 0x0402D637 RID: 185911
		public const int ReduceButton = 5;

		// Token: 0x0402D638 RID: 185912
		public const int FovBarSprite = 6;

		// Token: 0x0402D639 RID: 185913
		public const int ResetButton = 7;

		// Token: 0x0402D63A RID: 185914
		public const int PhotographButton = 8;

		// Token: 0x0402D63B RID: 185915
		public const int BackButton = 9;

		// Token: 0x0402D63C RID: 185916
		public const int CameraFovSlider = 10;

		// Token: 0x0402D63D RID: 185917
		public const int HideItem = 11;

		// Token: 0x0402D63E RID: 185918
		public const int PanelLeft = 12;

		// Token: 0x0402D63F RID: 185919
		public const int ControlScreenDraggable = 13;

		// Token: 0x0402D640 RID: 185920
		public const int SetButton = 14;

		// Token: 0x0402D641 RID: 185921
		public const int EntityPanel = 15;

		// Token: 0x0402D642 RID: 185922
		public const int PanelContent = 16;

		// Token: 0x0402D643 RID: 185923
		public const int PanelTitle = 17;

		// Token: 0x0402D644 RID: 185924
		public const int VisibleButton = 18;

		// Token: 0x0402D645 RID: 185925
		public const int RedDot = 19;

		// Token: 0x0402D646 RID: 185926
		public const int PanelKeyNormal = 20;

		// Token: 0x0402D647 RID: 185927
		public const int ForwardBtn = 21;

		// Token: 0x0402D648 RID: 185928
		public const int BackBtn = 22;

		// Token: 0x0402D649 RID: 185929
		public const int PlayerInfoMark = 23;

		// Token: 0x0402D64A RID: 185930
		public const int CameraMovePanel = 24;

		// Token: 0x0402D64B RID: 185931
		public const int CharacterMovePanel = 25;

		// Token: 0x0402D64C RID: 185932
		public const int CharacterMoveJoystick = 26;

		// Token: 0x0402D64D RID: 185933
		public const int DroneModeToggle = 27;

		// Token: 0x0402D64E RID: 185934
		public const int OverturnBtn = 28;

		// Token: 0x0402D64F RID: 185935
		public const int NormalModeToggle = 29;

		// Token: 0x0402D650 RID: 185936
		public const int SelfieModeToggle = 30;

		// Token: 0x0402D651 RID: 185937
		public const int FirstPersonModeToggle = 31;
	}
}
