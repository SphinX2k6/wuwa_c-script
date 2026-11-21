using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043E8 RID: 17384
	[NullableContext(1)]
	[Nullable(0)]
	public class FunctionItemViewTool
	{
		// Token: 0x0602BEA6 RID: 179878 RVA: 0x00C54470 File Offset: 0x00C52670
		public static float GetSliderPosition(float[] rangeList, float value, int digit = 0)
		{
			float min = rangeList[0];
			float num = rangeList[1];
			float rangePct = MathUtils.Instance.GetRangePct(min, num, value);
			return MathUtils.Instance.GetFloatPointFloor(rangePct * num, digit);
		}

		// Token: 0x0602BEA7 RID: 179879 RVA: 0x00C544A4 File Offset: 0x00C526A4
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

		// Token: 0x0602BEA8 RID: 179880 RVA: 0x00C544F0 File Offset: 0x00C526F0
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
