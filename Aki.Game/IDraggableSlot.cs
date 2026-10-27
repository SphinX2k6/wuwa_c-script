using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001BE3 RID: 7139
[NullableContext(1)]
public interface IDraggableSlot
{
	// Token: 0x0600D49F RID: 54431
	int? GetConfigId();

	// Token: 0x0600D4A0 RID: 54432
	int GetPlayerId();

	// Token: 0x0600D4A1 RID: 54433
	UUIItem GetRootItem();

	// Token: 0x0600D4A2 RID: 54434
	void RefreshLockItemState(bool isDrag);

	// Token: 0x0600D4A3 RID: 54435
	void ShowOtherItemUpState();

	// Token: 0x0600D4A4 RID: 54436
	void EndShowDragItem();

	// Token: 0x0600D4A5 RID: 54437
	void MouseCancelDrag();

	// Token: 0x0600D4A6 RID: 54438
	void GamePadPress();

	// Token: 0x0600D4A7 RID: 54439
	void GamePadRelease();

	// Token: 0x0600D4A8 RID: 54440
	void GamePadUp(bool isCancel = false);

	// Token: 0x0600D4A9 RID: 54441
	void Reset();
}
