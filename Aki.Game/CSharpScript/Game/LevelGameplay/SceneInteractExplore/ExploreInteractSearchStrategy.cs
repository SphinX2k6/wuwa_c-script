using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplore
{
	// Token: 0x02005BF1 RID: 23537
	[NullableContext(1)]
	[Nullable(0)]
	public class ExploreInteractSearchStrategy : SceneInteractSearchStrategy
	{
		// Token: 0x17006E21 RID: 28193
		// (get) Token: 0x06039CEB RID: 236779 RVA: 0x0103C399 File Offset: 0x0103A599
		public override int Priority
		{
			get
			{
				return 50;
			}
		}

		// Token: 0x06039CEC RID: 236780 RVA: 0x0103C3A0 File Offset: 0x0103A5A0
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

		// Token: 0x06039CED RID: 236781 RVA: 0x0103C514 File Offset: 0x0103A714
		public override void Dispose()
		{
			this.BlockChecker.Dispose();
		}

		// Token: 0x06039CEE RID: 236782 RVA: 0x0103C524 File Offset: 0x0103A724
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

		// Token: 0x06039CEF RID: 236783 RVA: 0x0103C588 File Offset: 0x0103A788
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

		// Token: 0x0401E8A4 RID: 125092
		private const string PROFILE_KEY = "ExploreInteractSearchStrategy_SelectBest";

		// Token: 0x0401E8A5 RID: 125093
		private readonly SphereTraceBlockChecker BlockChecker = new SphereTraceBlockChecker("ExploreInteractSearchStrategy_SelectBest");
	}
}
