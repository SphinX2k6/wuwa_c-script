using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039C3 RID: 14787
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeData
	{
		// Token: 0x06026187 RID: 156039 RVA: 0x00AAFD78 File Offset: 0x00AADF78
		public static TrapDefenseTalentTreeData Create(int activityId)
		{
			TrapDefenseTalentTreeData trapDefenseTalentTreeData = new TrapDefenseTalentTreeData();
			trapDefenseTalentTreeData.ActivityId = activityId;
			trapDefenseTalentTreeData.Init();
			return trapDefenseTalentTreeData;
		}

		// Token: 0x06026188 RID: 156040 RVA: 0x00AAFD8C File Offset: 0x00AADF8C
		public void SetRemainPoints(int points)
		{
			this.RemainPoints = points;
		}

		// Token: 0x06026189 RID: 156041 RVA: 0x00AAFD95 File Offset: 0x00AADF95
		public void SetMaxPoints(int points)
		{
			this.MaxPoints = points;
		}

		// Token: 0x0602618A RID: 156042 RVA: 0x00AAFDA0 File Offset: 0x00AADFA0
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

		// Token: 0x0602618B RID: 156043 RVA: 0x00AAFF28 File Offset: 0x00AAE128
		public List<TrapDefenseTalentTreeNodeData> GetNodeDataListByRow(int row)
		{
			if (this.NodeRowMap.ContainsKey(row))
			{
				return this.NodeRowMap[row];
			}
			return new List<TrapDefenseTalentTreeNodeData>();
		}

		// Token: 0x0602618C RID: 156044 RVA: 0x00AAFF4C File Offset: 0x00AAE14C
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

		// Token: 0x0602618D RID: 156045 RVA: 0x00AAFFBC File Offset: 0x00AAE1BC
		public bool CanNodeAfford(TrapDefenseTalentTreeNodeData node)
		{
			List<ICostData> costData = node.GetCostData();
			return costData.Count == 0 || costData[0].Count >= costData[0].Cost;
		}

		// Token: 0x0602618E RID: 156046 RVA: 0x00AAFFF8 File Offset: 0x00AAE1F8
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

		// Token: 0x0602618F RID: 156047 RVA: 0x00AB0098 File Offset: 0x00AAE298
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

		// Token: 0x06026190 RID: 156048 RVA: 0x00AB010C File Offset: 0x00AAE30C
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

		// Token: 0x06026191 RID: 156049 RVA: 0x00AB01D8 File Offset: 0x00AAE3D8
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

		// Token: 0x06026192 RID: 156050 RVA: 0x00AB02A4 File Offset: 0x00AAE4A4
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

		// Token: 0x06026193 RID: 156051 RVA: 0x00AB0348 File Offset: 0x00AAE548
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

		// Token: 0x06026194 RID: 156052 RVA: 0x00AB03FC File Offset: 0x00AAE5FC
		private ETrapDefenseTalentTreePathType GetPathType(TrapDefenseTalentTreeNodeData from, TrapDefenseTalentTreeNodeData to)
		{
			if (from.IsUnlock && to.IsUnlock)
			{
				return ETrapDefenseTalentTreePathType.Solid;
			}
			return ETrapDefenseTalentTreePathType.Dashed;
		}

		// Token: 0x06026195 RID: 156053 RVA: 0x00AB0414 File Offset: 0x00AAE614
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

		// Token: 0x04014EA6 RID: 85670
		private int ActivityId;

		// Token: 0x04014EA7 RID: 85671
		public int MaxRow;

		// Token: 0x04014EA8 RID: 85672
		public int RemainPoints;

		// Token: 0x04014EA9 RID: 85673
		public int MaxPoints;

		// Token: 0x04014EAA RID: 85674
		public Dictionary<int, List<TrapDefenseTalentTreeNodeData>> NodeRowMap = new Dictionary<int, List<TrapDefenseTalentTreeNodeData>>();

		// Token: 0x04014EAB RID: 85675
		public Dictionary<int, TrapDefenseTalentTreeNodeData> NodeIdMap = new Dictionary<int, TrapDefenseTalentTreeNodeData>();

		// Token: 0x04014EAC RID: 85676
		public List<TrapDefenseTalentTreeRowData> RowDataList = new List<TrapDefenseTalentTreeRowData>();

		// Token: 0x04014EAD RID: 85677
		public List<Dictionary<int, ETrapDefenseTalentTreePathType>> LineTypeMap = new List<Dictionary<int, ETrapDefenseTalentTreePathType>>();
	}
}
