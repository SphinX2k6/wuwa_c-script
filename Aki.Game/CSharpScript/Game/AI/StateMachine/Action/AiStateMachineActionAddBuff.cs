using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064CF RID: 25807
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionAddBuff : AiStateMachineAction
	{
		// Token: 0x0603EAE7 RID: 256743 RVA: 0x012432E9 File Offset: 0x012414E9
		public AiStateMachineActionAddBuff(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EAE8 RID: 256744 RVA: 0x012432F3 File Offset: 0x012414F3
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			this.BuffId = new long?(action.ActionAddBuff.BuffId);
			return true;
		}

		// Token: 0x0603EAE9 RID: 256745 RVA: 0x0124330C File Offset: 0x0124150C
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021764 RID: 137060
		public long? BuffId;
	}
}
