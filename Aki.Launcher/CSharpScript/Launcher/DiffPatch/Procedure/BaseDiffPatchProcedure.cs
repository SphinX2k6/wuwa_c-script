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
	// Token: 0x02000215 RID: 533
	public abstract class BaseDiffPatchProcedure : IDiffPatchProcedure
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x000534AB File Offset: 0x000516AB
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x000534B3 File Offset: 0x000516B3
		public bool HadOldResCleaned { get; private set; }

		// Token: 0x06000DD2 RID: 3538 RVA: 0x000534BC File Offset: 0x000516BC
		[NullableContext(1)]
		public BaseDiffPatchProcedure(AppPathMisc pathMisc, HotFixManager viewMgr)
		{
			this.PathMisc = pathMisc;
			this.ViewMgr = viewMgr;
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x000534F8 File Offset: 0x000516F8
		public UniTask<bool> Start()
		{
			BaseDiffPatchProcedure.<Start>d__9 <Start>d__;
			<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Start>d__.<>4__this = this;
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<BaseDiffPatchProcedure.<Start>d__9>(ref <Start>d__);
			return <Start>d__.<>t__builder.Task;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0005353C File Offset: 0x0005173C
		public UniTask<bool> GetRemoteVersionConfig()
		{
			BaseDiffPatchProcedure.<GetRemoteVersionConfig>d__10 <GetRemoteVersionConfig>d__;
			<GetRemoteVersionConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<GetRemoteVersionConfig>d__.<>4__this = this;
			<GetRemoteVersionConfig>d__.<>1__state = -1;
			<GetRemoteVersionConfig>d__.<>t__builder.Start<BaseDiffPatchProcedure.<GetRemoteVersionConfig>d__10>(ref <GetRemoteVersionConfig>d__);
			return <GetRemoteVersionConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00053580 File Offset: 0x00051780
		public bool HasPreDownloadData()
		{
			return LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PreDownloadRecord, "") == RemoteInfo.Instance.NewConfig.PackageVersion || LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PreDownloadState, "") != "";
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000535D6 File Offset: 0x000517D6
		public bool IsFirstTimeUpdateForPackage()
		{
			return ProcedureUtil.IsFirstTimeUpdateForPackage();
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000535E0 File Offset: 0x000517E0
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

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0005369C File Offset: 0x0005189C
		public UniTask<bool> IsAppVersionChange()
		{
			BaseDiffPatchProcedure.<IsAppVersionChange>d__14 <IsAppVersionChange>d__;
			<IsAppVersionChange>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<IsAppVersionChange>d__.<>4__this = this;
			<IsAppVersionChange>d__.<>1__state = -1;
			<IsAppVersionChange>d__.<>t__builder.Start<BaseDiffPatchProcedure.<IsAppVersionChange>d__14>(ref <IsAppVersionChange>d__);
			return <IsAppVersionChange>d__.<>t__builder.Task;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000536E0 File Offset: 0x000518E0
		public UniTask<bool> IsPostUpdateAppVersionChange()
		{
			BaseDiffPatchProcedure.<IsPostUpdateAppVersionChange>d__15 <IsPostUpdateAppVersionChange>d__;
			<IsPostUpdateAppVersionChange>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<IsPostUpdateAppVersionChange>d__.<>4__this = this;
			<IsPostUpdateAppVersionChange>d__.<>1__state = -1;
			<IsPostUpdateAppVersionChange>d__.<>t__builder.Start<BaseDiffPatchProcedure.<IsPostUpdateAppVersionChange>d__15>(ref <IsPostUpdateAppVersionChange>d__);
			return <IsPostUpdateAppVersionChange>d__.<>t__builder.Task;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00053724 File Offset: 0x00051924
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

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00053777 File Offset: 0x00051977
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x0005377F File Offset: 0x0005197F
		[Nullable(1)]
		public Func<DiffUpdate, HotFixManager, UniTask> RegistryExtraPack { [NullableContext(1)] get; [NullableContext(1)] set; } = (DiffUpdate update, HotFixManager hotFixManager) => UniTask.CompletedTask;

		// Token: 0x06000DDD RID: 3549 RVA: 0x00053788 File Offset: 0x00051988
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

		// Token: 0x06000DDE RID: 3550 RVA: 0x00053908 File Offset: 0x00051B08
		public UniTask<bool> Complete()
		{
			BaseDiffPatchProcedure.<Complete>d__22 <Complete>d__;
			<Complete>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Complete>d__.<>4__this = this;
			<Complete>d__.<>1__state = -1;
			<Complete>d__.<>t__builder.Start<BaseDiffPatchProcedure.<Complete>d__22>(ref <Complete>d__);
			return <Complete>d__.<>t__builder.Task;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0005394C File Offset: 0x00051B4C
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

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000539A0 File Offset: 0x00051BA0
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
					hotPatchLog.s_step_result = LauncherJson.Stringify<HotPatchLogResult>(hotPatchLogResult, null);
					HotPatchLogReport.Instance.Report(hotPatchLog);
					return ERemoteConfigResult.None;
				}
				if (!ignoreOutDateAndIllegal)
				{
					if (num4 > num5)
					{
						hotPatchLogResult.success = false;
						hotPatchLogResult.info = "failed, the most of remote configs is out of date.";
						hotPatchLog.s_step_result = LauncherJson.Stringify<HotPatchLogResult>(hotPatchLogResult, null);
						HotPatchLogReport.Instance.Report(hotPatchLog);
						return ERemoteConfigResult.OutDate;
					}
					hotPatchLogResult.success = false;
					hotPatchLogResult.info = "failed, the most of remote config field is illegal.";
					hotPatchLog.s_step_result = LauncherJson.Stringify<HotPatchLogResult>(hotPatchLogResult, null);
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
						hotPatchLog.s_step_result = LauncherJson.Stringify<HotPatchLogResult>(hotPatchLogResult, null);
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
			hotPatchLog.s_step_result = LauncherJson.Stringify<HotPatchLogResult>(hotPatchLogResult, null);
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

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00053D40 File Offset: 0x00051F40
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

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00053D8C File Offset: 0x00051F8C
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

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00053DDF File Offset: 0x00051FDF
		[NullableContext(1)]
		protected virtual UniTask OnAfterResolveManifests(DiffUpdate _update)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x040008A7 RID: 2215
		private bool IsInitUrlPrefix;

		// Token: 0x040008A8 RID: 2216
		[Nullable(2)]
		private string AppVersion;

		// Token: 0x040008AA RID: 2218
		[Nullable(2)]
		private readonly AppPathMisc PathMisc;

		// Token: 0x040008AB RID: 2219
		[Nullable(2)]
		protected readonly HotFixManager ViewMgr;
	}
}
