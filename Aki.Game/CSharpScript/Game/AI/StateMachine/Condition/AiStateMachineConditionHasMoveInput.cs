using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x0200733E RID: 29502
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionHasMoveInput : AiStateMachineCondition
	{
		// Token: 0x0604863B RID: 296507 RVA: 0x0129EFF5 File Offset: 0x0129D1F5
		public AiStateMachineConditionHasMoveInput(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0604863C RID: 296508 RVA: 0x0129F000 File Offset: 0x0129D200
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

		// Token: 0x0604863D RID: 296509 RVA: 0x0129F0DC File Offset: 0x0129D2DC
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

		// Token: 0x0604863E RID: 296510 RVA: 0x0129F1B6 File Offset: 0x0129D3B6
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.RegisterEvents();
			return true;
		}

		// Token: 0x0604863F RID: 296511 RVA: 0x0129F1C0 File Offset: 0x0129D3C0
		protected override void OnClear()
		{
			this.UnregisterEvents();
		}

		// Token: 0x06048640 RID: 296512 RVA: 0x0129F1C9 File Offset: 0x0129D3C9
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

		// Token: 0x06048641 RID: 296513 RVA: 0x0129F200 File Offset: 0x0129D400
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

		// Token: 0x06048642 RID: 296514 RVA: 0x0129F27C File Offset: 0x0129D47C
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

		// Token: 0x06048643 RID: 296515 RVA: 0x0129F2F5 File Offset: 0x0129D4F5
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("有移动输入\n");
		}
	}
}
