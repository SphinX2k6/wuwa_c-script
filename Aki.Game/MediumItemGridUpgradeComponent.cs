using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DFC RID: 3580
public class MediumItemGridUpgradeComponent : MediumItemGridComponent
{
	// Token: 0x060090E8 RID: 37096 RVA: 0x002B689F File Offset: 0x002B4A9F
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_Upgrade";
	}

	// Token: 0x060090E9 RID: 37097 RVA: 0x002B68A8 File Offset: 0x002B4AA8
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
