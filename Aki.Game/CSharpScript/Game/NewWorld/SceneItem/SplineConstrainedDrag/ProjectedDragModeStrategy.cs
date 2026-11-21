using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x02006262 RID: 25186
	[NullableContext(1)]
	[Nullable(0)]
	public class ProjectedDragModeStrategy : BaseDragModeStrategy
	{
		// Token: 0x17007301 RID: 29441
		// (get) Token: 0x0603CC65 RID: 248933 RVA: 0x0117353C File Offset: 0x0117173C
		public override EKuroSplineConstrainedDragMode Mode { get; } = 1;

		// Token: 0x0603CC66 RID: 248934 RVA: 0x01173544 File Offset: 0x01171744
		public override void BeginDrag()
		{
			base.BeginDrag();
			IKuroSplineConstrainedDrag host = this.Host;
			if (host == null)
			{
				return;
			}
			host.SnapToSpline();
		}

		// Token: 0x0603CC67 RID: 248935 RVA: 0x01173569 File Offset: 0x01171769
		public override void SetCurrentScreenPosition(Vector screenPosition)
		{
		}

		// Token: 0x0603CC68 RID: 248936 RVA: 0x0117356C File Offset: 0x0117176C
		public override void ApplyScreenDelta(Vector screenDelta)
		{
			IKuroSplineConstrainedDrag host = this.Host;
			if (host == null)
			{
				return;
			}
			float currentDistanceAlongSpline = host.GetCurrentDistanceAlongSpline();
			float num = this.ComputeDistanceDeltaByProjectedTangent(screenDelta, currentDistanceAlongSpline);
			if (!MathUtils.Instance.IsNearlyZero((double)num, null))
			{
				host.SetDistanceAlongSpline(currentDistanceAlongSpline + num, true);
			}
		}

		// Token: 0x0603CC69 RID: 248937 RVA: 0x011735B8 File Offset: 0x011717B8
		private float ComputeDistanceDeltaByProjectedTangent(Vector screenDelta, float anchorDistance)
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null || !characterController.IsValid())
			{
				return 0f;
			}
			IKuroSplineConstrainedDrag host = this.Host;
			if (host == null)
			{
				return 0f;
			}
			USplineComponent constraintSpline = host.GetConstraintSpline();
			if (constraintSpline == null || !constraintSpline.IsValid())
			{
				return 0f;
			}
			float splineLength = constraintSpline.GetSplineLength();
			float num = Math.Max(1f, this.ProjectionScreenSpaceSampleDistance);
			float num2 = MathUtils.Instance.Clamp(anchorDistance - num, 0f, splineLength);
			float num3 = MathUtils.Instance.Clamp(anchorDistance + num, 0f, splineLength);
			float num4 = num3 - num2;
			if (num4 < 0.0001f)
			{
				return 0f;
			}
			FVectorDouble fvectorDouble = constraintSpline.D_GetLocationAtDistanceAlongSpline(num2, ESplineCoordinateSpace.World);
			FVectorDouble fvectorDouble2 = constraintSpline.D_GetLocationAtDistanceAlongSpline(num3, ESplineCoordinateSpace.World);
			FVector2D projectionStartScreenPos2D = this.ProjectionStartScreenPos2D;
			FVector2D projectionEndScreenPos2D = this.ProjectionEndScreenPos2D;
			if (!UGameplayStatics.D_ProjectWorldToScreen(Global.CharacterController, fvectorDouble, ref projectionStartScreenPos2D, false))
			{
				return 0f;
			}
			if (!UGameplayStatics.D_ProjectWorldToScreen(Global.CharacterController, fvectorDouble2, ref projectionEndScreenPos2D, false))
			{
				return 0f;
			}
			this.ProjectionStartScreenPos2D = projectionStartScreenPos2D;
			this.ProjectionEndScreenPos2D = projectionEndScreenPos2D;
			FVector2D fvector2D = this.ProjectionEndScreenPos2D - this.ProjectionStartScreenPos2D;
			float num5 = fvector2D.Size();
			if (num5 < this.ProjectionMinScreenTangentPixels)
			{
				return 0f;
			}
			this.ProjectionScreenDelta2D.Set((float)screenDelta.X, (float)screenDelta.Y);
			float num6 = this.ProjectionScreenDelta2D.Size();
			if (num6 < 0.0001f)
			{
				return 0f;
			}
			FVector2D fvector2D2 = fvector2D / num5;
			float num7 = FVector2D.DotProduct(this.ProjectionScreenDelta2D, fvector2D2);
			if (Math.Abs(num7) / num6 < this.ProjectionTangentAlignmentThreshold)
			{
				return 0f;
			}
			float num8 = num4 / num5;
			return num7 * num8 * this.ProjectionScreenSpaceDragScale;
		}

		// Token: 0x0402038F RID: 131983
		private readonly float ProjectionScreenSpaceSampleDistance = 20f;

		// Token: 0x04020390 RID: 131984
		private readonly float ProjectionMinScreenTangentPixels = 0.1f;

		// Token: 0x04020391 RID: 131985
		private readonly float ProjectionScreenSpaceDragScale = 1f;

		// Token: 0x04020392 RID: 131986
		private readonly float ProjectionTangentAlignmentThreshold = 0.2f;

		// Token: 0x04020393 RID: 131987
		private FVector2D ProjectionStartScreenPos2D = new FVector2D();

		// Token: 0x04020394 RID: 131988
		private FVector2D ProjectionEndScreenPos2D = new FVector2D();

		// Token: 0x04020395 RID: 131989
		private FVector2D ProjectionScreenDelta2D = new FVector2D();
	}
}
