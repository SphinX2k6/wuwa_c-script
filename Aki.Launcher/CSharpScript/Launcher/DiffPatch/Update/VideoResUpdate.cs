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
	// Token: 0x02000210 RID: 528
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoResUpdate : Singleton
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00051C16 File Offset: 0x0004FE16
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00051C34 File Offset: 0x0004FE34
		public Dictionary<string, VideoResourceInfo> VideoMap
		{
			get
			{
				return this.GetVideoMap(null);
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00051C50 File Offset: 0x0004FE50
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

		// Token: 0x06000D81 RID: 3457 RVA: 0x00051C94 File Offset: 0x0004FE94
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

		// Token: 0x06000D82 RID: 3458 RVA: 0x00051CD0 File Offset: 0x0004FED0
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x00051D0C File Offset: 0x0004FF0C
		private Dictionary<string, VideoResourceInfo> Video
		{
			get
			{
				return this.GetVideoMap(null);
			}
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00051D28 File Offset: 0x0004FF28
		[NullableContext(2)]
		public void SetViewMgr(HotFixManager viewMgr)
		{
			this.ViewMgr = viewMgr;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00051D31 File Offset: 0x0004FF31
		public void ResetNetworkTypeRecord()
		{
			this.IsAllowCellDownload = false;
			this.NetworkListener.NetworkChangeDelegate.Clear();
			this.CallbackOnNetworkTypeChange = null;
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00051D51 File Offset: 0x0004FF51
		public bool GetIsCellNetworkType()
		{
			return this.NetworkListener.GetNetworkType() == 3;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00051D61 File Offset: 0x0004FF61
		public bool GetIsAllowCellDownload()
		{
			return this.IsAllowCellDownload;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00051D69 File Offset: 0x0004FF69
		public void SetCallbackOnNetworkTypeChange(Action<byte> callback)
		{
			this.NetworkListener.NetworkChangeDelegate.Clear();
			this.CallbackOnNetworkTypeChange = callback;
			this.NetworkListener.NetworkChangeDelegate.Add(this.CallbackOnNetworkTypeChange);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00051D98 File Offset: 0x0004FF98
		public void SetIsAllowCellDownload(bool isAllowCellDownload)
		{
			this.IsAllowCellDownload = isAllowCellDownload;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00051DA1 File Offset: 0x0004FFA1
		public bool GetIsSeparateVideo()
		{
			return this.IsSeparateVideoInternal;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00051DAC File Offset: 0x0004FFAC
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

		// Token: 0x06000D8C RID: 3468 RVA: 0x00051E6C File Offset: 0x0005006C
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

		// Token: 0x06000D8D RID: 3469 RVA: 0x00051F41 File Offset: 0x00050141
		public void SetVideoResSize(EVideoResSizeType sizeType, long size)
		{
			this.VideoResSizeMap[sizeType] = size;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00051F50 File Offset: 0x00050150
		public bool GetIsNewUser()
		{
			return this.IsNewUser;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00051F58 File Offset: 0x00050158
		public bool GetIsEnableVideoUpdateEntry()
		{
			return this.IsSeparateVideoInternal && this.GetIsGrayBoxHit();
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00051F6A File Offset: 0x0005016A
		public bool GetIsGrayBoxHit()
		{
			return false;
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00051F6D File Offset: 0x0005016D
		public long GetVideoResSize(EVideoResSizeType sizeType)
		{
			if (this.VideoResSizeMap.ContainsKey(sizeType))
			{
				return this.VideoResSizeMap[sizeType];
			}
			return 0L;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00051F8C File Offset: 0x0005018C
		public void SetVideoResSavedSize(EVideoResSizeType sizeType, long size)
		{
			this.VideoResSavedSizeMap[sizeType] = size;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00051F9B File Offset: 0x0005019B
		public long GetVideoResSavedSize(EVideoResSizeType sizeType)
		{
			if (this.VideoResSavedSizeMap.ContainsKey(sizeType))
			{
				return this.VideoResSavedSizeMap[sizeType];
			}
			return 0L;
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00051FBA File Offset: 0x000501BA
		public void SetVideoResPak(EVideoResSizeType sizeType, List<string> paks)
		{
			this.VideoResPakMap[sizeType] = paks;
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00051FCC File Offset: 0x000501CC
		public IReadOnlyList<string> GetVideoResPak(EVideoResSizeType sizeType)
		{
			List<string> result;
			if (this.VideoResPakMap.TryGetValue(sizeType, out result))
			{
				return result;
			}
			return Array.Empty<string>();
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00051FF0 File Offset: 0x000501F0
		public void SetAllSpecialVideoResPak(EVideoResSizeType sizeType, List<string> paks)
		{
			this.AllSpVideoResPakMap[sizeType] = paks;
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00052000 File Offset: 0x00050200
		public IReadOnlyList<string> GetAllSpecialVideoResPak(EVideoResSizeType sizeType)
		{
			List<string> result;
			if (this.AllSpVideoResPakMap.TryGetValue(sizeType, out result))
			{
				return result;
			}
			return Array.Empty<string>();
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00052024 File Offset: 0x00050224
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

		// Token: 0x06000D99 RID: 3481 RVA: 0x00052144 File Offset: 0x00050344
		public void ResetResPakDownloadingState(EVideoResSizeType sizeType)
		{
			if (this.VideoResPakMapDownLoadState.ContainsKey(sizeType))
			{
				this.VideoResPakMapDownLoadState.Remove(sizeType);
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00052164 File Offset: 0x00050364
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

		// Token: 0x06000D9B RID: 3483 RVA: 0x000521F0 File Offset: 0x000503F0
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

		// Token: 0x06000D9C RID: 3484 RVA: 0x00052354 File Offset: 0x00050554
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

		// Token: 0x06000D9D RID: 3485 RVA: 0x0005238C File Offset: 0x0005058C
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

		// Token: 0x06000D9E RID: 3486 RVA: 0x00052418 File Offset: 0x00050618
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

		// Token: 0x06000D9F RID: 3487 RVA: 0x00052588 File Offset: 0x00050788
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

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0005266C File Offset: 0x0005086C
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

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0005274C File Offset: 0x0005094C
		public long GetFreeSpace()
		{
			return ResPackageInfo.GetTotalAndFreeSpace(ResPackageInfo.GetResSaveDir()).Item2;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00052760 File Offset: 0x00050960
		public bool IsVideoDirExists()
		{
			return UBlueprintPathsLibrary.DirectoryExists(ResPackageInfo.GetResSaveDir() + "Video/" + this.GetTierSubDir(null) + "Paks");
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00052798 File Offset: 0x00050998
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

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0005280C File Offset: 0x00050A0C
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

		// Token: 0x06000DA5 RID: 3493 RVA: 0x000528F0 File Offset: 0x00050AF0
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

		// Token: 0x06000DA6 RID: 3494 RVA: 0x000529B0 File Offset: 0x00050BB0
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

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00052A90 File Offset: 0x00050C90
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

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00052AD4 File Offset: 0x00050CD4
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

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00052B5C File Offset: 0x00050D5C
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

		// Token: 0x06000DAA RID: 3498 RVA: 0x00052BA8 File Offset: 0x00050DA8
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

		// Token: 0x06000DAB RID: 3499 RVA: 0x00052BF4 File Offset: 0x00050DF4
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

		// Token: 0x06000DAC RID: 3500 RVA: 0x00052CCC File Offset: 0x00050ECC
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

		// Token: 0x06000DAD RID: 3501 RVA: 0x00052D20 File Offset: 0x00050F20
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

		// Token: 0x06000DAE RID: 3502 RVA: 0x00052D84 File Offset: 0x00050F84
		private string GetTierSuffix(ETier? tier = null)
		{
			string text = LauncherDeviceTierLib.TierToLabel(this.ResolveTierKey(tier));
			if (!(text != ""))
			{
				return "";
			}
			return "_" + text.ToLower();
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00052DC4 File Offset: 0x00050FC4
		private string GetTierSubDir(ETier? tier = null)
		{
			string text = LauncherDeviceTierLib.TierToLabel(this.ResolveTierKey(tier));
			if (!(text != ""))
			{
				return "";
			}
			return text.ToLower() + "/";
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00052E04 File Offset: 0x00051004
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

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00052E5C File Offset: 0x0005105C
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

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00052EDA File Offset: 0x000510DA
		public string GetVideoLocalSavePath(ETier? tier = null)
		{
			return ResPackageInfo.GetResSaveDir() + "Video/" + this.GetTierSubDir(tier) + "Paks";
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00052EF8 File Offset: 0x000510F8
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

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00052F5C File Offset: 0x0005115C
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

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00053088 File Offset: 0x00051288
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

		// Token: 0x06000DB6 RID: 3510 RVA: 0x000530CC File Offset: 0x000512CC
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

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0005313C File Offset: 0x0005133C
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

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0005315F File Offset: 0x0005135F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00053161 File Offset: 0x00051361
		public static void ResetStaticDefaultValue()
		{
			VideoResUpdate instance = VideoResUpdate._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			VideoResUpdate._instance = null;
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0005317A File Offset: 0x0005137A
		static VideoResUpdate()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VideoResUpdate.CreateStaticDefaultValue), new Action(VideoResUpdate.ResetStaticDefaultValue));
		}

		// Token: 0x04000886 RID: 2182
		private const int DOWNLOAD_TRY_COUNT = 3;

		// Token: 0x04000887 RID: 2183
		private const string CLEAR_VIDEO_RES_GRAY_BOX = "ClearVideoResGrayBox";

		// Token: 0x04000888 RID: 2184
		private readonly Dictionary<ETier, RemoteVideoConfigUpdateTime> TierConfigUpdateInfos = new Dictionary<ETier, RemoteVideoConfigUpdateTime>();

		// Token: 0x04000889 RID: 2185
		private readonly Dictionary<ETier, Dictionary<string, VideoResourceInfo>> TierVideos = new Dictionary<ETier, Dictionary<string, VideoResourceInfo>>();

		// Token: 0x0400088A RID: 2186
		private readonly Dictionary<ETier, Dictionary<int, string>> TierVideoIdToPackNames = new Dictionary<ETier, Dictionary<int, string>>();

		// Token: 0x0400088B RID: 2187
		private readonly Dictionary<string, VideoResourceInfo> PreDownloadVideo = new Dictionary<string, VideoResourceInfo>();

		// Token: 0x0400088C RID: 2188
		private readonly Dictionary<EVideoResSizeType, long> VideoResSizeMap = new Dictionary<EVideoResSizeType, long>();

		// Token: 0x0400088D RID: 2189
		private readonly Dictionary<EVideoResSizeType, long> VideoResSavedSizeMap = new Dictionary<EVideoResSizeType, long>();

		// Token: 0x0400088E RID: 2190
		private readonly Dictionary<EVideoResSizeType, List<string>> VideoResPakMap = new Dictionary<EVideoResSizeType, List<string>>();

		// Token: 0x0400088F RID: 2191
		private readonly Dictionary<EVideoResSizeType, bool> VideoResPakMapDownLoadState = new Dictionary<EVideoResSizeType, bool>();

		// Token: 0x04000890 RID: 2192
		private readonly Dictionary<EVideoResSizeType, List<string>> AllSpVideoResPakMap = new Dictionary<EVideoResSizeType, List<string>>();

		// Token: 0x04000891 RID: 2193
		[Nullable(2)]
		private AppPathMisc PathMisc;

		// Token: 0x04000892 RID: 2194
		private bool IsSeparateVideoInternal;

		// Token: 0x04000893 RID: 2195
		private bool IsNewUser;

		// Token: 0x04000894 RID: 2196
		private bool IsAllowCellDownload;

		// Token: 0x04000895 RID: 2197
		[Nullable(2)]
		private Action<byte> CallbackOnNetworkTypeChange;

		// Token: 0x04000896 RID: 2198
		[Nullable(2)]
		private UKuroNetworkChange NetworkListenerInternal;

		// Token: 0x04000897 RID: 2199
		public bool ManifestInited;

		// Token: 0x04000898 RID: 2200
		[Nullable(2)]
		private HotFixManager ViewMgr;

		// Token: 0x04000899 RID: 2201
		public EVideoResSizeType VideoDownloadState = EVideoResSizeType.StartMinNeed;

		// Token: 0x0400089A RID: 2202
		[Nullable(2)]
		private static VideoResUpdate _instance;
	}
}
