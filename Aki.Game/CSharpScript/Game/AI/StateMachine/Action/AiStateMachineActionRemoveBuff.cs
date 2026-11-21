using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064D7 RID: 25815
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionRemoveBuff : AiStateMachineAction
	{
		// Token: 0x0603EB02 RID: 256770 RVA: 0x01243806 File Offset: 0x01241A06
		public AiStateMachineActionRemoveBuff(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EB03 RID: 256771 RVA: 0x01243810 File Offset: 0x01241A10
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			this.BuffId = new long?(action.ActionRemoveBuff.BuffId);
			return true;
		}

		// Token: 0x0603EB04 RID: 256772 RVA: 0x01243829 File Offset: 0x01241A29
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0402176E RID: 137070
		public long? BuffId;
	}
}
