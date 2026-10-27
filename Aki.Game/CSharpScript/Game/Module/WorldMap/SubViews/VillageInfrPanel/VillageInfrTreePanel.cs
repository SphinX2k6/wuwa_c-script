using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.VillageInfr;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.VillageInfrPanel
{
	// Token: 0x020047E2 RID: 18402
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrTreePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x0603033F RID: 197439 RVA: 0x00B2C046 File Offset: 0x00B2A246
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06030340 RID: 197440 RVA: 0x00B2C050 File Offset: 0x00B2A250
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrTreePanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrTreePanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030341 RID: 197441 RVA: 0x00B2C094 File Offset: 0x00B2A294
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			base.GetVerticalLayout(7).RootUIComp.Get().SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(14).SetUIActive(true);
			base.GetVerticalLayout(5).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x06030342 RID: 197442 RVA: 0x00B2C0F8 File Offset: 0x00B2A2F8
		private UniTask CreateRewardItemBar()
		{
			VillageInfrTreePanel.<CreateRewardItemBar>d__5 <CreateRewardItemBar>d__;
			<CreateRewardItemBar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRewardItemBar>d__.<>4__this = this;
			<CreateRewardItemBar>d__.<>1__state = -1;
			<CreateRewardItemBar>d__.<>t__builder.Start<VillageInfrTreePanel.<CreateRewardItemBar>d__5>(ref <CreateRewardItemBar>d__);
			return <CreateRewardItemBar>d__.<>t__builder.Task;
		}

		// Token: 0x06030343 RID: 197443 RVA: 0x00B2C13C File Offset: 0x00B2A33C
		protected override void OnShowWorldMapSecondaryUi(params object[] parameters)
		{
			VillageInfrTreeMarkItem villageInfrTreeMarkItem = (VillageInfrTreeMarkItem)parameters[0];
			this.LayoutContext.MarkItem = villageInfrTreeMarkItem;
			this.UpdateConfirmButtonEnableClickByTeleportState();
			WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
			WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
			WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
			WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
			base.GetText(4).ShowTextNew(villageInfrTreeMarkItem.GetLocaleDesc());
			base.UpdateMultiMap();
			base.UpdateTopRightIconActive();
			bool flag = base.UpdateQuickGoto();
			this.LayoutContext.SetConfirmBtnActive(!flag);
			this.RefreshGiftTip();
			this.VerticalLayout.RefreshByData(this.GetVerticalLayoutData(), null, false);
			this.RefreshRewardItemBar();
		}

		// Token: 0x06030344 RID: 197444 RVA: 0x00B2C1E4 File Offset: 0x00B2A3E4
		private void UpdateConfirmButtonEnableClickByTeleportState()
		{
			VillageInfrTreeMarkItem villageInfrTreeMarkItem = (VillageInfrTreeMarkItem)this.LayoutContext.MarkItem;
			this.LayoutContext.SetConfirmBtnEnableClick(!villageInfrTreeMarkItem.IsLocked);
		}

		// Token: 0x06030345 RID: 197445 RVA: 0x00B2C218 File Offset: 0x00B2A418
		private void RefreshGiftTip()
		{
			VillageInfrTreeMarkItem villageInfrTreeMarkItem = (VillageInfrTreeMarkItem)this.LayoutContext.MarkItem;
			InfrV2TreeBuild? treeConfigByMarkId = VillageInfrConfig.Instance.GetTreeConfigByMarkId(villageInfrTreeMarkItem.MarkId);
			if (VillageInfrModel.Instance.GetCanTreeLevelUp(treeConfigByMarkId.Value.Id))
			{
				base.GetItem(25).SetUIActive(true);
				base.GetText(30).ShowTextNew("VillageInfr_Map_Tree5");
				return;
			}
			base.GetItem(25).SetUIActive(false);
		}

		// Token: 0x06030346 RID: 197446 RVA: 0x00B2C294 File Offset: 0x00B2A494
		private List<IMapSubViewListItemData> GetVerticalLayoutData()
		{
			VillageInfrTreeMarkItem villageInfrTreeMarkItem = (VillageInfrTreeMarkItem)this.LayoutContext.MarkItem;
			InfrV2TreeBuild? treeConfigByMarkId = VillageInfrConfig.Instance.GetTreeConfigByMarkId(villageInfrTreeMarkItem.MarkId);
			IVillageInfrTreeData treeData = VillageInfrModel.Instance.GetTreeData(treeConfigByMarkId.Value.Id);
			InfrV2StatusPb infrV2StatusPb = (treeData != null) ? treeData.Status : InfrV2StatusPb.InfrV2StatusLock;
			MapSubViewListItemData item = new MapSubViewListItemData
			{
				LeftTextId = "VillageInfr_Map_Tree1",
				RightTextId = ((infrV2StatusPb == InfrV2StatusPb.InfrV2StatusComplete) ? "VillageInfr_Map_Tree3" : "VillageInfr_Map_Tree2"),
				ShowBtnHelp = false,
				ShowIcon = false,
				ShowSprite = false,
				ShowScaleIcon = false
			};
			return new List<IMapSubViewListItemData>
			{
				item
			};
		}

		// Token: 0x06030347 RID: 197447 RVA: 0x00B2C33C File Offset: 0x00B2A53C
		private void RefreshRewardItemBar()
		{
			VillageInfrTreeMarkItem villageInfrTreeMarkItem = (VillageInfrTreeMarkItem)this.LayoutContext.MarkItem;
			InfrV2TreeBuild? treeConfigByMarkId = VillageInfrConfig.Instance.GetTreeConfigByMarkId(villageInfrTreeMarkItem.MarkId);
			IVillageInfrTreeData treeData = VillageInfrModel.Instance.GetTreeData(treeConfigByMarkId.Value.Id);
			if (treeData != null && treeData.Status == InfrV2StatusPb.InfrV2StatusComplete)
			{
				return;
			}
			base.GetVerticalLayout(7).RootUIComp.Get().SetUIActive(true);
			base.GetItem(8).SetUIActive(true);
			TItem[] data = (from r in treeConfigByMarkId.Value.RequirementIter()
			orderby r.Key
			select new TItem(new InventoryDefine.GetItemData(r.Key, 0), r.Value)).ToArray<TItem>();
			this.RewardsView.RebuildRewardsByData(data);
			this.RewardsView.SetTitleNewTxt("VillageInfr_Map_Tree4");
		}

		// Token: 0x04019F56 RID: 106326
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapVerticalLayoutItem, IMapSubViewListItemData> VerticalLayout;

		// Token: 0x04019F57 RID: 106327
		public MapSubViewRewardPanel RewardsView = new MapSubViewRewardPanel();
	}
}
