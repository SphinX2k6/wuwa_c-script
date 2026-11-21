using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A08 RID: 23048
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class SolarSchoolShopGoodsRowItem : GridProxyAbstract<SolarSchoolShopGoodsRowData>
	{
		// Token: 0x17006C66 RID: 27750
		// (get) Token: 0x06038C04 RID: 232452 RVA: 0x00FE2743 File Offset: 0x00FE0943
		// (set) Token: 0x06038C05 RID: 232453 RVA: 0x00FE274B File Offset: 0x00FE094B
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SolarSchoolShopGoodsData> ClickCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x06038C06 RID: 232454 RVA: 0x00FE2754 File Offset: 0x00FE0954
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038C07 RID: 232455 RVA: 0x00FE27BD File Offset: 0x00FE09BD
		protected override void OnStart()
		{
			this.GoodsLayout = new GenericLayout<SolarSchoolShopTogItem, SolarSchoolShopSlotData>(base.GetHorizontalLayout(0), new Func<SolarSchoolShopTogItem>(this.CreateGoodsItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06038C08 RID: 232456 RVA: 0x00FE27F0 File Offset: 0x00FE09F0
		public override void Refresh(SolarSchoolShopGoodsRowData data, bool isSelected, int gridIndex)
		{
			GenericLayout<SolarSchoolShopTogItem, SolarSchoolShopSlotData> goodsLayout = this.GoodsLayout;
			if (goodsLayout == null)
			{
				return;
			}
			goodsLayout.RefreshByData(data.Slots, null, false);
		}

		// Token: 0x06038C09 RID: 232457 RVA: 0x00FE280A File Offset: 0x00FE0A0A
		public override object GetKey(SolarSchoolShopGoodsRowData data, int displayIndex)
		{
			return displayIndex;
		}

		// Token: 0x06038C0A RID: 232458 RVA: 0x00FE2814 File Offset: 0x00FE0A14
		public void SelectGoods(long goodsKey)
		{
			int num = -1;
			GenericLayout<SolarSchoolShopTogItem, SolarSchoolShopSlotData> goodsLayout = this.GoodsLayout;
			IReadOnlyList<SolarSchoolShopSlotData> readOnlyList = (goodsLayout != null) ? goodsLayout.GetDatas() : null;
			if (readOnlyList != null)
			{
				for (int i = 0; i < readOnlyList.Count; i++)
				{
					SolarSchoolShopGoodsData goods = readOnlyList[i].Goods;
					int? num2 = (goods != null) ? new int?(goods.Goods.Id) : null;
					long? num3 = (num2 != null) ? new long?((long)num2.GetValueOrDefault()) : null;
					if (num3.GetValueOrDefault() == goodsKey & num3 != null)
					{
						num = i;
						break;
					}
				}
			}
			if (num >= 0)
			{
				GenericLayout<SolarSchoolShopTogItem, SolarSchoolShopSlotData> goodsLayout2 = this.GoodsLayout;
				if (goodsLayout2 == null)
				{
					return;
				}
				goodsLayout2.SelectGridProxy(num, false);
				return;
			}
			else
			{
				GenericLayout<SolarSchoolShopTogItem, SolarSchoolShopSlotData> goodsLayout3 = this.GoodsLayout;
				if (goodsLayout3 == null)
				{
					return;
				}
				goodsLayout3.DeselectCurrentGridProxy();
				return;
			}
		}

		// Token: 0x06038C0B RID: 232459 RVA: 0x00FE28EB File Offset: 0x00FE0AEB
		private SolarSchoolShopTogItem CreateGoodsItem()
		{
			return new SolarSchoolShopTogItem
			{
				ClickCallback = this.ClickCallback
			};
		}

		// Token: 0x0401DE06 RID: 122374
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolShopTogItem, SolarSchoolShopSlotData> GoodsLayout;

		// Token: 0x0200B5B8 RID: 46520
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04038316 RID: 230166
			public const int Layout = 0;

			// Token: 0x04038317 RID: 230167
			public const int GoodsItem = 1;
		}
	}
}
