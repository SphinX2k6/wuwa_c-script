using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EA7 RID: 20135
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleShopDiscount : MediumItemGridComponent
	{
		// Token: 0x06033BB7 RID: 211895 RVA: 0x00C1E7F4 File Offset: 0x00C1C9F4
		protected override string GetResourceId()
		{
			return "UiItem_ItemDiscount";
		}

		// Token: 0x06033BB8 RID: 211896 RVA: 0x00C1E7FB File Offset: 0x00C1C9FB
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(0, typeof(UUITexture))
			};
		}

		// Token: 0x06033BB9 RID: 211897 RVA: 0x00C1E834 File Offset: 0x00C1CA34
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
