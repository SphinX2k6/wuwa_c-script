using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context;
using CSharpScript.Game.LevelGamePlay.SceneInteractExplore;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced
{
	// Token: 0x02006A9C RID: 27292
	[NullableContext(1)]
	[Nullable(0)]
	public class PlacedExploreInteractSkillPointContext : ExploreSkillInteractPointContextBase
	{
		// Token: 0x06043CE8 RID: 277736 RVA: 0x01098C1C File Offset: 0x01096E1C
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

		// Token: 0x06043CE9 RID: 277737 RVA: 0x01098C78 File Offset: 0x01096E78
		public override ESceneInteractPointType GetInteractPointType()
		{
			return ESceneInteractPointType.PlacedExploreInteractPoint;
		}

		// Token: 0x06043CEA RID: 277738 RVA: 0x01098C7B File Offset: 0x01096E7B
		public override AActor GetOwnerActor()
		{
			return this.ActorBindingSlot.Actor;
		}

		// Token: 0x06043CEB RID: 277739 RVA: 0x01098C88 File Offset: 0x01096E88
		public override Vector GetLocation()
		{
			return this.LocationBindingSlot.Location;
		}

		// Token: 0x06043CEC RID: 277740 RVA: 0x01098C95 File Offset: 0x01096E95
		public int GetEnableRangeId()
		{
			return this.RangeGateBindingSlot.EnableRangeId;
		}

		// Token: 0x06043CED RID: 277741 RVA: 0x01098CA2 File Offset: 0x01096EA2
		public int GetDisableRangeId()
		{
			return this.RangeGateBindingSlot.DisableRangeId;
		}

		// Token: 0x06043CEE RID: 277742 RVA: 0x01098CAF File Offset: 0x01096EAF
		[NullableContext(2)]
		public Vector GetRaycastDestLocation()
		{
			return this.RaycastDestLocation;
		}

		// Token: 0x040236C9 RID: 145097
		[Nullable(2)]
		private readonly Vector RaycastDestLocation;
	}
}
