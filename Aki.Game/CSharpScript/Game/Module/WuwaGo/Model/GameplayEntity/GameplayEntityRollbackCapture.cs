using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02004745 RID: 18245
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class GameplayEntityRollbackCapture<[Nullable(0)] TEntity> : ActorWorldRollbackCapture<TEntity> where TEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x0602FAE8 RID: 195304 RVA: 0x00B0CC74 File Offset: 0x00B0AE74
		public GameplayEntityRollbackCapture(TEntity entity) : base(entity)
		{
		}

		// Token: 0x17007728 RID: 30504
		// (get) Token: 0x0602FAE9 RID: 195305 RVA: 0x00B0CC9F File Offset: 0x00B0AE9F
		protected TEntity Entity
		{
			get
			{
				return this.Unit;
			}
		}

		// Token: 0x0602FAEA RID: 195306 RVA: 0x00B0CCA7 File Offset: 0x00B0AEA7
		public override void Restore()
		{
			this.Entity.SetStateSilently(this.State);
			this.Entity.SetStandGridId(this.StandGridId);
			base.RestoreActorWorldTransform();
		}

		// Token: 0x04019BE2 RID: 105442
		private readonly EGameplayEntityState State = entity.State;

		// Token: 0x04019BE3 RID: 105443
		private readonly int StandGridId = entity.StandGridId;
	}
}
