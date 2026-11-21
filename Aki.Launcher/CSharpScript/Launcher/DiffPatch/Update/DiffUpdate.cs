using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.Download;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x0200020B RID: 523
	[NullableContext(1)]
	[Nullable(0)]
	public class DiffUpdate
	{
		// Token: 0x06000D80 RID: 3456 RVA: 0x00052E00 File Offset: 0x00051000
		public DiffUpdate(List<ResPackageInfo> resPackageInfos, UrlPrefixDownload downloader, [Nullable(2)] IDiffUpdateUiEvent uiEvent, [Nullable(2)] IDiffUpdateReportEvent reportEvent, bool forceUpdate = false, EUpdateType updateType = EUpdateType.NormalUpdate)
		{
			this.ResPackageInfos = resPackageInfos;
			this.Downloader = downloader;
			this.UiEvent = uiEvent;
			this.ReportEvent = reportEvent;
			this.ForceUpdate = forceUpdate;
			this.UpdateType = updateType;
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x00052E68 File Offset: 0x00051068
		protected UKuroNetworkChange NetworkListener
		{
			get
			{
				if (this.NetworkListenerInternal == null)
				{
					this.NetworkListenerInternal = new UKuroNetworkChange();
				}
				return this.NetworkListenerInternal;
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00052E84 File Offset: 0x00051084
		[return: Nullable(2)]
		private RequestFileInfo CreateManifestRequestOrNot(string filePath, string hash, string remoteRoute)
		{
			if (hash == null || hash.Length == 0)
			{
				return null;
			}
			if (UKuroLauncherLibrary.CheckFileSha1(filePath, hash))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "已下载过清单文件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("manifest", filePath);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			if (UBlueprintPathsLibrary.FileExists(filePath))
			{
				UKuroLauncherLibrary.DeleteFile(filePath);
			}
			return new RequestFileInfo
			{
				HashString = hash,
				Size = new long?(0L),
				bUseDownloadCache = false,
				Url = (remoteRoute ?? ""),
				SavePath = filePath
			};
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00052F14 File Offset: 0x00051114
		private List<ResPackageInfo> EnumeratePacksWithTierChildren()
		{
			HashSet<ResPackageInfo> hashSet = new HashSet<ResPackageInfo>(this.ResPackageInfos);
			foreach (ResPackageInfo resPackageInfo in this.ResPackageInfos)
			{
				foreach (ResPackageInfo item in resPackageInfo.GetAllTierPackageInfos())
				{
					hashSet.Add(item);
				}
			}
			return new List<ResPackageInfo>(hashSet);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00052FB4 File Offset: 0x000511B4
		private List<ResPackageInfo> EnumeratePacksWithActiveTierChild(ETier? tier = null)
		{
			return ResPackageInfo.EnumerateWithTierChild(this.ResPackageInfos, tier ?? RemoteInfo.Instance.ActiveTier);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00052FEC File Offset: 0x000511EC
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public UniTask<List<RequestFileInfo>> HasContentOnRemote()
		{
			DiffUpdate.<HasContentOnRemote>d__27 <HasContentOnRemote>d__;
			<HasContentOnRemote>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<RequestFileInfo>>.Create();
			<HasContentOnRemote>d__.<>4__this = this;
			<HasContentOnRemote>d__.<>1__state = -1;
			<HasContentOnRemote>d__.<>t__builder.Start<DiffUpdate.<HasContentOnRemote>d__27>(ref <HasContentOnRemote>d__);
			return <HasContentOnRemote>d__.<>t__builder.Task;
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00053030 File Offset: 0x00051230
		[NullableContext(0)]
		public UniTask<bool> DownloadManifests([Nullable(1)] List<RequestFileInfo> requests)
		{
			DiffUpdate.<DownloadManifests>d__28 <DownloadManifests>d__;
			<DownloadManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadManifests>d__.<>4__this = this;
			<DownloadManifests>d__.requests = requests;
			<DownloadManifests>d__.<>1__state = -1;
			<DownloadManifests>d__.<>t__builder.Start<DiffUpdate.<DownloadManifests>d__28>(ref <DownloadManifests>d__);
			return <DownloadManifests>d__.<>t__builder.Task;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0005307C File Offset: 0x0005127C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private ValueTuple<bool, string> LoadManifest(string filePath)
		{
			string inCipher = null;
			if (!UKuroStaticLibrary.LoadFileToString(ref inCipher, filePath))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "index文件不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("file", filePath);
				instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new ValueTuple<bool, string>(false, "");
			}
			string text = null;
			if (!UKuroLauncherLibrary.Decrypt(inCipher, ref text))
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "index文件内容无法解析";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("file", filePath);
				instance2.Warn(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return new ValueTuple<bool, string>(false, "");
			}
			string item = text.Trim();
			return new ValueTuple<bool, string>(true, item);
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00053110 File Offset: 0x00051310
		[NullableContext(0)]
		public UniTask<bool> ResolveManifests()
		{
			DiffUpdate.<ResolveManifests>d__30 <ResolveManifests>d__;
			<ResolveManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ResolveManifests>d__.<>4__this = this;
			<ResolveManifests>d__.<>1__state = -1;
			<ResolveManifests>d__.<>t__builder.Start<DiffUpdate.<ResolveManifests>d__30>(ref <ResolveManifests>d__);
			return <ResolveManifests>d__.<>t__builder.Task;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00053154 File Offset: 0x00051354
		public void ForEachExpectedTargetFile(Action<string, string, long, string> visitor)
		{
			foreach (ResPackageInfo resPackageInfo in this.ResPackageInfos)
			{
				if (resPackageInfo.NeedProcessUpdate(this.ForceUpdate))
				{
					resPackageInfo.EnumerateExpectedTargetFiles(visitor);
				}
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x000531B8 File Offset: 0x000513B8
		public void ForEachExpectedExtraTargetFile(Action<string, string, long, string> visitor)
		{
			if (this.ExtraRequireFileInfo != null && this.ExtraRequireFileInfo.Count > 0)
			{
				foreach (RequireFileInfo requireFileInfo in this.ExtraRequireFileInfo)
				{
					string text = requireFileInfo.LocalPath.Replace("\\", "/");
					int num = text.LastIndexOf('/');
					string arg = text.Substring(num + 1);
					visitor(arg, requireFileInfo.Hash, requireFileInfo.Size, requireFileInfo.LocalPath);
				}
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0005325C File Offset: 0x0005145C
		[return: Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})]
		public UniTask<ValueTuple<bool, List<RequireFileInfo>, long, EUpdateMode, long, long>> AnalyzeRequireFiles(EUpdateMode updateMode = EUpdateMode.All, bool firstTimeUpdate = false, bool bIsLauncher = false)
		{
			DiffUpdate.<AnalyzeRequireFiles>d__33 <AnalyzeRequireFiles>d__;
			<AnalyzeRequireFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<bool, List<RequireFileInfo>, long, EUpdateMode, long, long>>.Create();
			<AnalyzeRequireFiles>d__.<>4__this = this;
			<AnalyzeRequireFiles>d__.updateMode = updateMode;
			<AnalyzeRequireFiles>d__.firstTimeUpdate = firstTimeUpdate;
			<AnalyzeRequireFiles>d__.bIsLauncher = bIsLauncher;
			<AnalyzeRequireFiles>d__.<>1__state = -1;
			<AnalyzeRequireFiles>d__.<>t__builder.Start<DiffUpdate.<AnalyzeRequireFiles>d__33>(ref <AnalyzeRequireFiles>d__);
			return <AnalyzeRequireFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000532B8 File Offset: 0x000514B8
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"totalNeed",
			"savedSize",
			"extra"
		})]
		private ValueTuple<long, long, long> CalcTotalNeedAndSaved([Nullable(1)] List<LocalFileInfo> fileSpace, ETier? tier = null)
		{
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			foreach (ResPackageInfo resPackageInfo in this.EnumeratePacksWithActiveTierChild(tier))
			{
				if (resPackageInfo.NeedProcessUpdate(this.ForceUpdate))
				{
					PackageSpaceModel spaceModel = resPackageInfo.SpaceModel;
					num += spaceModel.DownloadSize;
					num2 += spaceModel.SavedSize;
					long num6 = num4 + spaceModel.PatchPeak;
					if (num5 < num6)
					{
						num5 = num6;
					}
					num4 += spaceModel.PatchNetDelta;
					num3 += spaceModel.CopySize;
				}
			}
			long num7 = num4 + num3;
			long num8 = (num5 > num7) ? num5 : num7;
			if (num8 < 0L)
			{
				num8 = 0L;
			}
			long num9 = num + num8;
			long num10 = num2;
			foreach (LocalFileInfo localFileInfo in fileSpace)
			{
				num9 += localFileInfo.ExpectSize;
				num10 += localFileInfo.GetLocalSize();
			}
			return new ValueTuple<long, long, long>(num9, num10, num8);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000533F0 File Offset: 0x000515F0
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"need",
			"localSaved",
			"extra"
		})]
		private ValueTuple<long, long, long> CalcRealtimeNeedSpace([Nullable(1)] List<RequireFileInfo> requireFiles, bool bIncludePatchExtra)
		{
			long num = 2097152L;
			long num2 = 10485760L;
			long num3 = 0L;
			long num4 = 0L;
			foreach (RequireFileInfo requireFileInfo in requireFiles)
			{
				long localSize = new DestFileInfo(requireFileInfo.LocalPath, requireFileInfo.LocalPath, requireFileInfo.Size, requireFileInfo.RemoteRoute, requireFileInfo.Hash).GetLocalSize();
				num4 += localSize;
				long num5 = requireFileInfo.Size - localSize;
				if (num5 > 0L)
				{
					num3 += num5;
				}
			}
			long num6 = 0L;
			if (bIncludePatchExtra)
			{
				num6 = this.CalcTotalNeedAndSaved(new List<LocalFileInfo>(), null).Item3;
				num3 += num6;
			}
			num3 += num2;
			return new ValueTuple<long, long, long>((num3 >= num) ? num3 : num, num4, num6);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x000534D4 File Offset: 0x000516D4
		[NullableContext(0)]
		public UniTask<bool> DownloadFiles([Nullable(1)] List<RequireFileInfo> requireFiles, long needSpace, bool bUseBgDownload = false)
		{
			DiffUpdate.<DownloadFiles>d__36 <DownloadFiles>d__;
			<DownloadFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadFiles>d__.<>4__this = this;
			<DownloadFiles>d__.requireFiles = requireFiles;
			<DownloadFiles>d__.needSpace = needSpace;
			<DownloadFiles>d__.bUseBgDownload = bUseBgDownload;
			<DownloadFiles>d__.<>1__state = -1;
			<DownloadFiles>d__.<>t__builder.Start<DiffUpdate.<DownloadFiles>d__36>(ref <DownloadFiles>d__);
			return <DownloadFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00053530 File Offset: 0x00051730
		[return: Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})]
		public UniTask<ValueTuple<bool, List<RequireFileInfo>, long>> ExecutePatch()
		{
			DiffUpdate.<ExecutePatch>d__37 <ExecutePatch>d__;
			<ExecutePatch>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<bool, List<RequireFileInfo>, long>>.Create();
			<ExecutePatch>d__.<>4__this = this;
			<ExecutePatch>d__.<>1__state = -1;
			<ExecutePatch>d__.<>t__builder.Start<DiffUpdate.<ExecutePatch>d__37>(ref <ExecutePatch>d__);
			return <ExecutePatch>d__.<>t__builder.Task;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00053574 File Offset: 0x00051774
		[NullableContext(0)]
		public UniTask<bool> DownloadMissFiles([Nullable(1)] List<RequireFileInfo> requireFiles, long needSpace, bool bHasMiss, bool bUseBgDownload = false)
		{
			DiffUpdate.<DownloadMissFiles>d__38 <DownloadMissFiles>d__;
			<DownloadMissFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadMissFiles>d__.<>4__this = this;
			<DownloadMissFiles>d__.requireFiles = requireFiles;
			<DownloadMissFiles>d__.needSpace = needSpace;
			<DownloadMissFiles>d__.bHasMiss = bHasMiss;
			<DownloadMissFiles>d__.bUseBgDownload = bUseBgDownload;
			<DownloadMissFiles>d__.<>1__state = -1;
			<DownloadMissFiles>d__.<>t__builder.Start<DiffUpdate.<DownloadMissFiles>d__38>(ref <DownloadMissFiles>d__);
			return <DownloadMissFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x000535D8 File Offset: 0x000517D8
		[NullableContext(0)]
		public UniTask<bool> MoveSameFiles()
		{
			DiffUpdate.<MoveSameFiles>d__39 <MoveSameFiles>d__;
			<MoveSameFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MoveSameFiles>d__.<>4__this = this;
			<MoveSameFiles>d__.<>1__state = -1;
			<MoveSameFiles>d__.<>t__builder.Start<DiffUpdate.<MoveSameFiles>d__39>(ref <MoveSameFiles>d__);
			return <MoveSameFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0005361C File Offset: 0x0005181C
		public unsafe bool ProcessRecord()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "res updated and update record.";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("forceUpdate", this.ForceUpdate);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("updateType", Enum.GetName(typeof(EUpdateType), this.UpdateType));
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			string s_step_id = "diffUpdate_update_record";
			HotPatchLog hotPatchLog = new HotPatchLog();
			hotPatchLog.s_step_id = s_step_id;
			if (this.ReportEvent != null)
			{
				this.ReportEvent.Start(hotPatchLog, null);
			}
			foreach (ResPackageInfo resPackageInfo in this.EnumeratePacksWithActiveTierChild(null))
			{
				if (resPackageInfo.NeedProcessUpdate(this.ForceUpdate))
				{
					resPackageInfo.UpdateRecord();
					if (resPackageInfo.HadDeletion)
					{
						this.HadDiskChange = true;
					}
				}
			}
			HotPatchLog hotPatchLog2 = new HotPatchLog();
			hotPatchLog2.s_step_id = s_step_id;
			if (this.ReportEvent != null)
			{
				this.ReportEvent.End(hotPatchLog2, null);
			}
			return true;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00053758 File Offset: 0x00051958
		public bool NeedReboot()
		{
			foreach (ResPackageInfo resPackageInfo in this.EnumeratePacksWithActiveTierChild(null))
			{
				if (resPackageInfo.NeedProcessUpdate(this.ForceUpdate) && resPackageInfo.NeedRebootModuleOrApp())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x000537CC File Offset: 0x000519CC
		public bool HasMountedRestartRequiredPak18(TArray<string> mountedPaks)
		{
			HashSet<string> hashSet = new HashSet<string>();
			foreach (string text in mountedPaks)
			{
				if (text.Contains("pakchunk18"))
				{
					hashSet.Add(text);
				}
			}
			if (hashSet.Count == 0)
			{
				return false;
			}
			foreach (ResPackageInfo resPackageInfo in this.EnumeratePacksWithActiveTierChild(null))
			{
				if (resPackageInfo.NeedProcessUpdate(this.ForceUpdate))
				{
					foreach (ValueTuple<string, string, int> valueTuple in resPackageInfo.GetMountInfos().Item2)
					{
						string item = valueTuple.Item1;
						if (item.Contains("pakchunk18") && !hashSet.Contains(item))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000538F8 File Offset: 0x00051AF8
		public bool IsHotFixOrNot()
		{
			foreach (ResPackageInfo resPackageInfo in this.EnumeratePacksWithActiveTierChild(null))
			{
				if (resPackageInfo.NeedProcessUpdate(this.ForceUpdate) && resPackageInfo.IsHotFixOrNot())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0005396C File Offset: 0x00051B6C
		public unsafe void MountFiles()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "will mount the res files.";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("forceUpdate", this.ForceUpdate);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("updateType", Enum.GetName(typeof(EUpdateType), this.UpdateType));
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (this.UiEvent != null)
			{
				this.UiEvent.ShowInfo(false, "MountPak", false);
			}
			foreach (ResPackageInfo resPackageInfo in this.EnumeratePacksWithActiveTierChild(null))
			{
				if (resPackageInfo.NeedProcessUpdate(this.ForceUpdate))
				{
					ValueTuple<List<string>, List<ValueTuple<string, string, int>>> mountInfos = resPackageInfo.GetMountInfos();
					List<string> item = mountInfos.Item1;
					List<ValueTuple<string, string, int>> item2 = mountInfos.Item2;
					foreach (string path in item)
					{
						UKuroPakMountStatic.UnmountPak(path);
					}
					foreach (ValueTuple<string, string, int> valueTuple in item2)
					{
						string item3 = valueTuple.Item1;
						string item4 = valueTuple.Item2;
						int item5 = valueTuple.Item3;
						UKuroPakMountStatic.MountPak(item3, item5);
						if (!Platform.Instance.IsCloudGame() && Platform.Instance.IsWindowsPlatform())
						{
							UKuroPakMountStatic.AddSha1Check(item3, item4);
						}
					}
				}
			}
			if (!Platform.Instance.IsCloudGame() && Platform.Instance.IsWindowsPlatform())
			{
				UKuroPakMountStatic.StartSha1Check();
			}
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00053B4C File Offset: 0x00051D4C
		[NullableContext(0)]
		public unsafe ValueTuple<long, long, long, long, long> CalcNeedSizeInfo(ETier tier = ETier.None)
		{
			List<RequireFileInfo> list = new List<RequireFileInfo>();
			foreach (ResPackageInfo resPackageInfo in this.EnumeratePacksWithActiveTierChild(new ETier?(tier)))
			{
				if (resPackageInfo.NeedProcessUpdate(this.ForceUpdate))
				{
					List<RequireFileInfo> item = resPackageInfo.AnalyzeRequireFiles(false, ETier.None).Item1;
					list.AddRange(item);
				}
			}
			ValueTuple<long, long, long> valueTuple = this.CalcTotalNeedAndSaved(this.ExtraFileSpace, new ETier?(tier));
			long item2 = valueTuple.Item1;
			long item3 = valueTuple.Item2;
			long num = 0L;
			foreach (RequireFileInfo requireFileInfo in list)
			{
				num += requireFileInfo.Size;
			}
			foreach (RequireFileInfo requireFileInfo2 in this.ExtraRequireFileInfo)
			{
				num += requireFileInfo2.Size;
			}
			string resSaveDir = ResPackageInfo.GetResSaveDir();
			long item4 = ResPackageInfo.GetTotalAndFreeSpace(resSaveDir).Item2;
			long num2 = item2 - item3 + 10485760L;
			LauncherLog instance = LauncherLog.Instance;
			string message = "calc need size info.";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", resSaveDir);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("needSize", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("freeSize", item4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("savedSize", item3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("totalNeed", item2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("totalReqFileSize", num);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			return new ValueTuple<long, long, long, long, long>(num2, item4, item3, item2, num);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00053D70 File Offset: 0x00051F70
		public void Stop()
		{
			this.IsStopped = true;
			if (this.Downloader != null)
			{
				this.Downloader.CancelDownload();
			}
			if (this.BgDownloader != null)
			{
				this.BgDownloader.Cancel();
			}
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00053D9F File Offset: 0x00051F9F
		public void Resume()
		{
			this.IsStopped = false;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00053DA8 File Offset: 0x00051FA8
		[NullableContext(0)]
		public UniTask<bool> PromptNetwork(long updateSize)
		{
			DiffUpdate.<PromptNetwork>d__48 <PromptNetwork>d__;
			<PromptNetwork>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PromptNetwork>d__.<>4__this = this;
			<PromptNetwork>d__.updateSize = updateSize;
			<PromptNetwork>d__.<>1__state = -1;
			<PromptNetwork>d__.<>t__builder.Start<DiffUpdate.<PromptNetwork>d__48>(ref <PromptNetwork>d__);
			return <PromptNetwork>d__.<>t__builder.Task;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00053DF4 File Offset: 0x00051FF4
		[NullableContext(0)]
		private UniTask<bool> ForegroundDownload([Nullable(1)] List<RequireFileInfo> requireFiles)
		{
			DiffUpdate.<ForegroundDownload>d__49 <ForegroundDownload>d__;
			<ForegroundDownload>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ForegroundDownload>d__.<>4__this = this;
			<ForegroundDownload>d__.requireFiles = requireFiles;
			<ForegroundDownload>d__.<>1__state = -1;
			<ForegroundDownload>d__.<>t__builder.Start<DiffUpdate.<ForegroundDownload>d__49>(ref <ForegroundDownload>d__);
			return <ForegroundDownload>d__.<>t__builder.Task;
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00053E40 File Offset: 0x00052040
		[NullableContext(0)]
		private UniTask<bool> UseBgDownload([Nullable(1)] List<RequireFileInfo> requireFiles)
		{
			DiffUpdate.<UseBgDownload>d__50 <UseBgDownload>d__;
			<UseBgDownload>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UseBgDownload>d__.<>4__this = this;
			<UseBgDownload>d__.requireFiles = requireFiles;
			<UseBgDownload>d__.<>1__state = -1;
			<UseBgDownload>d__.<>t__builder.Start<DiffUpdate.<UseBgDownload>d__50>(ref <UseBgDownload>d__);
			return <UseBgDownload>d__.<>t__builder.Task;
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00053E8C File Offset: 0x0005208C
		[NullableContext(0)]
		private UniTask<bool> DownloadRestrictByNetwork([Nullable(new byte[]
		{
			1,
			0,
			1
		})] Func<bool, UniTask<IDownloadResult>> downloadFunc, [Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<string, UniTask<bool>> showFailedDialog)
		{
			DiffUpdate.<DownloadRestrictByNetwork>d__51 <DownloadRestrictByNetwork>d__;
			<DownloadRestrictByNetwork>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadRestrictByNetwork>d__.<>4__this = this;
			<DownloadRestrictByNetwork>d__.downloadFunc = downloadFunc;
			<DownloadRestrictByNetwork>d__.showFailedDialog = showFailedDialog;
			<DownloadRestrictByNetwork>d__.<>1__state = -1;
			<DownloadRestrictByNetwork>d__.<>t__builder.Start<DiffUpdate.<DownloadRestrictByNetwork>d__51>(ref <DownloadRestrictByNetwork>d__);
			return <DownloadRestrictByNetwork>d__.<>t__builder.Task;
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00053EE0 File Offset: 0x000520E0
		[return: Nullable(0)]
		private UniTask<ValueTuple<int, int>> BackgroundDownload(UKuroBgPrefixDownload bgDownloader, TArray<string> prefixList, TArray<FKuroRequestDownloadInfo> requestInfos, Action<int, long> cb, bool retry = false)
		{
			DiffUpdate.<BackgroundDownload>d__52 <BackgroundDownload>d__;
			<BackgroundDownload>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<int, int>>.Create();
			<BackgroundDownload>d__.<>4__this = this;
			<BackgroundDownload>d__.bgDownloader = bgDownloader;
			<BackgroundDownload>d__.prefixList = prefixList;
			<BackgroundDownload>d__.requestInfos = requestInfos;
			<BackgroundDownload>d__.cb = cb;
			<BackgroundDownload>d__.retry = retry;
			<BackgroundDownload>d__.<>1__state = -1;
			<BackgroundDownload>d__.<>t__builder.Start<DiffUpdate.<BackgroundDownload>d__52>(ref <BackgroundDownload>d__);
			return <BackgroundDownload>d__.<>t__builder.Task;
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00053F50 File Offset: 0x00052150
		[NullableContext(0)]
		protected UniTask<bool> CheckUsedPatch(long needSize, long patchDownloadSize, long allDownloadSize)
		{
			DiffUpdate.<CheckUsedPatch>d__53 <CheckUsedPatch>d__;
			<CheckUsedPatch>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CheckUsedPatch>d__.<>4__this = this;
			<CheckUsedPatch>d__.needSize = needSize;
			<CheckUsedPatch>d__.patchDownloadSize = patchDownloadSize;
			<CheckUsedPatch>d__.allDownloadSize = allDownloadSize;
			<CheckUsedPatch>d__.<>1__state = -1;
			<CheckUsedPatch>d__.<>t__builder.Start<DiffUpdate.<CheckUsedPatch>d__53>(ref <CheckUsedPatch>d__);
			return <CheckUsedPatch>d__.<>t__builder.Task;
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00053FAC File Offset: 0x000521AC
		[NullableContext(0)]
		protected UniTask<bool> DoesSavedDirHaveEnoughSpace(long needSize)
		{
			DiffUpdate.<DoesSavedDirHaveEnoughSpace>d__54 <DoesSavedDirHaveEnoughSpace>d__;
			<DoesSavedDirHaveEnoughSpace>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DoesSavedDirHaveEnoughSpace>d__.<>4__this = this;
			<DoesSavedDirHaveEnoughSpace>d__.needSize = needSize;
			<DoesSavedDirHaveEnoughSpace>d__.<>1__state = -1;
			<DoesSavedDirHaveEnoughSpace>d__.<>t__builder.Start<DiffUpdate.<DoesSavedDirHaveEnoughSpace>d__54>(ref <DoesSavedDirHaveEnoughSpace>d__);
			return <DoesSavedDirHaveEnoughSpace>d__.<>t__builder.Task;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00053FF7 File Offset: 0x000521F7
		public void RegisterExtraRequireFiles(List<LocalFileInfo> extraFileSpace, List<RequireFileInfo> extraRequireFileInfo)
		{
			this.ExtraFileSpace = extraFileSpace;
			this.ExtraRequireFileInfo = extraRequireFileInfo;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00054008 File Offset: 0x00052208
		public int RemoveExtraRequireFiles(Func<string, bool> shouldRemove)
		{
			int count = this.ExtraRequireFileInfo.Count;
			this.ExtraRequireFileInfo.RemoveAll((RequireFileInfo it) => shouldRemove(it.LocalPath));
			this.ExtraFileSpace.RemoveAll((LocalFileInfo it) => shouldRemove(it.FilePath));
			return count - this.ExtraRequireFileInfo.Count;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0005406C File Offset: 0x0005226C
		public void AppendResPackageInfo(List<ResPackageInfo> resPackageInfos)
		{
			foreach (ResPackageInfo item in resPackageInfos)
			{
				if (!this.ResPackageInfos.Contains(item))
				{
					this.ResPackageInfos.Add(item);
				}
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000540D0 File Offset: 0x000522D0
		public void AddSpaceNotEnoughHandler(Action<long, long, bool> handler)
		{
			this.SpaceNotEnoughHandlers.Add(handler);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x000540E0 File Offset: 0x000522E0
		public void InvokeSpaceNotEnoughHandlers(long needSize, long freeSize, bool isRetry)
		{
			foreach (Action<long, long, bool> action in this.SpaceNotEnoughHandlers)
			{
				action(needSize, freeSize, isRetry);
			}
		}

		// Token: 0x04000892 RID: 2194
		private bool CanceledByNetworkChange;

		// Token: 0x04000893 RID: 2195
		private bool UserAnsweredDialog;

		// Token: 0x04000894 RID: 2196
		private ENetworkType LastNetworkType = ENetworkType.None;

		// Token: 0x04000895 RID: 2197
		private bool IsAllowCellDownload;

		// Token: 0x04000896 RID: 2198
		[Nullable(2)]
		private UKuroBgPrefixDownload BgDownloader;

		// Token: 0x04000897 RID: 2199
		[Nullable(2)]
		private UKuroNetworkChange NetworkListenerInternal;

		// Token: 0x04000898 RID: 2200
		[Nullable(2)]
		private Action<bool> DialogCb;

		// Token: 0x04000899 RID: 2201
		private Action<byte> OnChangeNetworkType;

		// Token: 0x0400089A RID: 2202
		private bool IsStopped;

		// Token: 0x0400089B RID: 2203
		[Nullable(2)]
		private object BgDownloadOwner;

		// Token: 0x0400089C RID: 2204
		private List<LocalFileInfo> ExtraFileSpace = new List<LocalFileInfo>();

		// Token: 0x0400089D RID: 2205
		private List<RequireFileInfo> ExtraRequireFileInfo = new List<RequireFileInfo>();

		// Token: 0x0400089E RID: 2206
		private List<Action<long, long, bool>> SpaceNotEnoughHandlers = new List<Action<long, long, bool>>();

		// Token: 0x0400089F RID: 2207
		private readonly List<ResPackageInfo> ResPackageInfos;

		// Token: 0x040008A0 RID: 2208
		private UrlPrefixDownload Downloader;

		// Token: 0x040008A1 RID: 2209
		[Nullable(2)]
		private readonly IDiffUpdateUiEvent UiEvent;

		// Token: 0x040008A2 RID: 2210
		[Nullable(2)]
		private readonly IDiffUpdateReportEvent ReportEvent;

		// Token: 0x040008A3 RID: 2211
		private readonly bool ForceUpdate;

		// Token: 0x040008A4 RID: 2212
		public bool HadDiskChange;

		// Token: 0x040008A5 RID: 2213
		private bool bReportNeedDownload;

		// Token: 0x040008A6 RID: 2214
		private readonly EUpdateType UpdateType;
	}
}
