using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.VillageInfr;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.VillageInfrPanel
{
	// Token: 0x02003712 RID: 14098
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024B05 RID: 150277 RVA: 0x00A5BC7D File Offset: 0x00A59E7D
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024B06 RID: 150278 RVA: 0x00A5BC84 File Offset: 0x00A59E84
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrPanel.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrPanel.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024B07 RID: 150279 RVA: 0x00A5BCC8 File Offset: 0x00A59EC8
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			base.GetVerticalLayout(7).RootUIComp.Get().SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(14).SetUIActive(true);
			base.GetVerticalLayout(5).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x06024B08 RID: 150280 RVA: 0x00A5BD2C File Offset: 0x00A59F2C
		protected override void OnShowWorldMapSecondaryUi(params object[] parameters)
		{
			ConfigMarkItem configMarkItem = parameters[0] as ConfigMarkItem;
			this.LayoutContext.MarkItem = configMarkItem;
			this.UpdateConfirmButtonEnableClickByTeleportState();
			WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
			WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
			WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
			WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
			base.GetText(4).ShowTextNew(configMarkItem.GetLocaleDesc());
			base.UpdateMultiMap();
			base.UpdateTopRightIconByTeleportState();
			bool flag = base.UpdateQuickGoto();
			this.LayoutContext.SetConfirmBtnActive(!flag);
			this.RefreshGiftTip();
			this.RefreshVerticalLayout();
		}

		// Token: 0x06024B09 RID: 150281 RVA: 0x00A5BDC0 File Offset: 0x00A59FC0
		private void UpdateConfirmButtonEnableClickByTeleportState()
		{
			ConfigMarkItem configMarkItem = this.LayoutContext.MarkItem as ConfigMarkItem;
			this.LayoutContext.SetConfirmBtnEnableClick(configMarkItem == null || !configMarkItem.IsLocked);
		}

		// Token: 0x06024B0A RID: 150282 RVA: 0x00A5BDF8 File Offset: 0x00A59FF8
		private void RefreshGiftTip()
		{
			if (VillageInfrModel.Instance.GetCanVillageLevelUp())
			{
				base.GetItem(25).SetUIActive(true);
				base.GetText(30).ShowTextNew("VillageInfr_Map_Village2");
				return;
			}
			base.GetItem(25).SetUIActive(false);
		}

		// Token: 0x06024B0B RID: 150283 RVA: 0x00A5BE38 File Offset: 0x00A5A038
		private void RefreshVerticalLayout()
		{
			this.VerticalLayout.RefreshByData(this.GetVerticalLayoutData(), null, false);
			int villageLevel = VillageInfrModel.Instance.GetVillageLevel();
			int infrMaxLevel = VillageInfrConfig.Instance.GetInfrMaxLevel();
			base.GetText(51).SetUIActive(villageLevel >= infrMaxLevel);
			base.GetText(51).ShowTextNew("VillageInfr_Map_Village3");
		}

		// Token: 0x06024B0C RID: 150284 RVA: 0x00A5BE94 File Offset: 0x00A5A094
		private List<IMapSubViewListItemData> GetVerticalLayoutData()
		{
			InfrV2Level? infrLevel = VillageInfrConfig.Instance.GetInfrLevel(VillageInfrModel.Instance.GetVillageLevel());
			return new List<IMapSubViewListItemData>
			{
				new MapSubViewListItemData
				{
					LeftTextId = "VillageInfr_Map_Village1",
					RightTextId = infrLevel.Value.Name,
					ShowBtnHelp = false,
					ShowIcon = false,
					ShowSprite = false,
					ShowScaleIcon = false
				}
			};
		}

		// Token: 0x04014609 RID: 83465
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapVerticalLayoutItem, IMapSubViewListItemData> VerticalLayout;
	}
}
