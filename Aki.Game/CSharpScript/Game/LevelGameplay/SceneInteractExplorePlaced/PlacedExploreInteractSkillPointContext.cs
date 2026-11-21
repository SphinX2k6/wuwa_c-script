using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context;
using CSharpScript.Game.LevelGamePlay.SceneInteractExplore;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced
{
	// Token: 0x02005BF9 RID: 23545
	[NullableContext(1)]
	[Nullable(0)]
	public class PlacedExploreInteractSkillPointContext : ExploreSkillInteractPointContextBase
	{
		// Token: 0x06039D36 RID: 236854 RVA: 0x0103D464 File Offset: 0x0103B664
		public PlacedExploreInteractSkillPointContext(IExploreSkillInteract config, EntityHandle entityHandle, AActor ownerActor, Vector location, int enableRangeId, int disableRangeId, [Nullable(2)] Vector raycastDestLocation = null, int landingSplineEntityId = 0) : base(config, entityHandle)
		{
			this.RaycastDestLocation = raycastDestLocation;
			this.ActorBindingSlot = new ActorBinding(ownerActor);
			this.LocationBindingSlot = new LocationBinding(location);
			this.RangeGateBindingSlot = new RangeGateBinding(enableRangeId, disableRangeId);
			if (landingSplineEntityId != 0)
			{
				this.SplineLandingBindingSlot = new SplineLandingBinding(landingSplineEntityId, entityHandle.PbDataId);
			}
		}

		// Token: 0x06039D37 RID: 236855 RVA: 0x0103D4C0 File Offset: 0x0103B6C0
		public override ESceneInteractPointType GetInteractPointType()
		{
			return ESceneInteractPointType.PlacedExploreInteractPoint;
		}

		// Token: 0x06039D38 RID: 236856 RVA: 0x0103D4C3 File Offset: 0x0103B6C3
		public override AActor GetOwnerActor()
		{
			return this.ActorBindingSlot.Actor;
		}

		// Token: 0x06039D39 RID: 236857 RVA: 0x0103D4D0 File Offset: 0x0103B6D0
		public override Vector GetLocation()
		{
			return this.LocationBindingSlot.Location;
		}

		// Token: 0x06039D3A RID: 236858 RVA: 0x0103D4DD File Offset: 0x0103B6DD
		public int GetEnableRangeId()
		{
			return this.RangeGateBindingSlot.EnableRangeId;
		}

		// Token: 0x06039D3B RID: 236859 RVA: 0x0103D4EA File Offset: 0x0103B6EA
		public int GetDisableRangeId()
		{
			return this.RangeGateBindingSlot.DisableRangeId;
		}

		// Token: 0x06039D3C RID: 236860 RVA: 0x0103D4F7 File Offset: 0x0103B6F7
		[NullableContext(2)]
		public Vector GetRaycastDestLocation()
		{
			return this.RaycastDestLocation;
		}

		// Token: 0x0401E8BB RID: 125115
		[Nullable(2)]
		private readonly Vector RaycastDestLocation;
	}
}
