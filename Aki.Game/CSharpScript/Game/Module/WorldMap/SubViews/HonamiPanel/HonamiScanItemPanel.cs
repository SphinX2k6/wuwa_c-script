using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.HonamiPanel
{
	// Token: 0x02003749 RID: 14153
	public class HonamiScanItemPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024D06 RID: 150790 RVA: 0x00A676B4 File Offset: 0x00A658B4
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024D07 RID: 150791 RVA: 0x00A676BC File Offset: 0x00A658BC
		protected override void OnStart()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(16);
			if (verticalLayout != null)
			{
				verticalLayout.SetActive(false, false);
			}
			UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(7);
			if (verticalLayout2 != null)
			{
				verticalLayout2.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIVerticalLayout verticalLayout3 = base.GetVerticalLayout(5);
			if (verticalLayout3 != null)
			{
				verticalLayout3.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(14);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			base.OnStart();
		}

		// Token: 0x06024D08 RID: 150792 RVA: 0x00A6774C File Offset: 0x00A6594C
		[NullableContext(1)]
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				HonamiScanItemMarkItem honamiScanItemMarkItem = param[0] as HonamiScanItemMarkItem;
				if (honamiScanItemMarkItem != null)
				{
					this.LayoutContext.MarkItem = honamiScanItemMarkItem;
					this.UpdateEnableFastMoveLayout();
					base.UpdateMultiMap();
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateIconByServerMarkItem(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByServerMarkItem(this.LayoutContext);
					this.UpdateTitle();
					this.UpdateDescription();
					base.UpdateTopRightIconActive();
				}
			}
		}

		// Token: 0x06024D09 RID: 150793 RVA: 0x00A677BF File Offset: 0x00A659BF
		protected override void UpdateEnableFastMoveLayout()
		{
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext != null)
			{
				layoutContext.SetConfirmBtnActive(false);
			}
			WorldMapSecondaryUiContext layoutContext2 = this.LayoutContext;
			if (layoutContext2 != null)
			{
				layoutContext2.SetConfirmBtnEnableClick(false);
			}
			base.UpdateQuickGotoActive(true);
		}

		// Token: 0x06024D0A RID: 150794 RVA: 0x00A677EC File Offset: 0x00A659EC
		private void UpdateDescription()
		{
			HonamiScanItemMarkItem honamiScanItemMarkItem = this.LayoutContext.MarkItem as HonamiScanItemMarkItem;
			if (honamiScanItemMarkItem != null)
			{
				UUIText descriptionText = this.LayoutContext.DescriptionText;
				if (descriptionText == null)
				{
					return;
				}
				descriptionText.ShowTextNew(honamiScanItemMarkItem.GetDescriptionText());
			}
		}

		// Token: 0x06024D0B RID: 150795 RVA: 0x00A67828 File Offset: 0x00A65A28
		private void UpdateTitle()
		{
			HonamiScanItemMarkItem honamiScanItemMarkItem = this.LayoutContext.MarkItem as HonamiScanItemMarkItem;
			if (honamiScanItemMarkItem != null)
			{
				UUIText title = this.LayoutContext.Title;
				if (title == null)
				{
					return;
				}
				title.SetText(honamiScanItemMarkItem.GetTitleText(), true);
			}
		}

		// Token: 0x0200949E RID: 38046
		public static class EComponents
		{
			// Token: 0x0402E701 RID: 190209
			public const int HonamiScanItemPanel = 0;
		}
	}
}
