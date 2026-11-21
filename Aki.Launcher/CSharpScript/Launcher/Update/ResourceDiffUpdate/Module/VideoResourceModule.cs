using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate.Config;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Module
{
	// Token: 0x020000B0 RID: 176
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoResourceModule : BaseResourceModule
	{
		// Token: 0x0600060C RID: 1548 RVA: 0x00036A1C File Offset: 0x00034C1C
		private void Init()
		{
			if (this.Inited)
			{
				return;
			}
			foreach (QuestRefVideoConfigRow questRefVideoConfigRow in PackSelectionTables.QuestRefVideoConfigTableInstance.GetAll())
			{
				int item = int.Parse(questRefVideoConfigRow.PakName.Split('_', StringSplitOptions.None)[0]);
				if (questRefVideoConfigRow.PakName.EndsWith("2"))
				{
					if (!this.QuestRefCommonVideos.ContainsKey(questRefVideoConfigRow.QuestId))
					{
						this.QuestRefCommonVideos[questRefVideoConfigRow.QuestId] = new List<int>();
					}
					this.QuestRefCommonVideos[questRefVideoConfigRow.QuestId].Add(item);
				}
				else if (questRefVideoConfigRow.GirlOrBoy == 1)
				{
					if (!this.QuestRefMaleVideos.ContainsKey(questRefVideoConfigRow.QuestId))
					{
						this.QuestRefMaleVideos[questRefVideoConfigRow.QuestId] = new List<int>();
					}
					this.QuestRefMaleVideos[questRefVideoConfigRow.QuestId].Add(item);
				}
				else if (questRefVideoConfigRow.GirlOrBoy == 0)
				{
					if (!this.QuestRefFemaleVideos.ContainsKey(questRefVideoConfigRow.QuestId))
					{
						this.QuestRefFemaleVideos[questRefVideoConfigRow.QuestId] = new List<int>();
					}
					this.QuestRefFemaleVideos[questRefVideoConfigRow.QuestId].Add(item);
				}
			}
			this.Inited = true;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00036B90 File Offset: 0x00034D90
		[NullableContext(0)]
		public override UniTask<bool> PrepareManifests()
		{
			VideoResourceModule.<PrepareManifests>d__6 <PrepareManifests>d__;
			<PrepareManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PrepareManifests>d__.<>4__this = this;
			<PrepareManifests>d__.<>1__state = -1;
			<PrepareManifests>d__.<>t__builder.Start<VideoResourceModule.<PrepareManifests>d__6>(ref <PrepareManifests>d__);
			return <PrepareManifests>d__.<>t__builder.Task;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00036BD4 File Offset: 0x00034DD4
		public override PackClassification ClassifyPacks(ResourceSelectionContext context, ETier tier = ETier.None, bool forceMax = false)
		{
			LauncherStorageLib.Instance.DeleteGlobal(ELauncherStorageGlobalKey.UserFinishedVideoList);
			if (!VideoResUpdate.Instance.GetIsSeparateVideo())
			{
				VideoResourceModule.LogClassification(tier, context.Gender, "未拆包", 0, 0, 0, 0, 0L, 0L);
				return new PackClassification
				{
					MinPacks = new List<ResPackageInfo>(),
					MaxPacks = new List<ResPackageInfo>(),
					MinSize = 0L,
					MaxSize = 0L
				};
			}
			HashSet<int> unFinishedVideos = this.GetUnFinishedVideos(context.FinishedQuests);
			VideoResPackageInfo videoResPackageInfo = this.BuildVideoPackInfo(unFinishedVideos, -1, tier);
			long num = (videoResPackageInfo != null) ? videoResPackageInfo.AnalyzeRequireFiles(false, tier).Item3 : 0L;
			if (forceMax)
			{
				List<ResPackageInfo> list;
				if (videoResPackageInfo == null)
				{
					list = new List<ResPackageInfo>();
				}
				else
				{
					(list = new List<ResPackageInfo>()).Add(videoResPackageInfo);
				}
				List<ResPackageInfo> list2 = list;
				VideoResourceModule.LogClassification(tier, -1, "强制全量", unFinishedVideos.Count, unFinishedVideos.Count, list2.Count, list2.Count, num, num);
				return new PackClassification
				{
					MinPacks = list2,
					MaxPacks = list2,
					MinSize = num,
					MaxSize = num
				};
			}
			string reason;
			HashSet<int> hashSet;
			int gender;
			if (VideoResUpdate.Instance.IsVideoClearGrayBoxHit())
			{
				reason = "核心视频";
				hashSet = this.GetCoreVideoIds(context);
				LauncherStorageLib.Instance.SetGlobal<HashSet<int>>(ELauncherStorageGlobalKey.UserFinishedVideoList, hashSet);
				gender = context.Gender;
			}
			else
			{
				reason = "灰度未命中，采用全部未完成任务视频";
				hashSet = unFinishedVideos;
				gender = -1;
			}
			VideoResPackageInfo videoResPackageInfo2 = this.BuildVideoPackInfo(hashSet, gender, tier);
			long minSize = (videoResPackageInfo2 != null) ? videoResPackageInfo2.AnalyzeRequireFiles(false, tier).Item3 : 0L;
			VideoResourceModule.LogClassification(tier, gender, reason, hashSet.Count, unFinishedVideos.Count, (videoResPackageInfo2 != null) ? 1 : 0, (videoResPackageInfo != null) ? 1 : 0, minSize, num);
			PackClassification packClassification = new PackClassification();
			List<ResPackageInfo> minPacks;
			if (videoResPackageInfo2 == null)
			{
				minPacks = new List<ResPackageInfo>();
			}
			else
			{
				(minPacks = new List<ResPackageInfo>()).Add(videoResPackageInfo2);
			}
			packClassification.MinPacks = minPacks;
			List<ResPackageInfo> maxPacks;
			if (videoResPackageInfo == null)
			{
				maxPacks = new List<ResPackageInfo>();
			}
			else
			{
				(maxPacks = new List<ResPackageInfo>()).Add(videoResPackageInfo);
			}
			packClassification.MaxPacks = maxPacks;
			packClassification.MinSize = minSize;
			packClassification.MaxSize = num;
			return packClassification;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00036DA8 File Offset: 0x00034FA8
		private unsafe static void LogClassification(ETier tier, int gender, string reason, int minVideoCount, int maxVideoCount, int minPackCount, int maxPackCount, long minSize, long maxSize)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "Optional package 视频资源大小";
			<>y__InlineArray9<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray9<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tier", tier);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("gender", gender);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("minVideoIds.count", minVideoCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("maxVideoIds.count", maxVideoCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("minPacks.count", minPackCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("maxPacks.count", maxPackCount);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7);
			string item = "minSize";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendFormatted<double>((double)minSize / 1048576.0, "F2");
			defaultInterpolatedStringHandler.AppendLiteral(" MB");
			ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8);
			string item2 = "maxSize";
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendFormatted<double>((double)maxSize / 1048576.0, "F2");
			defaultInterpolatedStringHandler.AppendLiteral(" MB");
			ptr2 = new ValueTuple<string, object>(item2, defaultInterpolatedStringHandler.ToStringAndClear());
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 9));
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00036F38 File Offset: 0x00035138
		private List<VideoResourceInfo> GetVideoResourceInfos(HashSet<int> videoIds, int gender, ETier tier = ETier.None)
		{
			if (videoIds.Count == 0)
			{
				return new List<VideoResourceInfo>();
			}
			List<int> videoIds2 = new List<int>(videoIds);
			List<string> list = VideoResUpdate.Instance.GetVideoResPakByVideoIds(videoIds2, new ETier?(tier));
			list = this.FilterVideoPacksByGender(list, gender);
			Dictionary<string, VideoResourceInfo> videoMap = VideoResUpdate.Instance.GetVideoMap(new ETier?(tier));
			List<VideoResourceInfo> list2 = new List<VideoResourceInfo>();
			foreach (string key in list)
			{
				VideoResourceInfo item;
				if (videoMap.TryGetValue(key, out item))
				{
					list2.Add(item);
				}
			}
			return list2;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00036FE0 File Offset: 0x000351E0
		[return: Nullable(2)]
		private VideoResPackageInfo BuildVideoPackInfo(HashSet<int> videoIds, int gender, ETier tier = ETier.None)
		{
			List<VideoResourceInfo> videoResourceInfos = this.GetVideoResourceInfos(videoIds, gender, tier);
			if (videoResourceInfos.Count == 0)
			{
				return null;
			}
			return new VideoResPackageInfo(videoResourceInfos);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00037008 File Offset: 0x00035208
		public HashSet<int> GetCoreVideoIds(ResourceSelectionContext context)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int num in context.ActiveQuestIds)
			{
				HashSet<int> questRefVideo = this.GetQuestRefVideo(num, context.Gender);
				foreach (int item in questRefVideo)
				{
					hashSet.Add(item);
				}
				if (questRefVideo.Count > 0)
				{
					LauncherLog instance = LauncherLog.Instance;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
					defaultInterpolatedStringHandler.AppendLiteral("当前任务 ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					defaultInterpolatedStringHandler.AppendLiteral(" 引用视频: ");
					defaultInterpolatedStringHandler.AppendFormatted(string.Join<int>(",", questRefVideo));
					instance.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			List<string> values;
			List<int> list = this.EvaluateRecommendVideoQuestIds(context.FinishedQuests, out values);
			LauncherLog instance2 = LauncherLog.Instance;
			string message = "依据关键任务完成度推荐视频任务列表: " + ResourceUpdateUtils.FormatLogList<int>(list);
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("matchedConfigs", ResourceUpdateUtils.FormatLogList<string>(values));
			instance2.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			foreach (int num2 in list)
			{
				if (!context.FinishedQuests.Contains(num2))
				{
					foreach (int item2 in this.GetQuestRefVideo(num2, context.Gender))
					{
						hashSet.Add(item2);
					}
				}
			}
			LauncherLog.Instance.Info("最终核心包视频列表: " + string.Join<int>(",", hashSet), default(ReadOnlySpan<ValueTuple<string, object>>));
			return hashSet;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00037218 File Offset: 0x00035418
		private List<int> EvaluateRecommendVideoQuestIds(HashSet<int> finishedQuests, out List<string> matchedConfigs)
		{
			List<int> list = new List<int>();
			matchedConfigs = new List<string>();
			foreach (RecommendPackRow recommendPackRow in PackSelectionTables.RecommendPackTableInstance.GetAll())
			{
				bool flag = true;
				foreach (int item in recommendPackRow.FinishQuest)
				{
					if (!finishedQuests.Contains(item))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					bool flag2 = true;
					foreach (int item2 in recommendPackRow.UnfinishQuest)
					{
						if (finishedQuests.Contains(item2))
						{
							flag2 = false;
							break;
						}
					}
					if (flag2)
					{
						if (recommendPackRow.VideoQuestId.Count > 0)
						{
							List<string> list2 = matchedConfigs;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 4);
							defaultInterpolatedStringHandler.AppendLiteral("(Id=");
							defaultInterpolatedStringHandler.AppendFormatted<int>(recommendPackRow.Id);
							defaultInterpolatedStringHandler.AppendLiteral(",FinishQuest=");
							defaultInterpolatedStringHandler.AppendFormatted(ResourceUpdateUtils.FormatLogList<int>(recommendPackRow.FinishQuest));
							defaultInterpolatedStringHandler.AppendLiteral(",");
							defaultInterpolatedStringHandler.AppendLiteral("UnfinishQuest=");
							defaultInterpolatedStringHandler.AppendFormatted(ResourceUpdateUtils.FormatLogList<int>(recommendPackRow.UnfinishQuest));
							defaultInterpolatedStringHandler.AppendLiteral(",VideoQuestId=");
							defaultInterpolatedStringHandler.AppendFormatted(ResourceUpdateUtils.FormatLogList<int>(recommendPackRow.VideoQuestId));
							defaultInterpolatedStringHandler.AppendLiteral(")");
							list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
						}
						foreach (int item3 in recommendPackRow.VideoQuestId)
						{
							list.Add(item3);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00037450 File Offset: 0x00035650
		private HashSet<int> GetQuestRefVideo(int questId, int gender)
		{
			HashSet<int> hashSet = new HashSet<int>();
			List<int> list;
			if (this.QuestRefCommonVideos.TryGetValue(questId, out list))
			{
				foreach (int item in list)
				{
					hashSet.Add(item);
				}
			}
			List<int> list2;
			if ((gender == 1 || gender == -1) && this.QuestRefMaleVideos.TryGetValue(questId, out list2))
			{
				foreach (int item2 in list2)
				{
					hashSet.Add(item2);
				}
			}
			List<int> list3;
			if ((gender == 0 || gender == -1) && this.QuestRefFemaleVideos.TryGetValue(questId, out list3))
			{
				foreach (int item3 in list3)
				{
					hashSet.Add(item3);
				}
			}
			return hashSet;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0003756C File Offset: 0x0003576C
		public override void Delete(IReadOnlyList<string> pakNames)
		{
			foreach (string text in pakNames)
			{
				VideoResourceInfo videoResourceInfo2;
				VideoResourceInfo videoResourceInfo = VideoResUpdate.Instance.VideoMap.TryGetValue(text, out videoResourceInfo2) ? videoResourceInfo2 : null;
				if (videoResourceInfo != null)
				{
					VideoResUpdate.Instance.DeleteSingle(videoResourceInfo);
				}
				else
				{
					LauncherLog.Instance.Warn("Optional package 卸载视频时未找到资源包信息: " + text, default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000375F8 File Offset: 0x000357F8
		public override long GetLocalSize(IReadOnlyList<string> pakNames)
		{
			long num = 0L;
			foreach (string text in pakNames)
			{
				VideoResourceInfo videoResourceInfo2;
				VideoResourceInfo videoResourceInfo = VideoResUpdate.Instance.VideoMap.TryGetValue(text, out videoResourceInfo2) ? videoResourceInfo2 : null;
				if (videoResourceInfo != null)
				{
					long item = VideoResUpdate.Instance.AnalyzeSingle(videoResourceInfo).Item4;
					num += item;
				}
				else
				{
					LauncherLog.Instance.Warn("Optional package 获取视频资源大小时未找到资源包信息: " + text, default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			return num;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00037694 File Offset: 0x00035894
		public void DeleteByVideoIds(HashSet<int> videoIds)
		{
			LauncherLog.Instance.Info("Optional package 按视频ID卸载, videoIds: " + string.Join<int>(",", videoIds), default(ReadOnlySpan<ValueTuple<string, object>>));
			List<int> videoIds2 = new List<int>(videoIds);
			List<string> videoResPakByVideoIds = VideoResUpdate.Instance.GetVideoResPakByVideoIds(videoIds2, null);
			this.Delete(videoResPakByVideoIds);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000376EC File Offset: 0x000358EC
		public long GetLocalSizeByVideoIds(HashSet<int> videoIds)
		{
			List<int> videoIds2 = new List<int>(videoIds);
			List<string> videoResPakByVideoIds = VideoResUpdate.Instance.GetVideoResPakByVideoIds(videoIds2, null);
			long localSize = this.GetLocalSize(videoResPakByVideoIds);
			LauncherLog instance = LauncherLog.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(57, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Optional package 按视频ID获取本地大小, videoIds.count: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(videoIds.Count);
			defaultInterpolatedStringHandler.AppendLiteral(", size: ");
			defaultInterpolatedStringHandler.AppendFormatted<double>((double)localSize / 1048576.0);
			defaultInterpolatedStringHandler.AppendLiteral(" MB");
			instance.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return localSize;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00037788 File Offset: 0x00035988
		public List<string> FilterVideoPacksByGender(List<string> packs, int gender)
		{
			if (gender == 1)
			{
				return packs.FindAll((string v) => !v.EndsWith("_0"));
			}
			if (gender == 0)
			{
				return packs.FindAll((string v) => !v.EndsWith("_1"));
			}
			return packs;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000377EC File Offset: 0x000359EC
		public HashSet<int> GetUnusedVideos(HashSet<int> finishedQuests)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int key in finishedQuests)
			{
				List<int> list;
				if (this.QuestRefCommonVideos.TryGetValue(key, out list))
				{
					foreach (int item in list)
					{
						hashSet.Add(item);
					}
				}
				List<int> list2;
				if (this.QuestRefMaleVideos.TryGetValue(key, out list2))
				{
					foreach (int item2 in list2)
					{
						hashSet.Add(item2);
					}
				}
				List<int> list3;
				if (this.QuestRefFemaleVideos.TryGetValue(key, out list3))
				{
					foreach (int item3 in list3)
					{
						hashSet.Add(item3);
					}
				}
			}
			HashSet<int> unFinishedVideos = this.GetUnFinishedVideos(finishedQuests);
			HashSet<int> hashSet2 = new HashSet<int>();
			foreach (int item4 in hashSet)
			{
				if (!unFinishedVideos.Contains(item4))
				{
					hashSet2.Add(item4);
				}
			}
			LauncherLog.Instance.Info("不再需要的视频列表: " + string.Join<int>(",", hashSet2), default(ReadOnlySpan<ValueTuple<string, object>>));
			return hashSet2;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000379BC File Offset: 0x00035BBC
		public List<int> FilterVideoByFinishedQuest(IReadOnlyList<int> videoIds, HashSet<int> finishedQuests)
		{
			HashSet<int> unFinishedVideos = this.GetUnFinishedVideos(finishedQuests);
			List<int> list = new List<int>();
			foreach (int item in videoIds)
			{
				if (unFinishedVideos.Contains(item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00037A1C File Offset: 0x00035C1C
		private HashSet<int> GetUnFinishedVideos([Nullable(2)] HashSet<int> finishedQuests = null)
		{
			HashSet<int> hashSet = finishedQuests ?? new HashSet<int>();
			HashSet<int> hashSet2 = new HashSet<int>();
			foreach (KeyValuePair<int, List<int>> keyValuePair in this.QuestRefCommonVideos)
			{
				if (!hashSet.Contains(keyValuePair.Key))
				{
					foreach (int item in keyValuePair.Value)
					{
						hashSet2.Add(item);
					}
				}
			}
			foreach (KeyValuePair<int, List<int>> keyValuePair2 in this.QuestRefMaleVideos)
			{
				if (!hashSet.Contains(keyValuePair2.Key))
				{
					foreach (int item2 in keyValuePair2.Value)
					{
						hashSet2.Add(item2);
					}
				}
			}
			foreach (KeyValuePair<int, List<int>> keyValuePair3 in this.QuestRefFemaleVideos)
			{
				if (!hashSet.Contains(keyValuePair3.Key))
				{
					foreach (int item3 in keyValuePair3.Value)
					{
						hashSet2.Add(item3);
					}
				}
			}
			LauncherLog.Instance.Info("所有未完成任务引用视频列表: " + string.Join<int>(",", hashSet2), default(ReadOnlySpan<ValueTuple<string, object>>));
			return hashSet2;
		}

		// Token: 0x040003D6 RID: 982
		private const long MB_SIZE = 1048576L;

		// Token: 0x040003D7 RID: 983
		private readonly Dictionary<int, List<int>> QuestRefMaleVideos = new Dictionary<int, List<int>>();

		// Token: 0x040003D8 RID: 984
		private readonly Dictionary<int, List<int>> QuestRefFemaleVideos = new Dictionary<int, List<int>>();

		// Token: 0x040003D9 RID: 985
		private readonly Dictionary<int, List<int>> QuestRefCommonVideos = new Dictionary<int, List<int>>();

		// Token: 0x040003DA RID: 986
		private bool Inited;
	}
}
