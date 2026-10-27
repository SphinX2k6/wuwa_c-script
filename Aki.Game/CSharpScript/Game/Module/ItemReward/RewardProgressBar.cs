using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x0200580E RID: 22542
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardProgressBar : UiPanelBase
	{
		// Token: 0x060394BF RID: 234687 RVA: 0x00D96A46 File Offset: 0x00D94C46
		public RewardProgressBar(AActor rootActor)
		{
			base.CreateThenShowByActor(rootActor, null);
		}

		// Token: 0x060394C0 RID: 234688 RVA: 0x00D96A64 File Offset: 0x00D94C64
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

		// Token: 0x060394C1 RID: 234689 RVA: 0x00D96AF9 File Offset: 0x00D94CF9
		public void Clear()
		{
			this.AnimationRemainingTime = new float?(0f);
			this.ProgressBarAnimationQueue.Clear();
		}

		// Token: 0x060394C2 RID: 234690 RVA: 0x00D96B18 File Offset: 0x00D94D18
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

		// Token: 0x060394C3 RID: 234691 RVA: 0x00D96B80 File Offset: 0x00D94D80
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

		// Token: 0x060394C4 RID: 234692 RVA: 0x00D96BFC File Offset: 0x00D94DFC
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

		// Token: 0x060394C5 RID: 234693 RVA: 0x00D96C50 File Offset: 0x00D94E50
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

		// Token: 0x060394C6 RID: 234694 RVA: 0x00D96D1F File Offset: 0x00D94F1F
		private void OnProgressBarFinished()
		{
			this.AnimationRemainingTime = null;
			if (this.ProgressBarAnimationQueue.Count > 0)
			{
				this.PlayProgressAnimation(this.ProgressBarAnimationQueue, this.AnimationLength);
			}
		}

		// Token: 0x060394C7 RID: 234695 RVA: 0x00D96D50 File Offset: 0x00D94F50
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

		// Token: 0x060394C8 RID: 234696 RVA: 0x00D96D90 File Offset: 0x00D94F90
		private void SetProgressText(float currentProgress, float maxProgress)
		{
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<float>(Math.Min(maxProgress, currentProgress));
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<float>(maxProgress);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x060394C9 RID: 234697 RVA: 0x00D96DDC File Offset: 0x00D94FDC
		private void SetProgressBarPercent(float currentProgress, float maxProgress)
		{
			base.GetSprite(2).SetFillAmount(currentProgress / maxProgress);
		}

		// Token: 0x0401DF62 RID: 122722
		private const int ANIMATION_LENGTH = 500;

		// Token: 0x0401DF63 RID: 122723
		private float AnimationFromProgress;

		// Token: 0x0401DF64 RID: 122724
		private float AnimationToProgress;

		// Token: 0x0401DF65 RID: 122725
		private float AnimationMaxProgress;

		// Token: 0x0401DF66 RID: 122726
		private float AnimationLength;

		// Token: 0x0401DF67 RID: 122727
		private float? AnimationRemainingTime;

		// Token: 0x0401DF68 RID: 122728
		private List<IRewardProgress> ProgressBarAnimationQueue = new List<IRewardProgress>();

		// Token: 0x0200BA11 RID: 47633
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040383D1 RID: 230353
			public const int TitleText = 0;

			// Token: 0x040383D2 RID: 230354
			public const int ProgressText = 1;

			// Token: 0x040383D3 RID: 230355
			public const int ProgressBarSprite = 2;
		}
	}
}
