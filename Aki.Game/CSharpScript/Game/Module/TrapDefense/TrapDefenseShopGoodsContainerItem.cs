using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004ACD RID: 19149
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseShopGoodsContainerItem : GridProxyAbstract<TrapDefenseShopGoodsListData>
	{
		// Token: 0x060319AC RID: 203180 RVA: 0x00B81330 File Offset: 0x00B7F530
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060319AD RID: 203181 RVA: 0x00B813BA File Offset: 0x00B7F5BA
		protected override void OnStart()
		{
			this.GridLayout = new GenericLayout<TrapDefenseShopGoodsItem, ITrapDefenseShopGoods>(base.GetGridLayout(1), () => new TrapDefenseShopGoodsItem(), null, false, true);
		}

		// Token: 0x060319AE RID: 203182 RVA: 0x00B813F0 File Offset: 0x00B7F5F0
		public override void Refresh(TrapDefenseShopGoodsListData data, bool isSelected, int gridIndex)
		{
			if (data.Type == ETrapDefenseShopGoodsType.Item)
			{
				int ownItemTypeCount = TrapDefenseModel.Instance.BattleInventoryData.GetOwnItemTypeCount();
				int value = 8;
				LguiUtil instance = LguiUtil.Instance;
				UUIText text = base.GetText(0);
				string textStringId = ETrapDefenseTextKey.ShopGoodsItem.ToString();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(ownItemTypeCount);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), ETrapDefenseTextKey.ShopGoodsBuff.ToString(), Array.Empty<object>());
			}
			this.GridLayout.RefreshByData(data.GoodsList, null, false);
		}

		// Token: 0x0401A806 RID: 108550
		private GenericLayout<TrapDefenseShopGoodsItem, ITrapDefenseShopGoods> GridLayout;

		// Token: 0x0200AC41 RID: 44097
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04034573 RID: 214387
			public const int TextTitle = 0;

			// Token: 0x04034574 RID: 214388
			public const int LayoutItems = 1;

			// Token: 0x04034575 RID: 214389
			public const int ItemGrid = 2;
		}
	}
}
