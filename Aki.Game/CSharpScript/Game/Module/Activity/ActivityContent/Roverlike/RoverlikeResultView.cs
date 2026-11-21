using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050CA RID: 20682
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeResultView : UiViewBase
	{
		// Token: 0x06033C2A RID: 212010 RVA: 0x00E7CBA3 File Offset: 0x00E7ADA3
		public RoverlikeResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033C2B RID: 212011 RVA: 0x00E7CBAC File Offset: 0x00E7ADAC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 24;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIInturnAnimController));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickExit));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(22, new Action(this.OnClickDetailClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033C2C RID: 212012 RVA: 0x00E7CF5C File Offset: 0x00E7B15C
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeResultView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeResultView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033C2D RID: 212013 RVA: 0x00E7CFA0 File Offset: 0x00E7B1A0
		protected override void OnStart()
		{
			RoverRogueResultInfo roverRogueResultInfo = this.OpenParam as RoverRogueResultInfo;
			if (roverRogueResultInfo == null)
			{
				return;
			}
			RoverlikeSettleBlessingPanel blessingPanel = this.BlessingPanel;
			if (blessingPanel != null)
			{
				blessingPanel.BindOnItemClick(new Action<int>(this.OpenBlessingDetail));
			}
			RoverlikeSettleReinforcementPanel reinforcementPanel = this.ReinforcementPanel;
			if (reinforcementPanel != null)
			{
				reinforcementPanel.BindOnItemClick(new Action<int, int>(this.OpenReinforcementDetail));
			}
			RoverlikeSettleItemPanel itemPanel = this.ItemPanel;
			if (itemPanel != null)
			{
				itemPanel.BindOnItemClick(new Action<int, int>(this.OpenItemDetail));
			}
			this.RefreshTitle(roverRogueResultInfo);
			this.RefreshRole(roverRogueResultInfo);
			this.RefreshSummary(roverRogueResultInfo);
			this.RefreshDataGrid(roverRogueResultInfo);
			this.RefreshGainPanels(roverRogueResultInfo);
			UUIItem item = base.GetItem(18);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIButtonComponent button = base.GetButton(22);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.AddSequenceFinishEvent("TipClose", new Action<string>(this.OnTipCloseEnd), false);
		}

		// Token: 0x06033C2E RID: 212014 RVA: 0x00E7D090 File Offset: 0x00E7B290
		private void RefreshTitle(RoverRogueResultInfo resultInfo)
		{
			bool flag = resultInfo.SettleType != RoverRogueInstState.RoverRogueInstFinished;
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(10);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), flag ? "RoverRogue_EndGame_Defeat" : "RoverRogue_EndGame_Victory", Array.Empty<object>());
			this.UiViewSequence.StartSequenceName = (flag ? "Fail" : "Success");
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverRogueActivity? roverRogueActivity;
			if (instance == null)
			{
				roverRogueActivity = null;
			}
			else
			{
				RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
				roverRogueActivity = ((currentActivityData != null) ? currentActivityData.GetParamConfig() : null);
			}
			RoverRogueActivity? roverRogueActivity2 = roverRogueActivity;
			if (roverRogueActivity2 == null)
			{
				return;
			}
			string text = null;
			int settleLevelIconLength = roverRogueActivity2.Value.SettleLevelIconLength;
			for (int i = 0; i < settleLevelIconLength; i++)
			{
				DicIntString? dicIntString = roverRogueActivity2.Value.SettleLevelIcon(i);
				if (dicIntString != null && dicIntString.Value.Key == (int)resultInfo.Grade)
				{
					text = dicIntString.Value.Value;
					break;
				}
			}
			if (StringUtils.IsEmpty(text))
			{
				return;
			}
			base.SetTextureShowUntilLoaded(text, base.GetTexture(7), null);
		}

		// Token: 0x06033C2F RID: 212015 RVA: 0x00E7D1D4 File Offset: 0x00E7B3D4
		private void RefreshRole(RoverRogueResultInfo resultInfo)
		{
			RoverRogueRoleType? roleTypeConfig = RoverlikeConfig.Instance.GetRoleTypeConfig(resultInfo.RoleType);
			int? num = (roleTypeConfig != null) ? new int?(roleTypeConfig.GetValueOrDefault().FemaleRoleId) : null;
			int roverId = resultInfo.RoverId;
			bool flag = num.GetValueOrDefault() == roverId & num != null;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			if (roleTypeConfig != null)
			{
				base.SetTextureByPath(roleTypeConfig.Value.ResultElementIcon, base.GetTexture(4), null, null);
			}
		}

		// Token: 0x06033C30 RID: 212016 RVA: 0x00E7D294 File Offset: 0x00E7B494
		private void RefreshSummary(RoverRogueResultInfo resultInfo)
		{
			RoverRogueIns? insConfig = RoverlikeConfig.Instance.GetInsConfig(resultInfo.InstId);
			if (insConfig != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(11), insConfig.Value.LevelName, Array.Empty<object>());
			}
			long num = MathUtils.Instance.LongToNumber(resultInfo.TotalCostTime) / 1000L;
			base.GetText(12).SetText(TimeUtil.Instance.GetRemainTimeDataFormat6((double)num), true);
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverRogueActivity? roverRogueActivity;
			if (instance == null)
			{
				roverRogueActivity = null;
			}
			else
			{
				RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
				roverRogueActivity = ((currentActivityData != null) ? currentActivityData.GetParamConfig() : null);
			}
			RoverRogueActivity? roverRogueActivity2 = roverRogueActivity;
			this.RefreshReward(this.RewardItemUp, (roverRogueActivity2 != null) ? new int?(roverRogueActivity2.GetValueOrDefault().TokenItemId) : null, resultInfo.Rewards);
			this.RefreshReward(this.RewardItemDown, (roverRogueActivity2 != null) ? new int?(roverRogueActivity2.GetValueOrDefault().TalentPointItemId) : null, resultInfo.Rewards);
		}

		// Token: 0x06033C31 RID: 212017 RVA: 0x00E7D3BC File Offset: 0x00E7B5BC
		private void RefreshReward([Nullable(2)] RoverlikeRewardItem rewardItem, int? itemId, IList<RoverRogueSettleReward> rewardList)
		{
			bool flag = (itemId ?? 0) == 0;
			if (flag)
			{
				if (rewardItem != null)
				{
					rewardItem.SetUiActive(false);
				}
				return;
			}
			int num = 0;
			foreach (RoverRogueSettleReward roverRogueSettleReward in rewardList)
			{
				if (roverRogueSettleReward.ItemId == itemId.Value)
				{
					num = roverRogueSettleReward.Num;
					break;
				}
			}
			if (num == 0)
			{
				if (rewardItem != null)
				{
					rewardItem.SetUiActive(false);
				}
				return;
			}
			RoverRogueCurrency? currencyConfig = RoverlikeConfig.Instance.GetCurrencyConfig(itemId.Value);
			RoverlikeSettleRewardItemData data = new RoverlikeSettleRewardItemData
			{
				IconPath = (((currencyConfig != null) ? currencyConfig.GetValueOrDefault().IconSmall : null) ?? ""),
				NameTextId = (((currencyConfig != null) ? currencyConfig.GetValueOrDefault().Title : null) ?? ""),
				Num = num
			};
			if (rewardItem != null)
			{
				rewardItem.Refresh(data);
			}
			if (rewardItem != null)
			{
				rewardItem.SetUiActive(true);
			}
		}

		// Token: 0x06033C32 RID: 212018 RVA: 0x00E7D4DC File Offset: 0x00E7B6DC
		private void RefreshDataGrid(RoverRogueResultInfo resultInfo)
		{
			List<IRoverlikeSettleDataItemData> list = new List<IRoverlikeSettleDataItemData>();
			RoverlikeSettleDataItemData item = new RoverlikeSettleDataItemData
			{
				NameTextId = "RoverRogue_EndGame_RoomClear",
				ValueText = resultInfo.RoomPassedCount.ToString()
			};
			list.Add(item);
			RoverlikeSettleDataItemData item2 = new RoverlikeSettleDataItemData
			{
				NameTextId = "RoverRogue_EndGame_RoomElite",
				ValueText = resultInfo.EliteRoom.ToString()
			};
			list.Add(item2);
			RoverlikeSettleDataItemData item3 = new RoverlikeSettleDataItemData
			{
				NameTextId = "RoverRogue_EndGame_RoomBoss",
				ValueText = resultInfo.BossRoom.ToString()
			};
			list.Add(item3);
			RoverlikeSettleDataItemData item4 = new RoverlikeSettleDataItemData
			{
				NameTextId = "RoverRogue_EndGame_GoldGain",
				ValueText = resultInfo.TotalGold.ToString()
			};
			list.Add(item4);
			this.DataLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06033C33 RID: 212019 RVA: 0x00E7D5B4 File Offset: 0x00E7B7B4
		private void RefreshGainPanels(RoverRogueResultInfo resultInfo)
		{
			RoverlikeSettleBlessingPanel blessingPanel = this.BlessingPanel;
			if (blessingPanel != null)
			{
				blessingPanel.Refresh(RoverlikeInstanceData.SortGainConfigIds(resultInfo.GainBlessConfId, RoverRogueGainDataType.RoverRogueGainBless));
			}
			RoverlikeSettleReinforcementPanel reinforcementPanel = this.ReinforcementPanel;
			if (reinforcementPanel != null)
			{
				reinforcementPanel.Refresh(RoverlikeInstanceData.SortGainConfigIds(resultInfo.GainRoleConfId, RoverRogueGainDataType.RoverRogueGainRoleEnhance));
			}
			RoverlikeSettleItemPanel itemPanel = this.ItemPanel;
			if (itemPanel != null)
			{
				itemPanel.Refresh(RoverlikeInstanceData.SortGainConfigIds(resultInfo.GainItemConfId, RoverRogueGainDataType.RoverRogueGainItem));
			}
			bool flag = resultInfo.GainLootInfo.Count > 0;
			RoverlikeLootItem lootItem = this.LootItem;
			if (lootItem != null)
			{
				lootItem.SetUiActive(flag);
			}
			if (flag)
			{
				RoverlikeLootGainEntry data = new RoverlikeLootGainEntry(resultInfo.GainLootInfo[0]);
				RoverlikeLootItem lootItem2 = this.LootItem;
				if (lootItem2 == null)
				{
					return;
				}
				lootItem2.Refresh(data);
			}
		}

		// Token: 0x06033C34 RID: 212020 RVA: 0x00E7D65F File Offset: 0x00E7B85F
		private RoverlikeDataItem CreateDataItem()
		{
			return new RoverlikeDataItem();
		}

		// Token: 0x06033C35 RID: 212021 RVA: 0x00E7D666 File Offset: 0x00E7B866
		private void OnClickExit()
		{
			if (!RoverlikeController.Instance.CheckInRoverlike())
			{
				base.CloseMe(null);
			}
			RoverlikeController.Instance.RoverRogueExitRequest();
		}

		// Token: 0x06033C36 RID: 212022 RVA: 0x00E7D688 File Offset: 0x00E7B888
		private void OnTipCloseEnd(string sequenceName)
		{
			UUIItem item = base.GetItem(18);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIButtonComponent button = base.GetButton(22);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06033C37 RID: 212023 RVA: 0x00E7D6CC File Offset: 0x00E7B8CC
		private void OpenBlessingDetail(int blessId)
		{
			this.SelectPanelItem(this.BlessingPanel, blessId);
			RoverlikeBlessingItemData data = new RoverlikeBlessingItemData
			{
				BlessId = blessId,
				AllowToggleInteract = new bool?(false)
			};
			RoverlikeBlessingCardItem blessingCard = this.BlessingCard;
			if (blessingCard != null)
			{
				blessingCard.Refresh(data, false, 0);
			}
			this.ShowDetail(19);
		}

		// Token: 0x06033C38 RID: 212024 RVA: 0x00E7D71C File Offset: 0x00E7B91C
		private void OpenReinforcementDetail(int configId, int key)
		{
			this.SelectPanelItem(this.ReinforcementPanel, key);
			RoverlikeReinforcementItemData data = new RoverlikeReinforcementItemData
			{
				ConfigId = configId,
				AllowToggleInteract = new bool?(false)
			};
			RoverlikeReinforcementCardItem reinforcementCard = this.ReinforcementCard;
			if (reinforcementCard != null)
			{
				reinforcementCard.Refresh(data, false, 0);
			}
			this.ShowDetail(20);
		}

		// Token: 0x06033C39 RID: 212025 RVA: 0x00E7D76C File Offset: 0x00E7B96C
		private void OpenItemDetail(int configId, int key)
		{
			this.SelectPanelItem(this.ItemPanel, key);
			RoverlikePropItemData data = new RoverlikePropItemData
			{
				ConfigId = configId,
				IsInGame = false
			};
			RoverlikePropCardItem itemCard = this.ItemCard;
			if (itemCard != null)
			{
				itemCard.Refresh(data, false, 0);
			}
			this.ShowDetail(21);
		}

		// Token: 0x06033C3A RID: 212026 RVA: 0x00E7D7B8 File Offset: 0x00E7B9B8
		private void ShowDetail(int activeCard)
		{
			UUIItem item = base.GetItem(18);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIButtonComponent button = base.GetButton(22);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(19);
			if (item2 != null)
			{
				item2.SetUIActive(activeCard == 19);
			}
			UUIItem item3 = base.GetItem(20);
			if (item3 != null)
			{
				item3.SetUIActive(activeCard == 20);
			}
			UUIItem item4 = base.GetItem(21);
			if (item4 != null)
			{
				item4.SetUIActive(activeCard == 21);
			}
			if (!this.IsDetailShow)
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.PlayOrReplaySequenceByName("TipStart", true, null);
				}
			}
			this.IsDetailShow = true;
			UUIInturnAnimController uiInturnAnimController = base.GetUiInturnAnimController(23);
			if (uiInturnAnimController == null)
			{
				return;
			}
			uiInturnAnimController.Play("", -1, false);
		}

		// Token: 0x06033C3B RID: 212027 RVA: 0x00E7D88A File Offset: 0x00E7BA8A
		[NullableContext(2)]
		private void SelectPanelItem(IRoverlikeSettleSelectablePanel targetPanel, int key)
		{
			RoverlikeSettleBlessingPanel blessingPanel = this.BlessingPanel;
			if (blessingPanel != null)
			{
				blessingPanel.ClearSelect();
			}
			RoverlikeSettleReinforcementPanel reinforcementPanel = this.ReinforcementPanel;
			if (reinforcementPanel != null)
			{
				reinforcementPanel.ClearSelect();
			}
			RoverlikeSettleItemPanel itemPanel = this.ItemPanel;
			if (itemPanel != null)
			{
				itemPanel.ClearSelect();
			}
			if (targetPanel != null)
			{
				targetPanel.SelectByKey(key);
			}
		}

		// Token: 0x06033C3C RID: 212028 RVA: 0x00E7D8CC File Offset: 0x00E7BACC
		private void OnClickDetailClose()
		{
			RoverlikeSettleBlessingPanel blessingPanel = this.BlessingPanel;
			if (blessingPanel != null)
			{
				blessingPanel.ClearSelect();
			}
			RoverlikeSettleReinforcementPanel reinforcementPanel = this.ReinforcementPanel;
			if (reinforcementPanel != null)
			{
				reinforcementPanel.ClearSelect();
			}
			RoverlikeSettleItemPanel itemPanel = this.ItemPanel;
			if (itemPanel != null)
			{
				itemPanel.ClearSelect();
			}
			this.IsDetailShow = false;
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("TipClose", true, null);
		}

		// Token: 0x0401B6EC RID: 112364
		[Nullable(2)]
		private RoverlikeRewardItem RewardItemUp;

		// Token: 0x0401B6ED RID: 112365
		[Nullable(2)]
		private RoverlikeRewardItem RewardItemDown;

		// Token: 0x0401B6EE RID: 112366
		[Nullable(2)]
		private RoverlikeLootItem LootItem;

		// Token: 0x0401B6EF RID: 112367
		[Nullable(2)]
		private RoverlikeSettleBlessingPanel BlessingPanel;

		// Token: 0x0401B6F0 RID: 112368
		[Nullable(2)]
		private RoverlikeSettleReinforcementPanel ReinforcementPanel;

		// Token: 0x0401B6F1 RID: 112369
		[Nullable(2)]
		private RoverlikeSettleItemPanel ItemPanel;

		// Token: 0x0401B6F2 RID: 112370
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeDataItem, IRoverlikeSettleDataItemData> DataLayout;

		// Token: 0x0401B6F3 RID: 112371
		[Nullable(2)]
		private RoverlikeBlessingCardItem BlessingCard;

		// Token: 0x0401B6F4 RID: 112372
		[Nullable(2)]
		private RoverlikeReinforcementCardItem ReinforcementCard;

		// Token: 0x0401B6F5 RID: 112373
		[Nullable(2)]
		private RoverlikePropCardItem ItemCard;

		// Token: 0x0401B6F6 RID: 112374
		private bool IsDetailShow;

		// Token: 0x0200AD94 RID: 44436
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035A1A RID: 219674
			public const int BtnClose = 0;

			// Token: 0x04035A1B RID: 219675
			public const int PanelMale = 1;

			// Token: 0x04035A1C RID: 219676
			public const int PanelFemale = 2;

			// Token: 0x04035A1D RID: 219677
			public const int ItemLoot = 3;

			// Token: 0x04035A1E RID: 219678
			public const int TexIconElement = 4;

			// Token: 0x04035A1F RID: 219679
			public const int RewardItem1 = 5;

			// Token: 0x04035A20 RID: 219680
			public const int RewardItem2 = 6;

			// Token: 0x04035A21 RID: 219681
			public const int TexRankIcon = 7;

			// Token: 0x04035A22 RID: 219682
			public const int TxtResultTitle = 8;

			// Token: 0x04035A23 RID: 219683
			public const int ItemSuccessBg = 9;

			// Token: 0x04035A24 RID: 219684
			public const int ItemFailBg = 10;

			// Token: 0x04035A25 RID: 219685
			public const int TxtTitleDifficulty = 11;

			// Token: 0x04035A26 RID: 219686
			public const int TxtTime = 12;

			// Token: 0x04035A27 RID: 219687
			public const int InfoLayout = 13;

			// Token: 0x04035A28 RID: 219688
			public const int InfoItem = 14;

			// Token: 0x04035A29 RID: 219689
			public const int PanelBlessing = 15;

			// Token: 0x04035A2A RID: 219690
			public const int PanelReinforcement = 16;

			// Token: 0x04035A2B RID: 219691
			public const int PanelItem = 17;

			// Token: 0x04035A2C RID: 219692
			public const int PanelDetailInfo = 18;

			// Token: 0x04035A2D RID: 219693
			public const int CardBlessing = 19;

			// Token: 0x04035A2E RID: 219694
			public const int CardReinforcement = 20;

			// Token: 0x04035A2F RID: 219695
			public const int CardItem = 21;

			// Token: 0x04035A30 RID: 219696
			public const int BtnDetailClose = 22;

			// Token: 0x04035A31 RID: 219697
			public const int DetailCardPanel = 23;
		}

		// Token: 0x0200AD95 RID: 44437
		[Nullable(0)]
		private class EViewSeqName
		{
			// Token: 0x04035A32 RID: 219698
			public const string TipStart = "TipStart";

			// Token: 0x04035A33 RID: 219699
			public const string TipClose = "TipClose";
		}
	}
}
