using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point
{
	// Token: 0x02005BE4 RID: 23524
	[NullableContext(2)]
	[Nullable(0)]
	public class SplineLandingResolver
	{
		// Token: 0x06039CA7 RID: 236711 RVA: 0x0103B0CD File Offset: 0x010392CD
		public void Clear()
		{
			this.HasResolved = false;
		}

		// Token: 0x06039CA8 RID: 236712 RVA: 0x0103B0D6 File Offset: 0x010392D6
		public Vector GetResolvedLocation()
		{
			if (!this.HasResolved)
			{
				return null;
			}
			return this.ResolvedLocation;
		}

		// Token: 0x06039CA9 RID: 236713 RVA: 0x0103B0E8 File Offset: 0x010392E8
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

		// Token: 0x0401E872 RID: 125042
		private Vector ResolvedLocation;

		// Token: 0x0401E873 RID: 125043
		private bool HasResolved;

		// Token: 0x0401E874 RID: 125044
		private Vector RefLocation;

		// Token: 0x0401E875 RID: 125045
		private Rotator RefRotator;

		// Token: 0x0401E876 RID: 125046
		private Quat RefRotation;
	}
}
