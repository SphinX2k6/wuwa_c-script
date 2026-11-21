using System;

// Token: 0x02000400 RID: 1024
public class DrinksUtils
{
	// Token: 0x0600379B RID: 14235 RVA: 0x0014420C File Offset: 0x0014240C
	public static EDrinksRequireType GetStepType(int step)
	{
		if (step < 2)
		{
			return EDrinksRequireType.DrinksBase;
		}
		if (step < 4)
		{
			return EDrinksRequireType.Batching;
		}
		return EDrinksRequireType.Ornament;
	}
}
