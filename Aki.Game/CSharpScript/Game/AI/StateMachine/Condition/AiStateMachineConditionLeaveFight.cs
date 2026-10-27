using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007340 RID: 29504
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionLeaveFight : AiStateMachineCondition
	{
		// Token: 0x0604864B RID: 296523 RVA: 0x0129F5A3 File Offset: 0x0129D7A3
		public AiStateMachineConditionLeaveFight(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0604864C RID: 296524 RVA: 0x0129F5AE File Offset: 0x0129D7AE
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("离开战斗\n");
		}
	}
}
