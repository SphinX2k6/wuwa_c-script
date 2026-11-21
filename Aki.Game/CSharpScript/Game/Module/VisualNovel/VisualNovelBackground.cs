using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x0200379F RID: 14239
	[NullableContext(1)]
	[Nullable(0)]
	public class VisualNovelBackground
	{
		// Token: 0x17004BEE RID: 19438
		// (get) Token: 0x06025092 RID: 151698 RVA: 0x00A75AC3 File Offset: 0x00A73CC3
		public VisualNovelTransform Transform
		{
			get
			{
				return new VisualNovelTransform(this.BackgroundItem.GetAnchorOffsetX(), this.BackgroundItem.GetAnchorOffsetY(), this.CurrentScale);
			}
		}

		// Token: 0x06025093 RID: 151699 RVA: 0x00A75AE8 File Offset: 0x00A73CE8
		public VisualNovelBackground(UUIItem backgroundItem)
		{
			this.BackgroundItem = backgroundItem;
			this.OriginTransform = new VisualNovelTransform(backgroundItem.GetAnchorOffsetX(), backgroundItem.GetAnchorOffsetY(), 1f);
			this.CurrentScale = this.OriginTransform.Scale;
		}

		// Token: 0x06025094 RID: 151700 RVA: 0x00A75B54 File Offset: 0x00A73D54
		public UniTask MoveAsync(VisualNovelBackgroundMoveParameters parameters)
		{
			VisualNovelBackground.<MoveAsync>d__12 <MoveAsync>d__;
			<MoveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MoveAsync>d__.<>4__this = this;
			<MoveAsync>d__.parameters = parameters;
			<MoveAsync>d__.<>1__state = -1;
			<MoveAsync>d__.<>t__builder.Start<VisualNovelBackground.<MoveAsync>d__12>(ref <MoveAsync>d__);
			return <MoveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025095 RID: 151701 RVA: 0x00A75B9F File Offset: 0x00A73D9F
		public virtual UniTask ApplyAsync(int backgroundId)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06025096 RID: 151702 RVA: 0x00A75BA6 File Offset: 0x00A73DA6
		public virtual void FinishChange()
		{
		}

		// Token: 0x06025097 RID: 151703 RVA: 0x00A75BA8 File Offset: 0x00A73DA8
		public virtual void Destroy()
		{
			this.StopMove();
		}

		// Token: 0x06025098 RID: 151704 RVA: 0x00A75BB0 File Offset: 0x00A73DB0
		public virtual void Reset()
		{
			this.SetTransformImmediately(this.OriginTransform);
		}

		// Token: 0x06025099 RID: 151705 RVA: 0x00A75BBE File Offset: 0x00A73DBE
		public virtual void SetPlaybackRate(float playbackRate)
		{
			this.PlaybackRate = playbackRate;
			LguiFloatTween moveTween = this.MoveTween;
			if (moveTween == null)
			{
				return;
			}
			ULTweener tweener = moveTween.GetTweener();
			if (tweener == null)
			{
				return;
			}
			tweener.SetSpeed(this.PlaybackRate);
		}

		// Token: 0x0602509A RID: 151706 RVA: 0x00A75BE8 File Offset: 0x00A73DE8
		public virtual void SetPaused(bool paused)
		{
			if (this.IsPaused == paused)
			{
				return;
			}
			this.IsPaused = paused;
			LguiFloatTween moveTween = this.MoveTween;
			ULTweener ultweener = (moveTween != null) ? moveTween.GetTweener() : null;
			if (ultweener == null)
			{
				return;
			}
			if (paused)
			{
				ultweener.Pause();
				return;
			}
			ultweener.Resume();
		}

		// Token: 0x0602509B RID: 151707 RVA: 0x00A75C2D File Offset: 0x00A73E2D
		public void SetTransformImmediately(VisualNovelTransform transform)
		{
			this.StopMove();
			this.ApplyTransform(transform);
		}

		// Token: 0x0602509C RID: 151708 RVA: 0x00A75C3C File Offset: 0x00A73E3C
		private void ApplyLerp(VisualNovelTransform start, VisualNovelTransform target, float progress)
		{
			float x = MathUtils.Instance.Lerp(start.X, target.X, progress);
			float y = MathUtils.Instance.Lerp(start.Y, target.Y, progress);
			float scale = MathUtils.Instance.Lerp(start.Scale, target.Scale, progress);
			this.ApplyTransform(x, y, scale);
		}

		// Token: 0x0602509D RID: 151709 RVA: 0x00A75CA0 File Offset: 0x00A73EA0
		private void ApplyTransform(VisualNovelTransform transform)
		{
			this.ApplyTransform(transform.X, transform.Y, transform.Scale);
		}

		// Token: 0x0602509E RID: 151710 RVA: 0x00A75CBD File Offset: 0x00A73EBD
		private void ApplyTransform(float x, float y, float scale)
		{
			this.BackgroundItem.SetAnchorOffsetX(x);
			this.BackgroundItem.SetAnchorOffsetY(y);
			this.SetScale(scale);
		}

		// Token: 0x0602509F RID: 151711 RVA: 0x00A75CDE File Offset: 0x00A73EDE
		private void SetScale(float scale)
		{
			this.CurrentScale = scale;
			this.TempScale.X = scale;
			this.TempScale.Y = scale;
			this.BackgroundItem.SetUIItemScale(this.TempScale);
		}

		// Token: 0x060250A0 RID: 151712 RVA: 0x00A75D10 File Offset: 0x00A73F10
		private UniTask PlayTweenAsync(float start, float end, float duration, Action<float> update, LTweenEase ease, [Nullable(2)] UCurveFloat curve)
		{
			VisualNovelBackground.<PlayTweenAsync>d__24 <PlayTweenAsync>d__;
			<PlayTweenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayTweenAsync>d__.<>4__this = this;
			<PlayTweenAsync>d__.start = start;
			<PlayTweenAsync>d__.end = end;
			<PlayTweenAsync>d__.duration = duration;
			<PlayTweenAsync>d__.update = update;
			<PlayTweenAsync>d__.ease = ease;
			<PlayTweenAsync>d__.curve = curve;
			<PlayTweenAsync>d__.<>1__state = -1;
			<PlayTweenAsync>d__.<>t__builder.Start<VisualNovelBackground.<PlayTweenAsync>d__24>(ref <PlayTweenAsync>d__);
			return <PlayTweenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060250A1 RID: 151713 RVA: 0x00A75D88 File Offset: 0x00A73F88
		private void StopMoveTween()
		{
			LguiFloatTween moveTween = this.MoveTween;
			UniTaskCompletionSource movePromise = this.MovePromise;
			this.MoveTween = null;
			this.MovePromise = null;
			if (moveTween != null)
			{
				moveTween.KillTween();
			}
			if (movePromise != null)
			{
				movePromise.TrySetResult();
			}
		}

		// Token: 0x060250A2 RID: 151714 RVA: 0x00A75DC5 File Offset: 0x00A73FC5
		private void StopMove()
		{
			this.MoveVersion++;
			this.StopMoveTween();
		}

		// Token: 0x040147C7 RID: 83911
		private readonly UUIItem BackgroundItem;

		// Token: 0x040147C8 RID: 83912
		private readonly VisualNovelTransform OriginTransform;

		// Token: 0x040147C9 RID: 83913
		private FVector TempScale = new FVector(1f, 1f, 1f);

		// Token: 0x040147CA RID: 83914
		[Nullable(2)]
		private LguiFloatTween MoveTween;

		// Token: 0x040147CB RID: 83915
		[Nullable(2)]
		private UniTaskCompletionSource MovePromise;

		// Token: 0x040147CC RID: 83916
		private float CurrentScale;

		// Token: 0x040147CD RID: 83917
		private float PlaybackRate = 1f;

		// Token: 0x040147CE RID: 83918
		private bool IsPaused;

		// Token: 0x040147CF RID: 83919
		private int MoveVersion;
	}
}
