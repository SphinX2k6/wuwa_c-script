using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DCA RID: 3530
public class MediumItemGridDisableComponent : MediumItemGridVisibleComponent
{
	// Token: 0x06008FEE RID: 36846 RVA: 0x002B45AB File Offset: 0x002B27AB
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemDark";
	}

	// Token: 0x06008FEF RID: 36847 RVA: 0x002B45B2 File Offset: 0x002B27B2
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
