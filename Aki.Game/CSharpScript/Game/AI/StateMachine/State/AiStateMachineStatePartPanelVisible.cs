using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x02007331 RID: 29489
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStatePartPanelVisible : AiStateMachineState
	{
		// Token: 0x060485E3 RID: 296419 RVA: 0x0129DA56 File Offset: 0x0129BC56
		public AiStateMachineStatePartPanelVisible(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485E4 RID: 296420 RVA: 0x0129DA60 File Offset: 0x0129BC60
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.PartName = new FName?(new FName(state.BindPartPanelVisible.PartName));
			this.Visible = state.BindPartPanelVisible.Visible;
			return true;
		}

		// Token: 0x060485E5 RID: 296421 RVA: 0x0129DA8F File Offset: 0x0129BC8F
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			EventSystem.Instance.Emit<int, FName?, bool>(EEventName.OnSetPartStateVisible, this.Node.Entity.Id, this.PartName, this.Visible);
		}

		// Token: 0x060485E6 RID: 296422 RVA: 0x0129DABD File Offset: 0x0129BCBD
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			EventSystem.Instance.Emit<int, FName?, bool>(EEventName.OnSetPartStateVisible, this.Node.Entity.Id, this.PartName, !this.Visible);
		}

		// Token: 0x060485E7 RID: 296423 RVA: 0x0129DAEE File Offset: 0x0129BCEE
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0402643C RID: 156732
		public FName? PartName;

		// Token: 0x0402643D RID: 156733
		public bool Visible;
	}
}
