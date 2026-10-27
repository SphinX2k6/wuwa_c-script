using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02004747 RID: 18247
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class GearTrapRollbackCapture : GameplayEntityRollbackCapture<WuWaGoGearTrapEntity>
	{
		// Token: 0x0602FB04 RID: 195332 RVA: 0x00B0CF04 File Offset: 0x00B0B104
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

		// Token: 0x0602FB05 RID: 195333 RVA: 0x00B0CF94 File Offset: 0x00B0B194
		public override void Restore()
		{
			base.Restore();
			base.Entity.UpdatePosition(this.Position);
			base.Entity.SetCoordinate(this.Coordinate);
			base.Entity.SetRotator(this.Rotator);
			base.Entity.SetMoveDirection(this.MoveDirection);
			base.Entity.SetPendingAttackTargetUnitIdForRollback(this.PendingAttackTargetUnitId);
		}

		// Token: 0x04019BEB RID: 105451
		private readonly Vector MoveDirection;

		// Token: 0x04019BEC RID: 105452
		private readonly Vector Position;

		// Token: 0x04019BED RID: 105453
		private readonly Vector Coordinate;

		// Token: 0x04019BEE RID: 105454
		private readonly Rotator Rotator;

		// Token: 0x04019BEF RID: 105455
		private readonly int? PendingAttackTargetUnitId;
	}
}
