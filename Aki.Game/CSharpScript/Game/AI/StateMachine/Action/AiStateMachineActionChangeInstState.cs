using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064D2 RID: 25810
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionChangeInstState : AiStateMachineAction
	{
		// Token: 0x0603EAF2 RID: 256754 RVA: 0x01243468 File Offset: 0x01241668
		public AiStateMachineActionChangeInstState(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EAF3 RID: 256755 RVA: 0x0124347D File Offset: 0x0124167D
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			this.TagId = action.ActionInstChangeStateTag.TagId;
			this.TagName = GameplayTagUtils.GetNameByTagId(this.TagId);
			return true;
		}

		// Token: 0x0603EAF4 RID: 256756 RVA: 0x012434A2 File Offset: 0x012416A2
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021768 RID: 137064
		public int TagId;

		// Token: 0x04021769 RID: 137065
		public string TagName = "";
	}
}
