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
	// Token: 0x020042F7 RID: 17143
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResMapEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x170056E5 RID: 22245
		// (get) Token: 0x0602B5DE RID: 177630 RVA: 0x00C2FD64 File Offset: 0x00C2DF64
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

		// Token: 0x0602B5DF RID: 177631 RVA: 0x00C2FDBE File Offset: 0x00C2DFBE
		public override string GetResourceId()
		{
			return "UiView_InstanceEntranceTip_Prefab";
		}

		// Token: 0x0602B5E0 RID: 177632 RVA: 0x00C2FDC5 File Offset: 0x00C2DFC5
		[NullableContext(2)]
		public override UUIItem GetGuideFocusUiItem()
		{
			return base.GetButton(11).GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
		}

		// Token: 0x0602B5E1 RID: 177633 RVA: 0x00C2FDE8 File Offset: 0x00C2DFE8
		protected override UniTask OnBeforeStartAsync()
		{
			RogueResMapEntrancePanel.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueResMapEntrancePanel.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B5E2 RID: 177634 RVA: 0x00C2FE2C File Offset: 0x00C2E02C
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

		// Token: 0x0602B5E3 RID: 177635 RVA: 0x00C2FE7D File Offset: 0x00C2E07D
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			base.GetItem(32).SetUIActive(false);
		}

		// Token: 0x0602B5E4 RID: 177636 RVA: 0x00C2FE93 File Offset: 0x00C2E093
		protected override void OnBeforeDestroy()
		{
			this.InstanceCostTipView.ClearChildren();
			if (this.TimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0602B5E5 RID: 177637 RVA: 0x00C2FEC0 File Offset: 0x00C2E0C0
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

		// Token: 0x0602B5E6 RID: 177638 RVA: 0x00C2FEF4 File Offset: 0x00C2E0F4
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

		// Token: 0x0602B5E7 RID: 177639 RVA: 0x00C3000E File Offset: 0x00C2E20E
		protected override void OnCloseWorldMapSecondaryUi()
		{
			GenericLayoutAdd<InstanceDungeonCostTip> instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView == null)
			{
				return;
			}
			instanceCostTipView.ClearChildren();
		}

		// Token: 0x0602B5E8 RID: 177640 RVA: 0x00C30020 File Offset: 0x00C2E220
		protected string GetRemainTime()
		{
			long endTime = MathUtils.Instance.LongToNumber(ActivityPermanentRogueModel.Instance.GetTaskEndTime());
			return ActivityModel.Instance.GetRemainTimeText(endTime, this.RemainTimeText) ?? "";
		}

		// Token: 0x0602B5E9 RID: 177641 RVA: 0x00C3005C File Offset: 0x00C2E25C
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

		// Token: 0x0602B5EA RID: 177642 RVA: 0x00C3012C File Offset: 0x00C2E32C
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

		// Token: 0x0602B5EB RID: 177643 RVA: 0x00C301C4 File Offset: 0x00C2E3C4
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

		// Token: 0x0602B5EC RID: 177644 RVA: 0x00C30240 File Offset: 0x00C2E440
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

		// Token: 0x0602B5ED RID: 177645 RVA: 0x00C302FC File Offset: 0x00C2E4FC
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

		// Token: 0x0602B5EE RID: 177646 RVA: 0x00C303E4 File Offset: 0x00C2E5E4
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

		// Token: 0x0602B5EF RID: 177647 RVA: 0x00C304D0 File Offset: 0x00C2E6D0
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

		// Token: 0x0401769B RID: 95899
		[Nullable(2)]
		protected RewardItemBar RewardsView;

		// Token: 0x0401769C RID: 95900
		private int EntranceId;

		// Token: 0x0401769D RID: 95901
		[Nullable(2)]
		private TeleportMarkItem SelectedMarkItem;

		// Token: 0x0401769E RID: 95902
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutAdd<InstanceDungeonCostTip> InstanceCostTipView;

		// Token: 0x0401769F RID: 95903
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x040176A0 RID: 95904
		private readonly string RemainTimeText = "{0}";

		// Token: 0x040176A1 RID: 95905
		private const string ROGUE_SCORE_KEY = "rougeScore";

		// Token: 0x040176A2 RID: 95906
		private const string ROGUE_TASK = "rougeTask";

		// Token: 0x040176A3 RID: 95907
		private const string ROGUE_PROGRESS = "rougeProgress";

		// Token: 0x040176A4 RID: 95908
		private const string ROGUE_TIME = "rogueTime";
	}
}
