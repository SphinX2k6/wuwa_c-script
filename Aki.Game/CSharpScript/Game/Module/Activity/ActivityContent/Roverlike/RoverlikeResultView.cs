using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x0200614C RID: 24908
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeResultView : UiViewBase
	{
		// Token: 0x0603EF6A RID: 257898 RVA: 0x00F35CC3 File Offset: 0x00F33EC3
		public RoverlikeResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603EF6B RID: 257899 RVA: 0x00F35CCC File Offset: 0x00F33ECC
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

		// Token: 0x0603EF6C RID: 257900 RVA: 0x00F3607C File Offset: 0x00F3427C
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeResultView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeResultView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EF6D RID: 257901 RVA: 0x00F360C0 File Offset: 0x00F342C0
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

		// Token: 0x0603EF6E RID: 257902 RVA: 0x00F361B0 File Offset: 0x00F343B0
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

		// Token: 0x0603EF6F RID: 257903 RVA: 0x00F362F4 File Offset: 0x00F344F4
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

		// Token: 0x0603EF70 RID: 257904 RVA: 0x00F363B4 File Offset: 0x00F345B4
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

		// Token: 0x0603EF71 RID: 257905 RVA: 0x00F364DC File Offset: 0x00F346DC
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

		// Token: 0x0603EF72 RID: 257906 RVA: 0x00F365FC File Offset: 0x00F347FC
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

		// Token: 0x0603EF73 RID: 257907 RVA: 0x00F366D4 File Offset: 0x00F348D4
		private void RefreshGainPanels(RoverRogueResultInfo resultInfo)
		{
			RoverlikeSettleBlessingPanel blessingPanel = this.BlessingPanel;
			if (blessingPanel != null)
			{
				blessingPanel.Refresh(RoverlikeInstanceData.SortGainConfigIds(resultInfo.GainBlessConfId.ToList<int>(), RoverRogueGainDataType.RoverRogueGainBless));
			}
			RoverlikeSettleReinforcementPanel reinforcementPanel = this.ReinforcementPanel;
			if (reinforcementPanel != null)
			{
				reinforcementPanel.Refresh(RoverlikeInstanceData.SortGainConfigIds(resultInfo.GainRoleConfId.ToList<int>(), RoverRogueGainDataType.RoverRogueGainRoleEnhance));
			}
			RoverlikeSettleItemPanel itemPanel = this.ItemPanel;
			if (itemPanel != null)
			{
				itemPanel.Refresh(RoverlikeInstanceData.SortGainConfigIds(resultInfo.GainItemConfId.ToList<int>(), RoverRogueGainDataType.RoverRogueGainItem));
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

		// Token: 0x0603EF74 RID: 257908 RVA: 0x00F3678E File Offset: 0x00F3498E
		private RoverlikeDataItem CreateDataItem()
		{
			return new RoverlikeDataItem();
		}

		// Token: 0x0603EF75 RID: 257909 RVA: 0x00F36795 File Offset: 0x00F34995
		private void OnClickExit()
		{
			if (!RoverlikeController.Instance.CheckInRoverlike())
			{
				base.CloseMe(null);
			}
			RoverlikeController.Instance.RoverRogueExitRequest();
		}

		// Token: 0x0603EF76 RID: 257910 RVA: 0x00F367B4 File Offset: 0x00F349B4
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

		// Token: 0x0603EF77 RID: 257911 RVA: 0x00F367F8 File Offset: 0x00F349F8
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

		// Token: 0x0603EF78 RID: 257912 RVA: 0x00F36848 File Offset: 0x00F34A48
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

		// Token: 0x0603EF79 RID: 257913 RVA: 0x00F36898 File Offset: 0x00F34A98
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

		// Token: 0x0603EF7A RID: 257914 RVA: 0x00F368E4 File Offset: 0x00F34AE4
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

		// Token: 0x0603EF7B RID: 257915 RVA: 0x00F369B6 File Offset: 0x00F34BB6
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

		// Token: 0x0603EF7C RID: 257916 RVA: 0x00F369F8 File Offset: 0x00F34BF8
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

		// Token: 0x04020DBF RID: 134591
		[Nullable(2)]
		private RoverlikeRewardItem RewardItemUp;

		// Token: 0x04020DC0 RID: 134592
		[Nullable(2)]
		private RoverlikeRewardItem RewardItemDown;

		// Token: 0x04020DC1 RID: 134593
		[Nullable(2)]
		private RoverlikeLootItem LootItem;

		// Token: 0x04020DC2 RID: 134594
		[Nullable(2)]
		private RoverlikeSettleBlessingPanel BlessingPanel;

		// Token: 0x04020DC3 RID: 134595
		[Nullable(2)]
		private RoverlikeSettleReinforcementPanel ReinforcementPanel;

		// Token: 0x04020DC4 RID: 134596
		[Nullable(2)]
		private RoverlikeSettleItemPanel ItemPanel;

		// Token: 0x04020DC5 RID: 134597
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeDataItem, IRoverlikeSettleDataItemData> DataLayout;

		// Token: 0x04020DC6 RID: 134598
		[Nullable(2)]
		private RoverlikeBlessingCardItem BlessingCard;

		// Token: 0x04020DC7 RID: 134599
		[Nullable(2)]
		private RoverlikeReinforcementCardItem ReinforcementCard;

		// Token: 0x04020DC8 RID: 134600
		[Nullable(2)]
		private RoverlikePropCardItem ItemCard;

		// Token: 0x04020DC9 RID: 134601
		private bool IsDetailShow;

		// Token: 0x0200C3AD RID: 50093
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B0B9 RID: 241849
			public const int BtnClose = 0;

			// Token: 0x0403B0BA RID: 241850
			public const int PanelMale = 1;

			// Token: 0x0403B0BB RID: 241851
			public const int PanelFemale = 2;

			// Token: 0x0403B0BC RID: 241852
			public const int ItemLoot = 3;

			// Token: 0x0403B0BD RID: 241853
			public const int TexIconElement = 4;

			// Token: 0x0403B0BE RID: 241854
			public const int RewardItem1 = 5;

			// Token: 0x0403B0BF RID: 241855
			public const int RewardItem2 = 6;

			// Token: 0x0403B0C0 RID: 241856
			public const int TexRankIcon = 7;

			// Token: 0x0403B0C1 RID: 241857
			public const int TxtResultTitle = 8;

			// Token: 0x0403B0C2 RID: 241858
			public const int ItemSuccessBg = 9;

			// Token: 0x0403B0C3 RID: 241859
			public const int ItemFailBg = 10;

			// Token: 0x0403B0C4 RID: 241860
			public const int TxtTitleDifficulty = 11;

			// Token: 0x0403B0C5 RID: 241861
			public const int TxtTime = 12;

			// Token: 0x0403B0C6 RID: 241862
			public const int InfoLayout = 13;

			// Token: 0x0403B0C7 RID: 241863
			public const int InfoItem = 14;

			// Token: 0x0403B0C8 RID: 241864
			public const int PanelBlessing = 15;

			// Token: 0x0403B0C9 RID: 241865
			public const int PanelReinforcement = 16;

			// Token: 0x0403B0CA RID: 241866
			public const int PanelItem = 17;

			// Token: 0x0403B0CB RID: 241867
			public const int PanelDetailInfo = 18;

			// Token: 0x0403B0CC RID: 241868
			public const int CardBlessing = 19;

			// Token: 0x0403B0CD RID: 241869
			public const int CardReinforcement = 20;

			// Token: 0x0403B0CE RID: 241870
			public const int CardItem = 21;

			// Token: 0x0403B0CF RID: 241871
			public const int BtnDetailClose = 22;

			// Token: 0x0403B0D0 RID: 241872
			public const int DetailCardPanel = 23;
		}

		// Token: 0x0200C3AE RID: 50094
		[Nullable(0)]
		private class EViewSeqName
		{
			// Token: 0x0403B0D1 RID: 241873
			public const string TipStart = "TipStart";

			// Token: 0x0403B0D2 RID: 241874
			public const string TipClose = "TipClose";
		}
	}
}
