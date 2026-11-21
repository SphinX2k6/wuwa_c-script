using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064D6 RID: 25814
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionExitHit : AiStateMachineAction
	{
		// Token: 0x0603EAFF RID: 256767 RVA: 0x012437DC File Offset: 0x012419DC
		public AiStateMachineActionExitHit(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EB00 RID: 256768 RVA: 0x012437E6 File Offset: 0x012419E6
		public override void DoAction(long? contextId = null)
		{
			this.Node.UnifiedStateComponent.ExitHitState("");
		}

		// Token: 0x0603EB01 RID: 256769 RVA: 0x012437FD File Offset: 0x012419FD
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}
	}
}
