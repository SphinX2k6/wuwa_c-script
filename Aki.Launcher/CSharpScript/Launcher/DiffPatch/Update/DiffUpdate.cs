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
	// Token: 0x02000206 RID: 518
	[NullableContext(1)]
	[Nullable(0)]
	public class DiffUpdate
	{
		// Token: 0x06000D3F RID: 3391 RVA: 0x00050314 File Offset: 0x0004E514
		public DiffUpdate(List<ResPackageInfo> resPackageInfos, UrlPrefixDownload downloader, [Nullable(2)] IDiffUpdateUiEvent uiEvent, [Nullable(2)] IDiffUpdateReportEvent reportEvent, bool forceUpdate = false, EUpdateType updateType = EUpdateType.NormalUpdate)
		{
			this.ResPackageInfos = resPackageInfos;
			this.Downloader = downloader;
			this.UiEvent = uiEvent;
			this.ReportEvent = reportEvent;
			this.ForceUpdate = forceUpdate;
			this.UpdateType = updateType;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0005037C File Offset: 0x0004E57C
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

		// Token: 0x06000D41 RID: 3393 RVA: 0x00050398 File Offset: 0x0004E598
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

		// Token: 0x06000D42 RID: 3394 RVA: 0x00050428 File Offset: 0x0004E628
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

		// Token: 0x06000D43 RID: 3395 RVA: 0x000504C8 File Offset: 0x0004E6C8
		private List<ResPackageInfo> EnumeratePacksWithActiveTierChild(ETier? tier = null)
		{
			return ResPackageInfo.EnumerateWithTierChild(this.ResPackageInfos, tier ?? RemoteInfo.Instance.ActiveTier);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00050500 File Offset: 0x0004E700
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public UniTask<List<RequestFileInfo>> HasContentOnRemote()
		{
			DiffUpdate.<HasContentOnRemote>d__26 <HasContentOnRemote>d__;
			<HasContentOnRemote>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<RequestFileInfo>>.Create();
			<HasContentOnRemote>d__.<>4__this = this;
			<HasContentOnRemote>d__.<>1__state = -1;
			<HasContentOnRemote>d__.<>t__builder.Start<DiffUpdate.<HasContentOnRemote>d__26>(ref <HasContentOnRemote>d__);
			return <HasContentOnRemote>d__.<>t__builder.Task;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00050544 File Offset: 0x0004E744
		[NullableContext(0)]
		public UniTask<bool> DownloadManifests([Nullable(1)] List<RequestFileInfo> requests)
		{
			DiffUpdate.<DownloadManifests>d__27 <DownloadManifests>d__;
			<DownloadManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadManifests>d__.<>4__this = this;
			<DownloadManifests>d__.requests = requests;
			<DownloadManifests>d__.<>1__state = -1;
			<DownloadManifests>d__.<>t__builder.Start<DiffUpdate.<DownloadManifests>d__27>(ref <DownloadManifests>d__);
			return <DownloadManifests>d__.<>t__builder.Task;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00050590 File Offset: 0x0004E790
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

		// Token: 0x06000D47 RID: 3399 RVA: 0x00050624 File Offset: 0x0004E824
		[NullableContext(0)]
		public UniTask<bool> ResolveManifests()
		{
			DiffUpdate.<ResolveManifests>d__29 <ResolveManifests>d__;
			<ResolveManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ResolveManifests>d__.<>4__this = this;
			<ResolveManifests>d__.<>1__state = -1;
			<ResolveManifests>d__.<>t__builder.Start<DiffUpdate.<ResolveManifests>d__29>(ref <ResolveManifests>d__);
			return <ResolveManifests>d__.<>t__builder.Task;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00050668 File Offset: 0x0004E868
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

		// Token: 0x06000D49 RID: 3401 RVA: 0x000506CC File Offset: 0x0004E8CC
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

		// Token: 0x06000D4A RID: 3402 RVA: 0x00050770 File Offset: 0x0004E970
		[return: Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})]
		public UniTask<ValueTuple<bool, List<RequireFileInfo>, long, EUpdateMode, long, long>> AnalyzeRequireFiles(EUpdateMode updateMode = EUpdateMode.All, bool firstTimeUpdate = false, bool bIsLauncher = false)
		{
			DiffUpdate.<AnalyzeRequireFiles>d__32 <AnalyzeRequireFiles>d__;
			<AnalyzeRequireFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<bool, List<RequireFileInfo>, long, EUpdateMode, long, long>>.Create();
			<AnalyzeRequireFiles>d__.<>4__this = this;
			<AnalyzeRequireFiles>d__.updateMode = updateMode;
			<AnalyzeRequireFiles>d__.firstTimeUpdate = firstTimeUpdate;
			<AnalyzeRequireFiles>d__.bIsLauncher = bIsLauncher;
			<AnalyzeRequireFiles>d__.<>1__state = -1;
			<AnalyzeRequireFiles>d__.<>t__builder.Start<DiffUpdate.<AnalyzeRequireFiles>d__32>(ref <AnalyzeRequireFiles>d__);
			return <AnalyzeRequireFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000507CC File Offset: 0x0004E9CC
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

		// Token: 0x06000D4C RID: 3404 RVA: 0x00050904 File Offset: 0x0004EB04
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

		// Token: 0x06000D4D RID: 3405 RVA: 0x000509E8 File Offset: 0x0004EBE8
		[NullableContext(0)]
		public UniTask<bool> DownloadFiles([Nullable(1)] List<RequireFileInfo> requireFiles, long needSpace, bool bUseBgDownload = false)
		{
			DiffUpdate.<DownloadFiles>d__35 <DownloadFiles>d__;
			<DownloadFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadFiles>d__.<>4__this = this;
			<DownloadFiles>d__.requireFiles = requireFiles;
			<DownloadFiles>d__.needSpace = needSpace;
			<DownloadFiles>d__.bUseBgDownload = bUseBgDownload;
			<DownloadFiles>d__.<>1__state = -1;
			<DownloadFiles>d__.<>t__builder.Start<DiffUpdate.<DownloadFiles>d__35>(ref <DownloadFiles>d__);
			return <DownloadFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00050A44 File Offset: 0x0004EC44
		[return: Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})]
		public UniTask<ValueTuple<bool, List<RequireFileInfo>, long>> ExecutePatch()
		{
			DiffUpdate.<ExecutePatch>d__36 <ExecutePatch>d__;
			<ExecutePatch>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<bool, List<RequireFileInfo>, long>>.Create();
			<ExecutePatch>d__.<>4__this = this;
			<ExecutePatch>d__.<>1__state = -1;
			<ExecutePatch>d__.<>t__builder.Start<DiffUpdate.<ExecutePatch>d__36>(ref <ExecutePatch>d__);
			return <ExecutePatch>d__.<>t__builder.Task;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00050A88 File Offset: 0x0004EC88
		[NullableContext(0)]
		public UniTask<bool> DownloadMissFiles([Nullable(1)] List<RequireFileInfo> requireFiles, long needSpace, bool bHasMiss, bool bUseBgDownload = false)
		{
			DiffUpdate.<DownloadMissFiles>d__37 <DownloadMissFiles>d__;
			<DownloadMissFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadMissFiles>d__.<>4__this = this;
			<DownloadMissFiles>d__.requireFiles = requireFiles;
			<DownloadMissFiles>d__.needSpace = needSpace;
			<DownloadMissFiles>d__.bHasMiss = bHasMiss;
			<DownloadMissFiles>d__.bUseBgDownload = bUseBgDownload;
			<DownloadMissFiles>d__.<>1__state = -1;
			<DownloadMissFiles>d__.<>t__builder.Start<DiffUpdate.<DownloadMissFiles>d__37>(ref <DownloadMissFiles>d__);
			return <DownloadMissFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00050AEC File Offset: 0x0004ECEC
		[NullableContext(0)]
		public UniTask<bool> MoveSameFiles()
		{
			DiffUpdate.<MoveSameFiles>d__38 <MoveSameFiles>d__;
			<MoveSameFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MoveSameFiles>d__.<>4__this = this;
			<MoveSameFiles>d__.<>1__state = -1;
			<MoveSameFiles>d__.<>t__builder.Start<DiffUpdate.<MoveSameFiles>d__38>(ref <MoveSameFiles>d__);
			return <MoveSameFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00050B30 File Offset: 0x0004ED30
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

		// Token: 0x06000D52 RID: 3410 RVA: 0x00050C6C File Offset: 0x0004EE6C
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

		// Token: 0x06000D53 RID: 3411 RVA: 0x00050CE0 File Offset: 0x0004EEE0
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

		// Token: 0x06000D54 RID: 3412 RVA: 0x00050E04 File Offset: 0x0004F004
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

		// Token: 0x06000D55 RID: 3413 RVA: 0x00050E78 File Offset: 0x0004F078
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

		// Token: 0x06000D56 RID: 3414 RVA: 0x00051058 File Offset: 0x0004F258
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

		// Token: 0x06000D57 RID: 3415 RVA: 0x0005127C File Offset: 0x0004F47C
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

		// Token: 0x06000D58 RID: 3416 RVA: 0x000512AB File Offset: 0x0004F4AB
		public void Resume()
		{
			this.IsStopped = false;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x000512B4 File Offset: 0x0004F4B4
		[NullableContext(0)]
		public UniTask<bool> PromptNetwork(long updateSize)
		{
			DiffUpdate.<PromptNetwork>d__47 <PromptNetwork>d__;
			<PromptNetwork>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PromptNetwork>d__.<>4__this = this;
			<PromptNetwork>d__.updateSize = updateSize;
			<PromptNetwork>d__.<>1__state = -1;
			<PromptNetwork>d__.<>t__builder.Start<DiffUpdate.<PromptNetwork>d__47>(ref <PromptNetwork>d__);
			return <PromptNetwork>d__.<>t__builder.Task;
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00051300 File Offset: 0x0004F500
		[NullableContext(0)]
		private UniTask<bool> ForegroundDownload([Nullable(1)] List<RequireFileInfo> requireFiles)
		{
			DiffUpdate.<ForegroundDownload>d__48 <ForegroundDownload>d__;
			<ForegroundDownload>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ForegroundDownload>d__.<>4__this = this;
			<ForegroundDownload>d__.requireFiles = requireFiles;
			<ForegroundDownload>d__.<>1__state = -1;
			<ForegroundDownload>d__.<>t__builder.Start<DiffUpdate.<ForegroundDownload>d__48>(ref <ForegroundDownload>d__);
			return <ForegroundDownload>d__.<>t__builder.Task;
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0005134C File Offset: 0x0004F54C
		[NullableContext(0)]
		private UniTask<bool> UseBgDownload([Nullable(1)] List<RequireFileInfo> requireFiles)
		{
			DiffUpdate.<UseBgDownload>d__49 <UseBgDownload>d__;
			<UseBgDownload>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UseBgDownload>d__.<>4__this = this;
			<UseBgDownload>d__.requireFiles = requireFiles;
			<UseBgDownload>d__.<>1__state = -1;
			<UseBgDownload>d__.<>t__builder.Start<DiffUpdate.<UseBgDownload>d__49>(ref <UseBgDownload>d__);
			return <UseBgDownload>d__.<>t__builder.Task;
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00051398 File Offset: 0x0004F598
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
			DiffUpdate.<DownloadRestrictByNetwork>d__50 <DownloadRestrictByNetwork>d__;
			<DownloadRestrictByNetwork>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadRestrictByNetwork>d__.<>4__this = this;
			<DownloadRestrictByNetwork>d__.downloadFunc = downloadFunc;
			<DownloadRestrictByNetwork>d__.showFailedDialog = showFailedDialog;
			<DownloadRestrictByNetwork>d__.<>1__state = -1;
			<DownloadRestrictByNetwork>d__.<>t__builder.Start<DiffUpdate.<DownloadRestrictByNetwork>d__50>(ref <DownloadRestrictByNetwork>d__);
			return <DownloadRestrictByNetwork>d__.<>t__builder.Task;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x000513EC File Offset: 0x0004F5EC
		[return: Nullable(0)]
		private UniTask<ValueTuple<int, int>> BackgroundDownload(UKuroBgPrefixDownload bgDownloader, TArray<string> prefixList, TArray<FKuroRequestDownloadInfo> requestInfos, Action<int, long> cb, bool retry = false)
		{
			DiffUpdate.<BackgroundDownload>d__51 <BackgroundDownload>d__;
			<BackgroundDownload>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<int, int>>.Create();
			<BackgroundDownload>d__.<>4__this = this;
			<BackgroundDownload>d__.bgDownloader = bgDownloader;
			<BackgroundDownload>d__.prefixList = prefixList;
			<BackgroundDownload>d__.requestInfos = requestInfos;
			<BackgroundDownload>d__.cb = cb;
			<BackgroundDownload>d__.retry = retry;
			<BackgroundDownload>d__.<>1__state = -1;
			<BackgroundDownload>d__.<>t__builder.Start<DiffUpdate.<BackgroundDownload>d__51>(ref <BackgroundDownload>d__);
			return <BackgroundDownload>d__.<>t__builder.Task;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0005145C File Offset: 0x0004F65C
		[NullableContext(0)]
		protected UniTask<bool> CheckUsedPatch(long needSize, long patchDownloadSize, long allDownloadSize)
		{
			DiffUpdate.<CheckUsedPatch>d__52 <CheckUsedPatch>d__;
			<CheckUsedPatch>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CheckUsedPatch>d__.<>4__this = this;
			<CheckUsedPatch>d__.needSize = needSize;
			<CheckUsedPatch>d__.patchDownloadSize = patchDownloadSize;
			<CheckUsedPatch>d__.allDownloadSize = allDownloadSize;
			<CheckUsedPatch>d__.<>1__state = -1;
			<CheckUsedPatch>d__.<>t__builder.Start<DiffUpdate.<CheckUsedPatch>d__52>(ref <CheckUsedPatch>d__);
			return <CheckUsedPatch>d__.<>t__builder.Task;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x000514B8 File Offset: 0x0004F6B8
		[NullableContext(0)]
		protected UniTask<bool> DoesSavedDirHaveEnoughSpace(long needSize)
		{
			DiffUpdate.<DoesSavedDirHaveEnoughSpace>d__53 <DoesSavedDirHaveEnoughSpace>d__;
			<DoesSavedDirHaveEnoughSpace>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DoesSavedDirHaveEnoughSpace>d__.<>4__this = this;
			<DoesSavedDirHaveEnoughSpace>d__.needSize = needSize;
			<DoesSavedDirHaveEnoughSpace>d__.<>1__state = -1;
			<DoesSavedDirHaveEnoughSpace>d__.<>t__builder.Start<DiffUpdate.<DoesSavedDirHaveEnoughSpace>d__53>(ref <DoesSavedDirHaveEnoughSpace>d__);
			return <DoesSavedDirHaveEnoughSpace>d__.<>t__builder.Task;
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00051503 File Offset: 0x0004F703
		public void RegisterExtraRequireFiles(List<LocalFileInfo> extraFileSpace, List<RequireFileInfo> extraRequireFileInfo)
		{
			this.ExtraFileSpace = extraFileSpace;
			this.ExtraRequireFileInfo = extraRequireFileInfo;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00051514 File Offset: 0x0004F714
		public int RemoveExtraRequireFiles(Func<string, bool> shouldRemove)
		{
			int count = this.ExtraRequireFileInfo.Count;
			this.ExtraRequireFileInfo.RemoveAll((RequireFileInfo it) => shouldRemove(it.LocalPath));
			this.ExtraFileSpace.RemoveAll((LocalFileInfo it) => shouldRemove(it.FilePath));
			return count - this.ExtraRequireFileInfo.Count;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00051578 File Offset: 0x0004F778
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

		// Token: 0x06000D63 RID: 3427 RVA: 0x000515DC File Offset: 0x0004F7DC
		public void AddSpaceNotEnoughHandler(Action<long, long, bool> handler)
		{
			this.SpaceNotEnoughHandlers.Add(handler);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000515EC File Offset: 0x0004F7EC
		public void InvokeSpaceNotEnoughHandlers(long needSize, long freeSize, bool isRetry)
		{
			foreach (Action<long, long, bool> action in this.SpaceNotEnoughHandlers)
			{
				action(needSize, freeSize, isRetry);
			}
		}

		// Token: 0x04000852 RID: 2130
		private bool CanceledByNetworkChange;

		// Token: 0x04000853 RID: 2131
		private bool UserAnsweredDialog;

		// Token: 0x04000854 RID: 2132
		private ENetworkType LastNetworkType = ENetworkType.None;

		// Token: 0x04000855 RID: 2133
		private bool IsAllowCellDownload;

		// Token: 0x04000856 RID: 2134
		[Nullable(2)]
		private UKuroBgPrefixDownload BgDownloader;

		// Token: 0x04000857 RID: 2135
		[Nullable(2)]
		private UKuroNetworkChange NetworkListenerInternal;

		// Token: 0x04000858 RID: 2136
		[Nullable(2)]
		private Action<bool> DialogCb;

		// Token: 0x04000859 RID: 2137
		private Action<byte> OnChangeNetworkType;

		// Token: 0x0400085A RID: 2138
		private bool IsStopped;

		// Token: 0x0400085B RID: 2139
		[Nullable(2)]
		private object BgDownloadOwner;

		// Token: 0x0400085C RID: 2140
		private List<LocalFileInfo> ExtraFileSpace = new List<LocalFileInfo>();

		// Token: 0x0400085D RID: 2141
		private List<RequireFileInfo> ExtraRequireFileInfo = new List<RequireFileInfo>();

		// Token: 0x0400085E RID: 2142
		private List<Action<long, long, bool>> SpaceNotEnoughHandlers = new List<Action<long, long, bool>>();

		// Token: 0x0400085F RID: 2143
		private readonly List<ResPackageInfo> ResPackageInfos;

		// Token: 0x04000860 RID: 2144
		private UrlPrefixDownload Downloader;

		// Token: 0x04000861 RID: 2145
		[Nullable(2)]
		private readonly IDiffUpdateUiEvent UiEvent;

		// Token: 0x04000862 RID: 2146
		[Nullable(2)]
		private readonly IDiffUpdateReportEvent ReportEvent;

		// Token: 0x04000863 RID: 2147
		private readonly bool ForceUpdate;

		// Token: 0x04000864 RID: 2148
		public bool HadDiskChange;

		// Token: 0x04000865 RID: 2149
		private readonly EUpdateType UpdateType;
	}
}
