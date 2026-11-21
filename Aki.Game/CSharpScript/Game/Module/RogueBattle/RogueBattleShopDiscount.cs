using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E70 RID: 15984
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleShopDiscount : MediumItemGridComponent
	{
		// Token: 0x06028A22 RID: 166434 RVA: 0x00B67D0C File Offset: 0x00B65F0C
		protected override string GetResourceId()
		{
			return "UiItem_ItemDiscount";
		}

		// Token: 0x06028A23 RID: 166435 RVA: 0x00B67D13 File Offset: 0x00B65F13
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(0, typeof(UUITexture))
			};
		}

		// Token: 0x06028A24 RID: 166436 RVA: 0x00B67D4C File Offset: 0x00B65F4C
		protected override void OnRefresh(object data)
		{
			RogueResGainData rogueResGainData = (RogueResGainData)data;
			if (rogueResGainData.RogueResShopToken == null)
			{
				return;
			}
			RogueResShopToken rogueResShopToken = rogueResGainData.RogueResShopToken;
			if (rogueResShopToken.CurPrice != rogueResShopToken.SourcePrice)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RogueInfoViewShopPriceWithDiscount", new <>z__ReadOnlyArray<object>(new object[]
				{
					rogueResShopToken.CurPrice,
					rogueResShopToken.SourcePrice
				}));
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RogueInfoViewShopPrice", new <>z__ReadOnlySingleElementList<object>(rogueResShopToken.SourcePrice));
			}
			if (rogueResShopToken.ItemId != 0)
			{
				RogueCurrency? rogueCurrencyConfig = RoguelikeConfig.Instance.GetRogueCurrencyConfig(rogueResShopToken.ItemId);
				base.SetTextureByPath(((rogueCurrencyConfig != null) ? rogueCurrencyConfig.GetValueOrDefault().IconSmall : null) ?? string.Empty, base.GetTexture(0), null, null);
			}
		}
	}
}
