using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02006476 RID: 25718
	[NullableContext(1)]
	[Nullable(0)]
	public class BuildingMapMoveComponent
	{
		// Token: 0x1700949D RID: 38045
		// (get) Token: 0x060409D8 RID: 264664 RVA: 0x00FA3F40 File Offset: 0x00FA2140
		// (set) Token: 0x060409D9 RID: 264665 RVA: 0x00FA3F48 File Offset: 0x00FA2148
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

		// Token: 0x1700949E RID: 38046
		// (get) Token: 0x060409DA RID: 264666 RVA: 0x00FA3F51 File Offset: 0x00FA2151
		public bool IsInDrag
		{
			get
			{
				return this.IsDragging;
			}
		}

		// Token: 0x060409DB RID: 264667 RVA: 0x00FA3F5C File Offset: 0x00FA215C
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
				}
				draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
				draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
				draggable.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			}
			if (bindScroll)
			{
				draggable.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScrollCallback));
			}
			this.InitData();
		}

		// Token: 0x060409DC RID: 264668 RVA: 0x00FA41C5 File Offset: 0x00FA23C5
		private void InitData()
		{
			this.InitPosTweener();
			this.InitScaleTweener();
			this.InitViewportSize();
			this.InitScaleSafeArea();
			this.UpdateMoveDangerousArea();
			this.UpdateMoveSafeArea();
		}

		// Token: 0x060409DD RID: 264669 RVA: 0x00FA41EB File Offset: 0x00FA23EB
		private void InitPosTweener()
		{
			this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenVector2SetterDynamic>(new Action<FVector2D>(this.OnTweenUpdate));
		}

		// Token: 0x060409DE RID: 264670 RVA: 0x00FA4204 File Offset: 0x00FA2404
		private void InitScaleTweener()
		{
			this.ScaleDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenVector3SetterDynamic>(new Action<FVector>(this.OnScaleTweenUpdate));
		}

		// Token: 0x060409DF RID: 264671 RVA: 0x00FA4220 File Offset: 0x00FA2420
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

		// Token: 0x060409E0 RID: 264672 RVA: 0x00FA4368 File Offset: 0x00FA2568
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

		// Token: 0x060409E1 RID: 264673 RVA: 0x00FA4444 File Offset: 0x00FA2644
		protected virtual void UpdateMoveSafeArea()
		{
			double num = ((double)this.MapItem.GetWidth() - this.MapMoveRebound.X * 2.0) * this.MapScaleInternal;
			double num2 = ((double)this.MapItem.GetHeight() - this.MapMoveRebound.Y * 2.0) * this.MapScaleInternal;
			num = ((num < this.ViewportSize.X) ? this.ViewportSize.X : num);
			num2 = ((num2 < this.ViewportSize.Y) ? this.ViewportSize.Y : num2);
			double num3 = Math.Abs(num - this.ViewportSize.X) / 2.0;
			double num4 = Math.Abs(num2 - this.ViewportSize.Y) / 2.0;
			this.MoveSafeArea.MinX = -num3;
			this.MoveSafeArea.MaxX = num3;
			this.MoveSafeArea.MinY = -num4;
			this.MoveSafeArea.MaxY = num4;
		}

		// Token: 0x060409E2 RID: 264674 RVA: 0x00FA454C File Offset: 0x00FA274C
		private void InitScaleSafeArea()
		{
			this.SetScaleSafeArea(0.5, 2.0);
			this.MapMoveRebound.X = 400.0;
			this.MapMoveRebound.Y = 300.0;
		}

		// Token: 0x060409E3 RID: 264675 RVA: 0x00FA459C File Offset: 0x00FA279C
		private void ClampByMoveSafeArea(Vector2D vector2D)
		{
			vector2D.X = MathUtils.Instance.Clamp(vector2D.X, this.MoveSafeArea.MinX, this.MoveSafeArea.MaxX);
			vector2D.Y = MathUtils.Instance.Clamp(vector2D.Y, this.MoveSafeArea.MinY, this.MoveSafeArea.MaxY);
		}

		// Token: 0x060409E4 RID: 264676 RVA: 0x00FA4604 File Offset: 0x00FA2804
		private void ClampByMoveDangerousArea(Vector2D vector2D)
		{
			vector2D.X = MathUtils.Instance.Clamp(vector2D.X, this.MoveDangerousArea.MinX, this.MoveDangerousArea.MaxX);
			vector2D.Y = MathUtils.Instance.Clamp(vector2D.Y, this.MoveDangerousArea.MinY, this.MoveDangerousArea.MaxY);
		}

		// Token: 0x060409E5 RID: 264677 RVA: 0x00FA466C File Offset: 0x00FA286C
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

		// Token: 0x060409E6 RID: 264678 RVA: 0x00FA4734 File Offset: 0x00FA2934
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

		// Token: 0x060409E7 RID: 264679 RVA: 0x00FA4808 File Offset: 0x00FA2A08
		private Vector2D GetMousePosConverToLgui(double mousePosX, double mousePosY)
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
			vector2D.X = MathCommon.Clamp(vector2D.X, 0.0, this.ViewportSize.X);
			vector2D.Y = MathCommon.Clamp(vector2D.Y, 0.0, this.ViewportSize.Y);
			return vector2D;
		}

		// Token: 0x060409E8 RID: 264680 RVA: 0x00FA48A0 File Offset: 0x00FA2AA0
		[NullableContext(2)]
		private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			if (this.IsInMultiTouch)
			{
				return;
			}
			this.KillPosTweener();
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

		// Token: 0x060409E9 RID: 264681 RVA: 0x00FA48F8 File Offset: 0x00FA2AF8
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

		// Token: 0x060409EA RID: 264682 RVA: 0x00FA4A1B File Offset: 0x00FA2C1B
		public void EmitPointerDown()
		{
			this.PointerDownTime = Time.Instance.NowSeconds;
		}

		// Token: 0x060409EB RID: 264683 RVA: 0x00FA4A2D File Offset: 0x00FA2C2D
		[NullableContext(2)]
		private void OnPointerDown(ULGUIPointerEventData eventData)
		{
			if (eventData == null || this.IsInMultiTouch || !this.CheckPointInScope(eventData.pointerPosition))
			{
				return;
			}
			this.IsDragging = true;
			this.PointerDownTime = Time.Instance.NowSeconds;
		}

		// Token: 0x060409EC RID: 264684 RVA: 0x00FA4A60 File Offset: 0x00FA2C60
		[NullableContext(2)]
		private void OnPointerUp(ULGUIPointerEventData eventData)
		{
			if (this.IsInMultiTouch)
			{
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

		// Token: 0x060409ED RID: 264685 RVA: 0x00FA4AD0 File Offset: 0x00FA2CD0
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

		// Token: 0x060409EE RID: 264686 RVA: 0x00FA4B24 File Offset: 0x00FA2D24
		private void OnTweenUpdate(FVector2D targetPos)
		{
			this.MapItem.SetAnchorOffset(targetPos);
		}

		// Token: 0x060409EF RID: 264687 RVA: 0x00FA4B32 File Offset: 0x00FA2D32
		private void OnScaleTweenUpdate(FVector targetScale)
		{
			this.ScaleTempPos.Set((double)targetScale.Y, (double)targetScale.Z);
			this.SetScale((double)targetScale.X, ESetScaleSource.Tween, this.ScaleTempPos);
		}

		// Token: 0x060409F0 RID: 264688 RVA: 0x00FA4B64 File Offset: 0x00FA2D64
		private bool CheckPointInScope(FVector mousePos)
		{
			Vector2D mousePosConverToLgui = this.GetMousePosConverToLgui((double)mousePos.X, (double)mousePos.Y);
			return mousePosConverToLgui.X >= 0.0 && mousePosConverToLgui.X <= this.ViewportSize.X && mousePosConverToLgui.Y >= 0.0 && mousePosConverToLgui.Y <= this.ViewportSize.Y;
		}

		// Token: 0x060409F1 RID: 264689 RVA: 0x00FA4BD4 File Offset: 0x00FA2DD4
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

		// Token: 0x060409F2 RID: 264690 RVA: 0x00FA4CAE File Offset: 0x00FA2EAE
		private void KillPosTweener()
		{
			if (this.PosTweener != null)
			{
				this.PosTweener.Kill(false);
				this.PosTweener = null;
			}
		}

		// Token: 0x060409F3 RID: 264691 RVA: 0x00FA4CCB File Offset: 0x00FA2ECB
		private void KillScaleTweener()
		{
			if (this.ScaleTweener != null)
			{
				this.ScaleTweener.Kill(false);
				this.ScaleTweener = null;
			}
		}

		// Token: 0x060409F4 RID: 264692 RVA: 0x00FA4CE8 File Offset: 0x00FA2EE8
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

		// Token: 0x060409F5 RID: 264693 RVA: 0x00FA4D55 File Offset: 0x00FA2F55
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
		}

		// Token: 0x060409F6 RID: 264694 RVA: 0x00FA4D80 File Offset: 0x00FA2F80
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

		// Token: 0x060409F7 RID: 264695 RVA: 0x00FA4E04 File Offset: 0x00FA3004
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

		// Token: 0x060409F8 RID: 264696 RVA: 0x00FA4E94 File Offset: 0x00FA3094
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

		// Token: 0x060409F9 RID: 264697 RVA: 0x00FA4F50 File Offset: 0x00FA3150
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

		// Token: 0x060409FA RID: 264698 RVA: 0x00FA4F94 File Offset: 0x00FA3194
		private void OnGamepadMoveOverScreen(double overOffsetX, double overOffsetY)
		{
			this.TempVector2D.FromUeVector2D(this.MapItem.GetAnchorOffset());
			this.TempVector2D.X = this.TempVector2D.X - overOffsetX;
			this.TempVector2D.Y = this.TempVector2D.Y - overOffsetY;
			this.MoveToTargetPos(this.TempVector2D, EClampType.ClampToDangerousArea);
		}

		// Token: 0x060409FB RID: 264699 RVA: 0x00FA4FF9 File Offset: 0x00FA31F9
		public void LongPressScroll(float value)
		{
			this.InteractCenterPoint.Reset();
			this.SetScale(this.MapScaleInternal + (double)value, ESetScaleSource.LongPress, null);
		}

		// Token: 0x060409FC RID: 264700 RVA: 0x00FA5017 File Offset: 0x00FA3217
		public void SliderScroll(float value)
		{
			this.SetScale((double)value, ESetScaleSource.Slider, null);
		}

		// Token: 0x060409FD RID: 264701 RVA: 0x00FA5023 File Offset: 0x00FA3223
		public void SetChangeScaleCallback(Action<ESetScaleSource> callback)
		{
			this.ChangeScaleCallback = callback;
		}

		// Token: 0x060409FE RID: 264702 RVA: 0x00FA502C File Offset: 0x00FA322C
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

		// Token: 0x060409FF RID: 264703 RVA: 0x00FA51E9 File Offset: 0x00FA33E9
		public void SetMapMoveRebound(float x, float y)
		{
			this.MapMoveRebound.X = (double)x;
			this.MapMoveRebound.Y = (double)y;
		}

		// Token: 0x06040A00 RID: 264704 RVA: 0x00FA5205 File Offset: 0x00FA3405
		public void Destroy()
		{
			this.KillPosTweener();
			this.KillScaleTweener();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnTweenUpdate));
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector>(this.OnScaleTweenUpdate));
		}

		// Token: 0x06040A01 RID: 264705 RVA: 0x00FA5235 File Offset: 0x00FA3435
		public void AddGamepadEvent()
		{
			EventSystem.Instance.Add<double, double>(EEventName.GamepadMoveOverScreen, new Action<double, double>(this.OnGamepadMoveOverScreen));
		}

		// Token: 0x06040A02 RID: 264706 RVA: 0x00FA5253 File Offset: 0x00FA3453
		public void RemoveGamepadEvent()
		{
			EventSystem.Instance.Remove(EEventName.GamepadMoveOverScreen, new Action<double, double>(this.OnGamepadMoveOverScreen));
		}

		// Token: 0x1700949F RID: 38047
		// (get) Token: 0x06040A03 RID: 264707 RVA: 0x00FA5271 File Offset: 0x00FA3471
		public bool IsInTouch
		{
			get
			{
				return this.TouchMap.Count > 0;
			}
		}

		// Token: 0x170094A0 RID: 38048
		// (get) Token: 0x06040A04 RID: 264708 RVA: 0x00FA5281 File Offset: 0x00FA3481
		public bool IsInMultiTouch
		{
			get
			{
				return this.TouchMap.Count > 1;
			}
		}

		// Token: 0x06040A05 RID: 264709 RVA: 0x00FA5294 File Offset: 0x00FA3494
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

		// Token: 0x06040A06 RID: 264710 RVA: 0x00FA52C8 File Offset: 0x00FA34C8
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

		// Token: 0x06040A07 RID: 264711 RVA: 0x00FA53B0 File Offset: 0x00FA35B0
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

		// Token: 0x06040A08 RID: 264712 RVA: 0x00FA53F4 File Offset: 0x00FA35F4
		public void BindTouch()
		{
			InputDistributeController.Instance.BindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x06040A09 RID: 264713 RVA: 0x00FA5416 File Offset: 0x00FA3616
		public void UnbindTouch()
		{
			InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlyArray<int>(new int[]
			{
				0,
				1
			}), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x06040A0A RID: 264714 RVA: 0x00FA543D File Offset: 0x00FA363D
		public UUIItem GetMapItem()
		{
			return this.MapItem;
		}

		// Token: 0x06040A0B RID: 264715 RVA: 0x00FA5445 File Offset: 0x00FA3645
		public void SwitchOnMove(bool bOn)
		{
			this.CanMove = bOn;
		}

		// Token: 0x06040A0C RID: 264716 RVA: 0x00FA5450 File Offset: 0x00FA3650
		public void AddMoveListener(bool bOn = true)
		{
			this.SwitchOnMove(bOn);
			EventSystem.Instance.Add<float>(EEventName.MapDragMoveForward, new Action<float>(this.OnMoveForward));
			EventSystem.Instance.Add<float>(EEventName.MapDragMoveRight, new Action<float>(this.OnMoveRight));
		}

		// Token: 0x06040A0D RID: 264717 RVA: 0x00FA549C File Offset: 0x00FA369C
		public void RemoveMoveListener()
		{
			EventSystem.Instance.Remove(EEventName.MapDragMoveForward, new Action<float>(this.OnMoveForward));
			EventSystem.Instance.Remove(EEventName.MapDragMoveRight, new Action<float>(this.OnMoveRight));
		}

		// Token: 0x06040A0E RID: 264718 RVA: 0x00FA54D6 File Offset: 0x00FA36D6
		private void OnMoveForward(float delta)
		{
			if (!this.CanMove)
			{
				return;
			}
			this.ForwardVector.Y = (double)delta * this.MapScale * (double)(-(double)this.MoveSpeed);
			this.IsMoveForwardDirty = true;
		}

		// Token: 0x06040A0F RID: 264719 RVA: 0x00FA5505 File Offset: 0x00FA3705
		private void OnMoveRight(float delta)
		{
			if (!this.CanMove)
			{
				return;
			}
			this.RightVector.X = (double)delta * this.MapScale * (double)(-(double)this.MoveSpeed);
			this.IsMoveRightDirty = true;
		}

		// Token: 0x06040A10 RID: 264720 RVA: 0x00FA5534 File Offset: 0x00FA3734
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

		// Token: 0x06040A11 RID: 264721 RVA: 0x00FA55BC File Offset: 0x00FA37BC
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

		// Token: 0x04021978 RID: 137592
		private double PointerDownTime;

		// Token: 0x04021979 RID: 137593
		protected bool IsDragging;

		// Token: 0x0402197A RID: 137594
		protected bool IsTweening;

		// Token: 0x0402197B RID: 137595
		[Nullable(2)]
		private ULTweener PosTweener;

		// Token: 0x0402197C RID: 137596
		[Nullable(2)]
		private FLTweenVector2SetterDynamic Delegate;

		// Token: 0x0402197D RID: 137597
		[Nullable(2)]
		private ULTweener ScaleTweener;

		// Token: 0x0402197E RID: 137598
		[Nullable(2)]
		private FLTweenVector3SetterDynamic ScaleDelegate;

		// Token: 0x0402197F RID: 137599
		private readonly Vector2D ScaleTempPos = Vector2D.Create();

		// Token: 0x04021980 RID: 137600
		private readonly Vector ScaleTempStartVector = Vector.Create();

		// Token: 0x04021981 RID: 137601
		private readonly Vector ScaleTempEndVector = Vector.Create();

		// Token: 0x04021982 RID: 137602
		private readonly Vector2D LastDragPos = Vector2D.Create();

		// Token: 0x04021983 RID: 137603
		private readonly Vector2D PointerDeltaPos = Vector2D.Create();

		// Token: 0x04021984 RID: 137604
		public readonly double ScaleStep = 0.05000000074505806;

		// Token: 0x04021985 RID: 137605
		public readonly IScaleArea MapScaleSafeArea = new ScaleArea
		{
			Min = 0.0,
			Max = 0.0
		};

		// Token: 0x04021986 RID: 137606
		private double MapScaleInternal = 1.0;

		// Token: 0x04021987 RID: 137607
		private readonly Vector2D ViewportSize = Vector2D.Create();

		// Token: 0x04021988 RID: 137608
		private readonly Vector2D MapMoveRebound = Vector2D.Create();

		// Token: 0x04021989 RID: 137609
		protected readonly IMoveArea MoveSafeArea = new MoveArea
		{
			MinX = 0.0,
			MaxX = 0.0,
			MinY = 0.0,
			MaxY = 0.0
		};

		// Token: 0x0402198A RID: 137610
		protected readonly IMoveArea MoveDangerousArea = new MoveArea
		{
			MinX = 0.0,
			MaxX = 0.0,
			MinY = 0.0,
			MaxY = 0.0
		};

		// Token: 0x0402198B RID: 137611
		private readonly Vector2D InteractCenterPoint = Vector2D.Create();

		// Token: 0x0402198C RID: 137612
		private readonly UUIItem MapItem;

		// Token: 0x0402198D RID: 137613
		private readonly Vector2D TempVector2D = Vector2D.Create();

		// Token: 0x0402198E RID: 137614
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0402198F RID: 137615
		private double SizeInterval = 1.0;

		// Token: 0x04021990 RID: 137616
		[Nullable(2)]
		private Action<ESetScaleSource> ChangeScaleCallback;

		// Token: 0x04021991 RID: 137617
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ULGUIPointerEventData> PointerBeginDragExtraCallBack;

		// Token: 0x04021992 RID: 137618
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ULGUIPointerEventData> PointerUpExtraCallBack;

		// Token: 0x04021993 RID: 137619
		private readonly Vector2D TempTouchVector2D = Vector2D.Create();

		// Token: 0x04021994 RID: 137620
		private readonly Dictionary<int, InputDistributeDefine.ITouchData> TouchMap = new Dictionary<int, InputDistributeDefine.ITouchData>();

		// Token: 0x04021995 RID: 137621
		public float MoveSpeed = 1f;

		// Token: 0x04021996 RID: 137622
		private readonly Vector2D ForwardVector = new Vector2D();

		// Token: 0x04021997 RID: 137623
		private readonly Vector2D RightVector = new Vector2D();

		// Token: 0x04021998 RID: 137624
		private readonly Vector2D TempMoveVector2D = Vector2D.Create();

		// Token: 0x04021999 RID: 137625
		private bool IsMoveForwardDirty;

		// Token: 0x0402199A RID: 137626
		private bool IsMoveRightDirty;

		// Token: 0x0402199B RID: 137627
		private bool CanMove;

		// Token: 0x0402199C RID: 137628
		private const float TWEEN_TIME = 2f;

		// Token: 0x0402199D RID: 137629
		private const float DRAG_TWEEN_TIME = 0.8f;
	}
}
