using System;
using System.Runtime.CompilerServices;

// Token: 0x02001990 RID: 6544
public class SmallItemGridSelectedFlagComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600BF32 RID: 48946 RVA: 0x002B3741 File Offset: 0x002B1941
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBRoleSel";
	}

	// Token: 0x0600BF33 RID: 48947 RVA: 0x002B3748 File Offset: 0x002B1948
	[NullableContext(1)]
	protected override void OnRefresh(object bVisible)
	{
		base.OnRefresh(bVisible);
		base.SetUiActive((bool)bVisible);
	}

	// Token: 0x0600BF34 RID: 48948 RVA: 0x002B375D File Offset: 0x002B195D
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
