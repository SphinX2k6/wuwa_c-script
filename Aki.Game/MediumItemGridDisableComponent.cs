using System;
using System.Runtime.CompilerServices;

// Token: 0x02001911 RID: 6417
public class MediumItemGridDisableComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600BC04 RID: 48132 RVA: 0x002A9E4F File Offset: 0x002A804F
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemDark";
	}

	// Token: 0x0600BC05 RID: 48133 RVA: 0x002A9E56 File Offset: 0x002A8056
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
