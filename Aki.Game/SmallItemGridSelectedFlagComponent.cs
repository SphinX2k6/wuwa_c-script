using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E4D RID: 3661
public class SmallItemGridSelectedFlagComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600933A RID: 37690 RVA: 0x002BE6C5 File Offset: 0x002BC8C5
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBRoleSel";
	}

	// Token: 0x0600933B RID: 37691 RVA: 0x002BE6CC File Offset: 0x002BC8CC
	[NullableContext(1)]
	protected override void OnRefresh(object bVisible)
	{
		base.OnRefresh(bVisible);
		base.SetUiActive((bool)bVisible);
	}

	// Token: 0x0600933C RID: 37692 RVA: 0x002BE6E1 File Offset: 0x002BC8E1
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}
