using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020067EE RID: 26606
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlCombineViewListItem : GridProxyAbstract<DangoBrawlCombineViewListItemData>
	{
		// Token: 0x060424AE RID: 271534 RVA: 0x0101825C File Offset: 0x0101645C
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

		// Token: 0x060424AF RID: 271535 RVA: 0x01018328 File Offset: 0x01016528
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlCombineViewListItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlCombineViewListItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060424B0 RID: 271536 RVA: 0x0101836B File Offset: 0x0101656B
		protected override void OnStart()
		{
			this.InitSequencePlayer();
		}

		// Token: 0x060424B1 RID: 271537 RVA: 0x01018373 File Offset: 0x01016573
		protected override void OnBeforeDestroy()
		{
			this.ClearSequencePlayer();
		}

		// Token: 0x060424B2 RID: 271538 RVA: 0x0101837C File Offset: 0x0101657C
		private DangoBrawlCombineViewGrid CreateMaterialGrid()
		{
			DangoBrawlCombineViewGrid dangoBrawlCombineViewGrid = new DangoBrawlCombineViewGrid();
			this.BindGridCallbacks(dangoBrawlCombineViewGrid);
			return dangoBrawlCombineViewGrid;
		}

		// Token: 0x060424B3 RID: 271539 RVA: 0x01018398 File Offset: 0x01016598
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

		// Token: 0x060424B4 RID: 271540 RVA: 0x010183C2 File Offset: 0x010165C2
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060424B5 RID: 271541 RVA: 0x010183DC File Offset: 0x010165DC
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

		// Token: 0x060424B6 RID: 271542 RVA: 0x01018404 File Offset: 0x01016604
		public override void Refresh(DangoBrawlCombineViewListItemData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			DangoBrawlCombineRowData rowData = data.RowData;
			IEnumerable<DangoBrawlCombineViewGridData> source = this.BuildSourceGridDatas(rowData);
			Func<DangoBrawlCombineViewGridData, int> keySelector;
			if ((keySelector = DangoBrawlCombineViewListItem.<>O.<0>__GetSourceSortTier) == null)
			{
				keySelector = (DangoBrawlCombineViewListItem.<>O.<0>__GetSourceSortTier = new Func<DangoBrawlCombineViewGridData, int>(DangoBrawlCombineViewListItem.GetSourceSortTier));
			}
			List<DangoBrawlCombineViewGridData> list = source.OrderBy(keySelector).ThenBy((DangoBrawlCombineViewGridData x) => x.ItemId).ToList<DangoBrawlCombineViewGridData>();
			this.ResultGrid.RefreshByGridData(this.BuildResultGridData(rowData.ResultItemId));
			this.ItemGridLayout.RefreshByData(list, null, false);
			this.RefreshPlusItems(Math.Max(0, list.Count - 1));
			this.RefreshCombineButton(data.AllowCombine && rowData.CanCombine, rowData.IsLock);
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x060424B7 RID: 271543 RVA: 0x010184DD File Offset: 0x010166DD
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

		// Token: 0x060424B8 RID: 271544 RVA: 0x01018504 File Offset: 0x01016704
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

		// Token: 0x060424B9 RID: 271545 RVA: 0x010185AC File Offset: 0x010167AC
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

		// Token: 0x060424BA RID: 271546 RVA: 0x01018668 File Offset: 0x01016868
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

		// Token: 0x060424BB RID: 271547 RVA: 0x01018728 File Offset: 0x01016928
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

		// Token: 0x060424BC RID: 271548 RVA: 0x01018792 File Offset: 0x01016992
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

		// Token: 0x060424BD RID: 271549 RVA: 0x010187BA File Offset: 0x010169BA
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

		// Token: 0x060424BE RID: 271550 RVA: 0x010187D8 File Offset: 0x010169D8
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

		// Token: 0x04022960 RID: 141664
		[Nullable(2)]
		public Action<DangoBrawlCombineRowData> OnCombineClick;

		// Token: 0x04022961 RID: 141665
		[Nullable(2)]
		public Action<int, UUIItem> OnGridClick;

		// Token: 0x04022962 RID: 141666
		[Nullable(2)]
		public Func<int, bool> IsGridSelected;

		// Token: 0x04022963 RID: 141667
		[Nullable(2)]
		private DangoBrawlCombineViewGrid ResultGrid;

		// Token: 0x04022964 RID: 141668
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlCombineViewGrid, DangoBrawlCombineViewGridData> ItemGridLayout;

		// Token: 0x04022965 RID: 141669
		[Nullable(2)]
		private DangoBrawlCombineViewBtnItem BtnCombineItem;

		// Token: 0x04022966 RID: 141670
		private readonly List<UUIItem> PlusPool = new List<UUIItem>();

		// Token: 0x04022967 RID: 141671
		[Nullable(2)]
		private DangoBrawlCombineViewListItemData CurrentData;

		// Token: 0x04022968 RID: 141672
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200C92B RID: 51499
		[NullableContext(0)]
		private enum EItemComponents
		{
			// Token: 0x0403CBC3 RID: 248771
			PrefabItem,
			// Token: 0x0403CBC4 RID: 248772
			ItemLayout,
			// Token: 0x0403CBC5 RID: 248773
			PlusLayout,
			// Token: 0x0403CBC6 RID: 248774
			PlusItem,
			// Token: 0x0403CBC7 RID: 248775
			BtnCombine
		}

		// Token: 0x0200C92C RID: 51500
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403CBC8 RID: 248776
			[Nullable(0)]
			public static Func<DangoBrawlCombineViewGridData, int> <0>__GetSourceSortTier;
		}
	}
}
