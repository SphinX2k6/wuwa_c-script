using System;
using System.Runtime.CompilerServices;

// Token: 0x020012B4 RID: 4788
[NullableContext(1)]
[Nullable(0)]
public class HandBookDropItemData
{
	// Token: 0x0600BDAC RID: 48556 RVA: 0x00380033 File Offset: 0x0037E233
	public HandBookDropItemData(string title, string place, TItem[] itemData)
	{
		this.Title = title;
		this.Place = place;
		this.ItemData = itemData;
	}

	// Token: 0x04006D12 RID: 27922
	public string Title;

	// Token: 0x04006D13 RID: 27923
	public string Place;

	// Token: 0x04006D14 RID: 27924
	public TItem[] ItemData;
}
