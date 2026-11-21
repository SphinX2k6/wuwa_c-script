using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.GreatSword
{
	// Token: 0x0200374E RID: 14158
	[NullableContext(1)]
	[Nullable(0)]
	public class GreatSwordMarkTargetListPanel
	{
		// Token: 0x06024D21 RID: 150817 RVA: 0x00A67EDC File Offset: 0x00A660DC
		public void Initialize(UUILayoutBase rootLayout)
		{
			this.TargetListLayout = new GenericLayoutAdd<GreatSwordMarkTargetListItemPanel>(rootLayout, new TLayoutRefresh<GreatSwordMarkTargetListItemPanel>(this.OnLayoutRefresh));
		}

		// Token: 0x06024D22 RID: 150818 RVA: 0x00A67EF8 File Offset: 0x00A660F8
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

		// Token: 0x06024D23 RID: 150819 RVA: 0x00A67F34 File Offset: 0x00A66134
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

		// Token: 0x06024D24 RID: 150820 RVA: 0x00A67FA1 File Offset: 0x00A661A1
		public void Clear()
		{
			GenericLayoutAdd<GreatSwordMarkTargetListItemPanel> targetListLayout = this.TargetListLayout;
			if (targetListLayout == null)
			{
				return;
			}
			targetListLayout.ClearChildren();
		}

		// Token: 0x040146BF RID: 83647
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutAdd<GreatSwordMarkTargetListItemPanel> TargetListLayout;
	}
}
