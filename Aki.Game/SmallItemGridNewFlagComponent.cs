using System;
using System.Runtime.CompilerServices;

// Token: 0x02001986 RID: 6534
public class SmallItemGridNewFlagComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600BF0A RID: 48906 RVA: 0x002B3315 File Offset: 0x002B1515
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBTagNew";
	}

	// Token: 0x0600BF0B RID: 48907 RVA: 0x002B331C File Offset: 0x002B151C
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Top;
	}
}
