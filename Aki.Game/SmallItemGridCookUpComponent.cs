using System;
using System.Runtime.CompilerServices;

// Token: 0x0200196C RID: 6508
public class SmallItemGridCookUpComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600BEAC RID: 48812 RVA: 0x002B268E File Offset: 0x002B088E
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBCooking";
	}

	// Token: 0x0600BEAD RID: 48813 RVA: 0x002B2695 File Offset: 0x002B0895
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
