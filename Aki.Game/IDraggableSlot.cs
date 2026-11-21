using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020010A2 RID: 4258
[NullableContext(1)]
public interface IDraggableSlot
{
	// Token: 0x0600A8B1 RID: 43185
	int? GetConfigId();

	// Token: 0x0600A8B2 RID: 43186
	int GetPlayerId();

	// Token: 0x0600A8B3 RID: 43187
	UUIItem GetRootItem();

	// Token: 0x0600A8B4 RID: 43188
	void RefreshLockItemState(bool isDrag);

	// Token: 0x0600A8B5 RID: 43189
	void ShowOtherItemUpState();

	// Token: 0x0600A8B6 RID: 43190
	void EndShowDragItem();

	// Token: 0x0600A8B7 RID: 43191
	void MouseCancelDrag();

	// Token: 0x0600A8B8 RID: 43192
	void GamePadPress();

	// Token: 0x0600A8B9 RID: 43193
	void GamePadRelease();

	// Token: 0x0600A8BA RID: 43194
	void GamePadUp(bool isCancel = false);

	// Token: 0x0600A8BB RID: 43195
	void Reset();
}
