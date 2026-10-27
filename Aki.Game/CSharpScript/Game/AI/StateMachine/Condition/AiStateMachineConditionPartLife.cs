using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007345 RID: 29509
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionPartLife : AiStateMachineCondition
	{
		// Token: 0x06048673 RID: 296563 RVA: 0x012A02DB File Offset: 0x0129E4DB
		public AiStateMachineConditionPartLife(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048674 RID: 296564 RVA: 0x012A02E6 File Offset: 0x0129E4E6
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			return true;
		}

		// Token: 0x06048675 RID: 296565 RVA: 0x012A02E9 File Offset: 0x0129E4E9
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("[部位血量]");
		}
	}
}
