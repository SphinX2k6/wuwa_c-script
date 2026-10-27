using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update.ResourceDiffUpdate.Config;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Module
{
	// Token: 0x020000AC RID: 172
	[NullableContext(1)]
	[Nullable(0)]
	public class BlockResourceModule : BaseResourceModule
	{
		// Token: 0x060005E4 RID: 1508 RVA: 0x00033D38 File Offset: 0x00031F38
		[NullableContext(0)]
		public override UniTask<bool> PrepareManifests()
		{
			BlockResourceModule.<PrepareManifests>d__1 <PrepareManifests>d__;
			<PrepareManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PrepareManifests>d__.<>4__this = this;
			<PrepareManifests>d__.<>1__state = -1;
			<PrepareManifests>d__.<>t__builder.Start<BlockResourceModule.<PrepareManifests>d__1>(ref <PrepareManifests>d__);
			return <PrepareManifests>d__.<>t__builder.Task;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00033D7C File Offset: 0x00031F7C
		public unsafe override PackClassification ClassifyPacks(ResourceSelectionContext context, ETier tier = ETier.None, bool forceMax = false)
		{
			List<ResPackageInfo> list = new List<ResPackageInfo>();
			long num = 0L;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			foreach (KeyValuePair<string, ResPackageInfo> keyValuePair in ResPackageInfo.OptionalDownLoadInfo)
			{
				string key = keyValuePair.Key;
				ResPackageInfo value = keyValuePair.Value;
				ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> valueTuple = value.AnalyzeRequireFiles(false, tier);
				List<RequireFileInfo> item = valueTuple.Item1;
				long item2 = valueTuple.Item7;
				int item3 = valueTuple.Rest.Item2;
				long num2 = 0L;
				foreach (RequireFileInfo requireFileInfo in item)
				{
					num2 += requireFileInfo.Size;
				}
				list.Add(value);
				num += num2;
				LauncherLog instance = LauncherLog.Instance;
				string message = "Optional package.";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("地块资源包:", key);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item4 = "needSize:";
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendFormatted<long>(num2 / 1048576L);
				defaultInterpolatedStringHandler.AppendLiteral(" MB");
				ptr = new ValueTuple<string, object>(item4, defaultInterpolatedStringHandler.ToStringAndClear());
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item5 = "needSpace:";
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendFormatted<long>(item2 / 1048576L);
				defaultInterpolatedStringHandler.AppendLiteral(" MB");
				ptr2 = new ValueTuple<string, object>(item5, defaultInterpolatedStringHandler.ToStringAndClear());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("space.count", item3);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("requires.count", item.Count);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			}
			if (forceMax)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "Optional package 地图资源大小(forceMax)";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
				string item6 = "maxSize";
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendFormatted<long>(num / 1048576L);
				defaultInterpolatedStringHandler.AppendLiteral(" MB");
				ptr3 = new ValueTuple<string, object>(item6, defaultInterpolatedStringHandler.ToStringAndClear());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("maxPacks.count", list.Count);
				instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return new PackClassification
				{
					MinPacks = list,
					MaxPacks = list,
					MinSize = num,
					MaxSize = num
				};
			}
			HashSet<int> coreBlockIds = this.GetCoreBlockIds(context);
			HashSet<string> hashSet = new HashSet<string>();
			foreach (int num3 in coreBlockIds)
			{
				MapBlockInfoRow byId = PackSelectionTables.MapBlockInfoTableInstance.GetById(num3);
				if (byId != null)
				{
					hashSet.Add(byId.PackName);
				}
				else
				{
					LauncherLog instance3 = LauncherLog.Instance;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Optional package 地块ID不存在: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
					instance3.Warn(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			LauncherLog.Instance.Info("Optional package 核心包PackName列表: " + string.Join(",", hashSet), default(ReadOnlySpan<ValueTuple<string, object>>));
			List<ResPackageInfo> list2 = new List<ResPackageInfo>();
			long num4 = 0L;
			foreach (KeyValuePair<string, ResPackageInfo> keyValuePair2 in ResPackageInfo.OptionalDownLoadInfo)
			{
				string key2 = keyValuePair2.Key;
				ResPackageInfo value2 = keyValuePair2.Value;
				List<RequireFileInfo> item7 = value2.AnalyzeRequireFiles(false, tier).Item1;
				long num5 = 0L;
				foreach (RequireFileInfo requireFileInfo2 in item7)
				{
					num5 += requireFileInfo2.Size;
				}
				if (hashSet.Contains(key2))
				{
					list2.Add(value2);
					num4 += num5;
				}
				else if (value2.ResourceVersionInfo.RecordVersion != null && value2.ResourceVersionInfo.RecordVersion != "")
				{
					list2.Add(value2);
					num4 += num5;
					LauncherLog.Instance.Info("Optional package 已经下载过的地块资源包 " + key2 + ", 会自动参与更新.", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			LauncherLog instance4 = LauncherLog.Instance;
			string message3 = "Optional package 地图资源大小";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0);
			string item8 = "minSize";
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendFormatted<long>(num4 / 1048576L);
			defaultInterpolatedStringHandler.AppendLiteral(" MB");
			ptr4 = new ValueTuple<string, object>(item8, defaultInterpolatedStringHandler.ToStringAndClear());
			ref ValueTuple<string, object> ptr5 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
			string item9 = "maxSize";
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendFormatted<long>(num / 1048576L);
			defaultInterpolatedStringHandler.AppendLiteral(" MB");
			ptr5 = new ValueTuple<string, object>(item9, defaultInterpolatedStringHandler.ToStringAndClear());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("minPacks.count", list2.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("maxPacks.count", list.Count);
			instance4.Info(message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
			return new PackClassification
			{
				MinPacks = list2,
				MaxPacks = list,
				MinSize = num4,
				MaxSize = num
			};
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00034348 File Offset: 0x00032548
		[NullableContext(0)]
		private UniTask<bool> AnalysisBlockPackManifests([Nullable(1)] List<ResPackageInfo> resPackageInfos)
		{
			BlockResourceModule.<AnalysisBlockPackManifests>d__3 <AnalysisBlockPackManifests>d__;
			<AnalysisBlockPackManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<AnalysisBlockPackManifests>d__.resPackageInfos = resPackageInfos;
			<AnalysisBlockPackManifests>d__.<>1__state = -1;
			<AnalysisBlockPackManifests>d__.<>t__builder.Start<BlockResourceModule.<AnalysisBlockPackManifests>d__3>(ref <AnalysisBlockPackManifests>d__);
			return <AnalysisBlockPackManifests>d__.<>t__builder.Task;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0003438C File Offset: 0x0003258C
		public HashSet<int> GetCoreBlockIds(ResourceSelectionContext context)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int item in this.GetLoginBlockIds(context))
			{
				hashSet.Add(item);
			}
			foreach (int item2 in this.GetForceDownloadBlockIds())
			{
				hashSet.Add(item2);
			}
			foreach (int item3 in this.GetRecommendBlockIds(context))
			{
				hashSet.Add(item3);
			}
			LauncherLog.Instance.Info("最终核心包地块列表: " + string.Join<int>(",", hashSet), default(ReadOnlySpan<ValueTuple<string, object>>));
			return hashSet;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0003449C File Offset: 0x0003269C
		private HashSet<int> GetLoginBlockIds(ResourceSelectionContext context)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (ResourcePackagePositionData resourcePackagePositionData in context.Positions)
			{
				int mapBlockFromPosition = this.GetMapBlockFromPosition(resourcePackagePositionData.instanceId, resourcePackagePositionData.x, resourcePackagePositionData.y);
				if (mapBlockFromPosition >= 0)
				{
					hashSet.Add(mapBlockFromPosition);
					LauncherLog instance = LauncherLog.Instance;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 4);
					defaultInterpolatedStringHandler.AppendLiteral("登陆位置 instanceId:");
					defaultInterpolatedStringHandler.AppendFormatted<int>(resourcePackagePositionData.instanceId);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted<double>(resourcePackagePositionData.x);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<double>(resourcePackagePositionData.y);
					defaultInterpolatedStringHandler.AppendLiteral(" 依赖地块: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(mapBlockFromPosition);
					instance.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				DungeonPackInfoRow byId = PackSelectionTables.DungeonPackInfoTableInstance.GetById(resourcePackagePositionData.instanceId);
				if (byId != null && byId.ReachableBlockIds.Count > 0)
				{
					foreach (int item in byId.ReachableBlockIds)
					{
						hashSet.Add(item);
					}
					LauncherLog instance2 = LauncherLog.Instance;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
					defaultInterpolatedStringHandler.AppendLiteral("登陆位置 instanceId:");
					defaultInterpolatedStringHandler.AppendFormatted<int>(resourcePackagePositionData.instanceId);
					defaultInterpolatedStringHandler.AppendLiteral(" 副本可达地块: ");
					defaultInterpolatedStringHandler.AppendFormatted(string.Join<int>(",", byId.ReachableBlockIds));
					instance2.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			foreach (int num in context.CurrentBlockIds)
			{
				hashSet.Add(num);
				LauncherLog instance3 = LauncherLog.Instance;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("登陆依赖地块: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				instance3.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			foreach (int num2 in context.ActiveQuestIds)
			{
				QuestRefMapBlockRow byId2 = PackSelectionTables.QuestRefMapBlockTableInstance.GetById(num2);
				if (byId2 != null)
				{
					foreach (int item2 in byId2.MapBlockId)
					{
						hashSet.Add(item2);
					}
					LauncherLog instance4 = LauncherLog.Instance;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
					defaultInterpolatedStringHandler.AppendLiteral("任务 ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
					defaultInterpolatedStringHandler.AppendLiteral(" 依赖地块: ");
					defaultInterpolatedStringHandler.AppendFormatted(string.Join<int>(",", byId2.MapBlockId));
					instance4.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			HashSet<int> hashSet2 = new HashSet<int>();
			List<DownLoadSubPackageRow> all = PackSelectionTables.DownLoadSubPackageTableInstance.GetAll();
			Dictionary<int, DownLoadSubPackageRow> dictionary = new Dictionary<int, DownLoadSubPackageRow>();
			foreach (DownLoadSubPackageRow downLoadSubPackageRow in all)
			{
				foreach (int key in downLoadSubPackageRow.Area)
				{
					dictionary[key] = downLoadSubPackageRow;
				}
			}
			foreach (int num3 in hashSet)
			{
				DownLoadSubPackageRow downLoadSubPackageRow2;
				if (dictionary.TryGetValue(num3, out downLoadSubPackageRow2))
				{
					foreach (int item3 in downLoadSubPackageRow2.Area)
					{
						hashSet2.Add(item3);
					}
					LauncherLog instance5 = LauncherLog.Instance;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
					defaultInterpolatedStringHandler.AppendLiteral("地块 ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
					defaultInterpolatedStringHandler.AppendLiteral(" 属于地块组 ");
					defaultInterpolatedStringHandler.AppendFormatted(string.Join<int>(",", downLoadSubPackageRow2.Area));
					instance5.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else
				{
					hashSet2.Add(num3);
				}
			}
			LauncherLog.Instance.Info("依据登陆数据进核心包地块: " + string.Join<int>(",", hashSet2), default(ReadOnlySpan<ValueTuple<string, object>>));
			return hashSet2;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00034A28 File Offset: 0x00032C28
		private HashSet<int> GetForceDownloadBlockIds()
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (DownLoadSubPackageRow downLoadSubPackageRow in PackSelectionTables.DownLoadSubPackageTableInstance.GetAll())
			{
				if (downLoadSubPackageRow.BelongKey)
				{
					LauncherLog.Instance.Info("下载条目配置强制进核心包地块: " + string.Join<int>(",", downLoadSubPackageRow.Area), default(ReadOnlySpan<ValueTuple<string, object>>));
					foreach (int item in downLoadSubPackageRow.Area)
					{
						hashSet.Add(item);
					}
				}
			}
			return hashSet;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00034AFC File Offset: 0x00032CFC
		private HashSet<int> GetRecommendBlockIds(ResourceSelectionContext context)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int num in this.EvaluateRecommendSubPackageIds(context.FinishedQuests))
			{
				DownLoadSubPackageRow byId = PackSelectionTables.DownLoadSubPackageTableInstance.GetById(num);
				if (byId == null)
				{
					LauncherLog instance = LauncherLog.Instance;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
					defaultInterpolatedStringHandler.AppendLiteral("关键任务完成度配置中资源包ID不存在: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					instance.Warn(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else
				{
					foreach (int item in byId.Area)
					{
						hashSet.Add(item);
					}
				}
			}
			if (hashSet.Count > 0)
			{
				LauncherLog.Instance.Info("依据关键任务完成度进核心包地块: " + string.Join<int>(",", hashSet), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return hashSet;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00034C20 File Offset: 0x00032E20
		private List<int> EvaluateRecommendSubPackageIds(HashSet<int> finishedQuests)
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
						foreach (int item3 in recommendPackRow.Source)
						{
							list.Add(item3);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00034D68 File Offset: 0x00032F68
		public int GetMapBlockFromPosition(int mapId, double x, double y)
		{
			List<MapBlockInfoRow> all = PackSelectionTables.MapBlockInfoTableInstance.GetAll();
			List<MapBlockInfoRow> list = new List<MapBlockInfoRow>();
			foreach (MapBlockInfoRow mapBlockInfoRow in all)
			{
				if (mapBlockInfoRow.MapId == mapId)
				{
					list.Add(mapBlockInfoRow);
				}
			}
			if (list.Count != 0)
			{
				int result = -1;
				foreach (MapBlockInfoRow mapBlockInfoRow2 in list)
				{
					List<Vector2D> regionBoxes = mapBlockInfoRow2.RegionBoxes;
					if (regionBoxes.Count == 0)
					{
						result = mapBlockInfoRow2.BlockId;
					}
					else
					{
						for (int i = 0; i < regionBoxes.Count; i += 2)
						{
							Vector2D vector2D = regionBoxes[i];
							Vector2D vector2D2 = regionBoxes[i + 1];
							if (x >= (double)vector2D.X && x <= (double)vector2D2.X && y >= (double)vector2D.Y && y <= (double)vector2D2.Y)
							{
								return mapBlockInfoRow2.BlockId;
							}
						}
					}
				}
				return result;
			}
			DungeonPackInfoRow byId = PackSelectionTables.DungeonPackInfoTableInstance.GetById(mapId);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (byId != null && byId.OwnerBlockIds.Count == 1)
			{
				int num = byId.OwnerBlockIds[0];
				LauncherLog instance = LauncherLog.Instance;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
				defaultInterpolatedStringHandler.AppendLiteral("MapId ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(mapId);
				defaultInterpolatedStringHandler.AppendLiteral(" 为副本，所在地块ID: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				instance.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return num;
			}
			LauncherLog instance2 = LauncherLog.Instance;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
			defaultInterpolatedStringHandler.AppendLiteral("No map block info found for MapId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(mapId);
			instance2.Warn(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return -1;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00034F58 File Offset: 0x00033158
		public override void Delete(IReadOnlyList<string> pakNames)
		{
			base.DegradeToMinPack();
			foreach (string text in pakNames)
			{
				ResPackageInfo resPackageInfo2;
				ResPackageInfo resPackageInfo = ResPackageInfo.OptionalDownLoadInfo.TryGetValue(text, out resPackageInfo2) ? resPackageInfo2 : null;
				if (resPackageInfo != null)
				{
					resPackageInfo.DeleteLocalFiles();
					resPackageInfo.ClearRecord();
					using (List<ResPackageInfo>.Enumerator enumerator2 = resPackageInfo.GetAllTierPackageInfos().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							ResPackageInfo resPackageInfo3 = enumerator2.Current;
							resPackageInfo3.DeleteLocalFiles();
							resPackageInfo3.ClearRecord();
						}
						continue;
					}
				}
				LauncherLog.Instance.Warn("Optional package 卸载地块时未找到资源包信息: " + text, default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00035030 File Offset: 0x00033230
		public override long GetLocalSize(IReadOnlyList<string> pakNames)
		{
			long num = 0L;
			foreach (string text in pakNames)
			{
				ResPackageInfo resPackageInfo2;
				ResPackageInfo resPackageInfo = ResPackageInfo.OptionalDownLoadInfo.TryGetValue(text, out resPackageInfo2) ? resPackageInfo2 : null;
				if (resPackageInfo != null)
				{
					long item = resPackageInfo.AnalyzeRequireFiles(false, RemoteInfo.Instance.ActiveTier).Rest.Item1;
					num += item;
				}
				else
				{
					LauncherLog.Instance.Warn("Optional package 获取地块资源大小时未找到资源包信息: " + text, default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			return num;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000350D0 File Offset: 0x000332D0
		[NullableContext(2)]
		public string GetBlockPackName(int blockId)
		{
			MapBlockInfoRow byId = PackSelectionTables.MapBlockInfoTableInstance.GetById(blockId);
			if (byId != null)
			{
				return byId.PackName;
			}
			LauncherLog instance = LauncherLog.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Optional package 获取地块资源包时未找到地块信息: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(blockId);
			instance.Warn(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0003512C File Offset: 0x0003332C
		public bool IsAllBlockResourceDownloaded()
		{
			foreach (ResPackageInfo resPackageInfo in ResPackageInfo.OptionalDownLoadInfo.Values)
			{
				if (!resPackageInfo.IsCompleteDownload())
				{
					return false;
				}
				ResPackageInfo tierPackageInfo = resPackageInfo.GetTierPackageInfo(RemoteInfo.Instance.ActiveTier);
				if (tierPackageInfo != null && !tierPackageInfo.IsCompleteDownload())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040003A7 RID: 935
		private const long MB_SIZE = 1048576L;
	}
}
