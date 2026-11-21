using System;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Input
{
	// Token: 0x02002FF3 RID: 12275
	[NullableContext(1)]
	[Nullable(0)]
	internal abstract class TetrisNativeInputAdapter : ITetrisInputAdapter
	{
		// Token: 0x0601D221 RID: 119329 RVA: 0x008E6FD1 File Offset: 0x008E51D1
		protected TetrisNativeInputAdapter(ITetrisDragHost host)
		{
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x0601D222 RID: 119330 RVA: 0x008E6FE0 File Offset: 0x008E51E0
		protected ITetrisDragHost Host { get; } = host;

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x0601D223 RID: 119331 RVA: 0x008E6FE8 File Offset: 0x008E51E8
		// (set) Token: 0x0601D224 RID: 119332 RVA: 0x008E6FF0 File Offset: 0x008E51F0
		private protected bool IsStarted { protected get; private set; }

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x0601D225 RID: 119333
		public abstract EInputControllerMainType InputMode { get; }

		// Token: 0x0601D226 RID: 119334 RVA: 0x008E6FF9 File Offset: 0x008E51F9
		public virtual void Start()
		{
			this.IsStarted = true;
		}

		// Token: 0x0601D227 RID: 119335 RVA: 0x008E7002 File Offset: 0x008E5202
		public virtual void Stop()
		{
			this.IsStarted = false;
		}

		// Token: 0x0601D228 RID: 119336 RVA: 0x008E700B File Offset: 0x008E520B
		public virtual void OnTick(float delta)
		{
		}

		// Token: 0x0601D229 RID: 119337 RVA: 0x008E700D File Offset: 0x008E520D
		public virtual void OnDragCancelled()
		{
		}

		// Token: 0x0601D22A RID: 119338 RVA: 0x008E7010 File Offset: 0x008E5210
		[NullableContext(2)]
		public virtual long OnBeginDrag(in TetrisPointerSnapshot pointer, BlockInstance shape)
		{
			if (!this.IsStarted || pointer.InputMode != this.InputMode)
			{
				return 0L;
			}
			long result;
			if (!this.Host.TryBeginDrag(pointer, shape, out result))
			{
				return 0L;
			}
			return result;
		}

		// Token: 0x0601D22B RID: 119339 RVA: 0x008E704B File Offset: 0x008E524B
		public virtual bool OnDrag(long sessionId, in TetrisPointerSnapshot pointer)
		{
			return this.IsStarted && pointer.InputMode == this.InputMode && this.Host.MatchesNativeDrag(sessionId, pointer) && this.Host.UpdateDrag(sessionId, pointer.PointerPosition);
		}

		// Token: 0x0601D22C RID: 119340 RVA: 0x008E7088 File Offset: 0x008E5288
		public virtual bool OnEndDrag(long sessionId, in TetrisPointerSnapshot pointer)
		{
			if (!this.IsStarted || pointer.InputMode != this.InputMode || !this.Host.MatchesNativeDrag(sessionId, pointer))
			{
				return false;
			}
			ETetrisDragCompleteResult etetrisDragCompleteResult = this.Host.CompleteDrag(sessionId, pointer.PointerPosition);
			bool flag = etetrisDragCompleteResult == ETetrisDragCompleteResult.Ignored || etetrisDragCompleteResult == ETetrisDragCompleteResult.OutsideBoard;
			return !flag;
		}

		// Token: 0x0601D22D RID: 119341 RVA: 0x008E70E0 File Offset: 0x008E52E0
		[NullableContext(2)]
		public virtual void OnPointerDown(in TetrisPointerSnapshot pointer, BlockInstance shape)
		{
		}

		// Token: 0x0601D22E RID: 119342 RVA: 0x008E70E2 File Offset: 0x008E52E2
		public virtual void OnPointerUp(in TetrisPointerSnapshot pointer)
		{
		}

		// Token: 0x0601D22F RID: 119343 RVA: 0x008E70E4 File Offset: 0x008E52E4
		public virtual void OnPickShape(int handIndex)
		{
		}
	}
}
