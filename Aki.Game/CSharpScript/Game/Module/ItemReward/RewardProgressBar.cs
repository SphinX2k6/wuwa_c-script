using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047E5 RID: 18405
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardProgressBar : UiPanelBase
	{
		// Token: 0x0602E3D3 RID: 189395 RVA: 0x00CE58D7 File Offset: 0x00CE3AD7
		public RewardProgressBar(AActor rootActor)
		{
			base.CreateThenShowByActor(rootActor, null);
		}

		// Token: 0x0602E3D4 RID: 189396 RVA: 0x00CE58F4 File Offset: 0x00CE3AF4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0602E3D5 RID: 189397 RVA: 0x00CE5989 File Offset: 0x00CE3B89
		public void Clear()
		{
			this.AnimationRemainingTime = new float?(0f);
			this.ProgressBarAnimationQueue.Clear();
		}

		// Token: 0x0602E3D6 RID: 189398 RVA: 0x00CE59A8 File Offset: 0x00CE3BA8
		public void Refresh(string titleTextId, List<IRewardProgress> progressQueue, float progressAnimationLength = 500f)
		{
			this.SetTitleText(titleTextId);
			if (progressQueue == null || progressQueue.Count == 0)
			{
				return;
			}
			if (progressAnimationLength > 0f)
			{
				this.PlayProgressAnimation(progressQueue, progressAnimationLength);
				return;
			}
			IRewardProgress rewardProgress = progressQueue[progressQueue.Count - 1];
			if (rewardProgress == null)
			{
				return;
			}
			int toProgress = rewardProgress.ToProgress;
			int maxProgress = rewardProgress.MaxProgress;
			this.SetProgressText((float)toProgress, (float)maxProgress);
			this.SetProgressBarPercent((float)toProgress, (float)maxProgress);
		}

		// Token: 0x0602E3D7 RID: 189399 RVA: 0x00CE5A10 File Offset: 0x00CE3C10
		public void PlayProgressAnimation(List<IRewardProgress> progressBarAnimationQueue, float progressAnimationLength = 500f)
		{
			this.ProgressBarAnimationQueue = progressBarAnimationQueue;
			IRewardProgress rewardProgress = (this.ProgressBarAnimationQueue.Count > 0) ? this.ProgressBarAnimationQueue[0] : null;
			if (rewardProgress != null)
			{
				this.ProgressBarAnimationQueue.RemoveAt(0);
			}
			if (rewardProgress == null)
			{
				return;
			}
			int fromProgress = rewardProgress.FromProgress;
			int toProgress = rewardProgress.ToProgress;
			int maxProgress = rewardProgress.MaxProgress;
			this.SetProgressText((float)fromProgress, (float)maxProgress);
			this.SetProgressBarPercent((float)fromProgress, (float)maxProgress);
			this.PlayProgressTo((float)fromProgress, (float)toProgress, (float)maxProgress, progressAnimationLength);
		}

		// Token: 0x0602E3D8 RID: 189400 RVA: 0x00CE5A8C File Offset: 0x00CE3C8C
		private void PlayProgressTo(float fromProgress, float toProgress, float maxProgress, float animationLength)
		{
			if (maxProgress < toProgress)
			{
				this.SetProgressText(toProgress, maxProgress);
				this.OnProgressBarFinished();
				this.SetProgressBarPercent(toProgress, maxProgress);
				return;
			}
			this.AnimationLength = animationLength;
			this.AnimationRemainingTime = new float?(animationLength);
			this.AnimationFromProgress = fromProgress;
			this.AnimationToProgress = toProgress;
			this.AnimationMaxProgress = maxProgress;
		}

		// Token: 0x0602E3D9 RID: 189401 RVA: 0x00CE5AE0 File Offset: 0x00CE3CE0
		public void Tick(float delta)
		{
			if (this.AnimationRemainingTime == null)
			{
				return;
			}
			float alpha = 1f - this.AnimationRemainingTime.Value / this.AnimationLength;
			float val = MathUtils.Instance.Lerp(this.AnimationFromProgress, this.AnimationToProgress, alpha);
			this.SetProgressText((float)((int)Math.Ceiling((double)Math.Min(val, this.AnimationToProgress))), this.AnimationMaxProgress);
			this.SetProgressBarPercent(Math.Min(val, this.AnimationToProgress), this.AnimationMaxProgress);
			if (this.AnimationRemainingTime.Value < 0f)
			{
				this.OnProgressBarFinished();
				return;
			}
			this.AnimationRemainingTime -= delta;
		}

		// Token: 0x0602E3DA RID: 189402 RVA: 0x00CE5BAF File Offset: 0x00CE3DAF
		private void OnProgressBarFinished()
		{
			this.AnimationRemainingTime = null;
			if (this.ProgressBarAnimationQueue.Count > 0)
			{
				this.PlayProgressAnimation(this.ProgressBarAnimationQueue, this.AnimationLength);
			}
		}

		// Token: 0x0602E3DB RID: 189403 RVA: 0x00CE5BE0 File Offset: 0x00CE3DE0
		private void SetTitleText(string titleTextId)
		{
			UUIText text = base.GetText(0);
			if (StringUtils.IsEmpty(titleTextId))
			{
				text.SetUIActive(false);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, titleTextId, Array.Empty<object>());
			text.SetUIActive(true);
		}

		// Token: 0x0602E3DC RID: 189404 RVA: 0x00CE5C20 File Offset: 0x00CE3E20
		private void SetProgressText(float currentProgress, float maxProgress)
		{
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<float>(Math.Min(maxProgress, currentProgress));
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<float>(maxProgress);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0602E3DD RID: 189405 RVA: 0x00CE5C6C File Offset: 0x00CE3E6C
		private void SetProgressBarPercent(float currentProgress, float maxProgress)
		{
			base.GetSprite(2).SetFillAmount(currentProgress / maxProgress);
		}

		// Token: 0x040189F9 RID: 100857
		private const int ANIMATION_LENGTH = 500;

		// Token: 0x040189FA RID: 100858
		private float AnimationFromProgress;

		// Token: 0x040189FB RID: 100859
		private float AnimationToProgress;

		// Token: 0x040189FC RID: 100860
		private float AnimationMaxProgress;

		// Token: 0x040189FD RID: 100861
		private float AnimationLength;

		// Token: 0x040189FE RID: 100862
		private float? AnimationRemainingTime;

		// Token: 0x040189FF RID: 100863
		private List<IRewardProgress> ProgressBarAnimationQueue = new List<IRewardProgress>();

		// Token: 0x0200A427 RID: 42023
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032DBE RID: 208318
			public const int TitleText = 0;

			// Token: 0x04032DBF RID: 208319
			public const int ProgressText = 1;

			// Token: 0x04032DC0 RID: 208320
			public const int ProgressBarSprite = 2;
		}
	}
}
