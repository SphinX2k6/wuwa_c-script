using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059F2 RID: 23026
	[NullableContext(1)]
	[Nullable(0)]
	public static class SolarSchoolQuestTreeBuilder
	{
		// Token: 0x06038B73 RID: 232307 RVA: 0x00FDF5D0 File Offset: 0x00FDD7D0
		public static List<SolarSchoolQuestColumnData> Build(int activityId)
		{
			Dictionary<int, List<int>> dictionary = SolarSchoolQuestTreeBuilder.CollectDisplayQuests(activityId);
			if (dictionary.Count == 0)
			{
				return new List<SolarSchoolQuestColumnData>();
			}
			Dictionary<int, int> columnIndexMap = SolarSchoolQuestTreeBuilder.CalcColumnIndex(dictionary);
			List<SolarSchoolQuestColumnData> list = SolarSchoolQuestTreeBuilder.GroupByColumn(columnIndexMap);
			SolarSchoolQuestTreeBuilder.FillLines(list, dictionary, columnIndexMap);
			return list;
		}

		// Token: 0x06038B74 RID: 232308 RVA: 0x00FDF608 File Offset: 0x00FDD808
		private static Dictionary<int, List<int>> CollectDisplayQuests(int activityId)
		{
			SolarSchoolQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData;
			Dictionary<int, List<int>> parentMap = new Dictionary<int, List<int>>();
			foreach (SolarSchoolQuest solarSchoolQuest in SolarSchoolConfig.Instance.GetQuestListByActivityId(activityId))
			{
				SolarSchoolSingleQuestData questData2 = questData.GetQuestData(solarSchoolQuest.Id);
				if (questData2 == null || questData2.IsTree)
				{
					SolarSchoolSingleQuestData questData3 = questData.GetQuestData(solarSchoolQuest.Id);
					if (questData3 != null && questData3.IsShowing)
					{
						parentMap[solarSchoolQuest.Id] = solarSchoolQuest.GetShowParentIdListArray().ToList<int>();
					}
				}
			}
			Predicate<int> <>9__0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in parentMap)
			{
				List<int> value = keyValuePair.Value;
				Predicate<int> match;
				if ((match = <>9__0) == null)
				{
					match = (<>9__0 = ((int parentId) => !parentMap.ContainsKey(parentId)));
				}
				value.RemoveAll(match);
			}
			return parentMap;
		}

		// Token: 0x06038B75 RID: 232309 RVA: 0x00FDF73C File Offset: 0x00FDD93C
		private static Dictionary<int, int> CalcColumnIndex(Dictionary<int, List<int>> parentMap)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			HashSet<int> resolving = new HashSet<int>();
			foreach (int questId in parentMap.Keys)
			{
				SolarSchoolQuestTreeBuilder.ResolveColumnIndex(questId, parentMap, dictionary, resolving);
			}
			return dictionary;
		}

		// Token: 0x06038B76 RID: 232310 RVA: 0x00FDF7A0 File Offset: 0x00FDD9A0
		private static int ResolveColumnIndex(int questId, Dictionary<int, List<int>> parentMap, Dictionary<int, int> columnIndexMap, HashSet<int> resolving)
		{
			int result;
			if (columnIndexMap.TryGetValue(questId, out result))
			{
				return result;
			}
			if (!resolving.Add(questId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool] 任务树 ParentIdList 成环，该节点按根处理";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questId", questId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				columnIndexMap[questId] = 0;
				return 0;
			}
			int num = 0;
			foreach (int questId2 in parentMap[questId])
			{
				int num2 = SolarSchoolQuestTreeBuilder.ResolveColumnIndex(questId2, parentMap, columnIndexMap, resolving);
				if (num2 + 1 > num)
				{
					num = num2 + 1;
				}
			}
			resolving.Remove(questId);
			columnIndexMap[questId] = num;
			return num;
		}

		// Token: 0x06038B77 RID: 232311 RVA: 0x00FDF864 File Offset: 0x00FDDA64
		private static List<SolarSchoolQuestColumnData> GroupByColumn(Dictionary<int, int> columnIndexMap)
		{
			int num = 0;
			foreach (int num2 in columnIndexMap.Values)
			{
				if (num2 > num)
				{
					num = num2;
				}
			}
			List<SolarSchoolQuestColumnData> list = new List<SolarSchoolQuestColumnData>(num + 1);
			for (int i = 0; i <= num; i++)
			{
				list.Add(new SolarSchoolQuestColumnData());
			}
			foreach (KeyValuePair<int, int> keyValuePair in columnIndexMap)
			{
				list[keyValuePair.Value].ArrowList.Add(new SolarSchoolQuestArrowItemData
				{
					QuestId = keyValuePair.Key
				});
			}
			foreach (SolarSchoolQuestColumnData solarSchoolQuestColumnData in list)
			{
				solarSchoolQuestColumnData.ArrowList.Sort(delegate(SolarSchoolQuestArrowItemData a, SolarSchoolQuestArrowItemData b)
				{
					int num3 = SolarSchoolQuestTreeBuilder.GetSort(b.QuestId).CompareTo(SolarSchoolQuestTreeBuilder.GetSort(a.QuestId));
					if (num3 == 0)
					{
						return a.QuestId.CompareTo(b.QuestId);
					}
					return num3;
				});
			}
			return list;
		}

		// Token: 0x06038B78 RID: 232312 RVA: 0x00FDF9A0 File Offset: 0x00FDDBA0
		private static void FillLines(List<SolarSchoolQuestColumnData> columns, Dictionary<int, List<int>> parentMap, Dictionary<int, int> columnIndexMap)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (SolarSchoolQuestColumnData solarSchoolQuestColumnData in columns)
			{
				for (int i = 0; i < solarSchoolQuestColumnData.ArrowList.Count; i++)
				{
					dictionary[solarSchoolQuestColumnData.ArrowList[i].QuestId] = i;
				}
			}
			Dictionary<int, SolarSchoolQuestArrowItemData> dictionary2 = new Dictionary<int, SolarSchoolQuestArrowItemData>();
			foreach (SolarSchoolQuestColumnData solarSchoolQuestColumnData2 in columns)
			{
				foreach (SolarSchoolQuestArrowItemData solarSchoolQuestArrowItemData in solarSchoolQuestColumnData2.ArrowList)
				{
					dictionary2[solarSchoolQuestArrowItemData.QuestId] = solarSchoolQuestArrowItemData;
				}
			}
			foreach (KeyValuePair<int, List<int>> keyValuePair in parentMap)
			{
				int index = columnIndexMap[keyValuePair.Key];
				float num = SolarSchoolQuestTreeBuilder.CalcRowOffset(dictionary[keyValuePair.Key], columns[index].ArrowList.Count);
				foreach (int key in keyValuePair.Value)
				{
					int index2 = columnIndexMap[key];
					float num2 = SolarSchoolQuestTreeBuilder.CalcRowOffset(dictionary[key], columns[index2].ArrowList.Count);
					float num3 = num - num2;
					SolarSchoolQuestArrowItemData solarSchoolQuestArrowItemData2 = dictionary2[key];
					if (num3 < 0f)
					{
						solarSchoolQuestArrowItemData2.HasTopLine = true;
						solarSchoolQuestArrowItemData2.Edges.Add(new SolarSchoolQuestEdgeData(keyValuePair.Key, ESolarSchoolQuestLineMask.Top));
					}
					else if (num3 > 0f)
					{
						solarSchoolQuestArrowItemData2.HasBottomLine = true;
						solarSchoolQuestArrowItemData2.Edges.Add(new SolarSchoolQuestEdgeData(keyValuePair.Key, ESolarSchoolQuestLineMask.Bottom));
					}
					else
					{
						solarSchoolQuestArrowItemData2.HasMiddleLine = true;
						solarSchoolQuestArrowItemData2.Edges.Add(new SolarSchoolQuestEdgeData(keyValuePair.Key, ESolarSchoolQuestLineMask.Middle));
					}
				}
			}
		}

		// Token: 0x06038B79 RID: 232313 RVA: 0x00FDFC50 File Offset: 0x00FDDE50
		private static int GetSort(int questId)
		{
			if (SolarSchoolConfig.Instance.GetQuest(questId) == null)
			{
				return 0;
			}
			SolarSchoolQuest? solarSchoolQuest;
			return solarSchoolQuest.GetValueOrDefault().Sort;
		}

		// Token: 0x06038B7A RID: 232314 RVA: 0x00FDFC83 File Offset: 0x00FDDE83
		private static float CalcRowOffset(int rowIndex, int rowCount)
		{
			return (float)rowIndex - (float)(rowCount - 1) / 2f;
		}
	}
}
