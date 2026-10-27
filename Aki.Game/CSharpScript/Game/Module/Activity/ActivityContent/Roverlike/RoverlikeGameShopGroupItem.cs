using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006158 RID: 24920
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeGameShopGroupItem : GridProxyAbstract<IRoverlikeGameShopGroupData>
	{
		// Token: 0x0603EFCB RID: 257995 RVA: 0x00F373CB File Offset: 0x00F355CB
		public void BindOnGridSelect(Action<IRoverlikeGameShopGridData> cb)
		{
			this.OnGridSelect = cb;
		}

		// Token: 0x0603EFCC RID: 257996 RVA: 0x00F373D4 File Offset: 0x00F355D4
		public void BindOnGridsRefreshed(Action<ERoverlikeGameShopItemType> cb)
		{
			this.OnGridsRefreshed = cb;
		}

		// Token: 0x0603EFCD RID: 257997 RVA: 0x00F373E0 File Offset: 0x00F355E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EFCE RID: 257998 RVA: 0x00F3746A File Offset: 0x00F3566A
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<RoverlikeGameShopGrid, IRoverlikeGameShopGridData>(base.GetGridLayout(1), new Func<RoverlikeGameShopGrid>(this.CreateShopGrid), null, false, true);
		}

		// Token: 0x0603EFCF RID: 257999 RVA: 0x00F37490 File Offset: 0x00F35690
		public override void Refresh(IRoverlikeGameShopGroupData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TitleTextKey, Array.Empty<object>());
			ERoverlikeGameShopItemType groupType = data.GroupType;
			this.ItemLayout.RefreshByData(data.Grids, delegate
			{
				Action<ERoverlikeGameShopItemType> onGridsRefreshed = this.OnGridsRefreshed;
				if (onGridsRefreshed == null)
				{
					return;
				}
				onGridsRefreshed(groupType);
			}, false);
		}

		// Token: 0x0603EFD0 RID: 258000 RVA: 0x00F374F0 File Offset: 0x00F356F0
		public override object GetKey(IRoverlikeGameShopGroupData data, int displayIndex)
		{
			return data.GroupType;
		}

		// Token: 0x0603EFD1 RID: 258001 RVA: 0x00F374FD File Offset: 0x00F356FD
		public void SetGridSelected(int incId, bool selected)
		{
			if (this.ItemLayout == null)
			{
				return;
			}
			RoverlikeGameShopGrid layoutItemByKey = this.ItemLayout.GetLayoutItemByKey(incId);
			if (layoutItemByKey == null)
			{
				return;
			}
			layoutItemByKey.SetSelected(selected, false);
		}

		// Token: 0x0603EFD2 RID: 258002 RVA: 0x00F37528 File Offset: 0x00F35728
		[NullableContext(2)]
		public UUIItem GetGridNavigationItem(int incId)
		{
			GenericLayout<RoverlikeGameShopGrid, IRoverlikeGameShopGridData> itemLayout = this.ItemLayout;
			TWeakObjectPtr<UUIItem>? tweakObjectPtr;
			if (itemLayout == null)
			{
				tweakObjectPtr = null;
			}
			else
			{
				RoverlikeGameShopGrid layoutItemByKey = itemLayout.GetLayoutItemByKey(incId);
				if (layoutItemByKey == null)
				{
					tweakObjectPtr = null;
				}
				else
				{
					UUIExtendToggle itemGridExtendToggle = layoutItemByKey.GetItemGridExtendToggle();
					tweakObjectPtr = ((itemGridExtendToggle != null) ? new TWeakObjectPtr<UUIItem>?(itemGridExtendToggle.RootUIComp) : null);
				}
			}
			TWeakObjectPtr<UUIItem>? tweakObjectPtr2 = tweakObjectPtr;
			if (tweakObjectPtr2 == null)
			{
				return null;
			}
			return tweakObjectPtr2.GetValueOrDefault();
		}

		// Token: 0x0603EFD3 RID: 258003 RVA: 0x00F3759A File Offset: 0x00F3579A
		private RoverlikeGameShopGrid CreateShopGrid()
		{
			RoverlikeGameShopGrid roverlikeGameShopGrid = new RoverlikeGameShopGrid();
			roverlikeGameShopGrid.BindOnSelect(new Action<IRoverlikeGameShopGridData>(this.OnGridSelectFromLayout));
			return roverlikeGameShopGrid;
		}

		// Token: 0x0603EFD4 RID: 258004 RVA: 0x00F375B3 File Offset: 0x00F357B3
		private void OnGridSelectFromLayout(IRoverlikeGameShopGridData data)
		{
			Action<IRoverlikeGameShopGridData> onGridSelect = this.OnGridSelect;
			if (onGridSelect == null)
			{
				return;
			}
			onGridSelect(data);
		}

		// Token: 0x0603EFD5 RID: 258005 RVA: 0x00F375C6 File Offset: 0x00F357C6
		protected override void OnBeforeDestroy()
		{
			this.OnGridSelect = null;
			this.OnGridsRefreshed = null;
		}

		// Token: 0x04020DE0 RID: 134624
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeGameShopGrid, IRoverlikeGameShopGridData> ItemLayout;

		// Token: 0x04020DE1 RID: 134625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeGameShopGridData> OnGridSelect;

		// Token: 0x04020DE2 RID: 134626
		[Nullable(2)]
		private Action<ERoverlikeGameShopItemType> OnGridsRefreshed;

		// Token: 0x0200C3B5 RID: 50101
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B0E6 RID: 241894
			public const int TxtTitle = 0;

			// Token: 0x0403B0E7 RID: 241895
			public const int ItemLayout = 1;

			// Token: 0x0403B0E8 RID: 241896
			public const int ItemShopGrid = 2;
		}
	}
}
