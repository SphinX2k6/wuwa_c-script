using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000D3 RID: 211
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixLayout<TItem, [Nullable(0)] TData> where TItem : class, IHotFixLayoutItem where TData : IHotFixLayoutData
	{
		// Token: 0x060006EE RID: 1774 RVA: 0x00039B24 File Offset: 0x00037D24
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

		// Token: 0x060006EF RID: 1775 RVA: 0x00039BDD File Offset: 0x00037DDD
		[NullableContext(2)]
		private void OnDestroy(AActor _)
		{
			this.Layout = null;
			this.TemplateGridActor = null;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00039BF0 File Offset: 0x00037DF0
		public void LoadGrid(int length)
		{
			for (int i = this.GridItemList.Count; i < length; i++)
			{
				UUIItem item = this.CreateGrid();
				this.GridItemList.Add(item);
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00039C28 File Offset: 0x00037E28
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

		// Token: 0x060006F2 RID: 1778 RVA: 0x00039C6C File Offset: 0x00037E6C
		public IReadOnlyList<TData> GetDataList()
		{
			return this.DataList;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00039C74 File Offset: 0x00037E74
		[NullableContext(2)]
		private UUIItem CreateGrid()
		{
			return HotFixLguiUtils.CopyItem(this.TemplateGridActor.GetUIItem(), this.GetRootUiItem());
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00039C8C File Offset: 0x00037E8C
		[NullableContext(2)]
		public UUIItem GetGridItemByIndex(int index)
		{
			if (index < 0 || index >= this.GridItemList.Count)
			{
				return null;
			}
			return this.GridItemList[index];
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00039CAE File Offset: 0x00037EAE
		[NullableContext(2)]
		public IHotFixLayoutItem GetLayoutItemByIndex(int index)
		{
			if (index < 0 || index >= this.ItemList.Count)
			{
				return null;
			}
			return this.ItemList[index];
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00039CD5 File Offset: 0x00037ED5
		public IReadOnlyList<IHotFixLayoutItem> GetLayoutItemList()
		{
			return this.ItemList;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00039CE0 File Offset: 0x00037EE0
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

		// Token: 0x060006F8 RID: 1784 RVA: 0x00039DC8 File Offset: 0x00037FC8
		public void HideChildren()
		{
			for (int i = 0; i < this.ItemList.Count; i++)
			{
				this.ItemList[i].SetActive(false);
			}
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00039E04 File Offset: 0x00038004
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

		// Token: 0x04000427 RID: 1063
		[Nullable(2)]
		private UUILayoutBase Layout;

		// Token: 0x04000428 RID: 1064
		[Nullable(2)]
		private AUIBaseActor TemplateGridActor;

		// Token: 0x04000429 RID: 1065
		private readonly List<UUIItem> GridItemList = new List<UUIItem>();

		// Token: 0x0400042A RID: 1066
		private readonly List<TItem> ItemList = new List<TItem>();

		// Token: 0x0400042B RID: 1067
		private List<TData> DataList = new List<TData>();

		// Token: 0x0400042C RID: 1068
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Func<TItem> ItemCreateFunction;
	}
}
