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
	// Token: 0x02005751 RID: 22353
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookFilterSortItem : UiPanelBase
	{
		// Token: 0x060371DB RID: 225755 RVA: 0x00F61910 File Offset: 0x00F5FB10
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

		// Token: 0x060371DC RID: 225756 RVA: 0x00F619FD File Offset: 0x00F5FBFD
		protected override void OnStart()
		{
			this.SortSelectLayout = new GenericLayout<DangoBrawlHandBookFilterSortSelectItem, int>(base.GetGridLayout(0), new Func<DangoBrawlHandBookFilterSortSelectItem>(this.CreateSelectItem), null, false, true);
			this.RefreshSortItem();
		}

		// Token: 0x060371DD RID: 225757 RVA: 0x00F61A26 File Offset: 0x00F5FC26
		public void SetSelectedIds(IReadOnlyList<int> ids)
		{
			this.SelectedSortItemList.Clear();
			this.SelectedSortItemList.AddRange(ids);
			this.RefreshSortItem();
		}

		// Token: 0x060371DE RID: 225758 RVA: 0x00F61A45 File Offset: 0x00F5FC45
		public void ResetSelection()
		{
			this.SelectedSortItemList.Clear();
			this.RefreshSortItem();
		}

		// Token: 0x060371DF RID: 225759 RVA: 0x00F61A58 File Offset: 0x00F5FC58
		public List<int> GetSelectedIds()
		{
			return this.SelectedSortItemList;
		}

		// Token: 0x060371E0 RID: 225760 RVA: 0x00F61A60 File Offset: 0x00F5FC60
		private DangoBrawlHandBookFilterSortSelectItem CreateSelectItem()
		{
			return new DangoBrawlHandBookFilterSortSelectItem
			{
				OnClickSortSelect = new Action<int>(this.OnClickSortItem),
				IsSelectedCheck = new Func<int, bool>(this.IsSortItemSelected)
			};
		}

		// Token: 0x060371E1 RID: 225761 RVA: 0x00F61A8B File Offset: 0x00F5FC8B
		private bool IsSortItemSelected(int itemId)
		{
			return this.SelectedSortItemList.Contains(itemId);
		}

		// Token: 0x060371E2 RID: 225762 RVA: 0x00F61A9C File Offset: 0x00F5FC9C
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

		// Token: 0x060371E3 RID: 225763 RVA: 0x00F61B0C File Offset: 0x00F5FD0C
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

		// Token: 0x0401D227 RID: 119335
		private readonly List<int> SelectedSortItemList = new List<int>();

		// Token: 0x0401D228 RID: 119336
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<List<int>> OnClickSortList;

		// Token: 0x0401D229 RID: 119337
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DangoBrawlHandBookFilterSortSelectItem, int> SortSelectLayout;

		// Token: 0x0200B33F RID: 45887
		[NullableContext(0)]
		private enum EItemComponent
		{
			// Token: 0x04037634 RID: 226868
			PnlGridBase,
			// Token: 0x04037635 RID: 226869
			TogBrawlSort,
			// Token: 0x04037636 RID: 226870
			TxtTitle,
			// Token: 0x04037637 RID: 226871
			PnlGridBaseSelect,
			// Token: 0x04037638 RID: 226872
			TogBrawlSortAll,
			// Token: 0x04037639 RID: 226873
			TogBrawlSortInv
		}
	}
}
