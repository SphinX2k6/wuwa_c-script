using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCameraAnimation;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BB3 RID: 11187
[NullableContext(1)]
[Nullable(0)]
public class TimeOfDayView : UiTickViewBase
{
	// Token: 0x06017300 RID: 94976 RVA: 0x005E0338 File Offset: 0x005DE538
	public TimeOfDayView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06017301 RID: 94977 RVA: 0x005E03B4 File Offset: 0x005DE5B4
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

	// Token: 0x06017302 RID: 94978 RVA: 0x005E0658 File Offset: 0x005DE858
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

	// Token: 0x06017303 RID: 94979 RVA: 0x005E076A File Offset: 0x005DE96A
	protected override void OnBeforeDestroy()
	{
		this.TimeAdjustingClock.Reset();
		this.TimeAdjustingAnimation.Stop();
		this.ClearStartAnimationTimer();
	}

	// Token: 0x06017304 RID: 94980 RVA: 0x005E0788 File Offset: 0x005DE988
	protected override void OnTick(float deltaTime)
	{
		TodTimeAdjustingAnimation timeAdjustingAnimation = this.TimeAdjustingAnimation;
		if (timeAdjustingAnimation == null)
		{
			return;
		}
		timeAdjustingAnimation.Tick((double)deltaTime);
	}

	// Token: 0x06017305 RID: 94981 RVA: 0x005E079C File Offset: 0x005DE99C
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

	// Token: 0x06017306 RID: 94982 RVA: 0x005E0828 File Offset: 0x005DEA28
	protected override void OnRemoveEventListener()
	{
		UUIDraggableComponent draggable = base.GetDraggable(14);
		draggable.OnPointerBeginDragCallBack.Unbind();
		draggable.OnPointerDragCallBack.Unbind();
		draggable.OnPointerEndDragCallBack.Unbind();
		draggable.OnUIDimensionsChangedCallBack.Unbind();
		EventSystem.Instance.Remove(EEventName.TodTimeChange, new Action(this.UpdateTime));
	}

