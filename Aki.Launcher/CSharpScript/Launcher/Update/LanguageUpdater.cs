using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Download;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200008D RID: 141
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageUpdater
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x0002F5FE File Offset: 0x0002D7FE
		public void Init(UObject worldContext, [Nullable(2)] LanguageUpdateUiEvent uiEvent)
		{
			this.VersionMisc.Init(worldContext);
			this.UpdateView = new LanguageUpdateViewAgent();
			if (uiEvent != null)
			{
				uiEvent.InitEvent(this.UpdateView);
			}
			this.CalculateDownloadStatus("LanguageUpdater Init");
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0002F634 File Offset: 0x0002D834
		public void Delete(UObject worldContext)
		{
			LanguageUpdater.SafeDeleteFile(this.VersionMisc.GetMountFilePath());
			List<PatchFileInfo> list = this.VersionMisc.ReadPatchFileInfoList();
			ResourceDiffUpdaterManager.Instance.VoiceModule.DeleteByAudioCode(this.LanguageCode);
			this.CalculateDownloadStatus("LanguageUpdater Delete");
			this.Status = ELanguageDownloadStatus.None;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0002F684 File Offset: 0x0002D884
		public UniTask Update(IResourceUpdateView updateViewImplement, UObject worldContext)
		{
			LanguageUpdater.<Update>d__14 <Update>d__;
			<Update>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Update>d__.<>4__this = this;
			<Update>d__.updateViewImplement = updateViewImplement;
			<Update>d__.worldContext = worldContext;
			<Update>d__.<>1__state = -1;
			<Update>d__.<>t__builder.Start<LanguageUpdater.<Update>d__14>(ref <Update>d__);
			return <Update>d__.<>t__builder.Task;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0002F6D8 File Offset: 0x0002D8D8
		private UniTask OldUpdate(IResourceUpdateView updateViewImplement, UObject worldContext)
		{
			LanguageUpdater.<OldUpdate>d__15 <OldUpdate>d__;
			<OldUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OldUpdate>d__.<>4__this = this;
			<OldUpdate>d__.updateViewImplement = updateViewImplement;
			<OldUpdate>d__.worldContext = worldContext;
			<OldUpdate>d__.<>1__state = -1;
			<OldUpdate>d__.<>t__builder.Start<LanguageUpdater.<OldUpdate>d__15>(ref <OldUpdate>d__);
			return <OldUpdate>d__.<>t__builder.Task;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0002F72C File Offset: 0x0002D92C
		private UniTask NewDiffUpdate(IResourceUpdateView updateViewImplement, UObject worldContext)
		{
			LanguageUpdater.<NewDiffUpdate>d__16 <NewDiffUpdate>d__;
			<NewDiffUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDiffUpdate>d__.<>4__this = this;
			<NewDiffUpdate>d__.updateViewImplement = updateViewImplement;
			<NewDiffUpdate>d__.<>1__state = -1;
			<NewDiffUpdate>d__.<>t__builder.Start<LanguageUpdater.<NewDiffUpdate>d__16>(ref <NewDiffUpdate>d__);
			return <NewDiffUpdate>d__.<>t__builder.Task;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0002F778 File Offset: 0x0002D978
		public void Pause()
		{
			LauncherLog.Instance.Info("Pause Language Downloading.", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Downloader.CancelDownload();
			this.IsDownloading = false;
			this.CalculateDownloadStatus("LanguageUpdater Pause");
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0002F7BC File Offset: 0x0002D9BC
		[NullableContext(2)]
		public unsafe void CalculateDownloadStatus(string reason = null)
		{
			if (!UKuroLauncherLibrary.NeedHotPatch())
			{
				this.Status = ELanguageDownloadStatus.Done;
				this.IsDownloading = false;
				LauncherLog instance = LauncherLog.Instance;
				string message = "CalculateDownloadStatus";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NeedHotPatch", UKuroLauncherLibrary.NeedHotPatch());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Status", this.Status);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("reason", reason);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			if (this.DiffResInfo == null)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "language res info is undefined";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
				instance2.Error(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ValueTuple<long, long> valueTuple2 = this.DiffResInfo.CalculateSavedSizeAndTotalSize();
			long num = valueTuple2.Item1;
			long num2 = valueTuple2.Item2;
			bool flag = this.DiffResInfo.IsCompleteUpdate();
			foreach (ResPackageInfo resPackageInfo in this.RoleVoiceResInfos)
			{
				ValueTuple<long, long> valueTuple3 = resPackageInfo.CalculateSavedSizeAndTotalSize();
				long item = valueTuple3.Item1;
				long item2 = valueTuple3.Item2;
				num += item;
				num2 += item2;
				if (!resPackageInfo.IsCompleteUpdate())
				{
					flag = false;
				}
			}
			this.LocalDiskSize = num;
			this.TotalDiskSize = num2;
			if ((num == num2 && flag) || !UKuroLauncherLibrary.NeedHotPatch() || Platform.Instance.IsHomeConsolePlatform() || Platform.Instance.IsMacPlatform())
			{
				this.Status = ELanguageDownloadStatus.Done;
				this.IsDownloading = false;
			}
			else if (num > 0L && num != num2)
			{
				this.Status = ELanguageDownloadStatus.Half;
			}
			else if (num == 0L)
			{
				this.Status = ELanguageDownloadStatus.None;
			}
			LauncherLog instance3 = LauncherLog.Instance;
			string message3 = "CalculateDownloadStatus";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("LocalDiskSize", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("TotalDiskSize", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("IsCompleteUpdate", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("NeedHotPatch", UKuroLauncherLibrary.NeedHotPatch());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("Status", this.Status);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("reason", reason);
			instance3.Info(message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0002FA5C File Offset: 0x0002DC5C
		private unsafe static void SafeDeleteFile(string filePath)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "SafeDeleteFile";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", filePath);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (UBlueprintPathsLibrary.FileExists(filePath))
			{
				bool flag = UKuroLauncherLibrary.DeleteFile(filePath);
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "SafeDeleteFile";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", filePath);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("result", flag);
				instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0002FB0D File Offset: 0x0002DD0D
		[CompilerGenerated]
		private void <OldUpdate>g__ProgressCb|15_0(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
			this.UpdateView.UpdatePatchProgress(receiveSize, curProgress, totalProgress, downloadSpeed);
		}

		// Token: 0x040002E9 RID: 745
		public ELanguageDownloadStatus Status;

		// Token: 0x040002EA RID: 746
		public bool IsDownloading;

		// Token: 0x040002EB RID: 747
		public long LocalDiskSize;

		// Token: 0x040002EC RID: 748
		public long TotalDiskSize;

		// Token: 0x040002ED RID: 749
		public string LanguageCode = "";

		// Token: 0x040002EE RID: 750
		[Nullable(2)]
		public UrlPrefixDownload Downloader;

		// Token: 0x040002EF RID: 751
		[Nullable(2)]
		public ResourceUpdate Updater;

		// Token: 0x040002F0 RID: 752
		[Nullable(2)]
		public DiffUpdate DiffUpdater;

		// Token: 0x040002F1 RID: 753
		[Nullable(2)]
		public LanguageVersionMisc VersionMisc;

		// Token: 0x040002F2 RID: 754
		[Nullable(2)]
		public ResPackageInfo DiffResInfo;

		// Token: 0x040002F3 RID: 755
		public List<ResPackageInfo> RoleVoiceResInfos = new List<ResPackageInfo>();

		// Token: 0x040002F4 RID: 756
		[Nullable(2)]
		public LanguageUpdateViewAgent UpdateView;
	}
}
