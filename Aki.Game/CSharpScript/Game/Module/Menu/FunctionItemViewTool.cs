using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x02005405 RID: 21509
	[NullableContext(1)]
	[Nullable(0)]
	public class FunctionItemViewTool
	{
		// Token: 0x06036F5E RID: 225118 RVA: 0x00D0502C File Offset: 0x00D0322C
		public static float GetSliderPosition(float[] rangeList, float value, int digit = 0)
		{
			float min = rangeList[0];
			float num = rangeList[1];
			float rangePct = MathUtils.Instance.GetRangePct(min, num, value);
			return MathUtils.Instance.GetFloatPointFloor(rangePct * num, digit);
		}

		// Token: 0x06036F5F RID: 225119 RVA: 0x00D05060 File Offset: 0x00D03260
		public static float GetSliderDisplayValue(MenuData data, float actualValue)
		{
			float[] sliderRange = data.SliderRange;
			float inRangeA = sliderRange[0];
			float inRangeB = sliderRange[1];
			float[] sliderRangeDisplay = data.SliderRangeDisplay;
			float outRangeA = sliderRangeDisplay[0];
			float outRangeB = sliderRangeDisplay[1];
			float num = MathUtils.Instance.RangeClamp(actualValue, inRangeA, inRangeB, outRangeA, outRangeB);
			return (float)MathUtils.Instance.GetRoundToNDecimalPlaces((double)num, data.SliderDigits);
		}

		// Token: 0x06036F60 RID: 225120 RVA: 0x00D050AC File Offset: 0x00D032AC
		public static float GetActualSliderStep(MenuData data, float displayStep)
		{
			float[] sliderRange = data.SliderRange;
			float num = sliderRange[0];
			float num2 = sliderRange[1];
			float[] sliderRangeDisplay = data.SliderRangeDisplay;
			float num3 = sliderRangeDisplay[0];
			float num4 = sliderRangeDisplay[1];
			return displayStep / (num4 - num3) * (num2 - num);
		}
	}
}
