using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064BF RID: 25791
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionCheckPositionState : AiStateMachineCondition
	{
		// Token: 0x0603EA79 RID: 256633 RVA: 0x01241661 File Offset: 0x0123F861
		public AiStateMachineConditionCheckPositionState(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA7A RID: 256634 RVA: 0x0124166C File Offset: 0x0123F86C
		protected override bool RegisterEvents()
		{
			if (base.RegisterEvents() && this.Node.Entity != null && !EventSystem.Instance.HasWithTarget(this.Node.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnCharPositionStateChanged)))
			{
				EventSystem.Instance.AddWithTarget(this.Node.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnCharPositionStateChanged));
				return true;
			}
			return false;
		}

		// Token: 0x0603EA7B RID: 256635 RVA: 0x012416E0 File Offset: 0x0123F8E0
		protected override bool UnregisterEvents()
		{
			if (base.UnregisterEvents() && this.Node.Entity != null && EventSystem.Instance.HasWithTarget(this.Node.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnCharPositionStateChanged)))
			{
				EventSystem.Instance.RemoveWithTarget(this.Node.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnCharPositionStateChanged));
				return true;
			}
			return false;
		}

		// Token: 0x0603EA7C RID: 256636 RVA: 0x01241754 File Offset: 0x0123F954
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.PositionState = (ECharPositionState)condition.CondCheckPositionState.PositionState;
			return true;
		}

		// Token: 0x0603EA7D RID: 256637 RVA: 0x01241768 File Offset: 0x0123F968
		protected override void OnTick()
		{
			this.ResultSelf = (this.Node.UnifiedStateComponent.PositionState == this.PositionState);
		}

		// Token: 0x0603EA7E RID: 256638 RVA: 0x01241788 File Offset: 0x0123F988
		private void OnCharPositionStateChanged(ECharPositionState oldState, ECharPositionState newState)
		{
			this.ResultSelf = (this.Node.UnifiedStateComponent.PositionState == this.PositionState);
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionCheckPositionState", this.Node.Name);
			}
		}

		// Token: 0x0603EA7F RID: 256639 RVA: 0x012417ED File Offset: 0x0123F9ED
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("有仇恨\n");
		}

		// Token: 0x0402174E RID: 137038
		private ECharPositionState PositionState;
	}
}
