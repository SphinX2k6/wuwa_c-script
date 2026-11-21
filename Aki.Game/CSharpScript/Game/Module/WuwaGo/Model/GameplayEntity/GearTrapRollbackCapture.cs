using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02003678 RID: 13944
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class GearTrapRollbackCapture : GameplayEntityRollbackCapture<WuWaGoGearTrapEntity>
	{
		// Token: 0x060242CE RID: 148174 RVA: 0x00A3CED0 File Offset: 0x00A3B0D0
		public GearTrapRollbackCapture(WuWaGoGearTrapEntity entity) : base(entity)
		{
			this.MoveDirection = Vector.Create();
			this.MoveDirection.DeepCopy(entity.MoveDirection);
			this.Position = Vector.Create();
			this.Position.DeepCopy(entity.Position);
			this.Coordinate = Vector.Create();
			this.Coordinate.DeepCopy(entity.Coordinate);
			this.Rotator = Rotator.Create();
			this.Rotator.DeepCopy(entity.Rotator);
			this.PendingAttackTargetUnitId = entity.PeekPendingAttackTargetUnitId();
		}

		// Token: 0x060242CF RID: 148175 RVA: 0x00A3CF60 File Offset: 0x00A3B160
		public override void Restore()
		{
			base.Restore();
			base.Entity.UpdatePosition(this.Position);
			base.Entity.SetCoordinate(this.Coordinate);
			base.Entity.SetRotator(this.Rotator);
			base.Entity.SetMoveDirection(this.MoveDirection);
			base.Entity.SetPendingAttackTargetUnitIdForRollback(this.PendingAttackTargetUnitId);
		}

		// Token: 0x0401429B RID: 82587
		private readonly Vector MoveDirection;

		// Token: 0x0401429C RID: 82588
		private readonly Vector Position;

		// Token: 0x0401429D RID: 82589
		private readonly Vector Coordinate;

		// Token: 0x0401429E RID: 82590
		private readonly Rotator Rotator;

		// Token: 0x0401429F RID: 82591
		private readonly int? PendingAttackTargetUnitId;
	}
}
