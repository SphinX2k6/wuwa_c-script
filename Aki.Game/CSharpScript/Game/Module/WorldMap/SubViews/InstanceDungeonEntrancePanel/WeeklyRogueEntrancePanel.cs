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
	// Token: 0x02004814 RID: 18452
	[NullableContext(1)]
	[Nullable(0)]
	public class WeeklyRogueEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x170078E8 RID: 30952
		// (get) Token: 0x06030501 RID: 197889 RVA: 0x00B35FC8 File Offset: 0x00B341C8
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

		// Token: 0x06030502 RID: 197890 RVA: 0x00B36005 File Offset: 0x00B34205
		public override string GetResourceId()
		{
			return "UiView_InstanceEntranceTip_Prefab";
		}

		// Token: 0x06030503 RID: 197891 RVA: 0x00B3600C File Offset: 0x00B3420C
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

		// Token: 0x06030504 RID: 197892 RVA: 0x00B36040 File Offset: 0x00B34240
		protected override UniTask OnBeforeStartAsync()
		{
			WeeklyRogueEntrancePanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueEntrancePanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030505 RID: 197893 RVA: 0x00B36084 File Offset: 0x00B34284
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

		// Token: 0x06030506 RID: 197894 RVA: 0x00B360D5 File Offset: 0x00B342D5
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

		// Token: 0x06030507 RID: 197895 RVA: 0x00B360F0 File Offset: 0x00B342F0
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

		// Token: 0x06030508 RID: 197896 RVA: 0x00B36124 File Offset: 0x00B34324
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

		// Token: 0x06030509 RID: 197897 RVA: 0x00B36158 File Offset: 0x00B34358
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

		// Token: 0x0603050A RID: 197898 RVA: 0x00B362C5 File Offset: 0x00B344C5
		protected override void OnCloseWorldMapSecondaryUi()
		{
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView == null)
			{
				return;
			}
			instanceCostTipView.ClearChildren();
		}

		// Token: 0x0603050B RID: 197899 RVA: 0x00B362D8 File Offset: 0x00B344D8
		protected string GetRemainTime()
		{
			double cycleRemainTime = WeeklyRogueModel.Instance.ActivityData.GetCycleRemainTime();
			CommonDefine.ETimeType[] timeTypeData = this.GetTimeTypeData(cycleRemainTime);
			return TimeUtil.Instance.GetCountDownDataFormat2(cycleRemainTime, new CommonDefine.ETimeType?(timeTypeData[0]), new CommonDefine.ETimeType?(timeTypeData[1])).CountDownText ?? "";
		}

		// Token: 0x0603050C RID: 197900 RVA: 0x00B36328 File Offset: 0x00B34528
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

		// Token: 0x0603050D RID: 197901 RVA: 0x00B36418 File Offset: 0x00B34618
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

		// Token: 0x0603050E RID: 197902 RVA: 0x00B364C4 File Offset: 0x00B346C4
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

		// Token: 0x0603050F RID: 197903 RVA: 0x00B36528 File Offset: 0x00B34728
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

		// Token: 0x06030510 RID: 197904 RVA: 0x00B365F8 File Offset: 0x00B347F8
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

		// Token: 0x06030511 RID: 197905 RVA: 0x00B36700 File Offset: 0x00B34900
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

		// Token: 0x04019FF6 RID: 106486
		private const string ROGUE_SCORE_KEY = "rougeScore";

		// Token: 0x04019FF7 RID: 106487
		private const string ROGUE_TIME = "rogueTime";

		// Token: 0x04019FF8 RID: 106488
		[Nullable(2)]
		protected RewardItemBar RewardsView;

		// Token: 0x04019FF9 RID: 106489
		private int EntranceId;

		// Token: 0x04019FFA RID: 106490
		[Nullable(2)]
		private TeleportMarkItem SelectedMarkItem;

		// Token: 0x04019FFB RID: 106491
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutAdd<InstanceDungeonCostTip> InstanceCostTipView;

		// Token: 0x04019FFC RID: 106492
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x0200AAE3 RID: 43747
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033F65 RID: 212837
			public const int WeeklyRoguePanel = 0;
		}
	}
}
