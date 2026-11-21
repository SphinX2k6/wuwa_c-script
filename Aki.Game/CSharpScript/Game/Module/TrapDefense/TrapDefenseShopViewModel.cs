using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A33 RID: 14899
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseShopViewModel
	{
		// Token: 0x06026501 RID: 156929 RVA: 0x00ABB0AF File Offset: 0x00AB92AF
		public static TrapDefenseShopViewModel Create()
		{
			return new TrapDefenseShopViewModel();
		}

		// Token: 0x06026502 RID: 156930 RVA: 0x00ABB0B6 File Offset: 0x00AB92B6
		public void AddOnSelectGoodsDelegate(Action<ITrapDefenseShopGoods> @delegate)
		{
			this.DelegatesOnSelectGoods.Add(@delegate);
		}

		// Token: 0x06026503 RID: 156931 RVA: 0x00ABB0C4 File Offset: 0x00AB92C4
		public void RemoveOnSelectGoodsDelegate(Action<ITrapDefenseShopGoods> @delegate)
		{
			int num = this.DelegatesOnSelectGoods.IndexOf(@delegate);
			if (num >= 0)
			{
				this.DelegatesOnSelectGoods.RemoveAt(num);
			}
		}

		// Token: 0x06026504 RID: 156932 RVA: 0x00ABB0F0 File Offset: 0x00AB92F0
		public void SelectGoods(ITrapDefenseShopGoods goods)
		{
			this.SelectedGoods = goods;
			foreach (Action<ITrapDefenseShopGoods> action in this.DelegatesOnSelectGoods)
			{
				action(goods);
			}
		}

		// Token: 0x06026505 RID: 156933 RVA: 0x00ABB148 File Offset: 0x00AB9348
		public void OnViewClose()
		{
			this.SelectedGoods = null;
			this.DelegatesOnSelectGoods.Clear();
		}

		// Token: 0x0401508C RID: 86156
		[Nullable(2)]
		public ITrapDefenseShopGoods SelectedGoods;

		// Token: 0x0401508D RID: 86157
		private readonly List<Action<ITrapDefenseShopGoods>> DelegatesOnSelectGoods = new List<Action<ITrapDefenseShopGoods>>();
	}
}
