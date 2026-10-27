using System;
using System.Runtime.CompilerServices;

// Token: 0x02001900 RID: 6400
public class MediumItemGridBranchUpgradeComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600BBB2 RID: 48050 RVA: 0x002A9015 File Offset: 0x002A7215
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_UpgradeTriangle";
	}

	// Token: 0x0600BBB3 RID: 48051 RVA: 0x002A901C File Offset: 0x002A721C
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
