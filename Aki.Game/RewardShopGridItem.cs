using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02000815 RID: 2069
[NullableContext(1)]
[Nullable(0)]
public class RewardShopGridItem : PayShopItem
{
	// Token: 0x06005DD8 RID: 24024 RVA: 0x001E187C File Offset: 0x001DFA7C
	protected override void OnStart()
	{
		base.OnStart();
		base.SetExtraFunction(new Action<PayShopItem, PayShopGoods>(this.ClearNewFlagState));
	}

	// Token: 0x06005DD9 RID: 24025 RVA: 0x001E1898 File Offset: 0x001DFA98
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

	// Token: 0x06005DDA RID: 24026 RVA: 0x001E18CC File Offset: 0x001DFACC
	private void ClearNewFlagState(PayShopItem item, PayShopGoods data)
	{
		if (MoonChasingRewardModel.Instance.ReadShopItemUnlockFlag(data))
		{
			base.SetNewFlagState(false);
		}
	}
}
