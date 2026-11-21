using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x0200367E RID: 13950
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class PullRodRollbackCapture : GameplayEntityRollbackCapture<WuWaGoPullRodEntity>
	{
		// Token: 0x06024316 RID: 148246 RVA: 0x00A3D99A File Offset: 0x00A3BB9A
		public PullRodRollbackCapture(WuWaGoPullRodEntity entity) : base(entity)
		{
		}

		// Token: 0x06024317 RID: 148247 RVA: 0x00A3D9A3 File Offset: 0x00A3BBA3
		public override void Restore()
		{
			base.Restore();
			base.Entity.SyncPresentationForRollback();
		}
	}
}
