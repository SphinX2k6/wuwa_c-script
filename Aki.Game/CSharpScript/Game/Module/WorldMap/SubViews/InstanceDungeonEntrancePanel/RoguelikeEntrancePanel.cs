using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.InstanceDungeonEntrancePanel
{
	// Token: 0x02004811 RID: 18449
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x170078E7 RID: 30951
		// (get) Token: 0x060304CB RID: 197835 RVA: 0x00B34980 File Offset: 0x00B32B80
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

		// Token: 0x060304CC RID: 197836 RVA: 0x00B349BD File Offset: 0x00B32BBD
		public override string GetResourceId()
		{
			return "UiView_InstanceEntranceTip_Prefab";
		}

		// Token: 0x060304CD RID: 197837 RVA: 0x00B349C4 File Offset: 0x00B32BC4
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeEntrancePanel.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeEntrancePanel.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060304CE RID: 197838 RVA: 0x00B34A08 File Offset: 0x00B32C08
		protected override void OnStart()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(5);
			if (verticalLayout != null)
			{
				verticalLayout.RootUIComp.Get().SetUIActive(true);
			}
			this.InstanceCostTipView = new GenericLayoutAdd<InstanceDungeonCostTip>(base.GetVerticalLayout(5), new TLayoutRefresh<InstanceDungeonCostTip>(this.OnInstanceRefresh));
			base.OnStart();
		}

		// Token: 0x060304CF RID: 197839 RVA: 0x00B34A59 File Offset: 0x00B32C59
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

		// Token: 0x060304D0 RID: 197840 RVA: 0x00B34A74 File Offset: 0x00B32C74
		protected override void OnBeforeDestroy()
		{
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.ClearChildren();
			}
			if (this.TimerId != null)
			{
				TimerSystem.Instance.Remove(this.TimerId);
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x060304D1 RID: 197841 RVA: 0x00B34AA8 File Offset: 0x00B32CA8
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

		// Token: 0x060304D2 RID: 197842 RVA: 0x00B34ADC File Offset: 0x00B32CDC
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
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", teleportMarkItem.MarkConfigId);
						instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					this.InitView();
					this.UpdateInstanceList();
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

		// Token: 0x060304D3 RID: 197843 RVA: 0x00B34C80 File Offset: 0x00B32E80
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
			LguiUtil.Instance.SetLocalTextNew(base.GetText(36), "Instance_RogueInstanceEntrance_Progress", Array.Empty<object>());
			bool flag = base.UpdateQuickGoto();
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext == null)
			{
				return;
			}
			layoutContext.SetConfirmBtnActive(!flag);
		}

		// Token: 0x060304D4 RID: 197844 RVA: 0x00B34D70 File Offset: 0x00B32F70
		private void RefreshReward()
		{
			ActivityRogueController instance = ActivityRogueController.Instance;
			List<TItem> list;
			if (instance == null)
			{
				list = null;
			}
			else
			{
				ActivityRogueData currentActivityData = instance.GetCurrentActivityData();
				list = ((currentActivityData != null) ? currentActivityData.GetPreviewReward(null) : null);
			}
			List<TItem> list2 = list;
			if (list2 == null || list2.Count == 0)
			{
				UUIItem item = base.GetItem(8);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				int num = Math.Min(list2.Count, 5);
				TItem[] array = new TItem[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = list2[i];
				}
				for (int j = 0; j < array.Length; j++)
				{
					array[j].Count = 0;
				}
				UUIItem item2 = base.GetItem(8);
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				RewardItemBar rewardsView = this.RewardsView;
				if (rewardsView == null)
				{
					return;
				}
				rewardsView.RebuildRewardsByData(array.ToList<TItem>());
				return;
			}
		}

		// Token: 0x060304D5 RID: 197845 RVA: 0x00B34E40 File Offset: 0x00B33040
		private void UpdateInstanceList()
		{
			InstanceDungeonEntranceConfig instance = InstanceDungeonEntranceConfig.Instance;
			int? num = (instance != null) ? new int?(instance.GetInstanceDungeonEntranceFlowId(this.EntranceId)) : null;
			this.RefreshReward();
			if (num.GetValueOrDefault() == 6)
			{
				RoguelikeModel instance2 = RoguelikeModel.Instance;
				if (instance2 == null || !instance2.CheckRogueIsOpen())
				{
					this.RefreshEmptyItem();
					return;
				}
				this.RefreshTimeItem();
				this.RefreshDifficultyItem();
				this.RefreshAchievementItem();
				this.RefreshShopProgressItem();
				if (this.TimerId != null)
				{
					TimerSystem.Instance.Remove(this.TimerId);
				}
				this.TimerId = TimerSystem.Instance.Forever(delegate(float delta)
				{
					this.RefreshTimeItem();
				}, 1000f, 1f, null, null, true);
			}
		}

		// Token: 0x060304D6 RID: 197846 RVA: 0x00B34EFC File Offset: 0x00B330FC
		private void RefreshEmptyItem()
		{
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.AddItemToLayout(new object[]
				{
					"rougeScore"
				}, 0);
			}
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView2 = this.InstanceCostTipView;
			InstanceDungeonCostTip instanceDungeonCostTip = ((instanceCostTipView2 != null) ? instanceCostTipView2.GetLayoutItemByKey("rougeScore", 0) : null) as InstanceDungeonCostTip;
			if (instanceDungeonCostTip == null)
			{
				return;
			}
			instanceDungeonCostTip.SetIconVisible(false);
			instanceDungeonCostTip.SetStarVisible(false);
			instanceDungeonCostTip.SetRightText("");
			instanceDungeonCostTip.SetLeftText(ConfigMultiTextLang.GetLocalTextNew("Rogue_Function_End_Tip", null) ?? "");
			instanceDungeonCostTip.SetHelpButtonVisible(false);
		}

		// Token: 0x060304D7 RID: 197847 RVA: 0x00B34F88 File Offset: 0x00B33188
		private void RefreshTimeItem()
		{
			ActivityRogueController instance = ActivityRogueController.Instance;
			bool flag;
			if (instance == null)
			{
				flag = (null != null);
			}
			else
			{
				ActivityRogueData currentActivityData = instance.GetCurrentActivityData();
				flag = (((currentActivityData != null) ? currentActivityData.SeasonData : null) != null);
			}
			if (!flag)
			{
				return;
			}
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			InstanceDungeonCostTip instanceDungeonCostTip = ((instanceCostTipView != null) ? instanceCostTipView.GetLayoutItemByKey("rogueTime", 0) : null) as InstanceDungeonCostTip;
			if (instanceDungeonCostTip == null)
			{
				GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView2 = this.InstanceCostTipView;
				if (instanceCostTipView2 != null)
				{
					instanceCostTipView2.AddItemToLayout(new object[]
					{
						"rogueTime"
					}, 0);
				}
				GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView3 = this.InstanceCostTipView;
				instanceDungeonCostTip = (((instanceCostTipView3 != null) ? instanceCostTipView3.GetLayoutItemByKey("rogueTime", 0) : null) as InstanceDungeonCostTip);
			}
			if (instanceDungeonCostTip == null)
			{
				return;
			}
			instanceDungeonCostTip.SetIconVisible(false);
			instanceDungeonCostTip.SetStarVisible(false);
			string remainTime = this.GetRemainTime();
			instanceDungeonCostTip.SetRightText(remainTime);
			string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_Rogue_Time", null) ?? "", new string[]
			{
				""
			});
			instanceDungeonCostTip.SetLeftText(leftText);
			instanceDungeonCostTip.SetHelpButtonVisible(false);
		}

		// Token: 0x060304D8 RID: 197848 RVA: 0x00B3506C File Offset: 0x00B3326C
		private unsafe void RefreshDifficultyItem()
		{
			ActivityRogueController instance = ActivityRogueController.Instance;
			RogueSeasonData rogueSeasonData;
			if (instance == null)
			{
				rogueSeasonData = null;
			}
			else
			{
				ActivityRogueData currentActivityData = instance.GetCurrentActivityData();
				rogueSeasonData = ((currentActivityData != null) ? currentActivityData.SeasonData : null);
			}
			RogueSeasonData rogueSeasonData2 = rogueSeasonData;
			if (rogueSeasonData2 == null)
			{
				return;
			}
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.AddItemToLayout(new object[]
				{
					"rogueDifficultyProgress"
				}, 0);
			}
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView2 = this.InstanceCostTipView;
			InstanceDungeonCostTip instanceDungeonCostTip = ((instanceCostTipView2 != null) ? instanceCostTipView2.GetLayoutItemByKey("rogueDifficultyProgress", 0) : null) as InstanceDungeonCostTip;
			if (instanceDungeonCostTip == null)
			{
				return;
			}
			instanceDungeonCostTip.SetIconVisible(false);
			instanceDungeonCostTip.SetStarVisible(false);
			RoguelikeConfig instance2 = RoguelikeConfig.Instance;
			RogueSeason? rogueSeason = (instance2 != null) ? instance2.GetRogueSeasonConfigById(rogueSeasonData2.SeasonId) : null;
			InstanceDungeonEntranceConfig instance3 = InstanceDungeonEntranceConfig.Instance;
			InstanceDungeonEntrance? instanceDungeonEntrance = (instance3 != null) ? instance3.GetConfig((rogueSeason != null) ? rogueSeason.GetValueOrDefault().InstanceDungeonEntrance : 0) : null;
			if (instanceDungeonEntrance != null && instanceDungeonEntrance.GetValueOrDefault().InstanceDungeonListLength <= 0)
			{
				return;
			}
			int num = 0;
			Span<int> instanceDungeonListBytes = instanceDungeonEntrance.Value.GetInstanceDungeonListBytes();
			for (int i = 0; i < instanceDungeonListBytes.Length; i++)
			{
				int num2 = *instanceDungeonListBytes[i];
				if (!ExchangeRewardModel.Instance.IsFinishInstance(num2))
				{
					num = num2;
					break;
				}
			}
			if (num == 0 && instanceDungeonEntrance.Value.InstanceDungeonListLength > 0)
			{
				num = instanceDungeonEntrance.Value.InstanceDungeonList(instanceDungeonEntrance.Value.InstanceDungeonListLength - 1);
			}
			InstanceDungeonConfig instance4 = InstanceDungeonConfig.Instance;
			InstanceDungeon? instanceDungeon = (instance4 != null) ? instance4.GetConfig(num) : null;
			instanceDungeonCostTip.SetRightText(ConfigMultiTextLang.GetLocalTextNew(((instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().DifficultyDesc(0) : null) ?? "", null) ?? "");
			string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_Rogue_Difficulty_Process", null) ?? "", new string[]
			{
				""
			});
			instanceDungeonCostTip.SetLeftText(leftText);
			instanceDungeonCostTip.SetHelpButtonVisible(false);
		}

		// Token: 0x060304D9 RID: 197849 RVA: 0x00B35280 File Offset: 0x00B33480
		private void RefreshAchievementItem()
		{
			ActivityRogueController instance = ActivityRogueController.Instance;
			RogueSeasonData rogueSeasonData;
			if (instance == null)
			{
				rogueSeasonData = null;
			}
			else
			{
				ActivityRogueData currentActivityData = instance.GetCurrentActivityData();
				rogueSeasonData = ((currentActivityData != null) ? currentActivityData.SeasonData : null);
			}
			RogueSeasonData rogueSeasonData2 = rogueSeasonData;
			if (rogueSeasonData2 == null)
			{
				return;
			}
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.AddItemToLayout(new object[]
				{
					"rogueAchievementProgress"
				}, 0);
			}
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView2 = this.InstanceCostTipView;
			InstanceDungeonCostTip instanceDungeonCostTip = ((instanceCostTipView2 != null) ? instanceCostTipView2.GetLayoutItemByKey("rogueAchievementProgress", 0) : null) as InstanceDungeonCostTip;
			if (instanceDungeonCostTip == null)
			{
				return;
			}
			instanceDungeonCostTip.SetIconVisible(false);
			instanceDungeonCostTip.SetStarVisible(false);
			RoguelikeConfig instance2 = RoguelikeConfig.Instance;
			RogueSeason? rogueSeason = (instance2 != null) ? instance2.GetRogueSeasonConfigById(rogueSeasonData2.SeasonId) : null;
			if (rogueSeason == null)
			{
				return;
			}
			AchievementModel instance3 = AchievementModel.Instance;
			List<AchievementGroupData> list = (instance3 != null) ? instance3.GetAchievementCategoryGroups(rogueSeason.Value.Achievement, true) : null;
			int num = 0;
			int num2 = 0;
			if (list != null)
			{
				foreach (AchievementGroupData achievementGroupData in list)
				{
					AchievementModel instance4 = AchievementModel.Instance;
					AchievementGroupData achievementGroupData2 = (instance4 != null) ? instance4.GetAchievementGroupData(new int?(achievementGroupData.GetId())) : null;
					if (achievementGroupData2 != null)
					{
						num += achievementGroupData2.GetCurrentProgress();
						num2 += achievementGroupData2.GetMaxProgress();
					}
				}
			}
			string rightText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_Rogue_Score", null) ?? "{0}/{1}", new string[]
			{
				num.ToString(),
				num2.ToString()
			});
			instanceDungeonCostTip.SetRightText(rightText);
			string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_Rogue_Achievement_Count", null) ?? "", new string[]
			{
				""
			});
			instanceDungeonCostTip.SetLeftText(leftText);
			instanceDungeonCostTip.SetHelpButtonVisible(false);
		}

		// Token: 0x060304DA RID: 197850 RVA: 0x00B35444 File Offset: 0x00B33644
		private void RefreshShopProgressItem()
		{
			ActivityRogueController instance = ActivityRogueController.Instance;
			RogueSeasonData rogueSeasonData;
			if (instance == null)
			{
				rogueSeasonData = null;
			}
			else
			{
				ActivityRogueData currentActivityData = instance.GetCurrentActivityData();
				rogueSeasonData = ((currentActivityData != null) ? currentActivityData.SeasonData : null);
			}
			RogueSeasonData rogueSeasonData2 = rogueSeasonData;
			if (rogueSeasonData2 == null)
			{
				return;
			}
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.AddItemToLayout(new object[]
				{
					"rougeScore"
				}, 0);
			}
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView2 = this.InstanceCostTipView;
			InstanceDungeonCostTip instanceDungeonCostTip = ((instanceCostTipView2 != null) ? instanceCostTipView2.GetLayoutItemByKey("rougeScore", 0) : null) as InstanceDungeonCostTip;
			if (instanceDungeonCostTip == null)
			{
				return;
			}
			instanceDungeonCostTip.SetIconVisible(false);
			instanceDungeonCostTip.SetStarVisible(false);
			RoguelikeModel instance2 = RoguelikeModel.Instance;
			RogueParam? rogueParam;
			int valueOrDefault = ((instance2 != null) ? ((instance2.GetParamConfigBySeasonId(null) != null) ? new int?(rogueParam.GetValueOrDefault().WeekTokenMaxCount) : null) : null).GetValueOrDefault(1);
			string rightText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_Rogue_Score", null) ?? "{0}/{1}", new string[]
			{
				rogueSeasonData2.TokenItemCount.ToString(),
				valueOrDefault.ToString()
			});
			instanceDungeonCostTip.SetRightText(rightText);
			string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_Rogue_Week_Score", null) ?? "", new string[]
			{
				""
			});
			instanceDungeonCostTip.SetLeftText(leftText);
			instanceDungeonCostTip.SetHelpButtonVisible(false);
		}

		// Token: 0x060304DB RID: 197851 RVA: 0x00B35599 File Offset: 0x00B33799
		protected override void OnCloseWorldMapSecondaryUi()
		{
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView == null)
			{
				return;
			}
			instanceCostTipView.ClearChildren();
		}

		// Token: 0x060304DC RID: 197852 RVA: 0x00B355AB File Offset: 0x00B337AB
		public override UUIItem GetGuideFocusUiItem()
		{
			return base.GetButton(11).GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
		}

		// Token: 0x060304DD RID: 197853 RVA: 0x00B355D0 File Offset: 0x00B337D0
		protected string GetRemainTime()
		{
			ActivityRogueController instance = ActivityRogueController.Instance;
			ActivityRogueData activityRogueData = (instance != null) ? instance.GetCurrentActivityData() : null;
			if (activityRogueData == null)
			{
				return "";
			}
			bool flag = activityRogueData.CheckIfInShowTime();
			bool flag2 = activityRogueData.CheckIfInOpenTime();
			if (!flag2 && !flag)
			{
				TextConfig instance2 = TextConfig.Instance;
				return ((instance2 != null) ? instance2.GetTextContentIdById("ActiveClose") : null) ?? "";
			}
			long endOpenTime = activityRogueData.EndOpenTime;
			long endShowTime = activityRogueData.EndShowTime;
			long num;
			if (activityRogueData.EndOpenTime == 0L)
			{
				num = endShowTime;
			}
			else
			{
				num = (flag2 ? endOpenTime : endShowTime);
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			double num2 = Math.Max((double)num - serverTime, 1.0);
			CommonDefine.ETimeType[] timeTypeData = this.GetTimeTypeData(num2);
			return TimeUtil.Instance.GetCountDownDataFormat2(num2, new CommonDefine.ETimeType?(timeTypeData[0]), new CommonDefine.ETimeType?(timeTypeData[1])).CountDownText ?? "";
		}

		// Token: 0x060304DE RID: 197854 RVA: 0x00B356B0 File Offset: 0x00B338B0
		private CommonDefine.ETimeType[] GetTimeTypeData(double remainTime)
		{
			if (remainTime > 86400.0)
			{
				return new CommonDefine.ETimeType[]
				{
					CommonDefine.ETimeType.Day,
					CommonDefine.ETimeType.Hour
				};
			}
			if (remainTime > 3600.0)
			{
				return new CommonDefine.ETimeType[]
				{
					CommonDefine.ETimeType.Hour,
					CommonDefine.ETimeType.Minute
				};
			}
			if (remainTime > 60.0)
			{
				CommonDefine.ETimeType[] array = new CommonDefine.ETimeType[2];
				array[0] = CommonDefine.ETimeType.Minute;
				return array;
			}
			return new CommonDefine.ETimeType[2];
		}

		// Token: 0x04019FDE RID: 106462
		private const string ROGUE_SCORE_KEY = "rougeScore";

		// Token: 0x04019FDF RID: 106463
		private const string ROGUE_TIME = "rogueTime";

		// Token: 0x04019FE0 RID: 106464
		private const string ROGUE_ACHIEVEMENT_PROGRESS = "rogueAchievementProgress";

		// Token: 0x04019FE1 RID: 106465
		private const string ROGUE_DIFFICULTY_PROGRESS = "rogueDifficultyProgress";

		// Token: 0x04019FE2 RID: 106466
		private int EntranceId;

		// Token: 0x04019FE3 RID: 106467
		[Nullable(2)]
		private TeleportMarkItem SelectedMarkItem;

		// Token: 0x04019FE4 RID: 106468
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutAdd<InstanceDungeonCostTip> InstanceCostTipView;

		// Token: 0x04019FE5 RID: 106469
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x04019FE6 RID: 106470
		[Nullable(2)]
		protected RewardItemBar RewardsView;

		// Token: 0x0200AADD RID: 43741
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033F56 RID: 212822
			public const int RoguelikePanel = 0;
		}
	}
}
