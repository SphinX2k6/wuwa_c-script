using System;
using System.Runtime.CompilerServices;

// Token: 0x0200203B RID: 8251
public class SurvivorRewardTaskTabData
{
	// Token: 0x0400AD41 RID: 44353
	[Nullable(2)]
	public string NameTextId;

	// Token: 0x0400AD42 RID: 44354
	public int Index = -1;

	// Token: 0x0400AD43 RID: 44355
	public int Type;

	// Token: 0x0400AD44 RID: 44356
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<SurvivorRewardTaskTabData> ClickedCallback;

	// Token: 0x0400AD45 RID: 44357
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<SurvivorRewardTaskTabData, bool> RefreshRedDot;
}
