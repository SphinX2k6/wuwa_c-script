using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064D0 RID: 25808
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionAddTagCount : AiStateMachineAction
	{
		// Token: 0x0603EAEA RID: 256746 RVA: 0x01243315 File Offset: 0x01241515
		public AiStateMachineActionAddTagCount(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EAEB RID: 256747 RVA: 0x01243320 File Offset: 0x01241520
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			CombatStateMachineDefine.Fsm.ActionAddTagCount actionAddTagCount = action.ActionAddTagCount;
			this.TagId = ((actionAddTagCount != null) ? new int?(actionAddTagCount.TagId) : null);
			CombatStateMachineDefine.Fsm.ActionAddTagCount actionAddTagCount2 = action.ActionAddTagCount;
			this.Count = ((actionAddTagCount2 != null) ? new int?(actionAddTagCount2.Count) : null);
			return true;
		}

		// Token: 0x0603EAEC RID: 256748 RVA: 0x01243378 File Offset: 0x01241578
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

		// Token: 0x0603EAED RID: 256749 RVA: 0x012433FA File Offset: 0x012415FA
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021765 RID: 137061
		public int? TagId;

		// Token: 0x04021766 RID: 137062
		public int? Count;
	}
}
