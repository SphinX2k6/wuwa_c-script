using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x020060D6 RID: 24790
	[NullableContext(1)]
	[Nullable(0)]
	public class BigStuffedDollProgressItem : UiPanelBase
	{
		// Token: 0x0603B716 RID: 243478 RVA: 0x010D2118 File Offset: 0x010D0318
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B717 RID: 243479 RVA: 0x010D21C4 File Offset: 0x010D03C4
		protected override void OnStart()
		{
			base.OnStart();
			UUIItem item = base.GetItem(1);
			this.ProgressBarWidth = item.GetWidth();
			item.SetStretchLeft(0f);
			item.SetStretchRight(this.ProgressBarWidth);
			item.SetUIActive(true);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.CurrentPerformanceScore = 0f;
		}

		// Token: 0x0603B718 RID: 243480 RVA: 0x010D2228 File Offset: 0x010D0428
		public void Init(BrokenRockConfig config)
		{
			this.ScoreMax = (float)((config.ScoreMax != 0) ? config.ScoreMax : 100);
			this.AutoIncreaseScore = (float)config.ScoreUp;
			LevelGeneralNetworks.RequestEntitySendEvent(BigStuffedDollModel.Instance.BrokenRockEntityCreatureDataId, "BrokenRockEventKey1");
			this.UpdateProgressText();
			base.GetSprite(0).SetFillAmount(0f);
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetAnchorOffsetX(this.ProgressBarWidth * -0.5f);
		}

		// Token: 0x0603B719 RID: 243481 RVA: 0x010D22A8 File Offset: 0x010D04A8
		public void Init(BrokenRockConfig config)
		{
			this.ScoreMax = (float)((config.ScoreMax != 0) ? config.ScoreMax : 100);
			this.AutoIncreaseScore = (float)config.ScoreUp;
			LevelGeneralNetworks.RequestEntitySendEvent(BigStuffedDollModel.Instance.BrokenRockEntityCreatureDataId, "BrokenRockEventKey1");
			this.UpdateProgressText();
			base.GetSprite(0).SetFillAmount(0f);
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetAnchorOffsetX(this.ProgressBarWidth * -0.5f);
		}

		// Token: 0x0603B71A RID: 243482 RVA: 0x010D2324 File Offset: 0x010D0524
		public void OnTick(float delta)
		{
			if (BigStuffedDollModel.Instance.GetGameStage() != EGameStage.GamePlaying)
			{
				return;
			}
			float num = delta / 1000f;
			if (this.AutoIncreaseScore != 0f)
			{
				this.AddScore(num * this.AutoIncreaseScore, false);
			}
			this.UpdateAddItem(num);
			this.ProcessProgressEvent();
		}

		// Token: 0x0603B71B RID: 243483 RVA: 0x010D2370 File Offset: 0x010D0570
		public void AddScore(float score, bool playAnim = true)
		{
			BigStuffedDollModel instance = BigStuffedDollModel.Instance;
			if (playAnim)
			{
				this.CurrentPerformanceScore = instance.CurrentScore;
			}
			instance.CurrentScore = MathCommon.Clamp(instance.CurrentScore + score, 0f, this.ScoreMax);
			float num = this.UpdateProgressText();
			if (playAnim)
			{
				UUIItem item = base.GetItem(1);
				float progress = this.GetProgress(this.CurrentPerformanceScore);
				item.SetStretchLeft(this.ProgressBarWidth * progress);
				item.SetStretchRight(this.ProgressBarWidth * (1f - num));
				this.LevelSequencePlayer.StopCurrentSequence(true, true);
				this.LevelSequencePlayer.PlayLevelSequenceByName((score >= 0f) ? "Add" : "Subtract", false, null, false);
				return;
			}
			base.GetSprite(0).SetFillAmount(num);
		}

		// Token: 0x0603B71C RID: 243484 RVA: 0x010D2434 File Offset: 0x010D0634
		private void UpdateAddItem(float deltaSecond)
		{
			float currentProgress = this.GetCurrentProgress();
			this.CurrentPerformanceScore = MathCommon.Clamp(this.CurrentPerformanceScore + deltaSecond * 10f, 0f, BigStuffedDollModel.Instance.CurrentScore);
			float progress = this.GetProgress(this.CurrentPerformanceScore);
			base.GetSprite(0).SetFillAmount(progress);
			UUIItem item = base.GetItem(1);
			item.SetStretchLeft(this.ProgressBarWidth * progress);
			item.SetStretchRight(this.ProgressBarWidth * (1f - currentProgress));
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetAnchorOffsetX(this.ProgressBarWidth * (progress - 0.5f));
		}

		// Token: 0x0603B71D RID: 243485 RVA: 0x010D24D4 File Offset: 0x010D06D4
		private void ProcessProgressEvent()
		{
			BigStuffedDollModel instance = BigStuffedDollModel.Instance;
			float currentProgress = this.GetCurrentProgress();
			if (currentProgress > 0.2f && this.LastProgress <= 0.2f)
			{
				LevelGeneralNetworks.RequestEntitySendEvent(instance.BrokenRockEntityCreatureDataId, "BrokenRockEventKey2");
			}
			else if (currentProgress > 0.4f && this.LastProgress <= 0.4f)
			{
				LevelGeneralNetworks.RequestEntitySendEvent(instance.BrokenRockEntityCreatureDataId, "BrokenRockEventKey3");
			}
			else if (currentProgress > 0.6f && this.LastProgress <= 0.6f)
			{
				LevelGeneralNetworks.RequestEntitySendEvent(instance.BrokenRockEntityCreatureDataId, "BrokenRockEventKey4");
			}
			else if (currentProgress > 0.8f && this.LastProgress <= 0.8f)
			{
				LevelGeneralNetworks.RequestEntitySendEvent(instance.BrokenRockEntityCreatureDataId, "BrokenRockEventKey5");
			}
			if (currentProgress >= 1f)
			{
				instance.GameResult = true;
				instance.EnterNextGameStage();
			}
			this.LastProgress = currentProgress;
		}

		// Token: 0x0603B71E RID: 243486 RVA: 0x010D25A4 File Offset: 0x010D07A4
		private float UpdateProgressText()
		{
			UUIText text = base.GetText(2);
			LguiUtil.Instance.SetLocalTextNew(text, "TeddyBear_Progress", Array.Empty<object>());
			string text2 = text.GetText();
			float currentProgress = this.GetCurrentProgress();
			int currentProgressPercent = this.GetCurrentProgressPercent();
			UUIText uuitext = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted<int>(currentProgressPercent);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			return currentProgress;
		}

		// Token: 0x0603B71F RID: 243487 RVA: 0x010D2621 File Offset: 0x010D0821
		public float GetCurrentProgress()
		{
			if (this.ScoreMax == 0f)
			{
				return 1f;
			}
			return this.GetProgress(BigStuffedDollModel.Instance.CurrentScore);
		}

		// Token: 0x0603B720 RID: 243488 RVA: 0x010D2646 File Offset: 0x010D0846
		public int GetCurrentProgressPercent()
		{
			if (this.ScoreMax == 0f)
			{
				return 100;
			}
			return Math.Min(100, (int)Math.Floor((double)(this.GetCurrentProgress() * 100f)));
		}

		// Token: 0x0603B721 RID: 243489 RVA: 0x010D2672 File Offset: 0x010D0872
		private float GetProgress(float score)
		{
			if (this.ScoreMax == 0f)
			{
				return 1f;
			}
			return score / this.ScoreMax;
		}

		// Token: 0x0401F554 RID: 128340
		private const string ADD_SCORE_ANIMNAME = "Add";

		// Token: 0x0401F555 RID: 128341
		private const string SUB_SCORE_ANIMNAME = "Subtract";

		// Token: 0x0401F556 RID: 128342
		private const string QTE_EVENTKEY1 = "BrokenRockEventKey1";

		// Token: 0x0401F557 RID: 128343
		private const string QTE_EVENTKEY2 = "BrokenRockEventKey2";

		// Token: 0x0401F558 RID: 128344
		private const string QTE_EVENTKEY3 = "BrokenRockEventKey3";

		// Token: 0x0401F559 RID: 128345
		private const string QTE_EVENTKEY4 = "BrokenRockEventKey4";

		// Token: 0x0401F55A RID: 128346
		private const string QTE_EVENTKEY5 = "BrokenRockEventKey5";

		// Token: 0x0401F55B RID: 128347
		private const float QTE_EVENTKEY_PROGRESS2 = 0.2f;

		// Token: 0x0401F55C RID: 128348
		private const float QTE_EVENTKEY_PROGRESS3 = 0.4f;

		// Token: 0x0401F55D RID: 128349
		private const float QTE_EVENTKEY_PROGRESS4 = 0.6f;

		// Token: 0x0401F55E RID: 128350
		private const float QTE_EVENTKEY_PROGRESS5 = 0.8f;

		// Token: 0x0401F55F RID: 128351
		private float ProgressBarWidth;

		// Token: 0x0401F560 RID: 128352
		private float CurrentPerformanceScore;

		// Token: 0x0401F561 RID: 128353
		public float ScoreMax;

		// Token: 0x0401F562 RID: 128354
		public float AutoIncreaseScore;

		// Token: 0x0401F563 RID: 128355
		private float LastProgress;

		// Token: 0x0401F564 RID: 128356
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B97E RID: 47486
		[NullableContext(0)]
		private class EViewComponent
		{
			// Token: 0x04039329 RID: 234281
			public const int ProgressSprite = 0;

			// Token: 0x0403932A RID: 234282
			public const int AdditionItem = 1;

			// Token: 0x0403932B RID: 234283
			public const int ProgressText = 2;

			// Token: 0x0403932C RID: 234284
			public const int Effect = 3;
		}
	}
}
