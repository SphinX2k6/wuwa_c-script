using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048D8 RID: 18648
	[NullableContext(1)]
	[Nullable(0)]
	public class GenericScrollView<[Nullable(0)] TItem> where TItem : UiPanelBase
	{
		// Token: 0x1700798B RID: 31115
		// (get) Token: 0x06030BD6 RID: 199638 RVA: 0x00B516CA File Offset: 0x00B4F8CA
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

		// Token: 0x1700798C RID: 31116
		// (get) Token: 0x06030BD7 RID: 199639 RVA: 0x00B516E0 File Offset: 0x00B4F8E0
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

		// Token: 0x1700798D RID: 31117
		// (get) Token: 0x06030BD8 RID: 199640 RVA: 0x00B51763 File Offset: 0x00B4F963
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

		// Token: 0x1700798E RID: 31118
		// (get) Token: 0x06030BD9 RID: 199641 RVA: 0x00B51770 File Offset: 0x00B4F970
		public float ScrollWidth
		{
			get
			{
				return this.TargetScroll.RootUIComp.Get().Width;
			}
		}

		// Token: 0x06030BDA RID: 199642 RVA: 0x00B51798 File Offset: 0x00B4F998
		public GenericScrollView(UUIScrollViewWithScrollbarComponent scrollView, TLayoutRefresh<TItem> refreshFunction, [Nullable(2)] UUIItem originalItem = null)
		{
			this.TargetScroll = scrollView;
			this.GenericLayout = new GenericLayoutNew<TItem>(this.TargetScroll.GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase, refreshFunction, originalItem);
			this.GenericLayout.SetScrollView(scrollView);
		}

		// Token: 0x06030BDB RID: 199643 RVA: 0x00B517EA File Offset: 0x00B4F9EA
		[NullableContext(2)]
		public void RefreshByData<T>([Nullable(new byte[]
		{
			2,
			1
		})] List<T> data, int? length = null)
		{
			this.GenericLayout.RebuildLayoutByDataNew<T>(data, length);
		}

		// Token: 0x06030BDC RID: 199644 RVA: 0x00B517F9 File Offset: 0x00B4F9F9
		public void ClearChildren()
		{
			this.GenericLayout.ClearChildren();
			this.TargetScroll.OnScrollValueChange.Unbind();
		}

		// Token: 0x06030BDD RID: 199645 RVA: 0x00B51816 File Offset: 0x00B4FA16
		public void SetHorizontalScrollEnable(bool enable)
		{
			this.TargetScroll.SetHorizontal(enable);
		}

		// Token: 0x06030BDE RID: 199646 RVA: 0x00B51824 File Offset: 0x00B4FA24
		public void SetVerticalScrollEnable(bool enable)
		{
			this.TargetScroll.SetVertical(enable);
		}

		// Token: 0x06030BDF RID: 199647 RVA: 0x00B51832 File Offset: 0x00B4FA32
		[NullableContext(2)]
		public UUIItem GetItemByIndex(int index)
		{
			return this.GenericLayout.GetItemByIndex(index);
		}

		// Token: 0x06030BE0 RID: 199648 RVA: 0x00B51840 File Offset: 0x00B4FA40
		[return: Nullable(2)]
		public TItem GetScrollItemByKey(object key)
		{
			return this.GenericLayout.GetLayoutItemByKey(key);
		}

		// Token: 0x06030BE1 RID: 199649 RVA: 0x00B5184E File Offset: 0x00B4FA4E
		public Dictionary<object, TItem> GetScrollItemMap()
		{
			return this.GenericLayout.GetLayoutItemMap();
		}

		// Token: 0x06030BE2 RID: 199650 RVA: 0x00B5185B File Offset: 0x00B4FA5B
		public List<TItem> GetScrollItemList()
		{
			return this.GenericLayout.GetLayoutItemList();
		}

		// Token: 0x06030BE3 RID: 199651 RVA: 0x00B51868 File Offset: 0x00B4FA68
		public void ScrollTo(UUIItem uiItem)
		{
			this.TargetScroll.ScrollTo(uiItem, false);
		}

		// Token: 0x06030BE4 RID: 199652 RVA: 0x00B51878 File Offset: 0x00B4FA78
		public void ScrollToLeft(object key)
		{
			TItem layoutItemByKey = this.GenericLayout.GetLayoutItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToLeft(ref fvector2D, layoutItemByKey.GetRootItem(), false);
		}

		// Token: 0x06030BE5 RID: 199653 RVA: 0x00B518D8 File Offset: 0x00B4FAD8
		public void ScrollToRight(object key)
		{
			TItem layoutItemByKey = this.GenericLayout.GetLayoutItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToRight(ref fvector2D, layoutItemByKey.GetRootItem(), false);
		}

		// Token: 0x06030BE6 RID: 199654 RVA: 0x00B51938 File Offset: 0x00B4FB38
		public void ScrollToTop(object key)
		{
			TItem layoutItemByKey = this.GenericLayout.GetLayoutItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToTop(ref fvector2D, layoutItemByKey.GetRootItem(), false);
		}

		// Token: 0x06030BE7 RID: 199655 RVA: 0x00B51998 File Offset: 0x00B4FB98
		public void ScrollToBottom(object key)
		{
			TItem layoutItemByKey = this.GenericLayout.GetLayoutItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToBottom(ref fvector2D, layoutItemByKey.GetRootItem(), false);
		}

		// Token: 0x06030BE8 RID: 199656 RVA: 0x00B519F8 File Offset: 0x00B4FBF8
		public void SetActive(bool bActive)
		{
			this.TargetScroll.RootUIComp.Get().SetUIActive(bActive);
		}

		// Token: 0x06030BE9 RID: 199657 RVA: 0x00B51A1E File Offset: 0x00B4FC1E
		public void BindScrollValueChange(Action<FVector2D> callback)
		{
			this.TargetScroll.OnScrollValueChange.Bind(callback);
		}

		// Token: 0x06030BEA RID: 199658 RVA: 0x00B51A31 File Offset: 0x00B4FC31
		public void BindLateUpdate(Action<float> callBack)
		{
			this.GenericLayout.BindLateUpdate(callBack);
		}

		// Token: 0x06030BEB RID: 199659 RVA: 0x00B51A3F File Offset: 0x00B4FC3F
		public void UnBindLateUpdate()
		{
			this.GenericLayout.UnBindLateUpdate();
		}

		// Token: 0x06030BEC RID: 199660 RVA: 0x00B51A4C File Offset: 0x00B4FC4C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public GenericLayoutNew<TItem> GetGenericLayout()
		{
			return this.GenericLayout;
		}

		// Token: 0x0401A2DC RID: 107228
		[Nullable(2)]
		private readonly UUIScrollViewWithScrollbarComponent TargetScroll;

		// Token: 0x0401A2DD RID: 107229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly GenericLayoutNew<TItem> GenericLayout;
	}
}
