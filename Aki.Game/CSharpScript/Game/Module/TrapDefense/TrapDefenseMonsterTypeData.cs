using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A2E RID: 18990
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMonsterTypeData
	{
		// Token: 0x060314E8 RID: 201960 RVA: 0x00B70061 File Offset: 0x00B6E261
		public static TrapDefenseMonsterTypeData Create(TrapDefenseMonsterRisk config)
		{
			TrapDefenseMonsterTypeData trapDefenseMonsterTypeData = new TrapDefenseMonsterTypeData(config.Id);
			trapDefenseMonsterTypeData.Config = config;
			trapDefenseMonsterTypeData.Init();
			return trapDefenseMonsterTypeData;
		}

		// Token: 0x060314E9 RID: 201961 RVA: 0x00B7007C File Offset: 0x00B6E27C
		private TrapDefenseMonsterTypeData(int id)
		{
			this.Id = id;
		}

		// Token: 0x060314EA RID: 201962 RVA: 0x00B70096 File Offset: 0x00B6E296
		private void Init()
		{
		}

		// Token: 0x060314EB RID: 201963 RVA: 0x00B70098 File Offset: 0x00B6E298
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

		// Token: 0x0401A5AB RID: 107947
		public int Id;

		// Token: 0x0401A5AC RID: 107948
		public TrapDefenseMonsterRisk Config;

		// Token: 0x0401A5AD RID: 107949
		private List<TrapDefenseMonsterData> MonsterDataList = new List<TrapDefenseMonsterData>();
	}
}
