using System;
using System.Runtime.CompilerServices;

// Token: 0x0200193B RID: 6459
public class MediumItemGridTemplateIconComponent : MediumItemGridComponent
{
	// Token: 0x0600BCDF RID: 48351 RVA: 0x002ABC5E File Offset: 0x002A9E5E
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_TemplateIcon";
	}

	// Token: 0x0600BCE0 RID: 48352 RVA: 0x002ABC68 File Offset: 0x002A9E68
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
