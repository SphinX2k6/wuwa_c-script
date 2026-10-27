using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006582 RID: 25986
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingLimitTimeShopGridItem : PayShopItem
	{
		// Token: 0x06041213 RID: 266771 RVA: 0x00FC8BF9 File Offset: 0x00FC6DF9
		public FishingLimitTimeShopGridItem(ActivityFishingData ActivityDataBase)
		{
		}

		// Token: 0x06041214 RID: 266772 RVA: 0x00FC8C01 File Offset: 0x00FC6E01
		protected override void OnStart()
		{
			base.OnStart();
			base.SetExtraFunction(new Action<PayShopItem, PayShopGoods>(this.ClearNewFlagState));
			base.SetRedDotState(false);
		}

		// Token: 0x06041215 RID: 266773 RVA: 0x00FC8C24 File Offset: 0x00FC6E24
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

		// Token: 0x06041216 RID: 266774 RVA: 0x00FC8C51 File Offset: 0x00FC6E51
		private void ClearNewFlagState(PayShopItem item, PayShopGoods data)
		{
			base.SetNewFlagState(data.GetIfNeedRemind());
		}
	}
}
