using System;
using System.Runtime.CompilerServices;

// Token: 0x02001987 RID: 6535
[NullableContext(1)]
[Nullable(0)]
public class SmallItemGridNotFoundComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600BF0D RID: 48909 RVA: 0x002B3327 File Offset: 0x002B1527
	protected override string GetResourceId()
	{
		return "UiItem_ItemBNotFound";
	}

	// Token: 0x0600BF0E RID: 48910 RVA: 0x002B3330 File Offset: 0x002B1530
	protected override void OnRefresh(object bVisible)
	{
		base.OnRefresh(bVisible);
		this.SetActive((bVisible as bool?).GetValueOrDefault());
	}

	// Token: 0x0600BF0F RID: 48911 RVA: 0x002B335D File Offset: 0x002B155D
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
