using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064C9 RID: 25801
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionTag : AiStateMachineCondition
	{
		// Token: 0x0603EAC3 RID: 256707 RVA: 0x01242D87 File Offset: 0x01240F87
		public AiStateMachineConditionTag(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EAC4 RID: 256708 RVA: 0x01242DA0 File Offset: 0x01240FA0
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.TagId = condition.CondTag.TagId;
			this.TagName = condition.CondTag.TagName;
			this.Handle = this.Node.TagComponent.ListenForTagAddOrRemove(new int?(this.TagId), new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange), null);
			this.ResultSelf = this.Node.TagComponent.HasTag(this.TagId);
			return true;
		}

		// Token: 0x0603EAC5 RID: 256709 RVA: 0x01242E1A File Offset: 0x0124101A
		protected override void OnEnter()
		{
			this.ResultSelf = this.Node.TagComponent.HasTag(this.TagId);
		}

		// Token: 0x0603EAC6 RID: 256710 RVA: 0x01242E38 File Offset: 0x01241038
		private void OnTagChange(int tagId, bool tagExists)
		{
			this.ResultSelf = tagExists;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionTag", this.Node.Name);
			}
		}

		// Token: 0x0603EAC7 RID: 256711 RVA: 0x01242E86 File Offset: 0x01241086
		protected override void OnClear()
		{
			this.Handle.EndTask();
			this.Handle = null;
		}

		// Token: 0x0603EAC8 RID: 256712 RVA: 0x01242E9C File Offset: 0x0124109C
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("Tag[");
			appendInterpolatedStringHandler.AppendFormatted(this.TagName);
			appendInterpolatedStringHandler.AppendLiteral("]\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x0402175A RID: 137050
		public string TagName = "";

		// Token: 0x0402175B RID: 137051
		public int TagId;

		// Token: 0x0402175C RID: 137052
		[Nullable(2)]
		private ITagTask Handle;
	}
}
