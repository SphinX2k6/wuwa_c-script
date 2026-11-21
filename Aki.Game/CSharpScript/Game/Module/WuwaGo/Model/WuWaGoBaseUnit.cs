using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x02003665 RID: 13925
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class WuWaGoBaseUnit : IStaticVariableResetter
	{
		// Token: 0x060241C6 RID: 147910 RVA: 0x00A38AC7 File Offset: 0x00A36CC7
		static WuWaGoBaseUnit()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoBaseUnit.CreateStaticDefaultValue), new Action(WuWaGoBaseUnit.ResetStaticDefaultValue));
		}

		// Token: 0x060241C7 RID: 147911 RVA: 0x00A38AE6 File Offset: 0x00A36CE6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060241C8 RID: 147912 RVA: 0x00A38AE8 File Offset: 0x00A36CE8
		public static void ResetStaticDefaultValue()
		{
			WuWaGoBaseUnit._unitIndex = 0;
		}

		// Token: 0x170049B8 RID: 18872
		// (get) Token: 0x060241C9 RID: 147913
		public abstract bool Actionable { get; }

		// Token: 0x170049B9 RID: 18873
		// (get) Token: 0x060241CA RID: 147914
		public abstract bool MoveAbility { get; }

		// Token: 0x060241CB RID: 147915 RVA: 0x00A38AF0 File Offset: 0x00A36CF0
		protected WuWaGoBaseUnit(Vector coordinateInner, Rotator rotatorInner)
		{
			this.Coordinate = coordinateInner;
			this.Rotator = rotatorInner;
			this.Id = ++WuWaGoBaseUnit._unitIndex;
		}

		// Token: 0x170049BA RID: 18874
		// (get) Token: 0x060241CC RID: 147916 RVA: 0x00A38B19 File Offset: 0x00A36D19
		public Vector Coordinate { get; }

		// Token: 0x170049BB RID: 18875
		// (get) Token: 0x060241CD RID: 147917 RVA: 0x00A38B21 File Offset: 0x00A36D21
		public Rotator Rotator { get; }

		// Token: 0x060241CE RID: 147918 RVA: 0x00A38B29 File Offset: 0x00A36D29
		public void SetCoordinate(Vector target)
		{
			this.MarkRollbackDirty();
			this.Coordinate.DeepCopy(target);
		}

		// Token: 0x060241CF RID: 147919 RVA: 0x00A38B3D File Offset: 0x00A36D3D
		public void SetRotator(Rotator target)
		{
			this.MarkRollbackDirty();
			this.Rotator.DeepCopy(target);
		}

		// Token: 0x060241D0 RID: 147920 RVA: 0x00A38B51 File Offset: 0x00A36D51
		protected void MarkRollbackDirty()
		{
			WuWaGoRollbackPreStates.MarkDirty(this);
		}

		// Token: 0x060241D1 RID: 147921 RVA: 0x00A38B59 File Offset: 0x00A36D59
		[NullableContext(2)]
		public virtual IRollbackCapture CaptureRollback()
		{
			return null;
		}

		// Token: 0x060241D2 RID: 147922
		[NullableContext(2)]
		protected abstract AActor GetActorRaw();

		// Token: 0x060241D3 RID: 147923 RVA: 0x00A38B5C File Offset: 0x00A36D5C
		public bool IsActorValid()
		{
			AActor actorRaw = this.GetActorRaw();
			return actorRaw != null && actorRaw.IsValid();
		}

		// Token: 0x060241D4 RID: 147924 RVA: 0x00A38B6F File Offset: 0x00A36D6F
		public string GetActorName()
		{
			AActor actorRaw = this.GetActorRaw();
			return ((actorRaw != null) ? actorRaw.GetName() : null) ?? "";
		}

		// Token: 0x060241D5 RID: 147925 RVA: 0x00A38B8C File Offset: 0x00A36D8C
		public FVectorDouble? GetWorldLocation()
		{
			AActor actorRaw = this.GetActorRaw();
			if (actorRaw == null || !actorRaw.IsValid())
			{
				return null;
			}
			return new FVectorDouble?(actorRaw.D_K2_GetActorLocation());
		}

		// Token: 0x060241D6 RID: 147926 RVA: 0x00A38BC0 File Offset: 0x00A36DC0
		public FRotator? GetWorldRotation()
		{
			AActor actorRaw = this.GetActorRaw();
			if (actorRaw == null || !actorRaw.IsValid())
			{
				return null;
			}
			return new FRotator?(actorRaw.K2_GetActorRotation());
		}

		// Token: 0x060241D7 RID: 147927 RVA: 0x00A38BF4 File Offset: 0x00A36DF4
		[NullableContext(2)]
		public UObject GetActorAsObject()
		{
			return this.GetActorRaw();
		}

		// Token: 0x060241D8 RID: 147928 RVA: 0x00A38BFC File Offset: 0x00A36DFC
		public void SetHiddenInGame(bool hidden)
		{
			AActor actorRaw = this.GetActorRaw();
			if (actorRaw == null || !actorRaw.IsValid())
			{
				return;
			}
			actorRaw.SetActorHiddenInGame(hidden);
		}

		// Token: 0x060241D9 RID: 147929 RVA: 0x00A38C29 File Offset: 0x00A36E29
		public void MarkActorWorldTransformDirty()
		{
			if (!this.IsActorValid())
			{
				return;
			}
			this.MarkRollbackDirty();
		}

		// Token: 0x060241DA RID: 147930 RVA: 0x00A38C3C File Offset: 0x00A36E3C
		public void SetActorWorldLocation(Vector worldLocation, bool sweep = false)
		{
			AActor actorRaw = this.GetActorRaw();
			if (actorRaw == null || !actorRaw.IsValid())
			{
				return;
			}
			this.MarkRollbackDirty();
			actorRaw.D_K2_SetActorLocation(worldLocation.ToUeVector(false), sweep, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x060241DB RID: 147931 RVA: 0x00A38C80 File Offset: 0x00A36E80
		public void SetActorWorldRotation(Rotator worldRotation)
		{
			AActor actorRaw = this.GetActorRaw();
			if (actorRaw == null || !actorRaw.IsValid())
			{
				return;
			}
			this.MarkRollbackDirty();
			actorRaw.K2_SetActorRotation(worldRotation.ToUeRotator(), false);
		}

		// Token: 0x060241DC RID: 147932 RVA: 0x00A38CBC File Offset: 0x00A36EBC
		public void SetActorWorldTransform(Vector worldLocation, Rotator worldRotation, bool teleport = false)
		{
			AActor actorRaw = this.GetActorRaw();
			if (actorRaw == null || !actorRaw.IsValid())
			{
				return;
			}
			this.MarkRollbackDirty();
			actorRaw.D_K2_SetActorLocationAndRotation(worldLocation.ToUeVector(false), worldRotation.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, teleport);
		}

		// Token: 0x04014234 RID: 82484
		private static int _unitIndex;

		// Token: 0x04014235 RID: 82485
		public readonly int Id;
	}
}
