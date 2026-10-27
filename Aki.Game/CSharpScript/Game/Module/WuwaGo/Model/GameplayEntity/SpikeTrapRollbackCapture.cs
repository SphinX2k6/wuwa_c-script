using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02004751 RID: 18257
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpikeTrapRollbackCapture : GameplayEntityRollbackCapture<WuWaGoSpikeTrapEntity>
	{
		// Token: 0x0602FB64 RID: 195428 RVA: 0x00B0DB8F File Offset: 0x00B0BD8F
		public SpikeTrapRollbackCapture(WuWaGoSpikeTrapEntity entity) : base(entity)
		{
		}

		// Token: 0x0602FB65 RID: 195429 RVA: 0x00B0DBC8 File Offset: 0x00B0BDC8
		public override void Restore()
		{
			base.Restore();
			base.Entity.RestoreOccupantTrackingForRollback(this.StepCount, this.OccupantId, this.PrevOccupantId, this.IsDirty);
		}

		// Token: 0x04019C08 RID: 105480
		private readonly int StepCount = entity.CurrentStepCount;

		// Token: 0x04019C09 RID: 105481
		private readonly int OccupantId = entity.PeekOccupantId();

		// Token: 0x04019C0A RID: 105482
		private readonly int PrevOccupantId = entity.PeekPrevOccupantId();

		// Token: 0x04019C0B RID: 105483
		private readonly bool IsDirty = entity.PeekIsDirty();
	}
}
