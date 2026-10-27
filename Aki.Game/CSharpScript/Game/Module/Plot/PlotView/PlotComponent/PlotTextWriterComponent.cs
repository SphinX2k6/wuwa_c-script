using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200508E RID: 20622
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTextWriterComponent
	{
		// Token: 0x06034D49 RID: 216393 RVA: 0x00C7EC4C File Offset: 0x00C7CE4C
		[NullableContext(1)]
		public void Init(PlotTextWriterComponentContext context)
		{
			this.TextAnimComp = context.TextAnimComp;
			this.TweenComp = context.TweenComp;
			this.TextComponent = context.TextComponent;
			this.OnAnimCompleteDelegate = context.OnAnimCompleteDelegate;
			this.OnStopDelegate = context.OnStopDelegate;
			ULGUIPlayTweenComponent tweenComp = this.TweenComp;
			if (tweenComp == null)
			{
				return;
			}
			ULGUIPlayTween playTween = tweenComp.GetPlayTween();
			if (playTween == null)
			{
				return;
			}
			ULTweener tweener = playTween.GetTweener();
			if (tweener == null)
			{
				return;
			}
			tweener.OnCompleteCallBack.Bind(new Action(this.OnTweenComplete));
		}

		// Token: 0x06034D4A RID: 216394 RVA: 0x00C7ECCC File Offset: 0x00C7CECC
		public void SetPlayDuration(float duration)
		{
			ULGUIPlayTweenComponent tweenComp = this.TweenComp;
			ULGUIPlayTween ulguiplayTween = (tweenComp != null) ? tweenComp.GetPlayTween() : null;
			if (ulguiplayTween == null)
			{
				return;
			}
			ulguiplayTween.duration = duration;
		}

		// Token: 0x06034D4B RID: 216395 RVA: 0x00C7ECF7 File Offset: 0x00C7CEF7
		public void Play()
		{
			UUIEffectTextAnimation textAnimComp = this.TextAnimComp;
			if (textAnimComp != null)
			{
				textAnimComp.SetSelectorOffset(1f);
			}
			ULGUIPlayTweenComponent tweenComp = this.TweenComp;
			if (tweenComp != null)
			{
				tweenComp.Play();
			}
			this.BindOnTweenComplete();
			this.IsPlaying = true;
		}

		// Token: 0x06034D4C RID: 216396 RVA: 0x00C7ED2D File Offset: 0x00C7CF2D
		public void Stop()
		{
			if (!this.IsPlaying)
			{
				return;
			}
			this.UnbindOnTweenComplete();
			ULGUIPlayTweenComponent tweenComp = this.TweenComp;
			if (tweenComp != null)
			{
				tweenComp.Stop();
			}
			this.IsPlaying = false;
			this.IsPaused = false;
			Action onStopDelegate = this.OnStopDelegate;
			if (onStopDelegate == null)
			{
				return;
			}
			onStopDelegate();
		}

		// Token: 0x06034D4D RID: 216397 RVA: 0x00C7ED6D File Offset: 0x00C7CF6D
		public void Pause()
		{
			if (this.IsPaused)
			{
				return;
			}
			if (!this.IsPlaying)
			{
				return;
			}
			ULGUIPlayTweenComponent tweenComp = this.TweenComp;
			if (tweenComp != null)
			{
				tweenComp.Pause();
			}
			this.IsPaused = true;
		}

		// Token: 0x06034D4E RID: 216398 RVA: 0x00C7ED99 File Offset: 0x00C7CF99
		public void Resume()
		{
			if (!this.IsPaused)
			{
				return;
			}
			this.IsPaused = false;
			ULGUIPlayTweenComponent tweenComp = this.TweenComp;
			if (tweenComp == null)
			{
				return;
			}
			tweenComp.Resume();
		}

		// Token: 0x06034D4F RID: 216399 RVA: 0x00C7EDBB File Offset: 0x00C7CFBB
		public void JumpToEnd()
		{
			this.Stop();
			UUIEffectTextAnimation textAnimComp = this.TextAnimComp;
			if (textAnimComp == null)
			{
				return;
			}
			textAnimComp.SetSelectorOffset(0f);
		}

		// Token: 0x06034D50 RID: 216400 RVA: 0x00C7EDD8 File Offset: 0x00C7CFD8
		public void Clear()
		{
			this.UnbindOnTweenComplete();
			this.TextAnimComp = null;
			this.TweenComp = null;
		}

		// Token: 0x06034D51 RID: 216401 RVA: 0x00C7EDEE File Offset: 0x00C7CFEE
		private void BindOnTweenComplete()
		{
			ULGUIPlayTweenComponent tweenComp = this.TweenComp;
			if (tweenComp == null)
			{
				return;
			}
			ULGUIPlayTween playTween = tweenComp.GetPlayTween();
			if (playTween == null)
			{
				return;
			}
			ULTweener tweener = playTween.GetTweener();
			if (tweener == null)
			{
				return;
			}
			tweener.OnCompleteCallBack.Bind(new Action(this.OnTweenComplete));
		}

		// Token: 0x06034D52 RID: 216402 RVA: 0x00C7EE25 File Offset: 0x00C7D025
		private void UnbindOnTweenComplete()
		{
			ULGUIPlayTweenComponent tweenComp = this.TweenComp;
			if (tweenComp == null)
			{
				return;
			}
			ULGUIPlayTween playTween = tweenComp.GetPlayTween();
			if (playTween == null)
			{
				return;
			}
			ULTweener tweener = playTween.GetTweener();
			if (tweener == null)
			{
				return;
			}
			tweener.OnCompleteCallBack.Unbind();
		}

		// Token: 0x06034D53 RID: 216403 RVA: 0x00C7EE50 File Offset: 0x00C7D050
		protected void OnTextWriterAnimComplete()
		{
			this.IsPlaying = false;
			this.IsPaused = false;
			this.UnbindOnTweenComplete();
			Action onAnimCompleteDelegate = this.OnAnimCompleteDelegate;
			if (onAnimCompleteDelegate == null)
			{
				return;
			}
			onAnimCompleteDelegate();
		}

		// Token: 0x06034D54 RID: 216404 RVA: 0x00C7EE76 File Offset: 0x00C7D076
		protected void OnTweenComplete()
		{
			this.OnTextWriterAnimComplete();
		}

		// Token: 0x06034D55 RID: 216405 RVA: 0x00C7EE7E File Offset: 0x00C7D07E
		public ULGUIPlayTweenComponent GetTweenComponent()
		{
			return this.TweenComp;
		}

		// Token: 0x06034D56 RID: 216406 RVA: 0x00C7EE86 File Offset: 0x00C7D086
		public UUIText GetTextComponent()
		{
			return this.TextComponent;
		}

		// Token: 0x06034D57 RID: 216407 RVA: 0x00C7EE8E File Offset: 0x00C7D08E
		public UUIEffectTextAnimation GetTextAnimComponent()
		{
			return this.TextAnimComp;
		}

		// Token: 0x06034D58 RID: 216408 RVA: 0x00C7EE96 File Offset: 0x00C7D096
		public bool GetIsPlaying()
		{
			return this.IsPlaying;
		}

		// Token: 0x06034D59 RID: 216409 RVA: 0x00C7EE9E File Offset: 0x00C7D09E
		public bool GetIsPaused()
		{
			return this.IsPaused;
		}

		// Token: 0x0401C25B RID: 115291
		private UUIText TextComponent;

		// Token: 0x0401C25C RID: 115292
		private UUIEffectTextAnimation TextAnimComp;

		// Token: 0x0401C25D RID: 115293
		private ULGUIPlayTweenComponent TweenComp;

		// Token: 0x0401C25E RID: 115294
		private bool IsPlaying;

		// Token: 0x0401C25F RID: 115295
		private bool IsPaused;

		// Token: 0x0401C260 RID: 115296
		private Action OnAnimCompleteDelegate;

		// Token: 0x0401C261 RID: 115297
		private Action OnStopDelegate;
	}
}
