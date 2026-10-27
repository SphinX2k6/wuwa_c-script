using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x02005831 RID: 22577
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalInventoryDataProxy : InventoryDataProxy
	{
		// Token: 0x060395CF RID: 234959 RVA: 0x00D9B40A File Offset: 0x00D9960A
		public NormalInventoryDataProxy(InventoryModel model)
		{
			this.Model = model;
		}

		// Token: 0x060395D0 RID: 234960 RVA: 0x00D9B419 File Offset: 0x00D99619
		public override List<ItemMainType> GetOpenIdMainTypeConfig()
		{
			return this.Model.GetOpenIdMainTypeConfigBase();
		}

		// Token: 0x060395D1 RID: 234961 RVA: 0x00D9B426 File Offset: 0x00D99626
		public override HashSet<ItemDataBase> GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId mainType)
		{
			return this.Model.GetItemDataBaseByMainTypeBase(mainType);
		}

		// Token: 0x060395D2 RID: 234962 RVA: 0x00D9B434 File Offset: 0x00D99634
		public override int GetInventoryItemGridCountByMainType(InventoryDefine.EItemMainTypeId mainType)
		{
			return this.Model.GetInventoryItemGridCountByMainTypeBase(mainType);
		}

		// Token: 0x060395D3 RID: 234963 RVA: 0x00D9B442 File Offset: 0x00D99642
		public override bool SupportShowCurrency()
		{
			return true;
		}

		// Token: 0x060395D4 RID: 234964 RVA: 0x00D9B445 File Offset: 0x00D99645
		public override int GetItemCountByConfigId(int itemConfigId, int uniqueId)
		{
			return this.Model.GetItemCountByConfigIdBase(itemConfigId, uniqueId);
		}

		// Token: 0x060395D5 RID: 234965 RVA: 0x00D9B454 File Offset: 0x00D99654
		public override int GetCommonItemCount(int configId, int uniqueId)
		{
			return this.Model.GetCommonItemCountBase(configId, uniqueId);
		}

		// Token: 0x0401DFED RID: 122861
		private readonly InventoryModel Model;
	}
}
