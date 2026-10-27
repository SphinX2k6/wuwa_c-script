using System;
using System.Runtime.CompilerServices;

// Token: 0x02001922 RID: 6434
public class MediumItemGridMainVisionComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600BC75 RID: 48245 RVA: 0x002AAA9D File Offset: 0x002A8C9D
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemMainVision";
	}

	// Token: 0x0600BC76 RID: 48246 RVA: 0x002AAAA4 File Offset: 0x002A8CA4
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
