using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util.Layout
{
	// Token: 0x0200385C RID: 14428
	[NullableContext(2)]
	[Nullable(0)]
	public class GenericLayoutNew<TGenericLayoutNewItem> : IGridPreserver
	{
		// Token: 0x17004D03 RID: 19715
		// (get) Token: 0x060257C3 RID: 153539 RVA: 0x00A8F211 File Offset: 0x00A8D411
		public UUIItem TempOriginalItem
		{
			get
			{
				return this.OriginalItem;
			}
		}

		// Token: 0x060257C4 RID: 153540 RVA: 0x00A8F21C File Offset: 0x00A8D41C
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

		// Token: 0x060257C5 RID: 153541 RVA: 0x00A8F298 File Offset: 0x00A8D498
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

		// Token: 0x060257C6 RID: 153542 RVA: 0x00A8F314 File Offset: 0x00A8D514
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

		// Token: 0x060257C7 RID: 153543 RVA: 0x00A8F36D File Offset: 0x00A8D56D
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

		// Token: 0x060257C8 RID: 153544 RVA: 0x00A8F390 File Offset: 0x00A8D590
		public void PreLoadCopyItem(int preLoadNum)
		{
			for (int i = 0; i < preLoadNum; i++)
			{
				this.CreateCopyItem().SetUIActive(false);
			}
		}

		// Token: 0x060257C9 RID: 153545 RVA: 0x00A8F3B5 File Offset: 0x00A8D5B5
		public UUIItem GetRootUiItem()
		{
			return this.ProxyLayout.RootUIComp;
		}

		// Token: 0x060257CA RID: 153546 RVA: 0x00A8F3C7 File Offset: 0x00A8D5C7
		private UUIItem GetRootParentUiItem()
		{
			return this.GetRootUiItem().GetParentAsUIItem();
		}

		// Token: 0x060257CB RID: 153547 RVA: 0x00A8F3D4 File Offset: 0x00A8D5D4
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

		// Token: 0x060257CC RID: 153548 RVA: 0x00A8F430 File Offset: 0x00A8D630
		[NullableContext(1)]
		private UUIItem CreateCopyItem()
		{
			UUIItem uuiitem = LguiUtil.Instance.CopyItem(this.OriginalItem, this.GetRootUiItem());
			this.CopyItemList.Add(uuiitem);
			return uuiitem;
		}

		// Token: 0x060257CD RID: 153549 RVA: 0x00A8F464 File Offset: 0x00A8D664
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

		// Token: 0x060257CE RID: 153550 RVA: 0x00A8F4CB File Offset: 0x00A8D6CB
		private void ResetOriginalActor()
		{
			if (this.OriginalItem != null)
			{
				this.OriginalItem.SetUIActive(true);
				this.OriginalItem.SetUIParent(this.GetRootUiItem(), false);
				this.OriginalItem = null;
			}
		}

		// Token: 0x060257CF RID: 153551 RVA: 0x00A8F4FC File Offset: 0x00A8D6FC
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

		// Token: 0x060257D0 RID: 153552 RVA: 0x00A8F5BD File Offset: 0x00A8D7BD
		public void ClearGridController()
		{
			if (this.GridsController != null)
			{
				this.GridsController.Clear();
				this.GridsController = null;
			}
		}

		// Token: 0x060257D1 RID: 153553 RVA: 0x00A8F5D9 File Offset: 0x00A8D7D9
		public void SetNeedAnim(bool value)
		{
			this.NeedAnim = value;
		}

		// Token: 0x060257D2 RID: 153554 RVA: 0x00A8F5E4 File Offset: 0x00A8D7E4
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

		// Token: 0x060257D3 RID: 153555 RVA: 0x00A8F798 File Offset: 0x00A8D998
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

		// Token: 0x060257D4 RID: 153556 RVA: 0x00A8F7CC File Offset: 0x00A8D9CC
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

		// Token: 0x060257D5 RID: 153557 RVA: 0x00A8F7F4 File Offset: 0x00A8D9F4
		[NullableContext(1)]
		public Dictionary<object, TGenericLayoutNewItem> GetLayoutItemMap()
		{
			return this.ItemMap;
		}

		// Token: 0x060257D6 RID: 153558 RVA: 0x00A8F7FC File Offset: 0x00A8D9FC
		[NullableContext(1)]
		public List<TGenericLayoutNewItem> GetLayoutItemList()
		{
			return this.ItemList;
		}

		// Token: 0x060257D7 RID: 153559 RVA: 0x00A8F804 File Offset: 0x00A8DA04
		public TGenericLayoutNewItem GetLayoutItemByIndex(int index)
		{
			if (index >= 0 && index < this.ItemList.Count)
			{
				return this.ItemList[index];
			}
			return default(TGenericLayoutNewItem);
		}

		// Token: 0x060257D8 RID: 153560 RVA: 0x00A8F839 File Offset: 0x00A8DA39
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

		// Token: 0x060257D9 RID: 153561 RVA: 0x00A8F870 File Offset: 0x00A8DA70
		public void SetActive(bool bActive)
		{
			this.ProxyLayout.RootUIComp.Get().SetUIActive(bActive);
		}

		// Token: 0x060257DA RID: 153562 RVA: 0x00A8F896 File Offset: 0x00A8DA96
		public int GetDisplayGridNum()
		{
			return this.DisplayGridNum;
		}

		// Token: 0x060257DB RID: 153563 RVA: 0x00A8F89E File Offset: 0x00A8DA9E
		public int GetPreservedGridNum()
		{
			return this.CopyItemList.Count;
		}

		// Token: 0x060257DC RID: 153564 RVA: 0x00A8F8AB File Offset: 0x00A8DAAB
		public int GetDisplayGridStartIndex()
		{
			return 0;
		}

		// Token: 0x060257DD RID: 153565 RVA: 0x00A8F8AE File Offset: 0x00A8DAAE
		public int GetDisplayGridEndIndex()
		{
			return this.DisplayGridNum - 1;
		}

		// Token: 0x060257DE RID: 153566 RVA: 0x00A8F8B8 File Offset: 0x00A8DAB8
		public float GetGridAnimationInterval()
		{
			return this.ProxyLayout.GetGridAnimationInterval();
		}

		// Token: 0x060257DF RID: 153567 RVA: 0x00A8F8C5 File Offset: 0x00A8DAC5
		public float GetGridAnimationStartTime()
		{
			return this.ProxyLayout.GetGridAnimationStartTime();
		}

		// Token: 0x060257E0 RID: 153568 RVA: 0x00A8F8D2 File Offset: 0x00A8DAD2
		public UUIItem GetGrid(int gridIndex)
		{
			return this.GetItemByIndex(gridIndex % this.DisplayGridNum);
		}

		// Token: 0x060257E1 RID: 153569 RVA: 0x00A8F8E2 File Offset: 0x00A8DAE2
		public UUIItem GetGridByDisplayIndex(int displayIndex)
		{
			return this.GetItemByIndex(displayIndex);
		}

		// Token: 0x060257E2 RID: 153570 RVA: 0x00A8F8EB File Offset: 0x00A8DAEB
		[NullableContext(1)]
		public void BindLateUpdate(Action<float> callBack)
		{
			this.ProxyLayout.OnLateUpdate.Bind(callBack);
		}

		// Token: 0x060257E3 RID: 153571 RVA: 0x00A8F8FE File Offset: 0x00A8DAFE
		public void UnBindLateUpdate()
		{
			this.ProxyLayout.OnLateUpdate.Unbind();
		}

		// Token: 0x060257E4 RID: 153572 RVA: 0x00A8F910 File Offset: 0x00A8DB10
		public void NotifyAnimationStart()
		{
			this.ProxyLayout.SetInAnimation(true);
		}

		// Token: 0x060257E5 RID: 153573 RVA: 0x00A8F91E File Offset: 0x00A8DB1E
		public void NotifyAnimationEnd()
		{
			this.ProxyLayout.SetInAnimation(false);
		}

		// Token: 0x060257E6 RID: 153574 RVA: 0x00A8F92C File Offset: 0x00A8DB2C
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

		// Token: 0x04014B94 RID: 84884
		private GridAppearAnimationBase GridsController;

		// Token: 0x04014B95 RID: 84885
		private readonly UUILayoutBase ProxyLayout;

		// Token: 0x04014B96 RID: 84886
		private UUIScrollViewWithScrollbarComponent ScrollView;

		// Token: 0x04014B97 RID: 84887
		[Nullable(1)]
		private readonly List<UUIItem> CopyItemList = new List<UUIItem>();

		// Token: 0x04014B98 RID: 84888
		[Nullable(1)]
		private readonly List<UUIItem> PoolItemList = new List<UUIItem>();

		// Token: 0x04014B99 RID: 84889
		private UUIItem OriginalItem;

		// Token: 0x04014B9A RID: 84890
		[Nullable(1)]
		private readonly Dictionary<object, TGenericLayoutNewItem> ItemMap = new Dictionary<object, TGenericLayoutNewItem>();

		// Token: 0x04014B9B RID: 84891
		[Nullable(1)]
		private List<TGenericLayoutNewItem> ItemList = new List<TGenericLayoutNewItem>();

		// Token: 0x04014B9C RID: 84892
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly TLayoutRefresh<TGenericLayoutNewItem> RefreshFunction;

		// Token: 0x04014B9D RID: 84893
		private int DisplayGridNum;

		// Token: 0x04014B9E RID: 84894
		private bool IsClear;

		// Token: 0x04014B9F RID: 84895
		private string DisplayName;

		// Token: 0x04014BA0 RID: 84896
		private bool NeedAnim = true;

		// Token: 0x04014BA1 RID: 84897
		private bool IsUseByLayout = true;
	}
}
