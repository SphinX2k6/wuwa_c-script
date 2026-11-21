using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x0200384F RID: 14415
	[NullableContext(1)]
	[Nullable(0)]
	public class GenericScrollView<[Nullable(0)] TItem> where TItem : UiPanelBase
	{
		// Token: 0x17004CF3 RID: 19699
		// (get) Token: 0x06025702 RID: 153346 RVA: 0x00A8C4F6 File Offset: 0x00A8A6F6
		[Nullable(2)]
		public UUIItem TempOriginalItem
		{
			[NullableContext(2)]
			get
			{
				GenericLayoutNew<TItem> genericLayout = this.GenericLayout;
				if (genericLayout == null)
				{
					return null;
				}
				return genericLayout.TempOriginalItem;
			}
		}

		// Token: 0x17004CF4 RID: 19700
		// (get) Token: 0x06025703 RID: 153347 RVA: 0x00A8C50C File Offset: 0x00A8A70C
		public bool IsExpand
		{
			get
			{
				if (this.TargetScroll.Horizontal)
				{
					float width = this.TargetScroll.RootUIComp.Get().Width;
					return this.TargetScroll.ContentUIItem.Get().Width > width;
				}
				float height = this.TargetScroll.RootUIComp.Get().Height;
				return this.TargetScroll.ContentUIItem.Get().Height > height;
			}
		}

		// Token: 0x17004CF5 RID: 19701
		// (get) Token: 0x06025704 RID: 153348 RVA: 0x00A8C58F File Offset: 0x00A8A78F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public TWeakObjectPtr<UUIItem> ContentItem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return this.TargetScroll.ContentUIItem;
			}
		}

		// Token: 0x17004CF6 RID: 19702
		// (get) Token: 0x06025705 RID: 153349 RVA: 0x00A8C59C File Offset: 0x00A8A79C
		public float ScrollWidth
		{
			get
			{
				return this.TargetScroll.RootUIComp.Get().Width;
			}
		}

		// Token: 0x06025706 RID: 153350 RVA: 0x00A8C5C4 File Offset: 0x00A8A7C4
		public GenericScrollView(UUIScrollViewWithScrollbarComponent scrollView, TLayoutRefresh<TItem> refreshFunction, [Nullable(2)] UUIItem originalItem = null)
		{
			this.TargetScroll = scrollView;
			this.GenericLayout = new GenericLayoutNew<TItem>(this.TargetScroll.GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase, refreshFunction, originalItem);
			this.GenericLayout.SetScrollView(scrollView);
		}

		// Token: 0x06025707 RID: 153351 RVA: 0x00A8C616 File Offset: 0x00A8A816
		[NullableContext(2)]
		public void RefreshByData<T>([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<T> data, int? length = null)
		{
			this.GenericLayout.RebuildLayoutByDataNew<T>(data, length);
		}

		// Token: 0x06025708 RID: 153352 RVA: 0x00A8C625 File Offset: 0x00A8A825
		public void ClearChildren()
		{
			this.GenericLayout.ClearChildren();
			this.TargetScroll.OnScrollValueChange.Unbind();
		}

		// Token: 0x06025709 RID: 153353 RVA: 0x00A8C642 File Offset: 0x00A8A842
		public void SetHorizontalScrollEnable(bool enable)
		{
			this.TargetScroll.SetHorizontal(enable);
		}

		// Token: 0x0602570A RID: 153354 RVA: 0x00A8C650 File Offset: 0x00A8A850
		public void SetVerticalScrollEnable(bool enable)
		{
			this.TargetScroll.SetVertical(enable);
		}

		// Token: 0x0602570B RID: 153355 RVA: 0x00A8C65E File Offset: 0x00A8A85E
		[NullableContext(2)]
		public UUIItem GetItemByIndex(int index)
		{
			return this.GenericLayout.GetItemByIndex(index);
		}

		// Token: 0x0602570C RID: 153356 RVA: 0x00A8C66C File Offset: 0x00A8A86C
		[return: Nullable(2)]
		public TItem GetScrollItemByKey(object key)
		{
			return this.GenericLayout.GetLayoutItemByKey(key);
		}

		// Token: 0x0602570D RID: 153357 RVA: 0x00A8C67A File Offset: 0x00A8A87A
		public Dictionary<object, TItem> GetScrollItemMap()
		{
			return this.GenericLayout.GetLayoutItemMap();
		}

		// Token: 0x0602570E RID: 153358 RVA: 0x00A8C687 File Offset: 0x00A8A887
		public List<TItem> GetScrollItemList()
		{
			return this.GenericLayout.GetLayoutItemList();
		}

		// Token: 0x0602570F RID: 153359 RVA: 0x00A8C694 File Offset: 0x00A8A894
		public void ScrollTo(UUIItem uiItem)
		{
			this.TargetScroll.ScrollTo(uiItem, false);
		}

		// Token: 0x06025710 RID: 153360 RVA: 0x00A8C6A4 File Offset: 0x00A8A8A4
		public void ScrollToLeft(object key)
		{
			TItem layoutItemByKey = this.GenericLayout.GetLayoutItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToLeft(ref fvector2D, layoutItemByKey.GetRootItem(), false);
		}

		// Token: 0x06025711 RID: 153361 RVA: 0x00A8C704 File Offset: 0x00A8A904
		public void ScrollToRight(object key)
		{
			TItem layoutItemByKey = this.GenericLayout.GetLayoutItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToRight(ref fvector2D, layoutItemByKey.GetRootItem(), false);
		}

		// Token: 0x06025712 RID: 153362 RVA: 0x00A8C764 File Offset: 0x00A8A964
		public void ScrollToTop(object key)
		{
			TItem layoutItemByKey = this.GenericLayout.GetLayoutItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToTop(ref fvector2D, layoutItemByKey.GetRootItem(), false);
		}

		// Token: 0x06025713 RID: 153363 RVA: 0x00A8C7C4 File Offset: 0x00A8A9C4
		public void ScrollToBottom(object key)
		{
			TItem layoutItemByKey = this.GenericLayout.GetLayoutItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToBottom(ref fvector2D, layoutItemByKey.GetRootItem(), false);
		}

		// Token: 0x06025714 RID: 153364 RVA: 0x00A8C824 File Offset: 0x00A8AA24
		public void SetActive(bool bActive)
		{
			this.TargetScroll.RootUIComp.Get().SetUIActive(bActive);
		}

		// Token: 0x06025715 RID: 153365 RVA: 0x00A8C84A File Offset: 0x00A8AA4A
		public void BindScrollValueChange(Action<FVector2D> callback)
		{
			this.TargetScroll.OnScrollValueChange.Bind(callback);
		}

		// Token: 0x06025716 RID: 153366 RVA: 0x00A8C85D File Offset: 0x00A8AA5D
		public void BindLateUpdate(Action<float> callBack)
		{
			this.GenericLayout.BindLateUpdate(callBack);
		}

		// Token: 0x06025717 RID: 153367 RVA: 0x00A8C86B File Offset: 0x00A8AA6B
		public void UnBindLateUpdate()
		{
			this.GenericLayout.UnBindLateUpdate();
		}

		// Token: 0x06025718 RID: 153368 RVA: 0x00A8C878 File Offset: 0x00A8AA78
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public GenericLayoutNew<TItem> GetGenericLayout()
		{
			return this.GenericLayout;
		}

		// Token: 0x04014B4F RID: 84815
		[Nullable(2)]
		private readonly UUIScrollViewWithScrollbarComponent TargetScroll;

		// Token: 0x04014B50 RID: 84816
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly GenericLayoutNew<TItem> GenericLayout;
	}
}
