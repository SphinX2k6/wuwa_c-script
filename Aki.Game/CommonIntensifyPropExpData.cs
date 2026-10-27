using System;
using System.Runtime.CompilerServices;

// Token: 0x0200194E RID: 6478
public class CommonIntensifyPropExpData
{
	// Token: 0x0400555B RID: 21851
	public int CurrentLevel;

	// Token: 0x0400555C RID: 21852
	public int CurrentMaxLevel;

	// Token: 0x0400555D RID: 21853
	public int CurrentExp;

	// Token: 0x0400555E RID: 21854
	[Nullable(2)]
	public Func<int, int> MaxExpFunction;

	// Token: 0x0400555F RID: 21855
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<ISelectedData, int> GetItemExpFunction;
}
