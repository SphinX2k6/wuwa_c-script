using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E45 RID: 3653
public class SmallItemGridOrnamentConflictComponent : SmallItemGridVisibleComponent
{
	// Token: 0x06009319 RID: 37657 RVA: 0x002BE2EC File Offset: 0x002BC4EC
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemAccessoriesTag";
	}

	// Token: 0x0600931A RID: 37658 RVA: 0x002BE2F3 File Offset: 0x002BC4F3
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
