using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006801 RID: 26625
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookFilterSortItem : UiPanelBase
	{
		// Token: 0x06042686 RID: 272006 RVA: 0x010203CC File Offset: 0x0101E5CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06042687 RID: 272007 RVA: 0x010204B9 File Offset: 0x0101E6B9
		protected override void OnStart()
		{
			this.SortSelectLayout = new GenericLayout<DangoBrawlHandBookFilterSortSelectItem, int>(base.GetGridLayout(0), new Func<DangoBrawlHandBookFilterSortSelectItem>(this.CreateSelectItem), null, false, true);
			this.RefreshSortItem();
		}

		// Token: 0x06042688 RID: 272008 RVA: 0x010204E2 File Offset: 0x0101E6E2
		public void SetSelectedIds(IReadOnlyList<int> ids)
		{
			this.SelectedSortItemList.Clear();
			this.SelectedSortItemList.AddRange(ids);
			this.RefreshSortItem();
		}

		// Token: 0x06042689 RID: 272009 RVA: 0x01020501 File Offset: 0x0101E701
		public void ResetSelection()
		{
			this.SelectedSortItemList.Clear();
			this.RefreshSortItem();
		}

		// Token: 0x0604268A RID: 272010 RVA: 0x01020514 File Offset: 0x0101E714
		public List<int> GetSelectedIds()
		{
			return this.SelectedSortItemList;
		}

		// Token: 0x0604268B RID: 272011 RVA: 0x0102051C File Offset: 0x0101E71C
		private DangoBrawlHandBookFilterSortSelectItem CreateSelectItem()
		{
			return new DangoBrawlHandBookFilterSortSelectItem
			{
				OnClickSortSelect = new Action<int>(this.OnClickSortItem),
				IsSelectedCheck = new Func<int, bool>(this.IsSortItemSelected)
			};
		}

		// Token: 0x0604268C RID: 272012 RVA: 0x01020547 File Offset: 0x0101E747
		private bool IsSortItemSelected(int itemId)
		{
			return this.SelectedSortItemList.Contains(itemId);
		}

		// Token: 0x0604268D RID: 272013 RVA: 0x01020558 File Offset: 0x0101E758
		private void RefreshSortItem()
		{
			IEnumerable<DangoBrawlOccupation> occupationConfigList = DangoBrawlConfig.Instance.GetOccupationConfigList();
			List<int> list = new List<int>();
			foreach (DangoBrawlOccupation dangoBrawlOccupation in occupationConfigList)
			{
				list.Add(dangoBrawlOccupation.Id);
			}
			GenericLayout<DangoBrawlHandBookFilterSortSelectItem, int> sortSelectLayout = this.SortSelectLayout;
			if (sortSelectLayout == null)
			{
				return;
			}
			sortSelectLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0604268E RID: 272014 RVA: 0x010205C8 File Offset: 0x0101E7C8
		private void OnClickSortItem(int itemId)
		{
			if (this.SelectedSortItemList.Contains(itemId))
			{
				this.SelectedSortItemList.Remove(itemId);
			}
			else
			{
				this.SelectedSortItemList.Add(itemId);
			}
			Action<List<int>> onClickSortList = this.OnClickSortList;
			if (onClickSortList == null)
			{
				return;
			}
			onClickSortList(this.SelectedSortItemList);
		}

		// Token: 0x040229CA RID: 141770
		private readonly List<int> SelectedSortItemList = new List<int>();

		// Token: 0x040229CB RID: 141771
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<List<int>> OnClickSortList;

		// Token: 0x040229CC RID: 141772
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DangoBrawlHandBookFilterSortSelectItem, int> SortSelectLayout;

		// Token: 0x0200C972 RID: 51570
		[NullableContext(0)]
		private enum EItemComponent
		{
			// Token: 0x0403CD47 RID: 249159
			PnlGridBase,
			// Token: 0x0403CD48 RID: 249160
			TogBrawlSort,
			// Token: 0x0403CD49 RID: 249161
			TxtTitle,
			// Token: 0x0403CD4A RID: 249162
			PnlGridBaseSelect,
			// Token: 0x0403CD4B RID: 249163
			TogBrawlSortAll,
			// Token: 0x0403CD4C RID: 249164
			TogBrawlSortInv
		}
	}
}
