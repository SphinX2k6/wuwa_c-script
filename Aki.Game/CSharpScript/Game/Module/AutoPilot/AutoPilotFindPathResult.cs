using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Transport;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E51 RID: 20049
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotFindPathResult
	{
		// Token: 0x060326F4 RID: 206580 RVA: 0x00E25AD8 File Offset: 0x00E23CD8
		public AutoPilotFindPathResult()
		{
			this.CheckFindPathAutoPilotConditions = delegate(float? _)
			{
				AutoPilotModel instance = AutoPilotModel.Instance;
				if (!((instance != null) ? new bool?(instance.CheckCommonConditions()) : null).GetValueOrDefault())
				{
					return;
				}
				if (this.GetIsShowPlayerToTargetLine())
				{
					AutoPilotModel instance2 = AutoPilotModel.Instance;
					if (instance2 == null)
					{
						return;
					}
					instance2.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Disable, new AutoPilotDefine.EDisableAutoPilotReason?(AutoPilotDefine.EDisableAutoPilotReason.NoHighLightLine));
					return;
				}
				else
				{
					this.RefreshHasArriveStartPoint();
					if (this.GetHasArriveStartPoint())
					{
						AutoPilotModel instance3 = AutoPilotModel.Instance;
						if (instance3 == null)
						{
							return;
						}
						instance3.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Dest, null);
						return;
					}
					else
					{
						AutoPilotModel instance4 = AutoPilotModel.Instance;
						if (instance4 == null)
						{
							return;
						}
						instance4.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Disable, new AutoPilotDefine.EDisableAutoPilotReason?(AutoPilotDefine.EDisableAutoPilotReason.NotNearRoad));
						return;
					}
				}
			};
			AutoPilotController.Instance.AddTick(this.CheckFindPathAutoPilotConditions);
		}

		// Token: 0x1700624B RID: 25163
		// (get) Token: 0x060326F5 RID: 206581 RVA: 0x00E25B65 File Offset: 0x00E23D65
		public Vector PlayerPoint
		{
			get
			{
				AutoPilotModel instance = AutoPilotModel.Instance;
				Vector vector;
				if (instance == null)
				{
					vector = null;
				}
				else
				{
					CharacterActorComponent actorComp = instance.ActorComp;
					vector = ((actorComp != null) ? actorComp.ActorLocationProxy : null);
				}
				return vector ?? Vector.ZeroVectorProxy;
			}
		}

		// Token: 0x060326F6 RID: 206582 RVA: 0x00E25B8D File Offset: 0x00E23D8D
		public bool GetIsShowStartPoint()
		{
			AutoPilotModel instance = AutoPilotModel.Instance;
			return (instance == null || !instance.GetIsInAutoPilot()) && !this.HasArriveStartPoint && !this.GetIsShowPlayerToTargetLine();
		}

		// Token: 0x060326F7 RID: 206583 RVA: 0x00E25BB5 File Offset: 0x00E23DB5
		public bool GetIsShowEndPoint()
		{
			return !this.GetIsShowPlayerToTargetLine();
		}

		// Token: 0x060326F8 RID: 206584 RVA: 0x00E25BC2 File Offset: 0x00E23DC2
		public bool GetIsShowHighLightLine()
		{
			return !this.GetIsShowPlayerToTargetLine();
		}

		// Token: 0x060326F9 RID: 206585 RVA: 0x00E25BCF File Offset: 0x00E23DCF
		public bool GetIsShowPlayerToStartLine()
		{
			return this.GetIsShowStartPoint() && !this.GetIsShowPlayerToTargetLine();
		}

		// Token: 0x060326FA RID: 206586 RVA: 0x00E25BE4 File Offset: 0x00E23DE4
		public bool GetIsShowEndToTargetLine()
		{
			return this.GetIsShowEndPoint() && !this.GetIsShowPlayerToTargetLine();
		}

		// Token: 0x060326FB RID: 206587 RVA: 0x00E25BF9 File Offset: 0x00E23DF9
		public bool GetIsShowPlayerToTargetLine()
		{
			return this.IsShowPlayerToTargetLine;
		}

		// Token: 0x060326FC RID: 206588 RVA: 0x00E25C01 File Offset: 0x00E23E01
		[NullableContext(2)]
		public Vector GetTrackingPoint()
		{
			if (this.GetIsShowStartPoint())
			{
				return this.StartPoint;
			}
			if (this.GetIsShowEndPoint())
			{
				return this.EndPoint;
			}
			return null;
		}

		// Token: 0x060326FD RID: 206589 RVA: 0x00E25C24 File Offset: 0x00E23E24
		public void RefreshSplinePoints()
		{
			this.ClearRoadWaySplinePointsMap();
			if (this.Roadways.Length == 0)
			{
				return;
			}
			this.RefreshRoadWaySplinePointsMap();
			this.SplineDistance = AutoPilotUtil.GenerateAllSplinePoints(this.Roadways, this.SplinePoints, this.StartPoint, this.EndPoint, this.RoadWaySplinePointsMap);
		}

		// Token: 0x060326FE RID: 206590 RVA: 0x00E25C70 File Offset: 0x00E23E70
		private void ClearRoadWaySplinePointsMap()
		{
			foreach (List<double> list in this.RoadWaySplinePointsMap.Values)
			{
				list.Clear();
				this.RoadWaySplinePointsPool.Push(list);
			}
			this.RoadWaySplinePointsMap.Clear();
		}

		// Token: 0x060326FF RID: 206591 RVA: 0x00E25CE0 File Offset: 0x00E23EE0
		private void RefreshRoadWaySplinePointsMap()
		{
			foreach (UKuroRoadway ukuroRoadway in this.Roadways)
			{
				this.RoadWaySplinePointsMap[ukuroRoadway.Id] = (this.RoadWaySplinePointsPool.Pop() ?? new List<double>());
			}
		}

		// Token: 0x06032700 RID: 206592 RVA: 0x00E25D2B File Offset: 0x00E23F2B
		public double GetDistSquaredPlayerToEndPoint()
		{
			return this.DistSquaredPlayerToEndPointInner;
		}

		// Token: 0x06032701 RID: 206593 RVA: 0x00E25D34 File Offset: 0x00E23F34
		public void RefreshHasArriveStartPoint()
		{
			if (this.Roadways.Length == 0)
			{
				this.HasArriveStartPoint = false;
				return;
			}
			UKuroRoadway ukuroRoadway = this.Roadways[0];
			if (AutoPilotUtil.IsNearRoadWay(ukuroRoadway, this.PlayerPoint))
			{
				this.HasArriveStartPoint = true;
				return;
			}
			UKuroRoadway roadWay = TransportNetworkController.Instance.GetTransportSystem().GetRoadWay(ukuroRoadway.OpposingId);
			if (roadWay != null && AutoPilotUtil.IsNearRoadWay(roadWay, this.PlayerPoint))
			{
				this.HasArriveStartPoint = true;
				return;
			}
			this.HasArriveStartPoint = false;
		}

		// Token: 0x06032702 RID: 206594 RVA: 0x00E25DA7 File Offset: 0x00E23FA7
		public bool GetHasArriveStartPoint()
		{
			return this.HasArriveStartPoint;
		}

		// Token: 0x06032703 RID: 206595 RVA: 0x00E25DB0 File Offset: 0x00E23FB0
		[NullableContext(2)]
		public void SetIsShowPlayerToTargetLine(bool value, string reason = null)
		{
			if (this.IsShowPlayerToTargetLine != value)
			{
				if (value)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.AutoPilot;
					ELogAuthor author = ELogAuthor.CB;
					string message = "直接连接玩家和目标点";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				this.IsShowPlayerToTargetLine = value;
			}
		}

		// Token: 0x06032704 RID: 206596 RVA: 0x00E25DFC File Offset: 0x00E23FFC
		public void RefreshData(int mapId, Vector source, Vector desc, ITransportFindPathResult findPathResult)
		{
			this.MapId = mapId;
			this.LastFindPathPoint.FromUeVector(source);
			this.TargetPoint.FromUeVector(desc);
			Vector startPoint = this.StartPoint;
			FVectorDouble fvectorDouble = findPathResult.RoadStartPoint;
			startPoint.FromUeVector(fvectorDouble);
			this.Roadways = new UKuroRoadway[findPathResult.Roadways.Num()];
			for (int i = 0; i < findPathResult.Roadways.Num(); i++)
			{
				this.Roadways[i] = findPathResult.Roadways.Get(i);
			}
			Vector endPoint = this.EndPoint;
			fvectorDouble = findPathResult.RoadEndPoint;
			endPoint.FromUeVector(fvectorDouble);
			this.RefreshSplinePoints();
			if (this.SplineDistance < AutoPilotModel.Instance.GetSplineDistanceThreshold())
			{
				this.SetIsShowPlayerToTargetLine(true, "样条线距离过短");
				return;
			}
			double num = Vector.DistSquared2D(this.StartPoint, this.PlayerPoint);
			double num2 = Vector.DistSquared2D(this.EndPoint, this.TargetPoint);
			if (Vector.DistSquared2D(this.PlayerPoint, this.TargetPoint) < num + num2)
			{
				this.SetIsShowPlayerToTargetLine(true, "玩家到目标点距离<起点到切入点+切出点到目标点");
				return;
			}
			this.SetIsShowPlayerToTargetLine(false, null);
			this.DistSquaredPlayerToEndPointInner = Vector.DistSquared(this.PlayerPoint, this.EndPoint);
		}

		// Token: 0x06032705 RID: 206597 RVA: 0x00E25F20 File Offset: 0x00E24120
		public void RefreshDataInAutoPilot()
		{
			this.IsNeedForceRefresh = true;
			this.StartPoint.FromUeVector(this.PlayerPoint);
			this.DistSquaredPlayerToEndPointInner = Vector.DistSquared(this.PlayerPoint, this.EndPoint);
			AutoPilotModel instance = AutoPilotModel.Instance;
			int? num;
			if (instance == null)
			{
				num = null;
			}
			else
			{
				MotorcycleSplineMoveComponent splineMoveComp = instance.SplineMoveComp;
				if (splineMoveComp == null)
				{
					num = null;
				}
				else
				{
					SplineMoveParams currentSplineMoveParams = splineMoveComp.CurrentSplineMoveParams;
					num = ((currentSplineMoveParams != null) ? new int?(currentSplineMoveParams.CurrentRouteIndex) : null);
				}
			}
			int? num2 = num;
			if (num2 == null)
			{
				return;
			}
			int? num3 = num2;
			int num4 = this.Roadways.Length - 1;
			if ((num3.GetValueOrDefault() == num4 & num3 != null) && AutoPilotUtil.CheckReachEnd(this.Roadways[num2.Value].RoadSpline, this.StartPoint, this.EndPoint, 1000))
			{
				AutoPilotController.Instance.ExitAutoPilot("OnReachEndPoint", true).Forget();
				return;
			}
			AutoPilotUtil.ProcessSplinePointsForAutoPilotRoute(this.Roadways[num2.Value], this.SplinePoints, this.StartPoint, this.RoadWaySplinePointsMap);
		}

		// Token: 0x06032706 RID: 206598 RVA: 0x00E26034 File Offset: 0x00E24234
		[NullableContext(2)]
		public UKuroRoadway GetLastRoadWay()
		{
			if (this.Roadways.Length == 0)
			{
				return null;
			}
			return this.Roadways[this.Roadways.Length - 1];
		}

		// Token: 0x06032707 RID: 206599 RVA: 0x00E26054 File Offset: 0x00E24254
		[NullableContext(2)]
		public UAutopilotRoute GenerateAutopilotRoute()
		{
			if (this.Roadways == null)
			{
				return null;
			}
			List<int> list = new List<int>();
			foreach (UKuroRoadway ukuroRoadway in this.Roadways)
			{
				list.Add(ukuroRoadway.Id);
			}
			TransportNetworkController instance = TransportNetworkController.Instance;
			IEnumerable<int> idList = list;
			bool isLoop = false;
			AutoPilotModel instance2 = AutoPilotModel.Instance;
			return instance.GetAssembleAutopilotRoute(idList, isLoop, instance2 != null && instance2.IsDebugMode);
		}

		// Token: 0x06032708 RID: 206600 RVA: 0x00E260B4 File Offset: 0x00E242B4
		public bool IsNeedRefreshByFindPath(Vector location)
		{
			if (this.IsNeedForceRefresh)
			{
				this.IsNeedForceRefresh = false;
				return true;
			}
			if (this.Roadways.Length == 0)
			{
				return false;
			}
			double num = Vector.DistSquared(location, this.LastFindPathPoint);
			double num2 = AutoPilotModel.Instance.AutoPilotRoadWayWidthOffset;
			double num3 = (double)this.Roadways[0].Width / 2.0 + num2;
			double num4 = num3 * num3;
			return num > num4;
		}

		// Token: 0x06032709 RID: 206601 RVA: 0x00E26118 File Offset: 0x00E24318
		public FRotator? GetStartRotator()
		{
			if (this.Roadways.Length == 0)
			{
				return null;
			}
			double distanceAlongSplineAtWorldLocation = AutoPilotUtil.GetDistanceAlongSplineAtWorldLocation(this.Roadways[0].RoadSpline, this.StartPoint);
			USplineComponent roadSpline = this.Roadways[0].RoadSpline;
			if (roadSpline == null)
			{
				return null;
			}
			return new FRotator?(roadSpline.GetRotationAtDistanceAlongSpline((float)distanceAlongSplineAtWorldLocation, ESplineCoordinateSpace.World));
		}

		// Token: 0x0603270A RID: 206602 RVA: 0x00E26179 File Offset: 0x00E24379
		public void Clear()
		{
			AutoPilotController.Instance.RemoveTick(this.CheckFindPathAutoPilotConditions);
		}

		// Token: 0x0401ABF2 RID: 109554
		public int MapId;

		// Token: 0x0401ABF3 RID: 109555
		public Vector TargetPoint = Vector.Create();

		// Token: 0x0401ABF4 RID: 109556
		public Vector StartPoint = Vector.Create();

		// Token: 0x0401ABF5 RID: 109557
		public Vector EndPoint = Vector.Create();

		// Token: 0x0401ABF6 RID: 109558
		private readonly Vector LastFindPathPoint = Vector.Create();

		// Token: 0x0401ABF7 RID: 109559
		public UKuroRoadway[] Roadways = Array.Empty<UKuroRoadway>();

		// Token: 0x0401ABF8 RID: 109560
		public readonly TArray<FVector2D> SplinePoints = new TArray<FVector2D>();

		// Token: 0x0401ABF9 RID: 109561
		private double SplineDistance;

		// Token: 0x0401ABFA RID: 109562
		private bool IsShowPlayerToTargetLine;

		// Token: 0x0401ABFB RID: 109563
		private readonly Dictionary<int, List<double>> RoadWaySplinePointsMap = new Dictionary<int, List<double>>();

		// Token: 0x0401ABFC RID: 109564
		private readonly global::Stack<List<double>> RoadWaySplinePointsPool = new global::Stack<List<double>>();

		// Token: 0x0401ABFD RID: 109565
		private bool IsNeedForceRefresh;

		// Token: 0x0401ABFE RID: 109566
		private bool HasArriveStartPoint;

		// Token: 0x0401ABFF RID: 109567
		private double DistSquaredPlayerToEndPointInner;

		// Token: 0x0401AC00 RID: 109568
		public readonly Action<float?> CheckFindPathAutoPilotConditions;
	}
}
