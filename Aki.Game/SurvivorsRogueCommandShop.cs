using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02002065 RID: 8293
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandShop : SurvivorsRogueCommandBase
{
	// Token: 0x060147E7 RID: 83943 RVA: 0x005F9B5D File Offset: 0x005F7D5D
	public SurvivorsRogueCommandShop(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x060147E8 RID: 83944 RVA: 0x005F9B68 File Offset: 0x005F7D68
	public override string ToString()
	{
		SurvivorsOption shopData = this.GetShopData();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
		defaultInterpolatedStringHandler.AppendLiteral("[Shop] Count: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(shopData.GoodsDetails.Count);
		defaultInterpolatedStringHandler.AppendLiteral(" RefreshCost: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(shopData.RefreshCost);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060147E9 RID: 83945 RVA: 0x005F9BC4 File Offset: 0x005F7DC4
	private SurvivorsOption GetShopData()
	{
		return this.Data.ShopView.SurvivorsOption;
	}

	// Token: 0x060147EA RID: 83946 RVA: 0x005F9BD6 File Offset: 0x005F7DD6
	protected override void Back2Fore()
	{
		if (this.ViewProxy == null)
		{
			base.OpenView(EUiViewName.SurvivorsRogueShopView, false);
		}
	}

	// Token: 0x060147EB RID: 83947 RVA: 0x005F9BEC File Offset: 0x005F7DEC
	protected override void Fore2Back()
	{
	}

	// Token: 0x060147EC RID: 83948 RVA: 0x005F9BEE File Offset: 0x005F7DEE
	protected override void OnStartExecute()
	{
		base.OpenView(EUiViewName.SurvivorsRogueShopView, false);
	}

	// Token: 0x060147ED RID: 83949 RVA: 0x005F9BFC File Offset: 0x005F7DFC
	protected override void OnExecute()
	{
	}

	// Token: 0x060147EE RID: 83950 RVA: 0x005F9BFE File Offset: 0x005F7DFE
	protected override void OnFinish()
	{
		base.RequestCommand(new int[]
		{
			-2
		}, null);
	}

	// Token: 0x060147EF RID: 83951 RVA: 0x005F9C12 File Offset: 0x005F7E12
	protected override void OnDelete()
	{
	}

	// Token: 0x060147F0 RID: 83952 RVA: 0x005F9C14 File Offset: 0x005F7E14
	[NullableContext(2)]
	public void RequestLock(int dataIncId, bool isLock, Action<bool> callback = null)
	{
		if (!this.InForeground)
		{
			return;
		}
		if (base.IsFinished)
		{
			return;
		}
		SurvivorsRogueController.Instance.RequestDataLock(this.IncId, dataIncId, isLock, delegate(bool success)
		{
			Action<bool> callback2 = callback;
			if (callback2 != null)
			{
				callback2(success);
			}
			if (!success)
			{
				return;
			}
			if (isLock)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SurvivorsCard_LockTips", Array.Empty<object>());
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("SurvivorsCard_UnLockTips", Array.Empty<object>());
		});
	}

	// Token: 0x060147F1 RID: 83953 RVA: 0x005F9C6C File Offset: 0x005F7E6C
	[NullableContext(2)]
	public ISurvivorsShopViewInfo GetViewInfo()
	{
		SurvivorsOption shopData = this.GetShopData();
		return new SurvivorsShopViewInfo
		{
			DataList = new List<GoodsDetail>(shopData.GoodsDetails),
			RefreshItemId = shopData.RefreshItem,
			RefreshCost = shopData.RefreshCost
		};
	}

	// Token: 0x060147F2 RID: 83954 RVA: 0x005F9CB0 File Offset: 0x005F7EB0
	public bool IsShopPurchaseAvailable()
	{
		int currencyCount = SurvivorsRogueModel.Instance.BattleData.GetCurrencyCount();
		foreach (GoodsDetail goodsDetail in this.GetShopData().GoodsDetails)
		{
			if (!goodsDetail.IsSell && goodsDetail.CurPrice <= currencyCount)
			{
				return true;
			}
		}
		return false;
	}
}
