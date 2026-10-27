using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007344 RID: 29508
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionOr : AiStateMachineCondition
	{
		// Token: 0x0604866A RID: 296554 RVA: 0x012A005D File Offset: 0x0129E25D
		public AiStateMachineConditionOr(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0604866B RID: 296555 RVA: 0x012A0068 File Offset: 0x0129E268
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

		// Token: 0x0604866C RID: 296556 RVA: 0x012A0104 File Offset: 0x0129E304
		protected override void OnEnter()
		{
			this.HasSignaled = false;
			AiStateMachineCondition[] conditions = this.Conditions;
			for (int i = 0; i < conditions.Length; i++)
			{
				conditions[i].Enter();
			}
		}

		// Token: 0x0604866D RID: 296557 RVA: 0x012A0138 File Offset: 0x0129E338
		protected override void OnExit()
		{
			this.HasSignaled = false;
			AiStateMachineCondition[] conditions = this.Conditions;
			for (int i = 0; i < conditions.Length; i++)
			{
				conditions[i].Exit();
			}
		}

		// Token: 0x0604866E RID: 296558 RVA: 0x012A016C File Offset: 0x0129E36C
		protected override void OnTick()
		{
			this.ResultSelf = false;
			foreach (AiStateMachineCondition aiStateMachineCondition in this.Conditions)
			{
				aiStateMachineCondition.Tick();
				this.ResultSelf = (this.ResultSelf || aiStateMachineCondition.Result);
			}
		}

		// Token: 0x0604866F RID: 296559 RVA: 0x012A01B8 File Offset: 0x0129E3B8
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

		// Token: 0x06048670 RID: 296560 RVA: 0x012A0200 File Offset: 0x0129E400
		public override void HandleServerDebugInfo(RepeatedField<bool> conditions)
		{
			this.ResultServer = conditions[this.Index.Value];
			int num = this.Conditions.Length;
			for (int i = 0; i < num; i++)
			{
				this.Conditions[i].HandleServerDebugInfo(conditions);
			}
		}

		// Token: 0x06048671 RID: 296561 RVA: 0x012A0248 File Offset: 0x0129E448
		public override void OnSignaled()
		{
			this.ResultSelf = false;
			foreach (AiStateMachineCondition aiStateMachineCondition in this.Conditions)
			{
				this.ResultSelf = (this.ResultSelf || aiStateMachineCondition.Result);
			}
			base.Signaled();
		}

		// Token: 0x06048672 RID: 296562 RVA: 0x012A0294 File Offset: 0x0129E494
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

		// Token: 0x0402646C RID: 156780
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public AiStateMachineCondition[] Conditions;
	}
}
