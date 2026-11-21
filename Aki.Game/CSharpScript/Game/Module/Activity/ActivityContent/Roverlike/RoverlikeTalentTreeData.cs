using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005061 RID: 20577
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTalentTreeData
	{
		// Token: 0x06033814 RID: 210964 RVA: 0x00E6C1E4 File Offset: 0x00E6A3E4
		public static bool IsSameNode(RoverRogueTalentTree a, RoverRogueTalentTree b)
		{
			return a.Row == b.Row && a.Column == b.Column;
		}

		// Token: 0x06033815 RID: 210965 RVA: 0x00E6C208 File Offset: 0x00E6A408
		private static int GetNodeKey(RoverRogueTalentTree config)
		{
			return config.Column * 10000 + config.Row;
		}

		// Token: 0x06033816 RID: 210966 RVA: 0x00E6C220 File Offset: 0x00E6A420
		public void PhraseEx(int activityId, int talentPointItemId, RoverRogueActivityData roverData)
		{
			this.ActivityId = activityId;
			this.TalentPointItemId = talentPointItemId;
			if (!this.IsStructureBuilt)
			{
				this.BuildStructure();
				this.IsStructureBuilt = true;
			}
			List<int> activeIds = (roverData.ActiveTalentIdList != null) ? new List<int>(roverData.ActiveTalentIdList) : new List<int>();
			List<int> unlockIds = (roverData.UnlockTalentIdList != null) ? new List<int>(roverData.UnlockTalentIdList) : new List<int>();
			this.UpdateTalentStateByServer(activeIds, unlockIds, true);
		}

		// Token: 0x06033817 RID: 210967 RVA: 0x00E6C290 File Offset: 0x00E6A490
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
			Dictionary<int, List<RoverlikeTalentNodeData>> dictionary2 = new Dictionary<int, List<RoverlikeTalentNodeData>>();
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
				if (!dictionary2.TryGetValue(roverlikeTalentNodeData.HeadConfig.Column, out list4))
				{
					list4 = new List<RoverlikeTalentNodeData>();
					dictionary2[roverlikeTalentNodeData.HeadConfig.Column] = list4;
				}
				list4.Add(roverlikeTalentNodeData);
			}
			List<int> list5 = new List<int>(dictionary2.Keys);
			list5.Sort((int a, int b) => a - b);
			List<List<RoverlikeTalentNodeData>> list6 = new List<List<RoverlikeTalentNodeData>>(list5.Count);
			for (int i = 0; i < list5.Count; i++)
			{
				int key2 = list5[i];
				this.ColumnIndexMap[key2] = i;
				List<RoverlikeTalentNodeData> list7 = dictionary2[key2];
				list7.Sort((RoverlikeTalentNodeData a, RoverlikeTalentNodeData b) => a.HeadConfig.Row - b.HeadConfig.Row);
				list6.Add(list7);
			}
			this.NodeColumnList = list6;
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

		// Token: 0x06033818 RID: 210968 RVA: 0x00E6C5C0 File Offset: 0x00E6A7C0
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

		// Token: 0x06033819 RID: 210969 RVA: 0x00E6C728 File Offset: 0x00E6A928
		public void Reset()
		{
			this.CurSelectNode = null;
			this.OnClickNode = null;
		}

		// Token: 0x0603381A RID: 210970 RVA: 0x00E6C738 File Offset: 0x00E6A938
		public int GetColumnIndex(int column)
		{
			int result;
			if (!this.ColumnIndexMap.TryGetValue(column, out result))
			{
				return -1;
			}
			return result;
		}

		// Token: 0x0603381B RID: 210971 RVA: 0x00E6C758 File Offset: 0x00E6A958
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

		// Token: 0x0603381C RID: 210972 RVA: 0x00E6C7A8 File Offset: 0x00E6A9A8
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

		// Token: 0x0603381D RID: 210973 RVA: 0x00E6C87C File Offset: 0x00E6AA7C
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

		// Token: 0x0603381E RID: 210974 RVA: 0x00E6C8AE File Offset: 0x00E6AAAE
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

		// Token: 0x0603381F RID: 210975 RVA: 0x00E6C8E0 File Offset: 0x00E6AAE0
		public void SelectNode(RoverlikeTalentNodeData node)
		{
			if (node == null || (this.CurSelectNode != null && this.CurSelectNode.HeadConfig.Id == node.HeadConfig.Id))
			{
				return;
			}
			this.CurSelectNode = node;
		}

		// Token: 0x06033820 RID: 210976 RVA: 0x00E6C923 File Offset: 0x00E6AB23
		public int GetTalentCoinNum()
		{
			return RoverlikeModel.Instance.GetCurrency(this.TalentPointItemId);
		}

		// Token: 0x06033821 RID: 210977 RVA: 0x00E6C935 File Offset: 0x00E6AB35
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

		// Token: 0x06033822 RID: 210978 RVA: 0x00E6C964 File Offset: 0x00E6AB64
		public void UpdateUnlockTalentIds(IReadOnlyList<int> unlockIds, bool needEmit = true)
		{
			this.MergeTalentIds(new List<int>(), unlockIds);
			this.RecomputeNodeStateFromCache();
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			}
		}

		// Token: 0x06033823 RID: 210979 RVA: 0x00E6C994 File Offset: 0x00E6AB94
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

		// Token: 0x06033824 RID: 210980 RVA: 0x00E6CA2C File Offset: 0x00E6AC2C
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

		// Token: 0x06033825 RID: 210981 RVA: 0x00E6CB0C File Offset: 0x00E6AD0C
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

		// Token: 0x06033826 RID: 210982 RVA: 0x00E6CB9C File Offset: 0x00E6AD9C
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

		// Token: 0x06033827 RID: 210983 RVA: 0x00E6CBE6 File Offset: 0x00E6ADE6
		public bool IsTalentCanUnlock(RoverlikeTalentNodeData node)
		{
			return !node.IsMaxLevel && node.IsServerUnlocked && this.GetTalentCoinNum() >= node.NextLevelCost;
		}

		// Token: 0x06033828 RID: 210984 RVA: 0x00E6CC10 File Offset: 0x00E6AE10
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

		// Token: 0x06033829 RID: 210985 RVA: 0x00E6CC6C File Offset: 0x00E6AE6C
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

		// Token: 0x0603382A RID: 210986 RVA: 0x00E6CD7C File Offset: 0x00E6AF7C
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

		// Token: 0x0603382B RID: 210987 RVA: 0x00E6CDFC File Offset: 0x00E6AFFC
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

		// Token: 0x0603382C RID: 210988 RVA: 0x00E6CE64 File Offset: 0x00E6B064
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

		// Token: 0x0603382D RID: 210989 RVA: 0x00E6CF18 File Offset: 0x00E6B118
		private bool GetPathActive(RoverlikeTalentNodeData a, RoverlikeTalentNodeData b)
		{
			return a.IsMaxLevel && b.IsMaxLevel;
		}

		// Token: 0x0603382E RID: 210990 RVA: 0x00E6CF2C File Offset: 0x00E6B12C
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

		// Token: 0x0603382F RID: 210991 RVA: 0x00E6D120 File Offset: 0x00E6B320
		private void EnsureLineActiveMapSize(int row)
		{
			while (this.LineActiveMap.Count <= row)
			{
				this.LineActiveMap.Add(null);
			}
		}

		// Token: 0x06033830 RID: 210992 RVA: 0x00E6D140 File Offset: 0x00E6B340
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

		// Token: 0x0401B5A6 RID: 112038
		public int ActivityId;

		// Token: 0x0401B5A7 RID: 112039
		public int TalentPointItemId;

		// Token: 0x0401B5A8 RID: 112040
		public readonly Dictionary<int, RoverlikeTalentNodeData> NodeIdMap = new Dictionary<int, RoverlikeTalentNodeData>();

		// Token: 0x0401B5A9 RID: 112041
		public readonly List<RoverlikeTalentNodeData> NodeList = new List<RoverlikeTalentNodeData>();

		// Token: 0x0401B5AA RID: 112042
		public List<List<RoverlikeTalentNodeData>> NodeColumnList = new List<List<RoverlikeTalentNodeData>>();

		// Token: 0x0401B5AB RID: 112043
		public readonly Dictionary<int, int> ColumnIndexMap = new Dictionary<int, int>();

		// Token: 0x0401B5AC RID: 112044
		public readonly Dictionary<int, int> LevelIdToHeadIdMap = new Dictionary<int, int>();

		// Token: 0x0401B5AD RID: 112045
		[Nullable(2)]
		public RoverlikeTalentNodeData CurSelectNode;

		// Token: 0x0401B5AE RID: 112046
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<bool, RoverlikeTalentNodeData> OnClickNode;

		// Token: 0x0401B5AF RID: 112047
		public int MaxRow;

		// Token: 0x0401B5B0 RID: 112048
		public readonly Dictionary<int, List<RoverlikeTalentNodeData>> NodeRowMap = new Dictionary<int, List<RoverlikeTalentNodeData>>();

		// Token: 0x0401B5B1 RID: 112049
		public readonly List<RoverlikeTalentTreeNodeRowData> RowDataList = new List<RoverlikeTalentTreeNodeRowData>();

		// Token: 0x0401B5B2 RID: 112050
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public List<Dictionary<int, bool>> LineActiveMap = new List<Dictionary<int, bool>>();

		// Token: 0x0401B5B3 RID: 112051
		private readonly HashSet<int> ActivatedTalentIdSet = new HashSet<int>();

		// Token: 0x0401B5B4 RID: 112052
		private readonly HashSet<int> UnlockedTalentIdSet = new HashSet<int>();

		// Token: 0x0401B5B5 RID: 112053
		private bool IsStructureBuilt;
	}
}
