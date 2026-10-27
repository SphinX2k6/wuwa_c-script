using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x020071AD RID: 29101
	[NullableContext(1)]
	[Nullable(0)]
	public class ProjectedDragModeStrategy : BaseDragModeStrategy
	{
		// Token: 0x17009DB1 RID: 40369
		// (get) Token: 0x0604736A RID: 291690 RVA: 0x01219638 File Offset: 0x01217838
		public override EKuroSplineConstrainedDragMode Mode { get; } = 1;

		// Token: 0x0604736B RID: 291691 RVA: 0x01219640 File Offset: 0x01217840
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

		// Token: 0x0604736C RID: 291692 RVA: 0x01219665 File Offset: 0x01217865
		public override void SetCurrentScreenPosition(Vector screenPosition)
		{
		}

		// Token: 0x0604736D RID: 291693 RVA: 0x01219668 File Offset: 0x01217868
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

		// Token: 0x0604736E RID: 291694 RVA: 0x012196B4 File Offset: 0x012178B4
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

		// Token: 0x04025720 RID: 153376
		private readonly float ProjectionScreenSpaceSampleDistance = 20f;

		// Token: 0x04025721 RID: 153377
		private readonly float ProjectionMinScreenTangentPixels = 0.1f;

		// Token: 0x04025722 RID: 153378
		private readonly float ProjectionScreenSpaceDragScale = 1f;

		// Token: 0x04025723 RID: 153379
		private readonly float ProjectionTangentAlignmentThreshold = 0.2f;

		// Token: 0x04025724 RID: 153380
		private FVector2D ProjectionStartScreenPos2D = new FVector2D();

		// Token: 0x04025725 RID: 153381
		private FVector2D ProjectionEndScreenPos2D = new FVector2D();

		// Token: 0x04025726 RID: 153382
		private FVector2D ProjectionScreenDelta2D = new FVector2D();
	}
}
