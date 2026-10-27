using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x02007356 RID: 29526
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionResetPart : AiStateMachineAction
	{
		// Token: 0x060486BC RID: 296636 RVA: 0x012A0ED5 File Offset: 0x0129F0D5
		public AiStateMachineActionResetPart(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x060486BD RID: 296637 RVA: 0x012A0EDF File Offset: 0x0129F0DF
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}
	}
}
