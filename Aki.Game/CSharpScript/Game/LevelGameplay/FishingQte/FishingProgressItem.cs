using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FB8 RID: 24504
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingProgressItem : UiPanelBase
	{
		// Token: 0x0603AE26 RID: 241190 RVA: 0x010A38FC File Offset: 0x010A1AFC
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

		// Token: 0x0603AE27 RID: 241191 RVA: 0x010A39C8 File Offset: 0x010A1BC8
		[NullableContext(1)]
		public void Init(IFishingQteConfig config, FishingQteGameInfo gameInfo)
		{
			this.GameInfo = gameInfo;
			this.GameConfig = config;
			this.AnimTime = Math.Max((float)config.HitColdTime, 100f);
		}

		// Token: 0x0603AE28 RID: 241192 RVA: 0x010A39EF File Offset: 0x010A1BEF
		protected override void OnStart()
		{
			this.PanelProgressItem = base.GetItem(1);
			this.PanelProgressFrameItem = base.GetItem(3);
			this.PanelProgressFrameItem2 = base.GetItem(4);
			this.PanelProgressAnimItem = base.GetItem(2);
		}

		// Token: 0x0603AE29 RID: 241193 RVA: 0x010A3A25 File Offset: 0x010A1C25
		protected override void OnBeforeDestroy()
		{
			this.PanelProgressItem = null;
			this.PanelProgressFrameItem = null;
			this.PanelProgressAnimItem = null;
		}

		// Token: 0x0603AE2A RID: 241194 RVA: 0x010A3A3C File Offset: 0x010A1C3C
		public void OnTick(float delta)
		{
			float currentProgress = this.GetCurrentProgress();
			this.RefreshAnimProgress(currentProgress, delta);
			this.RefreshProgress(currentProgress);
		}

		// Token: 0x0603AE2B RID: 241195 RVA: 0x010A3A60 File Offset: 0x010A1C60
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

		// Token: 0x0603AE2C RID: 241196 RVA: 0x010A3B28 File Offset: 0x010A1D28
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

		// Token: 0x0603AE2D RID: 241197 RVA: 0x010A3BE0 File Offset: 0x010A1DE0
		private float GetCurrentProgress()
		{
			float currentScore = this.GameInfo.CurrentScore;
			int maxScore = this.GameConfig.MaxScore;
			return MathUtils.Instance.Clamp(currentScore / (float)maxScore, 0f, 1f);
		}

		// Token: 0x0603AE2E RID: 241198 RVA: 0x010A3C1D File Offset: 0x010A1E1D
		public void StartAnimProgress()
		{
			this.AnimStartProgress = this.GetCurrentProgress();
			this.CurrentAnimTime = 0f;
			this.InAnim = true;
		}

		// Token: 0x0603AE2F RID: 241199 RVA: 0x010A3C3D File Offset: 0x010A1E3D
		public void EnterNextRound()
		{
			this.AnimStartProgress = 0f;
		}

		// Token: 0x0401EF40 RID: 126784
		private const float PROGRESS_START_ANGLE = -77f;

		// Token: 0x0401EF41 RID: 126785
		private const float PROGRESS_END_ANGLE = 0f;

		// Token: 0x0401EF42 RID: 126786
		private const float PAUSE_TIME = 0f;

		// Token: 0x0401EF43 RID: 126787
		private const float MIN_ANIM_TIME = 100f;

		// Token: 0x0401EF44 RID: 126788
		protected IFishingQteConfig GameConfig;

		// Token: 0x0401EF45 RID: 126789
		protected FishingQteGameInfo GameInfo;

		// Token: 0x0401EF46 RID: 126790
		[Nullable(1)]
		private Rotator CurrentRotator = Rotator.Create();

		// Token: 0x0401EF47 RID: 126791
		[Nullable(1)]
		private Rotator AnimRotator = Rotator.Create();

		// Token: 0x0401EF48 RID: 126792
		private UUIItem PanelProgressItem;

		// Token: 0x0401EF49 RID: 126793
		private UUIItem PanelProgressFrameItem;

		// Token: 0x0401EF4A RID: 126794
		private UUIItem PanelProgressFrameItem2;

		// Token: 0x0401EF4B RID: 126795
		private UUIItem PanelProgressAnimItem;

		// Token: 0x0401EF4C RID: 126796
		private bool InAnim;

		// Token: 0x0401EF4D RID: 126797
		private float CurrentAnimTime;

		// Token: 0x0401EF4E RID: 126798
		private float AnimStartProgress;

		// Token: 0x0401EF4F RID: 126799
		private float AnimTime;

		// Token: 0x0200B8D8 RID: 47320
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040390D7 RID: 233687
			public const int TxtProgress = 0;

			// Token: 0x040390D8 RID: 233688
			public const int PanelProgress = 1;

			// Token: 0x040390D9 RID: 233689
			public const int PanelProgressAnim = 2;

			// Token: 0x040390DA RID: 233690
			public const int PanelProgressFrame = 3;

			// Token: 0x040390DB RID: 233691
			public const int PanelProgressFrame2 = 4;
		}
	}
}
