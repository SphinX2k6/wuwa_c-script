using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064D5 RID: 25813
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionEnterFight : AiStateMachineAction
	{
		// Token: 0x0603EAFD RID: 256765 RVA: 0x012437C9 File Offset: 0x012419C9
		public AiStateMachineActionEnterFight(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EAFE RID: 256766 RVA: 0x012437D3 File Offset: 0x012419D3
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}
	}
}
