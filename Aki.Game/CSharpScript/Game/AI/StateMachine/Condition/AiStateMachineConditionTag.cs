using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007346 RID: 29510
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionTag : AiStateMachineCondition
	{
		// Token: 0x06048676 RID: 296566 RVA: 0x012A02FF File Offset: 0x0129E4FF
		public AiStateMachineConditionTag(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048677 RID: 296567 RVA: 0x012A0318 File Offset: 0x0129E518
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.TagId = condition.CondTag.TagId;
			this.TagName = condition.CondTag.TagName;
			this.Handle = this.Node.TagComponent.ListenForTagAddOrRemove(new int?(this.TagId), new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange), null);
			this.ResultSelf = this.Node.TagComponent.HasTag(this.TagId);
			return true;
		}

		// Token: 0x06048678 RID: 296568 RVA: 0x012A0392 File Offset: 0x0129E592
		protected override void OnEnter()
		{
			this.ResultSelf = this.Node.TagComponent.HasTag(this.TagId);
		}

		// Token: 0x06048679 RID: 296569 RVA: 0x012A03B0 File Offset: 0x0129E5B0
		private void OnTagChange(int tagId, bool tagExists)
		{
			this.ResultSelf = tagExists;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionTag", this.Node.Name);
			}
		}

		// Token: 0x0604867A RID: 296570 RVA: 0x012A03FE File Offset: 0x0129E5FE
		protected override void OnClear()
		{
			this.Handle.EndTask();
			this.Handle = null;
		}

		// Token: 0x0604867B RID: 296571 RVA: 0x012A0414 File Offset: 0x0129E614
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("Tag[");
			appendInterpolatedStringHandler.AppendFormatted(this.TagName);
			appendInterpolatedStringHandler.AppendLiteral("]\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x0402646D RID: 156781
		public string TagName = "";

		// Token: 0x0402646E RID: 156782
		public int TagId;

		// Token: 0x0402646F RID: 156783
		[Nullable(2)]
		private ITagTask Handle;
	}
}
