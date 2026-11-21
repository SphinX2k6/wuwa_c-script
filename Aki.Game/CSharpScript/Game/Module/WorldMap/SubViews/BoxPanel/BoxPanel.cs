using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.BoxPanel
{
	// Token: 0x02003773 RID: 14195
	public class BoxPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024E4F RID: 151119 RVA: 0x00A6C8E3 File Offset: 0x00A6AAE3
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024E50 RID: 151120 RVA: 0x00A6C8EC File Offset: 0x00A6AAEC
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

		// Token: 0x06024E51 RID: 151121 RVA: 0x00A6C98C File Offset: 0x00A6AB8C
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

		// Token: 0x020094CF RID: 38095
		public static class EComponents
		{
			// Token: 0x0402E793 RID: 190355
			public const int BoxPanel = 0;
		}
	}
}
