using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.NewWorld.Character.Monster.Controller;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064BC RID: 25788
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionCheckGroupPerform : AiStateMachineCondition
	{
		// Token: 0x0603EA6C RID: 256620 RVA: 0x012413FF File Offset: 0x0123F5FF
		public AiStateMachineConditionCheckGroupPerform(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA6D RID: 256621 RVA: 0x0124140A File Offset: 0x0123F60A
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			return true;
		}

		// Token: 0x0603EA6E RID: 256622 RVA: 0x0124140D File Offset: 0x0123F60D
		protected override void OnTick()
		{
			this.ResultSelf = MonsterGroupEcologyController.Instance.CheckEntityInMonsterGroup(this.Node.Entity.Id);
		}

		// Token: 0x0603EA6F RID: 256623 RVA: 0x0124142F File Offset: 0x0123F62F
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("可以集群表演\n");
		}
	}
}
