using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DFB RID: 3579
public class MediumItemGridUpgradeArrowComponent : MediumItemGridComponent
{
	// Token: 0x060090E5 RID: 37093 RVA: 0x002B686A File Offset: 0x002B4A6A
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_UpgradeArrow";
	}

	// Token: 0x060090E6 RID: 37094 RVA: 0x002B6874 File Offset: 0x002B4A74
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
