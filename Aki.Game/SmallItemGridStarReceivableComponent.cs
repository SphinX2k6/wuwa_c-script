using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E51 RID: 3665
public class SmallItemGridStarReceivableComponent : SmallItemGridVisibleComponent
{
	// Token: 0x06009356 RID: 37718 RVA: 0x002BEAFB File Offset: 0x002BCCFB
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBReceivableA";
	}

	// Token: 0x06009357 RID: 37719 RVA: 0x002BEB02 File Offset: 0x002BCD02
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
