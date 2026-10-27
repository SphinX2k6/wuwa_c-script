using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.RecallQuest.Model
{
	// Token: 0x02004F20 RID: 20256
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallInventoryDataProxy : InventoryDataProxy
	{
		// Token: 0x06033EFE RID: 212734 RVA: 0x00C2C6E9 File Offset: 0x00C2A8E9
		public RecallInventoryDataProxy(RecallInventoryData data)
		{
			this.Data = data;
		}

		// Token: 0x06033EFF RID: 212735 RVA: 0x00C2C6F8 File Offset: 0x00C2A8F8
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

		// Token: 0x06033F00 RID: 212736 RVA: 0x00C2C7A4 File Offset: 0x00C2A9A4
		public override HashSet<ItemDataBase> GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId mainType)
		{
			return this.Data.GetItemDataBaseSetByMainType(mainType);
		}

		// Token: 0x06033F01 RID: 212737 RVA: 0x00C2C7B2 File Offset: 0x00C2A9B2
		public override int GetInventoryItemGridCountByMainType(InventoryDefine.EItemMainTypeId mainType)
		{
			return 0;
		}

		// Token: 0x06033F02 RID: 212738 RVA: 0x00C2C7B5 File Offset: 0x00C2A9B5
		public override bool SupportShowCurrency()
		{
			return false;
		}

		// Token: 0x06033F03 RID: 212739 RVA: 0x00C2C7B8 File Offset: 0x00C2A9B8
		public override int GetItemCountByConfigId(int itemConfigId, int uniqueId)
		{
			return this.Data.GetCount(itemConfigId);
		}

		// Token: 0x06033F04 RID: 212740 RVA: 0x00C2C7C6 File Offset: 0x00C2A9C6
		public override int GetCommonItemCount(int configId, int uniqueId)
		{
			return this.Data.GetCount(configId);
		}

		// Token: 0x0401B98C RID: 113036
		private readonly RecallInventoryData Data;
	}
}
