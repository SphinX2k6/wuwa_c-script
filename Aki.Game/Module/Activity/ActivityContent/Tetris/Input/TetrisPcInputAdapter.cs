using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.InputSetting;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Input
{
	// Token: 0x02002FF4 RID: 12276
	internal sealed class TetrisPcInputAdapter : TetrisNativeInputAdapter
	{
		// Token: 0x0601D230 RID: 119344 RVA: 0x008E70E6 File Offset: 0x008E52E6
		[NullableContext(1)]
		public TetrisPcInputAdapter(ITetrisDragHost host) : base(host)
		{
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x0601D231 RID: 119345 RVA: 0x008E70EF File Offset: 0x008E52EF
		public override EInputControllerMainType InputMode
		{
			get
			{
				return EInputControllerMainType.Keyboard;
			}
		}

		// Token: 0x0601D232 RID: 119346 RVA: 0x008E70F2 File Offset: 0x008E52F2
		public override void Stop()
		{
			this.ResetSession();
			base.Stop();
		}

		// Token: 0x0601D233 RID: 119347 RVA: 0x008E7100 File Offset: 0x008E5300
		public override void OnDragCancelled()
		{
			this.ResetSession();
		}

		// Token: 0x0601D234 RID: 119348 RVA: 0x008E7108 File Offset: 0x008E5308
		[NullableContext(2)]
		public override long OnBeginDrag(in TetrisPointerSnapshot pointer, BlockInstance shape)
		{
			if (!base.IsStarted || pointer.InputMode != this.InputMode || base.Host.ActiveDragSessionId != null)
			{
				return 0L;
			}
			if (pointer.MouseButtonType != EMouseButtonType.Left)
			{
				return 0L;
			}
			bool flag;
			FVector fvector;
			ETetrisDragCancelReason etetrisDragCancelReason;
			if (!TetrisPcInputAdapter.TryGetPointerState(out flag, out fvector, out etetrisDragCancelReason))
			{
				return 0L;
			}
			if (!flag)
			{
				return 0L;
			}
			long num = base.OnBeginDrag(pointer, shape);
			if (num != 0L)
			{
				this.ResetSession();
				this.DragSessionId = num;
				this.PrevLeftMouseDown = true;
			}
			return num;
		}

		// Token: 0x0601D235 RID: 119349 RVA: 0x008E7188 File Offset: 0x008E5388
		public override bool OnDrag(long sessionId, in TetrisPointerSnapshot pointer)
		{
			if (!this.MatchesSession(sessionId, pointer))
			{
				return false;
			}
			bool flag;
			FVector fvector;
			ETetrisDragCancelReason reason;
			if (!TetrisPcInputAdapter.TryGetPointerState(out flag, out fvector, out reason))
			{
				this.CancelSession(reason);
				return false;
			}
			return flag && base.OnDrag(sessionId, pointer);
		}

		// Token: 0x0601D236 RID: 119350 RVA: 0x008E71C4 File Offset: 0x008E53C4
		public override bool OnEndDrag(long sessionId, in TetrisPointerSnapshot pointer)
		{
			if (!this.MatchesSession(sessionId, pointer))
			{
				return false;
			}
			if (pointer.MouseButtonType != EMouseButtonType.Left)
			{
				return false;
			}
			bool flag;
			FVector pointerPosition;
			ETetrisDragCancelReason reason;
			if (!TetrisPcInputAdapter.TryGetPointerState(out flag, out pointerPosition, out reason))
			{
				this.CancelSession(reason);
				return false;
			}
			if (flag)
			{
				return false;
			}
			ETetrisDragCompleteResult etetrisDragCompleteResult = this.CompleteSession(pointerPosition);
			bool flag2 = etetrisDragCompleteResult == ETetrisDragCompleteResult.Ignored || etetrisDragCompleteResult == ETetrisDragCompleteResult.OutsideBoard;
			return !flag2;
		}

		// Token: 0x0601D237 RID: 119351 RVA: 0x008E7220 File Offset: 0x008E5420
		public override void OnTick(float delta)
		{
			if (!base.IsStarted || this.DragSessionId == 0L)
			{
				return;
			}
			long? activeDragSessionId = base.Host.ActiveDragSessionId;
			long dragSessionId = this.DragSessionId;
			if (!(activeDragSessionId.GetValueOrDefault() == dragSessionId & activeDragSessionId != null))
			{
				this.ResetSession();
				return;
			}
			bool flag;
			FVector pointerPosition;
			ETetrisDragCancelReason reason;
			if (!TetrisPcInputAdapter.TryGetPointerState(out flag, out pointerPosition, out reason))
			{
				this.CancelSession(reason);
				return;
			}
			bool flag2 = this.PrevLeftMouseDown && !flag;
			this.PrevLeftMouseDown = flag;
			if (!base.Host.UpdateDrag(this.DragSessionId, pointerPosition))
			{
				this.ResetSession();
				return;
			}
			if (flag2 || !flag)
			{
				this.CompleteSession(pointerPosition);
			}
		}

		// Token: 0x0601D238 RID: 119352 RVA: 0x008E72C4 File Offset: 0x008E54C4
		private bool MatchesSession(long sessionId, in TetrisPointerSnapshot pointer)
		{
			return base.IsStarted && sessionId != 0L && this.DragSessionId == sessionId && pointer.InputMode == this.InputMode && base.Host.MatchesNativeDrag(sessionId, pointer);
		}

		// Token: 0x0601D239 RID: 119353 RVA: 0x008E72F8 File Offset: 0x008E54F8
		private static bool TryGetPointerState(out bool isLeftDown, out FVector pointerPosition, out ETetrisDragCancelReason reason)
		{
			isLeftDown = false;
			pointerPosition = default(FVector);
			reason = ETetrisDragCancelReason.MissingPointerPosition;
			bool? windowActivationState = Application.Instance.GetWindowActivationState();
			bool flag = false;
			if (windowActivationState.GetValueOrDefault() == flag & windowActivationState != null)
			{
				reason = ETetrisDragCancelReason.ApplicationInactive;
				return false;
			}
			APlayerController playerController = Global.PlayerController;
			if (playerController == null || !playerController.IsValid())
			{
				reason = ETetrisDragCancelReason.InputControllerUnavailable;
				return false;
			}
			isLeftDown = playerController.IsInputKeyDown(new FKey
			{
				KeyName = new FName(EKey.LeftMouseButton)
			});
			float inX = 0f;
			float inY = 0f;
			if (!playerController.GetMousePosition(ref inX, ref inY))
			{
				return false;
			}
			pointerPosition = new FVector(inX, inY, 0f);
			if (!float.IsFinite(pointerPosition.X) || !float.IsFinite(pointerPosition.Y))
			{
				reason = ETetrisDragCancelReason.InvalidPointerPosition;
				return false;
			}
			return true;
		}

		// Token: 0x0601D23A RID: 119354 RVA: 0x008E73C0 File Offset: 0x008E55C0
		private ETetrisDragCompleteResult CompleteSession(FVector pointerPosition)
		{
			long dragSessionId = this.DragSessionId;
			this.ResetSession();
			return base.Host.CompleteDrag(dragSessionId, pointerPosition);
		}

		// Token: 0x0601D23B RID: 119355 RVA: 0x008E73E8 File Offset: 0x008E55E8
		private void CancelSession(ETetrisDragCancelReason reason)
		{
			long dragSessionId = this.DragSessionId;
			this.ResetSession();
			base.Host.CancelDrag(reason, new long?(dragSessionId));
		}

		// Token: 0x0601D23C RID: 119356 RVA: 0x008E7415 File Offset: 0x008E5615
		private void ResetSession()
		{
			this.DragSessionId = 0L;
			this.PrevLeftMouseDown = false;
		}

		// Token: 0x0400F587 RID: 62855
		private long DragSessionId;

		// Token: 0x0400F588 RID: 62856
		private bool PrevLeftMouseDown;
	}
}
