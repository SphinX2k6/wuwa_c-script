using System;
using System.Runtime.CompilerServices;

// Token: 0x02002ABF RID: 10943
public class SurvivorRewardTaskTabData
{
	// Token: 0x0400A93B RID: 43323
	[Nullable(2)]
	public string NameTextId;

	// Token: 0x0400A93C RID: 43324
	public int Index = -1;

	// Token: 0x0400A93D RID: 43325
	public int Type;

	// Token: 0x0400A93E RID: 43326
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<SurvivorRewardTaskTabData> ClickedCallback;

	// Token: 0x0400A93F RID: 43327
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<SurvivorRewardTaskTabData, bool> RefreshRedDot;
}
