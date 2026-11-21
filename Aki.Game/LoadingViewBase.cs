using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Ui.HotFix;
using UnrealEngine;

// Token: 0x02001552 RID: 5458
[NullableContext(1)]
[Nullable(0)]
public abstract class LoadingViewBase : UiTickViewBase
{
	// Token: 0x0600DA81 RID: 55937 RVA: 0x0040AE54 File Offset: 0x00409054
	protected LoadingViewBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DA82 RID: 55938 RVA: 0x0040AE5D File Offset: 0x0040905D
	protected override void OnBeforeCreate()
	{
		LoadingModel.Instance.SetIsLoadingView(true);
	}

	// Token: 0x0600DA83 RID: 55939 RVA: 0x0040AE6A File Offset: 0x0040906A
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.LevelSequencePlayerBandStateChange, new Action<bool>(this.HandleLevelSequencePlayerBandStateChange));
	}

	// Token: 0x0600DA84 RID: 55940 RVA: 0x0040AE85 File Offset: 0x00409085
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LevelSequencePlayerBandStateChange, new Action<bool>(this.HandleLevelSequencePlayerBandStateChange));
	}

	// Token: 0x0600DA85 RID: 55941 RVA: 0x0040AEA0 File Offset: 0x004090A0
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

	// Token: 0x0600DA86 RID: 55942 RVA: 0x0040AF1C File Offset: 0x0040911C
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

	// Token: 0x0600DA87 RID: 55943 RVA: 0x0040AF94 File Offset: 0x00409194
	protected virtual void UpdateBgUi(string path)
	{
	}

	// Token: 0x0600DA88 RID: 55944 RVA: 0x0040AF98 File Offset: 0x00409198
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

	// Token: 0x0600DA89 RID: 55945 RVA: 0x0040B008 File Offset: 0x00409208
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

	// Token: 0x0600DA8A RID: 55946 RVA: 0x0040B090 File Offset: 0x00409290
	protected virtual void UpdateShowTipsUi(string title, string tips)
	{
	}

	// Token: 0x0600DA8B RID: 55947 RVA: 0x0040B092 File Offset: 0x00409292
	protected override void OnAfterShow()
	{
		if (this.BackToGameLoadingViewData != null)
		{
			base.GetRootItem().SetUIActive(false);
		}
		EventSystem.Instance.Emit(EEventName.LoadingViewOnAfterShow);
	}

	// Token: 0x0600DA8C RID: 55948 RVA: 0x0040B0B8 File Offset: 0x004092B8
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

	// Token: 0x0600DA8D RID: 55949 RVA: 0x0040B114 File Offset: 0x00409314
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

	// Token: 0x0600DA8E RID: 55950 RVA: 0x0040B234 File Offset: 0x00409434
	private void InitProgress()
	{
		float currentProgress = LoadingModel.Instance.CurrentProgress;
		float progressRate = currentProgress / 100f;
		this.UpdateProgress(progressRate, currentProgress);
	}

	// Token: 0x0600DA8F RID: 55951 RVA: 0x0040B25C File Offset: 0x0040945C
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

	// Token: 0x0600DA90 RID: 55952 RVA: 0x0040B27E File Offset: 0x0040947E
	private void HandleLevelSequencePlayerBandStateChange(bool state)
	{
		this.OnLevelSequencePlayerBandStateChange(state);
	}

	// Token: 0x0600DA91 RID: 55953 RVA: 0x0040B287 File Offset: 0x00409487
	protected virtual void OnLevelSequencePlayerBandStateChange(bool state)
	{
	}

	// Token: 0x0600DA92 RID: 55954
	protected abstract void UpdateProgressRate(float rate);

	// Token: 0x0600DA93 RID: 55955
	protected abstract void UpdateProgressValue(float value);

	// Token: 0x0600DA94 RID: 55956 RVA: 0x0040B28C File Offset: 0x0040948C
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

	// Token: 0x0600DA95 RID: 55957 RVA: 0x0040B311 File Offset: 0x00409511
	protected override void OnAfterDestroy()
	{
		BackToGameLoadingViewData backToGameLoadingViewData = this.BackToGameLoadingViewData;
		if (backToGameLoadingViewData == null)
		{
			return;
		}
		backToGameLoadingViewData.Close();
	}

	// Token: 0x0600DA96 RID: 55958 RVA: 0x0040B324 File Offset: 0x00409524
	protected virtual void SetTextProgressValue(int textKey, float value, string suffix = "")
	{
		double value2 = Math.Round((double)value);
		UUIText text = base.GetText(textKey);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted<double>(value2);
		defaultInterpolatedStringHandler.AppendFormatted(suffix);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x0600DA97 RID: 55959 RVA: 0x0040B366 File Offset: 0x00409566
	protected void SetTextureProgressRate(int textureKey, float rate)
	{
		base.GetTexture(textureKey).SetFillAmount(rate);
	}

	// Token: 0x040079E4 RID: 31204
	private double TipTimeElapsed;

	// Token: 0x040079E5 RID: 31205
	private double LoadingTimeElapsed;

	// Token: 0x040079E6 RID: 31206
	[Nullable(2)]
	protected LoadingShowData ShowData;

	// Token: 0x040079E7 RID: 31207
	private bool Closing;

	// Token: 0x040079E8 RID: 31208
	[Nullable(2)]
	private BackToGameLoadingViewData BackToGameLoadingViewData;
}
