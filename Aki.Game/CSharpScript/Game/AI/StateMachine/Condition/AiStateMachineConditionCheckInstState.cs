using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x0200733A RID: 29498
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionCheckInstState : AiStateMachineCondition
	{
		// Token: 0x06048623 RID: 296483 RVA: 0x0129E9BD File Offset: 0x0129CBBD
		public AiStateMachineConditionCheckInstState(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048624 RID: 296484 RVA: 0x0129E9D4 File Offset: 0x0129CBD4
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.TagId = condition.CondInstStateChange.TagId;
			this.TagName = GameplayTagUtils.GetNameByTagId(this.TagId);
			this.Handle = this.Node.TagComponent.ListenForTagAddOrRemove(new int?(this.TagId), new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange), null);
			this.ResultSelf = this.Node.TagComponent.HasTag(this.TagId);
			return true;
		}

		// Token: 0x06048625 RID: 296485 RVA: 0x0129EA50 File Offset: 0x0129CC50
		private void OnTagChange(int tagId, bool tagExists)
		{
			this.ResultSelf = tagExists;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionCheckInstState", this.Node.Name);
			}
		}

		// Token: 0x06048626 RID: 296486 RVA: 0x0129EA9E File Offset: 0x0129CC9E
		protected override void OnClear()
		{
			this.Handle.EndTask();
			this.Handle = null;
		}

		// Token: 0x06048627 RID: 296487 RVA: 0x0129EAB4 File Offset: 0x0129CCB4
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("Tag[");
			appendInterpolatedStringHandler.AppendFormatted(this.TagName);
			appendInterpolatedStringHandler.AppendLiteral("]\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x0402645C RID: 156764
		public string TagName = "";

		// Token: 0x0402645D RID: 156765
		public int TagId;

		// Token: 0x0402645E RID: 156766
		[Nullable(2)]
		private ITagTask Handle;
	}
}
