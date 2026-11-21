using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A8 RID: 26792
	public class IBuyGoodsT
	{
		// Token: 0x1700C4E2 RID: 50402
		// (get) Token: 0x0602DCE1 RID: 187617 RVA: 0x00642A6C File Offset: 0x00640C6C
		// (set) Token: 0x0602DCE2 RID: 187618 RVA: 0x00642A74 File Offset: 0x00640C74
		public ESystemFunction Type { get; set; }

		// Token: 0x1700C4E3 RID: 50403
		// (get) Token: 0x0602DCE3 RID: 187619 RVA: 0x00642A7D File Offset: 0x00640C7D
		// (set) Token: 0x0602DCE4 RID: 187620 RVA: 0x00642A85 File Offset: 0x00640C85
		public int GoodsId { get; set; }

		// Token: 0x0602DCE5 RID: 187621 RVA: 0x00642A8E File Offset: 0x00640C8E
		public IBuyGoodsT()
		{
			this.Type = ESystemFunction.BuyGoods;
			this.GoodsId = 0;
		}
	}
}
