using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Transport;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E69 RID: 24169
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotCirclePathResult
	{
		// Token: 0x0603D72A RID: 251690 RVA: 0x00ED315C File Offset: 0x00ED135C
		public AutoPilotCirclePathResult(int circleId, bool isInCircle)
		{
			this.CircleId = circleId;
			this.IsInCircle = isInCircle;
			AutoPilotCircles? config = ConfigAutoPilotCirclesById.GetConfig(circleId, true);
			this.MapId = ((config != null) ? config.GetValueOrDefault().MapId : 0);
			this.CircleRoadWaysIds = ((config != null) ? config.GetValueOrDefault().GetWaySplinesArray() : null);
		}

		// Token: 0x0603D72B RID: 251691 RVA: 0x00ED31F4 File Offset: 0x00ED13F4
		public void RefreshPathToCircleDataInAutoPilot(float? _ = null)
		{
			CharacterActorComponent actorComp = AutoPilotModel.Instance.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			MotorcycleSplineMoveComponent splineMoveComp = AutoPilotModel.Instance.SplineMoveComp;
			int? num;
			if (splineMoveComp == null)
			{
				num = null;
			}
			else
			{
				SplineMoveParams currentSplineMoveParams = splineMoveComp.CurrentSplineMoveParams;
				num = ((currentSplineMoveParams != null) ? new int?(currentSplineMoveParams.CurrentRouteIndex) : null);
			}
			int? num2 = num;
			if (num2 == null)
			{
				return;
			}
			int? num3 = num2;
			int num4 = this.PathToCircleRoadWays.Count - 1;
			if ((num3.GetValueOrDefault() == num4 & num3 != null) && AutoPilotUtil.CheckReachEnd(this.PathToCircleRoadWays[num2.Value].RoadSpline, actorComp.ActorLocationProxy, this.EnterCirclePoint, 1000))
			{
				this.RefreshIsInCircle(true);
				return;
			}
			AutoPilotUtil.ProcessSplinePointsForAutoPilotRoute(this.PathToCircleRoadWays[num2.Value], this.PathToCircleSplinePoints, actorComp.ActorLocationProxy, this.RoadWaySplinePointsMap);
		}

		// Token: 0x0603D72C RID: 251692 RVA: 0x00ED32D8 File Offset: 0x00ED14D8
		public void RefreshPathToCircleData()
		{
			if (this.IsInCircle)
			{
				return;
			}
			int enterCircleRoadId = AutoPilotModel.Instance.EnterCircleRoadId;
			if (enterCircleRoadId == 0)
			{
				return;
			}
			UKuroRoadway roadWay = TransportNetworkController.Instance.GetTransportSystem().GetRoadWay(enterCircleRoadId);
			FVectorDouble? fvectorDouble;
			if (roadWay == null)
			{
				fvectorDouble = null;
			}
			else
			{
				USplineComponent roadSpline = roadWay.RoadSpline;
				fvectorDouble = ((roadSpline != null) ? new FVectorDouble?(roadSpline.D_GetLocationAtSplinePoint(1, ESplineCoordinateSpace.World)) : null);
			}
			FVectorDouble? fvectorDouble2 = fvectorDouble;
			if (fvectorDouble2 == null)
			{
				return;
			}
			global::Vector enterCirclePoint = this.EnterCirclePoint;
			FVectorDouble value = fvectorDouble2.Value;
			enterCirclePoint.FromUeVector(value);
			CharacterActorComponent actorComp = AutoPilotModel.Instance.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			ITransportFindPathResult transportFindPathResult = TransportNetworkController.Instance.FindPath(actorComp.ActorLocationProxy, this.EnterCirclePoint, true, false, AutoPilotModel.Instance.IsDebugMode);
			if (transportFindPathResult == null)
			{
				return;
			}
			this.PathToCircleRoadWays.Clear();
			int num = transportFindPathResult.Roadways.Num();
			for (int i = 0; i < num; i++)
			{
				UKuroRoadway ukuroRoadway = transportFindPathResult.Roadways.Get(i);
				this.PathToCircleRoadWays.Add(ukuroRoadway);
				this.RoadWaySplinePointsMap[ukuroRoadway.Id] = new List<double>();
			}
			AutoPilotUtil.GenerateAllSplinePoints(this.PathToCircleRoadWays.ToArray(), this.PathToCircleSplinePoints, actorComp.ActorLocationProxy, this.EnterCirclePoint, this.RoadWaySplinePointsMap);
			AutoPilotController.Instance.AddTick(new Action<float?>(this.RefreshPathToCircleDataInAutoPilot));
		}

		// Token: 0x0603D72D RID: 251693 RVA: 0x00ED3430 File Offset: 0x00ED1630
		[NullableContext(2)]
		public UAutopilotRoute GenerateAutopilotRoute()
		{
			if (!this.IsInCircle)
			{
				List<int> list = new List<int>();
				foreach (UKuroRoadway ukuroRoadway in this.PathToCircleRoadWays)
				{
					list.Add(ukuroRoadway.Id);
				}
				return TransportNetworkController.Instance.GetAssembleAutopilotRoute(list, false, AutoPilotModel.Instance.IsDebugMode);
			}
			if (this.CircleRoadWaysIds == null)
			{
				return null;
			}
			return TransportNetworkController.Instance.GetAssembleAutopilotRoute(this.CircleRoadWaysIds, true, AutoPilotModel.Instance.IsDebugMode);
		}

		// Token: 0x0603D72E RID: 251694 RVA: 0x00ED34D4 File Offset: 0x00ED16D4
		public void RefreshIsInCircle(bool isInCircle)
		{
			if (this.IsInCircle == isInCircle)
			{
				return;
			}
			this.IsInCircle = isInCircle;
			if (isInCircle)
			{
				AutoPilotController.Instance.RemoveTick(new Action<float?>(this.RefreshPathToCircleDataInAutoPilot));
			}
			EventSystem.Instance.Emit<bool>(EEventName.OnCircleStateChange, isInCircle);
		}

		// Token: 0x0603D72F RID: 251695 RVA: 0x00ED3511 File Offset: 0x00ED1711
		public bool GetIsInCircle()
		{
			return this.IsInCircle;
		}

		// Token: 0x04020107 RID: 131335
		public int MapId;

		// Token: 0x04020108 RID: 131336
		public int CircleId;

		// Token: 0x04020109 RID: 131337
		[Nullable(2)]
		public int[] CircleRoadWaysIds;

		// Token: 0x0402010A RID: 131338
		public readonly TArray<FVector2D> PathToCircleSplinePoints = new TArray<FVector2D>();

		// Token: 0x0402010B RID: 131339
		private readonly List<UKuroRoadway> PathToCircleRoadWays = new List<UKuroRoadway>();

		// Token: 0x0402010C RID: 131340
		private bool IsInCircle;

		// Token: 0x0402010D RID: 131341
		public readonly global::Vector EnterCirclePoint = global::Vector.Create();

		// Token: 0x0402010E RID: 131342
		private readonly Dictionary<int, List<double>> RoadWaySplinePointsMap = new Dictionary<int, List<double>>();
	}
}
