using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x0200367A RID: 13946
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class MovableFloorRollbackCapture : GameplayEntityRollbackCapture<WuWaGoMovableFloorEntity>
	{
		// Token: 0x060242E8 RID: 148200 RVA: 0x00A3D308 File Offset: 0x00A3B508
		public MovableFloorRollbackCapture(WuWaGoMovableFloorEntity entity) : base(entity)
		{
			this.CurrentStateIndex = entity.StateIndex;
			this.Coordinate = Vector.Create();
			this.Coordinate.DeepCopy(entity.Coordinate);
		}

		// Token: 0x060242E9 RID: 148201 RVA: 0x00A3D339 File Offset: 0x00A3B539
		public override void Restore()
		{
			base.Restore();
			base.Entity.RestoreMoveStateForRollback(this.CurrentStateIndex);
			base.Entity.SetCoordinate(this.Coordinate);
		}

		// Token: 0x040142A6 RID: 82598
		private readonly int CurrentStateIndex;

		// Token: 0x040142A7 RID: 82599
		private readonly Vector Coordinate;
	}
}
