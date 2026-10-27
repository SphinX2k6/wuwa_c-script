using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x0200734D RID: 29517
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionAddTagCount : AiStateMachineAction
	{
		// Token: 0x0604869D RID: 296605 RVA: 0x012A088D File Offset: 0x0129EA8D
		public AiStateMachineActionAddTagCount(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0604869E RID: 296606 RVA: 0x012A0898 File Offset: 0x0129EA98
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			CombatStateMachineDefine.Fsm.ActionAddTagCount actionAddTagCount = action.ActionAddTagCount;
			this.TagId = ((actionAddTagCount != null) ? new int?(actionAddTagCount.TagId) : null);
			CombatStateMachineDefine.Fsm.ActionAddTagCount actionAddTagCount2 = action.ActionAddTagCount;
			this.Count = ((actionAddTagCount2 != null) ? new int?(actionAddTagCount2.Count) : null);
			return true;
		}

		// Token: 0x0604869F RID: 296607 RVA: 0x012A08F0 File Offset: 0x0129EAF0
		public override void DoAction(long? contextId = null)
		{
			BaseTagComponent tagComponent = this.Node.TagComponent;
			if (tagComponent == null || !tagComponent.Valid)
			{
				return;
			}
			if (this.TagId != null && this.Count != null)
			{
				int? count = this.Count;
				int num = 0;
				if (!(count.GetValueOrDefault() <= num & count != null))
				{
					tagComponent.TagContainer.UpdateExactTag(ETagChannel.Common, this.TagId.Value, this.Count.Value);
					return;
				}
			}
		}

		// Token: 0x060486A0 RID: 296608 RVA: 0x012A0972 File Offset: 0x0129EB72
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026478 RID: 156792
		public int? TagId;

		// Token: 0x04026479 RID: 156793
		public int? Count;
	}
}
