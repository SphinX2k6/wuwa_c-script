using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C23 RID: 7203
[NullableContext(1)]
[Nullable(0)]
internal class TabItemData
{
	// Token: 0x040062AC RID: 25260
	[Nullable(2)]
	public FragmentMemoryCollectData FragmentCollectData;

	// Token: 0x040062AD RID: 25261
	public Action<int> TabCallBack = delegate(int value)
	{
	};

	// Token: 0x040062AE RID: 25262
	public Func<int> GetCurrentSelectTabIndex = () => 0;

	// Token: 0x040062AF RID: 25263
	public bool NeedSwitchAnimation;
}
