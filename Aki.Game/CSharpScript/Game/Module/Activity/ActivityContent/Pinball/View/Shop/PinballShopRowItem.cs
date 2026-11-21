using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Shop
{
	// Token: 0x0200526A RID: 21098
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class PinballShopRowItem : GridProxyAbstract<List<PinballShopItemProxy>>
	{
		// Token: 0x06034862 RID: 215138 RVA: 0x00EB246C File Offset: 0x00EB066C
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

		// Token: 0x06034863 RID: 215139 RVA: 0x00EB24E0 File Offset: 0x00EB06E0
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

		// Token: 0x06034864 RID: 215140 RVA: 0x00EB2550 File Offset: 0x00EB0750
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

		// Token: 0x06034865 RID: 215141 RVA: 0x00EB25FC File Offset: 0x00EB07FC
		public override void Clear()
		{
		}

		// Token: 0x06034866 RID: 215142 RVA: 0x00EB25FE File Offset: 0x00EB07FE
		public override void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06034867 RID: 215143 RVA: 0x00EB2600 File Offset: 0x00EB0800
		public override void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06034868 RID: 215144 RVA: 0x00EB2602 File Offset: 0x00EB0802
		public override object GetKey(List<PinballShopItemProxy> data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x06034869 RID: 215145 RVA: 0x00EB260C File Offset: 0x00EB080C
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

		// Token: 0x0603486A RID: 215146 RVA: 0x00EB26F0 File Offset: 0x00EB08F0
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

		// Token: 0x0401BDAE RID: 114094
		private const int MAX_ITEMS_PER_ROW = 5;

		// Token: 0x0401BDAF RID: 114095
		[Nullable(2)]
		private UUIItem PanelItem;

		// Token: 0x0401BDB0 RID: 114096
		[Nullable(2)]
		private UUIItem TemplateItem;

		// Token: 0x0401BDB1 RID: 114097
		private readonly List<UUIItem> ItemSlots = new List<UUIItem>();

		// Token: 0x0401BDB2 RID: 114098
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<PinballShopGridItem> SlotProxies = new List<PinballShopGridItem>();

		// Token: 0x0200AEC5 RID: 44741
		[NullableContext(0)]
		private enum ERowComponent
		{
			// Token: 0x04035FF8 RID: 221176
			ItemPanel,
			// Token: 0x04035FF9 RID: 221177
			ShopItem
		}
	}
}
