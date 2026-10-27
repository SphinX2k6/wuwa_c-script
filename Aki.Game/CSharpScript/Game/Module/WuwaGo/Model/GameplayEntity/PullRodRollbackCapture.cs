using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x0200474D RID: 18253
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class PullRodRollbackCapture : GameplayEntityRollbackCapture<WuWaGoPullRodEntity>
	{
		// Token: 0x0602FB4C RID: 195404 RVA: 0x00B0D9BA File Offset: 0x00B0BBBA
		public PullRodRollbackCapture(WuWaGoPullRodEntity entity) : base(entity)
		{
		}

		// Token: 0x0602FB4D RID: 195405 RVA: 0x00B0D9C3 File Offset: 0x00B0BBC3
		public override void Restore()
		{
			base.Restore();
			base.Entity.SyncPresentationForRollback();
		}
	}
}
