using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004871 RID: 18545
	public class InstanceDungeonCostItem : UiPanelBase
	{
		// Token: 0x0602EA7C RID: 191100 RVA: 0x00D05AA8 File Offset: 0x00D03CA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnPowerHelp));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602EA7D RID: 191101 RVA: 0x00D05B90 File Offset: 0x00D03D90
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			if (this.ItemDataHandle != null)
			{
				this.RefreshItem(this.ItemDataHandle.Item);
			}
			EventSystem.Instance.Add(EEventName.OnPowerChanged, new Action(this.OnPowerChanged));
		}

		// Token: 0x0602EA7E RID: 191102 RVA: 0x00D05C05 File Offset: 0x00D03E05
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnPowerChanged, new Action(this.OnPowerChanged));
		}

		// Token: 0x0602EA7F RID: 191103 RVA: 0x00D05C23 File Offset: 0x00D03E23
		private void OnPowerChanged()
		{
			if (this.ItemDataHandle != null && this.ItemDataHandle.Item.ItemData.ItemId == 5)
			{
				this.RefreshItem(this.ItemDataHandle.Item);
			}
		}

		// Token: 0x0602EA80 RID: 191104 RVA: 0x00D05C58 File Offset: 0x00D03E58
		public void RefreshItem(TItem item)
		{
			this.ItemDataHandle = new InstanceDungeonCostItemData
			{
				Item = item
			};
			if (base.InAsyncLoading())
			{
				return;
			}
			bool flag = item.ItemData.ItemId == 5 && !PowerModel.Instance.IsPowerEnough(new int?(item.Count));
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText("x" + item.Count.ToString(), true);
			}
			if (text != null)
			{
				UUIItem uuiitem = text;
				bool bUseChangeColor = flag;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			base.SetItemIcon(base.GetTexture(0), item.ItemData.ItemId, null, null);
		}

		// Token: 0x0602EA81 RID: 191105 RVA: 0x00D05D0C File Offset: 0x00D03F0C
		private void OnClickBtnPowerHelp()
		{
			HelpController.Instance.OpenHelpById(26);
		}

		// Token: 0x04018CEA RID: 101610
		[Nullable(2)]
		private InstanceDungeonCostItemData ItemDataHandle;

		// Token: 0x0200A50B RID: 42251
		private enum EChildType
		{
			// Token: 0x040331C7 RID: 209351
			TextureConsume,
			// Token: 0x040331C8 RID: 209352
			TextConsume,
			// Token: 0x040331C9 RID: 209353
			ButtonPowerHelp,
			// Token: 0x040331CA RID: 209354
			PowerCostDiscountsItem
		}
	}
}
