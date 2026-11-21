using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064B1 RID: 25777
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateDisableCollision : AiStateMachineState
	{
		// Token: 0x0603EA21 RID: 256545 RVA: 0x0123FE80 File Offset: 0x0123E080
		public AiStateMachineStateDisableCollision(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603EA22 RID: 256546 RVA: 0x0123FE8A File Offset: 0x0123E08A
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			this.DisableCollisionHandle = this.Node.ActorComponent.DisableCollision("状态机隐藏碰撞");
		}

		// Token: 0x0603EA23 RID: 256547 RVA: 0x0123FEA7 File Offset: 0x0123E0A7
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			this.Node.ActorComponent.EnableCollision(this.DisableCollisionHandle);
			this.DisableCollisionHandle = 0;
		}

		// Token: 0x0603EA24 RID: 256548 RVA: 0x0123FEC7 File Offset: 0x0123E0C7
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021722 RID: 136994
		private int DisableCollisionHandle;
	}
}
