using System;
using System.Runtime.CompilerServices;

// Token: 0x0200193F RID: 6463
public class MediumItemGridUpgradeArrowComponent : MediumItemGridComponent
{
	// Token: 0x0600BCEA RID: 48362 RVA: 0x002ABD9E File Offset: 0x002A9F9E
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_UpgradeArrow";
	}

	// Token: 0x0600BCEB RID: 48363 RVA: 0x002ABDA8 File Offset: 0x002A9FA8
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
