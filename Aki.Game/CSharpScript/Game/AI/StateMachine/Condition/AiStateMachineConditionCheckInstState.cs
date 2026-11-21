using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064BD RID: 25789
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionCheckInstState : AiStateMachineCondition
	{
		// Token: 0x0603EA70 RID: 256624 RVA: 0x01241445 File Offset: 0x0123F645
		public AiStateMachineConditionCheckInstState(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA71 RID: 256625 RVA: 0x0124145C File Offset: 0x0123F65C
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.TagId = condition.CondInstStateChange.TagId;
			this.TagName = GameplayTagUtils.GetNameByTagId(this.TagId);
			this.Handle = this.Node.TagComponent.ListenForTagAddOrRemove(new int?(this.TagId), new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange), null);
			this.ResultSelf = this.Node.TagComponent.HasTag(this.TagId);
			return true;
		}

		// Token: 0x0603EA72 RID: 256626 RVA: 0x012414D8 File Offset: 0x0123F6D8
		private void OnTagChange(int tagId, bool tagExists)
		{
			this.ResultSelf = tagExists;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionCheckInstState", this.Node.Name);
			}
		}

		// Token: 0x0603EA73 RID: 256627 RVA: 0x01241526 File Offset: 0x0123F726
		protected override void OnClear()
		{
			this.Handle.EndTask();
			this.Handle = null;
		}

		// Token: 0x0603EA74 RID: 256628 RVA: 0x0124153C File Offset: 0x0123F73C
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("Tag[");
			appendInterpolatedStringHandler.AppendFormatted(this.TagName);
			appendInterpolatedStringHandler.AppendLiteral("]\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x04021749 RID: 137033
		public string TagName = "";

		// Token: 0x0402174A RID: 137034
		public int TagId;

		// Token: 0x0402174B RID: 137035
		[Nullable(2)]
		private ITagTask Handle;
	}
}
