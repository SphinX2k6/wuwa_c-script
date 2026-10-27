using System;
using System.Runtime.CompilerServices;

// Token: 0x02001967 RID: 6503
public class SmallItemGridReceivableComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600BEA0 RID: 48800 RVA: 0x002B261B File Offset: 0x002B081B
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBReceivable";
	}

	// Token: 0x0600BEA1 RID: 48801 RVA: 0x002B2622 File Offset: 0x002B0822
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
