using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x020011E9 RID: 4585
[NullableContext(1)]
[Nullable(0)]
public class ActivityShopGridItem : ActivityGrid
{
	// Token: 0x06007A71 RID: 31345 RVA: 0x0019C8BF File Offset: 0x0019AABF
	protected override void OnStart()
	{
		base.OnStart();
		base.SetExtraFunction(new Action<PayShopItem, PayShopGoods>(this.ClearNewFlagState));
		base.SetRedDotState(false);
	}

	// Token: 0x06007A72 RID: 31346 RVA: 0x0019C8E0 File Offset: 0x0019AAE0
	public override void Refresh(IPayShopUnionData data, bool isSelected, int gridIndex)
	{
		PayShopGoods payShopGoods = data as PayShopGoods;
		if (payShopGoods == null)
		{
			return;
		}
		base.Refresh(payShopGoods, isSelected, gridIndex);
		base.SetNewFlagState(payShopGoods.GetIfNeedRemind());
	}

	// Token: 0x06007A73 RID: 31347 RVA: 0x0019C90D File Offset: 0x0019AB0D
	private void ClearNewFlagState(PayShopItem item, PayShopGoods data)
	{
		base.SetNewFlagState(data.GetIfNeedRemind());
	}
}
