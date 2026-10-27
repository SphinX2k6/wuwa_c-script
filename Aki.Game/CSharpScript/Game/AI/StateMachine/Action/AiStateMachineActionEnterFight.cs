using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x02007352 RID: 29522
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionEnterFight : AiStateMachineAction
	{
		// Token: 0x060486B0 RID: 296624 RVA: 0x012A0D41 File Offset: 0x0129EF41
		public AiStateMachineActionEnterFight(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x060486B1 RID: 296625 RVA: 0x012A0D4B File Offset: 0x0129EF4B
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}
	}
}
