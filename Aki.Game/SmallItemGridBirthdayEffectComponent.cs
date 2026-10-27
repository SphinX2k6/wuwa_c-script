using System;
using System.Runtime.CompilerServices;

// Token: 0x02001969 RID: 6505
public class SmallItemGridBirthdayEffectComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600BEA5 RID: 48805 RVA: 0x002B263C File Offset: 0x002B083C
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBShinning";
	}

	// Token: 0x0600BEA6 RID: 48806 RVA: 0x002B2643 File Offset: 0x002B0843
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Top;
	}
}
