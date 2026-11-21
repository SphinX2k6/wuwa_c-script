using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02003674 RID: 13940
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BowTrapRollbackCapture : GameplayEntityRollbackCapture<WuWaGoBowTrapEntity>
	{
		// Token: 0x060242A5 RID: 148133 RVA: 0x00A3CB21 File Offset: 0x00A3AD21
		public BowTrapRollbackCapture(WuWaGoBowTrapEntity entity) : base(entity)
		{
		}

		// Token: 0x060242A6 RID: 148134 RVA: 0x00A3CB36 File Offset: 0x00A3AD36
		public override void Restore()
		{
			base.Restore();
			base.Entity.MarkShotInRound(this.LastShootRound);
		}

		// Token: 0x0401428E RID: 82574
		private readonly int LastShootRound = entity.PeekLastShootRound();
	}
}
