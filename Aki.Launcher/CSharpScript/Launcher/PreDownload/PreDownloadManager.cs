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
	// Token: 0x02000117 RID: 279
	[NullableContext(1)]
	[Nullable(0)]
	public class PreDownloadManager : IPreDownload, IStaticVariableResetter
	{
		// Token: 0x060008E8 RID: 2280 RVA: 0x00040A6C File Offset: 0x0003EC6C
		static PreDownloadManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PreDownloadManager.CreateStaticDefaultValue), new Action(PreDownloadManager.ResetStaticDefaultValue));
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00040A8B File Offset: 0x0003EC8B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00040A8D File Offset: 0x0003EC8D
		public static void ResetStaticDefaultValue()
		{
			PreDownloadManager.PreDownload = null;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00040A98 File Offset: 0x0003EC98
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

		// Token: 0x060008EC RID: 2284 RVA: 0x00040B00 File Offset: 0x0003ED00
		private PreDownloadManager()
		{
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00040B34 File Offset: 0x0003ED34
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

		// Token: 0x060008EE RID: 2286 RVA: 0x00040B9C File Offset: 0x0003ED9C
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

		// Token: 0x060008EF RID: 2287 RVA: 0x00040BE8 File Offset: 0x0003EDE8
		public void CheckEnabledWithTick()
		{
			LauncherLog.Instance.Info("PreDownloadManager add tick to check preDownload config", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (!this.IsPreDownloadEnabled())
			{
				this.AddTick();
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00040C1B File Offset: 0x0003EE1B
		public void TryRemoveTick()
		{
			this.RemoveTick();
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00040C24 File Offset: 0x0003EE24
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

		// Token: 0x060008F2 RID: 2290 RVA: 0x00040CBC File Offset: 0x0003EEBC
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

		// Token: 0x060008F3 RID: 2291 RVA: 0x00040D0C File Offset: 0x0003EF0C
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

		// Token: 0x060008F4 RID: 2292 RVA: 0x00040D58 File Offset: 0x0003EF58
		protected UniTask CheckPreDownloadConfig()
		{
			PreDownloadManager.<CheckPreDownloadConfig>d__30 <CheckPreDownloadConfig>d__;
			<CheckPreDownloadConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckPreDownloadConfig>d__.<>4__this = this;
			<CheckPreDownloadConfig>d__.<>1__state = -1;
			<CheckPreDownloadConfig>d__.<>t__builder.Start<PreDownloadManager.<CheckPreDownloadConfig>d__30>(ref <CheckPreDownloadConfig>d__);
			return <CheckPreDownloadConfig>d__.<>t__builder.Task;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00040D9B File Offset: 0x0003EF9B
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

		// Token: 0x060008F6 RID: 2294 RVA: 0x00040DBC File Offset: 0x0003EFBC
		public void RemoveEnabledEvent(Action cb)
		{
			if (cb != null)
			{
				this.EnabledCbSet.Remove(cb);
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00040DCE File Offset: 0x0003EFCE
		public void AddCompleteEvent(Action cb)
		{
			if (cb != null)
			{
				this.CompleteCbSet.Add(cb);
			}
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00040DE0 File Offset: 0x0003EFE0
		public void RemoveCompleteEvent(Action cb)
		{
			if (cb != null)
			{
				this.CompleteCbSet.Remove(cb);
			}
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00040DF2 File Offset: 0x0003EFF2
		private bool HasPreDownloadConfig()
		{
			return this.Config != null;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00040DFD File Offset: 0x0003EFFD
		public bool IsPreDownloadEnabled()
		{
			return this.HasPreDownloadConfig() && this.CheckedRes;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00040E0F File Offset: 0x0003F00F
		public void SetView(IPreDownloadUiEvent ui)
		{
			if (this.UiAgent != null)
			{
				this.UiAgent.SetView(ui);
			}
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00040E25 File Offset: 0x0003F025
		public void ClearView()
		{
			if (this.UiAgent != null)
			{
				this.UiAgent.ClearView();
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00040E3C File Offset: 0x0003F03C
		protected UniTask GetPreDownloadVersionCfg()
		{
			PreDownloadManager.<GetPreDownloadVersionCfg>d__39 <GetPreDownloadVersionCfg>d__;
			<GetPreDownloadVersionCfg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GetPreDownloadVersionCfg>d__.<>4__this = this;
			<GetPreDownloadVersionCfg>d__.<>1__state = -1;
			<GetPreDownloadVersionCfg>d__.<>t__builder.Start<PreDownloadManager.<GetPreDownloadVersionCfg>d__39>(ref <GetPreDownloadVersionCfg>d__);
			return <GetPreDownloadVersionCfg>d__.<>t__builder.Task;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00040E80 File Offset: 0x0003F080
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

		// Token: 0x060008FF RID: 2303 RVA: 0x00040EC4 File Offset: 0x0003F0C4
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

		// Token: 0x06000900 RID: 2304 RVA: 0x00040EFC File Offset: 0x0003F0FC
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

		// Token: 0x06000901 RID: 2305 RVA: 0x000414D8 File Offset: 0x0003F6D8
		protected UniTask CheckResource()
		{
			PreDownloadManager.<CheckResource>d__43 <CheckResource>d__;
			<CheckResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckResource>d__.<>4__this = this;
			<CheckResource>d__.<>1__state = -1;
			<CheckResource>d__.<>t__builder.Start<PreDownloadManager.<CheckResource>d__43>(ref <CheckResource>d__);
			return <CheckResource>d__.<>t__builder.Task;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0004151C File Offset: 0x0003F71C
		protected UniTask DownloadPreResources()
		{
			PreDownloadManager.<DownloadPreResources>d__44 <DownloadPreResources>d__;
			<DownloadPreResources>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DownloadPreResources>d__.<>4__this = this;
			<DownloadPreResources>d__.<>1__state = -1;
			<DownloadPreResources>d__.<>t__builder.Start<PreDownloadManager.<DownloadPreResources>d__44>(ref <DownloadPreResources>d__);
			return <DownloadPreResources>d__.<>t__builder.Task;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0004155F File Offset: 0x0003F75F
		public long GetDownloadSize()
		{
			return this.TotalDownSize;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00041567 File Offset: 0x0003F767
		public long GetNeedSpace()
		{
			return this.NeedSpace;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00041570 File Offset: 0x0003F770
		public void Start(EPreDownloadMode mode)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "start pre download.";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mode", mode);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.DownloadPreResources().Forget();
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x000415B0 File Offset: 0x0003F7B0
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

		// Token: 0x06000907 RID: 2311 RVA: 0x00041614 File Offset: 0x0003F814
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

		// Token: 0x06000908 RID: 2312 RVA: 0x00041679 File Offset: 0x0003F879
		public bool IsDownloading()
		{
			return this.PreDownloadState == EPreDownloadState.Downloading;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00041684 File Offset: 0x0003F884
		public bool IsComplete()
		{
			return this.PreDownloadState == EPreDownloadState.Finished;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0004168F File Offset: 0x0003F88F
		public EPreDownloadState GetState()
		{
			return this.PreDownloadState;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00041697 File Offset: 0x0003F897
		[CompilerGenerated]
		private void <AddTick>g__TickCallback|27_0(float deltaSeconds)
		{
			this.Tick(deltaSeconds).Forget();
		}

		// Token: 0x04000514 RID: 1300
		private const int TICK_INTERVAL_S = 600;

		// Token: 0x04000515 RID: 1301
		[Nullable(2)]
		private static IPreDownload PreDownload;

		// Token: 0x04000516 RID: 1302
		private string Platform = "";

		// Token: 0x04000517 RID: 1303
		private EPreDownloadState PreDownloadState;

		// Token: 0x04000518 RID: 1304
		[Nullable(2)]
		private object PreDownloadRunToken;

		// Token: 0x04000519 RID: 1305
		[Nullable(2)]
		private PreDownloadConfig Config;

		// Token: 0x0400051A RID: 1306
		private readonly HashSet<Action> EnabledCbSet = new HashSet<Action>();

		// Token: 0x0400051B RID: 1307
		private readonly HashSet<Action> CompleteCbSet = new HashSet<Action>();

		// Token: 0x0400051C RID: 1308
		[Nullable(2)]
		private UKuroTickManager TickMgr;

		// Token: 0x0400051D RID: 1309
		[Nullable(2)]
		private Action<float> TickDelegate;

		// Token: 0x0400051E RID: 1310
		private float Interval;

		// Token: 0x0400051F RID: 1311
		[Nullable(2)]
		private PreDownloadUiEvent UiAgent;

		// Token: 0x04000520 RID: 1312
		private bool CheckedRes;

		// Token: 0x04000521 RID: 1313
		[Nullable(2)]
		private DiffUpdate DiffUpdater;

		// Token: 0x04000522 RID: 1314
		[Nullable(2)]
		private RemoteVersionConfig PreTierConfig;

		// Token: 0x04000523 RID: 1315
		private List<RequireFileInfo> RequireFiles = new List<RequireFileInfo>();

		// Token: 0x04000524 RID: 1316
		private long TotalDownSize;

		// Token: 0x04000525 RID: 1317
		private long NeedSpace;
	}
}
