using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DF7 RID: 3575
public class MediumItemGridTemplateIconComponent : MediumItemGridComponent
{
	// Token: 0x060090DA RID: 37082 RVA: 0x002B672A File Offset: 0x002B492A
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_TemplateIcon";
	}

	// Token: 0x060090DB RID: 37083 RVA: 0x002B6734 File Offset: 0x002B4934
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
