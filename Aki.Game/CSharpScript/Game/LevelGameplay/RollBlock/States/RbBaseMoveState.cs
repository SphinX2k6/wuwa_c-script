using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.States
{
	// Token: 0x02005C08 RID: 23560
	[OverrideFunctionRoot]
	public class RbBaseMoveState
	{
		// Token: 0x06039DCF RID: 237007 RVA: 0x01044006 File Offset: 0x01042206
		[NullableContext(1)]
		public RbBaseMoveState(RbBlockComponent owner)
		{
			this.Owner = owner;
			this.NeedUpdate = this.NeedUpdateInternal;
			this.IsFinishedInternal = false;
		}

		// Token: 0x06039DD0 RID: 237008 RVA: 0x0104402F File Offset: 0x0104222F
		public virtual void Enter([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<RbBlockIdlePbState, RbJumpMovement, RbRollMovement> info)
		{
		}

		// Token: 0x06039DD1 RID: 237009 RVA: 0x01044031 File Offset: 0x01042231
		public virtual void Exit()
		{
		}

		// Token: 0x06039DD2 RID: 237010 RVA: 0x01044033 File Offset: 0x01042233
		[OverrideFunction]
		public virtual void Update(float delta)
		{
		}

		// Token: 0x06039DD3 RID: 237011 RVA: 0x01044035 File Offset: 0x01042235
		public bool IsFinished()
		{
			return this.IsFinishedInternal;
		}

		// Token: 0x06039DD4 RID: 237012 RVA: 0x01044040 File Offset: 0x01042240
		protected void NotifyServerMovementFinish()
		{
			RollBlockMovementFinishRequest rollBlockMovementFinishRequest = RollBlockMovementFinishRequest.Create();
			rollBlockMovementFinishRequest.IncId = this.Owner.IncId.Value;
			rollBlockMovementFinishRequest.EntityId = this.Owner.CreatureDataId;
			Net.Instance.Call(ERequestMessageId.RollBlockMovementFinishRequest, rollBlockMovementFinishRequest, null, 0);
		}

		// Token: 0x17006E37 RID: 28215
		// (get) Token: 0x06039DD5 RID: 237013 RVA: 0x0104408C File Offset: 0x0104228C
		public virtual bool NeedUpdateInternal
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0401E93A RID: 125242
		[Nullable(2)]
		protected RbBlockComponent Owner;

		// Token: 0x0401E93B RID: 125243
		public readonly bool NeedUpdate;

		// Token: 0x0401E93C RID: 125244
		public ERollBlockMoveState StateName = ERollBlockMoveState.Idle;

		// Token: 0x0401E93D RID: 125245
		protected bool IsFinishedInternal;
	}
}
