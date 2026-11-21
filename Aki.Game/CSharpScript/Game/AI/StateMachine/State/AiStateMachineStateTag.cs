using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064B5 RID: 25781
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateTag : AiStateMachineState
	{
		// Token: 0x0603EA35 RID: 256565 RVA: 0x01240580 File Offset: 0x0123E780
		public AiStateMachineStateTag(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603EA36 RID: 256566 RVA: 0x01240595 File Offset: 0x0123E795
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.TagId = state.BindTag.TagId;
			return true;
		}

		// Token: 0x0603EA37 RID: 256567 RVA: 0x012405A9 File Offset: 0x0123E7A9
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			if (this.TagHandle == null)
			{
				this.TagHandle = new int?(this.Node.BuffComponent.AddTagWithReturnHandle(new <>z__ReadOnlySingleElementList<int>(this.TagId), -1f));
			}
		}

		// Token: 0x0603EA38 RID: 256568 RVA: 0x012405E4 File Offset: 0x0123E7E4
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			bool flag = false;
			if (nextState != null && nextState.BindStates != null && nextState.BindStates.Count > 0)
			{
				foreach (AiStateMachineState aiStateMachineState in nextState.BindStates)
				{
					AiStateMachineStateTag aiStateMachineStateTag = aiStateMachineState as AiStateMachineStateTag;
					if (aiStateMachineStateTag != null && aiStateMachineStateTag.TagId == this.TagId)
					{
						aiStateMachineStateTag.TagHandle = this.TagHandle;
						flag = true;
					}
				}
			}
			if (this.TagHandle == null)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.StateMachineNew;
				Entity entity = this.Node.Entity;
				string message = "AiStateMachineStateTag移除Tag失败，TagHandle不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("node", this.Node.Name);
				instance.Error(flag2, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			if (!flag && this.TagHandle != null)
			{
				this.Node.BuffComponent.RemoveBuffByHandle(this.TagHandle.Value, -1, null, null, null, null);
			}
			this.TagHandle = null;
		}

		// Token: 0x0603EA39 RID: 256569 RVA: 0x01240710 File Offset: 0x0123E910
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0402172B RID: 137003
		public int TagId;

		// Token: 0x0402172C RID: 137004
		public string TagName = "";

		// Token: 0x0402172D RID: 137005
		public int? TagHandle;
	}
}
