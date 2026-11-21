using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x0200385A RID: 14426
	[NullableContext(2)]
	[Nullable(0)]
	public class UiTransformDragController
	{
		// Token: 0x17004D01 RID: 19713
		// (get) Token: 0x060257A8 RID: 153512 RVA: 0x00A8E9EA File Offset: 0x00A8CBEA
		public bool IsEnabled
		{
			get
			{
				return this.Enabled;
			}
		}

		// Token: 0x060257A9 RID: 153513 RVA: 0x00A8E9F2 File Offset: 0x00A8CBF2
		[NullableContext(1)]
		public void Init(UUIDraggableComponent draggable, [Nullable(2)] AUIBaseActor boundActor = null)
		{
			this.Draggable = draggable;
			this.TargetItem = draggable.GetRootComponent();
			this.BoundActor = boundActor;
		}

		// Token: 0x060257AA RID: 153514 RVA: 0x00A8EA10 File Offset: 0x00A8CC10
		public void SetScaleRange(float minScale, float maxScale)
		{
			this.MinScale = ((minScale > 0f) ? minScale : 0.5f);
			this.MaxScale = ((maxScale > 0f) ? maxScale : 3f);
			if (this.MinScale >= this.MaxScale)
			{
				this.MinScale = 0.5f;
				this.MaxScale = 3f;
			}
		}

		// Token: 0x060257AB RID: 153515 RVA: 0x00A8EA6D File Offset: 0x00A8CC6D
		public void SetScaleItem(UUIItem scaleItem)
		{
			this.ScaleItem = scaleItem;
			this.RefreshScaleBaseSize();
		}

		// Token: 0x060257AC RID: 153516 RVA: 0x00A8EA7C File Offset: 0x00A8CC7C
		public void RefreshScaleBaseSize()
		{
			UUIItem scaleTarget = this.ScaleTarget;
			if (scaleTarget == null)
			{
				return;
			}
			this.ScaleItemBaseWidth = scaleTarget.Width;
			this.ScaleItemBaseHeight = scaleTarget.Height;
			this.CurrentScale = 1f;
		}

		// Token: 0x17004D02 RID: 19714
		// (get) Token: 0x060257AD RID: 153517 RVA: 0x00A8EAB7 File Offset: 0x00A8CCB7
		private UUIItem ScaleTarget
		{
			get
			{
				return this.ScaleItem ?? this.TargetItem;
			}
		}

		// Token: 0x060257AE RID: 153518 RVA: 0x00A8EACC File Offset: 0x00A8CCCC
		private void ApplyScale(double scale)
		{
			UUIItem scaleTarget = this.ScaleTarget;
			if (scaleTarget == null || this.ScaleItemBaseWidth <= 0f || this.ScaleItemBaseHeight <= 0f)
			{
				return;
			}
			this.CurrentScale = (float)scale;
			scaleTarget.SetWidth(this.ScaleItemBaseWidth * this.CurrentScale);
			scaleTarget.SetHeight(this.ScaleItemBaseHeight * this.CurrentScale);
		}

		// Token: 0x060257AF RID: 153519 RVA: 0x00A8EB2C File Offset: 0x00A8CD2C
		public void SetBoundActor(AUIBaseActor boundActor)
		{
			this.BoundActor = boundActor;
		}

		// Token: 0x060257B0 RID: 153520 RVA: 0x00A8EB38 File Offset: 0x00A8CD38
		public void EnableDrag()
		{
			if (this.Draggable == null)
			{
				return;
			}
			this.Draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
			this.Draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDrag));
			this.Draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnd));
		}

		// Token: 0x060257B1 RID: 153521 RVA: 0x00A8EBA2 File Offset: 0x00A8CDA2
		[NullableContext(1)]
		public void BindTransformButton(UUIButtonComponent btn, bool supportRotate)
		{
			this.TransformButton = btn;
			this.SupportRotate = supportRotate;
			btn.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnTransformBegin));
			btn.OnPointerDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnTransformDrag));
		}

		// Token: 0x060257B2 RID: 153522 RVA: 0x00A8EBE0 File Offset: 0x00A8CDE0
		public void SetEnabled(bool enabled)
		{
			this.Enabled = enabled;
			UUIDraggableComponent draggable = this.Draggable;
			if (draggable != null)
			{
				draggable.SetEnable(enabled);
			}
			UUIItem targetItem = this.TargetItem;
			if (targetItem != null)
			{
				targetItem.SetRaycastTarget(enabled);
			}
			UUIButtonComponent transformButton = this.TransformButton;
			if (transformButton != null)
			{
				transformButton.SetSelfInteractive(enabled);
			}
			if (!enabled)
			{
				this.DragGrabOffset = null;
				this.TransformStartDir = null;
			}
		}

		// Token: 0x060257B3 RID: 153523 RVA: 0x00A8EC45 File Offset: 0x00A8CE45
		public void ChangeScaleByDelta(float delta)
		{
			if (this.ScaleTarget == null || delta == 0f)
			{
				return;
			}
			this.ApplyScale((double)MathCommon.Clamp(this.CurrentScale + delta, this.MinScale, this.MaxScale));
		}

		// Token: 0x060257B4 RID: 153524 RVA: 0x00A8EC78 File Offset: 0x00A8CE78
		public void MoveByDelta(float deltaX, float deltaY)
		{
			if (!this.Enabled || this.TargetItem == null || (deltaX == 0f && deltaY == 0f))
			{
				return;
			}
			FVector relativeLocation = this.TargetItem.RelativeLocation;
			FVectorDouble location = new FVectorDouble(ref relativeLocation);
			location.X += (double)deltaX;
			location.Y += (double)deltaY;
			FVectorDouble fvectorDouble = this.ClampBound(location);
			this.TargetItem.SetUIRelativeLocation(new FVector((float)fvectorDouble.X, (float)fvectorDouble.Y, (float)fvectorDouble.Z));
		}

		// Token: 0x060257B5 RID: 153525 RVA: 0x00A8ED04 File Offset: 0x00A8CF04
		public void Mirror()
		{
			UUIItem scaleTarget = this.ScaleTarget;
			if (scaleTarget == null)
			{
				return;
			}
			FVector relativeScale3D = scaleTarget.RelativeScale3D;
			relativeScale3D.X = -relativeScale3D.X;
			scaleTarget.SetUIItemScale(relativeScale3D);
		}

		// Token: 0x060257B6 RID: 153526 RVA: 0x00A8ED38 File Offset: 0x00A8CF38
		private void OnDragBegin(ULGUIPointerEventData eventData)
		{
			if (!this.Enabled || eventData == null || this.TargetItem == null)
			{
				return;
			}
			FVector fvector = this.WorldToParentLocal(eventData.GetWorldPointInPlane());
			FVector relativeLocation = this.TargetItem.RelativeLocation;
			this.DragGrabOffset = new FVector?(relativeLocation - fvector);
		}

		// Token: 0x060257B7 RID: 153527 RVA: 0x00A8ED88 File Offset: 0x00A8CF88
		private void OnDrag(ULGUIPointerEventData eventData)
		{
			if (!this.Enabled || eventData == null || this.TargetItem == null || this.DragGrabOffset == null)
			{
				return;
			}
			FVector fvector = this.WorldToParentLocal(eventData.GetWorldPointInPlane());
			FVector value = this.DragGrabOffset.Value;
			FVector fvector2 = fvector + value;
			FVectorDouble fvectorDouble = this.ClampBound(new FVectorDouble(ref fvector2));
			this.TargetItem.SetUIRelativeLocation(new FVector((float)fvectorDouble.X, (float)fvectorDouble.Y, (float)fvectorDouble.Z));
		}

		// Token: 0x060257B8 RID: 153528 RVA: 0x00A8EE0C File Offset: 0x00A8D00C
		private void OnDragEnd(ULGUIPointerEventData eventData)
		{
			this.DragGrabOffset = null;
		}

		// Token: 0x060257B9 RID: 153529 RVA: 0x00A8EE1C File Offset: 0x00A8D01C
		private FVector WorldToParentLocal(FVector worldPoint)
		{
			UUIItem parentAsUIItem = this.TargetItem.GetParentAsUIItem();
			if (parentAsUIItem == null)
			{
				return worldPoint;
			}
			return parentAsUIItem.K2_GetComponentToWorld().InverseTransformPosition(worldPoint);
		}

		// Token: 0x060257BA RID: 153530 RVA: 0x00A8EE4C File Offset: 0x00A8D04C
		private FVectorDouble ClampBound(FVectorDouble location)
		{
			UUIItem scaleTarget = this.ScaleTarget;
			if (this.TargetItem == null || scaleTarget == null || this.BoundActor == null)
			{
				return location;
			}
			FVector2D pivot = this.TargetItem.GetPivot();
			UUIItem uiitem = this.BoundActor.GetUIItem();
			float num = uiitem.Width / 2f;
			float num2 = uiitem.Height / 2f;
			float width = scaleTarget.Width;
			float height = scaleTarget.Height;
			float num3 = -num + width * pivot.X;
			float num4 = num - width * (1f - pivot.X);
			float num5 = -num2 + height * pivot.Y;
			float num6 = num2 - height * (1f - pivot.Y);
			location.X = MathCommon.Clamp(location.X, (double)num3, (double)num4);
			location.Y = MathCommon.Clamp(location.Y, (double)num5, (double)num6);
			return location;
		}

		// Token: 0x060257BB RID: 153531 RVA: 0x00A8EF24 File Offset: 0x00A8D124
		private bool OnTransformBegin(ULGUIPointerEventData eventData)
		{
			if (!this.Enabled || eventData == null || this.TargetItem == null)
			{
				return true;
			}
			FVectorDouble fvectorDouble = this.TargetItem.GetOwner().D_K2_GetActorLocation();
			FVector worldPointInPlane = eventData.GetWorldPointInPlane();
			this.TransformPlaneNormal = eventData.worldNormal;
			this.TransformStartDir = new FVector?(new FVector(worldPointInPlane.X - (float)fvectorDouble.X, worldPointInPlane.Y - (float)fvectorDouble.Y, worldPointInPlane.Z - (float)fvectorDouble.Z));
			this.TransformStartDistance = MathUtils.Instance.VectorDistance(fvectorDouble, worldPointInPlane);
			this.TransformStartScale = (double)this.CurrentScale;
			this.TransformStartAngle = this.CurrentAngle;
			return true;
		}

		// Token: 0x060257BC RID: 153532 RVA: 0x00A8EFDC File Offset: 0x00A8D1DC
		private bool OnTransformDrag(ULGUIPointerEventData eventData)
		{
			if (!this.Enabled || eventData == null || this.TargetItem == null || this.TransformStartDir == null || this.TransformStartDistance <= 9.99999993922529E-09)
			{
				return true;
			}
			FVectorDouble fvectorDouble = this.TargetItem.GetOwner().D_K2_GetActorLocation();
			FVector worldPointInPlane = eventData.GetWorldPointInPlane();
			double num = MathUtils.Instance.VectorDistance(fvectorDouble, worldPointInPlane);
			this.ApplyScale(MathCommon.Clamp(this.TransformStartScale * num / this.TransformStartDistance, (double)this.MinScale, (double)this.MaxScale));
			if (this.SupportRotate)
			{
				FVector fvector = new FVector(worldPointInPlane.X - (float)fvectorDouble.X, worldPointInPlane.Y - (float)fvectorDouble.Y, worldPointInPlane.Z - (float)fvectorDouble.Z);
				float num2 = (float)MathUtils.Instance.SignedAngleOnPlaneDeg(this.TransformStartDir.Value, fvector, this.TransformPlaneNormal);
				this.CurrentAngle = this.TransformStartAngle + num2;
				UUIItem targetItem = this.TargetItem;
				FRotator frotator = Rotator.Create(0f, this.CurrentAngle, 0f).ToUeRotator();
				targetItem.SetUIRelativeRotation(frotator);
			}
			return true;
		}

		// Token: 0x060257BD RID: 153533 RVA: 0x00A8F118 File Offset: 0x00A8D318
		public void Dispose()
		{
			if (this.Draggable != null)
			{
				this.Draggable.OnPointerBeginDragCallBack.Unbind();
				this.Draggable.OnPointerDragCallBack.Unbind();
				this.Draggable.OnPointerEndDragCallBack.Unbind();
			}
			if (this.TransformButton != null)
			{
				this.TransformButton.OnPointerBeginDragCallBack.Unbind();
				this.TransformButton.OnPointerDragCallBack.Unbind();
			}
			this.Draggable = null;
			this.TargetItem = null;
			this.ScaleItem = null;
			this.ScaleItemBaseWidth = 0f;
			this.ScaleItemBaseHeight = 0f;
			this.CurrentScale = 1f;
			this.BoundActor = null;
			this.TransformButton = null;
			this.DragGrabOffset = null;
			this.TransformStartDir = null;
		}

		// Token: 0x04014B7F RID: 84863
		private UUIDraggableComponent Draggable;

		// Token: 0x04014B80 RID: 84864
		private UUIItem TargetItem;

		// Token: 0x04014B81 RID: 84865
		private UUIItem ScaleItem;

		// Token: 0x04014B82 RID: 84866
		private float ScaleItemBaseWidth;

		// Token: 0x04014B83 RID: 84867
		private float ScaleItemBaseHeight;

		// Token: 0x04014B84 RID: 84868
		private AUIBaseActor BoundActor;

		// Token: 0x04014B85 RID: 84869
		private const float DefaultMinScale = 0.5f;

		// Token: 0x04014B86 RID: 84870
		private const float DefaultMaxScale = 3f;

		// Token: 0x04014B87 RID: 84871
		public float MinScale = 0.5f;

		// Token: 0x04014B88 RID: 84872
		public float MaxScale = 3f;

		// Token: 0x04014B89 RID: 84873
		private UUIButtonComponent TransformButton;

		// Token: 0x04014B8A RID: 84874
		private bool SupportRotate;

		// Token: 0x04014B8B RID: 84875
		private FVector? DragGrabOffset;

		// Token: 0x04014B8C RID: 84876
		private FVector? TransformStartDir;

		// Token: 0x04014B8D RID: 84877
		private double TransformStartDistance;

		// Token: 0x04014B8E RID: 84878
		private double TransformStartScale;

		// Token: 0x04014B8F RID: 84879
		private float TransformStartAngle;

		// Token: 0x04014B90 RID: 84880
		private FVector TransformPlaneNormal;

		// Token: 0x04014B91 RID: 84881
		private float CurrentAngle;

		// Token: 0x04014B92 RID: 84882
		private float CurrentScale = 1f;

		// Token: 0x04014B93 RID: 84883
		private bool Enabled = true;
	}
}
