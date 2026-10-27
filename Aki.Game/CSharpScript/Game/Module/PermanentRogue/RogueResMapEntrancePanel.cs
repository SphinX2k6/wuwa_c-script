using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.SubViews;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005327 RID: 21287
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResMapEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x17008325 RID: 33573
		// (get) Token: 0x060366E2 RID: 222946 RVA: 0x00CE2394 File Offset: 0x00CE0594
		private InstanceDungeonEntrance? EntranceConfig
		{
			get
			{
				int? num = (this.EntranceId != 0) ? new int?(InstanceDungeonEntranceConfig.Instance.GetEntranceIdByMarkId(this.EntranceId)) : null;
				if (num == null)
				{
					return null;
				}
				return InstanceDungeonEntranceConfig.Instance.GetConfig(num.Value);
			}
		}

		// Token: 0x060366E3 RID: 222947 RVA: 0x00CE23EE File Offset: 0x00CE05EE
		public override string GetResourceId()
		{
			return "UiView_InstanceEntranceTip_Prefab";
		}

		// Token: 0x060366E4 RID: 222948 RVA: 0x00CE23F5 File Offset: 0x00CE05F5
		[NullableContext(2)]
		public override UUIItem GetGuideFocusUiItem()
		{
			return base.GetButton(11).GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
		}

		// Token: 0x060366E5 RID: 222949 RVA: 0x00CE2418 File Offset: 0x00CE0618
		protected override UniTask OnBeforeStartAsync()
		{
			RogueResMapEntrancePanel.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueResMapEntrancePanel.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060366E6 RID: 222950 RVA: 0x00CE245C File Offset: 0x00CE065C
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

		// Token: 0x060366E7 RID: 222951 RVA: 0x00CE24AD File Offset: 0x00CE06AD
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			base.GetItem(32).SetUIActive(false);
		}

		// Token: 0x060366E8 RID: 222952 RVA: 0x00CE24C3 File Offset: 0x00CE06C3
		protected override void OnBeforeDestroy()
		{
			this.InstanceCostTipView.ClearChildren();
			if (this.TimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x060366E9 RID: 222953 RVA: 0x00CE24F0 File Offset: 0x00CE06F0
		protected ILayoutItem<InstanceDungeonCostTip> OnInstanceRefresh(object data, UUIItem uiItem, int index, int originalItemIndex)
		{
			InstanceDungeonCostTip instanceDungeonCostTip = new InstanceDungeonCostTip();
			instanceDungeonCostTip.SetRootActor(uiItem.GetOwner(), true);
			return new LayoutItem<InstanceDungeonCostTip>
			{
				Key = data,
				Value = instanceDungeonCostTip
			};
		}

		// Token: 0x060366EA RID: 222954 RVA: 0x00CE2524 File Offset: 0x00CE0724
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
						ELogAuthor author = ELogAuthor.WHJ;
						string message = "副本入口弹窗打开错误，副本入口表中找不到对应的地图标记Id！";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", teleportMarkItem.MarkConfigId);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					this.InitView();
					this.UpdateInstanceList();
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					int unLockCondition = this.EntranceConfig.Value.UnLockCondition;
					if (unLockCondition != 0 && !FunctionModel.Instance.IsOpen(unLockCondition))
					{
						FunctionCondition? functionCondition = FunctionConfig.Instance.GetFunctionCondition(unLockCondition);
						ConditionGroup? conditionGroupConfig = ConditionConfig.Instance.GetConditionGroupConfig(functionCondition.Value.OpenConditionId);
						LguiUtil.Instance.SetLocalTextNew(base.GetText(4), conditionGroupConfig.Value.HintText, Array.Empty<object>());
					}
				}
			}
		}

		// Token: 0x060366EB RID: 222955 RVA: 0x00CE263E File Offset: 0x00CE083E
		protected override void OnCloseWorldMapSecondaryUi()
		{
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView == null)
			{
				return;
			}
			instanceCostTipView.ClearChildren();
		}

		// Token: 0x060366EC RID: 222956 RVA: 0x00CE2650 File Offset: 0x00CE0850
		protected string GetRemainTime()
		{
			long endTime = MathUtils.Instance.LongToNumber(ActivityPermanentRogueModel.Instance.GetTaskEndTime());
			return ActivityModel.Instance.GetRemainTimeText(endTime, this.RemainTimeText) ?? "";
		}

		// Token: 0x060366ED RID: 222957 RVA: 0x00CE268C File Offset: 0x00CE088C
		private void InitView()
		{
			InstanceDungeonEntrance? entranceConfig = this.EntranceConfig;
			if (entranceConfig == null)
			{
				return;
			}
			base.GetText(4).ShowTextNew(entranceConfig.Value.Description);
			WorldMapSecondaryUiLayoutHelper.UpdateIcon(this.LayoutContext);
			base.GetText(1).ShowTextNew(entranceConfig.Value.Name);
			WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
			base.GetItem(9).SetUIActive(!this.SelectedMarkItem.IsFogUnlock);
			base.GetText(10).ShowTextNew("Instance_Dungeon_Rcommand_Text");
			LguiUtil.Instance.SetLocalTextNew(base.GetText(36), "Instance_RogueInstanceEntrance_Progress", Array.Empty<object>());
			bool flag = base.UpdateQuickGoto();
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext == null)
			{
				return;
			}
			layoutContext.SetConfirmBtnActive(!flag);
		}

		// Token: 0x060366EE RID: 222958 RVA: 0x00CE275C File Offset: 0x00CE095C
		private void RefreshReward()
		{
			List<TItem> previewReward = ActivityPermanentRogueModel.Instance.GetActivityData().GetPreviewReward(null);
			if (previewReward.Count == 0)
			{
				base.GetItem(8).SetUIActive(false);
				return;
			}
			List<TItem> list = (previewReward.Count > 5) ? previewReward.GetRange(0, 5) : previewReward;
			for (int i = 0; i < list.Count; i++)
			{
				TItem value = list[i];
				value.Count = 0;
				list[i] = value;
			}
			base.GetItem(8).SetUIActive(true);
			this.RewardsView.RebuildRewardsByData(list);
		}

		// Token: 0x060366EF RID: 222959 RVA: 0x00CE27F4 File Offset: 0x00CE09F4
		private void UpdateInstanceList()
		{
			this.RefreshReward();
			if (!ActivityPermanentRogueModel.Instance.GetTaskIsEnd())
			{
				this.RefreshTimeItem();
				this.RefreshTaskItem();
				if (this.TimerId != null)
				{
					TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
				}
				this.TimerId = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
				{
					this.RefreshTimeItem();
				}, 1000f, 1f, null, null, true);
			}
			this.RefreshInstItem();
			this.RefreshShopProgressItem();
		}

		// Token: 0x060366F0 RID: 222960 RVA: 0x00CE2870 File Offset: 0x00CE0A70
		private void RefreshTimeItem()
		{
			if (ActivityPermanentRogueModel.Instance.GetActivityData() != null)
			{
				InstanceDungeonCostTip instanceDungeonCostTip = this.InstanceCostTipView.GetLayoutItemByKey("rogueTime", 0) as InstanceDungeonCostTip;
				if (instanceDungeonCostTip == null)
				{
					this.InstanceCostTipView.AddItemToLayout(new object[]
					{
						"rogueTime"
					}, 0);
					instanceDungeonCostTip = (this.InstanceCostTipView.GetLayoutItemByKey("rogueTime", 0) as InstanceDungeonCostTip);
				}
				instanceDungeonCostTip.SetIconVisible(false);
				instanceDungeonCostTip.SetStarVisible(false);
				string remainTime = this.GetRemainTime();
				instanceDungeonCostTip.SetRightText(remainTime);
				string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("RogueRes_MapNote_4", null) ?? "", new string[]
				{
					""
				});
				instanceDungeonCostTip.SetLeftText(leftText);
				instanceDungeonCostTip.SetHelpButtonVisible(false);
			}
		}

		// Token: 0x060366F1 RID: 222961 RVA: 0x00CE292C File Offset: 0x00CE0B2C
		private void RefreshInstItem()
		{
			if (ActivityPermanentRogueModel.Instance.GetActivityData() != null)
			{
				InstanceDungeonCostTip instanceDungeonCostTip = this.InstanceCostTipView.GetLayoutItemByKey("rougeProgress", 0) as InstanceDungeonCostTip;
				if (instanceDungeonCostTip == null)
				{
					this.InstanceCostTipView.AddItemToLayout(new object[]
					{
						"rougeProgress"
					}, 0);
					instanceDungeonCostTip = (this.InstanceCostTipView.GetLayoutItemByKey("rougeProgress", 0) as InstanceDungeonCostTip);
				}
				instanceDungeonCostTip.SetIconVisible(false);
				instanceDungeonCostTip.SetStarVisible(false);
				int newSeasonId = ActivityPermanentRogueModel.Instance.GetNewSeasonId();
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(ConfigRogueResDungeonConfigById.GetConfig(ActivityPermanentRogueModel.Instance.GetLatestDungeon(newSeasonId), true).Value.Title, null);
				instanceDungeonCostTip.SetRightText(localTextNew);
				string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("RogueRes_MapNote_1", null) ?? "", new string[]
				{
					""
				});
				instanceDungeonCostTip.SetLeftText(leftText);
				instanceDungeonCostTip.SetHelpButtonVisible(false);
			}
		}

		// Token: 0x060366F2 RID: 222962 RVA: 0x00CE2A14 File Offset: 0x00CE0C14
		private void RefreshTaskItem()
		{
			if (ActivityPermanentRogueModel.Instance.GetActivityData() != null)
			{
				InstanceDungeonCostTip instanceDungeonCostTip = this.InstanceCostTipView.GetLayoutItemByKey("rougeTask", 0) as InstanceDungeonCostTip;
				if (instanceDungeonCostTip == null)
				{
					this.InstanceCostTipView.AddItemToLayout(new object[]
					{
						"rougeTask"
					}, 0);
					instanceDungeonCostTip = (this.InstanceCostTipView.GetLayoutItemByKey("rougeTask", 0) as InstanceDungeonCostTip);
				}
				instanceDungeonCostTip.SetIconVisible(false);
				instanceDungeonCostTip.SetStarVisible(false);
				int[] taskCount = ActivityPermanentRogueModel.Instance.GetTaskCount();
				InstanceDungeonCostTip instanceDungeonCostTip2 = instanceDungeonCostTip;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(taskCount[0]);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(taskCount[1]);
				instanceDungeonCostTip2.SetRightText(defaultInterpolatedStringHandler.ToStringAndClear());
				string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("RogueRes_MapNote_2", null) ?? "", new string[]
				{
					""
				});
				instanceDungeonCostTip.SetLeftText(leftText);
				instanceDungeonCostTip.SetHelpButtonVisible(false);
			}
		}

		// Token: 0x060366F3 RID: 222963 RVA: 0x00CE2B00 File Offset: 0x00CE0D00
		private void RefreshShopProgressItem()
		{
			if (ActivityPermanentRogueModel.Instance.GetActivityData() != null)
			{
				this.InstanceCostTipView.AddItemToLayout(new object[]
				{
					"rougeScore"
				}, 0);
				InstanceDungeonCostTip instanceDungeonCostTip = this.InstanceCostTipView.GetLayoutItemByKey("rougeScore", 0) as InstanceDungeonCostTip;
				instanceDungeonCostTip.SetIconVisible(false);
				instanceDungeonCostTip.SetStarVisible(false);
				int newSeasonId = ActivityPermanentRogueModel.Instance.GetNewSeasonId();
				int[] shopCount = ActivityPermanentRogueModel.Instance.GetShopCount(newSeasonId);
				string inString = ConfigMultiTextLang.GetLocalTextNew("Text_Weekly_Rogue_Score", null) ?? "{0}";
				string[] array = new string[1];
				int num = 0;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(shopCount[0]);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(shopCount[1]);
				array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
				string rightText = StringUtils.Format(inString, array);
				instanceDungeonCostTip.SetRightText(rightText);
				string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("RogueRes_MapNote_3", null) ?? "", new string[]
				{
					""
				});
				instanceDungeonCostTip.SetLeftText(leftText);
				instanceDungeonCostTip.SetHelpButtonVisible(false);
			}
		}

		// Token: 0x0401CC65 RID: 117861
		[Nullable(2)]
		protected RewardItemBar RewardsView;

		// Token: 0x0401CC66 RID: 117862
		private int EntranceId;

		// Token: 0x0401CC67 RID: 117863
		[Nullable(2)]
		private TeleportMarkItem SelectedMarkItem;

		// Token: 0x0401CC68 RID: 117864
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutAdd<InstanceDungeonCostTip> InstanceCostTipView;

		// Token: 0x0401CC69 RID: 117865
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x0401CC6A RID: 117866
		private readonly string RemainTimeText = "{0}";

		// Token: 0x0401CC6B RID: 117867
		private const string ROGUE_SCORE_KEY = "rougeScore";

		// Token: 0x0401CC6C RID: 117868
		private const string ROGUE_TASK = "rougeTask";

		// Token: 0x0401CC6D RID: 117869
		private const string ROGUE_PROGRESS = "rougeProgress";

		// Token: 0x0401CC6E RID: 117870
		private const string ROGUE_TIME = "rogueTime";
	}
}
