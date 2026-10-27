using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200508D RID: 20621
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTextScrollComponent
	{
		// Token: 0x06034D31 RID: 216369 RVA: 0x00C7E7C2 File Offset: 0x00C7C9C2
		[NullableContext(1)]
		public void Init(PlotTextScrollComponentContext context)
		{
			this.TextComponent = context.TextComponent;
			this.TextScrollView = context.TextScrollView;
		}

		// Token: 0x06034D32 RID: 216370 RVA: 0x00C7E7DC File Offset: 0x00C7C9DC
		public void SetCharReadSpeed(float readSpeed)
		{
			this.CharReadSpeed = readSpeed;
		}

		// Token: 0x06034D33 RID: 216371 RVA: 0x00C7E7E5 File Offset: 0x00C7C9E5
		public void SetDelayCharNum(float delayCharNum)
		{
			this.DelayCharNum = delayCharNum;
		}

		// Token: 0x06034D34 RID: 216372 RVA: 0x00C7E7EE File Offset: 0x00C7C9EE
		public void PlayNextFrame()
		{
			if (this.IsWaitingNextFrame)
			{
				return;
			}
			this.IsWaitingNextFrame = true;
			this.NextFrameTimer = TimerSystem.GameplayTimeInstance.Next(new TTimerAction(this.OnNextFramePlay), null, null);
		}

		// Token: 0x06034D35 RID: 216373 RVA: 0x00C7E81E File Offset: 0x00C7CA1E
		private void OnNextFramePlay(float handle)
		{
			this.IsWaitingNextFrame = false;
			this.RemoveNextFrameTimer();
			this.Play();
		}

		// Token: 0x06034D36 RID: 216374 RVA: 0x00C7E834 File Offset: 0x00C7CA34
		public void Play()
		{
			if (this.TextComponent == null || this.TextScrollView == null)
			{
				return;
			}
			if (this.IsPlaying || this.IsPaused)
			{
				return;
			}
			float y = this.TextComponent.GetTextRenderSize().Y;
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
			float interval = num / this.CharReadSpeed * 1000f;
			float num2 = (float)displayCharLength - num;
			int renderLineNum = this.TextComponent.GetRenderLineNum();
			float num3 = num2;
			if (renderLineNum > 1)
			{
				num3 = num2 - (float)this.TextComponent.GetRenderLineCharNum(0);
			}
			this.ScrollDuration = num3 / this.CharReadSpeed * 1000f;
			this.DelayTextScrollAnimTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.StartAutoScrollAnim), interval, null, null, true, 1f);
			this.IsPlaying = true;
		}

		// Token: 0x06034D37 RID: 216375 RVA: 0x00C7E928 File Offset: 0x00C7CB28
		public void Stop()
		{
			if (this.IsWaitingNextFrame)
			{
				this.IsWaitingNextFrame = false;
				this.RemoveNextFrameTimer();
				return;
			}
			if (!this.IsPlaying)
			{
				return;
			}
			this.Reset();
		}

		// Token: 0x06034D38 RID: 216376 RVA: 0x00C7E950 File Offset: 0x00C7CB50
		public void Pause()
		{
			if (!this.IsPlaying)
			{
				return;
			}
			if (this.IsScrolling && this.ScrollTextAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.ScrollTextAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Pause(this.ScrollTextAnimTimer, null);
			}
			else if (this.DelayTextScrollAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.DelayTextScrollAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Pause(this.DelayTextScrollAnimTimer, null);
			}
			this.IsPaused = true;
		}

		// Token: 0x06034D39 RID: 216377 RVA: 0x00C7E9D0 File Offset: 0x00C7CBD0
		public void Resume()
		{
			if (!this.IsPlaying || !this.IsPaused)
			{
				return;
			}
			if (this.IsScrolling && this.ScrollTextAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.ScrollTextAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Resume(this.ScrollTextAnimTimer);
			}
			else if (this.DelayTextScrollAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.DelayTextScrollAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Resume(this.DelayTextScrollAnimTimer);
			}
			this.IsPaused = false;
		}

		// Token: 0x06034D3A RID: 216378 RVA: 0x00C7EA55 File Offset: 0x00C7CC55
		public void JumpToEnd()
		{
			this.Stop();
			UUIScrollViewComponent textScrollView = this.TextScrollView;
			if (textScrollView == null)
			{
				return;
			}
			textScrollView.SetScrollProgress(1f);
		}

		// Token: 0x06034D3B RID: 216379 RVA: 0x00C7EA72 File Offset: 0x00C7CC72
		public void Clear()
		{
			this.Reset();
		}

		// Token: 0x06034D3C RID: 216380 RVA: 0x00C7EA7C File Offset: 0x00C7CC7C
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

		// Token: 0x06034D3D RID: 216381 RVA: 0x00C7EAD8 File Offset: 0x00C7CCD8
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
			this.ScrollElapsedTime += delta;
		}

		// Token: 0x06034D3E RID: 216382 RVA: 0x00C7EB22 File Offset: 0x00C7CD22
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

		// Token: 0x06034D3F RID: 216383 RVA: 0x00C7EB43 File Offset: 0x00C7CD43
		private void Reset()
		{
			this.IsWaitingNextFrame = false;
			this.IsScrolling = false;
			this.IsPlaying = false;
			this.IsPaused = false;
			this.ScrollElapsedTime = 0f;
			this.RemoveScrollAnimTimer();
			this.RemoveDelayScrollAnimTimer();
			this.RemoveNextFrameTimer();
		}

		// Token: 0x06034D40 RID: 216384 RVA: 0x00C7EB7E File Offset: 0x00C7CD7E
		private void RemoveNextFrameTimer()
		{
			if (this.NextFrameTimer != null && TimerSystem.GameplayTimeInstance.Has(this.NextFrameTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.NextFrameTimer);
			}
			this.NextFrameTimer = null;
		}

		// Token: 0x06034D41 RID: 216385 RVA: 0x00C7EBB2 File Offset: 0x00C7CDB2
		private void RemoveScrollAnimTimer()
		{
			if (this.ScrollTextAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.ScrollTextAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ScrollTextAnimTimer);
			}
			this.ScrollTextAnimTimer = null;
		}

		// Token: 0x06034D42 RID: 216386 RVA: 0x00C7EBE6 File Offset: 0x00C7CDE6
		private void RemoveDelayScrollAnimTimer()
		{
			if (this.DelayTextScrollAnimTimer != null && TimerSystem.GameplayTimeInstance.Has(this.DelayTextScrollAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTextScrollAnimTimer);
			}
			this.DelayTextScrollAnimTimer = null;
		}

		// Token: 0x06034D43 RID: 216387 RVA: 0x00C7EC1A File Offset: 0x00C7CE1A
		public float GetTextWriterAnimDuration()
		{
			return this.ScrollDuration;
		}

		// Token: 0x06034D44 RID: 216388 RVA: 0x00C7EC22 File Offset: 0x00C7CE22
		public UUIText GetTextComponent()
		{
			return this.TextComponent;
		}

		// Token: 0x06034D45 RID: 216389 RVA: 0x00C7EC2A File Offset: 0x00C7CE2A
		public UUIScrollViewComponent GetTextScrollView()
		{
			return this.TextScrollView;
		}

		// Token: 0x06034D46 RID: 216390 RVA: 0x00C7EC32 File Offset: 0x00C7CE32
		public bool GetIsPlaying()
		{
			return this.IsPlaying;
		}

		// Token: 0x06034D47 RID: 216391 RVA: 0x00C7EC3A File Offset: 0x00C7CE3A
		public bool GetIsPaused()
		{
			return this.IsPaused;
		}

		// Token: 0x0401C24D RID: 115277
		private UUIText TextComponent;

		// Token: 0x0401C24E RID: 115278
		private UUIScrollViewComponent TextScrollView;

		// Token: 0x0401C24F RID: 115279
		private float DelayCharNum;

		// Token: 0x0401C250 RID: 115280
		private float CharReadSpeed;

		// Token: 0x0401C251 RID: 115281
		private float ScrollDuration;

		// Token: 0x0401C252 RID: 115282
		private float ScrollElapsedTime;

		// Token: 0x0401C253 RID: 115283
		private bool IsPlaying;

		// Token: 0x0401C254 RID: 115284
		private bool IsPaused;

		// Token: 0x0401C255 RID: 115285
		private bool IsScrolling;

		// Token: 0x0401C256 RID: 115286
		private bool IsWaitingNextFrame;

		// Token: 0x0401C257 RID: 115287
		private TimerHandle NextFrameTimer;

		// Token: 0x0401C258 RID: 115288
		private TimerHandle DelayTextScrollAnimTimer;

		// Token: 0x0401C259 RID: 115289
		private TimerHandle ScrollTextAnimTimer;

		// Token: 0x0401C25A RID: 115290
		private readonly Action OnScrollCompleteDelegate;
	}
}
