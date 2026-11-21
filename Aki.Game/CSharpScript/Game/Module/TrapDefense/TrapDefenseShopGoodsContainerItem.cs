using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A75 RID: 14965
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseShopGoodsContainerItem : GridProxyAbstract<TrapDefenseShopGoodsListData>
	{
		// Token: 0x0602673C RID: 157500 RVA: 0x00AC52E4 File Offset: 0x00AC34E4
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

		// Token: 0x0602673D RID: 157501 RVA: 0x00AC536E File Offset: 0x00AC356E
		protected override void OnStart()
		{
			this.GridLayout = new GenericLayout<TrapDefenseShopGoodsItem, ITrapDefenseShopGoods>(base.GetGridLayout(1), () => new TrapDefenseShopGoodsItem(), null, false, true);
		}

		// Token: 0x0602673E RID: 157502 RVA: 0x00AC53A4 File Offset: 0x00AC35A4
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

		// Token: 0x04015158 RID: 86360
		private GenericLayout<TrapDefenseShopGoodsItem, ITrapDefenseShopGoods> GridLayout;

		// Token: 0x02009661 RID: 38497
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402EF24 RID: 192292
			public const int TextTitle = 0;

			// Token: 0x0402EF25 RID: 192293
			public const int LayoutItems = 1;

			// Token: 0x0402EF26 RID: 192294
			public const int ItemGrid = 2;
		}
	}
}
