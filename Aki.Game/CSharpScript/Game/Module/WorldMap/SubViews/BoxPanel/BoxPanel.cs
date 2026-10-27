using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.BoxPanel
{
	// Token: 0x02004842 RID: 18498
	public class BoxPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x0603067F RID: 198271 RVA: 0x00B3C6FB File Offset: 0x00B3A8FB
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06030680 RID: 198272 RVA: 0x00B3C704 File Offset: 0x00B3A904
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(7);
			if (verticalLayout != null)
			{
				verticalLayout.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(5);
			if (verticalLayout2 != null)
			{
				verticalLayout2.RootUIComp.Get().SetUIActive(false);
			}
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext != null)
			{
				layoutContext.SetConfirmBtnActive(false);
			}
			UUIItem item3 = base.GetItem(32);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
		}

		// Token: 0x06030681 RID: 198273 RVA: 0x00B3C7A4 File Offset: 0x00B3A9A4
		[NullableContext(1)]
		protected override void OnShowWorldMapSecondaryUi(params object[] parameters)
		{
			if (parameters.Length != 0)
			{
				MarkItem markItem = parameters[0] as MarkItem;
				if (markItem != null)
				{
					this.LayoutContext.MarkItem = markItem;
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateBoxDesc(this.LayoutContext);
				}
			}
		}

		// Token: 0x0200AB21 RID: 43809
		public static class EComponents
		{
			// Token: 0x04034018 RID: 213016
			public const int BoxPanel = 0;
		}
	}
}
