using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CaveHole
{
	// Token: 0x02004841 RID: 18497
	public class CaveHoleSecondaryPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x0603067A RID: 198266 RVA: 0x00B3C5E0 File Offset: 0x00B3A7E0
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x0603067B RID: 198267 RVA: 0x00B3C5E8 File Offset: 0x00B3A7E8
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(7);
			if (verticalLayout != null)
			{
				verticalLayout.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(5);
			if (verticalLayout2 != null)
			{
				verticalLayout2.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(14);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x0603067C RID: 198268 RVA: 0x00B3C664 File Offset: 0x00B3A864
		[NullableContext(1)]
		protected override void OnShowWorldMapSecondaryUi(params object[] parameters)
		{
			if (parameters.Length != 0)
			{
				CaveHoleMarkItem caveHoleMarkItem = parameters[0] as CaveHoleMarkItem;
				if (caveHoleMarkItem != null)
				{
					this.LayoutContext.MarkItem = caveHoleMarkItem;
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateDesc(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithTrackStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					base.UpdateTopRightIconActive();
					base.UpdateRightDownIconActive();
					bool flag = base.UpdateQuickGoto();
					WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
					if (layoutContext == null)
					{
						return;
					}
					layoutContext.SetConfirmBtnActive(!flag);
				}
			}
		}

		// Token: 0x0603067D RID: 198269 RVA: 0x00B3C6EB File Offset: 0x00B3A8EB
		protected override void OnConfirmBtnClick(int index)
		{
			this.HandleTrack();
		}

		// Token: 0x0200AB20 RID: 43808
		public static class EComponents
		{
			// Token: 0x04034017 RID: 213015
			public const int CaveHole = 1;
		}
	}
}
