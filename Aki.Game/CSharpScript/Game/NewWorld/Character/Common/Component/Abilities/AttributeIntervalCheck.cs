using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities
{
	// Token: 0x02007127 RID: 28967
	[NullableContext(1)]
	[Nullable(0)]
	public class AttributeIntervalCheck
	{
		// Token: 0x17009D31 RID: 40241
		// (get) Token: 0x06046BC0 RID: 289728 RVA: 0x011D2180 File Offset: 0x011D0380
		public EAttributeType ListenAttributeId { get; }

		// Token: 0x17009D32 RID: 40242
		// (get) Token: 0x06046BC1 RID: 289729 RVA: 0x011D2188 File Offset: 0x011D0388
		// (set) Token: 0x06046BC2 RID: 289730 RVA: 0x011D2190 File Offset: 0x011D0390
		public EAttributeType? MaxAttributeId { get; private set; }

		// Token: 0x17009D33 RID: 40243
		// (get) Token: 0x06046BC3 RID: 289731 RVA: 0x011D2199 File Offset: 0x011D0399
		// (set) Token: 0x06046BC4 RID: 289732 RVA: 0x011D21A1 File Offset: 0x011D03A1
		public float LowerBound { get; set; }

		// Token: 0x17009D34 RID: 40244
		// (get) Token: 0x06046BC5 RID: 289733 RVA: 0x011D21AA File Offset: 0x011D03AA
		// (set) Token: 0x06046BC6 RID: 289734 RVA: 0x011D21B2 File Offset: 0x011D03B2
		public float UpperBound { get; set; }

		// Token: 0x17009D35 RID: 40245
		// (get) Token: 0x06046BC7 RID: 289735 RVA: 0x011D21BB File Offset: 0x011D03BB
		public bool IsPerTenThousand { get; }

		// Token: 0x06046BC8 RID: 289736 RVA: 0x011D21C4 File Offset: 0x011D03C4
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

		// Token: 0x06046BC9 RID: 289737 RVA: 0x011D221C File Offset: 0x011D041C
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

		// Token: 0x06046BCA RID: 289738 RVA: 0x011D227C File Offset: 0x011D047C
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

		// Token: 0x06046BCB RID: 289739 RVA: 0x011D22EC File Offset: 0x011D04EC
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
