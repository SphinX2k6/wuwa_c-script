using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020036F2 RID: 14066
	[NullableContext(1)]
	[Nullable(0)]
	public class TipsListView
	{
		// Token: 0x060249B1 RID: 149937 RVA: 0x00A5734E File Offset: 0x00A5554E
		public void Initialize(UUILayoutBase rootLayout)
		{
			this.InstanceCostTipView = new GenericLayoutAdd<InstanceDungeonCostTip>(rootLayout, new TLayoutRefresh<InstanceDungeonCostTip>(this.OnInstanceRefresh));
		}

		// Token: 0x060249B2 RID: 149938 RVA: 0x00A57368 File Offset: 0x00A55568
		private ILayoutItem<InstanceDungeonCostTip> OnInstanceRefresh(object data, UUIItem uiItem, int index, int originalItemIndex)
		{
			InstanceDungeonCostTip instanceDungeonCostTip = new InstanceDungeonCostTip();
			instanceDungeonCostTip.SetRootActor(uiItem.GetOwner(), true);
			return new LayoutItem<InstanceDungeonCostTip>
			{
				Key = data,
				Value = instanceDungeonCostTip
			};
		}

		// Token: 0x060249B3 RID: 149939 RVA: 0x00A5739C File Offset: 0x00A5559C
		public InstanceDungeonCostTip AddItemByKey(string key)
		{
			InstanceDungeonCostTip instanceDungeonCostTip = this.InstanceCostTipView.GetLayoutItemByKey(key, 0) as InstanceDungeonCostTip;
			if (instanceDungeonCostTip != null)
			{
				return instanceDungeonCostTip;
			}
			this.InstanceCostTipView.AddItemToLayout(new object[]
			{
				key
			}, 0);
			instanceDungeonCostTip = (this.InstanceCostTipView.GetLayoutItemByKey(key, 0) as InstanceDungeonCostTip);
			instanceDungeonCostTip.SetStarVisible(false);
			instanceDungeonCostTip.SetIconVisible(false);
			instanceDungeonCostTip.SetLeftText("");
			instanceDungeonCostTip.SetRightText("");
			return instanceDungeonCostTip;
		}

		// Token: 0x060249B4 RID: 149940 RVA: 0x00A5740F File Offset: 0x00A5560F
		public void Clear()
		{
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView == null)
			{
				return;
			}
			instanceCostTipView.ClearChildren();
		}

		// Token: 0x04014587 RID: 83335
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutAdd<InstanceDungeonCostTip> InstanceCostTipView;
	}
}
