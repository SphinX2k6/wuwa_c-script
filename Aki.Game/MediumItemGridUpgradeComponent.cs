using System;
using System.Runtime.CompilerServices;

// Token: 0x02001940 RID: 6464
public class MediumItemGridUpgradeComponent : MediumItemGridComponent
{
	// Token: 0x0600BCED RID: 48365 RVA: 0x002ABDD3 File Offset: 0x002A9FD3
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_Upgrade";
	}

	// Token: 0x0600BCEE RID: 48366 RVA: 0x002ABDDC File Offset: 0x002A9FDC
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
