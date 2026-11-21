using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update;

// Token: 0x02001C49 RID: 7241
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ResDownLoadModel : ModelBase
{
	// Token: 0x06011F9C RID: 73628 RVA: 0x00549776 File Offset: 0x00547976
	protected override bool OnInit()
	{
		VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.LoginPrepare).SetDownLoadStateChangeCallBack(new Action<EVideoDownloadStatus>(this.OnDownLoadStateChange));
		VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.LoginPrepare).SetDownLoadFailedCallBack(new Action<bool>(this.OnDownLoadFailed));
		return true;
	}

	// Token: 0x06011F9D RID: 73629 RVA: 0x005497B1 File Offset: 0x005479B1
	protected override bool OnClear()
	{
		this.ResSizeType = null;
		return true;
	}

	// Token: 0x06011F9E RID: 73630 RVA: 0x005497C0 File Offset: 0x005479C0
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

	// Token: 0x06011F9F RID: 73631 RVA: 0x0054988B File Offset: 0x00547A8B
	public void OnDownLoadFailed(bool noFreeSize)
	{
		if (noFreeSize)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("DownLoadTips_NotEnough", Array.Empty<object>());
		}
	}

	// Token: 0x06011FA0 RID: 73632 RVA: 0x005498A4 File Offset: 0x00547AA4
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

	// Token: 0x06011FA1 RID: 73633 RVA: 0x005499B0 File Offset: 0x00547BB0
	public bool NeedShowBattleViewButton()
	{
		QuestResourceModel.Instance.CalcPrepareResource();
		return (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male && VideoResUpdate.Instance.GetVideoResSize(EVideoResSizeType.MalePrepare) != VideoResUpdate.Instance.GetVideoResSavedSize(EVideoResSizeType.MalePrepare)) || (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female && VideoResUpdate.Instance.GetVideoResSize(EVideoResSizeType.FemalePrepare) != VideoResUpdate.Instance.GetVideoResSavedSize(EVideoResSizeType.FemalePrepare)) || VideoResUpdate.Instance.GetIsResPakDownloading(EVideoResSizeType.MalePrepare) || VideoResUpdate.Instance.GetIsResPakDownloading(EVideoResSizeType.FemalePrepare) || VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.FemalePrepare).GetDownLoadState() == EVideoDownloadStatus.Downloading || VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.MalePrepare).GetDownLoadState() == EVideoDownloadStatus.Downloading;
	}

	// Token: 0x17001B4B RID: 6987
	// (get) Token: 0x06011FA2 RID: 73634 RVA: 0x00549A5D File Offset: 0x00547C5D
	public static ResDownLoadModel Instance
	{
		get
		{
			return ResDownLoadModel._Instance;
		}
	}

	// Token: 0x06011FA3 RID: 73635 RVA: 0x00549A64 File Offset: 0x00547C64
	public static ResDownLoadModel GetOrCreateInstance()
	{
		if (ResDownLoadModel._Instance == null)
		{
			ResDownLoadModel.CreateInstance();
		}
		return ResDownLoadModel._Instance;
	}

	// Token: 0x06011FA4 RID: 73636 RVA: 0x00549A78 File Offset: 0x00547C78
	public static bool CreateInstance()
	{
		if (ResDownLoadModel._Instance != null)
		{
			return true;
		}
		ResDownLoadModel._Instance = new ResDownLoadModel();
		return true;
	}

	// Token: 0x06011FA5 RID: 73637 RVA: 0x00549A8E File Offset: 0x00547C8E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011FA6 RID: 73638 RVA: 0x00549A90 File Offset: 0x00547C90
	public static void ResetStaticDefaultValue()
	{
		ResDownLoadModel._Instance = null;
	}

	// Token: 0x06011FA7 RID: 73639 RVA: 0x00549A98 File Offset: 0x00547C98
	static ResDownLoadModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ResDownLoadModel.CreateStaticDefaultValue), new Action(ResDownLoadModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009CB2 RID: 40114
	public int CurrentDownLoadVideo = -1;

	// Token: 0x04009CB3 RID: 40115
	private EVideoResSizeType? ResSizeType;

	// Token: 0x04009CB4 RID: 40116
	[Nullable(2)]
	private static ResDownLoadModel _Instance;
}
