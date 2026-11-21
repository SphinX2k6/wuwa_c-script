using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E26 RID: 3622
public class SmallItemGridBirthdayEffectComponent : SmallItemGridVisibleComponent
{
	// Token: 0x060092AD RID: 37549 RVA: 0x002BD5C0 File Offset: 0x002BB7C0
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBShinning";
	}

	// Token: 0x060092AE RID: 37550 RVA: 0x002BD5C7 File Offset: 0x002BB7C7
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Top;
	}
}
