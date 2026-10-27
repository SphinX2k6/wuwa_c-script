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
	// Token: 0x02005B25 RID: 23333
	public class CookSuccessView : UiViewBase
	{
		// Token: 0x0603B13F RID: 241983 RVA: 0x00E16340 File Offset: 0x00E14540
		[NullableContext(1)]
		public CookSuccessView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B140 RID: 241984 RVA: 0x00E1634C File Offset: 0x00E1454C
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

		// Token: 0x0603B141 RID: 241985 RVA: 0x00E164BC File Offset: 0x00E146BC
		protected override void OnStart()
		{
			CookRewardPopData cookRewardPopData = this.OpenParam as CookRewardPopData;
			this.Type = cookRewardPopData.CookRewardPopType;
			this.CookPopScroll = new GenericScrollView<CommonItemSimpleGrid>(base.GetScrollViewWithScrollbar(3), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemSimpleGrid>(this.CreatePropItem), null);
			base.GetButton(5).GetRootComponent().SetUIActive(false);
			this.ExpSliderItem = new ExpSliderItem(base.GetItem(4));
		}

		// Token: 0x0603B142 RID: 241986 RVA: 0x00E16524 File Offset: 0x00E14724
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FixSuccess, new Action(this.OnClose));
		}

		// Token: 0x0603B143 RID: 241987 RVA: 0x00E16542 File Offset: 0x00E14742
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FixSuccess, new Action(this.OnClose));
		}

		// Token: 0x0603B144 RID: 241988 RVA: 0x00E16560 File Offset: 0x00E14760
		private void OnConfirm()
		{
			this.OnClose();
		}

		// Token: 0x0603B145 RID: 241989 RVA: 0x00E16568 File Offset: 0x00E14768
		private void OnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603B146 RID: 241990 RVA: 0x00E16574 File Offset: 0x00E14774
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

		// Token: 0x0603B147 RID: 241991 RVA: 0x00E165CF File Offset: 0x00E147CF
		protected override void OnAfterShow()
		{
			this.RefreshTitle();
			this.RefreshScroller();
			this.RefreshSlider();
		}

		// Token: 0x0603B148 RID: 241992 RVA: 0x00E165E4 File Offset: 0x00E147E4
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

		// Token: 0x0603B149 RID: 241993 RVA: 0x00E16638 File Offset: 0x00E14838
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

		// Token: 0x0603B14A RID: 241994 RVA: 0x00E166C4 File Offset: 0x00E148C4
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

		// Token: 0x0603B14B RID: 241995 RVA: 0x00E16705 File Offset: 0x00E14905
		protected override void OnBeforeDestroy()
		{
			this.CookPopScroll.ClearChildren();
		}

		// Token: 0x0401ECE4 RID: 126180
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<CommonItemSimpleGrid> CookPopScroll;

		// Token: 0x0401ECE5 RID: 126181
		private ECookPopType Type;

		// Token: 0x0401ECE6 RID: 126182
		[Nullable(2)]
		private ExpSliderItem ExpSliderItem;

		// Token: 0x0200BD64 RID: 48484
		public enum ECookPopDefine
		{
			// Token: 0x040391F8 RID: 233976
			Title,
			// Token: 0x040391F9 RID: 233977
			Desc,
			// Token: 0x040391FA RID: 233978
			BtnItem,
			// Token: 0x040391FB RID: 233979
			ItemScroller,
			// Token: 0x040391FC RID: 233980
			ExpItem,
			// Token: 0x040391FD RID: 233981
			CancelBtn,
			// Token: 0x040391FE RID: 233982
			ConfirmBtn
		}
	}
}
