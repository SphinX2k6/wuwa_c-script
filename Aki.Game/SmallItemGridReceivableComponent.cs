using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E24 RID: 3620
public class SmallItemGridReceivableComponent : SmallItemGridVisibleComponent
{
	// Token: 0x060092A8 RID: 37544 RVA: 0x002BD59F File Offset: 0x002BB79F
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBReceivable";
	}

	// Token: 0x060092A9 RID: 37545 RVA: 0x002BD5A6 File Offset: 0x002BB7A6
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
