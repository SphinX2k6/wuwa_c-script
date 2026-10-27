using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x0200732D RID: 29485
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateDisableActor : AiStateMachineState
	{
		// Token: 0x060485D0 RID: 296400 RVA: 0x0129D3B0 File Offset: 0x0129B5B0
		public AiStateMachineStateDisableActor(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485D1 RID: 296401 RVA: 0x0129D3BA File Offset: 0x0129B5BA
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			this.DisableActorHandle = this.Node.ActorComponent.DisableActor("状态机隐藏");
		}

		// Token: 0x060485D2 RID: 296402 RVA: 0x0129D3D7 File Offset: 0x0129B5D7
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			this.Node.ActorComponent.EnableActor(this.DisableActorHandle);
			this.DisableActorHandle = 0;
		}

		// Token: 0x060485D3 RID: 296403 RVA: 0x0129D3F7 File Offset: 0x0129B5F7
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026434 RID: 156724
		private int DisableActorHandle;
	}
}
