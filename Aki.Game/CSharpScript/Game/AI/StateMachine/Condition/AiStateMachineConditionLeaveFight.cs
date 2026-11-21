using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064C3 RID: 25795
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionLeaveFight : AiStateMachineCondition
	{
		// Token: 0x0603EA98 RID: 256664 RVA: 0x0124202B File Offset: 0x0124022B
		public AiStateMachineConditionLeaveFight(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA99 RID: 256665 RVA: 0x01242036 File Offset: 0x01240236
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("离开战斗\n");
		}
	}
}
