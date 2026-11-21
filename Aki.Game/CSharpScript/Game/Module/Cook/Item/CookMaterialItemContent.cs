using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.Item
{
	// Token: 0x02004B0F RID: 19215
	public class CookMaterialItemContent : UiPanelBase
	{
		// Token: 0x06030116 RID: 196886 RVA: 0x00D6904C File Offset: 0x00D6724C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030117 RID: 196887 RVA: 0x00D69240 File Offset: 0x00D67440
		private void OnClick(EToggleState toggleState)
		{
			Action clickDelegate = this.ClickDelegate;
			if (clickDelegate == null)
			{
				return;
			}
			clickDelegate();
		}

		// Token: 0x06030118 RID: 196888 RVA: 0x00D69252 File Offset: 0x00D67452
		public void SetSelect()
		{
			base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06030119 RID: 196889 RVA: 0x00D69265 File Offset: 0x00D67465
		public void SetDelect()
		{
			base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603011A RID: 196890 RVA: 0x00D69278 File Offset: 0x00D67478
		protected override void OnStart()
		{
			base.GetSprite(0).SetUIActive(true);
			base.GetTexture(1).SetUIActive(true);
			base.GetText(2).SetUIActive(true);
			UUIItem uuiitem = base.GetExtendToggle(4).GetOwner().GetComponentByClass(UUITexture.StaticClass()) as UUIItem;
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(true);
			}
			base.GetItem(3).SetUIActive(true);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetText(9).SetUIActive(false);
			base.GetSprite(10).SetUIActive(false);
			base.GetSprite(11).SetUIActive(false);
		}

		// Token: 0x0603011B RID: 196891 RVA: 0x00D69343 File Offset: 0x00D67543
		[NullableContext(1)]
		public void Update(ISingleItemInfo data)
		{
			this.CookItemData = data;
			this.RefreshHave(1);
			this.RefreshIcon();
			this.RefreshQuality();
		}

		// Token: 0x0603011C RID: 196892 RVA: 0x00D6935F File Offset: 0x00D6755F
		public void RefreshNeed(int num = 1)
		{
			this.RefreshHave(num);
		}

		// Token: 0x0603011D RID: 196893 RVA: 0x00D69368 File Offset: 0x00D67568
		protected void RefreshHave(int times = 1)
		{
			int num = this.CookItemData.Proto_ItemNum * times;
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.CookItemData.Proto_ItemId, 0);
			string newText;
			if (this.CookItemData.Proto_IsUnlock)
			{
				if (itemCountByConfigId < this.CookItemData.Proto_ItemNum)
				{
					newText = StringUtils.Format("<color=#f55e66>{0}</color>/{1}", new string[]
					{
						itemCountByConfigId.ToString(),
						num.ToString()
					});
				}
				else
				{
					newText = StringUtils.Format("<color=#f7eba6>{0}</color>/{1}", new string[]
					{
						itemCountByConfigId.ToString(),
						num.ToString()
					});
				}
			}
			else
			{
				newText = StringUtils.Format("--/{0}", new string[]
				{
					num.ToString()
				});
			}
			base.GetText(2).SetText(newText, true);
		}

		// Token: 0x0603011E RID: 196894 RVA: 0x00D69430 File Offset: 0x00D67630
		private void RefreshIcon()
		{
			if (this.CookItemData.Proto_IsUnlock)
			{
				base.GetTexture(1).SetUIActive(true);
				base.SetTextureByPath(ItemConfig.Instance.GetConfig(this.CookItemData.Proto_ItemId).Value.Icon, base.GetTexture(1), null, null);
				return;
			}
			base.GetTexture(1).SetUIActive(false);
		}

		// Token: 0x0603011F RID: 196895 RVA: 0x00D694A4 File Offset: 0x00D676A4
		private void RefreshQuality()
		{
			if (this.CookItemData.Proto_IsUnlock)
			{
				base.GetSprite(0).SetUIActive(true);
				base.SetItemQualityIcon(base.GetSprite(0), this.CookItemData.Proto_ItemId, null, global::CommonDefine.EQualityIconType.BackgroundSprite, null);
				return;
			}
			base.GetSprite(0).SetUIActive(false);
		}

		// Token: 0x06030120 RID: 196896 RVA: 0x00D694FC File Offset: 0x00D676FC
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x040197C3 RID: 104387
		[Nullable(2)]
		private ISingleItemInfo CookItemData;

		// Token: 0x040197C4 RID: 104388
		[Nullable(2)]
		public Action ClickDelegate;

		// Token: 0x0200A772 RID: 42866
		private enum ECookMaterialItemComponents
		{
			// Token: 0x04033BEE RID: 211950
			SprQuality,
			// Token: 0x04033BEF RID: 211951
			TexIcon,
			// Token: 0x04033BF0 RID: 211952
			TxtNum,
			// Token: 0x04033BF1 RID: 211953
			PnlNum,
			// Token: 0x04033BF2 RID: 211954
			PnlItemBase,
			// Token: 0x04033BF3 RID: 211955
			PnlRedPoint,
			// Token: 0x04033BF4 RID: 211956
			PnlRedPoint1,
			// Token: 0x04033BF5 RID: 211957
			PnlCD,
			// Token: 0x04033BF6 RID: 211958
			BarCd,
			// Token: 0x04033BF7 RID: 211959
			TxtCD,
			// Token: 0x04033BF8 RID: 211960
			SprDark,
			// Token: 0x04033BF9 RID: 211961
			SprLock
		}
	}
}
