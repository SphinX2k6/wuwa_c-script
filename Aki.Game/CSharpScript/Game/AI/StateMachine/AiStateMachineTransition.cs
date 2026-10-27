using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.AI.StateMachine.Condition;
using CSharpScript.Game.Utils.CombatStateMachine;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.AI.StateMachine
{
	// Token: 0x02007316 RID: 29462
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineTransition
	{
		// Token: 0x06048509 RID: 296201 RVA: 0x01298FBC File Offset: 0x012971BC
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

		// Token: 0x0604850A RID: 296202 RVA: 0x01299075 File Offset: 0x01297275
		public void Enter()
		{
			this.Condition.Enter();
		}

		// Token: 0x0604850B RID: 296203 RVA: 0x01299082 File Offset: 0x01297282
		public void Exit()
		{
			this.Condition.Exit();
		}

		// Token: 0x0604850C RID: 296204 RVA: 0x0129908F File Offset: 0x0129728F
		public void Tick()
		{
			this.Condition.Tick();
		}

		// Token: 0x0604850D RID: 296205 RVA: 0x0129909C File Offset: 0x0129729C
		public bool CheckPredictionCondition()
		{
			return ((this.TransitionPredictionType.GetValueOrDefault() == CombatStateMachineDefine.Fsm.ETransitionPredictionType.Autonomous && this.Node.ActorComponent.IsAutonomousProxy) || this.TransitionPredictionType.GetValueOrDefault() == CombatStateMachineDefine.Fsm.ETransitionPredictionType.Simulated) && this.Condition.Result;
		}

		// Token: 0x0604850E RID: 296206 RVA: 0x012990D9 File Offset: 0x012972D9
		public bool CanPrediction()
		{
			return (this.TransitionPredictionType.GetValueOrDefault() == CombatStateMachineDefine.Fsm.ETransitionPredictionType.Autonomous && this.Node.ActorComponent.IsAutonomousProxy) || this.TransitionPredictionType.GetValueOrDefault() == CombatStateMachineDefine.Fsm.ETransitionPredictionType.Simulated;
		}

		// Token: 0x0604850F RID: 296207 RVA: 0x0129910B File Offset: 0x0129730B
		public bool GetResult()
		{
			return this.Condition.Result;
		}

		// Token: 0x06048510 RID: 296208 RVA: 0x01299118 File Offset: 0x01297318
		public void HandleServerDebugInfo(RepeatedField<bool> conditions)
		{
			this.Condition.HandleServerDebugInfo(conditions);
		}

		// Token: 0x06048511 RID: 296209 RVA: 0x01299126 File Offset: 0x01297326
		public void Clear()
		{
			this.Condition.Clear();
			this.Node = null;
			this.ConditionDatas = null;
			this.Condition = null;
			this.Conditions = null;
		}

		// Token: 0x040263B2 RID: 156594
		[Nullable(2)]
		public AiStateMachineBase Node;

		// Token: 0x040263B3 RID: 156595
		public int From;

		// Token: 0x040263B4 RID: 156596
		public int To;

		// Token: 0x040263B5 RID: 156597
		public CombatStateMachineDefine.Fsm.ETransitionPredictionType? TransitionPredictionType;

		// Token: 0x040263B6 RID: 156598
		public int Weight;

		// Token: 0x040263B7 RID: 156599
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<CombatStateMachineDefine.Fsm.Condition> ConditionDatas;

		// Token: 0x040263B8 RID: 156600
		[Nullable(2)]
		public AiStateMachineCondition Condition;

		// Token: 0x040263B9 RID: 156601
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<AiStateMachineCondition> Conditions;

		// Token: 0x040263BA RID: 156602
		public bool HasTaskFinishCondition;
	}
}
