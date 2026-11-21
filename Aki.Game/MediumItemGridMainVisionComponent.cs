using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DDB RID: 3547
public class MediumItemGridMainVisionComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600905F RID: 36959 RVA: 0x002B51F9 File Offset: 0x002B33F9
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemMainVision";
	}

	// Token: 0x06009060 RID: 36960 RVA: 0x002B5200 File Offset: 0x002B3400
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
