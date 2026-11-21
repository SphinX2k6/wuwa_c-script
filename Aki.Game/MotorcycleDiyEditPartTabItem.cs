using System;
using System.Runtime.CompilerServices;

// Token: 0x02001780 RID: 6016
public class MotorcycleDiyEditPartTabItem : MotorcycleDiyPartTabItem
{
	// Token: 0x0600E991 RID: 59793 RVA: 0x00446861 File Offset: 0x00444A61
	[NullableContext(1)]
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		base.OnRefresh(data, isSelected, gridIndex);
		base.SetPreviewRedDotVisible(false);
	}
}
