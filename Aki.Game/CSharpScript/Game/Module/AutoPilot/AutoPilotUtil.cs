using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E5C RID: 20060
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotUtil
	{
		// Token: 0x060327A5 RID: 206757 RVA: 0x00E29284 File Offset: 0x00E27484
		public static double GenerateAllSplinePoints(UKuroRoadway[] roadways, TArray<FVector2D> splinePoints, [Nullable(2)] Vector startPoint = null, [Nullable(2)] Vector endPoint = null, [Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<int, List<double>> roadWaySplinePointsMap = null)
		{
			splinePoints.Empty(true);
			double num = 0.0;
			int num2 = roadways.Length;
			for (int i = 0; i < num2; i++)
			{
				UKuroRoadway ukuroRoadway = roadways[i];
				USplineComponent roadSpline = ukuroRoadway.RoadSpline;
				if (roadSpline != null)
				{
					num += AutoPilotUtil.ProcessRoadwaySpline(roadSpline, i, num2, splinePoints, startPoint, endPoint, (roadWaySplinePointsMap != null) ? roadWaySplinePointsMap.GetValueOrDefault(ukuroRoadway.Id) : null);
				}
			}
			return num;
		}

		// Token: 0x060327A6 RID: 206758 RVA: 0x00E292E6 File Offset: 0x00E274E6
		public static void GenerateSingleSplinePoints(USplineComponent splineComp, TArray<FVector2D> splinePoints)
		{
			splinePoints.Empty(true);
			AutoPilotUtil.GenerateSplinePoints(splineComp, 0.0, (double)splineComp.GetSplineLength(), splinePoints, true, true, null);
		}

		// Token: 0x060327A7 RID: 206759 RVA: 0x00E2930C File Offset: 0x00E2750C
		[NullableContext(2)]
		private static double ProcessRoadwaySpline([Nullable(1)] USplineComponent splineComp, int index, int totalRoadways, [Nullable(1)] TArray<FVector2D> splinePoints, Vector startPoint = null, Vector endPoint = null, List<double> splinePointsDistanceArr = null)
		{
			float splineLength = splineComp.GetSplineLength();
			double num = 0.0;
			double num2 = (double)splineLength;
			bool isAddStartPoint = false;
			bool isAddEndPoint = false;
			double result;
			if (totalRoadways == 1 && startPoint != null && endPoint != null)
			{
				num = AutoPilotUtil.GetDistanceAlongSplineAtWorldLocation(splineComp, startPoint);
				num2 = AutoPilotUtil.GetDistanceAlongSplineAtWorldLocation(splineComp, endPoint);
				result = num2 - num;
				isAddStartPoint = true;
				isAddEndPoint = true;
			}
			else if (index == 0 && startPoint != null)
			{
				num = AutoPilotUtil.GetDistanceAlongSplineAtWorldLocation(splineComp, startPoint);
				result = (double)splineLength - num;
				isAddStartPoint = true;
			}
			else if (index == totalRoadways - 1 && endPoint != null)
			{
				num2 = AutoPilotUtil.GetDistanceAlongSplineAtWorldLocation(splineComp, endPoint);
				result = num2;
				isAddEndPoint = true;
			}
			else
			{
				result = (double)splineLength;
			}
			AutoPilotUtil.GenerateSplinePoints(splineComp, num, num2, splinePoints, isAddStartPoint, isAddEndPoint, splinePointsDistanceArr);
			return result;
		}

		// Token: 0x060327A8 RID: 206760 RVA: 0x00E293A4 File Offset: 0x00E275A4
		public static double GetDistanceAlongSplineAtWorldLocation(USplineComponent splineComp, Vector location)
		{
			FVectorDouble fvectorDouble = location.ToUeVector(false);
			float inKey = splineComp.D_FindInputKeyClosestToWorldLocation(fvectorDouble);
			return (double)splineComp.GetDistanceAlongSplineAtSplineInputKey(inKey);
		}

		// Token: 0x060327A9 RID: 206761 RVA: 0x00E293CC File Offset: 0x00E275CC
		public static void GenerateSplinePoints(USplineComponent splineComp, double startDistance, double endDistance, TArray<FVector2D> splinePoints, bool isAddStartPoint, bool isAddEndPoint, [Nullable(2)] List<double> splinePointsDistanceArr = null)
		{
			double num = endDistance - startDistance;
			double highLightSampleDist = AutoPilotModel.Instance.HighLightSampleDist;
			if (num < highLightSampleDist)
			{
				return;
			}
			if (isAddStartPoint)
			{
				splinePoints.Add(AutoPilotUtil.GetPoint(startDistance, splineComp));
				if (splinePointsDistanceArr != null)
				{
					splinePointsDistanceArr.Add(startDistance);
				}
			}
			int num2 = (int)Math.Floor(num / highLightSampleDist);
			for (int i = 1; i <= num2; i++)
			{
				double num3 = startDistance + (double)i * highLightSampleDist;
				splinePoints.Add(AutoPilotUtil.GetPoint(num3, splineComp));
				if (splinePointsDistanceArr != null)
				{
					splinePointsDistanceArr.Add(num3);
				}
			}
			if (isAddEndPoint)
			{
				splinePoints.Add(AutoPilotUtil.GetPoint(endDistance, splineComp));
				if (splinePointsDistanceArr != null)
				{
					splinePointsDistanceArr.Add(endDistance);
				}
			}
		}

		// Token: 0x060327AA RID: 206762 RVA: 0x00E29460 File Offset: 0x00E27660
		private static FVector2D GetPoint(double distance, USplineComponent splineComp)
		{
			FVectorDouble fvectorDouble = splineComp.D_GetLocationAtDistanceAlongSpline((float)distance, ESplineCoordinateSpace.World);
			AutoPilotUtil.TmpVector2D.Set(fvectorDouble.X, fvectorDouble.Y);
			MapUtil.WorldPosition2UiPosition2D(AutoPilotUtil.TmpVector2D, AutoPilotUtil.SplinePoint2D);
			return AutoPilotUtil.SplinePoint2D.ToUeVector2D(false);
		}

		// Token: 0x060327AB RID: 206763 RVA: 0x00E294A8 File Offset: 0x00E276A8
		public static void ProcessSplinePointsForAutoPilotRoute(UKuroRoadway roadway, TArray<FVector2D> splinePoints, Vector startPoint, Dictionary<int, List<double>> roadWaySplinePointsMap)
		{
			if (!roadWaySplinePointsMap.ContainsKey(roadway.Id))
			{
				return;
			}
			double distanceAlongSplineAtWorldLocation = AutoPilotUtil.GetDistanceAlongSplineAtWorldLocation(roadway.RoadSpline, startPoint);
			int num = 0;
			AutoPilotUtil.TmpArray.Clear();
			foreach (KeyValuePair<int, List<double>> keyValuePair in roadWaySplinePointsMap)
			{
				int num2;
				List<double> list;
				keyValuePair.Deconstruct(out num2, out list);
				int num3 = num2;
				List<double> list2 = list;
				if (num3 != roadway.Id)
				{
					num += list2.Count;
					AutoPilotUtil.TmpArray.Add(num3);
				}
				else
				{
					int num4 = 0;
					for (int i = 0; i < list2.Count; i++)
					{
						if (distanceAlongSplineAtWorldLocation - list2[i] >= AutoPilotModel.Instance.HighLightSampleDist)
						{
							num4 = i + 1;
							break;
						}
					}
					if (num4 > 0)
					{
						list2.RemoveRange(0, num4);
						num += num4;
						break;
					}
					break;
				}
			}
			for (int j = 0; j < num; j++)
			{
				if (splinePoints.Num() > 0)
				{
					splinePoints.RemoveAt(0);
				}
			}
			foreach (int key in AutoPilotUtil.TmpArray)
			{
				roadWaySplinePointsMap.Remove(key);
			}
		}

		// Token: 0x060327AC RID: 206764 RVA: 0x00E29604 File Offset: 0x00E27804
		public static bool CheckReachEnd(USplineComponent splineComp, Vector startPoint, Vector endPoint, int reachEndThreshold = 1000)
		{
			double distanceAlongSplineAtWorldLocation = AutoPilotUtil.GetDistanceAlongSplineAtWorldLocation(splineComp, startPoint);
			return AutoPilotUtil.GetDistanceAlongSplineAtWorldLocation(splineComp, endPoint) - distanceAlongSplineAtWorldLocation < (double)reachEndThreshold;
		}

		// Token: 0x060327AD RID: 206765 RVA: 0x00E29628 File Offset: 0x00E27828
		public static bool IsNearRoadWay(UKuroRoadway roadWay, Vector location)
		{
			if (roadWay.RoadSpline == null)
			{
				return false;
			}
			USplineComponent roadSpline = roadWay.RoadSpline;
			FVectorDouble fvectorDouble = location.ToUeVector(false);
			float inKey = roadSpline.D_FindInputKeyClosestToWorldLocation(fvectorDouble);
			FVectorDouble center = roadWay.RoadSpline.D_GetLocationAtSplineInputKey(inKey, ESplineCoordinateSpace.World);
			if (AutoPilotModel.Instance.IsDebugMode)
			{
				int num = 30;
				int num2 = 30;
				FLinearColor value = new FLinearColor(1f, 0f, 0f, 0f);
				UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, center, (float)num, 30, new FLinearColor?(value), (float)num2, 0f);
			}
			AutoPilotUtil.SplineLocation.FromUeVector(center);
			double num3 = Vector.DistSquared(location, AutoPilotUtil.SplineLocation);
			double num4 = AutoPilotModel.Instance.AutoPilotRoadWayWidthOffset;
			double num5 = (double)roadWay.Width / 2.0 + num4;
			double num6 = num5 * num5;
			return num3 <= num6;
		}

		// Token: 0x060327AE RID: 206766 RVA: 0x00E296F4 File Offset: 0x00E278F4
		public static UniTask TeleportToTarget(string reason, FVectorDouble targetPos, FRotator? targetRotator = null)
		{
			AutoPilotUtil.<TeleportToTarget>d__19 <TeleportToTarget>d__;
			<TeleportToTarget>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TeleportToTarget>d__.reason = reason;
			<TeleportToTarget>d__.targetPos = targetPos;
			<TeleportToTarget>d__.targetRotator = targetRotator;
			<TeleportToTarget>d__.<>1__state = -1;
			<TeleportToTarget>d__.<>t__builder.Start<AutoPilotUtil.<TeleportToTarget>d__19>(ref <TeleportToTarget>d__);
			return <TeleportToTarget>d__.<>t__builder.Task;
		}

		// Token: 0x0401AC58 RID: 109656
		[StaticVariableRuleIgnore]
		private static readonly Vector2D TmpVector2D = Vector2D.Create();

		// Token: 0x0401AC59 RID: 109657
		[StaticVariableRuleIgnore]
		private static readonly Vector2D SplinePoint2D = Vector2D.Create();

		// Token: 0x0401AC5A RID: 109658
		[StaticVariableRuleIgnore]
		private static readonly List<int> TmpArray = new List<int>();

		// Token: 0x0401AC5B RID: 109659
		[StaticVariableRuleIgnore]
		private static readonly Vector SplineLocation = Vector.Create();

		// Token: 0x0401AC5C RID: 109660
		[StaticVariableRuleIgnore]
		private static readonly Stat StatsObject0 = Stat.Create("GenerateSplinePoints", "", "");

		// Token: 0x0401AC5D RID: 109661
		[StaticVariableRuleIgnore]
		private static readonly Stat StatsObject1 = Stat.Create("IsNearRoadWay", "", "");

		// Token: 0x0401AC5E RID: 109662
		[StaticVariableRuleIgnore]
		private static readonly Stat StatsObject2 = Stat.Create("ProcessRoadwaySpline", "", "");

		// Token: 0x0401AC5F RID: 109663
		[StaticVariableRuleIgnore]
		private static readonly Stat StatsObject3 = Stat.Create("CheckReachEnd", "", "");

		// Token: 0x0401AC60 RID: 109664
		[StaticVariableRuleIgnore]
		private static readonly Stat StatsObject4 = Stat.Create("ProcessSplinePointsForAutoPilotRoute", "", "");

		// Token: 0x0401AC61 RID: 109665
		[StaticVariableRuleIgnore]
		private static readonly Stat StatsObject5 = Stat.Create("GetDistanceAlongSplineAtWorldLocation", "", "");
	}
}
