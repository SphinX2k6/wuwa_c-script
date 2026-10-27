using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020047C1 RID: 18369
	[NullableContext(1)]
	[Nullable(0)]
	public class TipsListView
	{
		// Token: 0x060301E1 RID: 197089 RVA: 0x00B27542 File Offset: 0x00B25742
		public void Initialize(UUILayoutBase rootLayout)
		{
			this.InstanceCostTipView = new GenericLayoutAdd<InstanceDungeonCostTip>(rootLayout, new TLayoutRefresh<InstanceDungeonCostTip>(this.OnInstanceRefresh));
		}

		// Token: 0x060301E2 RID: 197090 RVA: 0x00B2755C File Offset: 0x00B2575C
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

		// Token: 0x060301E3 RID: 197091 RVA: 0x00B27590 File Offset: 0x00B25790
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

		// Token: 0x060301E4 RID: 197092 RVA: 0x00B27603 File Offset: 0x00B25803
		public void Clear()
		{
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView == null)
			{
				return;
			}
			instanceCostTipView.ClearChildren();
		}

		// Token: 0x04019ED6 RID: 106198
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutAdd<InstanceDungeonCostTip> InstanceCostTipView;
	}
}
