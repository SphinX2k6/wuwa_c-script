using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064B7 RID: 25783
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionAnd : AiStateMachineCondition
	{
		// Token: 0x0603EA4E RID: 256590 RVA: 0x01240AFF File Offset: 0x0123ECFF
		public AiStateMachineConditionAnd(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA4F RID: 256591 RVA: 0x01240B0C File Offset: 0x0123ED0C
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

		// Token: 0x0603EA50 RID: 256592 RVA: 0x01240BA8 File Offset: 0x0123EDA8
		protected override void OnEnter()
		{
			this.HasSignaled = false;
			AiStateMachineCondition[] conditions = this.Conditions;
			for (int i = 0; i < conditions.Length; i++)
			{
				conditions[i].Enter();
			}
		}

		// Token: 0x0603EA51 RID: 256593 RVA: 0x01240BDC File Offset: 0x0123EDDC
		protected override void OnExit()
		{
			this.HasSignaled = false;
			AiStateMachineCondition[] conditions = this.Conditions;
			for (int i = 0; i < conditions.Length; i++)
			{
				conditions[i].Exit();
			}
		}

		// Token: 0x0603EA52 RID: 256594 RVA: 0x01240C10 File Offset: 0x0123EE10
		protected override void OnTick()
		{
			this.ResultSelf = true;
			foreach (AiStateMachineCondition aiStateMachineCondition in this.Conditions)
			{
				aiStateMachineCondition.Tick();
				this.ResultSelf &= aiStateMachineCondition.Result;
			}
		}

		// Token: 0x0603EA53 RID: 256595 RVA: 0x01240C58 File Offset: 0x0123EE58
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

		// Token: 0x0603EA54 RID: 256596 RVA: 0x01240C90 File Offset: 0x0123EE90
		public override void HandleServerDebugInfo(RepeatedField<bool> conditions)
		{
			this.ResultServer = conditions[this.Index.Value];
			AiStateMachineCondition[] conditions2 = this.Conditions;
			for (int i = 0; i < conditions2.Length; i++)
			{
				conditions2[i].HandleServerDebugInfo(conditions);
			}
		}

		// Token: 0x0603EA55 RID: 256597 RVA: 0x01240CD4 File Offset: 0x0123EED4
		public override void OnSignaled()
		{
			this.ResultSelf = true;
			foreach (AiStateMachineCondition aiStateMachineCondition in this.Conditions)
			{
				this.ResultSelf &= aiStateMachineCondition.Result;
			}
			base.Signaled();
		}

		// Token: 0x0603EA56 RID: 256598 RVA: 0x01240D1C File Offset: 0x0123EF1C
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

		// Token: 0x0402173B RID: 137019
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public AiStateMachineCondition[] Conditions;
	}
}
