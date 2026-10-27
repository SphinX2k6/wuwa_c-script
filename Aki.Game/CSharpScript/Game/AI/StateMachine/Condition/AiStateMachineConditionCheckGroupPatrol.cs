using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MonsterGroup;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007338 RID: 29496
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionCheckGroupPatrol : AiStateMachineCondition
	{
		// Token: 0x06048617 RID: 296471 RVA: 0x0129E7D2 File Offset: 0x0129C9D2
		public AiStateMachineConditionCheckGroupPatrol(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048618 RID: 296472 RVA: 0x0129E7E0 File Offset: 0x0129C9E0
		protected override bool RegisterEvents()
		{
			if (base.RegisterEvents() && this.Node.Entity != null && !EventSystem.Instance.Has<int>(EEventName.OnGeneratedMonsterPatrolGroup, new Action<int>(this.OnGeneratedMonsterPatrolGroup)))
			{
				EventSystem.Instance.Add<int>(EEventName.OnGeneratedMonsterPatrolGroup, new Action<int>(this.OnGeneratedMonsterPatrolGroup));
				return true;
			}
			return false;
		}

		// Token: 0x06048619 RID: 296473 RVA: 0x0129E840 File Offset: 0x0129CA40
		protected override bool UnregisterEvents()
		{
			if (base.UnregisterEvents() && this.Node.Entity != null && EventSystem.Instance.Has<int>(EEventName.OnGeneratedMonsterPatrolGroup, new Action<int>(this.OnGeneratedMonsterPatrolGroup)))
			{
				EventSystem.Instance.Remove<int>(EEventName.OnGeneratedMonsterPatrolGroup, new Action<int>(this.OnGeneratedMonsterPatrolGroup));
				return true;
			}
			return false;
		}

		// Token: 0x0604861A RID: 296474 RVA: 0x0129E89E File Offset: 0x0129CA9E
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.RegisterEvents();
			return true;
		}

		// Token: 0x0604861B RID: 296475 RVA: 0x0129E8A8 File Offset: 0x0129CAA8
		protected override void OnClear()
		{
			this.UnregisterEvents();
		}

		// Token: 0x0604861C RID: 296476 RVA: 0x0129E8B4 File Offset: 0x0129CAB4
		protected override void OnTick()
		{
			MonsterPatrolInfo monsterInfoByEntityId = MonsterGroupPatrolModel.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id);
			this.ResultSelf = (monsterInfoByEntityId != null);
		}

		// Token: 0x0604861D RID: 296477 RVA: 0x0129E8E8 File Offset: 0x0129CAE8
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

		// Token: 0x0604861E RID: 296478 RVA: 0x0129E961 File Offset: 0x0129CB61
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("可以集群巡逻\n");
		}
	}
}
