using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F70 RID: 8048
public class ShopItem : UiPanelBase
{
	// Token: 0x06013E84 RID: 81540 RVA: 0x005CD8FC File Offset: 0x005CBAFC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick))
		};
	}

	// Token: 0x06013E85 RID: 81541 RVA: 0x005CDAA0 File Offset: 0x005CBCA0
	[NullableContext(1)]
	public void UpdateItem(ShopItemFullInfo data)
	{
		if (data == null)
		{
			return;
		}
		this.RootItem.SetAsLastHierarchy();
		this.ItemInfo = data;
		base.SetItemIcon(base.GetTexture(2), this.ItemInfo.ItemId, null, null);
		base.SetItemQualityIcon(base.GetSprite(3), this.ItemInfo.ItemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		base.SetItemQualityIcon(base.GetSprite(4), this.ItemInfo.ItemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		LguiUtil.Instance.SetLocalText(base.GetText(5), "ShowCount", new <>z__ReadOnlySingleElementList<object>(data.StackSize));
		ItemConfig itemInfo = this.ItemInfo.ItemInfo;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), itemInfo.Name, Array.Empty<object>());
		base.SetItemIcon(base.GetTexture(6), data.GetMoneyId(), null, null);
		if (!data.IsAffordable(1))
		{
			base.GetText(7).SetColor(this.coinNotEnoughColor);
		}
		base.GetText(7).SetText(data.GetDefaultPrice().ToString(), true);
		UUIText text = base.GetText(8);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
		defaultInterpolatedStringHandler.AppendLiteral("<s>");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.ItemInfo.GetOriginalPrice());
		defaultInterpolatedStringHandler.AppendLiteral("</s>");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.GetText(8).SetUIActive(this.ItemInfo.GetOriginalPrice() != -1);
		this.UpdateLockState();
		this.UpdateLimitTime();
	}

	// Token: 0x06013E86 RID: 81542 RVA: 0x005CDC3C File Offset: 0x005CBE3C
	protected void UpdateLockState()
	{
		bool flag = this.ItemInfo.IsInteractive();
		base.GetItem(12).SetUIActive(!flag);
		base.GetItem(11).SetAlpha((!flag) ? 0.5f : 1f);
		base.GetItem(13).SetUIActive(!this.ItemInfo.IsUnlocked());
		base.GetText(9).SetUIActive(this.ItemInfo.BuyLimit != -1);
		if (this.ItemInfo.BuyLimit != -1)
		{
			base.GetText(9).SetUIActive(true);
			LguiUtil.Instance.SetLocalText(base.GetText(9), "ShopItemLimitCount", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.ItemInfo.BuyLimit - this.ItemInfo.BoughtCount,
				this.ItemInfo.BuyLimit
			}));
		}
		if (!this.ItemInfo.IsUnlocked())
		{
			base.GetText(15).SetUIActive(false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), this.ItemInfo.LockInfo, Array.Empty<object>());
			return;
		}
		if (this.ItemInfo.IsSoldOut())
		{
			base.GetText(15).SetColor(this.soldOutColor);
			base.GetText(15).SetUIActive(true);
			LguiUtil.Instance.SetLocalText(base.GetText(15), "ShopItemSoldOut", Array.Empty<object>());
			return;
		}
		if (this.ItemInfo.IsOutOfDate())
		{
			LguiUtil.Instance.SetLocalText(base.GetText(15), "ShopItemTimeout", Array.Empty<object>());
			base.GetText(15).SetColor(this.red);
			base.GetText(15).SetUIActive(true);
		}
	}

	// Token: 0x06013E87 RID: 81543 RVA: 0x005CDE00 File Offset: 0x005CC000
	protected void UpdateLimitTime()
	{
		if (this.ItemInfo.EndTime != 0U)
		{
			double num = this.ItemInfo.EndTime - TimeUtil.Instance.GetServerTimeStamp();
			int num2 = (int)(num / 86400.0);
			if (num2 > 0)
			{
				LguiUtil.Instance.SetLocalText(base.GetText(10), "ShopItemLimitTime1", new <>z__ReadOnlySingleElementList<object>(num2));
			}
			else if (num2 == 0)
			{
				int num3 = (int)(num / 3600.0);
				int num4 = (int)(num / 60.0) % 60;
				LguiUtil.Instance.SetLocalText(base.GetText(10), "ShopItemLimitTime2", new <>z__ReadOnlyArray<object>(new object[]
				{
					num3,
					num4
				}));
			}
		}
		base.GetText(10).SetUIActive(this.ItemInfo.InSaleTime());
	}

	// Token: 0x06013E88 RID: 81544 RVA: 0x005CDED7 File Offset: 0x005CC0D7
	public void Tick()
	{
		this.UpdateLockState();
		this.UpdateLimitTime();
	}

	// Token: 0x06013E89 RID: 81545 RVA: 0x005CDEE5 File Offset: 0x005CC0E5
	private void ButtonClick()
	{
		ShopModel.Instance.OpenItemInfo = this.ItemInfo;
		EventSystem.Instance.Emit(EEventName.OpenItemInfo);
	}

	// Token: 0x0400A9A1 RID: 43425
	private const int SECONDS_PER_DAY = 86400;

	// Token: 0x0400A9A2 RID: 43426
	private readonly FColor red = new FColor(byte.MaxValue, 0, 0, byte.MaxValue);

	// Token: 0x0400A9A3 RID: 43427
	private readonly FColor soldOutColor = FColor.FromHex("FFFFFFFF");

	// Token: 0x0400A9A4 RID: 43428
	private readonly FColor coinNotEnoughColor = FColor.FromHex("9D2437FF");

	// Token: 0x0400A9A5 RID: 43429
	[Nullable(2)]
	public ShopItemFullInfo ItemInfo;

	// Token: 0x02008275 RID: 33397
	private enum EShopItemDefine
	{
		// Token: 0x0402A1D2 RID: 172498
		Button,
		// Token: 0x0402A1D3 RID: 172499
		Name,
		// Token: 0x0402A1D4 RID: 172500
		Icon,
		// Token: 0x0402A1D5 RID: 172501
		Quality,
		// Token: 0x0402A1D6 RID: 172502
		Quality2,
		// Token: 0x0402A1D7 RID: 172503
		Count,
		// Token: 0x0402A1D8 RID: 172504
		CurrencyIcon,
		// Token: 0x0402A1D9 RID: 172505
		PriceText,
		// Token: 0x0402A1DA RID: 172506
		OriginalPriceText,
		// Token: 0x0402A1DB RID: 172507
		PurchaseLimitText,
		// Token: 0x0402A1DC RID: 172508
		LimitTimeText,
		// Token: 0x0402A1DD RID: 172509
		UnLockItem,
		// Token: 0x0402A1DE RID: 172510
		LockItem,
		// Token: 0x0402A1DF RID: 172511
		LockConditionItem,
		// Token: 0x0402A1E0 RID: 172512
		LockConditionText,
		// Token: 0x0402A1E1 RID: 172513
		LockLimitText
	}
}
