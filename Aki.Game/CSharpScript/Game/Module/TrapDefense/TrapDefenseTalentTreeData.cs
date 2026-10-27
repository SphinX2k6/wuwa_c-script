using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A1B RID: 18971
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeData
	{
		// Token: 0x060313F7 RID: 201719 RVA: 0x00B6BD7C File Offset: 0x00B69F7C
		public static TrapDefenseTalentTreeData Create(int activityId)
		{
			TrapDefenseTalentTreeData trapDefenseTalentTreeData = new TrapDefenseTalentTreeData();
			trapDefenseTalentTreeData.ActivityId = activityId;
			trapDefenseTalentTreeData.Init();
			return trapDefenseTalentTreeData;
		}

		// Token: 0x060313F8 RID: 201720 RVA: 0x00B6BD90 File Offset: 0x00B69F90
		public void SetRemainPoints(int points)
		{
			this.RemainPoints = points;
		}

		// Token: 0x060313F9 RID: 201721 RVA: 0x00B6BD99 File Offset: 0x00B69F99
		public void SetMaxPoints(int points)
		{
			this.MaxPoints = points;
		}

		// Token: 0x060313FA RID: 201722 RVA: 0x00B6BDA4 File Offset: 0x00B69FA4
		private void Init()
		{
			this.RowDataList = new List<TrapDefenseTalentTreeRowData>();
			IReadOnlyList<TrapDefenseTech> trapDefenseTalentTreeConfigByActivityId = TrapDefenseConfig.Instance.GetTrapDefenseTalentTreeConfigByActivityId(this.ActivityId);
			if (trapDefenseTalentTreeConfigByActivityId == null)
			{
				return;
			}
			foreach (TrapDefenseTech config in trapDefenseTalentTreeConfigByActivityId)
			{
				TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData = TrapDefenseTalentTreeNodeData.Create(config);
				if (!this.NodeRowMap.ContainsKey(trapDefenseTalentTreeNodeData.Row))
				{
					this.NodeRowMap[trapDefenseTalentTreeNodeData.Row] = new List<TrapDefenseTalentTreeNodeData>();
				}
				this.NodeRowMap[trapDefenseTalentTreeNodeData.Row].Add(trapDefenseTalentTreeNodeData);
				this.NodeIdMap[trapDefenseTalentTreeNodeData.Id] = trapDefenseTalentTreeNodeData;
				this.MaxRow = Math.Max(this.MaxRow, trapDefenseTalentTreeNodeData.Row);
			}
			this.RefreshLineTypeMap();
			foreach (KeyValuePair<int, List<TrapDefenseTalentTreeNodeData>> keyValuePair in this.NodeRowMap)
			{
				int key = keyValuePair.Key;
				List<TrapDefenseTalentTreeNodeData> value = keyValuePair.Value;
				value.Sort((TrapDefenseTalentTreeNodeData a, TrapDefenseTalentTreeNodeData b) => a.Index.CompareTo(b.Index));
				this.RowDataList.Add(TrapDefenseTalentTreeRowData.Create(key, value));
			}
			this.RowDataList.Sort((TrapDefenseTalentTreeRowData a, TrapDefenseTalentTreeRowData b) => a.Row.CompareTo(b.Row));
		}

		// Token: 0x060313FB RID: 201723 RVA: 0x00B6BF2C File Offset: 0x00B6A12C
		public List<TrapDefenseTalentTreeNodeData> GetNodeDataListByRow(int row)
		{
			if (this.NodeRowMap.ContainsKey(row))
			{
				return this.NodeRowMap[row];
			}
			return new List<TrapDefenseTalentTreeNodeData>();
		}

		// Token: 0x060313FC RID: 201724 RVA: 0x00B6BF50 File Offset: 0x00B6A150
		public bool CanNodeUnlock(TrapDefenseTalentTreeNodeData node)
		{
			if (node.IsUnlock)
			{
				return false;
			}
			List<TrapDefenseTalentTreeNodeData> preNodesByNodeData = this.GetPreNodesByNodeData(node);
			if (preNodesByNodeData.Count == 0)
			{
				return true;
			}
			using (List<TrapDefenseTalentTreeNodeData>.Enumerator enumerator = preNodesByNodeData.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsUnlock)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060313FD RID: 201725 RVA: 0x00B6BFC0 File Offset: 0x00B6A1C0
		public bool CanNodeAfford(TrapDefenseTalentTreeNodeData node)
		{
			List<ICostData> costData = node.GetCostData();
			return costData.Count == 0 || costData[0].Count >= costData[0].Cost;
		}

		// Token: 0x060313FE RID: 201726 RVA: 0x00B6BFFC File Offset: 0x00B6A1FC
		public bool HasAnyNodeCanUnlockAndAfford()
		{
			foreach (List<TrapDefenseTalentTreeNodeData> list in this.NodeRowMap.Values)
			{
				foreach (TrapDefenseTalentTreeNodeData node in list)
				{
					if (this.CanNodeUnlock(node) && this.CanNodeAfford(node))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060313FF RID: 201727 RVA: 0x00B6C09C File Offset: 0x00B6A29C
		public List<TrapDefenseTalentTreeNodeData> GetPreNodesByNodeData(TrapDefenseTalentTreeNodeData node)
		{
			List<TrapDefenseTalentTreeNodeData> list = new List<TrapDefenseTalentTreeNodeData>();
			foreach (int key in node.Config.PreNodeIter())
			{
				if (this.NodeIdMap.ContainsKey(key))
				{
					list.Add(this.NodeIdMap[key]);
				}
			}
			return list;
		}

		// Token: 0x06031400 RID: 201728 RVA: 0x00B6C110 File Offset: 0x00B6A310
		public TrapDefenseTalentTreeNodeData GetDefaultSelectNode()
		{
			TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData = null;
			TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData2 = null;
			List<TrapDefenseTalentTreeNodeData> list = this.NodeRowMap[this.MaxRow];
			TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData3 = list[list.Count - 1];
			for (int i = 1; i <= this.MaxRow; i++)
			{
				foreach (TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData4 in this.GetNodeDataListByRow(i))
				{
					if (this.CanNodeUnlock(trapDefenseTalentTreeNodeData4) && this.CanNodeAfford(trapDefenseTalentTreeNodeData4) && trapDefenseTalentTreeNodeData == null)
					{
						trapDefenseTalentTreeNodeData = trapDefenseTalentTreeNodeData4;
					}
					if ((!this.CanNodeUnlock(trapDefenseTalentTreeNodeData4) || !this.CanNodeAfford(trapDefenseTalentTreeNodeData4)) && trapDefenseTalentTreeNodeData2 == null && !trapDefenseTalentTreeNodeData4.IsUnlock)
					{
						trapDefenseTalentTreeNodeData2 = trapDefenseTalentTreeNodeData4;
					}
				}
			}
			TrapDefenseTalentTreeNodeData result;
			if ((result = trapDefenseTalentTreeNodeData) == null)
			{
				result = (trapDefenseTalentTreeNodeData2 ?? trapDefenseTalentTreeNodeData3);
			}
			return result;
		}

		// Token: 0x06031401 RID: 201729 RVA: 0x00B6C1DC File Offset: 0x00B6A3DC
		[NullableContext(2)]
		public TrapDefenseTalentTreeNodeData GetDefaultSelectNodeByFuncType(ETrapDefenseTalentFuncType funcType)
		{
			TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData = null;
			TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData2 = null;
			TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData3 = null;
			for (int i = 1; i <= this.MaxRow; i++)
			{
				foreach (TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData4 in this.GetNodeDataListByRow(i))
				{
					if (trapDefenseTalentTreeNodeData4.Config.FuncType == (int)funcType)
					{
						if (trapDefenseTalentTreeNodeData == null)
						{
							trapDefenseTalentTreeNodeData = trapDefenseTalentTreeNodeData4;
						}
						if (this.CanNodeUnlock(trapDefenseTalentTreeNodeData4) && this.CanNodeAfford(trapDefenseTalentTreeNodeData4) && trapDefenseTalentTreeNodeData2 == null)
						{
							trapDefenseTalentTreeNodeData2 = trapDefenseTalentTreeNodeData4;
						}
						if ((!this.CanNodeUnlock(trapDefenseTalentTreeNodeData4) || !this.CanNodeAfford(trapDefenseTalentTreeNodeData4)) && !trapDefenseTalentTreeNodeData4.IsUnlock && trapDefenseTalentTreeNodeData3 == null)
						{
							trapDefenseTalentTreeNodeData3 = trapDefenseTalentTreeNodeData4;
						}
					}
				}
			}
			TrapDefenseTalentTreeNodeData result;
			if ((result = trapDefenseTalentTreeNodeData2) == null)
			{
				result = (trapDefenseTalentTreeNodeData3 ?? trapDefenseTalentTreeNodeData);
			}
			return result;
		}

		// Token: 0x06031402 RID: 201730 RVA: 0x00B6C2A8 File Offset: 0x00B6A4A8
		public bool IsDotVisible(int row, int index)
		{
			using (List<TrapDefenseTalentTreeNodeData>.Enumerator enumerator = this.GetNodeDataListByRow(row).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Index == index)
					{
						return true;
					}
				}
			}
			using (List<TrapDefenseTalentTreeNodeData>.Enumerator enumerator = this.GetNodeDataListByRow(row + 1).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Index == index)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06031403 RID: 201731 RVA: 0x00B6C34C File Offset: 0x00B6A54C
		private List<Tuple<int, int>> GetPath(TrapDefenseTalentTreeNodeData from, TrapDefenseTalentTreeNodeData to)
		{
			List<Tuple<int, int>> list = new List<Tuple<int, int>>();
			for (int i = from.Row + 1; i < to.Row; i++)
			{
				list.Add(new Tuple<int, int>(i, to.Index + 6));
			}
			list.Add(new Tuple<int, int>(from.Row, from.Index + 12));
			list.Add(new Tuple<int, int>(to.Row, to.Index));
			int num = Math.Max(from.Index, to.Index);
			for (int j = Math.Min(from.Index, to.Index); j < num; j++)
			{
				list.Add(new Tuple<int, int>(from.Row, j + 18));
			}
			return list;
		}

		// Token: 0x06031404 RID: 201732 RVA: 0x00B6C400 File Offset: 0x00B6A600
		private ETrapDefenseTalentTreePathType GetPathType(TrapDefenseTalentTreeNodeData from, TrapDefenseTalentTreeNodeData to)
		{
			if (from.IsUnlock && to.IsUnlock)
			{
				return ETrapDefenseTalentTreePathType.Solid;
			}
			return ETrapDefenseTalentTreePathType.Dashed;
		}

		// Token: 0x06031405 RID: 201733 RVA: 0x00B6C418 File Offset: 0x00B6A618
		public void RefreshLineTypeMap()
		{
			foreach (Dictionary<int, ETrapDefenseTalentTreePathType> dictionary in this.LineTypeMap)
			{
				dictionary.Clear();
			}
			foreach (int row in this.NodeRowMap.Keys)
			{
				foreach (TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData in this.GetNodeDataListByRow(row))
				{
					foreach (TrapDefenseTalentTreeNodeData from in this.GetPreNodesByNodeData(trapDefenseTalentTreeNodeData))
					{
						List<Tuple<int, int>> path = this.GetPath(from, trapDefenseTalentTreeNodeData);
						ETrapDefenseTalentTreePathType pathType = this.GetPathType(from, trapDefenseTalentTreeNodeData);
						foreach (Tuple<int, int> tuple in path)
						{
							while (this.LineTypeMap.Count <= tuple.Item1)
							{
								this.LineTypeMap.Add(new Dictionary<int, ETrapDefenseTalentTreePathType>());
							}
							if (!this.LineTypeMap[tuple.Item1].ContainsKey(tuple.Item2) || this.LineTypeMap[tuple.Item1][tuple.Item2] != ETrapDefenseTalentTreePathType.Solid)
							{
								this.LineTypeMap[tuple.Item1][tuple.Item2] = pathType;
							}
						}
					}
				}
			}
		}

		// Token: 0x0401A54F RID: 107855
		private int ActivityId;

		// Token: 0x0401A550 RID: 107856
		public int MaxRow;

		// Token: 0x0401A551 RID: 107857
		public int RemainPoints;

		// Token: 0x0401A552 RID: 107858
		public int MaxPoints;

		// Token: 0x0401A553 RID: 107859
		public Dictionary<int, List<TrapDefenseTalentTreeNodeData>> NodeRowMap = new Dictionary<int, List<TrapDefenseTalentTreeNodeData>>();

		// Token: 0x0401A554 RID: 107860
		public Dictionary<int, TrapDefenseTalentTreeNodeData> NodeIdMap = new Dictionary<int, TrapDefenseTalentTreeNodeData>();

		// Token: 0x0401A555 RID: 107861
		public List<TrapDefenseTalentTreeRowData> RowDataList = new List<TrapDefenseTalentTreeRowData>();

		// Token: 0x0401A556 RID: 107862
		public List<Dictionary<int, ETrapDefenseTalentTreePathType>> LineTypeMap = new List<Dictionary<int, ETrapDefenseTalentTreePathType>>();
	}
}
