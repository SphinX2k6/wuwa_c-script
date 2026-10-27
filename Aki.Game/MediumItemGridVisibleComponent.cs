using System;
using System.Runtime.CompilerServices;

// Token: 0x02001941 RID: 6465
public class MediumItemGridVisibleComponent : MediumItemGridComponent
{
	// Token: 0x0600BCF0 RID: 48368 RVA: 0x002ABE08 File Offset: 0x002AA008
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
