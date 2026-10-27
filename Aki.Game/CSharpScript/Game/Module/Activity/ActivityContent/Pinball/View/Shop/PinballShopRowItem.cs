using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Shop
{
	// Token: 0x020062EC RID: 25324
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class PinballShopRowItem : GridProxyAbstract<List<PinballShopItemProxy>>
	{
		// Token: 0x0603FBA1 RID: 261025 RVA: 0x00F6B510 File Offset: 0x00F69710
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0603FBA2 RID: 261026 RVA: 0x00F6B584 File Offset: 0x00F69784
		protected override void OnStart()
		{
			this.PanelItem = base.GetItem(0);
			this.TemplateItem = base.GetItem(1);
			UUIItem panelItem = this.PanelItem;
			if (panelItem != null && panelItem.IsValid())
			{
				UUIItem templateItem = this.TemplateItem;
				if (templateItem != null && templateItem.IsValid())
				{
					this.TemplateItem.SetUIParent(this.PanelItem, false);
					this.TemplateItem.SetUIActive(false);
				}
			}
		}

		// Token: 0x0603FBA3 RID: 261027 RVA: 0x00F6B5F4 File Offset: 0x00F697F4
		public override void Refresh(List<PinballShopItemProxy> data, bool isSelected, int gridIndex)
		{
			base.GridIndex = gridIndex;
			int num = Math.Min(data.Count, 5);
			this.EnsureSlots(num);
			this.EnsureSlotProxiesCreated(num);
			for (int i = 0; i < num; i++)
			{
				UUIItem uuiitem = this.ItemSlots[i];
				PinballShopGridItem pinballShopGridItem = this.SlotProxies[i];
				PinballShopItemProxy data2 = data[i];
				if (uuiitem != null && pinballShopGridItem != null)
				{
					uuiitem.SetUIActive(true);
					pinballShopGridItem.Refresh(data2, false, gridIndex * 5 + i);
				}
			}
			for (int j = num; j < this.ItemSlots.Count; j++)
			{
				UUIItem uuiitem2 = this.ItemSlots[j];
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(false);
				}
			}
		}

		// Token: 0x0603FBA4 RID: 261028 RVA: 0x00F6B6A0 File Offset: 0x00F698A0
		public override void Clear()
		{
		}

		// Token: 0x0603FBA5 RID: 261029 RVA: 0x00F6B6A2 File Offset: 0x00F698A2
		public override void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603FBA6 RID: 261030 RVA: 0x00F6B6A4 File Offset: 0x00F698A4
		public override void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603FBA7 RID: 261031 RVA: 0x00F6B6A6 File Offset: 0x00F698A6
		public override object GetKey(List<PinballShopItemProxy> data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x0603FBA8 RID: 261032 RVA: 0x00F6B6B0 File Offset: 0x00F698B0
		private void EnsureSlots(int needCount)
		{
			int num = Math.Min(needCount, 5);
			UUIItem panelItem = this.PanelItem;
			if (panelItem != null && panelItem.IsValid())
			{
				UUIItem templateItem = this.TemplateItem;
				if (templateItem != null && templateItem.IsValid())
				{
					if (num <= 0)
					{
						this.TemplateItem.SetUIActive(false);
						return;
					}
					if (this.ItemSlots.Count == 0)
					{
						this.ItemSlots.Add(this.TemplateItem);
					}
					int num2 = num - this.ItemSlots.Count;
					for (int i = 0; i < num2; i++)
					{
						UUIItem uuiitem = LguiUtil.Instance.CopyItem(this.TemplateItem, this.PanelItem);
						uuiitem.SetUIActive(false);
						this.ItemSlots.Add(uuiitem);
					}
					int num3 = 5 - this.SlotProxies.Count;
					for (int j = 0; j < num3; j++)
					{
						this.SlotProxies.Add(null);
					}
					return;
				}
			}
		}

		// Token: 0x0603FBA9 RID: 261033 RVA: 0x00F6B794 File Offset: 0x00F69994
		private void EnsureSlotProxiesCreated(int needCount)
		{
			for (int i = 0; i < needCount; i++)
			{
				if (this.SlotProxies[i] == null)
				{
					UUIItem uuiitem = this.ItemSlots[i];
					AActor aactor = (uuiitem != null) ? uuiitem.GetOwner() : null;
					if (aactor != null)
					{
						PinballShopGridItem pinballShopGridItem = new PinballShopGridItem();
						pinballShopGridItem.CreateThenShowByActor(aactor, null);
						this.SlotProxies[i] = pinballShopGridItem;
					}
				}
			}
		}

		// Token: 0x0402147F RID: 136319
		private const int MAX_ITEMS_PER_ROW = 5;

		// Token: 0x04021480 RID: 136320
		[Nullable(2)]
		private UUIItem PanelItem;

		// Token: 0x04021481 RID: 136321
		[Nullable(2)]
		private UUIItem TemplateItem;

		// Token: 0x04021482 RID: 136322
		private readonly List<UUIItem> ItemSlots = new List<UUIItem>();

		// Token: 0x04021483 RID: 136323
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<PinballShopGridItem> SlotProxies = new List<PinballShopGridItem>();

		// Token: 0x0200C4DE RID: 50398
		[NullableContext(0)]
		private enum ERowComponent
		{
			// Token: 0x0403B696 RID: 243350
			ItemPanel,
			// Token: 0x0403B697 RID: 243351
			ShopItem
		}
	}
}
