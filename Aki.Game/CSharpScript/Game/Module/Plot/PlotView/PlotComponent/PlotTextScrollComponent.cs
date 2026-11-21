using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200405D RID: 16477
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTextScrollComponent
	{
		// Token: 0x06029C26 RID: 171046 RVA: 0x00BCBBAA File Offset: 0x00BC9DAA
		[NullableContext(1)]
		public void Init(PlotTextScrollComponentContext context)
		{
			this.TextComponent = context.TextComponent;
			this.TextScrollView = context.TextScrollView;
		}

		// Token: 0x06029C27 RID: 171047 RVA: 0x00BCBBC4 File Offset: 0x00BC9DC4
		[NullableContext(1)]
		public void EnableManualScroll(Action onClick)
		{
			if (this.TextScrollView == null)
			{
				return;
			}
			this.OnClickDelegate = onClick;
			this.TextScrollView.SetCanScroll(true);
			this.TextScrollView.SetRayCastTargetForScrollView(true);
			this.TextScrollView.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnManualDragBegin));
			this.TextScrollView.OnScrollViewDownUpCallback.Bind(new Action<ULGUIPointerEventData>(this.OnManualPointerUp));
		}

		// Token: 0x06029C28 RID: 171048 RVA: 0x00BCBC31 File Offset: 0x00BC9E31
		public void SetCharReadSpeed(float readSpeed)
		{
			this.CharReadSpeed = readSpeed;
		}

		// Token: 0x06029C29 RID: 171049 RVA: 0x00BCBC3A File Offset: 0x00BC9E3A
		public void SetDelayCharNum(float delayCharNum)
		{
			this.DelayCharNum = delayCharNum;
		}

		// Token: 0x06029C2A RID: 171050 RVA: 0x00BCBC43 File Offset: 0x00BC9E43
		public void SetPlayRate(float playRate)
		{
			this.PlayRate = playRate;
			if (this.DelayTextScrollAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.DelayTextScrollAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.ChangeDilation(this.DelayTextScrollAnimTimer, this.PlayRate, null);
			}
		}

		// Token: 0x06029C2B RID: 171051 RVA: 0x00BCBC7E File Offset: 0x00BC9E7E
		public void PlayNextFrame()
		{
			if (this.IsWaitingNextFrame)
			{
				return;
			}
			this.IsWaitingNextFrame = true;
			this.NextFrameTimer = TimerSystem.GameplayTimeInstance.Next(new TTimerAction(this.OnNextFramePlay), null, null);
		}

		// Token: 0x06029C2C RID: 171052 RVA: 0x00BCBCAE File Offset: 0x00BC9EAE
		private void OnNextFramePlay(float handle)
		{
			this.IsWaitingNextFrame = false;
			this.RemoveNextFrameTimer();
			UUIScrollViewComponent textScrollView = this.TextScrollView;
			if (textScrollView != null)
			{
				textScrollView.SetScrollProgress(this.IsJumpToEndPending > false);
			}
			if (this.IsJumpToEndPending)
			{
				this.IsJumpToEndPending = false;
				return;
			}
			this.Play();
		}

		// Token: 0x06029C2D RID: 171053 RVA: 0x00BCBCF0 File Offset: 0x00BC9EF0
		public void Play()
		{
			if (this.TextComponent == null || this.TextScrollView == null)
			{
				return;
			}
			if (this.IsPlaying)
			{
				return;
			}
			float y = this.TextComponent.GetRealSize().Y;
			float height = this.TextScrollView.GetRootComponent().GetHeight();
			if (y <= height)
			{
				return;
			}
			float num = this.DelayCharNum;
			int displayCharLength = this.TextComponent.GetDisplayCharLength();
			if ((float)displayCharLength <= this.DelayCharNum)
			{
				num = (float)this.TextComponent.GetRenderLineCharNum(0);
			}
			num = Math.Min(num, (float)Math.Max(displayCharLength - 1, 1));
			float interval = Math.Max(num / this.CharReadSpeed * 1000f, 20f);
			float num2 = (float)displayCharLength - num;
			int renderLineNum = this.TextComponent.GetRenderLineNum();
			float val = num2;
			if (renderLineNum > 1)
			{
				val = num2 - (float)this.TextComponent.GetRenderLineCharNum(0);
			}
			this.ScrollDuration = Math.Max(val, 1f) / this.CharReadSpeed * 1000f;
			this.DelayTextScrollAnimTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.StartAutoScrollAnim), interval, null, null, true, this.PlayRate);
			if (this.IsPaused && this.DelayTextScrollAnimTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Pause(this.DelayTextScrollAnimTimer, null);
			}
			this.IsPlaying = true;
		}

		// Token: 0x06029C2E RID: 171054 RVA: 0x00BCBE29 File Offset: 0x00BCA029
		public void Stop()
		{
			if (this.IsWaitingNextFrame)
			{
				this.IsWaitingNextFrame = false;
				this.IsJumpToEndPending = false;
				this.RemoveNextFrameTimer();
				return;
			}
			if (!this.IsPlaying)
			{
				return;
			}
			this.Reset();
		}

		// Token: 0x06029C2F RID: 171055 RVA: 0x00BCBE58 File Offset: 0x00BCA058
		public void Pause()
		{
			if (this.IsPaused)
			{
				return;
			}
			this.IsPaused = true;
			if (!this.IsPlaying)
			{
				return;
			}
			if (this.IsScrolling && this.ScrollTextAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.ScrollTextAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Pause(this.ScrollTextAnimTimer, null);
				return;
			}
			if (this.DelayTextScrollAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.DelayTextScrollAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Pause(this.DelayTextScrollAnimTimer, null);
			}
		}

		// Token: 0x06029C30 RID: 171056 RVA: 0x00BCBEE0 File Offset: 0x00BCA0E0
		public void Resume()
		{
			if (!this.IsPaused)
			{
				return;
			}
			this.IsPaused = false;
			if (!this.IsPlaying)
			{
				return;
			}
			if (this.IsScrolling && this.ScrollTextAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.ScrollTextAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Resume(this.ScrollTextAnimTimer);
				return;
			}
			if (this.DelayTextScrollAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.DelayTextScrollAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Resume(this.DelayTextScrollAnimTimer);
			}
		}

		// Token: 0x06029C31 RID: 171057 RVA: 0x00BCBF65 File Offset: 0x00BCA165
		public void JumpToEnd()
		{
			if (this.IsWaitingNextFrame)
			{
				this.IsJumpToEndPending = true;
				return;
			}
			this.Stop();
			UUIScrollViewComponent textScrollView = this.TextScrollView;
			if (textScrollView == null)
			{
				return;
			}
			textScrollView.SetScrollProgress(1f);
		}

		// Token: 0x06029C32 RID: 171058 RVA: 0x00BCBF94 File Offset: 0x00BCA194
		public void Clear()
		{
			this.Reset();
			this.IsPaused = false;
			if (this.OnClickDelegate != null)
			{
				UUIScrollViewComponent textScrollView = this.TextScrollView;
				if (textScrollView != null)
				{
					textScrollView.OnPointerBeginDragCallBack.Unbind();
				}
				UUIScrollViewComponent textScrollView2 = this.TextScrollView;
				if (textScrollView2 != null)
				{
					textScrollView2.OnScrollViewDownUpCallback.Unbind();
				}
				this.OnClickDelegate = null;
			}
		}

		// Token: 0x06029C33 RID: 171059 RVA: 0x00BCBFE9 File Offset: 0x00BCA1E9
		private bool OnManualDragBegin(ULGUIPointerEventData eventData)
		{
			this.IsManualDragging = true;
			this.Stop();
			return true;
		}

		// Token: 0x06029C34 RID: 171060 RVA: 0x00BCBFF9 File Offset: 0x00BCA1F9
		private void OnManualPointerUp(ULGUIPointerEventData eventData)
		{
			if (this.IsManualDragging)
			{
				this.IsManualDragging = false;
				return;
			}
			Action onClickDelegate = this.OnClickDelegate;
			if (onClickDelegate == null)
			{
				return;
			}
			onClickDelegate();
		}

		// Token: 0x06029C35 RID: 171061 RVA: 0x00BCC01C File Offset: 0x00BCA21C
		private void StartAutoScrollAnim(float handle)
		{
			if (this.TextComponent == null || this.TextScrollView == null)
			{
				return;
			}
			this.ScrollElapsedTime = 0f;
			this.ScrollTextAnimTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnScrollAnimUpdate), 100f, 1f, null, null, true);
			this.IsScrolling = true;
		}

		// Token: 0x06029C36 RID: 171062 RVA: 0x00BCC078 File Offset: 0x00BCA278
		private void OnScrollAnimUpdate(float delta)
		{
			float num = this.ScrollElapsedTime / this.ScrollDuration;
			UUIScrollViewComponent textScrollView = this.TextScrollView;
			if (textScrollView != null)
			{
				textScrollView.SetScrollProgress(num);
			}
			if (num >= 1f)
			{
				this.OnScrollComplete();
				return;
			}
			this.ScrollElapsedTime += delta * this.PlayRate;
		}

		// Token: 0x06029C37 RID: 171063 RVA: 0x00BCC0C9 File Offset: 0x00BCA2C9
		private void OnScrollComplete()
		{
			if (!this.IsScrolling)
			{
				return;
			}
			this.Reset();
			Action onScrollCompleteDelegate = this.OnScrollCompleteDelegate;
			if (onScrollCompleteDelegate == null)
			{
				return;
			}
			onScrollCompleteDelegate();
		}

		// Token: 0x06029C38 RID: 171064 RVA: 0x00BCC0EA File Offset: 0x00BCA2EA
		private void Reset()
		{
			this.IsWaitingNextFrame = false;
			this.IsJumpToEndPending = false;
			this.IsScrolling = false;
			this.IsPlaying = false;
			this.ScrollElapsedTime = 0f;
			this.RemoveScrollAnimTimer();
			this.RemoveDelayScrollAnimTimer();
			this.RemoveNextFrameTimer();
		}

		// Token: 0x06029C39 RID: 171065 RVA: 0x00BCC125 File Offset: 0x00BCA325
		private void RemoveNextFrameTimer()
		{
			if (this.NextFrameTimer != null && TimerSystem.GameplayTimeInstance.Has(this.NextFrameTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.NextFrameTimer);
			}
			this.NextFrameTimer = null;
		}

		// Token: 0x06029C3A RID: 171066 RVA: 0x00BCC159 File Offset: 0x00BCA359
		private void RemoveScrollAnimTimer()
		{
			if (this.ScrollTextAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.ScrollTextAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ScrollTextAnimTimer);
			}
			this.ScrollTextAnimTimer = null;
		}

		// Token: 0x06029C3B RID: 171067 RVA: 0x00BCC18D File Offset: 0x00BCA38D
		private void RemoveDelayScrollAnimTimer()
		{
			if (this.DelayTextScrollAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.DelayTextScrollAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTextScrollAnimTimer);
			}
			this.DelayTextScrollAnimTimer = null;
		}

		// Token: 0x06029C3C RID: 171068 RVA: 0x00BCC1C1 File Offset: 0x00BCA3C1
		public float GetTextWriterAnimDuration()
		{
			return this.ScrollDuration;
		}

		// Token: 0x06029C3D RID: 171069 RVA: 0x00BCC1C9 File Offset: 0x00BCA3C9
		public UUIText GetTextComponent()
		{
			return this.TextComponent;
		}

		// Token: 0x06029C3E RID: 171070 RVA: 0x00BCC1D1 File Offset: 0x00BCA3D1
		public UUIScrollViewComponent GetTextScrollView()
		{
			return this.TextScrollView;
		}

		// Token: 0x06029C3F RID: 171071 RVA: 0x00BCC1D9 File Offset: 0x00BCA3D9
		public bool GetIsPlaying()
		{
			return this.IsPlaying;
		}

		// Token: 0x06029C40 RID: 171072 RVA: 0x00BCC1E1 File Offset: 0x00BCA3E1
		public bool GetIsPaused()
		{
			return this.IsPaused;
		}

		// Token: 0x04016C78 RID: 93304
		private UUIText TextComponent;

		// Token: 0x04016C79 RID: 93305
		private UUIScrollViewComponent TextScrollView;

		// Token: 0x04016C7A RID: 93306
		private float DelayCharNum;

		// Token: 0x04016C7B RID: 93307
		private float CharReadSpeed;

		// Token: 0x04016C7C RID: 93308
		private float ScrollDuration;

		// Token: 0x04016C7D RID: 93309
		private float ScrollElapsedTime;

		// Token: 0x04016C7E RID: 93310
		private float PlayRate = 1f;

		// Token: 0x04016C7F RID: 93311
		private bool IsPlaying;

		// Token: 0x04016C80 RID: 93312
		private bool IsPaused;

		// Token: 0x04016C81 RID: 93313
		private bool IsScrolling;

		// Token: 0x04016C82 RID: 93314
		private bool IsWaitingNextFrame;

		// Token: 0x04016C83 RID: 93315
		private bool IsJumpToEndPending;

		// Token: 0x04016C84 RID: 93316
		private bool IsManualDragging;

		// Token: 0x04016C85 RID: 93317
		private TimerHandle NextFrameTimer;

		// Token: 0x04016C86 RID: 93318
		private TimerHandle DelayTextScrollAnimTimer;

		// Token: 0x04016C87 RID: 93319
		private TimerHandle ScrollTextAnimTimer;

		// Token: 0x04016C88 RID: 93320
		private readonly Action OnScrollCompleteDelegate;

		// Token: 0x04016C89 RID: 93321
		private Action OnClickDelegate;
	}
}
