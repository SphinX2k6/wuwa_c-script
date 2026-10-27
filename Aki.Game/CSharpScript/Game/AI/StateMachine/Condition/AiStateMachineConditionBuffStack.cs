using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007337 RID: 29495
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionBuffStack : AiStateMachineCondition
	{
		// Token: 0x06048614 RID: 296468 RVA: 0x0129E70F File Offset: 0x0129C90F
		public AiStateMachineConditionBuffStack(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048615 RID: 296469 RVA: 0x0129E71A File Offset: 0x0129C91A
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.BuffId = condition.CondBuffStack.BuffId;
			this.MinStack = condition.CondBuffStack.MinStack;
			this.MaxStack = condition.CondBuffStack.MaxStack;
			return true;
		}

		// Token: 0x06048616 RID: 296470 RVA: 0x0129E750 File Offset: 0x0129C950
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

		// Token: 0x04026459 RID: 156761
		public long BuffId;

		// Token: 0x0402645A RID: 156762
		public int MinStack;

		// Token: 0x0402645B RID: 156763
		public int MaxStack;
	}
}
