using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.RecallQuest.Model
{
	// Token: 0x02003EE8 RID: 16104
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallInventoryData
	{
		// Token: 0x06028D60 RID: 167264 RVA: 0x00B75B4C File Offset: 0x00B73D4C
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

		// Token: 0x06028D61 RID: 167265 RVA: 0x00B75BB8 File Offset: 0x00B73DB8
		public void SetItem(int itemId, int count)
		{
			CommonItemData value = new CommonItemData(itemId, 0, count, InventoryDefine.EItemDataType.CommonItem, null);
			this.VirtualItemMap[itemId] = value;
			this.CountMap[itemId] = count;
		}

		// Token: 0x06028D62 RID: 167266 RVA: 0x00B75BF2 File Offset: 0x00B73DF2
		public void RemoveItem(int itemId)
		{
			this.VirtualItemMap.Remove(itemId);
			this.CountMap.Remove(itemId);
		}

		// Token: 0x06028D63 RID: 167267 RVA: 0x00B75C0E File Offset: 0x00B73E0E
		public void Clear()
		{
			this.VirtualItemMap.Clear();
			this.CountMap.Clear();
		}

		// Token: 0x06028D64 RID: 167268 RVA: 0x00B75C28 File Offset: 0x00B73E28
		public int GetCount(int configId)
		{
			int result;
			if (!this.CountMap.TryGetValue(configId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x06028D65 RID: 167269 RVA: 0x00B75C48 File Offset: 0x00B73E48
		public bool IsEmpty()
		{
			return this.VirtualItemMap.Count == 0;
		}

		// Token: 0x06028D66 RID: 167270 RVA: 0x00B75C58 File Offset: 0x00B73E58
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

		// Token: 0x06028D67 RID: 167271 RVA: 0x00B75CD8 File Offset: 0x00B73ED8
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

		// Token: 0x0401635C RID: 90972
		private readonly Dictionary<int, CommonItemData> VirtualItemMap = new Dictionary<int, CommonItemData>();

		// Token: 0x0401635D RID: 90973
		private readonly Dictionary<int, int> CountMap = new Dictionary<int, int>();

		// Token: 0x0401635E RID: 90974
		private readonly HashSet<InventoryDefine.EItemMainTypeId> OpenIdMainTypeConfigCache = new HashSet<InventoryDefine.EItemMainTypeId>();
	}
}
