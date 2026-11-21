using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C69 RID: 3177
[NullableContext(1)]
public interface IAutoAttachExhibitionItem
{
	// Token: 0x060084E0 RID: 34016
	void OnSelect();

	// Token: 0x060084E1 RID: 34017
	void OnUnSelect();

	// Token: 0x060084E2 RID: 34018
	void SetData(object param);

	// Token: 0x060084E3 RID: 34019
	void RefreshItem(int showItemIndex);

	// Token: 0x060084E4 RID: 34020
	void OnMoveItem(float offset);

	// Token: 0x060084E5 RID: 34021
	void OnChangeDirection(int direction);

	// Token: 0x060084E6 RID: 34022
	void SetShowItemIndex(int showIndex);

	// Token: 0x060084E7 RID: 34023
	int GetShowItemIndex();

	// Token: 0x060084E8 RID: 34024
	void SetAttachItem(AutoAttachExhibitionItem item);

	// Token: 0x060084E9 RID: 34025
	[NullableContext(2)]
	AutoAttachExhibitionItem GetAttachItem();

	// Token: 0x060084EA RID: 34026
	void Clear();
}
