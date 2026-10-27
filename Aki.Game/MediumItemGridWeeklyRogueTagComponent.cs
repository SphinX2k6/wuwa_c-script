using System;
using System.Runtime.CompilerServices;

// Token: 0x02001949 RID: 6473
public class MediumItemGridWeeklyRogueTagComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600BD11 RID: 48401 RVA: 0x002AC75B File Offset: 0x002AA95B
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTagDescript";
	}

	// Token: 0x0600BD12 RID: 48402 RVA: 0x002AC762 File Offset: 0x002AA962
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
