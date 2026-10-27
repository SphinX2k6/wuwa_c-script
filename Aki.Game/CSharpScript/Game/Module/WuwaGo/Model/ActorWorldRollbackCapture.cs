using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x02004733 RID: 18227
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ActorWorldRollbackCapture<[Nullable(0)] TUnit> : IRollbackCapture where TUnit : WuWaGoBaseUnit
	{
		// Token: 0x0602F9F9 RID: 195065 RVA: 0x00B08B18 File Offset: 0x00B06D18
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

		// Token: 0x0602F9FA RID: 195066
		public abstract void Restore();

		// Token: 0x0602F9FB RID: 195067 RVA: 0x00B08BE1 File Offset: 0x00B06DE1
		protected bool RestoreActorWorldTransform()
		{
			if (!this.HasActorTransform)
			{
				return false;
			}
			this.Unit.SetActorWorldTransform(this.WorldLocation, this.WorldRotation, false);
			return true;
		}

		// Token: 0x04019B80 RID: 105344
		private readonly Vector WorldLocation;

		// Token: 0x04019B81 RID: 105345
		private readonly Rotator WorldRotation;

		// Token: 0x04019B82 RID: 105346
		private readonly bool HasActorTransform;

		// Token: 0x04019B83 RID: 105347
		protected readonly TUnit Unit;
	}
}
