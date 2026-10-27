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
	// Token: 0x020000AD RID: 173
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoResourceModule : BaseResourceModule
	{
		// Token: 0x060005F2 RID: 1522 RVA: 0x000351B4 File Offset: 0x000333B4
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

		// Token: 0x060005F3 RID: 1523 RVA: 0x00035328 File Offset: 0x00033528
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

		// Token: 0x060005F4 RID: 1524 RVA: 0x0003536C File Offset: 0x0003356C
		public override PackClassification ClassifyPacks(ResourceSelectionContext context, ETier tier = ETier.None, bool forceMax = false)
		{
			LauncherStorageLib.Instance.DeleteGlobal(ELauncherStorageGlobalKey.UserFinishedVideoList);
			if (!VideoResUpdate.Instance.GetIsSeparateVideo())
			{
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
				if (videoResPackageInfo != null)
				{
					LauncherLog instance = LauncherLog.Instance;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Optional package 视频资源大小: Max: ");
					defaultInterpolatedStringHandler.AppendFormatted<double>((double)num / 1048576.0);
					defaultInterpolatedStringHandler.AppendLiteral(" MB");
					instance.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
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
				return new PackClassification
				{
					MinPacks = list2,
					MaxPacks = list2,
					MinSize = num,
					MaxSize = num
				};
			}
			HashSet<int> hashSet;
			int gender;
			if (VideoResUpdate.Instance.IsVideoClearGrayBoxHit())
			{
				hashSet = this.GetCoreVideoIds(context);
				LauncherStorageLib.Instance.SetGlobal<HashSet<int>>(ELauncherStorageGlobalKey.UserFinishedVideoList, hashSet);
				gender = context.Gender;
			}
			else
			{
				hashSet = unFinishedVideos;
				gender = -1;
			}
			VideoResPackageInfo videoResPackageInfo2 = this.BuildVideoPackInfo(hashSet, gender, tier);
			long num2 = (videoResPackageInfo2 != null) ? videoResPackageInfo2.AnalyzeRequireFiles(false, tier).Item3 : 0L;
			if (videoResPackageInfo2 != null || videoResPackageInfo != null)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Optional package 视频资源大小: Max: ");
				defaultInterpolatedStringHandler.AppendFormatted<double>((double)num / 1048576.0);
				defaultInterpolatedStringHandler.AppendLiteral(" MB, Min: ");
				defaultInterpolatedStringHandler.AppendFormatted<double>((double)num2 / 1048576.0);
				defaultInterpolatedStringHandler.AppendLiteral(" MB");
				instance2.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
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
			packClassification.MinSize = num2;
			packClassification.MaxSize = num;
			return packClassification;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0003559C File Offset: 0x0003379C
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

		// Token: 0x060005F6 RID: 1526 RVA: 0x00035644 File Offset: 0x00033844
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

		// Token: 0x060005F7 RID: 1527 RVA: 0x0003566C File Offset: 0x0003386C
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
			List<int> list = this.EvaluateRecommendVideoQuestIds(context.FinishedQuests);
			if (list.Count > 0)
			{
				LauncherLog.Instance.Info("依据关键任务完成度推荐视频任务列表: " + string.Join<int>(",", list), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
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

		// Token: 0x060005F8 RID: 1528 RVA: 0x00035874 File Offset: 0x00033A74
		private List<int> EvaluateRecommendVideoQuestIds(HashSet<int> finishedQuests)
		{
			List<int> list = new List<int>();
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
						foreach (int item3 in recommendPackRow.VideoQuestId)
						{
							list.Add(item3);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000359BC File Offset: 0x00033BBC
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

		// Token: 0x060005FA RID: 1530 RVA: 0x00035AD8 File Offset: 0x00033CD8
		public override void Delete(IReadOnlyList<string> pakNames)
		{
			base.DegradeToMinPack();
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

		// Token: 0x060005FB RID: 1531 RVA: 0x00035B68 File Offset: 0x00033D68
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

		// Token: 0x060005FC RID: 1532 RVA: 0x00035C04 File Offset: 0x00033E04
		public void DeleteByVideoIds(HashSet<int> videoIds)
		{
			LauncherLog.Instance.Info("Optional package 按视频ID卸载, videoIds: " + string.Join<int>(",", videoIds), default(ReadOnlySpan<ValueTuple<string, object>>));
			List<int> videoIds2 = new List<int>(videoIds);
			List<string> videoResPakByVideoIds = VideoResUpdate.Instance.GetVideoResPakByVideoIds(videoIds2, null);
			this.Delete(videoResPakByVideoIds);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00035C5C File Offset: 0x00033E5C
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

		// Token: 0x060005FE RID: 1534 RVA: 0x00035CF8 File Offset: 0x00033EF8
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

		// Token: 0x060005FF RID: 1535 RVA: 0x00035D5C File Offset: 0x00033F5C
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

		// Token: 0x06000600 RID: 1536 RVA: 0x00035F2C File Offset: 0x0003412C
		public List<int> FilterVideoByFinishedQuest(List<int> videoIds, HashSet<int> finishedQuests)
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

		// Token: 0x06000601 RID: 1537 RVA: 0x00035F94 File Offset: 0x00034194
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

		// Token: 0x040003A8 RID: 936
		private const long MB_SIZE = 1048576L;

		// Token: 0x040003A9 RID: 937
		private readonly Dictionary<int, List<int>> QuestRefMaleVideos = new Dictionary<int, List<int>>();

		// Token: 0x040003AA RID: 938
		private readonly Dictionary<int, List<int>> QuestRefFemaleVideos = new Dictionary<int, List<int>>();

		// Token: 0x040003AB RID: 939
		private readonly Dictionary<int, List<int>> QuestRefCommonVideos = new Dictionary<int, List<int>>();

		// Token: 0x040003AC RID: 940
		private bool Inited;
	}
}
