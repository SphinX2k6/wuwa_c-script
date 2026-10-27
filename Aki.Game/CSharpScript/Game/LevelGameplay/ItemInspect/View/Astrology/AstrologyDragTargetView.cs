using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View.Astrology
{
	// Token: 0x02006DE8 RID: 28136
	[NullableContext(2)]
	[Nullable(0)]
	public class AstrologyDragTargetView : UiPanelBase
	{
		// Token: 0x06044A33 RID: 281139 RVA: 0x010F05AA File Offset: 0x010EE7AA
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEnd));
		}

		// Token: 0x06044A34 RID: 281140 RVA: 0x010F05D4 File Offset: 0x010EE7D4
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

		// Token: 0x06044A35 RID: 281141 RVA: 0x010F05F4 File Offset: 0x010EE7F4
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

		// Token: 0x06044A36 RID: 281142 RVA: 0x010F062E File Offset: 0x010EE82E
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

		// Token: 0x06044A37 RID: 281143 RVA: 0x010F0647 File Offset: 0x010EE847
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

		// Token: 0x06044A38 RID: 281144 RVA: 0x010F0680 File Offset: 0x010EE880
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

		// Token: 0x06044A39 RID: 281145 RVA: 0x010F06EE File Offset: 0x010EE8EE
		public void HideImmediately()
		{
			this.CancelHide();
			base.SetUiActive(false);
		}

		// Token: 0x06044A3A RID: 281146 RVA: 0x010F0700 File Offset: 0x010EE900
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

		// Token: 0x06044A3B RID: 281147 RVA: 0x010F0768 File Offset: 0x010EE968
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

		// Token: 0x06044A3C RID: 281148 RVA: 0x010F07E8 File Offset: 0x010EE9E8
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

		// Token: 0x06044A3D RID: 281149 RVA: 0x010F0828 File Offset: 0x010EEA28
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

		// Token: 0x06044A3E RID: 281150 RVA: 0x010F0847 File Offset: 0x010EEA47
		private void NotifyFinishAnimEnd(float _)
		{
			this.NotifyFinishAnimEnd();
		}

		// Token: 0x06044A3F RID: 281151 RVA: 0x010F084F File Offset: 0x010EEA4F
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

		// Token: 0x06044A40 RID: 281152 RVA: 0x010F087D File Offset: 0x010EEA7D
		private void DestroySelf(float _)
		{
			this.DestroySelf();
		}

		// Token: 0x06044A41 RID: 281153 RVA: 0x010F0885 File Offset: 0x010EEA85
		private void HideSelf()
		{
			this.ClearHideFallbackTimer();
			this.IsHidePlaying = false;
			base.SetUiActive(false);
		}

		// Token: 0x06044A42 RID: 281154 RVA: 0x010F089B File Offset: 0x010EEA9B
		private void HideSelf(float _)
		{
			this.HideSelf();
		}

		// Token: 0x06044A43 RID: 281155 RVA: 0x010F08A3 File Offset: 0x010EEAA3
		private void CancelHide()
		{
			this.ClearHideFallbackTimer();
			this.IsHidePlaying = false;
		}

		// Token: 0x06044A44 RID: 281156 RVA: 0x010F08B2 File Offset: 0x010EEAB2
		private void ClearFinishFallbackTimer()
		{
			TimerHandle finishFallbackTimer = this.FinishFallbackTimer;
			if (finishFallbackTimer != null)
			{
				finishFallbackTimer.Remove();
			}
			this.FinishFallbackTimer = null;
		}

		// Token: 0x06044A45 RID: 281157 RVA: 0x010F08CD File Offset: 0x010EEACD
		private void ClearCloseFallbackTimer()
		{
			TimerHandle closeFallbackTimer = this.CloseFallbackTimer;
			if (closeFallbackTimer != null)
			{
				closeFallbackTimer.Remove();
			}
			this.CloseFallbackTimer = null;
		}

		// Token: 0x06044A46 RID: 281158 RVA: 0x010F08E8 File Offset: 0x010EEAE8
		private void ClearHideFallbackTimer()
		{
			TimerHandle hideFallbackTimer = this.HideFallbackTimer;
			if (hideFallbackTimer != null)
			{
				hideFallbackTimer.Remove();
			}
			this.HideFallbackTimer = null;
		}

		// Token: 0x04023B42 RID: 146242
		private const int FINISH_ANIM_FALLBACK_MS = 1500;

		// Token: 0x04023B43 RID: 146243
		private const int CLOSE_ANIM_FALLBACK_MS = 1500;

		// Token: 0x04023B44 RID: 146244
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04023B45 RID: 146245
		private bool HasPlayedFinish;

		// Token: 0x04023B46 RID: 146246
		private bool HasPlayedClose;

		// Token: 0x04023B47 RID: 146247
		private bool IsHidePlaying;

		// Token: 0x04023B48 RID: 146248
		private Action OnFinishAnimEnd;

		// Token: 0x04023B49 RID: 146249
		private Action OnCloseAnimEnd;

		// Token: 0x04023B4A RID: 146250
		private TimerHandle FinishFallbackTimer;

		// Token: 0x04023B4B RID: 146251
		private TimerHandle CloseFallbackTimer;

		// Token: 0x04023B4C RID: 146252
		private TimerHandle HideFallbackTimer;
	}
}
