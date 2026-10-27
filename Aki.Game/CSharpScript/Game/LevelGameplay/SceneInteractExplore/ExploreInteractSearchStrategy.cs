using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplore
{
	// Token: 0x02006A94 RID: 27284
	[NullableContext(1)]
	[Nullable(0)]
	public class ExploreInteractSearchStrategy : SceneInteractSearchStrategy
	{
		// Token: 0x1700993C RID: 39228
		// (get) Token: 0x06043C9D RID: 277661 RVA: 0x01097B45 File Offset: 0x01095D45
		public override int Priority
		{
			get
			{
				return 50;
			}
		}

		// Token: 0x06043C9E RID: 277662 RVA: 0x01097B4C File Offset: 0x01095D4C
		[return: Nullable(2)]
		public override ISceneInteractPoint SelectBest(IReadOnlyList<ISceneInteractPoint> points, ISceneInteractSearchParams @params)
		{
			if (!this.CheckCurrentRoleGate(@params))
			{
				return null;
			}
			Vector currentRoleLocation = @params.CurrentRoleLocation;
			bool enabled = SceneInteractDebugDraw.Enabled;
			bool rangeDrawEnabled = SceneInteractDebugDraw.RangeDrawEnabled;
			double num = -3.402823466E+38;
			ExploreInteractPoint exploreInteractPoint = null;
			foreach (ISceneInteractPoint sceneInteractPoint in points)
			{
				ExploreInteractPoint exploreInteractPoint2 = sceneInteractPoint as ExploreInteractPoint;
				if (exploreInteractPoint2 != null)
				{
					exploreInteractPoint2.ClearResolvedSplineLanding();
					if (rangeDrawEnabled)
					{
						SceneInteractDebugDraw.DrawEntityTriggerRange(exploreInteractPoint2.GetEntityHandle());
					}
					if (!@params.IsInteractingPoint(sceneInteractPoint) && exploreInteractPoint2.CheckEntityCondition())
					{
						double lockWeight = exploreInteractPoint2.GetLockWeight(currentRoleLocation);
						if (enabled && exploreInteractPoint2.UseTwoPhaseBlockCheck())
						{
							SceneInteractDebugDraw.DrawInRangePoint(currentRoleLocation, exploreInteractPoint2, new double?(lockWeight), null, null);
						}
						if (lockWeight > num)
						{
							num = lockWeight;
							exploreInteractPoint = exploreInteractPoint2;
						}
					}
				}
			}
			if (exploreInteractPoint == null || num == -3.402823466E+38)
			{
				return null;
			}
			if (!SceneInteractScreenCheckUtils.IsLocationInScreen(exploreInteractPoint.GetLocation()))
			{
				if (enabled && exploreInteractPoint.UseTwoPhaseBlockCheck())
				{
					SceneInteractDebugDraw.DrawSelectedPoint(currentRoleLocation, exploreInteractPoint, num, "不在屏幕内");
				}
				return null;
			}
			if (this.IsBlocked(exploreInteractPoint, @params))
			{
				if (enabled && exploreInteractPoint.UseTwoPhaseBlockCheck())
				{
					SceneInteractDebugDraw.DrawSelectedPoint(currentRoleLocation, exploreInteractPoint, num, "被遮挡");
				}
				return null;
			}
			exploreInteractPoint.TryResolveSplineLanding(@params);
			if (enabled && exploreInteractPoint.UseTwoPhaseBlockCheck())
			{
				SceneInteractDebugDraw.DrawSelectedPoint(currentRoleLocation, exploreInteractPoint, num, null);
			}
			return exploreInteractPoint;
		}

		// Token: 0x06043C9F RID: 277663 RVA: 0x01097CC0 File Offset: 0x01095EC0
		public override void Dispose()
		{
			this.BlockChecker.Dispose();
		}

		// Token: 0x06043CA0 RID: 277664 RVA: 0x01097CD0 File Offset: 0x01095ED0
		private bool CheckCurrentRoleGate(ISceneInteractSearchParams @params)
		{
			EntityHandle currentRoleEntityHandle = @params.CurrentRoleEntityHandle;
			WorldEntity worldEntity = (currentRoleEntityHandle != null) ? currentRoleEntityHandle.Entity : null;
			if (worldEntity == null)
			{
				return false;
			}
			BaseTagComponent component = worldEntity.GetComponent<BaseTagComponent>();
			return component != null && !component.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.技能限制.禁止探索幻象技能"]) && component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]);
		}

		// Token: 0x06043CA1 RID: 277665 RVA: 0x01097D34 File Offset: 0x01095F34
		private bool IsBlocked(ExploreInteractPoint point, ISceneInteractSearchParams @params)
		{
			Vector raycastDestLocation = point.GetRaycastDestLocation();
			if (raycastDestLocation == null)
			{
				return false;
			}
			bool flag = point.UseTwoPhaseBlockCheck();
			return this.BlockChecker.IsBlocked(raycastDestLocation, @params, flag, (bool checkResult, UTraceBaseElement element) => point.FilterTraceResult(checkResult, element), flag && SceneInteractDebugDraw.Enabled, null);
		}

		// Token: 0x040236B2 RID: 145074
		private const string PROFILE_KEY = "ExploreInteractSearchStrategy_SelectBest";

		// Token: 0x040236B3 RID: 145075
		private readonly SphereTraceBlockChecker BlockChecker = new SphereTraceBlockChecker("ExploreInteractSearchStrategy_SelectBest");
	}
}
