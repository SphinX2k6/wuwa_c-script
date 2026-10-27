using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Role;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.LevelEvents;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.Menu.SubViews.EyeProtect;
using CSharpScript.Game.Module.QuickTimeAction;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002556 RID: 9558
[NullableContext(2)]
[Nullable(0)]
public class CaptureCollectView : UiViewBase, IQtaView, IUiProhibitRefreshData
{
	// Token: 0x0601342F RID: 78895 RVA: 0x004CA3AC File Offset: 0x004C85AC
	[NullableContext(1)]
	public CaptureCollectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013430 RID: 78896 RVA: 0x004CA418 File Offset: 0x004C8618
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnPhotographButtonClicked)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnFilterButtonClicked)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnAddButtonButtonClicked)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnReduceButtonClicked))
		};
	}

	// Token: 0x06013431 RID: 78897 RVA: 0x004CA5C0 File Offset: 0x004C87C0
	protected override UniTask OnBeforeStartAsync()
	{
		CaptureCollectView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CaptureCollectView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013432 RID: 78898 RVA: 0x004CA603 File Offset: 0x004C8803
	protected override void OnStart()
	{
		this.SetLodBias(-7);
		if (Info.Instance.IsXSXPlatform())
		{
			this.ShouldSavePhoto = false;
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}
	}

	// Token: 0x06013433 RID: 78899 RVA: 0x004CA632 File Offset: 0x004C8832
	protected override void OnBeforeDestroy()
	{
		this.RemoveChangeFovTimer();
		this.RemoveDelayTimer();
		PhotographQuickController.Instance.Reset();
		LoadingModel.Instance.IsShowUidView = true;
		UKuroSequencePerformanceManager.CloseKuroPerformanceMode();
	}

	// Token: 0x06013434 RID: 78900 RVA: 0x004CA65C File Offset: 0x004C885C
	protected override void OnAfterDestroy()
	{
		this.SetLodBias(0);
		BP_PhotoCutFilterPostProcess_C bpFilterFx = this.BpFilterFx;
		if (bpFilterFx != null && bpFilterFx.IsValid())
		{
			CaptureCollectView.WeakRefLastBpFilterFx = new WeakReference<BP_PhotoCutFilterPostProcess_C>(this.BpFilterFx);
		}
		if (this.QtaViewHandler != null)
		{
			this.QtaViewHandler.Finish();
			this.QtaViewHandler = null;
		}
	}

	// Token: 0x06013435 RID: 78901 RVA: 0x004CA6B0 File Offset: 0x004C88B0
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		CaptureCollectView.<OnPlayingStartSequenceAsync>d__28 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<CaptureCollectView.<OnPlayingStartSequenceAsync>d__28>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013436 RID: 78902 RVA: 0x004CA6F4 File Offset: 0x004C88F4
	protected override UniTask OnPlayingHideSequenceAsync()
	{
		CaptureCollectView.<OnPlayingHideSequenceAsync>d__29 <OnPlayingHideSequenceAsync>d__;
		<OnPlayingHideSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingHideSequenceAsync>d__.<>4__this = this;
		<OnPlayingHideSequenceAsync>d__.<>1__state = -1;
		<OnPlayingHideSequenceAsync>d__.<>t__builder.Start<CaptureCollectView.<OnPlayingHideSequenceAsync>d__29>(ref <OnPlayingHideSequenceAsync>d__);
		return <OnPlayingHideSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013437 RID: 78903 RVA: 0x004CA738 File Offset: 0x004C8938
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		CaptureCollectView.<OnPlayingCloseSequenceAsync>d__30 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<CaptureCollectView.<OnPlayingCloseSequenceAsync>d__30>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013438 RID: 78904 RVA: 0x004CA77C File Offset: 0x004C897C
	private void SetLodBias(int lodBias)
	{
		SceneTeamModel instance = SceneTeamModel.Instance;
		WorldEntity worldEntity;
		if (instance == null)
		{
			worldEntity = null;
		}
		else
		{
			EntityHandle getCurrentEntity = instance.GetCurrentEntity;
			worldEntity = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
		}
		WorldEntity worldEntity2 = worldEntity;
		if (worldEntity2 != null && worldEntity2.Valid)
		{
			UeSkeletalTickManageComponent component = worldEntity2.GetComponent<UeSkeletalTickManageComponent>();
			if (component == null)
			{
				return;
			}
			component.SetLodBias(lodBias);
		}
	}

	// Token: 0x06013439 RID: 78905 RVA: 0x004CA7C4 File Offset: 0x004C89C4
	protected override void OnAddEventListener()
	{
		UUIButtonComponent button = base.GetButton(4);
		UUIButtonComponent button2 = base.GetButton(6);
		UUISliderComponent slider = base.GetSlider(5);
		UUIDraggableComponent draggable = base.GetDraggable(7);
		button.OnPointDownCallBack.Bind(new Action(this.OnPressAddButton));
		button.OnPointUpCallBack.Bind(new Action(this.OnReleaseAddButton));
		button.OnPointCancelCallBack.Bind(new Action(this.OnReleaseAddButton));
		button2.OnPointDownCallBack.Bind(new Action(this.OnPressReduceButton));
		button2.OnPointUpCallBack.Bind(new Action(this.OnReleaseReduceButton));
		button2.OnPointCancelCallBack.Bind(new Action(this.OnReleaseReduceButton));
		slider.OnValueChangeCb.Bind(new Action<float>(this.OnSetFov));
		if (Info.Instance.IsMobileInputModel())
		{
			draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragMoved));
			draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
			draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnded));
		}
		draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
		draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnded));
		if (Info.Instance.IsPcInputModel())
		{
			InputDistributeController.Instance.BindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
		}
		InputDistributeController.Instance.BindAxis("UiIncrease", new TInputHandle<float>(this.OnInputUiIncrease));
		InputDistributeController.Instance.BindAxis("UiReduce", new TInputHandle<float>(this.OnInputUiReduce));
		EventSystem.Instance.Add(EEventName.OnPhotographSetVisible, new Action(this.OnPhotographSetVisible));
		EventSystem.Instance.Add(EEventName.OnScreenShotDone, new Action(this.OnScreenShotDone));
	}

	// Token: 0x0601343A RID: 78906 RVA: 0x004CA9A4 File Offset: 0x004C8BA4
	protected override void OnRemoveEventListener()
	{
		UUIButtonComponent button = base.GetButton(4);
		UUIButtonComponent button2 = base.GetButton(6);
		UUISliderComponent slider = base.GetSlider(5);
		UUIDraggableComponent draggable = base.GetDraggable(7);
		button.OnPointDownCallBack.Unbind();
		button.OnPointUpCallBack.Unbind();
		button.OnPointCancelCallBack.Unbind();
		button2.OnPointDownCallBack.Unbind();
		button2.OnPointUpCallBack.Unbind();
		button2.OnPointCancelCallBack.Unbind();
		slider.OnValueChangeCb.Unbind();
		if (Info.Instance.IsMobileInputModel())
		{
			draggable.OnPointerDragCallBack.Unbind();
			draggable.OnPointerBeginDragCallBack.Unbind();
			draggable.OnPointerEndDragCallBack.Unbind();
		}
		draggable.OnPointerDownCallBack.Unbind();
		draggable.OnPointerUpCallBack.Unbind();
		if (Info.Instance.IsPcInputModel())
		{
			InputDistributeController.Instance.UnBindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
		}
		InputDistributeController.Instance.UnBindAxis("UiIncrease", new TInputHandle<float>(this.OnInputUiIncrease));
		InputDistributeController.Instance.UnBindAxis("UiReduce", new TInputHandle<float>(this.OnInputUiReduce));
		EventSystem.Instance.Remove(EEventName.OnPhotographSetVisible, new Action(this.OnPhotographSetVisible));
		EventSystem.Instance.Remove(EEventName.OnScreenShotDone, new Action(this.OnScreenShotDone));
	}

	// Token: 0x0601343B RID: 78907 RVA: 0x004CAAF4 File Offset: 0x004C8CF4
	[NullableContext(1)]
	private void OnInputWheelAxis(string name, float value, InputIdentification inputIdentification)
	{
		if (value != 0f)
		{
			UUISliderComponent slider = base.GetSlider(5);
			slider.SetValue(slider.Value + value * this.CameraZoomSpeed, true);
		}
	}

	// Token: 0x0601343C RID: 78908 RVA: 0x004CAB1A File Offset: 0x004C8D1A
	[NullableContext(1)]
	private void OnInputUiIncrease(string axisName, float value, InputIdentification _)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.ChangeFov(-value * this.CameraZoomSpeed);
	}

	// Token: 0x0601343D RID: 78909 RVA: 0x004CAB40 File Offset: 0x004C8D40
	[NullableContext(1)]
	private void OnInputUiReduce(string axisName, float value, InputIdentification _)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.ChangeFov(-value * this.CameraZoomSpeed);
	}

	// Token: 0x0601343E RID: 78910 RVA: 0x004CAB66 File Offset: 0x004C8D66
	protected override void OnBeforeCreate()
	{
		PhotographQuickController.Instance.InitHandlerForCaptureCollect();
	}

	// Token: 0x0601343F RID: 78911 RVA: 0x004CAB74 File Offset: 0x004C8D74
	protected override void OnBeforeShow()
	{
		base.GetItem(10).SetUIActive(this.IsFilterEnabled);
		base.GetItem(11).SetUIActive(!this.IsFilterEnabled);
		if (PhotographQuickController.Instance.Model.GetHandler() == null)
		{
			return;
		}
		this.SetUiProhibitRefresh(true);
		InputDistributeController.Instance.RefreshInputTag();
		if (Info.Instance.IsMobileInputModel())
		{
			InputDistributeController.Instance.BindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}
		EyeProtectController.Instance.SwitchFilter(false);
		this.RefreshFov();
		this.EnableTipsItem(true);
	}

	// Token: 0x06013440 RID: 78912 RVA: 0x004CAC14 File Offset: 0x004C8E14
	protected override void OnAfterHide()
	{
		this.SetUiProhibitRefresh(false);
		InputDistributeController.Instance.RefreshInputTag();
		if (Info.Instance.IsMobileInputModel())
		{
			InputDistributeController.Instance.UnBindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}
		MenuController.Instance.OpenAllFilter();
		PhotographQuickController.Instance.Reset();
		this.EnableTipsItem(false);
		if (this.IsFilterEnabled)
		{
			this.EnableFilterFx(false);
		}
	}

	// Token: 0x06013441 RID: 78913 RVA: 0x004CAC88 File Offset: 0x004C8E88
	private void SetUiProhibitRefresh(bool reg)
	{
		if (reg)
		{
			UiProhibitFightInputCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
			return;
		}
		UiProhibitFightInputCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
	}

	// Token: 0x06013442 RID: 78914 RVA: 0x004CACC3 File Offset: 0x004C8EC3
	public bool CheckCondition()
	{
		return true;
	}

	// Token: 0x06013443 RID: 78915 RVA: 0x004CACC6 File Offset: 0x004C8EC6
	[NullableContext(1)]
	public string[] GetDistributeTags()
	{
		return new string[]
		{
			"FightInputRoot.FightInput.AxisInput",
			"FightInputRoot.FightInput.ActionInput.CharacterSkillInput",
			"FightInputRoot.FightInput.ActionInput",
			"UiInputRoot.ShortcutKeyTag",
			"UiInputRoot.MouseInputTag",
			"UiInputRoot.Navigation",
			"InteractionRoot"
		};
	}

	// Token: 0x06013444 RID: 78916 RVA: 0x004CAD06 File Offset: 0x004C8F06
	[NullableContext(1)]
	private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
	{
		if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchMove)
		{
			this.TouchMoved(int.Parse(touchIdName));
		}
	}

	// Token: 0x06013445 RID: 78917 RVA: 0x004CAD20 File Offset: 0x004C8F20
	private void TouchMoved(int touchId)
	{
		if (PhotographQuickController.Instance.Model.GetHandler() == null)
		{
			return;
		}
		if (TouchFingerManager.Instance.GetTouchFingerCount() <= 1)
		{
			return;
		}
		TouchFingerData touchFingerData = TouchFingerManager.Instance.GetTouchFingerData(EFingerIndex.One);
		if (touchFingerData != null && !touchFingerData.IsTouchEmpty() && !touchFingerData.IsTouchComponentContainTag(PhotographDefine.ignoreTouchTag))
		{
			return;
		}
		touchFingerData = TouchFingerManager.Instance.GetTouchFingerData(EFingerIndex.Two);
		if (touchFingerData != null && !touchFingerData.IsTouchEmpty() && !touchFingerData.IsTouchComponentContainTag(PhotographDefine.ignoreTouchTag))
		{
			return;
		}
		float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
		float changeValue = MathUtils.Instance.RangeClamp(fingerExpandCloseValue, -50000f, 50000f, -1f, 1f);
		this.ChangeFov(changeValue);
	}

	// Token: 0x06013446 RID: 78918 RVA: 0x004CADCB File Offset: 0x004C8FCB
	private void SetVisibleMode(bool bVisible)
	{
		if (this.VisibleMode == bVisible)
		{
			return;
		}
		this.VisibleMode = bVisible;
		LoadingModel.Instance.IsShowUidView = this.VisibleMode;
	}

	// Token: 0x06013447 RID: 78919 RVA: 0x004CADEE File Offset: 0x004C8FEE
	private void OnPhotographSetVisible()
	{
		this.SetVisibleMode(true);
	}

	// Token: 0x06013448 RID: 78920 RVA: 0x004CADF8 File Offset: 0x004C8FF8
	private void OnSetFov(float value)
	{
		float fov = MathUtils.Instance.RangeClamp(value, this.MinFov, this.MaxFov, this.MaxFov, this.MinFov);
		PhotographQuickController.Instance.SetFov(fov);
	}

	// Token: 0x06013449 RID: 78921 RVA: 0x004CAE34 File Offset: 0x004C9034
	private void OnDragMoved(ULGUIPointerEventData eventData)
	{
		if (eventData == null)
		{
			return;
		}
		this.InDragMove = true;
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			return;
		}
		FVector pointerPosition = eventData.pointerPosition;
		if (this.LastMoveVector != null)
		{
			PhotoCameraHandler handler = PhotographQuickController.Instance.Model.GetHandler();
			if (handler == null)
			{
				return;
			}
			float num = (pointerPosition.Y - this.LastMoveVector.Value.Y) * this.ControlCameraRate;
			float num2 = (this.LastMoveVector.Value.X - pointerPosition.X) * this.ControlCameraRate;
			handler.AddPitchInput(-num);
			handler.AddYawInput(-num2);
		}
		this.LastMoveVector = new FVector?(pointerPosition);
	}

	// Token: 0x0601344A RID: 78922 RVA: 0x004CAEDC File Offset: 0x004C90DC
	private void OnDragBegin(ULGUIPointerEventData _)
	{
		this.InDragMove = false;
		PhotoCameraHandler handler = PhotographQuickController.Instance.Model.GetHandler();
		if (handler == null)
		{
			return;
		}
		handler.ClearInput();
	}

	// Token: 0x0601344B RID: 78923 RVA: 0x004CAEFE File Offset: 0x004C90FE
	private void OnDragEnded(ULGUIPointerEventData _)
	{
		this.LastMoveVector = null;
		if (!this.InDragMove)
		{
			this.SetVisibleMode(true);
		}
		PhotoCameraHandler handler = PhotographQuickController.Instance.Model.GetHandler();
		if (handler == null)
		{
			return;
		}
		handler.ClearInput();
	}

	// Token: 0x0601344C RID: 78924 RVA: 0x004CAF34 File Offset: 0x004C9134
	private void OnPressAddButton()
	{
		this.RemoveChangeFovTimer();
		this.ChangeFovTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnAddFov), 100f, 1f, null, null, true);
	}

	// Token: 0x0601344D RID: 78925 RVA: 0x004CAF65 File Offset: 0x004C9165
	private void OnReleaseAddButton()
	{
		this.RemoveChangeFovTimer();
	}

	// Token: 0x0601344E RID: 78926 RVA: 0x004CAF6D File Offset: 0x004C916D
	private void OnPressReduceButton()
	{
		this.RemoveChangeFovTimer();
		this.ChangeFovTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnReduceFov), 100f, 1f, null, null, true);
	}

	// Token: 0x0601344F RID: 78927 RVA: 0x004CAF9E File Offset: 0x004C919E
	private void OnReleaseReduceButton()
	{
		this.RemoveChangeFovTimer();
	}

	// Token: 0x06013450 RID: 78928 RVA: 0x004CAFA6 File Offset: 0x004C91A6
	private void RemoveChangeFovTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.ChangeFovTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.ChangeFovTimerId);
			this.ChangeFovTimerId = null;
		}
	}

	// Token: 0x06013451 RID: 78929 RVA: 0x004CAFD2 File Offset: 0x004C91D2
	private void OnAddFov(float _)
	{
		this.ChangeFov(1f);
	}

	// Token: 0x06013452 RID: 78930 RVA: 0x004CAFDF File Offset: 0x004C91DF
	private void OnReduceFov(float _)
	{
		this.ChangeFov(-1f);
	}

	// Token: 0x06013453 RID: 78931 RVA: 0x004CAFEC File Offset: 0x004C91EC
	private void OnAddButtonButtonClicked()
	{
		this.ChangeFov(1f);
	}

	// Token: 0x06013454 RID: 78932 RVA: 0x004CAFF9 File Offset: 0x004C91F9
	private void OnReduceButtonClicked()
	{
		this.ChangeFov(-1f);
	}

	// Token: 0x06013455 RID: 78933 RVA: 0x004CB008 File Offset: 0x004C9208
	private void RefreshFov()
	{
		UUISliderComponent slider = base.GetSlider(5);
		slider.SetMinValue(this.MinFov, false, false);
		slider.SetMaxValue(this.MaxFov, false, false);
		PhotoCameraHandler handler = PhotographQuickController.Instance.Model.GetHandler();
		if (handler == null)
		{
			return;
		}
		float cameraInitializeFov = handler.GetCameraInitializeFov();
		float inValue = MathUtils.Instance.RangeClamp(cameraInitializeFov, this.MinFov, this.MaxFov, this.MaxFov, this.MinFov);
		slider.SetValue(inValue, true);
		handler.SetFov(cameraInitializeFov);
	}

	// Token: 0x06013456 RID: 78934 RVA: 0x004CB088 File Offset: 0x004C9288
	private void ChangeFov(float changeValue)
	{
		UUISliderComponent slider = base.GetSlider(5);
		float inValue = slider.GetValue() + changeValue;
		slider.SetValue(inValue, true);
	}

	// Token: 0x06013457 RID: 78935 RVA: 0x004CB0AC File Offset: 0x004C92AC
	private void OnCloseButtonClick()
	{
		if (this.PhotographStart)
		{
			return;
		}
		QtaViewHandler qtaViewHandler = this.QtaViewHandler;
		if (qtaViewHandler != null)
		{
			qtaViewHandler.SetResult(EQtaResult.Fail);
		}
		if (this.IsFilterEnabled && this.BpFilterFx != null && this.BpFilterFx.IsValid())
		{
			this.BpFilterFx.K2_DestroyActor();
			this.BpFilterFx = null;
		}
		base.CloseMe(null);
	}

	// Token: 0x06013458 RID: 78936 RVA: 0x004CB10A File Offset: 0x004C930A
	private void UpdateSaveToggle(bool state)
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ShouldSaveCaptureCollectFlag, state);
		this.ShouldSavePhoto = state;
	}

	// Token: 0x06013459 RID: 78937 RVA: 0x004CB120 File Offset: 0x004C9320
	private void OnPhotographButtonClicked()
	{
		if (this.PhotographStart || !base.IsShowOrShowing)
		{
			return;
		}
		this.PhotographStart = true;
		QtaViewHandler qtaViewHandler = this.QtaViewHandler;
		if (qtaViewHandler != null)
		{
			qtaViewHandler.SetResult(EQtaResult.Success);
		}
		if (this.ShouldSavePhoto && !Info.Instance.IsXSXPlatform())
		{
			base.SetUiActive(false);
			PhotographController.Instance.ScreenShot(new PhotoSaveViewParam
			{
				ScreenShot = true,
				PrepareFullScreenShot = true,
				IsHiddenBattleView = false,
				ShareId = 1
			});
			return;
		}
		this.QuickShotDone();
	}

	// Token: 0x0601345A RID: 78938 RVA: 0x004CB1A8 File Offset: 0x004C93A8
	private UniTask QuickShotDone()
	{
		CaptureCollectView.<QuickShotDone>d__65 <QuickShotDone>d__;
		<QuickShotDone>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<QuickShotDone>d__.<>4__this = this;
		<QuickShotDone>d__.<>1__state = -1;
		<QuickShotDone>d__.<>t__builder.Start<CaptureCollectView.<QuickShotDone>d__65>(ref <QuickShotDone>d__);
		return <QuickShotDone>d__.<>t__builder.Task;
	}

	// Token: 0x0601345B RID: 78939 RVA: 0x004CB1EB File Offset: 0x004C93EB
	private void OnScreenShotDone()
	{
		this.DelayTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.DelayTimer = null;
			this.EndView();
		}, 50f, null, null, true, 1f);
	}

	// Token: 0x0601345C RID: 78940 RVA: 0x004CB216 File Offset: 0x004C9416
	private void EndView()
	{
		SceneItemCaptureController.Instance.CollectItemsInViewport();
		LevelEventCaptureRequest.CollectInViewport();
		if (this.IsFilterEnabled)
		{
			this.EnableFilterFx(false);
			this.SetupRangeFilterFx();
		}
		base.CloseMe(null);
	}

	// Token: 0x0601345D RID: 78941 RVA: 0x004CB243 File Offset: 0x004C9443
	private void RemoveDelayTimer()
	{
		if (this.DelayTimer == null)
		{
			return;
		}
		TimerSystem.Instance.Remove(this.DelayTimer);
		this.DelayTimer = null;
	}

	// Token: 0x0601345E RID: 78942 RVA: 0x004CB266 File Offset: 0x004C9466
	public void SetQtaParam(QtaViewParam qtaParam)
	{
		this.QtaViewHandler = new QtaViewHandler(qtaParam);
	}

	// Token: 0x0601345F RID: 78943 RVA: 0x004CB274 File Offset: 0x004C9474
	private void EnableTipsItem(bool b)
	{
		BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.SpecialSkill, EBattleUiChild.InteractionHint, !b, true, 0);
		if (b)
		{
			EventSystem.Instance.Emit<bool, string>(EEventName.ShowItemTips, true, string.Empty);
			EventSystem.Instance.Emit(EEventName.HideInteractView);
			return;
		}
		EventSystem.Instance.Emit<bool, string>(EEventName.ShowItemTips, false, string.Empty);
		EventSystem.Instance.Emit(EEventName.InteractionViewUpdate);
	}

	// Token: 0x06013460 RID: 78944 RVA: 0x004CB2EC File Offset: 0x004C94EC
	private void OnFilterButtonClicked()
	{
		if (!base.IsShowOrShowing)
		{
			return;
		}
		if (Time.Instance.Now - this.LastTime < 500.0)
		{
			return;
		}
		this.LastTime = Time.Instance.Now;
		this.EnableFilterFx(!this.IsFilterEnabled);
		if (this.BpFilterFx == null)
		{
			ResourceSystem.Instance.LoadTypeAsync("BP_PhotoCutFilterPostProcess_C", new Action(this.InitFilterFx), "js_undefined");
		}
	}

	// Token: 0x06013461 RID: 78945 RVA: 0x004CB368 File Offset: 0x004C9568
	private void InitFilterFx()
	{
		this.BpFilterFx = ActorSystem.Instance.Get<BP_PhotoCutFilterPostProcess_C>(BP_PhotoCutFilterPostProcess_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
		if (this.BpFilterFx == null)
		{
			return;
		}
		this.CameraClipMaskIntOrg = (int)this.BpFilterFx.CameraClipMaskInt;
		this.BpFilterFx.SetUpPostProcess();
		if (this.IsFilterEnabled && !this.PhotographStart)
		{
			this.EnableFilterFx(this.IsFilterEnabled);
		}
	}

	// Token: 0x06013462 RID: 78946 RVA: 0x004CB3D8 File Offset: 0x004C95D8
	private void EnableFilterFx(bool b)
	{
		this.IsFilterEnabled = b;
		if (this.BpFilterFx == null)
		{
			return;
		}
		base.GetItem(10).SetUIActive(this.IsFilterEnabled);
		base.GetItem(11).SetUIActive(!this.IsFilterEnabled);
		UMaterialInstanceDynamic postProcessMI = this.BpFilterFx.PostProcessMI;
		if (postProcessMI != null)
		{
			postProcessMI.SetScalarParameterValue(this.MatParam1, (float)(b ? this.CameraClipMaskIntOrg : 0));
		}
		this.BpFilterFx.IsTickEnd = false;
		this.BpFilterFx.UseScreenUV = b;
		this.BpFilterFx.SwitchScreenUV();
	}

	// Token: 0x06013463 RID: 78947 RVA: 0x004CB46C File Offset: 0x004C966C
	private void SetupRangeFilterFx()
	{
		if (this.BpFilterFx == null)
		{
			return;
		}
		APlayerCameraManager characterCameraManager = Global.CharacterCameraManager;
		AActor target = characterCameraManager.ViewTarget.Target;
		UCameraComponent ucameraComponent = ((target != null) ? target.GetComponentByClass(UCameraComponent.StaticClass()) : null) as UCameraComponent;
		if (ucameraComponent == null)
		{
			return;
		}
		this.BpFilterFx.UseScreenUV = false;
		this.BpFilterFx.SwitchScreenUV();
		this.BpFilterFx.UpdateFxParams(characterCameraManager.D_GetCameraLocation(), characterCameraManager.GetCameraRotation(), ucameraComponent.AspectRatio, ucameraComponent.FieldOfView);
		this.BpFilterFx.SetUpPostProcess();
		this.BpFilterFx.DelayToFadeOut();
	}

	// Token: 0x0400915C RID: 37212
	private const int CHANGE_FOV_INTERVAL = 100;

	// Token: 0x0400915D RID: 37213
	private TimerHandle ChangeFovTimerId;

	// Token: 0x0400915E RID: 37214
	private FVector? LastMoveVector;

	// Token: 0x0400915F RID: 37215
	private float ControlCameraRate;

	// Token: 0x04009160 RID: 37216
	private bool InDragMove;

	// Token: 0x04009161 RID: 37217
	private bool VisibleMode = true;

	// Token: 0x04009162 RID: 37218
	private float MinFov = 30f;

	// Token: 0x04009163 RID: 37219
	private float MaxFov = 90f;

	// Token: 0x04009164 RID: 37220
	private float CameraZoomSpeed = 1f;

	// Token: 0x04009165 RID: 37221
	private PopupCaptionItem CaptionItem;

	// Token: 0x04009166 RID: 37222
	[Nullable(1)]
	private readonly PopupCaptionToggleItem ToggleTabItem = new PopupCaptionToggleItem();

	// Token: 0x04009167 RID: 37223
	private bool PhotographStart;

	// Token: 0x04009168 RID: 37224
	private BP_PhotoCutFilterPostProcess_C BpFilterFx;

	// Token: 0x04009169 RID: 37225
	[Nullable(new byte[]
	{
		2,
		1
	})]
	[StaticVariableRuleIgnore]
	private static WeakReference<BP_PhotoCutFilterPostProcess_C> WeakRefLastBpFilterFx;

	// Token: 0x0400916A RID: 37226
	private bool ShouldSavePhoto;

	// Token: 0x0400916B RID: 37227
	private QtaViewHandler QtaViewHandler;

	// Token: 0x0400916C RID: 37228
	[Nullable(1)]
	protected BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

	// Token: 0x0400916D RID: 37229
	private bool IsFilterEnabled;

	// Token: 0x0400916E RID: 37230
	private double LastTime;

	// Token: 0x0400916F RID: 37231
	private readonly FName MatParam1 = new FName("CameraClipMaskInt");

	// Token: 0x04009170 RID: 37232
	private int CameraClipMaskIntOrg = -1;

	// Token: 0x04009171 RID: 37233
	private TimerHandle DelayTimer;

	// Token: 0x02008B17 RID: 35607
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402D28A RID: 184970
		public const int CaptionItem = 0;

		// Token: 0x0402D28B RID: 184971
		public const int ToggleSaveItem = 1;

		// Token: 0x0402D28C RID: 184972
		public const int PhotographButton = 2;

		// Token: 0x0402D28D RID: 184973
		public const int FilterButton = 3;

		// Token: 0x0402D28E RID: 184974
		public const int AddButton = 4;

		// Token: 0x0402D28F RID: 184975
		public const int CameraFovSlider = 5;

		// Token: 0x0402D290 RID: 184976
		public const int ReduceButton = 6;

		// Token: 0x0402D291 RID: 184977
		public const int ControlScreenDraggable = 7;

		// Token: 0x0402D292 RID: 184978
		public const int AniIn = 8;

		// Token: 0x0402D293 RID: 184979
		public const int AniOut = 9;

		// Token: 0x0402D294 RID: 184980
		public const int FilterIcon1 = 10;

		// Token: 0x0402D295 RID: 184981
		public const int FilterIcon2 = 11;

		// Token: 0x0402D296 RID: 184982
		public const int AniPhotoTake = 12;
	}
}
