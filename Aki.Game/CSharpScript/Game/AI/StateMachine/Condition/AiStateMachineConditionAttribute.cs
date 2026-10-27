using System;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007335 RID: 29493
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionAttribute : AiStateMachineCondition
	{
		// Token: 0x0604860A RID: 296458 RVA: 0x0129E2D6 File Offset: 0x0129C4D6
		public AiStateMachineConditionAttribute(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0604860B RID: 296459 RVA: 0x0129E2E4 File Offset: 0x0129C4E4
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.AttributeId = (EAttributeType)condition.CondAttribute.AttributeId;
			this.Min = condition.CondAttribute.Min;
			this.Max = condition.CondAttribute.Max;
			this.Node.AttributeComponent.AddListener(this.AttributeId, new Action<EAttributeType, float, float>(this.OnAttrChanged), "AiConditionEvent");
			float currentValue = this.Node.AttributeComponent.GetCurrentValue(this.AttributeId);
			this.ResultSelf = (currentValue >= this.Min && currentValue <= this.Max);
			return true;
		}

		// Token: 0x0604860C RID: 296460 RVA: 0x0129E384 File Offset: 0x0129C584
		private void OnAttrChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.ResultSelf = (newValue >= this.Min && newValue <= this.Max);
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionAttribute", this.Node.Name);
			}
		}

		// Token: 0x0604860D RID: 296461 RVA: 0x0129E3E9 File Offset: 0x0129C5E9
		protected override void OnClear()
		{
			BaseAttributeComponent attributeComponent = this.Node.AttributeComponent;
			if (attributeComponent == null)
			{
				return;
			}
			attributeComponent.RemoveListener(this.AttributeId, new Action<EAttributeType, float, float>(this.OnAttrChanged));
		}

		// Token: 0x0604860E RID: 296462 RVA: 0x0129E414 File Offset: 0x0129C614
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(10, 3, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("属性 [");
			appendInterpolatedStringHandler.AppendFormatted<EAttributeType>(this.AttributeId);
			appendInterpolatedStringHandler.AppendLiteral(", ");
			appendInterpolatedStringHandler.AppendFormatted<float>(this.Min);
			appendInterpolatedStringHandler.AppendLiteral(", ");
			appendInterpolatedStringHandler.AppendFormatted<float>(this.Max);
			appendInterpolatedStringHandler.AppendLiteral("]\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x0402644F RID: 156751
		private EAttributeType AttributeId;

		// Token: 0x04026450 RID: 156752
		private float Min;

		// Token: 0x04026451 RID: 156753
		private float Max;
	}
}
