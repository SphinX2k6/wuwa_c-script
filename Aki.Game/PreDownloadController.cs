using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.PreDownload;

// Token: 0x020016F7 RID: 5879
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PreDownloadController : UiControllerBase
{
	// Token: 0x0600E494 RID: 58516 RVA: 0x00431BC5 File Offset: 0x0042FDC5
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600E495 RID: 58517 RVA: 0x00431BC8 File Offset: 0x0042FDC8
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0600E496 RID: 58518 RVA: 0x00431BCB File Offset: 0x0042FDCB
	protected override void OnAddEvents()
	{
	}

	// Token: 0x0600E497 RID: 58519 RVA: 0x00431BCD File Offset: 0x0042FDCD
	protected override void OnRemoveEvents()
	{
	}

	// Token: 0x0600E498 RID: 58520 RVA: 0x00431BD0 File Offset: 0x0042FDD0
	public void OnPreDownloadBtnClick(bool fromLogin)
	{
		if (PreDownloadManager.Get().IsComplete())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PreDownload_Complete", Array.Empty<object>());
			return;
		}
		PreDownloadEntranceRecord logData = new PreDownloadEntranceRecord(fromLogin ? 1 : 2);
		LogReportController.Instance.LogReport(logData);
		if (!PreDownloadModel.Instance.GetHasStartDownload())
		{
			this.OpenPreDownloadConfirmBox();
			return;
		}
		this.OpenPreDownloadView();
	}

	// Token: 0x0600E499 RID: 58521 RVA: 0x00431C30 File Offset: 0x0042FE30
	private void OpenPreDownloadConfirmBox()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PreDownloadConfirmBox);
		IPreDownload preDownload = PreDownloadManager.Get();
		string text = (preDownload.GetDownloadSize() / 1048576L).ToString() + "MB";
		string text2 = (preDownload.GetNeedSpace() / 1048576L).ToString() + "MB";
		confirmBoxDataNew.FunctionMap.Add(2, new Action(this.OpenPreDownloadView));
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			text,
			text2
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600E49A RID: 58522 RVA: 0x00431CC8 File Offset: 0x0042FEC8
	private void OpenPreDownloadView()
	{
		if (RemoteInfo.Instance.PreVerConfig != null)
		{
			string packageVersion = RemoteInfo.Instance.PreVerConfig.PackageVersion;
			LocalStorage.SetGlobal<string>(ELocalStorageGlobalKey.PreDownloadVersionRecord, packageVersion);
		}
		UiManager.Instance.OpenView(EUiViewName.PreDownloadView, null, null);
	}

	// Token: 0x0600E49B RID: 58523 RVA: 0x00431D0E File Offset: 0x0042FF0E
	public void ClosePreDownloadView()
	{
		UiManager.Instance.CloseView(EUiViewName.PreDownloadView, null);
		if (PreDownloadManager.Get().IsDownloading())
		{
			PreDownloadModel.Instance.SetDownloadMode(EPreDownloadMode.Normal);
		}
	}

	// Token: 0x0600E49C RID: 58524 RVA: 0x00431D38 File Offset: 0x0042FF38
	public void OnCellNetTypeChanged()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.PreDownloadView))
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PreDownloadNoWifi);
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				if (!PreDownloadModel.Instance.GetHasStartDownload() && UiManager.Instance.IsViewShow(EUiViewName.PreDownloadView))
				{
					UiManager.Instance.CloseView(EUiViewName.PreDownloadView, null);
				}
			});
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				PreDownloadModel.Instance.ResumePreDownload();
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("PreDownload_ChangeCellNet", Array.Empty<object>());
	}

	// Token: 0x0600E49D RID: 58525 RVA: 0x00431DD8 File Offset: 0x0042FFD8
	public string GetLocalText(string textTableId, params string[] args)
	{
		string hotPatchText = LauncherConfigLib.Instance.GetHotPatchText(textTableId);
		if (string.IsNullOrEmpty(hotPatchText))
		{
			return "";
		}
		string text = hotPatchText;
		if (args != null)
		{
			for (int i = 0; i < args.Length; i++)
			{
				string newValue = args[i];
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("{");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				defaultInterpolatedStringHandler.AppendLiteral("}");
				string oldValue = defaultInterpolatedStringHandler.ToStringAndClear();
				text = text.Replace(oldValue, newValue);
			}
		}
		return text;
	}

	// Token: 0x170015DD RID: 5597
	// (get) Token: 0x0600E49E RID: 58526 RVA: 0x00431E53 File Offset: 0x00430053
	public static PreDownloadController Instance
	{
		get
		{
			return PreDownloadController._Instance;
		}
	}

	// Token: 0x0600E49F RID: 58527 RVA: 0x00431E5A File Offset: 0x0043005A
	public static PreDownloadController GetOrCreateInstance()
	{
		if (PreDownloadController._Instance == null)
		{
			PreDownloadController.CreateInstance();
		}
		return PreDownloadController._Instance;
	}

	// Token: 0x0600E4A0 RID: 58528 RVA: 0x00431E6E File Offset: 0x0043006E
	public static bool CreateInstance()
	{
		if (PreDownloadController._Instance != null)
		{
			return true;
		}
		PreDownloadController._Instance = new PreDownloadController();
		return true;
	}

	// Token: 0x0600E4A1 RID: 58529 RVA: 0x00431E84 File Offset: 0x00430084
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E4A2 RID: 58530 RVA: 0x00431E86 File Offset: 0x00430086
	public static void ResetStaticDefaultValue()
	{
		PreDownloadController._Instance = null;
	}

	// Token: 0x0600E4A3 RID: 58531 RVA: 0x00431E8E File Offset: 0x0043008E
	static PreDownloadController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PreDownloadController.CreateStaticDefaultValue), new Action(PreDownloadController.ResetStaticDefaultValue));
	}

	// Token: 0x040082A7 RID: 33447
	[Nullable(2)]
	private static PreDownloadController _Instance;
}
