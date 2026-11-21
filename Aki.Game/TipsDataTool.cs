using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BA8 RID: 2984
public class TipsDataTool
{
	// Token: 0x06007C3C RID: 31804 RVA: 0x00267C70 File Offset: 0x00265E70
	[NullableContext(1)]
	public static CommonComponentDefine.TipsAttributeData GetCommonTipsAttributeData(double propValue, double ratio, bool isRatio, int propId)
	{
		double attributeValue = TipsDataTool.GetAttributeValue(propValue, ratio, isRatio);
		return new CommonComponentDefine.TipsAttributeData(propId, attributeValue, isRatio);
	}

	// Token: 0x06007C3D RID: 31805 RVA: 0x00267C90 File Offset: 0x00265E90
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

	// Token: 0x06007C3E RID: 31806 RVA: 0x00267CD4 File Offset: 0x00265ED4
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
