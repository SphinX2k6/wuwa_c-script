using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039BD RID: 14781
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBattleInventoryData
	{
		// Token: 0x0602614D RID: 155981 RVA: 0x00AAEBB1 File Offset: 0x00AACDB1
		public static TrapDefenseBattleInventoryData Create()
		{
			TrapDefenseBattleInventoryData trapDefenseBattleInventoryData = new TrapDefenseBattleInventoryData();
			trapDefenseBattleInventoryData.Init();
			return trapDefenseBattleInventoryData;
		}

		// Token: 0x0602614E RID: 155982 RVA: 0x00AAEBC0 File Offset: 0x00AACDC0
		public int GetOwnItemTypeCount()
		{
			int num = 0;
			using (Dictionary<int, TrapDefenseBattleItemData>.ValueCollection.Enumerator enumerator = this.ItemMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.InventoryCount > 0)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x0602614F RID: 155983 RVA: 0x00AAEC20 File Offset: 0x00AACE20
		private void Init()
		{
			foreach (TrapDefenseItem config in TrapDefenseConfig.Instance.GetAllTrapDefenseItem())
			{
				TrapDefenseBattleItemData trapDefenseBattleItemData = TrapDefenseBattleItemData.Create(config);
				this.ItemMap.Add(trapDefenseBattleItemData.Config.Id, trapDefenseBattleItemData);
			}
		}

		// Token: 0x06026150 RID: 155984 RVA: 0x00AAEC88 File Offset: 0x00AACE88
		[NullableContext(2)]
		public TrapDefenseBattleItemData GetItemData(int itemId)
		{
			TrapDefenseBattleItemData result;
			this.ItemMap.TryGetValue(itemId, out result);
			return result;
		}

		// Token: 0x06026151 RID: 155985 RVA: 0x00AAECA8 File Offset: 0x00AACEA8
		public void UpdateItemData(IReadOnlyList<TrapDefenseItemPbData> itemDataList)
		{
			foreach (TrapDefenseItemPbData trapDefenseItemPbData in itemDataList)
			{
				TrapDefenseBattleItemData trapDefenseBattleItemData;
				if (!this.ItemMap.TryGetValue(trapDefenseItemPbData.ConfigId, out trapDefenseBattleItemData))
				{
					trapDefenseBattleItemData = TrapDefenseBattleItemData.Create(TrapDefenseConfig.Instance.GetTrapDefenseItemConfigById(trapDefenseItemPbData.ConfigId).Value);
					this.ItemMap.Add(trapDefenseItemPbData.ConfigId, trapDefenseBattleItemData);
				}
				trapDefenseBattleItemData.UpdateByServerData(trapDefenseItemPbData.CarryCount, trapDefenseItemPbData.CarryLimit);
			}
		}

		// Token: 0x04014E85 RID: 85637
		public Dictionary<int, TrapDefenseBattleItemData> ItemMap = new Dictionary<int, TrapDefenseBattleItemData>();
	}
}
