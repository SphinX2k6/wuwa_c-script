using System;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007336 RID: 29494
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionAttributeRate : AiStateMachineCondition
	{
		// Token: 0x0604860F RID: 296463 RVA: 0x0129E496 File Offset: 0x0129C696
		public AiStateMachineConditionAttributeRate(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048610 RID: 296464 RVA: 0x0129E4A4 File Offset: 0x0129C6A4
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

		// Token: 0x06048611 RID: 296465 RVA: 0x0129E5A4 File Offset: 0x0129C7A4
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

		// Token: 0x06048612 RID: 296466 RVA: 0x0129E639 File Offset: 0x0129C839
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

		// Token: 0x06048613 RID: 296467 RVA: 0x0129E674 File Offset: 0x0129C874
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

		// Token: 0x04026452 RID: 156754
		private const float ATTRIBUTE_RATE_COE = 0.0001f;

		// Token: 0x04026453 RID: 156755
		private EAttributeType Numerator;

		// Token: 0x04026454 RID: 156756
		private EAttributeType Denominator;

		// Token: 0x04026455 RID: 156757
		private float Min;

		// Token: 0x04026456 RID: 156758
		private float Max;

		// Token: 0x04026457 RID: 156759
		private float NumeratorValue;

		// Token: 0x04026458 RID: 156760
		private float DenominatorValue;
	}
}
