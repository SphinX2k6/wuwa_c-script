using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View.Astrology
{
	// Token: 0x02005F67 RID: 24423
	[NullableContext(2)]
	[Nullable(0)]
	public class AstrologyDragTargetView : UiPanelBase
	{
		// Token: 0x0603AB97 RID: 240535 RVA: 0x0109A7F6 File Offset: 0x010989F6
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEnd));
		}

		// Token: 0x0603AB98 RID: 240536 RVA: 0x0109A820 File Offset: 0x01098A20
		protected override void OnBeforeShow()
		{
			this.HasPlayedFinish = false;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x0603AB99 RID: 240537 RVA: 0x0109A840 File Offset: 0x01098A40
		protected override void OnBeforeDestroy()
		{
			this.ClearFinishFallbackTimer();
			this.ClearCloseFallbackTimer();
			this.ClearHideFallbackTimer();
			this.OnFinishAnimEnd = null;
			this.OnCloseAnimEnd = null;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0603AB9A RID: 240538 RVA: 0x0109A87A File Offset: 0x01098A7A
		[NullableContext(1)]
		public void SetScreenPosition(Vector2D position)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(position.ToUeVector2D(false));
		}

		// Token: 0x0603AB9B RID: 240539 RVA: 0x0109A893 File Offset: 0x01098A93
		public void PlayShow()
		{
			if (this.HasPlayedClose || base.IsDestroy)
			{
				return;
			}
			this.CancelHide();
			base.SetUiActive(true);
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x0603AB9C RID: 240540 RVA: 0x0109A8CC File Offset: 0x01098ACC
		public void PlayCloseThenHide()
		{
			if (this.IsHidePlaying || this.HasPlayedClose || base.IsDestroy)
			{
				return;
			}
			this.IsHidePlaying = true;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlaySequencePurely("Close", false, false);
			}
			this.HideFallbackTimer = TimerSystem.Instance.Delay(new TTimerAction(this.HideSelf), 1500f, null, null, true, 1f);
		}

		// Token: 0x0603AB9D RID: 240541 RVA: 0x0109A93A File Offset: 0x01098B3A
		public void HideImmediately()
		{
			this.CancelHide();
			base.SetUiActive(false);
		}

		// Token: 0x0603AB9E RID: 240542 RVA: 0x0109A94C File Offset: 0x01098B4C
		public void PlayFinish(Action onAnimEnd = null)
		{
			if (this.HasPlayedFinish)
			{
				return;
			}
			this.HasPlayedFinish = true;
			this.OnFinishAnimEnd = onAnimEnd;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlaySequencePurely("Finish", false, false);
			}
			if (onAnimEnd != null)
			{
				this.FinishFallbackTimer = TimerSystem.Instance.Delay(new TTimerAction(this.NotifyFinishAnimEnd), 1500f, null, null, true, 1f);
			}
		}

		// Token: 0x0603AB9F RID: 240543 RVA: 0x0109A9B4 File Offset: 0x01098BB4
		public void PlayCloseThenDestroy(Action onAnimEnd = null)
		{
			if (this.HasPlayedClose || base.IsDestroy)
			{
				return;
			}
			this.HasPlayedClose = true;
			this.OnCloseAnimEnd = onAnimEnd;
			this.ClearFinishFallbackTimer();
			this.OnFinishAnimEnd = null;
			this.CancelHide();
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlaySequencePurely("Close", false, false);
			}
			this.CloseFallbackTimer = TimerSystem.Instance.Delay(new TTimerAction(this.DestroySelf), 1500f, null, null, true, 1f);
		}

		// Token: 0x0603ABA0 RID: 240544 RVA: 0x0109AA34 File Offset: 0x01098C34
		[NullableContext(1)]
		private void OnSequenceEnd(string sequenceName)
		{
			if (sequenceName == "Finish")
			{
				this.NotifyFinishAnimEnd();
				return;
			}
			if (sequenceName == "Close")
			{
				if (this.HasPlayedClose)
				{
					this.DestroySelf();
					return;
				}
				if (this.IsHidePlaying)
				{
					this.HideSelf();
				}
			}
		}

		// Token: 0x0603ABA1 RID: 240545 RVA: 0x0109AA74 File Offset: 0x01098C74
		private void NotifyFinishAnimEnd()
		{
			this.ClearFinishFallbackTimer();
			Action onFinishAnimEnd = this.OnFinishAnimEnd;
			this.OnFinishAnimEnd = null;
			if (onFinishAnimEnd == null)
			{
				return;
			}
			onFinishAnimEnd();
		}

		// Token: 0x0603ABA2 RID: 240546 RVA: 0x0109AA93 File Offset: 0x01098C93
		private void NotifyFinishAnimEnd(float _)
		{
			this.NotifyFinishAnimEnd();
		}

		// Token: 0x0603ABA3 RID: 240547 RVA: 0x0109AA9B File Offset: 0x01098C9B
		private void DestroySelf()
		{
			this.ClearCloseFallbackTimer();
			Action onCloseAnimEnd = this.OnCloseAnimEnd;
			this.OnCloseAnimEnd = null;
			if (!base.IsDestroy)
			{
				base.Destroy(null);
			}
			if (onCloseAnimEnd == null)
			{
				return;
			}
			onCloseAnimEnd();
		}

		// Token: 0x0603ABA4 RID: 240548 RVA: 0x0109AAC9 File Offset: 0x01098CC9
		private void DestroySelf(float _)
		{
			this.DestroySelf();
		}

		// Token: 0x0603ABA5 RID: 240549 RVA: 0x0109AAD1 File Offset: 0x01098CD1
		private void HideSelf()
		{
			this.ClearHideFallbackTimer();
			this.IsHidePlaying = false;
			base.SetUiActive(false);
		}

		// Token: 0x0603ABA6 RID: 240550 RVA: 0x0109AAE7 File Offset: 0x01098CE7
		private void HideSelf(float _)
		{
			this.HideSelf();
		}

		// Token: 0x0603ABA7 RID: 240551 RVA: 0x0109AAEF File Offset: 0x01098CEF
		private void CancelHide()
		{
			this.ClearHideFallbackTimer();
			this.IsHidePlaying = false;
		}

		// Token: 0x0603ABA8 RID: 240552 RVA: 0x0109AAFE File Offset: 0x01098CFE
		private void ClearFinishFallbackTimer()
		{
			TimerHandle finishFallbackTimer = this.FinishFallbackTimer;
			if (finishFallbackTimer != null)
			{
				finishFallbackTimer.Remove();
			}
			this.FinishFallbackTimer = null;
		}

		// Token: 0x0603ABA9 RID: 240553 RVA: 0x0109AB19 File Offset: 0x01098D19
		private void ClearCloseFallbackTimer()
		{
			TimerHandle closeFallbackTimer = this.CloseFallbackTimer;
			if (closeFallbackTimer != null)
			{
				closeFallbackTimer.Remove();
			}
			this.CloseFallbackTimer = null;
		}

		// Token: 0x0603ABAA RID: 240554 RVA: 0x0109AB34 File Offset: 0x01098D34
		private void ClearHideFallbackTimer()
		{
			TimerHandle hideFallbackTimer = this.HideFallbackTimer;
			if (hideFallbackTimer != null)
			{
				hideFallbackTimer.Remove();
			}
			this.HideFallbackTimer = null;
		}

		// Token: 0x0401EDE4 RID: 126436
		private const int FINISH_ANIM_FALLBACK_MS = 1500;

		// Token: 0x0401EDE5 RID: 126437
		private const int CLOSE_ANIM_FALLBACK_MS = 1500;

		// Token: 0x0401EDE6 RID: 126438
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401EDE7 RID: 126439
		private bool HasPlayedFinish;

		// Token: 0x0401EDE8 RID: 126440
		private bool HasPlayedClose;

		// Token: 0x0401EDE9 RID: 126441
		private bool IsHidePlaying;

		// Token: 0x0401EDEA RID: 126442
		private Action OnFinishAnimEnd;

		// Token: 0x0401EDEB RID: 126443
		private Action OnCloseAnimEnd;

		// Token: 0x0401EDEC RID: 126444
		private TimerHandle FinishFallbackTimer;

		// Token: 0x0401EDED RID: 126445
		private TimerHandle CloseFallbackTimer;

		// Token: 0x0401EDEE RID: 126446
		private TimerHandle HideFallbackTimer;
	}
}
