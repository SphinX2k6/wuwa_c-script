using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A8B RID: 19083
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseShopViewModel
	{
		// Token: 0x06031771 RID: 202609 RVA: 0x00B770FB File Offset: 0x00B752FB
		public static TrapDefenseShopViewModel Create()
		{
			return new TrapDefenseShopViewModel();
		}

		// Token: 0x06031772 RID: 202610 RVA: 0x00B77102 File Offset: 0x00B75302
		public void AddOnSelectGoodsDelegate(Action<ITrapDefenseShopGoods> @delegate)
		{
			this.DelegatesOnSelectGoods.Add(@delegate);
		}

		// Token: 0x06031773 RID: 202611 RVA: 0x00B77110 File Offset: 0x00B75310
		public void RemoveOnSelectGoodsDelegate(Action<ITrapDefenseShopGoods> @delegate)
		{
			int num = this.DelegatesOnSelectGoods.IndexOf(@delegate);
			if (num >= 0)
			{
				this.DelegatesOnSelectGoods.RemoveAt(num);
			}
		}

		// Token: 0x06031774 RID: 202612 RVA: 0x00B7713C File Offset: 0x00B7533C
		public void SelectGoods(ITrapDefenseShopGoods goods)
		{
			this.SelectedGoods = goods;
			foreach (Action<ITrapDefenseShopGoods> action in this.DelegatesOnSelectGoods)
			{
				action(goods);
			}
		}

		// Token: 0x06031775 RID: 202613 RVA: 0x00B77194 File Offset: 0x00B75394
		public void OnViewClose()
		{
			this.SelectedGoods = null;
			this.DelegatesOnSelectGoods.Clear();
		}

		// Token: 0x0401A73A RID: 108346
		[Nullable(2)]
		public ITrapDefenseShopGoods SelectedGoods;

		// Token: 0x0401A73B RID: 108347
		private readonly List<Action<ITrapDefenseShopGoods>> DelegatesOnSelectGoods = new List<Action<ITrapDefenseShopGoods>>();
	}
}
