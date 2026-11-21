using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DB9 RID: 3513
public class MediumItemGridBranchUpgradeComponent : MediumItemGridVisibleComponent
{
	// Token: 0x06008F9C RID: 36764 RVA: 0x002B3771 File Offset: 0x002B1971
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_UpgradeTriangle";
	}

	// Token: 0x06008F9D RID: 36765 RVA: 0x002B3778 File Offset: 0x002B1978
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
