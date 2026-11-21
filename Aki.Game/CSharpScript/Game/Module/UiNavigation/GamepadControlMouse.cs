using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003865 RID: 14437
	[NullableContext(1)]
	[Nullable(0)]
	public class GamepadControlMouse
	{
		// Token: 0x17004D09 RID: 19721
		// (get) Token: 0x0602584E RID: 153678 RVA: 0x00A9101C File Offset: 0x00A8F21C
		private Vector2D TempVector2D
		{
			get
			{
				if (this.InternalTempVector2D == null)
				{
					FVector pointerPosition = this.EventData.pointerPosition;
					this.InternalTempVector2D = new Vector2D((double)pointerPosition.X, (double)pointerPosition.Y);
				}
				return this.InternalTempVector2D;
			}
		}

		// Token: 0x17004D0A RID: 19722
		// (get) Token: 0x0602584F RID: 153679 RVA: 0x00A9105C File Offset: 0x00A8F25C
		private bool IsGamepadMoving
		{
			get
			{
				return this.GamepadMoveForwardValue != 0f || this.GamepadMoveRightValue != 0f;
			}
		}

		// Token: 0x06025850 RID: 153680 RVA: 0x00A91080 File Offset: 0x00A8F280
		public GamepadControlMouse(UUIItem gamepadItem, UiNavigationViewHandle viewHandle)
		{
			this.GamepadItem = gamepadItem;
			this.GamepadItem.SetAlpha(Info.Instance.IsInGamepad() > false);
			this.SequencePlayer = new LevelSequencePlayer(gamepadItem);
			this.ViewHandle = viewHandle;
			this.EventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			this.Canvas = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			this.CanvasScaleFactor = this.Canvas.Canvas.GetCanvasScale();
			this.HalfWidth = UiLayer.Instance.UiRootItem.GetWidth() / 2f;
			this.HalfHeight = UiLayer.Instance.UiRootItem.GetHeight() / 2f;
			FIntPoint viewportSize = UiLayer.Instance.UiRootItem.GetRenderCanvas().GetViewportSize();
			this.ViewPortWidth = (float)viewportSize.X;
			this.ViewPortHeight = (float)viewportSize.Y;
			this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenVector2SetterDynamic>(new Action<FVector2D>(this.OnTweenUpdate));
		}

		// Token: 0x06025851 RID: 153681 RVA: 0x00A911AC File Offset: 0x00A8F3AC
		private Vector2D GetTempVectorInLgui()
		{
			if (this.Canvas == null)
			{
				return this.TempVector2D;
			}
			FVector2D fvector2D = this.ConvertViewportToLguiCanvas(this.TempVector2D.X, this.TempVector2D.Y);
			return new Vector2D((double)(fvector2D.X - this.HalfWidth), (double)(fvector2D.Y - this.HalfHeight));
		}

		// Token: 0x06025852 RID: 153682 RVA: 0x00A91208 File Offset: 0x00A8F408
		private FVector2D ConvertViewportToLguiCanvas(double viewportX, double viewportY)
		{
			FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
			float num = (viewportSize.X > this.ViewPortWidth) ? ((viewportSize.X - this.ViewPortWidth) / 2f) : 0f;
			float num2 = (viewportSize.Y > this.ViewPortHeight) ? ((viewportSize.Y - this.ViewPortHeight) / 2f) : 0f;
			ULGUICanvasScaler canvas = this.Canvas;
			FVector2D fvector2D = new FVector2D((float)(viewportX - (double)num), (float)(viewportY - (double)num2));
			return canvas.ConvertPositionFromViewportToLGUICanvas(fvector2D);
		}

		// Token: 0x06025853 RID: 153683 RVA: 0x00A91290 File Offset: 0x00A8F490
		private void SetGamepadOffset()
		{
			Vector2D tempVectorInLgui = this.GetTempVectorInLgui();
			double num = 0.0;
			double num2 = 0.0;
			if (tempVectorInLgui.X > (double)this.HalfWidth)
			{
				num = tempVectorInLgui.X - (double)this.HalfWidth;
				tempVectorInLgui.X = (double)this.HalfWidth;
				this.TempVector2D.X = MathUtils.Instance.Clamp(this.TempVector2D.X - (double)this.GamepadMoveRightValue, 0.0, (double)this.ViewPortWidth);
			}
			else if (tempVectorInLgui.X < (double)(-(double)this.HalfWidth))
			{
				num = tempVectorInLgui.X + (double)this.HalfWidth;
				tempVectorInLgui.X = (double)(-(double)this.HalfWidth);
				this.TempVector2D.X = MathUtils.Instance.Clamp(this.TempVector2D.X - (double)this.GamepadMoveRightValue, 0.0, (double)this.ViewPortWidth);
			}
			if (tempVectorInLgui.Y > (double)this.HalfHeight)
			{
				num2 = tempVectorInLgui.Y - (double)this.HalfHeight;
				tempVectorInLgui.Y = (double)this.HalfHeight;
				this.TempVector2D.Y = MathUtils.Instance.Clamp(this.TempVector2D.Y + (double)this.GamepadMoveForwardValue, 0.0, (double)this.ViewPortHeight);
			}
			else if (tempVectorInLgui.Y < (double)(-(double)this.HalfHeight))
			{
				num2 = tempVectorInLgui.Y + (double)this.HalfHeight;
				tempVectorInLgui.Y = (double)(-(double)this.HalfHeight);
				this.TempVector2D.Y = MathUtils.Instance.Clamp(this.TempVector2D.Y + (double)this.GamepadMoveForwardValue, 0.0, (double)this.ViewPortHeight);
			}
			this.GamepadItem.SetAnchorOffset(tempVectorInLgui.ToUeVector2D(false));
			TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
			if (lguiEventSystemActor != null)
			{
				lguiEventSystemActor.OverrideMousePosition(this.TempVector2D.ToUeVector2D(false));
			}
			if (num != 0.0 || num2 != 0.0)
			{
				EventSystem.Instance.Emit<double, double>(EEventName.GamepadMoveOverScreen, num, num2);
			}
		}

		// Token: 0x06025854 RID: 153684 RVA: 0x00A914AC File Offset: 0x00A8F6AC
		private void InitMousePosition()
		{
			FVector2D positionInViewPort = this.GamepadItem.GetPositionInViewPort(true);
			this.EventData.pointerPosition = new FVector(positionInViewPort.X, positionInViewPort.Y, 0f);
		}

		// Token: 0x06025855 RID: 153685 RVA: 0x00A914E8 File Offset: 0x00A8F6E8
		private void CalculateGamepadMoveDistance(float deltaTime)
		{
			if (!this.IsGamepadMoving)
			{
				return;
			}
			float num = (float)TimeUtil.Instance.InverseMillisecond / deltaTime;
			float num2 = 60f / num;
			this.GamepadMoveForwardValue *= num2;
			this.GamepadMoveRightValue *= num2;
			if (this.EventData != null)
			{
				FVector pointerPosition = this.EventData.pointerPosition;
				pointerPosition.Y -= this.GamepadMoveForwardValue;
				pointerPosition.X += this.GamepadMoveRightValue;
				this.TempVector2D.Set((double)pointerPosition.X, (double)pointerPosition.Y);
				return;
			}
			this.TempVector2D.Set((double)this.GamepadMoveRightValue, (double)(-(double)this.GamepadMoveForwardValue));
		}

		// Token: 0x06025856 RID: 153686 RVA: 0x00A9159A File Offset: 0x00A8F79A
		private void UpdateMousePosition()
		{
			if (!this.IsGamepadMoving)
			{
				return;
			}
			this.KillPosTweener();
			this.IsStopMoved = false;
			this.SetGamepadOffset();
			TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
			if (lguiEventSystemActor == null)
			{
				return;
			}
			lguiEventSystemActor.SwitchToNavigationInputType();
		}

		// Token: 0x06025857 RID: 153687 RVA: 0x00A915CC File Offset: 0x00A8F7CC
		private void UpdateMousePositionByEventData()
		{
			if (this.EventData != null)
			{
				this.TempVector2D.Set((double)this.EventData.pointerPosition.X, (double)this.EventData.pointerPosition.Y);
			}
			this.KillPosTweener();
			this.SetGamepadOffset();
			TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
			if (lguiEventSystemActor == null)
			{
				return;
			}
			lguiEventSystemActor.SwitchToNavigationInputType();
		}

		// Token: 0x06025858 RID: 153688 RVA: 0x00A91630 File Offset: 0x00A8F830
		private void CalculateHitListener()
		{
			UUIItem nowHitComponent = LguiEventSystemManager.Instance.GetNowHitComponent();
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = null;
			if (nowHitComponent != null)
			{
				AActor owner = nowHitComponent.GetOwner();
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = ((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null) as TsUiNavigationBehaviorListener;
				if (tsUiNavigationBehaviorListener2 != null)
				{
					tsUiNavigationBehaviorListener = tsUiNavigationBehaviorListener2;
				}
			}
			if (this.HitListener != tsUiNavigationBehaviorListener)
			{
				this.ViewHandle.MarkRefreshHotKeyDirty();
			}
			this.HitListener = tsUiNavigationBehaviorListener;
		}

		// Token: 0x06025859 RID: 153689 RVA: 0x00A9168F File Offset: 0x00A8F88F
		private void KillPosTweener()
		{
			if (this.PosTweener != null)
			{
				this.PosTweener.Kill(false);
				this.PosTweener = null;
			}
		}

		// Token: 0x0602585A RID: 153690 RVA: 0x00A916AC File Offset: 0x00A8F8AC
		private void OnTweenUpdate(FVector2D targetPos)
		{
			this.TempTweenPosition.Set((double)targetPos.X, (double)targetPos.Y);
			this.TempVector2D.Set(this.TempTweenPosition.X, this.TempTweenPosition.Y);
			this.SetGamepadOffset();
		}

		// Token: 0x0602585B RID: 153691 RVA: 0x00A916FC File Offset: 0x00A8F8FC
		private bool IsInListenerAdsorbedDistance(Vector2D tempVector2D, TsUiNavigationBehaviorListener listener)
		{
			UUIItem uuiitem = listener.RootUIComp.Get();
			bool bIsScaledByDPI = true;
			FVector2D adsorbedPivot = listener.AdsorbedPivot;
			FVector2D positionInViewportWithPivot = uuiitem.GetPositionInViewportWithPivot(bIsScaledByDPI, adsorbedPivot);
			FVector2D fvector2D = this.ConvertViewportToLguiCanvas((double)positionInViewportWithPivot.X, (double)positionInViewportWithPivot.Y);
			this.TempListenerPosition.Set((double)positionInViewportWithPivot.X, (double)positionInViewportWithPivot.Y);
			Vector2D vector2D = new Vector2D((double)fvector2D.X, (double)fvector2D.Y);
			return Math.Abs(vector2D.X - tempVector2D.X) <= (double)listener.AdsorbedDistance && Math.Abs(vector2D.Y - tempVector2D.Y) <= (double)listener.AdsorbedDistance && Vector2D.Distance(vector2D, tempVector2D) <= (double)listener.AdsorbedDistance;
		}

		// Token: 0x0602585C RID: 153692 RVA: 0x00A917B8 File Offset: 0x00A8F9B8
		[NullableContext(2)]
		private TsUiNavigationBehaviorListener GetFirstCanAdsorbedListener(FVector2D temp)
		{
			Vector2D tempVector2D = new Vector2D((double)temp.X, (double)temp.Y);
			foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig in this.ViewHandle.GetPanelConfigMap().Values)
			{
				foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in tsUiNavigationPanelConfig.GetPanelHandle().GetListenerSet())
				{
					if (tsUiNavigationBehaviorListener.OpenAdsorbed && tsUiNavigationBehaviorListener.IsCanFocus() && tsUiNavigationBehaviorListener.IsInLoopScrollDisplayByGridActor() && tsUiNavigationBehaviorListener.IsInDynScrollDisplay() && this.IsInListenerAdsorbedDistance(tempVector2D, tsUiNavigationBehaviorListener))
					{
						return tsUiNavigationBehaviorListener;
					}
				}
			}
			return null;
		}

		// Token: 0x0602585D RID: 153693 RVA: 0x00A91894 File Offset: 0x00A8FA94
		[NullableContext(2)]
		private bool IsHitListenerUseDrag(TsUiNavigationBehaviorListener listener)
		{
			if (listener == null || !listener.IsUseDrag)
			{
				return false;
			}
			using (OrderedDictionary<int, TsUiNavigationPanelConfig>.ValueCollection.Enumerator enumerator = this.ViewHandle.GetPanelConfigMap().Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetPanelHandle().GetListenerSet().Contains(listener))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602585E RID: 153694 RVA: 0x00A91910 File Offset: 0x00A8FB10
		private void CalculateAroundListener()
		{
			if (this.IsGamepadMoving)
			{
				return;
			}
			if (this.IsStopMoved)
			{
				return;
			}
			this.IsStopMoved = true;
			FVector2D temp = this.ConvertViewportToLguiCanvas(this.TempVector2D.X, this.TempVector2D.Y);
			TsUiNavigationBehaviorListener firstCanAdsorbedListener = this.GetFirstCanAdsorbedListener(temp);
			if (firstCanAdsorbedListener != this.AdsorbedListener)
			{
				this.AdsorbedListener = firstCanAdsorbedListener;
				this.ViewHandle.MarkRefreshHotKeyDirty();
			}
			if (this.AdsorbedListener == null)
			{
				return;
			}
			this.KillPosTweener();
			this.PosTweener = ULTweenBPLibrary.Vector2To(GlobalData.World, this.Delegate, this.TempVector2D.ToUeVector2D(false), this.TempListenerPosition.ToUeVector2D(false), 0.3f, 0f, LTweenEase.OutCubic);
		}

		// Token: 0x0602585F RID: 153695 RVA: 0x00A919C0 File Offset: 0x00A8FBC0
		private unsafe void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			bool flag = Info.Instance.IsInGamepad();
			TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
			if (lguiEventSystemActor != null)
			{
				lguiEventSystemActor.SetIsOverrideMousePosition(flag);
			}
			this.GamepadItem.SetAlpha(flag > false);
			this.UpdateMousePositionByEventData();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "UiNavigation:GamepadControlMouse 输入类型方式变化";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("是否开启", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前操作类型", Info.Instance.InputControllerType);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06025860 RID: 153696 RVA: 0x00A91A6D File Offset: 0x00A8FC6D
		public void MoveForwardByGamepad(float value)
		{
			this.GamepadMoveForwardValue = value * 20f * this.CanvasScaleFactor;
		}

		// Token: 0x06025861 RID: 153697 RVA: 0x00A91A83 File Offset: 0x00A8FC83
		public void MoveRightByGamepad(float value)
		{
			this.GamepadMoveRightValue = value * 20f * this.CanvasScaleFactor;
		}

		// Token: 0x06025862 RID: 153698 RVA: 0x00A91A9C File Offset: 0x00A8FC9C
		public void TriggerByGamepad(bool isPress)
		{
			if (isPress)
			{
				this.SequencePlayer.StopSequenceByKey("Release", false, false);
				this.SequencePlayer.PlaySequencePurely("Press", false, false, null, null, false);
				return;
			}
			this.SequencePlayer.StopSequenceByKey("Press", false, false);
			this.SequencePlayer.PlaySequencePurely("Release", false, false, null, null, false);
		}

		// Token: 0x06025863 RID: 153699 RVA: 0x00A91B0C File Offset: 0x00A8FD0C
		public unsafe void CanOverridePosition(bool value)
		{
			bool flag = value && Info.Instance.IsInGamepad();
			TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
			if (lguiEventSystemActor != null)
			{
				lguiEventSystemActor.SetIsOverrideMousePosition(flag);
			}
			this.GamepadItem.SetAlpha(flag > false);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "UiNavigation:GamepadControlMouse 手柄控制鼠标功能";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("是否开启", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前操作类型", Info.Instance.InputControllerType);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (this.IsAddEvent == value)
			{
				return;
			}
			this.IsAddEvent = value;
			if (value)
			{
				this.InitMousePosition();
				EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
				return;
			}
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x06025864 RID: 153700 RVA: 0x00A91C0C File Offset: 0x00A8FE0C
		public void UpdateMousePositionByItem(UUIItem uiItem)
		{
			bool bIsScaledByDPI = true;
			FVector2D fvector2D = new FVector2D(0.5f, 0.5f);
			FVector2D positionInViewportWithPivot = uiItem.GetPositionInViewportWithPivot(bIsScaledByDPI, fvector2D);
			this.TempVector2D.Set((double)positionInViewportWithPivot.X, (double)positionInViewportWithPivot.Y);
			this.KillPosTweener();
			this.SetGamepadOffset();
			TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
			if (lguiEventSystemActor == null)
			{
				return;
			}
			lguiEventSystemActor.SwitchToNavigationInputType();
		}

		// Token: 0x06025865 RID: 153701 RVA: 0x00A91C6C File Offset: 0x00A8FE6C
		public void UpdateMousePositionForGuide(UUIItem uiItem)
		{
			AActor owner = uiItem.GetOwner();
			this.GuideUiListener = (((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null) as TsUiNavigationBehaviorListener);
			this.UpdateMousePositionByItem(uiItem);
			this.ViewHandle.MarkRefreshHotKeyDirty();
		}

		// Token: 0x06025866 RID: 153702 RVA: 0x00A91CA7 File Offset: 0x00A8FEA7
		public void ResetNavigationFocusForGuide()
		{
			this.GuideUiListener = null;
		}

		// Token: 0x06025867 RID: 153703 RVA: 0x00A91CB0 File Offset: 0x00A8FEB0
		public bool IsNearlyListenerUseDrag()
		{
			return !this.LockUseDrag && this.IsHitListenerUseDrag(this.HitListener);
		}

		// Token: 0x06025868 RID: 153704 RVA: 0x00A91CCD File Offset: 0x00A8FECD
		public void SetLockUseDragState(bool value)
		{
			this.LockUseDrag = value;
		}

		// Token: 0x06025869 RID: 153705 RVA: 0x00A91CD6 File Offset: 0x00A8FED6
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener GetHitComponentListener()
		{
			return this.HitListener;
		}

		// Token: 0x0602586A RID: 153706 RVA: 0x00A91CDE File Offset: 0x00A8FEDE
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener GetGuideUiListener()
		{
			return this.GuideUiListener;
		}

		// Token: 0x0602586B RID: 153707 RVA: 0x00A91CE6 File Offset: 0x00A8FEE6
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener GetAdsorbedListener()
		{
			return this.AdsorbedListener;
		}

		// Token: 0x0602586C RID: 153708 RVA: 0x00A91CEE File Offset: 0x00A8FEEE
		public void NotifyNavigationMousePositionDragState(bool state)
		{
			if (this.IsDragging != state)
			{
				this.ViewHandle.MarkRefreshHotKeyDirty();
			}
			this.IsDragging = state;
		}

		// Token: 0x0602586D RID: 153709 RVA: 0x00A91D0B File Offset: 0x00A8FF0B
		public bool IsNavigationMousePositionDragging()
		{
			return this.IsDragging;
		}

		// Token: 0x0602586E RID: 153710 RVA: 0x00A91D13 File Offset: 0x00A8FF13
		public Vector2D GetMouseViewportPosition()
		{
			this.ViewportPosition.FromUeVector2D(this.GamepadItem.GetPositionInViewPort(true));
			return this.ViewportPosition;
		}

		// Token: 0x0602586F RID: 153711 RVA: 0x00A91D37 File Offset: 0x00A8FF37
		public void Clear()
		{
			this.CanOverridePosition(false);
			this.KillPosTweener();
			this.SequencePlayer.Clear();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnTweenUpdate));
		}

		// Token: 0x06025870 RID: 153712 RVA: 0x00A91D62 File Offset: 0x00A8FF62
		public void Tick(float deltaTime)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			if (UiNavigationGlobalData.IsBlockNavigation)
			{
				return;
			}
			this.CalculateGamepadMoveDistance(deltaTime);
			this.UpdateMousePosition();
			this.CalculateAroundListener();
			this.CalculateHitListener();
		}

		// Token: 0x04014BD5 RID: 84949
		private const int MOVE_SPEED_INTERVAL = 20;

		// Token: 0x04014BD6 RID: 84950
		private const float TWEEN_TIME = 0.3f;

		// Token: 0x04014BD7 RID: 84951
		private const int BASE_FPS = 60;

		// Token: 0x04014BD8 RID: 84952
		[Nullable(2)]
		private Vector2D InternalTempVector2D;

		// Token: 0x04014BD9 RID: 84953
		[Nullable(2)]
		private readonly ULGUIPointerEventData EventData;

		// Token: 0x04014BDA RID: 84954
		[Nullable(2)]
		private readonly ULGUICanvasScaler Canvas;

		// Token: 0x04014BDB RID: 84955
		[Nullable(2)]
		private readonly UUIItem GamepadItem;

		// Token: 0x04014BDC RID: 84956
		private readonly float HalfWidth;

		// Token: 0x04014BDD RID: 84957
		private readonly float HalfHeight;

		// Token: 0x04014BDE RID: 84958
		private readonly float ViewPortWidth;

		// Token: 0x04014BDF RID: 84959
		private readonly float ViewPortHeight;

		// Token: 0x04014BE0 RID: 84960
		private float GamepadMoveForwardValue;

		// Token: 0x04014BE1 RID: 84961
		private float GamepadMoveRightValue;

		// Token: 0x04014BE2 RID: 84962
		private bool IsStopMoved;

		// Token: 0x04014BE3 RID: 84963
		private bool IsAddEvent;

		// Token: 0x04014BE4 RID: 84964
		private readonly UiNavigationViewHandle ViewHandle;

		// Token: 0x04014BE5 RID: 84965
		private readonly LevelSequencePlayer SequencePlayer;

		// Token: 0x04014BE6 RID: 84966
		private readonly float CanvasScaleFactor = 1f;

		// Token: 0x04014BE7 RID: 84967
		[Nullable(2)]
		protected TsUiNavigationBehaviorListener AdsorbedListener;

		// Token: 0x04014BE8 RID: 84968
		[Nullable(2)]
		protected TsUiNavigationBehaviorListener HitListener;

		// Token: 0x04014BE9 RID: 84969
		[Nullable(2)]
		protected TsUiNavigationBehaviorListener GuideUiListener;

		// Token: 0x04014BEA RID: 84970
		protected bool IsDragging;

		// Token: 0x04014BEB RID: 84971
		protected Vector2D ViewportPosition = new Vector2D();

		// Token: 0x04014BEC RID: 84972
		protected bool LockUseDrag;

		// Token: 0x04014BED RID: 84973
		private readonly Vector2D TempListenerPosition = new Vector2D();

		// Token: 0x04014BEE RID: 84974
		[Nullable(2)]
		private ULTweener PosTweener;

		// Token: 0x04014BEF RID: 84975
		private readonly FLTweenVector2SetterDynamic Delegate;

		// Token: 0x04014BF0 RID: 84976
		private readonly Vector2D TempTweenPosition = new Vector2D();
	}
}
