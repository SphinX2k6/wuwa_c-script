using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A0A RID: 23050
	public class SolarSchoolShopTogItem : GridProxyAbstract<SolarSchoolShopSlotData>
	{
		// Token: 0x17006C67 RID: 27751
		// (get) Token: 0x06038C11 RID: 232465 RVA: 0x00FE2AD6 File Offset: 0x00FE0CD6
		// (set) Token: 0x06038C12 RID: 232466 RVA: 0x00FE2ADE File Offset: 0x00FE0CDE
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

		// Token: 0x06038C13 RID: 232467 RVA: 0x00FE2AE8 File Offset: 0x00FE0CE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038C14 RID: 232468 RVA: 0x00FE2C78 File Offset: 0x00FE0E78
		public override void Refresh(SolarSchoolShopSlotData data, bool isSelected, int gridIndex)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetSelfInteractive(!data.IsEmpty);
			}
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(!data.IsEmpty);
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 != null)
			{
				item2.SetUIActive(data.IsEmpty);
			}
			FColor? fcolor;
			if (data.IsEmpty)
			{
				this.Data = null;
				UUITexture texture = base.GetTexture(1);
				if (texture != null)
				{
					texture.SetIsGray(false);
				}
				UUIItem text = base.GetText(3);
				bool bUseChangeColor = false;
				fcolor = new FColor?(base.GetText(3).changeColor);
				text.SetChangeColor(bUseChangeColor, fcolor);
				UUIItem item3 = base.GetItem(5);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				UUISprite sprite = base.GetSprite(6);
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
				UUIText text2 = base.GetText(7);
				if (text2 != null)
				{
					text2.SetUIActive(false);
				}
				this.SetSelectedState(false);
				return;
			}
			SolarSchoolShopGoodsData goods = data.Goods;
			this.Data = goods;
			base.SetTextureShowUntilLoaded(goods.Item.Icon, base.GetTexture(1), null);
			int price = goods.GetPrice();
			UUIText text3 = base.GetText(3);
			text3.SetText(price.ToString(), true);
			bool flag = SolarSchoolGamePlayModel.Instance.PlayerData.GetAttr(ESolarSchoolSecondAttr.Money) < price;
			UUIItem uuiitem = text3;
			bool bUseChangeColor2 = flag;
			fcolor = new FColor?(text3.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor2, fcolor);
			UUIText text4 = base.GetText(4);
			if (text4 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
				defaultInterpolatedStringHandler.AppendLiteral("<s>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(goods.Goods.Price);
				defaultInterpolatedStringHandler.AppendLiteral("</s>");
				text4.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIText text5 = base.GetText(4);
			if (text5 != null)
			{
				text5.SetUIActive(goods.IsDiscounted());
			}
			UUITexture texture2 = base.GetTexture(1);
			if (texture2 != null)
			{
				texture2.SetIsGray(goods.IsSoldOut());
			}
			UUIItem item4 = base.GetItem(5);
			if (item4 != null)
			{
				item4.SetUIActive(goods.IsSoldOut());
			}
			UUISprite sprite2 = base.GetSprite(6);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(goods.IsDiscounted());
			}
			UUIText text6 = base.GetText(7);
			if (text6 != null)
			{
				text6.SetUIActive(goods.IsDiscounted());
			}
			if (goods.IsDiscounted())
			{
				int value = 100 - goods.Goods.Discount / 10;
				UUIText text7 = base.GetText(7);
				if (text7 != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("-");
					defaultInterpolatedStringHandler.AppendFormatted<int>(value);
					defaultInterpolatedStringHandler.AppendLiteral("%");
					text7.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
			}
			this.SetSelectedState(isSelected);
		}

		// Token: 0x06038C15 RID: 232469 RVA: 0x00FE2F03 File Offset: 0x00FE1103
		public override void Clear()
		{
			this.Data = null;
		}

		// Token: 0x06038C16 RID: 232470 RVA: 0x00FE2F0C File Offset: 0x00FE110C
		[NullableContext(1)]
		public override object GetKey(SolarSchoolShopSlotData data, int displayIndex)
		{
			SolarSchoolShopGoodsData goods = data.Goods;
			return (goods != null) ? goods.Goods.Id : (-displayIndex - 1);
		}

		// Token: 0x06038C17 RID: 232471 RVA: 0x00FE2F3C File Offset: 0x00FE113C
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelectedState(true);
		}

		// Token: 0x06038C18 RID: 232472 RVA: 0x00FE2F45 File Offset: 0x00FE1145
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelectedState(false);
		}

		// Token: 0x06038C19 RID: 232473 RVA: 0x00FE2F50 File Offset: 0x00FE1150
		private void OnToggleChanged(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked || this.Data == null)
			{
				return;
			}
			IScrollViewDelegate<IGridProxy<SolarSchoolShopSlotData>, SolarSchoolShopSlotData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
			}
			Action<SolarSchoolShopGoodsData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.Data);
		}

		// Token: 0x06038C1A RID: 232474 RVA: 0x00FE2F9E File Offset: 0x00FE119E
		private void SetSelectedState(bool selected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401DE08 RID: 122376
		[Nullable(2)]
		private SolarSchoolShopGoodsData Data;

		// Token: 0x0200B5BA RID: 46522
		private class EComponent
		{
			// Token: 0x0403831C RID: 230172
			public const int Toggle = 0;

			// Token: 0x0403831D RID: 230173
			public const int TexIcon = 1;

			// Token: 0x0403831E RID: 230174
			public const int TxtPrice = 3;

			// Token: 0x0403831F RID: 230175
			public const int TxtOriginalPrice = 4;

			// Token: 0x04038320 RID: 230176
			public const int PnlSoldOut = 5;

			// Token: 0x04038321 RID: 230177
			public const int SprNum = 6;

			// Token: 0x04038322 RID: 230178
			public const int TxtNum = 7;

			// Token: 0x04038323 RID: 230179
			public const int PnlContent = 8;

			// Token: 0x04038324 RID: 230180
			public const int PnlNone = 9;
		}
	}
}
