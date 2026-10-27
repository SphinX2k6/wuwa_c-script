using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x0200474B RID: 18251
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class PressureTriggerRollbackCapture : GameplayEntityRollbackCapture<WuWaGoPressureTriggerEntity>
	{
		// Token: 0x0602FB39 RID: 195385 RVA: 0x00B0D84F File Offset: 0x00B0BA4F
		public PressureTriggerRollbackCapture(WuWaGoPressureTriggerEntity entity) : base(entity)
		{
		}

		// Token: 0x0602FB3A RID: 195386 RVA: 0x00B0D870 File Offset: 0x00B0BA70
		public override void Restore()
		{
			base.Restore();
			base.Entity.RestoreOccupantStateForRollback(this.OccupantId, this.IsDirty);
			base.Entity.SyncPresentationForRollback();
		}

		// Token: 0x04019BFE RID: 105470
		private readonly int OccupantId = entity.CurrentOccupantId;

		// Token: 0x04019BFF RID: 105471
		private readonly bool IsDirty = entity.Dirty;
	}
}
