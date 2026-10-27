using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005638 RID: 22072
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupComponentRewardList : UiPanelBase
	{
		// Token: 0x060381F3 RID: 229875 RVA: 0x00D4B463 File Offset: 0x00D49663
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x060381F4 RID: 229876 RVA: 0x00D4B49C File Offset: 0x00D4969C
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(0), new Func<CommonItemSmallItemGrid>(this.OnCreateRewardItem), null, false, true);
		}

		// Token: 0x060381F5 RID: 229877 RVA: 0x00D4B4C0 File Offset: 0x00D496C0
		public void Refresh(MapGridData gridData)
		{
			if (gridData.RewardItemIdList.Count == 0 || gridData.IsExplore)
			{
				this.SetActive(false);
				return;
			}
			List<TItem> list = new List<TItem>();
			foreach (int itemId in gridData.RewardItemIdList)
			{
				TItem item = new TItem(new InventoryDefine.GetItemData(itemId, 0), 0);
				list.Add(item);
			}
			this.ItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x060381F6 RID: 229878 RVA: 0x00D4B554 File Offset: 0x00D49754
		private CommonItemSmallItemGrid OnCreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0401D867 RID: 120935
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;
	}
}
