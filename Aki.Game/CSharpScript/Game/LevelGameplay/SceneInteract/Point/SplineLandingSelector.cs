using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point
{
	// Token: 0x02006A88 RID: 27272
	[NullableContext(1)]
	[Nullable(0)]
	public class SplineLandingSelector : IStaticVariableResetter
	{
		// Token: 0x06043C5D RID: 277597 RVA: 0x010969B4 File Offset: 0x01094BB4
		static SplineLandingSelector()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SplineLandingSelector.CreateStaticDefaultValue), new Action(SplineLandingSelector.ResetStaticDefaultValue));
		}

		// Token: 0x06043C5E RID: 277598 RVA: 0x01096A38 File Offset: 0x01094C38
		public static bool SelectLandingLocation(USplineComponent spline, Vector jumpPointLocation, ISceneInteractSearchParams @params, Vector outLocation, [Nullable(2)] Vector refLocation = null, [Nullable(2)] Quat refRotation = null)
		{
			if (spline == null || !spline.IsValid())
			{
				return false;
			}
			float splineLength = spline.GetSplineLength();
			if (splineLength <= 0f)
			{
				return false;
			}
			Vector playerGravityDir = SplineLandingSelector.GetPlayerGravityDir(@params);
			SplineLandingSelector.TmpCamToRole.DeepCopy(@params.CurrentRoleLocation);
			SplineLandingSelector.TmpCamToRole.SubtractionEqual(@params.CameraLocation);
			bool flag = SplineLandingSelector.TmpCamToRole.Normalize(9.99999993922529E-09);
			if (flag)
			{
				Vector.CrossProduct(SplineLandingSelector.TmpCamToRole, playerGravityDir, SplineLandingSelector.TmpPlaneNormal);
				flag = SplineLandingSelector.TmpPlaneNormal.Normalize(9.99999993922529E-09);
			}
			SplineLandingSelector.CandidateCount = 0;
			SplineLandingSelector.CollectCandidates(spline, (double)splineLength, flag, @params, refLocation, refRotation);
			return SplineLandingSelector.PickBest(jumpPointLocation, outLocation);
		}

		// Token: 0x06043C5F RID: 277599 RVA: 0x01096AE8 File Offset: 0x01094CE8
		private static void CollectCandidates(USplineComponent spline, double length, bool hasPlane, ISceneInteractSearchParams @params, [Nullable(2)] Vector refLocation = null, [Nullable(2)] Quat refRotation = null)
		{
			bool flag = refLocation != null && refRotation != null;
			double num = Math.Max(50.0, length / 128.0);
			double num2 = 0.0;
			bool flag2 = false;
			double num3 = 0.0;
			for (;;)
			{
				double num4 = Math.Min(num3, length);
				if (flag)
				{
					FVectorDouble fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline((float)num4, ESplineCoordinateSpace.Local);
					SplineLandingSelector.TmpLocalSample.FromUeVector(fvectorDouble);
					refRotation.RotateVector(SplineLandingSelector.TmpLocalSample, SplineLandingSelector.TmpSample);
					SplineLandingSelector.TmpSample.AdditionEqual(refLocation);
				}
				else
				{
					FVectorDouble fvectorDouble2 = spline.D_GetLocationAtDistanceAlongSpline((float)num4, ESplineCoordinateSpace.World);
					SplineLandingSelector.TmpSample.FromUeVector(fvectorDouble2);
				}
				SplineLandingSelector.LandingCandidate landingCandidate = SplineLandingSelector.AcquireCandidate();
				if (landingCandidate == null)
				{
					break;
				}
				landingCandidate.Location.DeepCopy(SplineLandingSelector.TmpSample);
				landingCandidate.DistToPlayer = Vector.Dist(landingCandidate.Location, @params.CurrentRoleLocation);
				if (hasPlane)
				{
					SplineLandingSelector.TmpToSample.DeepCopy(SplineLandingSelector.TmpSample);
					SplineLandingSelector.TmpToSample.SubtractionEqual(@params.CameraLocation);
					double num5 = Vector.DotProduct(SplineLandingSelector.TmpToSample, SplineLandingSelector.TmpPlaneNormal);
					if (Math.Abs(num5) <= 1.0)
					{
						landingCandidate.IsPlaneHit = true;
					}
					else if (flag2 && num2 * num5 < 0.0)
					{
						SplineLandingSelector.AddPlaneHitCandidate(num2, num5, @params);
					}
					num2 = num5;
					SplineLandingSelector.TmpPrevSample.DeepCopy(SplineLandingSelector.TmpSample);
					flag2 = true;
				}
				if (num4 >= length)
				{
					break;
				}
				num3 += num;
			}
		}

		// Token: 0x06043C60 RID: 277600 RVA: 0x01096C58 File Offset: 0x01094E58
		private static void AddPlaneHitCandidate(double prevSigned, double signed, ISceneInteractSearchParams @params)
		{
			SplineLandingSelector.LandingCandidate landingCandidate = SplineLandingSelector.AcquireCandidate();
			if (landingCandidate == null)
			{
				return;
			}
			double inB = prevSigned / (prevSigned - signed);
			SplineLandingSelector.TmpSample.Subtraction(SplineLandingSelector.TmpPrevSample, SplineLandingSelector.TmpDelta);
			SplineLandingSelector.TmpDelta.Multiply(inB, SplineLandingSelector.TmpDelta);
			SplineLandingSelector.TmpPrevSample.Addition(SplineLandingSelector.TmpDelta, landingCandidate.Location);
			landingCandidate.IsPlaneHit = true;
			landingCandidate.DistToPlayer = Vector.Dist(landingCandidate.Location, @params.CurrentRoleLocation);
		}

		// Token: 0x06043C61 RID: 277601 RVA: 0x01096CD0 File Offset: 0x01094ED0
		private static bool PickBest(Vector jumpPointLocation, Vector outLocation)
		{
			bool enabled = SceneInteractDebugDraw.Enabled;
			int num = 0;
			for (int i = 0; i < SplineLandingSelector.CandidateCount; i++)
			{
				if (SplineLandingSelector.Candidates[i].IsPlaneHit)
				{
					num++;
				}
			}
			bool flag = num > 0;
			SplineLandingSelector.LandingCandidate landingCandidate = null;
			for (int j = 0; j < SplineLandingSelector.CandidateCount; j++)
			{
				SplineLandingSelector.LandingCandidate landingCandidate2 = SplineLandingSelector.Candidates[j];
				if (enabled)
				{
					SceneInteractDebugDraw.DrawSplineLandingCandidate(landingCandidate2.Location, landingCandidate2.IsPlaneHit);
				}
				if ((!flag || landingCandidate2.IsPlaneHit) && (landingCandidate == null || SplineLandingSelector.IsBetter(landingCandidate2, landingCandidate)))
				{
					landingCandidate = landingCandidate2;
				}
			}
			if (landingCandidate == null)
			{
				return false;
			}
			outLocation.DeepCopy(landingCandidate.Location);
			if (enabled)
			{
				SceneInteractDebugDraw.DrawSplineLandingResult(jumpPointLocation, landingCandidate.Location, landingCandidate.IsPlaneHit, landingCandidate.DistToPlayer, SplineLandingSelector.CandidateCount, num);
			}
			return true;
		}

		// Token: 0x06043C62 RID: 277602 RVA: 0x01096DA0 File Offset: 0x01094FA0
		private static bool IsBetter(SplineLandingSelector.LandingCandidate a, SplineLandingSelector.LandingCandidate b)
		{
			return a.DistToPlayer < b.DistToPlayer - 100.0 || (b.DistToPlayer >= a.DistToPlayer - 100.0 && SplineLandingSelector.GetScreenCenterDistSq(a) < SplineLandingSelector.GetScreenCenterDistSq(b));
		}

		// Token: 0x06043C63 RID: 277603 RVA: 0x01096DEF File Offset: 0x01094FEF
		private static double GetScreenCenterDistSq(SplineLandingSelector.LandingCandidate candidate)
		{
			if (candidate.ScreenCenterDistSq == null)
			{
				candidate.ScreenCenterDistSq = new double?(SplineLandingSelector.CalcScreenCenterDistSq(candidate.Location));
			}
			return candidate.ScreenCenterDistSq.Value;
		}

		// Token: 0x06043C64 RID: 277604 RVA: 0x01096E20 File Offset: 0x01095020
		private static double CalcScreenCenterDistSq(Vector location)
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return double.MaxValue;
			}
			APlayerController player = characterController;
			FVectorDouble fvectorDouble = location.ToUeVector(false);
			if (!UGameplayStatics.D_ProjectWorldToScreen(player, fvectorDouble, ref SplineLandingSelector.RefScreenPos, false))
			{
				return double.MaxValue;
			}
			FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
			FVector2D refScreenPos = SplineLandingSelector.RefScreenPos;
			double num = (double)refScreenPos.X - (double)viewportSize.X * 0.5;
			double num2 = (double)refScreenPos.Y - (double)viewportSize.Y * 0.5;
			return num * num + num2 * num2;
		}

		// Token: 0x06043C65 RID: 277605 RVA: 0x01096EB0 File Offset: 0x010950B0
		[NullableContext(2)]
		private static SplineLandingSelector.LandingCandidate AcquireCandidate()
		{
			if (SplineLandingSelector.CandidateCount >= 258)
			{
				return null;
			}
			SplineLandingSelector.LandingCandidate landingCandidate = SplineLandingSelector.Candidates.ElementAtOrDefault(SplineLandingSelector.CandidateCount);
			if (landingCandidate == null)
			{
				landingCandidate = new SplineLandingSelector.LandingCandidate();
				SplineLandingSelector.Candidates.Add(landingCandidate);
			}
			SplineLandingSelector.CandidateCount++;
			landingCandidate.IsPlaneHit = false;
			landingCandidate.DistToPlayer = 0.0;
			landingCandidate.ScreenCenterDistSq = null;
			return landingCandidate;
		}

		// Token: 0x06043C66 RID: 277606 RVA: 0x01096F20 File Offset: 0x01095120
		private static Vector GetPlayerGravityDir(ISceneInteractSearchParams @params)
		{
			EntityHandle currentRoleEntityHandle = @params.CurrentRoleEntityHandle;
			BaseActorComponent baseActorComponent;
			if (currentRoleEntityHandle == null)
			{
				baseActorComponent = null;
			}
			else
			{
				WorldEntity entity = currentRoleEntityHandle.Entity;
				baseActorComponent = ((entity != null) ? entity.GetComponent<BaseActorComponent>() : null);
			}
			BaseActorComponent actorComp = baseActorComponent;
			return GravityUtils.Instance.GetGravityDirectForActor(actorComp);
		}

		// Token: 0x06043C67 RID: 277607 RVA: 0x01096F57 File Offset: 0x01095157
		public static void CreateStaticDefaultValue()
		{
			SplineLandingSelector.CandidateCount = 0;
			SplineLandingSelector.Candidates = new List<SplineLandingSelector.LandingCandidate>();
		}

		// Token: 0x06043C68 RID: 277608 RVA: 0x01096F69 File Offset: 0x01095169
		public static void ResetStaticDefaultValue()
		{
			SplineLandingSelector.CandidateCount = 0;
			SplineLandingSelector.Candidates = null;
		}

		// Token: 0x04023685 RID: 145029
		private const int MIN_SAMPLE_STEP = 50;

		// Token: 0x04023686 RID: 145030
		private const int MAX_SAMPLE_COUNT = 128;

		// Token: 0x04023687 RID: 145031
		private const int PLANE_HIT_EPSILON = 1;

		// Token: 0x04023688 RID: 145032
		private const int PLAYER_DIST_TOLERANCE = 100;

		// Token: 0x04023689 RID: 145033
		private const int MAX_CANDIDATE_COUNT = 258;

		// Token: 0x0402368A RID: 145034
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpCamToRole = Vector.Create();

		// Token: 0x0402368B RID: 145035
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpPlaneNormal = Vector.Create();

		// Token: 0x0402368C RID: 145036
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpSample = Vector.Create();

		// Token: 0x0402368D RID: 145037
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpLocalSample = Vector.Create();

		// Token: 0x0402368E RID: 145038
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpPrevSample = Vector.Create();

		// Token: 0x0402368F RID: 145039
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpToSample = Vector.Create();

		// Token: 0x04023690 RID: 145040
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpDelta = Vector.Create();

		// Token: 0x04023691 RID: 145041
		[StaticVariableRuleIgnore]
		private static FVector2D RefScreenPos = new FVector2D(0f, 0f);

		// Token: 0x04023692 RID: 145042
		private static List<SplineLandingSelector.LandingCandidate> Candidates;

		// Token: 0x04023693 RID: 145043
		private static int CandidateCount;

		// Token: 0x0200CB8F RID: 52111
		[NullableContext(0)]
		private class LandingCandidate
		{
			// Token: 0x0403D73A RID: 251706
			[Nullable(1)]
			public readonly Vector Location = Vector.Create();

			// Token: 0x0403D73B RID: 251707
			public bool IsPlaneHit;

			// Token: 0x0403D73C RID: 251708
			public double DistToPlayer;

			// Token: 0x0403D73D RID: 251709
			public double? ScreenCenterDistSq;
		}
	}
}
