using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E44 RID: 3652
[NullableContext(1)]
[Nullable(0)]
public class SmallItemGridNotFoundComponent : SmallItemGridVisibleComponent
{
	// Token: 0x06009315 RID: 37653 RVA: 0x002BE2AB File Offset: 0x002BC4AB
	protected override string GetResourceId()
	{
		return "UiItem_ItemBNotFound";
	}

	// Token: 0x06009316 RID: 37654 RVA: 0x002BE2B4 File Offset: 0x002BC4B4
	protected override void OnRefresh(object bVisible)
	{
		base.OnRefresh(bVisible);
		this.SetActive((bVisible as bool?).GetValueOrDefault());
	}

	// Token: 0x06009317 RID: 37655 RVA: 0x002BE2E1 File Offset: 0x002BC4E1
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
