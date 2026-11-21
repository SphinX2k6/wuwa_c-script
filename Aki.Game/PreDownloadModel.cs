using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.PreDownload;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Util;
using UnrealEngine;

// Token: 0x020016FD RID: 5885
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PreDownloadModel : ModelBase
{
	// Token: 0x0600E4AC RID: 58540 RVA: 0x00432053 File Offset: 0x00430253
	public bool GetHasStartDownload()
	{
		return this.HasDownloadStarted;
	}

	// Token: 0x0600E4AD RID: 58541 RVA: 0x0043205B File Offset: 0x0043025B
	public void SetDownloadMode(EPreDownloadMode newMode)
	{
		this.CurrentDownloadMode = newMode;
	}

	// Token: 0x0600E4AE RID: 58542 RVA: 0x00432064 File Offset: 0x00430264
	public EPreDownloadMode GetDownloadMode()
	{
		return this.CurrentDownloadMode;
	}

	// Token: 0x0600E4AF RID: 58543 RVA: 0x0043206C File Offset: 0x0043026C
	protected override bool OnInit()
	{
		this.AddEvents();
		this.PreDownloadNoViewObj = new PreDownloadNoView();
		return true;
	}

	// Token: 0x0600E4B0 RID: 58544 RVA: 0x00432080 File Offset: 0x00430280
	protected override bool OnClear()
	{
		this.RemoveEvents();
		IPreDownload preDownload = PreDownloadManager.Get();
		preDownload.RemoveCompleteEvent(new Action(this.OnPreDownloadComplete));
		preDownload.Stop();
		this.PreDownloadNoViewObj = null;
		return true;
	}

	// Token: 0x0600E4B1 RID: 58545 RVA: 0x004320AC File Offset: 0x004302AC
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

	// Token: 0x0600E4B2 RID: 58546 RVA: 0x00432124 File Offset: 0x00430324
	protected void RemoveEvents()
	{
		ReConnectModel.Instance.NetworkListener.NetworkChangeDelegate.Remove(new Action<byte>(this.OnNetworkTypeChange));
		EventSystem.Instance.Remove(EEventName.ReConnectSuccess, new Action(this.OnReconnect));
		EventSystem.Instance.Remove(EEventName.ReConnectFail, new Action(this.OnReconnect));
		HotFixManager.MobilePreDownloadApplyTierChangeHandler = null;
	}

	// Token: 0x0600E4B3 RID: 58547 RVA: 0x0043218F File Offset: 0x0043038F
	private void ResetPreDownloadState()
	{
		this.HasDownloadStarted = false;
		this.CurrentDownloadMode = EPreDownloadMode.Normal;
		this.IsBinPatch = false;
		this.BinPatch = null;
		this.UpdateData = null;
	}

	// Token: 0x0600E4B4 RID: 58548 RVA: 0x004321B4 File Offset: 0x004303B4
	public bool IsPreDownloadAvailable()
	{
		IPreDownload preDownload = PreDownloadManager.Get();
		return Info.Instance.IsMobilePlatform() && preDownload.IsPreDownloadEnabled();
	}

	// Token: 0x0600E4B5 RID: 58549 RVA: 0x004321DB File Offset: 0x004303DB
	public bool IsComplete()
	{
		return PreDownloadManager.Get().IsComplete();
	}

	// Token: 0x0600E4B6 RID: 58550 RVA: 0x004321E8 File Offset: 0x004303E8
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

	// Token: 0x0600E4B7 RID: 58551 RVA: 0x00432222 File Offset: 0x00430422
	public bool HasClickBtnCheck()
	{
		return this.IsPreDownloadAvailable() && !this.HasDownloadStarted;
	}

	// Token: 0x0600E4B8 RID: 58552 RVA: 0x00432238 File Offset: 0x00430438
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

	// Token: 0x0600E4B9 RID: 58553 RVA: 0x004322D0 File Offset: 0x004304D0
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

	// Token: 0x0600E4BA RID: 58554 RVA: 0x00432310 File Offset: 0x00430510
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

	// Token: 0x0600E4BB RID: 58555 RVA: 0x0043234D File Offset: 0x0043054D
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

	// Token: 0x0600E4BC RID: 58556 RVA: 0x00432388 File Offset: 0x00430588
	private void OnReconnect()
	{
		IPreDownload preDownload = PreDownloadManager.Get();
		if (!this.IsPreDownloadAvailable() || !preDownload.IsDownloading())
		{
			return;
		}
		this.PausePreDownload(EPreDownloadPauseType.Reconnect);
	}

	// Token: 0x0600E4BD RID: 58557 RVA: 0x004323B4 File Offset: 0x004305B4
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

	// Token: 0x0600E4BE RID: 58558 RVA: 0x0043242C File Offset: 0x0043062C
	private bool IsSpaceEnough()
	{
		IPreDownload preDownload = PreDownloadManager.Get();
		string checkPath = UKuroLauncherLibrary.GameSavedDir();
		long num = 0L;
		UKuroLauncherLibrary.GetTotalAndFreeSpace(checkPath, ref num);
		long needSpace = preDownload.GetNeedSpace();
		return num >= needSpace + 10485760L;
	}

	// Token: 0x0600E4BF RID: 58559 RVA: 0x00432464 File Offset: 0x00430664
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

	// Token: 0x0600E4C0 RID: 58560 RVA: 0x004324E4 File Offset: 0x004306E4
	private void OnPreDownloadComplete()
	{
		PreDownloadDownloadModeSuccessRecord logData = new PreDownloadDownloadModeSuccessRecord((this.CurrentDownloadMode == EPreDownloadMode.Speed) ? 1 : 2);
		LogReportController.Instance.LogReport(logData);
		ScrollingTipsController.Instance.ShowTipsByTextId("PreDownload_Complete", Array.Empty<object>());
		EventSystem.Instance.Emit(EEventName.PreDownloadStateUpdate);
		PreDownloadManager.Get().RemoveCompleteEvent(new Action(this.OnPreDownloadComplete));
	}

	// Token: 0x0600E4C1 RID: 58561 RVA: 0x00432549 File Offset: 0x00430749
	public bool IsBinPatching()
	{
		return this.IsBinPatch;
	}

	// Token: 0x0600E4C2 RID: 58562 RVA: 0x00432551 File Offset: 0x00430751
	public void ClearView()
	{
		PreDownloadManager.Get().SetView(this.PreDownloadNoViewObj);
	}

	// Token: 0x0600E4C3 RID: 58563 RVA: 0x00432564 File Offset: 0x00430764
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

	// Token: 0x0600E4C4 RID: 58564 RVA: 0x004325D8 File Offset: 0x004307D8
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

	// Token: 0x0600E4C5 RID: 58565 RVA: 0x00432630 File Offset: 0x00430830
	public void AddEnableCheck()
	{
		PreDownloadManager.Get().AddEnabledEvent(new Action(this.OnPreDownloadEnable));
		LauncherLog.Instance.Info("On PreDownload AddEnabledEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600E4C6 RID: 58566 RVA: 0x0043266C File Offset: 0x0043086C
	private void OnPreDownloadEnable()
	{
		PreDownloadManager.Get().TryRemoveTick();
		LauncherLog.Instance.Info("OnPreDownloadEnable And RemoveTick", default(ReadOnlySpan<ValueTuple<string, object>>));
		EventSystem.Instance.Emit(EEventName.OnPreDownloadAvailableUpdate);
		EventSystem.Instance.Emit(EEventName.PreDownloadStateUpdate);
	}

	// Token: 0x170015DE RID: 5598
	// (get) Token: 0x0600E4C7 RID: 58567 RVA: 0x004326BB File Offset: 0x004308BB
	public static PreDownloadModel Instance
	{
		get
		{
			return PreDownloadModel._Instance;
		}
	}

	// Token: 0x0600E4C8 RID: 58568 RVA: 0x004326C2 File Offset: 0x004308C2
	public static PreDownloadModel GetOrCreateInstance()
	{
		if (PreDownloadModel._Instance == null)
		{
			PreDownloadModel.CreateInstance();
		}
		return PreDownloadModel._Instance;
	}

	// Token: 0x0600E4C9 RID: 58569 RVA: 0x004326D6 File Offset: 0x004308D6
	public static bool CreateInstance()
	{
		if (PreDownloadModel._Instance != null)
		{
			return true;
		}
		PreDownloadModel._Instance = new PreDownloadModel();
		return true;
	}

	// Token: 0x0600E4CA RID: 58570 RVA: 0x004326EC File Offset: 0x004308EC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E4CB RID: 58571 RVA: 0x004326EE File Offset: 0x004308EE
	public static void ResetStaticDefaultValue()
	{
		PreDownloadModel._Instance = null;
	}

	// Token: 0x0600E4CC RID: 58572 RVA: 0x004326F6 File Offset: 0x004308F6
	static PreDownloadModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PreDownloadModel.CreateStaticDefaultValue), new Action(PreDownloadModel.ResetStaticDefaultValue));
	}

	// Token: 0x040082BE RID: 33470
	private bool HasDownloadStarted;

	// Token: 0x040082BF RID: 33471
	private EPreDownloadMode CurrentDownloadMode;

	// Token: 0x040082C0 RID: 33472
	private bool IsBinPatch;

	// Token: 0x040082C1 RID: 33473
	public BinPatchData BinPatch;

	// Token: 0x040082C2 RID: 33474
	public UpdateDownData UpdateData;

	// Token: 0x040082C3 RID: 33475
	private PreDownloadNoView PreDownloadNoViewObj;

	// Token: 0x040082C4 RID: 33476
	[Nullable(2)]
	private static PreDownloadModel _Instance;
}
