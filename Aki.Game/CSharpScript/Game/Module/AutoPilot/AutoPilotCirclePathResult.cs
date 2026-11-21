using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Transport;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E4E RID: 20046
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotCirclePathResult
	{
		// Token: 0x060326BA RID: 206522 RVA: 0x00E246CC File Offset: 0x00E228CC
		public AutoPilotCirclePathResult(int circleId, bool isInCircle)
		{
			this.CircleId = circleId;
			this.IsInCircle = isInCircle;
			AutoPilotCircles? config = ConfigAutoPilotCirclesById.GetConfig(circleId, true);
			this.MapId = ((config != null) ? config.GetValueOrDefault().MapId : 0);
			this.CircleRoadWaysIds = ((config != null) ? config.GetValueOrDefault().GetWaySplinesArray() : null);
		}

		// Token: 0x060326BB RID: 206523 RVA: 0x00E24764 File Offset: 0x00E22964
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

		// Token: 0x060326BC RID: 206524 RVA: 0x00E24848 File Offset: 0x00E22A48
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

		// Token: 0x060326BD RID: 206525 RVA: 0x00E249A0 File Offset: 0x00E22BA0
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

		// Token: 0x060326BE RID: 206526 RVA: 0x00E24A44 File Offset: 0x00E22C44
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

		// Token: 0x060326BF RID: 206527 RVA: 0x00E24A81 File Offset: 0x00E22C81
		public bool GetIsInCircle()
		{
			return this.IsInCircle;
		}

		// Token: 0x0401ABCE RID: 109518
		public int MapId;

		// Token: 0x0401ABCF RID: 109519
		public int CircleId;

		// Token: 0x0401ABD0 RID: 109520
		[Nullable(2)]
		public int[] CircleRoadWaysIds;

		// Token: 0x0401ABD1 RID: 109521
		public readonly TArray<FVector2D> PathToCircleSplinePoints = new TArray<FVector2D>();

		// Token: 0x0401ABD2 RID: 109522
		private readonly List<UKuroRoadway> PathToCircleRoadWays = new List<UKuroRoadway>();

		// Token: 0x0401ABD3 RID: 109523
		private bool IsInCircle;

		// Token: 0x0401ABD4 RID: 109524
		public readonly global::Vector EnterCirclePoint = global::Vector.Create();

		// Token: 0x0401ABD5 RID: 109525
		private readonly Dictionary<int, List<double>> RoadWaySplinePointsMap = new Dictionary<int, List<double>>();
	}
}
