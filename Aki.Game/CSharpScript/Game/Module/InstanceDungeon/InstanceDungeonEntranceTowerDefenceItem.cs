using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200484A RID: 18506
	public class InstanceDungeonEntranceTowerDefenceItem : UiPanelBase
	{
		// Token: 0x0602E8A4 RID: 190628 RVA: 0x00CFE078 File Offset: 0x00CFC278
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E8A5 RID: 190629 RVA: 0x00CFE168 File Offset: 0x00CFC368
		protected override void OnStart()
		{
			this.PhantomScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(0), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			base.SetButtonUiActive(1, false);
			if (this.ItemDataHandle != null)
			{
				this.RefreshItem(this.ItemDataHandle.Data);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "TowerDefence_Vison", Array.Empty<object>());
		}

		// Token: 0x0602E8A6 RID: 190630 RVA: 0x00CFE1EC File Offset: 0x00CFC3EC
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0602E8A7 RID: 190631 RVA: 0x00CFE1F3 File Offset: 0x00CFC3F3
		[NullableContext(1)]
		public void RefreshItem(List<TItem> data)
		{
			if (base.InAsyncLoading())
			{
				this.ItemDataHandle = new InstanceDungeonEntranceTowerDefenceItemData
				{
					Data = data
				};
				return;
			}
			this.PhantomScroll.RefreshByData(data, delegate
			{
				foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.PhantomScroll.GetScrollItemList())
				{
					commonItemSmallItemGrid.SetQuality(null);
					commonItemSmallItemGrid.SetAllowClickBack(false);
				}
			}, false);
		}

		// Token: 0x04018C62 RID: 101474
		[Nullable(2)]
		private InstanceDungeonEntranceTowerDefenceItemData ItemDataHandle;

		// Token: 0x04018C63 RID: 101475
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> PhantomScroll;

		// Token: 0x0200A4D0 RID: 42192
		private enum EComponent
		{
			// Token: 0x040330CC RID: 209100
			PhantomScroll,
			// Token: 0x040330CD RID: 209101
			HelpButton,
			// Token: 0x040330CE RID: 209102
			TitleText,
			// Token: 0x040330CF RID: 209103
			SubTitleItem,
			// Token: 0x040330D0 RID: 209104
			SubTitleNumText,
			// Token: 0x040330D1 RID: 209105
			UpItem
		}
	}
}
