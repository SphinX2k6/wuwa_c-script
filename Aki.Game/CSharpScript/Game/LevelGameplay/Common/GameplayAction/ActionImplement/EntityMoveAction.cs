using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x020060AD RID: 24749
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class EntityMoveAction : GameplayAction
	{
		// Token: 0x17007050 RID: 28752
		// (get) Token: 0x0603B58D RID: 243085 RVA: 0x010CC324 File Offset: 0x010CA524
		protected override bool NeedTickInner
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0603B58E RID: 243086 RVA: 0x010CC327 File Offset: 0x010CA527
		[NullableContext(1)]
		public void Init(EntityHandle moveEntity, IMoveConfig config, Vector targetLocation, Rotator targetRotator)
		{
			this.MoveEntityHandle = moveEntity;
			this.Config = config;
			this.TargetLocation = targetLocation;
			this.TargetRotator = targetRotator;
		}

		// Token: 0x0603B58F RID: 243087 RVA: 0x010CC346 File Offset: 0x010CA546
		protected BaseActorComponent GetMoveActorComp()
		{
			if (this.MoveEntityHandle == null || !this.MoveEntityHandle.IsInit)
			{
				return null;
			}
			return this.MoveEntityHandle.Entity.GetComponent<BaseActorComponent>();
		}

		// Token: 0x0401F454 RID: 128084
		protected IMoveConfig Config;

		// Token: 0x0401F455 RID: 128085
		protected EntityHandle MoveEntityHandle;

		// Token: 0x0401F456 RID: 128086
		protected Vector TargetLocation;

		// Token: 0x0401F457 RID: 128087
		protected Rotator TargetRotator;
	}
}
