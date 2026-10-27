using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000005 RID: 5
[NullableContext(1)]
[Nullable(0)]
public class ResPackageInfo : IStaticVariableResetter
{
	// Token: 0x06000006 RID: 6 RVA: 0x00002089 File Offset: 0x00000289
	static ResPackageInfo()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ResPackageInfo.CreateStaticDefaultValue), new Action(ResPackageInfo.ResetStaticDefaultValue));
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020A8 File Offset: 0x000002A8
	public static void CreateStaticDefaultValue()
	{
		ResPackageInfo.PathMisc = null;
		ResPackageInfo.Launcher = null;
		ResPackageInfo.Resource = null;
		ResPackageInfo.Languages = new Dictionary<string, ResPackageInfo>();
		ResPackageInfo.OptionalDownLoad = new Dictionary<string, ResPackageInfo>();
		ResPackageInfo.AggregatedManifest = null;
		ResPackageInfo.RoleVoices = new Dictionary<string, ResPackageInfo>();
		ResPackageInfo.TierPacks = new List<ResPackageInfo>();
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000020F5 File Offset: 0x000002F5
	public static void ResetStaticDefaultValue()
	{
		ResPackageInfo.Languages = null;
		ResPackageInfo.PathMisc = null;
		ResPackageInfo.Launcher = null;
		ResPackageInfo.Resource = null;
		ResPackageInfo.OptionalDownLoad = null;
		ResPackageInfo.AggregatedManifest = null;
		ResPackageInfo.RoleVoices = null;
		ResPackageInfo.TierPacks = null;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002128 File Offset: 0x00000328
	public unsafe static void Init(AppPathMisc pathMisc)
	{
		LauncherLog.Instance.Info("init all res versions.", default(ReadOnlySpan<ValueTuple<string, object>>));
		ResPackageInfo.PathMisc = pathMisc;
		string appVersion = UKuroLauncherLibrary.GetAppVersion();
		VersionItem versionItem;
		if (!RemoteInfo.Instance.NewConfig.ResVersions.TryGetValue("launcher", out versionItem))
		{
			throw new Exception("远程版本配置中，没有launcher的信息");
		}
		string resUri = BaseConfigController.Instance.GetResUri();
		ResPackageInfo.Launcher = new ResPackageInfo(resUri, new LauncherVersionInfo(appVersion, versionItem.Version, versionItem.IndexSha1), false);
		VersionItem versionItem2;
		if (!RemoteInfo.Instance.NewConfig.ResVersions.TryGetValue("resource", out versionItem2))
		{
			throw new Exception("远程版本配置中，没有resource的信息");
		}
		ResPackageInfo.Resource = new ResPackageInfo(resUri, new ResourceVersionInfo(appVersion, versionItem2.Version, versionItem2.IndexSha1), false);
		foreach (LaunchLangDefine launchLangDefine in LauncherLanguageLib.Instance.GetAllLanguageDefines())
		{
			if (!ResPackageInfo.Languages.ContainsKey(launchLangDefine.AudioCode))
			{
				VersionItem versionItem3;
				if (!RemoteInfo.Instance.NewConfig.ResVersions.TryGetValue(launchLangDefine.AudioCode, out versionItem3))
				{
					throw new Exception("远程版本配置中，没有多语言" + launchLangDefine.AudioCode + "的信息");
				}
				ResPackageInfo value = new ResPackageInfo(resUri, new LanguageVersionInfo(appVersion, versionItem3.Version, versionItem3.IndexSha1, launchLangDefine.AudioCode), false);
				ResPackageInfo.Languages[launchLangDefine.AudioCode] = value;
			}
		}
		foreach (KeyValuePair<string, VersionItem> keyValuePair in RemoteInfo.Instance.NewConfig.ResVersions)
		{
			if (keyValuePair.Key.StartsWith("Option_"))
			{
				string text = keyValuePair.Key.Replace("Option_", "");
				ResPackageInfo value2 = new ResPackageInfo(resUri, new OptionalDownloadVersionInfo(appVersion, keyValuePair.Value.Version, keyValuePair.Value.IndexSha1, text), false);
				ResPackageInfo.OptionalDownLoad[text] = value2;
			}
		}
		ResPackageInfo.AggregatedManifest = null;
		VersionItem versionItem4;
		if (RemoteInfo.Instance.NewConfig.ResVersions.TryGetValue("ManifestAggregated", out versionItem4))
		{
			ResPackageInfo.AggregatedManifest = new ResPackageInfo(resUri, new AggregatedManifestVersionInfo(appVersion, versionItem4.Version, versionItem4.IndexSha1), false);
		}
		ResPackageInfo.TierPacks.Clear();
		foreach (KeyValuePair<ETier, RemoteVersionConfig> keyValuePair2 in RemoteInfo.Instance.NewTierConfig)
		{
			ETier key = keyValuePair2.Key;
			List<ResPackageInfo> list = ResPackageInfo.BuildTierPacks(keyValuePair2.Value, LauncherDeviceTierLib.TierToLabel(key));
			if (key == RemoteInfo.Instance.ActiveTier)
			{
				foreach (ResPackageInfo item in list)
				{
					ResPackageInfo.TierPacks.Add(item);
				}
				LauncherLog instance = LauncherLog.Instance;
				string message = "已构建分级档位包";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tier", LauncherDeviceTierLib.TierToLabel(key));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("count", list.Count);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000024D0 File Offset: 0x000006D0
	public static List<ResPackageInfo> BuildTierPacks(RemoteVersionConfig tierConfig, string tierLabel)
	{
		List<ResPackageInfo> list = new List<ResPackageInfo>();
		string appVersion = UKuroLauncherLibrary.GetAppVersion();
		string resUri = BaseConfigController.Instance.GetResUri();
		ETier tier = LauncherDeviceTierLib.LabelToTier(tierLabel);
		VersionItem versionItem;
		if (tierConfig.ResVersions.TryGetValue("resource", out versionItem))
		{
			ResPackageInfo resPackageInfo = new ResPackageInfo(resUri, new TierResourceVersionInfo(appVersion, versionItem.Version, versionItem.IndexSha1, tierLabel), false);
			list.Add(resPackageInfo);
			ResPackageInfo resource = ResPackageInfo.Resource;
			if (resource != null)
			{
				resource.SetTierPackageInfo(tier, resPackageInfo);
			}
		}
		HashSet<string> hashSet = new HashSet<string>();
		foreach (LaunchLangDefine launchLangDefine in LauncherLanguageLib.Instance.GetAllLanguageDefines())
		{
			VersionItem versionItem2;
			if (!hashSet.Contains(launchLangDefine.AudioCode) && tierConfig.ResVersions.TryGetValue(launchLangDefine.AudioCode, out versionItem2))
			{
				hashSet.Add(launchLangDefine.AudioCode);
				ResPackageInfo resPackageInfo2 = new ResPackageInfo(resUri, new TierLanguageVersionInfo(appVersion, versionItem2.Version, versionItem2.IndexSha1, launchLangDefine.AudioCode, tierLabel), false);
				list.Add(resPackageInfo2);
				ResPackageInfo resPackageInfo3;
				if (ResPackageInfo.Languages.TryGetValue(launchLangDefine.AudioCode, out resPackageInfo3) && resPackageInfo3 != null)
				{
					resPackageInfo3.SetTierPackageInfo(tier, resPackageInfo2);
				}
			}
		}
		foreach (KeyValuePair<string, VersionItem> keyValuePair in tierConfig.ResVersions)
		{
			string key = keyValuePair.Key;
			VersionItem value = keyValuePair.Value;
			if (key.StartsWith("Option_"))
			{
				string text = key.Replace("Option_", "");
				ResPackageInfo resPackageInfo4 = new ResPackageInfo(resUri, new TierOptionalDownloadVersionInfo(appVersion, value.Version, value.IndexSha1, text, tierLabel), false);
				list.Add(resPackageInfo4);
				ResPackageInfo resPackageInfo5;
				if (ResPackageInfo.OptionalDownLoad.TryGetValue(text, out resPackageInfo5) && resPackageInfo5 != null)
				{
					resPackageInfo5.SetTierPackageInfo(tier, resPackageInfo4);
				}
			}
		}
		return list;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600000B RID: 11 RVA: 0x000026DC File Offset: 0x000008DC
	public static ResPackageInfo LauncherInfo
	{
		get
		{
			return ResPackageInfo.Launcher;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600000C RID: 12 RVA: 0x000026E3 File Offset: 0x000008E3
	public static ResPackageInfo ResourceInfo
	{
		get
		{
			return ResPackageInfo.Resource;
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000026EA File Offset: 0x000008EA
	public static List<ResPackageInfo> GetAllTierInfos()
	{
		return ResPackageInfo.TierPacks;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000026F4 File Offset: 0x000008F4
	public static List<ResPackageInfo> GetAllTierableBaseInfos()
	{
		List<ResPackageInfo> list = new List<ResPackageInfo>();
		list.Add(ResPackageInfo.Resource);
		foreach (ResPackageInfo item in ResPackageInfo.Languages.Values)
		{
			list.Add(item);
		}
		foreach (ResPackageInfo item2 in ResPackageInfo.OptionalDownLoad.Values)
		{
			list.Add(item2);
		}
		return list;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000027A4 File Offset: 0x000009A4
	public static List<ResPackageInfo> EnumerateWithTierChild(IReadOnlyList<ResPackageInfo> packs, ETier tier)
	{
		List<ResPackageInfo> list = new List<ResPackageInfo>();
		HashSet<ResPackageInfo> hashSet = new HashSet<ResPackageInfo>();
		foreach (ResPackageInfo resPackageInfo in packs)
		{
			if (!hashSet.Contains(resPackageInfo))
			{
				hashSet.Add(resPackageInfo);
				list.Add(resPackageInfo);
			}
			ResPackageInfo tierPackageInfo = resPackageInfo.GetTierPackageInfo(tier);
			if (tierPackageInfo != null && !hashSet.Contains(tierPackageInfo))
			{
				hashSet.Add(tierPackageInfo);
				list.Add(tierPackageInfo);
			}
		}
		return list;
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000010 RID: 16 RVA: 0x00002834 File Offset: 0x00000A34
	public static Dictionary<string, ResPackageInfo> OptionalDownLoadInfo
	{
		get
		{
			return ResPackageInfo.OptionalDownLoad;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000011 RID: 17 RVA: 0x0000283B File Offset: 0x00000A3B
	[Nullable(2)]
	public static ResPackageInfo AggregatedManifestInfo
	{
		[NullableContext(2)]
		get
		{
			return ResPackageInfo.AggregatedManifest;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000012 RID: 18 RVA: 0x00002842 File Offset: 0x00000A42
	public static Dictionary<string, ResPackageInfo> RoleVoiceInfos
	{
		get
		{
			return ResPackageInfo.RoleVoices;
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002849 File Offset: 0x00000A49
	public static List<ResPackageInfo> GetAllRoleVoiceInfos()
	{
		return new List<ResPackageInfo>(ResPackageInfo.RoleVoices.Values);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000285C File Offset: 0x00000A5C
	[return: Nullable(2)]
	public static ResPackageInfo GetRoleVoiceInfo(string packKey)
	{
		ResPackageInfo result;
		ResPackageInfo.RoleVoices.TryGetValue(packKey, out result);
		return result;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002878 File Offset: 0x00000A78
	public static void BuildAggregatedItems(string combinedText, [Nullable(2)] string revertCombinedText = null)
	{
		if (ResPackageInfo.AggregatedManifest == null)
		{
			return;
		}
		Dictionary<string, PatchManifestJson> entries = LauncherJson.Parse<Dictionary<string, PatchManifestJson>>(combinedText, null);
		Dictionary<string, PatchManifestJson> revertEntries = (revertCombinedText != null) ? LauncherJson.Parse<Dictionary<string, PatchManifestJson>>(revertCombinedText, null) : null;
		ResPackageInfo.BuildRoleVoiceItems(entries, revertEntries);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000028A8 File Offset: 0x00000AA8
	private static void BuildRoleVoiceItems(Dictionary<string, PatchManifestJson> entries, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, PatchManifestJson> revertEntries = null)
	{
		ResPackageInfo.RoleVoices.Clear();
		string appVersion = UKuroLauncherLibrary.GetAppVersion();
		string resUri = BaseConfigController.Instance.GetResUri();
		string latestVersion = ResPackageInfo.AggregatedManifest.ResourceVersionInfo.LatestVersion;
		string manifestHash = ResPackageInfo.AggregatedManifest.ResourceVersionInfo.ManifestHash;
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		if (!string.IsNullOrEmpty(manifestHash))
		{
			dictionary[latestVersion] = manifestHash;
		}
		foreach (string text in entries.Keys)
		{
			if (text.StartsWith("role_lang_"))
			{
				ResPackageInfo resPackageInfo = new ResPackageInfo(resUri, new RoleVoiceItemVersionInfo(appVersion, latestVersion, dictionary, text), false);
				PatchManifestJson patchManifestJson = null;
				if (revertEntries != null && !revertEntries.TryGetValue(text, out patchManifestJson))
				{
					patchManifestJson = new PatchManifestJson();
					patchManifestJson.DiffPatch = new PatchManifest();
				}
				resPackageInfo.SetManifest(entries[text], patchManifestJson);
				resPackageInfo.CollectAllFiles();
				ResPackageInfo.RoleVoices[text] = resPackageInfo;
			}
		}
		LauncherLog instance = LauncherLog.Instance;
		string message = "BuildRoleVoiceItems done.";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("count", ResPackageInfo.RoleVoices.Count);
		instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000029E8 File Offset: 0x00000BE8
	public void SetPathMisc(AppPathMisc pathMisc)
	{
		if (ResPackageInfo.PathMisc == null)
		{
			ResPackageInfo.PathMisc = pathMisc;
		}
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000029F8 File Offset: 0x00000BF8
	public static ResPackageInfo GetLanguageInfo(string lang)
	{
		ResPackageInfo result;
		ResPackageInfo.Languages.TryGetValue(lang, out result);
		return result;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002A14 File Offset: 0x00000C14
	public static List<ResPackageInfo> GetLanguageInfos(string[] langArr)
	{
		List<ResPackageInfo> list = new List<ResPackageInfo>();
		foreach (string key in langArr)
		{
			ResPackageInfo item;
			if (ResPackageInfo.Languages.TryGetValue(key, out item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002A54 File Offset: 0x00000C54
	public static List<ResPackageInfo> GetAllLanguageInfos()
	{
		List<ResPackageInfo> list = new List<ResPackageInfo>();
		foreach (ResPackageInfo item in ResPackageInfo.Languages.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002AB4 File Offset: 0x00000CB4
	public static List<ResPackageInfo> GetAllOptionalDownLoadInfo()
	{
		List<ResPackageInfo> list = new List<ResPackageInfo>();
		foreach (ResPackageInfo item in ResPackageInfo.OptionalDownLoad.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002B14 File Offset: 0x00000D14
	public static string GetResSaveDir()
	{
		return ResPackageInfo.PathMisc.GetPatchSaveDir();
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002B20 File Offset: 0x00000D20
	[NullableContext(0)]
	public static ValueTuple<long, long> GetTotalAndFreeSpace([Nullable(1)] string dirPath)
	{
		return ResPackageInfo.PathMisc.GetTotalAndFreeSpace(dirPath);
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002B30 File Offset: 0x00000D30
	public ResPackageInfo(string ResUri, ResVersionInfo VersionInfo, bool IsPreDownload = false)
	{
		this.VersionInfo = VersionInfo;
		this.ResUri = ResUri;
		this.IsPreDownload = IsPreDownload;
		this.VersionInfo.Init();
		this.LatestVersion = this.VersionInfo.LatestVersion;
		this.HotFixOrRepair = (this.LatestVersion != this.VersionInfo.RecordVersion);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002BFE File Offset: 0x00000DFE
	public bool NeedProcessUpdate(bool bForceUpdate)
	{
		if (bForceUpdate)
		{
			return this.VersionInfo.HasContentOnRemote();
		}
		return this.VersionInfo.HasContentOnRemote() && !this.VersionInfo.SkipUpdate();
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002C2C File Offset: 0x00000E2C
	public bool MustRevertVersion()
	{
		return this.VersionInfo.NeedRevertVersion;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002C39 File Offset: 0x00000E39
	public bool NeedRebootModuleOrApp()
	{
		return this.NeedReboot;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002C41 File Offset: 0x00000E41
	public void SetBasePatchOperate(PatchParams patchOp)
	{
		this.PatchOpParams.Add(patchOp);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002C4F File Offset: 0x00000E4F
	public bool IsHotFixOrNot()
	{
		return this.HotFixOrRepair;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002C58 File Offset: 0x00000E58
	public string GetRemoteManifestRoute()
	{
		if (this.LatestVersion != this.VersionInfo.LatestVersion)
		{
			this.ResetCache();
		}
		if (!string.IsNullOrWhiteSpace(this.ManifestRoute))
		{
			return this.ManifestRoute;
		}
		this.ManifestRoute = ResPackageInfo.PathMisc.GetManifestRoute(this.ResUri, this.VersionInfo.LatestVersion, this.VersionInfo.GetManifestFileName());
		return this.ManifestRoute;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002CC9 File Offset: 0x00000EC9
	public void SetRemoteManifestRoute(string route)
	{
		this.ManifestRoute = route;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002CD2 File Offset: 0x00000ED2
	public string GetRemoteRevertManifestRoute()
	{
		return ResPackageInfo.PathMisc.GetManifestRoute(this.ResUri, this.VersionInfo.RecordVersion, this.VersionInfo.GetManifestFileName());
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002CFC File Offset: 0x00000EFC
	public string GetManifestSavePath()
	{
		if (this.LatestVersion != this.VersionInfo.LatestVersion)
		{
			this.ResetCache();
		}
		if (!string.IsNullOrWhiteSpace(this.ManifestSavePath))
		{
			return this.ManifestSavePath;
		}
		this.ManifestSavePath = ResPackageInfo.PathMisc.GetManifestPath(this.VersionInfo.GetPackageVersion(), this.VersionInfo.LatestVersion, this.VersionInfo.GetManifestFileName());
		return this.ManifestSavePath;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002D72 File Offset: 0x00000F72
	public void SetManifestSavePath(string manifestPath)
	{
		this.ManifestSavePath = manifestPath;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002D7B File Offset: 0x00000F7B
	public string GetRevertManifestPath()
	{
		return ResPackageInfo.PathMisc.GetManifestPath(this.VersionInfo.GetPackageVersion(), this.VersionInfo.RecordVersion, this.VersionInfo.GetManifestFileName());
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002DA8 File Offset: 0x00000FA8
	public string GetManifestHash()
	{
		return this.VersionInfo.ManifestHash;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002DB5 File Offset: 0x00000FB5
	public string GetRevertManifestHash()
	{
		return this.VersionInfo.RevertManifestHash;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002DC2 File Offset: 0x00000FC2
	public bool IsAggregatedManifest()
	{
		return this.VersionInfo is AggregatedManifestVersionInfo;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002DD2 File Offset: 0x00000FD2
	public void SetManifest(PatchManifestJson patchManifest, PatchManifestJson revertManifest)
	{
		this.Manifest = patchManifest;
		this.RevertManifest = revertManifest;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002DE2 File Offset: 0x00000FE2
	public void SetTierPackageInfo(ETier tier, ResPackageInfo info)
	{
		this.TierPackageInfos[tier] = info;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002DF4 File Offset: 0x00000FF4
	[NullableContext(2)]
	public ResPackageInfo GetTierPackageInfo(ETier tier)
	{
		if (tier == ETier.None)
		{
			return null;
		}
		ResPackageInfo result;
		this.TierPackageInfos.TryGetValue(tier, out result);
		return result;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002E16 File Offset: 0x00001016
	public bool HasTierPackageInfo(ETier tier)
	{
		return tier != ETier.None && this.TierPackageInfos.ContainsKey(tier);
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002E29 File Offset: 0x00001029
	public List<ResPackageInfo> GetAllTierPackageInfos()
	{
		return new List<ResPackageInfo>(this.TierPackageInfos.Values);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002E3C File Offset: 0x0000103C
	public void EnumerateExpectedTargetFiles(Action<string, string, long, string> visitor)
	{
		if (this.Manifest == null || this.Manifest.DiffPatch == null)
		{
			return;
		}
		string packageVersion = this.VersionInfo.GetPackageVersion();
		string resType = this.VersionInfo.GetResType();
		string latestVersion = this.VersionInfo.LatestVersion;
		List<ResFileInfo> baseFiles = this.Manifest.DiffPatch.BaseFiles;
		if (baseFiles != null)
		{
			foreach (ResFileInfo resFileInfo in baseFiles)
			{
				if (!string.IsNullOrWhiteSpace(resFileInfo.Hash))
				{
					visitor(resFileInfo.Name, resFileInfo.Hash, resFileInfo.Size, ResPackageInfo.PathMisc.GetResFilePath(packageVersion, "Base", resType, resFileInfo.Name));
				}
			}
		}
		List<ResFileInfo> patchFiles = this.Manifest.DiffPatch.PatchFiles;
		if (patchFiles != null)
		{
			foreach (ResFileInfo resFileInfo2 in patchFiles)
			{
				if (!string.IsNullOrWhiteSpace(resFileInfo2.Hash))
				{
					visitor(resFileInfo2.Name, resFileInfo2.Hash, resFileInfo2.Size, ResPackageInfo.PathMisc.GetResFilePath(packageVersion, latestVersion, resType, resFileInfo2.Name));
				}
			}
		}
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002FA0 File Offset: 0x000011A0
	public unsafe virtual void UpdateRecord()
	{
		LauncherLog instance = LauncherLog.Instance;
		string message = "update manifest and record.";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
		instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (this.VersionInfo.NeedRecordMount())
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string text = "::Mount::\n";
			List<ValueTuple<string, string>> list = new List<ValueTuple<string, string>>();
			foreach (string text2 in this.LatestPakPairs.Keys)
			{
				int num = text2.LastIndexOf('/');
				string item = (num >= 0) ? text2.Substring(num) : text2;
				if (num < 0)
				{
					LauncherLog instance2 = LauncherLog.Instance;
					string message2 = "SaveManifest: key has no '/', fallback to full key.";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", text2);
					instance2.Warn(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					list.Add(new ValueTuple<string, string>(item, text2));
				}
			}
			list.Sort(delegate([Nullable(new byte[]
			{
				0,
				1,
				1
			})] ValueTuple<string, string> a, [Nullable(new byte[]
			{
				0,
				1,
				1
			})] ValueTuple<string, string> b)
			{
				if (a.Item1.CompareTo(b.Item1) < 0)
				{
					return -1;
				}
				if (a.Item1.CompareTo(b.Item1) > 0)
				{
					return 1;
				}
				return 0;
			});
			foreach (ValueTuple<string, string> valueTuple2 in list)
			{
				string item2 = valueTuple2.Item2;
				PakFilePair pakFilePair;
				if (this.LatestPakPairs.TryGetValue(item2, out pakFilePair))
				{
					string str = text;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 4);
					defaultInterpolatedStringHandler.AppendFormatted(item2);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int>(pakFilePair.MountOrder);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted(pakFilePair.Pak.GetHash());
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted((pakFilePair.Sig != null) ? pakFilePair.Sig.GetHash() : "");
					defaultInterpolatedStringHandler.AppendLiteral(",,\n");
					text = str + defaultInterpolatedStringHandler.ToStringAndClear();
					if (pakFilePair.Pak.IsRestartRequiredAfterHotPatchChunk)
					{
						dictionary[item2] = pakFilePair.Pak.GetHash() + "," + ((pakFilePair.Sig != null) ? pakFilePair.Sig.GetHash() : "") + ",,";
					}
				}
			}
			text += "::Del::\n";
			foreach (PakFilePair pakFilePair2 in this.OldPakPairs.Values)
			{
				if (pakFilePair2.Pak != null)
				{
					text = text + pakFilePair2.Pak.FilePath + "\n";
				}
				if (pakFilePair2.Sig != null)
				{
					text = text + pakFilePair2.Sig.FilePath + "\n";
				}
			}
			string mountManifestPath = ResPackageInfo.PathMisc.GetMountManifestPath(this.VersionInfo.GetPackageVersion(), this.VersionInfo.GetMountFileName());
			if (dictionary.Count > 0)
			{
				if (!UBlueprintPathsLibrary.FileExists(mountManifestPath))
				{
					this.NeedReboot = true;
					LauncherLog instance3 = LauncherLog.Instance;
					string message3 = "need reboot because mount manifest is not exist.";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
					instance3.Info(message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				else
				{
					Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
					TArray<string> tarray = UKuroStaticLibrary.LoadFileToStringArray(mountManifestPath);
					int num2 = tarray.Num();
					for (int i = 0; i < num2; i++)
					{
						string text3 = tarray.Get(i);
						string[] array = text3.Split(',', StringSplitOptions.None);
						dictionary2[array[0].Trim()] = text3;
					}
					foreach (KeyValuePair<string, string> keyValuePair in dictionary)
					{
						string key = keyValuePair.Key;
						string value = keyValuePair.Value;
						string text4;
						if (!dictionary2.TryGetValue(key, out text4) || text4 == null || !text4.Contains(value))
						{
							this.NeedReboot = true;
							LauncherLog instance4 = LauncherLog.Instance;
							string message4 = "need reboot because mount manifest need update.";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
							instance4.Info(message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
							break;
						}
					}
				}
			}
			UKuroStaticLibrary.SaveStringToFile(text, mountManifestPath, false);
		}
		this.VersionInfo.UpdateVersionRecord();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 3);
		defaultInterpolatedStringHandler.AppendFormatted(UKuroLauncherLibrary.GameSavedDir());
		defaultInterpolatedStringHandler.AppendLiteral("Resources/");
		defaultInterpolatedStringHandler.AppendFormatted(this.VersionInfo.GetPackageVersion());
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted(this.VersionInfo.GetResType());
		defaultInterpolatedStringHandler.AppendLiteral("/");
		string text5 = defaultInterpolatedStringHandler.ToStringAndClear();
		TArray<string> directories = UKuroStaticLibrary.GetDirectories(text5);
		int num3 = directories.Num();
		for (int j = 0; j < num3; j++)
		{
			string text6 = directories.Get(j);
			if (!string.Equals(text6, "Base", StringComparison.OrdinalIgnoreCase) && !(text6 == this.VersionInfo.LatestVersion))
			{
				UKuroLauncherLibrary.DeleteDirectory(text5 + text6);
				this.HadDeletion = true;
			}
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 3);
		defaultInterpolatedStringHandler.AppendFormatted(UKuroLauncherLibrary.GameSavedDir());
		defaultInterpolatedStringHandler.AppendLiteral("Resources/");
		defaultInterpolatedStringHandler.AppendFormatted(this.VersionInfo.GetPackageVersion());
		defaultInterpolatedStringHandler.AppendLiteral("/Diff/");
		defaultInterpolatedStringHandler.AppendFormatted(this.VersionInfo.GetResType());
		string text7 = defaultInterpolatedStringHandler.ToStringAndClear();
		if (UBlueprintPathsLibrary.DirectoryExists(text7))
		{
			UKuroLauncherLibrary.DeleteDirectory(text7);
			this.HadDeletion = true;
		}
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00003620 File Offset: 0x00001820
	public bool SkipLangUpdateButMountFileModify()
	{
		if (this.VersionInfo.SkipUpdate())
		{
			string mountManifestPath = ResPackageInfo.PathMisc.GetMountManifestPath(this.VersionInfo.GetPackageVersion(), this.VersionInfo.GetMountFileName());
			if (UBlueprintPathsLibrary.FileExists(mountManifestPath))
			{
				UKuroLauncherLibrary.DeleteFile(mountManifestPath);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x0000366D File Offset: 0x0000186D
	public void ClearRecord()
	{
		this.VersionInfo.ClearVersionRecord();
	}

	// Token: 0x06000036 RID: 54 RVA: 0x0000367C File Offset: 0x0000187C
	public virtual void CollectAllFiles()
	{
		this.LatestPakPairs.Clear();
		this.CollectAllFilesByVersion(ResPackageInfo.PathMisc.GetResFileDir(this.VersionInfo.GetPackageVersion(), "Base", this.VersionInfo.GetResType()), "Base", this.VersionInfo.GetPackageVersion(), this.Manifest.DiffPatch.BaseFiles);
		this.CollectAllFilesByVersion(ResPackageInfo.PathMisc.GetResFileDir(this.VersionInfo.GetPackageVersion(), this.VersionInfo.LatestVersion, this.VersionInfo.GetResType()), this.VersionInfo.LatestVersion, this.VersionInfo.LatestVersion, this.Manifest.DiffPatch.PatchFiles);
		int num = 0;
		string a = KuroApplication.IniPlatformNameIncludeEditor();
		foreach (KeyValuePair<string, PakFilePair> keyValuePair in this.LatestPakPairs)
		{
			string key = keyValuePair.Key;
			PakFilePair value = keyValuePair.Value;
			if (value.Pak == null)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "manifest miss pak file info.";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("file", key);
				instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				num++;
			}
			if (!(a == "PS4") && !(a == "PS5") && !(a == "XSX") && value.Sig == null)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "manifest miss sig file info.";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("file", key);
				instance2.Error(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				num++;
			}
		}
		if (num > 0)
		{
			throw new Exception("manifest miss file info. count:" + num.ToString());
		}
	}

	// Token: 0x06000037 RID: 55 RVA: 0x0000383C File Offset: 0x00001A3C
	[return: TupleElementNames(new string[]
	{
		"requireFiles",
		"localSavedSize",
		"totalDownloadSize",
		"totalNeedSpace",
		"totalDownloadAndPatch",
		"allResSize",
		"allFileExpectSize",
		"allFileSavedSize",
		"allFileCount",
		null,
		null
	})]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		0
	})]
	public unsafe virtual ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> AnalyzeRequireFiles(bool bForceDownload = false, ETier tier = ETier.None)
	{
		ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> valueTuple = this.AnalyzeSelfRequireFiles(bForceDownload);
		ResPackageInfo tierPackageInfo = this.GetTierPackageInfo(tier);
		if (tierPackageInfo == null)
		{
			if (tier != ETier.None)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "AnalyzeRequireFiles 无对应档位子包, 按 base 分析.";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tier", LauncherDeviceTierLib.TierToLabel(tier));
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return valueTuple;
		}
		ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> b = tierPackageInfo.AnalyzeSelfRequireFiles(bForceDownload);
		ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> result = ResPackageInfo.MergeAnalyzeResult(valueTuple, b);
		this.SpaceModel.DownloadSize += tierPackageInfo.SpaceModel.DownloadSize;
		this.SpaceModel.SavedSize += tierPackageInfo.SpaceModel.SavedSize;
		this.SpaceModel.PatchPeak += tierPackageInfo.SpaceModel.PatchPeak;
		this.SpaceModel.PatchNetDelta += tierPackageInfo.SpaceModel.PatchNetDelta;
		this.SpaceModel.CopySize += tierPackageInfo.SpaceModel.CopySize;
		return result;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00003960 File Offset: 0x00001B60
	[return: TupleElementNames(new string[]
	{
		"requireFiles",
		"localSavedSize",
		"totalDownloadSize",
		"totalNeedSpace",
		"totalDownloadAndPatch",
		"allResSize",
		"allFileExpectSize",
		"allFileSavedSize",
		"allFileCount",
		null,
		null
	})]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		0
	})]
	private static ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> MergeAnalyzeResult([TupleElementNames(new string[]
	{
		"requireFiles",
		"localSavedSize",
		"totalDownloadSize",
		"totalNeedSpace",
		"totalDownloadAndPatch",
		"allResSize",
		"allFileExpectSize",
		"allFileSavedSize",
		"allFileCount",
		null,
		null
	})] [Nullable(new byte[]
	{
		0,
		1,
		1,
		0
	})] ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> a, [TupleElementNames(new string[]
	{
		"requireFiles",
		"localSavedSize",
		"totalDownloadSize",
		"totalNeedSpace",
		"totalDownloadAndPatch",
		"allResSize",
		"allFileExpectSize",
		"allFileSavedSize",
		"allFileCount",
		null,
		null
	})] [Nullable(new byte[]
	{
		0,
		1,
		1,
		0
	})] ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> b)
	{
		List<RequireFileInfo> list = new List<RequireFileInfo>();
		list.AddRange(a.Item1);
		list.AddRange(b.Item1);
		return new ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>>(list, a.Item2 + b.Item2, a.Item3 + b.Item3, a.Item4 + b.Item4, a.Item5 + b.Item5, a.Item6 + b.Item6, a.Item7 + b.Item7, new ValueTuple<long, int>(a.Rest.Item1 + b.Rest.Item1, a.Rest.Item2 + b.Rest.Item2));
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003A10 File Offset: 0x00001C10
	[return: TupleElementNames(new string[]
	{
		"requireFiles",
		"localSavedSize",
		"totalDownloadSize",
		"totalNeedSpace",
		"totalDownloadAndPatch",
		"allResSize",
		"allFileExpectSize",
		"allFileSavedSize",
		"allFileCount",
		null,
		null
	})]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		0
	})]
	protected unsafe ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> AnalyzeSelfRequireFiles(bool bForceDownload = false)
	{
		if (this.IsAggregatedManifest())
		{
			this.SpaceModel.Reset();
			return new ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>>(new List<RequireFileInfo>(), 0L, 0L, 0L, 0L, 0L, 0L, new ValueTuple<long, int>(0L, 0));
		}
		if (this.Manifest == null || this.Manifest.DiffPatch == null)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "AnalyzeRequireFiles skipped: Manifest not loaded yet.";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
			instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.SpaceModel.Reset();
			return new ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>>(new List<RequireFileInfo>(), 0L, 0L, 0L, 0L, 0L, 0L, new ValueTuple<long, int>(0L, 0));
		}
		LauncherLog instance2 = LauncherLog.Instance;
		string message2 = "analyze res files.";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("forceDownload", bForceDownload);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
		instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.DownloadList.Clear();
		this.PatchOpParams.Clear();
		this.PreAnalyzeClear();
		this.AnalyzePatch(this.Manifest.DiffPatch.BaseDiffMap, this.VersionInfo.RecordPackageVersion, this.VersionInfo.GetPackageVersion(), true, bForceDownload, false);
		this.AnalyzePatch(this.MustRevertVersion() ? this.RevertManifest.DiffPatch.RevertMap : this.Manifest.DiffPatch.CurDiffMap, this.VersionInfo.RecordVersion, this.VersionInfo.LatestVersion, false, bForceDownload, this.MustRevertVersion());
		this.PostAnalyzeClear();
		ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> valueTuple2 = this.AnalyzeSpaceInfo();
		List<RequireFileInfo> item = valueTuple2.Item1;
		long item2 = valueTuple2.Item2;
		long item3 = valueTuple2.Item3;
		long item4 = valueTuple2.Item4;
		long item5 = valueTuple2.Item5;
		long item6 = valueTuple2.Item6;
		long item7 = valueTuple2.Item7;
		long item8 = valueTuple2.Rest.Item1;
		int item9 = valueTuple2.Rest.Item2;
		return new ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>>(item, item2, item3, item4, item5, item6, item7, new ValueTuple<long, int>(item8, item9));
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00003C23 File Offset: 0x00001E23
	public virtual bool NeedPatch()
	{
		return this.PatchOpParams.Count > 0;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00003C34 File Offset: 0x00001E34
	public long PatchTotalSize()
	{
		long num = 0L;
		foreach (PatchParams patchParams in this.PatchOpParams)
		{
			num += patchParams.NewRefSize;
		}
		return num;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00003C90 File Offset: 0x00001E90
	[return: Nullable(new byte[]
	{
		0,
		0,
		1,
		1
	})]
	public UniTask<ValueTuple<bool, EKuroPatchResult, List<LocalFileInfo>>> ExecutePatch(Action<long> cb)
	{
		ResPackageInfo.<ExecutePatch>d__86 <ExecutePatch>d__;
		<ExecutePatch>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<bool, EKuroPatchResult, List<LocalFileInfo>>>.Create();
		<ExecutePatch>d__.<>4__this = this;
		<ExecutePatch>d__.cb = cb;
		<ExecutePatch>d__.<>1__state = -1;
		<ExecutePatch>d__.<>t__builder.Start<ResPackageInfo.<ExecutePatch>d__86>(ref <ExecutePatch>d__);
		return <ExecutePatch>d__.<>t__builder.Task;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00003CDC File Offset: 0x00001EDC
	public bool MoveFiles()
	{
		LauncherLog instance = LauncherLog.Instance;
		string message = "move file after patch.";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
		instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		foreach (MoveParams moveParams in this.MoveOpParams)
		{
			if (UBlueprintPathsLibrary.FileExists(moveParams.OldFile.FilePath))
			{
				if (!moveParams.OldFile.IsRestartRequiredAfterHotPatchChunk)
				{
					if (moveParams.OldFile.FilePath.EndsWith(EResFile.PAK.ToEnumString()))
					{
						UKuroPakMountStatic.UnmountPak(moveParams.OldFile.FilePath);
					}
					if (!UKuroLauncherLibrary.MoveFile(moveParams.NewFile.FilePath, moveParams.OldFile.FilePath))
					{
						return false;
					}
				}
				else if (!UKuroLauncherLibrary.CopyFile(moveParams.NewFile.FilePath, moveParams.OldFile.FilePath))
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00003DE8 File Offset: 0x00001FE8
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		0,
		1,
		1
	})]
	public virtual ValueTuple<List<string>, List<ValueTuple<string, string, int>>> GetMountInfos()
	{
		List<string> list = new List<string>();
		List<ValueTuple<string, string, int>> list2 = new List<ValueTuple<string, string, int>>();
		foreach (PakFilePair pakFilePair in this.OldPakPairs.Values)
		{
			if (pakFilePair.Pak != null)
			{
				list.Add(pakFilePair.Pak.FilePath);
			}
		}
		foreach (PakFilePair pakFilePair2 in this.LatestPakPairs.Values)
		{
			if (pakFilePair2.Pak != null)
			{
				ValueTuple<string, string, int> item = new ValueTuple<string, string, int>(pakFilePair2.Pak.FilePath, pakFilePair2.Pak.GetHash(), pakFilePair2.MountOrder);
				list2.Add(item);
			}
		}
		return new ValueTuple<List<string>, List<ValueTuple<string, string, int>>>(list, list2);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00003EE0 File Offset: 0x000020E0
	public unsafe void DeleteLocalFiles()
	{
		LauncherLog instance = LauncherLog.Instance;
		string message = "delete lang res.";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
		instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		string mountManifestPath = ResPackageInfo.PathMisc.GetMountManifestPath(this.VersionInfo.GetPackageVersion(), this.VersionInfo.GetMountFileName());
		if (UBlueprintPathsLibrary.FileExists(mountManifestPath))
		{
			UKuroLauncherLibrary.DeleteFile(mountManifestPath);
		}
		foreach (PakFilePair pakFilePair in this.LatestPakPairs.Values)
		{
			if (pakFilePair.Pak != null)
			{
				UKuroPakMountStatic.UnmountPak(pakFilePair.Pak.FilePath);
				pakFilePair.Pak.DeleteAll();
			}
			if (pakFilePair.Sig != null)
			{
				pakFilePair.Sig.DeleteAll();
			}
		}
		this.ClearRecord();
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00004000 File Offset: 0x00002200
	public static string GetPlatformName()
	{
		return ResPackageInfo.PathMisc.GetPlatform();
	}

	// Token: 0x06000041 RID: 65 RVA: 0x0000400C File Offset: 0x0000220C
	public unsafe List<string> DeleteTierLocalFiles()
	{
		string resType = this.VersionInfo.GetResType();
		string mountFileName = this.VersionInfo.GetMountFileName();
		HashSet<string> hashSet = new HashSet<string>
		{
			this.VersionInfo.GetPackageVersion()
		};
		string deviceSaved = LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PreDownloadConfig, "");
		if (!string.IsNullOrEmpty(deviceSaved))
		{
			hashSet.Add(deviceSaved);
		}
		List<string> list = new List<string>();
		foreach (string text in hashSet)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 3);
			defaultInterpolatedStringHandler.AppendFormatted(UKuroLauncherLibrary.GameSavedDir());
			defaultInterpolatedStringHandler.AppendLiteral("Resources/");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(resType);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendFormatted(UKuroLauncherLibrary.GameSavedDir());
			defaultInterpolatedStringHandler.AppendLiteral("Resources/");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("/Diff/");
			defaultInterpolatedStringHandler.AppendFormatted(resType);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			string text3 = defaultInterpolatedStringHandler.ToStringAndClear();
			LauncherLog instance = LauncherLog.Instance;
			string message = "删除档位包本地资源";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("res", resType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dir", text2);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			TArray<string> filesRecursive = UKuroStaticLibrary.GetFilesRecursive(text2, "*.pak", true, false);
			int num = filesRecursive.Num();
			for (int i = 0; i < num; i++)
			{
				string text4 = filesRecursive.Get(i);
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "开始删旧档位文件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("file", text4);
				instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				UKuroPakMountStatic.UnmountPak(text4);
				UKuroLauncherLibrary.DeleteFile(text4);
			}
			UKuroLauncherLibrary.DeleteDirectory(text2);
			UKuroLauncherLibrary.DeleteDirectory(text3);
			if (mountFileName.Length > 0)
			{
				string mountManifestPath = ResPackageInfo.PathMisc.GetMountManifestPath(text, mountFileName);
				if (UBlueprintPathsLibrary.FileExists(mountManifestPath))
				{
					UKuroLauncherLibrary.DeleteFile(mountManifestPath);
				}
			}
			list.Add(text2);
			list.Add(text3);
		}
		return list;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00004270 File Offset: 0x00002470
	[NullableContext(0)]
	public unsafe virtual ValueTuple<long, long> CalculateSavedSizeAndTotalSize()
	{
		LauncherLog instance = LauncherLog.Instance;
		string message = "calculate all size of lang res.";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
		instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (this.LatestPakPairs.Count <= 0)
		{
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "first time to calculate all size of lang res.";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
			instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.Manifest == null)
			{
				string manifestSavePath = this.GetManifestSavePath();
				string inCipher = null;
				if (!UKuroStaticLibrary.LoadFileToString(ref inCipher, manifestSavePath))
				{
					LauncherLog instance3 = LauncherLog.Instance;
					string message3 = "清单文件不存在";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("file", manifestSavePath);
					instance3.Warn(message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return new ValueTuple<long, long>(0L, 1L);
				}
				string text = null;
				if (!UKuroLauncherLibrary.Decrypt(inCipher, ref text))
				{
					LauncherLog instance4 = LauncherLog.Instance;
					string message4 = "清单文件内容无法解析";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("file", manifestSavePath);
					instance4.Warn(message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					return new ValueTuple<long, long>(0L, 1L);
				}
				string text2 = text.Trim();
				if (string.IsNullOrWhiteSpace(text2))
				{
					LauncherLog instance5 = LauncherLog.Instance;
					string message5 = "清单文件内容为空";
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("file", manifestSavePath);
					instance5.Warn(message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					return new ValueTuple<long, long>(0L, 1L);
				}
				this.Manifest = LauncherJson.Parse<PatchManifestJson>(text2, null);
			}
			this.CollectAllFiles();
		}
		long num = 0L;
		long num2 = 0L;
		foreach (PakFilePair pakFilePair in this.LatestPakPairs.Values)
		{
			if (pakFilePair.Pak != null)
			{
				num2 += pakFilePair.Pak.ExpectSize;
				num += pakFilePair.Pak.GetLocalSize();
			}
			if (pakFilePair.Sig != null)
			{
				num2 += pakFilePair.Sig.ExpectSize;
				num += pakFilePair.Sig.GetLocalSize();
			}
		}
		return new ValueTuple<long, long>(num, num2);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x000044A0 File Offset: 0x000026A0
	public virtual bool IsCompleteUpdate()
	{
		return this.VersionInfo.LatestVersion == this.VersionInfo.RecordVersion;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x000044C0 File Offset: 0x000026C0
	public virtual bool IsCompleteDownload()
	{
		if (!this.IsCompleteUpdate())
		{
			return false;
		}
		ValueTuple<long, long> valueTuple = this.CalculateSavedSizeAndTotalSize();
		long item = valueTuple.Item1;
		long item2 = valueTuple.Item2;
		return item >= item2;
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000045 RID: 69 RVA: 0x000044F1 File Offset: 0x000026F1
	public ResVersionInfo ResourceVersionInfo
	{
		get
		{
			return this.VersionInfo;
		}
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000044FC File Offset: 0x000026FC
	private void PreAnalyzeClear()
	{
		if (!this.IsPreDownload)
		{
			if (this.HasPreAnalyzeClear)
			{
				return;
			}
			if (this.VersionInfo.GetResType() == EResType.Launcher.ToEnumString())
			{
				return;
			}
			if (string.IsNullOrWhiteSpace(this.VersionInfo.RecordVersion))
			{
				return;
			}
			LauncherFileLib.ClearOldPackageResDir(this.VersionInfo.RecordPackageVersion);
			if (LauncherFileLib.HadDeletion)
			{
				this.HadDeletion = true;
			}
			HashSet<string> hashSet = new HashSet<string>();
			hashSet.Add("Base");
			hashSet.Add(this.VersionInfo.RecordVersion);
			hashSet.Add(this.VersionInfo.LatestVersion);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 3);
			defaultInterpolatedStringHandler.AppendFormatted(UKuroLauncherLibrary.GameSavedDir());
			defaultInterpolatedStringHandler.AppendLiteral("Resources/");
			defaultInterpolatedStringHandler.AppendFormatted(this.VersionInfo.GetPackageVersion());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(this.VersionInfo.GetResType());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			LauncherFileLib.ClearResDirs(defaultInterpolatedStringHandler.ToStringAndClear(), hashSet);
			if (LauncherFileLib.HadDeletion)
			{
				this.HadDeletion = true;
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendFormatted(UKuroLauncherLibrary.GameSavedDir());
			defaultInterpolatedStringHandler.AppendLiteral("Resources/");
			defaultInterpolatedStringHandler.AppendFormatted(this.VersionInfo.GetPackageVersion());
			defaultInterpolatedStringHandler.AppendLiteral("/Diff/");
			defaultInterpolatedStringHandler.AppendFormatted(this.VersionInfo.GetResType());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			LauncherFileLib.ClearResDirs(defaultInterpolatedStringHandler.ToStringAndClear(), hashSet);
			if (LauncherFileLib.HadDeletion)
			{
				this.HadDeletion = true;
			}
			this.HasPreAnalyzeClear = true;
		}
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00004698 File Offset: 0x00002898
	private void PostAnalyzeClear()
	{
		if (!this.IsPreDownload)
		{
			foreach (PakFilePair pakFilePair in this.OldPakPairs.Values)
			{
				string text = (pakFilePair.Pak != null) ? pakFilePair.Pak.FilePath : ((pakFilePair.Sig != null) ? pakFilePair.Sig.FilePath : "");
				if (text != null && !(text == ""))
				{
					if (!text.EndsWith(EResFile.PAK.ToEnumString()))
					{
						int num = text.LastIndexOf('.');
						if (num <= 0)
						{
							LauncherLog instance = LauncherLog.Instance;
							string message = "UnmountPak: tmpPath has no extension, fallback to append.";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tmpPath", text);
							instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
							continue;
						}
						text = text.Substring(0, num) + EResFile.PAK.ToEnumString();
					}
					UKuroPakMountStatic.UnmountPak(text);
					if (pakFilePair.Pak != null)
					{
						pakFilePair.Pak.DeleteAll();
					}
					if (pakFilePair.Sig != null)
					{
						pakFilePair.Sig.DeleteAll();
					}
				}
			}
			this.OldPakPairs.Clear();
		}
	}

	// Token: 0x06000048 RID: 72 RVA: 0x000047D0 File Offset: 0x000029D0
	[return: TupleElementNames(new string[]
	{
		"requireFiles",
		"localSavedSize",
		"totalDownloadSize",
		"totalNeedSpace",
		"totalDownloadAndPatch",
		"allResSize",
		"allFileExpectSize",
		"allFileSavedSize",
		"allFileCount",
		null,
		null
	})]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		0
	})]
	private ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> AnalyzeSpaceInfo()
	{
		List<RequireFileInfo> list = new List<RequireFileInfo>();
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		int num8 = 0;
		foreach (PatchParams patchParams in this.PatchOpParams)
		{
			num += patchParams.DiffFile.ExpectSize;
			num2 += patchParams.DiffFile.GetLocalSize();
			num6 += patchParams.DiffFile.ExpectSize;
			num7 += patchParams.DiffFile.GetLocalSize();
			if (!patchParams.DiffFile.IsCompleteFile())
			{
				list.Add(patchParams.DiffFile.GetRequireInfo());
			}
			num8++;
			num4 += patchParams.CopySize;
			long num9 = 0L;
			foreach (LocalFileInfo localFileInfo in patchParams.AllDestFiles.Values)
			{
				num9 += localFileInfo.GetSelfSize();
			}
			long num10 = patchParams.NewRefSize - num9;
			num5 += num10;
			if (num3 < num5)
			{
				num3 = num5;
			}
			num5 -= patchParams.DiffFile.ExpectSize;
			foreach (LocalFileInfo localFileInfo2 in patchParams.OldModify)
			{
				num5 -= localFileInfo2.GetSelfSize();
			}
		}
		foreach (LocalFileInfo localFileInfo3 in this.DownloadList)
		{
			num += localFileInfo3.ExpectSize;
			num2 += localFileInfo3.GetLocalSize();
			list.Add(localFileInfo3.GetRequireInfo());
		}
		long num11;
		if (num5 >= 0L)
		{
			num11 = num4;
		}
		else
		{
			long num12 = num4 + num5;
			num11 = ((num12 >= 0L) ? num12 : 0L);
		}
		long item = num + num3 + num11;
		long item2 = num - num2 + num3 + num11;
		this.SpaceModel.DownloadSize = num;
		this.SpaceModel.SavedSize = num2;
		this.SpaceModel.PatchPeak = num3;
		this.SpaceModel.PatchNetDelta = num5;
		this.SpaceModel.CopySize = num4;
		long num13 = 0L;
		foreach (PakFilePair pakFilePair in this.LatestPakPairs.Values)
		{
			num13 += pakFilePair.Pak.ExpectSize;
			num6 += pakFilePair.Pak.ExpectSize;
			num7 += pakFilePair.Pak.GetLocalSize();
			num8++;
			if (pakFilePair.Sig != null)
			{
				num13 += pakFilePair.Sig.ExpectSize;
				num6 += pakFilePair.Sig.ExpectSize;
				num7 += pakFilePair.Sig.GetLocalSize();
				num8++;
			}
		}
		return new ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>>(list, num2, num, item2, item, num13, num6, new ValueTuple<long, int>(num7, num8));
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00004B70 File Offset: 0x00002D70
	private void AddToPakPairs(string key, LocalFileInfo info, Dictionary<string, PakFilePair> pakMap, int order = 0)
	{
		PakFilePair pakFilePair;
		if (!pakMap.TryGetValue(key, out pakFilePair))
		{
			pakFilePair = new PakFilePair();
			pakFilePair.MountOrder = order;
			pakMap[key] = pakFilePair;
		}
		if (info.FilePath.EndsWith(EResFile.PAK.ToEnumString()))
		{
			pakFilePair.Pak = info;
		}
		if (info.FilePath.EndsWith(EResFile.SIG.ToEnumString()))
		{
			pakFilePair.Sig = info;
		}
		if (info.FilePath.EndsWith(EResFile.UTOC.ToEnumString()))
		{
			pakFilePair.Utoc = info;
		}
		if (info.FilePath.EndsWith(EResFile.UCAS.ToEnumString()))
		{
			pakFilePair.Ucas = info;
		}
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00004C08 File Offset: 0x00002E08
	private unsafe string GetNewPakPairKey(string dirName, string fileName)
	{
		int num = fileName.LastIndexOf('.');
		if (num <= 0)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "GetNewPakPairKey: fileName has no extension, fallback to full name.";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dirName", dirName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("fileName", fileName);
			instance.Warn(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return "";
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
		defaultInterpolatedStringHandler.AppendFormatted(this.VersionInfo.GetResType());
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted(dirName);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted(fileName.Substring(0, num));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00004CC8 File Offset: 0x00002EC8
	private void CollectAllFilesByVersion(string dir, string localVerDirName, string ver, List<ResFileInfo> files)
	{
		int order = (localVerDirName == "Base") ? 4 : this.VersionInfo.GetMountOrder();
		foreach (ResFileInfo resFileInfo in files)
		{
			DestFileInfo info = new DestFileInfo(resFileInfo.Name, dir + resFileInfo.Name, resFileInfo.Size, ResPackageInfo.PathMisc.GetResFileRoute(this.ResUri, ver, resFileInfo.Name), resFileInfo.Hash);
			string newPakPairKey = this.GetNewPakPairKey(localVerDirName, resFileInfo.Name);
			this.AddToPakPairs(newPakPairKey, info, this.LatestPakPairs, order);
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00004D88 File Offset: 0x00002F88
	[return: Nullable(2)]
	private unsafe LocalFileInfo GetFileInfoFromNewPakPairs(string dirName, string fileName)
	{
		string newPakPairKey = this.GetNewPakPairKey(dirName, fileName);
		PakFilePair pakFilePair;
		if (this.LatestPakPairs.TryGetValue(newPakPairKey, out pakFilePair))
		{
			if (fileName.EndsWith(EResFile.PAK.ToEnumString()))
			{
				return pakFilePair.Pak;
			}
			if (fileName.EndsWith(EResFile.SIG.ToEnumString()))
			{
				return pakFilePair.Sig;
			}
			if (fileName.EndsWith(EResFile.UTOC.ToEnumString()))
			{
				return pakFilePair.Utoc;
			}
			if (fileName.EndsWith(EResFile.UCAS.ToEnumString()))
			{
				return pakFilePair.Ucas;
			}
		}
		LauncherLog instance = LauncherLog.Instance;
		string message = "manifest miss patch file!";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("file", fileName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dirName", dirName);
		instance.Warn(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return null;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00004E54 File Offset: 0x00003054
	[return: Nullable(2)]
	private unsafe LocalFileInfo ToDelOldFile(string fileName, string filePath)
	{
		LocalFileInfo localFileInfo = new LocalFileInfo(fileName, filePath, 0L);
		if (ChunkTool.IsRestartRequiredAfterHotPatchChunk(filePath))
		{
			return localFileInfo;
		}
		if (this.IsPreDownload)
		{
			return localFileInfo;
		}
		int num = fileName.LastIndexOf('.');
		if (num <= 0)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "ToDelOldFile: fileName has no extension, fallback to full name.";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("fileName", fileName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("filePath", filePath);
			instance.Warn(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		string key = fileName.Substring(0, num);
		this.AddToPakPairs(key, localFileInfo, this.OldPakPairs, 0);
		return localFileInfo;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00004EF8 File Offset: 0x000030F8
	private void DeleteOldDir(string oldDir, bool isBase)
	{
		if (!isBase)
		{
			TArray<string> files = UKuroStaticLibrary.GetFiles(oldDir, "");
			int num = files.Num();
			for (int i = 0; i < num; i++)
			{
				string text = files.Get(i);
				string filePath = oldDir + text;
				this.ToDelOldFile(text, filePath);
			}
			return;
		}
		if (this.IsPreDownload)
		{
			return;
		}
		if (UBlueprintPathsLibrary.DirectoryExists(oldDir))
		{
			UKuroLauncherLibrary.DeleteDirectory(oldDir);
		}
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00004F5C File Offset: 0x0000315C
	private void CollectPakDownloadFiles(PakFilePair pakPair)
	{
		if (pakPair.Pak.GetSelfSize() != pakPair.Pak.ExpectSize)
		{
			pakPair.Pak.DeleteSelf();
			this.DownloadList.Add(pakPair.Pak);
		}
		if (pakPair.Sig != null && pakPair.Sig.GetSelfSize() != pakPair.Sig.ExpectSize)
		{
			pakPair.Sig.DeleteSelf();
			this.DownloadList.Add(pakPair.Sig);
		}
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00004FDC File Offset: 0x000031DC
	private void CollectDownloadFiles(bool isBase)
	{
		if (isBase)
		{
			using (Dictionary<string, PakFilePair>.Enumerator enumerator = this.LatestPakPairs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, PakFilePair> keyValuePair = enumerator.Current;
					string key = keyValuePair.Key;
					PakFilePair value = keyValuePair.Value;
					if (key.Contains("/Base/"))
					{
						this.CollectPakDownloadFiles(value);
					}
				}
				return;
			}
		}
		foreach (KeyValuePair<string, PakFilePair> keyValuePair2 in this.LatestPakPairs)
		{
			string key2 = keyValuePair2.Key;
			PakFilePair value2 = keyValuePair2.Value;
			if (!key2.Contains("/Base/"))
			{
				this.CollectPakDownloadFiles(value2);
			}
		}
	}

	// Token: 0x06000051 RID: 81 RVA: 0x000050AC File Offset: 0x000032AC
	private unsafe void ClearDiffAndCollectDownload(PatchInfo patch, string oldDir, string newDir, bool isBase)
	{
		string text = isBase ? this.VersionInfo.GetPackageVersion() : this.VersionInfo.LatestVersion;
		string dirName = isBase ? "Base" : text;
		if (patch.DiffFile != null && patch.DiffFile.Size > 0L)
		{
			LauncherFileLib.RemoveDownloadFile(ResPackageInfo.PathMisc.GetDiffFilePath(this.VersionInfo.GetPackageVersion(), isBase ? "Base" : text, this.VersionInfo.GetResType(), patch.DiffFile.Name));
		}
		foreach (string fileName in patch.NewFiles)
		{
			LocalFileInfo fileInfoFromNewPakPairs = this.GetFileInfoFromNewPakPairs(dirName, fileName);
			if (fileInfoFromNewPakPairs != null && !fileInfoFromNewPakPairs.IsCompleteFile())
			{
				fileInfoFromNewPakPairs.DeleteSelf();
				this.DownloadList.Add(fileInfoFromNewPakPairs);
			}
		}
		foreach (string text2 in patch.ModFiles)
		{
			if (!this.IsPreDownload)
			{
				if (isBase)
				{
					LauncherFileLib.RemoveDownloadFile(oldDir + text2);
				}
				else
				{
					this.ToDelOldFile(text2, oldDir + text2);
				}
			}
			LocalFileInfo fileInfoFromNewPakPairs2 = this.GetFileInfoFromNewPakPairs(dirName, text2);
			if (fileInfoFromNewPakPairs2 != null && !fileInfoFromNewPakPairs2.IsCompleteFile())
			{
				fileInfoFromNewPakPairs2.DeleteSelf();
				this.DownloadList.Add(fileInfoFromNewPakPairs2);
			}
		}
		if (!this.IsPreDownload)
		{
			foreach (string text3 in patch.DelFiles)
			{
				if (isBase)
				{
					LauncherFileLib.RemoveDownloadFile(oldDir + text3);
				}
				else
				{
					this.ToDelOldFile(text3, oldDir + text3);
				}
			}
			foreach (IdenticalPair identicalPair in patch.SameFiles)
			{
				LocalFileInfo fileInfoFromNewPakPairs3 = this.GetFileInfoFromNewPakPairs(dirName, identicalPair.DestFile);
				if (fileInfoFromNewPakPairs3 != null)
				{
					string text4 = oldDir + identicalPair.SrcFile;
					LocalFileInfo localFileInfo = new LocalFileInfo(identicalPair.SrcFile, text4, fileInfoFromNewPakPairs3.ExpectSize);
					if (isBase)
					{
						if (fileInfoFromNewPakPairs3.IsCompleteFile())
						{
							localFileInfo.DeleteAll();
						}
						else if (UBlueprintPathsLibrary.FileExists(text4))
						{
							UKuroLauncherLibrary.MoveFile(newDir + identicalPair.DestFile, text4);
						}
						else if (!fileInfoFromNewPakPairs3.IsCompleteFile())
						{
							fileInfoFromNewPakPairs3.DeleteSelf();
							this.DownloadList.Add(fileInfoFromNewPakPairs3);
						}
					}
					else if (fileInfoFromNewPakPairs3.IsCompleteFile())
					{
						if (!localFileInfo.IsRestartRequiredAfterHotPatchChunk)
						{
							int num = identicalPair.SrcFile.LastIndexOf('.');
							string key;
							if (num <= 0)
							{
								LauncherLog instance = LauncherLog.Instance;
								string message = "AnalyzePatch: SrcFile has no extension, fallback to full name.";
								<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("srcFile", identicalPair.SrcFile);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("filePath", localFileInfo.FilePath);
								instance.Warn(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
								key = identicalPair.SrcFile;
							}
							else
							{
								key = identicalPair.SrcFile.Substring(0, num);
							}
							this.AddToPakPairs(key, localFileInfo, this.OldPakPairs, 0);
						}
					}
					else if (localFileInfo.IsCompleteFile())
					{
						this.MoveOpParams.Add(new MoveParams(localFileInfo, fileInfoFromNewPakPairs3));
					}
					else if (!fileInfoFromNewPakPairs3.IsCompleteFile())
					{
						fileInfoFromNewPakPairs3.DeleteSelf();
						this.DownloadList.Add(fileInfoFromNewPakPairs3);
					}
				}
			}
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x000054A8 File Offset: 0x000036A8
	private unsafe void AnalyzePatch(Dictionary<string, List<PatchInfo>> remotePatchMap, string oldVersion, string latestVersion, bool bIsBase, bool bForceDownload = false, bool bRevert = false)
	{
		bool flag = oldVersion == latestVersion;
		LauncherLog instance = LauncherLog.Instance;
		string message = "begin analyze and print the info";
		<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("bIsBase", bIsBase);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("oldVersion", oldVersion);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("latestVersion", latestVersion);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("isSameVer", flag);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("bForceDownload", bForceDownload);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("bIsPreDownload", this.IsPreDownload);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("map", remotePatchMap);
		instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
		if (flag)
		{
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "collect all files if local is miss";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
			instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			this.CollectDownloadFiles(bIsBase);
			return;
		}
		string resFileDir = ResPackageInfo.PathMisc.GetResFileDir(this.VersionInfo.GetPackageVersion(), bIsBase ? "Base" : latestVersion, this.VersionInfo.GetResType());
		string resFileDir2 = ResPackageInfo.PathMisc.GetResFileDir(bIsBase ? oldVersion : this.VersionInfo.GetPackageVersion(), bIsBase ? "Base" : oldVersion, this.VersionInfo.GetResType());
		List<PatchInfo> list;
		if (!remotePatchMap.TryGetValue(oldVersion, out list))
		{
			list = new List<PatchInfo>();
		}
		bool flag2 = list.Count <= 0 || bForceDownload;
		LauncherLog instance3 = LauncherLog.Instance;
		string message3 = "1st. use bin patch or not?";
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("useDiff", !flag2);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("diffCount", list.Count);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("forceDownload", bForceDownload);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
		instance3.Info(message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 5));
		if (!flag2)
		{
			foreach (PatchInfo patchInfo in list)
			{
				bool group = patchInfo.Group;
				if (patchInfo.Group)
				{
					int num = 0;
					Dictionary<string, LocalFileInfo> dictionary = new Dictionary<string, LocalFileInfo>();
					List<LocalFileInfo> list2 = new List<LocalFileInfo>();
					if (UBlueprintPathsLibrary.DirectoryExists(resFileDir2))
					{
						foreach (string text in patchInfo.ModFiles)
						{
							LocalFileInfo fileInfoFromNewPakPairs = this.GetFileInfoFromNewPakPairs(bIsBase ? "Base" : latestVersion, text);
							if (fileInfoFromNewPakPairs != null)
							{
								dictionary[text] = fileInfoFromNewPakPairs;
								string filePath = resFileDir2 + text;
								LocalFileInfo localFileInfo = new LocalFileInfo(text, filePath, 0L);
								if (localFileInfo.IsCompleteFile())
								{
									num++;
									if (!localFileInfo.IsRestartRequiredAfterHotPatchChunk)
									{
										list2.Add(localFileInfo);
									}
								}
							}
						}
					}
					bool flag3 = num > 0;
					LauncherLog instance4 = LauncherLog.Instance;
					string message4 = "2nd. use bin patch or not in each group?";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("useDiff", flag3);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("group", patchInfo.GroupName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
					instance4.Info(message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 4));
					if (!flag3)
					{
						LauncherLog instance5 = LauncherLog.Instance;
						string message5 = "cant use diff, clear diff and collect miss files.";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
						instance5.Info(message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
						this.ClearDiffAndCollectDownload(patchInfo, resFileDir2, resFileDir, bIsBase);
					}
					else
					{
						foreach (string text2 in patchInfo.NewFiles)
						{
							LocalFileInfo fileInfoFromNewPakPairs2 = this.GetFileInfoFromNewPakPairs(bIsBase ? "Base" : latestVersion, text2);
							if (fileInfoFromNewPakPairs2 != null)
							{
								dictionary[text2] = fileInfoFromNewPakPairs2;
							}
						}
						long num2 = 0L;
						if (!this.IsPreDownload)
						{
							foreach (string text3 in patchInfo.DelFiles)
							{
								string filePath2 = resFileDir2 + text3;
								this.ToDelOldFile(text3, filePath2);
							}
							foreach (IdenticalPair identicalPair in patchInfo.SameFiles)
							{
								LocalFileInfo fileInfoFromNewPakPairs3 = this.GetFileInfoFromNewPakPairs(bIsBase ? "Base" : latestVersion, identicalPair.DestFile);
								if (fileInfoFromNewPakPairs3 != null)
								{
									string text4 = resFileDir2 + identicalPair.SrcFile;
									LocalFileInfo localFileInfo2 = new LocalFileInfo(identicalPair.SrcFile, text4, fileInfoFromNewPakPairs3.ExpectSize);
									if (fileInfoFromNewPakPairs3.IsCompleteFile())
									{
										localFileInfo2.DeleteAll();
									}
									else if (localFileInfo2.IsCompleteFile())
									{
										this.MoveOpParams.Add(new MoveParams(localFileInfo2, fileInfoFromNewPakPairs3));
										if (ChunkTool.IsRestartRequiredAfterHotPatchChunk(text4))
										{
											num2 += fileInfoFromNewPakPairs3.ExpectSize;
										}
									}
									else
									{
										localFileInfo2.DeleteAll();
										fileInfoFromNewPakPairs3.DeleteSelf();
										this.DownloadList.Add(fileInfoFromNewPakPairs3);
									}
								}
							}
						}
						if (patchInfo.DiffFile != null && patchInfo.DiffFile.Size > 0L)
						{
							string diffFilePath = ResPackageInfo.PathMisc.GetDiffFilePath(this.VersionInfo.GetPackageVersion(), bIsBase ? "Base" : latestVersion, this.VersionInfo.GetResType(), patchInfo.DiffFile.Name);
							string resFileRoute = ResPackageInfo.PathMisc.GetResFileRoute(this.ResUri, bRevert ? oldVersion : latestVersion, patchInfo.DiffFile.Name);
							DestFileInfo destFileInfo = new DestFileInfo(patchInfo.DiffFile.Name, diffFilePath, patchInfo.DiffFile.Size, resFileRoute, patchInfo.DiffFile.Hash);
							long num3 = 0L;
							List<LocalFileInfo> list3 = new List<LocalFileInfo>();
							foreach (LocalFileInfo localFileInfo3 in dictionary.Values)
							{
								if (!localFileInfo3.IsCompleteFile())
								{
									num3 += localFileInfo3.ExpectSize;
									list3.Add(localFileInfo3);
								}
							}
							if (!destFileInfo.IsCompleteFile() && num3 <= patchInfo.DiffFile.Size)
							{
								foreach (LocalFileInfo item in list3)
								{
									this.DownloadList.Add(item);
								}
								if (this.IsPreDownload)
								{
									continue;
								}
								using (List<LocalFileInfo>.Enumerator enumerator5 = list2.GetEnumerator())
								{
									while (enumerator5.MoveNext())
									{
										LocalFileInfo localFileInfo4 = enumerator5.Current;
										if (!localFileInfo4.IsRestartRequiredAfterHotPatchChunk && UBlueprintPathsLibrary.FileExists(localFileInfo4.FilePath))
										{
											UKuroLauncherLibrary.DeleteFile(localFileInfo4.FilePath);
										}
									}
									continue;
								}
							}
							this.PatchOpParams.Add(new PatchParams(destFileInfo, resFileDir2, resFileDir, list2, dictionary, num2, patchInfo.NewRefSize));
						}
						else
						{
							foreach (LocalFileInfo item2 in dictionary.Values)
							{
								this.DownloadList.Add(item2);
							}
						}
					}
				}
			}
			return;
		}
		if (list.Count <= 0)
		{
			LauncherLog instance6 = LauncherLog.Instance;
			string message6 = "there is no diff info at remote. clear old dir and collect all new files.";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray6 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 0) = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 1) = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
			instance6.Info(message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray6, 2));
			this.DeleteOldDir(resFileDir2, bIsBase);
			this.CollectDownloadFiles(bIsBase);
			return;
		}
		LauncherLog instance7 = LauncherLog.Instance;
		string message7 = "force download, clear diff and collect miss files.";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray7 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray7, 0) = new ValueTuple<string, object>("res", this.VersionInfo.GetResType());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray7, 1) = new ValueTuple<string, object>("preDownload", this.IsPreDownload);
		instance7.Info(message7, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray7, 2));
		foreach (PatchInfo patch in list)
		{
			this.ClearDiffAndCollectDownload(patch, resFileDir2, resFileDir, bIsBase);
		}
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00005F2C File Offset: 0x0000412C
	private void ResetCache()
	{
		this.LatestVersion = this.VersionInfo.LatestVersion;
		this.ManifestRoute = "";
		this.ManifestSavePath = "";
	}

	// Token: 0x04000007 RID: 7
	private static AppPathMisc PathMisc;

	// Token: 0x04000008 RID: 8
	private static ResPackageInfo Launcher;

	// Token: 0x04000009 RID: 9
	private static ResPackageInfo Resource;

	// Token: 0x0400000A RID: 10
	private static Dictionary<string, ResPackageInfo> Languages;

	// Token: 0x0400000B RID: 11
	private static Dictionary<string, ResPackageInfo> OptionalDownLoad;

	// Token: 0x0400000C RID: 12
	[Nullable(2)]
	private static ResPackageInfo AggregatedManifest;

	// Token: 0x0400000D RID: 13
	private static Dictionary<string, ResPackageInfo> RoleVoices;

	// Token: 0x0400000E RID: 14
	private static List<ResPackageInfo> TierPacks;

	// Token: 0x0400000F RID: 15
	private string LatestVersion = "";

	// Token: 0x04000010 RID: 16
	private string ManifestRoute = "";

	// Token: 0x04000011 RID: 17
	private string ManifestSavePath = "";

	// Token: 0x04000012 RID: 18
	private PatchManifestJson Manifest;

	// Token: 0x04000013 RID: 19
	private PatchManifestJson RevertManifest;

	// Token: 0x04000014 RID: 20
	private bool NeedReboot;

	// Token: 0x04000015 RID: 21
	public bool HadDeletion;

	// Token: 0x04000016 RID: 22
	private readonly bool HotFixOrRepair;

	// Token: 0x04000017 RID: 23
	private readonly List<LocalFileInfo> DownloadList = new List<LocalFileInfo>();

	// Token: 0x04000018 RID: 24
	private readonly Dictionary<string, PakFilePair> LatestPakPairs = new Dictionary<string, PakFilePair>();

	// Token: 0x04000019 RID: 25
	private readonly Dictionary<string, PakFilePair> OldPakPairs = new Dictionary<string, PakFilePair>();

	// Token: 0x0400001A RID: 26
	private readonly List<PatchParams> PatchOpParams = new List<PatchParams>();

	// Token: 0x0400001B RID: 27
	private readonly List<MoveParams> MoveOpParams = new List<MoveParams>();

	// Token: 0x0400001C RID: 28
	private bool HasPreAnalyzeClear;

	// Token: 0x0400001D RID: 29
	public readonly PackageSpaceModel SpaceModel = new PackageSpaceModel();

	// Token: 0x0400001E RID: 30
	private readonly Dictionary<ETier, ResPackageInfo> TierPackageInfos = new Dictionary<ETier, ResPackageInfo>();

	// Token: 0x0400001F RID: 31
	private readonly string ResUri;

	// Token: 0x04000020 RID: 32
	private readonly ResVersionInfo VersionInfo;

	// Token: 0x04000021 RID: 33
	private readonly bool IsPreDownload;
}
