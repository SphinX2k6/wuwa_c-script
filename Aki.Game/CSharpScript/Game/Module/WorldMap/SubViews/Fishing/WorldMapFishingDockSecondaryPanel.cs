using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Fishing
{
	// Token: 0x02003755 RID: 14165
	public class WorldMapFishingDockSecondaryPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024D55 RID: 150869 RVA: 0x00A68DFB File Offset: 0x00A66FFB
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024D56 RID: 150870 RVA: 0x00A68E04 File Offset: 0x00A67004
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

		// Token: 0x06024D57 RID: 150871 RVA: 0x00A68E80 File Offset: 0x00A67080
		[NullableContext(1)]
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				ConfigMarkItem configMarkItem = param[0] as ConfigMarkItem;
				if (configMarkItem != null)
				{
					this.LayoutContext.MarkItem = configMarkItem;
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonEnableClickByTeleportState(this.LayoutContext);
					this.UpdateConfirmButton();
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateDesc(this.LayoutContext);
					base.UpdateMultiMap();
					base.UpdateQuickGotoActive(false);
				}
			}
		}

		// Token: 0x06024D58 RID: 150872 RVA: 0x00A68EE8 File Offset: 0x00A670E8
		private void UpdateConfirmButton()
		{
			if (FishingModel.Instance.IsOnShipVehicle())
			{
				WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithTrackStyle(this.LayoutContext);
				return;
			}
			WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
		}

		// Token: 0x06024D59 RID: 150873 RVA: 0x00A68F0D File Offset: 0x00A6710D
		protected override void OnConfirmBtnClick(int index)
		{
			if (FishingModel.Instance.IsOnShipVehicle())
			{
				this.HandleTrack();
				return;
			}
			this.HandleTeleport();
		}

		// Token: 0x020094A8 RID: 38056
		public static class EComponents
		{
			// Token: 0x0402E718 RID: 190232
			public const int FishingDock = 0;
		}
	}
}
