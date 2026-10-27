using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007349 RID: 29513
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionTrue : AiStateMachineCondition
	{
		// Token: 0x0604868C RID: 296588 RVA: 0x012A0795 File Offset: 0x0129E995
		public AiStateMachineConditionTrue(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0604868D RID: 296589 RVA: 0x012A07A0 File Offset: 0x0129E9A0
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.ResultSelf = true;
			return true;
		}

		// Token: 0x0604868E RID: 296590 RVA: 0x012A07AA File Offset: 0x0129E9AA
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("[True]");
		}
	}
}
