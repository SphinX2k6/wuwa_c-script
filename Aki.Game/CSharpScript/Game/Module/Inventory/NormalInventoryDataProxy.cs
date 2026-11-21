using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x02004808 RID: 18440
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalInventoryDataProxy : InventoryDataProxy
	{
		// Token: 0x0602E4E3 RID: 189667 RVA: 0x00CEA2BE File Offset: 0x00CE84BE
		public NormalInventoryDataProxy(InventoryModel model)
		{
			this.Model = model;
		}

		// Token: 0x0602E4E4 RID: 189668 RVA: 0x00CEA2CD File Offset: 0x00CE84CD
		public override List<ItemMainType> GetOpenIdMainTypeConfig()
		{
			return this.Model.GetOpenIdMainTypeConfigBase();
		}

		// Token: 0x0602E4E5 RID: 189669 RVA: 0x00CEA2DA File Offset: 0x00CE84DA
		public override HashSet<ItemDataBase> GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId mainType)
		{
			return this.Model.GetItemDataBaseByMainTypeBase(mainType);
		}

		// Token: 0x0602E4E6 RID: 189670 RVA: 0x00CEA2E8 File Offset: 0x00CE84E8
		public override int GetInventoryItemGridCountByMainType(InventoryDefine.EItemMainTypeId mainType)
		{
			return this.Model.GetInventoryItemGridCountByMainTypeBase(mainType);
		}

		// Token: 0x0602E4E7 RID: 189671 RVA: 0x00CEA2F6 File Offset: 0x00CE84F6
		public override bool SupportShowCurrency()
		{
			return true;
		}

		// Token: 0x0602E4E8 RID: 189672 RVA: 0x00CEA2F9 File Offset: 0x00CE84F9
		public override int GetItemCountByConfigId(int itemConfigId, int uniqueId)
		{
			return this.Model.GetItemCountByConfigIdBase(itemConfigId, uniqueId);
		}

		// Token: 0x0602E4E9 RID: 189673 RVA: 0x00CEA308 File Offset: 0x00CE8508
		public override int GetCommonItemCount(int configId, int uniqueId)
		{
			return this.Model.GetCommonItemCountBase(configId, uniqueId);
		}

		// Token: 0x04018A86 RID: 100998
		private readonly InventoryModel Model;
	}
}
