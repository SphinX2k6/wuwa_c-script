using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064BA RID: 25786
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionBuffStack : AiStateMachineCondition
	{
		// Token: 0x0603EA61 RID: 256609 RVA: 0x01241197 File Offset: 0x0123F397
		public AiStateMachineConditionBuffStack(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA62 RID: 256610 RVA: 0x012411A2 File Offset: 0x0123F3A2
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.BuffId = condition.CondBuffStack.BuffId;
			this.MinStack = condition.CondBuffStack.MinStack;
			this.MaxStack = condition.CondBuffStack.MaxStack;
			return true;
		}

		// Token: 0x0603EA63 RID: 256611 RVA: 0x012411D8 File Offset: 0x0123F3D8
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(34, 3, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("有检查Buff层数 [BuffId:");
			appendInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
			appendInterpolatedStringHandler.AppendLiteral("] [Min:");
			appendInterpolatedStringHandler.AppendFormatted<int>(this.MinStack);
			appendInterpolatedStringHandler.AppendLiteral("] [Max:");
			appendInterpolatedStringHandler.AppendFormatted<int>(this.MaxStack);
			appendInterpolatedStringHandler.AppendLiteral("]\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x04021746 RID: 137030
		public long BuffId;

		// Token: 0x04021747 RID: 137031
		public int MinStack;

		// Token: 0x04021748 RID: 137032
		public int MaxStack;
	}
}
