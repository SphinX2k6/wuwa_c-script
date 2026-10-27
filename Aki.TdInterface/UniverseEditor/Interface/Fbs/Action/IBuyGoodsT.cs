using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006237 RID: 25143
	public class IBuyGoodsT
	{
		// Token: 0x1700BB5A RID: 47962
		// (get) Token: 0x0602B580 RID: 177536 RVA: 0x005F7C64 File Offset: 0x005F5E64
		// (set) Token: 0x0602B581 RID: 177537 RVA: 0x005F7C6C File Offset: 0x005F5E6C
		public ESystemFunction Type { get; set; }

		// Token: 0x1700BB5B RID: 47963
		// (get) Token: 0x0602B582 RID: 177538 RVA: 0x005F7C75 File Offset: 0x005F5E75
		// (set) Token: 0x0602B583 RID: 177539 RVA: 0x005F7C7D File Offset: 0x005F5E7D
		public int GoodsId { get; set; }

		// Token: 0x0602B584 RID: 177540 RVA: 0x005F7C86 File Offset: 0x005F5E86
		public IBuyGoodsT()
		{
			this.Type = ESystemFunction.BuyGoods;
			this.GoodsId = 0;
		}
	}
}
