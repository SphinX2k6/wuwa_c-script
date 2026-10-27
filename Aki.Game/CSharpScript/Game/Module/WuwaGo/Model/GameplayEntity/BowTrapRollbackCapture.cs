using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02004743 RID: 18243
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BowTrapRollbackCapture : GameplayEntityRollbackCapture<WuWaGoBowTrapEntity>
	{
		// Token: 0x0602FADB RID: 195291 RVA: 0x00B0CB55 File Offset: 0x00B0AD55
		public BowTrapRollbackCapture(WuWaGoBowTrapEntity entity) : base(entity)
		{
		}

		// Token: 0x0602FADC RID: 195292 RVA: 0x00B0CB6A File Offset: 0x00B0AD6A
		public override void Restore()
		{
			base.Restore();
			base.Entity.MarkShotInRound(this.LastShootRound);
		}

		// Token: 0x04019BDE RID: 105438
		private readonly int LastShootRound = entity.PeekLastShootRound();
	}
}
