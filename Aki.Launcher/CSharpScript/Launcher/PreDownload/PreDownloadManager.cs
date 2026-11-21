using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Download;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.PreDownload
{
	// Token: 0x0200011B RID: 283
	[NullableContext(1)]
	[Nullable(0)]
	public class PreDownloadManager : IPreDownload, IStaticVariableResetter
	{
		// Token: 0x0600091C RID: 2332 RVA: 0x00042E34 File Offset: 0x00041034
		static PreDownloadManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PreDownloadManager.CreateStaticDefaultValue), new Action(PreDownloadManager.ResetStaticDefaultValue));
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00042E53 File Offset: 0x00041053
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00042E55 File Offset: 0x00041055
		public static void ResetStaticDefaultValue()
		{
			PreDownloadManager.PreDownload = null;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00042E60 File Offset: 0x00041060
		public static IPreDownload Get()
		{
			if (PreDownloadManager.PreDownload == null)
			{
				string text = KuroApplication.IniPlatformNameIncludeEditor();
				if (text == "Android" || text == "IOS" || text == "OpenHarmony")
				{
					(PreDownloadManager.PreDownload = new PreDownloadManager()).Init(text).Forget();
				}
				else
				{
					PreDownloadManager.PreDownload = new NullPreDownload();
				}
			}
			return PreDownloadManager.PreDownload;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00042EC8 File Offset: 0x000410C8
		private PreDownloadManager()
		{
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00042EFC File Offset: 0x000410FC
		public static string getLocalText([Nullable(2)] string textTableId, params string[] args)
		{
			if (string.IsNullOrEmpty(textTableId))
			{
				return string.Empty;
			}
			string hotPatchText = LauncherConfigLib.Instance.GetHotPatchText(textTableId);
			if (hotPatchText == null)
			{
				return string.Empty;
			}
			string text = hotPatchText;
			for (int i = 0; i < args.Length; i++)
			{
				string newValue = args[i];
				string oldValue = "{" + i.ToString() + "}";
				text = text.Replace(oldValue, newValue);
			}
			return text;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00042F64 File Offset: 0x00041164
		protected UniTask Init(string platform)
		{
			PreDownloadManager.<Init>d__24 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.platform = platform;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<PreDownloadManager.<Init>d__24>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00042FB0 File Offset: 0x000411B0
		public void CheckEnabledWithTick()
		{
			LauncherLog.Instance.Info("PreDownloadManager add tick to check preDownload config", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (!this.IsPreDownloadEnabled())
			{
				this.AddTick();
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00042FE3 File Offset: 0x000411E3
		public void TryRemoveTick()
		{
			this.RemoveTick();
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00042FEC File Offset: 0x000411EC
		protected void AddTick()
		{
			if (this.TickMgr != null && this.TickMgr.IsValid())
			{
				return;
			}
			if (Launch.LaunchGameInstance == null || !Launch.LaunchGameInstance.IsValid())
			{
				LauncherLog.Instance.Error("PreDownaloadManager AddTick ->Launch game instance is not valid", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.TickMgr = new UKuroTickManager(Launch.LaunchGameInstance, null, EObjectFlags.RF_NoFlags);
			this.TickDelegate = new Action<float>(this.<AddTick>g__TickCallback|27_0);
			this.Interval = 0f;
			this.TickMgr.AddTick(ETickingGroup.TG_PrePhysics, DelegateUtils.ToManualReleaseDelegate<FTickHandler>(this.TickDelegate), 0);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00043084 File Offset: 0x00041284
		protected void RemoveTick()
		{
			if (this.TickDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(this.TickDelegate);
				this.TickDelegate = null;
			}
			if (this.TickMgr != null)
			{
				this.TickMgr.RemoveTick(ETickingGroup.TG_PrePhysics);
				this.TickMgr = null;
			}
			this.Interval = 0f;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000430D4 File Offset: 0x000412D4
		protected UniTask Tick(float deltaSeconds)
		{
			PreDownloadManager.<Tick>d__29 <Tick>d__;
			<Tick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Tick>d__.<>4__this = this;
			<Tick>d__.deltaSeconds = deltaSeconds;
			<Tick>d__.<>1__state = -1;
			<Tick>d__.<>t__builder.Start<PreDownloadManager.<Tick>d__29>(ref <Tick>d__);
			return <Tick>d__.<>t__builder.Task;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00043120 File Offset: 0x00041320
		protected UniTask CheckPreDownloadConfig()
		{
			PreDownloadManager.<CheckPreDownloadConfig>d__30 <CheckPreDownloadConfig>d__;
			<CheckPreDownloadConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckPreDownloadConfig>d__.<>4__this = this;
			<CheckPreDownloadConfig>d__.<>1__state = -1;
			<CheckPreDownloadConfig>d__.<>t__builder.Start<PreDownloadManager.<CheckPreDownloadConfig>d__30>(ref <CheckPreDownloadConfig>d__);
			return <CheckPreDownloadConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00043163 File Offset: 0x00041363
		public void AddEnabledEvent(Action cb)
		{
			if (this.HasPreDownloadConfig())
			{
				cb();
				return;
			}
			if (cb != null)
			{
				this.EnabledCbSet.Add(cb);
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00043184 File Offset: 0x00041384
		public void RemoveEnabledEvent(Action cb)
		{
			if (cb != null)
			{
				this.EnabledCbSet.Remove(cb);
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00043196 File Offset: 0x00041396
		public void AddCompleteEvent(Action cb)
		{
			if (cb != null)
			{
				this.CompleteCbSet.Add(cb);
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000431A8 File Offset: 0x000413A8
		public void RemoveCompleteEvent(Action cb)
		{
			if (cb != null)
			{
				this.CompleteCbSet.Remove(cb);
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000431BA File Offset: 0x000413BA
		private bool HasPreDownloadConfig()
		{
			return this.Config != null;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000431C5 File Offset: 0x000413C5
		public bool IsPreDownloadEnabled()
		{
			return this.HasPreDownloadConfig() && this.CheckedRes;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000431D7 File Offset: 0x000413D7
		public void SetView(IPreDownloadUiEvent ui)
		{
			if (this.UiAgent != null)
			{
				this.UiAgent.SetView(ui);
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000431ED File Offset: 0x000413ED
		public void ClearView()
		{
			if (this.UiAgent != null)
			{
				this.UiAgent.ClearView();
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00043204 File Offset: 0x00041404
		protected UniTask GetPreDownloadVersionCfg()
		{
			PreDownloadManager.<GetPreDownloadVersionCfg>d__39 <GetPreDownloadVersionCfg>d__;
			<GetPreDownloadVersionCfg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GetPreDownloadVersionCfg>d__.<>4__this = this;
			<GetPreDownloadVersionCfg>d__.<>1__state = -1;
			<GetPreDownloadVersionCfg>d__.<>t__builder.Start<PreDownloadManager.<GetPreDownloadVersionCfg>d__39>(ref <GetPreDownloadVersionCfg>d__);
			return <GetPreDownloadVersionCfg>d__.<>t__builder.Task;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00043248 File Offset: 0x00041448
		[NullableContext(0)]
		protected UniTask<bool> GetPreDownloadTierVersionCfg()
		{
			PreDownloadManager.<GetPreDownloadTierVersionCfg>d__40 <GetPreDownloadTierVersionCfg>d__;
			<GetPreDownloadTierVersionCfg>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<GetPreDownloadTierVersionCfg>d__.<>4__this = this;
			<GetPreDownloadTierVersionCfg>d__.<>1__state = -1;
			<GetPreDownloadTierVersionCfg>d__.<>t__builder.Start<PreDownloadManager.<GetPreDownloadTierVersionCfg>d__40>(ref <GetPreDownloadTierVersionCfg>d__);
			return <GetPreDownloadTierVersionCfg>d__.<>t__builder.Task;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0004328C File Offset: 0x0004148C
		[NullableContext(2)]
		private string ResolvePreDownloadTierLabel()
		{
			if (!RemoteInfo.Instance.IsResourceQualityTierEnabled())
			{
				return null;
			}
			string text = LauncherDeviceTierLib.TierToLabel(RemoteInfo.Instance.ActiveTier);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return null;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000432C4 File Offset: 0x000414C4
		protected unsafe void InitPreDownloadVersion()
		{
			if (RemoteInfo.Instance.PreVerConfig == null)
			{
				LauncherLog.Instance.Error("pre download version is not exist", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			LauncherLog.Instance.Info("init pre download version config", default(ReadOnlySpan<ValueTuple<string, object>>));
			List<ResPackageInfo> list = new List<ResPackageInfo>();
			string packageVersion = RemoteInfo.Instance.PreVerConfig.PackageVersion;
			string appVersion = UKuroLauncherLibrary.GetAppVersion();
			ValueTuple<bool, VersionInfo> valueTuple = VersionInfo.TryParse(packageVersion);
			bool item = valueTuple.Item1;
			VersionInfo item2 = valueTuple.Item2;
			ValueTuple<bool, VersionInfo> valueTuple2 = VersionInfo.TryParse(appVersion);
			bool item3 = valueTuple2.Item1;
			VersionInfo item4 = valueTuple2.Item2;
			if (!item || !item3)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "app version is invalid";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("appVer", appVersion);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("nextAppVersion", packageVersion);
				instance.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (VersionInfo.LessThanOrEqual(item2, item4))
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "next app version is invalid";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("appVer", appVersion);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("nextAppVersion", packageVersion);
				instance2.Error(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			VersionItem versionItem;
			if (!RemoteInfo.Instance.PreVerConfig.ResVersions.TryGetValue("resource", out versionItem))
			{
				throw new Exception("预下载远程版本配置中，没有resource的信息");
			}
			string mixUri = this.Config.MixUri;
			ResPackageInfo item5 = new ResPackageInfo(mixUri, new ResourceVersionInfo(packageVersion, packageVersion, versionItem.IndexSha1), true);
			list.Add(item5);
			HashSet<string> hashSet = new HashSet<string>();
			IReadOnlyList<LaunchLangDefine> allLanguageDefines = LauncherLanguageLib.Instance.GetAllLanguageDefines();
			for (int i = 0; i < allLanguageDefines.Count; i++)
			{
				LaunchLangDefine launchLangDefine = allLanguageDefines[i];
				if (!hashSet.Contains(launchLangDefine.AudioCode))
				{
					VersionItem versionItem2;
					if (!RemoteInfo.Instance.PreVerConfig.ResVersions.TryGetValue(launchLangDefine.AudioCode, out versionItem2))
					{
						throw new Exception("预下载远程版本配置中，没有多语言" + launchLangDefine.AudioCode + "的信息");
					}
					ResPackageInfo item6 = new ResPackageInfo(mixUri, new LanguageVersionInfo(packageVersion, packageVersion, versionItem2.IndexSha1, launchLangDefine.AudioCode), true);
					hashSet.Add(launchLangDefine.AudioCode);
					list.Add(item6);
				}
			}
			foreach (KeyValuePair<string, VersionItem> keyValuePair in RemoteInfo.Instance.PreVerConfig.ResVersions)
			{
				string key = keyValuePair.Key;
				VersionItem value = keyValuePair.Value;
				if (key.StartsWith("Option_"))
				{
					string text = key.Replace("Option_", "");
					ResPackageInfo resPackageInfo = new ResPackageInfo(mixUri, new OptionalDownloadVersionInfo(packageVersion, packageVersion, value.IndexSha1, text), true);
					bool flag = resPackageInfo.ResourceVersionInfo.RecordVersion != "";
					bool flag2 = !ResPackageInfo.OptionalDownLoadInfo.ContainsKey(text);
					if (!flag && !flag2)
					{
						LauncherLog instance3 = LauncherLog.Instance;
						string message3 = "skip optional pre download (未下过且非新增)";
						ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("packName", text);
						instance3.Info(message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					}
					else
					{
						LauncherLog instance4 = LauncherLog.Instance;
						string message4 = "add optional download pre download ver info";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("packName", text);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("downloaded", flag);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("isNewBlock", flag2);
						instance4.Info(message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
						list.Add(resPackageInfo);
					}
				}
			}
			string text2 = (this.PreTierConfig != null) ? this.ResolvePreDownloadTierLabel() : null;
			if (!string.IsNullOrEmpty(text2) && this.PreTierConfig != null)
			{
				VersionItem versionItem3;
				if (this.PreTierConfig.ResVersions.TryGetValue("resource", out versionItem3))
				{
					list.Add(new ResPackageInfo(mixUri, new TierResourceVersionInfo(packageVersion, packageVersion, versionItem3.IndexSha1, text2), true));
				}
				HashSet<string> hashSet2 = new HashSet<string>();
				for (int j = 0; j < allLanguageDefines.Count; j++)
				{
					LaunchLangDefine launchLangDefine2 = allLanguageDefines[j];
					VersionItem versionItem4;
					if (!hashSet2.Contains(launchLangDefine2.AudioCode) && this.PreTierConfig.ResVersions.TryGetValue(launchLangDefine2.AudioCode, out versionItem4))
					{
						hashSet2.Add(launchLangDefine2.AudioCode);
						list.Add(new ResPackageInfo(mixUri, new TierLanguageVersionInfo(packageVersion, packageVersion, versionItem4.IndexSha1, launchLangDefine2.AudioCode, text2), true));
					}
				}
				foreach (KeyValuePair<string, VersionItem> keyValuePair2 in this.PreTierConfig.ResVersions)
				{
					if (keyValuePair2.Key.StartsWith("Option_"))
					{
						string packKey = keyValuePair2.Key.Replace("Option_", "");
						list.Add(new ResPackageInfo(mixUri, new TierOptionalDownloadVersionInfo(packageVersion, packageVersion, keyValuePair2.Value.IndexSha1, packKey, text2), true));
					}
				}
				LauncherLog instance5 = LauncherLog.Instance;
				string message5 = "预下载已追加当前档位的分级包";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("tier", text2);
				instance5.Info(message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			}
			UrlPrefixDownload downloader = new UrlPrefixDownload();
			UpdateReportEvent reportEvent = new UpdateReportEvent("PreDownload");
			this.UiAgent = new PreDownloadUiEvent();
			this.DiffUpdater = new DiffUpdate(list, downloader, this.UiAgent, reportEvent, false, EUpdateType.PreDownload);
			ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>> valueTuple5 = VideoPreDownload.Instance.AnalyzePreDownloadRequireFiles();
			List<LocalFileInfo> item7 = valueTuple5.Item1;
			List<RequireFileInfo> item8 = valueTuple5.Item2;
			this.DiffUpdater.RegisterExtraRequireFiles(item7, item8);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x000438A0 File Offset: 0x00041AA0
		protected UniTask CheckResource()
		{
			PreDownloadManager.<CheckResource>d__43 <CheckResource>d__;
			<CheckResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckResource>d__.<>4__this = this;
			<CheckResource>d__.<>1__state = -1;
			<CheckResource>d__.<>t__builder.Start<PreDownloadManager.<CheckResource>d__43>(ref <CheckResource>d__);
			return <CheckResource>d__.<>t__builder.Task;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x000438E4 File Offset: 0x00041AE4
		protected UniTask DownloadPreResources()
		{
			PreDownloadManager.<DownloadPreResources>d__44 <DownloadPreResources>d__;
			<DownloadPreResources>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DownloadPreResources>d__.<>4__this = this;
			<DownloadPreResources>d__.<>1__state = -1;
			<DownloadPreResources>d__.<>t__builder.Start<PreDownloadManager.<DownloadPreResources>d__44>(ref <DownloadPreResources>d__);
			return <DownloadPreResources>d__.<>t__builder.Task;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00043927 File Offset: 0x00041B27
		public long GetDownloadSize()
		{
			return this.TotalDownSize;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0004392F File Offset: 0x00041B2F
		public long GetNeedSpace()
		{
			return this.NeedSpace;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00043938 File Offset: 0x00041B38
		public void Start(EPreDownloadMode mode)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "start pre download.";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mode", mode);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.DownloadPreResources().Forget();
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00043978 File Offset: 0x00041B78
		public void Stop()
		{
			if (this.PreDownloadState == EPreDownloadState.Patching)
			{
				LauncherLog.Instance.Info("doing patch now.", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			LauncherLog.Instance.Info("stop pre download.", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.DiffUpdater != null)
			{
				this.DiffUpdater.Stop();
			}
			this.PreDownloadState = EPreDownloadState.Stopped;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000439DC File Offset: 0x00041BDC
		public void Resume()
		{
			if (this.PreDownloadState == EPreDownloadState.Patching)
			{
				LauncherLog.Instance.Info("still doing patch now.", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			LauncherLog.Instance.Info("resume pre download.", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.DiffUpdater != null)
			{
				this.DiffUpdater.Resume();
			}
			this.DownloadPreResources().Forget();
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00043A41 File Offset: 0x00041C41
		public bool IsDownloading()
		{
			return this.PreDownloadState == EPreDownloadState.Downloading;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00043A4C File Offset: 0x00041C4C
		public bool IsComplete()
		{
			return this.PreDownloadState == EPreDownloadState.Finished;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00043A57 File Offset: 0x00041C57
		public EPreDownloadState GetState()
		{
			return this.PreDownloadState;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00043A5F File Offset: 0x00041C5F
		[CompilerGenerated]
		private void <AddTick>g__TickCallback|27_0(float deltaSeconds)
		{
			this.Tick(deltaSeconds).Forget();
		}

		// Token: 0x0400054F RID: 1359
		private const int TICK_INTERVAL_S = 600;

		// Token: 0x04000550 RID: 1360
		[Nullable(2)]
		private static IPreDownload PreDownload;

		// Token: 0x04000551 RID: 1361
		private string Platform = "";

		// Token: 0x04000552 RID: 1362
		private EPreDownloadState PreDownloadState;

		// Token: 0x04000553 RID: 1363
		[Nullable(2)]
		private object PreDownloadRunToken;

		// Token: 0x04000554 RID: 1364
		[Nullable(2)]
		private PreDownloadConfig Config;

		// Token: 0x04000555 RID: 1365
		private readonly HashSet<Action> EnabledCbSet = new HashSet<Action>();

		// Token: 0x04000556 RID: 1366
		private readonly HashSet<Action> CompleteCbSet = new HashSet<Action>();

		// Token: 0x04000557 RID: 1367
		[Nullable(2)]
		private UKuroTickManager TickMgr;

		// Token: 0x04000558 RID: 1368
		[Nullable(2)]
		private Action<float> TickDelegate;

		// Token: 0x04000559 RID: 1369
		private float Interval;

		// Token: 0x0400055A RID: 1370
		[Nullable(2)]
		private PreDownloadUiEvent UiAgent;

		// Token: 0x0400055B RID: 1371
		private bool CheckedRes;

		// Token: 0x0400055C RID: 1372
		[Nullable(2)]
		private DiffUpdate DiffUpdater;

		// Token: 0x0400055D RID: 1373
		[Nullable(2)]
		private RemoteVersionConfig PreTierConfig;

		// Token: 0x0400055E RID: 1374
		private List<RequireFileInfo> RequireFiles = new List<RequireFileInfo>();

		// Token: 0x0400055F RID: 1375
		private long TotalDownSize;

		// Token: 0x04000560 RID: 1376
		private long NeedSpace;
	}
}
