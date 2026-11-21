using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E0B RID: 3595
public class CommonIntensifyPropExpData
{
	// Token: 0x04005608 RID: 22024
	public int CurrentLevel;

	// Token: 0x04005609 RID: 22025
	public int CurrentMaxLevel;

	// Token: 0x0400560A RID: 22026
	public int CurrentExp;

	// Token: 0x0400560B RID: 22027
	[Nullable(2)]
	public Func<int, int> MaxExpFunction;

	// Token: 0x0400560C RID: 22028
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<ISelectedData, int> GetItemExpFunction;
}
