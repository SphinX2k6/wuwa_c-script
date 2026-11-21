using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E6E RID: 15982
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleDiscountTagComponent : MediumItemGridComponent
	{
		// Token: 0x06028A1E RID: 166430 RVA: 0x00B67C68 File Offset: 0x00B65E68
		protected override string GetResourceId()
		{
			return "UiItem_ItemDiscountTag";
		}

		// Token: 0x06028A1F RID: 166431 RVA: 0x00B67C6F File Offset: 0x00B65E6F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06028A20 RID: 166432 RVA: 0x00B67C94 File Offset: 0x00B65E94
		protected override void OnRefresh(object data)
		{
			RogueResGainData rogueResGainData = (RogueResGainData)data;
			if (rogueResGainData.RogueResShopToken == null)
			{
				return;
			}
			int sourcePrice = rogueResGainData.RogueResShopToken.SourcePrice;
			int num = (int)Math.Floor((double)rogueResGainData.RogueResShopToken.CurPrice / (double)sourcePrice * 100.0);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RogueInfoViewShopDiscount", new <>z__ReadOnlySingleElementList<object>((100 - num).ToString()));
		}
	}
}
