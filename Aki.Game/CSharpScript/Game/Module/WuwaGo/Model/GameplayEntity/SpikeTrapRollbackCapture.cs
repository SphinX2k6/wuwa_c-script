using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02003682 RID: 13954
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpikeTrapRollbackCapture : GameplayEntityRollbackCapture<WuWaGoSpikeTrapEntity>
	{
		// Token: 0x0602432E RID: 148270 RVA: 0x00A3DB83 File Offset: 0x00A3BD83
		public SpikeTrapRollbackCapture(WuWaGoSpikeTrapEntity entity) : base(entity)
		{
		}

		// Token: 0x0602432F RID: 148271 RVA: 0x00A3DBBC File Offset: 0x00A3BDBC
		public override void Restore()
		{
			base.Restore();
			base.Entity.RestoreOccupantTrackingForRollback(this.StepCount, this.OccupantId, this.PrevOccupantId, this.IsDirty);
		}

		// Token: 0x040142B8 RID: 82616
		private readonly int StepCount = entity.CurrentStepCount;

		// Token: 0x040142B9 RID: 82617
		private readonly int OccupantId = entity.PeekOccupantId();

		// Token: 0x040142BA RID: 82618
		private readonly int PrevOccupantId = entity.PeekPrevOccupantId();

		// Token: 0x040142BB RID: 82619
		private readonly bool IsDirty = entity.PeekIsDirty();
	}
}
