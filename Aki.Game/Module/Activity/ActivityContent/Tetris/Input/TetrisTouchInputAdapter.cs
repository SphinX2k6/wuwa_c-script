using System;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Input
{
	// Token: 0x02002FF5 RID: 12277
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class TetrisTouchInputAdapter : TetrisNativeInputAdapter
	{
		// Token: 0x0601D23D RID: 119357 RVA: 0x008E7426 File Offset: 0x008E5626
		public TetrisTouchInputAdapter(ITetrisDragHost host, int viewId) : base(host)
		{
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x0601D23E RID: 119358 RVA: 0x008E742F File Offset: 0x008E562F
		public override EInputControllerMainType InputMode
		{
			get
			{
				return EInputControllerMainType.Touch;
			}
		}

		// Token: 0x0601D23F RID: 119359 RVA: 0x008E7434 File Offset: 0x008E5634
		[NullableContext(2)]
		public override long OnBeginDrag(in TetrisPointerSnapshot pointer, BlockInstance shape)
		{
			if (!this.IsPrimaryTouch(pointer))
			{
				this.LogInput("RejectBegin", 0L, pointer, null);
				return 0L;
			}
			long num = base.OnBeginDrag(pointer, shape);
			if (num != 0L)
			{
				this.LogInput("Begin", num, pointer, null);
			}
			return num;
		}

		// Token: 0x0601D240 RID: 119360 RVA: 0x008E7487 File Offset: 0x008E5687
		public override bool OnDrag(long sessionId, in TetrisPointerSnapshot pointer)
		{
			return this.IsPrimaryTouch(pointer) && base.OnDrag(sessionId, pointer);
		}

		// Token: 0x0601D241 RID: 119361 RVA: 0x008E749C File Offset: 0x008E569C
		public override bool OnEndDrag(long sessionId, in TetrisPointerSnapshot pointer)
		{
			if (!base.IsStarted || !this.IsPrimaryTouch(pointer) || !base.Host.MatchesNativeDrag(sessionId, pointer))
			{
				return false;
			}
			ETetrisDragCompleteResult etetrisDragCompleteResult = base.Host.CompleteDrag(sessionId, pointer.PointerPosition);
			this.LogInput("Complete", sessionId, pointer, new ETetrisDragCompleteResult?(etetrisDragCompleteResult));
			bool flag = etetrisDragCompleteResult == ETetrisDragCompleteResult.Ignored || etetrisDragCompleteResult == ETetrisDragCompleteResult.OutsideBoard;
			return !flag;
		}

		// Token: 0x0601D242 RID: 119362 RVA: 0x008E7502 File Offset: 0x008E5702
		private bool IsPrimaryTouch(in TetrisPointerSnapshot pointer)
		{
			return pointer.InputMode == this.InputMode && pointer.PointerId == 0;
		}

		// Token: 0x0601D243 RID: 119363 RVA: 0x008E751D File Offset: 0x008E571D
		private void LogInput(string phase, long sessionId, in TetrisPointerSnapshot pointer, ETetrisDragCompleteResult? result = null)
		{
		}
	}
}
