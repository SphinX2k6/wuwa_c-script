using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064B0 RID: 25776
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateDisableActor : AiStateMachineState
	{
		// Token: 0x0603EA1D RID: 256541 RVA: 0x0123FE30 File Offset: 0x0123E030
		public AiStateMachineStateDisableActor(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603EA1E RID: 256542 RVA: 0x0123FE3A File Offset: 0x0123E03A
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			this.DisableActorHandle = this.Node.ActorComponent.DisableActor("状态机隐藏");
		}

		// Token: 0x0603EA1F RID: 256543 RVA: 0x0123FE57 File Offset: 0x0123E057
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			this.Node.ActorComponent.EnableActor(this.DisableActorHandle);
			this.DisableActorHandle = 0;
		}

		// Token: 0x0603EA20 RID: 256544 RVA: 0x0123FE77 File Offset: 0x0123E077
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021721 RID: 136993
		private int DisableActorHandle;
	}
}
