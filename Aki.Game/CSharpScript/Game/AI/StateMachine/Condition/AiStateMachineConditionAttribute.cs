using System;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064B8 RID: 25784
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionAttribute : AiStateMachineCondition
	{
		// Token: 0x0603EA57 RID: 256599 RVA: 0x01240D5E File Offset: 0x0123EF5E
		public AiStateMachineConditionAttribute(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA58 RID: 256600 RVA: 0x01240D6C File Offset: 0x0123EF6C
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

		// Token: 0x0603EA59 RID: 256601 RVA: 0x01240E0C File Offset: 0x0123F00C
		private void OnAttrChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.ResultSelf = (newValue >= this.Min && newValue <= this.Max);
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionAttribute", this.Node.Name);
			}
		}

		// Token: 0x0603EA5A RID: 256602 RVA: 0x01240E71 File Offset: 0x0123F071
		protected override void OnClear()
		{
			BaseAttributeComponent attributeComponent = this.Node.AttributeComponent;
			if (attributeComponent == null)
			{
				return;
			}
			attributeComponent.RemoveListener(this.AttributeId, new Action<EAttributeType, float, float>(this.OnAttrChanged));
		}

		// Token: 0x0603EA5B RID: 256603 RVA: 0x01240E9C File Offset: 0x0123F09C
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

		// Token: 0x0402173C RID: 137020
		private EAttributeType AttributeId;

		// Token: 0x0402173D RID: 137021
		private float Min;

		// Token: 0x0402173E RID: 137022
		private float Max;
	}
}
