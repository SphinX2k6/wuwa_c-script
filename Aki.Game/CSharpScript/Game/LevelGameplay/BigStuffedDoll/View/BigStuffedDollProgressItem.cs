using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x02006F55 RID: 28501
	[NullableContext(1)]
	[Nullable(0)]
	public class BigStuffedDollProgressItem : UiPanelBase
	{
		// Token: 0x06045568 RID: 284008 RVA: 0x01128338 File Offset: 0x01126538
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

		// Token: 0x06045569 RID: 284009 RVA: 0x011283E4 File Offset: 0x011265E4
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

		// Token: 0x0604556A RID: 284010 RVA: 0x01128448 File Offset: 0x01126648
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

		// Token: 0x0604556B RID: 284011 RVA: 0x011284C8 File Offset: 0x011266C8
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

		// Token: 0x0604556C RID: 284012 RVA: 0x01128544 File Offset: 0x01126744
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

		// Token: 0x0604556D RID: 284013 RVA: 0x01128590 File Offset: 0x01126790
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

		// Token: 0x0604556E RID: 284014 RVA: 0x01128654 File Offset: 0x01126854
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

		// Token: 0x0604556F RID: 284015 RVA: 0x011286F4 File Offset: 0x011268F4
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

		// Token: 0x06045570 RID: 284016 RVA: 0x011287C4 File Offset: 0x011269C4
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

		// Token: 0x06045571 RID: 284017 RVA: 0x01128841 File Offset: 0x01126A41
		public float GetCurrentProgress()
		{
			if (this.ScoreMax == 0f)
			{
				return 1f;
			}
			return this.GetProgress(BigStuffedDollModel.Instance.CurrentScore);
		}

		// Token: 0x06045572 RID: 284018 RVA: 0x01128866 File Offset: 0x01126A66
		public int GetCurrentProgressPercent()
		{
			if (this.ScoreMax == 0f)
			{
				return 100;
			}
			return Math.Min(100, (int)Math.Floor((double)(this.GetCurrentProgress() * 100f)));
		}

		// Token: 0x06045573 RID: 284019 RVA: 0x01128892 File Offset: 0x01126A92
		private float GetProgress(float score)
		{
			if (this.ScoreMax == 0f)
			{
				return 1f;
			}
			return score / this.ScoreMax;
		}

		// Token: 0x0402429F RID: 148127
		private const string ADD_SCORE_ANIMNAME = "Add";

		// Token: 0x040242A0 RID: 148128
		private const string SUB_SCORE_ANIMNAME = "Subtract";

		// Token: 0x040242A1 RID: 148129
		private const string QTE_EVENTKEY1 = "BrokenRockEventKey1";

		// Token: 0x040242A2 RID: 148130
		private const string QTE_EVENTKEY2 = "BrokenRockEventKey2";

		// Token: 0x040242A3 RID: 148131
		private const string QTE_EVENTKEY3 = "BrokenRockEventKey3";

		// Token: 0x040242A4 RID: 148132
		private const string QTE_EVENTKEY4 = "BrokenRockEventKey4";

		// Token: 0x040242A5 RID: 148133
		private const string QTE_EVENTKEY5 = "BrokenRockEventKey5";

		// Token: 0x040242A6 RID: 148134
		private const float QTE_EVENTKEY_PROGRESS2 = 0.2f;

		// Token: 0x040242A7 RID: 148135
		private const float QTE_EVENTKEY_PROGRESS3 = 0.4f;

		// Token: 0x040242A8 RID: 148136
		private const float QTE_EVENTKEY_PROGRESS4 = 0.6f;

		// Token: 0x040242A9 RID: 148137
		private const float QTE_EVENTKEY_PROGRESS5 = 0.8f;

		// Token: 0x040242AA RID: 148138
		private float ProgressBarWidth;

		// Token: 0x040242AB RID: 148139
		private float CurrentPerformanceScore;

		// Token: 0x040242AC RID: 148140
		public float ScoreMax;

		// Token: 0x040242AD RID: 148141
		public float AutoIncreaseScore;

		// Token: 0x040242AE RID: 148142
		private float LastProgress;

		// Token: 0x040242AF RID: 148143
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200CD8C RID: 52620
		[NullableContext(0)]
		private class EViewComponent
		{
			// Token: 0x0403DEFA RID: 253690
			public const int ProgressSprite = 0;

			// Token: 0x0403DEFB RID: 253691
			public const int AdditionItem = 1;

			// Token: 0x0403DEFC RID: 253692
			public const int ProgressText = 2;

			// Token: 0x0403DEFD RID: 253693
			public const int Effect = 3;
		}
	}
}
