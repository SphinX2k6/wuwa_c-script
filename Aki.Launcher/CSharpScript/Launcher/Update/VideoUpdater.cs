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
	// Token: 0x0200009B RID: 155
	[NullableContext(2)]
	[Nullable(0)]
	public class VideoUpdater
	{
		// Token: 0x06000562 RID: 1378 RVA: 0x000316BB File Offset: 0x0002F8BB
		public void Init(VideoUpdateUiEvent uiEvent)
		{
			this.UpdateView = new ResourceUpdateViewAgent();
			if (uiEvent != null)
			{
				uiEvent.InitEvent(this.UpdateView);
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000316D8 File Offset: 0x0002F8D8
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

		// Token: 0x06000564 RID: 1380 RVA: 0x0003172C File Offset: 0x0002F92C
		[NullableContext(1)]
		public void SetCustomDownloadList(List<string> toDoList)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "设置自定义视频资源下载列表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("toDoList", toDoList);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ToDoList = toDoList;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00031764 File Offset: 0x0002F964
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

		// Token: 0x06000566 RID: 1382 RVA: 0x000317CE File Offset: 0x0002F9CE
		public EVideoDownloadStatus GetDownLoadState()
		{
			return this.Status;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000317D6 File Offset: 0x0002F9D6
		public void SetDownLoadStateChangeCallBack(Action<EVideoDownloadStatus> callback)
		{
			this.OnUpdateStateChange = callback;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000317DF File Offset: 0x0002F9DF
		public void SetDownLoadFailedCallBack(Action<bool> callback)
		{
			this.OnDownloadFailed = callback;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000317E8 File Offset: 0x0002F9E8
		public void SetDownloadFinishCallBack(Action<EVideoResSizeType> callback)
		{
			this.OnDownloadFinish = callback;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x000317F4 File Offset: 0x0002F9F4
		[NullableContext(0)]
		public ValueTuple<long, long, long, long> GetDownLoadProgress()
		{
			return new ValueTuple<long, long, long, long>(this.UpdateView.ReceiveSize + this.AllSize, this.UpdateView.CurProgress + this.AllSize - this.UpdateView.TotalProgress, this.AllSize, this.UpdateView.DownloadSpeed);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00031847 File Offset: 0x0002FA47
		[NullableContext(0)]
		public ValueTuple<double, double, double, bool> GetReportLogData()
		{
			return new ValueTuple<double, double, double, bool>((double)this.UpdateView.DownloadSpeedMax / 1048576.0, this.DownloadSizeMB, this.SpendTime, this.UpdateView.HasShowNotEnoughSpace);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0003187B File Offset: 0x0002FA7B
		public void ResetDownLoadProgress()
		{
			this.AllSize = 0L;
			this.UpdateView.ReceiveSize = 0L;
			this.UpdateView.CurProgress = 0L;
			this.UpdateView.TotalProgress = 0L;
			this.UpdateView.DownloadSpeed = 0L;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000318B9 File Offset: 0x0002FAB9
		public void SetDownLoadProgress(long curProgress, long totalProgress)
		{
			this.UpdateView.CurProgress = curProgress;
			this.UpdateView.TotalProgress = totalProgress;
			this.AllSize = totalProgress;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000318DA File Offset: 0x0002FADA
		public void ResetDownLoadState()
		{
			this.Status = EVideoDownloadStatus.None;
			this.ResetDownLoadProgress();
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x000318EC File Offset: 0x0002FAEC
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

		// Token: 0x06000570 RID: 1392 RVA: 0x00031944 File Offset: 0x0002FB44
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

		// Token: 0x06000571 RID: 1393 RVA: 0x00031A40 File Offset: 0x0002FC40
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

		// Token: 0x04000353 RID: 851
		private EVideoDownloadStatus Status;

		// Token: 0x04000354 RID: 852
		private Action<EVideoDownloadStatus> OnUpdateStateChange;

		// Token: 0x04000355 RID: 853
		private Action<bool> OnDownloadFailed;

		// Token: 0x04000356 RID: 854
		private Action<EVideoResSizeType> OnDownloadFinish;

		// Token: 0x04000357 RID: 855
		public UrlPrefixDownload Downloader;

		// Token: 0x04000358 RID: 856
		public DiffUpdate DiffUpdater;

		// Token: 0x04000359 RID: 857
		public ResPackageInfo DiffResInfo;

		// Token: 0x0400035A RID: 858
		public ResourceUpdateViewAgent UpdateView;

		// Token: 0x0400035B RID: 859
		[Nullable(1)]
		public List<string> ToDoList = new List<string>();

		// Token: 0x0400035C RID: 860
		public EVideoResSizeType TodoResSizeType;

		// Token: 0x0400035D RID: 861
		private long AllSize;

		// Token: 0x0400035E RID: 862
		private double DownloadSizeMB;

		// Token: 0x0400035F RID: 863
		private double SpendTime;
	}
}
