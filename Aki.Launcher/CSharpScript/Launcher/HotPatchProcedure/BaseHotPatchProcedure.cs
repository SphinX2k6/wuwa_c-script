using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.HotPatchProcedure
{
	// Token: 0x020001D5 RID: 469
	public abstract class BaseHotPatchProcedure : IHotPatchProcedure
	{
		// Token: 0x06000C69 RID: 3177 RVA: 0x0004BFE3 File Offset: 0x0004A1E3
		[NullableContext(1)]
		public BaseHotPatchProcedure(AppPathMisc pathMisc, HotFixManager viewMgr)
		{
			this.PathMisc = pathMisc;
			this.ViewMgr = viewMgr;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0004BFFC File Offset: 0x0004A1FC
		public virtual UniTask<bool> Start()
		{
			BaseHotPatchProcedure.<Start>d__5 <Start>d__;
			<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Start>d__.<>4__this = this;
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<BaseHotPatchProcedure.<Start>d__5>(ref <Start>d__);
			return <Start>d__.<>t__builder.Task;
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0004C040 File Offset: 0x0004A240
		public UniTask<bool> GetRemoteVersionConfig()
		{
			BaseHotPatchProcedure.<GetRemoteVersionConfig>d__6 <GetRemoteVersionConfig>d__;
			<GetRemoteVersionConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<GetRemoteVersionConfig>d__.<>4__this = this;
			<GetRemoteVersionConfig>d__.<>1__state = -1;
			<GetRemoteVersionConfig>d__.<>t__builder.Start<BaseHotPatchProcedure.<GetRemoteVersionConfig>d__6>(ref <GetRemoteVersionConfig>d__);
			return <GetRemoteVersionConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0004C084 File Offset: 0x0004A284
		public UniTask<bool> IsAppVersionChange()
		{
			BaseHotPatchProcedure.<IsAppVersionChange>d__7 <IsAppVersionChange>d__;
			<IsAppVersionChange>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<IsAppVersionChange>d__.<>4__this = this;
			<IsAppVersionChange>d__.<>1__state = -1;
			<IsAppVersionChange>d__.<>t__builder.Start<BaseHotPatchProcedure.<IsAppVersionChange>d__7>(ref <IsAppVersionChange>d__);
			return <IsAppVersionChange>d__.<>t__builder.Task;
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0004C0C8 File Offset: 0x0004A2C8
		public virtual UniTask<bool> UpdateResource(bool bUseBgDownload, [Nullable(1)] params ResourceUpdate[] updates)
		{
			BaseHotPatchProcedure.<UpdateResource>d__8 <UpdateResource>d__;
			<UpdateResource>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdateResource>d__.<>4__this = this;
			<UpdateResource>d__.bUseBgDownload = bUseBgDownload;
			<UpdateResource>d__.updates = updates;
			<UpdateResource>d__.<>1__state = -1;
			<UpdateResource>d__.<>t__builder.Start<BaseHotPatchProcedure.<UpdateResource>d__8>(ref <UpdateResource>d__);
			return <UpdateResource>d__.<>t__builder.Task;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0004C11C File Offset: 0x0004A31C
		protected virtual UniTask<bool> CheckResourceVersion([Nullable(1)] ResourceUpdate update)
		{
			BaseHotPatchProcedure.<CheckResourceVersion>d__9 <CheckResourceVersion>d__;
			<CheckResourceVersion>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CheckResourceVersion>d__.<>4__this = this;
			<CheckResourceVersion>d__.update = update;
			<CheckResourceVersion>d__.<>1__state = -1;
			<CheckResourceVersion>d__.<>t__builder.Start<BaseHotPatchProcedure.<CheckResourceVersion>d__9>(ref <CheckResourceVersion>d__);
			return <CheckResourceVersion>d__.<>t__builder.Task;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0004C168 File Offset: 0x0004A368
		protected UniTask<bool> DownloadIndexFile([Nullable(1)] ResourceUpdate update)
		{
			BaseHotPatchProcedure.<DownloadIndexFile>d__10 <DownloadIndexFile>d__;
			<DownloadIndexFile>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadIndexFile>d__.<>4__this = this;
			<DownloadIndexFile>d__.update = update;
			<DownloadIndexFile>d__.<>1__state = -1;
			<DownloadIndexFile>d__.<>t__builder.Start<BaseHotPatchProcedure.<DownloadIndexFile>d__10>(ref <DownloadIndexFile>d__);
			return <DownloadIndexFile>d__.<>t__builder.Task;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0004C1B4 File Offset: 0x0004A3B4
		protected UniTask<bool> ResolveIndexFile([Nullable(1)] ResourceUpdate update)
		{
			BaseHotPatchProcedure.<ResolveIndexFile>d__11 <ResolveIndexFile>d__;
			<ResolveIndexFile>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ResolveIndexFile>d__.<>4__this = this;
			<ResolveIndexFile>d__.update = update;
			<ResolveIndexFile>d__.<>1__state = -1;
			<ResolveIndexFile>d__.<>t__builder.Start<BaseHotPatchProcedure.<ResolveIndexFile>d__11>(ref <ResolveIndexFile>d__);
			return <ResolveIndexFile>d__.<>t__builder.Task;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0004C200 File Offset: 0x0004A400
		protected UniTask<bool> CheckResourceFiles([Nullable(1)] ResourceUpdate update)
		{
			BaseHotPatchProcedure.<CheckResourceFiles>d__12 <CheckResourceFiles>d__;
			<CheckResourceFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CheckResourceFiles>d__.<>4__this = this;
			<CheckResourceFiles>d__.update = update;
			<CheckResourceFiles>d__.<>1__state = -1;
			<CheckResourceFiles>d__.<>t__builder.Start<BaseHotPatchProcedure.<CheckResourceFiles>d__12>(ref <CheckResourceFiles>d__);
			return <CheckResourceFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0004C24C File Offset: 0x0004A44C
		protected UniTask<bool> DoesSavedDirHaveEnoughSpace(long needSize)
		{
			BaseHotPatchProcedure.<DoesSavedDirHaveEnoughSpace>d__13 <DoesSavedDirHaveEnoughSpace>d__;
			<DoesSavedDirHaveEnoughSpace>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DoesSavedDirHaveEnoughSpace>d__.<>4__this = this;
			<DoesSavedDirHaveEnoughSpace>d__.needSize = needSize;
			<DoesSavedDirHaveEnoughSpace>d__.<>1__state = -1;
			<DoesSavedDirHaveEnoughSpace>d__.<>t__builder.Start<BaseHotPatchProcedure.<DoesSavedDirHaveEnoughSpace>d__13>(ref <DoesSavedDirHaveEnoughSpace>d__);
			return <DoesSavedDirHaveEnoughSpace>d__.<>t__builder.Task;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0004C298 File Offset: 0x0004A498
		protected virtual UniTask<bool> DownloadFiles(bool bUseBgDownload, [Nullable(1)] params ResourceUpdate[] updates)
		{
			BaseHotPatchProcedure.<DownloadFiles>d__14 <DownloadFiles>d__;
			<DownloadFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadFiles>d__.<>4__this = this;
			<DownloadFiles>d__.updates = updates;
			<DownloadFiles>d__.<>1__state = -1;
			<DownloadFiles>d__.<>t__builder.Start<BaseHotPatchProcedure.<DownloadFiles>d__14>(ref <DownloadFiles>d__);
			return <DownloadFiles>d__.<>t__builder.Task;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0004C2E4 File Offset: 0x0004A4E4
		protected UniTask<bool> CheckNeedRestartApp([Nullable(1)] ResourceUpdate update)
		{
			BaseHotPatchProcedure.<CheckNeedRestartApp>d__15 <CheckNeedRestartApp>d__;
			<CheckNeedRestartApp>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CheckNeedRestartApp>d__.<>4__this = this;
			<CheckNeedRestartApp>d__.update = update;
			<CheckNeedRestartApp>d__.<>1__state = -1;
			<CheckNeedRestartApp>d__.<>t__builder.Start<BaseHotPatchProcedure.<CheckNeedRestartApp>d__15>(ref <CheckNeedRestartApp>d__);
			return <CheckNeedRestartApp>d__.<>t__builder.Task;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0004C330 File Offset: 0x0004A530
		[NullableContext(1)]
		public bool NeedRestart(params ResourceUpdate[] updates)
		{
			for (int i = 0; i < updates.Length; i++)
			{
				if (updates[i].GetNeedRestart())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0004C35C File Offset: 0x0004A55C
		public UniTask<bool> MountPak([Nullable(1)] params ResourceUpdate[] updates)
		{
			BaseHotPatchProcedure.<MountPak>d__17 <MountPak>d__;
			<MountPak>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MountPak>d__.<>4__this = this;
			<MountPak>d__.updates = updates;
			<MountPak>d__.<>1__state = -1;
			<MountPak>d__.<>t__builder.Start<BaseHotPatchProcedure.<MountPak>d__17>(ref <MountPak>d__);
			return <MountPak>d__.<>t__builder.Task;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0004C3A8 File Offset: 0x0004A5A8
		public virtual void PreComplete()
		{
			RemoteConfig config = RemoteInfo.Instance.Config;
			if (((config != null) ? config.LauncherVersion : null) != null)
			{
				LauncherStorageLib.Instance.SetDeviceSaved<string>(ELauncherStorageDeviceKey.LauncherPatchVersion, RemoteInfo.Instance.Config.LauncherVersion);
			}
			RemoteConfig config2 = RemoteInfo.Instance.Config;
			if (((config2 != null) ? config2.ResourceVersion : null) != null)
			{
				LauncherStorageLib.Instance.SetDeviceSaved<string>(ELauncherStorageDeviceKey.PatchVersion, RemoteInfo.Instance.Config.ResourceVersion);
			}
			RemoteConfig config3 = RemoteInfo.Instance.Config;
			if (((config3 != null) ? config3.ChangeList : null) != null && RemoteInfo.Instance.Config.ChangeList.Length > 0)
			{
				LauncherStorageLib.Instance.SetDeviceSaved<string>(ELauncherStorageDeviceKey.PatchP4Version, RemoteInfo.Instance.Config.ChangeList);
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0004C468 File Offset: 0x0004A668
		public virtual UniTask<bool> Complete()
		{
			BaseHotPatchProcedure.<Complete>d__19 <Complete>d__;
			<Complete>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Complete>d__.<>4__this = this;
			<Complete>d__.<>1__state = -1;
			<Complete>d__.<>t__builder.Start<BaseHotPatchProcedure.<Complete>d__19>(ref <Complete>d__);
			return <Complete>d__.<>t__builder.Task;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0004C4AC File Offset: 0x0004A6AC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<RemoteConfig> RequestRemoteConfig(List<string> prefixList, string remoteConfigUrl, Dictionary<string, RemoteConfig> configMapRef)
		{
			BaseHotPatchProcedure.<RequestRemoteConfig>d__20 <RequestRemoteConfig>d__;
			<RequestRemoteConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<RemoteConfig>.Create();
			<RequestRemoteConfig>d__.prefixList = prefixList;
			<RequestRemoteConfig>d__.remoteConfigUrl = remoteConfigUrl;
			<RequestRemoteConfig>d__.configMapRef = configMapRef;
			<RequestRemoteConfig>d__.<>1__state = -1;
			<RequestRemoteConfig>d__.<>t__builder.Start<BaseHotPatchProcedure.<RequestRemoteConfig>d__20>(ref <RequestRemoteConfig>d__);
			return <RequestRemoteConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0004C500 File Offset: 0x0004A700
		[NullableContext(1)]
		private ERemoteConfigResult SetRemoteConfigInfo(long lastUpdateTime, [Nullable(2)] RemoteConfig newestConfig, Dictionary<string, RemoteConfig> configMap, bool ignoreOutDateAndIllegal)
		{
			HotPatchLog hotPatchLog = new HotPatchLog();
			HotPatchLogResult hotPatchLogResult = new HotPatchLogResult
			{
				success = true
			};
			hotPatchLog.s_step_id = "end_download_remote_config";
			HotPatchLog hotPatchLog2 = new HotPatchLog();
			hotPatchLog2.s_step_id = "check_remote_config";
			RemoteConfig remoteConfig = newestConfig;
			long? num;
			if (remoteConfig != null)
			{
				long? updateTime = remoteConfig.UpdateTime;
				num = ((lastUpdateTime > updateTime.GetValueOrDefault() & updateTime != null) ? new long?(lastUpdateTime) : remoteConfig.UpdateTime);
			}
			else
			{
				num = new long?(lastUpdateTime);
			}
			long? num2 = num;
			int num3 = 0;
			int num4 = 0;
			foreach (KeyValuePair<string, RemoteConfig> keyValuePair in configMap)
			{
				string key = keyValuePair.Key;
				RemoteConfig value = keyValuePair.Value;
				if (value.UpdateTime == null)
				{
					LauncherLog.Instance.Error("远程配置文件UpdateTime字段非法！", default(ReadOnlySpan<ValueTuple<string, object>>));
					hotPatchLog2.s_url_prefix = key;
					hotPatchLog2.s_step_result = "remote config field is illegal. field: UpdateTime";
					HotPatchLogReport.Instance.Report(hotPatchLog2);
					num4++;
				}
				else
				{
					long? updateTime = value.UpdateTime;
					long? num5 = num2;
					if (updateTime.GetValueOrDefault() < num5.GetValueOrDefault() & (updateTime != null & num5 != null))
					{
						LauncherLog instance = LauncherLog.Instance;
						string message = "远程配置文件已过时！";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("prefix", key);
						instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						hotPatchLog2.s_url_prefix = key;
						hotPatchLog2.s_step_result = "out date";
						hotPatchLog2.i_latest_time = num2;
						hotPatchLog2.i_out_date_time = value.UpdateTime;
						HotPatchLogReport.Instance.Report(hotPatchLog2);
						num3++;
					}
				}
			}
			if (remoteConfig == null)
			{
				if (num3 <= 0 && num4 <= 0)
				{
					hotPatchLogResult.success = false;
					hotPatchLogResult.info = "failed, get all remote configs failed.";
					hotPatchLog.s_step_result = LauncherJson.Stringify<HotPatchLogResult>(hotPatchLogResult, null);
					HotPatchLogReport.Instance.Report(hotPatchLog);
					return ERemoteConfigResult.None;
				}
				if (!ignoreOutDateAndIllegal)
				{
					if (num3 > num4)
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
					using (Dictionary<string, RemoteConfig>.Enumerator enumerator = configMap.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							KeyValuePair<string, RemoteConfig> keyValuePair2 = enumerator.Current;
							remoteConfig = keyValuePair2.Value;
						}
					}
				}
			}
			hotPatchLogResult.success = true;
			hotPatchLogResult.info = "success";
			hotPatchLog.s_step_result = LauncherJson.Stringify<HotPatchLogResult>(hotPatchLogResult, null);
			HotPatchLogReport.Instance.Report(hotPatchLog);
			RemoteInfo.Instance.Config = remoteConfig;
			if (!ignoreOutDateAndIllegal)
			{
				long? num5 = RemoteInfo.Instance.Config.UpdateTime;
				if (num5.GetValueOrDefault() > lastUpdateTime & num5 != null)
				{
					LauncherStorageLib.Instance.SetDeviceSaved<long?>(ELauncherStorageDeviceKey.RemoteVersionUpdate, RemoteInfo.Instance.Config.UpdateTime);
				}
			}
			return ERemoteConfigResult.Success;
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0004C89C File Offset: 0x0004AA9C
		private UniTask<ERemoteConfigResult> InternalGetRemoteVersionConfig(bool ignoreOutDateAndIllegal = false)
		{
			BaseHotPatchProcedure.<InternalGetRemoteVersionConfig>d__22 <InternalGetRemoteVersionConfig>d__;
			<InternalGetRemoteVersionConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<ERemoteConfigResult>.Create();
			<InternalGetRemoteVersionConfig>d__.<>4__this = this;
			<InternalGetRemoteVersionConfig>d__.ignoreOutDateAndIllegal = ignoreOutDateAndIllegal;
			<InternalGetRemoteVersionConfig>d__.<>1__state = -1;
			<InternalGetRemoteVersionConfig>d__.<>t__builder.Start<BaseHotPatchProcedure.<InternalGetRemoteVersionConfig>d__22>(ref <InternalGetRemoteVersionConfig>d__);
			return <InternalGetRemoteVersionConfig>d__.<>t__builder.Task;
		}

		// Token: 0x040007D4 RID: 2004
		private bool IsInitUrlPrefix;

		// Token: 0x040007D5 RID: 2005
		[Nullable(2)]
		private string AppVersion;

		// Token: 0x040007D6 RID: 2006
		[Nullable(2)]
		private readonly AppPathMisc PathMisc;

		// Token: 0x040007D7 RID: 2007
		[Nullable(2)]
		protected readonly HotFixManager ViewMgr;
	}
}
