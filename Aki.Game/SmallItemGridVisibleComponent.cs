using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E53 RID: 3667
public class SmallItemGridVisibleComponent : SmallItemGridComponent
{
	// Token: 0x0600935B RID: 37723 RVA: 0x002BEB1C File Offset: 0x002BCD1C
	[NullableContext(1)]
	protected override void OnRefresh(object bVisible)
	{
		this.SetActive((bVisible as bool?).GetValueOrDefault());
	}
}
