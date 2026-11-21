using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E43 RID: 3651
public class SmallItemGridNewFlagComponent : SmallItemGridVisibleComponent
{
	// Token: 0x06009312 RID: 37650 RVA: 0x002BE299 File Offset: 0x002BC499
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBTagNew";
	}

	// Token: 0x06009313 RID: 37651 RVA: 0x002BE2A0 File Offset: 0x002BC4A0
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Top;
	}
}
