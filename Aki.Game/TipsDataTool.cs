using System;
using System.Runtime.CompilerServices;

// Token: 0x020016F0 RID: 5872
public class TipsDataTool
{
	// Token: 0x0600A85C RID: 43100 RVA: 0x0025D850 File Offset: 0x0025BA50
	[NullableContext(1)]
	public static CommonComponentDefine.TipsAttributeData GetCommonTipsAttributeData(double propValue, double ratio, bool isRatio, int propId)
	{
		double attributeValue = TipsDataTool.GetAttributeValue(propValue, ratio, isRatio);
		return new CommonComponentDefine.TipsAttributeData(propId, attributeValue, isRatio);
	}

	// Token: 0x0600A85D RID: 43101 RVA: 0x0025D870 File Offset: 0x0025BA70
	public static double GetAttributeValue(double propValue, double ratio, bool isRatio)
	{
		double result;
		if (isRatio)
		{
			result = propValue / 10000.0 * (ratio / 10000.0);
		}
		else
		{
			result = propValue * (ratio / 10000.0);
		}
		return result;
	}

	// Token: 0x0600A85E RID: 43102 RVA: 0x0025D8B4 File Offset: 0x0025BAB4
	public static double GetPropRatioValue(double propValue, bool isRatio)
	{
		double result;
		if (isRatio)
		{
			result = propValue / 10000.0;
		}
		else
		{
			result = propValue;
		}
		return result;
	}
}
