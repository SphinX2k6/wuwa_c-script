using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02005899 RID: 22681
	public class InstanceDungeonCostItem : UiPanelBase
	{
		// Token: 0x06039B59 RID: 236377 RVA: 0x00DB6B90 File Offset: 0x00DB4D90
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

		// Token: 0x06039B5A RID: 236378 RVA: 0x00DB6C78 File Offset: 0x00DB4E78
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

		// Token: 0x06039B5B RID: 236379 RVA: 0x00DB6CED File Offset: 0x00DB4EED
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnPowerChanged, new Action(this.OnPowerChanged));
		}

		// Token: 0x06039B5C RID: 236380 RVA: 0x00DB6D0B File Offset: 0x00DB4F0B
		private void OnPowerChanged()
		{
			if (this.ItemDataHandle != null && this.ItemDataHandle.Item.ItemData.ItemId == 5)
			{
				this.RefreshItem(this.ItemDataHandle.Item);
			}
		}

		// Token: 0x06039B5D RID: 236381 RVA: 0x00DB6D40 File Offset: 0x00DB4F40
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

		// Token: 0x06039B5E RID: 236382 RVA: 0x00DB6DF4 File Offset: 0x00DB4FF4
		private void OnClickBtnPowerHelp()
		{
			HelpController.Instance.OpenHelpById(26);
		}

		// Token: 0x0401E24D RID: 123469
		[Nullable(2)]
		private InstanceDungeonCostItemData ItemDataHandle;

		// Token: 0x0200BAF2 RID: 47858
		private enum EChildType
		{
			// Token: 0x040387C6 RID: 231366
			TextureConsume,
			// Token: 0x040387C7 RID: 231367
			TextConsume,
			// Token: 0x040387C8 RID: 231368
			ButtonPowerHelp,
			// Token: 0x040387C9 RID: 231369
			PowerCostDiscountsItem
		}
	}
}
