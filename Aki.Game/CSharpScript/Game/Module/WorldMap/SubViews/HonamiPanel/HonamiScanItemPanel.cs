using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.HonamiPanel
{
	// Token: 0x02004818 RID: 18456
	public class HonamiScanItemPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06030536 RID: 197942 RVA: 0x00B375F8 File Offset: 0x00B357F8
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06030537 RID: 197943 RVA: 0x00B37600 File Offset: 0x00B35800
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

		// Token: 0x06030538 RID: 197944 RVA: 0x00B37690 File Offset: 0x00B35890
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

		// Token: 0x06030539 RID: 197945 RVA: 0x00B37703 File Offset: 0x00B35903
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

		// Token: 0x0603053A RID: 197946 RVA: 0x00B37730 File Offset: 0x00B35930
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

		// Token: 0x0603053B RID: 197947 RVA: 0x00B3776C File Offset: 0x00B3596C
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

		// Token: 0x0200AAEF RID: 43759
		public static class EComponents
		{
			// Token: 0x04033F81 RID: 212865
			public const int HonamiScanItemPanel = 0;
		}
	}
}
