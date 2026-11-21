using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200405E RID: 16478
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTextWriterComponent
	{
		// Token: 0x06029C42 RID: 171074 RVA: 0x00BCC1FC File Offset: 0x00BCA3FC
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

		// Token: 0x06029C43 RID: 171075 RVA: 0x00BCC27C File Offset: 0x00BCA47C
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

		// Token: 0x06029C44 RID: 171076 RVA: 0x00BCC2A7 File Offset: 0x00BCA4A7
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

		// Token: 0x06029C45 RID: 171077 RVA: 0x00BCC2DD File Offset: 0x00BCA4DD
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

		// Token: 0x06029C46 RID: 171078 RVA: 0x00BCC31D File Offset: 0x00BCA51D
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

		// Token: 0x06029C47 RID: 171079 RVA: 0x00BCC349 File Offset: 0x00BCA549
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

		// Token: 0x06029C48 RID: 171080 RVA: 0x00BCC36B File Offset: 0x00BCA56B
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

		// Token: 0x06029C49 RID: 171081 RVA: 0x00BCC388 File Offset: 0x00BCA588
		public void Clear()
		{
			this.UnbindOnTweenComplete();
			this.TextAnimComp = null;
			this.TweenComp = null;
		}

		// Token: 0x06029C4A RID: 171082 RVA: 0x00BCC39E File Offset: 0x00BCA59E
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

		// Token: 0x06029C4B RID: 171083 RVA: 0x00BCC3D5 File Offset: 0x00BCA5D5
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

		// Token: 0x06029C4C RID: 171084 RVA: 0x00BCC400 File Offset: 0x00BCA600
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

		// Token: 0x06029C4D RID: 171085 RVA: 0x00BCC426 File Offset: 0x00BCA626
		protected void OnTweenComplete()
		{
			this.OnTextWriterAnimComplete();
		}

		// Token: 0x06029C4E RID: 171086 RVA: 0x00BCC42E File Offset: 0x00BCA62E
		public ULGUIPlayTweenComponent GetTweenComponent()
		{
			return this.TweenComp;
		}

		// Token: 0x06029C4F RID: 171087 RVA: 0x00BCC436 File Offset: 0x00BCA636
		public UUIText GetTextComponent()
		{
			return this.TextComponent;
		}

		// Token: 0x06029C50 RID: 171088 RVA: 0x00BCC43E File Offset: 0x00BCA63E
		public UUIEffectTextAnimation GetTextAnimComponent()
		{
			return this.TextAnimComp;
		}

		// Token: 0x06029C51 RID: 171089 RVA: 0x00BCC446 File Offset: 0x00BCA646
		public bool GetIsPlaying()
		{
			return this.IsPlaying;
		}

		// Token: 0x06029C52 RID: 171090 RVA: 0x00BCC44E File Offset: 0x00BCA64E
		public bool GetIsPaused()
		{
			return this.IsPaused;
		}

		// Token: 0x04016C8A RID: 93322
		private UUIText TextComponent;

		// Token: 0x04016C8B RID: 93323
		private UUIEffectTextAnimation TextAnimComp;

		// Token: 0x04016C8C RID: 93324
		private ULGUIPlayTweenComponent TweenComp;

		// Token: 0x04016C8D RID: 93325
		private bool IsPlaying;

		// Token: 0x04016C8E RID: 93326
		private bool IsPaused;

		// Token: 0x04016C8F RID: 93327
		private Action OnAnimCompleteDelegate;

		// Token: 0x04016C90 RID: 93328
		private Action OnStopDelegate;
	}
}
