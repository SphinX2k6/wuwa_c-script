using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E06 RID: 3590
public class MediumItemGridWeeklyRogueTagComponent : MediumItemGridVisibleComponent
{
	// Token: 0x06009114 RID: 37140 RVA: 0x002B759F File Offset: 0x002B579F
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTagDescript";
	}

	// Token: 0x06009115 RID: 37141 RVA: 0x002B75A6 File Offset: 0x002B57A6
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
