using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020029F5 RID: 10741
public class ShopItem : UiPanelBase
{
	// Token: 0x0601647D RID: 91261 RVA: 0x005A2924 File Offset: 0x005A0B24
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

	// Token: 0x0601647E RID: 91262 RVA: 0x005A2AC8 File Offset: 0x005A0CC8
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

	// Token: 0x0601647F RID: 91263 RVA: 0x005A2C64 File Offset: 0x005A0E64
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

	// Token: 0x06016480 RID: 91264 RVA: 0x005A2E28 File Offset: 0x005A1028
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

	// Token: 0x06016481 RID: 91265 RVA: 0x005A2EFF File Offset: 0x005A10FF
	public void Tick()
	{
		this.UpdateLockState();
		this.UpdateLimitTime();
	}

	// Token: 0x06016482 RID: 91266 RVA: 0x005A2F0D File Offset: 0x005A110D
	private void ButtonClick()
	{
		ShopModel.Instance.OpenItemInfo = this.ItemInfo;
		EventSystem.Instance.Emit(EEventName.OpenItemInfo);
	}

	// Token: 0x0400A5B7 RID: 42423
	private const int SECONDS_PER_DAY = 86400;

	// Token: 0x0400A5B8 RID: 42424
	private readonly FColor red = new FColor(byte.MaxValue, 0, 0, byte.MaxValue);

	// Token: 0x0400A5B9 RID: 42425
	private readonly FColor soldOutColor = FColor.FromHex("FFFFFFFF");

	// Token: 0x0400A5BA RID: 42426
	private readonly FColor coinNotEnoughColor = FColor.FromHex("9D2437FF");

	// Token: 0x0400A5BB RID: 42427
	[Nullable(2)]
	public ShopItemFullInfo ItemInfo;

	// Token: 0x0200902E RID: 36910
	private enum EShopItemDefine
	{
		// Token: 0x0402EADA RID: 191194
		Button,
		// Token: 0x0402EADB RID: 191195
		Name,
		// Token: 0x0402EADC RID: 191196
		Icon,
		// Token: 0x0402EADD RID: 191197
		Quality,
		// Token: 0x0402EADE RID: 191198
		Quality2,
		// Token: 0x0402EADF RID: 191199
		Count,
		// Token: 0x0402EAE0 RID: 191200
		CurrencyIcon,
		// Token: 0x0402EAE1 RID: 191201
		PriceText,
		// Token: 0x0402EAE2 RID: 191202
		OriginalPriceText,
		// Token: 0x0402EAE3 RID: 191203
		PurchaseLimitText,
		// Token: 0x0402EAE4 RID: 191204
		LimitTimeText,
		// Token: 0x0402EAE5 RID: 191205
		UnLockItem,
		// Token: 0x0402EAE6 RID: 191206
		LockItem,
		// Token: 0x0402EAE7 RID: 191207
		LockConditionItem,
		// Token: 0x0402EAE8 RID: 191208
		LockConditionText,
		// Token: 0x0402EAE9 RID: 191209
		LockLimitText
	}
}
