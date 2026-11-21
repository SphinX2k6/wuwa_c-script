using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.PunishReport
{
	// Token: 0x02003729 RID: 14121
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportTargetListPanel
	{
		// Token: 0x06024BE1 RID: 150497 RVA: 0x00A6105D File Offset: 0x00A5F25D
		public void Initialize(UUILayoutBase rootLayout)
		{
			this.TargetListLayout = new GenericLayoutAdd<PunishReportTargetListItemPanel>(rootLayout, new TLayoutRefresh<PunishReportTargetListItemPanel>(this.OnLayoutRefresh));
		}

		// Token: 0x06024BE2 RID: 150498 RVA: 0x00A61078 File Offset: 0x00A5F278
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

		// Token: 0x06024BE3 RID: 150499 RVA: 0x00A610B8 File Offset: 0x00A5F2B8
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

		// Token: 0x06024BE4 RID: 150500 RVA: 0x00A61138 File Offset: 0x00A5F338
		public void Clear()
		{
			GenericLayoutAdd<PunishReportTargetListItemPanel> targetListLayout = this.TargetListLayout;
			if (targetListLayout == null)
			{
				return;
			}
			targetListLayout.ClearChildren();
		}

		// Token: 0x0401464C RID: 83532
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutAdd<PunishReportTargetListItemPanel> TargetListLayout;
	}
}
