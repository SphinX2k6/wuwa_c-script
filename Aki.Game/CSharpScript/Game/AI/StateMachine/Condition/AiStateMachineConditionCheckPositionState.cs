using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x0200733C RID: 29500
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionCheckPositionState : AiStateMachineCondition
	{
		// Token: 0x0604862C RID: 296492 RVA: 0x0129EBD9 File Offset: 0x0129CDD9
		public AiStateMachineConditionCheckPositionState(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0604862D RID: 296493 RVA: 0x0129EBE4 File Offset: 0x0129CDE4
		protected override bool RegisterEvents()
		{
			if (base.RegisterEvents() && this.Node.Entity != null && !EventSystem.Instance.HasWithTarget(this.Node.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnCharPositionStateChanged)))
			{
				EventSystem.Instance.AddWithTarget(this.Node.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnCharPositionStateChanged));
				return true;
			}
			return false;
		}

		// Token: 0x0604862E RID: 296494 RVA: 0x0129EC58 File Offset: 0x0129CE58
		protected override bool UnregisterEvents()
		{
			if (base.UnregisterEvents() && this.Node.Entity != null && EventSystem.Instance.HasWithTarget(this.Node.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnCharPositionStateChanged)))
			{
				EventSystem.Instance.RemoveWithTarget(this.Node.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnCharPositionStateChanged));
				return true;
			}
			return false;
		}

		// Token: 0x0604862F RID: 296495 RVA: 0x0129ECCC File Offset: 0x0129CECC
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.PositionState = (ECharPositionState)condition.CondCheckPositionState.PositionState;
			return true;
		}

		// Token: 0x06048630 RID: 296496 RVA: 0x0129ECE0 File Offset: 0x0129CEE0
		protected override void OnTick()
		{
			this.ResultSelf = (this.Node.UnifiedStateComponent.PositionState == this.PositionState);
		}

		// Token: 0x06048631 RID: 296497 RVA: 0x0129ED00 File Offset: 0x0129CF00
		private void OnCharPositionStateChanged(ECharPositionState oldState, ECharPositionState newState)
		{
			this.ResultSelf = (this.Node.UnifiedStateComponent.PositionState == this.PositionState);
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionCheckPositionState", this.Node.Name);
			}
		}

		// Token: 0x06048632 RID: 296498 RVA: 0x0129ED65 File Offset: 0x0129CF65
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("有仇恨\n");
		}

		// Token: 0x04026461 RID: 156769
		private ECharPositionState PositionState;
	}
}
