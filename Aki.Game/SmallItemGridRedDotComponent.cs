using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E48 RID: 3656
public class SmallItemGridRedDotComponent : SmallItemGridVisibleComponent
{
	// Token: 0x06009324 RID: 37668 RVA: 0x002BE3A4 File Offset: 0x002BC5A4
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRedDot";
	}

	// Token: 0x06009325 RID: 37669 RVA: 0x002BE3AB File Offset: 0x002BC5AB
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Top;
	}
}
