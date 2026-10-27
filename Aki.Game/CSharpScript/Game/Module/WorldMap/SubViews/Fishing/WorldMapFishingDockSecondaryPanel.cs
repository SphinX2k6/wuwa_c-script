using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Fishing
{
	// Token: 0x02004824 RID: 18468
	public class WorldMapFishingDockSecondaryPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06030585 RID: 198021 RVA: 0x00B38D2F File Offset: 0x00B36F2F
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06030586 RID: 198022 RVA: 0x00B38D38 File Offset: 0x00B36F38
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

		// Token: 0x06030587 RID: 198023 RVA: 0x00B38DB4 File Offset: 0x00B36FB4
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

		// Token: 0x06030588 RID: 198024 RVA: 0x00B38E1C File Offset: 0x00B3701C
		private void UpdateConfirmButton()
		{
			if (FishingModel.Instance.IsOnShipVehicle())
			{
				WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithTrackStyle(this.LayoutContext);
				return;
			}
			WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
		}

		// Token: 0x06030589 RID: 198025 RVA: 0x00B38E41 File Offset: 0x00B37041
		protected override void OnConfirmBtnClick(int index)
		{
			if (FishingModel.Instance.IsOnShipVehicle())
			{
				this.HandleTrack();
				return;
			}
			this.HandleTeleport();
		}

		// Token: 0x0200AAF9 RID: 43769
		public static class EComponents
		{
			// Token: 0x04033F98 RID: 212888
			public const int FishingDock = 0;
		}
	}
}
