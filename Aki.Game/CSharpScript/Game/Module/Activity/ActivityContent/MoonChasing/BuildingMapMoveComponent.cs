using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x020053F4 RID: 21492
	[NullableContext(1)]
	[Nullable(0)]
	public class BuildingMapMoveComponent
	{
		// Token: 0x170067FF RID: 26623
		// (get) Token: 0x06035699 RID: 218777 RVA: 0x00EEAEBC File Offset: 0x00EE90BC
		// (set) Token: 0x0603569A RID: 218778 RVA: 0x00EEAEC4 File Offset: 0x00EE90C4
		public double MapScale
		{
			get
			{
				return this.MapScaleInternal;
			}
			set
			{
				this.MapScaleInternal = value;
			}
		}

		// Token: 0x17006800 RID: 26624
		// (get) Token: 0x0603569B RID: 218779 RVA: 0x00EEAECD File Offset: 0x00EE90CD
		public bool IsInDrag
		{
			get
			{
				return this.IsDragging;
			}
		}

		// Token: 0x0603569C RID: 218780 RVA: 0x00EEAED8 File Offset: 0x00EE90D8
		public BuildingMapMoveComponent(UUIDraggableComponent draggable, bool bindDrag = true, bool bindScroll = true, bool bindEndDrag = false)
		{
			this.MapItem = draggable.GetRootComponent();
			if (bindDrag)
			{
				draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
				if (bindEndDrag)
				{
					draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
				}
				else
				{
					draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
					draggable.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
				}
				draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
				draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
			}
			if (bindScroll)
			{
				draggable.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScrollCallback));
			}
			this.InitData();
		}

		// Token: 0x0603569D RID: 218781 RVA: 0x00EEB141 File Offset: 0x00EE9341
		private void InitData()
		{
			this.InitPosTweener();
			this.InitScaleTweener();
			this.InitViewportSize();
			this.InitScaleSafeArea();
			this.UpdateMoveDangerousArea();
			this.UpdateMoveSafeArea();
		}

		// Token: 0x0603569E RID: 218782 RVA: 0x00EEB167 File Offset: 0x00EE9367
		private void InitPosTweener()
		{
			this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenVector2SetterDynamic>(new Action<FVector2D>(this.OnTweenUpdate));
		}

		// Token: 0x0603569F RID: 218783 RVA: 0x00EEB180 File Offset: 0x00EE9380
		private void InitScaleTweener()
		{
			this.ScaleDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenVector3SetterDynamic>(new Action<FVector>(this.OnScaleTweenUpdate));
		}

		// Token: 0x060356A0 RID: 218784 RVA: 0x00EEB19C File Offset: 0x00EE939C
		private unsafe void InitViewportSize()
		{
			this.ViewportSize.X = (double)UiLayer.Instance.UiRootItem.GetWidth();
			this.ViewportSize.Y = (double)UiLayer.Instance.UiRootItem.GetHeight();
			ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			float num = canvasScaler.ReferenceResolution.X / canvasScaler.ReferenceResolution.Y;
			double num2 = this.ViewportSize.X / this.ViewportSize.Y;
			double num3 = num2 / (double)num;
			this.SizeInterval = ((num3 > 1.0) ? num3 : ((double)num / num2));
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MoonChasing;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[MapMoveComponent]初始化Viewport";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Viewport大小", this.ViewportSize);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ReferenceResolution大小", canvasScaler.ReferenceResolution);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Viewport与ReferenceResolution比值", num3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("实际应用的比值", this.SizeInterval);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x060356A1 RID: 218785 RVA: 0x00EEB2E4 File Offset: 0x00EE94E4
		protected virtual void UpdateMoveDangerousArea()
		{
			double num = (double)this.MapItem.GetWidth() * this.MapScaleInternal;
			double num2 = (double)this.MapItem.GetHeight() * this.MapScaleInternal;
			num = ((num < this.ViewportSize.X) ? this.ViewportSize.X : num);
			num2 = ((num2 < this.ViewportSize.Y) ? this.ViewportSize.Y : num2);
			double num3 = Math.Abs(num - this.ViewportSize.X) / 2.0;
			double num4 = Math.Abs(num2 - this.ViewportSize.Y) / 2.0;
			this.MoveDangerousArea.MinX = -num3;
			this.MoveDangerousArea.MaxX = num3;
			this.MoveDangerousArea.MinY = -num4;
			this.MoveDangerousArea.MaxY = num4;
		}

		// Token: 0x060356A2 RID: 218786 RVA: 0x00EEB3C0 File Offset: 0x00EE95C0
		protected virtual void UpdateMoveSafeArea()
		{
			double num = (double)this.MapItem.GetWidth() * this.MapScaleInternal - this.MapMoveRebound.X * 2.0;
			double num2 = (double)this.MapItem.GetHeight() * this.MapScaleInternal - this.MapMoveRebound.Y * 2.0;
			num = ((num < this.ViewportSize.X) ? this.ViewportSize.X : num);
			num2 = ((num2 < this.ViewportSize.Y) ? this.ViewportSize.Y : num2);
			double num3 = Math.Abs(num - this.ViewportSize.X) / 2.0;
			double num4 = Math.Abs(num2 - this.ViewportSize.Y) / 2.0;
			this.MoveSafeArea.MinX = -num3;
			this.MoveSafeArea.MaxX = num3;
			this.MoveSafeArea.MinY = -num4;
			this.MoveSafeArea.MaxY = num4;
		}

		// Token: 0x060356A3 RID: 218787 RVA: 0x00EEB4C8 File Offset: 0x00EE96C8
		private void InitScaleSafeArea()
		{
			this.SetScaleSafeArea(0.5, 2.0);
			this.MapMoveRebound.X = 400.0;
			this.MapMoveRebound.Y = 300.0;
		}

		// Token: 0x060356A4 RID: 218788 RVA: 0x00EEB518 File Offset: 0x00EE9718
		private void ClampByMoveSafeArea(Vector2D vector2D)
		{
			vector2D.X = MathUtils.Instance.Clamp(vector2D.X, this.MoveSafeArea.MinX, this.MoveSafeArea.MaxX);
			vector2D.Y = MathUtils.Instance.Clamp(vector2D.Y, this.MoveSafeArea.MinY, this.MoveSafeArea.MaxY);
		}

		// Token: 0x060356A5 RID: 218789 RVA: 0x00EEB580 File Offset: 0x00EE9780
		private void ClampByMoveDangerousArea(Vector2D vector2D)
		{
			vector2D.X = MathUtils.Instance.Clamp(vector2D.X, this.MoveDangerousArea.MinX, this.MoveDangerousArea.MaxX);
			vector2D.Y = MathUtils.Instance.Clamp(vector2D.Y, this.MoveDangerousArea.MinY, this.MoveDangerousArea.MaxY);
		}

		// Token: 0x060356A6 RID: 218790 RVA: 0x00EEB5E8 File Offset: 0x00EE97E8
		[NullableContext(2)]
		public void SetScale(double scale, ESetScaleSource source, Vector2D targetPos = null)
		{
			double num = MathUtils.Instance.Clamp(scale, this.MapScaleSafeArea.Min, this.MapScaleSafeArea.Max);
			if (num == this.MapScaleInternal && source != ESetScaleSource.Tween)
			{
				return;
			}
			this.KillPosTweener();
			double mapScaleInternal = this.MapScaleInternal;
			this.MapScaleInternal = num;
			this.UpdateMoveDangerousArea();
			this.UpdateMoveSafeArea();
			this.TempVector.Set(num, num, num);
			UUIItem mapItem = this.MapItem;
			FVector fvector = this.TempVector.ToUeVectorOld();
			mapItem.SetUIRelativeScale3D(fvector);
			Vector2D realPosition = this.GetRealPosition(num, mapScaleInternal, source, targetPos);
			this.TempVector2D.Reset();
			this.TempVector2D.AdditionEqual(realPosition);
			this.MoveToTargetPos(this.TempVector2D, EClampType.ClampToSafeArea);
			Action<ESetScaleSource> changeScaleCallback = this.ChangeScaleCallback;
			if (changeScaleCallback == null)
			{
				return;
			}
			changeScaleCallback(source);
		}

		// Token: 0x060356A7 RID: 218791 RVA: 0x00EEB6B0 File Offset: 0x00EE98B0
		private Vector2D GetRealPosition(double newScale, double oldScale, ESetScaleSource source, [Nullable(2)] Vector2D targetPos = null)
		{
			Vector2D vector2D = Vector2D.Create(this.MapItem.GetAnchorOffset());
			if (source <= ESetScaleSource.MultiTouch)
			{
				Vector2D mousePosConverToLgui = this.GetMousePosConverToLgui(this.InteractCenterPoint.X, this.InteractCenterPoint.Y);
				mousePosConverToLgui.Set(mousePosConverToLgui.X - this.ViewportSize.X / 2.0, mousePosConverToLgui.Y - this.ViewportSize.Y / 2.0);
				return vector2D.SubtractionEqual(mousePosConverToLgui).MultiplyEqual(newScale / oldScale).AdditionEqual(mousePosConverToLgui);
			}
			if (source != ESetScaleSource.Tween)
			{
				return vector2D.MultiplyEqual(newScale / oldScale);
			}
			if (targetPos != null)
			{
				return targetPos.MultiplyEqual(-1.0).MultiplyEqual(this.MapScale);
			}
			return vector2D.MultiplyEqual(newScale / oldScale);
		}

		// Token: 0x060356A8 RID: 218792 RVA: 0x00EEB784 File Offset: 0x00EE9984
		private Vector2D GetMousePosConverToLgui(double mousePosX, double mousePosY)
		{
			Vector2D mousePosInLgui = this.GetMousePosInLgui(mousePosX, mousePosY);
			mousePosInLgui.X = MathCommon.Clamp(mousePosInLgui.X, 0.0, this.ViewportSize.X);
			mousePosInLgui.Y = MathCommon.Clamp(mousePosInLgui.Y, 0.0, this.ViewportSize.Y);
			return mousePosInLgui;
		}

		// Token: 0x060356A9 RID: 218793 RVA: 0x00EEB7E4 File Offset: 0x00EE99E4
		private Vector2D GetMousePosInLgui(double mousePosX, double mousePosY)
		{
			ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			if (canvasScaler == null)
			{
				return Vector2D.Create();
			}
			Vector2D vector2D = Vector2D.Create(mousePosX, mousePosY);
			ULGUICanvasScaler ulguicanvasScaler = canvasScaler;
			FVector2D fvector2D = vector2D.ToUeVector2D(false);
			FVector2D fvector2D2 = ulguicanvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
			vector2D.FromUeVector2D(fvector2D2);
			return vector2D;
		}

		// Token: 0x060356AA RID: 218794 RVA: 0x00EEB830 File Offset: 0x00EE9A30
		[NullableContext(2)]
		private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			if (this.IsInMultiTouch)
			{
				return;
			}
			this.KillPosTweener();
			this.IsDragging = true;
			FVector pointerPosition = eventData.pointerPosition;
			Vector2D mousePosConverToLgui = this.GetMousePosConverToLgui((double)pointerPosition.X, (double)pointerPosition.Y);
			this.LastDragPos.DeepCopy(mousePosConverToLgui);
			Action<ULGUIPointerEventData> pointerBeginDragExtraCallBack = this.PointerBeginDragExtraCallBack;
			if (pointerBeginDragExtraCallBack == null)
			{
				return;
			}
			pointerBeginDragExtraCallBack(eventData);
		}

		// Token: 0x060356AB RID: 218795 RVA: 0x00EEB88C File Offset: 0x00EE9A8C
		[NullableContext(2)]
		private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			if (this.IsInMultiTouch)
			{
				this.IsDragging = false;
				this.PointerDeltaPos.Reset();
				return;
			}
			this.IsDragging = true;
			FVector pointerPosition = eventData.pointerPosition;
			Vector2D mousePosConverToLgui = this.GetMousePosConverToLgui((double)pointerPosition.X, (double)pointerPosition.Y);
			Vector2D vector2D = Vector2D.Create(mousePosConverToLgui.X, mousePosConverToLgui.Y).SubtractionEqual(this.LastDragPos);
			if (vector2D.X == 0.0 && vector2D.Y == 0.0)
			{
				return;
			}
			double num = mousePosConverToLgui.X - this.LastDragPos.X;
			double num2 = mousePosConverToLgui.Y - this.LastDragPos.Y;
			this.PointerDeltaPos.DeepCopy(vector2D);
			this.LastDragPos.DeepCopy(mousePosConverToLgui);
			this.TempVector2D.FromUeVector2D(this.MapItem.GetAnchorOffset());
			this.TempVector2D.X = this.TempVector2D.X + num;
			this.TempVector2D.Y = this.TempVector2D.Y + num2;
			this.MoveToTargetPos(this.TempVector2D, EClampType.ClampToDangerousArea);
		}

		// Token: 0x060356AC RID: 218796 RVA: 0x00EEB9AF File Offset: 0x00EE9BAF
		public void EmitPointerDown()
		{
			this.BeginPointerInteraction();
		}

		// Token: 0x060356AD RID: 218797 RVA: 0x00EEB9B7 File Offset: 0x00EE9BB7
		[NullableContext(2)]
		private void OnPointerDown(ULGUIPointerEventData eventData)
		{
			if (eventData == null || this.IsInMultiTouch || !this.CheckPointInScope(eventData.pointerPosition))
			{
				return;
			}
			this.BeginPointerInteraction();
		}

		// Token: 0x060356AE RID: 218798 RVA: 0x00EEB9DC File Offset: 0x00EE9BDC
		[NullableContext(2)]
		private void OnPointerUp(ULGUIPointerEventData eventData)
		{
			if (this.IsInMultiTouch)
			{
				this.IsDragging = false;
				this.PointerDeltaPos.Reset();
				return;
			}
			this.IsDragging = false;
			if (this.PointerDeltaPos.X == 0.0 && this.PointerDeltaPos.Y == 0.0)
			{
				return;
			}
			if (!this.CheckPointInScope(eventData.pointerPosition))
			{
				return;
			}
			this.HandleDragInertia();
			Action<ULGUIPointerEventData> pointerUpExtraCallBack = this.PointerUpExtraCallBack;
			if (pointerUpExtraCallBack == null)
			{
				return;
			}
			pointerUpExtraCallBack(eventData);
		}

		// Token: 0x060356AF RID: 218799 RVA: 0x00EEBA60 File Offset: 0x00EE9C60
		[NullableContext(2)]
		private void OnPointerScrollCallback(ULGUIPointerEventData eventData)
		{
			float scrollAxisValue = eventData.scrollAxisValue;
			if (scrollAxisValue == 0f)
			{
				return;
			}
			this.InteractCenterPoint.Reset();
			this.InteractCenterPoint.AdditionEqual(this.GetCursorPoint());
			double num = (double)scrollAxisValue * this.ScaleStep;
			this.SetScale(this.MapScaleInternal + num, ESetScaleSource.PointerScroll, null);
		}

		// Token: 0x060356B0 RID: 218800 RVA: 0x00EEBAB4 File Offset: 0x00EE9CB4
		private void OnTweenUpdate(FVector2D targetPos)
		{
			this.MapItem.SetAnchorOffset(targetPos);
			Action mapMovedCallback = this.MapMovedCallback;
			if (mapMovedCallback == null)
			{
				return;
			}
			mapMovedCallback();
		}

		// Token: 0x060356B1 RID: 218801 RVA: 0x00EEBAD2 File Offset: 0x00EE9CD2
		private void OnScaleTweenUpdate(FVector targetScale)
		{
			this.ScaleTempPos.Set((double)targetScale.Y, (double)targetScale.Z);
			this.SetScale((double)targetScale.X, ESetScaleSource.Tween, this.ScaleTempPos);
		}

		// Token: 0x060356B2 RID: 218802 RVA: 0x00EEBB04 File Offset: 0x00EE9D04
		private bool CheckPointInScope(FVector mousePos)
		{
			Vector2D mousePosInLgui = this.GetMousePosInLgui((double)mousePos.X, (double)mousePos.Y);
			return mousePosInLgui.X >= 0.0 && mousePosInLgui.X <= this.ViewportSize.X && mousePosInLgui.Y >= 0.0 && mousePosInLgui.Y <= this.ViewportSize.Y;
		}

		// Token: 0x060356B3 RID: 218803 RVA: 0x00EEBB73 File Offset: 0x00EE9D73
		private void BeginPointerInteraction()
		{
			this.IsDragging = false;
			this.PointerDownTime = Time.Instance.NowSeconds;
			this.PointerDeltaPos.Reset();
			this.KillPosTweener();
		}

		// Token: 0x060356B4 RID: 218804 RVA: 0x00EEBBA0 File Offset: 0x00EE9DA0
		private void HandleDragInertia()
		{
			double num = Time.Instance.NowSeconds - this.PointerDownTime;
			double num2 = this.PointerDeltaPos.Size() / num;
			if (!this.ViewportSize.IsNearlyZero(9.999999747378752E-05))
			{
				num2 = MathCommon.Clamp(num2, 0.0, this.ViewportSize.Size());
			}
			if (!this.PointerDeltaPos.Normalize(0.0))
			{
				this.PointerDeltaPos.Reset();
				return;
			}
			Vector2D vector2D = Vector2D.Create();
			this.PointerDeltaPos.Multiply(num2, vector2D);
			Vector2D vector2D2 = Vector2D.Create();
			vector2D.Multiply(2.0, vector2D2);
			Vector2D targetPos = Vector2D.Create(this.MapItem.GetAnchorOffset()).AdditionEqual(vector2D2);
			this.MoveToTargetPosWithTween(targetPos, LTweenEase.OutQuad, 0.800000011920929);
		}

		// Token: 0x060356B5 RID: 218805 RVA: 0x00EEBC7A File Offset: 0x00EE9E7A
		private void KillPosTweener()
		{
			if (this.PosTweener != null)
			{
				this.PosTweener.Kill(false);
				this.PosTweener = null;
				this.IsTweening = false;
			}
		}

		// Token: 0x060356B6 RID: 218806 RVA: 0x00EEBC9E File Offset: 0x00EE9E9E
		private void KillScaleTweener()
		{
			if (this.ScaleTweener != null)
			{
				this.ScaleTweener.Kill(false);
				this.ScaleTweener = null;
			}
		}

		// Token: 0x060356B7 RID: 218807 RVA: 0x00EEBCBC File Offset: 0x00EE9EBC
		private void MoveToTargetPosWithTween(Vector2D targetPos, LTweenEase tweenEase = LTweenEase.Linear, double tweenTime = 2.0)
		{
			this.ClampByMoveSafeArea(targetPos);
			this.IsTweening = true;
			this.KillPosTweener();
			this.PosTweener = ULTweenBPLibrary.Vector2To(GlobalData.World, this.Delegate, this.MapItem.GetAnchorOffset(), targetPos.ToUeVector2D(false), (float)tweenTime, 0f, tweenEase);
			this.PosTweener.OnCompleteCallBack.Bind(delegate()
			{
				this.IsTweening = false;
			});
		}

		// Token: 0x060356B8 RID: 218808 RVA: 0x00EEBD29 File Offset: 0x00EE9F29
		private void MoveToTargetPos(Vector2D targetPos, EClampType clampType = EClampType.ClampToSafeArea)
		{
			if (clampType == EClampType.ClampToSafeArea)
			{
				this.ClampByMoveSafeArea(targetPos);
			}
			else if (clampType == EClampType.ClampToDangerousArea)
			{
				this.ClampByMoveDangerousArea(targetPos);
			}
			this.MapItem.SetAnchorOffset(targetPos.ToUeVector2D(false));
			Action mapMovedCallback = this.MapMovedCallback;
			if (mapMovedCallback == null)
			{
				return;
			}
			mapMovedCallback();
		}

		// Token: 0x060356B9 RID: 218809 RVA: 0x00EEBD64 File Offset: 0x00EE9F64
		public void MoveToTarget(double[] offsetXY, LTweenEase tweenEase = LTweenEase.Linear, double tweenTime = 2.0, [Nullable(2)] Action callback = null)
		{
			this.TempVector2D.Reset();
			this.TempVector2D.X = -offsetXY[0] * this.MapScale;
			this.TempVector2D.Y = -offsetXY[1] * this.MapScale;
			if (tweenTime != 0.0)
			{
				this.MoveToTargetPosWithTween(this.TempVector2D, tweenEase, tweenTime);
				if (callback != null)
				{
					callback();
					return;
				}
			}
			else
			{
				this.MoveToTargetPos(this.TempVector2D, EClampType.ClampToSafeArea);
				if (callback != null)
				{
					callback();
				}
			}
		}

		// Token: 0x060356BA RID: 218810 RVA: 0x00EEBDE8 File Offset: 0x00EE9FE8
		public void ScaleToTarget(double scale, float[] offset, LTweenEase tweenEase = LTweenEase.Linear, float tweenTime = 2f, ETweenScaleType tweenScaleType = ETweenScaleType.Normal, [Nullable(2)] Action callback = null)
		{
			double targetScale = scale;
			if (tweenScaleType == ETweenScaleType.PreventOverScaling)
			{
				targetScale = ((this.MapScale > scale) ? this.MapScale : scale);
			}
			else if (tweenScaleType == ETweenScaleType.PreventUnderScaling)
			{
				targetScale = ((this.MapScale < scale) ? this.MapScale : scale);
			}
			if (tweenTime != 0f)
			{
				this.ScaleToTargetScaleWithTween(targetScale, offset, tweenEase, tweenTime);
				if (callback != null)
				{
					callback();
					return;
				}
			}
			else
			{
				this.ScaleTempPos.Set((double)offset[0], (double)offset[1]);
				this.SetScale(scale, ESetScaleSource.Tween, this.ScaleTempPos);
				if (callback != null)
				{
					callback();
				}
			}
		}

		// Token: 0x060356BB RID: 218811 RVA: 0x00EEBE78 File Offset: 0x00EEA078
		private void ScaleToTargetScaleWithTween(double targetScale, float[] offset, LTweenEase tweenEase = LTweenEase.Linear, float tweenTime = 2f)
		{
			this.IsTweening = true;
			this.KillScaleTweener();
			FVector2D anchorOffset = this.MapItem.GetAnchorOffset();
			this.ScaleTempStartVector.Set(this.MapScaleInternal, (double)(-(double)anchorOffset.X) / this.MapScaleInternal, (double)(-(double)anchorOffset.Y) / this.MapScaleInternal);
			this.ScaleTempEndVector.Set(targetScale, (double)offset[0], (double)offset[1]);
			this.ScaleTweener = ULTweenBPLibrary.Vector3To(GlobalData.World, this.ScaleDelegate, this.ScaleTempStartVector.ToUeVectorOld(), this.ScaleTempEndVector.ToUeVectorOld(), tweenTime, 0f, tweenEase);
			this.ScaleTweener.OnCompleteCallBack.Bind(delegate()
			{
				this.IsTweening = false;
			});
		}

		// Token: 0x060356BC RID: 218812 RVA: 0x00EEBF34 File Offset: 0x00EEA134
		private Vector2D GetCursorPoint()
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController != null)
			{
				this.TempVector2D.Reset();
				return this.TempVector2D.AdditionEqual(characterController.GetCursorPosition());
			}
			this.TempVector2D.Reset();
			return this.TempVector2D;
		}

		// Token: 0x060356BD RID: 218813 RVA: 0x00EEBF78 File Offset: 0x00EEA178
		private void OnGamepadMoveOverScreen(double overOffsetX, double overOffsetY)
		{
			this.TempVector2D.FromUeVector2D(this.MapItem.GetAnchorOffset());
			this.TempVector2D.X = this.TempVector2D.X - overOffsetX;
			this.TempVector2D.Y = this.TempVector2D.Y - overOffsetY;
			this.MoveToTargetPos(this.TempVector2D, EClampType.ClampToDangerousArea);
		}

		// Token: 0x060356BE RID: 218814 RVA: 0x00EEBFDD File Offset: 0x00EEA1DD
		public void LongPressScroll(float value)
		{
			this.InteractCenterPoint.Reset();
			this.SetScale(this.MapScaleInternal + (double)value, ESetScaleSource.LongPress, null);
		}

		// Token: 0x060356BF RID: 218815 RVA: 0x00EEBFFB File Offset: 0x00EEA1FB
		public void SliderScroll(float value)
		{
			this.SetScale((double)value, ESetScaleSource.Slider, null);
		}

		// Token: 0x060356C0 RID: 218816 RVA: 0x00EEC007 File Offset: 0x00EEA207
		public void SetChangeScaleCallback(Action<ESetScaleSource> callback)
		{
			this.ChangeScaleCallback = callback;
		}

		// Token: 0x060356C1 RID: 218817 RVA: 0x00EEC010 File Offset: 0x00EEA210
		public unsafe void SetScaleSafeArea(double min, double max)
		{
			if (min > max)
			{
				this.MapScaleSafeArea.Min = max * this.SizeInterval;
				this.MapScaleSafeArea.Max = min * this.SizeInterval;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MoonChasing;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[MapMoveComponent]按照分辨率比例设置真实大小";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("设置最小", max);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("设置最大", min);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("真实最小", this.MapScaleSafeArea.Min);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("真实最大", this.MapScaleSafeArea.Max);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return;
			}
			this.MapScaleSafeArea.Min = min * this.SizeInterval;
			this.MapScaleSafeArea.Max = max * this.SizeInterval;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.MoonChasing;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "[MapMoveComponent]按照分辨率比例设置真实大小";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("设置最小", min);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("设置最大", max);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("真实最小", this.MapScaleSafeArea.Min);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("真实最大", this.MapScaleSafeArea.Max);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
		}

		// Token: 0x060356C2 RID: 218818 RVA: 0x00EEC1CD File Offset: 0x00EEA3CD
		public void SetMapMoveRebound(float x, float y)
		{
			this.MapMoveRebound.X = (double)x;
			this.MapMoveRebound.Y = (double)y;
			this.UpdateMoveDangerousArea();
			this.UpdateMoveSafeArea();
		}

		// Token: 0x060356C3 RID: 218819 RVA: 0x00EEC1F5 File Offset: 0x00EEA3F5
		public void Destroy()
		{
			this.IsDragging = false;
			this.KillPosTweener();
			this.KillScaleTweener();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnTweenUpdate));
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector>(this.OnScaleTweenUpdate));
		}

		// Token: 0x060356C4 RID: 218820 RVA: 0x00EEC22C File Offset: 0x00EEA42C
		public void AddGamepadEvent()
		{
			EventSystem.Instance.Add<double, double>(EEventName.GamepadMoveOverScreen, new Action<double, double>(this.OnGamepadMoveOverScreen));
		}

		// Token: 0x060356C5 RID: 218821 RVA: 0x00EEC24A File Offset: 0x00EEA44A
		public void RemoveGamepadEvent()
		{
			EventSystem.Instance.Remove(EEventName.GamepadMoveOverScreen, new Action<double, double>(this.OnGamepadMoveOverScreen));
		}

		// Token: 0x17006801 RID: 26625
		// (get) Token: 0x060356C6 RID: 218822 RVA: 0x00EEC268 File Offset: 0x00EEA468
		public bool IsInTouch
		{
			get
			{
				return this.TouchMap.Count > 0;
			}
		}

		// Token: 0x17006802 RID: 26626
		// (get) Token: 0x060356C7 RID: 218823 RVA: 0x00EEC278 File Offset: 0x00EEA478
		public bool IsInMultiTouch
		{
			get
			{
				return this.TouchMap.Count > 1;
			}
		}

		// Token: 0x060356C8 RID: 218824 RVA: 0x00EEC288 File Offset: 0x00EEA488
		private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification inputIdentification)
		{
			InputDistributeDefine.ETouchType touchType = touchData.TouchType;
			if (touchType == InputDistributeDefine.ETouchType.TouchMove)
			{
				this.TouchChangeMapScale();
				return;
			}
			if (touchType == InputDistributeDefine.ETouchType.TouchBegin)
			{
				this.TouchTrigger(true, touchData);
				return;
			}
			this.TouchTrigger(false, touchData);
		}

		// Token: 0x060356C9 RID: 218825 RVA: 0x00EEC2BC File Offset: 0x00EEA4BC
		private void TouchTrigger(bool bTouchPress, InputDistributeDefine.ITouchData touchData)
		{
			int touchId = touchData.TouchId;
			if (bTouchPress)
			{
				if (LguiEventSystemManager.Instance.IsPressComponentIsValid(touchId))
				{
					this.TouchMap[touchId] = touchData;
				}
			}
			else
			{
				this.TouchMap.Remove(touchId);
			}
			this.InteractCenterPoint.Reset();
			foreach (InputDistributeDefine.ITouchData touchData2 in this.TouchMap.Values)
			{
				this.TempTouchVector2D.Set(touchData2.TouchPosition.X, touchData2.TouchPosition.Y);
				this.InteractCenterPoint.AdditionEqual(this.TempTouchVector2D);
			}
			if (this.TouchMap.Count > 0)
			{
				this.InteractCenterPoint.DivisionEqual((double)this.TouchMap.Count);
			}
		}

		// Token: 0x060356CA RID: 218826 RVA: 0x00EEC3A4 File Offset: 0x00EEA5A4
		private void TouchChangeMapScale()
		{
			if (!this.IsInMultiTouch)
			{
				return;
			}
			ValueTuple<EFingerExpandCloseType, float> fingerExpandCloseType = TouchFingerManager.Instance.GetFingerExpandCloseType(EFingerIndex.One, EFingerIndex.Two);
			EFingerExpandCloseType item = fingerExpandCloseType.Item1;
			float item2 = fingerExpandCloseType.Item2;
			if (item == EFingerExpandCloseType.None)
			{
				return;
			}
			this.SetScale(this.MapScaleInternal + (double)item2, ESetScaleSource.MultiTouch, null);
		}

		// Token: 0x060356CB RID: 218827 RVA: 0x00EEC3E8 File Offset: 0x00EEA5E8
		public void BindTouch()
		{
			InputDistributeController.Instance.BindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x060356CC RID: 218828 RVA: 0x00EEC40A File Offset: 0x00EEA60A
		public void UnbindTouch()
		{
			InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlyArray<int>(new int[]
			{
				0,
				1
			}), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x060356CD RID: 218829 RVA: 0x00EEC431 File Offset: 0x00EEA631
		public UUIItem GetMapItem()
		{
			return this.MapItem;
		}

		// Token: 0x060356CE RID: 218830 RVA: 0x00EEC439 File Offset: 0x00EEA639
		public void SwitchOnMove(bool bOn)
		{
			this.CanMove = bOn;
		}

		// Token: 0x060356CF RID: 218831 RVA: 0x00EEC442 File Offset: 0x00EEA642
		public void SwitchOnCheckMask(bool bOn)
		{
			this.CheckMask = bOn;
		}

		// Token: 0x060356D0 RID: 218832 RVA: 0x00EEC44C File Offset: 0x00EEA64C
		public void AddMoveListener(bool bOn = true, bool bCheckMask = false)
		{
			this.SwitchOnMove(bOn);
			this.SwitchOnCheckMask(bCheckMask);
			EventSystem.Instance.Add<float>(EEventName.MapDragMoveForward, new Action<float>(this.OnMoveForward));
			EventSystem.Instance.Add<float>(EEventName.MapDragMoveRight, new Action<float>(this.OnMoveRight));
		}

		// Token: 0x060356D1 RID: 218833 RVA: 0x00EEC49F File Offset: 0x00EEA69F
		public void RemoveMoveListener()
		{
			EventSystem.Instance.Remove(EEventName.MapDragMoveForward, new Action<float>(this.OnMoveForward));
			EventSystem.Instance.Remove(EEventName.MapDragMoveRight, new Action<float>(this.OnMoveRight));
		}

		// Token: 0x060356D2 RID: 218834 RVA: 0x00EEC4DC File Offset: 0x00EEA6DC
		private void OnMoveForward(float delta)
		{
			if (!this.CanMove)
			{
				return;
			}
			if (this.CheckMask && UiLayer.Instance.IsInMask())
			{
				return;
			}
			this.ForwardVector.Y = (double)delta * this.MapScale * (double)(-(double)this.MoveSpeed);
			this.IsMoveForwardDirty = true;
		}

		// Token: 0x060356D3 RID: 218835 RVA: 0x00EEC52C File Offset: 0x00EEA72C
		private void OnMoveRight(float delta)
		{
			if (!this.CanMove)
			{
				return;
			}
			if (this.CheckMask && UiLayer.Instance.IsInMask())
			{
				return;
			}
			this.RightVector.X = (double)delta * this.MapScale * (double)(-(double)this.MoveSpeed);
			this.IsMoveRightDirty = true;
		}

		// Token: 0x060356D4 RID: 218836 RVA: 0x00EEC57C File Offset: 0x00EEA77C
		public void TickMove()
		{
			if (!this.IsMoveForwardDirty && !this.IsMoveRightDirty)
			{
				return;
			}
			this.TempMoveVector2D.FromUeVector2D(this.MapItem.GetAnchorOffset());
			if (this.IsMoveForwardDirty)
			{
				this.TempMoveVector2D.AdditionEqual(this.ForwardVector);
				this.IsMoveForwardDirty = false;
			}
			if (this.IsMoveRightDirty)
			{
				this.TempMoveVector2D.AdditionEqual(this.RightVector);
				this.IsMoveRightDirty = false;
			}
			this.MoveToTargetPos(this.TempMoveVector2D, EClampType.ClampToSafeArea);
		}

		// Token: 0x060356D5 RID: 218837 RVA: 0x00EEC604 File Offset: 0x00EEA804
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"ratioX",
			"ratioY"
		})]
		public ValueTuple<double, double> GetOffsetDisRelativeToViewportCenterRatio(double offsetX, double offsetY)
		{
			double item = Math.Abs(offsetX) * this.MapScale / (this.ViewportSize.X / 2.0);
			double item2 = Math.Abs(offsetY) * this.MapScale / (this.ViewportSize.Y / 2.0);
			return new ValueTuple<double, double>(item, item2);
		}

		// Token: 0x0401C2A7 RID: 115367
		private double PointerDownTime;

		// Token: 0x0401C2A8 RID: 115368
		protected bool IsDragging;

		// Token: 0x0401C2A9 RID: 115369
		protected bool IsTweening;

		// Token: 0x0401C2AA RID: 115370
		[Nullable(2)]
		private ULTweener PosTweener;

		// Token: 0x0401C2AB RID: 115371
		[Nullable(2)]
		private FLTweenVector2SetterDynamic Delegate;

		// Token: 0x0401C2AC RID: 115372
		[Nullable(2)]
		private ULTweener ScaleTweener;

		// Token: 0x0401C2AD RID: 115373
		[Nullable(2)]
		private FLTweenVector3SetterDynamic ScaleDelegate;

		// Token: 0x0401C2AE RID: 115374
		private readonly Vector2D ScaleTempPos = Vector2D.Create();

		// Token: 0x0401C2AF RID: 115375
		private readonly Vector ScaleTempStartVector = Vector.Create();

		// Token: 0x0401C2B0 RID: 115376
		private readonly Vector ScaleTempEndVector = Vector.Create();

		// Token: 0x0401C2B1 RID: 115377
		private readonly Vector2D LastDragPos = Vector2D.Create();

		// Token: 0x0401C2B2 RID: 115378
		private readonly Vector2D PointerDeltaPos = Vector2D.Create();

		// Token: 0x0401C2B3 RID: 115379
		public readonly double ScaleStep = 0.05000000074505806;

		// Token: 0x0401C2B4 RID: 115380
		public readonly IScaleArea MapScaleSafeArea = new ScaleArea
		{
			Min = 0.0,
			Max = 0.0
		};

		// Token: 0x0401C2B5 RID: 115381
		private double MapScaleInternal = 1.0;

		// Token: 0x0401C2B6 RID: 115382
		private const float TWEEN_TIME = 2f;

		// Token: 0x0401C2B7 RID: 115383
		private const float DRAG_TWEEN_TIME = 0.8f;

		// Token: 0x0401C2B8 RID: 115384
		private readonly Vector2D ViewportSize = Vector2D.Create();

		// Token: 0x0401C2B9 RID: 115385
		private readonly Vector2D MapMoveRebound = Vector2D.Create();

		// Token: 0x0401C2BA RID: 115386
		protected readonly IMoveArea MoveSafeArea = new MoveArea
		{
			MinX = 0.0,
			MaxX = 0.0,
			MinY = 0.0,
			MaxY = 0.0
		};

		// Token: 0x0401C2BB RID: 115387
		protected readonly IMoveArea MoveDangerousArea = new MoveArea
		{
			MinX = 0.0,
			MaxX = 0.0,
			MinY = 0.0,
			MaxY = 0.0
		};

		// Token: 0x0401C2BC RID: 115388
		private readonly Vector2D InteractCenterPoint = Vector2D.Create();

		// Token: 0x0401C2BD RID: 115389
		private readonly UUIItem MapItem;

		// Token: 0x0401C2BE RID: 115390
		private readonly Vector2D TempVector2D = Vector2D.Create();

		// Token: 0x0401C2BF RID: 115391
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0401C2C0 RID: 115392
		private double SizeInterval = 1.0;

		// Token: 0x0401C2C1 RID: 115393
		[Nullable(2)]
		private Action<ESetScaleSource> ChangeScaleCallback;

		// Token: 0x0401C2C2 RID: 115394
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ULGUIPointerEventData> PointerBeginDragExtraCallBack;

		// Token: 0x0401C2C3 RID: 115395
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ULGUIPointerEventData> PointerUpExtraCallBack;

		// Token: 0x0401C2C4 RID: 115396
		[Nullable(2)]
		public Action MapMovedCallback;

		// Token: 0x0401C2C5 RID: 115397
		private readonly Vector2D TempTouchVector2D = Vector2D.Create();

		// Token: 0x0401C2C6 RID: 115398
		private readonly Dictionary<int, InputDistributeDefine.ITouchData> TouchMap = new Dictionary<int, InputDistributeDefine.ITouchData>();

		// Token: 0x0401C2C7 RID: 115399
		public float MoveSpeed = 1f;

		// Token: 0x0401C2C8 RID: 115400
		private readonly Vector2D ForwardVector = new Vector2D();

		// Token: 0x0401C2C9 RID: 115401
		private readonly Vector2D RightVector = new Vector2D();

		// Token: 0x0401C2CA RID: 115402
		private readonly Vector2D TempMoveVector2D = Vector2D.Create();

		// Token: 0x0401C2CB RID: 115403
		private bool IsMoveForwardDirty;

		// Token: 0x0401C2CC RID: 115404
		private bool IsMoveRightDirty;

		// Token: 0x0401C2CD RID: 115405
		private bool CanMove;

		// Token: 0x0401C2CE RID: 115406
		private bool CheckMask;
	}
}
