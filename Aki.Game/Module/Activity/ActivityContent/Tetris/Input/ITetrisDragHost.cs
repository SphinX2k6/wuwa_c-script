using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Input
{
	// Token: 0x02002FEC RID: 12268
	[NullableContext(2)]
	internal interface ITetrisDragHost
	{
		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x0601D1C8 RID: 119240
		long? ActiveDragSessionId { get; }

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x0601D1C9 RID: 119241
		int CurrentDragHandIndex { get; }

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x0601D1CA RID: 119242
		bool CanHandleDragInput { get; }

		// Token: 0x0601D1CB RID: 119243
		bool MatchesNativeDrag(long sessionId, in TetrisPointerSnapshot pointer);

		// Token: 0x0601D1CC RID: 119244
		bool TryGetHitHandPointer(out TetrisPointerSnapshot pointer, out BlockInstance shape);

		// Token: 0x0601D1CD RID: 119245
		bool TryGetHandPointer(int handIndex, out TetrisPointerSnapshot pointer, out BlockInstance shape);

		// Token: 0x0601D1CE RID: 119246
		void SetGamepadDragging(bool isDragging);

		// Token: 0x0601D1CF RID: 119247
		bool TryBeginDrag(in TetrisPointerSnapshot pointer, BlockInstance shape, out long sessionId);

		// Token: 0x0601D1D0 RID: 119248
		bool UpdateDrag(long sessionId, FVector pointerPosition);

		// Token: 0x0601D1D1 RID: 119249
		ETetrisDragCompleteResult CompleteDrag(long sessionId, FVector pointerPosition);

		// Token: 0x0601D1D2 RID: 119250
		bool CancelDrag(ETetrisDragCancelReason reason, long? expectedSessionId = null);

		// Token: 0x0601D1D3 RID: 119251
		bool TryReplaceDragShape(long sessionId, int handIndex);
	}
}
