using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.GreatSword
{
	// Token: 0x0200481D RID: 18461
	[NullableContext(1)]
	[Nullable(0)]
	public class GreatSwordMarkTargetListPanel
	{
		// Token: 0x06030551 RID: 197969 RVA: 0x00B37E1C File Offset: 0x00B3601C
		public void Initialize(UUILayoutBase rootLayout)
		{
			this.TargetListLayout = new GenericLayoutAdd<GreatSwordMarkTargetListItemPanel>(rootLayout, new TLayoutRefresh<GreatSwordMarkTargetListItemPanel>(this.OnLayoutRefresh));
		}

		// Token: 0x06030552 RID: 197970 RVA: 0x00B37E38 File Offset: 0x00B36038
		private ILayoutItem<GreatSwordMarkTargetListItemPanel> OnLayoutRefresh(object data, UUIItem uiItem, int index, int originalItemIndex)
		{
			GreatSwordMarkTargetListItemPanel greatSwordMarkTargetListItemPanel = new GreatSwordMarkTargetListItemPanel();
			greatSwordMarkTargetListItemPanel.CreateThenShowByActorAsync(uiItem.GetOwner(), null, false).Forget();
			return new LayoutItem<GreatSwordMarkTargetListItemPanel>
			{
				Key = data,
				Value = greatSwordMarkTargetListItemPanel
			};
		}

		// Token: 0x06030553 RID: 197971 RVA: 0x00B37E74 File Offset: 0x00B36074
		public GreatSwordMarkTargetListItemPanel AddItemByKey(string key)
		{
			GenericLayoutAdd<GreatSwordMarkTargetListItemPanel> targetListLayout = this.TargetListLayout;
			GreatSwordMarkTargetListItemPanel greatSwordMarkTargetListItemPanel = ((targetListLayout != null) ? targetListLayout.GetLayoutItemByKey(key, 0) : null) as GreatSwordMarkTargetListItemPanel;
			if (greatSwordMarkTargetListItemPanel != null)
			{
				return greatSwordMarkTargetListItemPanel;
			}
			GenericLayoutAdd<GreatSwordMarkTargetListItemPanel> targetListLayout2 = this.TargetListLayout;
			if (targetListLayout2 != null)
			{
				targetListLayout2.AddItemToLayout(new object[]
				{
					key
				}, 0);
			}
			GenericLayoutAdd<GreatSwordMarkTargetListItemPanel> targetListLayout3 = this.TargetListLayout;
			greatSwordMarkTargetListItemPanel = (((targetListLayout3 != null) ? targetListLayout3.GetLayoutItemByKey(key, 0) : null) as GreatSwordMarkTargetListItemPanel);
			if (greatSwordMarkTargetListItemPanel != null)
			{
				greatSwordMarkTargetListItemPanel.SetState(false);
			}
			return greatSwordMarkTargetListItemPanel;
		}

		// Token: 0x06030554 RID: 197972 RVA: 0x00B37EE1 File Offset: 0x00B360E1
		public void Clear()
		{
			GenericLayoutAdd<GreatSwordMarkTargetListItemPanel> targetListLayout = this.TargetListLayout;
			if (targetListLayout == null)
			{
				return;
			}
			targetListLayout.ClearChildren();
		}

		// Token: 0x0401A00B RID: 106507
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutAdd<GreatSwordMarkTargetListItemPanel> TargetListLayout;
	}
}
