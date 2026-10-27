using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E77 RID: 24183
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotUtil
	{
		// Token: 0x0603D815 RID: 251925 RVA: 0x00ED7CF8 File Offset: 0x00ED5EF8
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

		// Token: 0x0603D816 RID: 251926 RVA: 0x00ED7D5A File Offset: 0x00ED5F5A
		public static void GenerateSingleSplinePoints(USplineComponent splineComp, TArray<FVector2D> splinePoints)
		{
			splinePoints.Empty(true);
			AutoPilotUtil.GenerateSplinePoints(splineComp, 0.0, (double)splineComp.GetSplineLength(), splinePoints, true, true, null);
		}

		// Token: 0x0603D817 RID: 251927 RVA: 0x00ED7D80 File Offset: 0x00ED5F80
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

		// Token: 0x0603D818 RID: 251928 RVA: 0x00ED7E18 File Offset: 0x00ED6018
		public static double GetDistanceAlongSplineAtWorldLocation(USplineComponent splineComp, Vector location)
		{
			FVectorDouble fvectorDouble = location.ToUeVector(false);
			float inKey = splineComp.D_FindInputKeyClosestToWorldLocation(fvectorDouble);
			return (double)splineComp.GetDistanceAlongSplineAtSplineInputKey(inKey);
		}

		// Token: 0x0603D819 RID: 251929 RVA: 0x00ED7E40 File Offset: 0x00ED6040
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

		// Token: 0x0603D81A RID: 251930 RVA: 0x00ED7ED4 File Offset: 0x00ED60D4
		private static FVector2D GetPoint(double distance, USplineComponent splineComp)
		{
			FVectorDouble fvectorDouble = splineComp.D_GetLocationAtDistanceAlongSpline((float)distance, ESplineCoordinateSpace.World);
			AutoPilotUtil.TmpVector2D.Set(fvectorDouble.X, fvectorDouble.Y);
			MapUtil.WorldPosition2UiPosition2D(AutoPilotUtil.TmpVector2D, AutoPilotUtil.SplinePoint2D);
			return AutoPilotUtil.SplinePoint2D.ToUeVector2D(false);
		}

		// Token: 0x0603D81B RID: 251931 RVA: 0x00ED7F1C File Offset: 0x00ED611C
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

		// Token: 0x0603D81C RID: 251932 RVA: 0x00ED8078 File Offset: 0x00ED6278
		public static bool CheckReachEnd(USplineComponent splineComp, Vector startPoint, Vector endPoint, int reachEndThreshold = 1000)
		{
			double distanceAlongSplineAtWorldLocation = AutoPilotUtil.GetDistanceAlongSplineAtWorldLocation(splineComp, startPoint);
			return AutoPilotUtil.GetDistanceAlongSplineAtWorldLocation(splineComp, endPoint) - distanceAlongSplineAtWorldLocation < (double)reachEndThreshold;
		}

		// Token: 0x0603D81D RID: 251933 RVA: 0x00ED809C File Offset: 0x00ED629C
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

		// Token: 0x0603D81E RID: 251934 RVA: 0x00ED8168 File Offset: 0x00ED6368
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

		// Token: 0x04020191 RID: 131473
		[StaticVariableRuleIgnore]
		private static readonly Vector2D TmpVector2D = Vector2D.Create();

		// Token: 0x04020192 RID: 131474
		[StaticVariableRuleIgnore]
		private static readonly Vector2D SplinePoint2D = Vector2D.Create();

		// Token: 0x04020193 RID: 131475
		[StaticVariableRuleIgnore]
		private static readonly List<int> TmpArray = new List<int>();

		// Token: 0x04020194 RID: 131476
		[StaticVariableRuleIgnore]
		private static readonly Vector SplineLocation = Vector.Create();

		// Token: 0x04020195 RID: 131477
		[StaticVariableRuleIgnore]
		private static readonly Stat StatsObject0 = Stat.Create("GenerateSplinePoints", "", "");

		// Token: 0x04020196 RID: 131478
		[StaticVariableRuleIgnore]
		private static readonly Stat StatsObject1 = Stat.Create("IsNearRoadWay", "", "");

		// Token: 0x04020197 RID: 131479
		[StaticVariableRuleIgnore]
		private static readonly Stat StatsObject2 = Stat.Create("ProcessRoadwaySpline", "", "");

		// Token: 0x04020198 RID: 131480
		[StaticVariableRuleIgnore]
		private static readonly Stat StatsObject3 = Stat.Create("CheckReachEnd", "", "");

		// Token: 0x04020199 RID: 131481
		[StaticVariableRuleIgnore]
		private static readonly Stat StatsObject4 = Stat.Create("ProcessSplinePointsForAutoPilotRoute", "", "");

		// Token: 0x0402019A RID: 131482
		[StaticVariableRuleIgnore]
		private static readonly Stat StatsObject5 = Stat.Create("GetDistanceAlongSplineAtWorldLocation", "", "");
	}
}
