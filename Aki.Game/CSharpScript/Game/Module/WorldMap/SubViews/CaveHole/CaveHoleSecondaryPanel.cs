using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CaveHole
{
	// Token: 0x02003772 RID: 14194
	public class CaveHoleSecondaryPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024E4A RID: 151114 RVA: 0x00A6C7C8 File Offset: 0x00A6A9C8
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024E4B RID: 151115 RVA: 0x00A6C7D0 File Offset: 0x00A6A9D0
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

		// Token: 0x06024E4C RID: 151116 RVA: 0x00A6C84C File Offset: 0x00A6AA4C
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

		// Token: 0x06024E4D RID: 151117 RVA: 0x00A6C8D3 File Offset: 0x00A6AAD3
		protected override void OnConfirmBtnClick(int index)
		{
			this.HandleTrack();
		}

		// Token: 0x020094CE RID: 38094
		public static class EComponents
		{
			// Token: 0x0402E792 RID: 190354
			public const int CaveHole = 1;
		}
	}
}
