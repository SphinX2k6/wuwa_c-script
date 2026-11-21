using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.InstanceDungeonEntrancePanel
{
	// Token: 0x02003741 RID: 14145
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x17004BA3 RID: 19363
		// (get) Token: 0x06024C8A RID: 150666 RVA: 0x00A63DE4 File Offset: 0x00A61FE4
		private InstanceDungeonEntrance? EntranceConfig
		{
			get
			{
				if (this.EntranceId == 0)
				{
					return null;
				}
				InstanceDungeonEntranceConfig instance = InstanceDungeonEntranceConfig.Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.GetConfig(this.EntranceId);
			}
		}

		// Token: 0x06024C8B RID: 150667 RVA: 0x00A63E21 File Offset: 0x00A62021
		public override string GetResourceId()
		{
			return "UiView_InstanceEntranceTip_Prefab";
		}

		// Token: 0x06024C8C RID: 150668 RVA: 0x00A63E28 File Offset: 0x00A62028
		protected override void OnStart()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(5);
			if (verticalLayout != null)
			{
				verticalLayout.RootUIComp.Get().SetUIActive(true);
			}
			this.InstanceCostTipView = new GenericLayoutAdd<InstanceDungeonCostTip>(base.GetVerticalLayout(5), new TLayoutRefresh<InstanceDungeonCostTip>(this.OnInstanceRefresh));
			this.InstanceScrollView = new GenericLayout<InstanceTipGrid, IInstanceTipGridData>(base.GetVerticalLayout(7), new Func<InstanceTipGrid>(this.InitItem), null, false, true);
			base.OnStart();
		}

		// Token: 0x06024C8D RID: 150669 RVA: 0x00A63E9A File Offset: 0x00A6209A
		protected override void OnBeforeDestroy()
		{
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.ClearChildren();
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x06024C8E RID: 150670 RVA: 0x00A63EB4 File Offset: 0x00A620B4
		private ILayoutItem<InstanceDungeonCostTip> OnInstanceRefresh(object data, UUIItem uiItem, int index, int originalItemIndex)
		{
			InstanceDungeonCostTip instanceDungeonCostTip = new InstanceDungeonCostTip();
			instanceDungeonCostTip.SetRootActor(uiItem.GetOwner(), true);
			return new LayoutItem<InstanceDungeonCostTip>
			{
				Key = data,
				Value = instanceDungeonCostTip
			};
		}

		// Token: 0x06024C8F RID: 150671 RVA: 0x00A63EE7 File Offset: 0x00A620E7
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			UUIItem item = base.GetItem(32);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06024C90 RID: 150672 RVA: 0x00A63F04 File Offset: 0x00A62104
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				TeleportMarkItem teleportMarkItem = param[0] as TeleportMarkItem;
				if (teleportMarkItem != null)
				{
					this.SelectedMarkItem = teleportMarkItem;
					this.LayoutContext.MarkItem = teleportMarkItem;
					int num = (teleportMarkItem != null) ? teleportMarkItem.MarkConfig.Value.RelativeId : 0;
					int markConfigId = teleportMarkItem.MarkConfigId;
					int entranceId;
					if (num == 0)
					{
						InstanceDungeonEntranceConfig instance = InstanceDungeonEntranceConfig.Instance;
						entranceId = ((instance != null) ? instance.GetEntranceIdByMarkId(markConfigId) : 0);
					}
					else
					{
						entranceId = num;
					}
					this.EntranceId = entranceId;
					if (this.EntranceId == 0)
					{
						Log instance2 = Log.Instance;
						ELogModule module = ELogModule.InstanceDungeon;
						ELogAuthor author = ELogAuthor.LYX;
						string message = "副本入口弹窗打开错误，副本入口表中找不到对应的地图标记Id！";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", markConfigId);
						instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					this.InitView();
					InstanceDungeonEntranceController.Instance.InstEntranceDetailRequest(this.EntranceId).ContinueWith(delegate(bool _)
					{
						this.UpdateInstanceList();
						this.UpdateCost();
					});
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					InstanceDungeonEntrance? instanceDungeonEntrance;
					int num2 = (this.EntranceConfig != null) ? instanceDungeonEntrance.GetValueOrDefault().UnLockCondition : 0;
					if (num2 != 0 && !FunctionModel.Instance.IsOpen(num2))
					{
						FunctionConfig instance3 = FunctionConfig.Instance;
						FunctionCondition? functionCondition = (instance3 != null) ? instance3.GetFunctionCondition(num2) : null;
						ConditionConfig instance4 = ConditionConfig.Instance;
						ConditionGroup? conditionGroup = (instance4 != null) ? instance4.GetConditionGroupConfig((functionCondition != null) ? functionCondition.GetValueOrDefault().OpenConditionId : 0) : null;
						LguiUtil.Instance.SetLocalTextNew(base.GetText(4), ((conditionGroup != null) ? conditionGroup.GetValueOrDefault().HintText : null) ?? "", Array.Empty<object>());
					}
				}
			}
		}

		// Token: 0x06024C91 RID: 150673 RVA: 0x00A640C0 File Offset: 0x00A622C0
		public List<int> GetMaxUnlockInstanceList()
		{
			List<int> list = new List<int>();
			if (this.InstanceIdList.Count == 0)
			{
				return list;
			}
			int num = InstanceDungeonConfig.Instance.GetRecommendLevel(this.InstanceIdList[0], WorldLevelModel.Instance.CurWorldLevel);
			foreach (int num2 in this.InstanceIdList)
			{
				InstanceDungeonEntranceModel instance = InstanceDungeonEntranceModel.Instance;
				if (instance != null && instance.CheckInstanceUnlock(num2))
				{
					InstanceDungeonConfig instance2 = InstanceDungeonConfig.Instance;
					int num3 = (instance2 != null) ? instance2.GetRecommendLevel(num2, WorldLevelModel.Instance.CurWorldLevel) : 0;
					if (num3 >= num)
					{
						if (num3 > num)
						{
							list.Clear();
							num = num3;
						}
						list.Add(num2);
					}
				}
			}
			if (list.Count == 0)
			{
				foreach (int num4 in this.InstanceIdList)
				{
					InstanceDungeonConfig instance3 = InstanceDungeonConfig.Instance;
					int num5 = (instance3 != null) ? instance3.GetRecommendLevel(num4, WorldLevelModel.Instance.CurWorldLevel) : 0;
					if (num5 <= num)
					{
						if (num5 < num)
						{
							list.Clear();
							num = num5;
						}
						list.Add(num4);
					}
				}
			}
			list.Sort(delegate(int a, int b)
			{
				ExchangeRewardModel instance4 = ExchangeRewardModel.Instance;
				int num6 = (instance4 != null && instance4.GetInstanceDungeonIfCanExchange(a)) ? 1 : 0;
				ExchangeRewardModel instance5 = ExchangeRewardModel.Instance;
				bool flag = instance5 != null && instance5.GetInstanceDungeonIfCanExchange(b);
				return ((num6 == 0) - !flag) ? 1 : 0;
			});
			return list;
		}

		// Token: 0x06024C92 RID: 150674 RVA: 0x00A64234 File Offset: 0x00A62434
		private void InitView()
		{
			InstanceDungeonEntrance? entranceConfig = this.EntranceConfig;
			if (entranceConfig == null)
			{
				return;
			}
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.ShowTextNew(entranceConfig.Value.Description);
			}
			WorldMapSecondaryUiLayoutHelper.UpdateIcon(this.LayoutContext);
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.ShowTextNew(entranceConfig.Value.Name);
			}
			WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				TeleportMarkItem selectedMarkItem = this.SelectedMarkItem;
				item.SetUIActive(selectedMarkItem != null && !selectedMarkItem.IsFogUnlock);
			}
			UUIText text3 = base.GetText(10);
			if (text3 != null)
			{
				text3.ShowTextNew("Instance_Dungeon_Rcommand_Text");
			}
			bool flag = base.UpdateQuickGoto();
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext == null)
			{
				return;
			}
			layoutContext.SetConfirmBtnActive(!flag);
		}

		// Token: 0x06024C93 RID: 150675 RVA: 0x00A64308 File Offset: 0x00A62508
		private void UpdateInstanceList()
		{
			this.InstanceIdList.Clear();
			InstanceDungeonEntranceModel instance = InstanceDungeonEntranceModel.Instance;
			Dictionary<int, int> dictionary = (instance != null) ? instance.GetSortedByTitleEntranceInstanceIdList(this.EntranceId) : null;
			if (dictionary == null)
			{
				return;
			}
			List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>(dictionary);
			list.Sort((KeyValuePair<int, int> a, KeyValuePair<int, int> b) => a.Value - b.Value);
			foreach (KeyValuePair<int, int> keyValuePair in list)
			{
				this.InstanceIdList.Add(keyValuePair.Key);
			}
			this.InstanceIdList = this.GetMaxUnlockInstanceList();
			if (this.InstanceIdList.Count == 0)
			{
				return;
			}
			InstanceDungeonConfig instance2 = InstanceDungeonConfig.Instance;
			InstanceDungeon? instanceDungeon = (instance2 != null) ? instance2.GetConfig(this.InstanceIdList[0]) : null;
			if (instanceDungeon == null)
			{
				return;
			}
			List<int> list2 = new List<int>();
			list2.AddRange(instanceDungeon.Value.GetCustomTypesBytes());
			ActivityDoubleRewardController instance3 = ActivityDoubleRewardController.Instance;
			ActivityDoubleRewardData activityDoubleRewardData = (instance3 != null) ? instance3.GetDungeonUpActivity(list2, true) : null;
			UUIItem item = base.GetItem(19);
			if (item != null)
			{
				item.SetUIActive(activityDoubleRewardData != null);
			}
			if (activityDoubleRewardData != null)
			{
				ValueTuple<string, int, int> numTxtAndParam = activityDoubleRewardData.GetNumTxtAndParam();
				LguiUtil.Instance.SetLocalTextNew(base.GetText(20), numTxtAndParam.Item1, new <>z__ReadOnlyArray<object>(new object[]
				{
					numTxtAndParam.Item2,
					numTxtAndParam.Item3
				}));
				LguiUtil.Instance.SetLocalTextNew(base.GetText(42), "Double_reward_tips_02", Array.Empty<object>());
			}
			ValueTuple<bool, int, int, string, string> doubleRestAndMaxTimes = MapHelper.GetDoubleRestAndMaxTimes(this.SelectedMarkItem);
			bool item2 = doubleRestAndMaxTimes.Item1;
			int item3 = doubleRestAndMaxTimes.Item2;
			int item4 = doubleRestAndMaxTimes.Item3;
			string item5 = doubleRestAndMaxTimes.Item4;
			string item6 = doubleRestAndMaxTimes.Item5;
			if (item2)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(20), item5, new <>z__ReadOnlyArray<object>(new object[]
				{
					item3.ToString(),
					item4.ToString()
				}));
				LguiUtil.Instance.SetLocalTextNew(base.GetText(42), item6, Array.Empty<object>());
				UUIText text = base.GetText(42);
				if (text != null)
				{
					text.SetUIActive(item2);
				}
			}
			UUIItem item7 = base.GetItem(19);
			if (item7 != null)
			{
				item7.SetUIActive(item2 || activityDoubleRewardData != null);
			}
			List<IInstanceTipGridData> list3 = new List<IInstanceTipGridData>();
			foreach (int instanceId in this.InstanceIdList)
			{
				list3.Add(new InstanceTipGridData
				{
					InstanceId = instanceId,
					IsDouble = item2
				});
			}
			GenericLayout<InstanceTipGrid, IInstanceTipGridData> instanceScrollView = this.InstanceScrollView;
			if (instanceScrollView != null)
			{
				instanceScrollView.RefreshByData(list3, null, false);
			}
			int rewardId = instanceDungeon.Value.RewardId;
			ExchangeRewardConfig instance4 = ExchangeRewardConfig.Instance;
			ExchangeReward? exchangeReward;
			int? num = (instance4 != null) ? ((instance4.GetExchangeRewardConfig(new int?(rewardId)) != null) ? new int?(exchangeReward.GetValueOrDefault().SharedId) : null) : null;
			if (num != null && num.Value != 0)
			{
				GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
				if (instanceCostTipView != null)
				{
					instanceCostTipView.AddItemToLayout(new object[]
					{
						"countLimit"
					}, 0);
				}
				GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView2 = this.InstanceCostTipView;
				InstanceDungeonCostTip instanceDungeonCostTip = ((instanceCostTipView2 != null) ? instanceCostTipView2.GetLayoutItemByKey("countLimit", 0) : null) as InstanceDungeonCostTip;
				if (instanceDungeonCostTip != null)
				{
					instanceDungeonCostTip.SetIconVisible(false);
					instanceDungeonCostTip.SetStarVisible(false);
					string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_CanReceivedCount_Text", null) ?? "", new string[]
					{
						""
					});
					instanceDungeonCostTip.SetLeftText(leftText);
					ExchangeRewardConfig instance5 = ExchangeRewardConfig.Instance;
					ExchangeShared? exchangeShared = (instance5 != null) ? instance5.GetExchangeShareConfig(new int?(num.Value)) : null;
					if (exchangeShared != null)
					{
						ExchangeRewardModel instance6 = ExchangeRewardModel.Instance;
						int num2 = (instance6 != null) ? instance6.GetExchangeRewardShareCount(num.Value) : 0;
						int maxCount = exchangeShared.Value.MaxCount;
						instanceDungeonCostTip.SetRightText(StringUtils.Format("{0}/{1}", new string[]
						{
							(maxCount - num2).ToString(),
							maxCount.ToString()
						}));
					}
					instanceDungeonCostTip.SetHelpButtonVisible(false);
				}
			}
		}

		// Token: 0x06024C94 RID: 150676 RVA: 0x00A64778 File Offset: 0x00A62978
		private void UpdateCost()
		{
			if (this.InstanceIdList.Count == 0)
			{
				return;
			}
			ExchangeRewardModel instance = ExchangeRewardModel.Instance;
			List<TItem> list = (instance != null) ? instance.GetExchangeNormalConsume(this.InstanceIdList[0]) : null;
			if (list == null || list.Count == 0)
			{
				return;
			}
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.AddItemToLayout(new object[]
				{
					"power"
				}, 0);
			}
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView2 = this.InstanceCostTipView;
			InstanceDungeonCostTip instanceDungeonCostTip = ((instanceCostTipView2 != null) ? instanceCostTipView2.GetLayoutItemByKey("power", 0) : null) as InstanceDungeonCostTip;
			if (instanceDungeonCostTip != null)
			{
				instanceDungeonCostTip.SetStarVisible(false);
				int itemId = list[0].ItemData.ItemId;
				instanceDungeonCostTip.SetIconByItemId(itemId);
				instanceDungeonCostTip.SetLeftText(ConfigMultiTextLang.GetLocalTextNew("CostStamina", null) ?? "");
				instanceDungeonCostTip.SetHelpButtonVisible(true);
				instanceDungeonCostTip.SetRightText(list[0].Count.ToString());
				instanceDungeonCostTip.SetClickHelpFunc(new Action(this.OnClickHelpButton));
			}
		}

		// Token: 0x06024C95 RID: 150677 RVA: 0x00A6486B File Offset: 0x00A62A6B
		private void OnClickHelpButton()
		{
			HelpController instance = HelpController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.OpenHelpById(89);
		}

		// Token: 0x06024C96 RID: 150678 RVA: 0x00A6487E File Offset: 0x00A62A7E
		protected override void OnCloseWorldMapSecondaryUi()
		{
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView == null)
			{
				return;
			}
			instanceCostTipView.ClearChildren();
		}

		// Token: 0x06024C97 RID: 150679 RVA: 0x00A64890 File Offset: 0x00A62A90
		private InstanceTipGrid InitItem()
		{
			return new InstanceTipGrid();
		}

		// Token: 0x06024C98 RID: 150680 RVA: 0x00A64897 File Offset: 0x00A62A97
		[NullableContext(2)]
		public override UUIItem GetGuideFocusUiItem()
		{
			UUIButtonComponent button = base.GetButton(11);
			object obj;
			if (button == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = button.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null);
			}
			return obj as UUIItem;
		}

		// Token: 0x0401468A RID: 83594
		private const int HELP_ID = 89;

		// Token: 0x0401468B RID: 83595
		private const string POWER_COST_KEY = "power";

		// Token: 0x0401468C RID: 83596
		private const string COUNT_LIMMIT_KEY = "countLimit";

		// Token: 0x0401468D RID: 83597
		private int EntranceId;

		// Token: 0x0401468E RID: 83598
		private List<int> InstanceIdList = new List<int>();

		// Token: 0x0401468F RID: 83599
		[Nullable(2)]
		private TeleportMarkItem SelectedMarkItem;

		// Token: 0x04014690 RID: 83600
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutAdd<InstanceDungeonCostTip> InstanceCostTipView;

		// Token: 0x04014691 RID: 83601
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<InstanceTipGrid, IInstanceTipGridData> InstanceScrollView;

		// Token: 0x0200948C RID: 38028
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E6D5 RID: 190165
			public const int InstanceDungeonEntrancePanel = 0;
		}
	}
}
