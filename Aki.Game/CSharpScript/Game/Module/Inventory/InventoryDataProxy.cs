using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x02005830 RID: 22576
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class InventoryDataProxy
	{
		// Token: 0x060395C6 RID: 234950
		public abstract List<ItemMainType> GetOpenIdMainTypeConfig();

		// Token: 0x060395C7 RID: 234951
		public abstract HashSet<ItemDataBase> GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId mainType);

		// Token: 0x060395C8 RID: 234952
		public abstract int GetInventoryItemGridCountByMainType(InventoryDefine.EItemMainTypeId mainType);

		// Token: 0x060395C9 RID: 234953
		public abstract bool SupportShowCurrency();

		// Token: 0x060395CA RID: 234954
		public abstract int GetItemCountByConfigId(int itemConfigId, int uniqueId);

		// Token: 0x060395CB RID: 234955
		public abstract int GetCommonItemCount(int configId, int uniqueId);

		// Token: 0x060395CC RID: 234956 RVA: 0x00D9B3F1 File Offset: 0x00D995F1
		public int GetSelectedTypeIndex()
		{
			return this.SelectedTypeIndex;
		}

		// Token: 0x060395CD RID: 234957 RVA: 0x00D9B3F9 File Offset: 0x00D995F9
		public void SetSelectedTypeIndex(int index)
		{
			this.SelectedTypeIndex = index;
		}

		// Token: 0x0401DFEC RID: 122860
		protected int SelectedTypeIndex;
	}
}
