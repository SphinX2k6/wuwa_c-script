using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x0200734F RID: 29519
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionChangeInstState : AiStateMachineAction
	{
		// Token: 0x060486A5 RID: 296613 RVA: 0x012A09E0 File Offset: 0x0129EBE0
		public AiStateMachineActionChangeInstState(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x060486A6 RID: 296614 RVA: 0x012A09F5 File Offset: 0x0129EBF5
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			this.TagId = action.ActionInstChangeStateTag.TagId;
			this.TagName = GameplayTagUtils.GetNameByTagId(this.TagId);
			return true;
		}

		// Token: 0x060486A7 RID: 296615 RVA: 0x012A0A1A File Offset: 0x0129EC1A
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0402647B RID: 156795
		public int TagId;

		// Token: 0x0402647C RID: 156796
		public string TagName = "";
	}
}
