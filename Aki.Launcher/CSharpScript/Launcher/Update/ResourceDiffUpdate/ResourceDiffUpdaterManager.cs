using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update.ResourceDiffUpdate.Config;
using CSharpScript.Launcher.Update.ResourceDiffUpdate.Module;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x020000A3 RID: 163
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceDiffUpdaterManager : Singleton
	{
		// Token: 0x06000588 RID: 1416 RVA: 0x00031F08 File Offset: 0x00030108
		[NullableContext(2)]
		public void UpdatePlayerInfoFromHttpData(SubPackageHttpData httpData = null, string uid = null)
		{
			if (httpData == null)
			{
				httpData = HotFixManager.LaunchSubPackageHttpData;
			}
			if (uid == null)
			{
				FLoginStruct loginData = HotFixManager.LoginData;
				uid = ((loginData != null) ? loginData.Uid : null);
			}
			this.Context.ActiveQuestIds = (((httpData != null) ? httpData.NeedConfirmQuestIdSet : null) ?? new List<int>());
			this.Context.CurrentBlockIds = (((httpData != null) ? httpData.CurrentBlockIdSet : null) ?? new List<int>());
			this.Context.Gender = ((httpData != null) ? httpData.Sex : -1);
			this.Context.Positions = (((httpData != null) ? httpData.Positions : null) ?? new List<ResourcePackagePositionData>());
			this.InitFinishedQuests(uid, (httpData != null) ? httpData.Mp4FinishQuestFlag : null, (httpData != null) ? httpData.FinishQuestIdSet : null);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00031FCC File Offset: 0x000301CC
		public unsafe void MergeRecallQuests(int? curRecallId)
		{
			if (curRecallId != null)
			{
				int? num = curRecallId;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					RecallConfigRow byId = PackSelectionTables.RecallConfigTableInstance.GetById(curRecallId.Value);
					if (byId == null)
					{
						LauncherLog instance = LauncherLog.Instance;
						string message = "Optional package 回顾配置缺失";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("curRecallId", curRecallId);
						instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					foreach (int item in byId.QuestIds)
					{
						if (!this.Context.ActiveQuestIds.Contains(item))
						{
							this.Context.ActiveQuestIds.Add(item);
						}
					}
					LauncherLog instance2 = LauncherLog.Instance;
					string message2 = "Optional package 回顾任务并入核心包";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("curRecallId", curRecallId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("recallQuestIds", string.Join<int>(",", byId.QuestIds));
					instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00032108 File Offset: 0x00030308
		[NullableContext(2)]
		public void InitFinishedQuests(string sdkUid, List<uint> mp4FinishQuestFlag, List<int> finishQuestIdSet)
		{
			this.Context.FinishedQuests.Clear();
			if (sdkUid == null)
			{
				LauncherLog.Instance.Warn("Optional package 用户SDK Uid未定义, 无法初始化已完成任务列表", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (mp4FinishQuestFlag != null)
			{
				HashSet<int> hashSet = ResourceUpdateUtils.ParseMp4FinishQuestFlagToSet(mp4FinishQuestFlag);
				LauncherLog.Instance.Info("Optional package 解析Mp4FinishQuestFlag: " + string.Join<uint>(",", mp4FinishQuestFlag) + ", QuestBitIds: " + string.Join<int>(",", hashSet), default(ReadOnlySpan<ValueTuple<string, object>>));
				using (HashSet<int>.Enumerator enumerator = hashSet.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						int id = enumerator.Current;
						RefResourceQuestListRow byId = PackSelectionTables.RefResourceQuestListTableInstance.GetById(id);
						if (byId != null && byId.HasRefResource == 1)
						{
							this.Context.FinishedQuests.Add(byId.QuestId);
						}
					}
					goto IL_130;
				}
			}
			Dictionary<string, HashSet<int>> global = LauncherStorageLib.Instance.GetGlobal<Dictionary<string, HashSet<int>>>(ELauncherStorageGlobalKey.UserFinishedQuests, null);
			if (global != null && global.ContainsKey(sdkUid))
			{
				foreach (int item in global[sdkUid])
				{
					this.Context.FinishedQuests.Add(item);
				}
			}
			IL_130:
			foreach (int item2 in (finishQuestIdSet ?? new List<int>()))
			{
				this.Context.FinishedQuests.Add(item2);
			}
			LauncherLog.Instance.Info("Optional package 用户已完成任务列表: " + string.Join<int>(",", this.Context.FinishedQuests), default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000322E8 File Offset: 0x000304E8
		public void AddCurQuest(int questId)
		{
			if (!this.Context.ActiveQuestIds.Contains(questId))
			{
				this.Context.ActiveQuestIds.Add(questId);
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00032310 File Offset: 0x00030510
		public void UpdateFinishedQuests(List<int> quests)
		{
			LauncherLog.Instance.Info("Optional package 更新已完成任务列表: " + string.Join<int>(",", quests), default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Context.FinishedQuests.Clear();
			foreach (int item in quests)
			{
				this.Context.FinishedQuests.Add(item);
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x000323A4 File Offset: 0x000305A4
		public void AddFinishedQuest(int questId)
		{
			this.Context.FinishedQuests.Add(questId);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000323B8 File Offset: 0x000305B8
		public void UpdateCurrentBlockIds(List<int> blockIds)
		{
			LauncherLog.Instance.Info("Optional package 更新当前地块列表: " + string.Join<int>(",", blockIds), default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Context.CurrentBlockIds = blockIds;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000323FC File Offset: 0x000305FC
		public void UpdatePositions(int instanceId, double x, double y, double z)
		{
			ResourcePackagePositionData resourcePackagePositionData = new ResourcePackagePositionData();
			resourcePackagePositionData.instanceId = instanceId;
			resourcePackagePositionData.x = x;
			resourcePackagePositionData.y = y;
			resourcePackagePositionData.z = z;
			this.Context.Positions = new List<ResourcePackagePositionData>
			{
				resourcePackagePositionData
			};
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00032444 File Offset: 0x00030644
		public UniTask Init()
		{
			ResourceDiffUpdaterManager.<Init>d__22 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ResourceDiffUpdaterManager.<Init>d__22>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00032488 File Offset: 0x00030688
		public UniTask CheckOptionalPacks(DiffUpdate diffUpdate, HotFixManager viewMgr)
		{
			ResourceDiffUpdaterManager.<CheckOptionalPacks>d__23 <CheckOptionalPacks>d__;
			<CheckOptionalPacks>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckOptionalPacks>d__.<>4__this = this;
			<CheckOptionalPacks>d__.diffUpdate = diffUpdate;
			<CheckOptionalPacks>d__.viewMgr = viewMgr;
			<CheckOptionalPacks>d__.<>1__state = -1;
			<CheckOptionalPacks>d__.<>t__builder.Start<ResourceDiffUpdaterManager.<CheckOptionalPacks>d__23>(ref <CheckOptionalPacks>d__);
			return <CheckOptionalPacks>d__.<>t__builder.Task;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000324DC File Offset: 0x000306DC
		private UniTask ApplyDecision(DiffUpdate diffUpdate, HotFixManager viewMgr)
		{
			ResourceDiffUpdaterManager.<ApplyDecision>d__24 <ApplyDecision>d__;
			<ApplyDecision>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ApplyDecision>d__.<>4__this = this;
			<ApplyDecision>d__.diffUpdate = diffUpdate;
			<ApplyDecision>d__.viewMgr = viewMgr;
			<ApplyDecision>d__.<>1__state = -1;
			<ApplyDecision>d__.<>t__builder.Start<ResourceDiffUpdaterManager.<ApplyDecision>d__24>(ref <ApplyDecision>d__);
			return <ApplyDecision>d__.<>t__builder.Task;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00032530 File Offset: 0x00030730
		private unsafe void LogEffectiveResourceSelection()
		{
			string item = (RemoteInfo.Instance.ActiveTier == ETier.None) ? "未分级" : LauncherDeviceTierLib.TierToLabel(RemoteInfo.Instance.ActiveTier);
			string item2 = (this.ResUpdateState == EResUpdateType.Max) ? "全量包" : ((this.ResUpdateState == EResUpdateType.Min) ? "精简包" : "未设置");
			LauncherLog instance = LauncherLog.Instance;
			string message = "Optional package 本次流程生效的资源配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("资源等级", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("包体类型", item2);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000325D5 File Offset: 0x000307D5
		private void DeleteLegacyVideoDirForTierPlatform()
		{
			if (!RemoteInfo.Instance.IsResourceQualityTierEnabled() || RemoteInfo.Instance.ActiveTier == ETier.None)
			{
				return;
			}
			VideoResUpdate.Instance.DeleteLegacyVideoDir();
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000325FC File Offset: 0x000307FC
		private void ClearNonCurrentTierResourcesOnMobile()
		{
			ETier activeTier = RemoteInfo.Instance.ActiveTier;
			if (!Platform.Instance.IsMobilePlatform() || !RemoteInfo.Instance.IsResourceQualityTierEnabled() || activeTier == ETier.None)
			{
				return;
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "Optional package 清理移动端非当前档位资源";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activeTier", LauncherDeviceTierLib.TierToLabel(activeTier));
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			foreach (ResPackageInfo resPackageInfo in ResPackageInfo.GetAllTierableBaseInfos())
			{
				ResPackageInfo tierPackageInfo = resPackageInfo.GetTierPackageInfo(activeTier);
				foreach (ResPackageInfo resPackageInfo2 in resPackageInfo.GetAllTierPackageInfos())
				{
					if (resPackageInfo2 != tierPackageInfo)
					{
						resPackageInfo2.ClearRecord();
						resPackageInfo2.DeleteTierLocalFiles();
					}
				}
			}
			foreach (ETier etier in new ETier[]
			{
				ETier.SD,
				ETier.HD,
				ETier.UHD
			})
			{
				if (etier != activeTier)
				{
					VideoResUpdate.Instance.DeleteTierVideoDir(etier);
				}
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0003272C File Offset: 0x0003092C
		public void UpdateDecision()
		{
			IReadOnlyList<IResourceTypeModule> modules = new IResourceTypeModule[]
			{
				this.BlockModule,
				this.VideoModule,
				this.VoiceModule
			};
			ETier activeTier = RemoteInfo.Instance.ActiveTier;
			SelectionDecision selectionDecision = OptionalPackSelector.Select(modules, this.Context, activeTier);
			this.CurrentDecision = selectionDecision;
			if (this.CurrentDiffUpdate != null)
			{
				long item = this.CurrentDiffUpdate.CalcNeedSizeInfo(activeTier).Item5;
				this.BaseReqFileSize = item;
			}
			long num = selectionDecision.MinSize + this.BaseReqFileSize;
			long num2 = selectionDecision.MaxSize + this.BaseReqFileSize;
			this.SetResSize(EResUpdateType.Max, num2, new ETier?(activeTier));
			this.SetResSize(EResUpdateType.Min, num, new ETier?(activeTier));
			LauncherLog instance = LauncherLog.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(53, 3);
			defaultInterpolatedStringHandler.AppendLiteral("Optional package 分包计算完成: 档位: ");
			defaultInterpolatedStringHandler.AppendFormatted((LauncherDeviceTierLib.TierToLabel(activeTier) != "") ? LauncherDeviceTierLib.TierToLabel(activeTier) : "(默认)");
			defaultInterpolatedStringHandler.AppendLiteral(", 全量包大小: ");
			defaultInterpolatedStringHandler.AppendFormatted<double>((double)(num2 / 1048576L), "F2");
			defaultInterpolatedStringHandler.AppendLiteral(" MB, 精简包大小: ");
			defaultInterpolatedStringHandler.AppendFormatted<double>((double)(num / 1048576L), "F2");
			defaultInterpolatedStringHandler.AppendLiteral(" MB");
			instance.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0003287C File Offset: 0x00030A7C
		public void SwitchResTier(ETier? tier = null)
		{
			if (tier != null)
			{
				ETier? etier = tier;
				ETier activeTier = RemoteInfo.Instance.ActiveTier;
				if (etier.GetValueOrDefault() == activeTier & etier != null)
				{
					return;
				}
				if (!RemoteInfo.Instance.IsResourceQualityTierEnabled())
				{
					LauncherLog.Instance.Warn("Optional package 分级开关未开启, 忽略切换画质档位请求", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				LauncherLog.Instance.Info("Optional package 切换画质档位: " + LauncherDeviceTierLib.TierToLabel(tier.Value), default(ReadOnlySpan<ValueTuple<string, object>>));
				RemoteInfo.Instance.ActiveTier = tier.Value;
			}
			this.UpdateDecision();
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0003291C File Offset: 0x00030B1C
		public bool IsGrayBoxHit()
		{
			if (Platform.Instance.IsCloudGame())
			{
				LauncherLog.Instance.Info("云游戏不开启分包", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (!UKuroLauncherLibrary.NeedHotPatch())
			{
				LauncherLog.Instance.Info("Hot patch not needed, skipping optional package gray box check", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			bool flag = UKuroLauncherLibrary.IsEnableOptionalPackage();
			LauncherLog instance = LauncherLog.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 2);
			defaultInterpolatedStringHandler.AppendLiteral("PlatformType : ");
			defaultInterpolatedStringHandler.AppendFormatted<EPlatformType>(Platform.Instance.Type);
			defaultInterpolatedStringHandler.AppendLiteral(", EnableOptionalPackage: ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(flag);
			instance.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			if (!flag)
			{
				LauncherLog.Instance.Info("Optional package not enabled, skipping gray box check", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1")
			{
				return BaseConfigController.Instance.CheckGrayBoxHitByDeviceId("OptionalResourceDownloadGrayBox", UKuroSDKManager.GetBasicInfo().DeviceId);
			}
			LauncherLog.Instance.Info("Optional package 灰度检查: SDK未启用, 灰度命中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00032A44 File Offset: 0x00030C44
		public void RecordUserSelection()
		{
			LauncherStorageLib.Instance.SetDeviceSaved<EResUpdateType>(ELauncherStorageDeviceKey.SelectedMaxOrMinPackType, this.ResUpdateState);
			LauncherLog instance = LauncherLog.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Optional package 记录玩家选择的包体类型: ");
			defaultInterpolatedStringHandler.AppendFormatted<EResUpdateType>(this.ResUpdateState);
			instance.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			if (!RemoteInfo.Instance.IsResourceQualityTierEnabled())
			{
				return;
			}
			ETier etier = (RemoteInfo.Instance.ActiveTier != ETier.None) ? RemoteInfo.Instance.ActiveTier : LauncherDeviceTierLib.GetRecommendedTier();
			LauncherStorageLib.Instance.SetDeviceSaved<ETier>(ELauncherStorageDeviceKey.ResourceQualityTier, etier);
			LauncherLog.Instance.Info("Optional package 记录玩家选择的画质档位: " + LauncherDeviceTierLib.TierToLabel(etier), default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00032B00 File Offset: 0x00030D00
		private ETier ResolveTierKey(ETier? tier = null)
		{
			ETier? etier = tier;
			if (etier == null)
			{
				return RemoteInfo.Instance.ActiveTier;
			}
			return etier.GetValueOrDefault();
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00032B2C File Offset: 0x00030D2C
		private void SetResSize(EResUpdateType resType, long size, ETier? tier = null)
		{
			ETier key = this.ResolveTierKey(tier);
			Dictionary<EResUpdateType, long> dictionary;
			if (!this.ResourceSizeMap.TryGetValue(key, out dictionary))
			{
				dictionary = new Dictionary<EResUpdateType, long>();
				this.ResourceSizeMap[key] = dictionary;
			}
			dictionary[resType] = size;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00032B6C File Offset: 0x00030D6C
		public long GetResSize(EResUpdateType resType, ETier? tier = null)
		{
			ETier key = this.ResolveTierKey(tier);
			Dictionary<EResUpdateType, long> dictionary;
			long result;
			if (!this.ResourceSizeMap.TryGetValue(key, out dictionary) || !dictionary.TryGetValue(resType, out result))
			{
				return 0L;
			}
			return result;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00032BA0 File Offset: 0x00030DA0
		public long GetTierPacksSavedSize(ETier tier)
		{
			long num = 0L;
			List<ResPackageInfo> list = new List<ResPackageInfo>();
			list.Add(ResPackageInfo.ResourceInfo);
			list.AddRange(ResPackageInfo.GetAllLanguageInfos());
			list.AddRange(ResPackageInfo.GetAllOptionalDownLoadInfo());
			foreach (ResPackageInfo resPackageInfo in list)
			{
				ResPackageInfo resPackageInfo2 = (resPackageInfo != null) ? resPackageInfo.GetTierPackageInfo(tier) : null;
				if (resPackageInfo2 != null)
				{
					long item = resPackageInfo2.CalculateSavedSizeAndTotalSize().Item1;
					num += item;
				}
			}
			foreach (VideoResourceInfo singleInfo in VideoResUpdate.Instance.GetVideoMap(new ETier?(tier)).Values)
			{
				long item2 = VideoResUpdate.Instance.AnalyzeSingle(singleInfo).Item4;
				num += item2;
			}
			return num;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00032C94 File Offset: 0x00030E94
		public double GetSpendTime()
		{
			return (double)((long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalMilliseconds - this.StartTime) * 0.001;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00032CD0 File Offset: 0x00030ED0
		public void ReportInitialResDownloadState(bool successDownload, bool bStart = false)
		{
			if (successDownload && this.ResUpdateState != EResUpdateType.NotSet)
			{
				LauncherStorageLib.Instance.SetDeviceSaved<EResUpdateType>(ELauncherStorageDeviceKey.SelectedMaxOrMinPackType, this.ResUpdateState);
			}
			if (!ProcedureUtil.IsFirstTimeUpdateForPackage())
			{
				return;
			}
			int resUpdateState = (int)this.ResUpdateState;
			int downloadTime = (int)this.GetSpendTime();
			int downloadStatus = bStart ? 1 : (successDownload ? 0 : 2);
			FLoginStruct loginData = HotFixManager.LoginData;
			string uniqueId = ((loginData != null) ? loginData.Uid : null) ?? "";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.TraceId);
			new InitialResDownloadStateLog(resUpdateState, downloadTime, downloadStatus, uniqueId, defaultInterpolatedStringHandler.ToStringAndClear(), this.UserChoose, (int)(HotFixManager.GetAllCanClearSpace() / 1048576L), (int)(this.GetResSize(this.ResUpdateState, null) / 1048576L), null)
			{
				i_download_pkg = (int)LauncherDeviceTierLib.GetActiveTier(),
				i_recommand_pkg = (int)LauncherDeviceTierLib.GetRecommendedTier(),
				i_storage_bef = (int)(VideoResUpdate.Instance.GetFreeSpace() / 1073741824L)
			}.Report();
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00032DC0 File Offset: 0x00030FC0
		public void ReportResDownloadDeviceStorageState(long needSize, long freeSize, bool isRetry)
		{
			int resUpdateState = (int)this.ResUpdateState;
			bool ifStorageAlert = !isRetry;
			int requiredSpace = (int)(needSize / 1048576L);
			int remainingSpace = (int)(freeSize / 1048576L);
			FLoginStruct loginData = HotFixManager.LoginData;
			string uniqueId = ((loginData != null) ? loginData.Uid : null) ?? "";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.TraceId);
			new ResDownloadDeviceStorageState(resUpdateState, ifStorageAlert, requiredSpace, remainingSpace, uniqueId, defaultInterpolatedStringHandler.ToStringAndClear(), this.UserChoose, null).Report();
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00032E31 File Offset: 0x00031031
		public static ResourceDiffUpdaterManager Instance
		{
			get
			{
				if (ResourceDiffUpdaterManager._instance == null)
				{
					ResourceDiffUpdaterManager._instance = new ResourceDiffUpdaterManager();
					ResourceDiffUpdaterManager._instance.OnInit();
				}
				return ResourceDiffUpdaterManager._instance;
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00032E54 File Offset: 0x00031054
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00032E56 File Offset: 0x00031056
		public static void ResetStaticDefaultValue()
		{
			ResourceDiffUpdaterManager instance = ResourceDiffUpdaterManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			ResourceDiffUpdaterManager._instance = null;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00032E6F File Offset: 0x0003106F
		static ResourceDiffUpdaterManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ResourceDiffUpdaterManager.CreateStaticDefaultValue), new Action(ResourceDiffUpdaterManager.ResetStaticDefaultValue));
		}

		// Token: 0x04000376 RID: 886
		private const string OPTIONAL_RESOURCE_DOWNLOAD_GRAY_BOX = "OptionalResourceDownloadGrayBox";

		// Token: 0x04000377 RID: 887
		private const long MB_SIZE = 1048576L;

		// Token: 0x04000378 RID: 888
		public readonly BlockResourceModule BlockModule = new BlockResourceModule();

		// Token: 0x04000379 RID: 889
		public readonly VideoResourceModule VideoModule = new VideoResourceModule();

		// Token: 0x0400037A RID: 890
		public readonly VoiceResourceModule VoiceModule = new VoiceResourceModule();

		// Token: 0x0400037B RID: 891
		private readonly Dictionary<ETier, Dictionary<EResUpdateType, long>> ResourceSizeMap = new Dictionary<ETier, Dictionary<EResUpdateType, long>>();

		// Token: 0x0400037C RID: 892
		[Nullable(2)]
		private SelectionDecision CurrentDecision;

		// Token: 0x0400037D RID: 893
		private long BaseReqFileSize;

		// Token: 0x0400037E RID: 894
		[Nullable(2)]
		private DiffUpdate CurrentDiffUpdate;

		// Token: 0x0400037F RID: 895
		public EResUpdateType ResUpdateState;

		// Token: 0x04000380 RID: 896
		public int TraceId = -1;

		// Token: 0x04000381 RID: 897
		public long StartTime = -1L;

		// Token: 0x04000382 RID: 898
		private int UserChoose = 2;

		// Token: 0x04000383 RID: 899
		public readonly ResourceSelectionContext Context = new ResourceSelectionContext();

		// Token: 0x04000384 RID: 900
		[Nullable(2)]
		private static ResourceDiffUpdaterManager _instance;
	}
}
