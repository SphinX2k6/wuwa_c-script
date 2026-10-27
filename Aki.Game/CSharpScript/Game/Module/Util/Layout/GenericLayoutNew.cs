using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util.Layout
{
	// Token: 0x020048E5 RID: 18661
	[NullableContext(2)]
	[Nullable(0)]
	public class GenericLayoutNew<TGenericLayoutNewItem> : IGridPreserver
	{
		// Token: 0x1700799B RID: 31131
		// (get) Token: 0x06030C96 RID: 199830 RVA: 0x00B543A1 File Offset: 0x00B525A1
		public UUIItem TempOriginalItem
		{
			get
			{
				return this.OriginalItem;
			}
		}

		// Token: 0x06030C97 RID: 199831 RVA: 0x00B543AC File Offset: 0x00B525AC
		[NullableContext(1)]
		public GenericLayoutNew(UUILayoutBase layout, [Nullable(new byte[]
		{
			2,
			1
		})] TLayoutRefresh<TGenericLayoutNewItem> refreshFunction, [Nullable(2)] UUIItem originalItem = null)
		{
			this.ProxyLayout = layout;
			this.RefreshFunction = refreshFunction;
			this.SaveOriginalItem(originalItem);
			this.GridsController = new InTurnGridAppearAnimation(this);
			this.GridsController.RegisterAnimController();
		}

		// Token: 0x06030C98 RID: 199832 RVA: 0x00B54428 File Offset: 0x00B52628
		private void ClearItemList()
		{
			foreach (TGenericLayoutNewItem tgenericLayoutNewItem in this.ItemMap.Values)
			{
				UiComponentAction uiComponentAction = tgenericLayoutNewItem as UiComponentAction;
				if (uiComponentAction != null)
				{
					uiComponentAction.Destroy(null);
				}
			}
			this.ItemMap.Clear();
			this.ItemList.Clear();
		}

		// Token: 0x06030C99 RID: 199833 RVA: 0x00B544A4 File Offset: 0x00B526A4
		private void SaveOriginalItem(UUIItem originalItem)
		{
			if (this.OriginalItem == null)
			{
				UUIItem uuiitem;
				if (originalItem == null)
				{
					uuiitem = this.GetItemByIndex(0);
				}
				else
				{
					uuiitem = originalItem;
				}
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(false);
				}
				if (uuiitem != null)
				{
					uuiitem.SetUIParent(this.GetRootParentUiItem(), false);
				}
				this.OriginalItem = uuiitem;
				this.DisplayName = ((uuiitem != null) ? uuiitem.displayName : null);
			}
		}

		// Token: 0x06030C9A RID: 199834 RVA: 0x00B544FD File Offset: 0x00B526FD
		[NullableContext(1)]
		public void SetScrollView(UUIScrollViewWithScrollbarComponent scrollView)
		{
			this.ScrollView = scrollView;
			this.IsUseByLayout = false;
			GridAppearAnimationBase gridsController = this.GridsController;
			if (gridsController == null)
			{
				return;
			}
			gridsController.RegisterAnimController();
		}

		// Token: 0x06030C9B RID: 199835 RVA: 0x00B54520 File Offset: 0x00B52720
		public void PreLoadCopyItem(int preLoadNum)
		{
			for (int i = 0; i < preLoadNum; i++)
			{
				this.CreateCopyItem().SetUIActive(false);
			}
		}

		// Token: 0x06030C9C RID: 199836 RVA: 0x00B54545 File Offset: 0x00B52745
		public UUIItem GetRootUiItem()
		{
			return this.ProxyLayout.RootUIComp;
		}

		// Token: 0x06030C9D RID: 199837 RVA: 0x00B54557 File Offset: 0x00B52757
		private UUIItem GetRootParentUiItem()
		{
			return this.GetRootUiItem().GetParentAsUIItem();
		}

		// Token: 0x06030C9E RID: 199838 RVA: 0x00B54564 File Offset: 0x00B52764
		private void RecycleToPool()
		{
			if (this.CopyItemList.Count > 0)
			{
				List<UUIItem> copyItemList = this.CopyItemList;
				UUIItem uuiitem = copyItemList[copyItemList.Count - 1];
				this.CopyItemList.RemoveAt(this.CopyItemList.Count - 1);
				uuiitem.SetUIActive(false);
				this.PoolItemList.Add(uuiitem);
			}
		}

		// Token: 0x06030C9F RID: 199839 RVA: 0x00B545C0 File Offset: 0x00B527C0
		[NullableContext(1)]
		private UUIItem CreateCopyItem()
		{
			UUIItem uuiitem = LguiUtil.Instance.CopyItem(this.OriginalItem, this.GetRootUiItem());
			this.CopyItemList.Add(uuiitem);
			return uuiitem;
		}

		// Token: 0x06030CA0 RID: 199840 RVA: 0x00B545F4 File Offset: 0x00B527F4
		private void AddFromPool()
		{
			if (this.PoolItemList.Count > 0)
			{
				List<UUIItem> poolItemList = this.PoolItemList;
				UUIItem uuiitem = poolItemList[poolItemList.Count - 1];
				this.PoolItemList.RemoveAt(this.PoolItemList.Count - 1);
				uuiitem.SetUIActive(true);
				this.CopyItemList.Add(uuiitem);
				return;
			}
			this.CreateCopyItem().SetUIActive(true);
		}

		// Token: 0x06030CA1 RID: 199841 RVA: 0x00B5465B File Offset: 0x00B5285B
		private void ResetOriginalActor()
		{
			if (this.OriginalItem != null)
			{
				this.OriginalItem.SetUIActive(true);
				this.OriginalItem.SetUIParent(this.GetRootUiItem(), false);
				this.OriginalItem = null;
			}
		}

		// Token: 0x06030CA2 RID: 199842 RVA: 0x00B5468C File Offset: 0x00B5288C
		private void Clear()
		{
			for (int i = 0; i < this.PoolItemList.Count; i++)
			{
				AActor owner = this.PoolItemList[i].GetOwner();
				if (owner != null && owner.IsValid())
				{
					ULGUIBPLibrary.DestroyActorWithHierarchy(this.PoolItemList[i].GetOwner(), true);
				}
			}
			this.PoolItemList.Clear();
			for (int j = 0; j < this.CopyItemList.Count; j++)
			{
				AActor owner2 = this.CopyItemList[j].GetOwner();
				if (owner2 != null && owner2.IsValid())
				{
					ULGUIBPLibrary.DestroyActorWithHierarchy(this.CopyItemList[j].GetOwner(), true);
				}
			}
			this.CopyItemList.Clear();
			this.ClearGridController();
		}

		// Token: 0x06030CA3 RID: 199843 RVA: 0x00B5474D File Offset: 0x00B5294D
		public void ClearGridController()
		{
			if (this.GridsController != null)
			{
				this.GridsController.Clear();
				this.GridsController = null;
			}
		}

		// Token: 0x06030CA4 RID: 199844 RVA: 0x00B54769 File Offset: 0x00B52969
		public void SetNeedAnim(bool value)
		{
			this.NeedAnim = value;
		}

		// Token: 0x06030CA5 RID: 199845 RVA: 0x00B54774 File Offset: 0x00B52974
		public void RebuildLayoutByDataNew<T>([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<T> data, int? length = null)
		{
			this.SaveOriginalItem(null);
			this.ClearItemList();
			int num = (data != null) ? data.Count : 0;
			int valueOrDefault = length.GetValueOrDefault(num);
			int count = this.CopyItemList.Count;
			this.DisplayGridNum = valueOrDefault;
			this.IsClear = false;
			if (valueOrDefault < this.CopyItemList.Count)
			{
				for (int i = 0; i < valueOrDefault; i++)
				{
					this.CopyItemList[i].SetUIActive(true);
				}
				for (int j = valueOrDefault; j < count; j++)
				{
					this.RecycleToPool();
				}
			}
			else if (valueOrDefault > this.CopyItemList.Count)
			{
				for (int k = 0; k < count; k++)
				{
					this.CopyItemList[k].SetUIActive(true);
				}
				for (int l = 0; l < valueOrDefault - count; l++)
				{
					this.AddFromPool();
				}
			}
			int num2 = 0;
			for (int m = 0; m < valueOrDefault; m++)
			{
				UUIItem uuiitem = this.CopyItemList[m];
				uuiitem.displayName = this.DisplayName + "_" + m.ToString();
				object data2 = (m < num) ? data[m] : null;
				TLayoutRefresh<TGenericLayoutNewItem> refreshFunction = this.RefreshFunction;
				ILayoutItem<TGenericLayoutNewItem> layoutItem = (refreshFunction != null) ? refreshFunction(data2, uuiitem, num2) : null;
				if (layoutItem != null && layoutItem.Value != null)
				{
					this.ItemMap.Add(layoutItem.Key, layoutItem.Value);
					this.ItemList.Add(layoutItem.Value);
					num2++;
				}
			}
			if (this.GridsController != null && this.NeedAnim)
			{
				this.GridsController.PlayGridAnim(this.DisplayGridNum, false);
			}
		}

		// Token: 0x06030CA6 RID: 199846 RVA: 0x00B54928 File Offset: 0x00B52B28
		public UUIItem GetItemByIndex(int index)
		{
			if (this.ProxyLayout != null)
			{
				TArray<UUIItem> attachUIChildren = this.GetRootUiItem().GetAttachUIChildren();
				if (index < attachUIChildren.Num())
				{
					return attachUIChildren[index];
				}
			}
			return null;
		}

		// Token: 0x06030CA7 RID: 199847 RVA: 0x00B5495C File Offset: 0x00B52B5C
		[NullableContext(1)]
		[return: Nullable(2)]
		public TGenericLayoutNewItem GetLayoutItemByKey(object key)
		{
			TGenericLayoutNewItem result;
			if (this.ItemMap.TryGetValue(key, out result))
			{
				return result;
			}
			return default(TGenericLayoutNewItem);
		}

		// Token: 0x06030CA8 RID: 199848 RVA: 0x00B54984 File Offset: 0x00B52B84
		[NullableContext(1)]
		public Dictionary<object, TGenericLayoutNewItem> GetLayoutItemMap()
		{
			return this.ItemMap;
		}

		// Token: 0x06030CA9 RID: 199849 RVA: 0x00B5498C File Offset: 0x00B52B8C
		[NullableContext(1)]
		public List<TGenericLayoutNewItem> GetLayoutItemList()
		{
			return this.ItemList;
		}

		// Token: 0x06030CAA RID: 199850 RVA: 0x00B54994 File Offset: 0x00B52B94
		public TGenericLayoutNewItem GetLayoutItemByIndex(int index)
		{
			if (index >= 0 && index < this.ItemList.Count)
			{
				return this.ItemList[index];
			}
			return default(TGenericLayoutNewItem);
		}

		// Token: 0x06030CAB RID: 199851 RVA: 0x00B549C9 File Offset: 0x00B52BC9
		public void ClearChildren()
		{
			if (this.IsClear)
			{
				return;
			}
			this.IsClear = true;
			this.ProxyLayout.OnLateUpdate.Unbind();
			this.ClearItemList();
			this.Clear();
			this.ResetOriginalActor();
		}

		// Token: 0x06030CAC RID: 199852 RVA: 0x00B54A00 File Offset: 0x00B52C00
		public void SetActive(bool bActive)
		{
			this.ProxyLayout.RootUIComp.Get().SetUIActive(bActive);
		}

		// Token: 0x06030CAD RID: 199853 RVA: 0x00B54A26 File Offset: 0x00B52C26
		public int GetDisplayGridNum()
		{
			return this.DisplayGridNum;
		}

		// Token: 0x06030CAE RID: 199854 RVA: 0x00B54A2E File Offset: 0x00B52C2E
		public int GetPreservedGridNum()
		{
			return this.CopyItemList.Count;
		}

		// Token: 0x06030CAF RID: 199855 RVA: 0x00B54A3B File Offset: 0x00B52C3B
		public int GetDisplayGridStartIndex()
		{
			return 0;
		}

		// Token: 0x06030CB0 RID: 199856 RVA: 0x00B54A3E File Offset: 0x00B52C3E
		public int GetDisplayGridEndIndex()
		{
			return this.DisplayGridNum - 1;
		}

		// Token: 0x06030CB1 RID: 199857 RVA: 0x00B54A48 File Offset: 0x00B52C48
		public float GetGridAnimationInterval()
		{
			return this.ProxyLayout.GetGridAnimationInterval();
		}

		// Token: 0x06030CB2 RID: 199858 RVA: 0x00B54A55 File Offset: 0x00B52C55
		public float GetGridAnimationStartTime()
		{
			return this.ProxyLayout.GetGridAnimationStartTime();
		}

		// Token: 0x06030CB3 RID: 199859 RVA: 0x00B54A62 File Offset: 0x00B52C62
		public UUIItem GetGrid(int gridIndex)
		{
			return this.GetItemByIndex(gridIndex % this.DisplayGridNum);
		}

		// Token: 0x06030CB4 RID: 199860 RVA: 0x00B54A72 File Offset: 0x00B52C72
		public UUIItem GetGridByDisplayIndex(int displayIndex)
		{
			return this.GetItemByIndex(displayIndex);
		}

		// Token: 0x06030CB5 RID: 199861 RVA: 0x00B54A7B File Offset: 0x00B52C7B
		[NullableContext(1)]
		public void BindLateUpdate(Action<float> callBack)
		{
			this.ProxyLayout.OnLateUpdate.Bind(callBack);
		}

		// Token: 0x06030CB6 RID: 199862 RVA: 0x00B54A8E File Offset: 0x00B52C8E
		public void UnBindLateUpdate()
		{
			this.ProxyLayout.OnLateUpdate.Unbind();
		}

		// Token: 0x06030CB7 RID: 199863 RVA: 0x00B54AA0 File Offset: 0x00B52CA0
		public void NotifyAnimationStart()
		{
			this.ProxyLayout.SetInAnimation(true);
		}

		// Token: 0x06030CB8 RID: 199864 RVA: 0x00B54AAE File Offset: 0x00B52CAE
		public void NotifyAnimationEnd()
		{
			this.ProxyLayout.SetInAnimation(false);
		}

		// Token: 0x06030CB9 RID: 199865 RVA: 0x00B54ABC File Offset: 0x00B52CBC
		public UUIInturnAnimController GetUiAnimController()
		{
			if (this.IsUseByLayout)
			{
				UUILayoutBase proxyLayout = this.ProxyLayout;
				return ((proxyLayout != null) ? proxyLayout.GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController;
			}
			UUIScrollViewWithScrollbarComponent scrollView = this.ScrollView;
			AUIBaseActor auibaseActor = (scrollView != null) ? scrollView.GetContent() : null;
			return ((auibaseActor != null) ? auibaseActor.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController;
		}

		// Token: 0x0401A321 RID: 107297
		private GridAppearAnimationBase GridsController;

		// Token: 0x0401A322 RID: 107298
		private readonly UUILayoutBase ProxyLayout;

		// Token: 0x0401A323 RID: 107299
		private UUIScrollViewWithScrollbarComponent ScrollView;

		// Token: 0x0401A324 RID: 107300
		[Nullable(1)]
		private readonly List<UUIItem> CopyItemList = new List<UUIItem>();

		// Token: 0x0401A325 RID: 107301
		[Nullable(1)]
		private readonly List<UUIItem> PoolItemList = new List<UUIItem>();

		// Token: 0x0401A326 RID: 107302
		private UUIItem OriginalItem;

		// Token: 0x0401A327 RID: 107303
		[Nullable(1)]
		private readonly Dictionary<object, TGenericLayoutNewItem> ItemMap = new Dictionary<object, TGenericLayoutNewItem>();

		// Token: 0x0401A328 RID: 107304
		[Nullable(1)]
		private List<TGenericLayoutNewItem> ItemList = new List<TGenericLayoutNewItem>();

		// Token: 0x0401A329 RID: 107305
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly TLayoutRefresh<TGenericLayoutNewItem> RefreshFunction;

		// Token: 0x0401A32A RID: 107306
		private int DisplayGridNum;

		// Token: 0x0401A32B RID: 107307
		private bool IsClear;

		// Token: 0x0401A32C RID: 107308
		private string DisplayName;

		// Token: 0x0401A32D RID: 107309
		private bool NeedAnim = true;

		// Token: 0x0401A32E RID: 107310
		private bool IsUseByLayout = true;
	}
}
