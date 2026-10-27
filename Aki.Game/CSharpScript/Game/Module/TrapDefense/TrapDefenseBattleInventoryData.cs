using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A15 RID: 18965
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBattleInventoryData
	{
		// Token: 0x060313BD RID: 201661 RVA: 0x00B6ABB5 File Offset: 0x00B68DB5
		public static TrapDefenseBattleInventoryData Create()
		{
			TrapDefenseBattleInventoryData trapDefenseBattleInventoryData = new TrapDefenseBattleInventoryData();
			trapDefenseBattleInventoryData.Init();
			return trapDefenseBattleInventoryData;
		}

		// Token: 0x060313BE RID: 201662 RVA: 0x00B6ABC4 File Offset: 0x00B68DC4
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

		// Token: 0x060313BF RID: 201663 RVA: 0x00B6AC24 File Offset: 0x00B68E24
		private void Init()
		{
			foreach (TrapDefenseItem config in TrapDefenseConfig.Instance.GetAllTrapDefenseItem())
			{
				TrapDefenseBattleItemData trapDefenseBattleItemData = TrapDefenseBattleItemData.Create(config);
				this.ItemMap.Add(trapDefenseBattleItemData.Config.Id, trapDefenseBattleItemData);
			}
		}

		// Token: 0x060313C0 RID: 201664 RVA: 0x00B6AC8C File Offset: 0x00B68E8C
		[NullableContext(2)]
		public TrapDefenseBattleItemData GetItemData(int itemId)
		{
			TrapDefenseBattleItemData result;
			this.ItemMap.TryGetValue(itemId, out result);
			return result;
		}

		// Token: 0x060313C1 RID: 201665 RVA: 0x00B6ACAC File Offset: 0x00B68EAC
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

		// Token: 0x0401A52E RID: 107822
		public Dictionary<int, TrapDefenseBattleItemData> ItemMap = new Dictionary<int, TrapDefenseBattleItemData>();
	}
}
