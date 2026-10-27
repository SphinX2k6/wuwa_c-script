using System;
using System.Runtime.CompilerServices;

// Token: 0x02001948 RID: 6472
public class MediumItemGridWarningTipsComponent : MediumItemGridComponent
{
	// Token: 0x0600BD0E RID: 48398 RVA: 0x002AC728 File Offset: 0x002AA928
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_WarningIcon";
	}

	// Token: 0x0600BD0F RID: 48399 RVA: 0x002AC730 File Offset: 0x002AA930
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
