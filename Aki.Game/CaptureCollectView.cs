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

// Token: 0x02001A41 RID: 6721
[NullableContext(2)]
[Nullable(0)]
public class CaptureCollectView : UiViewBase, IQtaView, IUiProhibitRefreshData
{
	// Token: 0x0601090F RID: 67855 RVA: 0x004D8F2C File Offset: 0x004D712C
	[NullableContext(1)]
	public CaptureCollectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010910 RID: 67856 RVA: 0x004D8F98 File Offset: 0x004D7198
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

	// Token: 0x06010911 RID: 67857 RVA: 0x004D9140 File Offset: 0x004D7340
	protected override UniTask OnBeforeStartAsync()
	{
		CaptureCollectView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CaptureCollectView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010912 RID: 67858 RVA: 0x004D9183 File Offset: 0x004D7383
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

	// Token: 0x06010913 RID: 67859 RVA: 0x004D91B2 File Offset: 0x004D73B2
	protected override void OnBeforeDestroy()
	{
		this.RemoveChangeFovTimer();
		this.RemoveDelayTimer();
		PhotographQuickController.Instance.Reset();
		LoadingModel.Instance.IsShowUidView = true;
		UKuroSequencePerformanceManager.CloseKuroPerformanceMode();
	}

	// Token: 0x06010914 RID: 67860 RVA: 0x004D91DC File Offset: 0x004D73DC
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

	// Token: 0x06010915 RID: 67861 RVA: 0x004D9230 File Offset: 0x004D7430
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		CaptureCollectView.<OnPlayingStartSequenceAsync>d__28 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<CaptureCollectView.<OnPlayingStartSequenceAsync>d__28>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010916 RID: 67862 RVA: 0x004D9274 File Offset: 0x004D7474
	protected override UniTask OnPlayingHideSequenceAsync()
	{
		CaptureCollectView.<OnPlayingHideSequenceAsync>d__29 <OnPlayingHideSequenceAsync>d__;
		<OnPlayingHideSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingHideSequenceAsync>d__.<>4__this = this;
		<OnPlayingHideSequenceAsync>d__.<>1__state = -1;
		<OnPlayingHideSequenceAsync>d__.<>t__builder.Start<CaptureCollectView.<OnPlayingHideSequenceAsync>d__29>(ref <OnPlayingHideSequenceAsync>d__);
		return <OnPlayingHideSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010917 RID: 67863 RVA: 0x004D92B8 File Offset: 0x004D74B8
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		CaptureCollectView.<OnPlayingCloseSequenceAsync>d__30 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<CaptureCollectView.<OnPlayingCloseSequenceAsync>d__30>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010918 RID: 67864 RVA: 0x004D92FC File Offset: 0x004D74FC
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

	// Token: 0x06010919 RID: 67865 RVA: 0x004D9344 File Offset: 0x004D7544
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

	// Token: 0x0601091A RID: 67866 RVA: 0x004D9524 File Offset: 0x004D7724
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

	// Token: 0x0601091B RID: 67867 RVA: 0x004D9674 File Offset: 0x004D7874
	[NullableContext(1)]
	private void OnInputWheelAxis(string name, float value, InputIdentification inputIdentification)
	{
		if (value != 0f)
		{
			UUISliderComponent slider = base.GetSlider(5);
			slider.SetValue(slider.Value + value * this.CameraZoomSpeed, true);
		}
	}

	// Token: 0x0601091C RID: 67868 RVA: 0x004D969A File Offset: 0x004D789A
	[NullableContext(1)]
	private void OnInputUiIncrease(string axisName, float value, InputIdentification _)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.ChangeFov(-value * this.CameraZoomSpeed);
	}

	// Token: 0x0601091D RID: 67869 RVA: 0x004D96C0 File Offset: 0x004D78C0
	[NullableContext(1)]
	private void OnInputUiReduce(string axisName, float value, InputIdentification _)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.ChangeFov(-value * this.CameraZoomSpeed);
	}

