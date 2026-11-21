using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005500 RID: 21760
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingLimitTimeShopGridItem : PayShopItem
	{
		// Token: 0x06035ED8 RID: 220888 RVA: 0x00F0FBAD File Offset: 0x00F0DDAD
		public FishingLimitTimeShopGridItem(ActivityFishingData ActivityDataBase)
		{
		}

		// Token: 0x06035ED9 RID: 220889 RVA: 0x00F0FBB5 File Offset: 0x00F0DDB5
		protected override void OnStart()
		{
			base.OnStart();
			base.SetExtraFunction(new Action<PayShopItem, PayShopGoods>(this.ClearNewFlagState));
			base.SetRedDotState(false);
		}

		// Token: 0x06035EDA RID: 220890 RVA: 0x00F0FBD8 File Offset: 0x00F0DDD8
		public override void Refresh(IPayShopUnionData data, bool isSelected, int gridIndex)
		{
			PayShopGoods payShopGoods = data as PayShopGoods;
			if (payShopGoods == null)
			{
				return;
			}
			base.Refresh(data, isSelected, gridIndex);
			base.SetNewFlagState(payShopGoods.GetIfNeedRemind());
		}

		// Token: 0x06035EDB RID: 220891 RVA: 0x00F0FC05 File Offset: 0x00F0DE05
		private void ClearNewFlagState(PayShopItem item, PayShopGoods data)
		{
			base.SetNewFlagState(data.GetIfNeedRemind());
		}
	}
}
