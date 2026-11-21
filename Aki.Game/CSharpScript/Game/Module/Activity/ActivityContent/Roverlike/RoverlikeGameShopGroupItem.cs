using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050D6 RID: 20694
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeGameShopGroupItem : GridProxyAbstract<IRoverlikeGameShopGroupData>
	{
		// Token: 0x06033C8B RID: 212107 RVA: 0x00E7E29F File Offset: 0x00E7C49F
		public void BindOnGridSelect(Action<IRoverlikeGameShopGridData> cb)
		{
			this.OnGridSelect = cb;
		}

		// Token: 0x06033C8C RID: 212108 RVA: 0x00E7E2A8 File Offset: 0x00E7C4A8
		public void BindOnGridsRefreshed(Action<ERoverlikeGameShopItemType> cb)
		{
			this.OnGridsRefreshed = cb;
		}

		// Token: 0x06033C8D RID: 212109 RVA: 0x00E7E2B4 File Offset: 0x00E7C4B4
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

		// Token: 0x06033C8E RID: 212110 RVA: 0x00E7E33E File Offset: 0x00E7C53E
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<RoverlikeGameShopGrid, IRoverlikeGameShopGridData>(base.GetGridLayout(1), new Func<RoverlikeGameShopGrid>(this.CreateShopGrid), null, false, true);
		}

		// Token: 0x06033C8F RID: 212111 RVA: 0x00E7E364 File Offset: 0x00E7C564
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

		// Token: 0x06033C90 RID: 212112 RVA: 0x00E7E3C4 File Offset: 0x00E7C5C4
		public override object GetKey(IRoverlikeGameShopGroupData data, int displayIndex)
		{
			return data.GroupType;
		}

		// Token: 0x06033C91 RID: 212113 RVA: 0x00E7E3D1 File Offset: 0x00E7C5D1
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

		// Token: 0x06033C92 RID: 212114 RVA: 0x00E7E3FC File Offset: 0x00E7C5FC
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

		// Token: 0x06033C93 RID: 212115 RVA: 0x00E7E46E File Offset: 0x00E7C66E
		private RoverlikeGameShopGrid CreateShopGrid()
		{
			RoverlikeGameShopGrid roverlikeGameShopGrid = new RoverlikeGameShopGrid();
			roverlikeGameShopGrid.BindOnSelect(new Action<IRoverlikeGameShopGridData>(this.OnGridSelectFromLayout));
			return roverlikeGameShopGrid;
		}

		// Token: 0x06033C94 RID: 212116 RVA: 0x00E7E487 File Offset: 0x00E7C687
		private void OnGridSelectFromLayout(IRoverlikeGameShopGridData data)
		{
			Action<IRoverlikeGameShopGridData> onGridSelect = this.OnGridSelect;
			if (onGridSelect == null)
			{
				return;
			}
			onGridSelect(data);
		}

		// Token: 0x06033C95 RID: 212117 RVA: 0x00E7E49A File Offset: 0x00E7C69A
		protected override void OnBeforeDestroy()
		{
			this.OnGridSelect = null;
			this.OnGridsRefreshed = null;
		}

		// Token: 0x0401B70D RID: 112397
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeGameShopGrid, IRoverlikeGameShopGridData> ItemLayout;

		// Token: 0x0401B70E RID: 112398
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeGameShopGridData> OnGridSelect;

		// Token: 0x0401B70F RID: 112399
		[Nullable(2)]
		private Action<ERoverlikeGameShopItemType> OnGridsRefreshed;

		// Token: 0x0200AD9C RID: 44444
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035A47 RID: 219719
			public const int TxtTitle = 0;

			// Token: 0x04035A48 RID: 219720
			public const int ItemLayout = 1;

			// Token: 0x04035A49 RID: 219721
			public const int ItemShopGrid = 2;
		}
	}
}
