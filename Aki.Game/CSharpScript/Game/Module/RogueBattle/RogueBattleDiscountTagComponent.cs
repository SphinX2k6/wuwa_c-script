using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EA5 RID: 20133
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleDiscountTagComponent : MediumItemGridComponent
	{
		// Token: 0x06033BB3 RID: 211891 RVA: 0x00C1E751 File Offset: 0x00C1C951
		protected override string GetResourceId()
		{
			return "UiItem_ItemDiscountTag";
		}

		// Token: 0x06033BB4 RID: 211892 RVA: 0x00C1E758 File Offset: 0x00C1C958
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06033BB5 RID: 211893 RVA: 0x00C1E77C File Offset: 0x00C1C97C
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
