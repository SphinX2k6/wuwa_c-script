using System;
using System.Runtime.CompilerServices;

// Token: 0x0200198B RID: 6539
public class SmallItemGridRedDotComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600BF1C RID: 48924 RVA: 0x002B3420 File Offset: 0x002B1620
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRedDot";
	}

	// Token: 0x0600BF1D RID: 48925 RVA: 0x002B3427 File Offset: 0x002B1627
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Top;
	}
}
