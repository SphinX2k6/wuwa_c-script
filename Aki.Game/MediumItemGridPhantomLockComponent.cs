using System;
using System.Runtime.CompilerServices;

// Token: 0x02001924 RID: 6436
public class MediumItemGridPhantomLockComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600BC7A RID: 48250 RVA: 0x002AAABE File Offset: 0x002A8CBE
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemVisionLock";
	}
}
