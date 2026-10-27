using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x0200732E RID: 29486
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateDisableCollision : AiStateMachineState
	{
		// Token: 0x060485D4 RID: 296404 RVA: 0x0129D400 File Offset: 0x0129B600
		public AiStateMachineStateDisableCollision(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485D5 RID: 296405 RVA: 0x0129D40A File Offset: 0x0129B60A
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			this.DisableCollisionHandle = this.Node.ActorComponent.DisableCollision("状态机隐藏碰撞");
		}

		// Token: 0x060485D6 RID: 296406 RVA: 0x0129D427 File Offset: 0x0129B627
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			this.Node.ActorComponent.EnableCollision(this.DisableCollisionHandle);
			this.DisableCollisionHandle = 0;
		}

		// Token: 0x060485D7 RID: 296407 RVA: 0x0129D447 File Offset: 0x0129B647
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026435 RID: 156725
		private int DisableCollisionHandle;
	}
}
