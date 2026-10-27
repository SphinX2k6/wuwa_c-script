using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200257E RID: 9598
[NullableContext(1)]
[Nullable(0)]
public class PhotoMainView : UiTickViewBase
{
	// Token: 0x17001903 RID: 6403
	// (get) Token: 0x06013663 RID: 79459 RVA: 0x004D43A2 File Offset: 0x004D25A2
	private bool IsStickerSelected
	{
		get
		{
			return this.JoystickOwner.Current == EPhotoJoystickOwner.Sticker;
		}
	}

	// Token: 0x17001904 RID: 6404
	// (get) Token: 0x06013664 RID: 79460 RVA: 0x004D43B2 File Offset: 0x004D25B2
	private bool IsCursorMode
	{
		get
		{
			return this.JoystickOwner.Current == EPhotoJoystickOwner.Cursor;
		}
	}

	// Token: 0x06013665 RID: 79461 RVA: 0x004D43C2 File Offset: 0x004D25C2
	public PhotoMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013666 RID: 79462 RVA: 0x004D43FC File Offset: 0x004D25FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUITexture)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(12, new Action(this.OnCursorFocusClick))
		};
	}

	// Token: 0x06013667 RID: 79463 RVA: 0x004D4614 File Offset: 0x004D2814
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoMainView.<OnBeforeStartAsync>d__45 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoMainView.<OnBeforeStartAsync>d__45>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013668 RID: 79464 RVA: 0x004D4658 File Offset: 0x004D2858
	protected override void OnStart()
	{
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnRequestClose = (Action)Delegate.Combine(viewModel.OnRequestClose, new Action(this.OnRequestClose));
		PhotoMainViewModel viewModel2 = this.ViewModel;
		viewModel2.OnRequestHideUi = (Action)Delegate.Combine(viewModel2.OnRequestHideUi, new Action(this.OnRequestHideUi));
		PhotoMainViewModel viewModel3 = this.ViewModel;
		viewModel3.OnRequestCreateSticker = (Action<PhotoSticker>)Delegate.Combine(viewModel3.OnRequestCreateSticker, new Action<PhotoSticker>(this.OnRequestCreateSticker));
		PhotoMainViewModel viewModel4 = this.ViewModel;
		viewModel4.OnRequestRemoveSticker = (Action)Delegate.Combine(viewModel4.OnRequestRemoveSticker, new Action(this.OnRequestRemoveSticker));
		PhotoMainViewModel viewModel5 = this.ViewModel;
		viewModel5.OnStickerSelectedChanged = (Action<bool>)Delegate.Combine(viewModel5.OnStickerSelectedChanged, new Action<bool>(this.OnStickerSelectedChanged));
		PhotoMainViewModel viewModel6 = this.ViewModel;
		viewModel6.OnFrameSelected = (Action<int>)Delegate.Combine(viewModel6.OnFrameSelected, new Action<int>(this.OnFrameSelected));
		this.ViewModel.OnRequestPlaySwitchModeAnim = new Func<PhotoCameraType, UniTask>(this.PlaySwitchModeAnimAsync);
		this.ViewModel.OnRequestWaitSwitchModeAnimEnd = new Func<PhotoCameraType, UniTask>(this.WaitSwitchModeAnimEndAsync);
		PhotoMainViewModel viewModel7 = this.ViewModel;
		viewModel7.OnDetailPanelClosed = (Action)Delegate.Combine(viewModel7.OnDetailPanelClosed, new Action(this.OnDetailPanelClosed));
		PhotoMainViewModel viewModel8 = this.ViewModel;
		viewModel8.OnDetailPanelOpened = (Action)Delegate.Combine(viewModel8.OnDetailPanelOpened, new Action(this.OnDetailPanelOpened));
		PhotoMainViewModel viewModel9 = this.ViewModel;
		viewModel9.OnModeChanged = (Action<PhotoCameraType>)Delegate.Combine(viewModel9.OnModeChanged, new Action<PhotoCameraType>(this.OnModeChanged));
		PhotographController instance = PhotographController.Instance;
		instance.OnAuxiliaryLineChanged = (Action<bool>)Delegate.Combine(instance.OnAuxiliaryLineChanged, new Action<bool>(this.SetAuxiliaryLineVisible));
		PhotographController instance2 = PhotographController.Instance;
		instance2.OnRequestOpenLastDetailPanel = (Action)Delegate.Combine(instance2.OnRequestOpenLastDetailPanel, new Action(this.OnRequestOpenLastDetailPanel));
		PhotographController instance3 = PhotographController.Instance;
		instance3.OnRequestSelectSticker = (Action)Delegate.Combine(instance3.OnRequestSelectSticker, new Action(this.OnRequestSelectSticker));
		PhotographController instance4 = PhotographController.Instance;
		instance4.OnRequestDeselectSticker = (Action)Delegate.Combine(instance4.OnRequestDeselectSticker, new Action(this.OnRequestDeselectSticker));
		PhotographController instance5 = PhotographController.Instance;
		instance5.OnRequestChangeStickerScale = (Action<float>)Delegate.Combine(instance5.OnRequestChangeStickerScale, new Action<float>(this.OnRequestChangeStickerScale));
		this.SetAuxiliaryLineVisible(PhotographController.Instance.IsAuxiliaryLineOn());
		PhotographController instance6 = PhotographController.Instance;
		instance6.OnManualFocusChanged = (Action<bool>)Delegate.Combine(instance6.OnManualFocusChanged, new Action<bool>(this.OnManualFocusChanged));
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		PhotoCamera photoCamera = PhotographController.Instance.GetPhotoCamera();
		if (photoCamera != null)
		{
			PhotoCamera photoCamera2 = photoCamera;
			photoCamera2.OnTiltRollChanged = (Action<float>)Delegate.Combine(photoCamera2.OnTiltRollChanged, new Action<float>(this.OnCameraTiltRollChanged));
			PhotoCamera photoCamera3 = photoCamera;
			photoCamera3.OnTemplateDepthOfFieldChanged = (Action<float, float>)Delegate.Combine(photoCamera3.OnTemplateDepthOfFieldChanged, new Action<float, float>(this.OnTemplateDepthOfFieldChanged));
		}
	}

	// Token: 0x06013669 RID: 79465 RVA: 0x004D494B File Offset: 0x004D2B4B
	private void OnCameraTiltRollChanged(float roll)
	{
		PhotographController.Instance.OnCameraTiltRollChanged(roll);
	}

	// Token: 0x0601366A RID: 79466 RVA: 0x004D4958 File Offset: 0x004D2B58
	private void OnTemplateDepthOfFieldChanged(float focusDistance, float aperture)
	{
		PhotographController.Instance.OnTemplateDepthOfFieldChanged(focusDistance, aperture);
	}

	// Token: 0x0601366B RID: 79467 RVA: 0x004D4966 File Offset: 0x004D2B66
	private void OnRequestOpenLastDetailPanel()
	{
		PhotoLeftPanel leftPanel = this.LeftPanel;
		if (leftPanel == null)
		{
			return;
		}
		leftPanel.OpenLastDetailPanel();
	}

	// Token: 0x0601366C RID: 79468 RVA: 0x004D4978 File Offset: 0x004D2B78
	protected override void OnBeforeShow()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag(this.ViewInfo.Name);
		InputDistributeController.Instance.BindTouches(new int[]
		{
			0,
			1
		}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
	}

	// Token: 0x0601366D RID: 79469 RVA: 0x004D49B4 File Offset: 0x004D2BB4
	protected override void OnAfterPlayStartSequence()
	{
		base.OnAfterPlayStartSequence();
		if (PhotographController.Instance.GetManualFocusOn())
		{
			this.PlayFocusAtScreenCenter();
		}
	}

	// Token: 0x0601366E RID: 79470 RVA: 0x004D49D0 File Offset: 0x004D2BD0
	protected override void OnAddEventListener()
	{
		InputDistributeController instance = InputDistributeController.Instance;
		instance.BindAxis("UiIncrease", new TInputHandle<float>(this.OnInputUiIncrease));
		instance.BindAxis("UiReduce", new TInputHandle<float>(this.OnInputUiReduce));
		instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiMoveForward));
		instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiMoveRight));
		instance.BindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
		instance.BindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
		instance.BindAxis("UiLookInOut", new TInputHandle<float>(this.OnInputUiLookInOut));
		instance.BindAxis("UiCamRotate2", new TInputHandle<float>(this.OnInputUiCamRotate));
		instance.BindAction("UI键盘Q手柄LB", new TInputHandle<InputDistributeDefine.EActionType>(this.OnCursorAction));
		instance.BindAxis("CameraFocusHor", new TInputHandle<float>(this.OnInputCameraFocusHor));
		instance.BindAxis("CameraFocusVer", new TInputHandle<float>(this.OnInputCameraFocusVer));
		instance.BindTouches(new int[]
		{
			0,
			1
		}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		UUIDraggableComponent draggable = base.GetDraggable(0);
		draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
		draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
		draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragMoved));
		draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnded));
		draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnded));
		draggable.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScroll));
		EventSystem.Instance.Add<bool, bool>(EEventName.OnPhotographViewCaptureMode, new Action<bool, bool>(this.OnPhotographViewCaptureMode));
		EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChanged));
		EventSystem.Instance.Add(EEventName.UpdateNavigationListener, new Action(this.OnNavigationFocusChanged));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenViewForTimeDilation));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewForTimeDilation));
		EventSystem.Instance.Add(EEventName.OnPhotographSetVisible, new Action(this.OnPhotographSetVisible));
		EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
	}

	// Token: 0x0601366F RID: 79471 RVA: 0x004D4C44 File Offset: 0x004D2E44
	protected override void OnTick(float delta)
	{
		float num = this.ViewModel.FovInputValue + this.PendingFov;
		if (num != 0f)
		{
			InputDistributeController.Instance.InputAxis("PhotoFov", -num, false);
			PhotoRightPanel rightPanel = this.RightPanel;
			if (rightPanel != null)
			{
				rightPanel.SyncFovFromCamera();
			}
			this.PendingFov = 0f;
		}
		if (this.ViewModel.MoveForwardInputValue != 0f)
		{
			InputDistributeController.Instance.InputAxis("PhotoMoveForward", this.ViewModel.MoveForwardInputValue, false);
		}
		if (this.ViewModel.MoveRightInputValue != 0f)
		{
			InputDistributeController.Instance.InputAxis("PhotoMoveRight", this.ViewModel.MoveRightInputValue, false);
		}
		if (this.ViewModel.MoveUpInputValue != 0f)
		{
			InputDistributeController.Instance.InputAxis("PhotoMoveUp", this.ViewModel.MoveUpInputValue, false);
		}
		if (this.PendingPitch != 0f || this.PendingYaw != 0f)
		{
			InputDistributeController.Instance.InputAxis("PhotoPitch", this.PendingPitch, false);
			InputDistributeController.Instance.InputAxis("PhotoYaw", this.PendingYaw, false);
			this.PendingPitch = 0f;
			this.PendingYaw = 0f;
		}
		if (this.IsCursorMode && (this.CursorInputHor != 0f || this.CursorInputVer != 0f))
		{
			this.MoveCursor(delta);
		}
		if (this.IsStickerSelected && (this.StickerMoveInputHor != 0f || this.StickerMoveInputVer != 0f))
		{
			this.MoveSticker(delta);
		}
		PhotoLeftPanel leftPanel = this.LeftPanel;
		if (leftPanel != null)
		{
			leftPanel.TickCurrentDetail(delta);
		}
		PhotoLeftPanel leftPanel2 = this.LeftPanel;
		if (leftPanel2 == null)
		{
			return;
		}
		leftPanel2.TickMoveCtrl(delta);
	}

	// Token: 0x06013670 RID: 79472 RVA: 0x004D4DF2 File Offset: 0x004D2FF2
	protected override void OnAfterHide()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag(this.ViewInfo.Name);
		InputDistributeController.Instance.UnBindTouches(new int[]
		{
			0,
			1
		}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
	}

	// Token: 0x06013671 RID: 79473 RVA: 0x004D4E2E File Offset: 0x004D302E
	private void OnOpenViewForTimeDilation(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.PhotoSaveView)
		{
			return;
		}
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag(this.ViewInfo.Name);
	}

	// Token: 0x06013672 RID: 79474 RVA: 0x004D4E58 File Offset: 0x004D3058
	private void OnCloseViewForTimeDilation(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.PhotoSaveView)
		{
			return;
		}
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag(this.ViewInfo.Name);
	}

	// Token: 0x06013673 RID: 79475 RVA: 0x004D4E84 File Offset: 0x004D3084
	protected override void OnRemoveEventListener()
	{
		InputDistributeController instance = InputDistributeController.Instance;
		instance.UnBindAxis("UiIncrease", new TInputHandle<float>(this.OnInputUiIncrease));
		instance.UnBindAxis("UiReduce", new TInputHandle<float>(this.OnInputUiReduce));
		instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiMoveForward));
		instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiMoveRight));
		instance.UnBindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
		instance.UnBindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
		instance.UnBindAxis("UiLookInOut", new TInputHandle<float>(this.OnInputUiLookInOut));
		instance.UnBindAxis("UiCamRotate2", new TInputHandle<float>(this.OnInputUiCamRotate));
		instance.UnBindAction("UI键盘Q手柄LB", new TInputHandle<InputDistributeDefine.EActionType>(this.OnCursorAction));
		instance.UnBindAxis("CameraFocusHor", new TInputHandle<float>(this.OnInputCameraFocusHor));
		instance.UnBindAxis("CameraFocusVer", new TInputHandle<float>(this.OnInputCameraFocusVer));
		instance.UnBindTouches(new int[]
		{
			0,
			1
		}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		UUIDraggableComponent draggable = base.GetDraggable(0);
		draggable.OnPointerBeginDragCallBack.Unbind();
		draggable.OnPointerDownCallBack.Unbind();
		draggable.OnPointerDragCallBack.Unbind();
		draggable.OnPointerEndDragCallBack.Unbind();
		draggable.OnPointerUpCallBack.Unbind();
		draggable.OnPointerScrollCallBack.Unbind();
		EventSystem.Instance.Remove<bool, bool>(EEventName.OnPhotographViewCaptureMode, new Action<bool, bool>(this.OnPhotographViewCaptureMode));
		EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChanged));
		EventSystem.Instance.Remove(EEventName.UpdateNavigationListener, new Action(this.OnNavigationFocusChanged));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenViewForTimeDilation));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewForTimeDilation));
		EventSystem.Instance.Remove(EEventName.OnPhotographSetVisible, new Action(this.OnPhotographSetVisible));
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		this.ResetAllAxes();
		this.ExitCursorMode();
	}

	// Token: 0x06013674 RID: 79476 RVA: 0x004D50BC File Offset: 0x004D32BC
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		PhotographController.Instance.ResetPhotoCamera();
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnRequestClose = (Action)Delegate.Remove(viewModel.OnRequestClose, new Action(this.OnRequestClose));
		PhotoMainViewModel viewModel2 = this.ViewModel;
		viewModel2.OnRequestHideUi = (Action)Delegate.Remove(viewModel2.OnRequestHideUi, new Action(this.OnRequestHideUi));
		PhotoMainViewModel viewModel3 = this.ViewModel;
		viewModel3.OnRequestCreateSticker = (Action<PhotoSticker>)Delegate.Remove(viewModel3.OnRequestCreateSticker, new Action<PhotoSticker>(this.OnRequestCreateSticker));
		PhotoMainViewModel viewModel4 = this.ViewModel;
		viewModel4.OnRequestRemoveSticker = (Action)Delegate.Remove(viewModel4.OnRequestRemoveSticker, new Action(this.OnRequestRemoveSticker));
		PhotoMainViewModel viewModel5 = this.ViewModel;
		viewModel5.OnStickerSelectedChanged = (Action<bool>)Delegate.Remove(viewModel5.OnStickerSelectedChanged, new Action<bool>(this.OnStickerSelectedChanged));
		PhotoMainViewModel viewModel6 = this.ViewModel;
		viewModel6.OnFrameSelected = (Action<int>)Delegate.Remove(viewModel6.OnFrameSelected, new Action<int>(this.OnFrameSelected));
		this.ViewModel.OnRequestPlaySwitchModeAnim = null;
		CustomPromise<bool> switchModeAnimPromise = this.SwitchModeAnimPromise;
		if (switchModeAnimPromise != null)
		{
			switchModeAnimPromise.SetResult(true);
		}
		this.SwitchModeAnimPromise = null;
		this.ViewModel.OnRequestWaitSwitchModeAnimEnd = null;
		CustomPromise<bool> switchModeAnimEndPromise = this.SwitchModeAnimEndPromise;
		if (switchModeAnimEndPromise != null)
		{
			switchModeAnimEndPromise.SetResult(true);
		}
		this.SwitchModeAnimEndPromise = null;
		PhotoMainViewModel viewModel7 = this.ViewModel;
		viewModel7.OnDetailPanelClosed = (Action)Delegate.Remove(viewModel7.OnDetailPanelClosed, new Action(this.OnDetailPanelClosed));
		PhotoMainViewModel viewModel8 = this.ViewModel;
		viewModel8.OnDetailPanelOpened = (Action)Delegate.Remove(viewModel8.OnDetailPanelOpened, new Action(this.OnDetailPanelOpened));
		PhotoMainViewModel viewModel9 = this.ViewModel;
		viewModel9.OnModeChanged = (Action<PhotoCameraType>)Delegate.Remove(viewModel9.OnModeChanged, new Action<PhotoCameraType>(this.OnModeChanged));
		PhotographController instance = PhotographController.Instance;
		instance.OnAuxiliaryLineChanged = (Action<bool>)Delegate.Remove(instance.OnAuxiliaryLineChanged, new Action<bool>(this.SetAuxiliaryLineVisible));
		PhotographController instance2 = PhotographController.Instance;
		instance2.OnRequestOpenLastDetailPanel = (Action)Delegate.Remove(instance2.OnRequestOpenLastDetailPanel, new Action(this.OnRequestOpenLastDetailPanel));
		PhotographController instance3 = PhotographController.Instance;
		instance3.OnRequestSelectSticker = (Action)Delegate.Remove(instance3.OnRequestSelectSticker, new Action(this.OnRequestSelectSticker));
		PhotographController instance4 = PhotographController.Instance;
		instance4.OnRequestDeselectSticker = (Action)Delegate.Remove(instance4.OnRequestDeselectSticker, new Action(this.OnRequestDeselectSticker));
		PhotographController instance5 = PhotographController.Instance;
		instance5.OnRequestChangeStickerScale = (Action<float>)Delegate.Remove(instance5.OnRequestChangeStickerScale, new Action<float>(this.OnRequestChangeStickerScale));
		PhotographController instance6 = PhotographController.Instance;
		instance6.OnManualFocusChanged = (Action<bool>)Delegate.Remove(instance6.OnManualFocusChanged, new Action<bool>(this.OnManualFocusChanged));
		PhotoCamera photoCamera = PhotographController.Instance.GetPhotoCamera();
		if (photoCamera != null)
		{
			PhotoCamera photoCamera2 = photoCamera;
			photoCamera2.OnTiltRollChanged = (Action<float>)Delegate.Remove(photoCamera2.OnTiltRollChanged, new Action<float>(this.OnCameraTiltRollChanged));
			PhotoCamera photoCamera3 = photoCamera;
			photoCamera3.OnTemplateDepthOfFieldChanged = (Action<float, float>)Delegate.Remove(photoCamera3.OnTemplateDepthOfFieldChanged, new Action<float, float>(this.OnTemplateDepthOfFieldChanged));
		}
		this.ExitCursorMode();
		PhotoStickerItem sticker = this.Sticker;
		if (sticker != null)
		{
			sticker.Destroy(null);
		}
		this.Sticker = null;
		this.HasSticker = false;
		this.ClearStickerSelection();
		PhotoJoystickOwnerController joystickOwner = this.JoystickOwner;
		joystickOwner.OnOwnerChanged = (Action<EPhotoJoystickOwner, EPhotoJoystickOwner>)Delegate.Remove(joystickOwner.OnOwnerChanged, new Action<EPhotoJoystickOwner, EPhotoJoystickOwner>(this.OnJoystickOwnerChanged));
		PhotographController.Instance.CurrentJoystickOwner = null;
		PhotoSnapshotController.Instance.ClearSession();
	}

	// Token: 0x06013675 RID: 79477 RVA: 0x004D5434 File Offset: 0x004D3634
	private void ResetAllAxes()
	{
		this.PendingPitch = 0f;
		this.PendingYaw = 0f;
		this.PendingFov = 0f;
		this.ViewModel.FovInputValue = 0f;
		this.ViewModel.MoveForwardInputValue = 0f;
		this.ViewModel.MoveRightInputValue = 0f;
		this.ViewModel.MoveUpInputValue = 0f;
		this.StickerMoveInputHor = 0f;
		this.StickerMoveInputVer = 0f;
		InputDistributeController instance = InputDistributeController.Instance;
		instance.InputAxis("PhotoMoveForward", 0f, false);
		instance.InputAxis("PhotoMoveRight", 0f, false);
		instance.InputAxis("PhotoMoveUp", 0f, false);
		instance.InputAxis("PhotoFov", 0f, false);
	}

	// Token: 0x06013676 RID: 79478 RVA: 0x004D5500 File Offset: 0x004D3700
	private void OnInputUiIncrease(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		if (this.IsStickerSelected)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoFov", -value, false);
		PhotoRightPanel rightPanel = this.RightPanel;
		if (rightPanel == null)
		{
			return;
		}
		rightPanel.SyncFovFromCamera();
	}

	// Token: 0x06013677 RID: 79479 RVA: 0x004D5550 File Offset: 0x004D3750
	private void OnInputUiReduce(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		if (this.IsStickerSelected)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoFov", -value, false);
		PhotoRightPanel rightPanel = this.RightPanel;
		if (rightPanel == null)
		{
			return;
		}
		rightPanel.SyncFovFromCamera();
	}

	// Token: 0x06013678 RID: 79480 RVA: 0x004D55A0 File Offset: 0x004D37A0
	private void OnInputUiMoveForward(string axisName, float value, InputIdentification inputIdentification)
	{
		EPhotoJoystickOwner ephotoJoystickOwner = this.JoystickOwner.Current;
		if (ephotoJoystickOwner != EPhotoJoystickOwner.CameraMove)
		{
			if (ephotoJoystickOwner == EPhotoJoystickOwner.Sticker)
			{
				this.StickerMoveInputVer = value;
				return;
			}
		}
		else if (value != 0f)
		{
			InputDistributeController.Instance.InputAxis("PhotoMoveUp", value, false);
		}
	}

	// Token: 0x06013679 RID: 79481 RVA: 0x004D55E4 File Offset: 0x004D37E4
	private void OnInputUiMoveRight(string axisName, float value, InputIdentification inputIdentification)
	{
		EPhotoJoystickOwner ephotoJoystickOwner = this.JoystickOwner.Current;
		if (ephotoJoystickOwner != EPhotoJoystickOwner.CameraMove)
		{
			if (ephotoJoystickOwner == EPhotoJoystickOwner.Sticker)
			{
				this.StickerMoveInputHor = value;
				return;
			}
		}
		else if (value != 0f)
		{
			InputDistributeController.Instance.InputAxis("PhotoMoveRight", value, false);
		}
	}

	// Token: 0x0601367A RID: 79482 RVA: 0x004D5625 File Offset: 0x004D3825
	private void OnInputUiLookInOut(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoMoveForward", value, false);
	}

	// Token: 0x0601367B RID: 79483 RVA: 0x004D5641 File Offset: 0x004D3841
	private void OnInputUiLookUp(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoPitch", -value, false);
	}

	// Token: 0x0601367C RID: 79484 RVA: 0x004D566B File Offset: 0x004D386B
	private void OnInputUiTurn(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoYaw", value, false);
	}

	// Token: 0x0601367D RID: 79485 RVA: 0x004D5694 File Offset: 0x004D3894
	private void OnInputUiCamRotate(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoRoll", value, false);
	}

	// Token: 0x0601367E RID: 79486 RVA: 0x004D56B0 File Offset: 0x004D38B0
	[NullableContext(2)]
	private void OnDragBegin(ULGUIPointerEventData eventData)
	{
		if (eventData == null)
		{
			return;
		}
		this.IsDragging = true;
		this.InDragMove = false;
		this.LastDragX = eventData.pointerPosition.X;
		this.LastDragY = eventData.pointerPosition.Y;
	}

	// Token: 0x0601367F RID: 79487 RVA: 0x004D56E8 File Offset: 0x004D38E8
	[NullableContext(2)]
	private void OnDragMoved(ULGUIPointerEventData eventData)
	{
		if (eventData == null || !this.IsDragging)
		{
			return;
		}
		this.InDragMove = true;
		FVector pointerPosition = eventData.pointerPosition;
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			this.LastDragX = pointerPosition.X;
			this.LastDragY = pointerPosition.Y;
			return;
		}
		this.PendingPitch += -(pointerPosition.Y - this.LastDragY) * 0.1f;
		this.PendingYaw += -(this.LastDragX - pointerPosition.X) * 0.1f;
		this.LastDragX = pointerPosition.X;
		this.LastDragY = pointerPosition.Y;
	}

	// Token: 0x06013680 RID: 79488 RVA: 0x004D5790 File Offset: 0x004D3990
	[NullableContext(2)]
	private void OnDragEnded(ULGUIPointerEventData eventData)
	{
		this.IsDragging = false;
		if (!this.InDragMove)
		{
			if (!this.IsCursorMode)
			{
				this.SetVisibleMode(true, false);
			}
			if (this.IsStickerSelected)
			{
				this.ClearStickerSelection();
				return;
			}
			if (eventData != null)
			{
				FVector pointerPosition = eventData.pointerPosition;
				PhotographController.Instance.FocusAtScreenPosition(new FVector2D(pointerPosition.X, pointerPosition.Y));
				this.TriggerFocusItem(new FVector2D(pointerPosition.X, pointerPosition.Y));
			}
		}
	}

	// Token: 0x06013681 RID: 79489 RVA: 0x004D5807 File Offset: 0x004D3A07
	private void OnManualFocusChanged(bool on)
	{
		if (on)
		{
			this.PlayFocusAtScreenCenter();
			return;
		}
		UUIItem item = base.GetItem(8);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06013682 RID: 79490 RVA: 0x004D5828 File Offset: 0x004D3A28
	private void PlayFocusAtScreenCenter()
	{
		if (this.IsInCaptureMode)
		{
			return;
		}
		UUIItem item = base.GetItem(8);
		if (item == null)
		{
			return;
		}
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		item.SetUIActive(true);
		UUIItem uuiitem = item;
		FVector fvector = this.ViewportPosToCanvasPos(new FVector2D(viewportSize.X / 2f, viewportSize.Y / 2f));
		uuiitem.SetLGUISpaceAbsolutePosition(fvector);
		base.PlayOrReplaySequence("Focus", false, null);
	}

	// Token: 0x06013683 RID: 79491 RVA: 0x004D58A0 File Offset: 0x004D3AA0
	private void TriggerFocusItem(FVector2D pointerPos)
	{
		if (this.IsInCaptureMode || !PhotographController.Instance.GetManualFocusOn())
		{
			return;
		}
		UUIItem item = base.GetItem(8);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(true);
		UUIItem uuiitem = item;
		FVector fvector = this.ViewportPosToCanvasPos(pointerPos);
		uuiitem.SetLGUISpaceAbsolutePosition(fvector);
		bool hasFocusPoint = PhotographController.Instance.GetHasFocusPoint();
		string sequenceName = hasFocusPoint ? "Success" : "Fail";
		string sequenceName2 = hasFocusPoint ? "Fail" : "Success";
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.StopSequenceByKey(sequenceName2, false, false);
		}
		base.PlayOrReplaySequence(sequenceName, false, null);
	}

	// Token: 0x06013684 RID: 79492 RVA: 0x004D5934 File Offset: 0x004D3B34
	private UniTask PlaySwitchModeAnimAsync(PhotoCameraType target)
	{
		PhotoMainView.<PlaySwitchModeAnimAsync>d__74 <PlaySwitchModeAnimAsync>d__;
		<PlaySwitchModeAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySwitchModeAnimAsync>d__.<>4__this = this;
		<PlaySwitchModeAnimAsync>d__.target = target;
		<PlaySwitchModeAnimAsync>d__.<>1__state = -1;
		<PlaySwitchModeAnimAsync>d__.<>t__builder.Start<PhotoMainView.<PlaySwitchModeAnimAsync>d__74>(ref <PlaySwitchModeAnimAsync>d__);
		return <PlaySwitchModeAnimAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013685 RID: 79493 RVA: 0x004D5980 File Offset: 0x004D3B80
	private UniTask WaitSwitchModeAnimEndAsync(PhotoCameraType target)
	{
		PhotoMainView.<WaitSwitchModeAnimEndAsync>d__75 <WaitSwitchModeAnimEndAsync>d__;
		<WaitSwitchModeAnimEndAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitSwitchModeAnimEndAsync>d__.<>4__this = this;
		<WaitSwitchModeAnimEndAsync>d__.target = target;
		<WaitSwitchModeAnimEndAsync>d__.<>1__state = -1;
		<WaitSwitchModeAnimEndAsync>d__.<>t__builder.Start<PhotoMainView.<WaitSwitchModeAnimEndAsync>d__75>(ref <WaitSwitchModeAnimEndAsync>d__);
		return <WaitSwitchModeAnimEndAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013686 RID: 79494 RVA: 0x004D59CB File Offset: 0x004D3BCB
	private void OnSwitchModeSequenceEnd(string sequenceName)
	{
		CustomPromise<bool> switchModeAnimEndPromise = this.SwitchModeAnimEndPromise;
		if (switchModeAnimEndPromise == null)
		{
			return;
		}
		switchModeAnimEndPromise.SetResult(true);
	}

	// Token: 0x06013687 RID: 79495 RVA: 0x004D59DE File Offset: 0x004D3BDE
	private void OnSwitchModeSequenceEvent(string sequenceName, string eventName)
	{
		if (eventName != "Sequence_Switch")
		{
			return;
		}
		CustomPromise<bool> switchModeAnimPromise = this.SwitchModeAnimPromise;
		if (switchModeAnimPromise == null)
		{
			return;
		}
		switchModeAnimPromise.SetResult(true);
	}

	// Token: 0x06013688 RID: 79496 RVA: 0x004D5A00 File Offset: 0x004D3C00
	private void OnDetailPanelClosed()
	{
		base.PlayOrReplaySequence("Close1", false, null);
	}

	// Token: 0x06013689 RID: 79497 RVA: 0x004D5A24 File Offset: 0x004D3C24
	private void OnDetailPanelOpened()
	{
		base.PlayOrReplaySequence("BaseStart", false, null);
	}

	// Token: 0x0601368A RID: 79498 RVA: 0x004D5A48 File Offset: 0x004D3C48
	private FVector ViewportPosToCanvasPos(FVector2D viewportPos)
	{
		this.TempVector2D.Set((double)viewportPos.X, (double)viewportPos.Y);
		Vector2D tempVector2D = this.TempVector2D;
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		FVector2D fvector2D = this.TempVector2D.ToUeVector2D(true);
		tempVector2D.FromUeVector2D(canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D));
		return new FVector((float)this.TempVector2D.X, (float)this.TempVector2D.Y, 0f);
	}

	// Token: 0x0601368B RID: 79499 RVA: 0x004D5AC4 File Offset: 0x004D3CC4
	private FVector2D CanvasPosToViewportPos(FVector canvasPos)
	{
		this.TempVector2D.Set((double)canvasPos.X, (double)canvasPos.Y);
		Vector2D tempVector2D = this.TempVector2D;
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		FVector2D fvector2D = this.TempVector2D.ToUeVector2D(true);
		tempVector2D.FromUeVector2D(canvasScaler.ConvertPositionFromLGUICanvasToViewport(fvector2D));
		return new FVector2D((float)this.TempVector2D.X, (float)this.TempVector2D.Y);
	}

	// Token: 0x0601368C RID: 79500 RVA: 0x004D5B3A File Offset: 0x004D3D3A
	private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification inputIdentification)
	{
		if (touchData.TouchType != InputDistributeDefine.ETouchType.TouchMove)
		{
			return;
		}
		this.TouchMoved();
	}

	// Token: 0x0601368D RID: 79501 RVA: 0x004D5B4C File Offset: 0x004D3D4C
	private void TouchMoved()
	{
		if (TouchFingerManager.Instance.GetTouchFingerCount() <= 1)
		{
			return;
		}
		TouchFingerData touchFingerData = TouchFingerManager.Instance.GetTouchFingerData(EFingerIndex.One);
		if ((touchFingerData == null || !touchFingerData.IsTouchEmpty()) && (touchFingerData == null || !touchFingerData.IsTouchComponentContainTag(PhotographDefine.ignoreTouchTag)))
		{
			return;
		}
		TouchFingerData touchFingerData2 = TouchFingerManager.Instance.GetTouchFingerData(EFingerIndex.Two);
		if ((touchFingerData2 == null || !touchFingerData2.IsTouchEmpty()) && (touchFingerData2 == null || !touchFingerData2.IsTouchComponentContainTag(PhotographDefine.ignoreTouchTag)))
		{
			return;
		}
		float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
		float num = MathUtils.Instance.RangeClamp(fingerExpandCloseValue, -50000f, 50000f, -1f, 1f);
		if (this.IsStickerSelected)
		{
			this.OnRequestChangeStickerScale(num);
			return;
		}
		PhotoRightPanel rightPanel = this.RightPanel;
		if (rightPanel == null)
		{
			return;
		}
		rightPanel.ChangeFovByDelta(num);
	}

	// Token: 0x0601368E RID: 79502 RVA: 0x004D5C1D File Offset: 0x004D3E1D
	[NullableContext(2)]
	private void OnPointerScroll(ULGUIPointerEventData eventData)
	{
		if (eventData == null || eventData.scrollAxisValue == 0f)
		{
			return;
		}
		this.PendingFov += eventData.scrollAxisValue;
	}

	// Token: 0x0601368F RID: 79503 RVA: 0x004D5C43 File Offset: 0x004D3E43
	private void OnCursorAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		if (actionType == InputDistributeDefine.EActionType.Press)
		{
			this.EnterCursorMode();
			return;
		}
		if (actionType == InputDistributeDefine.EActionType.Release)
		{
			if (this.IsActionKeyStillPressed(actionName))
			{
				return;
			}
			this.ExitCursorMode();
		}
	}

	// Token: 0x06013690 RID: 79504 RVA: 0x004D5C70 File Offset: 0x004D3E70
	private bool IsActionKeyStillPressed(string actionName)
	{
		InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(actionName);
		if (actionBinding == null)
		{
			return false;
		}
		IReadOnlyList<string> currentPlatformKeyNameList = actionBinding.GetCurrentPlatformKeyNameList();
		int i = 0;
		int count = currentPlatformKeyNameList.Count;
		while (i < count)
		{
			if (InputSettings.Instance.IsInputKeyDown(currentPlatformKeyNameList[i]))
			{
				return true;
			}
			i++;
		}
		return false;
	}

	// Token: 0x06013691 RID: 79505 RVA: 0x004D5CBE File Offset: 0x004D3EBE
	private void OnInputCameraFocusHor(string axisName, float value, InputIdentification inputIdentification)
	{
		if (!this.IsCursorMode)
		{
			return;
		}
		this.CursorInputHor = value;
	}

	// Token: 0x06013692 RID: 79506 RVA: 0x004D5CD0 File Offset: 0x004D3ED0
	private void OnInputCameraFocusVer(string axisName, float value, InputIdentification inputIdentification)
	{
		if (!this.IsCursorMode)
		{
			return;
		}
		this.CursorInputVer = value;
	}

	// Token: 0x06013693 RID: 79507 RVA: 0x004D5CE4 File Offset: 0x004D3EE4
	private void MoveCursor(float delta)
	{
		UUIButtonComponent button = base.GetButton(12);
		UUIItem uuiitem = (button != null) ? button.RootUIComp.Get() : null;
		if (uuiitem == null)
		{
			return;
		}
		if (this.CursorBoundsDirty)
		{
			this.RefreshCursorBounds();
		}
		float valueOrDefault = ConfigCommonParamById.GetFloatConfig("PhotoCursorMoveSpeed").GetValueOrDefault(1f);
		FVector lguispaceAbsolutePosition = uuiitem.GetLGUISpaceAbsolutePosition();
		float inX = MathUtils.Instance.Clamp(lguispaceAbsolutePosition.X + this.CursorInputHor * valueOrDefault * delta, this.CursorBoundsMinX, this.CursorBoundsMaxX);
		float inY = MathUtils.Instance.Clamp(lguispaceAbsolutePosition.Y + this.CursorInputVer * valueOrDefault * delta, this.CursorBoundsMinY, this.CursorBoundsMaxY);
		UUIItem uuiitem2 = uuiitem;
		FVector fvector = new FVector(inX, inY, lguispaceAbsolutePosition.Z);
		uuiitem2.SetLGUISpaceAbsolutePosition(fvector);
	}

	// Token: 0x06013694 RID: 79508 RVA: 0x004D5DAC File Offset: 0x004D3FAC
	private void RefreshCursorBounds()
	{
		this.CursorBoundsDirty = false;
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		FVector fvector = this.ViewportPosToCanvasPos(new FVector2D(0f, 0f));
		FVector fvector2 = this.ViewportPosToCanvasPos(new FVector2D(viewportSize.X, viewportSize.Y));
		this.CursorBoundsMinX = Math.Min(fvector.X, fvector2.X);
		this.CursorBoundsMaxX = Math.Max(fvector.X, fvector2.X);
		this.CursorBoundsMinY = Math.Min(fvector.Y, fvector2.Y);
		this.CursorBoundsMaxY = Math.Max(fvector.Y, fvector2.Y);
	}

	// Token: 0x06013695 RID: 79509 RVA: 0x004D5E58 File Offset: 0x004D4058
	private void OnCursorFocusClick()
	{
		if (!this.IsCursorMode)
		{
			return;
		}
		UUIButtonComponent button = base.GetButton(12);
		UUIItem uuiitem = (button != null) ? button.RootUIComp.Get() : null;
		if (uuiitem == null)
		{
			return;
		}
		FVector2D fvector2D = this.CanvasPosToViewportPos(uuiitem.GetLGUISpaceAbsolutePosition());
		PhotographController.Instance.FocusAtScreenPosition(fvector2D);
		this.TriggerFocusItem(fvector2D);
	}

	// Token: 0x06013696 RID: 79510 RVA: 0x004D5EAE File Offset: 0x004D40AE
	private void EnterCursorMode()
	{
		this.JoystickOwner.Request(EPhotoJoystickOwner.Cursor, false);
	}

	// Token: 0x06013697 RID: 79511 RVA: 0x004D5EBE File Offset: 0x004D40BE
	private void ExitCursorMode()
	{
		this.JoystickOwner.Release(EPhotoJoystickOwner.Cursor);
	}

	// Token: 0x06013698 RID: 79512 RVA: 0x004D5ECC File Offset: 0x004D40CC
	private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		if (now == EInputControllerMainType.Gamepad)
		{
			return;
		}
		this.ExitCursorMode();
		this.RefreshStickerHotKey();
	}

	// Token: 0x06013699 RID: 79513 RVA: 0x004D5EDF File Offset: 0x004D40DF
	private void OnRequestHideUi()
	{
		this.SetVisibleMode(false, false);
	}

	// Token: 0x0601369A RID: 79514 RVA: 0x004D5EEC File Offset: 0x004D40EC
	private void SetVisibleMode(bool bVisible, bool isShowHotKey = false)
	{
		if (this.VisibleMode == bVisible)
		{
			return;
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(bVisible);
		}
		UUIItem item2 = base.GetItem(14);
		if (item2 != null)
		{
			item2.SetUIActive(!bVisible);
		}
		UUIItem item3 = base.GetItem(20);
		if (item3 != null)
		{
			item3.SetUIActive(bVisible || isShowHotKey);
		}
		this.VisibleMode = bVisible;
	}

	// Token: 0x0601369B RID: 79515 RVA: 0x004D5F4C File Offset: 0x004D414C
	private void RefreshHotKeyPanel()
	{
		PhotoCameraType currentMode = this.ViewModel.CurrentMode;
		bool isCursorMode = this.IsCursorMode;
		bool flag = currentMode == PhotoCameraType.Normal || currentMode == PhotoCameraType.Drone;
		bool flag2 = currentMode == PhotoCameraType.FirstPerson;
		bool flag3 = currentMode == PhotoCameraType.Selfie;
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(flag && !isCursorMode);
		}
		UUIItem item2 = base.GetItem(15);
		if (item2 != null)
		{
			item2.SetUIActive(flag && isCursorMode);
		}
		UUIItem item3 = base.GetItem(16);
		if (item3 != null)
		{
			item3.SetUIActive(flag2 && !isCursorMode);
		}
		UUIItem item4 = base.GetItem(17);
		if (item4 != null)
		{
			item4.SetUIActive(flag2 && isCursorMode);
		}
		UUIItem item5 = base.GetItem(18);
		if (item5 != null)
		{
			item5.SetUIActive(flag3 && !isCursorMode);
		}
		UUIItem item6 = base.GetItem(19);
		if (item6 == null)
		{
			return;
		}
		item6.SetUIActive(flag3 && isCursorMode);
	}

	// Token: 0x0601369C RID: 79516 RVA: 0x004D601B File Offset: 0x004D421B
	private void RefreshStickerHotKey()
	{
		PhotoStickerItem sticker = this.Sticker;
		if (sticker == null)
		{
			return;
		}
		sticker.SetHotKeyVisible(this.HasSticker && !this.IsInCaptureMode && !this.IsCursorMode);
	}

	// Token: 0x0601369D RID: 79517 RVA: 0x004D6049 File Offset: 0x004D4249
	private void OnModeChanged(PhotoCameraType mode)
	{
		this.RefreshHotKeyPanel();
		this.SyncLightToViewModel();
	}

	// Token: 0x0601369E RID: 79518 RVA: 0x004D6058 File Offset: 0x004D4258
	private void SyncLightToViewModel()
	{
		PhotoCameraEffectComponent photoCameraComponent = PhotographController.Instance.GetPhotoCameraComponent<PhotoCameraEffectComponent>(EPhotoCameraComponent.Effect);
		if (photoCameraComponent == null)
		{
			return;
		}
		int currentLightId = photoCameraComponent.GetCurrentLightId();
		if (currentLightId <= 0)
		{
			return;
		}
		this.ViewModel.CurrentLightId = currentLightId;
		PhotoLight? config = ConfigPhotoLightById.GetConfig(currentLightId, true);
		bool flag = config != null && config.GetValueOrDefault().IsDefault;
		this.ViewModel.CurrentLightDirection = (flag ? 0 : ((int)photoCameraComponent.GetCurrentLightDirection()));
	}

	// Token: 0x0601369F RID: 79519 RVA: 0x004D60CA File Offset: 0x004D42CA
	private void OnPhotographSetVisible()
	{
		this.SetVisibleMode(true, false);
	}

	// Token: 0x060136A0 RID: 79520 RVA: 0x004D60D4 File Offset: 0x004D42D4
	private void OnPhotographViewCaptureMode(bool enter, bool showMark)
	{
		if (enter)
		{
			this.SetVisibleMode(false, false);
			this.ClearStickerSelection();
			PhotoSaveMarkItem playerInfoItem = this.PlayerInfoItem;
			if (playerInfoItem != null)
			{
				playerInfoItem.SetUiActive(showMark);
			}
			this.IsInCaptureMode = true;
			this.RefreshStickerHotKey();
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			this.ApplyFrame(this.ViewModel.CurrentFrameId);
			return;
		}
		this.SetVisibleMode(true, false);
		PhotoSaveMarkItem playerInfoItem2 = this.PlayerInfoItem;
		if (playerInfoItem2 != null)
		{
			playerInfoItem2.SetUiActive(false);
		}
		this.IsInCaptureMode = false;
		this.RefreshStickerHotKey();
		this.SetAuxiliaryLineVisible(PhotographController.Instance.IsAuxiliaryLineOn());
		this.ApplyFrame(this.ViewModel.CurrentFrameId);
	}

	// Token: 0x060136A1 RID: 79521 RVA: 0x004D6191 File Offset: 0x004D4391
	private void SetAuxiliaryLineVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x060136A2 RID: 79522 RVA: 0x004D61A5 File Offset: 0x004D43A5
	private void OnRequestClose()
	{
		PhotographController.Instance.ClosePhotoCamera().Forget();
	}

	// Token: 0x060136A3 RID: 79523 RVA: 0x004D61B8 File Offset: 0x004D43B8
	private void OnRequestCreateSticker(PhotoSticker cfg)
	{
		this.ViewModel.SetStickerId(cfg.Id);
		if (this.Sticker != null)
		{
			this.Sticker.SetData(cfg);
			this.SetStickerVisible(true);
			this.SelectSticker(this.Sticker);
			return;
		}
		this.PendingStickerCfg = new PhotoSticker?(cfg);
		if (this.IsCreatingSticker)
		{
			this.IsPendingRemoveSticker = false;
			return;
		}
		this.CreateSticker().Forget();
	}

	// Token: 0x060136A4 RID: 79524 RVA: 0x004D6228 File Offset: 0x004D4428
	private UniTask CreateSticker()
	{
		PhotoMainView.<CreateSticker>d__106 <CreateSticker>d__;
		<CreateSticker>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSticker>d__.<>4__this = this;
		<CreateSticker>d__.<>1__state = -1;
		<CreateSticker>d__.<>t__builder.Start<PhotoMainView.<CreateSticker>d__106>(ref <CreateSticker>d__);
		return <CreateSticker>d__.<>t__builder.Task;
	}

	// Token: 0x060136A5 RID: 79525 RVA: 0x004D626B File Offset: 0x004D446B
	private void SelectSticker(PhotoStickerItem item)
	{
		if (this.Sticker != item || !this.HasSticker)
		{
			return;
		}
		this.SetStickerSelected(true);
	}

	// Token: 0x060136A6 RID: 79526 RVA: 0x004D6288 File Offset: 0x004D4488
	private void RemoveSticker(PhotoStickerItem item)
	{
		if (this.Sticker != item || !this.HasSticker)
		{
			return;
		}
		this.SetStickerSelected(false);
		this.SetStickerVisible(false);
		this.ViewModel.SetStickerId(0);
		Action onStickerRemoved = this.ViewModel.OnStickerRemoved;
		if (onStickerRemoved == null)
		{
			return;
		}
		onStickerRemoved();
	}

	// Token: 0x060136A7 RID: 79527 RVA: 0x004D62D6 File Offset: 0x004D44D6
	private void SetStickerVisible(bool visible)
	{
		if (this.Sticker == null)
		{
			return;
		}
		this.HasSticker = visible;
		this.Sticker.SetUiActive(visible);
		this.Sticker.SetEditable(visible);
		this.RefreshStickerHotKey();
	}

	// Token: 0x060136A8 RID: 79528 RVA: 0x004D6306 File Offset: 0x004D4506
	private void OnRequestRemoveSticker()
	{
		if (this.Sticker == null)
		{
			return;
		}
		if (this.IsCreatingSticker)
		{
			this.IsPendingRemoveSticker = true;
			return;
		}
		this.RemoveSticker(this.Sticker);
	}

	// Token: 0x060136A9 RID: 79529 RVA: 0x004D632D File Offset: 0x004D452D
	private void ClearStickerSelection()
	{
		this.SetStickerSelected(false);
	}

	// Token: 0x060136AA RID: 79530 RVA: 0x004D6336 File Offset: 0x004D4536
	private void SetStickerSelected(bool selected)
	{
		if (selected)
		{
			this.JoystickOwner.Request(EPhotoJoystickOwner.Sticker, true);
			return;
		}
		this.JoystickOwner.Release(EPhotoJoystickOwner.Sticker);
	}

	// Token: 0x060136AB RID: 79531 RVA: 0x004D6356 File Offset: 0x004D4556
	private void OnStickerSelectedChanged(bool selected)
	{
		PhotoLeftPanel leftPanel = this.LeftPanel;
		if (leftPanel != null)
		{
			leftPanel.SetStickerEditing(selected);
		}
		PhotoRightPanel rightPanel = this.RightPanel;
		if (rightPanel == null)
		{
			return;
		}
		rightPanel.SetStickerEditing(selected);
	}

	// Token: 0x060136AC RID: 79532 RVA: 0x004D637B File Offset: 0x004D457B
	private void OnRequestSelectSticker()
	{
		if (this.Sticker == null || !this.HasSticker)
		{
			return;
		}
		this.SelectSticker(this.Sticker);
	}

	// Token: 0x060136AD RID: 79533 RVA: 0x004D639A File Offset: 0x004D459A
	private void OnRequestDeselectSticker()
	{
		this.ClearStickerSelection();
	}

	// Token: 0x060136AE RID: 79534 RVA: 0x004D63A4 File Offset: 0x004D45A4
	private void OnRequestChangeStickerScale(float ratio)
	{
		if (!this.IsStickerSelected || this.Sticker == null || !this.HasSticker)
		{
			return;
		}
		this.Sticker.ChangeScaleByDelta(ratio * ConfigCommonParamById.GetFloatConfig("PhotoStickerScaleStep").GetValueOrDefault(0.01f));
	}

	// Token: 0x060136AF RID: 79535 RVA: 0x004D63F0 File Offset: 0x004D45F0
	private void MoveSticker(float delta)
	{
		if (this.Sticker == null)
		{
			return;
		}
		float valueOrDefault = ConfigCommonParamById.GetFloatConfig("PhotoStickerMoveSpeed").GetValueOrDefault(1f);
		this.Sticker.MoveByDelta(this.StickerMoveInputHor * valueOrDefault * delta, this.StickerMoveInputVer * valueOrDefault * delta);
	}

	// Token: 0x060136B0 RID: 79536 RVA: 0x004D643D File Offset: 0x004D463D
	private void OnNavigationFocusChanged()
	{
		this.JoystickOwner.OnNavigationFocusChanged();
	}

	// Token: 0x060136B1 RID: 79537 RVA: 0x004D644C File Offset: 0x004D464C
	private void OnJoystickOwnerChanged(EPhotoJoystickOwner prev, EPhotoJoystickOwner next)
	{
		if (prev != EPhotoJoystickOwner.Sticker)
		{
			if (prev == EPhotoJoystickOwner.Cursor)
			{
				this.CursorInputHor = 0f;
				this.CursorInputVer = 0f;
				UUIButtonComponent button = base.GetButton(12);
				if (button != null)
				{
					UUIItem uuiitem = button.RootUIComp.Get();
					if (uuiitem != null)
					{
						uuiitem.SetUIActive(false);
					}
				}
				this.SetVisibleMode(true, true);
			}
		}
		else
		{
			this.StickerMoveInputHor = 0f;
			this.StickerMoveInputVer = 0f;
			PhotoStickerItem sticker = this.Sticker;
			if (sticker != null)
			{
				sticker.SetSelected(false);
			}
			Action<bool> onStickerSelectedChanged = this.ViewModel.OnStickerSelectedChanged;
			if (onStickerSelectedChanged != null)
			{
				onStickerSelectedChanged(false);
			}
			UUIItem item = base.GetItem(20);
			if (item != null)
			{
				item.SetUIActive(this.VisibleMode);
			}
		}
		if (next != EPhotoJoystickOwner.Sticker)
		{
			if (next == EPhotoJoystickOwner.Cursor)
			{
				UUIButtonComponent button2 = base.GetButton(12);
				if (button2 != null)
				{
					UUIItem uuiitem2 = button2.RootUIComp.Get();
					if (uuiitem2 != null)
					{
						uuiitem2.SetUIActive(true);
					}
				}
				this.SetVisibleMode(false, true);
			}
		}
		else
		{
			PhotoStickerItem sticker2 = this.Sticker;
			if (sticker2 != null)
			{
				sticker2.SetSelected(true);
			}
			Action<bool> onStickerSelectedChanged2 = this.ViewModel.OnStickerSelectedChanged;
			if (onStickerSelectedChanged2 != null)
			{
				onStickerSelectedChanged2(true);
			}
			UUIItem item2 = base.GetItem(20);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
		this.RefreshHotKeyPanel();
		this.RefreshStickerHotKey();
	}

	// Token: 0x060136B2 RID: 79538 RVA: 0x004D6589 File Offset: 0x004D4789
	private void OnFrameSelected(int frameId)
	{
		this.ApplyFrame(frameId);
	}

	// Token: 0x060136B3 RID: 79539 RVA: 0x004D6592 File Offset: 0x004D4792
	private void OnViewPortSizeChanged()
	{
		this.CursorBoundsDirty = true;
		this.ApplyFrame(this.ViewModel.CurrentFrameId);
	}

	// Token: 0x060136B4 RID: 79540 RVA: 0x004D65AC File Offset: 0x004D47AC
	private unsafe void ApplyFrame(int frameId)
	{
		PhotoMainView.<>c__DisplayClass122_0 CS$<>8__locals1 = new PhotoMainView.<>c__DisplayClass122_0();
		CS$<>8__locals1.<>4__this = this;
		PhotoFrame? config = ConfigPhotoFrameById.GetConfig(frameId, true);
		if (config == null)
		{
			this.ClearFrame();
			return;
		}
		PhotoFrame value = config.Value;
		if (!Enum.IsDefined(typeof(EPhotoFrameMode), value.Mode))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhotoCamera;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "拍照画幅:配表 Mode 非法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("frameId", frameId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("mode", value.Mode);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.ClearFrame();
			return;
		}
		EPhotoFrameMode mode = (EPhotoFrameMode)value.Mode;
		if (mode == EPhotoFrameMode.None)
		{
			this.ClearFrame();
			return;
		}
		this.FrameApplyToken++;
		ValueTuple<float, float, float, float> valueTuple = FightPhotoModel.Instance.CalcFrameRect(value.AspectRatio, value.ScreenRatio);
		PhotoCameraEffectComponent photoCameraComponent = PhotographController.Instance.GetPhotoCameraComponent<PhotoCameraEffectComponent>(EPhotoCameraComponent.Effect);
		if (photoCameraComponent != null)
		{
			photoCameraComponent.ApplyFrame(value, valueTuple.Item3, valueTuple.Item4, !this.IsInCaptureMode);
		}
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(mode == EPhotoFrameMode.Frame);
		}
		if (mode == EPhotoFrameMode.Frame && item != null)
		{
			item.SetWidth(valueTuple.Item1);
			item.SetHeight(valueTuple.Item2);
			UUIItem uuiitem = item;
			FRotator frotator = new FRotator(0f, value.RotationAngle * 360f, 0f);
			uuiitem.SetUIRelativeRotation(frotator);
		}
		CS$<>8__locals1.tex = base.GetTexture(11);
		if (mode != EPhotoFrameMode.TextureFrame)
		{
			UUITexture tex = CS$<>8__locals1.tex;
			if (tex != null)
			{
				tex.SetUIActive(false);
			}
		}
		else if (CS$<>8__locals1.tex != null)
		{
			PhotoMainView.<>c__DisplayClass122_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = this.FrameApplyToken + 1;
			this.FrameApplyToken = num;
			CS$<>8__locals2.token = num;
			string texturePath = value.TexturePath;
			CS$<>8__locals1.texWidth = valueTuple.Item1 * value.LengthRatio;
			CS$<>8__locals1.texHeight = valueTuple.Item2 * value.WidthRatio;
			CS$<>8__locals1.texRotation = value.RotationAngle * 360f;
			base.SetTextureByPath(texturePath, CS$<>8__locals1.tex, null, delegate(bool success)
			{
				if (!success || CS$<>8__locals1.token != CS$<>8__locals1.<>4__this.FrameApplyToken)
				{
					return;
				}
				CS$<>8__locals1.tex.SetWidth(CS$<>8__locals1.texWidth);
				CS$<>8__locals1.tex.SetHeight(CS$<>8__locals1.texHeight);
				UUIItem tex2 = CS$<>8__locals1.tex;
				FRotator frotator2 = new FRotator(0f, CS$<>8__locals1.texRotation, 0f);
				tex2.SetUIRelativeRotation(frotator2);
				CS$<>8__locals1.tex.SetUIActive(true);
			});
		}
		this.HasFrameApplied = true;
	}

	// Token: 0x060136B5 RID: 79541 RVA: 0x004D6800 File Offset: 0x004D4A00
	private void ClearFrame()
	{
		this.ViewModel.ResetFrameId();
		if (!this.HasFrameApplied)
		{
			return;
		}
		this.HasFrameApplied = false;
		PhotoCameraEffectComponent photoCameraComponent = PhotographController.Instance.GetPhotoCameraComponent<PhotoCameraEffectComponent>(EPhotoCameraComponent.Effect);
		if (photoCameraComponent != null)
		{
			photoCameraComponent.ResetFrame();
		}
		this.FrameApplyToken++;
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUITexture texture = base.GetTexture(11);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(false);
	}

	// Token: 0x040091FE RID: 37374
	private readonly PhotoMainViewModel ViewModel = new PhotoMainViewModel();

	// Token: 0x040091FF RID: 37375
	private readonly PhotoJoystickOwnerController JoystickOwner = new PhotoJoystickOwnerController();

	// Token: 0x04009200 RID: 37376
	[Nullable(2)]
	private PhotoSaveMarkItem PlayerInfoItem;

	// Token: 0x04009201 RID: 37377
	[Nullable(2)]
	private PhotoLeftPanel LeftPanel;

	// Token: 0x04009202 RID: 37378
	[Nullable(2)]
	private PhotoRightPanel RightPanel;

	// Token: 0x04009203 RID: 37379
	private const string SWITCH_MODE_BLACK_SCREEN_EVENT = "Sequence_Switch";

	// Token: 0x04009204 RID: 37380
	[Nullable(2)]
	private CustomPromise<bool> SwitchModeAnimPromise;

	// Token: 0x04009205 RID: 37381
	[Nullable(2)]
	private CustomPromise<bool> SwitchModeAnimEndPromise;

	// Token: 0x04009206 RID: 37382
	private const string STICKER_RES_ID = "UiItem_StickerScreenItem";

	// Token: 0x04009207 RID: 37383
	[Nullable(2)]
	private PhotoStickerItem Sticker;

	// Token: 0x04009208 RID: 37384
	private bool IsCreatingSticker;

	// Token: 0x04009209 RID: 37385
	private bool IsPendingRemoveSticker;

	// Token: 0x0400920A RID: 37386
	private bool HasSticker;

	// Token: 0x0400920B RID: 37387
	private PhotoSticker? PendingStickerCfg;

	// Token: 0x0400920C RID: 37388
	private float StickerMoveInputHor;

	// Token: 0x0400920D RID: 37389
	private float StickerMoveInputVer;

	// Token: 0x0400920E RID: 37390
	private bool IsDragging;

	// Token: 0x0400920F RID: 37391
	private float LastDragX;

	// Token: 0x04009210 RID: 37392
	private float LastDragY;

	// Token: 0x04009211 RID: 37393
	private float PendingPitch;

	// Token: 0x04009212 RID: 37394
	private float PendingYaw;

	// Token: 0x04009213 RID: 37395
	private float PendingFov;

	// Token: 0x04009214 RID: 37396
	private bool InDragMove;

	// Token: 0x04009215 RID: 37397
	private bool VisibleMode = true;

	// Token: 0x04009216 RID: 37398
	private readonly Vector2D TempVector2D = Vector2D.Create();

	// Token: 0x04009217 RID: 37399
	private float CursorInputHor;

	// Token: 0x04009218 RID: 37400
	private float CursorInputVer;

	// Token: 0x04009219 RID: 37401
	private bool CursorBoundsDirty = true;

	// Token: 0x0400921A RID: 37402
	private float CursorBoundsMinX;

	// Token: 0x0400921B RID: 37403
	private float CursorBoundsMaxX;

	// Token: 0x0400921C RID: 37404
	private float CursorBoundsMinY;

	// Token: 0x0400921D RID: 37405
	private float CursorBoundsMaxY;

	// Token: 0x0400921E RID: 37406
	private int FrameApplyToken;

	// Token: 0x0400921F RID: 37407
	private bool IsInCaptureMode;

	// Token: 0x04009220 RID: 37408
	private bool HasFrameApplied;

	// Token: 0x04009221 RID: 37409
	private const float DRAG_ROTATE_RATE = 0.1f;

	// Token: 0x04009222 RID: 37410
	private const int MIN_TOUCH_MOVE_DIFFERENCE = -50000;

	// Token: 0x04009223 RID: 37411
	private const int MAX_TOUCH_MOVE_DIFFERENCE = 50000;

	// Token: 0x02008B7D RID: 35709
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D4B9 RID: 185529
		DragScreen,
		// Token: 0x0402D4BA RID: 185530
		ItemPlayerInfo,
		// Token: 0x0402D4BB RID: 185531
		ItemHideAll,
		// Token: 0x0402D4BC RID: 185532
		ItemLeft,
		// Token: 0x0402D4BD RID: 185533
		ItemRight,
		// Token: 0x0402D4BE RID: 185534
		ItemKeyA,
		// Token: 0x0402D4BF RID: 185535
		ItemStickerContent,
		// Token: 0x0402D4C0 RID: 185536
		ItemSliceLinePanel,
		// Token: 0x0402D4C1 RID: 185537
		ItemFocusFrame,
		// Token: 0x0402D4C2 RID: 185538
		ItemUiParentPanel,
		// Token: 0x0402D4C3 RID: 185539
		ItemPhotoFrameParent,
		// Token: 0x0402D4C4 RID: 185540
		TextureFrame,
		// Token: 0x0402D4C5 RID: 185541
		BtnCursor,
		// Token: 0x0402D4C6 RID: 185542
		TextDebug,
		// Token: 0x0402D4C7 RID: 185543
		ItemHideOnly,
		// Token: 0x0402D4C8 RID: 185544
		ItemKeyALB,
		// Token: 0x0402D4C9 RID: 185545
		ItemKeyB,
		// Token: 0x0402D4CA RID: 185546
		ItemKeyBLB,
		// Token: 0x0402D4CB RID: 185547
		ItemKeyC,
		// Token: 0x0402D4CC RID: 185548
		ItemKeyCLB,
		// Token: 0x0402D4CD RID: 185549
		ItemHotKeyRoot
	}
}
