using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E37 RID: 28215
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingProgressItem : UiPanelBase
	{
		// Token: 0x06044C99 RID: 281753 RVA: 0x010F937C File Offset: 0x010F757C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06044C9A RID: 281754 RVA: 0x010F9448 File Offset: 0x010F7648
		[NullableContext(1)]
		public void Init(IFishingQteConfig config, FishingQteGameInfo gameInfo)
		{
			this.GameInfo = gameInfo;
			this.GameConfig = config;
			this.AnimTime = Math.Max((float)config.HitColdTime, 100f);
		}

		// Token: 0x06044C9B RID: 281755 RVA: 0x010F946F File Offset: 0x010F766F
		protected override void OnStart()
		{
			this.PanelProgressItem = base.GetItem(1);
			this.PanelProgressFrameItem = base.GetItem(3);
			this.PanelProgressFrameItem2 = base.GetItem(4);
			this.PanelProgressAnimItem = base.GetItem(2);
		}

		// Token: 0x06044C9C RID: 281756 RVA: 0x010F94A5 File Offset: 0x010F76A5
		protected override void OnBeforeDestroy()
		{
			this.PanelProgressItem = null;
			this.PanelProgressFrameItem = null;
			this.PanelProgressAnimItem = null;
		}

		// Token: 0x06044C9D RID: 281757 RVA: 0x010F94BC File Offset: 0x010F76BC
		public void OnTick(float delta)
		{
			float currentProgress = this.GetCurrentProgress();
			this.RefreshAnimProgress(currentProgress, delta);
			this.RefreshProgress(currentProgress);
		}

		// Token: 0x06044C9E RID: 281758 RVA: 0x010F94E0 File Offset: 0x010F76E0
		private void RefreshProgress(float progress)
		{
			double value = Math.Ceiling((double)(progress * 100f));
			UUIText text = base.GetText(0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<double>(value);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			this.CurrentRotator.Yaw = MathUtils.Instance.Lerp(-77f, 0f, progress);
			UUIItem panelProgressItem = this.PanelProgressItem;
			FRotator frotator;
			if (panelProgressItem != null)
			{
				frotator = this.CurrentRotator.ToUeRotator();
				panelProgressItem.SetUIRelativeRotation(frotator);
			}
			UUIItem panelProgressFrameItem = this.PanelProgressFrameItem;
			if (panelProgressFrameItem != null)
			{
				frotator = this.CurrentRotator.ToUeRotator();
				panelProgressFrameItem.SetUIRelativeRotation(frotator);
			}
			UUIItem panelProgressFrameItem2 = this.PanelProgressFrameItem2;
			if (panelProgressFrameItem2 == null)
			{
				return;
			}
			frotator = this.CurrentRotator.ToUeRotator();
			panelProgressFrameItem2.SetUIRelativeRotation(frotator);
		}

		// Token: 0x06044C9F RID: 281759 RVA: 0x010F95A8 File Offset: 0x010F77A8
		private void RefreshAnimProgress(float currentProgress, float delta)
		{
			float alpha = currentProgress;
			if (this.InAnim)
			{
				this.CurrentAnimTime += delta;
				if (0f < this.CurrentAnimTime && this.CurrentAnimTime <= 0f + this.AnimTime)
				{
					float alpha2 = (this.CurrentAnimTime - 0f) / this.AnimTime;
					alpha = MathUtils.Instance.Lerp(this.AnimStartProgress, currentProgress, alpha2);
				}
				else
				{
					this.InAnim = false;
					alpha = currentProgress;
				}
			}
			this.AnimRotator.Yaw = MathUtils.Instance.Lerp(-77f, 0f, alpha);
			UUIItem panelProgressAnimItem = this.PanelProgressAnimItem;
			if (panelProgressAnimItem == null)
			{
				return;
			}
			FRotator frotator = this.AnimRotator.ToUeRotator();
			panelProgressAnimItem.SetUIRelativeRotation(frotator);
		}

		// Token: 0x06044CA0 RID: 281760 RVA: 0x010F9660 File Offset: 0x010F7860
		private float GetCurrentProgress()
		{
			float currentScore = this.GameInfo.CurrentScore;
			int maxScore = this.GameConfig.MaxScore;
			return MathUtils.Instance.Clamp(currentScore / (float)maxScore, 0f, 1f);
		}

		// Token: 0x06044CA1 RID: 281761 RVA: 0x010F969D File Offset: 0x010F789D
		public void StartAnimProgress()
		{
			this.AnimStartProgress = this.GetCurrentProgress();
			this.CurrentAnimTime = 0f;
			this.InAnim = true;
		}

		// Token: 0x06044CA2 RID: 281762 RVA: 0x010F96BD File Offset: 0x010F78BD
		public void EnterNextRound()
		{
			this.AnimStartProgress = 0f;
		}

		// Token: 0x04023C8B RID: 146571
		private const float PROGRESS_START_ANGLE = -77f;

		// Token: 0x04023C8C RID: 146572
		private const float PROGRESS_END_ANGLE = 0f;

		// Token: 0x04023C8D RID: 146573
		private const float PAUSE_TIME = 0f;

		// Token: 0x04023C8E RID: 146574
		private const float MIN_ANIM_TIME = 100f;

		// Token: 0x04023C8F RID: 146575
		protected IFishingQteConfig GameConfig;

		// Token: 0x04023C90 RID: 146576
		protected FishingQteGameInfo GameInfo;

		// Token: 0x04023C91 RID: 146577
		[Nullable(1)]
		private Rotator CurrentRotator = Rotator.Create();

		// Token: 0x04023C92 RID: 146578
		[Nullable(1)]
		private Rotator AnimRotator = Rotator.Create();

		// Token: 0x04023C93 RID: 146579
		private UUIItem PanelProgressItem;

		// Token: 0x04023C94 RID: 146580
		private UUIItem PanelProgressFrameItem;

		// Token: 0x04023C95 RID: 146581
		private UUIItem PanelProgressFrameItem2;

		// Token: 0x04023C96 RID: 146582
		private UUIItem PanelProgressAnimItem;

		// Token: 0x04023C97 RID: 146583
		private bool InAnim;

		// Token: 0x04023C98 RID: 146584
		private float CurrentAnimTime;

		// Token: 0x04023C99 RID: 146585
		private float AnimStartProgress;

		// Token: 0x04023C9A RID: 146586
		private float AnimTime;

		// Token: 0x0200CCE8 RID: 52456
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403DCB5 RID: 253109
			public const int TxtProgress = 0;

			// Token: 0x0403DCB6 RID: 253110
			public const int PanelProgress = 1;

			// Token: 0x0403DCB7 RID: 253111
			public const int PanelProgressAnim = 2;

			// Token: 0x0403DCB8 RID: 253112
			public const int PanelProgressFrame = 3;

			// Token: 0x0403DCB9 RID: 253113
			public const int PanelProgressFrame2 = 4;
		}
	}
}
