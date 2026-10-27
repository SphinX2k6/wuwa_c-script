using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point
{
	// Token: 0x02006A87 RID: 27271
	[NullableContext(2)]
	[Nullable(0)]
	public class SplineLandingResolver
	{
		// Token: 0x06043C59 RID: 277593 RVA: 0x0109688D File Offset: 0x01094A8D
		public void Clear()
		{
			this.HasResolved = false;
		}

		// Token: 0x06043C5A RID: 277594 RVA: 0x01096896 File Offset: 0x01094A96
		public Vector GetResolvedLocation()
		{
			if (!this.HasResolved)
			{
				return null;
			}
			return this.ResolvedLocation;
		}

		// Token: 0x06043C5B RID: 277595 RVA: 0x010968A8 File Offset: 0x01094AA8
		public void TryResolve(USplineComponent spline, Vector jumpPointLocation, [Nullable(1)] ISceneInteractSearchParams @params, AActor referenceActor = null)
		{
			this.HasResolved = false;
			if (spline == null || jumpPointLocation == null)
			{
				return;
			}
			if (this.ResolvedLocation == null)
			{
				this.ResolvedLocation = Vector.Create();
			}
			Vector refLocation = null;
			Quat refRotation = null;
			if (referenceActor != null && referenceActor.IsValid())
			{
				if (this.RefLocation == null || this.RefRotator == null || this.RefRotation == null)
				{
					this.RefLocation = Vector.Create();
					this.RefRotator = Rotator.Create();
					this.RefRotation = Quat.Create(0.0, 0.0, 0.0, 1.0);
				}
				Vector refLocation2 = this.RefLocation;
				FVectorDouble fvectorDouble = referenceActor.D_K2_GetActorLocation();
				refLocation2.FromUeVector(fvectorDouble);
				Rotator refRotator = this.RefRotator;
				FRotator frotator = referenceActor.K2_GetActorRotation();
				refRotator.FromUeRotator(frotator);
				this.RefRotator.Quaternion(this.RefRotation);
				refLocation = this.RefLocation;
				refRotation = this.RefRotation;
			}
			this.HasResolved = SplineLandingSelector.SelectLandingLocation(spline, jumpPointLocation, @params, this.ResolvedLocation, refLocation, refRotation);
		}

		// Token: 0x04023680 RID: 145024
		private Vector ResolvedLocation;

		// Token: 0x04023681 RID: 145025
		private bool HasResolved;

		// Token: 0x04023682 RID: 145026
		private Vector RefLocation;

		// Token: 0x04023683 RID: 145027
		private Rotator RefRotator;

		// Token: 0x04023684 RID: 145028
		private Quat RefRotation;
	}
}
