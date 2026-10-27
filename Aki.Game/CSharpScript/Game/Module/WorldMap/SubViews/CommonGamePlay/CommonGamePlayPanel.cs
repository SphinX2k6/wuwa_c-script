using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Morale.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.SubViews.SceneGameplayPanel;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CommonGamePlay
{
	// Token: 0x0200483C RID: 18492
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonGamePlayPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x170078FB RID: 30971
		// (get) Token: 0x06030640 RID: 198208 RVA: 0x00B3B7B3 File Offset: 0x00B399B3
		// (set) Token: 0x06030641 RID: 198209 RVA: 0x00B3B7BB File Offset: 0x00B399BB
		public MapMoraleLvItem MapMoraleLvItem { get; set; }

		// Token: 0x170078FC RID: 30972
		// (get) Token: 0x06030642 RID: 198210 RVA: 0x00B3B7C4 File Offset: 0x00B399C4
		// (set) Token: 0x06030643 RID: 198211 RVA: 0x00B3B7CC File Offset: 0x00B399CC
		public MapMoraleWarnItem MapMoraleWarnItem { get; set; }

		// Token: 0x170078FD RID: 30973
		// (get) Token: 0x06030644 RID: 198212 RVA: 0x00B3B7D5 File Offset: 0x00B399D5
		// (set) Token: 0x06030645 RID: 198213 RVA: 0x00B3B7DD File Offset: 0x00B399DD
		public RewardItemBar RewardsView { get; set; }

		// Token: 0x06030646 RID: 198214 RVA: 0x00B3B7E6 File Offset: 0x00B399E6
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06030647 RID: 198215 RVA: 0x00B3B7F0 File Offset: 0x00B399F0
		protected override UniTask OnBeforeStartAsync()
		{
			CommonGamePlayPanel.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonGamePlayPanel.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030648 RID: 198216 RVA: 0x00B3B834 File Offset: 0x00B39A34
		[NullableContext(1)]
		protected override UniTask OnBeforeShowWorldMapSecondaryUiAsync(params object[] param)
		{
			CommonGamePlayPanel.<OnBeforeShowWorldMapSecondaryUiAsync>d__23 <OnBeforeShowWorldMapSecondaryUiAsync>d__;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>4__this = this;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.param = param;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>1__state = -1;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder.Start<CommonGamePlayPanel.<OnBeforeShowWorldMapSecondaryUiAsync>d__23>(ref <OnBeforeShowWorldMapSecondaryUiAsync>d__);
			return <OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030649 RID: 198217 RVA: 0x00B3B87F File Offset: 0x00B39A7F
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(14);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			this.SetPanelItemLayoutActive(false);
		}

		// Token: 0x0603064A RID: 198218 RVA: 0x00B3B8B8 File Offset: 0x00B39AB8
		private void SetPanelItemLayoutActive(bool active)
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(7);
			if (verticalLayout == null)
			{
				return;
			}
			verticalLayout.RootUIComp.Get().SetUIActive(active);
		}

		// Token: 0x0603064B RID: 198219 RVA: 0x00B3B8E4 File Offset: 0x00B39AE4
		[NullableContext(1)]
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				ConfigMarkItem configMarkItem = param[0] as ConfigMarkItem;
				if (configMarkItem != null)
				{
					this.LayoutContext.MarkItem = configMarkItem;
					this.UpdateEnableFastMoveLayout();
					base.UpdateMultiMap();
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateDesc(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateDownStateIcon(this.LayoutContext);
					base.UpdateTopRightIconActive();
					if (!base.UpdateDeliveryPropLayout())
					{
						this.UpdateMoraleFlagReward(configMarkItem);
					}
					MapMark? markConfig = configMarkItem.MarkConfig;
					if (markConfig.Value.RelativeType == 1)
					{
						this.RefreshRewardItemBar(configMarkItem);
					}
					this.RefreshListLayout(configMarkItem);
					return;
				}
			}
		}

		// Token: 0x0603064C RID: 198220 RVA: 0x00B3B998 File Offset: 0x00B39B98
		[NullableContext(1)]
		private void RefreshListLayout(ConfigMarkItem markItem)
		{
			bool flag = markItem.IsRedNameProGameplay();
			List<IMapSubViewListItemData> list = flag ? this.GetRedNameProLayoutData() : new List<IMapSubViewListItemData>();
			List<MapProgressItemData> list2 = flag ? new List<MapProgressItemData>() : this.GetTreasureChestRows(markItem.MarkConfig.Value);
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(list.Count > 0 || list2.Count > 0);
			}
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(5);
			if (verticalLayout != null)
			{
				verticalLayout.RootUIComp.Get().SetUIActive(list.Count > 0);
			}
			UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(16);
			if (verticalLayout2 != null)
			{
				verticalLayout2.RootUIComp.Get().SetUIActive(list2.Count > 0);
			}
			GenericLayout<MapVerticalLayoutItem, IMapSubViewListItemData> listLayout = this._listLayout;
			if (listLayout != null)
			{
				listLayout.RefreshByData(list, null, false);
			}
			GenericLayout<MapProgressItem, MapProgressItemData> progressLayout = this._progressLayout;
			if (progressLayout == null)
			{
				return;
			}
			progressLayout.RefreshByData(list2, null, false);
		}

		// Token: 0x0603064D RID: 198221 RVA: 0x00B3BA78 File Offset: 0x00B39C78
		[NullableContext(1)]
		private List<MapProgressItemData> GetTreasureChestRows(MapMark markConfig)
		{
			int[] treasureChestCountTargetArray = markConfig.GetTreasureChestCountTargetArray();
			if (treasureChestCountTargetArray.Length < 2)
			{
				return new List<MapProgressItemData>();
			}
			TreasureChestCountTargetType targetType = (TreasureChestCountTargetType)treasureChestCountTargetArray[0];
			return (from info in treasureChestCountTargetArray.Skip(1).SelectMany((int targetId) => MapModel.Instance.GetTreasureChestCountList(targetType, targetId))
			group info by info.StatType).Select(delegate(IGrouping<TreasureChestStatType, TreasureChestCountData> group)
			{
				int num = group.Sum((TreasureChestCountData info) => info.CurrentCount);
				int num2 = group.Sum((TreasureChestCountData info) => info.TotalCount);
				MapProgressItemData mapProgressItemData = new MapProgressItemData();
				mapProgressItemData.TitleTextId = MapDefine.TreasureChestTitleTextId[group.Key];
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				mapProgressItemData.CountText = defaultInterpolatedStringHandler.ToStringAndClear();
				mapProgressItemData.Completed = (num >= num2);
				mapProgressItemData.IconPath = UiResourceConfig.Instance.GetResourcePath(MapDefine.TreasureChestIconResourceId[group.Key]);
				return mapProgressItemData;
			}).ToList<MapProgressItemData>();
		}

		// Token: 0x0603064E RID: 198222 RVA: 0x00B3BB10 File Offset: 0x00B39D10
		[NullableContext(1)]
		private unsafe List<IMapSubViewListItemData> GetRedNameProLayoutData()
		{
			long num = (long)WorldMapConfig.Instance.GetCommonValue("RedNameStartTimestamp");
			long elapsedSeconds = Math.Max(0L, (long)TimeUtil.Instance.GetServerTime() - num);
			int num2 = 1;
			List<IMapSubViewListItemData> list = new List<IMapSubViewListItemData>(num2);
			CollectionsMarshal.SetCount<IMapSubViewListItemData>(list, num2);
			Span<IMapSubViewListItemData> span = CollectionsMarshal.AsSpan<IMapSubViewListItemData>(list);
			int index = 0;
			*span[index] = new MapSubViewListItemData
			{
				LeftTextId = "MapMark_3750004_RedNameProDefeatsNum",
				RightText = this.CalcRedNameProCount(elapsedSeconds).ToString(),
				ShowBtnHelp = false,
				ShowIcon = false,
				ShowSprite = false,
				ShowScaleIcon = false
			};
			return list;
		}

		// Token: 0x0603064F RID: 198223 RVA: 0x00B3BBA8 File Offset: 0x00B39DA8
		private long CalcRedNameProCount(long elapsedSeconds)
		{
			int commonValue = WorldMapConfig.Instance.GetCommonValue("RedNameProBase");
			int commonValue2 = WorldMapConfig.Instance.GetCommonValue("RedNameProPerMinute");
			int commonValue3 = WorldMapConfig.Instance.GetCommonValue("RedNameProInterval");
			IReadOnlyList<int> commonIntArray = WorldMapConfig.Instance.GetCommonIntArray("RedNameProBuckets");
			if (commonIntArray == null || commonIntArray.Count == 0)
			{
				return (long)commonValue;
			}
			long num = elapsedSeconds / 60L;
			int num2 = (int)(elapsedSeconds % 60L) / commonValue3;
			if (num2 >= commonIntArray.Count)
			{
				num2 = commonIntArray.Count - 1;
			}
			long num3 = 0L;
			for (int i = 0; i <= num2; i++)
			{
				num3 += (long)commonIntArray[i];
			}
			return Math.Min((long)commonValue + num * (long)commonValue2 + num3, 999999L);
		}

		// Token: 0x06030650 RID: 198224 RVA: 0x00B3BC64 File Offset: 0x00B39E64
		[NullableContext(1)]
		public void UpdateMoraleFlagReward(ConfigMarkItem markItem)
		{
			if (!markItem.IsMoraleFlag())
			{
				return;
			}
			MoraleAreaFlagData flagDataByMarkId = MoraleModel.Instance.GetFlagDataByMarkId(markItem.MarkId);
			if (flagDataByMarkId == null)
			{
				return;
			}
			int boxRewardId = flagDataByMarkId.Config.BoxRewardId;
			if (boxRewardId <= 0)
			{
				return;
			}
			this.SetPanelItemLayoutActive(true);
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			RewardItemBar rewardsView = this.RewardsView;
			if (rewardsView != null)
			{
				rewardsView.RebuildRewardsByData(base.GetItemListByDropId(boxRewardId));
			}
			RewardItemBar rewardsView2 = this.RewardsView;
			if (rewardsView2 == null)
			{
				return;
			}
			rewardsView2.SetTitleNewTxt("Morale_title_18");
		}

		// Token: 0x06030651 RID: 198225 RVA: 0x00B3BCE8 File Offset: 0x00B39EE8
		[NullableContext(0)]
		private UniTask<bool> UpdateMoraleItem([Nullable(1)] ConfigMarkItem markItem)
		{
			CommonGamePlayPanel.<UpdateMoraleItem>d__32 <UpdateMoraleItem>d__;
			<UpdateMoraleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdateMoraleItem>d__.<>4__this = this;
			<UpdateMoraleItem>d__.markItem = markItem;
			<UpdateMoraleItem>d__.<>1__state = -1;
			<UpdateMoraleItem>d__.<>t__builder.Start<CommonGamePlayPanel.<UpdateMoraleItem>d__32>(ref <UpdateMoraleItem>d__);
			return <UpdateMoraleItem>d__.<>t__builder.Task;
		}

		// Token: 0x06030652 RID: 198226 RVA: 0x00B3BD34 File Offset: 0x00B39F34
		private void SetMoraleItemHide()
		{
			WorldMapSecondaryUiLayoutHelper.SetTitleUseChangeColor(this.LayoutContext, false);
			UUIItem item = base.GetItem(45);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			MapMoraleLvItem mapMoraleLvItem = this.MapMoraleLvItem;
			if (mapMoraleLvItem != null)
			{
				mapMoraleLvItem.SetActive(false);
			}
			MapMoraleWarnItem mapMoraleWarnItem = this.MapMoraleWarnItem;
			if (mapMoraleWarnItem != null)
			{
				mapMoraleWarnItem.SetActive(false);
			}
			PopupTypeRightItem uiBgItem = this.UiBgItem;
			if (uiBgItem == null)
			{
				return;
			}
			uiBgItem.ShowMoraleBg(false);
		}

		// Token: 0x06030653 RID: 198227 RVA: 0x00B3BD96 File Offset: 0x00B39F96
		private void SetNightMareItemHide()
		{
			SceneGameplayTipGrid rewardGrid = this.RewardGrid;
			if (rewardGrid != null)
			{
				rewardGrid.SetUiActive(false);
			}
			SceneGameplayTipGrid firstRewardGrid = this.FirstRewardGrid;
			if (firstRewardGrid != null)
			{
				firstRewardGrid.SetUiActive(false);
			}
			this.SetPanelItemLayoutActive(false);
		}

		// Token: 0x06030654 RID: 198228 RVA: 0x00B3BDC4 File Offset: 0x00B39FC4
		[NullableContext(1)]
		private bool UpdateNightMareItem(ConfigMarkItem markItem)
		{
			if (!markItem.IsNightMareFlag() && !markItem.IsVisionSettlementFlag())
			{
				return false;
			}
			this.LevelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo((markItem != null) ? markItem.MarkConfig.Value.RelativeId : 0);
			if (this.LevelPlayInfo == null)
			{
				this.LevelPlayInfo = new global::LevelPlayInfo((markItem != null) ? markItem.MarkConfig.Value.RelativeId : 0);
				this.LevelPlayInfo.InitConfig();
			}
			this.InitNightMareRewards(markItem);
			return true;
		}

		// Token: 0x06030655 RID: 198229 RVA: 0x00B3BE4C File Offset: 0x00B3A04C
		[NullableContext(1)]
		public void InitNightMareRewards(ConfigMarkItem markItem)
		{
			ValueTuple<bool, int, int, string, string> doubleRestAndMaxTimes = MapHelper.GetDoubleRestAndMaxTimes(markItem);
			bool item = doubleRestAndMaxTimes.Item1;
			int item2 = doubleRestAndMaxTimes.Item2;
			int item3 = doubleRestAndMaxTimes.Item3;
			string item4 = doubleRestAndMaxTimes.Item4;
			string item5 = doubleRestAndMaxTimes.Item5;
			if (item)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(20), item4, new <>z__ReadOnlyArray<object>(new object[]
				{
					item2,
					item3
				}));
				LguiUtil.Instance.SetLocalTextNew(base.GetText(42), item5, Array.Empty<object>());
				UUIText text = base.GetText(42);
				if (text != null)
				{
					text.SetUIActive(item);
				}
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(42), "Double_reward_tips_02", Array.Empty<object>());
			}
			UUIItem item6 = base.GetItem(19);
			if (item6 != null)
			{
				item6.SetUIActive(item);
			}
			if (this.RewardGrid == null)
			{
				AActor owner = base.GetItem(8).GetOwner();
				TWeakObjectPtr<UUIItem> rootUIComp = base.GetVerticalLayout(7).RootUIComp;
				this.FirstRewardGrid = new SceneGameplayTipGrid();
				this.FirstRewardGrid.Initialize(LguiUtil.Instance.DuplicateActor(owner, rootUIComp));
				this.RewardGrid = new SceneGameplayTipGrid();
				this.RewardGrid.Initialize(LguiUtil.Instance.DuplicateActor(owner, rootUIComp));
			}
			SceneGameplayTipGrid firstRewardGrid = this.FirstRewardGrid;
			if (firstRewardGrid != null)
			{
				firstRewardGrid.SetBtnPreviewVisible(false);
			}
			ExchangeReward? rewardConfig;
			if (markItem != null)
			{
				int reward = markItem.MarkConfig.Value.Reward;
				rewardConfig = ExchangeRewardConfig.Instance.GetExchangeRewardConfig(new int?(markItem.MarkConfig.Value.Reward));
			}
			else
			{
				rewardConfig = null;
			}
			this.RewardConfig = rewardConfig;
			global::LevelPlayInfo levelPlayInfo = this.LevelPlayInfo;
			bool flag;
			if (levelPlayInfo == null)
			{
				flag = false;
			}
			else
			{
				int firstRewardId = levelPlayInfo.FirstRewardId;
				flag = true;
			}
			this.FirstRewardConfig = (flag ? ExchangeRewardConfig.Instance.GetExchangeRewardConfig(new int?(this.LevelPlayInfo.FirstRewardId)) : null);
			global::LevelPlayInfo levelPlayInfo2 = this.LevelPlayInfo;
			if (levelPlayInfo2 != null && levelPlayInfo2.IsFirstPass)
			{
				this.UpdateNightMareReward(this.FirstRewardGrid, null, "", false);
			}
			else
			{
				this.UpdateNightMareReward(this.FirstRewardGrid, this.FirstRewardConfig, "FirstReward", false);
			}
			this.UpdateNightMareReward(this.RewardGrid, this.RewardConfig, "ProbReward", item);
		}

		// Token: 0x06030656 RID: 198230 RVA: 0x00B3C090 File Offset: 0x00B3A290
		[NullableContext(1)]
		private void UpdateNightMareReward([Nullable(2)] SceneGameplayTipGrid grid, ExchangeReward? rewardConfig, string title, bool showDouble = false)
		{
			if (grid == null)
			{
				return;
			}
			if (rewardConfig == null)
			{
				grid.SetUiActive(false);
				return;
			}
			Dictionary<int, int> nightMareShowReward = AdventureGuideConfig.Instance.GetNightMareShowReward(rewardConfig.Value.RewardIdCalabash());
			if (nightMareShowReward != null)
			{
				grid.Refresh(nightMareShowReward, title, false, false, showDouble);
				grid.SetUiActive(true);
			}
			else
			{
				grid.SetUiActive(false);
			}
			this.SetPanelItemLayoutActive(true);
		}

		// Token: 0x06030657 RID: 198231 RVA: 0x00B3C0F4 File Offset: 0x00B3A2F4
		[NullableContext(0)]
		private UniTask<bool> UpdateFlagChallengeItem([Nullable(1)] ConfigMarkItem markItem)
		{
			CommonGamePlayPanel.<UpdateFlagChallengeItem>d__38 <UpdateFlagChallengeItem>d__;
			<UpdateFlagChallengeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdateFlagChallengeItem>d__.<>4__this = this;
			<UpdateFlagChallengeItem>d__.markItem = markItem;
			<UpdateFlagChallengeItem>d__.<>1__state = -1;
			<UpdateFlagChallengeItem>d__.<>t__builder.Start<CommonGamePlayPanel.<UpdateFlagChallengeItem>d__38>(ref <UpdateFlagChallengeItem>d__);
			return <UpdateFlagChallengeItem>d__.<>t__builder.Task;
		}

		// Token: 0x06030658 RID: 198232 RVA: 0x00B3C140 File Offset: 0x00B3A340
		public UniTask CreateRewardItemBar()
		{
			CommonGamePlayPanel.<CreateRewardItemBar>d__39 <CreateRewardItemBar>d__;
			<CreateRewardItemBar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRewardItemBar>d__.<>4__this = this;
			<CreateRewardItemBar>d__.<>1__state = -1;
			<CreateRewardItemBar>d__.<>t__builder.Start<CommonGamePlayPanel.<CreateRewardItemBar>d__39>(ref <CreateRewardItemBar>d__);
			return <CreateRewardItemBar>d__.<>t__builder.Task;
		}

		// Token: 0x06030659 RID: 198233 RVA: 0x00B3C184 File Offset: 0x00B3A384
		[NullableContext(1)]
		private void RefreshRewardItemBar(ConfigMarkItem selectedMarkItem)
		{
			int levelPlayId = (selectedMarkItem != null) ? selectedMarkItem.MarkConfig.Value.RelativeId : 0;
			if (LevelPlayModel.Instance.GetLevelPlayConfig(levelPlayId) == null)
			{
				UUIVerticalLayout verticalLayout = base.GetVerticalLayout(7);
				if (verticalLayout == null)
				{
					return;
				}
				verticalLayout.RootUIComp.Get().SetUIActive(false);
				return;
			}
			else
			{
				List<TItem> gameplayDropPreviewItemList = selectedMarkItem.MarkItemEntity.GamePlay.GameplayDropPreviewItemList;
				if (gameplayDropPreviewItemList.Count <= 0)
				{
					UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(7);
					if (verticalLayout2 == null)
					{
						return;
					}
					verticalLayout2.RootUIComp.Get().SetUIActive(false);
					return;
				}
				else
				{
					UUIVerticalLayout verticalLayout3 = base.GetVerticalLayout(7);
					if (verticalLayout3 != null)
					{
						verticalLayout3.RootUIComp.Get().SetUIActive(true);
					}
					UUIItem item = base.GetItem(8);
					if (item != null)
					{
						item.SetUIActive(true);
					}
					bool finishRecord;
					if (selectedMarkItem.MarkItemEntity.GamePlay.GameplayCompleteRewardIds.Count > 0)
					{
						finishRecord = selectedMarkItem.MarkItemEntity.GamePlay.IsFinish;
					}
					else
					{
						finishRecord = selectedMarkItem.MarkItemEntity.GamePlay.IsAllRewardReceived;
					}
					RewardItemBar rewardsView = this.RewardsView;
					if (rewardsView != null)
					{
						rewardsView.RebuildRewardsByLevelRewardData(new CommonLevelPlayPanelRewardData
						{
							FinishRecord = finishRecord,
							ItemList = gameplayDropPreviewItemList
						});
					}
					RewardItemBar rewardsView2 = this.RewardsView;
					if (rewardsView2 == null)
					{
						return;
					}
					rewardsView2.SetTitleNewTxt("GameplayMark_Reward_Text");
					return;
				}
			}
		}

		// Token: 0x0603065A RID: 198234 RVA: 0x00B3C2C0 File Offset: 0x00B3A4C0
		protected override void OnBeforeDestroy()
		{
			if (this.RewardGrid != null)
			{
				base.AddChild(this.RewardGrid);
				this.RewardGrid = null;
			}
			if (this.FirstRewardGrid != null)
			{
				base.AddChild(this.FirstRewardGrid);
				this.FirstRewardGrid = null;
			}
			this.RewardConfig = null;
			this.FirstRewardConfig = null;
			CalabashModel.Instance.ClearOnlyShowData();
			base.OnBeforeDestroy();
		}

		// Token: 0x0401A048 RID: 106568
		private const long RED_NAME_PRO_MAX_COUNT = 999999L;

		// Token: 0x0401A04C RID: 106572
		private SceneGameplayTipGrid RewardGrid;

		// Token: 0x0401A04D RID: 106573
		private SceneGameplayTipGrid FirstRewardGrid;

		// Token: 0x0401A04E RID: 106574
		private global::LevelPlayInfo LevelPlayInfo;

		// Token: 0x0401A04F RID: 106575
		private ExchangeReward? RewardConfig;

		// Token: 0x0401A050 RID: 106576
		private ExchangeReward? FirstRewardConfig;

		// Token: 0x0401A051 RID: 106577
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapVerticalLayoutItem, IMapSubViewListItemData> _listLayout;

		// Token: 0x0401A052 RID: 106578
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapProgressItem, MapProgressItemData> _progressLayout;

		// Token: 0x0200AB14 RID: 43796
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033FE3 RID: 212963
			public const int CommonGamePlayPanel = 0;
		}
	}
}
