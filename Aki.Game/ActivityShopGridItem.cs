using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x0200069D RID: 1693
[NullableContext(1)]
[Nullable(0)]
public class ActivityShopGridItem : ActivityGrid
{
	// Token: 0x06004E08 RID: 19976 RVA: 0x001A556B File Offset: 0x001A376B
	protected override void OnStart()
	{
		base.OnStart();
		base.SetExtraFunction(new Action<PayShopItem, PayShopGoods>(this.ClearNewFlagState));
		base.SetRedDotState(false);
	}

	// Token: 0x06004E09 RID: 19977 RVA: 0x001A558C File Offset: 0x001A378C
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

	// Token: 0x06004E0A RID: 19978 RVA: 0x001A55B9 File Offset: 0x001A37B9
	private void ClearNewFlagState(PayShopItem item, PayShopGoods data)
	{
		base.SetNewFlagState(data.GetIfNeedRemind());
	}
}
