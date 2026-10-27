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
	// Token: 0x02005B2E RID: 23342
	public class CookMaterialItemContent : UiPanelBase
	{
		// Token: 0x0603B1A4 RID: 242084 RVA: 0x00E18334 File Offset: 0x00E16534
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

		// Token: 0x0603B1A5 RID: 242085 RVA: 0x00E18528 File Offset: 0x00E16728
		private void OnClick(EToggleState toggleState)
		{
			Action clickDelegate = this.ClickDelegate;
			if (clickDelegate == null)
			{
				return;
			}
			clickDelegate();
		}

		// Token: 0x0603B1A6 RID: 242086 RVA: 0x00E1853A File Offset: 0x00E1673A
		public void SetSelect()
		{
			base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603B1A7 RID: 242087 RVA: 0x00E1854D File Offset: 0x00E1674D
		public void SetDelect()
		{
			base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603B1A8 RID: 242088 RVA: 0x00E18560 File Offset: 0x00E16760
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

		// Token: 0x0603B1A9 RID: 242089 RVA: 0x00E1862B File Offset: 0x00E1682B
		[NullableContext(1)]
		public void Update(ISingleItemInfo data)
		{
			this.CookItemData = data;
			this.RefreshHave(1);
			this.RefreshIcon();
			this.RefreshQuality();
		}

		// Token: 0x0603B1AA RID: 242090 RVA: 0x00E18647 File Offset: 0x00E16847
		public void RefreshNeed(int num = 1)
		{
			this.RefreshHave(num);
		}

		// Token: 0x0603B1AB RID: 242091 RVA: 0x00E18650 File Offset: 0x00E16850
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

		// Token: 0x0603B1AC RID: 242092 RVA: 0x00E18718 File Offset: 0x00E16918
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

		// Token: 0x0603B1AD RID: 242093 RVA: 0x00E1878C File Offset: 0x00E1698C
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

		// Token: 0x0603B1AE RID: 242094 RVA: 0x00E187E4 File Offset: 0x00E169E4
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0401ED07 RID: 126215
		[Nullable(2)]
		private ISingleItemInfo CookItemData;

		// Token: 0x0401ED08 RID: 126216
		[Nullable(2)]
		public Action ClickDelegate;

		// Token: 0x0200BD69 RID: 48489
		private enum ECookMaterialItemComponents
		{
			// Token: 0x04039222 RID: 234018
			SprQuality,
			// Token: 0x04039223 RID: 234019
			TexIcon,
			// Token: 0x04039224 RID: 234020
			TxtNum,
			// Token: 0x04039225 RID: 234021
			PnlNum,
			// Token: 0x04039226 RID: 234022
			PnlItemBase,
			// Token: 0x04039227 RID: 234023
			PnlRedPoint,
			// Token: 0x04039228 RID: 234024
			PnlRedPoint1,
			// Token: 0x04039229 RID: 234025
			PnlCD,
			// Token: 0x0403922A RID: 234026
			BarCd,
			// Token: 0x0403922B RID: 234027
			TxtCD,
			// Token: 0x0403922C RID: 234028
			SprDark,
			// Token: 0x0403922D RID: 234029
			SprLock
		}
	}
}
