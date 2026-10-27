using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x02007355 RID: 29525
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionRemoveTagCount : AiStateMachineAction
	{
		// Token: 0x060486B8 RID: 296632 RVA: 0x012A0DAA File Offset: 0x0129EFAA
		public AiStateMachineActionRemoveTagCount(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x060486B9 RID: 296633 RVA: 0x012A0DB4 File Offset: 0x0129EFB4
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			CombatStateMachineDefine.Fsm.ActionRemoveTagCount actionRemoveTagCount = action.ActionRemoveTagCount;
			this.TagId = ((actionRemoveTagCount != null) ? new int?(actionRemoveTagCount.TagId) : null);
			CombatStateMachineDefine.Fsm.ActionRemoveTagCount actionRemoveTagCount2 = action.ActionRemoveTagCount;
			this.Count = ((actionRemoveTagCount2 != null) ? new int?(actionRemoveTagCount2.Count) : null);
			return true;
		}

		// Token: 0x060486BA RID: 296634 RVA: 0x012A0E0C File Offset: 0x0129F00C
		public override void DoAction(long? contextId = null)
		{
			BaseTagComponent tagComponent = this.Node.TagComponent;
			if (tagComponent == null || !tagComponent.Valid)
			{
				return;
			}
			if (this.TagId == null || this.Count == null)
			{
				return;
			}
			if (this.Count.GetValueOrDefault() == -1)
			{
				int rawTagCount = tagComponent.TagContainer.GetRawTagCount(ETagChannel.Common, this.TagId.Value);
				tagComponent.TagContainer.UpdateExactTag(ETagChannel.Common, this.TagId.Value, -rawTagCount);
				return;
			}
			int? count = this.Count;
			int num = 0;
			if (count.GetValueOrDefault() > num & count != null)
			{
				tagComponent.TagContainer.UpdateExactTag(ETagChannel.Common, this.TagId.Value, -this.Count.Value);
			}
		}

		// Token: 0x060486BB RID: 296635 RVA: 0x012A0ECC File Offset: 0x0129F0CC
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026482 RID: 156802
		public int? TagId;

		// Token: 0x04026483 RID: 156803
		public int? Count;
	}
}
