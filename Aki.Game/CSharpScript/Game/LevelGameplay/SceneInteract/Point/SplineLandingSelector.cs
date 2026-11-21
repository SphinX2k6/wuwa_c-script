using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point
{
	// Token: 0x02005BE5 RID: 23525
	[NullableContext(1)]
	[Nullable(0)]
	public class SplineLandingSelector : IStaticVariableResetter
	{
		// Token: 0x06039CAB RID: 236715 RVA: 0x0103B1F4 File Offset: 0x010393F4
		static SplineLandingSelector()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SplineLandingSelector.CreateStaticDefaultValue), new Action(SplineLandingSelector.ResetStaticDefaultValue));
		}

		// Token: 0x06039CAC RID: 236716 RVA: 0x0103B278 File Offset: 0x01039478
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

		// Token: 0x06039CAD RID: 236717 RVA: 0x0103B328 File Offset: 0x01039528
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

		// Token: 0x06039CAE RID: 236718 RVA: 0x0103B498 File Offset: 0x01039698
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

		// Token: 0x06039CAF RID: 236719 RVA: 0x0103B510 File Offset: 0x01039710
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

		// Token: 0x06039CB0 RID: 236720 RVA: 0x0103B5E0 File Offset: 0x010397E0
		private static bool IsBetter(SplineLandingSelector.LandingCandidate a, SplineLandingSelector.LandingCandidate b)
		{
			return a.DistToPlayer < b.DistToPlayer - 100.0 || (b.DistToPlayer >= a.DistToPlayer - 100.0 && SplineLandingSelector.GetScreenCenterDistSq(a) < SplineLandingSelector.GetScreenCenterDistSq(b));
		}

		// Token: 0x06039CB1 RID: 236721 RVA: 0x0103B62F File Offset: 0x0103982F
		private static double GetScreenCenterDistSq(SplineLandingSelector.LandingCandidate candidate)
		{
			if (candidate.ScreenCenterDistSq == null)
			{
				candidate.ScreenCenterDistSq = new double?(SplineLandingSelector.CalcScreenCenterDistSq(candidate.Location));
			}
			return candidate.ScreenCenterDistSq.Value;
		}

		// Token: 0x06039CB2 RID: 236722 RVA: 0x0103B660 File Offset: 0x01039860
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

		// Token: 0x06039CB3 RID: 236723 RVA: 0x0103B6F0 File Offset: 0x010398F0
		[NullableContext(2)]
		private static SplineLandingSelector.LandingCandidate AcquireCandidate()
		{
			if (SplineLandingSelector.CandidateCount >= 258)
			{
				return null;
			}
			SplineLandingSelector.LandingCandidate landingCandidate = (SplineLandingSelector.CandidateCount < SplineLandingSelector.Candidates.Count) ? SplineLandingSelector.Candidates[SplineLandingSelector.CandidateCount] : null;
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

		// Token: 0x06039CB4 RID: 236724 RVA: 0x0103B774 File Offset: 0x01039974
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

		// Token: 0x06039CB5 RID: 236725 RVA: 0x0103B7AB File Offset: 0x010399AB
		public static void CreateStaticDefaultValue()
		{
			SplineLandingSelector.CandidateCount = 0;
			SplineLandingSelector.Candidates = new List<SplineLandingSelector.LandingCandidate>();
		}

		// Token: 0x06039CB6 RID: 236726 RVA: 0x0103B7BD File Offset: 0x010399BD
		public static void ResetStaticDefaultValue()
		{
			SplineLandingSelector.CandidateCount = 0;
			SplineLandingSelector.Candidates = null;
		}

		// Token: 0x0401E877 RID: 125047
		private const int MIN_SAMPLE_STEP = 50;

		// Token: 0x0401E878 RID: 125048
		private const int MAX_SAMPLE_COUNT = 128;

		// Token: 0x0401E879 RID: 125049
		private const int PLANE_HIT_EPSILON = 1;

		// Token: 0x0401E87A RID: 125050
		private const int PLAYER_DIST_TOLERANCE = 100;

		// Token: 0x0401E87B RID: 125051
		private const int MAX_CANDIDATE_COUNT = 258;

		// Token: 0x0401E87C RID: 125052
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpCamToRole = Vector.Create();

		// Token: 0x0401E87D RID: 125053
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpPlaneNormal = Vector.Create();

		// Token: 0x0401E87E RID: 125054
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpSample = Vector.Create();

		// Token: 0x0401E87F RID: 125055
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpLocalSample = Vector.Create();

		// Token: 0x0401E880 RID: 125056
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpPrevSample = Vector.Create();

		// Token: 0x0401E881 RID: 125057
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpToSample = Vector.Create();

		// Token: 0x0401E882 RID: 125058
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpDelta = Vector.Create();

		// Token: 0x0401E883 RID: 125059
		[StaticVariableRuleIgnore]
		private static FVector2D RefScreenPos = new FVector2D(0f, 0f);

		// Token: 0x0401E884 RID: 125060
		private static List<SplineLandingSelector.LandingCandidate> Candidates;

		// Token: 0x0401E885 RID: 125061
		private static int CandidateCount;

		// Token: 0x0200B76E RID: 46958
		[NullableContext(0)]
		private class LandingCandidate
		{
			// Token: 0x04038B1C RID: 232220
			[Nullable(1)]
			public readonly Vector Location = Vector.Create();

			// Token: 0x04038B1D RID: 232221
			public bool IsPlaneHit;

			// Token: 0x04038B1E RID: 232222
			public double DistToPlayer;

			// Token: 0x04038B1F RID: 232223
			public double? ScreenCenterDistSq;
		}
	}
}
