using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.ItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004B06 RID: 19206
	public class CookSuccessView : UiViewBase
	{
		// Token: 0x060300B1 RID: 196785 RVA: 0x00D67058 File Offset: 0x00D65258
		[NullableContext(1)]
		public CookSuccessView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060300B2 RID: 196786 RVA: 0x00D67064 File Offset: 0x00D65264
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(delegate()
			{
				this.OnClose();
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(delegate()
			{
				this.OnConfirm();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060300B3 RID: 196787 RVA: 0x00D671D4 File Offset: 0x00D653D4
		protected override void OnStart()
		{
			CookRewardPopData cookRewardPopData = this.OpenParam as CookRewardPopData;
			this.Type = cookRewardPopData.CookRewardPopType;
			this.CookPopScroll = new GenericScrollView<CommonItemSimpleGrid>(base.GetScrollViewWithScrollbar(3), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemSimpleGrid>(this.CreatePropItem), null);
			base.GetButton(5).GetRootComponent().SetUIActive(false);
			this.ExpSliderItem = new ExpSliderItem(base.GetItem(4));
		}

		// Token: 0x060300B4 RID: 196788 RVA: 0x00D6723C File Offset: 0x00D6543C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FixSuccess, new Action(this.OnClose));
		}

		// Token: 0x060300B5 RID: 196789 RVA: 0x00D6725A File Offset: 0x00D6545A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FixSuccess, new Action(this.OnClose));
		}

		// Token: 0x060300B6 RID: 196790 RVA: 0x00D67278 File Offset: 0x00D65478
		private void OnConfirm()
		{
			this.OnClose();
		}

		// Token: 0x060300B7 RID: 196791 RVA: 0x00D67280 File Offset: 0x00D65480
		private void OnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060300B8 RID: 196792 RVA: 0x00D6728C File Offset: 0x00D6548C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<CommonItemSimpleGrid> CreatePropItem([Nullable(2)] object data, UUIItem uiItem, int index)
		{
			if (data is TItem)
			{
				TItem titem = (TItem)data;
				CommonItemSimpleGrid commonItemSimpleGrid = new CommonItemSimpleGrid(uiItem.GetOwner());
				commonItemSimpleGrid.RefreshItem(titem.ItemData.ItemId, titem.Count);
				return new LayoutItem<CommonItemSimpleGrid>
				{
					Key = index,
					Value = commonItemSimpleGrid
				};
			}
			return null;
		}

		// Token: 0x060300B9 RID: 196793 RVA: 0x00D672E7 File Offset: 0x00D654E7
		protected override void OnAfterShow()
		{
			this.RefreshTitle();
			this.RefreshScroller();
			this.RefreshSlider();
		}

		// Token: 0x060300BA RID: 196794 RVA: 0x00D672FC File Offset: 0x00D654FC
		private void RefreshTitle()
		{
			ECookPopType type = this.Type;
			if (type == ECookPopType.Cook)
			{
				LguiUtil.Instance.SetLocalText(base.GetText(0), "GetItem", Array.Empty<object>());
				return;
			}
			if (type != ECookPopType.Machining)
			{
				return;
			}
			LguiUtil.Instance.SetLocalText(base.GetText(0), "GetItem", Array.Empty<object>());
		}

		// Token: 0x060300BB RID: 196795 RVA: 0x00D67350 File Offset: 0x00D65550
		private void RefreshScroller()
		{
			List<TItem> list = new List<TItem>();
			foreach (ICookPopItem cookPopItem in CookModel.Instance.GetCookItemList())
			{
				TItem item = new TItem(new InventoryDefine.GetItemData(cookPopItem.ItemId, 0), cookPopItem.ItemNum);
				list.Add(item);
			}
			this.CookPopScroll.RefreshByData<TItem>(list, null);
		}

		// Token: 0x060300BC RID: 196796 RVA: 0x00D673DC File Offset: 0x00D655DC
		private void RefreshSlider()
		{
			ECookPopType type = this.Type;
			if (type == ECookPopType.Cook)
			{
				this.ExpSliderItem.SetActive(true);
				this.ExpSliderItem.Update();
				return;
			}
			if (type != ECookPopType.Machining)
			{
				return;
			}
			this.ExpSliderItem.SetActive(false);
		}

		// Token: 0x060300BD RID: 196797 RVA: 0x00D6741D File Offset: 0x00D6561D
		protected override void OnBeforeDestroy()
		{
			this.CookPopScroll.ClearChildren();
		}

		// Token: 0x040197A0 RID: 104352
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<CommonItemSimpleGrid> CookPopScroll;

		// Token: 0x040197A1 RID: 104353
		private ECookPopType Type;

		// Token: 0x040197A2 RID: 104354
		[Nullable(2)]
		private ExpSliderItem ExpSliderItem;

		// Token: 0x0200A76D RID: 42861
		public enum ECookPopDefine
		{
			// Token: 0x04033BC4 RID: 211908
			Title,
			// Token: 0x04033BC5 RID: 211909
			Desc,
			// Token: 0x04033BC6 RID: 211910
			BtnItem,
			// Token: 0x04033BC7 RID: 211911
			ItemScroller,
			// Token: 0x04033BC8 RID: 211912
			ExpItem,
			// Token: 0x04033BC9 RID: 211913
			CancelBtn,
			// Token: 0x04033BCA RID: 211914
			ConfirmBtn
		}
	}
}
