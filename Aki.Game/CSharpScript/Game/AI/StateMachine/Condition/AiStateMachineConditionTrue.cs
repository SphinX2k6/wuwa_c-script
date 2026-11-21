using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064CC RID: 25804
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionTrue : AiStateMachineCondition
	{
		// Token: 0x0603EAD9 RID: 256729 RVA: 0x0124321D File Offset: 0x0124141D
		public AiStateMachineConditionTrue(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EADA RID: 256730 RVA: 0x01243228 File Offset: 0x01241428
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.ResultSelf = true;
			return true;
		}

		// Token: 0x0603EADB RID: 256731 RVA: 0x01243232 File Offset: 0x01241432
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("[True]");
		}
	}
}
