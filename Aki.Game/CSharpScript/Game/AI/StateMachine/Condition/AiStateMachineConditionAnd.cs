using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007334 RID: 29492
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionAnd : AiStateMachineCondition
	{
		// Token: 0x06048601 RID: 296449 RVA: 0x0129E077 File Offset: 0x0129C277
		public AiStateMachineConditionAnd(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048602 RID: 296450 RVA: 0x0129E084 File Offset: 0x0129C284
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			int count = condition.CondAnd.Conditions.Count;
			if (count > 0)
			{
				this.Conditions = new AiStateMachineCondition[count];
				for (int i = 0; i < count; i++)
				{
					int index = condition.CondAnd.Conditions[i];
					CombatStateMachineDefine.Fsm.Condition condition2 = this.Transition.ConditionDatas[index];
					AiStateMachineCondition aiStateMachineCondition = AiStateMachineModel.Instance.AiStateMachineFactory.CreateCondition(this.Transition, condition2, index, this);
					this.HasTaskFinishCondition = (this.HasTaskFinishCondition || aiStateMachineCondition.HasTaskFinishCondition);
					this.Conditions[i] = aiStateMachineCondition;
				}
			}
			return true;
		}

		// Token: 0x06048603 RID: 296451 RVA: 0x0129E120 File Offset: 0x0129C320
		protected override void OnEnter()
		{
			this.HasSignaled = false;
			AiStateMachineCondition[] conditions = this.Conditions;
			for (int i = 0; i < conditions.Length; i++)
			{
				conditions[i].Enter();
			}
		}

		// Token: 0x06048604 RID: 296452 RVA: 0x0129E154 File Offset: 0x0129C354
		protected override void OnExit()
		{
			this.HasSignaled = false;
			AiStateMachineCondition[] conditions = this.Conditions;
			for (int i = 0; i < conditions.Length; i++)
			{
				conditions[i].Exit();
			}
		}

		// Token: 0x06048605 RID: 296453 RVA: 0x0129E188 File Offset: 0x0129C388
		protected override void OnTick()
		{
			this.ResultSelf = true;
			foreach (AiStateMachineCondition aiStateMachineCondition in this.Conditions)
			{
				aiStateMachineCondition.Tick();
				this.ResultSelf &= aiStateMachineCondition.Result;
			}
		}

		// Token: 0x06048606 RID: 296454 RVA: 0x0129E1D0 File Offset: 0x0129C3D0
		protected override void OnClear()
		{
			this.HasSignaled = false;
			AiStateMachineCondition[] conditions = this.Conditions;
			for (int i = 0; i < conditions.Length; i++)
			{
				conditions[i].Clear();
			}
			this.Conditions = null;
		}

		// Token: 0x06048607 RID: 296455 RVA: 0x0129E208 File Offset: 0x0129C408
		public override void HandleServerDebugInfo(RepeatedField<bool> conditions)
		{
			this.ResultServer = conditions[this.Index.Value];
			AiStateMachineCondition[] conditions2 = this.Conditions;
			for (int i = 0; i < conditions2.Length; i++)
			{
				conditions2[i].HandleServerDebugInfo(conditions);
			}
		}

		// Token: 0x06048608 RID: 296456 RVA: 0x0129E24C File Offset: 0x0129C44C
		public override void OnSignaled()
		{
			this.ResultSelf = true;
			foreach (AiStateMachineCondition aiStateMachineCondition in this.Conditions)
			{
				this.ResultSelf &= aiStateMachineCondition.Result;
			}
			base.Signaled();
		}

		// Token: 0x06048609 RID: 296457 RVA: 0x0129E294 File Offset: 0x0129C494
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("与\n");
			AiStateMachineCondition[] conditions = this.Conditions;
			for (int i = 0; i < conditions.Length; i++)
			{
				conditions[i].ToString(outBuilder, depth + 1);
			}
		}

		// Token: 0x0402644E RID: 156750
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public AiStateMachineCondition[] Conditions;
	}
}
