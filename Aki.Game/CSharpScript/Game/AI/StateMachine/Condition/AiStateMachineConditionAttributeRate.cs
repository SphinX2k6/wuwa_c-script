using System;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064B9 RID: 25785
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionAttributeRate : AiStateMachineCondition
	{
		// Token: 0x0603EA5C RID: 256604 RVA: 0x01240F1E File Offset: 0x0123F11E
		public AiStateMachineConditionAttributeRate(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA5D RID: 256605 RVA: 0x01240F2C File Offset: 0x0123F12C
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.Numerator = (EAttributeType)condition.CondAttributeRate.AttributeId;
			this.Denominator = (EAttributeType)condition.CondAttributeRate.Denominator;
			this.Min = condition.CondAttributeRate.Min * 0.0001f;
			this.Max = condition.CondAttributeRate.Max * 0.0001f;
			this.Node.AttributeComponent.AddListeners(new EAttributeType[]
			{
				this.Numerator,
				this.Denominator
			}, new Action<EAttributeType, float, float>(this.OnAttrRateChanged), "AiConditionEvent");
			this.NumeratorValue = this.Node.AttributeComponent.GetCurrentValue(this.Numerator);
			this.DenominatorValue = this.Node.AttributeComponent.GetCurrentValue(this.Denominator);
			float num = this.NumeratorValue / this.DenominatorValue;
			this.ResultSelf = (num >= this.Min && num <= this.Max);
			return true;
		}

		// Token: 0x0603EA5E RID: 256606 RVA: 0x0124102C File Offset: 0x0123F22C
		private void OnAttrRateChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			if (attributeId == this.Numerator)
			{
				this.NumeratorValue = newValue;
			}
			else if (attributeId == this.Denominator)
			{
				this.DenominatorValue = newValue;
			}
			float num = this.NumeratorValue / this.DenominatorValue;
			this.ResultSelf = (num >= this.Min && num <= this.Max);
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionAttributeRate", this.Node.Name);
			}
		}

		// Token: 0x0603EA5F RID: 256607 RVA: 0x012410C1 File Offset: 0x0123F2C1
		protected override void OnClear()
		{
			BaseAttributeComponent attributeComponent = this.Node.AttributeComponent;
			if (attributeComponent == null)
			{
				return;
			}
			attributeComponent.RemoveListeners(new EAttributeType[]
			{
				this.Numerator,
				this.Denominator
			}, new Action<EAttributeType, float, float>(this.OnAttrRateChanged));
		}

		// Token: 0x0603EA60 RID: 256608 RVA: 0x012410FC File Offset: 0x0123F2FC
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(13, 4, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("属性比例 [");
			appendInterpolatedStringHandler.AppendFormatted<EAttributeType>(this.Numerator);
			appendInterpolatedStringHandler.AppendLiteral("/");
			appendInterpolatedStringHandler.AppendFormatted<EAttributeType>(this.Denominator);
			appendInterpolatedStringHandler.AppendLiteral(", ");
			appendInterpolatedStringHandler.AppendFormatted<float>(this.Min);
			appendInterpolatedStringHandler.AppendLiteral(", ");
			appendInterpolatedStringHandler.AppendFormatted<float>(this.Max);
			appendInterpolatedStringHandler.AppendLiteral("]\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x0402173F RID: 137023
		private const float ATTRIBUTE_RATE_COE = 0.0001f;

		// Token: 0x04021740 RID: 137024
		private EAttributeType Numerator;

		// Token: 0x04021741 RID: 137025
		private EAttributeType Denominator;

		// Token: 0x04021742 RID: 137026
		private float Min;

		// Token: 0x04021743 RID: 137027
		private float Max;

		// Token: 0x04021744 RID: 137028
		private float NumeratorValue;

		// Token: 0x04021745 RID: 137029
		private float DenominatorValue;
	}
}
