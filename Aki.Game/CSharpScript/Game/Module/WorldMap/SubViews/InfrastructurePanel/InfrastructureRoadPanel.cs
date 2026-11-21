using System;
using System.Collections.Generic;
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
	// Token: 0x02003748 RID: 14152
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureRoadPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024CFA RID: 150778 RVA: 0x00A66E4B File Offset: 0x00A6504B
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024CFB RID: 150779 RVA: 0x00A66E54 File Offset: 0x00A65054
		protected override UniTask OnBeforeStartAsync()
		{
			InfrastructureRoadPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrastructureRoadPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024CFC RID: 150780 RVA: 0x00A66E98 File Offset: 0x00A65098
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

		// Token: 0x06024CFD RID: 150781 RVA: 0x00A66F14 File Offset: 0x00A65114
		private UniTask CreateRewardItemBar()
		{
			InfrastructureRoadPanel.<CreateRewardItemBar>d__6 <CreateRewardItemBar>d__;
			<CreateRewardItemBar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRewardItemBar>d__.<>4__this = this;
			<CreateRewardItemBar>d__.<>1__state = -1;
			<CreateRewardItemBar>d__.<>t__builder.Start<InfrastructureRoadPanel.<CreateRewardItemBar>d__6>(ref <CreateRewardItemBar>d__);
			return <CreateRewardItemBar>d__.<>t__builder.Task;
		}

		// Token: 0x06024CFE RID: 150782 RVA: 0x00A66F58 File Offset: 0x00A65158
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

		// Token: 0x06024CFF RID: 150783 RVA: 0x00A67024 File Offset: 0x00A65224
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

		// Token: 0x06024D00 RID: 150784 RVA: 0x00A67064 File Offset: 0x00A65264
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
			InfrStatusPb infrStatusPb = (infrRoadData != null) ? infrRoadData.Status : InfrStatusPb.InfrStatusLock;
			InventoryModel instance3 = InventoryModel.Instance;
			bool flag = true;
			foreach (DicIntInt dicIntInt in infrRoadBuild.Value.RequirementIter())
			{
				int? num = (instance3 != null) ? new int?(instance3.GetItemCountByConfigId(dicIntInt.Key, 0)) : null;
				int value = dicIntInt.Value;
				if (!(num.GetValueOrDefault() >= value & num != null))
				{
					flag = false;
					break;
				}
			}
			if (infrStatusPb == InfrStatusPb.InfrStatusProgress && flag)
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

		// Token: 0x06024D01 RID: 150785 RVA: 0x00A671B0 File Offset: 0x00A653B0
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

		// Token: 0x06024D02 RID: 150786 RVA: 0x00A673F0 File Offset: 0x00A655F0
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
			List<ValueTuple<int, TItem>> list = new List<ValueTuple<int, TItem>>();
			foreach (DicIntInt dicIntInt in infrRoadBuild.Value.RequirementIter())
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
			this.RewardsView.SetTitleNewTxt("PrefabTextItem_3987853903_Text");
		}

		// Token: 0x06024D03 RID: 150787 RVA: 0x00A67594 File Offset: 0x00A65794
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

		// Token: 0x040146B8 RID: 83640
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapVerticalLayoutItem, IMapSubViewListItemData> VerticalLayout;

		// Token: 0x040146B9 RID: 83641
		public MapSubViewRewardPanel RewardsView = new MapSubViewRewardPanel();

		// Token: 0x0200949A RID: 38042
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E6F5 RID: 190197
			public const int InfrRoadPanel = 0;
		}
	}
}
