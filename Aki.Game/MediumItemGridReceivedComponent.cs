using System;
using System.Runtime.CompilerServices;

// Token: 0x02001928 RID: 6440
public class MediumItemGridReceivedComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600BC87 RID: 48263 RVA: 0x002AAC77 File Offset: 0x002A8E77
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemReceived";
	}

	// Token: 0x0600BC88 RID: 48264 RVA: 0x002AAC7E File Offset: 0x002A8E7E
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
