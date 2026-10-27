using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02004749 RID: 18249
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class MovableFloorRollbackCapture : GameplayEntityRollbackCapture<WuWaGoMovableFloorEntity>
	{
		// Token: 0x0602FB1E RID: 195358 RVA: 0x00B0D33C File Offset: 0x00B0B53C
		public MovableFloorRollbackCapture(WuWaGoMovableFloorEntity entity) : base(entity)
		{
			this.CurrentStateIndex = entity.StateIndex;
			this.Coordinate = Vector.Create();
			this.Coordinate.DeepCopy(entity.Coordinate);
		}

		// Token: 0x0602FB1F RID: 195359 RVA: 0x00B0D36D File Offset: 0x00B0B56D
		public override void Restore()
		{
			base.Restore();
			base.Entity.RestoreMoveStateForRollback(this.CurrentStateIndex);
			base.Entity.SetCoordinate(this.Coordinate);
		}

		// Token: 0x04019BF6 RID: 105462
		private readonly int CurrentStateIndex;

		// Token: 0x04019BF7 RID: 105463
		private readonly Vector Coordinate;
	}
}
