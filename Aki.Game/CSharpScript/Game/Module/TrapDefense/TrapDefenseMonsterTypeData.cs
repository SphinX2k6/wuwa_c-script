using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039D6 RID: 14806
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMonsterTypeData
	{
		// Token: 0x06026278 RID: 156280 RVA: 0x00AB3FB1 File Offset: 0x00AB21B1
		public static TrapDefenseMonsterTypeData Create(TrapDefenseMonsterRisk config)
		{
			TrapDefenseMonsterTypeData trapDefenseMonsterTypeData = new TrapDefenseMonsterTypeData(config.Id);
			trapDefenseMonsterTypeData.Config = config;
			trapDefenseMonsterTypeData.Init();
			return trapDefenseMonsterTypeData;
		}

		// Token: 0x06026279 RID: 156281 RVA: 0x00AB3FCC File Offset: 0x00AB21CC
		private TrapDefenseMonsterTypeData(int id)
		{
			this.Id = id;
		}

		// Token: 0x0602627A RID: 156282 RVA: 0x00AB3FE6 File Offset: 0x00AB21E6
		private void Init()
		{
		}

		// Token: 0x0602627B RID: 156283 RVA: 0x00AB3FE8 File Offset: 0x00AB21E8
		public List<TrapDefenseMonsterData> GetMonsterDataList(bool showInInstance = true)
		{
			if (this.MonsterDataList.Count <= 0)
			{
				foreach (TrapDefenseMonsterData trapDefenseMonsterData in TrapDefenseModel.Instance.ViewModelMonster.GetMonsterMap().Values)
				{
					if (trapDefenseMonsterData.ConfigType.RiskType == this.Id)
					{
						this.MonsterDataList.Add(trapDefenseMonsterData);
					}
				}
				List<TrapDefenseMonsterData> list = new List<TrapDefenseMonsterData>(this.MonsterDataList);
				Dictionary<TrapDefenseMonsterData, int> orderIndexMap = new Dictionary<TrapDefenseMonsterData, int>();
				for (int i = 0; i < list.Count; i++)
				{
					orderIndexMap[list[i]] = i;
				}
				list.Sort(delegate(TrapDefenseMonsterData a, TrapDefenseMonsterData b)
				{
					if (a.SortId != b.SortId)
					{
						return a.SortId - b.SortId;
					}
					return orderIndexMap[a] - orderIndexMap[b];
				});
				this.MonsterDataList = list;
			}
			if (showInInstance)
			{
				List<TrapDefenseMonsterData> list2 = new List<TrapDefenseMonsterData>();
				foreach (TrapDefenseMonsterData trapDefenseMonsterData2 in this.MonsterDataList)
				{
					if (trapDefenseMonsterData2.InTheInstance)
					{
						list2.Add(trapDefenseMonsterData2);
					}
				}
				return list2;
			}
			return this.MonsterDataList;
		}

		// Token: 0x04014F00 RID: 85760
		public int Id;

		// Token: 0x04014F01 RID: 85761
		public TrapDefenseMonsterRisk Config;

		// Token: 0x04014F02 RID: 85762
		private List<TrapDefenseMonsterData> MonsterDataList = new List<TrapDefenseMonsterData>();
	}
}
