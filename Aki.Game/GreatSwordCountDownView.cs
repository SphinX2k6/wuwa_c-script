using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200126F RID: 4719
[NullableContext(2)]
[Nullable(0)]
public class GreatSwordCountDownView : UiViewBase
{
	// Token: 0x0600BAB5 RID: 47797 RVA: 0x00370EF5 File Offset: 0x0036F0F5
	[NullableContext(1)]
	public GreatSwordCountDownView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BAB6 RID: 47798 RVA: 0x00370F08 File Offset: 0x0036F108
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

	// Token: 0x0600BAB7 RID: 47799 RVA: 0x00370F78 File Offset: 0x0036F178
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.OnCountDownChanged));
	}

	// Token: 0x0600BAB8 RID: 47800 RVA: 0x00370F9C File Offset: 0x0036F19C
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.OnCountDownChanged));
	}

	// Token: 0x0600BAB9 RID: 47801 RVA: 0x00370FC0 File Offset: 0x0036F1C0
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

	// Token: 0x0600BABA RID: 47802 RVA: 0x00371035 File Offset: 0x0036F235
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

	// Token: 0x0600BABB RID: 47803 RVA: 0x00371075 File Offset: 0x0036F275
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

	// Token: 0x0600BABC RID: 47804 RVA: 0x003710A8 File Offset: 0x0036F2A8
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

	// Token: 0x0600BABD RID: 47805 RVA: 0x00371158 File Offset: 0x0036F358
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

	// Token: 0x0600BABE RID: 47806 RVA: 0x003711AC File Offset: 0x0036F3AC
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

	// Token: 0x0600BABF RID: 47807 RVA: 0x0037128C File Offset: 0x0036F48C
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

	// Token: 0x0600BAC0 RID: 47808 RVA: 0x003712BC File Offset: 0x0036F4BC
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

	// Token: 0x04006B87 RID: 27527
	private double RemainTime;

	// Token: 0x04006B88 RID: 27528
	private double TimerEndTime;

	// Token: 0x04006B89 RID: 27529
	private double LastRemainTime;

	// Token: 0x04006B8A RID: 27530
	private readonly int ColorChangeTime = 10;

	// Token: 0x04006B8B RID: 27531
	private UUIArtText CountDownText;

	// Token: 0x04006B8C RID: 27532
	private UUIArtText AdditionText;

	// Token: 0x04006B8D RID: 27533
	private ULGUIArtTextData YellowArtTextData;

	// Token: 0x04006B8E RID: 27534
	private ULGUIArtTextData RedArtTextData;

	// Token: 0x04006B8F RID: 27535
	private UUITexture TexTimeBg;
}
