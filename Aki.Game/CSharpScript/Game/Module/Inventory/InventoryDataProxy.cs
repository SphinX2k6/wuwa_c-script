using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x02004807 RID: 18439
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class InventoryDataProxy
	{
		// Token: 0x0602E4DA RID: 189658
		public abstract List<ItemMainType> GetOpenIdMainTypeConfig();

		// Token: 0x0602E4DB RID: 189659
		public abstract HashSet<ItemDataBase> GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId mainType);

		// Token: 0x0602E4DC RID: 189660
		public abstract int GetInventoryItemGridCountByMainType(InventoryDefine.EItemMainTypeId mainType);

		// Token: 0x0602E4DD RID: 189661
		public abstract bool SupportShowCurrency();

		// Token: 0x0602E4DE RID: 189662
		public abstract int GetItemCountByConfigId(int itemConfigId, int uniqueId);

		// Token: 0x0602E4DF RID: 189663
		public abstract int GetCommonItemCount(int configId, int uniqueId);

		// Token: 0x0602E4E0 RID: 189664 RVA: 0x00CEA2A5 File Offset: 0x00CE84A5
		public int GetSelectedTypeIndex()
		{
			return this.SelectedTypeIndex;
		}

		// Token: 0x0602E4E1 RID: 189665 RVA: 0x00CEA2AD File Offset: 0x00CE84AD
		public void SetSelectedTypeIndex(int index)
		{
			this.SelectedTypeIndex = index;
		}

		// Token: 0x04018A85 RID: 100997
		protected int SelectedTypeIndex;
	}
}
