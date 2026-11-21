using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064C7 RID: 25799
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionOr : AiStateMachineCondition
	{
		// Token: 0x0603EAB7 RID: 256695 RVA: 0x01242AE5 File Offset: 0x01240CE5
		public AiStateMachineConditionOr(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EAB8 RID: 256696 RVA: 0x01242AF0 File Offset: 0x01240CF0
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			int count = condition.CondOr.Conditions.Count;
			if (count > 0)
			{
				this.Conditions = new AiStateMachineCondition[count];
				for (int i = 0; i < count; i++)
				{
					int index = condition.CondOr.Conditions[i];
					CombatStateMachineDefine.Fsm.Condition condition2 = this.Transition.ConditionDatas[index];
					AiStateMachineCondition aiStateMachineCondition = AiStateMachineModel.Instance.AiStateMachineFactory.CreateCondition(this.Transition, condition2, index, this);
					this.HasTaskFinishCondition = (this.HasTaskFinishCondition || aiStateMachineCondition.HasTaskFinishCondition);
					this.Conditions[i] = aiStateMachineCondition;
				}
			}
			return true;
		}

		// Token: 0x0603EAB9 RID: 256697 RVA: 0x01242B8C File Offset: 0x01240D8C
		protected override void OnEnter()
		{
			this.HasSignaled = false;
			AiStateMachineCondition[] conditions = this.Conditions;
			for (int i = 0; i < conditions.Length; i++)
			{
				conditions[i].Enter();
			}
		}

		// Token: 0x0603EABA RID: 256698 RVA: 0x01242BC0 File Offset: 0x01240DC0
		protected override void OnExit()
		{
			this.HasSignaled = false;
			AiStateMachineCondition[] conditions = this.Conditions;
			for (int i = 0; i < conditions.Length; i++)
			{
				conditions[i].Exit();
			}
		}

		// Token: 0x0603EABB RID: 256699 RVA: 0x01242BF4 File Offset: 0x01240DF4
		protected override void OnTick()
		{
			this.ResultSelf = false;
			foreach (AiStateMachineCondition aiStateMachineCondition in this.Conditions)
			{
				aiStateMachineCondition.Tick();
				this.ResultSelf = (this.ResultSelf || aiStateMachineCondition.Result);
			}
		}

		// Token: 0x0603EABC RID: 256700 RVA: 0x01242C40 File Offset: 0x01240E40
		protected override void OnClear()
		{
			this.HasSignaled = false;
			AiStateMachineCondition[] conditions = this.Conditions;
			for (int i = 0; i < conditions.Length; i++)
			{
				conditions[i].Clear();
			}
			Array.Clear(this.Conditions, 0, this.Conditions.Length);
		}

		// Token: 0x0603EABD RID: 256701 RVA: 0x01242C88 File Offset: 0x01240E88
		public override void HandleServerDebugInfo(RepeatedField<bool> conditions)
		{
			this.ResultServer = conditions[this.Index.Value];
			int num = this.Conditions.Length;
			for (int i = 0; i < num; i++)
			{
				this.Conditions[i].HandleServerDebugInfo(conditions);
			}
		}

		// Token: 0x0603EABE RID: 256702 RVA: 0x01242CD0 File Offset: 0x01240ED0
		public override void OnSignaled()
		{
			this.ResultSelf = false;
			foreach (AiStateMachineCondition aiStateMachineCondition in this.Conditions)
			{
				this.ResultSelf = (this.ResultSelf || aiStateMachineCondition.Result);
			}
			base.Signaled();
		}

		// Token: 0x0603EABF RID: 256703 RVA: 0x01242D1C File Offset: 0x01240F1C
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("或\n");
			int num = this.Conditions.Length;
			for (int i = 0; i < num; i++)
			{
				this.Conditions[i].ToString(outBuilder, depth + 1);
			}
		}

		// Token: 0x04021759 RID: 137049
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public AiStateMachineCondition[] Conditions;
	}
}
