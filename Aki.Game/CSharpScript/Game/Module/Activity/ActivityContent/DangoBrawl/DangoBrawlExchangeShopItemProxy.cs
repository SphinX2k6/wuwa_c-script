using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200578E RID: 22414
	public class DangoBrawlExchangeShopItemProxy : DangoBrawlShopItemProxy
	{
		// Token: 0x06037513 RID: 226579 RVA: 0x00F73301 File Offset: 0x00F71501
		[NullableContext(1)]
		public override void UpdateFromPayShopGoods(PayShopGoods payShopGoods)
		{
			base.UpdateFromPayShopGoods(payShopGoods);
			base.RaycastTarget = false;
			base.RedDotVisible = false;
		}
	}
}
