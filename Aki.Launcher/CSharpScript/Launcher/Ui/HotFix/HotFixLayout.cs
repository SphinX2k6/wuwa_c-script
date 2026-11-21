using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000D6 RID: 214
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixLayout<TItem, [Nullable(0)] TData> where TItem : class, IHotFixLayoutItem where TData : IHotFixLayoutData
	{
		// Token: 0x0600070A RID: 1802 RVA: 0x0003B654 File Offset: 0x00039854
		public HotFixLayout(UUILayoutBase layout, Func<TItem> itemCreateFunction, [Nullable(2)] AUIBaseActor gridActor = null)
		{
			this.Layout = layout;
			((AUIBaseActor)this.Layout.GetOwner()).OnPreDestroyed.Add(new Action<AActor>(this.OnDestroy));
			if (gridActor == null)
			{
				UUIItem attachUIChild = layout.RootUIComp.Get().GetAttachUIChild(0);
				this.TemplateGridActor = (((attachUIChild != null) ? attachUIChild.GetOwner() : null) as AUIBaseActor);
			}
			else
			{
				this.TemplateGridActor = gridActor;
			}
			if (this.TemplateGridActor == null)
			{
				return;
			}
			this.ItemCreateFunction = itemCreateFunction;
			this.TemplateGridActor.GetUIItem().SetUIActive(false);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0003B70D File Offset: 0x0003990D
		[NullableContext(2)]
		private void OnDestroy(AActor _)
		{
			this.Layout = null;
			this.TemplateGridActor = null;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0003B720 File Offset: 0x00039920
		public void LoadGrid(int length)
		{
			for (int i = this.GridItemList.Count; i < length; i++)
			{
				UUIItem item = this.CreateGrid();
				this.GridItemList.Add(item);
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0003B758 File Offset: 0x00039958
		[NullableContext(2)]
		public UUIItem GetRootUiItem()
		{
			UUILayoutBase layout = this.Layout;
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (layout != null) ? new TWeakObjectPtr<UUIItem>?(layout.RootUIComp) : null;
			if (tweakObjectPtr == null)
			{
				return null;
			}
			return tweakObjectPtr.GetValueOrDefault();
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0003B79C File Offset: 0x0003999C
		public IReadOnlyList<TData> GetDataList()
		{
			return this.DataList;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0003B7A4 File Offset: 0x000399A4
		[NullableContext(2)]
		private UUIItem CreateGrid()
		{
			return HotFixLguiUtils.CopyItem(this.TemplateGridActor.GetUIItem(), this.GetRootUiItem());
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0003B7BC File Offset: 0x000399BC
		[NullableContext(2)]
		public UUIItem GetGridItemByIndex(int index)
		{
			if (index < 0 || index >= this.GridItemList.Count)
			{
				return null;
			}
			return this.GridItemList[index];
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0003B7DE File Offset: 0x000399DE
		[NullableContext(2)]
		public IHotFixLayoutItem GetLayoutItemByIndex(int index)
		{
			if (index < 0 || index >= this.ItemList.Count)
			{
				return null;
			}
			return this.ItemList[index];
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0003B805 File Offset: 0x00039A05
		public IReadOnlyList<IHotFixLayoutItem> GetLayoutItemList()
		{
			return this.ItemList;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0003B810 File Offset: 0x00039A10
		public void RefreshByData(IReadOnlyList<TData> dataList)
		{
			this.DataList = new List<TData>(dataList);
			this.HideChildren();
			this.LoadGrid(dataList.Count);
			for (int i = 0; i < dataList.Count; i++)
			{
				TData tdata = dataList[i];
				ref TData ptr = ref tdata;
				if (default(TData) == null)
				{
					TData tdata2 = tdata;
					ptr = ref tdata2;
				}
				ptr.Index = new int?(i);
				TItem titem;
				if (i >= this.ItemList.Count)
				{
					UUIItem uuiitem = this.GridItemList[i];
					titem = this.ItemCreateFunction();
					titem.SetRootActor(uuiitem.GetOwner());
					this.ItemList.Add(titem);
				}
				else
				{
					titem = this.ItemList[i];
				}
				titem.Refresh(tdata);
				titem.SetActive(true);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0003B8F8 File Offset: 0x00039AF8
		public void HideChildren()
		{
			for (int i = 0; i < this.ItemList.Count; i++)
			{
				this.ItemList[i].SetActive(false);
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0003B934 File Offset: 0x00039B34
		public void ClearChildren()
		{
			for (int i = 0; i < this.ItemList.Count; i++)
			{
				this.ItemList[i].Destroy();
			}
			this.ItemList.Clear();
			for (int j = 0; j < this.GridItemList.Count; j++)
			{
				AActor owner = this.GridItemList[j].GetOwner();
				if (owner != null && owner.IsValid())
				{
					owner.K2_DestroyActor();
				}
			}
			this.GridItemList.Clear();
		}

		// Token: 0x04000456 RID: 1110
		[Nullable(2)]
		private UUILayoutBase Layout;

		// Token: 0x04000457 RID: 1111
		[Nullable(2)]
		private AUIBaseActor TemplateGridActor;

		// Token: 0x04000458 RID: 1112
		private readonly List<UUIItem> GridItemList = new List<UUIItem>();

		// Token: 0x04000459 RID: 1113
		private readonly List<TItem> ItemList = new List<TItem>();

		// Token: 0x0400045A RID: 1114
		private List<TData> DataList = new List<TData>();

		// Token: 0x0400045B RID: 1115
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Func<TItem> ItemCreateFunction;
	}
}
