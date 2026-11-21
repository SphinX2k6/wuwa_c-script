using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200212F RID: 8495
[NullableContext(1)]
[Nullable(0)]
public class TimeOfDayView : UiTickViewBase
{
	// Token: 0x06014D31 RID: 85297 RVA: 0x0060CF0C File Offset: 0x0060B10C
	public TimeOfDayView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014D32 RID: 85298 RVA: 0x0060CF88 File Offset: 0x0060B188
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(15, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(16, typeof(UUITexture)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIText)),
			new ValueTuple<int, Type>(22, typeof(UUIInteractionGroup)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnConfirm)),
			new ValueTuple<int, Delegate>(15, new Action(this.OnClickBtnClose))
		};
	}

	// Token: 0x06014D33 RID: 85299 RVA: 0x0060D22C File Offset: 0x0060B42C
	protected override void OnStart()
	{
		this.DayStateUiItemMap[ETodDayState.One] = new TimeOfDayView.UiItemSwitcher(base.GetItem(6), base.GetItem(7));
		this.DayStateUiItemMap[ETodDayState.Two] = new TimeOfDayView.UiItemSwitcher(base.GetItem(8), base.GetItem(9));
		this.DayStateUiItemMap[ETodDayState.Three] = new TimeOfDayView.UiItemSwitcher(base.GetItem(10), base.GetItem(11));
		this.DayStateUiItemMap[ETodDayState.Four] = new TimeOfDayView.UiItemSwitcher(base.GetItem(12), base.GetItem(13));
		FVector2D uiitemPositionInViewPort = ULGUIBPLibrary.GetUIItemPositionInViewPort(GlobalData.World, base.GetItem(17), false);
		this.DragCenterPoint = global::Vector.Create((double)uiitemPositionInViewPort.X, (double)uiitemPositionInViewPort.Y, 0.0);
		this.TimeAdjustingClock = new TimeOfDayView.TodTimeAdjustingClock();
		this.TimeAdjustingAnimation = new TodTimeAdjustingAnimation(TimeOfDayConfig.Instance.GetMaxV(), TimeOfDayConfig.Instance.GetA(), new Action<double>(this.OnAnimation), new Action(this.OnAnimationFinished));
		this.ResetView();
		this.UpdateTime();
	}

	// Token: 0x06014D34 RID: 85300 RVA: 0x0060D33E File Offset: 0x0060B53E
	protected override void OnBeforeDestroy()
	{
		this.TimeAdjustingClock.Reset();
		this.TimeAdjustingAnimation.Stop();
		this.ClearStartAnimationTimer();
	}

	// Token: 0x06014D35 RID: 85301 RVA: 0x0060D35C File Offset: 0x0060B55C
	protected override void OnTick(float deltaTime)
	{
		TodTimeAdjustingAnimation timeAdjustingAnimation = this.TimeAdjustingAnimation;
		if (timeAdjustingAnimation == null)
		{
			return;
		}
		timeAdjustingAnimation.Tick((double)deltaTime);
	}

	// Token: 0x06014D36 RID: 85302 RVA: 0x0060D370 File Offset: 0x0060B570
	protected override void OnAddEventListener()
	{
		UUIDraggableComponent draggable = base.GetDraggable(14);
		draggable.OnPointerBeginDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
		{
			this.OnClockPointerPressed(eventData);
		});
		draggable.OnPointerDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
		{
			this.OnClockPointerDragCallBack(eventData);
		});
		draggable.OnPointerEndDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
		{
			this.OnClockPointerReleaseCallBack(eventData);
		});
		draggable.OnUIDimensionsChangedCallBack.Bind(new Action<bool, bool>(this.OnUiDimensionsChangedCallBack));
		EventSystem.Instance.Add(EEventName.TodTimeChange, new Action(this.UpdateTime));
	}

	// Token: 0x06014D37 RID: 85303 RVA: 0x0060D3FC File Offset: 0x0060B5FC
	protected override void OnRemoveEventListener()
	{
		UUIDraggableComponent draggable = base.GetDraggable(14);
		draggable.OnPointerBeginDragCallBack.Unbind();
		draggable.OnPointerDragCallBack.Unbind();
		draggable.OnPointerEndDragCallBack.Unbind();
		draggable.OnUIDimensionsChangedCallBack.Unbind();
		EventSystem.Instance.Remove(EEventName.TodTimeChange, new Action(this.UpdateTime));
	}

	// Token: 0x06014D38 RID: 85304 RVA: 0x0060D458 File Offset: 0x0060B658
	private void ClearStartAnimationTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.StartAnimationTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.StartAnimationTimerId);
		}
		this.StartAnimationTimerId = null;
	}

	// Token: 0x06014D39 RID: 85305 RVA: 0x0060D484 File Offset: 0x0060B684
	private void ResetView()
	{
		base.GetTexture(2).SetFillAmount(0f);
		base.GetTexture(3).SetFillAmount(0f);
		base.GetItem(18).SetUIActive(true);
		base.GetItem(19).SetUIActive(true);
		base.GetItem(23).SetUIActive(true);
		base.GetItem(24).SetUIActive(true);
		this.SetBtnConfirmState(false);
		base.GetText(5).ShowTextNew(this.TimeAdjustingClock.DayTextId);
	}

	// Token: 0x06014D3A RID: 85306 RVA: 0x0060D50C File Offset: 0x0060B70C
	private void UpdateTime()
	{
		if (this.TimeAdjustingClock.IsAdjusting)
		{
			return;
		}
		string hourMinuteString = TimeOfDayModel.Instance.GameTime.HourMinuteString;
		base.GetText(0).SetText(hourMinuteString, true);
		base.GetText(4).SetText(hourMinuteString, true);
		ETodDayState dayState = TimeOfDayModel.Instance.GameTime.DayState;
		foreach (KeyValuePair<ETodDayState, TimeOfDayView.UiItemSwitcher> keyValuePair in this.DayStateUiItemMap)
		{
			keyValuePair.Value.SwitchTo(keyValuePair.Key == dayState);
		}
		this.DragPointerRotator.Yaw = (float)this.GetPointerAngle(TimeOfDayModel.Instance.GameTime.Second);
		UUIItem texture = base.GetTexture(16);
		FRotator frotator = this.DragPointerRotator.ToUeRotator();
		texture.SetUIRelativeRotation(frotator);
		UUIItem item = base.GetItem(17);
		frotator = this.DragPointerRotator.ToUeRotator();
		item.SetUIRelativeRotation(frotator);
		UUIItem item2 = base.GetItem(25);
		frotator = this.DragPointerRotator.ToUeRotator();
		item2.SetUIRelativeRotation(frotator);
		UUIItem item3 = base.GetItem(18);
		frotator = this.TextureRotator.ToUeRotator();
		item3.SetUIRelativeRotation(frotator);
		UUIItem item4 = base.GetItem(19);
		frotator = this.TextureRotator.ToUeRotator();
		item4.SetUIRelativeRotation(frotator);
	}

	// Token: 0x06014D3B RID: 85307 RVA: 0x0060D668 File Offset: 0x0060B868
	private void OnClockPointerPressed(ULGUIPointerEventData eventData)
	{
		if (this.TimeAdjustingClock.IsAdjusting)
		{
			return;
		}
		this.TimeAdjustingClock.Start();
		global::Vector firstDragPoint = this.FirstDragPoint;
		FVector pointerPosition = eventData.pointerPosition;
		FVectorDouble fvectorDouble = pointerPosition;
		firstDragPoint.DeepCopy(fvectorDouble);
		global::Vector lastDragPoint = this.LastDragPoint;
		pointerPosition = eventData.pointerPosition;
		fvectorDouble = pointerPosition;
		lastDragPoint.DeepCopy(fvectorDouble);
		this.TextureRotator.Yaw = (float)this.GetPointerAngle(this.TimeAdjustingClock.StartSecond);
		UUIItem item = base.GetItem(19);
		FRotator frotator = this.TextureRotator.ToUeRotator();
		item.SetUIRelativeRotation(frotator);
		UUIItem item2 = base.GetItem(18);
		frotator = this.TextureRotator.ToUeRotator();
		item2.SetUIRelativeRotation(frotator);
		base.GetTexture(2).SetFillDirectionFlip(false);
		base.GetTexture(3).SetFillDirectionFlip(false);
	}

	// Token: 0x06014D3C RID: 85308 RVA: 0x0060D734 File Offset: 0x0060B934
	private void OnClockPointerDragCallBack(ULGUIPointerEventData eventData)
	{
		if (this.LastDragPoint.IsZero() || this.FirstDragPoint.IsZero())
		{
			global::Vector lastDragPoint = this.LastDragPoint;
			FVector pointerPosition = eventData.pointerPosition;
			FVectorDouble fvectorDouble = pointerPosition;
			lastDragPoint.DeepCopy(fvectorDouble);
			global::Vector firstDragPoint = this.FirstDragPoint;
			pointerPosition = eventData.pointerPosition;
			fvectorDouble = pointerPosition;
			firstDragPoint.DeepCopy(fvectorDouble);
			return;
		}
		global::Vector vector = global::Vector.Create(eventData.pointerPosition);
		bool isClockwise = this.JudgePointsClockwise(this.LastDragPoint, vector);
		double pointsAngle = this.GetPointsAngle(this.LastDragPoint, vector);
		double secondByAngle = this.GetSecondByAngle(pointsAngle);
		ValueTuple<bool, double> valueTuple = this.TimeAdjustingClock.AdjustToSecond(secondByAngle, isClockwise);
		if (!valueTuple.Item1)
		{
			if (valueTuple.Item2 != 0.0)
			{
				this.TimeAdjustingClock.AdjustToSecond(valueTuple.Item2, isClockwise);
				this.LastDragPoint.DeepCopy(this.FirstDragPoint);
			}
		}
		else
		{
			this.LastDragPoint.DeepCopy(vector);
		}
		this.RefreshAdjustingView();
	}

	// Token: 0x06014D3D RID: 85309 RVA: 0x0060D830 File Offset: 0x0060BA30
	private void OnClockPointerReleaseCallBack(ULGUIPointerEventData eventData)
	{
		this.LastDragPoint.DeepCopy(global::Vector.ZeroVectorProxy);
		this.FirstDragPoint.DeepCopy(global::Vector.ZeroVectorProxy);
	}

	// Token: 0x06014D3E RID: 85310 RVA: 0x0060D854 File Offset: 0x0060BA54
	private void OnUiDimensionsChangedCallBack(bool positionChanged, bool sizeChanged)
	{
		if (!sizeChanged)
		{
			return;
		}
		this.FirstDragPoint.DeepCopy(global::Vector.ZeroVectorProxy);
		this.LastDragPoint.DeepCopy(global::Vector.ZeroVectorProxy);
		FVector2D uiitemPositionInViewPort = ULGUIBPLibrary.GetUIItemPositionInViewPort(GlobalData.World, base.GetItem(17), false);
		this.DragCenterPoint = global::Vector.Create((double)uiitemPositionInViewPort.X, (double)uiitemPositionInViewPort.Y, 0.0);
	}

	// Token: 0x06014D3F RID: 85311 RVA: 0x0060D8BC File Offset: 0x0060BABC
	private void OnClickBtnConfirm()
	{
		TimeOfDayController.Instance.AdjustTime(this.TimeAdjustingClock.ToSecond, SceneDateUpdateReason.PlayerOperate, 0U, true);
		TimeOfDayController.Instance.PauseTime();
		UiLayer.Instance.SetShowNormalMaskLayer(true, "");
		Log.Instance.Info(ELogModule.Test, ELogAuthor.YZY, "OnClickBtnConfirm:" + CameraModel.Instance.MainModel.CurrentCameraActor.GetName(), default(ReadOnlySpan<ValueTuple<string, object>>));
		int? intConfig = ConfigCommonParamById.GetIntConfig("TimeCameraSettingName");
		int? intConfig2 = ConfigCommonParamById.GetIntConfig("TimeCameraBlendDataName");
		this.CameraHandleData = UiCameraModel.Instance.PlayCameraAnimationFromCurrent(intConfig.ToString(), intConfig2.ToString());
		SUiCameraAnimationSettings uiCameraAnimationConfig = UiCameraConfig.Instance.GetUiCameraAnimationConfig(intConfig.ToString());
		this.ClearStartAnimationTimer();
		this.StartAnimationTimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.OnAnimationBegin();
			this.TimeAdjustingAnimation.Play(this.TimeAdjustingClock.StartSecond, this.TimeAdjustingClock.ToSecond);
		}, 1000f * uiCameraAnimationConfig.BlendInTime, null, null, true, 1f);
	}

	// Token: 0x06014D40 RID: 85312 RVA: 0x0060D9BE File Offset: 0x0060BBBE
	private void OnClickBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014D41 RID: 85313 RVA: 0x0060D9C8 File Offset: 0x0060BBC8
	private void OnAnimationBegin()
	{
		this.TextureRotator.Yaw = (float)this.GetPointerAngle(this.TimeAdjustingClock.ToSecond);
		base.GetTexture(2).SetFillDirectionFlip(true);
		base.GetTexture(3).SetFillDirectionFlip(true);
		UUIItem item = base.GetItem(18);
		FRotator frotator = this.TextureRotator.ToUeRotator();
		item.SetUIRelativeRotation(frotator);
		UUIItem item2 = base.GetItem(19);
		frotator = this.TextureRotator.ToUeRotator();
		item2.SetUIRelativeRotation(frotator);
		base.GetItem(23).SetUIActive(false);
		base.GetItem(24).SetUIActive(false);
	}

	// Token: 0x06014D42 RID: 85314 RVA: 0x0060DA60 File Offset: 0x0060BC60
	private void OnAnimation(double second)
	{
		this.TimeAdjustingClock.AdjustStartSecond(second);
		double startSecondOneDay = this.TimeAdjustingClock.StartSecondOneDay;
		if (this.TimeAdjustingClock.IsAdjustingMoreThanOneDay)
		{
			base.GetTexture(2).SetFillAmount(1f);
			double num = this.TimeAdjustingClock.IsAdjustingToMaxLimit ? 1.0 : this.TimeAdjustingClock.DeltaDayOneDay;
			base.GetTexture(3).SetFillAmount((float)num);
		}
		else
		{
			base.GetTexture(2).SetFillAmount((float)this.TimeAdjustingClock.DeltaDayOneDay);
			base.GetTexture(3).SetFillAmount(0f);
		}
		ETodDayState etodDayState = TodDayTime.ConvertToDayState(startSecondOneDay);
		foreach (KeyValuePair<ETodDayState, TimeOfDayView.UiItemSwitcher> keyValuePair in this.DayStateUiItemMap)
		{
			keyValuePair.Value.SwitchTo(keyValuePair.Key == etodDayState);
		}
		this.DragPointerRotator.Yaw = (float)this.GetPointerAngle(startSecondOneDay);
		UUIItem texture = base.GetTexture(16);
		FRotator frotator = this.DragPointerRotator.ToUeRotator();
		texture.SetUIRelativeRotation(frotator);
		base.GetText(0).SetText(TodDayTime.ConvertToHourMinuteString(startSecondOneDay), true);
		TimeOfDayController.Instance.SyncGlobalGameTime(TodDayTime.ConvertToOneDaySecond(second), false);
	}

	// Token: 0x06014D43 RID: 85315 RVA: 0x0060DBB0 File Offset: 0x0060BDB0
	private void OnAnimationFinished()
	{
		UiLayer.Instance.SetShowNormalMaskLayer(false, "");
		int? intConfig = ConfigCommonParamById.GetIntConfig("TimeCameraBlendDataName");
		UiCameraModel.Instance.PlayCameraAnimationFromCurrent(this.CameraHandleData.GetHandleName(), intConfig.ToString());
		TimeOfDayController.Instance.ResumeTimeScale(true);
		this.TimeAdjustingClock.Reset();
		this.ResetView();
	}

	// Token: 0x06014D44 RID: 85316 RVA: 0x0060DC18 File Offset: 0x0060BE18
	private void RefreshAdjustingView()
	{
		if (this.TimeAdjustingClock.IsAdjustingMoreThanOneDay)
		{
			base.GetTexture(2).SetFillAmount(1f);
			double num = this.TimeAdjustingClock.IsAdjustingToMaxLimit ? 1.0 : this.TimeAdjustingClock.DeltaDayOneDay;
			base.GetTexture(3).SetFillAmount((float)num);
		}
		else
		{
			base.GetTexture(2).SetFillAmount((float)this.TimeAdjustingClock.DeltaDayOneDay);
			base.GetTexture(3).SetFillAmount(0f);
		}
		base.GetText(5).ShowTextNew(this.TimeAdjustingClock.DayTextId);
		this.SetBtnConfirmState(this.TimeAdjustingClock.IsAdjustingMoreThanMinLimit);
		this.DragPointerRotator.Yaw = (float)this.GetPointerAngle(this.TimeAdjustingClock.ToSecondOneDay);
		UUIItem item = base.GetItem(17);
		FRotator frotator = this.DragPointerRotator.ToUeRotator();
		item.SetUIRelativeRotation(frotator);
		UUIItem item2 = base.GetItem(25);
		frotator = this.DragPointerRotator.ToUeRotator();
		item2.SetUIRelativeRotation(frotator);
		base.GetText(4).SetText(TodDayTime.ConvertToHourMinuteString(this.TimeAdjustingClock.ToSecondOneDay), true);
	}

	// Token: 0x06014D45 RID: 85317 RVA: 0x0060DD38 File Offset: 0x0060BF38
	private void SetBtnConfirmState(bool state)
	{
		base.GetInteractionGroup(22).SetInteractable(state);
		string id = state ? "TimeOfDayConfirmTextOn" : "TimeOfDayConfirmTextOff";
		base.GetText(21).ShowTextNew(TextConfig.Instance.GetTextContentIdById(id));
	}

	// Token: 0x06014D46 RID: 85318 RVA: 0x0060DD7B File Offset: 0x0060BF7B
	private double GetPointerAngle(double second)
	{
		return -(TodDayTime.ConvertToOneDaySecond(second) / 86400.0) * 360.0;
	}

	// Token: 0x06014D47 RID: 85319 RVA: 0x0060DD98 File Offset: 0x0060BF98
	private double GetSecondByAngle(double angle)
	{
		return angle / 360.0 * 86400.0;
	}

	// Token: 0x06014D48 RID: 85320 RVA: 0x0060DDB0 File Offset: 0x0060BFB0
	private double GetPointsAngle(global::Vector point1, global::Vector point2)
	{
		point1.Subtraction(this.DragCenterPoint, this.TempVector1);
		point2.Subtraction(this.DragCenterPoint, this.TempVector2);
		double num = Math.Acos(this.TempVector1.CosineAngle2D(this.TempVector2, 9.999999747378752E-05)) * 57.295780181884766;
		if (point1.X < 0.0)
		{
			num = 360.0 - num;
		}
		return num;
	}

	// Token: 0x06014D49 RID: 85321 RVA: 0x0060DE2C File Offset: 0x0060C02C
	private bool JudgePointsClockwise(global::Vector from, global::Vector to)
	{
		from.Subtraction(this.DragCenterPoint, this.TempVector1);
		to.Subtraction(this.DragCenterPoint, this.TempVector2);
		global::Vector.CrossProduct(this.TempVector1, this.TempVector2, this.TempCrossProduct);
		return this.TempCrossProduct.Z > 0.0;
	}

	// Token: 0x0400B197 RID: 45463
	private readonly global::Vector FirstDragPoint = global::Vector.Create();

	// Token: 0x0400B198 RID: 45464
	private readonly global::Vector LastDragPoint = global::Vector.Create();

	// Token: 0x0400B199 RID: 45465
	private readonly global::Vector TempVector1 = global::Vector.Create();

	// Token: 0x0400B19A RID: 45466
	private readonly global::Vector TempVector2 = global::Vector.Create();

	// Token: 0x0400B19B RID: 45467
	private readonly global::Vector TempCrossProduct = global::Vector.Create();

	// Token: 0x0400B19C RID: 45468
	private readonly global::Rotator DragPointerRotator = global::Rotator.Create();

	// Token: 0x0400B19D RID: 45469
	private readonly global::Rotator TextureRotator = global::Rotator.Create(0f, 0f, 180f);

	// Token: 0x0400B19E RID: 45470
	private readonly Dictionary<ETodDayState, TimeOfDayView.UiItemSwitcher> DayStateUiItemMap = new Dictionary<ETodDayState, TimeOfDayView.UiItemSwitcher>();

	// Token: 0x0400B19F RID: 45471
	[Nullable(2)]
	private global::Vector DragCenterPoint;

	// Token: 0x0400B1A0 RID: 45472
	[Nullable(2)]
	private TimeOfDayView.TodTimeAdjustingClock TimeAdjustingClock;

	// Token: 0x0400B1A1 RID: 45473
	[Nullable(2)]
	private TodTimeAdjustingAnimation TimeAdjustingAnimation;

	// Token: 0x0400B1A2 RID: 45474
	[Nullable(2)]
	private TimerHandle StartAnimationTimerId;

	// Token: 0x0400B1A3 RID: 45475
	[Nullable(2)]
	private UiCameraHandleData CameraHandleData;

	// Token: 0x020083AF RID: 33711
	[NullableContext(0)]
	private class EChildCom
	{
		// Token: 0x0402A817 RID: 174103
		public const int TextTime = 0;

		// Token: 0x0402A818 RID: 174104
		public const int BtnConfirm = 1;

		// Token: 0x0402A819 RID: 174105
		public const int TextureClockOuter = 2;

		// Token: 0x0402A81A RID: 174106
		public const int TextureClockInner = 3;

		// Token: 0x0402A81B RID: 174107
		public const int TextTimeAdjust = 4;

		// Token: 0x0402A81C RID: 174108
		public const int TextTomorrow = 5;

		// Token: 0x0402A81D RID: 174109
		public const int PanelMorning1 = 6;

		// Token: 0x0402A81E RID: 174110
		public const int PanelMorning2 = 7;

		// Token: 0x0402A81F RID: 174111
		public const int PanelSunset1 = 8;

		// Token: 0x0402A820 RID: 174112
		public const int PanelSunset2 = 9;

		// Token: 0x0402A821 RID: 174113
		public const int PanelNight1 = 10;

		// Token: 0x0402A822 RID: 174114
		public const int PanelNight2 = 11;

		// Token: 0x0402A823 RID: 174115
		public const int PanelSunrise1 = 12;

		// Token: 0x0402A824 RID: 174116
		public const int PanelSunrise2 = 13;

		// Token: 0x0402A825 RID: 174117
		public const int DraggableClock = 14;

		// Token: 0x0402A826 RID: 174118
		public const int BtnBack = 15;

		// Token: 0x0402A827 RID: 174119
		public const int TexturePointerShort = 16;

		// Token: 0x0402A828 RID: 174120
		public const int PanelPointerLong = 17;

		// Token: 0x0402A829 RID: 174121
		public const int PanelClockOuter = 18;

		// Token: 0x0402A82A RID: 174122
		public const int PanelClockInner = 19;

		// Token: 0x0402A82B RID: 174123
		public const int PanelTimeAdjust = 20;

		// Token: 0x0402A82C RID: 174124
		public const int TextConfirm = 21;

		// Token: 0x0402A82D RID: 174125
		public const int InteractionConfirm = 22;

		// Token: 0x0402A82E RID: 174126
		public const int PanelBtnBack = 23;

		// Token: 0x0402A82F RID: 174127
		public const int PanelBtnConfirm = 24;

		// Token: 0x0402A830 RID: 174128
		public const int PanelBtnPointerLong = 25;
	}

	// Token: 0x020083B0 RID: 33712
	[Nullable(0)]
	private class UiItemSwitcher
	{
		// Token: 0x060421ED RID: 270829 RVA: 0x013A62BB File Offset: 0x013A44BB
		public UiItemSwitcher(UUIItem uiItemOff, UUIItem uiItemOn)
		{
			this.UiItemOn = uiItemOn;
			this.UiItemOff = uiItemOff;
		}

		// Token: 0x060421EE RID: 270830 RVA: 0x013A62D1 File Offset: 0x013A44D1
		public void SwitchTo(bool state)
		{
			this.UiItemOn.SetUIActive(state);
			this.UiItemOff.SetUIActive(!state);
		}

		// Token: 0x0402A831 RID: 174129
		private readonly UUIItem UiItemOn;

		// Token: 0x0402A832 RID: 174130
		private readonly UUIItem UiItemOff;
	}

	// Token: 0x020083B1 RID: 33713
	[NullableContext(0)]
	private class TodTimeAdjustingClock
	{
		// Token: 0x17007835 RID: 30773
		// (get) Token: 0x060421EF RID: 270831 RVA: 0x013A62EE File Offset: 0x013A44EE
		public double DeltaSecond
		{
			get
			{
				return this.ToSecond - this.StartSecond;
			}
		}

		// Token: 0x17007836 RID: 30774
		// (get) Token: 0x060421F0 RID: 270832 RVA: 0x013A62FD File Offset: 0x013A44FD
		public double DeltaMinute
		{
			get
			{
				return Math.Floor(this.ToSecond / 60.0) - Math.Floor(this.StartSecond / 60.0);
			}
		}

		// Token: 0x17007837 RID: 30775
		// (get) Token: 0x060421F1 RID: 270833 RVA: 0x013A632A File Offset: 0x013A452A
		public double DeltaSecondOneDay
		{
			get
			{
				return TodDayTime.ConvertToOneDaySecond(this.DeltaSecond);
			}
		}

		// Token: 0x17007838 RID: 30776
		// (get) Token: 0x060421F2 RID: 270834 RVA: 0x013A6337 File Offset: 0x013A4537
		public double DeltaDayOneDay
		{
			get
			{
				return TodDayTime.ConvertToDay(this.DeltaSecondOneDay);
			}
		}

		// Token: 0x17007839 RID: 30777
		// (get) Token: 0x060421F3 RID: 270835 RVA: 0x013A6344 File Offset: 0x013A4544
		public double ToSecondOneDay
		{
			get
			{
				return TodDayTime.ConvertToOneDaySecond(this.ToSecond);
			}
		}

		// Token: 0x1700783A RID: 30778
		// (get) Token: 0x060421F4 RID: 270836 RVA: 0x013A6351 File Offset: 0x013A4551
		public double StartSecondOneDay
		{
			get
			{
				return TodDayTime.ConvertToOneDaySecond(this.StartSecond);
			}
		}

		// Token: 0x1700783B RID: 30779
		// (get) Token: 0x060421F5 RID: 270837 RVA: 0x013A635E File Offset: 0x013A455E
		public bool IsAdjusting
		{
			get
			{
				return this.StartSecond >= 0.0;
			}
		}

		// Token: 0x1700783C RID: 30780
		// (get) Token: 0x060421F6 RID: 270838 RVA: 0x013A6374 File Offset: 0x013A4574
		public bool IsTomorrow
		{
			get
			{
				return this.ToSecond >= 86400.0;
			}
		}

		// Token: 0x1700783D RID: 30781
		// (get) Token: 0x060421F7 RID: 270839 RVA: 0x013A638C File Offset: 0x013A458C
		[Nullable(1)]
		public string DayTextId
		{
			[NullableContext(1)]
			get
			{
				int num = (int)Math.Floor(this.ToSecond / 86400.0);
				if (num == 1)
				{
					return TextConfig.Instance.GetTextContentIdById("TimeOfDayTomorrow");
				}
				if (num == 2)
				{
					return TextConfig.Instance.GetTextContentIdById("TimeOfDayPlusTwoDay");
				}
				return TextConfig.Instance.GetTextContentIdById("TimeOfDayToday");
			}
		}

		// Token: 0x1700783E RID: 30782
		// (get) Token: 0x060421F8 RID: 270840 RVA: 0x013A63E7 File Offset: 0x013A45E7
		public bool IsAdjustingMoreThanOneDay
		{
			get
			{
				return this.DeltaSecond >= 86400.0;
			}
		}

		// Token: 0x1700783F RID: 30783
		// (get) Token: 0x060421F9 RID: 270841 RVA: 0x013A63FD File Offset: 0x013A45FD
		public bool IsAdjustingMoreThanMinLimit
		{
			get
			{
				return this.DeltaMinute >= 30.0;
			}
		}

		// Token: 0x17007840 RID: 30784
		// (get) Token: 0x060421FA RID: 270842 RVA: 0x013A6413 File Offset: 0x013A4613
		public bool IsAdjustingToMaxLimit
		{
			get
			{
				return this.DeltaSecond >= 172800.0;
			}
		}

		// Token: 0x060421FB RID: 270843 RVA: 0x013A6429 File Offset: 0x013A4629
		public void Start()
		{
			this.StartSecond = TimeOfDayModel.Instance.GameTime.Second;
			this.ToSecond = this.StartSecond;
		}

		// Token: 0x060421FC RID: 270844 RVA: 0x013A644C File Offset: 0x013A464C
		public void Reset()
		{
			this.StartSecond = -1.0;
			this.ToSecond = -1.0;
		}

		// Token: 0x060421FD RID: 270845 RVA: 0x013A646C File Offset: 0x013A466C
		public ValueTuple<bool, double> AdjustToSecond(double addSecond, bool isClockwise)
		{
			if (addSecond == 0.0 || double.IsNaN(addSecond))
			{
				return new ValueTuple<bool, double>(false, 0.0);
			}
			if (!this.IsAdjusting)
			{
				return new ValueTuple<bool, double>(false, 0.0);
			}
			double num;
			if (isClockwise)
			{
				num = this.ToSecond + addSecond;
				if (num > this.StartSecond + 172800.0)
				{
					return new ValueTuple<bool, double>(false, this.StartSecond + 172800.0 - this.ToSecond);
				}
			}
			else
			{
				num = this.ToSecond - addSecond;
				if (num < this.StartSecond)
				{
					return new ValueTuple<bool, double>(false, this.ToSecond - this.StartSecond);
				}
			}
			this.ToSecond = num;
			return new ValueTuple<bool, double>(true, 0.0);
		}

		// Token: 0x060421FE RID: 270846 RVA: 0x013A6538 File Offset: 0x013A4738
		public void AdjustStartSecond(double second)
		{
			if (second == 0.0 || double.IsNaN(second))
			{
				return;
			}
			if (!this.IsAdjusting)
			{
				return;
			}
			this.StartSecond = second;
			if (this.StartSecond > this.ToSecond)
			{
				this.StartSecond = this.ToSecond;
			}
		}

		// Token: 0x060421FF RID: 270847 RVA: 0x013A6584 File Offset: 0x013A4784
		public unsafe void DebugPrint()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TimeOfDay;
			ELogAuthor author = ELogAuthor.TL;
			string message = "TodTimeAdjustingClock";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("this.StartSecond", this.StartSecond);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("this.ToSecond", this.ToSecond);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0402A833 RID: 174131
		public double StartSecond = -1.0;

		// Token: 0x0402A834 RID: 174132
		public double ToSecond = -1.0;
	}
}
