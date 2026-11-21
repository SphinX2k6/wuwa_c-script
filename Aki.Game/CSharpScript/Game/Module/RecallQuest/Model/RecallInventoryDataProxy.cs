using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.RecallQuest.Model
{
	// Token: 0x02003EE9 RID: 16105
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallInventoryDataProxy : InventoryDataProxy
	{
		// Token: 0x06028D69 RID: 167273 RVA: 0x00B75D5D File Offset: 0x00B73F5D
		public RecallInventoryDataProxy(RecallInventoryData data)
		{
			this.Data = data;
		}

		// Token: 0x06028D6A RID: 167274 RVA: 0x00B75D6C File Offset: 0x00B73F6C
		public override List<ItemMainType> GetOpenIdMainTypeConfig()
		{
			HashSet<InventoryDefine.EItemMainTypeId> availableMainTypes = this.Data.GetAvailableMainTypes();
			IEnumerable<ItemMainType> enumerable = InventoryConfig.Instance.GetAllMainTypeConfig() ?? Array.Empty<ItemMainType>();
			List<ItemMainType> list = new List<ItemMainType>();
			foreach (ItemMainType item in enumerable)
			{
				if (item.BShowInInventoryView && availableMainTypes.Contains((InventoryDefine.EItemMainTypeId)item.Id))
				{
					list.Add(item);
				}
			}
			list.Sort((ItemMainType a, ItemMainType b) => a.SequenceId - b.SequenceId);
			return list;
		}

		// Token: 0x06028D6B RID: 167275 RVA: 0x00B75E18 File Offset: 0x00B74018
		public override HashSet<ItemDataBase> GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId mainType)
		{
			return this.Data.GetItemDataBaseSetByMainType(mainType);
		}

		// Token: 0x06028D6C RID: 167276 RVA: 0x00B75E26 File Offset: 0x00B74026
		public override int GetInventoryItemGridCountByMainType(InventoryDefine.EItemMainTypeId mainType)
		{
			return 0;
		}

		// Token: 0x06028D6D RID: 167277 RVA: 0x00B75E29 File Offset: 0x00B74029
		public override bool SupportShowCurrency()
		{
			return false;
		}

		// Token: 0x06028D6E RID: 167278 RVA: 0x00B75E2C File Offset: 0x00B7402C
		public override int GetItemCountByConfigId(int itemConfigId, int uniqueId)
		{
			return this.Data.GetCount(itemConfigId);
		}

		// Token: 0x06028D6F RID: 167279 RVA: 0x00B75E3A File Offset: 0x00B7403A
		public override int GetCommonItemCount(int configId, int uniqueId)
		{
			return this.Data.GetCount(configId);
		}

		// Token: 0x0401635F RID: 90975
		private readonly RecallInventoryData Data;
	}
}
