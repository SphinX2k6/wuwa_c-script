using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020011DE RID: 4574
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCountDownTipsPanel : SurvivorsRogueTipsPanelBase
{
	// Token: 0x0600B57E RID: 46462 RVA: 0x00359E10 File Offset: 0x00358010
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

	// Token: 0x0600B57F RID: 46463 RVA: 0x00359E98 File Offset: 0x00358098
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

	// Token: 0x0600B580 RID: 46464 RVA: 0x00359F0E File Offset: 0x0035810E
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.TickEnabled = true;
	}

	// Token: 0x0600B581 RID: 46465 RVA: 0x00359F1D File Offset: 0x0035811D
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		this.TickEnabled = false;
	}

	// Token: 0x0600B582 RID: 46466 RVA: 0x00359F2C File Offset: 0x0035812C
	public override void ShowTips()
	{
		base.Show(null);
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
	}

	// Token: 0x0600B583 RID: 46467 RVA: 0x00359F68 File Offset: 0x00358168
	public void InitCountDown(float remainTime, bool endlessWave)
	{
		this.RemainTime = remainTime;
		this.ElapsedTime = 0f;
		this.NeedTick = true;
		this.EndlessWave = endlessWave;
		this.ParentPanel.SetAnchorOffsetY((float)(endlessWave ? -30 : -100));
		this.TitleText.SetText("", true);
	}

	// Token: 0x0600B584 RID: 46468 RVA: 0x00359FBB File Offset: 0x003581BB
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

	// Token: 0x0600B585 RID: 46469 RVA: 0x00359FE8 File Offset: 0x003581E8
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

	// Token: 0x0600B586 RID: 46470 RVA: 0x0035A0F4 File Offset: 0x003582F4
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

	// Token: 0x04006903 RID: 26883
	private const int ONE_HUNDRED = 100;

	// Token: 0x04006904 RID: 26884
	private const int ELAPSED_ANCHOR_OFFSET_Y = -30;

	// Token: 0x04006905 RID: 26885
	private const int COUNT_DOWN_ANCHOR_OFFSET_Y = -100;

	// Token: 0x04006906 RID: 26886
	private float RemainTime;

	// Token: 0x04006907 RID: 26887
	private float ElapsedTime;

	// Token: 0x04006908 RID: 26888
	private UUIText TitleText;

	// Token: 0x04006909 RID: 26889
	private UUIArtText CountDownText;

	// Token: 0x0400690A RID: 26890
	private UUIItem ParentPanel;

	// Token: 0x0400690B RID: 26891
	private bool NeedTick;

	// Token: 0x0400690C RID: 26892
	private bool TickEnabled;

	// Token: 0x0400690D RID: 26893
	private bool EndlessWave;

	// Token: 0x0200749D RID: 29853
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025F2B RID: 155435
		public const int BgTexture = 0;

		// Token: 0x04025F2C RID: 155436
		public const int TipsText = 1;

		// Token: 0x04025F2D RID: 155437
		public const int CountDownText = 2;

		// Token: 0x04025F2E RID: 155438
		public const int ChangeText = 3;

		// Token: 0x04025F2F RID: 155439
		public const int ParentPanel = 4;
	}
}