	// Token: 0x0601091E RID: 67870 RVA: 0x004D96E6 File Offset: 0x004D78E6
	protected override void OnBeforeCreate()
	{
		PhotographQuickController.Instance.InitHandlerForCaptureCollect();
	}

	// Token: 0x0601091F RID: 67871 RVA: 0x004D96F4 File Offset: 0x004D78F4
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

	// Token: 0x06010920 RID: 67872 RVA: 0x004D9794 File Offset: 0x004D7994
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

	// Token: 0x06010921 RID: 67873 RVA: 0x004D9808 File Offset: 0x004D7A08
	private void SetUiProhibitRefresh(bool reg)
	{
		if (reg)
		{
			UiProhibitFightInputCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
			return;
		}
		UiProhibitFightInputCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
	}

	// Token: 0x06010922 RID: 67874 RVA: 0x004D9843 File Offset: 0x004D7A43
	public bool CheckCondition()
	{
		return true;
	}

	// Token: 0x06010923 RID: 67875 RVA: 0x004D9846 File Offset: 0x004D7A46
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

	// Token: 0x06010924 RID: 67876 RVA: 0x004D9886 File Offset: 0x004D7A86
	[NullableContext(1)]
	private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
	{
		if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchMove)
		{
			this.TouchMoved(int.Parse(touchIdName));
		}
	}

	// Token: 0x06010925 RID: 67877 RVA: 0x004D98A0 File Offset: 0x004D7AA0
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

	// Token: 0x06010926 RID: 67878 RVA: 0x004D994B File Offset: 0x004D7B4B
	private void SetVisibleMode(bool bVisible)
	{
		if (this.VisibleMode == bVisible)
		{
			return;
		}
		this.VisibleMode = bVisible;
		LoadingModel.Instance.IsShowUidView = this.VisibleMode;
	}

	// Token: 0x06010927 RID: 67879 RVA: 0x004D996E File Offset: 0x004D7B6E
	private void OnPhotographSetVisible()
	{
		this.SetVisibleMode(true);
	}

	// Token: 0x06010928 RID: 67880 RVA: 0x004D9978 File Offset: 0x004D7B78
	private void OnSetFov(float value)
	{
		float fov = MathUtils.Instance.RangeClamp(value, this.MinFov, this.MaxFov, this.MaxFov, this.MinFov);
		PhotographQuickController.Instance.SetFov(fov);
	}

	// Token: 0x06010929 RID: 67881 RVA: 0x004D99B4 File Offset: 0x004D7BB4
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

	// Token: 0x0601092A RID: 67882 RVA: 0x004D9A5C File Offset: 0x004D7C5C
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

	// Token: 0x0601092B RID: 67883 RVA: 0x004D9A7E File Offset: 0x004D7C7E
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

	// Token: 0x0601092C RID: 67884 RVA: 0x004D9AB4 File Offset: 0x004D7CB4
	private void OnPressAddButton()
	{
		this.RemoveChangeFovTimer();
		this.ChangeFovTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnAddFov), 100f, 1f, null, null, true);
	}

	// Token: 0x0601092D RID: 67885 RVA: 0x004D9AE5 File Offset: 0x004D7CE5
	private void OnReleaseAddButton()
	{
		this.RemoveChangeFovTimer();
	}

	// Token: 0x0601092E RID: 67886 RVA: 0x004D9AED File Offset: 0x004D7CED
	private void OnPressReduceButton()
	{
		this.RemoveChangeFovTimer();
		this.ChangeFovTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnReduceFov), 100f, 1f, null, null, true);
	}

	// Token: 0x0601092F RID: 67887 RVA: 0x004D9B1E File Offset: 0x004D7D1E
	private void OnReleaseReduceButton()
	{
		this.RemoveChangeFovTimer();
	}

	// Token: 0x06010930 RID: 67888 RVA: 0x004D9B26 File Offset: 0x004D7D26
	private void RemoveChangeFovTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.ChangeFovTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.ChangeFovTimerId);
			this.ChangeFovTimerId = null;
		}
	}

	// Token: 0x06010931 RID: 67889 RVA: 0x004D9B52 File Offset: 0x004D7D52
	private void OnAddFov(float _)
	{
		this.ChangeFov(1f);
	}

	// Token: 0x06010932 RID: 67890 RVA: 0x004D9B5F File Offset: 0x004D7D5F
	private void OnReduceFov(float _)
	{
		this.ChangeFov(-1f);
	}

	// Token: 0x06010933 RID: 67891 RVA: 0x004D9B6C File Offset: 0x004D7D6C
	private void OnAddButtonButtonClicked()
	{
		this.ChangeFov(1f);
	}

	// Token: 0x06010934 RID: 67892 RVA: 0x004D9B79 File Offset: 0x004D7D79
	private void OnReduceButtonClicked()
	{
		this.ChangeFov(-1f);
	}

	// Token: 0x06010935 RID: 67893 RVA: 0x004D9B88 File Offset: 0x004D7D88
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

	// Token: 0x06010936 RID: 67894 RVA: 0x004D9C08 File Offset: 0x004D7E08
	private void ChangeFov(float changeValue)
	{
		UUISliderComponent slider = base.GetSlider(5);
		float inValue = slider.GetValue() + changeValue;
		slider.SetValue(inValue, true);
	}

	// Token: 0x06010937 RID: 67895 RVA: 0x004D9C2C File Offset: 0x004D7E2C
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

	// Token: 0x06010938 RID: 67896 RVA: 0x004D9C8A File Offset: 0x004D7E8A
	private void UpdateSaveToggle(bool state)
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ShouldSaveCaptureCollectFlag, state);
		this.ShouldSavePhoto = state;
	}

	// Token: 0x06010939 RID: 67897 RVA: 0x004D9CA0 File Offset: 0x004D7EA0
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

	// Token: 0x0601093A RID: 67898 RVA: 0x004D9D28 File Offset: 0x004D7F28
	private UniTask QuickShotDone()
	{
		CaptureCollectView.<QuickShotDone>d__65 <QuickShotDone>d__;
		<QuickShotDone>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<QuickShotDone>d__.<>4__this = this;
		<QuickShotDone>d__.<>1__state = -1;
		<QuickShotDone>d__.<>t__builder.Start<CaptureCollectView.<QuickShotDone>d__65>(ref <QuickShotDone>d__);
		return <QuickShotDone>d__.<>t__builder.Task;
	}

	// Token: 0x0601093B RID: 67899 RVA: 0x004D9D6B File Offset: 0x004D7F6B
	private void OnScreenShotDone()
	{
		this.DelayTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.DelayTimer = null;
			this.EndView();
		}, 50f, null, null, true, 1f);
	}

	// Token: 0x0601093C RID: 67900 RVA: 0x004D9D96 File Offset: 0x004D7F96
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

	// Token: 0x0601093D RID: 67901 RVA: 0x004D9DC3 File Offset: 0x004D7FC3
	private void RemoveDelayTimer()
	{
		if (this.DelayTimer == null)
		{
			return;
		}
		TimerSystem.Instance.Remove(this.DelayTimer);
		this.DelayTimer = null;
	}

	// Token: 0x0601093E RID: 67902 RVA: 0x004D9DE6 File Offset: 0x004D7FE6
	public void SetQtaParam(QtaViewParam qtaParam)
	{
		this.QtaViewHandler = new QtaViewHandler(qtaParam);
	}

	// Token: 0x0601093F RID: 67903 RVA: 0x004D9DF4 File Offset: 0x004D7FF4
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

	// Token: 0x06010940 RID: 67904 RVA: 0x004D9E6C File Offset: 0x004D806C
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

	// Token: 0x06010941 RID: 67905 RVA: 0x004D9EE8 File Offset: 0x004D80E8
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

	// Token: 0x06010942 RID: 67906 RVA: 0x004D9F58 File Offset: 0x004D8158
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

	// Token: 0x06010943 RID: 67907 RVA: 0x004D9FEC File Offset: 0x004D81EC
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

	// Token: 0x040092B5 RID: 37557
	private const int CHANGE_FOV_INTERVAL = 100;

	// Token: 0x040092B6 RID: 37558
	private TimerHandle ChangeFovTimerId;

	// Token: 0x040092B7 RID: 37559
	private FVector? LastMoveVector;

	// Token: 0x040092B8 RID: 37560
	private float ControlCameraRate;

	// Token: 0x040092B9 RID: 37561
	private bool InDragMove;

	// Token: 0x040092BA RID: 37562
	private bool VisibleMode = true;

	// Token: 0x040092BB RID: 37563
	private float MinFov = 30f;

	// Token: 0x040092BC RID: 37564
	private float MaxFov = 90f;

	// Token: 0x040092BD RID: 37565
	private float CameraZoomSpeed = 1f;

	// Token: 0x040092BE RID: 37566
	private PopupCaptionItem CaptionItem;

	// Token: 0x040092BF RID: 37567
	[Nullable(1)]
	private readonly PopupCaptionToggleItem ToggleTabItem = new PopupCaptionToggleItem();

	// Token: 0x040092C0 RID: 37568
	private bool PhotographStart;

	// Token: 0x040092C1 RID: 37569
	private BP_PhotoCutFilterPostProcess_C BpFilterFx;

	// Token: 0x040092C2 RID: 37570
	[Nullable(new byte[]
	{
		2,
		1
	})]
	[StaticVariableRuleIgnore]
	private static WeakReference<BP_PhotoCutFilterPostProcess_C> WeakRefLastBpFilterFx;

	// Token: 0x040092C3 RID: 37571
	private bool ShouldSavePhoto;

	// Token: 0x040092C4 RID: 37572
	private QtaViewHandler QtaViewHandler;

	// Token: 0x040092C5 RID: 37573
	[Nullable(1)]
	protected BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

	// Token: 0x040092C6 RID: 37574
	private bool IsFilterEnabled;

	// Token: 0x040092C7 RID: 37575
	private double LastTime;

	// Token: 0x040092C8 RID: 37576
	private readonly FName MatParam1 = new FName("CameraClipMaskInt");

	// Token: 0x040092C9 RID: 37577
	private int CameraClipMaskIntOrg = -1;

	// Token: 0x040092CA RID: 37578
	private TimerHandle DelayTimer;

	// Token: 0x02007C9D RID: 31901
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04028599 RID: 165273
		public const int CaptionItem = 0;

		// Token: 0x0402859A RID: 165274
		public const int ToggleSaveItem = 1;

		// Token: 0x0402859B RID: 165275
		public const int PhotographButton = 2;

		// Token: 0x0402859C RID: 165276
		public const int FilterButton = 3;

		// Token: 0x0402859D RID: 165277
		public const int AddButton = 4;

		// Token: 0x0402859E RID: 165278
		public const int CameraFovSlider = 5;

		// Token: 0x0402859F RID: 165279
		public const int ReduceButton = 6;

		// Token: 0x040285A0 RID: 165280
		public const int ControlScreenDraggable = 7;

		// Token: 0x040285A1 RID: 165281
		public const int AniIn = 8;

		// Token: 0x040285A2 RID: 165282
		public const int AniOut = 9;

		// Token: 0x040285A3 RID: 165283
		public const int FilterIcon1 = 10;

		// Token: 0x040285A4 RID: 165284
		public const int FilterIcon2 = 11;

		// Token: 0x040285A5 RID: 165285
		public const int AniPhotoTake = 12;
	}
}
