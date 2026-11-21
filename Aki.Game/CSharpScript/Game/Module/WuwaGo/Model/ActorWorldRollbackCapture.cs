using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x02003664 RID: 13924
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ActorWorldRollbackCapture<[Nullable(0)] TUnit> : IRollbackCapture where TUnit : WuWaGoBaseUnit
	{
		// Token: 0x060241C3 RID: 147907 RVA: 0x00A389D4 File Offset: 0x00A36BD4
		protected ActorWorldRollbackCapture(TUnit unit)
		{
			this.Unit = unit;
			this.WorldLocation = Vector.Create();
			this.WorldRotation = Rotator.Create();
			FVectorDouble? worldLocation = this.Unit.GetWorldLocation();
			FRotator? worldRotation = this.Unit.GetWorldRotation();
			if (worldLocation != null && worldRotation != null)
			{
				this.WorldLocation.Set(worldLocation.Value.X, worldLocation.Value.Y, worldLocation.Value.Z);
				this.WorldRotation.Set(worldRotation.Value.Pitch, worldRotation.Value.Yaw, worldRotation.Value.Roll);
				this.HasActorTransform = true;
			}
		}

		// Token: 0x060241C4 RID: 147908
		public abstract void Restore();

		// Token: 0x060241C5 RID: 147909 RVA: 0x00A38A9D File Offset: 0x00A36C9D
		protected bool RestoreActorWorldTransform()
		{
			if (!this.HasActorTransform)
			{
				return false;
			}
			this.Unit.SetActorWorldTransform(this.WorldLocation, this.WorldRotation, false);
			return true;
		}

		// Token: 0x04014230 RID: 82480
		private readonly Vector WorldLocation;

		// Token: 0x04014231 RID: 82481
		private readonly Rotator WorldRotation;

		// Token: 0x04014232 RID: 82482
		private readonly bool HasActorTransform;

		// Token: 0x04014233 RID: 82483
		protected readonly TUnit Unit;
	}
}