	// Token: 0x06017307 RID: 94983 RVA: 0x005E0884 File Offset: 0x005DEA84
	private void ClearStartAnimationTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.StartAnimationTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.StartAnimationTimerId);
		}
		this.StartAnimationTimerId = null;
	}

	// Token: 0x06017308 RID: 94984 RVA: 0x005E08B0 File Offset: 0x005DEAB0
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

	// Token: 0x06017309 RID: 94985 RVA: 0x005E0938 File Offset: 0x005DEB38
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

	// Token: 0x0601730A RID: 94986 RVA: 0x005E0A94 File Offset: 0x005DEC94
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

	// Token: 0x0601730B RID: 94987 RVA: 0x005E0B60 File Offset: 0x005DED60
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

	// Token: 0x0601730C RID: 94988 RVA: 0x005E0C5C File Offset: 0x005DEE5C
	private void OnClockPointerReleaseCallBack(ULGUIPointerEventData eventData)
	{
		this.LastDragPoint.DeepCopy(global::Vector.ZeroVectorProxy);
		this.FirstDragPoint.DeepCopy(global::Vector.ZeroVectorProxy);
	}

	// Token: 0x0601730D RID: 94989 RVA: 0x005E0C80 File Offset: 0x005DEE80
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

	// Token: 0x0601730E RID: 94990 RVA: 0x005E0CE8 File Offset: 0x005DEEE8
	private void OnClickBtnConfirm()
	{
		TimeOfDayController.Instance.AdjustTime(this.TimeAdjustingClock.ToSecond, SceneDateUpdateReason.PlayerOperate, 0U, true);
		TimeOfDayController.Instance.PauseTime();
		UiLayer.Instance.SetShowNormalMaskLayer(true, "");
		Log.Instance.Info(ELogModule.Test, ELogAuthor.YZY, "OnClickBtnConfirm:" + CameraModel.Instance.MainModel.CurrentCameraActor.GetName(), default(ReadOnlySpan<ValueTuple<string, object>>));
		int? intConfig = ConfigCommonParamById.GetIntConfig("TimeCameraSettingName");
		int? intConfig2 = ConfigCommonParamById.GetIntConfig("TimeCameraBlendDataName");
		this.CameraHandleData = UiCameraAnimationManager.Instance.PlayCameraAnimationFromCurrent(intConfig.ToString(), intConfig2.ToString());
		SUiCameraAnimationSettings uiCameraAnimationConfig = UiCameraAnimationConfig.Instance.GetUiCameraAnimationConfig(intConfig.ToString());
		this.ClearStartAnimationTimer();
		this.StartAnimationTimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.OnAnimationBegin();
			this.TimeAdjustingAnimation.Play(this.TimeAdjustingClock.StartSecond, this.TimeAdjustingClock.ToSecond);
		}, 1000f * uiCameraAnimationConfig.BlendInTime, null, null, true, 1f);
	}

	// Token: 0x0601730F RID: 94991 RVA: 0x005E0DEA File Offset: 0x005DEFEA
	private void OnClickBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06017310 RID: 94992 RVA: 0x005E0DF4 File Offset: 0x005DEFF4
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

	// Token: 0x06017311 RID: 94993 RVA: 0x005E0E8C File Offset: 0x005DF08C
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

	// Token: 0x06017312 RID: 94994 RVA: 0x005E0FDC File Offset: 0x005DF1DC
	private void OnAnimationFinished()
	{
		UiLayer.Instance.SetShowNormalMaskLayer(false, "");
		int? intConfig = ConfigCommonParamById.GetIntConfig("TimeCameraBlendDataName");
		UiCameraAnimationManager.Instance.PlayCameraAnimationFromCurrent(this.CameraHandleData.GetHandleName(), intConfig.ToString());
		TimeOfDayController.Instance.ResumeTimeScale(true);
		this.TimeAdjustingClock.Reset();
		this.ResetView();
	}

	// Token: 0x06017313 RID: 94995 RVA: 0x005E1044 File Offset: 0x005DF244
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

	// Token: 0x06017314 RID: 94996 RVA: 0x005E1164 File Offset: 0x005DF364
	private void SetBtnConfirmState(bool state)
	{
		base.GetInteractionGroup(22).SetInteractable(state);
		string id = state ? "TimeOfDayConfirmTextOn" : "TimeOfDayConfirmTextOff";
		base.GetText(21).ShowTextNew(TextConfig.Instance.GetTextContentIdById(id));
	}

	// Token: 0x06017315 RID: 94997 RVA: 0x005E11A7 File Offset: 0x005DF3A7
	private double GetPointerAngle(double second)
	{
		return -(TodDayTime.ConvertToOneDaySecond(second) / 86400.0) * 360.0;
	}

	// Token: 0x06017316 RID: 94998 RVA: 0x005E11C4 File Offset: 0x005DF3C4
	private double GetSecondByAngle(double angle)
	{
		return angle / 360.0 * 86400.0;
	}

	// Token: 0x06017317 RID: 94999 RVA: 0x005E11DC File Offset: 0x005DF3DC
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

	// Token: 0x06017318 RID: 95000 RVA: 0x005E1258 File Offset: 0x005DF458
	private bool JudgePointsClockwise(global::Vector from, global::Vector to)
	{
		from.Subtraction(this.DragCenterPoint, this.TempVector1);
		to.Subtraction(this.DragCenterPoint, this.TempVector2);
		global::Vector.CrossProduct(this.TempVector1, this.TempVector2, this.TempCrossProduct);
		return this.TempCrossProduct.Z > 0.0;
	}

	// Token: 0x0400AD90 RID: 44432
	private readonly global::Vector FirstDragPoint = global::Vector.Create();

	// Token: 0x0400AD91 RID: 44433
	private readonly global::Vector LastDragPoint = global::Vector.Create();

	// Token: 0x0400AD92 RID: 44434
	private readonly global::Vector TempVector1 = global::Vector.Create();

	// Token: 0x0400AD93 RID: 44435
	private readonly global::Vector TempVector2 = global::Vector.Create();

	// Token: 0x0400AD94 RID: 44436
	private readonly global::Vector TempCrossProduct = global::Vector.Create();

	// Token: 0x0400AD95 RID: 44437
	private readonly global::Rotator DragPointerRotator = global::Rotator.Create();

	// Token: 0x0400AD96 RID: 44438
	private readonly global::Rotator TextureRotator = global::Rotator.Create(0f, 0f, 180f);

	// Token: 0x0400AD97 RID: 44439
	private readonly Dictionary<ETodDayState, TimeOfDayView.UiItemSwitcher> DayStateUiItemMap = new Dictionary<ETodDayState, TimeOfDayView.UiItemSwitcher>();

	// Token: 0x0400AD98 RID: 44440
	[Nullable(2)]
	private global::Vector DragCenterPoint;

	// Token: 0x0400AD99 RID: 44441
	[Nullable(2)]
	private TimeOfDayView.TodTimeAdjustingClock TimeAdjustingClock;

	// Token: 0x0400AD9A RID: 44442
	[Nullable(2)]
	private TodTimeAdjustingAnimation TimeAdjustingAnimation;

	// Token: 0x0400AD9B RID: 44443
	[Nullable(2)]
	private TimerHandle StartAnimationTimerId;

	// Token: 0x0400AD9C RID: 44444
	[Nullable(2)]
	private UiCameraHandleData CameraHandleData;

	// Token: 0x0200916C RID: 37228
	[NullableContext(0)]
	private class EChildCom
	{
		// Token: 0x0402F112 RID: 192786
		public const int TextTime = 0;

		// Token: 0x0402F113 RID: 192787
		public const int BtnConfirm = 1;

		// Token: 0x0402F114 RID: 192788
		public const int TextureClockOuter = 2;

		// Token: 0x0402F115 RID: 192789
		public const int TextureClockInner = 3;

		// Token: 0x0402F116 RID: 192790
		public const int TextTimeAdjust = 4;

		// Token: 0x0402F117 RID: 192791
		public const int TextTomorrow = 5;

		// Token: 0x0402F118 RID: 192792
		public const int PanelMorning1 = 6;

		// Token: 0x0402F119 RID: 192793
		public const int PanelMorning2 = 7;

		// Token: 0x0402F11A RID: 192794
		public const int PanelSunset1 = 8;

		// Token: 0x0402F11B RID: 192795
		public const int PanelSunset2 = 9;

		// Token: 0x0402F11C RID: 192796
		public const int PanelNight1 = 10;

		// Token: 0x0402F11D RID: 192797
		public const int PanelNight2 = 11;

		// Token: 0x0402F11E RID: 192798
		public const int PanelSunrise1 = 12;

		// Token: 0x0402F11F RID: 192799
		public const int PanelSunrise2 = 13;

		// Token: 0x0402F120 RID: 192800
		public const int DraggableClock = 14;

		// Token: 0x0402F121 RID: 192801
		public const int BtnBack = 15;

		// Token: 0x0402F122 RID: 192802
		public const int TexturePointerShort = 16;

		// Token: 0x0402F123 RID: 192803
		public const int PanelPointerLong = 17;

		// Token: 0x0402F124 RID: 192804
		public const int PanelClockOuter = 18;

		// Token: 0x0402F125 RID: 192805
		public const int PanelClockInner = 19;

		// Token: 0x0402F126 RID: 192806
		public const int PanelTimeAdjust = 20;

		// Token: 0x0402F127 RID: 192807
		public const int TextConfirm = 21;

		// Token: 0x0402F128 RID: 192808
		public const int InteractionConfirm = 22;

		// Token: 0x0402F129 RID: 192809
		public const int PanelBtnBack = 23;

		// Token: 0x0402F12A RID: 192810
		public const int PanelBtnConfirm = 24;

		// Token: 0x0402F12B RID: 192811
		public const int PanelBtnPointerLong = 25;
	}

	// Token: 0x0200916D RID: 37229
	[Nullable(0)]
	private class UiItemSwitcher
	{
		// Token: 0x0604BCFB RID: 310523 RVA: 0x013FA8E3 File Offset: 0x013F8AE3
		public UiItemSwitcher(UUIItem uiItemOff, UUIItem uiItemOn)
		{
			this.UiItemOn = uiItemOn;
			this.UiItemOff = uiItemOff;
		}

		// Token: 0x0604BCFC RID: 310524 RVA: 0x013FA8F9 File Offset: 0x013F8AF9
		public void SwitchTo(bool state)
		{
			this.UiItemOn.SetUIActive(state);
			this.UiItemOff.SetUIActive(!state);
		}

		// Token: 0x0402F12C RID: 192812
		private readonly UUIItem UiItemOn;

		// Token: 0x0402F12D RID: 192813
		private readonly UUIItem UiItemOff;
	}

	// Token: 0x0200916E RID: 37230
	[NullableContext(0)]
	private class TodTimeAdjustingClock
	{
		// Token: 0x1700A097 RID: 41111
		// (get) Token: 0x0604BCFD RID: 310525 RVA: 0x013FA916 File Offset: 0x013F8B16
		public double DeltaSecond
		{
			get
			{
				return this.ToSecond - this.StartSecond;
			}
		}

		// Token: 0x1700A098 RID: 41112
		// (get) Token: 0x0604BCFE RID: 310526 RVA: 0x013FA925 File Offset: 0x013F8B25
		public double DeltaMinute
		{
			get
			{
				return Math.Floor(this.ToSecond / 60.0) - Math.Floor(this.StartSecond / 60.0);
			}
		}

		// Token: 0x1700A099 RID: 41113
		// (get) Token: 0x0604BCFF RID: 310527 RVA: 0x013FA952 File Offset: 0x013F8B52
		public double DeltaSecondOneDay
		{
			get
			{
				return TodDayTime.ConvertToOneDaySecond(this.DeltaSecond);
			}
		}

		// Token: 0x1700A09A RID: 41114
		// (get) Token: 0x0604BD00 RID: 310528 RVA: 0x013FA95F File Offset: 0x013F8B5F
		public double DeltaDayOneDay
		{
			get
			{
				return TodDayTime.ConvertToDay(this.DeltaSecondOneDay);
			}
		}

		// Token: 0x1700A09B RID: 41115
		// (get) Token: 0x0604BD01 RID: 310529 RVA: 0x013FA96C File Offset: 0x013F8B6C
		public double ToSecondOneDay
		{
			get
			{
				return TodDayTime.ConvertToOneDaySecond(this.ToSecond);
			}
		}

		// Token: 0x1700A09C RID: 41116
		// (get) Token: 0x0604BD02 RID: 310530 RVA: 0x013FA979 File Offset: 0x013F8B79
		public double StartSecondOneDay
		{
			get
			{
				return TodDayTime.ConvertToOneDaySecond(this.StartSecond);
			}
		}

		// Token: 0x1700A09D RID: 41117
		// (get) Token: 0x0604BD03 RID: 310531 RVA: 0x013FA986 File Offset: 0x013F8B86
		public bool IsAdjusting
		{
			get
			{
				return this.StartSecond >= 0.0;
			}
		}

		// Token: 0x1700A09E RID: 41118
		// (get) Token: 0x0604BD04 RID: 310532 RVA: 0x013FA99C File Offset: 0x013F8B9C
		public bool IsTomorrow
		{
			get
			{
				return this.ToSecond >= 86400.0;
			}
		}

		// Token: 0x1700A09F RID: 41119
		// (get) Token: 0x0604BD05 RID: 310533 RVA: 0x013FA9B4 File Offset: 0x013F8BB4
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

		// Token: 0x1700A0A0 RID: 41120
		// (get) Token: 0x0604BD06 RID: 310534 RVA: 0x013FAA0F File Offset: 0x013F8C0F
		public bool IsAdjustingMoreThanOneDay
		{
			get
			{
				return this.DeltaSecond >= 86400.0;
			}
		}

		// Token: 0x1700A0A1 RID: 41121
		// (get) Token: 0x0604BD07 RID: 310535 RVA: 0x013FAA25 File Offset: 0x013F8C25
		public bool IsAdjustingMoreThanMinLimit
		{
			get
			{
				return this.DeltaMinute >= 30.0;
			}
		}

		// Token: 0x1700A0A2 RID: 41122
		// (get) Token: 0x0604BD08 RID: 310536 RVA: 0x013FAA3B File Offset: 0x013F8C3B
		public bool IsAdjustingToMaxLimit
		{
			get
			{
				return this.DeltaSecond >= 172800.0;
			}
		}

		// Token: 0x0604BD09 RID: 310537 RVA: 0x013FAA51 File Offset: 0x013F8C51
		public void Start()
		{
			this.StartSecond = TimeOfDayModel.Instance.GameTime.Second;
			this.ToSecond = this.StartSecond;
		}

		// Token: 0x0604BD0A RID: 310538 RVA: 0x013FAA74 File Offset: 0x013F8C74
		public void Reset()
		{
			this.StartSecond = -1.0;
			this.ToSecond = -1.0;
		}

		// Token: 0x0604BD0B RID: 310539 RVA: 0x013FAA94 File Offset: 0x013F8C94
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

		// Token: 0x0604BD0C RID: 310540 RVA: 0x013FAB60 File Offset: 0x013F8D60
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

		// Token: 0x0604BD0D RID: 310541 RVA: 0x013FABAC File Offset: 0x013F8DAC
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

		// Token: 0x0402F12E RID: 192814
		public double StartSecond = -1.0;

		// Token: 0x0402F12F RID: 192815
		public double ToSecond = -1.0;
	}
}
