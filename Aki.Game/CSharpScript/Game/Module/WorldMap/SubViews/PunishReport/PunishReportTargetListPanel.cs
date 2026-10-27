using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.PunishReport
{
	// Token: 0x020047F8 RID: 18424
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportTargetListPanel
	{
		// Token: 0x06030411 RID: 197649 RVA: 0x00B310BD File Offset: 0x00B2F2BD
		public void Initialize(UUILayoutBase rootLayout)
		{
			this.TargetListLayout = new GenericLayoutAdd<PunishReportTargetListItemPanel>(rootLayout, new TLayoutRefresh<PunishReportTargetListItemPanel>(this.OnLayoutRefresh));
		}

		// Token: 0x06030412 RID: 197650 RVA: 0x00B310D8 File Offset: 0x00B2F2D8
		private ILayoutItem<PunishReportTargetListItemPanel> OnLayoutRefresh(object data, UUIItem uiItem, int index, int originalItemIndex)
		{
			PunishReportTargetListItemPanel punishReportTargetListItemPanel = new PunishReportTargetListItemPanel();
			punishReportTargetListItemPanel.CreateThenShowByActorAsync((uiItem != null) ? uiItem.GetOwner() : null, null, false).Forget();
			return new LayoutItem<PunishReportTargetListItemPanel>
			{
				Key = data,
				Value = punishReportTargetListItemPanel
			};
		}

		// Token: 0x06030413 RID: 197651 RVA: 0x00B31118 File Offset: 0x00B2F318
		public PunishReportTargetListItemPanel AddItemByKey(string key)
		{
			GenericLayoutAdd<PunishReportTargetListItemPanel> targetListLayout = this.TargetListLayout;
			PunishReportTargetListItemPanel punishReportTargetListItemPanel = ((targetListLayout != null) ? targetListLayout.GetLayoutItemByKey(key, 0) : null) as PunishReportTargetListItemPanel;
			if (punishReportTargetListItemPanel != null)
			{
				return punishReportTargetListItemPanel;
			}
			GenericLayoutAdd<PunishReportTargetListItemPanel> targetListLayout2 = this.TargetListLayout;
			if (targetListLayout2 != null)
			{
				targetListLayout2.AddItemToLayout(new object[]
				{
					key
				}, 0);
			}
			GenericLayoutAdd<PunishReportTargetListItemPanel> targetListLayout3 = this.TargetListLayout;
			punishReportTargetListItemPanel = (((targetListLayout3 != null) ? targetListLayout3.GetLayoutItemByKey(key, 0) : null) as PunishReportTargetListItemPanel);
			punishReportTargetListItemPanel.SetDescTxt("");
			punishReportTargetListItemPanel.SetNumTxt("");
			punishReportTargetListItemPanel.SetState(EPunishReportTargetListItemPanelState.Lock);
			return punishReportTargetListItemPanel;
		}

		// Token: 0x06030414 RID: 197652 RVA: 0x00B31198 File Offset: 0x00B2F398
		public void Clear()
		{
			GenericLayoutAdd<PunishReportTargetListItemPanel> targetListLayout = this.TargetListLayout;
			if (targetListLayout == null)
			{
				return;
			}
			targetListLayout.ClearChildren();
		}

		// Token: 0x04019F98 RID: 106392
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutAdd<PunishReportTargetListItemPanel> TargetListLayout;
	}
}
