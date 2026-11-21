using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.TraceExploreEntityPanel
{
	// Token: 0x0200371B RID: 14107
	public class TraceExploreEntityPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024B59 RID: 150361 RVA: 0x00A5CFFF File Offset: 0x00A5B1FF
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024B5A RID: 150362 RVA: 0x00A5D006 File Offset: 0x00A5B206
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(14);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			this.SetPanelItemLayoutActive(false);
		}

		// Token: 0x06024B5B RID: 150363 RVA: 0x00A5D03C File Offset: 0x00A5B23C
		private void SetPanelItemLayoutActive(bool active)
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(7);
			if (verticalLayout == null)
			{
				return;
			}
			verticalLayout.RootUIComp.Get().SetUIActive(active);
		}

		// Token: 0x06024B5C RID: 150364 RVA: 0x00A5D068 File Offset: 0x00A5B268
		[NullableContext(1)]
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				TraceExploreEntityMarkItem traceExploreEntityMarkItem = param[0] as TraceExploreEntityMarkItem;
				if (traceExploreEntityMarkItem != null)
				{
					this.LayoutContext.MarkItem = traceExploreEntityMarkItem;
					this.UpdateEnableFastMoveLayout();
					base.UpdateMultiMap();
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByServerMarkItem(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateDesc(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateDownStateIcon(this.LayoutContext);
					base.UpdateTopRightIconActive();
				}
			}
		}

		// Token: 0x0200945F RID: 37983
		public static class EComponents
		{
			// Token: 0x0402E646 RID: 190022
			public const int TraceExploreEntityPanel = 0;
		}
	}
}
