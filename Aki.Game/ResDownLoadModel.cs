using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update;

// Token: 0x0200275E RID: 10078
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ResDownLoadModel : ModelBase
{
	// Token: 0x06014AB9 RID: 84665 RVA: 0x0053A8E2 File Offset: 0x00538AE2
	protected override bool OnInit()
	{
		VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.LoginPrepare).SetDownLoadStateChangeCallBack(new Action<EVideoDownloadStatus>(this.OnDownLoadStateChange));
		VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.LoginPrepare).SetDownLoadFailedCallBack(new Action<bool>(this.OnDownLoadFailed));
		return true;
	}

	// Token: 0x06014ABA RID: 84666 RVA: 0x0053A91D File Offset: 0x00538B1D
	protected override bool OnClear()
	{
		this.ResSizeType = null;
		return true;
	}

	// Token: 0x06014ABB RID: 84667 RVA: 0x0053A92C File Offset: 0x00538B2C
	public void OnDownLoadStateChange(EVideoDownloadStatus state)
	{
		if (state == EVideoDownloadStatus.Done)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.ResDownLoadView))
			{
				UiManager.Instance.CloseView(EUiViewName.ResDownLoadView, null);
			}
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			if ((playerGender == EPlayerGender.Female && this.CurrentDownLoadVideo == 3) || (playerGender == EPlayerGender.Male && this.CurrentDownLoadVideo == 4))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DownloadCompletedTip1", Array.Empty<object>());
			}
			else if ((playerGender == EPlayerGender.Male && this.CurrentDownLoadVideo == 3) || (playerGender == EPlayerGender.Female && this.CurrentDownLoadVideo == 4))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DownloadCompletedTip2", Array.Empty<object>());
			}
			this.CurrentDownLoadVideo = -1;
		}
		else if (state == EVideoDownloadStatus.Pause)
		{
			this.CurrentDownLoadVideo = -1;
		}
		QuestResourceModel.Instance.RefreshCachePrepareResourceSize();
		EventSystem.Instance.Emit<EVideoDownloadStatus>(EEventName.ResDownLoadStateRefresh, state);
	}

	// Token: 0x06014ABC RID: 84668 RVA: 0x0053A9F7 File Offset: 0x00538BF7
	public void OnDownLoadFailed(bool noFreeSize)
	{
		if (noFreeSize)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("DownLoadTips_NotEnough", Array.Empty<object>());
		}
	}

	// Token: 0x06014ABD RID: 84669 RVA: 0x0053AA10 File Offset: 0x00538C10
	[NullableContext(0)]
	public ValueTuple<float, EVideoDownloadStatus> DownLoadPercentage()
	{
		int downLoadState = (int)VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.FemalePrepare).GetDownLoadState();
		EVideoDownloadStatus downLoadState2 = VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.MalePrepare).GetDownLoadState();
		if (downLoadState == 1)
		{
			this.ResSizeType = new EVideoResSizeType?(EVideoResSizeType.FemalePrepare);
		}
		else if (downLoadState2 == EVideoDownloadStatus.Downloading)
		{
			this.ResSizeType = new EVideoResSizeType?(EVideoResSizeType.MalePrepare);
		}
		else if (this.ResSizeType == null)
		{
			if (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male)
			{
				this.ResSizeType = new EVideoResSizeType?(EVideoResSizeType.MalePrepare);
			}
			else
			{
				this.ResSizeType = new EVideoResSizeType?(EVideoResSizeType.FemalePrepare);
			}
		}
		VideoUpdater videoUpdater = VideoUpdateManager.Instance.GetVideoUpdater(this.ResSizeType.Value);
		ValueTuple<long, long, long, long> downLoadProgress = videoUpdater.GetDownLoadProgress();
		if (downLoadProgress.Item3 != 0L && downLoadProgress.Item2 > 0L)
		{
			return new ValueTuple<float, EVideoDownloadStatus>((float)downLoadProgress.Item2 / (float)downLoadProgress.Item3, videoUpdater.GetDownLoadState());
		}
		float videoResSavedSize = (float)VideoResUpdate.Instance.GetVideoResSavedSize(this.ResSizeType.Value);
		long videoResSize = VideoResUpdate.Instance.GetVideoResSize(this.ResSizeType.Value);
		return new ValueTuple<float, EVideoDownloadStatus>(videoResSavedSize / (float)videoResSize, videoUpdater.GetDownLoadState());
	}

	// Token: 0x06014ABE RID: 84670 RVA: 0x0053AB1C File Offset: 0x00538D1C
	public bool NeedShowBattleViewButton()
	{
		QuestResourceModel.Instance.CalcPrepareResource();
		return (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male && VideoResUpdate.Instance.GetVideoResSize(EVideoResSizeType.MalePrepare) != VideoResUpdate.Instance.GetVideoResSavedSize(EVideoResSizeType.MalePrepare)) || (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female && VideoResUpdate.Instance.GetVideoResSize(EVideoResSizeType.FemalePrepare) != VideoResUpdate.Instance.GetVideoResSavedSize(EVideoResSizeType.FemalePrepare)) || VideoResUpdate.Instance.GetIsResPakDownloading(EVideoResSizeType.MalePrepare) || VideoResUpdate.Instance.GetIsResPakDownloading(EVideoResSizeType.FemalePrepare) || VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.FemalePrepare).GetDownLoadState() == EVideoDownloadStatus.Downloading || VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.MalePrepare).GetDownLoadState() == EVideoDownloadStatus.Downloading;
	}

	// Token: 0x17001B12 RID: 6930
	// (get) Token: 0x06014ABF RID: 84671 RVA: 0x0053ABC9 File Offset: 0x00538DC9
	public static ResDownLoadModel Instance
	{
		get
		{
			return ResDownLoadModel._Instance;
		}
	}

	// Token: 0x06014AC0 RID: 84672 RVA: 0x0053ABD0 File Offset: 0x00538DD0
	public static ResDownLoadModel GetOrCreateInstance()
	{
		if (ResDownLoadModel._Instance == null)
		{
			ResDownLoadModel.CreateInstance();
		}
		return ResDownLoadModel._Instance;
	}

	// Token: 0x06014AC1 RID: 84673 RVA: 0x0053ABE4 File Offset: 0x00538DE4
	public static bool CreateInstance()
	{
		if (ResDownLoadModel._Instance != null)
		{
			return true;
		}
		ResDownLoadModel._Instance = new ResDownLoadModel();
		return true;
	}

	// Token: 0x06014AC2 RID: 84674 RVA: 0x0053ABFA File Offset: 0x00538DFA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014AC3 RID: 84675 RVA: 0x0053ABFC File Offset: 0x00538DFC
	public static void ResetStaticDefaultValue()
	{
		ResDownLoadModel._Instance = null;
	}

	// Token: 0x06014AC4 RID: 84676 RVA: 0x0053AC04 File Offset: 0x00538E04
	static ResDownLoadModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ResDownLoadModel.CreateStaticDefaultValue), new Action(ResDownLoadModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009B59 RID: 39769
	public int CurrentDownLoadVideo = -1;

	// Token: 0x04009B5A RID: 39770
	private EVideoResSizeType? ResSizeType;

	// Token: 0x04009B5B RID: 39771
	[Nullable(2)]
	private static ResDownLoadModel _Instance;
}
