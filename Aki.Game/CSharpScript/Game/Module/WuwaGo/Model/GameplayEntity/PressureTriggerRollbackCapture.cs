using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x0200367C RID: 13948
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class PressureTriggerRollbackCapture : GameplayEntityRollbackCapture<WuWaGoPressureTriggerEntity>
	{
		// Token: 0x06024303 RID: 148227 RVA: 0x00A3D82F File Offset: 0x00A3BA2F
		public PressureTriggerRollbackCapture(WuWaGoPressureTriggerEntity entity) : base(entity)
		{
		}

		// Token: 0x06024304 RID: 148228 RVA: 0x00A3D850 File Offset: 0x00A3BA50
		public override void Restore()
		{
			base.Restore();
			base.Entity.RestoreOccupantStateForRollback(this.OccupantId, this.IsDirty);
			base.Entity.SyncPresentationForRollback();
		}

		// Token: 0x040142AE RID: 82606
		private readonly int OccupantId = entity.CurrentOccupantId;

		// Token: 0x040142AF RID: 82607
		private readonly bool IsDirty = entity.Dirty;
	}
}
