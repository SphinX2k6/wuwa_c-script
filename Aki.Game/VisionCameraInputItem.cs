using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200249A RID: 9370
[NullableContext(1)]
[Nullable(0)]
public class VisionCameraInputItem : UiPanelBase
{
	// Token: 0x06012CF0 RID: 77040 RVA: 0x004A4763 File Offset: 0x004A2963
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent))
		};
	}

	// Token: 0x06012CF1 RID: 77041 RVA: 0x004A4788 File Offset: 0x004A2988
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add<UiCameraHandleData, UiCameraHandleData, string>(EEventName.OnPlayCameraAnimationStart, new Action<UiCameraHandleData, UiCameraHandleData, string>(this.OnPlayCameraAnimationStart));
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		UUIDraggableComponent draggable = base.GetDraggable(0);
		draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
		draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
		draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDragCallBack));
		draggable.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScrollCallBack));
		InputDistributeController.Instance.BindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
		InputDistributeController.Instance.BindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
		InputDistributeController.Instance.BindAxis("UiIncrease", new TInputHandle<float>(this.OnInputUiIncrease));
		InputDistributeController.Instance.BindAxis("UiReduce", new TInputHandle<float>(this.OnInputUiReduce));
		InputDistributeController.Instance.BindTouches(new int[]
		{
			0,
			1
		}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
	}

	// Token: 0x06012CF2 RID: 77042 RVA: 0x004A48BC File Offset: 0x004A2ABC
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPlayCameraAnimationStart, new Action<UiCameraHandleData, UiCameraHandleData, string>(this.OnPlayCameraAnimationStart));
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		UUIDraggableComponent draggable = base.GetDraggable(0);
		draggable.OnPointerBeginDragCallBack.Unbind();
		draggable.OnPointerDragCallBack.Unbind();
		draggable.OnPointerEndDragCallBack.Unbind();
		draggable.OnPointerScrollCallBack.Unbind();
		InputDistributeController.Instance.UnBindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
		InputDistributeController.Instance.UnBindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
		InputDistributeController.Instance.UnBindAxis("UiIncrease", new TInputHandle<float>(this.OnInputUiIncrease));
		InputDistributeController.Instance.UnBindAxis("UiReduce", new TInputHandle<float>(this.OnInputUiReduce));
		InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlyArray<int>(new int[]
		{
			0,
			1
		}), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
	}

	// Token: 0x06012CF3 RID: 77043 RVA: 0x004A49C4 File Offset: 0x004A2BC4
	protected override void OnStart()
	{
		this.InitCameraComponent();
	}

	// Token: 0x06012CF4 RID: 77044 RVA: 0x004A49CC File Offset: 0x004A2BCC
	protected override void OnBeforeShow()
	{
		this.OnActivateUiCameraAnimationHandle(null);
		this.OnAddEventListener();
	}

	// Token: 0x06012CF5 RID: 77045 RVA: 0x004A49DB File Offset: 0x004A2BDB
	protected override void OnBeforeHide()
	{
		UiCameraControlRotationComponent uiCameraControlRotationComponent = this.UiCameraControlRotationComponent;
		if (uiCameraControlRotationComponent != null)
		{
			uiCameraControlRotationComponent.Deactivate();
		}
		this.OnRemoveEventListener();
		this.CanCameraInput = false;
	}

	// Token: 0x06012CF6 RID: 77046 RVA: 0x004A49FB File Offset: 0x004A2BFB
	protected override void OnBeforeDestroy()
	{
		this.DestroyCameraComponent();
	}

	// Token: 0x06012CF7 RID: 77047 RVA: 0x004A4A03 File Offset: 0x004A2C03
	public void OnPlayCameraAnimationStart(UiCameraHandleData uiCameraHandleData, UiCameraHandleData cameraHandleData, string arg3)
	{
		this.Pause();
	}

	// Token: 0x06012CF8 RID: 77048 RVA: 0x004A4A0B File Offset: 0x004A2C0B
	public void Pause()
	{
		this.CanCameraInput = false;
		UiCameraControlRotationComponent uiCameraControlRotationComponent = this.UiCameraControlRotationComponent;
		if (uiCameraControlRotationComponent == null)
		{
			return;
		}
		uiCameraControlRotationComponent.PauseTick();
	}

	// Token: 0x06012CF9 RID: 77049 RVA: 0x004A4A24 File Offset: 0x004A2C24
	private void InitCameraComponent()
	{
		UiCamera uiCamera = UiCameraManager.Get();
		this.UiCameraControlRotationComponent = (uiCamera.AddUiCameraComponent(typeof(UiCameraControlRotationComponent), false) as UiCameraControlRotationComponent);
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig("声骸");
		this.UiCameraControlRotationComponent.InitDataByConfig(roleCameraConfig.Value);
	}

	// Token: 0x06012CFA RID: 77050 RVA: 0x004A4A75 File Offset: 0x004A2C75
	private void DestroyCameraComponent()
	{
		UiCameraManager.Get().DestroyUiCameraComponent(typeof(UiCameraControlRotationComponent));
		this.UiCameraControlRotationComponent = null;
	}

	// Token: 0x06012CFB RID: 77051 RVA: 0x004A4A94 File Offset: 0x004A2C94
	public void OnActivateUiCameraAnimationHandle(UiCameraHandleData uiCameraHandleData)
	{
		this.CanCameraInput = this.CheckCanCameraInput();
		if (this.CanCameraInput && this.UiCameraControlRotationComponent != null)
		{
			FVectorDouble sourceLocation = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("MonsterCase").Value, ECollectActorType.UI).D_K2_GetActorLocation();
			this.UiCameraControlRotationComponent.UpdateData(sourceLocation, 0f, 0f, 0f, 0f);
			this.UiCameraControlRotationComponent.Activate();
			this.UiCameraControlRotationComponent.ResumeTick();
		}
	}

	// Token: 0x06012CFC RID: 77052 RVA: 0x004A4B11 File Offset: 0x004A2D11
	private bool CheckCanCameraInput()
	{
		return !UiCameraAnimationManager.Instance.IsPlayingAnimation();
	}

	// Token: 0x06012CFD RID: 77053 RVA: 0x004A4B20 File Offset: 0x004A2D20
	[NullableContext(2)]
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!this.CanCameraInput)
		{
			return;
		}
		this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
	}

	// Token: 0x06012CFE RID: 77054 RVA: 0x004A4B3C File Offset: 0x004A2D3C
	[NullableContext(2)]
	private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!this.CanCameraInput || TouchFingerManager.Instance.GetTouchFingerCount() > 1 || InputSettings.Instance.IsInputKeyDown("RightMouseButton"))
		{
			this.CurrentDragPosition = null;
			return;
		}
		FVector? currentDragPosition = this.CurrentDragPosition;
		this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		if (currentDragPosition == null)
		{
			return;
		}
		float num = this.CurrentDragPosition.Value.X - currentDragPosition.Value.X;
		if (num != 0f)
		{
			this.UiCameraControlRotationComponent.AddYawInput(num);
		}
		float num2 = this.CurrentDragPosition.Value.Y - currentDragPosition.Value.Y;
		if (num2 != 0f && this.CanPitchInput)
		{
			this.UiCameraControlRotationComponent.AddPitchInput(num2);
		}
	}

	// Token: 0x06012CFF RID: 77055 RVA: 0x004A4C0A File Offset: 0x004A2E0A
	[NullableContext(2)]
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!this.CanCameraInput)
		{
			return;
		}
		this.CurrentDragPosition = null;
	}

	// Token: 0x06012D00 RID: 77056 RVA: 0x004A4C21 File Offset: 0x004A2E21
	private void OnInputUiLookUp(string axisName, float value, InputIdentification _)
	{
		if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad() || !this.CanPitchInput)
		{
			return;
		}
		this.UiCameraControlRotationComponent.AddPitchInput(-value);
	}

	// Token: 0x06012D01 RID: 77057 RVA: 0x004A4C55 File Offset: 0x004A2E55
	private void OnInputUiTurn(string axisName, float value, InputIdentification _)
	{
		if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraControlRotationComponent.AddYawInput(value);
	}

	// Token: 0x06012D02 RID: 77058 RVA: 0x004A4C80 File Offset: 0x004A2E80
	[NullableContext(2)]
	private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
	{
		if (!this.CanCameraInput)
		{
			return;
		}
		if (eventData.scrollAxisValue != 0f)
		{
			this.UiCameraControlRotationComponent.AddZoomInput(-eventData.scrollAxisValue);
		}
	}

	// Token: 0x06012D03 RID: 77059 RVA: 0x004A4CAA File Offset: 0x004A2EAA
	private void OnInputUiIncrease(string axisName, float value, InputIdentification _)
	{
		if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraControlRotationComponent.AddZoomInput(value);
	}

	// Token: 0x06012D04 RID: 77060 RVA: 0x004A4CD5 File Offset: 0x004A2ED5
	private void OnInputUiReduce(string axisName, float value, InputIdentification _)
	{
		if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraControlRotationComponent.AddZoomInput(value);
	}

	// Token: 0x06012D05 RID: 77061 RVA: 0x004A4D00 File Offset: 0x004A2F00
	private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
	{
		if (!this.CanCameraInput)
		{
			return;
		}
		if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchMove)
		{
			this.TouchMoved();
		}
	}

	// Token: 0x06012D06 RID: 77062 RVA: 0x004A4D1C File Offset: 0x004A2F1C
	private void TouchMoved()
	{
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
			this.UiCameraControlRotationComponent.AddZoomInput(-fingerExpandCloseValue);
		}
	}

	// Token: 0x04008DA8 RID: 36264
	private bool CanCameraInput;

	// Token: 0x04008DA9 RID: 36265
	public bool CanPitchInput;

	// Token: 0x04008DAA RID: 36266
	[Nullable(2)]
	private UiCameraControlRotationComponent UiCameraControlRotationComponent;

	// Token: 0x04008DAB RID: 36267
	private FVector? CurrentDragPosition;

	// Token: 0x02008A19 RID: 35353
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CD8D RID: 183693
		DragItem
	}
}
