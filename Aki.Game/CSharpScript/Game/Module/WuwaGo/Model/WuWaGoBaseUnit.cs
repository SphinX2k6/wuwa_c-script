using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x02004734 RID: 18228
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class WuWaGoBaseUnit : IStaticVariableResetter
	{
		// Token: 0x0602F9FC RID: 195068 RVA: 0x00B08C0B File Offset: 0x00B06E0B
		static WuWaGoBaseUnit()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoBaseUnit.CreateStaticDefaultValue), new Action(WuWaGoBaseUnit.ResetStaticDefaultValue));
		}

		// Token: 0x0602F9FD RID: 195069 RVA: 0x00B08C2A File Offset: 0x00B06E2A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F9FE RID: 195070 RVA: 0x00B08C2C File Offset: 0x00B06E2C
		public static void ResetStaticDefaultValue()
		{
			WuWaGoBaseUnit._unitIndex = 0;
		}

		// Token: 0x170076FC RID: 30460
		// (get) Token: 0x0602F9FF RID: 195071
		public abstract bool Actionable { get; }

		// Token: 0x170076FD RID: 30461
		// (get) Token: 0x0602FA00 RID: 195072
		public abstract bool MoveAbility { get; }

		// Token: 0x0602FA01 RID: 195073 RVA: 0x00B08C34 File Offset: 0x00B06E34
		protected WuWaGoBaseUnit(Vector coordinateInner, Rotator rotatorInner)
		{
			this.Coordinate = coordinateInner;
			this.Rotator = rotatorInner;
			this.Id = ++WuWaGoBaseUnit._unitIndex;
		}

		// Token: 0x170076FE RID: 30462
		// (get) Token: 0x0602FA02 RID: 195074 RVA: 0x00B08C5D File Offset: 0x00B06E5D
		public Vector Coordinate { get; }

		// Token: 0x170076FF RID: 30463
		// (get) Token: 0x0602FA03 RID: 195075 RVA: 0x00B08C65 File Offset: 0x00B06E65
		public Rotator Rotator { get; }

		// Token: 0x0602FA04 RID: 195076 RVA: 0x00B08C6D File Offset: 0x00B06E6D
		public void SetCoordinate(Vector target)
		{
			this.MarkRollbackDirty();
			this.Coordinate.DeepCopy(target);
		}

		// Token: 0x0602FA05 RID: 195077 RVA: 0x00B08C81 File Offset: 0x00B06E81
		public void SetRotator(Rotator target)
		{
			this.MarkRollbackDirty();
			this.Rotator.DeepCopy(target);
		}

		// Token: 0x0602FA06 RID: 195078 RVA: 0x00B08C95 File Offset: 0x00B06E95
		protected void MarkRollbackDirty()
		{
			WuWaGoRollbackPreStates.MarkDirty(this);
		}

		// Token: 0x0602FA07 RID: 195079 RVA: 0x00B08C9D File Offset: 0x00B06E9D
		[NullableContext(2)]
		public virtual IRollbackCapture CaptureRollback()
		{
			return null;
		}

		// Token: 0x0602FA08 RID: 195080
		[NullableContext(2)]
		protected abstract AActor GetActorRaw();

		// Token: 0x0602FA09 RID: 195081 RVA: 0x00B08CA0 File Offset: 0x00B06EA0
		public bool IsActorValid()
		{
			AActor actorRaw = this.GetActorRaw();
			return actorRaw != null && actorRaw.IsValid();
		}

		// Token: 0x0602FA0A RID: 195082 RVA: 0x00B08CB3 File Offset: 0x00B06EB3
		public string GetActorName()
		{
			AActor actorRaw = this.GetActorRaw();
			return ((actorRaw != null) ? actorRaw.GetName() : null) ?? "";
		}

		// Token: 0x0602FA0B RID: 195083 RVA: 0x00B08CD0 File Offset: 0x00B06ED0
		public FVectorDouble? GetWorldLocation()
		{
			AActor actorRaw = this.GetActorRaw();
			if (actorRaw == null || !actorRaw.IsValid())
			{
				return null;
			}
			return new FVectorDouble?(actorRaw.D_K2_GetActorLocation());
		}

		// Token: 0x0602FA0C RID: 195084 RVA: 0x00B08D04 File Offset: 0x00B06F04
		public FRotator? GetWorldRotation()
		{
			AActor actorRaw = this.GetActorRaw();
			if (actorRaw == null || !actorRaw.IsValid())
			{
				return null;
			}
			return new FRotator?(actorRaw.K2_GetActorRotation());
		}

		// Token: 0x0602FA0D RID: 195085 RVA: 0x00B08D38 File Offset: 0x00B06F38
		[NullableContext(2)]
		public UObject GetActorAsObject()
		{
			return this.GetActorRaw();
		}

		// Token: 0x0602FA0E RID: 195086 RVA: 0x00B08D40 File Offset: 0x00B06F40
		public void SetHiddenInGame(bool hidden)
		{
			AActor actorRaw = this.GetActorRaw();
			if (actorRaw == null || !actorRaw.IsValid())
			{
				return;
			}
			actorRaw.SetActorHiddenInGame(hidden);
		}

		// Token: 0x0602FA0F RID: 195087 RVA: 0x00B08D6D File Offset: 0x00B06F6D
		public void MarkActorWorldTransformDirty()
		{
			if (!this.IsActorValid())
			{
				return;
			}
			this.MarkRollbackDirty();
		}

		// Token: 0x0602FA10 RID: 195088 RVA: 0x00B08D80 File Offset: 0x00B06F80
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

		// Token: 0x0602FA11 RID: 195089 RVA: 0x00B08DC4 File Offset: 0x00B06FC4
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

		// Token: 0x0602FA12 RID: 195090 RVA: 0x00B08E00 File Offset: 0x00B07000
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

		// Token: 0x04019B84 RID: 105348
		private static int _unitIndex;

		// Token: 0x04019B85 RID: 105349
		public readonly int Id;
	}
}
