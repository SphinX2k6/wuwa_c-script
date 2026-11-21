using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced
{
	// Token: 0x02005BF8 RID: 23544
	[NullableContext(1)]
	[Nullable(0)]
	public class PlacedExploreInteractPointSearchStrategy : SceneInteractSearchStrategy
	{
		// Token: 0x17006E28 RID: 28200
		// (get) Token: 0x06039D2F RID: 236847 RVA: 0x0103D054 File Offset: 0x0103B254
		public override int Priority
		{
			get
			{
				return 50;
			}
		}

		// Token: 0x06039D30 RID: 236848 RVA: 0x0103D058 File Offset: 0x0103B258
		[return: Nullable(2)]
		public override ISceneInteractPoint SelectBest(IReadOnlyList<ISceneInteractPoint> points, ISceneInteractSearchParams @params)
		{
			bool enabled = SceneInteractDebugDraw.Enabled;
			bool rangeDrawEnabled = SceneInteractDebugDraw.RangeDrawEnabled;
			this.HitBoxIdSet.Clear();
			InteractBoxQueryManager.Instance.QueryAll(@params.CurrentRoleLocation, this.HitBoxIdSet);
			if (this.HitBoxIdSet.Count == 0)
			{
				if (rangeDrawEnabled)
				{
					foreach (ISceneInteractPoint sceneInteractPoint in points)
					{
						PlacedExploreInteractPoint placedExploreInteractPoint = sceneInteractPoint as PlacedExploreInteractPoint;
						if (placedExploreInteractPoint != null)
						{
							SceneInteractDebugDraw.DrawRangeGateBoxes(placedExploreInteractPoint.GetEnableRangeId(), placedExploreInteractPoint.GetDisableRangeId(), placedExploreInteractPoint.GetEntityId());
						}
					}
				}
				return null;
			}
			this.EntityConditionCache.Clear();
			Vector currentRoleLocation = @params.CurrentRoleLocation;
			double num = -3.402823466E+38;
			PlacedExploreInteractPoint placedExploreInteractPoint2 = null;
			foreach (ISceneInteractPoint sceneInteractPoint2 in points)
			{
				PlacedExploreInteractPoint placedExploreInteractPoint3 = sceneInteractPoint2 as PlacedExploreInteractPoint;
				if (placedExploreInteractPoint3 != null)
				{
					placedExploreInteractPoint3.ClearResolvedSplineLanding();
					if (rangeDrawEnabled)
					{
						SceneInteractDebugDraw.DrawRangeGateBoxes(placedExploreInteractPoint3.GetEnableRangeId(), placedExploreInteractPoint3.GetDisableRangeId(), placedExploreInteractPoint3.GetEntityId());
					}
					if (!@params.IsInteractingPoint(placedExploreInteractPoint3) && this.HitBoxIdSet.Contains(placedExploreInteractPoint3.GetEnableRangeId()))
					{
						if (this.HitBoxIdSet.Contains(placedExploreInteractPoint3.GetDisableRangeId()))
						{
							if (enabled)
							{
								SceneInteractDebugDraw.DrawInRangePoint(currentRoleLocation, placedExploreInteractPoint3, null, "禁止交互区域", new int?(placedExploreInteractPoint3.GetEnableRangeId()));
							}
						}
						else if (!this.CheckEntityConditionCached(placedExploreInteractPoint3, this.EntityConditionCache))
						{
							if (enabled)
							{
								SceneInteractDebugDraw.DrawInRangePoint(currentRoleLocation, placedExploreInteractPoint3, null, "实体条件不满足", new int?(placedExploreInteractPoint3.GetEnableRangeId()));
							}
						}
						else if (!placedExploreInteractPoint3.CheckPointCondition())
						{
							if (enabled)
							{
								SceneInteractDebugDraw.DrawInRangePoint(currentRoleLocation, placedExploreInteractPoint3, null, "点位条件不满足", new int?(placedExploreInteractPoint3.GetEnableRangeId()));
							}
						}
						else
						{
							double lockWeight = placedExploreInteractPoint3.GetLockWeight(currentRoleLocation);
							if (enabled)
							{
								SceneInteractDebugDraw.DrawInRangePoint(currentRoleLocation, placedExploreInteractPoint3, new double?(lockWeight), null, new int?(placedExploreInteractPoint3.GetEnableRangeId()));
							}
							if (lockWeight > num)
							{
								num = lockWeight;
								placedExploreInteractPoint2 = placedExploreInteractPoint3;
							}
						}
					}
				}
			}
			if (placedExploreInteractPoint2 == null || num == -3.402823466E+38)
			{
				return null;
			}
			if (!SceneInteractScreenCheckUtils.IsLocationInScreen(placedExploreInteractPoint2.GetLocation()))
			{
				if (enabled)
				{
					SceneInteractDebugDraw.DrawSelectedPoint(currentRoleLocation, placedExploreInteractPoint2, num, "不在屏幕内");
				}
				return null;
			}
			if (this.IsBlocked(placedExploreInteractPoint2, @params))
			{
				if (enabled)
				{
					SceneInteractDebugDraw.DrawSelectedPoint(currentRoleLocation, placedExploreInteractPoint2, num, "被遮挡");
				}
				return null;
			}
			placedExploreInteractPoint2.TryResolveSplineLanding(@params);
			if (enabled)
			{
				SceneInteractDebugDraw.DrawSelectedPoint(currentRoleLocation, placedExploreInteractPoint2, num, null);
			}
			return placedExploreInteractPoint2;
		}

		// Token: 0x06039D31 RID: 236849 RVA: 0x0103D318 File Offset: 0x0103B518
		public override void Dispose()
		{
			this.BlockChecker.Dispose();
		}

		// Token: 0x06039D32 RID: 236850 RVA: 0x0103D328 File Offset: 0x0103B528
		private bool CheckEntityConditionCached(PlacedExploreInteractPoint point, Dictionary<int, bool> cache)
		{
			WorldEntity entity = point.GetEntityHandle().Entity;
			if (entity == null)
			{
				return false;
			}
			bool result;
			if (cache.TryGetValue(entity.Id, out result))
			{
				return result;
			}
			bool flag = point.CheckEntityCondition();
			cache.Add(entity.Id, flag);
			return flag;
		}

		// Token: 0x06039D33 RID: 236851 RVA: 0x0103D370 File Offset: 0x0103B570
		private bool IsBlocked(PlacedExploreInteractPoint point, ISceneInteractSearchParams @params)
		{
			Vector raycastDestLocation = point.GetRaycastDestLocation();
			return raycastDestLocation != null && this.BlockChecker.IsBlocked(raycastDestLocation, @params, point.UseTwoPhaseBlockCheck(), (bool checkResult, UTraceBaseElement element) => this.FilterTraceResult(point, checkResult, element), SceneInteractDebugDraw.Enabled, point.GetOwnerActor());
		}

		// Token: 0x06039D34 RID: 236852 RVA: 0x0103D3D8 File Offset: 0x0103B5D8
		private bool FilterTraceResult(PlacedExploreInteractPoint point, bool checkResult, UTraceBaseElement element)
		{
			if (!checkResult)
			{
				return false;
			}
			UKuroHitResult hitResult = element.HitResult;
			TArray<TWeakObjectPtr<AActor>> tarray = (hitResult != null) ? hitResult.Actors : null;
			if (tarray == null)
			{
				return false;
			}
			AActor ownerActor = point.GetOwnerActor();
			for (int i = 0; i < tarray.Num(); i++)
			{
				AActor aactor = tarray.Get(i).Get();
				if (aactor != null && aactor != ownerActor)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0401E8B7 RID: 125111
		private readonly SphereTraceBlockChecker BlockChecker = new SphereTraceBlockChecker("PlacedExploreInteractPointSearchStrategy_SelectBest");

		// Token: 0x0401E8B8 RID: 125112
		private readonly HashSet<int> HitBoxIdSet = new HashSet<int>();

		// Token: 0x0401E8B9 RID: 125113
		private readonly Dictionary<int, bool> EntityConditionCache = new Dictionary<int, bool>();

		// Token: 0x0401E8BA RID: 125114
		private const string PROFILE_KEY = "PlacedExploreInteractPointSearchStrategy_SelectBest";
	}
}
