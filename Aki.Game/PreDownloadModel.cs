using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.PreDownload;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Util;
using UnrealEngine;

// Token: 0x02002219 RID: 8729
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PreDownloadModel : ModelBase
{
	// Token: 0x06011016 RID: 69654 RVA: 0x004254B7 File Offset: 0x004236B7
	public bool GetHasStartDownload()
	{
		return this.HasDownloadStarted;
	}

	// Token: 0x06011017 RID: 69655 RVA: 0x004254BF File Offset: 0x004236BF
	public void SetDownloadMode(EPreDownloadMode newMode)
	{
		this.CurrentDownloadMode = newMode;
	}

	// Token: 0x06011018 RID: 69656 RVA: 0x004254C8 File Offset: 0x004236C8
	public EPreDownloadMode GetDownloadMode()
	{
		return this.CurrentDownloadMode;
	}

	// Token: 0x06011019 RID: 69657 RVA: 0x004254D0 File Offset: 0x004236D0
	protected override bool OnInit()
	{
		this.AddEvents();
		this.PreDownloadNoViewObj = new PreDownloadNoView();
		return true;
	}

	// Token: 0x0601101A RID: 69658 RVA: 0x004254E4 File Offset: 0x004236E4
	protected override bool OnClear()
	{
		this.RemoveEvents();
		IPreDownload preDownload = PreDownloadManager.Get();
		preDownload.RemoveCompleteEvent(new Action(this.OnPreDownloadComplete));
		preDownload.Stop();
		this.PreDownloadNoViewObj = null;
		return true;
	}

	// Token: 0x0601101B RID: 69659 RVA: 0x00425510 File Offset: 0x00423710
	protected void AddEvents()
	{
		ReConnectModel.Instance.NetworkListener.NetworkChangeDelegate.Add(new Action<byte>(this.OnNetworkTypeChange));
		EventSystem.Instance.Add(EEventName.ReConnectSuccess, new Action(this.OnReconnect));
		EventSystem.Instance.Add(EEventName.ReConnectFail, new Action(this.OnReconnect));
		HotFixManager.MobilePreDownloadApplyTierChangeHandler = delegate(ETier oldTier, ETier newTier)
		{
			this.ResetPreDownloadState();
		};
	}

	// Token: 0x0601101C RID: 69660 RVA: 0x00425588 File Offset: 0x00423788
	protected void RemoveEvents()
	{
		ReConnectModel.Instance.NetworkListener.NetworkChangeDelegate.Remove(new Action<byte>(this.OnNetworkTypeChange));
		EventSystem.Instance.Remove(EEventName.ReConnectSuccess, new Action(this.OnReconnect));
		EventSystem.Instance.Remove(EEventName.ReConnectFail, new Action(this.OnReconnect));
		HotFixManager.MobilePreDownloadApplyTierChangeHandler = null;
	}

	// Token: 0x0601101D RID: 69661 RVA: 0x004255F3 File Offset: 0x004237F3
	private void ResetPreDownloadState()
	{
		this.HasDownloadStarted = false;
		this.CurrentDownloadMode = EPreDownloadMode.Normal;
		this.IsBinPatch = false;
		this.BinPatch = null;
		this.UpdateData = null;
	}

	// Token: 0x0601101E RID: 69662 RVA: 0x00425618 File Offset: 0x00423818
	public bool IsPreDownloadAvailable()
	{
		IPreDownload preDownload = PreDownloadManager.Get();
		return (Info.Instance.IsMobilePlatform() || Info.Instance.IsPlayInEditor) && preDownload.IsPreDownloadEnabled();
	}

	// Token: 0x0601101F RID: 69663 RVA: 0x0042564B File Offset: 0x0042384B
	public bool IsComplete()
	{
		return PreDownloadManager.Get().IsComplete();
	}

	// Token: 0x06011020 RID: 69664 RVA: 0x00425658 File Offset: 0x00423858
	private void OnNetworkTypeChange(byte newType)
	{
		IPreDownload preDownload = PreDownloadManager.Get();
		if (!this.IsPreDownloadAvailable() || !preDownload.IsDownloading())
		{
			return;
		}
		if (newType != 3)
		{
			return;
		}
		this.PausePreDownload(EPreDownloadPauseType.NetSwitch);
		PreDownloadController.Instance.OnCellNetTypeChanged();
	}

	// Token: 0x06011021 RID: 69665 RVA: 0x00425692 File Offset: 0x00423892
	public bool HasClickBtnCheck()
	{
		return this.IsPreDownloadAvailable() && !this.HasDownloadStarted;
	}

	// Token: 0x06011022 RID: 69666 RVA: 0x004256A8 File Offset: 0x004238A8
	public void StartPreDownload()
	{
		IPreDownload preDownload = PreDownloadManager.Get();
		if (!this.HasDownloadStarted)
		{
			preDownload.AddCompleteEvent(new Action(this.OnPreDownloadComplete));
		}
		this.HasDownloadStarted = true;
		if (!this.IsSpaceEnough())
		{
			long num = preDownload.GetDownloadSize() / 1048576L;
			PreDownloadDownloadNoSpaceBeforeStartRecord logData = new PreDownloadDownloadNoSpaceBeforeStartRecord(preDownload.GetNeedSpace() / 1048576L + num);
			LogReportController.Instance.LogReport(logData);
			this.NoSpaceConfirmBox();
			EventSystem.Instance.Emit(EEventName.PreDownloadStateUpdate);
			return;
		}
		EventSystem.Instance.Emit(EEventName.PreDownloadStateUpdate);
		preDownload.Start(EPreDownloadMode.Normal);
	}

	// Token: 0x06011023 RID: 69667 RVA: 0x00425740 File Offset: 0x00423940
	public void ResumePreDownload()
	{
		IPreDownload preDownload = PreDownloadManager.Get();
		if (!this.HasDownloadStarted)
		{
			this.StartPreDownload();
			return;
		}
		this.HasDownloadStarted = true;
		preDownload.Resume();
		EventSystem.Instance.Emit(EEventName.PreDownloadStateUpdate);
	}

	// Token: 0x06011024 RID: 69668 RVA: 0x00425780 File Offset: 0x00423980
	public void PausePreDownload(EPreDownloadPauseType pauseReason)
	{
		if (pauseReason > EPreDownloadPauseType.None)
		{
			PreDownloadPauseRecord logData = new PreDownloadPauseRecord((int)pauseReason);
			LogReportController.Instance.LogReport(logData);
		}
		PreDownloadManager.Get().Stop();
		EventSystem.Instance.Emit(EEventName.PreDownloadStateUpdate);
	}

	// Token: 0x06011025 RID: 69669 RVA: 0x004257BD File Offset: 0x004239BD
	public void SwitchResumeOrPause()
	{
		if (PreDownloadManager.Get().IsDownloading())
		{
			this.PausePreDownload(EPreDownloadPauseType.Player);
			return;
		}
		if (!this.IsSpaceEnough())
		{
			this.NoSpaceConfirmBox();
			EventSystem.Instance.Emit(EEventName.PreDownloadStateUpdate);
			return;
		}
		this.ResumePreDownload();
	}

	// Token: 0x06011026 RID: 69670 RVA: 0x004257F8 File Offset: 0x004239F8
	private void OnReconnect()
	{
		IPreDownload preDownload = PreDownloadManager.Get();
		if (!this.IsPreDownloadAvailable() || !preDownload.IsDownloading())
		{
			return;
		}
		this.PausePreDownload(EPreDownloadPauseType.Reconnect);
	}

	// Token: 0x06011027 RID: 69671 RVA: 0x00425824 File Offset: 0x00423A24
	public void SwitchDownloadMode()
	{
		if (this.CurrentDownloadMode == EPreDownloadMode.Normal)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.PreDownloadView))
			{
				this.SetDownloadMode(EPreDownloadMode.Speed);
			}
		}
		else
		{
			this.SetDownloadMode(EPreDownloadMode.Normal);
		}
		if (UiManager.Instance.IsViewShow(EUiViewName.PreDownloadView))
		{
			PreDownloadDownloadModeSwitchRecord logData = new PreDownloadDownloadModeSwitchRecord((this.CurrentDownloadMode == EPreDownloadMode.Speed) ? 1 : 2);
			LogReportController.Instance.LogReport(logData);
			EventSystem.Instance.Emit(EEventName.PreDownloadStateUpdate);
		}
	}

	// Token: 0x06011028 RID: 69672 RVA: 0x0042589C File Offset: 0x00423A9C
	private bool IsSpaceEnough()
	{
		IPreDownload preDownload = PreDownloadManager.Get();
		string checkPath = UKuroLauncherLibrary.GameSavedDir();
		long num = 0L;
		UKuroLauncherLibrary.GetTotalAndFreeSpace(checkPath, ref num);
		long needSpace = preDownload.GetNeedSpace();
		return num >= needSpace + 10485760L;
	}

	// Token: 0x06011029 RID: 69673 RVA: 0x004258D4 File Offset: 0x00423AD4
	private void NoSpaceConfirmBox()
	{
		IPreDownload preDownload = PreDownloadManager.Get();
		if (UiManager.Instance.IsViewShow(EUiViewName.PreDownloadView))
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PreDownloadNoSpace);
			string text = (preDownload.GetNeedSpace() / 1048576L).ToString() + "MB";
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				text
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("PreDownload_NoSpace", Array.Empty<object>());
	}

	// Token: 0x0601102A RID: 69674 RVA: 0x00425954 File Offset: 0x00423B54
	private void OnPreDownloadComplete()
	{
		PreDownloadDownloadModeSuccessRecord logData = new PreDownloadDownloadModeSuccessRecord((this.CurrentDownloadMode == EPreDownloadMode.Speed) ? 1 : 2);
		LogReportController.Instance.LogReport(logData);
		ScrollingTipsController.Instance.ShowTipsByTextId("PreDownload_Complete", Array.Empty<object>());
		EventSystem.Instance.Emit(EEventName.PreDownloadStateUpdate);
		PreDownloadManager.Get().RemoveCompleteEvent(new Action(this.OnPreDownloadComplete));
	}

	// Token: 0x0601102B RID: 69675 RVA: 0x004259B9 File Offset: 0x00423BB9
	public bool IsBinPatching()
	{
		return this.IsBinPatch;
	}

	// Token: 0x0601102C RID: 69676 RVA: 0x004259C1 File Offset: 0x00423BC1
	public void ClearView()
	{
		PreDownloadManager.Get().SetView(this.PreDownloadNoViewObj);
	}

	// Token: 0x0601102D RID: 69677 RVA: 0x004259D4 File Offset: 0x00423BD4
	public void OnUpdateDownData(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal)
	{
		this.IsBinPatch = false;
		if (this.UpdateData == null)
		{
			this.UpdateData = new UpdateDownData();
		}
		this.UpdateData.NeedWait = bNeedWait;
		this.UpdateData.Rate = rate;
		this.UpdateData.FileName = fileName;
		this.UpdateData.SpeedText = speedText;
		this.UpdateData.SizeCurrent = sizeCurrent;
		this.UpdateData.SizeTotal = sizeTotal;
	}

	// Token: 0x0601102E RID: 69678 RVA: 0x00425A48 File Offset: 0x00423C48
	public void OnBinPatch(bool bNeedWait, float rate, string textId, params string[] args)
	{
		if (this.BinPatch == null)
		{
			this.BinPatch = new BinPatchData();
		}
		this.BinPatch.NeedWait = bNeedWait;
		this.BinPatch.Rate = rate;
		this.BinPatch.TextId = textId;
		this.BinPatch.Args = args;
		this.IsBinPatch = true;
	}

	// Token: 0x0601102F RID: 69679 RVA: 0x00425AA0 File Offset: 0x00423CA0
	public void AddEnableCheck()
	{
		PreDownloadManager.Get().AddEnabledEvent(new Action(this.OnPreDownloadEnable));
		LauncherLog.Instance.Info("On PreDownload AddEnabledEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06011030 RID: 69680 RVA: 0x00425ADC File Offset: 0x00423CDC
	private void OnPreDownloadEnable()
	{
		PreDownloadManager.Get().TryRemoveTick();
		LauncherLog.Instance.Info("OnPreDownloadEnable And RemoveTick", default(ReadOnlySpan<ValueTuple<string, object>>));
		EventSystem.Instance.Emit(EEventName.OnPreDownloadAvailableUpdate);
		EventSystem.Instance.Emit(EEventName.PreDownloadStateUpdate);
	}

	// Token: 0x170015A7 RID: 5543
	// (get) Token: 0x06011031 RID: 69681 RVA: 0x00425B2B File Offset: 0x00423D2B
	public static PreDownloadModel Instance
	{
		get
		{
			return PreDownloadModel._Instance;
		}
	}

	// Token: 0x06011032 RID: 69682 RVA: 0x00425B32 File Offset: 0x00423D32
	public static PreDownloadModel GetOrCreateInstance()
	{
		if (PreDownloadModel._Instance == null)
		{
			PreDownloadModel.CreateInstance();
		}
		return PreDownloadModel._Instance;
	}

	// Token: 0x06011033 RID: 69683 RVA: 0x00425B46 File Offset: 0x00423D46
	public static bool CreateInstance()
	{
		if (PreDownloadModel._Instance != null)
		{
			return true;
		}
		PreDownloadModel._Instance = new PreDownloadModel();
		return true;
	}

	// Token: 0x06011034 RID: 69684 RVA: 0x00425B5C File Offset: 0x00423D5C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011035 RID: 69685 RVA: 0x00425B5E File Offset: 0x00423D5E
	public static void ResetStaticDefaultValue()
	{
		PreDownloadModel._Instance = null;
	}

	// Token: 0x06011036 RID: 69686 RVA: 0x00425B66 File Offset: 0x00423D66
	static PreDownloadModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PreDownloadModel.CreateStaticDefaultValue), new Action(PreDownloadModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008180 RID: 33152
	private bool HasDownloadStarted;

	// Token: 0x04008181 RID: 33153
	private EPreDownloadMode CurrentDownloadMode;

	// Token: 0x04008182 RID: 33154
	private bool IsBinPatch;

	// Token: 0x04008183 RID: 33155
	public BinPatchData BinPatch;

	// Token: 0x04008184 RID: 33156
	public UpdateDownData UpdateData;

	// Token: 0x04008185 RID: 33157
	private PreDownloadNoView PreDownloadNoViewObj;

	// Token: 0x04008186 RID: 33158
	[Nullable(2)]
	private static PreDownloadModel _Instance;
}
