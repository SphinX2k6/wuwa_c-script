using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A69 RID: 6761
[NullableContext(1)]
[Nullable(0)]
public class PhotoMainView : UiTickViewBase
{
	// Token: 0x1700193D RID: 6461
	// (get) Token: 0x06010B44 RID: 68420 RVA: 0x004E2D72 File Offset: 0x004E0F72
	private bool IsStickerSelected
	{
		get
		{
			return this.JoystickOwner.Current == EPhotoJoystickOwner.Sticker;
		}
	}

	// Token: 0x1700193E RID: 6462
	// (get) Token: 0x06010B45 RID: 68421 RVA: 0x004E2D82 File Offset: 0x004E0F82
	private bool IsCursorMode
	{
		get
		{
			return this.JoystickOwner.Current == EPhotoJoystickOwner.Cursor;
		}
	}

	// Token: 0x06010B46 RID: 68422 RVA: 0x004E2D92 File Offset: 0x004E0F92
	public PhotoMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010B47 RID: 68423 RVA: 0x004E2DCC File Offset: 0x004E0FCC
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

	// Token: 0x06010B48 RID: 68424 RVA: 0x004E2FE4 File Offset: 0x004E11E4
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoMainView.<OnBeforeStartAsync>d__45 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoMainView.<OnBeforeStartAsync>d__45>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010B49 RID: 68425 RVA: 0x004E3028 File Offset: 0x004E1228
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

	// Token: 0x06010B4A RID: 68426 RVA: 0x004E331B File Offset: 0x004E151B
	private void OnCameraTiltRollChanged(float roll)
	{
		PhotographController.Instance.OnCameraTiltRollChanged(roll);
	}

	// Token: 0x06010B4B RID: 68427 RVA: 0x004E3328 File Offset: 0x004E1528
	private void OnTemplateDepthOfFieldChanged(float focusDistance, float aperture)
	{
		PhotographController.Instance.OnTemplateDepthOfFieldChanged(focusDistance, aperture);
	}

	// Token: 0x06010B4C RID: 68428 RVA: 0x004E3336 File Offset: 0x004E1536
	private void OnRequestOpenLastDetailPanel()
	{
		PhotoLeftPanel leftPanel = this.LeftPanel;
		if (leftPanel == null)
		{
			return;
		}
		leftPanel.OpenLastDetailPanel();
	}

	// Token: 0x06010B4D RID: 68429 RVA: 0x004E3348 File Offset: 0x004E1548
	protected override void OnBeforeShow()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag(this.ViewInfo.Name);
		InputDistributeController.Instance.BindTouches(new int[]
		{
			0,
			1
		}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
	}

	// Token: 0x06010B4E RID: 68430 RVA: 0x004E3384 File Offset: 0x004E1584
	protected override void OnAfterPlayStartSequence()
	{
		base.OnAfterPlayStartSequence();
		if (PhotographController.Instance.GetManualFocusOn())
		{
			this.PlayFocusAtScreenCenter();
		}
	}

	// Token: 0x06010B4F RID: 68431 RVA: 0x004E33A0 File Offset: 0x004E15A0
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

	// Token: 0x06010B50 RID: 68432 RVA: 0x004E3614 File Offset: 0x004E1814
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

	// Token: 0x06010B51 RID: 68433 RVA: 0x004E37C2 File Offset: 0x004E19C2
	protected override void OnAfterHide()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag(this.ViewInfo.Name);
		InputDistributeController.Instance.UnBindTouches(new int[]
		{
			0,
			1
		}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
	}

