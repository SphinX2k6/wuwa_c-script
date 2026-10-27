using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DF2 RID: 7666
[NullableContext(1)]
[Nullable(0)]
public class HandBookDropItemData
{
	// Token: 0x0600E98D RID: 59789 RVA: 0x0037432B File Offset: 0x0037252B
	public HandBookDropItemData(string title, string place, TItem[] itemData)
	{
		this.Title = title;
		this.Place = place;
		this.ItemData = itemData;
	}

	// Token: 0x04006C31 RID: 27697
	public string Title;

	// Token: 0x04006C32 RID: 27698
	public string Place;

	// Token: 0x04006C33 RID: 27699
	public TItem[] ItemData;
}
