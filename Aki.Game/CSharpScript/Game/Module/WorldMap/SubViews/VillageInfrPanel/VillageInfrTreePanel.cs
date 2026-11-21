using System;
using System.Collections.Generic;
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
	// Token: 0x02003713 RID: 14099
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrTreePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024B0F RID: 150287 RVA: 0x00A5BF12 File Offset: 0x00A5A112
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024B10 RID: 150288 RVA: 0x00A5BF1C File Offset: 0x00A5A11C
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrTreePanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrTreePanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024B11 RID: 150289 RVA: 0x00A5BF60 File Offset: 0x00A5A160
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			base.GetVerticalLayout(7).RootUIComp.Get().SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(14).SetUIActive(true);
			base.GetVerticalLayout(5).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x06024B12 RID: 150290 RVA: 0x00A5BFC4 File Offset: 0x00A5A1C4
		private UniTask CreateRewardItemBar()
		{
			VillageInfrTreePanel.<CreateRewardItemBar>d__5 <CreateRewardItemBar>d__;
			<CreateRewardItemBar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRewardItemBar>d__.<>4__this = this;
			<CreateRewardItemBar>d__.<>1__state = -1;
			<CreateRewardItemBar>d__.<>t__builder.Start<VillageInfrTreePanel.<CreateRewardItemBar>d__5>(ref <CreateRewardItemBar>d__);
			return <CreateRewardItemBar>d__.<>t__builder.Task;
		}

		// Token: 0x06024B13 RID: 150291 RVA: 0x00A5C008 File Offset: 0x00A5A208
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

		// Token: 0x06024B14 RID: 150292 RVA: 0x00A5C0B0 File Offset: 0x00A5A2B0
		private void UpdateConfirmButtonEnableClickByTeleportState()
		{
			VillageInfrTreeMarkItem villageInfrTreeMarkItem = (VillageInfrTreeMarkItem)this.LayoutContext.MarkItem;
			this.LayoutContext.SetConfirmBtnEnableClick(!villageInfrTreeMarkItem.IsLocked);
		}

		// Token: 0x06024B15 RID: 150293 RVA: 0x00A5C0E4 File Offset: 0x00A5A2E4
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

		// Token: 0x06024B16 RID: 150294 RVA: 0x00A5C160 File Offset: 0x00A5A360
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

		// Token: 0x06024B17 RID: 150295 RVA: 0x00A5C208 File Offset: 0x00A5A408
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
			List<ValueTuple<int, TItem>> list = new List<ValueTuple<int, TItem>>();
			foreach (DicIntInt dicIntInt in treeConfigByMarkId.Value.RequirementIter())
			{
				list.Add(new ValueTuple<int, TItem>(dicIntInt.Key, new TItem(new InventoryDefine.GetItemData(dicIntInt.Key, 0), dicIntInt.Value)));
			}
			list.Sort(([TupleElementNames(new string[]
			{
				"Key",
				"Item"
			})] ValueTuple<int, TItem> a, [TupleElementNames(new string[]
			{
				"Key",
				"Item"
			})] ValueTuple<int, TItem> b) => a.Item1.CompareTo(b.Item1));
			TItem[] array = new TItem[list.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = list[i].Item2;
			}
			this.RewardsView.RebuildRewardsByData(array);
			this.RewardsView.SetTitleNewTxt("VillageInfr_Map_Tree4");
		}

		// Token: 0x0401460A RID: 83466
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapVerticalLayoutItem, IMapSubViewListItemData> VerticalLayout;

		// Token: 0x0401460B RID: 83467
		public MapSubViewRewardPanel RewardsView = new MapSubViewRewardPanel();
	}
}
