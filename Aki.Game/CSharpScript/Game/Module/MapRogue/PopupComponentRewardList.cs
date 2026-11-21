using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200460E RID: 17934
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupComponentRewardList : UiPanelBase
	{
		// Token: 0x0602D0F1 RID: 184561 RVA: 0x00C991AB File Offset: 0x00C973AB
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602D0F2 RID: 184562 RVA: 0x00C991E4 File Offset: 0x00C973E4
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(0), new Func<CommonItemSmallItemGrid>(this.OnCreateRewardItem), null, false, true);
		}

		// Token: 0x0602D0F3 RID: 184563 RVA: 0x00C99208 File Offset: 0x00C97408
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

		// Token: 0x0602D0F4 RID: 184564 RVA: 0x00C9929C File Offset: 0x00C9749C
		private CommonItemSmallItemGrid OnCreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x040182F2 RID: 99058
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;
	}
}
