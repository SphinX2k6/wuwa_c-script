using System;
using System.Runtime.CompilerServices;

// Token: 0x020010E2 RID: 4322
[NullableContext(1)]
[Nullable(0)]
internal class TabItemData
{
	// Token: 0x0400637E RID: 25470
	[Nullable(2)]
	public FragmentMemoryCollectData FragmentCollectData;

	// Token: 0x0400637F RID: 25471
	public Action<int> TabCallBack = delegate(int value)
	{
	};

	// Token: 0x04006380 RID: 25472
	public Func<int> GetCurrentSelectTabIndex = () => 0;

	// Token: 0x04006381 RID: 25473
	public bool NeedSwitchAnimation;
}
