using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064D8 RID: 25816
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionRemoveTagCount : AiStateMachineAction
	{
		// Token: 0x0603EB05 RID: 256773 RVA: 0x01243832 File Offset: 0x01241A32
		public AiStateMachineActionRemoveTagCount(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EB06 RID: 256774 RVA: 0x0124383C File Offset: 0x01241A3C
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			CombatStateMachineDefine.Fsm.ActionRemoveTagCount actionRemoveTagCount = action.ActionRemoveTagCount;
			this.TagId = ((actionRemoveTagCount != null) ? new int?(actionRemoveTagCount.TagId) : null);
			CombatStateMachineDefine.Fsm.ActionRemoveTagCount actionRemoveTagCount2 = action.ActionRemoveTagCount;
			this.Count = ((actionRemoveTagCount2 != null) ? new int?(actionRemoveTagCount2.Count) : null);
			return true;
		}

		// Token: 0x0603EB07 RID: 256775 RVA: 0x01243894 File Offset: 0x01241A94
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
				using (IEnumerator<ETagChannel> enumerator = AiStateMachineActionRemoveTagCount.RemoveChannels.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ETagChannel tagChannel = enumerator.Current;
						tagComponent.TagContainer.RemoveExactTag(tagChannel, this.TagId.Value);
					}
					return;
				}
			}
			int? count = this.Count;
			int num = 0;
			if (count.GetValueOrDefault() > num & count != null)
			{
				foreach (ETagChannel tagChannel2 in AiStateMachineActionRemoveTagCount.RemoveChannels)
				{
					tagComponent.TagContainer.UpdateExactTag(tagChannel2, this.TagId.Value, -this.Count.Value);
				}
			}
		}

		// Token: 0x0603EB08 RID: 256776 RVA: 0x012439AC File Offset: 0x01241BAC
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0402176F RID: 137071
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<ETagChannel> RemoveChannels = new <>z__ReadOnlyArray<ETagChannel>(new ETagChannel[]
		{
			ETagChannel.Common,
			ETagChannel.Anim
		});

		// Token: 0x04021770 RID: 137072
		public int? TagId;

		// Token: 0x04021771 RID: 137073
		public int? Count;
	}
}
