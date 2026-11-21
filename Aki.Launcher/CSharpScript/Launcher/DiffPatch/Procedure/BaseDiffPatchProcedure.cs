using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Procedure
{
	// Token: 0x0200021A RID: 538
	public abstract class BaseDiffPatchProcedure : IDiffPatchProcedure
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00055F9F File Offset: 0x0005419F
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x00055FA7 File Offset: 0x000541A7
		public bool HadOldResCleaned { get; private set; }

		// Token: 0x06000E13 RID: 3603 RVA: 0x00055FB0 File Offset: 0x000541B0
		[NullableContext(1)]
		public BaseDiffPatchProcedure(AppPathMisc pathMisc, HotFixManager viewMgr)
		{
			this.PathMisc = pathMisc;
			this.ViewMgr = viewMgr;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00055FEC File Offset: 0x000541EC
		public UniTask<bool> Start()
		{
			BaseDiffPatchProcedure.<Start>d__9 <Start>d__;
			<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Start>d__.<>4__this = this;
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<BaseDiffPatchProcedure.<Start>d__9>(ref <Start>d__);
			return <Start>d__.<>t__builder.Task;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00056030 File Offset: 0x00054230
		public UniTask<bool> GetRemoteVersionConfig()
		{
			BaseDiffPatchProcedure.<GetRemoteVersionConfig>d__10 <GetRemoteVersionConfig>d__;
			<GetRemoteVersionConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<GetRemoteVersionConfig>d__.<>4__this = this;
			<GetRemoteVersionConfig>d__.<>1__state = -1;
			<GetRemoteVersionConfig>d__.<>t__builder.Start<BaseDiffPatchProcedure.<GetRemoteVersionConfig>d__10>(ref <GetRemoteVersionConfig>d__);
			return <GetRemoteVersionConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00056074 File Offset: 0x00054274
		public bool HasPreDownloadData()
		{
			return LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PreDownloadRecord, "") == RemoteInfo.Instance.NewConfig.PackageVersion || LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PreDownloadState, "") != "";
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000560CA File Offset: 0x000542CA
		public bool IsFirstTimeUpdateForPackage()
		{
			return ProcedureUtil.IsFirstTimeUpdateForPackage();
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000560D4 File Offset: 0x000542D4
		public unsafe EUpdateMode GetPatchUpdateMode()
		{
			if (!Platform.Instance.IsMobilePlatform())
			{
				return EUpdateMode.All;
			}
			bool flag = this.IsFirstTimeUpdateForPackage();
			if (flag)
			{
				EUpdateMode eupdateMode = LauncherStorageLib.Instance.GetDeviceSaved<EUpdateMode>(ELauncherStorageDeviceKey.MajorVerPatchMode, EUpdateMode.All);
				bool flag2 = this.HasPreDownloadData();
				if (flag2)
				{
					eupdateMode = EUpdateMode.Diff;
				}
				LauncherLog instance = LauncherLog.Instance;
				string message = "get patch update mode";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("firstTimeUpdate", flag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("hasPreDownloadData", flag2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("patchMode", eupdateMode);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return eupdateMode;
			}
			return EUpdateMode.All;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00056190 File Offset: 0x00054390
		public UniTask<bool> IsAppVersionChange()
		{
			BaseDiffPatchProcedure.<IsAppVersionChange>d__14 <IsAppVersionChange>d__;
			<IsAppVersionChange>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<IsAppVersionChange>d__.<>4__this = this;
			<IsAppVersionChange>d__.<>1__state = -1;
			<IsAppVersionChange>d__.<>t__builder.Start<BaseDiffPatchProcedure.<IsAppVersionChange>d__14>(ref <IsAppVersionChange>d__);
			return <IsAppVersionChange>d__.<>t__builder.Task;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000561D4 File Offset: 0x000543D4
		public UniTask<bool> IsPostUpdateAppVersionChange()
		{
			BaseDiffPatchProcedure.<IsPostUpdateAppVersionChange>d__15 <IsPostUpdateAppVersionChange>d__;
			<IsPostUpdateAppVersionChange>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<IsPostUpdateAppVersionChange>d__.<>4__this = this;
			<IsPostUpdateAppVersionChange>d__.<>1__state = -1;
			<IsPostUpdateAppVersionChange>d__.<>t__builder.Start<BaseDiffPatchProcedure.<IsPostUpdateAppVersionChange>d__15>(ref <IsPostUpdateAppVersionChange>d__);
			return <IsPostUpdateAppVersionChange>d__.<>t__builder.Task;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00056218 File Offset: 0x00054418
		public virtual UniTask<bool> UpdateResource(bool bUseBgDownload, [Nullable(1)] DiffUpdate update, bool bIsLauncher)
		{
			BaseDiffPatchProcedure.<UpdateResource>d__16 <UpdateResource>d__;
			<UpdateResource>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdateResource>d__.<>4__this = this;
			<UpdateResource>d__.update = update;
			<UpdateResource>d__.bIsLauncher = bIsLauncher;
			<UpdateResource>d__.<>1__state = -1;
			<UpdateResource>d__.<>t__builder.Start<BaseDiffPatchProcedure.<UpdateResource>d__16>(ref <UpdateResource>d__);
			return <UpdateResource>d__.<>t__builder.Task;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x0005626B File Offset: 0x0005446B
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x00056273 File Offset: 0x00054473
		[Nullable(1)]
		public Func<DiffUpdate, HotFixManager, UniTask> RegistryExtraPack { [NullableContext(1)] get; [NullableContext(1)] set; } = (DiffUpdate update, HotFixManager hotFixManager) => UniTask.CompletedTask;

		// Token: 0x06000E1E RID: 3614 RVA: 0x0005627C File Offset: 0x0005447C
		public virtual void PreComplete()
		{
			RemoteInfo instance = RemoteInfo.Instance;
			VersionItem versionItem;
			if (instance == null)
			{
				versionItem = null;
			}
			else
			{
				RemoteVersionConfig newConfig = instance.NewConfig;
				versionItem = ((newConfig != null) ? newConfig.ResVersions.GetValueOrDefault("launcher") : null);
			}
			VersionItem versionItem2 = versionItem;
			if (versionItem2 != null)
			{
				LauncherStorageLib.Instance.SetDeviceSaved<string>(ELauncherStorageDeviceKey.LauncherPatchVersion, versionItem2.Version);
			}
			RemoteInfo instance2 = RemoteInfo.Instance;
			VersionItem versionItem3;
			if (instance2 == null)
			{
				versionItem3 = null;
			}
			else
			{
				RemoteVersionConfig newConfig2 = instance2.NewConfig;
				versionItem3 = ((newConfig2 != null) ? newConfig2.ResVersions.GetValueOrDefault("resource") : null);
			}
			VersionItem versionItem4 = versionItem3;
			if (versionItem4 != null)
			{
				string version = versionItem4.Version;
				RemoteVersionConfig valueOrDefault = RemoteInfo.Instance.NewTierConfig.GetValueOrDefault(RemoteInfo.Instance.ActiveTier);
				VersionItem versionItem5 = (valueOrDefault != null) ? valueOrDefault.ResVersions.GetValueOrDefault("resource") : null;
				if (versionItem5 != null)
				{
					ValueTuple<bool, VersionInfo> valueTuple = VersionInfo.TryParse(versionItem4.Version);
					bool item = valueTuple.Item1;
					VersionInfo item2 = valueTuple.Item2;
					ValueTuple<bool, VersionInfo> valueTuple2 = VersionInfo.TryParse(versionItem5.Version);
					bool item3 = valueTuple2.Item1;
					VersionInfo item4 = valueTuple2.Item2;
					if (item && item3 && !VersionInfo.LessThanOrEqual(item4, item2))
					{
						version = versionItem5.Version;
					}
				}
				LauncherStorageLib.Instance.SetDeviceSaved<string>(ELauncherStorageDeviceKey.PatchVersion, version);
			}
			RemoteInfo instance3 = RemoteInfo.Instance;
			bool flag;
			if (instance3 == null)
			{
				flag = (null != null);
			}
			else
			{
				RemoteVersionConfig newConfig3 = instance3.NewConfig;
				flag = (((newConfig3 != null) ? newConfig3.ChangeList : null) != null);
			}
			if (flag && RemoteInfo.Instance.NewConfig.ChangeList.Length > 0)
			{
				LauncherStorageLib.Instance.SetDeviceSaved<string>(ELauncherStorageDeviceKey.PatchP4Version, RemoteInfo.Instance.NewConfig.ChangeList);
			}
			if (Platform.Instance.IsMobilePlatform() && this.IsFirstTimeUpdateForPackage())
			{
				LauncherStorageLib.Instance.SetDeviceSaved<EUpdateMode>(ELauncherStorageDeviceKey.MajorVerPatchMode, EUpdateMode.All);
			}
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x000563FC File Offset: 0x000545FC
		public UniTask<bool> Complete()
		{
			BaseDiffPatchProcedure.<Complete>d__22 <Complete>d__;
			<Complete>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Complete>d__.<>4__this = this;
			<Complete>d__.<>1__state = -1;
			<Complete>d__.<>t__builder.Start<BaseDiffPatchProcedure.<Complete>d__22>(ref <Complete>d__);
			return <Complete>d__.<>t__builder.Task;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00056440 File Offset: 0x00054640
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<RemoteVersionConfig> RequestRemoteConfig(List<string> prefixList, string remoteConfigUrl, Dictionary<string, RemoteVersionConfig> configMapRef)
		{
			BaseDiffPatchProcedure.<RequestRemoteConfig>d__23 <RequestRemoteConfig>d__;
			<RequestRemoteConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<RemoteVersionConfig>.Create();
			<RequestRemoteConfig>d__.prefixList = prefixList;
			<RequestRemoteConfig>d__.remoteConfigUrl = remoteConfigUrl;
			<RequestRemoteConfig>d__.configMapRef = configMapRef;
			<RequestRemoteConfig>d__.<>1__state = -1;
			<RequestRemoteConfig>d__.<>t__builder.Start<BaseDiffPatchProcedure.<RequestRemoteConfig>d__23>(ref <RequestRemoteConfig>d__);
			return <RequestRemoteConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00056494 File Offset: 0x00054694
		[NullableContext(1)]
		private ERemoteConfigResult SetRemoteConfigInfo(int lastUpdateTime, [Nullable(2)] RemoteVersionConfig newestConfig, Dictionary<string, RemoteVersionConfig> configMap, bool ignoreOutDateAndIllegal)
		{
			HotPatchLog hotPatchLog = new HotPatchLog();
			HotPatchLogResult hotPatchLogResult = new HotPatchLogResult
			{
				success = true
			};
			hotPatchLog.s_step_id = "end_download_remote_config";
			HotPatchLog hotPatchLog2 = new HotPatchLog();
			hotPatchLog2.s_step_id = "check_remote_config";
			RemoteVersionConfig remoteVersionConfig = newestConfig;
			long? num2;
			if (remoteVersionConfig != null)
			{
				long num = (long)lastUpdateTime;
				long? updateTime = remoteVersionConfig.UpdateTime;
				num2 = ((num > updateTime.GetValueOrDefault() & updateTime != null) ? new long?((long)lastUpdateTime) : remoteVersionConfig.UpdateTime);
			}
			else
			{
				num2 = new long?((long)lastUpdateTime);
			}
			long? num3 = num2;
			int num4 = 0;
			int num5 = 0;
			foreach (KeyValuePair<string, RemoteVersionConfig> keyValuePair in configMap)
			{
				string key = keyValuePair.Key;
				RemoteVersionConfig value = keyValuePair.Value;
				if (value.UpdateTime == null)
				{
					LauncherLog.Instance.Error("远程配置文件UpdateTime字段非法！", default(ReadOnlySpan<ValueTuple<string, object>>));
					hotPatchLog2.s_url_prefix = key;
					hotPatchLog2.s_step_result = "remote config field is illegal. field: UpdateTime";
					HotPatchLogReport.Instance.Report(hotPatchLog2);
					num5++;
				}
				else
				{
					long? updateTime = value.UpdateTime;
					long? num6 = num3;
					if (updateTime.GetValueOrDefault() < num6.GetValueOrDefault() & (updateTime != null & num6 != null))
					{
						LauncherLog instance = LauncherLog.Instance;
						string message = "远程配置文件已过时！";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("prefix", key);
						instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						hotPatchLog2.s_url_prefix = key;
						hotPatchLog2.s_step_result = "out date";
						hotPatchLog2.i_latest_time = num3;
						hotPatchLog2.i_out_date_time = value.UpdateTime;
						HotPatchLogReport.Instance.Report(hotPatchLog2);
						num4++;
					}
				}
			}
			if (remoteVersionConfig == null)
			{
				if (num4 <= 0 && num5 <= 0)
				{
					hotPatchLogResult.success = false;
					hotPatchLogResult.info = "failed, get all remote configs failed.";
					hotPatchLog.s_step_result = LauncherJson.Stringify(hotPatchLogResult, null);
					HotPatchLogReport.Instance.Report(hotPatchLog);
					return ERemoteConfigResult.None;
				}
				if (!ignoreOutDateAndIllegal)
				{
					if (num4 > num5)
					{
						hotPatchLogResult.success = false;
						hotPatchLogResult.info = "failed, the most of remote configs is out of date.";
						hotPatchLog.s_step_result = LauncherJson.Stringify(hotPatchLogResult, null);
						HotPatchLogReport.Instance.Report(hotPatchLog);
						return ERemoteConfigResult.OutDate;
					}
					hotPatchLogResult.success = false;
					hotPatchLogResult.info = "failed, the most of remote config field is illegal.";
					hotPatchLog.s_step_result = LauncherJson.Stringify(hotPatchLogResult, null);
					HotPatchLogReport.Instance.Report(hotPatchLog);
					return ERemoteConfigResult.FieldIllegal;
				}
				else
				{
					LauncherLog instance2 = LauncherLog.Instance;
					string message2 = "所有远程配置更新时间戳字段都不可用，强行设置一个远程配置";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("configCount", configMap.Count);
					instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					if (configMap.Count <= 0)
					{
						LauncherLog.Instance.Error("所有远程配置更新时间戳字段都不可用，并且没有获取到有效的配置个数。", default(ReadOnlySpan<ValueTuple<string, object>>));
						hotPatchLogResult.success = false;
						hotPatchLogResult.info = "failed, can not assign a valid remote config.";
						hotPatchLog.s_step_result = LauncherJson.Stringify(hotPatchLogResult, null);
						HotPatchLogReport.Instance.Report(hotPatchLog);
						return ERemoteConfigResult.None;
					}
					using (Dictionary<string, RemoteVersionConfig>.Enumerator enumerator = configMap.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							KeyValuePair<string, RemoteVersionConfig> keyValuePair2 = enumerator.Current;
							remoteVersionConfig = keyValuePair2.Value;
						}
					}
				}
			}
			hotPatchLogResult.success = true;
			hotPatchLogResult.info = "success";
			hotPatchLog.s_step_result = LauncherJson.Stringify(hotPatchLogResult, null);
			HotPatchLogReport.Instance.Report(hotPatchLog);
			RemoteInfo.Instance.NewConfig = remoteVersionConfig;
			if (!ignoreOutDateAndIllegal)
			{
				long? num6 = RemoteInfo.Instance.NewConfig.UpdateTime;
				long num7 = (long)lastUpdateTime;
				if (num6.GetValueOrDefault() > num7 & num6 != null)
				{
					LauncherStorageLib.Instance.SetDeviceSaved<long?>(ELauncherStorageDeviceKey.RemoteVersionUpdate, RemoteInfo.Instance.NewConfig.UpdateTime);
				}
			}
			return ERemoteConfigResult.Success;
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00056834 File Offset: 0x00054A34
		private UniTask<ERemoteConfigResult> InternalGetRemoteVersionConfig(bool ignoreOutDateAndIllegal = false)
		{
			BaseDiffPatchProcedure.<InternalGetRemoteVersionConfig>d__25 <InternalGetRemoteVersionConfig>d__;
			<InternalGetRemoteVersionConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<ERemoteConfigResult>.Create();
			<InternalGetRemoteVersionConfig>d__.<>4__this = this;
			<InternalGetRemoteVersionConfig>d__.ignoreOutDateAndIllegal = ignoreOutDateAndIllegal;
			<InternalGetRemoteVersionConfig>d__.<>1__state = -1;
			<InternalGetRemoteVersionConfig>d__.<>t__builder.Start<BaseDiffPatchProcedure.<InternalGetRemoteVersionConfig>d__25>(ref <InternalGetRemoteVersionConfig>d__);
			return <InternalGetRemoteVersionConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00056880 File Offset: 0x00054A80
		[NullableContext(1)]
		[return: Nullable(0)]
		private UniTask<bool> RequestTierVersionConfig(string urlPath, List<string> prefixList)
		{
			BaseDiffPatchProcedure.<RequestTierVersionConfig>d__26 <RequestTierVersionConfig>d__;
			<RequestTierVersionConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestTierVersionConfig>d__.<>4__this = this;
			<RequestTierVersionConfig>d__.urlPath = urlPath;
			<RequestTierVersionConfig>d__.prefixList = prefixList;
			<RequestTierVersionConfig>d__.<>1__state = -1;
			<RequestTierVersionConfig>d__.<>t__builder.Start<BaseDiffPatchProcedure.<RequestTierVersionConfig>d__26>(ref <RequestTierVersionConfig>d__);
			return <RequestTierVersionConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x000568D3 File Offset: 0x00054AD3
		[NullableContext(1)]
		protected virtual UniTask OnAfterResolveManifests(DiffUpdate _update)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x040008E8 RID: 2280
		private bool IsInitUrlPrefix;

		// Token: 0x040008E9 RID: 2281
		[Nullable(2)]
		private string AppVersion;

		// Token: 0x040008EB RID: 2283
		[Nullable(2)]
		private readonly AppPathMisc PathMisc;

		// Token: 0x040008EC RID: 2284
		[Nullable(2)]
		protected readonly HotFixManager ViewMgr;
	}
}
