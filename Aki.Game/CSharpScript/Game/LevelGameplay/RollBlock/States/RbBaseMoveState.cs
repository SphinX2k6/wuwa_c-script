using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.States
{
	// Token: 0x02006AAB RID: 27307
	public class RbBaseMoveState
	{
		// Token: 0x06043D7A RID: 277882 RVA: 0x0109F8AC File Offset: 0x0109DAAC
		[NullableContext(1)]
		public RbBaseMoveState(RbBlockComponent owner)
		{
			this.Owner = owner;
			MethodInfo method = base.GetType().GetMethod("Update", BindingFlags.Instance | BindingFlags.Public);
			MethodInfo method2 = typeof(RbBaseMoveState).GetMethod("Update", BindingFlags.Instance | BindingFlags.Public);
			this.NeedUpdate = (method != null && method2 != null && method != method2);
			this.IsFinishedInternal = false;
		}

		// Token: 0x06043D7B RID: 277883 RVA: 0x0109F920 File Offset: 0x0109DB20
		public virtual void Enter([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<RbBlockIdlePbState, RbJumpMovement, RbRollMovement> info)
		{
		}

		// Token: 0x06043D7C RID: 277884 RVA: 0x0109F922 File Offset: 0x0109DB22
		public virtual void Exit()
		{
		}

		// Token: 0x06043D7D RID: 277885 RVA: 0x0109F924 File Offset: 0x0109DB24
		public virtual void Update(float delta)
		{
		}

		// Token: 0x06043D7E RID: 277886 RVA: 0x0109F926 File Offset: 0x0109DB26
		public bool IsFinished()
		{
			return this.IsFinishedInternal;
		}

		// Token: 0x06043D7F RID: 277887 RVA: 0x0109F930 File Offset: 0x0109DB30
		protected void NotifyServerMovementFinish()
		{
			RollBlockMovementFinishRequest rollBlockMovementFinishRequest = RollBlockMovementFinishRequest.Create();
			rollBlockMovementFinishRequest.IncId = this.Owner.IncId.Value;
			rollBlockMovementFinishRequest.EntityId = MathUtils.Instance.NumberToLong(this.Owner.CreatureDataId);
			Net.Instance.Call(ERequestMessageId.RollBlockMovementFinishRequest, rollBlockMovementFinishRequest, null, 0);
		}

		// Token: 0x04023748 RID: 145224
		[Nullable(2)]
		protected RbBlockComponent Owner;

		// Token: 0x04023749 RID: 145225
		public bool NeedUpdate;

		// Token: 0x0402374A RID: 145226
		public ERollBlockMoveState StateName = ERollBlockMoveState.Idle;

		// Token: 0x0402374B RID: 145227
		protected bool IsFinishedInternal;
	}
}
