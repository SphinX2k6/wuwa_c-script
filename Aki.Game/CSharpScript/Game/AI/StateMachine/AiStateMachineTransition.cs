using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.AI.StateMachine.Condition;
using CSharpScript.Game.Utils.CombatStateMachine;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.AI.StateMachine
{
	// Token: 0x02006499 RID: 25753
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineTransition
	{
		// Token: 0x0603E956 RID: 256342 RVA: 0x0123BA3C File Offset: 0x01239C3C
		public AiStateMachineTransition(AiStateMachineBase node, CombatStateMachineDefine.Fsm.Transition transition)
		{
			this.Node = node;
			CombatStateMachineDefine.Fsm.Node nodeData = node.Owner.GetNodeData(transition.From);
			this.From = ((nodeData != null) ? nodeData.Uuid : 0);
			CombatStateMachineDefine.Fsm.Node nodeData2 = node.Owner.GetNodeData(transition.To);
			this.To = ((nodeData2 != null) ? nodeData2.Uuid : 0);
			this.TransitionPredictionType = transition.TransitionPredictionType;
			this.Weight = transition.Weight;
			this.ConditionDatas = transition.Conditions;
			this.Condition = AiStateMachineModel.Instance.AiStateMachineFactory.CreateCondition(this, transition.Conditions[0], 0, null);
			this.HasTaskFinishCondition = this.Condition.HasTaskFinishCondition;
		}

		// Token: 0x0603E957 RID: 256343 RVA: 0x0123BAF5 File Offset: 0x01239CF5
		public void Enter()
		{
			this.Condition.Enter();
		}

		// Token: 0x0603E958 RID: 256344 RVA: 0x0123BB02 File Offset: 0x01239D02
		public void Exit()
		{
			this.Condition.Exit();
		}

		// Token: 0x0603E959 RID: 256345 RVA: 0x0123BB0F File Offset: 0x01239D0F
		public void Tick()
		{
			this.Condition.Tick();
		}

		// Token: 0x0603E95A RID: 256346 RVA: 0x0123BB1C File Offset: 0x01239D1C
		public bool CheckPredictionCondition()
		{
			return ((this.TransitionPredictionType.GetValueOrDefault() == CombatStateMachineDefine.Fsm.ETransitionPredictionType.Autonomous && this.Node.ActorComponent.IsAutonomousProxy) || this.TransitionPredictionType.GetValueOrDefault() == CombatStateMachineDefine.Fsm.ETransitionPredictionType.Simulated) && this.Condition.Result;
		}

		// Token: 0x0603E95B RID: 256347 RVA: 0x0123BB59 File Offset: 0x01239D59
		public bool CanPrediction()
		{
			return (this.TransitionPredictionType.GetValueOrDefault() == CombatStateMachineDefine.Fsm.ETransitionPredictionType.Autonomous && this.Node.ActorComponent.IsAutonomousProxy) || this.TransitionPredictionType.GetValueOrDefault() == CombatStateMachineDefine.Fsm.ETransitionPredictionType.Simulated;
		}

		// Token: 0x0603E95C RID: 256348 RVA: 0x0123BB8B File Offset: 0x01239D8B
		public bool GetResult()
		{
			return this.Condition.Result;
		}

		// Token: 0x0603E95D RID: 256349 RVA: 0x0123BB98 File Offset: 0x01239D98
		public void HandleServerDebugInfo(RepeatedField<bool> conditions)
		{
			this.Condition.HandleServerDebugInfo(conditions);
		}

		// Token: 0x0603E95E RID: 256350 RVA: 0x0123BBA6 File Offset: 0x01239DA6
		public void Clear()
		{
			this.Condition.Clear();
			this.Node = null;
			this.ConditionDatas = null;
			this.Condition = null;
			this.Conditions = null;
		}

		// Token: 0x0402169F RID: 136863
		[Nullable(2)]
		public AiStateMachineBase Node;

		// Token: 0x040216A0 RID: 136864
		public int From;

		// Token: 0x040216A1 RID: 136865
		public int To;

		// Token: 0x040216A2 RID: 136866
		public CombatStateMachineDefine.Fsm.ETransitionPredictionType? TransitionPredictionType;

		// Token: 0x040216A3 RID: 136867
		public int Weight;

		// Token: 0x040216A4 RID: 136868
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<CombatStateMachineDefine.Fsm.Condition> ConditionDatas;

		// Token: 0x040216A5 RID: 136869
		[Nullable(2)]
		public AiStateMachineCondition Condition;

		// Token: 0x040216A6 RID: 136870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<AiStateMachineCondition> Conditions;

		// Token: 0x040216A7 RID: 136871
		public bool HasTaskFinishCondition;
	}
}