	// Token: 0x06010B52 RID: 68434 RVA: 0x004E37FE File Offset: 0x004E19FE
	private void OnOpenViewForTimeDilation(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.PhotoSaveView)
		{
			return;
		}
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag(this.ViewInfo.Name);
	}

	// Token: 0x06010B53 RID: 68435 RVA: 0x004E3828 File Offset: 0x004E1A28
	private void OnCloseViewForTimeDilation(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.PhotoSaveView)
		{
			return;
		}
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag(this.ViewInfo.Name);
	}

	// Token: 0x06010B54 RID: 68436 RVA: 0x004E3854 File Offset: 0x004E1A54
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

	// Token: 0x06010B55 RID: 68437 RVA: 0x004E3A8C File Offset: 0x004E1C8C
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		int playerId = CreatureModel.Instance.GetPlayerId();
		FormationDataController.Instance.RemovePlayerTag(playerId, new int?(GameplayTagDefine.EGameplayTagId["系统.功能.进入拍照"]));
		PhotographController.Instance.ResetPhotoCamera();
		if (PhotographController.Instance.GetPhotoCamera() != null)
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			if (fightCamera != null)
			{
				FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
				if (logicComponent != null)
				{
					logicComponent.ExitPhotoCamera();
				}
			}
		}
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

	// Token: 0x06010B56 RID: 68438 RVA: 0x004E3E60 File Offset: 0x004E2060
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

	// Token: 0x06010B57 RID: 68439 RVA: 0x004E3F2C File Offset: 0x004E212C
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

	// Token: 0x06010B58 RID: 68440 RVA: 0x004E3F7C File Offset: 0x004E217C
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

	// Token: 0x06010B59 RID: 68441 RVA: 0x004E3FCC File Offset: 0x004E21CC
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

	// Token: 0x06010B5A RID: 68442 RVA: 0x004E4010 File Offset: 0x004E2210
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

	// Token: 0x06010B5B RID: 68443 RVA: 0x004E4051 File Offset: 0x004E2251
	private void OnInputUiLookInOut(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoMoveForward", value, false);
	}

	// Token: 0x06010B5C RID: 68444 RVA: 0x004E406D File Offset: 0x004E226D
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

	// Token: 0x06010B5D RID: 68445 RVA: 0x004E4097 File Offset: 0x004E2297
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

	// Token: 0x06010B5E RID: 68446 RVA: 0x004E40C0 File Offset: 0x004E22C0
	private void OnInputUiCamRotate(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		InputDistributeController.Instance.InputAxis("PhotoRoll", value, false);
	}

	// Token: 0x06010B5F RID: 68447 RVA: 0x004E40DC File Offset: 0x004E22DC
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

	// Token: 0x06010B60 RID: 68448 RVA: 0x004E4114 File Offset: 0x004E2314
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

	// Token: 0x06010B61 RID: 68449 RVA: 0x004E41BC File Offset: 0x004E23BC
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

	// Token: 0x06010B62 RID: 68450 RVA: 0x004E4233 File Offset: 0x004E2433
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

	// Token: 0x06010B63 RID: 68451 RVA: 0x004E4254 File Offset: 0x004E2454
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

	// Token: 0x06010B64 RID: 68452 RVA: 0x004E42CC File Offset: 0x004E24CC
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

	// Token: 0x06010B65 RID: 68453 RVA: 0x004E4360 File Offset: 0x004E2560
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

	// Token: 0x06010B66 RID: 68454 RVA: 0x004E43AC File Offset: 0x004E25AC
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

	// Token: 0x06010B67 RID: 68455 RVA: 0x004E43F7 File Offset: 0x004E25F7
	private void OnSwitchModeSequenceEnd(string sequenceName)
	{
		CustomPromise<bool> switchModeAnimEndPromise = this.SwitchModeAnimEndPromise;
		if (switchModeAnimEndPromise == null)
		{
			return;
		}
		switchModeAnimEndPromise.SetResult(true);
	}

	// Token: 0x06010B68 RID: 68456 RVA: 0x004E440A File Offset: 0x004E260A
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

	// Token: 0x06010B69 RID: 68457 RVA: 0x004E442C File Offset: 0x004E262C
	private void OnDetailPanelClosed()
	{
		base.PlayOrReplaySequence("Close1", false, null);
	}

	// Token: 0x06010B6A RID: 68458 RVA: 0x004E4450 File Offset: 0x004E2650
	private void OnDetailPanelOpened()
	{
		base.PlayOrReplaySequence("BaseStart", false, null);
	}

	// Token: 0x06010B6B RID: 68459 RVA: 0x004E4474 File Offset: 0x004E2674
	private FVector ViewportPosToCanvasPos(FVector2D viewportPos)
	{
		this.TempVector2D.Set((double)viewportPos.X, (double)viewportPos.Y);
		Vector2D tempVector2D = this.TempVector2D;
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		FVector2D fvector2D = this.TempVector2D.ToUeVector2D(true);
		tempVector2D.FromUeVector2D(canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D));
		return new FVector((float)this.TempVector2D.X, (float)this.TempVector2D.Y, 0f);
	}

	// Token: 0x06010B6C RID: 68460 RVA: 0x004E44F0 File Offset: 0x004E26F0
	private FVector2D CanvasPosToViewportPos(FVector canvasPos)
	{
		this.TempVector2D.Set((double)canvasPos.X, (double)canvasPos.Y);
		Vector2D tempVector2D = this.TempVector2D;
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		FVector2D fvector2D = this.TempVector2D.ToUeVector2D(true);
		tempVector2D.FromUeVector2D(canvasScaler.ConvertPositionFromLGUICanvasToViewport(fvector2D));
		return new FVector2D((float)this.TempVector2D.X, (float)this.TempVector2D.Y);
	}

	// Token: 0x06010B6D RID: 68461 RVA: 0x004E4566 File Offset: 0x004E2766
	private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification inputIdentification)
	{
		if (touchData.TouchType != InputDistributeDefine.ETouchType.TouchMove)
		{
			return;
		}
		this.TouchMoved();
	}

	// Token: 0x06010B6E RID: 68462 RVA: 0x004E4578 File Offset: 0x004E2778
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

	// Token: 0x06010B6F RID: 68463 RVA: 0x004E4649 File Offset: 0x004E2849
	[NullableContext(2)]
	private void OnPointerScroll(ULGUIPointerEventData eventData)
	{
		if (eventData == null || eventData.scrollAxisValue == 0f)
		{
			return;
		}
		this.PendingFov += eventData.scrollAxisValue;
	}

	// Token: 0x06010B70 RID: 68464 RVA: 0x004E466F File Offset: 0x004E286F
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

	// Token: 0x06010B71 RID: 68465 RVA: 0x004E469C File Offset: 0x004E289C
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

	// Token: 0x06010B72 RID: 68466 RVA: 0x004E46EA File Offset: 0x004E28EA
	private void OnInputCameraFocusHor(string axisName, float value, InputIdentification inputIdentification)
	{
		if (!this.IsCursorMode)
		{
			return;
		}
		this.CursorInputHor = value;
	}

	// Token: 0x06010B73 RID: 68467 RVA: 0x004E46FC File Offset: 0x004E28FC
	private void OnInputCameraFocusVer(string axisName, float value, InputIdentification inputIdentification)
	{
		if (!this.IsCursorMode)
		{
			return;
		}
		this.CursorInputVer = value;
	}

	// Token: 0x06010B74 RID: 68468 RVA: 0x004E4710 File Offset: 0x004E2910
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

	// Token: 0x06010B75 RID: 68469 RVA: 0x004E47D8 File Offset: 0x004E29D8
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

	// Token: 0x06010B76 RID: 68470 RVA: 0x004E4884 File Offset: 0x004E2A84
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

	// Token: 0x06010B77 RID: 68471 RVA: 0x004E48DA File Offset: 0x004E2ADA
	private void EnterCursorMode()
	{
		this.JoystickOwner.Request(EPhotoJoystickOwner.Cursor, false);
	}

	// Token: 0x06010B78 RID: 68472 RVA: 0x004E48EA File Offset: 0x004E2AEA
	private void ExitCursorMode()
	{
		this.JoystickOwner.Release(EPhotoJoystickOwner.Cursor);
	}

	// Token: 0x06010B79 RID: 68473 RVA: 0x004E48F8 File Offset: 0x004E2AF8
	private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		if (now == EInputControllerMainType.Gamepad)
		{
			return;
		}
		this.ExitCursorMode();
		this.RefreshStickerHotKey();
	}

	// Token: 0x06010B7A RID: 68474 RVA: 0x004E490B File Offset: 0x004E2B0B
	private void OnRequestHideUi()
	{
		this.SetVisibleMode(false, false);
	}

	// Token: 0x06010B7B RID: 68475 RVA: 0x004E4918 File Offset: 0x004E2B18
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

	// Token: 0x06010B7C RID: 68476 RVA: 0x004E4978 File Offset: 0x004E2B78
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

	// Token: 0x06010B7D RID: 68477 RVA: 0x004E4A47 File Offset: 0x004E2C47
	private void RefreshStickerHotKey()
	{
		PhotoStickerItem sticker = this.Sticker;
		if (sticker == null)
		{
			return;
		}
		sticker.SetHotKeyVisible(this.HasSticker && !this.IsInCaptureMode && !this.IsCursorMode);
	}

	// Token: 0x06010B7E RID: 68478 RVA: 0x004E4A75 File Offset: 0x004E2C75
	private void OnModeChanged(PhotoCameraType mode)
	{
		this.RefreshHotKeyPanel();
		this.SyncLightToViewModel();
	}

	// Token: 0x06010B7F RID: 68479 RVA: 0x004E4A84 File Offset: 0x004E2C84
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

	// Token: 0x06010B80 RID: 68480 RVA: 0x004E4AF6 File Offset: 0x004E2CF6
	private void OnPhotographSetVisible()
	{
		this.SetVisibleMode(true, false);
	}

	// Token: 0x06010B81 RID: 68481 RVA: 0x004E4B00 File Offset: 0x004E2D00
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

	// Token: 0x06010B82 RID: 68482 RVA: 0x004E4BBD File Offset: 0x004E2DBD
	private void SetAuxiliaryLineVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x06010B83 RID: 68483 RVA: 0x004E4BD1 File Offset: 0x004E2DD1
	private void OnRequestClose()
	{
		PhotographController.Instance.ClosePhotoCamera().Forget();
	}

	// Token: 0x06010B84 RID: 68484 RVA: 0x004E4BE4 File Offset: 0x004E2DE4
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

	// Token: 0x06010B85 RID: 68485 RVA: 0x004E4C54 File Offset: 0x004E2E54
	private UniTask CreateSticker()
	{
		PhotoMainView.<CreateSticker>d__106 <CreateSticker>d__;
		<CreateSticker>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSticker>d__.<>4__this = this;
		<CreateSticker>d__.<>1__state = -1;
		<CreateSticker>d__.<>t__builder.Start<PhotoMainView.<CreateSticker>d__106>(ref <CreateSticker>d__);
		return <CreateSticker>d__.<>t__builder.Task;
	}

	// Token: 0x06010B86 RID: 68486 RVA: 0x004E4C97 File Offset: 0x004E2E97
	private void SelectSticker(PhotoStickerItem item)
	{
		if (this.Sticker != item || !this.HasSticker)
		{
			return;
		}
		this.SetStickerSelected(true);
	}

	// Token: 0x06010B87 RID: 68487 RVA: 0x004E4CB4 File Offset: 0x004E2EB4
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

	// Token: 0x06010B88 RID: 68488 RVA: 0x004E4D02 File Offset: 0x004E2F02
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

	// Token: 0x06010B89 RID: 68489 RVA: 0x004E4D32 File Offset: 0x004E2F32
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

	// Token: 0x06010B8A RID: 68490 RVA: 0x004E4D59 File Offset: 0x004E2F59
	private void ClearStickerSelection()
	{
		this.SetStickerSelected(false);
	}

	// Token: 0x06010B8B RID: 68491 RVA: 0x004E4D62 File Offset: 0x004E2F62
	private void SetStickerSelected(bool selected)
	{
		if (selected)
		{
			this.JoystickOwner.Request(EPhotoJoystickOwner.Sticker, true);
			return;
		}
		this.JoystickOwner.Release(EPhotoJoystickOwner.Sticker);
	}

	// Token: 0x06010B8C RID: 68492 RVA: 0x004E4D82 File Offset: 0x004E2F82
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

	// Token: 0x06010B8D RID: 68493 RVA: 0x004E4DA7 File Offset: 0x004E2FA7
	private void OnRequestSelectSticker()
	{
		if (this.Sticker == null || !this.HasSticker)
		{
			return;
		}
		this.SelectSticker(this.Sticker);
	}

	// Token: 0x06010B8E RID: 68494 RVA: 0x004E4DC6 File Offset: 0x004E2FC6
	private void OnRequestDeselectSticker()
	{
		this.ClearStickerSelection();
	}

	// Token: 0x06010B8F RID: 68495 RVA: 0x004E4DD0 File Offset: 0x004E2FD0
	private void OnRequestChangeStickerScale(float ratio)
	{
		if (!this.IsStickerSelected || this.Sticker == null || !this.HasSticker)
		{
			return;
		}
		this.Sticker.ChangeScaleByDelta(ratio * ConfigCommonParamById.GetFloatConfig("PhotoStickerScaleStep").GetValueOrDefault(0.01f));
	}

	// Token: 0x06010B90 RID: 68496 RVA: 0x004E4E1C File Offset: 0x004E301C
	private void MoveSticker(float delta)
	{
		if (this.Sticker == null)
		{
			return;
		}
		float valueOrDefault = ConfigCommonParamById.GetFloatConfig("PhotoStickerMoveSpeed").GetValueOrDefault(1f);
		this.Sticker.MoveByDelta(this.StickerMoveInputHor * valueOrDefault * delta, this.StickerMoveInputVer * valueOrDefault * delta);
	}

	// Token: 0x06010B91 RID: 68497 RVA: 0x004E4E69 File Offset: 0x004E3069
	private void OnNavigationFocusChanged()
	{
		this.JoystickOwner.OnNavigationFocusChanged();
	}

	// Token: 0x06010B92 RID: 68498 RVA: 0x004E4E78 File Offset: 0x004E3078
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

	// Token: 0x06010B93 RID: 68499 RVA: 0x004E4FB5 File Offset: 0x004E31B5
	private void OnFrameSelected(int frameId)
	{
		this.ApplyFrame(frameId);
	}

	// Token: 0x06010B94 RID: 68500 RVA: 0x004E4FBE File Offset: 0x004E31BE
	private void OnViewPortSizeChanged()
	{
		this.CursorBoundsDirty = true;
		this.ApplyFrame(this.ViewModel.CurrentFrameId);
	}

	// Token: 0x06010B95 RID: 68501 RVA: 0x004E4FD8 File Offset: 0x004E31D8
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

	// Token: 0x06010B96 RID: 68502 RVA: 0x004E522C File Offset: 0x004E342C
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

	// Token: 0x04009356 RID: 37718
	private readonly PhotoMainViewModel ViewModel = new PhotoMainViewModel();

	// Token: 0x04009357 RID: 37719
	private readonly PhotoJoystickOwnerController JoystickOwner = new PhotoJoystickOwnerController();

	// Token: 0x04009358 RID: 37720
	[Nullable(2)]
	private PhotoSaveMarkItem PlayerInfoItem;

	// Token: 0x04009359 RID: 37721
	[Nullable(2)]
	private PhotoLeftPanel LeftPanel;

	// Token: 0x0400935A RID: 37722
	[Nullable(2)]
	private PhotoRightPanel RightPanel;

	// Token: 0x0400935B RID: 37723
	private const string SWITCH_MODE_BLACK_SCREEN_EVENT = "Sequence_Switch";

	// Token: 0x0400935C RID: 37724
	[Nullable(2)]
	private CustomPromise<bool> SwitchModeAnimPromise;

	// Token: 0x0400935D RID: 37725
	[Nullable(2)]
	private CustomPromise<bool> SwitchModeAnimEndPromise;

	// Token: 0x0400935E RID: 37726
	private const string STICKER_RES_ID = "UiItem_StickerScreenItem";

	// Token: 0x0400935F RID: 37727
	[Nullable(2)]
	private PhotoStickerItem Sticker;

	// Token: 0x04009360 RID: 37728
	private bool IsCreatingSticker;

	// Token: 0x04009361 RID: 37729
	private bool IsPendingRemoveSticker;

	// Token: 0x04009362 RID: 37730
	private bool HasSticker;

	// Token: 0x04009363 RID: 37731
	private PhotoSticker? PendingStickerCfg;

	// Token: 0x04009364 RID: 37732
	private float StickerMoveInputHor;

	// Token: 0x04009365 RID: 37733
	private float StickerMoveInputVer;

	// Token: 0x04009366 RID: 37734
	private bool IsDragging;

	// Token: 0x04009367 RID: 37735
	private float LastDragX;

	// Token: 0x04009368 RID: 37736
	private float LastDragY;

	// Token: 0x04009369 RID: 37737
	private float PendingPitch;

	// Token: 0x0400936A RID: 37738
	private float PendingYaw;

	// Token: 0x0400936B RID: 37739
	private float PendingFov;

	// Token: 0x0400936C RID: 37740
	private bool InDragMove;

	// Token: 0x0400936D RID: 37741
	private bool VisibleMode = true;

	// Token: 0x0400936E RID: 37742
	private readonly Vector2D TempVector2D = Vector2D.Create();

	// Token: 0x0400936F RID: 37743
	private float CursorInputHor;

	// Token: 0x04009370 RID: 37744
	private float CursorInputVer;

	// Token: 0x04009371 RID: 37745
	private bool CursorBoundsDirty = true;

	// Token: 0x04009372 RID: 37746
	private float CursorBoundsMinX;

	// Token: 0x04009373 RID: 37747
	private float CursorBoundsMaxX;

	// Token: 0x04009374 RID: 37748
	private float CursorBoundsMinY;

	// Token: 0x04009375 RID: 37749
	private float CursorBoundsMaxY;

	// Token: 0x04009376 RID: 37750
	private int FrameApplyToken;

	// Token: 0x04009377 RID: 37751
	private bool IsInCaptureMode;

	// Token: 0x04009378 RID: 37752
	private bool HasFrameApplied;

	// Token: 0x04009379 RID: 37753
	private const float DRAG_ROTATE_RATE = 0.1f;

	// Token: 0x0400937A RID: 37754
	private const int MIN_TOUCH_MOVE_DIFFERENCE = -50000;

	// Token: 0x0400937B RID: 37755
	private const int MAX_TOUCH_MOVE_DIFFERENCE = 50000;

	// Token: 0x02007D03 RID: 32003
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040287C6 RID: 165830
		DragScreen,
		// Token: 0x040287C7 RID: 165831
		ItemPlayerInfo,
		// Token: 0x040287C8 RID: 165832
		ItemHideAll,
		// Token: 0x040287C9 RID: 165833
		ItemLeft,
		// Token: 0x040287CA RID: 165834
		ItemRight,
		// Token: 0x040287CB RID: 165835
		ItemKeyA,
		// Token: 0x040287CC RID: 165836
		ItemStickerContent,
		// Token: 0x040287CD RID: 165837
		ItemSliceLinePanel,
		// Token: 0x040287CE RID: 165838
		ItemFocusFrame,
		// Token: 0x040287CF RID: 165839
		ItemUiParentPanel,
		// Token: 0x040287D0 RID: 165840
		ItemPhotoFrameParent,
		// Token: 0x040287D1 RID: 165841
		TextureFrame,
		// Token: 0x040287D2 RID: 165842
		BtnCursor,
		// Token: 0x040287D3 RID: 165843
		TextDebug,
		// Token: 0x040287D4 RID: 165844
		ItemHideOnly,
		// Token: 0x040287D5 RID: 165845
		ItemKeyALB,
		// Token: 0x040287D6 RID: 165846
		ItemKeyB,
		// Token: 0x040287D7 RID: 165847
		ItemKeyBLB,
		// Token: 0x040287D8 RID: 165848
		ItemKeyC,
		// Token: 0x040287D9 RID: 165849
		ItemKeyCLB,
		// Token: 0x040287DA RID: 165850
		ItemHotKeyRoot
	}
}
