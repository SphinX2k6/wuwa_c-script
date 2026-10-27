using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DAD RID: 7597
[NullableContext(2)]
[Nullable(0)]
public class GreatSwordCountDownView : UiViewBase
{
	// Token: 0x0600E697 RID: 59031 RVA: 0x00365295 File Offset: 0x00363495
	[NullableContext(1)]
	public GreatSwordCountDownView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E698 RID: 59032 RVA: 0x003652A8 File Offset: 0x003634A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIArtText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIArtText))
		};
	}

	// Token: 0x0600E699 RID: 59033 RVA: 0x00365318 File Offset: 0x00363518
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.OnCountDownChanged));
	}

	// Token: 0x0600E69A RID: 59034 RVA: 0x0036533C File Offset: 0x0036353C
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.OnCountDownChanged));
	}

	// Token: 0x0600E69B RID: 59035 RVA: 0x00365360 File Offset: 0x00363560
	protected override void OnStart()
	{
		this.CountDownText = base.GetArtText(0);
		this.AdditionText = base.GetArtText(3);
		this.YellowArtTextData = this.CountDownText.GetArtTextData();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("TextData_NumB1");
		ResourceSystem.Instance.LoadAsync<ULGUIArtTextData>(resourcePath, delegate([Nullable(2)] ULGUIArtTextData artTextData, string path)
		{
			if (artTextData != null && artTextData.IsValid())
			{
				this.RedArtTextData = artTextData;
			}
		}, ResourceSystem.EResourceLoadPriority.Default, this.MemoryTag);
		this.TexTimeBg = base.GetTexture(2);
	}

	// Token: 0x0600E69C RID: 59036 RVA: 0x003653D5 File Offset: 0x003635D5
	private void OnCountDownChanged(double remainTime, double timerEndTime)
	{
		this.LastRemainTime = this.RemainTime;
		this.RemainTime = remainTime;
		if (this.RemainTime <= 0.0)
		{
			this.HandleCountDownEnd();
			return;
		}
		this.UpdateTimeDisplay();
		this.TryPlayColorChangeSequence();
		this.HandleTimerEndTime(timerEndTime);
	}

	// Token: 0x0600E69D RID: 59037 RVA: 0x00365415 File Offset: 0x00363615
	private void HandleCountDownEnd()
	{
		GeneralLogicTreeModel.Instance.CountDownViewClosing = true;
		base.CloseMe(delegate(bool success)
		{
			if (success)
			{
				GeneralLogicTreeModel.Instance.CountDownViewClosing = false;
			}
		});
	}

	// Token: 0x0600E69E RID: 59038 RVA: 0x00365448 File Offset: 0x00363648
	private void TryPlayColorChangeSequence()
	{
		bool flag = this.RemainTime >= (double)this.ColorChangeTime;
		bool flag2 = this.LastRemainTime >= (double)this.ColorChangeTime;
		if (!flag2 || flag)
		{
			if (!flag2 && flag)
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.PlaySequence("ColorChange1", false, null);
				}
				UUIArtText countDownText = this.CountDownText;
				if (countDownText == null)
				{
					return;
				}
				countDownText.SetArtTextData(this.YellowArtTextData);
			}
			return;
		}
		UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
		if (uiViewSequence2 != null)
		{
			uiViewSequence2.PlaySequence("ColorChange", false, null);
		}
		UUIArtText countDownText2 = this.CountDownText;
		if (countDownText2 == null)
		{
			return;
		}
		countDownText2.SetArtTextData(this.RedArtTextData);
	}

	// Token: 0x0600E69F RID: 59039 RVA: 0x003654F8 File Offset: 0x003636F8
	private void HandleTimerEndTime(double timerEndTime)
	{
		if (this.TimerEndTime == 0.0)
		{
			this.TimerEndTime = timerEndTime;
			return;
		}
		int num = (int)Math.Round((timerEndTime - this.TimerEndTime) / 1000.0);
		this.TimerEndTime = timerEndTime;
		if (num != 0)
		{
			this.ShowAdditionTime(num);
		}
	}

	// Token: 0x0600E6A0 RID: 59040 RVA: 0x0036554C File Offset: 0x0036374C
	private void ShowAdditionTime(int diff)
	{
		string value = (diff > 0) ? "+" : "-";
		UUIArtText additionText = this.AdditionText;
		if (additionText != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendFormatted<int>(Math.Abs(diff));
			defaultInterpolatedStringHandler.AppendLiteral("s");
			additionText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		bool flag = diff < 0;
		UUIArtText additionText2 = this.AdditionText;
		if (additionText2 != null)
		{
			additionText2.SetArtTextData(flag ? this.RedArtTextData : this.YellowArtTextData);
		}
		this.SetBgTextureByTimeChange(flag);
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null && uiViewSequence.HasSequenceNameInPlaying("TimeIn"))
		{
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 != null)
			{
				uiViewSequence2.StopSequenceByKey("TimeIn", false, true);
			}
		}
		UiBehaviorLevelSequence uiViewSequence3 = this.UiViewSequence;
		if (uiViewSequence3 == null)
		{
			return;
		}
		uiViewSequence3.PlaySequence("TimeIn", false, null);
	}

	// Token: 0x0600E6A1 RID: 59041 RVA: 0x0036562C File Offset: 0x0036382C
	private void UpdateTimeDisplay()
	{
		string remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat5(this.RemainTime);
		UUIArtText countDownText = this.CountDownText;
		if (countDownText == null)
		{
			return;
		}
		countDownText.SetText(remainTimeDataFormat);
	}

	// Token: 0x0600E6A2 RID: 59042 RVA: 0x0036565C File Offset: 0x0036385C
	private void SetBgTextureByTimeChange(bool isReduce)
	{
		if (this.TexTimeBg == null)
		{
			return;
		}
		this.TexTimeBg.SetUIActive(false);
		string resourceId = isReduce ? "T_BlackBladeCountDownBgRed" : "T_BlackBladeCountDownBgGreen";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, this.TexTimeBg, null, delegate(bool _)
		{
			UUITexture texTimeBg = this.TexTimeBg;
			if (texTimeBg == null)
			{
				return;
			}
			texTimeBg.SetUIActive(true);
		});
	}

	// Token: 0x04006AA6 RID: 27302
	private double RemainTime;

	// Token: 0x04006AA7 RID: 27303
	private double TimerEndTime;

	// Token: 0x04006AA8 RID: 27304
	private double LastRemainTime;

	// Token: 0x04006AA9 RID: 27305
	private readonly int ColorChangeTime = 10;

	// Token: 0x04006AAA RID: 27306
	private UUIArtText CountDownText;

	// Token: 0x04006AAB RID: 27307
	private UUIArtText AdditionText;

	// Token: 0x04006AAC RID: 27308
	private ULGUIArtTextData YellowArtTextData;

	// Token: 0x04006AAD RID: 27309
	private ULGUIArtTextData RedArtTextData;

	// Token: 0x04006AAE RID: 27310
	private UUITexture TexTimeBg;
}
