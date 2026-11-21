using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037A1 RID: 14241
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class VisualNovelCgMotion
	{
		// Token: 0x17004BF1 RID: 19441
		// (get) Token: 0x060250A6 RID: 151718 RVA: 0x00A75E01 File Offset: 0x00A74001
		public VisualNovelTransform Transform
		{
			get
			{
				if (this.CgItem != null)
				{
					return new VisualNovelTransform(this.CgItem.GetAnchorOffsetX(), this.CgItem.GetAnchorOffsetY(), this.CurrentScale);
				}
				return new VisualNovelTransform(0f, 0f, 1f);
			}
		}

		// Token: 0x060250A7 RID: 151719 RVA: 0x00A75E41 File Offset: 0x00A74041
		public void SetItem(UUIItem cgItem)
		{
			this.ClearItem();
			if (cgItem == null)
			{
				return;
			}
			this.CgItem = cgItem;
			this.OriginTransform = new VisualNovelTransform(cgItem.GetAnchorOffsetX(), cgItem.GetAnchorOffsetY(), 1f);
			this.CurrentScale = this.OriginTransform.Scale;
		}

		// Token: 0x060250A8 RID: 151720 RVA: 0x00A75E84 File Offset: 0x00A74084
		public UniTask MoveAsync(VisualNovelCgMoveParameters parameters)
		{
			VisualNovelCgMotion.<MoveAsync>d__12 <MoveAsync>d__;
			<MoveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MoveAsync>d__.<>4__this = this;
			<MoveAsync>d__.parameters = parameters;
			<MoveAsync>d__.<>1__state = -1;
			<MoveAsync>d__.<>t__builder.Start<VisualNovelCgMotion.<MoveAsync>d__12>(ref <MoveAsync>d__);
			return <MoveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060250A9 RID: 151721 RVA: 0x00A75ECF File Offset: 0x00A740CF
		public void SetTransformImmediately(VisualNovelTransform transform)
		{
			this.StopMove();
			if (this.CgItem != null)
			{
				this.ApplyTransform(transform);
			}
		}

		// Token: 0x060250AA RID: 151722 RVA: 0x00A75EE6 File Offset: 0x00A740E6
		public void SetPlaybackRate(float playbackRate)
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

		// Token: 0x060250AB RID: 151723 RVA: 0x00A75F10 File Offset: 0x00A74110
		public void SetPaused(bool paused)
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

		// Token: 0x060250AC RID: 151724 RVA: 0x00A75F55 File Offset: 0x00A74155
		public void ClearItem()
		{
			this.StopMove();
			if (this.CgItem != null)
			{
				this.ApplyTransform(this.OriginTransform);
			}
			this.CgItem = null;
		}

		// Token: 0x060250AD RID: 151725 RVA: 0x00A75F78 File Offset: 0x00A74178
		private void ApplyLerp(VisualNovelTransform start, VisualNovelTransform target, float progress)
		{
			float x = MathUtils.Instance.Lerp(start.X, target.X, progress);
			float y = MathUtils.Instance.Lerp(start.Y, target.Y, progress);
			float scale = MathUtils.Instance.Lerp(start.Scale, target.Scale, progress);
			this.ApplyTransform(x, y, scale);
		}

		// Token: 0x060250AE RID: 151726 RVA: 0x00A75FDC File Offset: 0x00A741DC
		private void ApplyTransform(VisualNovelTransform transform)
		{
			this.ApplyTransform(transform.X, transform.Y, transform.Scale);
		}

		// Token: 0x060250AF RID: 151727 RVA: 0x00A75FFC File Offset: 0x00A741FC
		private void ApplyTransform(float x, float y, float scale)
		{
			UUIItem cgItem = this.CgItem;
			if (cgItem == null)
			{
				return;
			}
			cgItem.SetAnchorOffsetX(x);
			cgItem.SetAnchorOffsetY(y);
			this.CurrentScale = scale;
			this.TempScale.X = scale;
			this.TempScale.Y = scale;
			cgItem.SetUIItemScale(this.TempScale);
		}

		// Token: 0x060250B0 RID: 151728 RVA: 0x00A76050 File Offset: 0x00A74250
		[NullableContext(1)]
		private UniTask PlayTweenAsync(float start, float end, float duration, Action<float> update, LTweenEase ease, [Nullable(2)] UCurveFloat curve)
		{
			VisualNovelCgMotion.<PlayTweenAsync>d__20 <PlayTweenAsync>d__;
			<PlayTweenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayTweenAsync>d__.<>4__this = this;
			<PlayTweenAsync>d__.start = start;
			<PlayTweenAsync>d__.end = end;
			<PlayTweenAsync>d__.duration = duration;
			<PlayTweenAsync>d__.update = update;
			<PlayTweenAsync>d__.ease = ease;
			<PlayTweenAsync>d__.curve = curve;
			<PlayTweenAsync>d__.<>1__state = -1;
			<PlayTweenAsync>d__.<>t__builder.Start<VisualNovelCgMotion.<PlayTweenAsync>d__20>(ref <PlayTweenAsync>d__);
			return <PlayTweenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060250B1 RID: 151729 RVA: 0x00A760C8 File Offset: 0x00A742C8
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

		// Token: 0x060250B2 RID: 151730 RVA: 0x00A76105 File Offset: 0x00A74305
		private void StopMove()
		{
			this.MoveVersion++;
			this.StopMoveTween();
		}

		// Token: 0x040147D2 RID: 83922
		private FVector TempScale = new FVector(1f, 1f, 1f);

		// Token: 0x040147D3 RID: 83923
		private UUIItem CgItem;

		// Token: 0x040147D4 RID: 83924
		private VisualNovelTransform OriginTransform;

		// Token: 0x040147D5 RID: 83925
		private LguiFloatTween MoveTween;

		// Token: 0x040147D6 RID: 83926
		private UniTaskCompletionSource MovePromise;

		// Token: 0x040147D7 RID: 83927
		private float CurrentScale = 1f;

		// Token: 0x040147D8 RID: 83928
		private float PlaybackRate = 1f;

		// Token: 0x040147D9 RID: 83929
		private bool IsPaused;

		// Token: 0x040147DA RID: 83930
		private int MoveVersion;
	}
}
