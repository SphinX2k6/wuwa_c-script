using System;
using System.Runtime.CompilerServices;

// Token: 0x02001988 RID: 6536
public class SmallItemGridOrnamentConflictComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600BF11 RID: 48913 RVA: 0x002B3368 File Offset: 0x002B1568
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemAccessoriesTag";
	}

	// Token: 0x0600BF12 RID: 48914 RVA: 0x002B336F File Offset: 0x002B156F
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
