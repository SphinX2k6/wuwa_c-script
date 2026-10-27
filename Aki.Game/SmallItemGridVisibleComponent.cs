using System;
using System.Runtime.CompilerServices;

// Token: 0x02001996 RID: 6550
public class SmallItemGridVisibleComponent : SmallItemGridComponent
{
	// Token: 0x0600BF53 RID: 48979 RVA: 0x002B3B98 File Offset: 0x002B1D98
	[NullableContext(1)]
	protected override void OnRefresh(object bVisible)
	{
		this.SetActive((bVisible as bool?).GetValueOrDefault());
	}
}
