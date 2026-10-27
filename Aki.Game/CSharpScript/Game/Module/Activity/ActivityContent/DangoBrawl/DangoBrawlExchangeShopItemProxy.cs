using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200683E RID: 26686
	public class DangoBrawlExchangeShopItemProxy : DangoBrawlShopItemProxy
	{
		// Token: 0x060429BF RID: 272831 RVA: 0x01031DF5 File Offset: 0x0102FFF5
		[NullableContext(1)]
		public override void UpdateFromPayShopGoods(PayShopGoods payShopGoods)
		{
			base.UpdateFromPayShopGoods(payShopGoods);
			base.RaycastTarget = false;
			base.RedDotVisible = false;
		}
	}
}
