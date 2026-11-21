using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001260 RID: 4704
[NullableContext(2)]
[Nullable(0)]
public class CountDownChallengeView : UiViewBase
{
	// Token: 0x0600BA48 RID: 47688 RVA: 0x0036F800 File Offset: 0x0036DA00
	[NullableContext(1)]
	public CountDownChallengeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BA49 RID: 47689 RVA: 0x0036F814 File Offset: 0x0036DA14
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIArtText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BA4A RID: 47690 RVA: 0x0036F8C0 File Offset: 0x0036DAC0
	protected override void OnStart()
	{
		ChallengeCountDownViewParams challengeCountDownViewParams = this.OpenParam as ChallengeCountDownViewParams;
		this.TimerEndTime = challengeCountDownViewParams.TimerEndTime;
		this.TitleKey = challengeCountDownViewParams.UiTitleKey;
		this.CountDownText = base.GetArtText(2);
		this.ChangeText = base.GetArtText(3);
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.YellowArtTextData = this.CountDownText.GetArtTextData();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("TextData_NumB1");
		ResourceSystem.Instance.LoadAsync<ULGUIArtTextData>(resourcePath, delegate([Nullable(2)] ULGUIArtTextData artTextData, string loadPath)
		{
			if (artTextData == null || !artTextData.IsValid())
			{
				Log.Instance.Error(ELogModule.UiImageSetting, ELogAuthor.YSQ, "CountDownChallengeView找不到artTextData：TextData_NumB1", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.RedArtTextData = artTextData;
		}, 100, this.MemoryTag);
	}

	// Token: 0x0600BA4B RID: 47691 RVA: 0x0036F95D File Offset: 0x0036DB5D
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add<double, double>(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.UpdateCountDown));
	}

	// Token: 0x0600BA4C RID: 47692 RVA: 0x0036F981 File Offset: 0x0036DB81
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.UpdateCountDown));
	}

	// Token: 0x0600BA4D RID: 47693 RVA: 0x0036F9A8 File Offset: 0x0036DBA8
	private void UpdateCountDown(double remainTime, double timerEndTime)
	{
		this.LastRemainTime = this.RemainTime;
		this.RemainTime = remainTime;
		if (this.RemainTime <= 0.0)
		{
			GeneralLogicTreeModel.Instance.CountDownViewClosing = true;
			base.CloseMe(delegate(bool success)
			{
				if (success)
				{
					GeneralLogicTreeModel.Instance.CountDownViewClosing = false;
				}
			});
			return;
		}
		bool flag = this.RemainTime >= 10.0;
		if (this.LastRemainTime >= 10.0 && !flag)
		{
			if (this.SequencePlayer.GetCurrentSequence() == "Switch")
			{
				this.SequencePlayer.StopCurrentSequence(false, true);
			}
			this.SequencePlayer.PlayLevelSequenceByName("Switch", false, null, false);
		}
		int num = (int)Math.Floor(this.RemainTime % TimeUtil.Instance.Hour / TimeUtil.Instance.Minute);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted((num < 10) ? "0" : "");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		string value = defaultInterpolatedStringHandler.ToStringAndClear();
		int num2 = (int)Math.Floor(this.RemainTime % TimeUtil.Instance.Minute);
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted((num2 < 10) ? "0" : "");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
		string value2 = defaultInterpolatedStringHandler.ToStringAndClear();
		int num3 = (int)Math.Floor((this.RemainTime - Math.Floor(this.RemainTime)) * 100.0);
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted((num3 < 10) ? "0" : "");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
		string value3 = defaultInterpolatedStringHandler.ToStringAndClear();
		UUIArtText countDownText = this.CountDownText;
		if (countDownText != null)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			countDownText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		UUIArtText countDownText2 = this.CountDownText;
		if (countDownText2 != null)
		{
			countDownText2.SetArtTextData(flag ? this.YellowArtTextData : this.RedArtTextData);
		}
		if (timerEndTime != 0.0)
		{
			UUIArtText changeText = this.ChangeText;
			if (changeText != null)
			{
				changeText.SetArtTextData(flag ? this.YellowArtTextData : this.RedArtTextData);
			}
			int num4 = (int)Math.Round((timerEndTime - this.TimerEndTime) / 1000.0);
			this.TimerEndTime = timerEndTime;
			if (num4 != 0)
			{
				UUIArtText changeText2 = this.ChangeText;
				if (changeText2 != null)
				{
					string text;
					if (num4 <= 0)
					{
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
						defaultInterpolatedStringHandler.AppendFormatted<int>(num4);
						defaultInterpolatedStringHandler.AppendLiteral("s");
						text = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
						defaultInterpolatedStringHandler.AppendLiteral("+");
						defaultInterpolatedStringHandler.AppendFormatted<int>(num4);
						defaultInterpolatedStringHandler.AppendLiteral("s");
						text = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					changeText2.SetText(text);
				}
				if (this.SequencePlayer.GetCurrentSequence() == "Add")
				{
					this.SequencePlayer.StopCurrentSequence(false, true);
				}
				this.SequencePlayer.PlayLevelSequenceByName("Add", false, null, false);
			}
		}
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(this.TitleKey, true);
	}

	// Token: 0x04006B5D RID: 27485
	private const int ONE_HUNDRED = 100;

	// Token: 0x04006B5E RID: 27486
	[Nullable(1)]
	private const string SWITCH_ANIM = "Switch";

	// Token: 0x04006B5F RID: 27487
	[Nullable(1)]
	private const string ADD_ANIM = "Add";

	// Token: 0x04006B60 RID: 27488
	private double LastRemainTime;

	// Token: 0x04006B61 RID: 27489
	private double RemainTime;

	// Token: 0x04006B62 RID: 27490
	private double TimerEndTime;

	// Token: 0x04006B63 RID: 27491
	[Nullable(1)]
	private string TitleKey = "";

	// Token: 0x04006B64 RID: 27492
	private UUIArtText CountDownText;

	// Token: 0x04006B65 RID: 27493
	private UUIArtText ChangeText;

	// Token: 0x04006B66 RID: 27494
	private ULGUIArtTextData YellowArtTextData;

	// Token: 0x04006B67 RID: 27495
	private ULGUIArtTextData RedArtTextData;

	// Token: 0x04006B68 RID: 27496
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x02007502 RID: 29954
	[NullableContext(0)]
	private static class EViewComponent
	{
		// Token: 0x040260B3 RID: 155827
		public const int BgTexture = 0;

		// Token: 0x040260B4 RID: 155828
		public const int TipsText = 1;

		// Token: 0x040260B5 RID: 155829
		public const int CountDownText = 2;

		// Token: 0x040260B6 RID: 155830
		public const int ChangeText = 3;
	}
}
