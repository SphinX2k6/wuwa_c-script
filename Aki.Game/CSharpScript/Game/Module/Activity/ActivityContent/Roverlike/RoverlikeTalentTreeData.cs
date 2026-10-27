using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060E3 RID: 24803
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTalentTreeData
	{
		// Token: 0x0603EB52 RID: 256850 RVA: 0x00F2538C File Offset: 0x00F2358C
		public static bool IsSameNode(RoverRogueTalentTree a, RoverRogueTalentTree b)
		{
			return a.Row == b.Row && a.Column == b.Column;
		}

		// Token: 0x0603EB53 RID: 256851 RVA: 0x00F253B0 File Offset: 0x00F235B0
		private static int GetNodeKey(RoverRogueTalentTree config)
		{
			return config.Column * 10000 + config.Row;
		}

		// Token: 0x0603EB54 RID: 256852 RVA: 0x00F253C8 File Offset: 0x00F235C8
		public void PhraseEx(int activityId, int talentPointItemId, RoverRogueActivityData roverData)
		{
			this.ActivityId = activityId;
			this.TalentPointItemId = talentPointItemId;
			if (!this.IsStructureBuilt)
			{
				this.BuildStructure();
				this.IsStructureBuilt = true;
			}
			List<int> activeIds = (roverData.ActiveTalentIdList != null) ? roverData.ActiveTalentIdList.ToList<int>() : new List<int>();
			List<int> unlockIds = (roverData.UnlockTalentIdList != null) ? roverData.UnlockTalentIdList.ToList<int>() : new List<int>();
			this.UpdateTalentStateByServer(activeIds, unlockIds, true);
		}

		// Token: 0x0603EB55 RID: 256853 RVA: 0x00F25438 File Offset: 0x00F23638
		private void BuildStructure()
		{
			this.NodeIdMap.Clear();
			this.NodeList.Clear();
			this.NodeColumnList = new List<List<RoverlikeTalentNodeData>>();
			this.ColumnIndexMap.Clear();
			this.LevelIdToHeadIdMap.Clear();
			this.CurSelectNode = null;
			this.OnClickNode = null;
			IReadOnlyList<RoverRogueTalentTree> talentTreeConfigList = RoverlikeConfig.Instance.GetTalentTreeConfigList();
			if (talentTreeConfigList.Count == 0)
			{
				return;
			}
			Dictionary<int, List<RoverRogueTalentTree>> dictionary = new Dictionary<int, List<RoverRogueTalentTree>>();
			List<int> list = new List<int>();
			foreach (RoverRogueTalentTree roverRogueTalentTree in talentTreeConfigList)
			{
				int nodeKey = RoverlikeTalentTreeData.GetNodeKey(roverRogueTalentTree);
				List<RoverRogueTalentTree> list2;
				if (!dictionary.TryGetValue(nodeKey, out list2))
				{
					list2 = new List<RoverRogueTalentTree>();
					dictionary[nodeKey] = list2;
					list.Add(nodeKey);
				}
				list2.Add(roverRogueTalentTree);
			}
			Dictionary<int, List<RoverlikeTalentNodeData>> columnGroupMap = new Dictionary<int, List<RoverlikeTalentNodeData>>();
			foreach (int key in list)
			{
				List<RoverRogueTalentTree> list3 = dictionary[key];
				list3.Sort(delegate(RoverRogueTalentTree a, RoverRogueTalentTree b)
				{
					if (a.Consule != b.Consule)
					{
						return a.Consule - b.Consule;
					}
					return a.Id - b.Id;
				});
				RoverlikeTalentNodeData roverlikeTalentNodeData = new RoverlikeTalentNodeData(list3);
				this.NodeIdMap[roverlikeTalentNodeData.HeadConfig.Id] = roverlikeTalentNodeData;
				this.NodeList.Add(roverlikeTalentNodeData);
				foreach (RoverRogueTalentTree roverRogueTalentTree2 in list3)
				{
					this.LevelIdToHeadIdMap[roverRogueTalentTree2.Id] = roverlikeTalentNodeData.HeadConfig.Id;
				}
				List<RoverlikeTalentNodeData> list4;
				if (!columnGroupMap.TryGetValue(roverlikeTalentNodeData.HeadConfig.Column, out list4))
				{
					list4 = new List<RoverlikeTalentNodeData>();
					columnGroupMap[roverlikeTalentNodeData.HeadConfig.Column] = list4;
				}
				list4.Add(roverlikeTalentNodeData);
			}
			List<int> list5 = columnGroupMap.Keys.ToList<int>();
			list5.Sort((int a, int b) => a - b);
			this.NodeColumnList = list5.Select(delegate(int col, int index)
			{
				this.ColumnIndexMap[col] = index;
				List<RoverlikeTalentNodeData> list6 = columnGroupMap[col];
				list6.Sort((RoverlikeTalentNodeData a, RoverlikeTalentNodeData b) => a.HeadConfig.Row - b.HeadConfig.Row);
				return list6;
			}).ToList<List<RoverlikeTalentNodeData>>();
			this.NodeList.Sort(delegate(RoverlikeTalentNodeData a, RoverlikeTalentNodeData b)
			{
				if (a.HeadConfig.Column != b.HeadConfig.Column)
				{
					return a.HeadConfig.Column - b.HeadConfig.Column;
				}
				return a.HeadConfig.Row - b.HeadConfig.Row;
			});
			this.BuildRowStructure();
			this.RefreshLineActiveMap();
		}

		// Token: 0x0603EB56 RID: 256854 RVA: 0x00F25728 File Offset: 0x00F23928
		private void BuildRowStructure()
		{
			this.NodeRowMap.Clear();
			this.RowDataList.Clear();
			this.MaxRow = 0;
			foreach (RoverlikeTalentNodeData roverlikeTalentNodeData in this.NodeList)
			{
				List<RoverlikeTalentNodeData> list;
				if (!this.NodeRowMap.TryGetValue(roverlikeTalentNodeData.Row, out list))
				{
					list = new List<RoverlikeTalentNodeData>();
					this.NodeRowMap[roverlikeTalentNodeData.Row] = list;
				}
				list.Add(roverlikeTalentNodeData);
				this.MaxRow = Math.Max(this.MaxRow, roverlikeTalentNodeData.Row);
			}
			foreach (KeyValuePair<int, List<RoverlikeTalentNodeData>> keyValuePair in this.NodeRowMap)
			{
				int key = keyValuePair.Key;
				List<RoverlikeTalentNodeData> value = keyValuePair.Value;
				value.Sort((RoverlikeTalentNodeData a, RoverlikeTalentNodeData b) => a.Index - b.Index);
				this.RowDataList.Add(new RoverlikeTalentTreeNodeRowData(key, value));
			}
			this.RowDataList.Sort((RoverlikeTalentTreeNodeRowData a, RoverlikeTalentTreeNodeRowData b) => a.Row - b.Row);
		}

		// Token: 0x0603EB57 RID: 256855 RVA: 0x00F25890 File Offset: 0x00F23A90
		public void Reset()
		{
			this.CurSelectNode = null;
			this.OnClickNode = null;
		}

		// Token: 0x0603EB58 RID: 256856 RVA: 0x00F258A0 File Offset: 0x00F23AA0
		public int GetColumnIndex(int column)
		{
			int result;
			if (!this.ColumnIndexMap.TryGetValue(column, out result))
			{
				return -1;
			}
			return result;
		}

		// Token: 0x0603EB59 RID: 256857 RVA: 0x00F258C0 File Offset: 0x00F23AC0
		[NullableContext(2)]
		public RoverlikeTalentNodeData GetNodeData(int id)
		{
			RoverlikeTalentNodeData result;
			if (!this.NodeIdMap.TryGetValue(id, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "获取RoverlikeTalentNodeData失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return result;
		}

		// Token: 0x0603EB5A RID: 256858 RVA: 0x00F25910 File Offset: 0x00F23B10
		[NullableContext(2)]
		public RoverlikeTalentNodeData GetDefaultSelectNode()
		{
			RoverlikeTalentNodeData roverlikeTalentNodeData = null;
			RoverlikeTalentNodeData roverlikeTalentNodeData2 = null;
			RoverlikeTalentNodeData roverlikeTalentNodeData3 = null;
			foreach (RoverlikeTalentNodeData roverlikeTalentNodeData4 in this.NodeList)
			{
				if (!roverlikeTalentNodeData4.IsMaxLevel)
				{
					if (!roverlikeTalentNodeData4.IsServerUnlocked)
					{
						if (this.IsCloserToTop(roverlikeTalentNodeData3, roverlikeTalentNodeData4))
						{
							roverlikeTalentNodeData3 = roverlikeTalentNodeData4;
						}
					}
					else
					{
						if (this.IsDeeper(roverlikeTalentNodeData2, roverlikeTalentNodeData4))
						{
							roverlikeTalentNodeData2 = roverlikeTalentNodeData4;
						}
						if (this.IsTalentCanUnlock(roverlikeTalentNodeData4) && this.IsDeeper(roverlikeTalentNodeData, roverlikeTalentNodeData4))
						{
							roverlikeTalentNodeData = roverlikeTalentNodeData4;
						}
					}
				}
			}
			RoverlikeTalentNodeData result;
			if ((result = roverlikeTalentNodeData) == null && (result = roverlikeTalentNodeData2) == null && (result = roverlikeTalentNodeData3) == null)
			{
				if (this.NodeList.Count <= 0)
				{
					return null;
				}
				result = this.NodeList[this.NodeList.Count - 1];
			}
			return result;
		}

		// Token: 0x0603EB5B RID: 256859 RVA: 0x00F259E4 File Offset: 0x00F23BE4
		private bool IsDeeper([Nullable(2)] RoverlikeTalentNodeData current, RoverlikeTalentNodeData candidate)
		{
			if (current == null)
			{
				return true;
			}
			if (candidate.Row == current.Row)
			{
				return candidate.Index < current.Index;
			}
			return candidate.Row > current.Row;
		}

		// Token: 0x0603EB5C RID: 256860 RVA: 0x00F25A16 File Offset: 0x00F23C16
		private bool IsCloserToTop([Nullable(2)] RoverlikeTalentNodeData current, RoverlikeTalentNodeData candidate)
		{
			if (current == null)
			{
				return true;
			}
			if (candidate.Row == current.Row)
			{
				return candidate.Index < current.Index;
			}
			return candidate.Row < current.Row;
		}

		// Token: 0x0603EB5D RID: 256861 RVA: 0x00F25A48 File Offset: 0x00F23C48
		public void SelectNode(RoverlikeTalentNodeData node)
		{
			if (node == null || (this.CurSelectNode != null && this.CurSelectNode.HeadConfig.Id == node.HeadConfig.Id))
			{
				return;
			}
			this.CurSelectNode = node;
		}

		// Token: 0x0603EB5E RID: 256862 RVA: 0x00F25A8B File Offset: 0x00F23C8B
		public int GetTalentCoinNum()
		{
			return RoverlikeModel.Instance.GetCurrency(this.TalentPointItemId);
		}

		// Token: 0x0603EB5F RID: 256863 RVA: 0x00F25A9D File Offset: 0x00F23C9D
		public void UpdateTalentStateByServer(IReadOnlyList<int> activeIds, IReadOnlyList<int> unlockIds, bool needEmit = false)
		{
			this.MergeTalentIds(activeIds, unlockIds);
			this.RecomputeNodeStateFromCache();
			this.RefreshLineActiveMap();
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			}
		}

		// Token: 0x0603EB60 RID: 256864 RVA: 0x00F25ACC File Offset: 0x00F23CCC
		public void UpdateUnlockTalentIds(IReadOnlyList<int> unlockIds, bool needEmit = true)
		{
			this.MergeTalentIds(new List<int>(), unlockIds);
			this.RecomputeNodeStateFromCache();
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			}
		}

		// Token: 0x0603EB61 RID: 256865 RVA: 0x00F25AFC File Offset: 0x00F23CFC
		private void MergeTalentIds(IReadOnlyList<int> activeIds, IReadOnlyList<int> unlockIds)
		{
			foreach (int item in activeIds)
			{
				this.ActivatedTalentIdSet.Add(item);
				this.UnlockedTalentIdSet.Add(item);
			}
			foreach (int item2 in unlockIds)
			{
				this.UnlockedTalentIdSet.Add(item2);
			}
		}

		// Token: 0x0603EB62 RID: 256866 RVA: 0x00F25B94 File Offset: 0x00F23D94
		private void RecomputeNodeStateFromCache()
		{
			foreach (RoverlikeTalentNodeData roverlikeTalentNodeData in this.NodeIdMap.Values)
			{
				int num = 0;
				bool flag = false;
				foreach (RoverRogueTalentTree roverRogueTalentTree in roverlikeTalentNodeData.LevelConfigs)
				{
					if (this.ActivatedTalentIdSet.Contains(roverRogueTalentTree.Id))
					{
						num++;
					}
					if (this.UnlockedTalentIdSet.Contains(roverRogueTalentTree.Id))
					{
						flag = true;
					}
				}
				roverlikeTalentNodeData.CurLevel = num;
				roverlikeTalentNodeData.ActiveLevel = num;
				roverlikeTalentNodeData.IsServerUnlocked = flag;
				roverlikeTalentNodeData.IsFinishPreCondition = flag;
			}
		}

		// Token: 0x0603EB63 RID: 256867 RVA: 0x00F25C74 File Offset: 0x00F23E74
		public string GetTalentProgress()
		{
			int num = 0;
			using (List<RoverlikeTalentNodeData>.Enumerator enumerator = this.NodeList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsMaxLevel)
					{
						num++;
					}
				}
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.NodeList.Count);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0603EB64 RID: 256868 RVA: 0x00F25D04 File Offset: 0x00F23F04
		public bool IsPreNodeAllUnlock(RoverlikeTalentNodeData node)
		{
			RoverRogueTalentTree headConfig = node.HeadConfig;
			for (int i = 0; i < headConfig.PostIdLength; i++)
			{
				int key = headConfig.PostId(i);
				RoverlikeTalentNodeData roverlikeTalentNodeData;
				if (this.NodeIdMap.TryGetValue(key, out roverlikeTalentNodeData) && !roverlikeTalentNodeData.IsMaxLevel)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603EB65 RID: 256869 RVA: 0x00F25D4E File Offset: 0x00F23F4E
		public bool IsTalentCanUnlock(RoverlikeTalentNodeData node)
		{
			return !node.IsMaxLevel && node.IsServerUnlocked && this.GetTalentCoinNum() >= node.NextLevelCost;
		}

		// Token: 0x0603EB66 RID: 256870 RVA: 0x00F25D78 File Offset: 0x00F23F78
		public bool IsTalentTreeHasRedDot()
		{
			foreach (RoverlikeTalentNodeData node in this.NodeList)
			{
				if (this.IsTalentCanUnlock(node))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603EB67 RID: 256871 RVA: 0x00F25DD4 File Offset: 0x00F23FD4
		public void UpdateTalentLevelByActivatedIds(IReadOnlyList<int> activatedLevelIds, bool needEmit = false)
		{
			foreach (RoverlikeTalentNodeData roverlikeTalentNodeData in this.NodeIdMap.Values)
			{
				roverlikeTalentNodeData.CurLevel = 0;
			}
			HashSet<int> hashSet = new HashSet<int>(activatedLevelIds);
			foreach (RoverlikeTalentNodeData roverlikeTalentNodeData2 in this.NodeIdMap.Values)
			{
				int num = 0;
				foreach (RoverRogueTalentTree roverRogueTalentTree in roverlikeTalentNodeData2.LevelConfigs)
				{
					if (hashSet.Contains(roverRogueTalentTree.Id))
					{
						num++;
					}
				}
				roverlikeTalentNodeData2.CurLevel = num;
			}
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			}
		}

		// Token: 0x0603EB68 RID: 256872 RVA: 0x00F25EE4 File Offset: 0x00F240E4
		public bool LocalUnlockNextTalentLevel(int headTalentId)
		{
			RoverlikeTalentNodeData roverlikeTalentNodeData;
			if (!this.NodeIdMap.TryGetValue(headTalentId, out roverlikeTalentNodeData) || roverlikeTalentNodeData.IsMaxLevel)
			{
				return false;
			}
			int nextLevelId = roverlikeTalentNodeData.NextLevelId;
			if (nextLevelId > 0)
			{
				this.ActivatedTalentIdSet.Add(nextLevelId);
				this.UnlockedTalentIdSet.Add(nextLevelId);
			}
			roverlikeTalentNodeData.CurLevel++;
			roverlikeTalentNodeData.IsServerUnlocked = true;
			this.RefreshLineActiveMap();
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			return true;
		}

		// Token: 0x0603EB69 RID: 256873 RVA: 0x00F25F64 File Offset: 0x00F24164
		private List<RoverlikeTalentNodeData> GetPreNodes(RoverlikeTalentNodeData node)
		{
			List<RoverlikeTalentNodeData> list = new List<RoverlikeTalentNodeData>();
			RoverRogueTalentTree headConfig = node.HeadConfig;
			for (int i = 0; i < headConfig.PostIdLength; i++)
			{
				int num = headConfig.PostId(i);
				int num2;
				int key = this.LevelIdToHeadIdMap.TryGetValue(num, out num2) ? num2 : num;
				RoverlikeTalentNodeData item;
				if (this.NodeIdMap.TryGetValue(key, out item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0603EB6A RID: 256874 RVA: 0x00F25FCC File Offset: 0x00F241CC
		[return: TupleElementNames(new string[]
		{
			"Row",
			"Index"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		private List<ValueTuple<int, int>> GetPath(RoverlikeTalentNodeData from, RoverlikeTalentNodeData to)
		{
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			for (int i = from.Row + 1; i < to.Row; i++)
			{
				list.Add(new ValueTuple<int, int>(i, to.Index + 6));
			}
			list.Add(new ValueTuple<int, int>(from.Row, from.Index + 12));
			list.Add(new ValueTuple<int, int>(to.Row, to.Index));
			int num = Math.Max(from.Index, to.Index);
			for (int j = Math.Min(from.Index, to.Index); j < num; j++)
			{
				list.Add(new ValueTuple<int, int>(from.Row, j + 18));
			}
			return list;
		}

		// Token: 0x0603EB6B RID: 256875 RVA: 0x00F26080 File Offset: 0x00F24280
		private bool GetPathActive(RoverlikeTalentNodeData a, RoverlikeTalentNodeData b)
		{
			return a.IsMaxLevel && b.IsMaxLevel;
		}

		// Token: 0x0603EB6C RID: 256876 RVA: 0x00F26094 File Offset: 0x00F24294
		public void RefreshLineActiveMap()
		{
			foreach (Dictionary<int, bool> dictionary in this.LineActiveMap)
			{
				if (dictionary != null)
				{
					dictionary.Clear();
				}
			}
			foreach (RoverlikeTalentNodeData roverlikeTalentNodeData in this.NodeList)
			{
				foreach (RoverlikeTalentNodeData roverlikeTalentNodeData2 in this.GetPreNodes(roverlikeTalentNodeData))
				{
					RoverlikeTalentNodeData roverlikeTalentNodeData3 = (roverlikeTalentNodeData2.Row <= roverlikeTalentNodeData.Row) ? roverlikeTalentNodeData2 : roverlikeTalentNodeData;
					RoverlikeTalentNodeData roverlikeTalentNodeData4 = (roverlikeTalentNodeData2.Row <= roverlikeTalentNodeData.Row) ? roverlikeTalentNodeData : roverlikeTalentNodeData2;
					List<ValueTuple<int, int>> path = this.GetPath(roverlikeTalentNodeData3, roverlikeTalentNodeData4);
					bool pathActive = this.GetPathActive(roverlikeTalentNodeData3, roverlikeTalentNodeData4);
					foreach (ValueTuple<int, int> valueTuple in path)
					{
						int item = valueTuple.Item1;
						int item2 = valueTuple.Item2;
						this.EnsureLineActiveMapSize(item);
						List<Dictionary<int, bool>> lineActiveMap = this.LineActiveMap;
						int index = item;
						if (lineActiveMap[index] == null)
						{
							lineActiveMap[index] = new Dictionary<int, bool>();
						}
						bool flag;
						if (!this.LineActiveMap[item].TryGetValue(item2, out flag) || !flag)
						{
							this.LineActiveMap[item][item2] = pathActive;
						}
					}
				}
			}
		}

		// Token: 0x0603EB6D RID: 256877 RVA: 0x00F26288 File Offset: 0x00F24488
		private void EnsureLineActiveMapSize(int row)
		{
			while (this.LineActiveMap.Count <= row)
			{
				this.LineActiveMap.Add(null);
			}
		}

		// Token: 0x0603EB6E RID: 256878 RVA: 0x00F262A8 File Offset: 0x00F244A8
		public bool IsDotVisible(int row, int index)
		{
			List<RoverlikeTalentNodeData> list;
			if (this.NodeRowMap.TryGetValue(row, out list))
			{
				using (List<RoverlikeTalentNodeData>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Index == index)
						{
							return true;
						}
					}
				}
			}
			List<RoverlikeTalentNodeData> list2;
			if (this.NodeRowMap.TryGetValue(row + 1, out list2))
			{
				using (List<RoverlikeTalentNodeData>.Enumerator enumerator = list2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Index == index)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x04020C79 RID: 134265
		public int ActivityId;

		// Token: 0x04020C7A RID: 134266
		public int TalentPointItemId;

		// Token: 0x04020C7B RID: 134267
		public readonly Dictionary<int, RoverlikeTalentNodeData> NodeIdMap = new Dictionary<int, RoverlikeTalentNodeData>();

		// Token: 0x04020C7C RID: 134268
		public readonly List<RoverlikeTalentNodeData> NodeList = new List<RoverlikeTalentNodeData>();

		// Token: 0x04020C7D RID: 134269
		public List<List<RoverlikeTalentNodeData>> NodeColumnList = new List<List<RoverlikeTalentNodeData>>();

		// Token: 0x04020C7E RID: 134270
		public readonly Dictionary<int, int> ColumnIndexMap = new Dictionary<int, int>();

		// Token: 0x04020C7F RID: 134271
		public readonly Dictionary<int, int> LevelIdToHeadIdMap = new Dictionary<int, int>();

		// Token: 0x04020C80 RID: 134272
		[Nullable(2)]
		public RoverlikeTalentNodeData CurSelectNode;

		// Token: 0x04020C81 RID: 134273
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<bool, RoverlikeTalentNodeData> OnClickNode;

		// Token: 0x04020C82 RID: 134274
		public int MaxRow;

		// Token: 0x04020C83 RID: 134275
		public readonly Dictionary<int, List<RoverlikeTalentNodeData>> NodeRowMap = new Dictionary<int, List<RoverlikeTalentNodeData>>();

		// Token: 0x04020C84 RID: 134276
		public readonly List<RoverlikeTalentTreeNodeRowData> RowDataList = new List<RoverlikeTalentTreeNodeRowData>();

		// Token: 0x04020C85 RID: 134277
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public List<Dictionary<int, bool>> LineActiveMap = new List<Dictionary<int, bool>>();

		// Token: 0x04020C86 RID: 134278
		private readonly HashSet<int> ActivatedTalentIdSet = new HashSet<int>();

		// Token: 0x04020C87 RID: 134279
		private readonly HashSet<int> UnlockedTalentIdSet = new HashSet<int>();

		// Token: 0x04020C88 RID: 134280
		private bool IsStructureBuilt;
	}
}
