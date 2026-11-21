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
	// Token: 0x02000090 RID: 144
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageUpdater
	{
		// Token: 0x06000528 RID: 1320 RVA: 0x00030B66 File Offset: 0x0002ED66
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

		// Token: 0x06000529 RID: 1321 RVA: 0x00030B9C File Offset: 0x0002ED9C
		public void Delete(UObject worldContext)
		{
			LanguageUpdater.SafeDeleteFile(this.VersionMisc.GetMountFilePath());
			List<PatchFileInfo> list = this.VersionMisc.ReadPatchFileInfoList();
			ResourceDiffUpdaterManager.Instance.VoiceModule.DeleteByAudioCode(this.LanguageCode);
			this.CalculateDownloadStatus("LanguageUpdater Delete");
			this.Status = ELanguageDownloadStatus.None;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00030BEC File Offset: 0x0002EDEC
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

		// Token: 0x0600052B RID: 1323 RVA: 0x00030C40 File Offset: 0x0002EE40
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

		// Token: 0x0600052C RID: 1324 RVA: 0x00030C94 File Offset: 0x0002EE94
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

		// Token: 0x0600052D RID: 1325 RVA: 0x00030CE0 File Offset: 0x0002EEE0
		public void Pause()
		{
			LauncherLog.Instance.Info("Pause Language Downloading.", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Downloader.CancelDownload();
			this.IsDownloading = false;
			this.CalculateDownloadStatus("LanguageUpdater Pause");
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00030D24 File Offset: 0x0002EF24
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

		// Token: 0x0600052F RID: 1327 RVA: 0x00030FC4 File Offset: 0x0002F1C4
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

		// Token: 0x06000531 RID: 1329 RVA: 0x00031075 File Offset: 0x0002F275
		[CompilerGenerated]
		private void <OldUpdate>g__ProgressCb|15_0(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
			this.UpdateView.UpdatePatchProgress(receiveSize, curProgress, totalProgress, downloadSpeed);
		}

		// Token: 0x04000317 RID: 791
		public ELanguageDownloadStatus Status;

		// Token: 0x04000318 RID: 792
		public bool IsDownloading;

		// Token: 0x04000319 RID: 793
		public long LocalDiskSize;

		// Token: 0x0400031A RID: 794
		public long TotalDiskSize;

		// Token: 0x0400031B RID: 795
		public string LanguageCode = "";

		// Token: 0x0400031C RID: 796
		[Nullable(2)]
		public UrlPrefixDownload Downloader;

		// Token: 0x0400031D RID: 797
		[Nullable(2)]
		public ResourceUpdate Updater;

		// Token: 0x0400031E RID: 798
		[Nullable(2)]
		public DiffUpdate DiffUpdater;

		// Token: 0x0400031F RID: 799
		[Nullable(2)]
		public LanguageVersionMisc VersionMisc;

		// Token: 0x04000320 RID: 800
		[Nullable(2)]
		public ResPackageInfo DiffResInfo;

		// Token: 0x04000321 RID: 801
		public List<ResPackageInfo> RoleVoiceResInfos = new List<ResPackageInfo>();

		// Token: 0x04000322 RID: 802
		[Nullable(2)]
		public LanguageUpdateViewAgent UpdateView;
	}
}
