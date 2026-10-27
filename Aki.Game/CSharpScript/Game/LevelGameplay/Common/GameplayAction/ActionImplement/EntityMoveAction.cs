using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x02006F2C RID: 28460
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class EntityMoveAction : GameplayAction
	{
		// Token: 0x17009B11 RID: 39697
		// (get) Token: 0x060453DF RID: 283615 RVA: 0x01122378 File Offset: 0x01120578
		protected override bool NeedTickInner
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060453E0 RID: 283616 RVA: 0x0112237B File Offset: 0x0112057B
		[NullableContext(1)]
		public void Init(EntityHandle moveEntity, IMoveConfig config, Vector targetLocation, Rotator targetRotator)
		{
			this.MoveEntityHandle = moveEntity;
			this.Config = config;
			this.TargetLocation = targetLocation;
			this.TargetRotator = targetRotator;
		}

		// Token: 0x060453E1 RID: 283617 RVA: 0x0112239A File Offset: 0x0112059A
		protected BaseActorComponent GetMoveActorComp()
		{
			if (this.MoveEntityHandle == null || !this.MoveEntityHandle.IsInit)
			{
				return null;
			}
			return this.MoveEntityHandle.Entity.GetComponent<BaseActorComponent>();
		}

		// Token: 0x0402419F RID: 147871
		protected IMoveConfig Config;

		// Token: 0x040241A0 RID: 147872
		protected EntityHandle MoveEntityHandle;

		// Token: 0x040241A1 RID: 147873
		protected Vector TargetLocation;

		// Token: 0x040241A2 RID: 147874
		protected Rotator TargetRotator;
	}
}
