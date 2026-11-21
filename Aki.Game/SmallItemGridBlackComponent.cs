using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E27 RID: 3623
[NullableContext(1)]
[Nullable(0)]
public class SmallItemGridBlackComponent : SmallItemGridComponent
{
	// Token: 0x060092B0 RID: 37552 RVA: 0x002BD5D2 File Offset: 0x002BB7D2
	protected override string GetResourceId()
	{
		return "UiItem_ItemBDark";
	}

	// Token: 0x060092B1 RID: 37553 RVA: 0x002BD5DC File Offset: 0x002BB7DC
	protected override void OnRefresh(object bVisible)
	{
		this.SetActive((bVisible as bool?).GetValueOrDefault());
	}
}
