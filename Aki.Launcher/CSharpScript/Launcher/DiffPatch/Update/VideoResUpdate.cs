using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x02000215 RID: 533
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoResUpdate : Singleton
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x0005470A File Offset: 0x0005290A
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

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x00054728 File Offset: 0x00052928
		public Dictionary<string, VideoResourceInfo> VideoMap
		{
			get
			{
				return this.GetVideoMap(null);
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00054744 File Offset: 0x00052944
		private ETier ResolveTierKey(ETier? tier = null)
		{
			if (!RemoteInfo.Instance.IsResourceQualityTierEnabled())
			{
				return ETier.None;
			}
			ETier etier = tier ?? RemoteInfo.Instance.ActiveTier;
			if (etier != ETier.None)
			{
				return etier;
			}
			return LauncherDeviceTierLib.GetHighestSupportTier();
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00054788 File Offset: 0x00052988
		public Dictionary<string, VideoResourceInfo> GetVideoMap(ETier? tier = null)
		{
			ETier key = this.ResolveTierKey(tier);
			Dictionary<string, VideoResourceInfo> dictionary;
			if (!this.TierVideos.TryGetValue(key, out dictionary))
			{
				dictionary = new Dictionary<string, VideoResourceInfo>();
				this.TierVideos[key] = dictionary;
			}
			return dictionary;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x000547C4 File Offset: 0x000529C4
		private Dictionary<int, string> GetVideoIdToPackNameMap(ETier? tier = null)
		{
			ETier key = this.ResolveTierKey(tier);
			Dictionary<int, string> dictionary;
			if (!this.TierVideoIdToPackNames.TryGetValue(key, out dictionary))
			{
				dictionary = new Dictionary<int, string>();
				this.TierVideoIdToPackNames[key] = dictionary;
			}
			return dictionary;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00054800 File Offset: 0x00052A00
		private Dictionary<string, VideoResourceInfo> Video
		{
			get
			{
				return this.GetVideoMap(null);
			}
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0005481C File Offset: 0x00052A1C
		[NullableContext(2)]
		public void SetViewMgr(HotFixManager viewMgr)
		{
			this.ViewMgr = viewMgr;
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00054825 File Offset: 0x00052A25
		public void ResetNetworkTypeRecord()
		{
			this.IsAllowCellDownload = false;
			this.NetworkListener.NetworkChangeDelegate.Clear();
			this.CallbackOnNetworkTypeChange = null;
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00054845 File Offset: 0x00052A45
		public bool GetIsCellNetworkType()
		{
			return this.NetworkListener.GetNetworkType() == 3;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00054855 File Offset: 0x00052A55
		public bool GetIsAllowCellDownload()
		{
			return this.IsAllowCellDownload;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0005485D File Offset: 0x00052A5D
		public void SetCallbackOnNetworkTypeChange(Action<byte> callback)
		{
			this.NetworkListener.NetworkChangeDelegate.Clear();
			this.CallbackOnNetworkTypeChange = callback;
			this.NetworkListener.NetworkChangeDelegate.Add(this.CallbackOnNetworkTypeChange);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0005488C File Offset: 0x00052A8C
		public void SetIsAllowCellDownload(bool isAllowCellDownload)
		{
			this.IsAllowCellDownload = isAllowCellDownload;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00054895 File Offset: 0x00052A95
		public bool GetIsSeparateVideo()
		{
			return this.IsSeparateVideoInternal;
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x000548A0 File Offset: 0x00052AA0
		public bool IsVideoClearGrayBoxHit()
		{
			if (!this.IsSeparateVideoInternal)
			{
				return false;
			}
			if (Platform.Instance.IsCloudGame())
			{
				LauncherLog.Instance.Info("云游戏不开启Mp4分包", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
			{
				LauncherLog.Instance.Info("分包开启, 忽略mp4灰度, 直接命中", default(ReadOnlySpan<ValueTuple<string, object>>));
				return true;
			}
			if (UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1")
			{
				return BaseConfigController.Instance.CheckGrayBoxHitByDeviceId("ClearVideoResGrayBox", UKuroSDKManager.GetBasicInfo().DeviceId);
			}
			LauncherLog.Instance.Info("VideoResUpdate ClearVideoResGrayBox 灰度检查: SDK未启用，灰度命中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00054960 File Offset: 0x00052B60
		public unsafe void Init(AppPathMisc appPathMisc, bool isSeparateVideo, bool isNewUser)
		{
			this.PathMisc = appPathMisc;
			this.IsSeparateVideoInternal = isSeparateVideo;
			int deviceSaved = LauncherStorageLib.Instance.GetDeviceSaved<int>(ELauncherStorageDeviceKey.IsNewUserSelected, 0);
			if (isNewUser)
			{
				if (deviceSaved == 0)
				{
					LauncherStorageLib.Instance.SetDeviceSaved<int>(ELauncherStorageDeviceKey.IsNewUserSelected, 1);
				}
				this.IsNewUser = isNewUser;
			}
			else if (deviceSaved == 1)
			{
				this.IsNewUser = true;
			}
			else
			{
				this.IsNewUser = false;
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "VideoResInit";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isSeparateVideo", isSeparateVideo);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsNewUser", this.IsNewUser);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("isNewUserSaved", deviceSaved);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00054A35 File Offset: 0x00052C35
		public void SetVideoResSize(EVideoResSizeType sizeType, long size)
		{
			this.VideoResSizeMap[sizeType] = size;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00054A44 File Offset: 0x00052C44
		public bool GetIsNewUser()
		{
			return this.IsNewUser;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00054A4C File Offset: 0x00052C4C
		public bool GetIsEnableVideoUpdateEntry()
		{
			return this.IsSeparateVideoInternal && this.GetIsGrayBoxHit();
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00054A5E File Offset: 0x00052C5E
		public bool GetIsGrayBoxHit()
		{
			return false;
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00054A61 File Offset: 0x00052C61
		public long GetVideoResSize(EVideoResSizeType sizeType)
		{
			if (this.VideoResSizeMap.ContainsKey(sizeType))
			{
				return this.VideoResSizeMap[sizeType];
			}
			return 0L;
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00054A80 File Offset: 0x00052C80
		public void SetVideoResSavedSize(EVideoResSizeType sizeType, long size)
		{
			this.VideoResSavedSizeMap[sizeType] = size;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00054A8F File Offset: 0x00052C8F
		public long GetVideoResSavedSize(EVideoResSizeType sizeType)
		{
			if (this.VideoResSavedSizeMap.ContainsKey(sizeType))
			{
				return this.VideoResSavedSizeMap[sizeType];
			}
			return 0L;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00054AAE File Offset: 0x00052CAE
		public void SetVideoResPak(EVideoResSizeType sizeType, List<string> paks)
		{
			this.VideoResPakMap[sizeType] = paks;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00054AC0 File Offset: 0x00052CC0
		public IReadOnlyList<string> GetVideoResPak(EVideoResSizeType sizeType)
		{
			List<string> result;
			if (this.VideoResPakMap.TryGetValue(sizeType, out result))
			{
				return result;
			}
			return Array.Empty<string>();
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00054AE4 File Offset: 0x00052CE4
		public void SetAllSpecialVideoResPak(EVideoResSizeType sizeType, List<string> paks)
		{
			this.AllSpVideoResPakMap[sizeType] = paks;
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00054AF4 File Offset: 0x00052CF4
		public IReadOnlyList<string> GetAllSpecialVideoResPak(EVideoResSizeType sizeType)
		{
			List<string> result;
			if (this.AllSpVideoResPakMap.TryGetValue(sizeType, out result))
			{
				return result;
			}
			return Array.Empty<string>();
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00054B18 File Offset: 0x00052D18
		public unsafe bool GetIsResPakDownloading(EVideoResSizeType sizeType)
		{
			List<string> list;
			if (!this.VideoResPakMap.TryGetValue(sizeType, out list))
			{
				return false;
			}
			bool result;
			if (this.VideoResPakMapDownLoadState.TryGetValue(sizeType, out result))
			{
				return result;
			}
			List<string> list2 = new List<string>();
			foreach (string text in list)
			{
				if (!text.EndsWith("2"))
				{
					list2.Add(text);
				}
			}
			bool flag = false;
			ValueTuple<List<RequireFileInfo>, long, long, List<LocalFileInfo>> valueTuple = this.AnalyzeRequireFilesByNames(list2);
			long item = valueTuple.Item2;
			long item2 = valueTuple.Item3;
			if (item != item2 && item2 > 0L)
			{
				flag = true;
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "VideoDown Is VideoRes Downloading?";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ResType", sizeType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isDownloading", flag);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.VideoResPakMapDownLoadState[sizeType] = flag;
			return flag;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00054C38 File Offset: 0x00052E38
		public void ResetResPakDownloadingState(EVideoResSizeType sizeType)
		{
			if (this.VideoResPakMapDownLoadState.ContainsKey(sizeType))
			{
				this.VideoResPakMapDownLoadState.Remove(sizeType);
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00054C58 File Offset: 0x00052E58
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1
		})]
		public ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>> AnalyzeRequireFiles()
		{
			List<LocalFileInfo> list = new List<LocalFileInfo>();
			List<RequireFileInfo> list2 = new List<RequireFileInfo>();
			foreach (KeyValuePair<string, VideoResourceInfo> keyValuePair in this.Video)
			{
				ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, long, long> valueTuple = this.AnalyzeSingle(keyValuePair.Value);
				List<LocalFileInfo> item = valueTuple.Item1;
				List<RequireFileInfo> item2 = valueTuple.Item2;
				list.AddRange(item);
				list2.AddRange(item2);
			}
			return new ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>>(list, list2);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00054CE4 File Offset: 0x00052EE4
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			0
		})]
		public ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, List<LocalFileInfo>, List<RequireFileInfo>, List<LocalFileInfo>, List<RequireFileInfo>, long, ValueTuple<long>> GetRequireFiles()
		{
			List<LocalFileInfo> list = new List<LocalFileInfo>();
			List<RequireFileInfo> list2 = new List<RequireFileInfo>();
			List<LocalFileInfo> list3 = new List<LocalFileInfo>();
			List<RequireFileInfo> list4 = new List<RequireFileInfo>();
			List<LocalFileInfo> list5 = new List<LocalFileInfo>();
			List<RequireFileInfo> list6 = new List<RequireFileInfo>();
			long num = 0L;
			long num2 = 0L;
			foreach (KeyValuePair<string, VideoResourceInfo> keyValuePair in this.Video)
			{
				ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, long, long> valueTuple = this.AnalyzeSingle(keyValuePair.Value);
				List<LocalFileInfo> item = valueTuple.Item1;
				List<RequireFileInfo> item2 = valueTuple.Item2;
				long item3 = valueTuple.Item3;
				long item4 = valueTuple.Item4;
				list.AddRange(item);
				list2.AddRange(item2);
				num += item3;
				num2 += item4;
				if (keyValuePair.Key.EndsWith("0"))
				{
					list3.AddRange(item);
					list4.AddRange(item2);
				}
				else if (keyValuePair.Key.EndsWith("1"))
				{
					list5.AddRange(item);
					list6.AddRange(item2);
				}
				else if (keyValuePair.Key.EndsWith("2"))
				{
					list3.AddRange(item);
					list4.AddRange(item2);
					list5.AddRange(item);
					list6.AddRange(item2);
				}
			}
			return new ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, List<LocalFileInfo>, List<RequireFileInfo>, List<LocalFileInfo>, List<RequireFileInfo>, long, ValueTuple<long>>(list, list2, list3, list4, list5, list6, num, new ValueTuple<long>(num2));
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00054E48 File Offset: 0x00053048
		public void CheckVideoManifestsData()
		{
			if (!UKuroLauncherLibrary.NeedHotPatch())
			{
				return;
			}
			if (this.Video.Count == 0)
			{
				this.ResolveVideoManifests(this.ResolveTierKey(null));
			}
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00054E80 File Offset: 0x00053080
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1
		})]
		public ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>> GetPreDownloadRequireFiles()
		{
			List<LocalFileInfo> list = new List<LocalFileInfo>();
			List<RequireFileInfo> list2 = new List<RequireFileInfo>();
			foreach (KeyValuePair<string, VideoResourceInfo> keyValuePair in this.PreDownloadVideo)
			{
				ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, long, long> valueTuple = this.AnalyzeSingle(keyValuePair.Value);
				List<LocalFileInfo> item = valueTuple.Item1;
				List<RequireFileInfo> item2 = valueTuple.Item2;
				list.AddRange(item);
				list2.AddRange(item2);
			}
			return new ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>>(list, list2);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00054F0C File Offset: 0x0005310C
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1
		})]
		public ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, long, long> AnalyzeSingle(VideoResourceInfo singleInfo)
		{
			List<LocalFileInfo> list = new List<LocalFileInfo>();
			List<RequireFileInfo> list2 = new List<RequireFileInfo>();
			long num = 0L;
			long num2 = 0L;
			string text = singleInfo.LocalPath + "/" + singleInfo.PakFileName;
			string remoteRoute = singleInfo.RemoteRoute + "/" + singleInfo.PakFileName;
			DestFileInfo destFileInfo = new DestFileInfo(singleInfo.PakFileName, text, singleInfo.PakSize, remoteRoute, singleInfo.PakHash);
			num += destFileInfo.ExpectSize;
			num2 += destFileInfo.GetLocalSize();
			if (!destFileInfo.IsCompleteFile())
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "VideoRes new download file";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("res", text);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				list.Add(destFileInfo);
				list2.Add(destFileInfo.GetRequireInfo());
			}
			string text2 = singleInfo.LocalPath + "/" + singleInfo.SigFileName;
			string remoteRoute2 = singleInfo.RemoteRoute + "/" + singleInfo.SigFileName;
			DestFileInfo destFileInfo2 = new DestFileInfo(singleInfo.SigFileName, text2, singleInfo.SigSize, remoteRoute2, singleInfo.SigHash);
			num += destFileInfo2.ExpectSize;
			num2 += destFileInfo2.GetLocalSize();
			if (!destFileInfo2.IsCompleteFile())
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "VideoRes new download file";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("res", text2);
				instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				list.Add(destFileInfo2);
				list2.Add(destFileInfo2.GetRequireInfo());
			}
			return new ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, long, long>(list, list2, num, num2);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0005507C File Offset: 0x0005327C
		public void DeleteSingle(VideoResourceInfo singleInfo)
		{
			UKuroPakMountStatic.UnmountPak(singleInfo.LocalPath + "/" + singleInfo.PakFileName);
			LauncherLog instance = LauncherLog.Instance;
			string message = "delete video res dir";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dir", singleInfo.LocalPath);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (!UBlueprintPathsLibrary.DirectoryExists(singleInfo.LocalPath))
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "VideoRes delete file but dir not exist";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("dir", singleInfo.LocalPath);
				instance2.Warn(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			if (UKuroLauncherLibrary.DeleteDirectory(singleInfo.LocalPath))
			{
				LauncherLog instance3 = LauncherLog.Instance;
				string message3 = "delete video res dir success";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("dir", singleInfo.LocalPath);
				instance3.Info(message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return;
			}
			LauncherLog instance4 = LauncherLog.Instance;
			string message4 = "VideoRes delete file fail";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("dir", singleInfo.LocalPath);
			instance4.Warn(message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00055160 File Offset: 0x00053360
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1
		})]
		public ValueTuple<List<RequireFileInfo>, long, long, List<LocalFileInfo>> AnalyzeRequireFilesByNames(IReadOnlyList<string> videoNames)
		{
			List<LocalFileInfo> list = new List<LocalFileInfo>();
			List<RequireFileInfo> list2 = new List<RequireFileInfo>();
			long num = 0L;
			long num2 = 0L;
			foreach (string text in videoNames)
			{
				VideoResourceInfo singleInfo;
				if (!this.Video.TryGetValue(text, out singleInfo))
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "VideoRes not find remote video info ";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("res", text);
					instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, long, long> valueTuple2 = this.AnalyzeSingle(singleInfo);
					List<LocalFileInfo> item = valueTuple2.Item1;
					List<RequireFileInfo> item2 = valueTuple2.Item2;
					long item3 = valueTuple2.Item3;
					long item4 = valueTuple2.Item4;
					num += item3;
					num2 += item4;
					list.AddRange(item);
					list2.AddRange(item2);
				}
			}
			return new ValueTuple<List<RequireFileInfo>, long, long, List<LocalFileInfo>>(list2, num, num2, list);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00055240 File Offset: 0x00053440
		public long GetFreeSpace()
		{
			return ResPackageInfo.GetTotalAndFreeSpace(ResPackageInfo.GetResSaveDir()).Item2;
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00055254 File Offset: 0x00053454
		public bool IsVideoDirExists()
		{
			return UBlueprintPathsLibrary.DirectoryExists(ResPackageInfo.GetResSaveDir() + "Video/" + this.GetTierSubDir(null) + "Paks");
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0005528C File Offset: 0x0005348C
		public void DeleteLegacyVideoDir()
		{
			string text = ResPackageInfo.GetResSaveDir() + "Video/Paks";
			LauncherLog instance = LauncherLog.Instance;
			string message = "删除旧视频目录";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dir", text);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (UBlueprintPathsLibrary.DirectoryExists(text) && !UKuroLauncherLibrary.DeleteDirectory(text))
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "删除旧视频目录失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("dir", text);
				instance2.Warn(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00055300 File Offset: 0x00053500
		public string DeleteTierVideoDir(ETier tier)
		{
			string text = LauncherDeviceTierLib.TierToLabel(this.ResolveTierKey(new ETier?(tier)));
			string text2 = ResPackageInfo.GetResSaveDir() + "Video/" + ((text != "") ? text.ToLower() : "Paks");
			foreach (VideoResourceInfo videoResourceInfo in this.GetVideoMap(new ETier?(tier)).Values)
			{
				UKuroPakMountStatic.UnmountPak(videoResourceInfo.LocalPath + "/" + videoResourceInfo.PakFileName);
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "删除档位视频目录";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dir", text2);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (UBlueprintPathsLibrary.DirectoryExists(text2))
			{
				UKuroLauncherLibrary.DeleteDirectory(text2);
			}
			return text2;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000553E4 File Offset: 0x000535E4
		public void MountPaks()
		{
			foreach (KeyValuePair<string, VideoResourceInfo> keyValuePair in this.Video)
			{
				string text = keyValuePair.Value.LocalPath + "/" + keyValuePair.Value.PakFileName;
				if (UKuroLauncherLibrary.GetFileSize(text) == keyValuePair.Value.PakSize)
				{
					UKuroPakMountStatic.MountPak(text, 4);
					LauncherLog instance = LauncherLog.Instance;
					string message = "VideoRes mount pak";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("res", keyValuePair.Value.PakSize);
					instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000554A4 File Offset: 0x000536A4
		public void MountPaksByName(List<string> videoNames)
		{
			foreach (string text in videoNames)
			{
				VideoResourceInfo videoResourceInfo;
				if (!this.Video.TryGetValue(text, out videoResourceInfo))
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "VideoRes not find remote video info ";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("res", text);
					instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					string text2 = videoResourceInfo.LocalPath + "/" + videoResourceInfo.PakFileName;
					if (UKuroLauncherLibrary.GetFileSize(text2) == videoResourceInfo.PakSize)
					{
						UKuroPakMountStatic.MountPak(text2, 4);
						LauncherLog instance2 = LauncherLog.Instance;
						string message2 = "VideoRes mount pak";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("res", videoResourceInfo.PakSize);
						instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}
				}
			}
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00055584 File Offset: 0x00053784
		[NullableContext(0)]
		public UniTask<bool> UpdateVideoSource()
		{
			VideoResUpdate.<UpdateVideoSource>d__64 <UpdateVideoSource>d__;
			<UpdateVideoSource>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdateVideoSource>d__.<>4__this = this;
			<UpdateVideoSource>d__.<>1__state = -1;
			<UpdateVideoSource>d__.<>t__builder.Start<VideoResUpdate.<UpdateVideoSource>d__64>(ref <UpdateVideoSource>d__);
			return <UpdateVideoSource>d__.<>t__builder.Task;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x000555C8 File Offset: 0x000537C8
		private unsafe List<ETier> GetManifestTiers()
		{
			if (!RemoteInfo.Instance.IsResourceQualityTierEnabled())
			{
				int num = 1;
				List<ETier> list = new List<ETier>(num);
				CollectionsMarshal.SetCount<ETier>(list, num);
				Span<ETier> span = CollectionsMarshal.AsSpan<ETier>(list);
				int num2 = 0;
				*span[num2] = ETier.None;
				return list;
			}
			List<ETier> list2 = new List<ETier>(RemoteInfo.Instance.NewTierConfig.Keys);
			if (list2.Count <= 0)
			{
				int num2 = 1;
				List<ETier> list3 = new List<ETier>(num2);
				CollectionsMarshal.SetCount<ETier>(list3, num2);
				Span<ETier> span = CollectionsMarshal.AsSpan<ETier>(list3);
				int num = 0;
				*span[num] = RemoteInfo.Instance.ActiveTier;
				return list3;
			}
			return list2;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00055650 File Offset: 0x00053850
		private UniTask RequestVideoCfg(ETier tier)
		{
			VideoResUpdate.<RequestVideoCfg>d__66 <RequestVideoCfg>d__;
			<RequestVideoCfg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestVideoCfg>d__.<>4__this = this;
			<RequestVideoCfg>d__.tier = tier;
			<RequestVideoCfg>d__.<>1__state = -1;
			<RequestVideoCfg>d__.<>t__builder.Start<VideoResUpdate.<RequestVideoCfg>d__66>(ref <RequestVideoCfg>d__);
			return <RequestVideoCfg>d__.<>t__builder.Task;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0005569C File Offset: 0x0005389C
		[NullableContext(0)]
		private UniTask<bool> RequestVideoCfgManifest(ETier tier)
		{
			VideoResUpdate.<RequestVideoCfgManifest>d__67 <RequestVideoCfgManifest>d__;
			<RequestVideoCfgManifest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestVideoCfgManifest>d__.<>4__this = this;
			<RequestVideoCfgManifest>d__.tier = tier;
			<RequestVideoCfgManifest>d__.<>1__state = -1;
			<RequestVideoCfgManifest>d__.<>t__builder.Start<VideoResUpdate.<RequestVideoCfgManifest>d__67>(ref <RequestVideoCfgManifest>d__);
			return <RequestVideoCfgManifest>d__.<>t__builder.Task;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000556E8 File Offset: 0x000538E8
		private bool ResolveVideoManifests(ETier tier)
		{
			Dictionary<string, VideoResourceInfo> videoMap = this.GetVideoMap(new ETier?(tier));
			bool result = this.ResolveVideoManifestsFromPath(videoMap, BaseConfigController.Instance.GetMixUri(), BaseConfigController.Instance.GetResUri(), UKuroLauncherLibrary.GetAppVersion(), new ETier?(tier));
			Dictionary<int, string> videoIdToPackNameMap = this.GetVideoIdToPackNameMap(new ETier?(tier));
			foreach (KeyValuePair<string, VideoResourceInfo> keyValuePair in videoMap)
			{
				string key = keyValuePair.Key;
				int key2;
				if (!int.TryParse(key.Split('_', StringSplitOptions.None)[0], out key2))
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "VideoRes invalid video id";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("res", key);
					instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					videoIdToPackNameMap[key2] = key;
				}
			}
			return result;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x000557C0 File Offset: 0x000539C0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<RemoteVideoConfigUpdateTime> RequestVideoCfgForPath(string mixPath, ETier? tier = null)
		{
			VideoResUpdate.<RequestVideoCfgForPath>d__69 <RequestVideoCfgForPath>d__;
			<RequestVideoCfgForPath>d__.<>t__builder = AsyncUniTaskMethodBuilder<RemoteVideoConfigUpdateTime>.Create();
			<RequestVideoCfgForPath>d__.<>4__this = this;
			<RequestVideoCfgForPath>d__.mixPath = mixPath;
			<RequestVideoCfgForPath>d__.tier = tier;
			<RequestVideoCfgForPath>d__.<>1__state = -1;
			<RequestVideoCfgForPath>d__.<>t__builder.Start<VideoResUpdate.<RequestVideoCfgForPath>d__69>(ref <RequestVideoCfgForPath>d__);
			return <RequestVideoCfgForPath>d__.<>t__builder.Task;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00055814 File Offset: 0x00053A14
		[return: Nullable(0)]
		public UniTask<bool> DownloadVideoCfgManifestForConfig(RemoteVideoConfigUpdateTime videoConfig, string mixUri, string appVersion, ETier? tier = null)
		{
			VideoResUpdate.<DownloadVideoCfgManifestForConfig>d__70 <DownloadVideoCfgManifestForConfig>d__;
			<DownloadVideoCfgManifestForConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadVideoCfgManifestForConfig>d__.<>4__this = this;
			<DownloadVideoCfgManifestForConfig>d__.videoConfig = videoConfig;
			<DownloadVideoCfgManifestForConfig>d__.mixUri = mixUri;
			<DownloadVideoCfgManifestForConfig>d__.appVersion = appVersion;
			<DownloadVideoCfgManifestForConfig>d__.tier = tier;
			<DownloadVideoCfgManifestForConfig>d__.<>1__state = -1;
			<DownloadVideoCfgManifestForConfig>d__.<>t__builder.Start<VideoResUpdate.<DownloadVideoCfgManifestForConfig>d__70>(ref <DownloadVideoCfgManifestForConfig>d__);
			return <DownloadVideoCfgManifestForConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00055878 File Offset: 0x00053A78
		private string GetTierSuffix(ETier? tier = null)
		{
			string text = LauncherDeviceTierLib.TierToLabel(this.ResolveTierKey(tier));
			if (!(text != ""))
			{
				return "";
			}
			return "_" + text.ToLower();
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x000558B8 File Offset: 0x00053AB8
		private string GetTierSubDir(ETier? tier = null)
		{
			string text = LauncherDeviceTierLib.TierToLabel(this.ResolveTierKey(tier));
			if (!(text != ""))
			{
				return "";
			}
			return text.ToLower() + "/";
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000558F8 File Offset: 0x00053AF8
		private string GetVideoManifestSavePath(string appVersion, ETier? tier = null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
			defaultInterpolatedStringHandler.AppendFormatted(ResPackageInfo.GetResSaveDir());
			defaultInterpolatedStringHandler.AppendLiteral("Video/");
			defaultInterpolatedStringHandler.AppendFormatted(this.GetTierSubDir(tier));
			defaultInterpolatedStringHandler.AppendFormatted(appVersion);
			defaultInterpolatedStringHandler.AppendLiteral("/VideoManifest.json");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00055950 File Offset: 0x00053B50
		private string GetVideoManifestDownloadPath(string mixPath, string appVersion, ETier? tier = null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 4);
			defaultInterpolatedStringHandler.AppendFormatted(mixPath);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(this.PathMisc.GetPlatform());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(appVersion);
			defaultInterpolatedStringHandler.AppendLiteral("/Video/VideoManifest");
			defaultInterpolatedStringHandler.AppendFormatted(this.GetTierSuffix(tier));
			defaultInterpolatedStringHandler.AppendLiteral(".json");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000559CE File Offset: 0x00053BCE
		public string GetVideoLocalSavePath(ETier? tier = null)
		{
			return ResPackageInfo.GetResSaveDir() + "Video/" + this.GetTierSubDir(tier) + "Paks";
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x000559EC File Offset: 0x00053BEC
		private string GetVideoRemoteRoute(string resUri, string appVersion)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
			defaultInterpolatedStringHandler.AppendFormatted(resUri);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(this.PathMisc.GetPlatform());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(appVersion);
			defaultInterpolatedStringHandler.AppendLiteral("/Video");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00055A50 File Offset: 0x00053C50
		public bool ResolveVideoManifestsFromPath(Dictionary<string, VideoResourceInfo> outVideo, string mixUri, string resUri, string appVersion, ETier? tier = null)
		{
			string videoManifestSavePath = this.GetVideoManifestSavePath(appVersion, tier);
			string inCipher = "";
			if (!UKuroStaticLibrary.LoadFileToString(ref inCipher, videoManifestSavePath))
			{
				return false;
			}
			string text = "";
			if (!UKuroLauncherLibrary.Decrypt(inCipher, ref text))
			{
				return false;
			}
			RemoteVideoConfig remoteVideoConfig = LauncherJson.Parse<RemoteVideoConfig>(text, null);
			if (remoteVideoConfig == null)
			{
				LauncherLog.Instance.Error("VideoCfg is not exist.", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			string videoRemoteRoute = this.GetVideoRemoteRoute(resUri, appVersion);
			string videoLocalSavePath = this.GetVideoLocalSavePath(tier);
			foreach (KeyValuePair<string, VideoItem> keyValuePair in remoteVideoConfig.VideoInfos.PakMap)
			{
				string key = keyValuePair.Key;
				VideoItem value = keyValuePair.Value;
				if (!(key == "__kr_map__"))
				{
					VideoResourceInfo value2 = new VideoResourceInfo(videoRemoteRoute, videoLocalSavePath + "/" + key, value.PakName, value.PakSize, value.PakHash, value.SigName, value.SigSize, value.SigHash);
					outVideo[key] = value2;
				}
			}
			return true;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00055B7C File Offset: 0x00053D7C
		[return: Nullable(new byte[]
		{
			0,
			0,
			1,
			1,
			1,
			1
		})]
		public UniTask<ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, long>> AnalyzeVideoManifests()
		{
			VideoResUpdate.<AnalyzeVideoManifests>d__78 <AnalyzeVideoManifests>d__;
			<AnalyzeVideoManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, long>>.Create();
			<AnalyzeVideoManifests>d__.<>4__this = this;
			<AnalyzeVideoManifests>d__.<>1__state = -1;
			<AnalyzeVideoManifests>d__.<>t__builder.Start<VideoResUpdate.<AnalyzeVideoManifests>d__78>(ref <AnalyzeVideoManifests>d__);
			return <AnalyzeVideoManifests>d__.<>t__builder.Task;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00055BC0 File Offset: 0x00053DC0
		public List<string> GetVideoResPakByVideoIds(IReadOnlyList<int> videoIds, ETier? tier = null)
		{
			Dictionary<int, string> videoIdToPackNameMap = this.GetVideoIdToPackNameMap(tier);
			List<string> list = new List<string>();
			foreach (int key in videoIds)
			{
				string item;
				if (videoIdToPackNameMap.TryGetValue(key, out item) && !list.Contains(item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x00055C30 File Offset: 0x00053E30
		public static VideoResUpdate Instance
		{
			get
			{
				if (VideoResUpdate._instance == null)
				{
					VideoResUpdate._instance = new VideoResUpdate();
					VideoResUpdate._instance.OnInit();
				}
				return VideoResUpdate._instance;
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00055C53 File Offset: 0x00053E53
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00055C55 File Offset: 0x00053E55
		public static void ResetStaticDefaultValue()
		{
			VideoResUpdate instance = VideoResUpdate._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			VideoResUpdate._instance = null;
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00055C6E File Offset: 0x00053E6E
		static VideoResUpdate()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VideoResUpdate.CreateStaticDefaultValue), new Action(VideoResUpdate.ResetStaticDefaultValue));
		}

		// Token: 0x040008C7 RID: 2247
		private const int DOWNLOAD_TRY_COUNT = 3;

		// Token: 0x040008C8 RID: 2248
		private const string CLEAR_VIDEO_RES_GRAY_BOX = "ClearVideoResGrayBox";

		// Token: 0x040008C9 RID: 2249
		private readonly Dictionary<ETier, RemoteVideoConfigUpdateTime> TierConfigUpdateInfos = new Dictionary<ETier, RemoteVideoConfigUpdateTime>();

		// Token: 0x040008CA RID: 2250
		private readonly Dictionary<ETier, Dictionary<string, VideoResourceInfo>> TierVideos = new Dictionary<ETier, Dictionary<string, VideoResourceInfo>>();

		// Token: 0x040008CB RID: 2251
		private readonly Dictionary<ETier, Dictionary<int, string>> TierVideoIdToPackNames = new Dictionary<ETier, Dictionary<int, string>>();

		// Token: 0x040008CC RID: 2252
		private readonly Dictionary<string, VideoResourceInfo> PreDownloadVideo = new Dictionary<string, VideoResourceInfo>();

		// Token: 0x040008CD RID: 2253
		private readonly Dictionary<EVideoResSizeType, long> VideoResSizeMap = new Dictionary<EVideoResSizeType, long>();

		// Token: 0x040008CE RID: 2254
		private readonly Dictionary<EVideoResSizeType, long> VideoResSavedSizeMap = new Dictionary<EVideoResSizeType, long>();

		// Token: 0x040008CF RID: 2255
		private readonly Dictionary<EVideoResSizeType, List<string>> VideoResPakMap = new Dictionary<EVideoResSizeType, List<string>>();

		// Token: 0x040008D0 RID: 2256
		private readonly Dictionary<EVideoResSizeType, bool> VideoResPakMapDownLoadState = new Dictionary<EVideoResSizeType, bool>();

		// Token: 0x040008D1 RID: 2257
		private readonly Dictionary<EVideoResSizeType, List<string>> AllSpVideoResPakMap = new Dictionary<EVideoResSizeType, List<string>>();

		// Token: 0x040008D2 RID: 2258
		[Nullable(2)]
		private AppPathMisc PathMisc;

		// Token: 0x040008D3 RID: 2259
		private bool IsSeparateVideoInternal;

		// Token: 0x040008D4 RID: 2260
		private bool IsNewUser;

		// Token: 0x040008D5 RID: 2261
		private bool IsAllowCellDownload;

		// Token: 0x040008D6 RID: 2262
		[Nullable(2)]
		private Action<byte> CallbackOnNetworkTypeChange;

		// Token: 0x040008D7 RID: 2263
		[Nullable(2)]
		private UKuroNetworkChange NetworkListenerInternal;

		// Token: 0x040008D8 RID: 2264
		public bool ManifestInited;

		// Token: 0x040008D9 RID: 2265
		[Nullable(2)]
		private HotFixManager ViewMgr;

		// Token: 0x040008DA RID: 2266
		public EVideoResSizeType VideoDownloadState = EVideoResSizeType.StartMinNeed;

		// Token: 0x040008DB RID: 2267
		[Nullable(2)]
		private static VideoResUpdate _instance;
	}
}
