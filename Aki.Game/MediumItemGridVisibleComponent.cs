using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DFD RID: 3581
public class MediumItemGridVisibleComponent : MediumItemGridComponent
{
	// Token: 0x060090EB RID: 37099 RVA: 0x002B68D4 File Offset: 0x002B4AD4
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
