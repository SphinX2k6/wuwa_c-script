using System;
using System.Runtime.CompilerServices;

// Token: 0x0200196A RID: 6506
[NullableContext(1)]
[Nullable(0)]
public class SmallItemGridBlackComponent : SmallItemGridComponent
{
	// Token: 0x0600BEA8 RID: 48808 RVA: 0x002B264E File Offset: 0x002B084E
	protected override string GetResourceId()
	{
		return "UiItem_ItemBDark";
	}

	// Token: 0x0600BEA9 RID: 48809 RVA: 0x002B2658 File Offset: 0x002B0858
	protected override void OnRefresh(object bVisible)
	{
		this.SetActive((bVisible as bool?).GetValueOrDefault());
	}
}
