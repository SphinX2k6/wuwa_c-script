using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DC5 RID: 3525
public class MediumItemGridCurTagComponent : MediumItemGridComponent
{
	// Token: 0x06008FD7 RID: 36823 RVA: 0x002B407B File Offset: 0x002B227B
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTagCur";
	}

	// Token: 0x06008FD8 RID: 36824 RVA: 0x002B4084 File Offset: 0x002B2284
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (data is bool)
		{
			bool active = (bool)data;
			this.SetActive(active);
		}
	}
}
