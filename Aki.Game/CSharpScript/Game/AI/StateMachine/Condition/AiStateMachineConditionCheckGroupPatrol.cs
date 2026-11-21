using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MonsterGroup;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064BB RID: 25787
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionCheckGroupPatrol : AiStateMachineCondition
	{
		// Token: 0x0603EA64 RID: 256612 RVA: 0x0124125A File Offset: 0x0123F45A
		public AiStateMachineConditionCheckGroupPatrol(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA65 RID: 256613 RVA: 0x01241268 File Offset: 0x0123F468
		protected override bool RegisterEvents()
		{
			if (base.RegisterEvents() && this.Node.Entity != null && !EventSystem.Instance.Has<int>(EEventName.OnGeneratedMonsterPatrolGroup, new Action<int>(this.OnGeneratedMonsterPatrolGroup)))
			{
				EventSystem.Instance.Add<int>(EEventName.OnGeneratedMonsterPatrolGroup, new Action<int>(this.OnGeneratedMonsterPatrolGroup));
				return true;
			}
			return false;
		}

		// Token: 0x0603EA66 RID: 256614 RVA: 0x012412C8 File Offset: 0x0123F4C8
		protected override bool UnregisterEvents()
		{
			if (base.UnregisterEvents() && this.Node.Entity != null && EventSystem.Instance.Has<int>(EEventName.OnGeneratedMonsterPatrolGroup, new Action<int>(this.OnGeneratedMonsterPatrolGroup)))
			{
				EventSystem.Instance.Remove<int>(EEventName.OnGeneratedMonsterPatrolGroup, new Action<int>(this.OnGeneratedMonsterPatrolGroup));
				return true;
			}
			return false;
		}

		// Token: 0x0603EA67 RID: 256615 RVA: 0x01241326 File Offset: 0x0123F526
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.RegisterEvents();
			return true;
		}

		// Token: 0x0603EA68 RID: 256616 RVA: 0x01241330 File Offset: 0x0123F530
		protected override void OnClear()
		{
			this.UnregisterEvents();
		}

		// Token: 0x0603EA69 RID: 256617 RVA: 0x0124133C File Offset: 0x0123F53C
		protected override void OnTick()
		{
			MonsterPatrolInfo monsterInfoByEntityId = MonsterGroupPatrolModel.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id);
			this.ResultSelf = (monsterInfoByEntityId != null);
		}

		// Token: 0x0603EA6A RID: 256618 RVA: 0x01241370 File Offset: 0x0123F570
		private void OnGeneratedMonsterPatrolGroup(int groupEntityId)
		{
			if (this.Node != null && this.Node.Activated)
			{
				MonsterPatrolInfo monsterInfoByEntityId = MonsterGroupPatrolModel.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id);
				if (monsterInfoByEntityId != null != this.ResultSelf)
				{
					this.ResultSelf = (monsterInfoByEntityId != null);
					this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionCheckGroupPatrol", this.Node.Name);
				}
			}
		}

		// Token: 0x0603EA6B RID: 256619 RVA: 0x012413E9 File Offset: 0x0123F5E9
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("可以集群巡逻\n");
		}
	}
}
