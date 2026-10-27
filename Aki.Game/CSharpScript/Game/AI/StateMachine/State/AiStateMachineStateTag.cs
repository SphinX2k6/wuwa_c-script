using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x02007332 RID: 29490
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateTag : AiStateMachineState
	{
		// Token: 0x060485E8 RID: 296424 RVA: 0x0129DAF7 File Offset: 0x0129BCF7
		public AiStateMachineStateTag(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485E9 RID: 296425 RVA: 0x0129DB0C File Offset: 0x0129BD0C
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.TagId = state.BindTag.TagId;
			return true;
		}

		// Token: 0x060485EA RID: 296426 RVA: 0x0129DB20 File Offset: 0x0129BD20
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			if (this.TagHandle == null)
			{
				this.TagHandle = new int?(this.Node.BuffComponent.AddTagWithReturnHandle(new <>z__ReadOnlySingleElementList<int>(this.TagId), -1f));
			}
		}

		// Token: 0x060485EB RID: 296427 RVA: 0x0129DB5C File Offset: 0x0129BD5C
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

		// Token: 0x060485EC RID: 296428 RVA: 0x0129DC88 File Offset: 0x0129BE88
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0402643E RID: 156734
		public int TagId;

		// Token: 0x0402643F RID: 156735
		public string TagName = "";

		// Token: 0x04026440 RID: 156736
		public int? TagHandle;
	}
}
