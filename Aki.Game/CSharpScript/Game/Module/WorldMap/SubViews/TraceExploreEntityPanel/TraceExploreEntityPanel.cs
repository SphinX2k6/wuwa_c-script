using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.TraceExploreEntityPanel
{
	// Token: 0x020047EA RID: 18410
	public class TraceExploreEntityPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06030389 RID: 197513 RVA: 0x00B2D0BB File Offset: 0x00B2B2BB
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x0603038A RID: 197514 RVA: 0x00B2D0C2 File Offset: 0x00B2B2C2
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

		// Token: 0x0603038B RID: 197515 RVA: 0x00B2D0F8 File Offset: 0x00B2B2F8
		private void SetPanelItemLayoutActive(bool active)
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(7);
			if (verticalLayout == null)
			{
				return;
			}
			verticalLayout.RootUIComp.Get().SetUIActive(active);
		}

		// Token: 0x0603038C RID: 197516 RVA: 0x00B2D124 File Offset: 0x00B2B324
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

		// Token: 0x0200AAAD RID: 43693
		public static class EComponents
		{
			// Token: 0x04033EC0 RID: 212672
			public const int TraceExploreEntityPanel = 0;
		}
	}
}
