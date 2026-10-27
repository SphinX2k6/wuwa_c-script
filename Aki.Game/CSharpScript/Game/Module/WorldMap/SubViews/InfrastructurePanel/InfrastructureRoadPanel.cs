using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Infrastructure;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.InfrastructurePanel
{
	// Token: 0x02004817 RID: 18455
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureRoadPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x0603052A RID: 197930 RVA: 0x00B36E6F File Offset: 0x00B3506F
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x0603052B RID: 197931 RVA: 0x00B36E78 File Offset: 0x00B35078
		protected override UniTask OnBeforeStartAsync()
		{
			InfrastructureRoadPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrastructureRoadPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603052C RID: 197932 RVA: 0x00B36EBC File Offset: 0x00B350BC
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
			UUIItem item2 = base.GetItem(14);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(5);
			if (verticalLayout2 == null)
			{
				return;
			}
			verticalLayout2.RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x0603052D RID: 197933 RVA: 0x00B36F38 File Offset: 0x00B35138
		private UniTask CreateRewardItemBar()
		{
			InfrastructureRoadPanel.<CreateRewardItemBar>d__6 <CreateRewardItemBar>d__;
			<CreateRewardItemBar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRewardItemBar>d__.<>4__this = this;
			<CreateRewardItemBar>d__.<>1__state = -1;
			<CreateRewardItemBar>d__.<>t__builder.Start<InfrastructureRoadPanel.<CreateRewardItemBar>d__6>(ref <CreateRewardItemBar>d__);
			return <CreateRewardItemBar>d__.<>t__builder.Task;
		}

		// Token: 0x0603052E RID: 197934 RVA: 0x00B36F7C File Offset: 0x00B3517C
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				InfrRoadMarkItem infrRoadMarkItem = param[0] as InfrRoadMarkItem;
				if (infrRoadMarkItem != null)
				{
					this.LayoutContext.MarkItem = infrRoadMarkItem;
					this.UpdateConfirmButtonEnableClickByTeleportState();
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
					UUIText text = base.GetText(4);
					if (text != null)
					{
						text.ShowTextNew(infrRoadMarkItem.GetLocaleDesc());
					}
					base.UpdateMultiMap();
					base.UpdateTopRightIconActive();
					bool flag = base.UpdateQuickGoto();
					WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
					if (layoutContext != null)
					{
						layoutContext.SetConfirmBtnActive(!flag);
					}
					this.RefreshGiftTip();
					GenericLayout<MapVerticalLayoutItem, IMapSubViewListItemData> verticalLayout = this.VerticalLayout;
					if (verticalLayout != null)
					{
						verticalLayout.RefreshByData(this.GetVerticalLayoutData(), null, false);
					}
					this.RefreshRewardItemBar();
					this.RefreshProgress();
				}
			}
		}

		// Token: 0x0603052F RID: 197935 RVA: 0x00B37048 File Offset: 0x00B35248
		private void UpdateConfirmButtonEnableClickByTeleportState()
		{
			InfrRoadMarkItem infrRoadMarkItem = this.LayoutContext.MarkItem as InfrRoadMarkItem;
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext == null)
			{
				return;
			}
			layoutContext.SetConfirmBtnEnableClick(infrRoadMarkItem == null || !infrRoadMarkItem.IsLocked);
		}

		// Token: 0x06030530 RID: 197936 RVA: 0x00B37088 File Offset: 0x00B35288
		private void RefreshGiftTip()
		{
			InfrRoadMarkItem infrRoadMarkItem = this.LayoutContext.MarkItem as InfrRoadMarkItem;
			if (infrRoadMarkItem == null)
			{
				return;
			}
			InfrastructureConfig instance = InfrastructureConfig.Instance;
			InfrRoadBuild? infrRoadBuild = (instance != null) ? instance.GetRoadConfigByMarkId(infrRoadMarkItem.MarkId) : null;
			if (infrRoadBuild == null)
			{
				return;
			}
			InfrastructureModel instance2 = InfrastructureModel.Instance;
			InfrastructureDefine.IInfrRoadData infrRoadData = (instance2 != null) ? instance2.GetRoadDataByRoadId(infrRoadBuild.Value.Id) : null;
			int num = (int)((infrRoadData != null) ? infrRoadData.Status : InfrStatusPb.InfrStatusLock);
			InventoryModel inventoryModel = InventoryModel.Instance;
			bool flag = infrRoadBuild.Value.RequirementIter().All(delegate(DicIntInt r)
			{
				InventoryModel inventoryModel = inventoryModel;
				int? num2 = (inventoryModel != null) ? new int?(inventoryModel.GetItemCountByConfigId(r.Key, 0)) : null;
				int value = r.Value;
				return num2.GetValueOrDefault() >= value & num2 != null;
			});
			if (num == 1 && flag)
			{
				UUIItem item = base.GetItem(25);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIText text = base.GetText(30);
				if (text == null)
				{
					return;
				}
				text.ShowTextNew("Map_BuildRoad_BuildAllowedTips");
			}
		}

		// Token: 0x06030531 RID: 197937 RVA: 0x00B37168 File Offset: 0x00B35368
		private unsafe List<IMapSubViewListItemData> GetVerticalLayoutData()
		{
			InfrRoadMarkItem infrRoadMarkItem = this.LayoutContext.MarkItem as InfrRoadMarkItem;
			if (infrRoadMarkItem == null)
			{
				return new List<IMapSubViewListItemData>();
			}
			InfrastructureConfig instance = InfrastructureConfig.Instance;
			InfrRoadBuild? infrRoadBuild = (instance != null) ? instance.GetRoadConfigByMarkId(infrRoadMarkItem.MarkId) : null;
			if (infrRoadBuild == null)
			{
				return new List<IMapSubViewListItemData>();
			}
			InfrastructureModel instance2 = InfrastructureModel.Instance;
			InfrastructureDefine.IInfrRoadData infrRoadData = (instance2 != null) ? instance2.GetRoadDataByRoadId(infrRoadBuild.Value.Id) : null;
			InfrStatusPb infrStatusPb = (infrRoadData != null) ? infrRoadData.Status : InfrStatusPb.InfrStatusLock;
			MapSubViewListItemData mapSubViewListItemData = new MapSubViewListItemData
			{
				LeftTextId = "Map_BuildRoad_State",
				RightTextId = ((infrStatusPb == InfrStatusPb.InfrStatusComplete) ? "Map_BuildRoad_State_BuildingComplete" : "Map_BuildRoad_State_Building"),
				ShowBtnHelp = false,
				ShowIcon = false,
				ShowSprite = false,
				ShowScaleIcon = false
			};
			int num;
			Span<IMapSubViewListItemData> span;
			int num2;
			if (infrStatusPb == InfrStatusPb.InfrStatusComplete)
			{
				DateTime localDateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)((infrRoadData != null) ? infrRoadData.CompleteTime : 0) * (long)TimeUtil.Instance.InverseMillisecond).LocalDateTime;
				num = 2;
				List<IMapSubViewListItemData> list = new List<IMapSubViewListItemData>(num);
				CollectionsMarshal.SetCount<IMapSubViewListItemData>(list, num);
				span = CollectionsMarshal.AsSpan<IMapSubViewListItemData>(list);
				num2 = 0;
				*span[num2] = mapSubViewListItemData;
				num2++;
				*span[num2] = new MapSubViewListItemData
				{
					LeftTextId = "PrefabTextItem_1724067072_Text",
					RightText = TimeUtil.Instance.DateFormat3(localDateTime),
					ShowBtnHelp = false,
					ShowIcon = false,
					ShowSprite = false
				};
				return list;
			}
			string text;
			InfrastructureDefine.difficultySpriteResourceId.TryGetValue(infrRoadBuild.Value.Difficulty, out text);
			UiResourceConfig instance3 = UiResourceConfig.Instance;
			UiResource? uiResource;
			string text2 = (instance3 != null) ? ((instance3.GetResourceConfig(text ?? "") != null) ? uiResource.GetValueOrDefault().Path : null) : null;
			MapSubViewListItemData mapSubViewListItemData2 = new MapSubViewListItemData
			{
				LeftTextId = "JijianTask_ConstructionDifficulty",
				ShowBtnHelp = false,
				ShowIcon = false,
				ShowSprite = false,
				ShowScaleIcon = true,
				ScaleIconPath = (text2 ?? "")
			};
			num2 = 2;
			List<IMapSubViewListItemData> list2 = new List<IMapSubViewListItemData>(num2);
			CollectionsMarshal.SetCount<IMapSubViewListItemData>(list2, num2);
			span = CollectionsMarshal.AsSpan<IMapSubViewListItemData>(list2);
			num = 0;
			*span[num] = mapSubViewListItemData;
			num++;
			*span[num] = mapSubViewListItemData2;
			return list2;
		}

		// Token: 0x06030532 RID: 197938 RVA: 0x00B373A8 File Offset: 0x00B355A8
		private void RefreshRewardItemBar()
		{
			InfrRoadMarkItem infrRoadMarkItem = this.LayoutContext.MarkItem as InfrRoadMarkItem;
			if (infrRoadMarkItem == null)
			{
				return;
			}
			InfrastructureConfig instance = InfrastructureConfig.Instance;
			InfrRoadBuild? infrRoadBuild = (instance != null) ? instance.GetRoadConfigByMarkId(infrRoadMarkItem.MarkId) : null;
			if (infrRoadBuild == null)
			{
				return;
			}
			InfrastructureModel instance2 = InfrastructureModel.Instance;
			InfrastructureDefine.IInfrRoadData infrRoadData = (instance2 != null) ? instance2.GetRoadDataByRoadId(infrRoadBuild.Value.Id) : null;
			if (infrRoadData != null && infrRoadData.Status == InfrStatusPb.InfrStatusComplete)
			{
				return;
			}
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(7);
			if (verticalLayout != null)
			{
				verticalLayout.RootUIComp.Get().SetUIActive(true);
			}
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			TItem[] data = (from r in infrRoadBuild.Value.RequirementIter()
			orderby r.Key
			select new TItem(new InventoryDefine.GetItemData(r.Key, 0), r.Value)).ToArray<TItem>();
			this.RewardsView.RebuildRewardsByData(data);
			this.RewardsView.SetTitleNewTxt("PrefabTextItem_3987853903_Text");
		}

		// Token: 0x06030533 RID: 197939 RVA: 0x00B374D8 File Offset: 0x00B356D8
		private void RefreshProgress()
		{
			InfrRoadMarkItem infrRoadMarkItem = this.LayoutContext.MarkItem as InfrRoadMarkItem;
			if (infrRoadMarkItem == null)
			{
				return;
			}
			InfrastructureConfig instance = InfrastructureConfig.Instance;
			InfrRoadBuild? infrRoadBuild = (instance != null) ? instance.GetRoadConfigByMarkId(infrRoadMarkItem.MarkId) : null;
			if (infrRoadBuild == null)
			{
				return;
			}
			InfrastructureModel instance2 = InfrastructureModel.Instance;
			InfrastructureDefine.IInfrRoadData infrRoadData = (instance2 != null) ? instance2.GetRoadDataByRoadId(infrRoadBuild.Value.Id) : null;
			if (infrRoadData == null || infrRoadData.Status != InfrStatusPb.InfrStatusComplete)
			{
				UUIItem item = base.GetItem(48);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIText text = base.GetText(49);
				if (text != null)
				{
					text.ShowTextNew("PrefabTextItem_3953589534_Text");
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(50), infrRoadBuild.Value.EffectDes(0) ?? "", new <>z__ReadOnlySingleElementList<object>(infrRoadBuild.Value.FireExpReward.ToString()));
				return;
			}
			UUIItem item2 = base.GetItem(48);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x0401A004 RID: 106500
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapVerticalLayoutItem, IMapSubViewListItemData> VerticalLayout;

		// Token: 0x0401A005 RID: 106501
		public MapSubViewRewardPanel RewardsView = new MapSubViewRewardPanel();

		// Token: 0x0200AAEA RID: 43754
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033F73 RID: 212851
			public const int InfrRoadPanel = 0;
		}
	}
}
