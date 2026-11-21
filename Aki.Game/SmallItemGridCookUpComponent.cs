using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E29 RID: 3625
public class SmallItemGridCookUpComponent : SmallItemGridVisibleComponent
{
	// Token: 0x060092B4 RID: 37556 RVA: 0x002BD612 File Offset: 0x002BB812
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBCooking";
	}

	// Token: 0x060092B5 RID: 37557 RVA: 0x002BD619 File Offset: 0x002BB819
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
