using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02001361 RID: 4961
[NullableContext(1)]
[Nullable(0)]
public class RewardShopGridItem : PayShopItem
{
	// Token: 0x06008A3D RID: 35389 RVA: 0x001D8A20 File Offset: 0x001D6C20
	protected override void OnStart()
	{
		base.OnStart();
		base.SetExtraFunction(new Action<PayShopItem, PayShopGoods>(this.ClearNewFlagState));
	}

	// Token: 0x06008A3E RID: 35390 RVA: 0x001D8A3C File Offset: 0x001D6C3C
	public override void Refresh(IPayShopUnionData data, bool isSelected, int gridIndex)
	{
		PayShopGoods payShopGoods = data as PayShopGoods;
		if (payShopGoods == null)
		{
			return;
		}
		base.Refresh(payShopGoods, isSelected, gridIndex);
		bool newFlagState = MoonChasingRewardModel.Instance.CheckShopItemRedDotState(payShopGoods);
		base.SetNewFlagState(newFlagState);
	}

	// Token: 0x06008A3F RID: 35391 RVA: 0x001D8A70 File Offset: 0x001D6C70
	private void ClearNewFlagState(PayShopItem item, PayShopGoods data)
	{
		if (MoonChasingRewardModel.Instance.ReadShopItemUnlockFlag(data))
		{
			base.SetNewFlagState(false);
		}
	}
}
