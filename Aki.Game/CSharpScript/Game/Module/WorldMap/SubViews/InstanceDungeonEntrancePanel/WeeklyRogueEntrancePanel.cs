using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.InstanceDungeonEntrancePanel
{
	// Token: 0x02003745 RID: 14149
	[NullableContext(1)]
	[Nullable(0)]
	public class WeeklyRogueEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x17004BA5 RID: 19365
		// (get) Token: 0x06024CD1 RID: 150737 RVA: 0x00A65F3C File Offset: 0x00A6413C
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

		// Token: 0x06024CD2 RID: 150738 RVA: 0x00A65F79 File Offset: 0x00A64179
		public override string GetResourceId()
		{
			return "UiView_InstanceEntranceTip_Prefab";
		}

		// Token: 0x06024CD3 RID: 150739 RVA: 0x00A65F80 File Offset: 0x00A64180
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
			return (UUIItem)obj;
		}

		// Token: 0x06024CD4 RID: 150740 RVA: 0x00A65FB4 File Offset: 0x00A641B4
		protected override UniTask OnBeforeStartAsync()
		{
			WeeklyRogueEntrancePanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueEntrancePanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024CD5 RID: 150741 RVA: 0x00A65FF8 File Offset: 0x00A641F8
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

		// Token: 0x06024CD6 RID: 150742 RVA: 0x00A66049 File Offset: 0x00A64249
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

		// Token: 0x06024CD7 RID: 150743 RVA: 0x00A66064 File Offset: 0x00A64264
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

		// Token: 0x06024CD8 RID: 150744 RVA: 0x00A66098 File Offset: 0x00A64298
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

		// Token: 0x06024CD9 RID: 150745 RVA: 0x00A660CC File Offset: 0x00A642CC
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				TeleportMarkItem teleportMarkItem = param[0] as TeleportMarkItem;
				if (teleportMarkItem != null)
				{
					this.SelectedMarkItem = teleportMarkItem;
					this.LayoutContext.MarkItem = teleportMarkItem;
					this.EntranceId = this.SelectedMarkItem.MarkConfigId;
					if (this.EntranceId == 0)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.InstanceDungeon;
						ELogAuthor author = ELogAuthor.LYX;
						string message = "副本入口弹窗打开错误，副本入口表中找不到对应的地图标记Id！";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", teleportMarkItem.MarkConfigId);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					this.InitView();
					this.UpdateInstanceList();
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					InstanceDungeonEntrance? instanceDungeonEntrance;
					int num = (this.EntranceConfig != null) ? instanceDungeonEntrance.GetValueOrDefault().UnLockCondition : 0;
					if (num != 0 && !FunctionModel.Instance.IsOpen(num))
					{
						FunctionConfig instance2 = FunctionConfig.Instance;
						FunctionCondition? functionCondition = (instance2 != null) ? instance2.GetFunctionCondition(num) : null;
						ConditionConfig instance3 = ConditionConfig.Instance;
						ConditionGroup? conditionGroup = (instance3 != null) ? instance3.GetConditionGroupConfig((functionCondition != null) ? functionCondition.GetValueOrDefault().OpenConditionId : 0) : null;
						LguiUtil.Instance.SetLocalTextNew(base.GetText(4), ((conditionGroup != null) ? conditionGroup.GetValueOrDefault().HintText : null) ?? "", Array.Empty<object>());
					}
				}
			}
		}

		// Token: 0x06024CDA RID: 150746 RVA: 0x00A66239 File Offset: 0x00A64439
		protected override void OnCloseWorldMapSecondaryUi()
		{
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView == null)
			{
				return;
			}
			instanceCostTipView.ClearChildren();
		}

		// Token: 0x06024CDB RID: 150747 RVA: 0x00A6624C File Offset: 0x00A6444C
		protected string GetRemainTime()
		{
			double cycleRemainTime = WeeklyRogueModel.Instance.ActivityData.GetCycleRemainTime();
			CommonDefine.ETimeType[] timeTypeData = this.GetTimeTypeData(cycleRemainTime);
			return TimeUtil.Instance.GetCountDownDataFormat2(cycleRemainTime, new CommonDefine.ETimeType?(timeTypeData[0]), new CommonDefine.ETimeType?(timeTypeData[1])).CountDownText ?? "";
		}

		// Token: 0x06024CDC RID: 150748 RVA: 0x00A6629C File Offset: 0x00A6449C
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

		// Token: 0x06024CDD RID: 150749 RVA: 0x00A6638C File Offset: 0x00A6458C
		private void RefreshReward()
		{
			List<TItem> previewReward = WeeklyRogueModel.Instance.ActivityData.GetPreviewReward(null);
			if (previewReward.Count == 0)
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
				int count = Math.Min(previewReward.Count, 5);
				List<TItem> range = previewReward.GetRange(0, count);
				for (int i = 0; i < range.Count; i++)
				{
					TItem value = range[i];
					value.Count = 0;
					range[i] = value;
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
				rewardsView.RebuildRewardsByData(range);
				return;
			}
		}

		// Token: 0x06024CDE RID: 150750 RVA: 0x00A66438 File Offset: 0x00A64638
		private void UpdateInstanceList()
		{
			this.RefreshReward();
			this.RefreshTimeItem();
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

		// Token: 0x06024CDF RID: 150751 RVA: 0x00A6649C File Offset: 0x00A6469C
		private void RefreshTimeItem()
		{
			if (WeeklyRogueModel.Instance.ActivityData != null)
			{
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
		}

		// Token: 0x06024CE0 RID: 150752 RVA: 0x00A6656C File Offset: 0x00A6476C
		private void RefreshShopProgressItem()
		{
			WeeklyRogueModel instance = WeeklyRogueModel.Instance;
			WeeklyRogueData weeklyRogueData = (instance != null) ? instance.ActivityData : null;
			if (weeklyRogueData != null)
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
				instanceDungeonCostTip.SetIconVisible(false);
				instanceDungeonCostTip.SetStarVisible(false);
				RogueWeeklyCycle? rogueWeeklyCycle;
				string rightText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("WeRogueMapScoreText", null) ?? "{0}", new string[]
				{
					((weeklyRogueData.GetCycleConfig() != null) ? rogueWeeklyCycle.GetValueOrDefault().BaseScore.ToString() : null) ?? "0"
				});
				instanceDungeonCostTip.SetRightText(rightText);
				string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_Weekly_Rogue_Week_Score", null) ?? "", new string[]
				{
					""
				});
				instanceDungeonCostTip.SetLeftText(leftText);
				instanceDungeonCostTip.SetHelpButtonVisible(false);
			}
		}

		// Token: 0x06024CE1 RID: 150753 RVA: 0x00A66674 File Offset: 0x00A64874
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

		// Token: 0x040146AA RID: 83626
		private const string ROGUE_SCORE_KEY = "rougeScore";

		// Token: 0x040146AB RID: 83627
		private const string ROGUE_TIME = "rogueTime";

		// Token: 0x040146AC RID: 83628
		[Nullable(2)]
		protected RewardItemBar RewardsView;

		// Token: 0x040146AD RID: 83629
		private int EntranceId;

		// Token: 0x040146AE RID: 83630
		[Nullable(2)]
		private TeleportMarkItem SelectedMarkItem;

		// Token: 0x040146AF RID: 83631
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutAdd<InstanceDungeonCostTip> InstanceCostTipView;

		// Token: 0x040146B0 RID: 83632
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x02009494 RID: 38036
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E6E8 RID: 190184
			public const int WeeklyRoguePanel = 0;
		}
	}
}
