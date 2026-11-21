using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200573E RID: 22334
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlCombineViewListItem : GridProxyAbstract<DangoBrawlCombineViewListItemData>
	{
		// Token: 0x06037003 RID: 225283 RVA: 0x00F59710 File Offset: 0x00F57910
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06037004 RID: 225284 RVA: 0x00F597DC File Offset: 0x00F579DC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlCombineViewListItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlCombineViewListItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037005 RID: 225285 RVA: 0x00F5981F File Offset: 0x00F57A1F
		protected override void OnStart()
		{
			this.InitSequencePlayer();
		}

		// Token: 0x06037006 RID: 225286 RVA: 0x00F59827 File Offset: 0x00F57A27
		protected override void OnBeforeDestroy()
		{
			this.ClearSequencePlayer();
		}

		// Token: 0x06037007 RID: 225287 RVA: 0x00F59830 File Offset: 0x00F57A30
		private DangoBrawlCombineViewGrid CreateMaterialGrid()
		{
			DangoBrawlCombineViewGrid dangoBrawlCombineViewGrid = new DangoBrawlCombineViewGrid();
			this.BindGridCallbacks(dangoBrawlCombineViewGrid);
			return dangoBrawlCombineViewGrid;
		}

		// Token: 0x06037008 RID: 225288 RVA: 0x00F5984C File Offset: 0x00F57A4C
		private void InitSequencePlayer()
		{
			this.ClearSequencePlayer();
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			this.SequencePlayer = new UiSequencePlayer(rootItem);
		}

		// Token: 0x06037009 RID: 225289 RVA: 0x00F59876 File Offset: 0x00F57A76
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0603700A RID: 225290 RVA: 0x00F59890 File Offset: 0x00F57A90
		private void BindGridCallbacks(DangoBrawlCombineViewGrid grid)
		{
			grid.OnGridClick = delegate(int itemId, UUIItem navItem)
			{
				Action<int, UUIItem> onGridClick = this.OnGridClick;
				if (onGridClick == null)
				{
					return;
				}
				onGridClick(itemId, navItem);
			};
			grid.IsSelected = delegate(int itemId)
			{
				Func<int, bool> isGridSelected = this.IsGridSelected;
				return isGridSelected != null && isGridSelected(itemId);
			};
		}

		// Token: 0x0603700B RID: 225291 RVA: 0x00F598B8 File Offset: 0x00F57AB8
		public override void Refresh(DangoBrawlCombineViewListItemData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			DangoBrawlCombineRowData rowData = data.RowData;
			List<DangoBrawlCombineViewGridData> list = this.BuildSourceGridDatas(rowData);
			NoLinq.SortStable<DangoBrawlCombineViewGridData>(list, delegate(DangoBrawlCombineViewGridData left, DangoBrawlCombineViewGridData right)
			{
				int num = DangoBrawlCombineViewListItem.GetSourceSortTier(left).CompareTo(DangoBrawlCombineViewListItem.GetSourceSortTier(right));
				if (num == 0)
				{
					return left.ItemId.CompareTo(right.ItemId);
				}
				return num;
			});
			List<DangoBrawlCombineViewGridData> list2 = list;
			this.ResultGrid.RefreshByGridData(this.BuildResultGridData(rowData.ResultItemId));
			this.ItemGridLayout.RefreshByData(list2, null, false);
			this.RefreshPlusItems(Math.Max(0, list2.Count - 1));
			this.RefreshCombineButton(data.AllowCombine && rowData.CanCombine, rowData.IsLock);
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x0603700C RID: 225292 RVA: 0x00F5996D File Offset: 0x00F57B6D
		private void RefreshCombineButton(bool isShow, bool isLock)
		{
			if (this.BtnCombineItem == null)
			{
				return;
			}
			this.BtnCombineItem.SetUiActive(isShow);
			if (isShow)
			{
				this.BtnCombineItem.SetLock(isLock);
			}
		}

		// Token: 0x0603700D RID: 225293 RVA: 0x00F59994 File Offset: 0x00F57B94
		public void RefreshGridSelection()
		{
			DangoBrawlCombineViewGrid resultGrid = this.ResultGrid;
			if (resultGrid != null)
			{
				Func<int, bool> isGridSelected = this.IsGridSelected;
				resultGrid.SetSelected(isGridSelected != null && isGridSelected(this.ResultGrid.ItemId));
			}
			if (this.ItemGridLayout == null)
			{
				return;
			}
			foreach (DangoBrawlCombineViewGrid dangoBrawlCombineViewGrid in this.ItemGridLayout.GetLayoutItemList())
			{
				DangoBrawlCombineViewGrid dangoBrawlCombineViewGrid2 = dangoBrawlCombineViewGrid;
				Func<int, bool> isGridSelected2 = this.IsGridSelected;
				dangoBrawlCombineViewGrid2.SetSelected(isGridSelected2 != null && isGridSelected2(dangoBrawlCombineViewGrid.ItemId));
			}
		}

		// Token: 0x0603700E RID: 225294 RVA: 0x00F59A3C File Offset: 0x00F57C3C
		private void RefreshPlusItems(int visibleCount)
		{
			UUIItem item = base.GetItem(3);
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(2);
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (horizontalLayout != null) ? new TWeakObjectPtr<UUIItem>?(horizontalLayout.RootUIComp) : null;
			if (item == null || tweakObjectPtr == null)
			{
				return;
			}
			while (this.PlusPool.Count < visibleCount)
			{
				LguiUtil instance = LguiUtil.Instance;
				UUIItem item2 = item;
				TWeakObjectPtr<UUIItem>? tweakObjectPtr2 = tweakObjectPtr;
				UUIItem uuiitem = instance.CopyItem(item2, (tweakObjectPtr2 != null) ? tweakObjectPtr2.GetValueOrDefault() : null);
				uuiitem.SetUIActive(false);
				this.PlusPool.Add(uuiitem);
			}
			for (int i = 0; i < this.PlusPool.Count; i++)
			{
				this.PlusPool[i].SetUIActive(i < visibleCount);
			}
		}

		// Token: 0x0603700F RID: 225295 RVA: 0x00F59AF8 File Offset: 0x00F57CF8
		private List<DangoBrawlCombineViewGridData> BuildSourceGridDatas(DangoBrawlCombineRowData rowData)
		{
			List<DangoBrawlCombineViewGridData> list = new List<DangoBrawlCombineViewGridData>();
			DangoBrawlItemCompose? dangoBrawlItemComposeById = DangoBrawlConfig.Instance.GetDangoBrawlItemComposeById(rowData.ComposeId);
			int[] array = ((dangoBrawlItemComposeById != null) ? dangoBrawlItemComposeById.GetValueOrDefault().GetNeedItemsArray() : null) ?? Array.Empty<int>();
			if (array.Length == 0)
			{
				return list;
			}
			for (int i = 0; i < array.Length; i++)
			{
				int itemId = array[i];
				int itemUid = (i < rowData.SourceItems.Length) ? rowData.SourceItems[i].Uid : 0;
				EDragSourceKind source = (i < rowData.SourceItems.Length) ? rowData.SourceItems[i].Source : EDragSourceKind.Bag;
				list.Add(this.BuildMaterialGridData(itemUid, itemId, source));
			}
			return list;
		}

		// Token: 0x06037010 RID: 225296 RVA: 0x00F59BB8 File Offset: 0x00F57DB8
		private DangoBrawlCombineViewGridData BuildMaterialGridData(int itemUid, int itemId, EDragSourceKind source)
		{
			bool flag = itemUid > 0;
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = source - EDragSourceKind.Bag <= 1;
				flag2 = flag3;
			}
			bool isExist = flag2;
			bool flag4 = flag && source == EDragSourceKind.Shop;
			return new DangoBrawlCombineViewGridData
			{
				ItemUid = itemUid,
				ItemId = itemId,
				IsExist = isExist,
				IsShop = (flag4 ? new bool?(true) : null)
			};
		}

		// Token: 0x06037011 RID: 225297 RVA: 0x00F59C22 File Offset: 0x00F57E22
		private DangoBrawlCombineViewGridData BuildResultGridData(int resultItemId)
		{
			return new DangoBrawlCombineViewGridData
			{
				ItemUid = 0,
				ItemId = resultItemId,
				IsExist = false,
				IsShop = null
			};
		}

		// Token: 0x06037012 RID: 225298 RVA: 0x00F59C4A File Offset: 0x00F57E4A
		private static int GetSourceSortTier(DangoBrawlCombineViewGridData item)
		{
			if (item.IsExist)
			{
				return 0;
			}
			if (item.IsShop.GetValueOrDefault())
			{
				return 1;
			}
			return 2;
		}

		// Token: 0x06037013 RID: 225299 RVA: 0x00F59C68 File Offset: 0x00F57E68
		private void OnClickCombine()
		{
			DangoBrawlCombineViewListItemData currentData = this.CurrentData;
			if (currentData == null || !currentData.AllowCombine || !currentData.RowData.CanCombine)
			{
				return;
			}
			if (currentData.RowData.IsLock)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlTips008", Array.Empty<object>());
				return;
			}
			if (DangoBrawlViewManager.TryBlockIfThreeChoose(true))
			{
				return;
			}
			Action<DangoBrawlCombineRowData> onCombineClick = this.OnCombineClick;
			if (onCombineClick == null)
			{
				return;
			}
			onCombineClick(currentData.RowData);
		}

		// Token: 0x0401D1BD RID: 119229
		[Nullable(2)]
		public Action<DangoBrawlCombineRowData> OnCombineClick;

		// Token: 0x0401D1BE RID: 119230
		[Nullable(2)]
		public Action<int, UUIItem> OnGridClick;

		// Token: 0x0401D1BF RID: 119231
		[Nullable(2)]
		public Func<int, bool> IsGridSelected;

		// Token: 0x0401D1C0 RID: 119232
		[Nullable(2)]
		private DangoBrawlCombineViewGrid ResultGrid;

		// Token: 0x0401D1C1 RID: 119233
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlCombineViewGrid, DangoBrawlCombineViewGridData> ItemGridLayout;

		// Token: 0x0401D1C2 RID: 119234
		[Nullable(2)]
		private DangoBrawlCombineViewBtnItem BtnCombineItem;

		// Token: 0x0401D1C3 RID: 119235
		private readonly List<UUIItem> PlusPool = new List<UUIItem>();

		// Token: 0x0401D1C4 RID: 119236
		[Nullable(2)]
		private DangoBrawlCombineViewListItemData CurrentData;

		// Token: 0x0401D1C5 RID: 119237
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200B2F9 RID: 45817
		[NullableContext(0)]
		private enum EItemComponents
		{
			// Token: 0x040374B4 RID: 226484
			PrefabItem,
			// Token: 0x040374B5 RID: 226485
			ItemLayout,
			// Token: 0x040374B6 RID: 226486
			PlusLayout,
			// Token: 0x040374B7 RID: 226487
			PlusItem,
			// Token: 0x040374B8 RID: 226488
			BtnCombine
		}
	}
}
