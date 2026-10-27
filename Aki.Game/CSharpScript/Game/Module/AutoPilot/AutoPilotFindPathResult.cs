using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Transport;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E6C RID: 24172
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotFindPathResult
	{
		// Token: 0x0603D764 RID: 251748 RVA: 0x00ED4568 File Offset: 0x00ED2768
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

		// Token: 0x17008E79 RID: 36473
		// (get) Token: 0x0603D765 RID: 251749 RVA: 0x00ED45F5 File Offset: 0x00ED27F5
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

		// Token: 0x0603D766 RID: 251750 RVA: 0x00ED461D File Offset: 0x00ED281D
		public bool GetIsShowStartPoint()
		{
			AutoPilotModel instance = AutoPilotModel.Instance;
			return (instance == null || !instance.GetIsInAutoPilot()) && !this.HasArriveStartPoint && !this.GetIsShowPlayerToTargetLine();
		}

		// Token: 0x0603D767 RID: 251751 RVA: 0x00ED4645 File Offset: 0x00ED2845
		public bool GetIsShowEndPoint()
		{
			return !this.GetIsShowPlayerToTargetLine();
		}

		// Token: 0x0603D768 RID: 251752 RVA: 0x00ED4652 File Offset: 0x00ED2852
		public bool GetIsShowHighLightLine()
		{
			return !this.GetIsShowPlayerToTargetLine();
		}

		// Token: 0x0603D769 RID: 251753 RVA: 0x00ED465F File Offset: 0x00ED285F
		public bool GetIsShowPlayerToStartLine()
		{
			return this.GetIsShowStartPoint() && !this.GetIsShowPlayerToTargetLine();
		}

		// Token: 0x0603D76A RID: 251754 RVA: 0x00ED4674 File Offset: 0x00ED2874
		public bool GetIsShowEndToTargetLine()
		{
			return this.GetIsShowEndPoint() && !this.GetIsShowPlayerToTargetLine();
		}

		// Token: 0x0603D76B RID: 251755 RVA: 0x00ED4689 File Offset: 0x00ED2889
		public bool GetIsShowPlayerToTargetLine()
		{
			return this.IsShowPlayerToTargetLine;
		}

		// Token: 0x0603D76C RID: 251756 RVA: 0x00ED4691 File Offset: 0x00ED2891
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

		// Token: 0x0603D76D RID: 251757 RVA: 0x00ED46B4 File Offset: 0x00ED28B4
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

		// Token: 0x0603D76E RID: 251758 RVA: 0x00ED4700 File Offset: 0x00ED2900
		private void ClearRoadWaySplinePointsMap()
		{
			foreach (List<double> list in this.RoadWaySplinePointsMap.Values)
			{
				list.Clear();
				this.RoadWaySplinePointsPool.Push(list);
			}
			this.RoadWaySplinePointsMap.Clear();
		}

		// Token: 0x0603D76F RID: 251759 RVA: 0x00ED4770 File Offset: 0x00ED2970
		private void RefreshRoadWaySplinePointsMap()
		{
			foreach (UKuroRoadway ukuroRoadway in this.Roadways)
			{
				this.RoadWaySplinePointsMap[ukuroRoadway.Id] = (this.RoadWaySplinePointsPool.Pop() ?? new List<double>());
			}
		}

		// Token: 0x0603D770 RID: 251760 RVA: 0x00ED47BB File Offset: 0x00ED29BB
		public double GetDistSquaredPlayerToEndPoint()
		{
			return this.DistSquaredPlayerToEndPointInner;
		}

		// Token: 0x0603D771 RID: 251761 RVA: 0x00ED47C4 File Offset: 0x00ED29C4
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

		// Token: 0x0603D772 RID: 251762 RVA: 0x00ED4837 File Offset: 0x00ED2A37
		public bool GetHasArriveStartPoint()
		{
			return this.HasArriveStartPoint;
		}

		// Token: 0x0603D773 RID: 251763 RVA: 0x00ED4840 File Offset: 0x00ED2A40
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

		// Token: 0x0603D774 RID: 251764 RVA: 0x00ED488C File Offset: 0x00ED2A8C
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

		// Token: 0x0603D775 RID: 251765 RVA: 0x00ED49B0 File Offset: 0x00ED2BB0
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

		// Token: 0x0603D776 RID: 251766 RVA: 0x00ED4AC4 File Offset: 0x00ED2CC4
		[NullableContext(2)]
		public UKuroRoadway GetLastRoadWay()
		{
			if (this.Roadways.Length == 0)
			{
				return null;
			}
			return this.Roadways[this.Roadways.Length - 1];
		}

		// Token: 0x0603D777 RID: 251767 RVA: 0x00ED4AE4 File Offset: 0x00ED2CE4
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

		// Token: 0x0603D778 RID: 251768 RVA: 0x00ED4B44 File Offset: 0x00ED2D44
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

		// Token: 0x0603D779 RID: 251769 RVA: 0x00ED4BA8 File Offset: 0x00ED2DA8
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

		// Token: 0x0603D77A RID: 251770 RVA: 0x00ED4C09 File Offset: 0x00ED2E09
		public void Clear()
		{
			AutoPilotController.Instance.RemoveTick(this.CheckFindPathAutoPilotConditions);
		}

		// Token: 0x0402012B RID: 131371
		public int MapId;

		// Token: 0x0402012C RID: 131372
		public Vector TargetPoint = Vector.Create();

		// Token: 0x0402012D RID: 131373
		public Vector StartPoint = Vector.Create();

		// Token: 0x0402012E RID: 131374
		public Vector EndPoint = Vector.Create();

		// Token: 0x0402012F RID: 131375
		private readonly Vector LastFindPathPoint = Vector.Create();

		// Token: 0x04020130 RID: 131376
		public UKuroRoadway[] Roadways = Array.Empty<UKuroRoadway>();

		// Token: 0x04020131 RID: 131377
		public readonly TArray<FVector2D> SplinePoints = new TArray<FVector2D>();

		// Token: 0x04020132 RID: 131378
		private double SplineDistance;

		// Token: 0x04020133 RID: 131379
		private bool IsShowPlayerToTargetLine;

		// Token: 0x04020134 RID: 131380
		private readonly Dictionary<int, List<double>> RoadWaySplinePointsMap = new Dictionary<int, List<double>>();

		// Token: 0x04020135 RID: 131381
		private readonly global::Stack<List<double>> RoadWaySplinePointsPool = new global::Stack<List<double>>();

		// Token: 0x04020136 RID: 131382
		private bool IsNeedForceRefresh;

		// Token: 0x04020137 RID: 131383
		private bool HasArriveStartPoint;

		// Token: 0x04020138 RID: 131384
		private double DistSquaredPlayerToEndPointInner;

		// Token: 0x04020139 RID: 131385
		public readonly Action<float?> CheckFindPathAutoPilotConditions;
	}
}
