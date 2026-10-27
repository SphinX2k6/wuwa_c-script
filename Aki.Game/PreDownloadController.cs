using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.PreDownload;

// Token: 0x02002213 RID: 8723
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PreDownloadController : UiControllerBase
{
	// Token: 0x06010FFE RID: 69630 RVA: 0x00425029 File Offset: 0x00423229
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06010FFF RID: 69631 RVA: 0x0042502C File Offset: 0x0042322C
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06011000 RID: 69632 RVA: 0x0042502F File Offset: 0x0042322F
	protected override void OnAddEvents()
	{
	}

	// Token: 0x06011001 RID: 69633 RVA: 0x00425031 File Offset: 0x00423231
	protected override void OnRemoveEvents()
	{
	}

	// Token: 0x06011002 RID: 69634 RVA: 0x00425034 File Offset: 0x00423234
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

	// Token: 0x06011003 RID: 69635 RVA: 0x00425094 File Offset: 0x00423294
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

	// Token: 0x06011004 RID: 69636 RVA: 0x0042512C File Offset: 0x0042332C
	private void OpenPreDownloadView()
	{
		if (RemoteInfo.Instance.PreVerConfig != null)
		{
			string packageVersion = RemoteInfo.Instance.PreVerConfig.PackageVersion;
			LocalStorage.SetGlobal<string>(ELocalStorageGlobalKey.PreDownloadVersionRecord, packageVersion);
		}
		UiManager.Instance.OpenView(EUiViewName.PreDownloadView, null, null);
	}

	// Token: 0x06011005 RID: 69637 RVA: 0x00425172 File Offset: 0x00423372
	public void ClosePreDownloadView()
	{
		UiManager.Instance.CloseView(EUiViewName.PreDownloadView, null);
		if (PreDownloadManager.Get().IsDownloading())
		{
			PreDownloadModel.Instance.SetDownloadMode(EPreDownloadMode.Normal);
		}
	}

	// Token: 0x06011006 RID: 69638 RVA: 0x0042519C File Offset: 0x0042339C
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

	// Token: 0x06011007 RID: 69639 RVA: 0x0042523C File Offset: 0x0042343C
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

	// Token: 0x170015A6 RID: 5542
	// (get) Token: 0x06011008 RID: 69640 RVA: 0x004252B7 File Offset: 0x004234B7
	public static PreDownloadController Instance
	{
		get
		{
			return PreDownloadController._Instance;
		}
	}

	// Token: 0x06011009 RID: 69641 RVA: 0x004252BE File Offset: 0x004234BE
	public static PreDownloadController GetOrCreateInstance()
	{
		if (PreDownloadController._Instance == null)
		{
			PreDownloadController.CreateInstance();
		}
		return PreDownloadController._Instance;
	}

	// Token: 0x0601100A RID: 69642 RVA: 0x004252D2 File Offset: 0x004234D2
	public static bool CreateInstance()
	{
		if (PreDownloadController._Instance != null)
		{
			return true;
		}
		PreDownloadController._Instance = new PreDownloadController();
		return true;
	}

	// Token: 0x0601100B RID: 69643 RVA: 0x004252E8 File Offset: 0x004234E8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601100C RID: 69644 RVA: 0x004252EA File Offset: 0x004234EA
	public static void ResetStaticDefaultValue()
	{
		PreDownloadController._Instance = null;
	}

	// Token: 0x0601100D RID: 69645 RVA: 0x004252F2 File Offset: 0x004234F2
	static PreDownloadController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PreDownloadController.CreateStaticDefaultValue), new Action(PreDownloadController.ResetStaticDefaultValue));
	}

	// Token: 0x04008169 RID: 33129
	[Nullable(2)]
	private static PreDownloadController _Instance;
}
