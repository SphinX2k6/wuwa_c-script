using System;
using System.Runtime.CompilerServices;

// Token: 0x0200192E RID: 6446
public class MediumItemGridRoleDevelopTagMarkComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600BCA3 RID: 48291 RVA: 0x002AAF81 File Offset: 0x002A9181
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_RoleDevelopTagMark";
	}

	// Token: 0x0600BCA4 RID: 48292 RVA: 0x002AAF88 File Offset: 0x002A9188
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
