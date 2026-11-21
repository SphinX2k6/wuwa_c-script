using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02003676 RID: 13942
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class GameplayEntityRollbackCapture<[Nullable(0)] TEntity> : ActorWorldRollbackCapture<TEntity> where TEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x060242B2 RID: 148146 RVA: 0x00A3CC40 File Offset: 0x00A3AE40
		public GameplayEntityRollbackCapture(TEntity entity) : base(entity)
		{
		}

		// Token: 0x170049E4 RID: 18916
		// (get) Token: 0x060242B3 RID: 148147 RVA: 0x00A3CC6B File Offset: 0x00A3AE6B
		protected TEntity Entity
		{
			get
			{
				return this.Unit;
			}
		}

		// Token: 0x060242B4 RID: 148148 RVA: 0x00A3CC73 File Offset: 0x00A3AE73
		public override void Restore()
		{
			this.Entity.SetStateSilently(this.State);
			this.Entity.SetStandGridId(this.StandGridId);
			base.RestoreActorWorldTransform();
		}

		// Token: 0x04014292 RID: 82578
		private readonly EGameplayEntityState State = entity.State;

		// Token: 0x04014293 RID: 82579
		private readonly int StandGridId = entity.StandGridId;
	}
}
