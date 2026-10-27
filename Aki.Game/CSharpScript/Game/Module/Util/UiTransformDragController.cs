using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048E3 RID: 18659
	[NullableContext(2)]
	[Nullable(0)]
	public class UiTransformDragController
	{
		// Token: 0x17007999 RID: 31129
		// (get) Token: 0x06030C7B RID: 199803 RVA: 0x00B53B7A File Offset: 0x00B51D7A
		public bool IsEnabled
		{
			get
			{
				return this.Enabled;
			}
		}

		// Token: 0x06030C7C RID: 199804 RVA: 0x00B53B82 File Offset: 0x00B51D82
		[NullableContext(1)]
		public void Init(UUIDraggableComponent draggable, [Nullable(2)] AUIBaseActor boundActor = null)
		{
			this.Draggable = draggable;
			this.TargetItem = draggable.GetRootComponent();
			this.BoundActor = boundActor;
		}

		// Token: 0x06030C7D RID: 199805 RVA: 0x00B53BA0 File Offset: 0x00B51DA0
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

		// Token: 0x06030C7E RID: 199806 RVA: 0x00B53BFD File Offset: 0x00B51DFD
		public void SetScaleItem(UUIItem scaleItem)
		{
			this.ScaleItem = scaleItem;
			this.RefreshScaleBaseSize();
		}

		// Token: 0x06030C7F RID: 199807 RVA: 0x00B53C0C File Offset: 0x00B51E0C
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

		// Token: 0x1700799A RID: 31130
		// (get) Token: 0x06030C80 RID: 199808 RVA: 0x00B53C47 File Offset: 0x00B51E47
		private UUIItem ScaleTarget
		{
			get
			{
				return this.ScaleItem ?? this.TargetItem;
			}
		}

		// Token: 0x06030C81 RID: 199809 RVA: 0x00B53C5C File Offset: 0x00B51E5C
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

		// Token: 0x06030C82 RID: 199810 RVA: 0x00B53CBC File Offset: 0x00B51EBC
		public void SetBoundActor(AUIBaseActor boundActor)
		{
			this.BoundActor = boundActor;
		}

		// Token: 0x06030C83 RID: 199811 RVA: 0x00B53CC8 File Offset: 0x00B51EC8
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

		// Token: 0x06030C84 RID: 199812 RVA: 0x00B53D32 File Offset: 0x00B51F32
		[NullableContext(1)]
		public void BindTransformButton(UUIButtonComponent btn, bool supportRotate)
		{
			this.TransformButton = btn;
			this.SupportRotate = supportRotate;
			btn.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnTransformBegin));
			btn.OnPointerDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnTransformDrag));
		}

		// Token: 0x06030C85 RID: 199813 RVA: 0x00B53D70 File Offset: 0x00B51F70
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

		// Token: 0x06030C86 RID: 199814 RVA: 0x00B53DD5 File Offset: 0x00B51FD5
		public void ChangeScaleByDelta(float delta)
		{
			if (this.ScaleTarget == null || delta == 0f)
			{
				return;
			}
			this.ApplyScale((double)MathCommon.Clamp(this.CurrentScale + delta, this.MinScale, this.MaxScale));
		}

		// Token: 0x06030C87 RID: 199815 RVA: 0x00B53E08 File Offset: 0x00B52008
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

		// Token: 0x06030C88 RID: 199816 RVA: 0x00B53E94 File Offset: 0x00B52094
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

		// Token: 0x06030C89 RID: 199817 RVA: 0x00B53EC8 File Offset: 0x00B520C8
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

		// Token: 0x06030C8A RID: 199818 RVA: 0x00B53F18 File Offset: 0x00B52118
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

		// Token: 0x06030C8B RID: 199819 RVA: 0x00B53F9C File Offset: 0x00B5219C
		private void OnDragEnd(ULGUIPointerEventData eventData)
		{
			this.DragGrabOffset = null;
		}

		// Token: 0x06030C8C RID: 199820 RVA: 0x00B53FAC File Offset: 0x00B521AC
		private FVector WorldToParentLocal(FVector worldPoint)
		{
			UUIItem parentAsUIItem = this.TargetItem.GetParentAsUIItem();
			if (parentAsUIItem == null)
			{
				return worldPoint;
			}
			return parentAsUIItem.K2_GetComponentToWorld().InverseTransformPosition(worldPoint);
		}

		// Token: 0x06030C8D RID: 199821 RVA: 0x00B53FDC File Offset: 0x00B521DC
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

		// Token: 0x06030C8E RID: 199822 RVA: 0x00B540B4 File Offset: 0x00B522B4
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

		// Token: 0x06030C8F RID: 199823 RVA: 0x00B5416C File Offset: 0x00B5236C
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

		// Token: 0x06030C90 RID: 199824 RVA: 0x00B542A8 File Offset: 0x00B524A8
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

		// Token: 0x0401A30C RID: 107276
		private UUIDraggableComponent Draggable;

		// Token: 0x0401A30D RID: 107277
		private UUIItem TargetItem;

		// Token: 0x0401A30E RID: 107278
		private UUIItem ScaleItem;

		// Token: 0x0401A30F RID: 107279
		private float ScaleItemBaseWidth;

		// Token: 0x0401A310 RID: 107280
		private float ScaleItemBaseHeight;

		// Token: 0x0401A311 RID: 107281
		private AUIBaseActor BoundActor;

		// Token: 0x0401A312 RID: 107282
		private const float DefaultMinScale = 0.5f;

		// Token: 0x0401A313 RID: 107283
		private const float DefaultMaxScale = 3f;

		// Token: 0x0401A314 RID: 107284
		public float MinScale = 0.5f;

		// Token: 0x0401A315 RID: 107285
		public float MaxScale = 3f;

		// Token: 0x0401A316 RID: 107286
		private UUIButtonComponent TransformButton;

		// Token: 0x0401A317 RID: 107287
		private bool SupportRotate;

		// Token: 0x0401A318 RID: 107288
		private FVector? DragGrabOffset;

		// Token: 0x0401A319 RID: 107289
		private FVector? TransformStartDir;

		// Token: 0x0401A31A RID: 107290
		private double TransformStartDistance;

		// Token: 0x0401A31B RID: 107291
		private double TransformStartScale;

		// Token: 0x0401A31C RID: 107292
		private float TransformStartAngle;

		// Token: 0x0401A31D RID: 107293
		private FVector TransformPlaneNormal;

		// Token: 0x0401A31E RID: 107294
		private float CurrentAngle;

		// Token: 0x0401A31F RID: 107295
		private float CurrentScale = 1f;

		// Token: 0x0401A320 RID: 107296
		private bool Enabled = true;
	}
}
