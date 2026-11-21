using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02005BE6 RID: 23526
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class BindingSceneInteractPointContext : SceneInteractPointContext
	{
		// Token: 0x06039CB8 RID: 236728 RVA: 0x0103B7D3 File Offset: 0x010399D3
		public virtual EntityHandle GetEntityHandle()
		{
			EntityBinding entityBindingSlot = this.EntityBindingSlot;
			if (entityBindingSlot == null)
			{
				return null;
			}
			return entityBindingSlot.Handle;
		}

		// Token: 0x06039CB9 RID: 236729 RVA: 0x0103B7E6 File Offset: 0x010399E6
		public virtual AActor GetOwnerActor()
		{
			ActorBinding actorBindingSlot = this.ActorBindingSlot;
			if (actorBindingSlot == null)
			{
				return null;
			}
			return actorBindingSlot.Actor;
		}

		// Token: 0x06039CBA RID: 236730 RVA: 0x0103B7F9 File Offset: 0x010399F9
		public virtual Vector GetLocation()
		{
			LocationBinding locationBindingSlot = this.LocationBindingSlot;
			if (locationBindingSlot == null)
			{
				return null;
			}
			return locationBindingSlot.Location;
		}

		// Token: 0x06039CBB RID: 236731 RVA: 0x0103B80C File Offset: 0x01039A0C
		public USplineComponent TryGetLandingSpline()
		{
			SplineLandingBinding splineLandingBindingSlot = this.SplineLandingBindingSlot;
			if (splineLandingBindingSlot == null)
			{
				return null;
			}
			return splineLandingBindingSlot.TryGetSplineComponent();
		}

		// Token: 0x06039CBC RID: 236732 RVA: 0x0103B81F File Offset: 0x01039A1F
		public override bool IsValid()
		{
			return (this.EntityBindingSlot == null || this.EntityBindingSlot.IsValid()) && (this.ActorBindingSlot == null || this.ActorBindingSlot.IsValid());
		}

		// Token: 0x06039CBD RID: 236733 RVA: 0x0103B850 File Offset: 0x01039A50
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

		// Token: 0x0401E886 RID: 125062
		protected EntityBinding EntityBindingSlot;

		// Token: 0x0401E887 RID: 125063
		protected ActorBinding ActorBindingSlot;

		// Token: 0x0401E888 RID: 125064
		protected LocationBinding LocationBindingSlot;

		// Token: 0x0401E889 RID: 125065
		protected RangeGateBinding RangeGateBindingSlot;

		// Token: 0x0401E88A RID: 125066
		protected SplineLandingBinding SplineLandingBindingSlot;
	}
}
