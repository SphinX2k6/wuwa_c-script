using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02006A89 RID: 27273
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class BindingSceneInteractPointContext : SceneInteractPointContext
	{
		// Token: 0x06043C6A RID: 277610 RVA: 0x01096F7F File Offset: 0x0109517F
		public virtual EntityHandle GetEntityHandle()
		{
			EntityBinding entityBindingSlot = this.EntityBindingSlot;
			if (entityBindingSlot == null)
			{
				return null;
			}
			return entityBindingSlot.Handle;
		}

		// Token: 0x06043C6B RID: 277611 RVA: 0x01096F92 File Offset: 0x01095192
		public virtual AActor GetOwnerActor()
		{
			ActorBinding actorBindingSlot = this.ActorBindingSlot;
			if (actorBindingSlot == null)
			{
				return null;
			}
			return actorBindingSlot.Actor;
		}

		// Token: 0x06043C6C RID: 277612 RVA: 0x01096FA5 File Offset: 0x010951A5
		public virtual Vector GetLocation()
		{
			LocationBinding locationBindingSlot = this.LocationBindingSlot;
			if (locationBindingSlot == null)
			{
				return null;
			}
			return locationBindingSlot.Location;
		}

		// Token: 0x06043C6D RID: 277613 RVA: 0x01096FB8 File Offset: 0x010951B8
		public USplineComponent TryGetLandingSpline()
		{
			SplineLandingBinding splineLandingBindingSlot = this.SplineLandingBindingSlot;
			if (splineLandingBindingSlot == null)
			{
				return null;
			}
			return splineLandingBindingSlot.TryGetSplineComponent();
		}

		// Token: 0x06043C6E RID: 277614 RVA: 0x01096FCB File Offset: 0x010951CB
		public override bool IsValid()
		{
			return (this.EntityBindingSlot == null || this.EntityBindingSlot.IsValid()) && (this.ActorBindingSlot == null || this.ActorBindingSlot.IsValid());
		}

		// Token: 0x06043C6F RID: 277615 RVA: 0x01096FFC File Offset: 0x010951FC
		public override void Dispose()
		{
			RangeGateBinding rangeGateBindingSlot = this.RangeGateBindingSlot;
			if (rangeGateBindingSlot != null)
			{
				rangeGateBindingSlot.Dispose();
			}
			SplineLandingBinding splineLandingBindingSlot = this.SplineLandingBindingSlot;
			if (splineLandingBindingSlot == null)
			{
				return;
			}
			splineLandingBindingSlot.Dispose();
		}

		// Token: 0x04023694 RID: 145044
		protected EntityBinding EntityBindingSlot;

		// Token: 0x04023695 RID: 145045
		protected ActorBinding ActorBindingSlot;

		// Token: 0x04023696 RID: 145046
		protected LocationBinding LocationBindingSlot;

		// Token: 0x04023697 RID: 145047
		protected RangeGateBinding RangeGateBindingSlot;

		// Token: 0x04023698 RID: 145048
		protected SplineLandingBinding SplineLandingBindingSlot;
	}
}
