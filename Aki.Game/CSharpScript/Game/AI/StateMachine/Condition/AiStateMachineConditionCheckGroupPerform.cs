using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.NewWorld.Character.Monster.Controller;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007339 RID: 29497
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionCheckGroupPerform : AiStateMachineCondition
	{
		// Token: 0x0604861F RID: 296479 RVA: 0x0129E977 File Offset: 0x0129CB77
		public AiStateMachineConditionCheckGroupPerform(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048620 RID: 296480 RVA: 0x0129E982 File Offset: 0x0129CB82
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			return true;
		}

		// Token: 0x06048621 RID: 296481 RVA: 0x0129E985 File Offset: 0x0129CB85
		protected override void OnTick()
		{
			this.ResultSelf = MonsterGroupEcologyController.Instance.CheckEntityInMonsterGroup(this.Node.Entity.Id);
		}

		// Token: 0x06048622 RID: 296482 RVA: 0x0129E9A7 File Offset: 0x0129CBA7
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("可以集群表演\n");
		}
	}
}
