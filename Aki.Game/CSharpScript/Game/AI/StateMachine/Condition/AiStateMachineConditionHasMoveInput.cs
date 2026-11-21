using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064C1 RID: 25793
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionHasMoveInput : AiStateMachineCondition
	{
		// Token: 0x0603EA88 RID: 256648 RVA: 0x01241A7D File Offset: 0x0123FC7D
		public AiStateMachineConditionHasMoveInput(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA89 RID: 256649 RVA: 0x01241A88 File Offset: 0x0123FC88
		protected override bool RegisterEvents()
		{
			if (base.RegisterEvents() && this.Node != null && this.Node.Entity != null)
			{
				bool result = false;
				if (!EventSystem.Instance.HasWithTarget(this.Node.Entity, EEventName.OnInputMoveChanged, new Action<bool, bool>(this.OnInputMoveChanged)))
				{
					EventSystem.Instance.AddWithTarget(this.Node.Entity, EEventName.OnInputMoveChanged, new Action<bool, bool>(this.OnInputMoveChanged));
					result = true;
				}
				if (!EventSystem.Instance.HasWithTarget(this.Node.Entity, EEventName.OnFloatingMoveInputChanged, new Action<bool, bool>(this.OnFloatingMoveInputChanged)))
				{
					EventSystem.Instance.AddWithTarget(this.Node.Entity, EEventName.OnFloatingMoveInputChanged, new Action<bool, bool>(this.OnFloatingMoveInputChanged));
					result = true;
				}
				return result;
			}
			return false;
		}

		// Token: 0x0603EA8A RID: 256650 RVA: 0x01241B64 File Offset: 0x0123FD64
		protected override bool UnregisterEvents()
		{
			if (base.UnregisterEvents() && this.Node != null && this.Node.Entity != null)
			{
				bool result = false;
				if (EventSystem.Instance.HasWithTarget(this.Node.Entity, EEventName.OnInputMoveChanged, new Action<bool, bool>(this.OnInputMoveChanged)))
				{
					EventSystem.Instance.RemoveWithTarget(this.Node.Entity, EEventName.OnInputMoveChanged, new Action<bool, bool>(this.OnInputMoveChanged));
					result = true;
				}
				if (EventSystem.Instance.HasWithTarget(this.Node.Entity, EEventName.OnFloatingMoveInputChanged, new Action<bool, bool>(this.OnFloatingMoveInputChanged)))
				{
					EventSystem.Instance.RemoveWithTarget(this.Node.Entity, EEventName.OnFloatingMoveInputChanged, new Action<bool, bool>(this.OnFloatingMoveInputChanged));
					result = true;
				}
				return result;
			}
			return false;
		}

		// Token: 0x0603EA8B RID: 256651 RVA: 0x01241C3E File Offset: 0x0123FE3E
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.RegisterEvents();
			return true;
		}

		// Token: 0x0603EA8C RID: 256652 RVA: 0x01241C48 File Offset: 0x0123FE48
		protected override void OnClear()
		{
			this.UnregisterEvents();
		}

		// Token: 0x0603EA8D RID: 256653 RVA: 0x01241C51 File Offset: 0x0123FE51
		protected override void OnTick()
		{
			bool resultSelf;
			if (!this.Node.MoveComponent.HasMoveInput)
			{
				CharacterFloatingComponent floatingComponent = this.Node.FloatingComponent;
				resultSelf = (floatingComponent != null && floatingComponent.HasFloatingMoveInput);
			}
			else
			{
				resultSelf = true;
			}
			this.ResultSelf = resultSelf;
		}

		// Token: 0x0603EA8E RID: 256654 RVA: 0x01241C88 File Offset: 0x0123FE88
		private void OnInputMoveChanged(bool hadInputMove, bool hasInputMove)
		{
			bool resultSelf;
			if (!this.Node.MoveComponent.HasMoveInput)
			{
				CharacterFloatingComponent floatingComponent = this.Node.FloatingComponent;
				resultSelf = (floatingComponent != null && floatingComponent.HasFloatingMoveInput);
			}
			else
			{
				resultSelf = true;
			}
			this.ResultSelf = resultSelf;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionHasMoveInput", this.Node.Name);
			}
		}

		// Token: 0x0603EA8F RID: 256655 RVA: 0x01241D04 File Offset: 0x0123FF04
		private void OnFloatingMoveInputChanged(bool hadFloatingMoveInput, bool hasFloatingMoveInput)
		{
			bool resultSelf;
			if (!this.Node.MoveComponent.HasMoveInput)
			{
				CharacterFloatingComponent floatingComponent = this.Node.FloatingComponent;
				resultSelf = (floatingComponent != null && floatingComponent.HasFloatingMoveInput);
			}
			else
			{
				resultSelf = true;
			}
			this.ResultSelf = resultSelf;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionHasFloatingMoveInput", this.Node.Name);
			}
		}

		// Token: 0x0603EA90 RID: 256656 RVA: 0x01241D7D File Offset: 0x0123FF7D
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("有移动输入\n");
		}
	}
}
