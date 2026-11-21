using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064D9 RID: 25817
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionResetPart : AiStateMachineAction
	{
		// Token: 0x0603EB0A RID: 256778 RVA: 0x012439CF File Offset: 0x01241BCF
		public AiStateMachineActionResetPart(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EB0B RID: 256779 RVA: 0x012439D9 File Offset: 0x01241BD9
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}
	}
}
