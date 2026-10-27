using System;
using System.Runtime.CompilerServices;

// Token: 0x0200229C RID: 8860
public class MotorcycleDiyEditPartTabItem : MotorcycleDiyPartTabItem
{
	// Token: 0x060114F9 RID: 70905 RVA: 0x00439C69 File Offset: 0x00437E69
	[NullableContext(1)]
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		base.OnRefresh(data, isSelected, gridIndex);
		base.SetPreviewRedDotVisible(false);
	}
}
