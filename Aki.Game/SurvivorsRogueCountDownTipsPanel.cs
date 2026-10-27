using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001D1C RID: 7452
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCountDownTipsPanel : SurvivorsRogueTipsPanelBase
{
	// Token: 0x0600E161 RID: 57697 RVA: 0x0034E3E0 File Offset: 0x0034C5E0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIArtText)),
			new ValueTuple<int, Type>(3, typeof(UUIArtText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0600E162 RID: 57698 RVA: 0x0034E468 File Offset: 0x0034C668
	protected override void OnStart()
	{
		base.OnStart();
		this.TitleText = base.GetText(1);
		this.TitleText.SetUIActive(false);
		this.CountDownText = base.GetArtText(2);
		this.ParentPanel = base.GetItem(4);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("TextData_NumB1");
		ResourceSystem.Instance.LoadAsync<ULGUIArtTextData>(resourcePath, delegate([Nullable(2)] ULGUIArtTextData artTextData, string pathArg)
		{
			if (artTextData == null || !artTextData.IsValid())
			{
				Log.Instance.Error(ELogModule.UiImageSetting, ELogAuthor.CK, "SurvivorsRogueCountDownTipsPanel找不到artTextData: TextData_NumB1", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.CountDownText.SetArtTextData(artTextData);
		}, ResourceSystem.EResourceLoadPriority.Default, this.MemoryTag);
	}

	// Token: 0x0600E163 RID: 57699 RVA: 0x0034E4DE File Offset: 0x0034C6DE
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.TickEnabled = true;
	}

	// Token: 0x0600E164 RID: 57700 RVA: 0x0034E4ED File Offset: 0x0034C6ED
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		this.TickEnabled = false;
	}

	// Token: 0x0600E165 RID: 57701 RVA: 0x0034E4FC File Offset: 0x0034C6FC
	public override void ShowTips()
	{
		base.Show(null);
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
	}

	// Token: 0x0600E166 RID: 57702 RVA: 0x0034E538 File Offset: 0x0034C738
	public void InitCountDown(float remainTime, bool endlessWave)
	{
		this.RemainTime = remainTime;
		this.ElapsedTime = 0f;
		this.NeedTick = true;
		this.EndlessWave = endlessWave;
		this.ParentPanel.SetAnchorOffsetY((float)(endlessWave ? -30 : -100));
		this.TitleText.SetText("", true);
	}

	// Token: 0x0600E167 RID: 57703 RVA: 0x0034E58B File Offset: 0x0034C78B
	public void OnTick(float delta)
	{
		if (!this.TickEnabled || !this.NeedTick)
		{
			return;
		}
		if (this.EndlessWave)
		{
			this.TickEndlessWave(delta);
			return;
		}
		this.TickNormalWave(delta);
	}

	// Token: 0x0600E168 RID: 57704 RVA: 0x0034E5B8 File Offset: 0x0034C7B8
	private void TickEndlessWave(float delta)
	{
		this.ElapsedTime += delta * (float)TimeUtil.Instance.Millisecond;
		float elapsedTime = this.ElapsedTime;
		int num = (int)Math.Floor((double)elapsedTime / TimeUtil.Instance.Minute);
		string text = (num < 10) ? ("0" + num.ToString()) : num.ToString();
		int num2 = (int)Math.Floor((double)elapsedTime % TimeUtil.Instance.Minute);
		string text2 = (num2 < 10) ? ("0" + num2.ToString()) : num2.ToString();
		int num3 = (int)Math.Floor(((double)elapsedTime - Math.Floor((double)elapsedTime)) * 100.0);
		string text3 = (num3 < 10) ? ("0" + num3.ToString()) : num3.ToString();
		this.CountDownText.SetText(string.Concat(new string[]
		{
			text,
			":",
			text2,
			":",
			text3
		}));
	}

	// Token: 0x0600E169 RID: 57705 RVA: 0x0034E6C4 File Offset: 0x0034C8C4
	private void TickNormalWave(float delta)
	{
		if (this.RemainTime <= 0f)
		{
			this.CountDownText.SetText("0s");
			this.NeedTick = false;
			return;
		}
		this.CountDownText.SetText(((int)this.RemainTime).ToString() + "s");
		this.RemainTime -= delta * (float)TimeUtil.Instance.Millisecond;
	}

	// Token: 0x04006824 RID: 26660
	private const int ONE_HUNDRED = 100;

	// Token: 0x04006825 RID: 26661
	private const int ELAPSED_ANCHOR_OFFSET_Y = -30;

	// Token: 0x04006826 RID: 26662
	private const int COUNT_DOWN_ANCHOR_OFFSET_Y = -100;

	// Token: 0x04006827 RID: 26663
	private float RemainTime;

	// Token: 0x04006828 RID: 26664
	private float ElapsedTime;

	// Token: 0x04006829 RID: 26665
	private UUIText TitleText;

	// Token: 0x0400682A RID: 26666
	private UUIArtText CountDownText;

	// Token: 0x0400682B RID: 26667
	private UUIItem ParentPanel;

	// Token: 0x0400682C RID: 26668
	private bool NeedTick;

	// Token: 0x0400682D RID: 26669
	private bool TickEnabled;

	// Token: 0x0400682E RID: 26670
	private bool EndlessWave;

	// Token: 0x02008314 RID: 33556
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AC03 RID: 175107
		public const int BgTexture = 0;

		// Token: 0x0402AC04 RID: 175108
		public const int TipsText = 1;

		// Token: 0x0402AC05 RID: 175109
		public const int CountDownText = 2;

		// Token: 0x0402AC06 RID: 175110
		public const int ChangeText = 3;

		// Token: 0x0402AC07 RID: 175111
		public const int ParentPanel = 4;
	}
}
