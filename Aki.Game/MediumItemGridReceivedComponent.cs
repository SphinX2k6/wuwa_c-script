using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DE1 RID: 3553
public class MediumItemGridReceivedComponent : MediumItemGridVisibleComponent
{
	// Token: 0x06009071 RID: 36977 RVA: 0x002B53D3 File Offset: 0x002B35D3
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemReceived";
	}

	// Token: 0x06009072 RID: 36978 RVA: 0x002B53DA File Offset: 0x002B35DA
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
