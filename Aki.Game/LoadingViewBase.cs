using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Ui.HotFix;
using UnrealEngine;

// Token: 0x0200207F RID: 8319
[NullableContext(1)]
[Nullable(0)]
public abstract class LoadingViewBase : UiTickViewBase
{
	// Token: 0x06010619 RID: 67097 RVA: 0x003FEA0C File Offset: 0x003FCC0C
	protected LoadingViewBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601061A RID: 67098 RVA: 0x003FEA15 File Offset: 0x003FCC15
	protected override void OnBeforeCreate()
	{
		LoadingModel.Instance.SetIsLoadingView(true);
	}

	// Token: 0x0601061B RID: 67099 RVA: 0x003FEA22 File Offset: 0x003FCC22
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.LevelSequencePlayerBandStateChange, new Action<bool>(this.HandleLevelSequencePlayerBandStateChange));
	}

	// Token: 0x0601061C RID: 67100 RVA: 0x003FEA3D File Offset: 0x003FCC3D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LevelSequencePlayerBandStateChange, new Action<bool>(this.HandleLevelSequencePlayerBandStateChange));
	}

	// Token: 0x0601061D RID: 67101 RVA: 0x003FEA58 File Offset: 0x003FCC58
	[NullableContext(2)]
	public string GetGenderImage(int id)
	{
		PlayerInfoModel instance = PlayerInfoModel.Instance;
		EPlayerGender? eplayerGender = (instance != null) ? new EPlayerGender?(instance.GetPlayerGender()) : null;
		BroadcastImage? broadcastImageConfig = LoadingConfig.Instance.GetBroadcastImageConfig(id);
		if (broadcastImageConfig == null)
		{
			return null;
		}
		EPlayerGender? eplayerGender2 = eplayerGender;
		EPlayerGender eplayerGender3 = EPlayerGender.Female;
		if (!(eplayerGender2.GetValueOrDefault() == eplayerGender3 & eplayerGender2 != null))
		{
			return broadcastImageConfig.Value.ImageM;
		}
		return broadcastImageConfig.Value.ImageF;
	}

	// Token: 0x0601061E RID: 67102 RVA: 0x003FEAD4 File Offset: 0x003FCCD4
	private void InitShowData()
	{
		this.ShowData = new LoadingShowData();
		this.ShowData.Initialize();
		string text = this.GetGenderImage(this.ShowData.GetImageId());
		if (BaseConfigController.Instance.GetIosAuditFirstDownloadTip())
		{
			text = "/Game/Aki/UI/UIResources/Common/Image/BgCg/T_Bgloadin10_UI.T_Bgloadin10_UI";
		}
		if (!string.IsNullOrEmpty(LoadingModel.Instance.LoadingTexturePathOverride))
		{
			text = LoadingModel.Instance.LoadingTexturePathOverride;
		}
		if (text != null)
		{
			LoadingModel.Instance.SetLoadingTexturePath(text);
			this.UpdateBgUi(text);
		}
	}

	// Token: 0x0601061F RID: 67103 RVA: 0x003FEB4C File Offset: 0x003FCD4C
	protected virtual void UpdateBgUi(string path)
	{
	}

	// Token: 0x06010620 RID: 67104 RVA: 0x003FEB50 File Offset: 0x003FCD50
	protected override void OnStart()
	{
		HotFixSceneManager.StopHotPatchBgm();
		this.InitShowData();
		this.InitProgress();
		this.ChangeShowTips();
		if (LoginModel.Instance.HasBackToGameData())
		{
			BackToGameData backToGameData = LoginModel.Instance.GetBackToGameData();
			this.BackToGameLoadingViewData = new BackToGameLoadingViewData();
			this.BackToGameLoadingViewData.LoadingWidget = backToGameData.LoadingWidget;
			this.BackToGameLoadingViewData.RebootFinished();
			LoginModel.Instance.RemoveBackToGameData();
		}
	}

	// Token: 0x06010621 RID: 67105 RVA: 0x003FEBC0 File Offset: 0x003FCDC0
	protected void ChangeShowTips()
	{
		this.TipTimeElapsed = 0.0;
		LoadingTipsText? nextTip = this.ShowData.GetNextTip();
		if (nextTip == null)
		{
			return;
		}
		LoadingModel.Instance.SetLoadingTitle(nextTip.Value.Title);
		LoadingModel.Instance.SetLoadingTips(nextTip.Value.TipsText);
		this.UpdateShowTipsUi(nextTip.Value.Title, nextTip.Value.TipsText);
	}

	// Token: 0x06010622 RID: 67106 RVA: 0x003FEC48 File Offset: 0x003FCE48
	protected virtual void UpdateShowTipsUi(string title, string tips)
	{
	}

	// Token: 0x06010623 RID: 67107 RVA: 0x003FEC4A File Offset: 0x003FCE4A
	protected override void OnAfterShow()
	{
		if (this.BackToGameLoadingViewData != null)
		{
			base.GetRootItem().SetUIActive(false);
		}
		EventSystem.Instance.Emit(EEventName.LoadingViewOnAfterShow);
	}

	// Token: 0x06010624 RID: 67108 RVA: 0x003FEC70 File Offset: 0x003FCE70
	protected override void OnTick(float delta)
	{
		float num = delta / (float)TimeUtil.Instance.InverseMillisecond;
		this.LoadingTimeElapsed += (double)num;
		this.TickProgress(num);
		this.TipTimeElapsed += (double)num;
		if (this.TipTimeElapsed >= (double)LoadingModel.Instance.TipTime)
		{
			this.ChangeShowTips();
		}
	}

	// Token: 0x06010625 RID: 67109 RVA: 0x003FECCC File Offset: 0x003FCECC
	private void TickProgress(float delta)
	{
		if (this.Closing)
		{
			return;
		}
		LoadingModel instance = LoadingModel.Instance;
		int num = 100;
		float num2 = Math.Min(instance.CurrentProgress + (float)(instance.Speed * instance.SpeedRate) * delta, (float)instance.NextProgress);
		float progressRate = num2 / (float)num;
		instance.CurrentProgress = num2;
		this.UpdateProgress(progressRate, num2);
		while (instance.ReachHandleQueue.Size > 0)
		{
			ValueTuple<int, Action> front = instance.ReachHandleQueue.Front;
			if ((float)front.Item1 > num2)
			{
				break;
			}
			instance.ReachHandleQueue.Pop();
			front.Item2();
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Loading;
			ELogAuthor author = ELogAuthor.TL;
			string message = "TickProgress";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("progress", num2);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		int duringTime = this.ShowData.GetDuringTime();
		if (!this.Closing && num2 >= (float)num && this.LoadingTimeElapsed >= (double)duringTime)
		{
			this.Closing = true;
			UiManager.Instance.CloseView(this.ViewInfo.Name, null);
			BackToGameLoadingViewData backToGameLoadingViewData = this.BackToGameLoadingViewData;
			if (backToGameLoadingViewData != null)
			{
				backToGameLoadingViewData.Close();
			}
			this.BackToGameLoadingViewData = null;
		}
	}

	// Token: 0x06010626 RID: 67110 RVA: 0x003FEDEC File Offset: 0x003FCFEC
	private void InitProgress()
	{
		float currentProgress = LoadingModel.Instance.CurrentProgress;
		float progressRate = currentProgress / 100f;
		this.UpdateProgress(progressRate, currentProgress);
	}

	// Token: 0x06010627 RID: 67111 RVA: 0x003FEE14 File Offset: 0x003FD014
	private void UpdateProgress(float progressRate, float progressValue)
	{
		BackToGameLoadingViewData backToGameLoadingViewData = this.BackToGameLoadingViewData;
		if (backToGameLoadingViewData != null)
		{
			backToGameLoadingViewData.SetProgress(progressRate);
		}
		this.UpdateProgressRate(progressRate);
		this.UpdateProgressValue(progressValue);
	}

	// Token: 0x06010628 RID: 67112 RVA: 0x003FEE36 File Offset: 0x003FD036
	private void HandleLevelSequencePlayerBandStateChange(bool state)
	{
		this.OnLevelSequencePlayerBandStateChange(state);
	}

	// Token: 0x06010629 RID: 67113 RVA: 0x003FEE3F File Offset: 0x003FD03F
	protected virtual void OnLevelSequencePlayerBandStateChange(bool state)
	{
	}

	// Token: 0x0601062A RID: 67114
	protected abstract void UpdateProgressRate(float rate);

	// Token: 0x0601062B RID: 67115
	protected abstract void UpdateProgressValue(float value);

	// Token: 0x0601062C RID: 67116 RVA: 0x003FEE44 File Offset: 0x003FD044
	protected override void OnBeforeDestroyImplement()
	{
		LoadingModel instance = LoadingModel.Instance;
		instance.SetIsLoadingView(false);
		EventSystem.Instance.Emit(EEventName.RefreshCursor);
		while (instance.ReachHandleQueue.Size > 0)
		{
			instance.ReachHandleQueue.Pop().Item2();
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Loading;
			ELogAuthor author = ELogAuthor.TL;
			string message = "OnBeforeDestroyImplement";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("loadingModel.ReachHandleQueue.Size", instance.ReachHandleQueue.Size);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x0601062D RID: 67117 RVA: 0x003FEEC9 File Offset: 0x003FD0C9
	protected override void OnAfterDestroy()
	{
		BackToGameLoadingViewData backToGameLoadingViewData = this.BackToGameLoadingViewData;
		if (backToGameLoadingViewData == null)
		{
			return;
		}
		backToGameLoadingViewData.Close();
	}

	// Token: 0x0601062E RID: 67118 RVA: 0x003FEEDC File Offset: 0x003FD0DC
	protected virtual void SetTextProgressValue(int textKey, float value, string suffix = "")
	{
		double value2 = Math.Round((double)value);
		UUIText text = base.GetText(textKey);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted<double>(value2);
		defaultInterpolatedStringHandler.AppendFormatted(suffix);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x0601062F RID: 67119 RVA: 0x003FEF1E File Offset: 0x003FD11E
	protected void SetTextureProgressRate(int textureKey, float rate)
	{
		base.GetTexture(textureKey).SetFillAmount(rate);
	}

	// Token: 0x040078FB RID: 30971
	private double TipTimeElapsed;

	// Token: 0x040078FC RID: 30972
	private double LoadingTimeElapsed;

	// Token: 0x040078FD RID: 30973
	[Nullable(2)]
	protected LoadingShowData ShowData;

	// Token: 0x040078FE RID: 30974
	private bool Closing;

	// Token: 0x040078FF RID: 30975
	[Nullable(2)]
	private BackToGameLoadingViewData BackToGameLoadingViewData;
}
