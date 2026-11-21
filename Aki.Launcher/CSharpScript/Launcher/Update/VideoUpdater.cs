using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Download;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200009E RID: 158
	[NullableContext(2)]
	[Nullable(0)]
	public class VideoUpdater
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x00032C23 File Offset: 0x00030E23
		public void Init(VideoUpdateUiEvent uiEvent)
		{
			this.UpdateView = new ResourceUpdateViewAgent();
			if (uiEvent != null)
			{
				uiEvent.InitEvent(this.UpdateView);
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00032C40 File Offset: 0x00030E40
		[NullableContext(0)]
		public UniTask<bool> Update(EVideoResSizeType videoResSizeType, [Nullable(1)] IResourceUpdateView updateViewImplement)
		{
			VideoUpdater.<Update>d__14 <Update>d__;
			<Update>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Update>d__.<>4__this = this;
			<Update>d__.videoResSizeType = videoResSizeType;
			<Update>d__.updateViewImplement = updateViewImplement;
			<Update>d__.<>1__state = -1;
			<Update>d__.<>t__builder.Start<VideoUpdater.<Update>d__14>(ref <Update>d__);
			return <Update>d__.<>t__builder.Task;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00032C94 File Offset: 0x00030E94
		[NullableContext(1)]
		public void SetCustomDownloadList(List<string> toDoList)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "设置自定义视频资源下载列表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("toDoList", toDoList);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ToDoList = toDoList;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00032CCC File Offset: 0x00030ECC
		[NullableContext(0)]
		public ValueTuple<bool, long> DoesSavedDirHaveEnoughSpace()
		{
			ValueTuple<List<RequireFileInfo>, long, long, List<LocalFileInfo>> valueTuple = VideoResUpdate.Instance.AnalyzeRequireFilesByNames(this.ToDoList);
			long item = valueTuple.Item2;
			long item2 = valueTuple.Item3;
			if (VideoResUpdate.Instance.GetFreeSpace() + 10485760L < item - item2)
			{
				LauncherLog.Instance.Warn("下载空间不足", default(ReadOnlySpan<ValueTuple<string, object>>));
				return new ValueTuple<bool, long>(false, item - item2);
			}
			return new ValueTuple<bool, long>(true, 0L);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00032D36 File Offset: 0x00030F36
		public EVideoDownloadStatus GetDownLoadState()
		{
			return this.Status;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00032D3E File Offset: 0x00030F3E
		public void SetDownLoadStateChangeCallBack(Action<EVideoDownloadStatus> callback)
		{
			this.OnUpdateStateChange = callback;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00032D47 File Offset: 0x00030F47
		public void SetDownLoadFailedCallBack(Action<bool> callback)
		{
			this.OnDownloadFailed = callback;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00032D50 File Offset: 0x00030F50
		public void SetDownloadFinishCallBack(Action<EVideoResSizeType> callback)
		{
			this.OnDownloadFinish = callback;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00032D5C File Offset: 0x00030F5C
		[NullableContext(0)]
		public ValueTuple<long, long, long, long> GetDownLoadProgress()
		{
			return new ValueTuple<long, long, long, long>(this.UpdateView.ReceiveSize + this.AllSize, this.UpdateView.CurProgress + this.AllSize - this.UpdateView.TotalProgress, this.AllSize, this.UpdateView.DownloadSpeed);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00032DAF File Offset: 0x00030FAF
		[NullableContext(0)]
		public ValueTuple<double, double, double, bool> GetReportLogData()
		{
			return new ValueTuple<double, double, double, bool>((double)this.UpdateView.DownloadSpeedMax / 1048576.0, this.DownloadSizeMB, this.SpendTime, this.UpdateView.HasShowNotEnoughSpace);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00032DE3 File Offset: 0x00030FE3
		public void ResetDownLoadProgress()
		{
			this.AllSize = 0L;
			this.UpdateView.ReceiveSize = 0L;
			this.UpdateView.CurProgress = 0L;
			this.UpdateView.TotalProgress = 0L;
			this.UpdateView.DownloadSpeed = 0L;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00032E21 File Offset: 0x00031021
		public void SetDownLoadProgress(long curProgress, long totalProgress)
		{
			this.UpdateView.CurProgress = curProgress;
			this.UpdateView.TotalProgress = totalProgress;
			this.AllSize = totalProgress;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00032E42 File Offset: 0x00031042
		public void ResetDownLoadState()
		{
			this.Status = EVideoDownloadStatus.None;
			this.ResetDownLoadProgress();
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00032E54 File Offset: 0x00031054
		public void Pause()
		{
			LauncherLog.Instance.Info("VideoDown Pause", default(ReadOnlySpan<ValueTuple<string, object>>));
			DiffUpdate diffUpdater = this.DiffUpdater;
			if (diffUpdater != null)
			{
				diffUpdater.Stop();
			}
			this.Status = EVideoDownloadStatus.Pause;
			if (this.OnUpdateStateChange != null)
			{
				this.OnUpdateStateChange(this.Status);
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00032EAC File Offset: 0x000310AC
		public void CancelDownload()
		{
			LauncherLog.Instance.Info("Cancel Video Downloading.", default(ReadOnlySpan<ValueTuple<string, object>>));
			DiffUpdate diffUpdater = this.DiffUpdater;
			if (diffUpdater != null)
			{
				diffUpdater.Stop();
			}
			IReadOnlyList<string> readOnlyList;
			if (this.TodoResSizeType == EVideoResSizeType.Custom)
			{
				readOnlyList = this.ToDoList;
			}
			else
			{
				readOnlyList = VideoResUpdate.Instance.GetAllSpecialVideoResPak(this.TodoResSizeType);
			}
			string str = VideoResUpdate.Instance.GetVideoLocalSavePath(null) + "/";
			foreach (string str2 in readOnlyList)
			{
				string text = str + str2;
				if (UBlueprintPathsLibrary.DirectoryExists(text))
				{
					UKuroLauncherLibrary.DeleteDirectory(text);
				}
			}
			this.ResetDownLoadProgress();
			this.TodoResSizeType = EVideoResSizeType.NoSize;
			this.Status = EVideoDownloadStatus.None;
			if (this.OnUpdateStateChange != null)
			{
				this.OnUpdateStateChange(this.Status);
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00032FA8 File Offset: 0x000311A8
		public unsafe void UpdateDeviceSave(EVideoResSizeType videoResSizeType)
		{
			if (this.Status == EVideoDownloadStatus.Done)
			{
				int deviceSaved = LauncherStorageLib.Instance.GetDeviceSaved<int>(ELauncherStorageDeviceKey.UserSelectedVideoUpdate, 0);
				EVideoResSizeType evideoResSizeType = (EVideoResSizeType)deviceSaved;
				if (deviceSaved == 2 && videoResSizeType == EVideoResSizeType.FemalePrepare)
				{
					evideoResSizeType = EVideoResSizeType.FemalePrepare;
				}
				else if (deviceSaved == 2 && videoResSizeType == EVideoResSizeType.MalePrepare)
				{
					evideoResSizeType = EVideoResSizeType.MalePrepare;
				}
				else if (deviceSaved == 4 && videoResSizeType == EVideoResSizeType.FemalePrepare)
				{
					evideoResSizeType = EVideoResSizeType.StartMaxNeed;
				}
				else if (deviceSaved == 3 && videoResSizeType == EVideoResSizeType.MalePrepare)
				{
					evideoResSizeType = EVideoResSizeType.StartMaxNeed;
				}
				else
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "视频下载类型和设备存储类型没有变化";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("userSelectedDownload", deviceSaved);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("videoResSizeType", videoResSizeType);
					instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "保存新下载类型";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("userSelectedDownload", deviceSaved);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("newUserSelectedDownload", evideoResSizeType);
				instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				LauncherStorageLib.Instance.SetDeviceSaved<int>(ELauncherStorageDeviceKey.UserSelectedVideoUpdate, (int)evideoResSizeType);
			}
		}

		// Token: 0x04000381 RID: 897
		private EVideoDownloadStatus Status;

		// Token: 0x04000382 RID: 898
		private Action<EVideoDownloadStatus> OnUpdateStateChange;

		// Token: 0x04000383 RID: 899
		private Action<bool> OnDownloadFailed;

		// Token: 0x04000384 RID: 900
		private Action<EVideoResSizeType> OnDownloadFinish;

		// Token: 0x04000385 RID: 901
		public UrlPrefixDownload Downloader;

		// Token: 0x04000386 RID: 902
		public DiffUpdate DiffUpdater;

		// Token: 0x04000387 RID: 903
		public ResPackageInfo DiffResInfo;

		// Token: 0x04000388 RID: 904
		public ResourceUpdateViewAgent UpdateView;

		// Token: 0x04000389 RID: 905
		[Nullable(1)]
		public List<string> ToDoList = new List<string>();

		// Token: 0x0400038A RID: 906
		public EVideoResSizeType TodoResSizeType;

		// Token: 0x0400038B RID: 907
		private long AllSize;

		// Token: 0x0400038C RID: 908
		private double DownloadSizeMB;

		// Token: 0x0400038D RID: 909
		private double SpendTime;
	}
}
