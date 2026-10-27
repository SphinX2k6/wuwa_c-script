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
	// Token: 0x020047E1 RID: 18401
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06030335 RID: 197429 RVA: 0x00B2BDB1 File Offset: 0x00B29FB1
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06030336 RID: 197430 RVA: 0x00B2BDB8 File Offset: 0x00B29FB8
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrPanel.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrPanel.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030337 RID: 197431 RVA: 0x00B2BDFC File Offset: 0x00B29FFC
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			base.GetVerticalLayout(7).RootUIComp.Get().SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(14).SetUIActive(true);
			base.GetVerticalLayout(5).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x06030338 RID: 197432 RVA: 0x00B2BE60 File Offset: 0x00B2A060
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

		// Token: 0x06030339 RID: 197433 RVA: 0x00B2BEF4 File Offset: 0x00B2A0F4
		private void UpdateConfirmButtonEnableClickByTeleportState()
		{
			ConfigMarkItem configMarkItem = this.LayoutContext.MarkItem as ConfigMarkItem;
			this.LayoutContext.SetConfirmBtnEnableClick(configMarkItem == null || !configMarkItem.IsLocked);
		}

		// Token: 0x0603033A RID: 197434 RVA: 0x00B2BF2C File Offset: 0x00B2A12C
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

		// Token: 0x0603033B RID: 197435 RVA: 0x00B2BF6C File Offset: 0x00B2A16C
		private void RefreshVerticalLayout()
		{
			this.VerticalLayout.RefreshByData(this.GetVerticalLayoutData(), null, false);
			int villageLevel = VillageInfrModel.Instance.GetVillageLevel();
			int infrMaxLevel = VillageInfrConfig.Instance.GetInfrMaxLevel();
			base.GetText(51).SetUIActive(villageLevel >= infrMaxLevel);
			base.GetText(51).ShowTextNew("VillageInfr_Map_Village3");
		}

		// Token: 0x0603033C RID: 197436 RVA: 0x00B2BFC8 File Offset: 0x00B2A1C8
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

		// Token: 0x04019F55 RID: 106325
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapVerticalLayoutItem, IMapSubViewListItemData> VerticalLayout;
	}
}
