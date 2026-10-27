using System;
using System.Runtime.CompilerServices;

// Token: 0x0200190C RID: 6412
public class MediumItemGridCurTagComponent : MediumItemGridComponent
{
	// Token: 0x0600BBED RID: 48109 RVA: 0x002A991F File Offset: 0x002A7B1F
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTagCur";
	}

	// Token: 0x0600BBEE RID: 48110 RVA: 0x002A9928 File Offset: 0x002A7B28
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (data is bool)
		{
			bool active = (bool)data;
			this.SetActive(active);
		}
	}
}
