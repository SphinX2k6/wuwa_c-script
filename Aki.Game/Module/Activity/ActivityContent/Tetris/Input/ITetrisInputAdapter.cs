using System;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Input
{
	// Token: 0x02002FED RID: 12269
	[NullableContext(2)]
	internal interface ITetrisInputAdapter
	{
		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x0601D1D4 RID: 119252
		EInputControllerMainType InputMode { get; }

		// Token: 0x0601D1D5 RID: 119253
		void Start();

		// Token: 0x0601D1D6 RID: 119254
		void Stop();

		// Token: 0x0601D1D7 RID: 119255
		void OnTick(float delta);

		// Token: 0x0601D1D8 RID: 119256
		void OnDragCancelled();

		// Token: 0x0601D1D9 RID: 119257
		long OnBeginDrag(in TetrisPointerSnapshot pointer, BlockInstance shape);

		// Token: 0x0601D1DA RID: 119258
		bool OnDrag(long sessionId, in TetrisPointerSnapshot pointer);

		// Token: 0x0601D1DB RID: 119259
		bool OnEndDrag(long sessionId, in TetrisPointerSnapshot pointer);

		// Token: 0x0601D1DC RID: 119260
		void OnPointerDown(in TetrisPointerSnapshot pointer, BlockInstance shape);

		// Token: 0x0601D1DD RID: 119261
		void OnPointerUp(in TetrisPointerSnapshot pointer);

		// Token: 0x0601D1DE RID: 119262
		void OnPickShape(int handIndex);
	}
}
