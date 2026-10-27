using System;

// Token: 0x02000F4B RID: 3915
public class DrinksUtils
{
	// Token: 0x06006403 RID: 25603 RVA: 0x0013B940 File Offset: 0x00139B40
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
