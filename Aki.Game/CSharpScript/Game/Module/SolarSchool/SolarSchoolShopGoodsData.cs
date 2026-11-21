using System;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058E2 RID: 22754
	public sealed class SolarSchoolShopGoodsData
	{
		// Token: 0x17006B85 RID: 27525
		// (get) Token: 0x06038137 RID: 229687 RVA: 0x00FACF22 File Offset: 0x00FAB122
		public int ShopId { get; }

		// Token: 0x17006B86 RID: 27526
		// (get) Token: 0x06038138 RID: 229688 RVA: 0x00FACF2A File Offset: 0x00FAB12A
		public SolarSchoolShopGoods Goods { get; }

		// Token: 0x17006B87 RID: 27527
		// (get) Token: 0x06038139 RID: 229689 RVA: 0x00FACF32 File Offset: 0x00FAB132
		public SolarSchoolItem Item { get; }

		// Token: 0x17006B88 RID: 27528
		// (get) Token: 0x0603813A RID: 229690 RVA: 0x00FACF3A File Offset: 0x00FAB13A
		public int BuyLimit { get; }

		// Token: 0x17006B89 RID: 27529
		// (get) Token: 0x0603813B RID: 229691 RVA: 0x00FACF42 File Offset: 0x00FAB142
		// (set) Token: 0x0603813C RID: 229692 RVA: 0x00FACF4A File Offset: 0x00FAB14A
		public int BoughtCount { get; private set; }

		// Token: 0x0603813D RID: 229693 RVA: 0x00FACF53 File Offset: 0x00FAB153
		public SolarSchoolShopGoodsData(int shopId, SolarSchoolShopGoods goods, SolarSchoolItem item, int boughtCount)
		{
			this.ShopId = shopId;
			this.Goods = goods;
			this.Item = item;
			this.BoughtCount = Math.Max(0, boughtCount);
			this.BuyLimit = Math.Max(0, goods.BuyLimit);
		}

		// Token: 0x0603813E RID: 229694 RVA: 0x00FACF94 File Offset: 0x00FAB194
		public int GetPrice()
		{
			int bonus = SolarSchoolGamePlayModel.Instance.GetBonus(ESolarSchoolBonusType.ShopPriceDiscount, 0);
			long num = (long)Math.Max(0, this.Goods.Price);
			if (num > 0L && this.Goods.Discount > 0)
			{
				num = Math.Max(1L, num * (long)Math.Clamp(this.Goods.Discount, 0, 1000) / 1000L);
			}
			num = num * (long)(10000 - Math.Clamp(bonus, 0, 10000)) / 10000L;
			if (this.Goods.Price > 0)
			{
				int discount = this.Goods.Discount;
				if (discount > 0 && discount < 1000)
				{
					num = Math.Max(1L, num);
				}
			}
			return (int)num;
		}

		// Token: 0x0603813F RID: 229695 RVA: 0x00FAD05A File Offset: 0x00FAB25A
		public int GetRemainingCount()
		{
			if (this.BuyLimit <= 0)
			{
				return int.MaxValue;
			}
			return Math.Max(0, this.BuyLimit - this.BoughtCount);
		}

		// Token: 0x06038140 RID: 229696 RVA: 0x00FAD07E File Offset: 0x00FAB27E
		public bool IsSoldOut()
		{
			return this.GetRemainingCount() == 0;
		}

		// Token: 0x06038141 RID: 229697 RVA: 0x00FAD08C File Offset: 0x00FAB28C
		public bool IsDiscounted()
		{
			int discount = this.Goods.Discount;
			return discount > 0 && discount < 1000;
		}

		// Token: 0x06038142 RID: 229698 RVA: 0x00FAD0B6 File Offset: 0x00FAB2B6
		public void AddBoughtCount(int count)
		{
			this.BoughtCount = (int)Math.Min((long)this.BoughtCount + (long)count, 2147483647L);
		}

		// Token: 0x0401D8C1 RID: 121025
		private const int DiscountRateBase = 1000;

		// Token: 0x0401D8C2 RID: 121026
		private const int BonusRateBase = 10000;
	}
}
