using System;
using System.Runtime.CompilerServices;

// Token: 0x020017B0 RID: 6064
[NullableContext(1)]
public interface IAutoAttachExhibitionItem
{
	// Token: 0x0600B0F8 RID: 45304
	void OnSelect();

	// Token: 0x0600B0F9 RID: 45305
	void OnUnSelect();

	// Token: 0x0600B0FA RID: 45306
	void SetData(object param);

	// Token: 0x0600B0FB RID: 45307
	void RefreshItem(int showItemIndex);

	// Token: 0x0600B0FC RID: 45308
	void OnMoveItem(float offset);

	// Token: 0x0600B0FD RID: 45309
	void OnChangeDirection(int direction);

	// Token: 0x0600B0FE RID: 45310
	void SetShowItemIndex(int showIndex);

	// Token: 0x0600B0FF RID: 45311
	int GetShowItemIndex();

	// Token: 0x0600B100 RID: 45312
	void SetAttachItem(AutoAttachExhibitionItem item);

	// Token: 0x0600B101 RID: 45313
	[NullableContext(2)]
	AutoAttachExhibitionItem GetAttachItem();

	// Token: 0x0600B102 RID: 45314
	void Clear();
}
