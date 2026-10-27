using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02002AE9 RID: 10985
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandShop : SurvivorsRogueCommandBase
{
	// Token: 0x06016DB6 RID: 93622 RVA: 0x005CD00D File Offset: 0x005CB20D
	public SurvivorsRogueCommandShop(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x06016DB7 RID: 93623 RVA: 0x005CD018 File Offset: 0x005CB218
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

	// Token: 0x06016DB8 RID: 93624 RVA: 0x005CD074 File Offset: 0x005CB274
	private SurvivorsOption GetShopData()
	{
		return this.Data.ShopView.SurvivorsOption;
	}

	// Token: 0x06016DB9 RID: 93625 RVA: 0x005CD086 File Offset: 0x005CB286
	protected override void Back2Fore()
	{
		if (this.ViewProxy == null)
		{
			base.OpenView(EUiViewName.SurvivorsRogueShopView, false);
		}
	}

	// Token: 0x06016DBA RID: 93626 RVA: 0x005CD09C File Offset: 0x005CB29C
	protected override void Fore2Back()
	{
	}

	// Token: 0x06016DBB RID: 93627 RVA: 0x005CD09E File Offset: 0x005CB29E
	protected override void OnStartExecute()
	{
		base.OpenView(EUiViewName.SurvivorsRogueShopView, false);
	}

	// Token: 0x06016DBC RID: 93628 RVA: 0x005CD0AC File Offset: 0x005CB2AC
	protected override void OnExecute()
	{
	}

	// Token: 0x06016DBD RID: 93629 RVA: 0x005CD0AE File Offset: 0x005CB2AE
	protected override void OnFinish()
	{
		base.RequestCommand(new int[]
		{
			-2
		}, null);
	}

	// Token: 0x06016DBE RID: 93630 RVA: 0x005CD0C2 File Offset: 0x005CB2C2
	protected override void OnDelete()
	{
	}

	// Token: 0x06016DBF RID: 93631 RVA: 0x005CD0C4 File Offset: 0x005CB2C4
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

	// Token: 0x06016DC0 RID: 93632 RVA: 0x005CD11C File Offset: 0x005CB31C
	[NullableContext(2)]
	public ISurvivorsShopViewInfo GetViewInfo()
	{
		SurvivorsOption shopData = this.GetShopData();
		return new SurvivorsShopViewInfo
		{
			DataList = shopData.GoodsDetails.ToList<GoodsDetail>(),
			RefreshItemId = shopData.RefreshItem,
			RefreshCost = shopData.RefreshCost
		};
	}

	// Token: 0x06016DC1 RID: 93633 RVA: 0x005CD160 File Offset: 0x005CB360
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
