using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DDD RID: 3549
public class MediumItemGridPhantomLockComponent : MediumItemGridVisibleComponent
{
	// Token: 0x06009064 RID: 36964 RVA: 0x002B521A File Offset: 0x002B341A
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemVisionLock";
	}
}
