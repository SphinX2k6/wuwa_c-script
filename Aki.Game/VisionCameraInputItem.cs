using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001981 RID: 6529
[NullableContext(1)]
[Nullable(0)]
public class VisionCameraInputItem : UiPanelBase
{
	// Token: 0x060101B1 RID: 65969 RVA: 0x004B2253 File Offset: 0x004B0453
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent))
		};
	}

	// Token: 0x060101B2 RID: 65970 RVA: 0x004B2278 File Offset: 0x004B0478
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

	// Token: 0x060101B3 RID: 65971 RVA: 0x004B23AC File Offset: 0x004B05AC
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

	// Token: 0x060101B4 RID: 65972 RVA: 0x004B24B4 File Offset: 0x004B06B4
	protected override void OnStart()
	{
		this.InitCameraComponent();
	}

	// Token: 0x060101B5 RID: 65973 RVA: 0x004B24BC File Offset: 0x004B06BC
	protected override void OnBeforeShow()
	{
		this.OnActivateUiCameraAnimationHandle(null);
		this.OnAddEventListener();
	}

	// Token: 0x060101B6 RID: 65974 RVA: 0x004B24CB File Offset: 0x004B06CB
	protected override void OnBeforeHide()
	{
		UiCameraInputComponent uiCameraInputComponent = this.UiCameraInputComponent;
		if (uiCameraInputComponent != null)
		{
			uiCameraInputComponent.Deactivate();
		}
		this.OnRemoveEventListener();
		this.CanCameraInput = false;
	}

	// Token: 0x060101B7 RID: 65975 RVA: 0x004B24EB File Offset: 0x004B06EB
	protected override void OnBeforeDestroy()
	{
		this.DestroyCameraComponent();
	}

	// Token: 0x060101B8 RID: 65976 RVA: 0x004B24F3 File Offset: 0x004B06F3
	public void OnPlayCameraAnimationStart(UiCameraHandleData uiCameraHandleData, UiCameraHandleData cameraHandleData, string arg3)
	{
		this.Pause();
	}

	// Token: 0x060101B9 RID: 65977 RVA: 0x004B24FB File Offset: 0x004B06FB
	public void Pause()
	{
		this.CanCameraInput = false;
		UiCameraInputComponent uiCameraInputComponent = this.UiCameraInputComponent;
		if (uiCameraInputComponent == null)
		{
			return;
		}
		uiCameraInputComponent.PauseTick();
	}

	// Token: 0x060101BA RID: 65978 RVA: 0x004B2514 File Offset: 0x004B0714
	private void InitCameraComponent()
	{
		UiCamera orCreateCamera = UiCameraModel.Instance.GetOrCreateCamera();
		this.UiCameraInputComponent = orCreateCamera.GetUiCameraComponent<UiCameraInputComponent>();
		this.UiCameraLogicComponent = orCreateCamera.GetUiCameraComponent<UiCameraLogicComponent>();
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig("声骸");
		this.UiCameraLogicComponent.InitDataByConfig(roleCameraConfig.Value);
	}

	// Token: 0x060101BB RID: 65979 RVA: 0x004B2566 File Offset: 0x004B0766
	private void DestroyCameraComponent()
	{
		UiCameraModel.Instance.GetOrCreateCamera();
		UiCameraInputComponent uiCameraInputComponent = this.UiCameraInputComponent;
		if (uiCameraInputComponent != null)
		{
			uiCameraInputComponent.Deactivate();
		}
		this.UiCameraInputComponent = null;
		this.UiCameraLogicComponent = null;
	}

	// Token: 0x060101BC RID: 65980 RVA: 0x004B2594 File Offset: 0x004B0794
	public void OnActivateUiCameraAnimationHandle(UiCameraHandleData uiCameraHandleData)
	{
		this.CanCameraInput = this.CheckCanCameraInput();
		if (this.CanCameraInput && this.UiCameraInputComponent != null && this.UiCameraLogicComponent != null)
		{
			FVectorDouble sourceLocation = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("MonsterCase").Value, ECollectActorType.UI).D_K2_GetActorLocation();
			this.UiCameraLogicComponent.UpdateData(sourceLocation, 0f, 0f, 0f, 0f);
			this.UiCameraInputComponent.Activate();
			this.UiCameraInputComponent.ResumeTick();
		}
	}

	// Token: 0x060101BD RID: 65981 RVA: 0x004B2619 File Offset: 0x004B0819
	private bool CheckCanCameraInput()
	{
		return !UiCameraModel.Instance.IsPlayingAnimation();
	}

	// Token: 0x060101BE RID: 65982 RVA: 0x004B2628 File Offset: 0x004B0828
	[NullableContext(2)]
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!this.CanCameraInput)
		{
			return;
		}
		this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
	}

	// Token: 0x060101BF RID: 65983 RVA: 0x004B2644 File Offset: 0x004B0844
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
			this.UiCameraInputComponent.AddYawInput(num);
		}
		float num2 = this.CurrentDragPosition.Value.Y - currentDragPosition.Value.Y;
		if (num2 != 0f && this.CanPitchInput)
		{
			this.UiCameraInputComponent.AddPitchInput(num2);
		}
	}

	// Token: 0x060101C0 RID: 65984 RVA: 0x004B2712 File Offset: 0x004B0912
	[NullableContext(2)]
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!this.CanCameraInput)
		{
			return;
		}
		this.CurrentDragPosition = null;
	}

	// Token: 0x060101C1 RID: 65985 RVA: 0x004B2729 File Offset: 0x004B0929
	private void OnInputUiLookUp(string axisName, float value, InputIdentification _)
	{
		if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad() || !this.CanPitchInput)
		{
			return;
		}
		this.UiCameraInputComponent.AddPitchInput(-value);
	}

	// Token: 0x060101C2 RID: 65986 RVA: 0x004B275D File Offset: 0x004B095D
	private void OnInputUiTurn(string axisName, float value, InputIdentification _)
	{
		if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraInputComponent.AddYawInput(value);
	}

	// Token: 0x060101C3 RID: 65987 RVA: 0x004B2788 File Offset: 0x004B0988
	[NullableContext(2)]
	private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
	{
		if (!this.CanCameraInput)
		{
			return;
		}
		if (eventData.scrollAxisValue != 0f)
		{
			this.UiCameraInputComponent.AddZoomInput(-eventData.scrollAxisValue);
		}
	}

	// Token: 0x060101C4 RID: 65988 RVA: 0x004B27B2 File Offset: 0x004B09B2
	private void OnInputUiIncrease(string axisName, float value, InputIdentification _)
	{
		if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraInputComponent.AddZoomInput(value);
	}

	// Token: 0x060101C5 RID: 65989 RVA: 0x004B27DD File Offset: 0x004B09DD
	private void OnInputUiReduce(string axisName, float value, InputIdentification _)
	{
		if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraInputComponent.AddZoomInput(value);
	}

	// Token: 0x060101C6 RID: 65990 RVA: 0x004B2808 File Offset: 0x004B0A08
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

	// Token: 0x060101C7 RID: 65991 RVA: 0x004B2824 File Offset: 0x004B0A24
	private void TouchMoved()
	{
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
			this.UiCameraInputComponent.AddZoomInput(-fingerExpandCloseValue);
		}
	}

	// Token: 0x04008EF1 RID: 36593
	private bool CanCameraInput;

	// Token: 0x04008EF2 RID: 36594
	public bool CanPitchInput;

	// Token: 0x04008EF3 RID: 36595
	[Nullable(2)]
	private UiCameraInputComponent UiCameraInputComponent;

	// Token: 0x04008EF4 RID: 36596
	[Nullable(2)]
	private UiCameraLogicComponent UiCameraLogicComponent;

	// Token: 0x04008EF5 RID: 36597
	private FVector? CurrentDragPosition;

	// Token: 0x02007BA3 RID: 31651
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040280AD RID: 164013
		DragItem
	}
}
