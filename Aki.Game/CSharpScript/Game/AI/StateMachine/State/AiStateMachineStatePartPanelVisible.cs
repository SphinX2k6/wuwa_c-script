using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064B4 RID: 25780
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStatePartPanelVisible : AiStateMachineState
	{
		// Token: 0x0603EA30 RID: 256560 RVA: 0x012404DF File Offset: 0x0123E6DF
		public AiStateMachineStatePartPanelVisible(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603EA31 RID: 256561 RVA: 0x012404E9 File Offset: 0x0123E6E9
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.PartName = new FName?(new FName(state.BindPartPanelVisible.PartName));
			this.Visible = state.BindPartPanelVisible.Visible;
			return true;
		}

		// Token: 0x0603EA32 RID: 256562 RVA: 0x01240518 File Offset: 0x0123E718
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			EventSystem.Instance.Emit<int, FName?, bool>(EEventName.OnSetPartStateVisible, this.Node.Entity.Id, this.PartName, this.Visible);
		}

		// Token: 0x0603EA33 RID: 256563 RVA: 0x01240546 File Offset: 0x0123E746
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			EventSystem.Instance.Emit<int, FName?, bool>(EEventName.OnSetPartStateVisible, this.Node.Entity.Id, this.PartName, !this.Visible);
		}

		// Token: 0x0603EA34 RID: 256564 RVA: 0x01240577 File Offset: 0x0123E777
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021729 RID: 137001
		public FName? PartName;

		// Token: 0x0402172A RID: 137002
		public bool Visible;
	}
}
