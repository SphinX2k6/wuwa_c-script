using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064C8 RID: 25800
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionPartLife : AiStateMachineCondition
	{
		// Token: 0x0603EAC0 RID: 256704 RVA: 0x01242D63 File Offset: 0x01240F63
		public AiStateMachineConditionPartLife(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EAC1 RID: 256705 RVA: 0x01242D6E File Offset: 0x01240F6E
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			return true;
		}

		// Token: 0x0603EAC2 RID: 256706 RVA: 0x01242D71 File Offset: 0x01240F71
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("[部位血量]");
		}
	}
}
