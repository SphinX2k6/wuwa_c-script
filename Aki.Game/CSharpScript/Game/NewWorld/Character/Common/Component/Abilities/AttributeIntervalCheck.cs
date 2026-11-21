using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities
{
	// Token: 0x02006355 RID: 25429
	[NullableContext(1)]
	[Nullable(0)]
	public class AttributeIntervalCheck
	{
		// Token: 0x17007500 RID: 29952
		// (get) Token: 0x0603DA0E RID: 252430 RVA: 0x011DACE0 File Offset: 0x011D8EE0
		public EAttributeType ListenAttributeId { get; }

		// Token: 0x17007501 RID: 29953
		// (get) Token: 0x0603DA0F RID: 252431 RVA: 0x011DACE8 File Offset: 0x011D8EE8
		// (set) Token: 0x0603DA10 RID: 252432 RVA: 0x011DACF0 File Offset: 0x011D8EF0
		public EAttributeType? MaxAttributeId { get; private set; }

		// Token: 0x17007502 RID: 29954
		// (get) Token: 0x0603DA11 RID: 252433 RVA: 0x011DACF9 File Offset: 0x011D8EF9
		// (set) Token: 0x0603DA12 RID: 252434 RVA: 0x011DAD01 File Offset: 0x011D8F01
		public float LowerBound { get; set; }

		// Token: 0x17007503 RID: 29955
		// (get) Token: 0x0603DA13 RID: 252435 RVA: 0x011DAD0A File Offset: 0x011D8F0A
		// (set) Token: 0x0603DA14 RID: 252436 RVA: 0x011DAD12 File Offset: 0x011D8F12
		public float UpperBound { get; set; }

		// Token: 0x17007504 RID: 29956
		// (get) Token: 0x0603DA15 RID: 252437 RVA: 0x011DAD1B File Offset: 0x011D8F1B
		public bool IsPerTenThousand { get; }

		// Token: 0x0603DA16 RID: 252438 RVA: 0x011DAD24 File Offset: 0x011D8F24
		public AttributeIntervalCheck(EAttributeType listenId, float lowerBound, float upperBound, bool isPerTenThousandth)
		{
			this.ListenAttributeId = listenId;
			this.LowerBound = lowerBound;
			this.UpperBound = upperBound;
			this.IsPerTenThousand = isPerTenThousandth;
			if (this.IsPerTenThousand)
			{
				EAttributeType value;
				CharacterAttributeTypes.attributeIdsWithMax.TryGetValue(this.ListenAttributeId, out value);
				this.MaxAttributeId = new EAttributeType?(value);
			}
		}

		// Token: 0x0603DA17 RID: 252439 RVA: 0x011DAD7C File Offset: 0x011D8F7C
		public bool CheckListenActiveness(float newValue, BaseAttributeComponent listenAttributeComponent)
		{
			if (!this.IsPerTenThousand)
			{
				return newValue <= this.UpperBound && newValue > this.LowerBound;
			}
			float currentValue = listenAttributeComponent.GetCurrentValue(this.MaxAttributeId.Value);
			float num = newValue / currentValue * 10000f;
			return num <= this.UpperBound && num > this.LowerBound;
		}

		// Token: 0x0603DA18 RID: 252440 RVA: 0x011DADDC File Offset: 0x011D8FDC
		[NullableContext(2)]
		public bool CheckActiveness(BaseAttributeComponent targetAttributeComponent)
		{
			if (targetAttributeComponent == null)
			{
				return false;
			}
			float currentValue = targetAttributeComponent.GetCurrentValue(this.ListenAttributeId);
			if (!this.IsPerTenThousand)
			{
				return currentValue <= this.UpperBound && currentValue > this.LowerBound;
			}
			float currentValue2 = targetAttributeComponent.GetCurrentValue(this.MaxAttributeId.Value);
			float num = currentValue / currentValue2 * 10000f;
			return num <= this.UpperBound && num > this.LowerBound;
		}

		// Token: 0x0603DA19 RID: 252441 RVA: 0x011DAE4C File Offset: 0x011D904C
		public string GetDebugString()
		{
			string value = this.ListenAttributeId.ToString();
			EAttributeType? eattributeType;
			string text = (this.MaxAttributeId != null) ? eattributeType.GetValueOrDefault().ToString() : null;
			string value2 = this.IsPerTenThousand ? ((this.UpperBound * 0.0001f * 100f).ToString() + "%") : this.UpperBound.ToString(CultureInfo.InvariantCulture);
			string value3 = this.IsPerTenThousand ? ((this.LowerBound * 0.0001f * 100f).ToString() + "%") : this.LowerBound.ToString(CultureInfo.InvariantCulture);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 4);
			defaultInterpolatedStringHandler.AppendLiteral("属性");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("位于");
			defaultInterpolatedStringHandler.AppendFormatted((!string.IsNullOrEmpty(text)) ? (text + "的") : "");
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			defaultInterpolatedStringHandler.AppendLiteral("~");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral("之间");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}
}
