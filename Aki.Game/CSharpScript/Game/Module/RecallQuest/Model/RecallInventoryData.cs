using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.RecallQuest.Model
{
	// Token: 0x02004F1F RID: 20255
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallInventoryData
	{
		// Token: 0x06033EF5 RID: 212725 RVA: 0x00C2C4D8 File Offset: 0x00C2A6D8
		public void InitFromFullSnapshot([TupleElementNames(new string[]
		{
			"ItemId",
			"Count"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] IReadOnlyList<ValueTuple<int, int>> items)
		{
			this.VirtualItemMap.Clear();
			this.CountMap.Clear();
			foreach (ValueTuple<int, int> valueTuple in items)
			{
				this.SetItem(valueTuple.Item1, valueTuple.Item2);
			}
		}

		// Token: 0x06033EF6 RID: 212726 RVA: 0x00C2C544 File Offset: 0x00C2A744
		public void SetItem(int itemId, int count)
		{
			CommonItemData value = new CommonItemData(itemId, 0, count, InventoryDefine.EItemDataType.CommonItem, null);
			this.VirtualItemMap[itemId] = value;
			this.CountMap[itemId] = count;
		}

		// Token: 0x06033EF7 RID: 212727 RVA: 0x00C2C57E File Offset: 0x00C2A77E
		public void RemoveItem(int itemId)
		{
			this.VirtualItemMap.Remove(itemId);
			this.CountMap.Remove(itemId);
		}

		// Token: 0x06033EF8 RID: 212728 RVA: 0x00C2C59A File Offset: 0x00C2A79A
		public void Clear()
		{
			this.VirtualItemMap.Clear();
			this.CountMap.Clear();
		}

		// Token: 0x06033EF9 RID: 212729 RVA: 0x00C2C5B4 File Offset: 0x00C2A7B4
		public int GetCount(int configId)
		{
			int result;
			if (!this.CountMap.TryGetValue(configId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x06033EFA RID: 212730 RVA: 0x00C2C5D4 File Offset: 0x00C2A7D4
		public bool IsEmpty()
		{
			return this.VirtualItemMap.Count == 0;
		}

		// Token: 0x06033EFB RID: 212731 RVA: 0x00C2C5E4 File Offset: 0x00C2A7E4
		public HashSet<ItemDataBase> GetItemDataBaseSetByMainType(InventoryDefine.EItemMainTypeId mainType)
		{
			HashSet<ItemDataBase> hashSet = new HashSet<ItemDataBase>();
			foreach (CommonItemData commonItemData in this.VirtualItemMap.Values)
			{
				InventoryDefine.EItemMainTypeId? mainType2 = commonItemData.GetMainType();
				if (mainType2.GetValueOrDefault() == mainType & mainType2 != null)
				{
					hashSet.Add(commonItemData);
				}
			}
			return hashSet;
		}

		// Token: 0x06033EFC RID: 212732 RVA: 0x00C2C664 File Offset: 0x00C2A864
		public HashSet<InventoryDefine.EItemMainTypeId> GetAvailableMainTypes()
		{
			if (this.OpenIdMainTypeConfigCache.Count > 0)
			{
				return this.OpenIdMainTypeConfigCache;
			}
			this.OpenIdMainTypeConfigCache.Add(InventoryDefine.EItemMainTypeId.Common);
			this.OpenIdMainTypeConfigCache.Add(InventoryDefine.EItemMainTypeId.Material);
			this.OpenIdMainTypeConfigCache.Add(InventoryDefine.EItemMainTypeId.Mission);
			this.OpenIdMainTypeConfigCache.Add(InventoryDefine.EItemMainTypeId.Special);
			return this.OpenIdMainTypeConfigCache;
		}

		// Token: 0x0401B989 RID: 113033
		private readonly Dictionary<int, CommonItemData> VirtualItemMap = new Dictionary<int, CommonItemData>();

		// Token: 0x0401B98A RID: 113034
		private readonly Dictionary<int, int> CountMap = new Dictionary<int, int>();

		// Token: 0x0401B98B RID: 113035
		private readonly HashSet<InventoryDefine.EItemMainTypeId> OpenIdMainTypeConfigCache = new HashSet<InventoryDefine.EItemMainTypeId>();
	}
}
