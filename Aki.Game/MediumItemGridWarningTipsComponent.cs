using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E05 RID: 3589
public class MediumItemGridWarningTipsComponent : MediumItemGridComponent
{
	// Token: 0x06009111 RID: 37137 RVA: 0x002B756C File Offset: 0x002B576C
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_WarningIcon";
	}

	// Token: 0x06009112 RID: 37138 RVA: 0x002B7574 File Offset: 0x002B5774
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
