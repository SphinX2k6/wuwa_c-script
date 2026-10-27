using System;
using System.Runtime.CompilerServices;

// Token: 0x02001994 RID: 6548
public class SmallItemGridStarReceivableComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600BF4E RID: 48974 RVA: 0x002B3B77 File Offset: 0x002B1D77
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBReceivableA";
	}

	// Token: 0x0600BF4F RID: 48975 RVA: 0x002B3B7E File Offset: 0x002B1D7E
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
