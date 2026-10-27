using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048EE RID: 18670
	[NullableContext(1)]
	[Nullable(0)]
	public class GamepadControlMouse
	{
		// Token: 0x170079A1 RID: 31137
		// (get) Token: 0x06030D21 RID: 199969 RVA: 0x00B561AC File Offset: 0x00B543AC
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

		// Token: 0x170079A2 RID: 31138
		// (get) Token: 0x06030D22 RID: 199970 RVA: 0x00B561EC File Offset: 0x00B543EC
		private bool IsGamepadMoving
		{
			get
			{
				return this.GamepadMoveForwardValue != 0f || this.GamepadMoveRightValue != 0f;
			}
		}

		// Token: 0x06030D23 RID: 199971 RVA: 0x00B56210 File Offset: 0x00B54410
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

		// Token: 0x06030D24 RID: 199972 RVA: 0x00B5633C File Offset: 0x00B5453C
		private Vector2D GetTempVectorInLgui()
		{
			if (this.Canvas == null)
			{
				return this.TempVector2D;
			}
			FVector2D fvector2D = this.ConvertViewportToLguiCanvas(this.TempVector2D.X, this.TempVector2D.Y);
			return new Vector2D((double)(fvector2D.X - this.HalfWidth), (double)(fvector2D.Y - this.HalfHeight));
		}

		// Token: 0x06030D25 RID: 199973 RVA: 0x00B56398 File Offset: 0x00B54598
		private FVector2D ConvertViewportToLguiCanvas(double viewportX, double viewportY)
		{
			FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
			float num = (viewportSize.X > this.ViewPortWidth) ? ((viewportSize.X - this.ViewPortWidth) / 2f) : 0f;
			float num2 = (viewportSize.Y > this.ViewPortHeight) ? ((viewportSize.Y - this.ViewPortHeight) / 2f) : 0f;
			ULGUICanvasScaler canvas = this.Canvas;
			FVector2D fvector2D = new FVector2D((float)(viewportX - (double)num), (float)(viewportY - (double)num2));
			return canvas.ConvertPositionFromViewportToLGUICanvas(fvector2D);
		}

		// Token: 0x06030D26 RID: 199974 RVA: 0x00B56420 File Offset: 0x00B54620
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

		// Token: 0x06030D27 RID: 199975 RVA: 0x00B5663C File Offset: 0x00B5483C
		private void InitMousePosition()
		{
			FVector2D positionInViewPort = this.GamepadItem.GetPositionInViewPort(true);
			this.EventData.pointerPosition = new FVector(positionInViewPort.X, positionInViewPort.Y, 0f);
		}

		// Token: 0x06030D28 RID: 199976 RVA: 0x00B56678 File Offset: 0x00B54878
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

		// Token: 0x06030D29 RID: 199977 RVA: 0x00B5672A File Offset: 0x00B5492A
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

		// Token: 0x06030D2A RID: 199978 RVA: 0x00B5675C File Offset: 0x00B5495C
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

		// Token: 0x06030D2B RID: 199979 RVA: 0x00B567C0 File Offset: 0x00B549C0
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

		// Token: 0x06030D2C RID: 199980 RVA: 0x00B5681F File Offset: 0x00B54A1F
		private void KillPosTweener()
		{
			if (this.PosTweener != null)
			{
				this.PosTweener.Kill(false);
				this.PosTweener = null;
			}
		}

		// Token: 0x06030D2D RID: 199981 RVA: 0x00B5683C File Offset: 0x00B54A3C
		private void OnTweenUpdate(FVector2D targetPos)
		{
			this.TempTweenPosition.Set((double)targetPos.X, (double)targetPos.Y);
			this.TempVector2D.Set(this.TempTweenPosition.X, this.TempTweenPosition.Y);
			this.SetGamepadOffset();
		}

		// Token: 0x06030D2E RID: 199982 RVA: 0x00B5688C File Offset: 0x00B54A8C
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

		// Token: 0x06030D2F RID: 199983 RVA: 0x00B56948 File Offset: 0x00B54B48
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

		// Token: 0x06030D30 RID: 199984 RVA: 0x00B56A24 File Offset: 0x00B54C24
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

		// Token: 0x06030D31 RID: 199985 RVA: 0x00B56AA0 File Offset: 0x00B54CA0
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

		// Token: 0x06030D32 RID: 199986 RVA: 0x00B56B50 File Offset: 0x00B54D50
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

		// Token: 0x06030D33 RID: 199987 RVA: 0x00B56BFD File Offset: 0x00B54DFD
		public void MoveForwardByGamepad(float value)
		{
			this.GamepadMoveForwardValue = value * 20f * this.CanvasScaleFactor;
		}

		// Token: 0x06030D34 RID: 199988 RVA: 0x00B56C13 File Offset: 0x00B54E13
		public void MoveRightByGamepad(float value)
		{
			this.GamepadMoveRightValue = value * 20f * this.CanvasScaleFactor;
		}

		// Token: 0x06030D35 RID: 199989 RVA: 0x00B56C2C File Offset: 0x00B54E2C
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

		// Token: 0x06030D36 RID: 199990 RVA: 0x00B56C9C File Offset: 0x00B54E9C
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

		// Token: 0x06030D37 RID: 199991 RVA: 0x00B56D9C File Offset: 0x00B54F9C
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

		// Token: 0x06030D38 RID: 199992 RVA: 0x00B56DFC File Offset: 0x00B54FFC
		public void UpdateMousePositionForGuide(UUIItem uiItem)
		{
			AActor owner = uiItem.GetOwner();
			this.GuideUiListener = (((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null) as TsUiNavigationBehaviorListener);
			this.UpdateMousePositionByItem(uiItem);
			this.ViewHandle.MarkRefreshHotKeyDirty();
		}

		// Token: 0x06030D39 RID: 199993 RVA: 0x00B56E37 File Offset: 0x00B55037
		public void ResetNavigationFocusForGuide()
		{
			this.GuideUiListener = null;
		}

		// Token: 0x06030D3A RID: 199994 RVA: 0x00B56E40 File Offset: 0x00B55040
		public bool IsNearlyListenerUseDrag()
		{
			return !this.LockUseDrag && this.IsHitListenerUseDrag(this.HitListener);
		}

		// Token: 0x06030D3B RID: 199995 RVA: 0x00B56E5D File Offset: 0x00B5505D
		public void SetLockUseDragState(bool value)
		{
			this.LockUseDrag = value;
		}

		// Token: 0x06030D3C RID: 199996 RVA: 0x00B56E66 File Offset: 0x00B55066
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener GetHitComponentListener()
		{
			return this.HitListener;
		}

		// Token: 0x06030D3D RID: 199997 RVA: 0x00B56E6E File Offset: 0x00B5506E
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener GetGuideUiListener()
		{
			return this.GuideUiListener;
		}

		// Token: 0x06030D3E RID: 199998 RVA: 0x00B56E76 File Offset: 0x00B55076
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener GetAdsorbedListener()
		{
			return this.AdsorbedListener;
		}

		// Token: 0x06030D3F RID: 199999 RVA: 0x00B56E7E File Offset: 0x00B5507E
		public void NotifyNavigationMousePositionDragState(bool state)
		{
			if (this.IsDragging != state)
			{
				this.ViewHandle.MarkRefreshHotKeyDirty();
			}
			this.IsDragging = state;
		}

		// Token: 0x06030D40 RID: 200000 RVA: 0x00B56E9B File Offset: 0x00B5509B
		public bool IsNavigationMousePositionDragging()
		{
			return this.IsDragging;
		}

		// Token: 0x06030D41 RID: 200001 RVA: 0x00B56EA3 File Offset: 0x00B550A3
		public Vector2D GetMouseViewportPosition()
		{
			this.ViewportPosition.FromUeVector2D(this.GamepadItem.GetPositionInViewPort(true));
			return this.ViewportPosition;
		}

		// Token: 0x06030D42 RID: 200002 RVA: 0x00B56EC7 File Offset: 0x00B550C7
		public void Clear()
		{
			this.CanOverridePosition(false);
			this.KillPosTweener();
			this.SequencePlayer.Clear();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnTweenUpdate));
		}

		// Token: 0x06030D43 RID: 200003 RVA: 0x00B56EF2 File Offset: 0x00B550F2
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

		// Token: 0x0401A362 RID: 107362
		private const int MOVE_SPEED_INTERVAL = 20;

		// Token: 0x0401A363 RID: 107363
		private const float TWEEN_TIME = 0.3f;

		// Token: 0x0401A364 RID: 107364
		private const int BASE_FPS = 60;

		// Token: 0x0401A365 RID: 107365
		[Nullable(2)]
		private Vector2D InternalTempVector2D;

		// Token: 0x0401A366 RID: 107366
		[Nullable(2)]
		private readonly ULGUIPointerEventData EventData;

		// Token: 0x0401A367 RID: 107367
		[Nullable(2)]
		private readonly ULGUICanvasScaler Canvas;

		// Token: 0x0401A368 RID: 107368
		[Nullable(2)]
		private readonly UUIItem GamepadItem;

		// Token: 0x0401A369 RID: 107369
		private readonly float HalfWidth;

		// Token: 0x0401A36A RID: 107370
		private readonly float HalfHeight;

		// Token: 0x0401A36B RID: 107371
		private readonly float ViewPortWidth;

		// Token: 0x0401A36C RID: 107372
		private readonly float ViewPortHeight;

		// Token: 0x0401A36D RID: 107373
		private float GamepadMoveForwardValue;

		// Token: 0x0401A36E RID: 107374
		private float GamepadMoveRightValue;

		// Token: 0x0401A36F RID: 107375
		private bool IsStopMoved;

		// Token: 0x0401A370 RID: 107376
		private bool IsAddEvent;

		// Token: 0x0401A371 RID: 107377
		private readonly UiNavigationViewHandle ViewHandle;

		// Token: 0x0401A372 RID: 107378
		private readonly LevelSequencePlayer SequencePlayer;

		// Token: 0x0401A373 RID: 107379
		private readonly float CanvasScaleFactor = 1f;

		// Token: 0x0401A374 RID: 107380
		[Nullable(2)]
		protected TsUiNavigationBehaviorListener AdsorbedListener;

		// Token: 0x0401A375 RID: 107381
		[Nullable(2)]
		protected TsUiNavigationBehaviorListener HitListener;

		// Token: 0x0401A376 RID: 107382
		[Nullable(2)]
		protected TsUiNavigationBehaviorListener GuideUiListener;

		// Token: 0x0401A377 RID: 107383
		protected bool IsDragging;

		// Token: 0x0401A378 RID: 107384
		protected Vector2D ViewportPosition = new Vector2D();

		// Token: 0x0401A379 RID: 107385
		protected bool LockUseDrag;

		// Token: 0x0401A37A RID: 107386
		private readonly Vector2D TempListenerPosition = new Vector2D();

		// Token: 0x0401A37B RID: 107387
		[Nullable(2)]
		private ULTweener PosTweener;

		// Token: 0x0401A37C RID: 107388
		private readonly FLTweenVector2SetterDynamic Delegate;

		// Token: 0x0401A37D RID: 107389
		private readonly Vector2D TempTweenPosition = new Vector2D();
	}
}
