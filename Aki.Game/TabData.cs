using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EF0 RID: 3824
[NullableContext(2)]
[Nullable(0)]
internal class TabData
{
	// Token: 0x04005BB6 RID: 23478
	public DangoAbyssActivityData ActivityData;

	// Token: 0x04005BB7 RID: 23479
	public int CurrentSelectTabId;

	// Token: 0x04005BB8 RID: 23480
	public int TabId;

	// Token: 0x04005BB9 RID: 23481
	public Action<int> ClickCallBack;
}
